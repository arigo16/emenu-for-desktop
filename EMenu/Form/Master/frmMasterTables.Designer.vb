<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterTables
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
        Me.txtQuota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCapacity = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalTable = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DGTable = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.btnBack = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelTables.SuspendLayout()
        CType(Me.DGTable, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelX1.Text = "Master Tables"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelTables
        '
        Me.PanelTables.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelTables.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelTables.Controls.Add(Me.txtQuota)
        Me.PanelTables.Controls.Add(Me.txtNo)
        Me.PanelTables.Controls.Add(Me.lblCapacity)
        Me.PanelTables.Controls.Add(Me.lblTotalTable)
        Me.PanelTables.Controls.Add(Me.LabelX5)
        Me.PanelTables.Controls.Add(Me.LabelX4)
        Me.PanelTables.Controls.Add(Me.DGTable)
        Me.PanelTables.Controls.Add(Me.btnBack)
        Me.PanelTables.Controls.Add(Me.btnDelete)
        Me.PanelTables.Controls.Add(Me.btnEdit)
        Me.PanelTables.Controls.Add(Me.btnAdd)
        Me.PanelTables.Controls.Add(Me.LabelX3)
        Me.PanelTables.Controls.Add(Me.LabelX2)
        Me.PanelTables.Location = New System.Drawing.Point(509, 140)
        Me.PanelTables.Name = "PanelTables"
        Me.PanelTables.Size = New System.Drawing.Size(342, 381)
        Me.PanelTables.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelTables.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelTables.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelTables.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelTables.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelTables.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelTables.Style.GradientAngle = 90
        Me.PanelTables.TabIndex = 2
        '
        'txtQuota
        '
        '
        '
        '
        Me.txtQuota.Border.Class = "TextBoxBorder"
        Me.txtQuota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtQuota.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuota.Location = New System.Drawing.Point(214, 43)
        Me.txtQuota.MaxLength = 2
        Me.txtQuota.Name = "txtQuota"
        Me.txtQuota.Size = New System.Drawing.Size(55, 29)
        Me.txtQuota.TabIndex = 2
        '
        'txtNo
        '
        '
        '
        '
        Me.txtNo.Border.Class = "TextBoxBorder"
        Me.txtNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo.Location = New System.Drawing.Point(214, 8)
        Me.txtNo.MaxLength = 2
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(55, 29)
        Me.txtNo.TabIndex = 1
        '
        'lblCapacity
        '
        '
        '
        '
        Me.lblCapacity.BackgroundStyle.Class = ""
        Me.lblCapacity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCapacity.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Location = New System.Drawing.Point(255, 348)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(75, 23)
        Me.lblCapacity.TabIndex = 19
        Me.lblCapacity.Text = "00"
        Me.lblCapacity.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTotalTable
        '
        '
        '
        '
        Me.lblTotalTable.BackgroundStyle.Class = ""
        Me.lblTotalTable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalTable.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTable.Location = New System.Drawing.Point(255, 319)
        Me.lblTotalTable.Name = "lblTotalTable"
        Me.lblTotalTable.Size = New System.Drawing.Size(75, 23)
        Me.lblTotalTable.TabIndex = 18
        Me.lblTotalTable.Text = "00"
        Me.lblTotalTable.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 348)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(150, 23)
        Me.LabelX5.TabIndex = 18
        Me.LabelX5.Text = "Total Capacity"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 319)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(150, 23)
        Me.LabelX4.TabIndex = 17
        Me.LabelX4.Text = "Total Table"
        '
        'DGTable
        '
        Me.DGTable.AllowUserToAddRows = False
        Me.DGTable.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGTable.Location = New System.Drawing.Point(12, 128)
        Me.DGTable.Name = "DGTable"
        Me.DGTable.ReadOnly = True
        Me.DGTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGTable.Size = New System.Drawing.Size(318, 185)
        Me.DGTable.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(255, 87)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 35)
        Me.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(174, 87)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(93, 87)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 35)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "&Edit"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 3
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
        Me.LabelX3.Location = New System.Drawing.Point(58, 45)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(150, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Quota"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(58, 10)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(150, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "No Table"
        '
        'frmMasterTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.PanelTables)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasterTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Tables"
        Me.PanelTables.ResumeLayout(False)
        CType(Me.DGTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelTables As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBack As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGTable As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lblCapacity As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalTable As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtQuota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
