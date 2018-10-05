<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCategories
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
        Me.PanelTables = New DevComponents.DotNetBar.PanelEx()
        Me.txtCategory = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblTotalCategory = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DGCategory = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.PanelTables.SuspendLayout()
        CType(Me.DGCategory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelX1.Text = "Master Category"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelTables
        '
        Me.PanelTables.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelTables.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelTables.Controls.Add(Me.txtCategory)
        Me.PanelTables.Controls.Add(Me.lblTotalCategory)
        Me.PanelTables.Controls.Add(Me.LabelX4)
        Me.PanelTables.Controls.Add(Me.DGCategory)
        Me.PanelTables.Controls.Add(Me.btnBack)
        Me.PanelTables.Controls.Add(Me.btnDelete)
        Me.PanelTables.Controls.Add(Me.btnEdit)
        Me.PanelTables.Controls.Add(Me.btnAdd)
        Me.PanelTables.Controls.Add(Me.LabelX3)
        Me.PanelTables.Location = New System.Drawing.Point(508, 166)
        Me.PanelTables.Name = "PanelTables"
        Me.PanelTables.Size = New System.Drawing.Size(342, 322)
        Me.PanelTables.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelTables.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelTables.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelTables.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelTables.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelTables.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelTables.Style.GradientAngle = 90
        Me.PanelTables.TabIndex = 3
        '
        'txtCategory
        '
        '
        '
        '
        Me.txtCategory.Border.Class = "TextBoxBorder"
        Me.txtCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(174, 10)
        Me.txtCategory.MaxLength = 20
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(156, 29)
        Me.txtCategory.TabIndex = 1
        '
        'lblTotalCategory
        '
        '
        '
        '
        Me.lblTotalCategory.BackgroundStyle.Class = ""
        Me.lblTotalCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalCategory.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCategory.Location = New System.Drawing.Point(255, 286)
        Me.lblTotalCategory.Name = "lblTotalCategory"
        Me.lblTotalCategory.Size = New System.Drawing.Size(75, 23)
        Me.lblTotalCategory.TabIndex = 18
        Me.lblTotalCategory.Text = "00"
        Me.lblTotalCategory.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 286)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(150, 23)
        Me.LabelX4.TabIndex = 17
        Me.LabelX4.Text = "Total Category"
        '
        'DGCategory
        '
        Me.DGCategory.AllowUserToAddRows = False
        Me.DGCategory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGCategory.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGCategory.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGCategory.Location = New System.Drawing.Point(12, 95)
        Me.DGCategory.Name = "DGCategory"
        Me.DGCategory.ReadOnly = True
        Me.DGCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGCategory.Size = New System.Drawing.Size(318, 185)
        Me.DGCategory.TabIndex = 6
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(255, 54)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&Back"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(174, 54)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(93, 54)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 54)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(18, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(150, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Category"
        '
        'frmMasterCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.PanelTables)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasterCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Categories"
        Me.PanelTables.ResumeLayout(False)
        CType(Me.DGCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelTables As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtCategory As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTotalCategory As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DGCategory As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
