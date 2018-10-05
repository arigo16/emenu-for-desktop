<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRpt
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
        Me.ViewReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ViewReport
        '
        Me.ViewReport.ActiveViewIndex = -1
        Me.ViewReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.ViewReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewReport.Location = New System.Drawing.Point(0, 0)
        Me.ViewReport.Name = "ViewReport"
        Me.ViewReport.ShowCloseButton = False
        Me.ViewReport.ShowGroupTreeButton = False
        Me.ViewReport.ShowLogo = False
        Me.ViewReport.ShowParameterPanelButton = False
        Me.ViewReport.ShowRefreshButton = False
        Me.ViewReport.Size = New System.Drawing.Size(1344, 722)
        Me.ViewReport.TabIndex = 1
        Me.ViewReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmViewRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 722)
        Me.Controls.Add(Me.ViewReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewRpt"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
