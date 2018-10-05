Imports MySql.Data.MySqlClient

Public Class frmReportOrders
    Sub fillcategory()
        Call connectdb()
        Dim str As String
        str = "SELECT category FROM categories WHERE isActive='1' ORDER BY category ASC"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cbCategory.Items.Add(rd("category"))
            Loop
        Else
        End If
        closerd()
    End Sub

    Private Sub frmReportOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFromPeriodDoc.Value = Date.Now.AddDays(-30)
        dtToPeriodDoc.Value = Date.Now.AddDays(1)
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
        dtFromMenuDoc.Value = Date.Now.AddDays(-30)
        dtToMenuDoc.Value = Date.Now.AddDays(1)
        dtToMenuDoc.MinDate = dtFromMenuDoc.Value
        Call fillcategory()
    End Sub

    Private Sub dtFromPeriodDoc_ValueChanged(sender As Object, e As EventArgs) Handles dtFromPeriodDoc.ValueChanged
        dtToPeriodDoc.MinDate = dtFromPeriodDoc.Value
    End Sub

    Private Sub dtFromMenuDoc_ValueChanged(sender As Object, e As EventArgs) Handles dtFromMenuDoc.ValueChanged
        dtToMenuDoc.MinDate = dtFromMenuDoc.Value
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearchMenus.Show()
        frmMainMenu.Enabled = False
    End Sub

    Private Sub btnViewPeriodeGraph_Click(sender As Object, e As EventArgs) Handles btnViewPeriodeGraph.Click
        Dim lapOrdersGraph As New lapOrdersGraph
        frmViewRpt.ViewReport.RefreshReport()
        lapOrdersGraph.SetParameterValue("from", dtFromPeriodDoc.Value)
        lapOrdersGraph.SetParameterValue("to", dtToPeriodDoc.Value)
        lapOrdersGraph.SetParameterValue("filter", "No Filter (All data)")
        lapOrdersGraph.SetParameterValue("title", "Graphic Report Orders based on Period")
        frmViewRpt.ViewReport.ReportSource = lapOrdersGraph
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "Graphic Report Orders based on Period"
        frmViewRpt.Show()
    End Sub

    Private Sub btnViewPeriodDoc_Click(sender As Object, e As EventArgs) Handles btnViewPeriodDoc.Click
        Dim lapOrders As New lapOrders
        frmViewRpt.ViewReport.RefreshReport()
        lapOrders.SetParameterValue("from", dtFromPeriodDoc.Value)
        lapOrders.SetParameterValue("to", dtToPeriodDoc.Value)
        lapOrders.SetParameterValue("filter", "No Filter (All data)")
        lapOrders.SetParameterValue("title", "List Report Orders based on Period")
        frmViewRpt.ViewReport.ReportSource = lapOrders
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "List Report Orders based on Period"
        frmViewRpt.Show()
    End Sub

    Private Sub btnViewCatGraph_Click(sender As Object, e As EventArgs) Handles btnViewCatGraph.Click
        If cbCategory.Text = "" Then
            MsgBoxError("Choose category")
            cbCategory.Focus()
        Else
            Dim lapOrdersGraph As New lapOrdersGraph
            frmViewRpt.ViewReport.RefreshReport()
            lapOrdersGraph.SetParameterValue("from", dtFromMenuDoc.Value)
            lapOrdersGraph.SetParameterValue("to", dtToMenuDoc.Value)
            lapOrdersGraph.SetParameterValue("filter", "Category")
            lapOrdersGraph.SetParameterValue("title", "Graphic Report Orders based on Period and Category")
            frmViewRpt.ViewReport.SelectionFormula = "{menus1.category} ='" & cbCategory.Text & "' AND {orders1.date_order} in DateTime ({?from}) to DateTime ({?to})"
            frmViewRpt.ViewReport.ReportSource = lapOrdersGraph
            frmViewRpt.ViewReport.Refresh()
            frmViewRpt.Text = "Graphic Report Orders based on Period and Category"
            frmViewRpt.Show()
        End If
    End Sub

    Private Sub btnViewCatDoc_Click(sender As Object, e As EventArgs) Handles btnViewCatDoc.Click
        If cbCategory.Text = "" Then
            MsgBoxError("Choose category")
            cbCategory.Focus()
        Else
            Dim lapOrders As New lapOrders
            frmViewRpt.ViewReport.RefreshReport()
            lapOrders.SetParameterValue("from", dtFromMenuDoc.Value)
            lapOrders.SetParameterValue("to", dtToMenuDoc.Value)
            lapOrders.SetParameterValue("filter", "Category")
            lapOrders.SetParameterValue("title", "List Report Orders based on Period and Category")
            frmViewRpt.ViewReport.SelectionFormula = "{menus1.category} ='" & cbCategory.Text & "' AND {orders1.date_order} in DateTime ({?from}) to DateTime ({?to})"
            frmViewRpt.ViewReport.ReportSource = lapOrders
            frmViewRpt.ViewReport.Refresh()
            frmViewRpt.Text = "List Report Orders based on Period and Category"
            frmViewRpt.Show()
        End If
    End Sub

    Private Sub btnViewMenuGraph_Click(sender As Object, e As EventArgs) Handles btnViewMenuGraph.Click
        If txtMenu.Text = "" Then
            MsgBoxError("Fill menu")
        Else
            Dim lapOrdersGraphMenu As New lapOrdersGraphMenu
            frmViewRpt.ViewReport.RefreshReport()
            lapOrdersGraphMenu.SetParameterValue("from", dtFromMenuDoc.Value)
            lapOrdersGraphMenu.SetParameterValue("to", dtToMenuDoc.Value)
            lapOrdersGraphMenu.SetParameterValue("filter", "Menu")
            lapOrdersGraphMenu.SetParameterValue("title", "Graphic Report Orders based on Period and Menu")
            frmViewRpt.ViewReport.SelectionFormula = "{menus1.id_menu} ='" & txtMenu.Text & "' AND {orders1.date_order} in DateTime ({?from}) to DateTime ({?to})"
            frmViewRpt.ViewReport.ReportSource = lapOrdersGraphMenu
            frmViewRpt.ViewReport.Refresh()
            frmViewRpt.Text = "Graphic Report Orders based on Period and Menu"
            frmViewRpt.Show()
        End If
    End Sub

    Private Sub btnViewMenuDoc_Click(sender As Object, e As EventArgs) Handles btnViewMenuDoc.Click
        If txtMenu.Text = "" Then
            MsgBoxError("Fill menu")
        Else
            Dim lapOrders As New lapOrders
            frmViewRpt.ViewReport.RefreshReport()
            lapOrders.SetParameterValue("from", dtFromMenuDoc.Value)
            lapOrders.SetParameterValue("to", dtToMenuDoc.Value)
            lapOrders.SetParameterValue("filter", "Menu")
            lapOrders.SetParameterValue("title", "List Report Orders based on Period and Menu")
            frmViewRpt.ViewReport.SelectionFormula = "{menus1.id_menu} ='" & txtMenu.Text & "' AND {orders1.date_order} in DateTime ({?from}) to DateTime ({?to})"
            frmViewRpt.ViewReport.ReportSource = lapOrders
            frmViewRpt.ViewReport.Refresh()
            frmViewRpt.Text = "List Report Orders based on Period and Menu"
            frmViewRpt.Show()
        End If
    End Sub

End Class