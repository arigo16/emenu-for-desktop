<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionOrders))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelOrders = New DevComponents.DotNetBar.PanelEx()
        Me.lblTerbilang = New DevComponents.DotNetBar.LabelX()
        Me.btnDel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.txtCategory = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPPN = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalPrice = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalQty = New DevComponents.DotNetBar.LabelX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.lblGrandTotal = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.btnCart = New DevComponents.DotNetBar.ButtonX()
        Me.txtQty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPrice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtMenu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdMenu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DGMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCustomer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbTable = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.PanelOrders.SuspendLayout()
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
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Transaction Order"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelOrders
        '
        Me.PanelOrders.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelOrders.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelOrders.Controls.Add(Me.btnEdit)
        Me.PanelOrders.Controls.Add(Me.lblTerbilang)
        Me.PanelOrders.Controls.Add(Me.btnDel)
        Me.PanelOrders.Controls.Add(Me.btnSearch)
        Me.PanelOrders.Controls.Add(Me.txtCategory)
        Me.PanelOrders.Controls.Add(Me.lblPPN)
        Me.PanelOrders.Controls.Add(Me.lblTotalPrice)
        Me.PanelOrders.Controls.Add(Me.lblTotalQty)
        Me.PanelOrders.Controls.Add(Me.btnBack)
        Me.PanelOrders.Controls.Add(Me.btnAdd)
        Me.PanelOrders.Controls.Add(Me.lblGrandTotal)
        Me.PanelOrders.Controls.Add(Me.LabelX5)
        Me.PanelOrders.Controls.Add(Me.LabelX4)
        Me.PanelOrders.Controls.Add(Me.LabelX2)
        Me.PanelOrders.Controls.Add(Me.btnCart)
        Me.PanelOrders.Controls.Add(Me.txtQty)
        Me.PanelOrders.Controls.Add(Me.txtPrice)
        Me.PanelOrders.Controls.Add(Me.LabelX3)
        Me.PanelOrders.Controls.Add(Me.txtMenu)
        Me.PanelOrders.Controls.Add(Me.txtIdMenu)
        Me.PanelOrders.Controls.Add(Me.DGMenu)
        Me.PanelOrders.Controls.Add(Me.txtCustomer)
        Me.PanelOrders.Controls.Add(Me.cbTable)
        Me.PanelOrders.Location = New System.Drawing.Point(12, 72)
        Me.PanelOrders.Name = "PanelOrders"
        Me.PanelOrders.Size = New System.Drawing.Size(1336, 501)
        Me.PanelOrders.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelOrders.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelOrders.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelOrders.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelOrders.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelOrders.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelOrders.Style.GradientAngle = 90
        Me.PanelOrders.TabIndex = 3
        '
        'lblTerbilang
        '
        Me.lblTerbilang.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.lblTerbilang.BackgroundStyle.Class = ""
        Me.lblTerbilang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTerbilang.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerbilang.ForeColor = System.Drawing.Color.Black
        Me.lblTerbilang.Location = New System.Drawing.Point(927, 408)
        Me.lblTerbilang.Name = "lblTerbilang"
        Me.lblTerbilang.Size = New System.Drawing.Size(395, 38)
        Me.lblTerbilang.TabIndex = 24
        Me.lblTerbilang.Text = "-"
        Me.lblTerbilang.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnDel
        '
        Me.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.Location = New System.Drawing.Point(881, 148)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(40, 339)
        Me.btnDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDel.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(124, 98)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 44)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 5
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtCategory.Border.Class = "TextBoxBorder"
        Me.txtCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(170, 98)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(174, 44)
        Me.txtCategory.TabIndex = 6
        Me.txtCategory.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.WatermarkText = "Category"
        '
        'lblPPN
        '
        '
        '
        '
        Me.lblPPN.BackgroundStyle.Class = ""
        Me.lblPPN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPPN.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPN.Location = New System.Drawing.Point(1087, 304)
        Me.lblPPN.Name = "lblPPN"
        Me.lblPPN.Size = New System.Drawing.Size(235, 32)
        Me.lblPPN.TabIndex = 23
        Me.lblPPN.Text = "0"
        Me.lblPPN.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTotalPrice
        '
        '
        '
        '
        Me.lblTotalPrice.BackgroundStyle.Class = ""
        Me.lblTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalPrice.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(1087, 266)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(235, 32)
        Me.lblTotalPrice.TabIndex = 22
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTotalQty
        '
        '
        '
        '
        Me.lblTotalQty.BackgroundStyle.Class = ""
        Me.lblTotalQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalQty.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.Location = New System.Drawing.Point(1155, 228)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(167, 32)
        Me.lblTotalQty.TabIndex = 21
        Me.lblTotalQty.Text = "0"
        Me.lblTotalQty.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1227, 452)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "&Back"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(927, 452)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(193, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "&Add"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Red
        '
        '
        '
        Me.lblGrandTotal.BackgroundStyle.Class = ""
        Me.lblGrandTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGrandTotal.Font = New System.Drawing.Font("Unispace", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.White
        Me.lblGrandTotal.Location = New System.Drawing.Point(927, 342)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(395, 60)
        Me.lblGrandTotal.TabIndex = 18
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(927, 304)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(167, 32)
        Me.LabelX5.TabIndex = 17
        Me.LabelX5.Text = "PPN (10%)"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(927, 266)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(167, 32)
        Me.LabelX4.TabIndex = 16
        Me.LabelX4.Text = "Total Price"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(927, 228)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(167, 32)
        Me.LabelX2.TabIndex = 15
        Me.LabelX2.Text = "Total Qty"
        '
        'btnCart
        '
        Me.btnCart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.Image = CType(resources.GetObject("btnCart.Image"), System.Drawing.Image)
        Me.btnCart.Location = New System.Drawing.Point(881, 98)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(40, 44)
        Me.btnCart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCart.TabIndex = 10
        '
        'txtQty
        '
        '
        '
        '
        Me.txtQty.Border.Class = "TextBoxBorder"
        Me.txtQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtQty.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(807, 98)
        Me.txtQty.MaxLength = 3
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(68, 44)
        Me.txtQty.TabIndex = 9
        Me.txtQty.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.WatermarkText = "Qty"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtPrice.Border.Class = "TextBoxBorder"
        Me.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(675, 98)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(126, 44)
        Me.txtPrice.TabIndex = 8
        Me.txtPrice.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.WatermarkText = "Price"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.SystemColors.Highlight
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.White
        Me.LabelX3.Location = New System.Drawing.Point(0, 63)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(1336, 24)
        Me.LabelX3.TabIndex = 11
        Me.LabelX3.Text = "List Menu"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtMenu
        '
        Me.txtMenu.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtMenu.Border.Class = "TextBoxBorder"
        Me.txtMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenu.Enabled = False
        Me.txtMenu.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.Location = New System.Drawing.Point(350, 98)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(319, 44)
        Me.txtMenu.TabIndex = 7
        Me.txtMenu.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.WatermarkText = "Menu Name"
        '
        'txtIdMenu
        '
        '
        '
        '
        Me.txtIdMenu.Border.Class = "TextBoxBorder"
        Me.txtIdMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdMenu.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMenu.Location = New System.Drawing.Point(17, 98)
        Me.txtIdMenu.MaxLength = 5
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(119, 44)
        Me.txtIdMenu.TabIndex = 4
        Me.txtIdMenu.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMenu.WatermarkText = "ID Menu"
        '
        'DGMenu
        '
        Me.DGMenu.AllowUserToDeleteRows = False
        Me.DGMenu.AllowUserToResizeColumns = False
        Me.DGMenu.AllowUserToResizeRows = False
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_menu, Me.category, Me.menu, Me.price_menu, Me.qty_menu, Me.total_menu})
        Me.DGMenu.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMenu.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGMenu.Location = New System.Drawing.Point(17, 148)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGMenu.Size = New System.Drawing.Size(865, 339)
        Me.DGMenu.TabIndex = 11
        '
        'id_menu
        '
        Me.id_menu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id_menu.HeaderText = "ID MENU"
        Me.id_menu.MaxInputLength = 10
        Me.id_menu.Name = "id_menu"
        Me.id_menu.ReadOnly = True
        Me.id_menu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'category
        '
        Me.category.HeaderText = "CATEGORY"
        Me.category.MaxInputLength = 20
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.category.Width = 120
        '
        'menu
        '
        Me.menu.HeaderText = "MENU NAME"
        Me.menu.MaxInputLength = 30
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        Me.menu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.menu.Width = 350
        '
        'price_menu
        '
        Me.price_menu.HeaderText = "PRICE"
        Me.price_menu.MaxInputLength = 11
        Me.price_menu.Name = "price_menu"
        Me.price_menu.ReadOnly = True
        Me.price_menu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'qty_menu
        '
        Me.qty_menu.HeaderText = "QTY"
        Me.qty_menu.MaxInputLength = 11
        Me.qty_menu.Name = "qty_menu"
        Me.qty_menu.ReadOnly = True
        Me.qty_menu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.qty_menu.Width = 50
        '
        'total_menu
        '
        Me.total_menu.HeaderText = "TOTAL"
        Me.total_menu.MaxInputLength = 11
        Me.total_menu.Name = "total_menu"
        Me.total_menu.ReadOnly = True
        Me.total_menu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtCustomer
        '
        '
        '
        '
        Me.txtCustomer.Border.Class = "TextBoxBorder"
        Me.txtCustomer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomer.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(130, 10)
        Me.txtCustomer.MaxLength = 30
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(1185, 44)
        Me.txtCustomer.TabIndex = 3
        Me.txtCustomer.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.WatermarkText = "Customer Name (Optional)"
        '
        'cbTable
        '
        Me.cbTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbTable.DisplayMember = "Text"
        Me.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTable.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTable.FormattingEnabled = True
        Me.cbTable.ItemHeight = 38
        Me.cbTable.Location = New System.Drawing.Point(17, 10)
        Me.cbTable.MaxLength = 20
        Me.cbTable.Name = "cbTable"
        Me.cbTable.Size = New System.Drawing.Size(107, 44)
        Me.cbTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbTable.TabIndex = 2
        Me.cbTable.WatermarkFont = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTable.WatermarkText = "Table"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1126, 452)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 35)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "&Edit"
        '
        'frmTransactionOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.PanelOrders)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransactionOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Orders"
        Me.PanelOrders.ResumeLayout(False)
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelOrders As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cbTable As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtCustomer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DGMenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMenu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdMenu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCart As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPrice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblGrandTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCategory As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPPN As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalPrice As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalQty As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents id_menu As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents price_menu As DataGridViewTextBoxColumn
    Friend WithEvents qty_menu As DataGridViewTextBoxColumn
    Friend WithEvents total_menu As DataGridViewTextBoxColumn
    Friend WithEvents lblTerbilang As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
End Class
