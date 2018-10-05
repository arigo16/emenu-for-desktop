<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportOrders))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnViewMenuGraph = New DevComponents.DotNetBar.ButtonX()
        Me.btnViewCatGraph = New DevComponents.DotNetBar.ButtonX()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.btnViewCatDoc = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cbCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtMenu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnViewMenuDoc = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dtToMenuDoc = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtFromMenuDoc = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnViewPeriodeGraph = New DevComponents.DotNetBar.ButtonX()
        Me.btnViewPeriodDoc = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtToPeriodDoc = New System.Windows.Forms.DateTimePicker()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dtFromPeriodDoc = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.LabelX1.Text = "Report Order"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.btnViewMenuGraph)
        Me.GroupPanel2.Controls.Add(Me.btnViewCatGraph)
        Me.GroupPanel2.Controls.Add(Me.btnSearch)
        Me.GroupPanel2.Controls.Add(Me.btnViewCatDoc)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.cbCategory)
        Me.GroupPanel2.Controls.Add(Me.txtMenu)
        Me.GroupPanel2.Controls.Add(Me.btnViewMenuDoc)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.dtToMenuDoc)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.dtFromMenuDoc)
        Me.GroupPanel2.Location = New System.Drawing.Point(411, 285)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(562, 254)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 5
        Me.GroupPanel2.Text = "Based on Periode and Menu"
        '
        'btnViewMenuGraph
        '
        Me.btnViewMenuGraph.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewMenuGraph.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewMenuGraph.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewMenuGraph.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMenuGraph.Location = New System.Drawing.Point(357, 184)
        Me.btnViewMenuGraph.Name = "btnViewMenuGraph"
        Me.btnViewMenuGraph.Size = New System.Drawing.Size(84, 35)
        Me.btnViewMenuGraph.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewMenuGraph.TabIndex = 15
        Me.btnViewMenuGraph.Text = "&Graph"
        '
        'btnViewCatGraph
        '
        Me.btnViewCatGraph.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewCatGraph.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewCatGraph.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewCatGraph.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCatGraph.Location = New System.Drawing.Point(143, 184)
        Me.btnViewCatGraph.Name = "btnViewCatGraph"
        Me.btnViewCatGraph.Size = New System.Drawing.Size(84, 35)
        Me.btnViewCatGraph.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewCatGraph.TabIndex = 14
        Me.btnViewCatGraph.Text = "&Graph"
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(491, 149)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 29)
        Me.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSearch.TabIndex = 13
        '
        'btnViewCatDoc
        '
        Me.btnViewCatDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewCatDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewCatDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewCatDoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCatDoc.Location = New System.Drawing.Point(233, 184)
        Me.btnViewCatDoc.Name = "btnViewCatDoc"
        Me.btnViewCatDoc.Size = New System.Drawing.Size(84, 35)
        Me.btnViewCatDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewCatDoc.TabIndex = 8
        Me.btnViewCatDoc.Text = "&View"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(333, 114)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(93, 29)
        Me.LabelX7.TabIndex = 12
        Me.LabelX7.Text = "Menu"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(121, 114)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(93, 29)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Category"
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
        Me.cbCategory.Location = New System.Drawing.Point(121, 149)
        Me.cbCategory.MaxLength = 20
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(196, 29)
        Me.cbCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCategory.TabIndex = 6
        '
        'txtMenu
        '
        '
        '
        '
        Me.txtMenu.Border.Class = "TextBoxBorder"
        Me.txtMenu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMenu.Enabled = False
        Me.txtMenu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.Location = New System.Drawing.Point(333, 149)
        Me.txtMenu.MaxLength = 30
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(198, 29)
        Me.txtMenu.TabIndex = 7
        '
        'btnViewMenuDoc
        '
        Me.btnViewMenuDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewMenuDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewMenuDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewMenuDoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMenuDoc.Location = New System.Drawing.Point(447, 184)
        Me.btnViewMenuDoc.Name = "btnViewMenuDoc"
        Me.btnViewMenuDoc.Size = New System.Drawing.Size(84, 35)
        Me.btnViewMenuDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewMenuDoc.TabIndex = 9
        Me.btnViewMenuDoc.Text = "&View"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(22, 60)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 29)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "To"
        '
        'dtToMenuDoc
        '
        Me.dtToMenuDoc.CustomFormat = "yyyy-MM-dd"
        Me.dtToMenuDoc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToMenuDoc.Location = New System.Drawing.Point(121, 60)
        Me.dtToMenuDoc.Name = "dtToMenuDoc"
        Me.dtToMenuDoc.Size = New System.Drawing.Size(410, 29)
        Me.dtToMenuDoc.TabIndex = 5
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(22, 25)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(93, 29)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "From"
        '
        'dtFromMenuDoc
        '
        Me.dtFromMenuDoc.CustomFormat = "yyyy-MM-dd"
        Me.dtFromMenuDoc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFromMenuDoc.Location = New System.Drawing.Point(121, 25)
        Me.dtFromMenuDoc.Name = "dtFromMenuDoc"
        Me.dtFromMenuDoc.Size = New System.Drawing.Size(410, 29)
        Me.dtFromMenuDoc.TabIndex = 4
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnViewPeriodeGraph)
        Me.GroupPanel1.Controls.Add(Me.btnViewPeriodDoc)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.dtToPeriodDoc)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.dtFromPeriodDoc)
        Me.GroupPanel1.Location = New System.Drawing.Point(411, 112)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(562, 167)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "Based on Periode"
        '
        'btnViewPeriodeGraph
        '
        Me.btnViewPeriodeGraph.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewPeriodeGraph.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewPeriodeGraph.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPeriodeGraph.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPeriodeGraph.Location = New System.Drawing.Point(357, 95)
        Me.btnViewPeriodeGraph.Name = "btnViewPeriodeGraph"
        Me.btnViewPeriodeGraph.Size = New System.Drawing.Size(84, 35)
        Me.btnViewPeriodeGraph.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewPeriodeGraph.TabIndex = 8
        Me.btnViewPeriodeGraph.Text = "&Graph"
        '
        'btnViewPeriodDoc
        '
        Me.btnViewPeriodDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewPeriodDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewPeriodDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPeriodDoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewPeriodDoc.Location = New System.Drawing.Point(447, 95)
        Me.btnViewPeriodDoc.Name = "btnViewPeriodDoc"
        Me.btnViewPeriodDoc.Size = New System.Drawing.Size(84, 35)
        Me.btnViewPeriodDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewPeriodDoc.TabIndex = 3
        Me.btnViewPeriodDoc.Text = "&View"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(22, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(93, 29)
        Me.LabelX2.TabIndex = 7
        Me.LabelX2.Text = "To"
        '
        'dtToPeriodDoc
        '
        Me.dtToPeriodDoc.CustomFormat = "yyyy-MM-dd"
        Me.dtToPeriodDoc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToPeriodDoc.Location = New System.Drawing.Point(121, 60)
        Me.dtToPeriodDoc.Name = "dtToPeriodDoc"
        Me.dtToPeriodDoc.Size = New System.Drawing.Size(410, 29)
        Me.dtToPeriodDoc.TabIndex = 2
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(22, 25)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 29)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "From"
        '
        'dtFromPeriodDoc
        '
        Me.dtFromPeriodDoc.CustomFormat = "yyyy-MM-dd"
        Me.dtFromPeriodDoc.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFromPeriodDoc.Location = New System.Drawing.Point(121, 25)
        Me.dtFromPeriodDoc.Name = "dtFromPeriodDoc"
        Me.dtFromPeriodDoc.Size = New System.Drawing.Size(410, 29)
        Me.dtFromPeriodDoc.TabIndex = 1
        '
        'frmReportOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Order"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnViewMenuGraph As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnViewCatGraph As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnViewCatDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtMenu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnViewMenuDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtToMenuDoc As DateTimePicker
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFromMenuDoc As DateTimePicker
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnViewPeriodeGraph As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnViewPeriodDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtToPeriodDoc As DateTimePicker
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFromPeriodDoc As DateTimePicker
End Class
