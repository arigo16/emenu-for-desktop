<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetServer))
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ExpandablePanel = New DevComponents.DotNetBar.ExpandablePanel()
        Me.lblDatabase = New DevComponents.DotNetBar.LabelX()
        Me.lblPort = New DevComponents.DotNetBar.LabelX()
        Me.lblPassword = New DevComponents.DotNetBar.LabelX()
        Me.lblUsername = New DevComponents.DotNetBar.LabelX()
        Me.lblServer = New DevComponents.DotNetBar.LabelX()
        Me.txtServer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPort = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDatabase = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.errorServer = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorUsername = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDatabase = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ExpandablePanel.SuspendLayout()
        CType(Me.errorServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(12, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(175, 34)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<b><font size=""12"">Setting <font color=""#B02B2C"">Server</font></font></b>"
        '
        'ExpandablePanel
        '
        Me.ExpandablePanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel.Controls.Add(Me.lblDatabase)
        Me.ExpandablePanel.Controls.Add(Me.lblPort)
        Me.ExpandablePanel.Controls.Add(Me.lblPassword)
        Me.ExpandablePanel.Controls.Add(Me.lblUsername)
        Me.ExpandablePanel.Controls.Add(Me.lblServer)
        Me.ExpandablePanel.Expanded = False
        Me.ExpandablePanel.ExpandedBounds = New System.Drawing.Rectangle(12, 52, 200, 186)
        Me.ExpandablePanel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel.Location = New System.Drawing.Point(12, 52)
        Me.ExpandablePanel.Name = "ExpandablePanel"
        Me.ExpandablePanel.Size = New System.Drawing.Size(200, 26)
        Me.ExpandablePanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel.Style.GradientAngle = 90
        Me.ExpandablePanel.TabIndex = 1
        Me.ExpandablePanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel.TitleText = "Current settings"
        '
        'lblDatabase
        '
        '
        '
        '
        Me.lblDatabase.BackgroundStyle.Class = ""
        Me.lblDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDatabase.Location = New System.Drawing.Point(3, 160)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(172, 23)
        Me.lblDatabase.TabIndex = 5
        Me.lblDatabase.Text = "db_emenu"
        '
        'lblPort
        '
        '
        '
        '
        Me.lblPort.BackgroundStyle.Class = ""
        Me.lblPort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPort.Location = New System.Drawing.Point(3, 128)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(172, 23)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "3306"
        '
        'lblPassword
        '
        '
        '
        '
        Me.lblPassword.BackgroundStyle.Class = ""
        Me.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPassword.Location = New System.Drawing.Point(3, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(172, 23)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "-"
        '
        'lblUsername
        '
        '
        '
        '
        Me.lblUsername.BackgroundStyle.Class = ""
        Me.lblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUsername.Location = New System.Drawing.Point(3, 64)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(172, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "root"
        '
        'lblServer
        '
        '
        '
        '
        Me.lblServer.BackgroundStyle.Class = ""
        Me.lblServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblServer.Location = New System.Drawing.Point(3, 32)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(172, 23)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "127.0.0.1"
        '
        'txtServer
        '
        '
        '
        '
        Me.txtServer.Border.Class = "TextBoxBorder"
        Me.txtServer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtServer.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(12, 84)
        Me.txtServer.MaxLength = 16
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(175, 26)
        Me.txtServer.TabIndex = 2
        Me.txtServer.WatermarkText = "Server"
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.Border.Class = "TextBoxBorder"
        Me.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsername.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(12, 116)
        Me.txtUsername.MaxLength = 8
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(175, 26)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.WatermarkText = "User"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(12, 148)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 26)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.WatermarkText = "Password"
        '
        'txtPort
        '
        '
        '
        '
        Me.txtPort.Border.Class = "TextBoxBorder"
        Me.txtPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPort.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(12, 180)
        Me.txtPort.MaxLength = 5
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(175, 26)
        Me.txtPort.TabIndex = 5
        Me.txtPort.WatermarkText = "Port"
        '
        'txtDatabase
        '
        '
        '
        '
        Me.txtDatabase.Border.Class = "TextBoxBorder"
        Me.txtDatabase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDatabase.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Location = New System.Drawing.Point(12, 212)
        Me.txtDatabase.MaxLength = 16
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(175, 26)
        Me.txtDatabase.TabIndex = 6
        Me.txtDatabase.WatermarkText = "Database"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 244)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(112, 244)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 30)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&Close"
        '
        'errorServer
        '
        Me.errorServer.ContainerControl = Me
        '
        'errorUsername
        '
        Me.errorUsername.ContainerControl = Me
        '
        'errorDatabase
        '
        Me.errorDatabase.ContainerControl = Me
        '
        'frmSetServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(226, 287)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ExpandablePanel)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSetServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Setting Server"
        Me.TopMost = True
        Me.ExpandablePanel.ResumeLayout(False)
        CType(Me.errorServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents ExpandablePanel As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents txtServer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPort As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDatabase As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents errorServer As ErrorProvider
    Friend WithEvents errorUsername As ErrorProvider
    Friend WithEvents errorDatabase As ErrorProvider
    Friend WithEvents lblServer As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDatabase As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPort As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPassword As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblUsername As DevComponents.DotNetBar.LabelX
End Class
