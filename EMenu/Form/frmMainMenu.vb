Public Class frmMainMenu
    Private Sub frmMainMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Wallpaper.ImageLocation = My.Settings.Wallpaper
        Wallpaper.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub frmMainMenu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frmLogin.Show()
    End Sub
    Private Sub frmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Wallpaper.Visible = False Then
                Wallpaper.Visible = True
            Else
                Me.Dispose()
                frmLogin.Show()
            End If
        End If
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblDate.Text = Format(Now, "dd - MMMM - yyyy")
        lblTime.Text = Format(Now, "HH : mm : ss tt")
    End Sub
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Dispose()
        frmLogin.Show()
    End Sub
    Private Sub tbMenus_Click(sender As Object, e As EventArgs) Handles tbMenus.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterMenus.Show()
        frmMasterMenus.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbTables_Click(sender As Object, e As EventArgs) Handles tbTables.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterTables.Show()
        frmMasterTables.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbUsers_Click(sender As Object, e As EventArgs) Handles tbUsers.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterUsers.Show()
        frmMasterUsers.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbCategories_Click(sender As Object, e As EventArgs) Handles tbCategories.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterCategories.Show()
        frmMasterCategories.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbOrders_Click(sender As Object, e As EventArgs) Handles tbOrders.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmTransactionOrders.Show()
        frmTransactionOrders.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbPayments_Click(sender As Object, e As EventArgs) Handles tbPayments.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmTransactionPayments.Show()
        frmTransactionPayments.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbReportMasters_Click(sender As Object, e As EventArgs) Handles tbReportMasters.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportMasters.Show()
        frmReportMasters.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbReportOrders_Click(sender As Object, e As EventArgs) Handles tbReportOrders.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportOrders.Show()
        frmReportOrders.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbReportPayments_Click(sender As Object, e As EventArgs) Handles tbReportPayments.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportPayments.Show()
        frmReportPayments.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbReportFinance_Click(sender As Object, e As EventArgs) Handles tbReportFinance.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportFinance.Show()
        frmReportFinance.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbSettingsWallpaper_Click(sender As Object, e As EventArgs) Handles tbSettingsWallpaper.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingWallpaper.Show()
        frmSettingWallpaper.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbSettingsPassword_Click(sender As Object, e As EventArgs) Handles tbSettingsPassword.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingPassword.Show()
        frmSettingPassword.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbSettingsBackup_Click(sender As Object, e As EventArgs) Handles tbSettingsBackup.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingDatabase.Show()
        frmSettingDatabase.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbHelpDeveloper_Click(sender As Object, e As EventArgs) Handles tbHelpDeveloper.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmHelpDev.Show()
        frmHelpDev.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub tbHelpApp_Click(sender As Object, e As EventArgs) Handles tbHelpApp.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmHelpApp.Show()
        frmHelpApp.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnMaster_Menu_Click(sender As Object, e As EventArgs) Handles mnMaster_Menu.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterMenus.Show()
        frmMasterMenus.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnMaster_Tables_Click(sender As Object, e As EventArgs) Handles mnMaster_Tables.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterTables.Show()
        frmMasterTables.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnMaster_Users_Click(sender As Object, e As EventArgs) Handles mnMaster_Users.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterUsers.Show()
        frmMasterUsers.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnMaster_Categories_Click(sender As Object, e As EventArgs) Handles mnMaster_Categories.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmMasterCategories.Show()
        frmMasterCategories.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnTransaction_Orders_Click(sender As Object, e As EventArgs) Handles mnTransaction_Orders.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmTransactionOrders.Show()
        frmTransactionOrders.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnTransaction_Payments_Click(sender As Object, e As EventArgs) Handles mnTransaction_Payments.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmTransactionPayments.Show()
        frmTransactionPayments.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnReport_Masters_Click(sender As Object, e As EventArgs) Handles mnReport_Masters.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportMasters.Show()
        frmReportMasters.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnReport_Orders_Click(sender As Object, e As EventArgs) Handles mnReport_Orders.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportOrders.Show()
        frmReportOrders.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnReport_Payments_Click(sender As Object, e As EventArgs) Handles mnReport_Payments.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportPayments.Show()
        frmReportPayments.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnReport_Finance_Click(sender As Object, e As EventArgs) Handles mnReport_Finance.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmReportFinance.Show()
        frmReportFinance.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnSetting_Wallpaper_Click(sender As Object, e As EventArgs) Handles mnSetting_Wallpaper.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingWallpaper.Show()
        frmSettingWallpaper.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnSetting_Password_Click(sender As Object, e As EventArgs) Handles mnSetting_Password.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingPassword.Show()
        frmSettingPassword.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnSetting_Backup_Click(sender As Object, e As EventArgs) Handles mnSetting_Backup.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmSettingDatabase.Show()
        frmSettingDatabase.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnHelp_Dev_Click(sender As Object, e As EventArgs) Handles mnHelp_Dev.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmHelpDev.Show()
        frmHelpDev.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
    Private Sub mnHelp_App_Click(sender As Object, e As EventArgs) Handles mnHelp_App.Click
        Me.IsMdiContainer = False
        Me.IsMdiContainer = True
        frmHelpApp.Show()
        frmHelpApp.MdiParent = Me
        Wallpaper.Visible = False
    End Sub
End Class