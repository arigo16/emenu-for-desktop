Public Class frmReportMasters
    Private Sub btnViewMenus_Click(sender As Object, e As EventArgs) Handles btnViewMenus.Click
        Dim printMenus As New printMenus
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.ReportSource = printMenus
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "List Menus"
        frmViewRpt.Show()
    End Sub
End Class