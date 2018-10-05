<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterMenus
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelMenus = New DevComponents.DotNetBar.PanelEx()
        Me.cbStatusMenu = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtPrice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblSearch = New DevComponents.DotNetBar.LabelX()
        Me.cbSearch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.btnChoosePhoto = New DevComponents.DotNetBar.ButtonX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.txtPhoto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PhotoMenu = New System.Windows.Forms.PictureBox()
        Me.DGMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cbCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMenu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdMenu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ChoosePhoto = New System.Windows.Forms.OpenFileDialog()
        Me.PanelMenus.SuspendLayout()
        CType(Me.PhotoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Master Menu"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelMenus
        '
        Me.PanelMenus.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelMenus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelMenus.Controls.Add(Me.cbStatusMenu)
        Me.PanelMenus.Controls.Add(Me.txtPrice)
        Me.PanelMenus.Controls.Add(Me.lblSearch)
        Me.PanelMenus.Controls.Add(Me.cbSearch)
        Me.PanelMenus.Controls.Add(Me.LabelX9)
        Me.PanelMenus.Controls.Add(Me.txtSearch)
        Me.PanelMenus.Controls.Add(Me.LabelX8)
        Me.PanelMenus.Controls.Add(Me.btnChoosePhoto)
        Me.PanelMenus.Controls.Add(Me.btnBack)
        Me.PanelMenus.Controls.Add(Me.btnDelete)
        Me.PanelMenus.Controls.Add(Me.btnEdit)
        Me.PanelMenus.Controls.Add(Me.btnAdd)
        Me.PanelMenus.Controls.Add(Me.txtPhoto)
        Me.PanelMenus.Controls.Add(Me.PhotoMenu)
        Me.PanelMenus.Controls.Add(Me.DGMenu)
        Me.PanelMenus.Controls.Add(Me.cbCategory)
        Me.PanelMenus.Controls.Add(Me.txtDescription)
        Me.PanelMenus.Controls.Add(Me.txtMenu)
        Me.PanelMenus.Controls.Add(Me.txtIdMenu)
        Me.PanelMenus.Controls.Add(Me.LabelX7)
        Me.PanelMenus.Controls.Add(Me.LabelX6)
        Me.PanelMenus.Controls.Add(Me.LabelX5)
        Me.PanelMenus.Controls.Add(Me.LabelX4)
        Me.PanelMenus.Controls.Add(Me.LabelX3)
        Me.PanelMenus.Controls.Add(Me.LabelX2)
        Me.PanelMenus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenus.Location = New System.Drawing.Point(12, 72)
        Me.PanelMenus.Name = "PanelMenus"
        Me.PanelMenus.Size = New System.Drawing.Size(1336, 501)
        Me.PanelMenus.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelMenus.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelMenus.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelMenus.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelMenus.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelMenus.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelMenus.Style.GradientAngle = 90
        Me.PanelMenus.TabIndex = 1
        '
        'cbStatusMenu
        '
        '
        '
        '
        Me.cbStatusMenu.BackgroundStyle.Class = ""
        Me.cbStatusMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbStatusMenu.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusMenu.Location = New System.Drawing.Point(362, 116)
        Me.cbStatusMenu.Name = "cbStatusMenu"
        Me.cbStatusMenu.Size = New System.Drawing.Size(134, 29)
        Me.cbStatusMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbStatusMenu.TabIndex = 5
        Me.cbStatusMenu.Text = "  Out Of Stock"
        '
        'txtPrice
        '
        '
        '
        '
        Me.txtPrice.Border.Class = "TextBoxBorder"
        Me.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(178, 116)
        Me.txtPrice.MaxLength = 7
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(162, 29)
        Me.txtPrice.TabIndex = 4
        '
        'lblSearch
        '
        '
        '
        '
        Me.lblSearch.BackgroundStyle.Class = ""
        Me.lblSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(1270, 237)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(52, 29)
        Me.lblSearch.TabIndex = 23
        Me.lblSearch.Text = "0"
        Me.lblSearch.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cbSearch
        '
        Me.cbSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbSearch.DisplayMember = "Text"
        Me.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.ItemHeight = 23
        Me.cbSearch.Location = New System.Drawing.Point(779, 237)
        Me.cbSearch.MaxLength = 20
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(156, 29)
        Me.cbSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbSearch.TabIndex = 12
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(669, 237)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(104, 29)
        Me.LabelX9.TabIndex = 22
        Me.LabelX9.Text = "Filter by"
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(941, 238)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(323, 29)
        Me.txtSearch.TabIndex = 0
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(862, 52)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(315, 23)
        Me.LabelX8.TabIndex = 20
        Me.LabelX8.Text = "Note: Format image must be JPG or PNG"
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChoosePhoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePhoto.Location = New System.Drawing.Point(1274, 11)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(48, 29)
        Me.btnChoosePhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnChoosePhoto.TabIndex = 7
        Me.btnChoosePhoto.Text = "..."
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(421, 231)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "&Back"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(340, 231)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(259, 231)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(178, 231)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        '
        'txtPhoto
        '
        Me.txtPhoto.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtPhoto.Border.Class = "TextBoxBorder"
        Me.txtPhoto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPhoto.Enabled = False
        Me.txtPhoto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoto.Location = New System.Drawing.Point(669, 11)
        Me.txtPhoto.MaxLength = 200
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(653, 29)
        Me.txtPhoto.TabIndex = 6
        Me.txtPhoto.WatermarkColor = System.Drawing.Color.Silver
        Me.txtPhoto.WatermarkText = "Choose Photo File ..."
        '
        'PhotoMenu
        '
        Me.PhotoMenu.BackColor = System.Drawing.Color.Silver
        Me.PhotoMenu.Location = New System.Drawing.Point(669, 50)
        Me.PhotoMenu.Name = "PhotoMenu"
        Me.PhotoMenu.Size = New System.Drawing.Size(175, 175)
        Me.PhotoMenu.TabIndex = 13
        Me.PhotoMenu.TabStop = False
        '
        'DGMenu
        '
        Me.DGMenu.AllowUserToAddRows = False
        Me.DGMenu.AllowUserToDeleteRows = False
        Me.DGMenu.AllowUserToResizeColumns = False
        Me.DGMenu.AllowUserToResizeRows = False
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGMenu.Location = New System.Drawing.Point(15, 272)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.ReadOnly = True
        Me.DGMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGMenu.Size = New System.Drawing.Size(1307, 215)
        Me.DGMenu.TabIndex = 12
        '
        'cbCategory
        '
        Me.cbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbCategory.DisplayMember = "Text"
        Me.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.ItemHeight = 23
        Me.cbCategory.Location = New System.Drawing.Point(178, 46)
        Me.cbCategory.MaxLength = 20
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(162, 29)
        Me.cbCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCategory.TabIndex = 2
        '
        'txtDescription
        '
        '
        '
        '
        Me.txtDescription.Border.Class = "TextBoxBorder"
        Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(178, 151)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(318, 74)
        Me.txtDescription.TabIndex = 6
        '
        'txtMenu
        '
        '
        '
        '
        Me.txtMenu.Border.Class = "TextBoxBorder"
        Me.txtMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.Location = New System.Drawing.Point(178, 81)
        Me.txtMenu.MaxLength = 30
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(318, 29)
        Me.txtMenu.TabIndex = 3
        '
        'txtIdMenu
        '
        Me.txtIdMenu.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdMenu.Border.Class = "TextBoxBorder"
        Me.txtIdMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdMenu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMenu.Enabled = False
        Me.txtIdMenu.FocusHighlightColor = System.Drawing.Color.White
        Me.txtIdMenu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMenu.Location = New System.Drawing.Point(178, 11)
        Me.txtIdMenu.MaxLength = 5
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(80, 29)
        Me.txtIdMenu.TabIndex = 1
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(506, 13)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(157, 23)
        Me.LabelX7.TabIndex = 5
        Me.LabelX7.Text = "Photo"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(15, 151)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(157, 23)
        Me.LabelX6.TabIndex = 4
        Me.LabelX6.Text = "Description"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(15, 118)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(157, 23)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Price"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(15, 81)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(157, 23)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Menu"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(15, 46)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(157, 23)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Category"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(15, 13)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(157, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "ID Menu"
        '
        'ChoosePhoto
        '
        Me.ChoosePhoto.Filter = "Image Files (JPG,JPEG)|*.JPG;*.JPEG;*.PNG"
        '
        'frmMasterMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.PanelMenus)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasterMenus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Menus"
        Me.PanelMenus.ResumeLayout(False)
        CType(Me.PhotoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelMenus As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMenu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdMenu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPhoto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PhotoMenu As PictureBox
    Friend WithEvents DGMenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnChoosePhoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbSearch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblSearch As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChoosePhoto As OpenFileDialog
    Friend WithEvents txtPrice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbStatusMenu As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
