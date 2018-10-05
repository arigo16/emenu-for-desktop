<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.RibbonControl = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.tbHelpDeveloper = New DevComponents.DotNetBar.ButtonItem()
        Me.tbHelpApp = New DevComponents.DotNetBar.ButtonItem()
        Me.rbSettings = New DevComponents.DotNetBar.RibbonBar()
        Me.tbSettingsWallpaper = New DevComponents.DotNetBar.ButtonItem()
        Me.tbSettingsPassword = New DevComponents.DotNetBar.ButtonItem()
        Me.tbSettingsBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.rbReports = New DevComponents.DotNetBar.RibbonBar()
        Me.tbReportMasters = New DevComponents.DotNetBar.ButtonItem()
        Me.tbReportOrders = New DevComponents.DotNetBar.ButtonItem()
        Me.tbReportPayments = New DevComponents.DotNetBar.ButtonItem()
        Me.tbReportFinance = New DevComponents.DotNetBar.ButtonItem()
        Me.rbTransactions = New DevComponents.DotNetBar.RibbonBar()
        Me.tbOrders = New DevComponents.DotNetBar.ButtonItem()
        Me.tbPayments = New DevComponents.DotNetBar.ButtonItem()
        Me.rbMasters = New DevComponents.DotNetBar.RibbonBar()
        Me.tbMenus = New DevComponents.DotNetBar.ButtonItem()
        Me.tbTables = New DevComponents.DotNetBar.ButtonItem()
        Me.tbUsers = New DevComponents.DotNetBar.ButtonItem()
        Me.tbCategories = New DevComponents.DotNetBar.ButtonItem()
        Me.Toolbar = New DevComponents.DotNetBar.RibbonTabItem()
        Me.mnMasters = New DevComponents.DotNetBar.ButtonItem()
        Me.mnMaster_Menu = New DevComponents.DotNetBar.ButtonItem()
        Me.mnMaster_Tables = New DevComponents.DotNetBar.ButtonItem()
        Me.mnMaster_Users = New DevComponents.DotNetBar.ButtonItem()
        Me.mnMaster_Categories = New DevComponents.DotNetBar.ButtonItem()
        Me.mnTransactions = New DevComponents.DotNetBar.ButtonItem()
        Me.mnTransaction_Orders = New DevComponents.DotNetBar.ButtonItem()
        Me.mnTransaction_Payments = New DevComponents.DotNetBar.ButtonItem()
        Me.mnReports = New DevComponents.DotNetBar.ButtonItem()
        Me.mnReport_Masters = New DevComponents.DotNetBar.ButtonItem()
        Me.mnReport_Orders = New DevComponents.DotNetBar.ButtonItem()
        Me.mnReport_Payments = New DevComponents.DotNetBar.ButtonItem()
        Me.mnReport_Finance = New DevComponents.DotNetBar.ButtonItem()
        Me.MnSettings = New DevComponents.DotNetBar.ButtonItem()
        Me.mnSetting_Wallpaper = New DevComponents.DotNetBar.ButtonItem()
        Me.mnSetting_Password = New DevComponents.DotNetBar.ButtonItem()
        Me.mnSetting_Backup = New DevComponents.DotNetBar.ButtonItem()
        Me.mnHelp = New DevComponents.DotNetBar.ButtonItem()
        Me.mnHelp_Dev = New DevComponents.DotNetBar.ButtonItem()
        Me.mnHelp_App = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.btnSignOut = New DevComponents.DotNetBar.ButtonItem()
        Me.SMMainMenu = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.lblFullname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAuthorization = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Wallpaper = New System.Windows.Forms.PictureBox()
        Me.RibbonControl.SuspendLayout()
        Me.RibbonPanel.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        CType(Me.Wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        '
        '
        '
        Me.RibbonControl.BackgroundStyle.Class = ""
        Me.RibbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl.CaptionVisible = True
        Me.RibbonControl.Controls.Add(Me.RibbonPanel)
        Me.RibbonControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Toolbar, Me.mnMasters, Me.mnTransactions, Me.mnReports, Me.MnSettings, Me.mnHelp})
        Me.RibbonControl.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1, Me.btnSignOut})
        Me.RibbonControl.Size = New System.Drawing.Size(1366, 154)
        Me.RibbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl.TabGroupHeight = 14
        Me.RibbonControl.TabIndex = 0
        Me.RibbonControl.Text = "RibbonControl"
        '
        'RibbonPanel
        '
        Me.RibbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel.Controls.Add(Me.rbSettings)
        Me.RibbonPanel.Controls.Add(Me.rbReports)
        Me.RibbonPanel.Controls.Add(Me.rbTransactions)
        Me.RibbonPanel.Controls.Add(Me.rbMasters)
        Me.RibbonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel.Name = "RibbonPanel"
        Me.RibbonPanel.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel.Size = New System.Drawing.Size(1366, 96)
        '
        '
        '
        Me.RibbonPanel.Style.Class = ""
        Me.RibbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel.StyleMouseDown.Class = ""
        Me.RibbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel.StyleMouseOver.Class = ""
        Me.RibbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel.TabIndex = 1
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.Class = ""
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.Class = ""
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tbHelpDeveloper, Me.tbHelpApp})
        Me.RibbonBar3.Location = New System.Drawing.Point(792, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(134, 93)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 4
        Me.RibbonBar3.Text = "Help"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.Class = ""
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.Class = ""
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'tbHelpDeveloper
        '
        Me.tbHelpDeveloper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbHelpDeveloper.Icon = CType(resources.GetObject("tbHelpDeveloper.Icon"), System.Drawing.Icon)
        Me.tbHelpDeveloper.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbHelpDeveloper.Name = "tbHelpDeveloper"
        Me.tbHelpDeveloper.SubItemsExpandWidth = 14
        Me.tbHelpDeveloper.Text = "Developer"
        '
        'tbHelpApp
        '
        Me.tbHelpApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbHelpApp.Icon = CType(resources.GetObject("tbHelpApp.Icon"), System.Drawing.Icon)
        Me.tbHelpApp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbHelpApp.Name = "tbHelpApp"
        Me.tbHelpApp.SubItemsExpandWidth = 14
        Me.tbHelpApp.Text = "Application"
        '
        'rbSettings
        '
        Me.rbSettings.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbSettings.BackgroundMouseOverStyle.Class = ""
        Me.rbSettings.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSettings.BackgroundStyle.Class = ""
        Me.rbSettings.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbSettings.ContainerControlProcessDialogKey = True
        Me.rbSettings.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbSettings.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tbSettingsWallpaper, Me.tbSettingsPassword, Me.tbSettingsBackup})
        Me.rbSettings.Location = New System.Drawing.Point(608, 0)
        Me.rbSettings.Name = "rbSettings"
        Me.rbSettings.Size = New System.Drawing.Size(184, 93)
        Me.rbSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbSettings.TabIndex = 3
        Me.rbSettings.Text = "Settings"
        '
        '
        '
        Me.rbSettings.TitleStyle.Class = ""
        Me.rbSettings.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSettings.TitleStyleMouseOver.Class = ""
        Me.rbSettings.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'tbSettingsWallpaper
        '
        Me.tbSettingsWallpaper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSettingsWallpaper.Icon = CType(resources.GetObject("tbSettingsWallpaper.Icon"), System.Drawing.Icon)
        Me.tbSettingsWallpaper.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbSettingsWallpaper.Name = "tbSettingsWallpaper"
        Me.tbSettingsWallpaper.SubItemsExpandWidth = 14
        Me.tbSettingsWallpaper.Text = "Wallpaper"
        '
        'tbSettingsPassword
        '
        Me.tbSettingsPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSettingsPassword.Icon = CType(resources.GetObject("tbSettingsPassword.Icon"), System.Drawing.Icon)
        Me.tbSettingsPassword.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbSettingsPassword.Name = "tbSettingsPassword"
        Me.tbSettingsPassword.SubItemsExpandWidth = 14
        Me.tbSettingsPassword.Text = "Password"
        '
        'tbSettingsBackup
        '
        Me.tbSettingsBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbSettingsBackup.Icon = CType(resources.GetObject("tbSettingsBackup.Icon"), System.Drawing.Icon)
        Me.tbSettingsBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbSettingsBackup.Name = "tbSettingsBackup"
        Me.tbSettingsBackup.SubItemsExpandWidth = 14
        Me.tbSettingsBackup.Text = "Database"
        '
        'rbReports
        '
        Me.rbReports.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbReports.BackgroundMouseOverStyle.Class = ""
        Me.rbReports.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbReports.BackgroundStyle.Class = ""
        Me.rbReports.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbReports.ContainerControlProcessDialogKey = True
        Me.rbReports.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbReports.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tbReportMasters, Me.tbReportOrders, Me.tbReportPayments, Me.tbReportFinance})
        Me.rbReports.Location = New System.Drawing.Point(371, 0)
        Me.rbReports.Name = "rbReports"
        Me.rbReports.Size = New System.Drawing.Size(237, 93)
        Me.rbReports.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbReports.TabIndex = 2
        Me.rbReports.Text = "Reports"
        '
        '
        '
        Me.rbReports.TitleStyle.Class = ""
        Me.rbReports.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbReports.TitleStyleMouseOver.Class = ""
        Me.rbReports.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'tbReportMasters
        '
        Me.tbReportMasters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbReportMasters.Icon = CType(resources.GetObject("tbReportMasters.Icon"), System.Drawing.Icon)
        Me.tbReportMasters.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbReportMasters.Name = "tbReportMasters"
        Me.tbReportMasters.SubItemsExpandWidth = 14
        Me.tbReportMasters.Text = "Masters"
        '
        'tbReportOrders
        '
        Me.tbReportOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbReportOrders.Icon = CType(resources.GetObject("tbReportOrders.Icon"), System.Drawing.Icon)
        Me.tbReportOrders.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbReportOrders.Name = "tbReportOrders"
        Me.tbReportOrders.SubItemsExpandWidth = 14
        Me.tbReportOrders.Text = "Orders"
        '
        'tbReportPayments
        '
        Me.tbReportPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbReportPayments.Icon = CType(resources.GetObject("tbReportPayments.Icon"), System.Drawing.Icon)
        Me.tbReportPayments.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbReportPayments.Name = "tbReportPayments"
        Me.tbReportPayments.SubItemsExpandWidth = 14
        Me.tbReportPayments.Text = "Payments"
        '
        'tbReportFinance
        '
        Me.tbReportFinance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbReportFinance.Icon = CType(resources.GetObject("tbReportFinance.Icon"), System.Drawing.Icon)
        Me.tbReportFinance.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbReportFinance.Name = "tbReportFinance"
        Me.tbReportFinance.SubItemsExpandWidth = 14
        Me.tbReportFinance.Text = "Finance"
        '
        'rbTransactions
        '
        Me.rbTransactions.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbTransactions.BackgroundMouseOverStyle.Class = ""
        Me.rbTransactions.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbTransactions.BackgroundStyle.Class = ""
        Me.rbTransactions.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbTransactions.ContainerControlProcessDialogKey = True
        Me.rbTransactions.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbTransactions.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tbOrders, Me.tbPayments})
        Me.rbTransactions.Location = New System.Drawing.Point(245, 0)
        Me.rbTransactions.Name = "rbTransactions"
        Me.rbTransactions.Size = New System.Drawing.Size(126, 93)
        Me.rbTransactions.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbTransactions.TabIndex = 1
        Me.rbTransactions.Text = "Transactions"
        '
        '
        '
        Me.rbTransactions.TitleStyle.Class = ""
        Me.rbTransactions.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbTransactions.TitleStyleMouseOver.Class = ""
        Me.rbTransactions.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'tbOrders
        '
        Me.tbOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbOrders.Icon = CType(resources.GetObject("tbOrders.Icon"), System.Drawing.Icon)
        Me.tbOrders.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbOrders.Name = "tbOrders"
        Me.tbOrders.SubItemsExpandWidth = 14
        Me.tbOrders.Text = "Orders"
        '
        'tbPayments
        '
        Me.tbPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbPayments.Icon = CType(resources.GetObject("tbPayments.Icon"), System.Drawing.Icon)
        Me.tbPayments.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbPayments.Name = "tbPayments"
        Me.tbPayments.SubItemsExpandWidth = 14
        Me.tbPayments.Text = "Payments"
        '
        'rbMasters
        '
        Me.rbMasters.AutoOverflowEnabled = True
        '
        '
        '
        Me.rbMasters.BackgroundMouseOverStyle.Class = ""
        Me.rbMasters.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbMasters.BackgroundStyle.Class = ""
        Me.rbMasters.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbMasters.ContainerControlProcessDialogKey = True
        Me.rbMasters.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbMasters.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tbMenus, Me.tbTables, Me.tbUsers, Me.tbCategories})
        Me.rbMasters.Location = New System.Drawing.Point(3, 0)
        Me.rbMasters.Name = "rbMasters"
        Me.rbMasters.Size = New System.Drawing.Size(242, 93)
        Me.rbMasters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbMasters.TabIndex = 0
        Me.rbMasters.Text = "Masters"
        '
        '
        '
        Me.rbMasters.TitleStyle.Class = ""
        Me.rbMasters.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbMasters.TitleStyleMouseOver.Class = ""
        Me.rbMasters.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'tbMenus
        '
        Me.tbMenus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbMenus.Icon = CType(resources.GetObject("tbMenus.Icon"), System.Drawing.Icon)
        Me.tbMenus.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbMenus.Name = "tbMenus"
        Me.tbMenus.SubItemsExpandWidth = 14
        Me.tbMenus.Text = "Menus"
        '
        'tbTables
        '
        Me.tbTables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbTables.Icon = CType(resources.GetObject("tbTables.Icon"), System.Drawing.Icon)
        Me.tbTables.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbTables.Name = "tbTables"
        Me.tbTables.SubItemsExpandWidth = 14
        Me.tbTables.Text = "Tables"
        '
        'tbUsers
        '
        Me.tbUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbUsers.Icon = CType(resources.GetObject("tbUsers.Icon"), System.Drawing.Icon)
        Me.tbUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbUsers.Name = "tbUsers"
        Me.tbUsers.SubItemsExpandWidth = 14
        Me.tbUsers.Text = "Users"
        '
        'tbCategories
        '
        Me.tbCategories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbCategories.Icon = CType(resources.GetObject("tbCategories.Icon"), System.Drawing.Icon)
        Me.tbCategories.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.tbCategories.Name = "tbCategories"
        Me.tbCategories.SubItemsExpandWidth = 14
        Me.tbCategories.Text = "Categories"
        '
        'Toolbar
        '
        Me.Toolbar.Checked = True
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Panel = Me.RibbonPanel
        Me.Toolbar.Text = "Home"
        '
        'mnMasters
        '
        Me.mnMasters.Name = "mnMasters"
        Me.mnMasters.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnMaster_Menu, Me.mnMaster_Tables, Me.mnMaster_Users, Me.mnMaster_Categories})
        Me.mnMasters.Text = "&Masters"
        '
        'mnMaster_Menu
        '
        Me.mnMaster_Menu.Icon = CType(resources.GetObject("mnMaster_Menu.Icon"), System.Drawing.Icon)
        Me.mnMaster_Menu.Name = "mnMaster_Menu"
        Me.mnMaster_Menu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlM)
        Me.mnMaster_Menu.Text = "Menus"
        '
        'mnMaster_Tables
        '
        Me.mnMaster_Tables.Icon = CType(resources.GetObject("mnMaster_Tables.Icon"), System.Drawing.Icon)
        Me.mnMaster_Tables.Name = "mnMaster_Tables"
        Me.mnMaster_Tables.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT)
        Me.mnMaster_Tables.Text = "Tables"
        '
        'mnMaster_Users
        '
        Me.mnMaster_Users.Icon = CType(resources.GetObject("mnMaster_Users.Icon"), System.Drawing.Icon)
        Me.mnMaster_Users.Name = "mnMaster_Users"
        Me.mnMaster_Users.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU)
        Me.mnMaster_Users.Text = "Users"
        '
        'mnMaster_Categories
        '
        Me.mnMaster_Categories.Icon = CType(resources.GetObject("mnMaster_Categories.Icon"), System.Drawing.Icon)
        Me.mnMaster_Categories.Name = "mnMaster_Categories"
        Me.mnMaster_Categories.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlG)
        Me.mnMaster_Categories.Text = "Categories"
        '
        'mnTransactions
        '
        Me.mnTransactions.Name = "mnTransactions"
        Me.mnTransactions.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnTransaction_Orders, Me.mnTransaction_Payments})
        Me.mnTransactions.Text = "Transactions"
        '
        'mnTransaction_Orders
        '
        Me.mnTransaction_Orders.Icon = CType(resources.GetObject("mnTransaction_Orders.Icon"), System.Drawing.Icon)
        Me.mnTransaction_Orders.Name = "mnTransaction_Orders"
        Me.mnTransaction_Orders.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftO)
        Me.mnTransaction_Orders.Text = "Orders"
        '
        'mnTransaction_Payments
        '
        Me.mnTransaction_Payments.Icon = CType(resources.GetObject("mnTransaction_Payments.Icon"), System.Drawing.Icon)
        Me.mnTransaction_Payments.Name = "mnTransaction_Payments"
        Me.mnTransaction_Payments.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftP)
        Me.mnTransaction_Payments.Text = "Payments"
        '
        'mnReports
        '
        Me.mnReports.Name = "mnReports"
        Me.mnReports.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnReport_Masters, Me.mnReport_Orders, Me.mnReport_Payments, Me.mnReport_Finance})
        Me.mnReports.Text = "Reports"
        '
        'mnReport_Masters
        '
        Me.mnReport_Masters.Icon = CType(resources.GetObject("mnReport_Masters.Icon"), System.Drawing.Icon)
        Me.mnReport_Masters.Name = "mnReport_Masters"
        Me.mnReport_Masters.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltM)
        Me.mnReport_Masters.Text = "Masters"
        '
        'mnReport_Orders
        '
        Me.mnReport_Orders.Icon = CType(resources.GetObject("mnReport_Orders.Icon"), System.Drawing.Icon)
        Me.mnReport_Orders.Name = "mnReport_Orders"
        Me.mnReport_Orders.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltO)
        Me.mnReport_Orders.Text = "Orders"
        '
        'mnReport_Payments
        '
        Me.mnReport_Payments.Icon = CType(resources.GetObject("mnReport_Payments.Icon"), System.Drawing.Icon)
        Me.mnReport_Payments.Name = "mnReport_Payments"
        Me.mnReport_Payments.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltP)
        Me.mnReport_Payments.Text = "Payments"
        '
        'mnReport_Finance
        '
        Me.mnReport_Finance.Icon = CType(resources.GetObject("mnReport_Finance.Icon"), System.Drawing.Icon)
        Me.mnReport_Finance.Name = "mnReport_Finance"
        Me.mnReport_Finance.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.ShiftAltF)
        Me.mnReport_Finance.Text = "Finance"
        '
        'MnSettings
        '
        Me.MnSettings.Name = "MnSettings"
        Me.MnSettings.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnSetting_Wallpaper, Me.mnSetting_Password, Me.mnSetting_Backup})
        Me.MnSettings.Text = "Settings"
        '
        'mnSetting_Wallpaper
        '
        Me.mnSetting_Wallpaper.Icon = CType(resources.GetObject("mnSetting_Wallpaper.Icon"), System.Drawing.Icon)
        Me.mnSetting_Wallpaper.Name = "mnSetting_Wallpaper"
        Me.mnSetting_Wallpaper.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW)
        Me.mnSetting_Wallpaper.Text = "Change Wallpaper"
        '
        'mnSetting_Password
        '
        Me.mnSetting_Password.Icon = CType(resources.GetObject("mnSetting_Password.Icon"), System.Drawing.Icon)
        Me.mnSetting_Password.Name = "mnSetting_Password"
        Me.mnSetting_Password.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.mnSetting_Password.Text = "Change Password"
        '
        'mnSetting_Backup
        '
        Me.mnSetting_Backup.Icon = CType(resources.GetObject("mnSetting_Backup.Icon"), System.Drawing.Icon)
        Me.mnSetting_Backup.Name = "mnSetting_Backup"
        Me.mnSetting_Backup.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB)
        Me.mnSetting_Backup.Text = "Backup Restore"
        '
        'mnHelp
        '
        Me.mnHelp.Name = "mnHelp"
        Me.mnHelp.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnHelp_Dev, Me.mnHelp_App})
        Me.mnHelp.Text = "Help"
        '
        'mnHelp_Dev
        '
        Me.mnHelp_Dev.Icon = CType(resources.GetObject("mnHelp_Dev.Icon"), System.Drawing.Icon)
        Me.mnHelp_Dev.Name = "mnHelp_Dev"
        Me.mnHelp_Dev.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.mnHelp_Dev.Text = "About Developer"
        '
        'mnHelp_App
        '
        Me.mnHelp_App.Icon = CType(resources.GetObject("mnHelp_App.Icon"), System.Drawing.Icon)
        Me.mnHelp_App.Name = "mnHelp_App"
        Me.mnHelp_App.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.mnHelp_App.Text = "About Application"
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.Text = "&File"
        '
        'btnSignOut
        '
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Text = "Sign Out"
        '
        'SMMainMenu
        '
        Me.SMMainMenu.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.SMMainMenu.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFullname, Me.lblUsername, Me.ToolStripStatusLabel3, Me.lblAuthorization, Me.ToolStripStatusLabel5, Me.lblDate, Me.ToolStripStatusLabel7, Me.lblTime})
        Me.StatusBar.Location = New System.Drawing.Point(0, 746)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1366, 22)
        Me.StatusBar.TabIndex = 1
        '
        'lblFullname
        '
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(57, 17)
        Me.lblFullname.Text = "Fullname"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(64, 17)
        Me.lblUsername.Text = "Username"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(21, 17)
        Me.ToolStripStatusLabel3.Text = "AS"
        '
        'lblAuthorization
        '
        Me.lblAuthorization.Name = "lblAuthorization"
        Me.lblAuthorization.Size = New System.Drawing.Size(83, 17)
        Me.lblAuthorization.Text = "Authorization"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel5.Text = "/"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(110, 17)
        Me.lblDate.Text = "01 - Januari - 2018"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel7.Text = "/"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(65, 17)
        Me.lblTime.Text = "12 : 02 PM"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Wallpaper
        '
        Me.Wallpaper.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Wallpaper.Location = New System.Drawing.Point(0, 155)
        Me.Wallpaper.Name = "Wallpaper"
        Me.Wallpaper.Size = New System.Drawing.Size(1366, 588)
        Me.Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wallpaper.TabIndex = 2
        Me.Wallpaper.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Wallpaper)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonControl.ResumeLayout(False)
        Me.RibbonControl.PerformLayout()
        Me.RibbonPanel.ResumeLayout(False)
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.Wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents rbMasters As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents Toolbar As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents mnMasters As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnMaster_Menu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnTransactions As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnTransaction_Orders As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnReports As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnReport_Orders As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents btnSignOut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SMMainMenu As DevComponents.DotNetBar.StyleManager
    Friend WithEvents mnMaster_Tables As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnMaster_Users As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnMaster_Categories As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MnSettings As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnSetting_Wallpaper As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnHelp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnHelp_Dev As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnTransaction_Payments As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnReport_Masters As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnReport_Payments As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnReport_Finance As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnSetting_Password As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnSetting_Backup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnHelp_App As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents tbMenus As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents rbTransactions As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents tbPayments As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblFullname As ToolStripStatusLabel
    Friend WithEvents lblUsername As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblAuthorization As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents tbOrders As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbTables As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbUsers As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbCategories As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rbSettings As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents rbReports As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents tbReportMasters As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbReportOrders As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbReportPayments As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbReportFinance As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbSettingsWallpaper As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbSettingsPassword As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbSettingsBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbHelpDeveloper As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents tbHelpApp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Wallpaper As PictureBox
End Class
