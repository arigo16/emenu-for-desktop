Imports MySql.Data.MySqlClient

Public Class frmSettingPassword
    Public Function encryptmd5(ByVal textToHash As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If txtOldPassword.Text = "" Or txtNewPassword.Text = "" Or txtRetype.Text = "" Then
            MsgBoxInformation("Please fill all field")
            txtOldPassword.Focus()
        Else
            Dim oldpassword, newpassword As String
            oldpassword = encryptmd5(txtOldPassword.Text)
            newpassword = encryptmd5(txtNewPassword.Text)
            Call connectdb()
            Try
                str = "SELECT password FROM users WHERE username='" & frmMainMenu.lblUsername.Text & "' and password = '" & oldpassword & "'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader()
                rd.Read()
                If rd.HasRows = True Then
                    If txtNewPassword.Text = txtRetype.Text Then
                        closerd()
                        str = "UPDATE users SET password = '" & newpassword & "' WHERE username = '" & frmMainMenu.lblUsername.Text & "'"
                        cmd = New MySqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        Call closecmd()
                        MsgBoxInformation("Password has been changed")
                        txtOldPassword.Clear()
                        txtNewPassword.Clear()
                        txtRetype.Clear()
                    Else
                        MsgBoxError("Old password and new password doesn't match")
                        txtNewPassword.Focus()
                    End If
                Else
                    MsgBoxError("Old password is wrong")
                    txtOldPassword.Focus()
                End If
            Catch ex As Exception
                MsgBoxError("Failed change password")
            End Try
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Wallpaper.Visible = True
    End Sub
    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            txtOldPassword.UseSystemPasswordChar = False
            txtNewPassword.UseSystemPasswordChar = False
            txtRetype.UseSystemPasswordChar = False
        Else
            txtOldPassword.UseSystemPasswordChar = True
            txtNewPassword.UseSystemPasswordChar = True
            txtRetype.UseSystemPasswordChar = True
        End If
    End Sub
End Class