Imports MySql.Data.MySqlClient

Public Class frmTransactionPayments
    Private id_order, id_payment_auto, no_table As String
    Private total_qty, total_price, ppn, grandtotal, cash, changemoney As Long

    Sub autonumber()
        Call connectdb()
        cmd = New MySqlCommand("SELECT id_payment FROM payments WHERE id_payment IN(SELECT MAX(id_payment)FROM payments)", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "PYM" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                urutan = "PYM" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 2) + 1
                urutan = "PYM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        id_payment_auto = urutan
        closerd()
    End Sub

    Sub billPayments()
        Dim billPayments As New billPayments
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.SelectionFormula = "{payments1.id_payment} ='" & id_payment_auto & "'"
        frmViewRpt.ViewReport.ReportSource = billPayments
        frmViewRpt.ViewReport.RefreshReport()
        frmViewRpt.ViewReport.Refresh()
        frmViewRpt.Text = "Bill" + id_payment_auto
        frmViewRpt.Show()
    End Sub

    Sub showGridOrder()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT id_order, no_table, customer, grandtotal, username FROM orders WHERE status_order='1' ORDER BY id_order DESC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "orders")
        DGOrder.DataSource = ds.Tables("orders")
    End Sub

    Sub showGridMenu()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT menus.category, menus.menu, ordersdetails.qty, ordersdetails.price_order FROM menus INNER JOIN (orders INNER JOIN ordersdetails ON orders.id_order = ordersdetails.id_order) ON menus.id_menu = ordersdetails.id_menu WHERE ordersdetails.id_order='" & id_order & "' ORDER BY menus.category ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "ordersdetails")
        DGMenu.DataSource = ds.Tables("ordersdetails")
    End Sub

    Sub sizeGridOrder()
        DGOrder.Columns(0).Width = 120
        DGOrder.Columns(1).Width = 40
        DGOrder.Columns(2).Width = 150
        DGOrder.Columns(3).Width = 100
        DGOrder.Columns(4).Width = 90
        DGOrder.Columns(0).Resizable = DataGridViewTriState.False
        DGOrder.Columns(1).Resizable = DataGridViewTriState.False
        DGOrder.Columns(2).Resizable = DataGridViewTriState.False
        DGOrder.Columns(3).Resizable = DataGridViewTriState.False
        DGOrder.Columns(4).Resizable = DataGridViewTriState.False
        DGOrder.Columns(0).HeaderText = "ID Order"
        DGOrder.Columns(1).HeaderText = "Table"
        DGOrder.Columns(2).HeaderText = "Customer"
        DGOrder.Columns(3).HeaderText = "Grandtotal"
        DGOrder.Columns(4).HeaderText = "Waiter"
    End Sub

    Sub sizeGridMenu()
        DGMenu.Columns(0).Width = 100
        DGMenu.Columns(1).Width = 200
        DGMenu.Columns(2).Width = 30
        DGMenu.Columns(3).Width = 100
        DGMenu.Columns(0).Resizable = DataGridViewTriState.False
        DGMenu.Columns(1).Resizable = DataGridViewTriState.False
        DGMenu.Columns(2).Resizable = DataGridViewTriState.False
        DGMenu.Columns(3).Resizable = DataGridViewTriState.False
        DGMenu.Columns(0).HeaderText = "Category"
        DGMenu.Columns(1).HeaderText = "Menu"
        DGMenu.Columns(2).HeaderText = "Qty"
        DGMenu.Columns(3).HeaderText = "Price"
    End Sub

    Sub getDataOrder()
        Call connectdb()
        Dim str As String
        str = "SELECT * FROM orders WHERE id_order='" & id_order & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lblIdOrder.Text = rd.Item("id_order")
            lblTime.Text = Format(rd.Item("date_order"), "dd/MM/yyyy HH:mm:ss")
            no_table = rd.Item("no_table")
            lblTable.Text = rd.Item("no_table")
            If (rd.Item("customer") = "") Then
                lblCustomer.Text = "Anonymous"
            Else
                lblCustomer.Text = rd.Item("customer")
            End If
            total_qty = rd.Item("total_qty")
            total_price = rd.Item("total_price")
            ppn = rd.Item("ppn")
            grandtotal = rd.Item("grandtotal")

            lblTotalQty.Text = Format(Val(total_qty), "###,###")
            lblTotalPrice.Text = Format(Val(total_price), "###,###")
            lblPPN.Text = Format(Val(ppn), "###,###")
            lblGrandTotal.Text = Format(Val(grandtotal), "###,###")
            closerd()
        End If
    End Sub


    Sub clearText()
        txtCash.Text = ""
        lblIdOrder.Text = "-"
        lblTime.Text = "-"
        lblTable.Text = "-"
        lblCustomer.Text = "-"
        lblTotalQty.Text = "0"
        lblTotalPrice.Text = "0"
        lblPPN.Text = "0"
        lblGrandTotal.Text = "0"
        lblChangemoney.Text = "0"
        DGMenu.DataSource = Nothing
    End Sub

    Sub savepayment()
        If lblGrandTotal.Text = "0" Then
            MsgBoxError("Choose data")
        ElseIf (grandtotal > cash) Then
            MsgBoxError("Money not enough")
        Else
            Call autonumber()
            Call connectdb()
            Try
                Dim str As String
                str = "INSERT INTO payments VALUES ('" & id_payment_auto & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '" & lblIdOrder.Text & "', '" & cash & "', '" & changemoney & "', '" & frmMainMenu.lblUsername.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                closecmd()

                str = "UPDATE tables SET status='0' WHERE no_table='" & no_table & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()

                str = "UPDATE ordersdetails SET status='0' WHERE id_order='" & lblIdOrder.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()

                MsgBoxInformation("Data payment has been saved")
                Call atStart()
                Call billPayments()
            Catch ex As Exception
                MsgBoxError("Data payment hasn't been saved")
                Call atStart()
            End Try
        End If
    End Sub

    Sub enabledObj()
        DGOrder.Enabled = True
        DGMenu.Enabled = True
        txtCash.Enabled = True
    End Sub

    Sub disabledObj()
        DGOrder.Enabled = False
        DGMenu.Enabled = False
        txtCash.Enabled = False
    End Sub

    Sub atStart()
        btnAdd.Text = "&Add"
        btnBack.Text = "&Back"
        btnAdd.Enabled = True
        btnBack.Enabled = True
        Call showGridOrder()
        Call sizeGridOrder()
        Call disabledObj()
        btnBack.Focus()
        Call clearText()
    End Sub

    Private Sub DGMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellContentClick

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Call showGridOrder()
        Call sizeGridOrder()
    End Sub

    Sub clickAdd()
        btnAdd.Text = "&Pay"
        btnBack.Text = "&Cancel"
        Call enabledObj()
        DGOrder.Focus()
        Call clearText()
    End Sub

    Private Sub frmTransactionPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atStart()
        DGOrder.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "&Add") Then
            Call clickAdd()
            txtCash.Enabled = False
            DGOrder.Focus()
        Else
            savepayment()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            frmMainMenu.Wallpaper.Visible = True
        ElseIf btnBack.Text = "&Cancel" Then
            Call atStart()
        End If
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        If txtCash.Text = "" Or Not IsNumeric(txtCash.Text) Then
            Exit Sub
        End If

        cash = txtCash.Text
        txtCash.Text = Format(Val(cash), "###,###")
        txtCash.SelectionStart = Len(txtCash.Text)

        changemoney = cash - grandtotal
        If (changemoney = "0") Then
            lblChangemoney.Text = "0"
        Else
            lblChangemoney.Text = Format(Val(changemoney), "###,###")
        End If
    End Sub

    Private Sub DGOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrder.CellContentClick
        Try
            Dim i As Integer
            i = Me.DGOrder.CurrentRow.Index
            With DGOrder.Rows.Item(i)
                id_order = .Cells(0).Value
                Call showGridMenu()
                Call sizeGridMenu()
                Call getDataOrder()
                txtCash.Enabled = True
                txtCash.Focus()
            End With
        Catch ex As Exception
            MsgBoxWarning("Data orders empty")
        End Try
    End Sub

    Private Sub DGOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrder.CellClick
        Try
            Dim i As Integer
            i = Me.DGOrder.CurrentRow.Index
            With DGOrder.Rows.Item(i)
                id_order = .Cells(0).Value
                Call showGridMenu()
                Call sizeGridMenu()
                Call getDataOrder()
                txtCash.Enabled = True
                txtCash.Focus()
            End With
        Catch ex As Exception
            MsgBoxWarning("Data orders empty")
        End Try
    End Sub

    Private Sub DGOrder_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrder.CellContentDoubleClick
        Try
            Dim i As Integer
            i = Me.DGOrder.CurrentRow.Index
            With DGOrder.Rows.Item(i)
                id_order = .Cells(0).Value
                Call showGridMenu()
                Call sizeGridMenu()
                Call getDataOrder()
                txtCash.Enabled = True
                txtCash.Focus()
            End With
        Catch ex As Exception
            MsgBoxWarning("Data orders empty")
        End Try
    End Sub

    Private Sub DGOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOrder.CellDoubleClick
        Try
            Dim i As Integer
            i = Me.DGOrder.CurrentRow.Index
            With DGOrder.Rows.Item(i)
                id_order = .Cells(0).Value
                Call showGridMenu()
                Call sizeGridMenu()
                Call getDataOrder()
                txtCash.Enabled = True
                txtCash.Focus()
            End With
        Catch ex As Exception
            MsgBoxWarning("Data orders empty")
        End Try
    End Sub
End Class