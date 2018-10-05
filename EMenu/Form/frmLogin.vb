Imports MySql.Data.MySqlClient

Public Class frmLogin
    Public Function encryptmd5(ByVal textToHash As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function
    Sub lastlogin()
        Dim str, datelastlogin As String
        datelastlogin = Format(Now, "yyyy-MM-dd HH:mm:ss")
        str = "UPDATE users SET LastLogin='" & datelastlogin & "' WHERE username='" & txtUsername.Text & "'"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        Call closecmd()
    End Sub
    Sub cleartext()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
    Sub login()
        Dim password As String
        password = encryptmd5(txtPassword.Text)
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            errorUsername.SetError(txtUsername, "Username Empty")
            errorPassword.SetError(txtPassword, "Password Empty")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            errorUsername.SetError(txtUsername, "Username Empty")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            errorPassword.SetError(txtPassword, "Password Empty")
            txtPassword.Focus()
        Else
            Call connectdb()
            Try
                str = "SELECT * FROM users WHERE username='" & txtUsername.Text & "' AND password='" & password & "' AND isActive='1' AND (authorization='Cashier' OR authorization='Administrator' OR authorization='Owner')"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader()
                rd.Read()

                If rd.HasRows = True Then
                    If rd.Item("authorization") = "Administrator" Then
                        Me.Hide()
                        frmMainMenu.Show()
                        frmMainMenu.lblFullname.Text = rd.Item("fullname")
                        frmMainMenu.lblUsername.Text = rd.Item("username")
                        frmMainMenu.lblUsername.Visible = False
                        frmMainMenu.lblAuthorization.Text = rd.Item("authorization")
                        Call closerd()
                        Call lastlogin()
                        Call cleartext()
                    ElseIf rd.Item("authorization") = "Owner" Then
                        Me.Hide()
                        frmMainMenu.Show()
                        frmMainMenu.lblFullname.Text = rd.Item("fullname")
                        frmMainMenu.lblUsername.Text = rd.Item("username")
                        frmMainMenu.lblUsername.Visible = False
                        frmMainMenu.lblAuthorization.Text = rd.Item("authorization")
                        Call closerd()
                        Call lastlogin()
                        Call cleartext()
                    ElseIf rd.Item("authorization") = "Cashier" Then
                        Me.Hide()
                        frmMainMenu.Show()
                        frmMainMenu.lblFullname.Text = rd.Item("fullname")
                        frmMainMenu.lblUsername.Text = rd.Item("username")
                        frmMainMenu.lblUsername.Visible = False
                        frmMainMenu.lblAuthorization.Text = rd.Item("authorization")
                        frmMainMenu.tbMenus.Enabled = False
                        frmMainMenu.tbTables.Enabled = False
                        frmMainMenu.tbUsers.Enabled = False
                        frmMainMenu.tbCategories.Enabled = False
                        Call closerd()
                        Call lastlogin()
                        Call cleartext()
                    End If
                Else
                    MsgBoxError("Username and Password doesn't match")
                    Call cleartext()
                    txtUsername.Focus()
                End If
            Catch ex As Exception
                MsgBoxError("Make sure your connection valid")
                Me.Hide()
                frmSetServer.Show()
                frmSetServer.txtServer.Clear()
                frmSetServer.txtUsername.Clear()
                frmSetServer.txtPort.Clear()
                frmSetServer.txtPassword.Clear()
                frmSetServer.txtDatabase.Clear()
                frmSetServer.txtServer.Focus()
            End Try
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call login()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        errorUsername.Dispose()
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        errorPassword.Dispose()
    End Sub
    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.Alt And e.KeyCode = Keys.A Then
            frmSetServer.Show()
            frmSetServer.txtServer.Clear()
            frmSetServer.txtUsername.Clear()
            frmSetServer.txtPort.Clear()
            frmSetServer.txtPassword.Clear()
            frmSetServer.txtDatabase.Clear()
            frmSetServer.txtServer.Focus()
            Me.Hide()
        ElseIf e.KeyCode = Keys.Escape Then
            End
        ElseIf e.KeyCode = Keys.Enter Then
            txtUsername.Focus()
        ElseIf e.Control And e.KeyCode = Keys.M Then
            frmMonitoringOrders.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call login()
        End If
    End Sub
End Class
