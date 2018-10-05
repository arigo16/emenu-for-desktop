Imports MySql.Data.MySqlClient

Public Class frmMasterUsers
    Public Function encryptmd5(ByVal textToHash As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function
    Sub showgrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT username, fullname, authorization FROM users WHERE isActive='1' ORDER BY authorization ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "users")
        DGUser.DataSource = ds.Tables("users")
    End Sub
    Sub sizegrid()
        DGUser.Columns(0).Width = 100
        DGUser.Columns(1).Width = 200
        DGUser.Columns(2).Width = 130
        DGUser.Columns(0).Resizable = DataGridViewTriState.False
        DGUser.Columns(1).Resizable = DataGridViewTriState.False
        DGUser.Columns(2).Resizable = DataGridViewTriState.False
        DGUser.Columns(0).HeaderText = "Username"
        DGUser.Columns(1).HeaderText = "Fullname"
        DGUser.Columns(2).HeaderText = "Authorization"
    End Sub
    Sub countgrid()
        Dim rs As Integer
        rs = DGUser.RowCount
        lblUser.Text = rs
    End Sub
    Sub saveuser()
        Call connectdb()
        Try
            If cbAuthorization.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtFullname.Text = "" Then
                MsgBoxError("Fill data")
                txtUsername.Focus()
            Else
                Dim str, password As String
                password = encryptmd5(txtPassword.Text)
                str = "INSERT INTO users VALUES ('" & txtUsername.Text & "', '" & password & "', '" & txtFullname.Text & "', '" & cbAuthorization.Text & "', 'CURRENT_TIMESTAMP', '1', '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP, '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP)"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                closecmd()
                MsgBoxInformation("Data user has been saved")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data user hasn't been saved, username already exist")
            Call atstart()
        End Try
    End Sub
    Sub updateuser()
        Call connectdb()
        Try
            If cbAuthorization.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtFullname.Text = "" Then
                MsgBoxError("Fill data")
                txtUsername.Focus()
            Else
                Dim str, password As String
                password = encryptmd5(txtPassword.Text)
                str = "UPDATE users SET password='" & password & "', fullname='" & txtFullname.Text & "', authorization='" & cbAuthorization.Text & "' WHERE username='" & txtUsername.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                MsgBoxInformation("Data user has been updated")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data user hasn't been updated")
            Call atstart()
        End Try
    End Sub
    Sub deleteuser()
        Call connectdb()
        Try
            Dim str As String
            str = "DELETE FROM users WHERE username='" & txtUsername.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data user has been deleted")
            Call atstart()
        Catch ex As Exception
            Dim str As String
            str = "UPDATE users SET isActive='0' WHERE username='" & txtUsername.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data user has been deleted")
            Call atstart()
        End Try
    End Sub
    Sub cleartext()
        txtUsername.Clear()
        cbAuthorization.SelectedIndex = -1
        txtPassword.Clear()
        txtFullname.Clear()
    End Sub
    Sub disabletext()
        txtUsername.Enabled = False
        cbAuthorization.Enabled = False
        txtPassword.Enabled = False
        txtFullname.Enabled = False
    End Sub
    Sub enabletext()
        txtUsername.Enabled = True
        cbAuthorization.Enabled = True
        txtPassword.Enabled = True
        txtFullname.Enabled = True
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
        Call countgrid()
        Call cleartext()
    End Sub
    Sub clickadd()
        btnAdd.Text = "&Save"
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        Call enabletext()
        txtUsername.Focus()
        Call cleartext()
    End Sub
    Sub clickedit()
        btnEdit.Text = "&Update"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtUsername.Enabled = True
        txtUsername.Focus()
        Call cleartext()
    End Sub
    Sub clickdelete()
        btnDelete.Text = "&Yes"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtUsername.Enabled = True
        txtUsername.Focus()
        Call cleartext()
    End Sub
    Private Sub frmMasterUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atstart()
        Call sizegrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Call clickadd()
        ElseIf btnAdd.Text = "&Save" Then
            Call saveuser()
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
            Call updateuser()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            Call clickdelete()
        ElseIf btnDelete.Text = "&Yes" And txtFullname.Text = "" Then
            MsgBoxWarning("Fill id user")
            txtUsername.Focus()
        Else
            Call deleteuser()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If (btnAdd.Text <> "&Save") Then
                Call connectdb()
                Dim str As String
                str = "SELECT * FROM users WHERE username='" & txtUsername.Text & "'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    txtFullname.Text = rd.Item("fullname")
                    cbAuthorization.Text = rd.Item("authorization")
                    closerd()
                    If btnEdit.Text = "&Update" Then
                        Call enabletext()
                        btnEdit.Enabled = True
                        txtUsername.Enabled = False
                    ElseIf btnDelete.Text = "&Yes" Then
                        Call disabletext()
                        btnDelete.Enabled = True
                    End If
                Else
                    MsgBoxWarning("Data user doesn't exist")
                    txtUsername.Focus()
                    closerd()
                End If
            End If
        End If
    End Sub
End Class