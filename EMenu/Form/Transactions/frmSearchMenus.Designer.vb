<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchMenus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchMenus))
        Me.cbSearch = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DGMenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSearch
        '
        Me.cbSearch.DisplayMember = "Text"
        Me.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.ItemHeight = 34
        Me.cbSearch.Location = New System.Drawing.Point(122, 12)
        Me.cbSearch.MaxLength = 20
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(214, 40)
        Me.cbSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbSearch.TabIndex = 1
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(12, 15)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(104, 37)
        Me.LabelX9.TabIndex = 26
        Me.LabelX9.Text = "Filter by"
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(342, 12)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(341, 40)
        Me.txtSearch.TabIndex = 2
        '
        'DGMenu
        '
        Me.DGMenu.AllowUserToAddRows = False
        Me.DGMenu.AllowUserToDeleteRows = False
        Me.DGMenu.AllowUserToResizeColumns = False
        Me.DGMenu.AllowUserToResizeRows = False
        Me.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMenu.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMenu.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGMenu.Location = New System.Drawing.Point(12, 58)
        Me.DGMenu.Name = "DGMenu"
        Me.DGMenu.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGMenu.Size = New System.Drawing.Size(671, 392)
        Me.DGMenu.TabIndex = 3
        '
        'frmSearchMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 464)
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DGMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchMenus"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Menus"
        Me.TopMost = True
        CType(Me.DGMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbSearch As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DGMenu As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
