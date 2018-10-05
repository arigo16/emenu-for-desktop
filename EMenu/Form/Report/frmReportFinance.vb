Imports MySql.Data.MySqlClient

Public Class frmReportFinance
    Private Sub btnViewPeriodDoc_Click(sender As Object, e As EventArgs) Handles btnViewPeriodDoc.Click
        Dim lapFinance As New lapFinance
        frmViewRpt.ViewReport.RefreshReport()
        lapFinance.SetParameterValue("from", dtFromPeriodDoc.Value)
        lapFinance.SetParameterValue("to", dtToPeriodDoc.Value)
        lapFinance.SetParameterValue("title", "List Report Income Payment based on Period")
        frmViewRpt.ViewReport.ReportSource = lapFinance
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "List Report Income based on Period"
        frmViewRpt.Show()
    End Sub

    Private Sub dtFromPeriodDoc_ValueChanged(sender As Object, e As EventArgs) Handles dtFromPeriodDoc.ValueChanged
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
    End Sub

    Private Sub frmReportFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFromPeriodDoc.Value = Date.Now.AddDays(-30)
        dtToPeriodDoc.Value = Date.Now.AddDays(1)
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
    End Sub
End Class