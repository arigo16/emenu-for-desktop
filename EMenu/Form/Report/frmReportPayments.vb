Imports MySql.Data.MySqlClient

Public Class frmReportPayments
    Private Sub dtFromPeriodDoc_ValueChanged(sender As Object, e As EventArgs) Handles dtFromPeriodDoc.ValueChanged
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
    End Sub
    Private Sub frmReportPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFromPeriodDoc.Value = Date.Now.AddDays(-30)
        dtToPeriodDoc.Value = Date.Now.AddDays(1)
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        frmSearchMenus.Show()
        frmMainMenu.Enabled = False
    End Sub
    Private Sub btnViewPeriodDoc_Click(sender As Object, e As EventArgs) Handles btnViewPeriodDoc.Click
        Dim lapPayments As New lapPayments
        frmViewRpt.ViewReport.RefreshReport()
        lapPayments.SetParameterValue("from", dtFromPeriodDoc.Value)
        lapPayments.SetParameterValue("to", dtToPeriodDoc.Value)
        lapPayments.SetParameterValue("filter", "No Filter (All data)")
        lapPayments.SetParameterValue("title", "List Bill Payment based on Period")
        frmViewRpt.ViewReport.ReportSource = lapPayments
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "List Bill Payment based on Period"
        frmViewRpt.Show()
    End Sub

    Private Sub btnViewPeriodeGraph_Click(sender As Object, e As EventArgs) Handles btnViewPeriodeGraph.Click
        Dim lapPaymentsGraph As New lapPaymentsGraph
        frmViewRpt.ViewReport.RefreshReport()
        lapPaymentsGraph.SetParameterValue("from", dtFromPeriodDoc.Value)
        lapPaymentsGraph.SetParameterValue("to", dtToPeriodDoc.Value)
        lapPaymentsGraph.SetParameterValue("filter", "No Filter (All data)")
        lapPaymentsGraph.SetParameterValue("title", "Graphic Report Income based on Period")
        frmViewRpt.ViewReport.ReportSource = lapPaymentsGraph
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "Graphic Report Income based on Period"
        frmViewRpt.Show()
    End Sub

    Private Sub btnViewBill_Click(sender As Object, e As EventArgs) Handles btnViewBill.Click
        Dim billPayments As New billPayments
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.SelectionFormula = "{payments1.id_payment} ='" & txtIDPayment.Text & "'"
        frmViewRpt.ViewReport.ReportSource = billPayments
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "Bill" + txtIDPayment.Text
        frmViewRpt.Show()
    End Sub
End Class