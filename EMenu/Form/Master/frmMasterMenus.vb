Imports MySql.Data.MySqlClient

Public Class frmMasterMenus
    Private available, photo As String

    Sub autonumber()
        Call connectdb()
        cmd = New MySqlCommand("SELECT id_menu FROM menus WHERE id_menu IN(SELECT MAX(id_menu)FROM menus)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = 0 Then
            txtIdMenu.Text = "MN" + "001"
            Call closerd()
        End If
        If Not rd.HasRows Then
            txtIdMenu.Text = "MN" + "001"
            Call closerd()
        Else
            txtIdMenu.Text = Val(Microsoft.VisualBasic.Right(rd.Item("id_menu").ToString, 3)) + 1
            If Len(txtIdMenu.Text) = 1 Then
                txtIdMenu.Text = "MN" + "00" & txtIdMenu.Text & ""
            ElseIf Len(txtIdMenu.Text) = 2 Then
                txtIdMenu.Text = "MN" + "0" & txtIdMenu.Text & ""
            End If
            Call closerd()
        End If
    End Sub
    Sub filtergrid()
        Call connectdb()
        If cbSearch.SelectedIndex = 0 Then
            da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE (menu like '%" & txtSearch.Text & "%') AND (isActive='1')", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "menus")
            DGMenu.DataSource = ds.Tables("menus")
        Else
            da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE (category='" & cbSearch.Text & "') AND (menu like '%" & txtSearch.Text & "%') AND (isActive='1') ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "menus")
            DGMenu.DataSource = ds.Tables("menus")
        End If
    End Sub
    Sub showgrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE isActive='1' ORDER BY menus.id_menu ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "menus")
        DGMenu.DataSource = ds.Tables("menus")
    End Sub
    Sub sizegrid()
        DGMenu.Columns(0).Width = 90
        DGMenu.Columns(1).Width = 150
        DGMenu.Columns(2).Width = 300
        DGMenu.Columns(3).Width = 100
        DGMenu.Columns(4).Width = 610
        DGMenu.Columns(0).Resizable = DataGridViewTriState.False
        DGMenu.Columns(1).Resizable = DataGridViewTriState.False
        DGMenu.Columns(2).Resizable = DataGridViewTriState.False
        DGMenu.Columns(3).Resizable = DataGridViewTriState.False
        DGMenu.Columns(4).Resizable = DataGridViewTriState.False
        DGMenu.Columns(0).HeaderText = "ID Menu"
        DGMenu.Columns(1).HeaderText = "Category"
        DGMenu.Columns(2).HeaderText = "Menu Names"
        DGMenu.Columns(3).HeaderText = "Price"
        DGMenu.Columns(4).HeaderText = "Description"
    End Sub
    Sub countgrid()
        Dim rs As Integer
        rs = DGMenu.RowCount
        lblSearch.Text = rs
    End Sub
    Sub fillcategory()
        Call connectdb()
        Dim str As String
        str = "SELECT category FROM categories WHERE isActive='1' ORDER BY category ASC"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cbCategory.Items.Add(rd("category"))
            Loop
        Else
        End If
        closerd()
    End Sub
    Sub fillcategorysearch()
        Call connectdb()
        Dim str As String
        str = "SELECT category FROM categories WHERE isActive='1' ORDER BY category ASC"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            cbSearch.Items.Add("All")
            Do While rd.Read
                cbSearch.Items.Add(rd("category"))
            Loop
        Else
        End If
        closerd()
    End Sub
    Sub savemenu()
        Call connectdb()
        Try
            If cbCategory.Text = "" Or txtMenu.Text = "" Or txtPrice.Text = "0" Or txtPrice.Text = "" Then
                MsgBoxError("Fill data")
                cbCategory.Focus()
            Else
                Dim str, path As String
                photo = ""
                If txtPhoto.Text = "" Then
                    photo = ""
                ElseIf txtPhoto.Text <> "" Then
                    photo = txtIdMenu.Text & ".jpg"
                    path = My.Settings.Photo
                    FileCopy("" & txtPhoto.Text & "", "" & path & "" & photo & " ")
                End If

                If (cbStatusMenu.Checked) Then
                    available = "0"
                Else
                    available = "1"
                End If

                str = "INSERT INTO menus VALUES ('" & txtIdMenu.Text & "', '" & cbCategory.Text & "', '" & txtMenu.Text & "', '" & txtPrice.Text & "', '" & txtDescription.Text & "', '" & photo & "', '" & available & "', '1', '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP, '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP)"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                closecmd()
                MsgBoxInformation("Data menu has been saved")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data menu hasn't been saved")
            Call atstart()
        End Try
    End Sub
    Sub updatemenu()
        Call connectdb()
        Try
            If txtIdMenu.Text = "" Or cbCategory.Text = "" Or txtMenu.Text = "" Or txtPrice.Text = "0" Or txtPrice.Text = "" Then
                MsgBoxError("Fill data")
                txtMenu.Focus()
            Else
                Dim str, path As String
                photo = ""
                path = My.Settings.Photo
                If txtPhoto.Text = "" Then
                    photo = ""
                    If System.IO.File.Exists("" & path & "" & txtIdMenu.Text & ".jpg") Then
                        My.Computer.FileSystem.DeleteFile("" & path & "" & txtIdMenu.Text & ".jpg")
                    End If
                ElseIf txtPhoto.Text <> "" Then
                    photo = txtIdMenu.Text & ".jpg"
                    If txtPhoto.Text <> "" & path & "" & photo & "" Then
                        FileCopy("" & txtPhoto.Text & "", "" & path & "" & photo & "")
                    End If
                End If

                If (cbStatusMenu.Checked) Then
                    available = "0"
                Else
                    available = "1"
                End If

                str = "UPDATE menus SET category='" & cbCategory.Text & "', menu='" & txtMenu.Text & "', price='" & txtPrice.Text & "', status_menu='" & available & "', description='" & txtDescription.Text & "', photo='" & photo & "' WHERE id_menu='" & txtIdMenu.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                MsgBoxInformation("Data menu has been updated")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data menu hasn't been updated")
            Call atstart()
        End Try
    End Sub
    Sub deletemenu()
        Call connectdb()
        Try
            Dim str, path, photo As String
            path = My.Settings.Photo
            photo = txtIdMenu.Text & ".jpg"
            str = "DELETE FROM menus WHERE id_menu='" & txtIdMenu.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            If txtPhoto.Text <> "" Then
                My.Computer.FileSystem.DeleteFile("" & path & "" & txtIdMenu.Text & ".jpg")
            End If
            MsgBoxInformation("Data menu has been deleted")
            Call atstart()
        Catch ex As Exception
            str = "UPDATE menus SET isActive='0' WHERE id_menu='" & txtIdMenu.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data menu has been deleted")
            Call atstart()
        End Try
    End Sub
    Sub cleartext()
        txtIdMenu.Clear()
        cbCategory.SelectedIndex = -1
        txtMenu.Clear()
        txtPrice.Clear()
        cbStatusMenu.CheckValue = False
        txtDescription.Clear()
        txtPhoto.Clear()
    End Sub
    Sub disabletext()
        txtIdMenu.Enabled = False
        cbCategory.Enabled = False
        txtMenu.Enabled = False
        txtPrice.Enabled = False
        cbStatusMenu.Enabled = False
        txtDescription.Enabled = False
        btnChoosePhoto.Enabled = False
    End Sub
    Sub enabletext()
        txtIdMenu.Enabled = True
        cbCategory.Enabled = True
        txtMenu.Enabled = True
        txtPrice.Enabled = True
        cbStatusMenu.Enabled = True
        txtDescription.Enabled = True
        btnChoosePhoto.Enabled = True
    End Sub
    Sub atstart()
        btnAdd.Text = "&Add"
        btnEdit.Text = "&Edit"
        btnDelete.Text = "&Delete"
        btnBack.Text = "&Back"
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnBack.Enabled = True
        Call disabletext()
        cbStatusMenu.CheckValue = False
        txtSearch.Focus()
        Call showgrid()
        Call countgrid()
        Call cleartext()
    End Sub
    Sub clickadd()
        btnAdd.Text = "&Save"
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        Call enabletext()
        txtIdMenu.Enabled = False
        cbCategory.Focus()
        Call cleartext()
        Call autonumber()
    End Sub
    Sub clickedit()
        btnEdit.Text = "&Update"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtIdMenu.Enabled = True
        txtIdMenu.Focus()
        Call cleartext()
    End Sub
    Sub clickdelete()
        btnDelete.Text = "&Yes"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtIdMenu.Enabled = True
        txtIdMenu.Focus()
        Call cleartext()
    End Sub
    Private Sub frmMasterMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atstart()
        Call fillcategory()
        Call fillcategorysearch()
        cbSearch.SelectedIndex = 0
        Call sizegrid()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Call clickadd()
        ElseIf btnAdd.Text = "&Save" Then
            Call savemenu()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            frmMainMenu.Wallpaper.Visible = True
        ElseIf btnBack.Text = "&Cancel" Then
            Call atstart()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            Call clickedit()
        ElseIf btnEdit.Text = "&Update" Then
            Call updatemenu()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            Call clickdelete()
        ElseIf btnDelete.Text = "&Yes" And txtMenu.Text = "" Then
            MsgBoxWarning("Fill id menu")
            txtIdMenu.Focus()
        Else
            Call deletemenu()
        End If
    End Sub
    Private Sub btnChoosePhoto_Click(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Dim file = ChoosePhoto.ShowDialog
        If file = Windows.Forms.DialogResult.OK Then
            txtPhoto.Text = ChoosePhoto.FileName
        End If
    End Sub
    Private Sub txtPhoto_TextChanged(sender As Object, e As EventArgs) Handles txtPhoto.TextChanged
        PhotoMenu.ImageLocation = txtPhoto.Text
        PhotoMenu.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub txtIdMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMenu.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call connectdb()
            Dim str, path As String
            path = My.Settings.Photo
            str = "SELECT * FROM menus WHERE id_menu='" & txtIdMenu.Text & "' AND isActive='1'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                cbCategory.Text = rd.Item("category")
                txtMenu.Text = rd.Item("menu")
                txtPrice.Text = rd.Item("price")
                If rd.Item("status_menu") = "0" Then
                    cbStatusMenu.CheckValue = True
                Else
                    cbStatusMenu.CheckValue = False
                End If
                txtDescription.Text = rd.Item("description")
                If rd.Item("photo") = "" Then
                    photo = ""
                    txtPhoto.Text = ""
                ElseIf rd.Item("photo") <> "" Then
                    txtPhoto.Text = path + rd.Item("photo")
                End If
                closerd()
                If btnEdit.Text = "&Update" Then
                    Call enabletext()
                    btnEdit.Enabled = True
                    txtIdMenu.Enabled = False
                ElseIf btnDelete.Text = "&Yes" Then
                    Call disabletext()
                    btnDelete.Enabled = True
                End If
            Else
                MsgBoxWarning("Data Menu doesn't exist")
                txtIdMenu.Focus()
                closerd()
            End If
        End If
    End Sub
    Private Sub PhotoMenu_Click(sender As Object, e As EventArgs) Handles PhotoMenu.Click
        If btnEdit.Text = "&Update" And txtMenu.Text <> "" Then
            txtPhoto.Text = ""
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call filtergrid()
        Call countgrid()
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub cbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged
        Call filtergrid()
        Call countgrid()
    End Sub
End Class