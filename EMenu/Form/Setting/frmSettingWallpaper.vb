Public Class frmSettingWallpaper
    Sub showwallpaper()
        txtWallpaper.Text = My.Settings.Wallpaper
    End Sub
    Private Sub btnChooseWallpaper_Click(sender As Object, e As EventArgs) Handles btnChooseWallpaper.Click
        Dim file = ChooseWallpaper.ShowDialog
        If file = Windows.Forms.DialogResult.OK Then
            txtWallpaper.Text = ChooseWallpaper.FileName
        End If
    End Sub
    Private Sub txtWallpaper_TextChanged(sender As Object, e As EventArgs) Handles txtWallpaper.TextChanged
        SampleWallpaper.ImageLocation = txtWallpaper.Text
        SampleWallpaper.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtWallpaper.Text = "" Then
            MsgBoxError("Please choose wallpaper")
        Else
            My.Settings.Wallpaper = txtWallpaper.Text
            My.Settings.Save()
            MsgBoxInformation("Wallpaper has been changed")
        End If
    End Sub

    Private Sub frmSettingWallpaper_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Call showwallpaper()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Wallpaper.Visible = True
    End Sub
End Class