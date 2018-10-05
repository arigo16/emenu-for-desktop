<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelUser = New DevComponents.DotNetBar.PanelEx()
        Me.lblUser = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DGUser = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.cbAuthorization = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Administrator = New DevComponents.Editors.ComboItem()
        Me.Owner = New DevComponents.Editors.ComboItem()
        Me.Waiter = New DevComponents.Editors.ComboItem()
        Me.Cashier = New DevComponents.Editors.ComboItem()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtFullname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelUser.SuspendLayout()
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(1336, 54)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Master User"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelUser
        '
        Me.PanelUser.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelUser.Controls.Add(Me.lblUser)
        Me.PanelUser.Controls.Add(Me.LabelX6)
        Me.PanelUser.Controls.Add(Me.DGUser)
        Me.PanelUser.Controls.Add(Me.btnBack)
        Me.PanelUser.Controls.Add(Me.btnDelete)
        Me.PanelUser.Controls.Add(Me.btnEdit)
        Me.PanelUser.Controls.Add(Me.btnAdd)
        Me.PanelUser.Controls.Add(Me.cbAuthorization)
        Me.PanelUser.Controls.Add(Me.LabelX5)
        Me.PanelUser.Controls.Add(Me.txtFullname)
        Me.PanelUser.Controls.Add(Me.LabelX4)
        Me.PanelUser.Controls.Add(Me.txtPassword)
        Me.PanelUser.Controls.Add(Me.txtUsername)
        Me.PanelUser.Controls.Add(Me.LabelX3)
        Me.PanelUser.Controls.Add(Me.LabelX2)
        Me.PanelUser.Location = New System.Drawing.Point(426, 121)
        Me.PanelUser.Name = "PanelUser"
        Me.PanelUser.Size = New System.Drawing.Size(507, 416)
        Me.PanelUser.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelUser.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelUser.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelUser.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelUser.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelUser.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelUser.Style.GradientAngle = 90
        Me.PanelUser.TabIndex = 2
        '
        'lblUser
        '
        '
        '
        '
        Me.lblUser.BackgroundStyle.Class = ""
        Me.lblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUser.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(418, 384)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(75, 23)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "00"
        Me.lblUser.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(12, 384)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(157, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Total User"
        '
        'DGUser
        '
        Me.DGUser.AllowUserToAddRows = False
        Me.DGUser.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGUser.Location = New System.Drawing.Point(12, 191)
        Me.DGUser.Name = "DGUser"
        Me.DGUser.ReadOnly = True
        Me.DGUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGUser.Size = New System.Drawing.Size(481, 187)
        Me.DGUser.TabIndex = 9
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(418, 150)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "&Back"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(337, 150)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(256, 150)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(175, 150)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        '
        'cbAuthorization
        '
        Me.cbAuthorization.DisplayMember = "Text"
        Me.cbAuthorization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAuthorization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAuthorization.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAuthorization.FormattingEnabled = True
        Me.cbAuthorization.ItemHeight = 23
        Me.cbAuthorization.Items.AddRange(New Object() {Me.Administrator, Me.Owner, Me.Waiter, Me.Cashier})
        Me.cbAuthorization.Location = New System.Drawing.Point(175, 115)
        Me.cbAuthorization.MaxLength = 20
        Me.cbAuthorization.Name = "cbAuthorization"
        Me.cbAuthorization.Size = New System.Drawing.Size(162, 29)
        Me.cbAuthorization.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbAuthorization.TabIndex = 4
        '
        'Administrator
        '
        Me.Administrator.FontName = "Arial"
        Me.Administrator.FontSize = 14.0!
        Me.Administrator.FontStyle = System.Drawing.FontStyle.Bold
        Me.Administrator.Text = "Administrator"
        '
        'Owner
        '
        Me.Owner.FontName = "Arial"
        Me.Owner.FontSize = 14.0!
        Me.Owner.FontStyle = System.Drawing.FontStyle.Bold
        Me.Owner.Text = "Owner"
        '
        'Waiter
        '
        Me.Waiter.FontName = "Arial"
        Me.Waiter.FontSize = 14.0!
        Me.Waiter.FontStyle = System.Drawing.FontStyle.Bold
        Me.Waiter.Text = "Waiter"
        '
        'Cashier
        '
        Me.Cashier.FontName = "Arial"
        Me.Cashier.FontSize = 14.0!
        Me.Cashier.FontStyle = System.Drawing.FontStyle.Bold
        Me.Cashier.Text = "Cashier"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 115)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(157, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Authorization"
        '
        'txtFullname
        '
        '
        '
        '
        Me.txtFullname.Border.Class = "TextBoxBorder"
        Me.txtFullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFullname.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(175, 80)
        Me.txtFullname.MaxLength = 30
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(318, 29)
        Me.txtFullname.TabIndex = 3
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 82)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(157, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Fullname"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(175, 45)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(232, 29)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.Border.Class = "TextBoxBorder"
        Me.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(175, 10)
        Me.txtUsername.MaxLength = 8
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(164, 29)
        Me.txtUsername.TabIndex = 1
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(12, 47)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(157, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Password"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(12, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(157, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Username"
        '
        'frmMasterUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.PanelUser)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasterUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Users"
        Me.PanelUser.ResumeLayout(False)
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelUser As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFullname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbAuthorization As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGUser As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lblUser As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Administrator As DevComponents.Editors.ComboItem
    Friend WithEvents Owner As DevComponents.Editors.ComboItem
    Friend WithEvents Waiter As DevComponents.Editors.ComboItem
    Friend WithEvents Cashier As DevComponents.Editors.ComboItem
End Class
