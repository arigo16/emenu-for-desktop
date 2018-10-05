Public Class frmSetServer
    Sub save()
        My.Settings.dbServer = txtServer.Text
        My.Settings.dbUser = txtUsername.Text
        My.Settings.dbPass = txtPassword.Text
        My.Settings.dbPort = txtPort.Text
        My.Settings.dbName = txtDatabase.Text
        My.Settings.Save()
        txtServer.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPort.Clear()
        txtDatabase.Clear()
        MsgBoxInformation("Configuration has been saved")
    End Sub
    Sub view()
        lblServer.Text = My.Settings.dbServer
        lblUsername.Text = My.Settings.dbUser
        lblPassword.Text = My.Settings.dbPass
        lblPort.Text = My.Settings.dbPort
        lblDatabase.Text = My.Settings.dbName
    End Sub
    Private Sub frmSetServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call view()
        txtServer.Focus()
    End Sub
    Private Sub frmSetServer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            frmLogin.Show()
            frmLogin.txtUsername.Clear()
            frmLogin.txtPassword.Clear()
            frmLogin.txtUsername.Focus()
        ElseIf e.Shift Then
            If ExpandablePanel.Expanded = True Then
                ExpandablePanel.Expanded = False
            Else
                ExpandablePanel.Expanded = True
            End If
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmLogin.Show()
        frmLogin.txtUsername.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUsername.Focus()
    End Sub
    Private Sub ExpandablePanel_Click(sender As Object, e As EventArgs) Handles ExpandablePanel.Click
        Call view()
    End Sub
    Private Sub frmSetServer_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call view()
        txtServer.Focus()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtServer.Text = "" Then
            errorServer.SetError(txtServer, "Input Server Name")
            txtServer.Focus()
        ElseIf txtUsername.Text = "" Then
            errorUsername.SetError(txtUsername, "Input User Name")
            txtUsername.Focus()
        ElseIf txtDatabase.Text = "" Then
            errorDatabase.SetError(txtDatabase, "Input Database Name")
            txtDatabase.Focus()
        Else
            Call save()
            Call view()
        End If
    End Sub
    Private Sub txtServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServer.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            txtUsername.Focus()
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtPort.Focus()
        End If
    End Sub
    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            txtDatabase.Focus()
        End If
    End Sub
    Private Sub txtDatabase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatabase.KeyPress
        If txtServer.Text = "" Then
            errorServer.SetError(txtServer, "Input Server")
            txtServer.Focus()
        ElseIf txtUsername.Text = "" Then
            errorUsername.SetError(txtUsername, "Input User")
            txtUsername.Focus()
        ElseIf txtDatabase.Text = "" Then
            errorDatabase.SetError(txtDatabase, "Input Database")
            txtDatabase.Focus()
        Else
            Call save()
            Call view()
        End If
    End Sub
    Private Sub txtServer_TextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged
        errorServer.Dispose()
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        errorUsername.Dispose()
    End Sub
    Private Sub txtDatabase_TextChanged(sender As Object, e As EventArgs) Handles txtDatabase.TextChanged
        errorDatabase.Dispose()
    End Sub
End Class