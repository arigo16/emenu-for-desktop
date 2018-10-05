Imports MySql.Data.MySqlClient

Public Class frmMasterCategories
    Private category As String

    Sub showgrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT category FROM categories WHERE isActive = '1' ORDER BY category ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "categories")
        DGCategory.DataSource = ds.Tables("categories")
        Call closecmd()
        Call countcategory()
    End Sub
    Sub sizegrid()
        DGCategory.Columns(0).Width = 270
        DGCategory.Columns(0).Resizable = DataGridViewTriState.False
        DGCategory.Columns(0).HeaderText = "Category Name"
    End Sub
    Sub countcategory()
        Dim rs As Integer
        rs = DGCategory.RowCount
        lblTotalCategory.Text = rs
    End Sub
    Sub savecategory()
        Call connectdb()
        Try
            If txtCategory.Text = "" Then
                MsgBoxError("Fill data")
                txtCategory.Focus()
            Else
                Dim str As String
                str = "SELECT * FROM categories WHERE category='" & txtCategory.Text & "'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    If rd.Item("isActive") = "1" Then
                        closerd()
                        MsgBoxError("Data table exist")
                        Call atstart()
                    Else
                        closerd()
                        str = "UPDATE categories SET isActive='1' WHERE category='" & txtCategory.Text & "'"
                        cmd = New MySqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        closecmd()
                        MsgBoxInformation("Data category has been saved")
                        Call atstart()
                    End If
                Else
                    closerd()
                    str = "INSERT INTO categories VALUES ('" & txtCategory.Text & "', '1', '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP, '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP)"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    closecmd()
                    MsgBoxInformation("Data category has been saved")
                    Call atstart()
                End If

            End If
        Catch ex As Exception
            MsgBoxError("Data category hasn't been saved")
            Call atstart()
        End Try
    End Sub
    Sub updatecategory()
        Call connectdb()
        Try
            If txtCategory.Text = "" Then
                MsgBoxError("Fill data")
                txtCategory.Focus()
            Else
                str = "UPDATE categories SET category='" & txtCategory.Text & "' WHERE category='" & category & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                MsgBoxInformation("Data category has been updated")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data category hasn't been updated")
            Call atstart()
        End Try
    End Sub
    Sub deletecategory()
        Call connectdb()
        Try
            str = "DELETE FROM categories WHERE category='" & txtCategory.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data category has been deleted")
            Call atstart()
        Catch ex As Exception
            str = "UPDATE categories SET isActive='0' WHERE category='" & txtCategory.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data category has been deleted")
            Call atstart()
        End Try
    End Sub
    Sub cleartext()
        txtCategory.Clear()
    End Sub
    Sub disabletext()
        txtCategory.Enabled = False
    End Sub
    Sub enabletext()
        txtCategory.Enabled = True
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
        Call showgrid()
        Call countcategory()
        Call cleartext()
    End Sub
    Sub clickadd()
        btnAdd.Text = "&Save"
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        Call enabletext()
        txtCategory.Focus()
        Call cleartext()
    End Sub
    Sub clickedit()
        btnEdit.Text = "&Update"
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtCategory.Enabled = True
        txtCategory.Focus()
        Call cleartext()
    End Sub
    Sub clickdelete()
        btnDelete.Text = "&Yes"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnBack.Text = "&Cancel"
        txtCategory.Enabled = True
        txtCategory.Focus()
        Call cleartext()
    End Sub
    Private Sub frmMasterCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atstart()
        Call sizegrid()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Call clickadd()
        ElseIf btnAdd.Text = "&Save" Then
            Call savecategory()
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
            btnEdit.Enabled = False
            Call clickedit()
        ElseIf btnEdit.Text = "&Update" Then
            Call updatecategory()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            btnDelete.Enabled = False
            Call clickdelete()
        ElseIf btnDelete.Text = "&Yes" And (txtCategory.Text = "0" Or txtCategory.Text = "") Then
            MsgBoxWarning("Fill category")
            txtCategory.Focus()
        Else
            Call deletecategory()
        End If
    End Sub
    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If (btnAdd.Text <> "&Save") Then
                Call connectdb()
                Dim str As String
                str = "SELECT * FROM categories WHERE category='" & txtCategory.Text & "' AND isActive='1'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    category = rd.Item("category")
                    closerd()
                    If btnEdit.Text = "&Update" Then
                        Call enabletext()
                        btnEdit.Enabled = True
                    ElseIf btnDelete.Text = "&Yes" Then
                        btnDelete.Enabled = True
                        Call disabletext()
                    End If
                Else
                    MsgBoxWarning("Data category doesn't exist")
                    txtCategory.Focus()
                    closerd()
                End If
            End If
        End If
    End Sub
End Class