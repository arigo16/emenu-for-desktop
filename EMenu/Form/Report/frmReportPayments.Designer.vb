<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportPayments
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtIDPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnViewBill = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
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
        Me.LabelX1.Text = "Report Payment"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtIDPayment)
        Me.GroupPanel2.Controls.Add(Me.btnViewBill)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Location = New System.Drawing.Point(407, 344)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(562, 137)
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
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Bill"
        '
        'txtIDPayment
        '
        '
        '
        '
        Me.txtIDPayment.Border.Class = "TextBoxBorder"
        Me.txtIDPayment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIDPayment.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPayment.Location = New System.Drawing.Point(121, 25)
        Me.txtIDPayment.MaxLength = 12
        Me.txtIDPayment.Name = "txtIDPayment"
        Me.txtIDPayment.Size = New System.Drawing.Size(410, 29)
        Me.txtIDPayment.TabIndex = 7
        '
        'btnViewBill
        '
        Me.btnViewBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewBill.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewBill.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBill.Location = New System.Drawing.Point(447, 60)
        Me.btnViewBill.Name = "btnViewBill"
        Me.btnViewBill.Size = New System.Drawing.Size(84, 35)
        Me.btnViewBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewBill.TabIndex = 9
        Me.btnViewBill.Text = "&View"
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
        Me.LabelX5.Text = "Payment"
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
        Me.GroupPanel1.Location = New System.Drawing.Point(407, 171)
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
        Me.GroupPanel1.TabIndex = 0
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
        'frmReportPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1360, 585)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Payment"
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnViewBill As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnViewPeriodeGraph As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnViewPeriodDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtToPeriodDoc As DateTimePicker
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtFromPeriodDoc As DateTimePicker
    Friend WithEvents txtIDPayment As DevComponents.DotNetBar.Controls.TextBoxX
End Class
