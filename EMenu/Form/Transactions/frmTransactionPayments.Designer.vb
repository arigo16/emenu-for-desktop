<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactionPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DGOrder = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lblGrandTotal = New DevComponents.DotNetBar.LabelX()
        Me.txtCash = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblChangemoney = New DevComponents.DotNetBar.LabelX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.DGMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.label44 = New DevComponents.DotNetBar.LabelX()
        Me.lbl45 = New DevComponents.DotNetBar.LabelX()
        Me.lblIdOrder = New DevComponents.DotNetBar.LabelX()
        Me.lblTime = New DevComponents.DotNetBar.LabelX()
        Me.lblTable = New DevComponents.DotNetBar.LabelX()
        Me.lblCustomer = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalQty = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalPrice = New DevComponents.DotNetBar.LabelX()
        Me.lblPPN = New DevComponents.DotNetBar.LabelX()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Transaction Payment"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'DGOrder
        '
        Me.DGOrder.AllowUserToAddRows = False
        Me.DGOrder.AllowUserToDeleteRows = False
        Me.DGOrder.AllowUserToResizeColumns = False
        Me.DGOrder.AllowUserToResizeRows = False
        Me.DGOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGOrder.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGOrder.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGOrder.Location = New System.Drawing.Point(12, 72)
        Me.DGOrder.Name = "DGOrder"
        Me.DGOrder.ReadOnly = True
        Me.DGOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGOrder.Size = New System.Drawing.Size(548, 501)
        Me.DGOrder.TabIndex = 1
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Red
        '
        '
        '
        Me.lblGrandTotal.BackgroundStyle.Class = ""
        Me.lblGrandTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGrandTotal.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.White
        Me.lblGrandTotal.Location = New System.Drawing.Point(1045, 386)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(303, 44)
        Me.lblGrandTotal.TabIndex = 19
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtCash
        '
        '
        '
        '
        Me.txtCash.Border.Class = "TextBoxBorder"
        Me.txtCash.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCash.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(1045, 436)
        Me.txtCash.MaxLength = 11
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(303, 46)
        Me.txtCash.TabIndex = 3
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCash.WatermarkFont = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.WatermarkText = "Cash"
        '
        'lblChangemoney
        '
        Me.lblChangemoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.lblChangemoney.BackgroundStyle.Class = ""
        Me.lblChangemoney.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblChangemoney.Font = New System.Drawing.Font("Unispace", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangemoney.ForeColor = System.Drawing.Color.White
        Me.lblChangemoney.Location = New System.Drawing.Point(1045, 488)
        Me.lblChangemoney.Name = "lblChangemoney"
        Me.lblChangemoney.Size = New System.Drawing.Size(303, 44)
        Me.lblChangemoney.TabIndex = 21
        Me.lblChangemoney.Text = "0"
        Me.lblChangemoney.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1045, 538)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(202, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1253, 538)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&Back"
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
        Me.DGMenu.Location = New System.Drawing.Point(566, 72)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.ReadOnly = True
        Me.DGMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGMenu.Size = New System.Drawing.Size(473, 501)
        Me.DGMenu.TabIndex = 2
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(1045, 72)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(98, 32)
        Me.LabelX3.TabIndex = 25
        Me.LabelX3.Text = "ID Order"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(1045, 110)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(98, 32)
        Me.LabelX4.TabIndex = 26
        Me.LabelX4.Text = "Datetime"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(1045, 148)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(98, 32)
        Me.LabelX5.TabIndex = 27
        Me.LabelX5.Text = "Table"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(1045, 186)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(98, 32)
        Me.LabelX6.TabIndex = 28
        Me.LabelX6.Text = "Customer"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(1045, 272)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(98, 32)
        Me.LabelX7.TabIndex = 29
        Me.LabelX7.Text = "Total Qty"
        '
        'label44
        '
        '
        '
        '
        Me.label44.BackgroundStyle.Class = ""
        Me.label44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.label44.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label44.Location = New System.Drawing.Point(1045, 310)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(98, 32)
        Me.label44.TabIndex = 30
        Me.label44.Text = "Total Price"
        '
        'lbl45
        '
        '
        '
        '
        Me.lbl45.BackgroundStyle.Class = ""
        Me.lbl45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl45.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl45.Location = New System.Drawing.Point(1045, 348)
        Me.lbl45.Name = "lbl45"
        Me.lbl45.Size = New System.Drawing.Size(98, 32)
        Me.lbl45.TabIndex = 31
        Me.lbl45.Text = "PPN"
        '
        'lblIdOrder
        '
        '
        '
        '
        Me.lblIdOrder.BackgroundStyle.Class = ""
        Me.lblIdOrder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIdOrder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdOrder.Location = New System.Drawing.Point(1149, 72)
        Me.lblIdOrder.Name = "lblIdOrder"
        Me.lblIdOrder.Size = New System.Drawing.Size(199, 32)
        Me.lblIdOrder.TabIndex = 32
        Me.lblIdOrder.Text = "-"
        Me.lblIdOrder.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTime
        '
        '
        '
        '
        Me.lblTime.BackgroundStyle.Class = ""
        Me.lblTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1149, 110)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(199, 32)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "-"
        Me.lblTime.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTable
        '
        '
        '
        '
        Me.lblTable.BackgroundStyle.Class = ""
        Me.lblTable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTable.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(1149, 148)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(199, 32)
        Me.lblTable.TabIndex = 34
        Me.lblTable.Text = "-"
        Me.lblTable.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblCustomer
        '
        '
        '
        '
        Me.lblCustomer.BackgroundStyle.Class = ""
        Me.lblCustomer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(1149, 186)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(199, 32)
        Me.lblCustomer.TabIndex = 35
        Me.lblCustomer.Text = "-"
        Me.lblCustomer.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTotalQty
        '
        '
        '
        '
        Me.lblTotalQty.BackgroundStyle.Class = ""
        Me.lblTotalQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalQty.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.Location = New System.Drawing.Point(1149, 272)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(199, 32)
        Me.lblTotalQty.TabIndex = 36
        Me.lblTotalQty.Text = "0"
        Me.lblTotalQty.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTotalPrice
        '
        '
        '
        '
        Me.lblTotalPrice.BackgroundStyle.Class = ""
        Me.lblTotalPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalPrice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(1149, 310)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(199, 32)
        Me.lblTotalPrice.TabIndex = 37
        Me.lblTotalPrice.Text = "0"
        Me.lblTotalPrice.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblPPN
        '
        '
        '
        '
        Me.lblPPN.BackgroundStyle.Class = ""
        Me.lblPPN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPPN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPN.Location = New System.Drawing.Point(1149, 348)
        Me.lblPPN.Name = "lblPPN"
        Me.lblPPN.Size = New System.Drawing.Size(199, 32)
        Me.lblPPN.TabIndex = 38
        Me.lblPPN.Text = "0"
        Me.lblPPN.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'frmTransactionPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.lblPPN)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotalQty)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblIdOrder)
        Me.Controls.Add(Me.lbl45)
        Me.Controls.Add(Me.label44)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.DGMenu)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblChangemoney)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.DGOrder)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransactionPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Order"
        CType(Me.DGOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DGOrder As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lblGrandTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCash As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblChangemoney As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGMenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents label44 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl45 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIdOrder As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTime As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTable As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCustomer As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalQty As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalPrice As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPPN As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer As Timer
End Class
