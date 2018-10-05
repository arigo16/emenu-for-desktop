Imports MySql.Data.MySqlClient

Public Class frmTransactionOrdersEdit
    Private id_order As String
    Public total_qty, total_price, ppn, grandtotal As Long

    Sub showgrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT orderdetails_edit.id_menu, menus.category, menus.menu, menus.price, orderdetails_edit.qty, orderdetails_edit.price_order FROM menus INNER JOIN orderdetails_edit ON menus.id_menu = orderdetails_edit.id_menu ORDER BY orderdetails_edit.id_order ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "orderdetails_edit")
        DGMenu.DataSource = ds.Tables("orderdetails_edit")
    End Sub
    Sub sizegrid()
        DGMenu.Columns(0).Width = 100
        DGMenu.Columns(1).Width = 120
        DGMenu.Columns(2).Width = 350
        DGMenu.Columns(3).Width = 100
        DGMenu.Columns(4).Width = 50
        DGMenu.Columns(5).Width = 100
        DGMenu.Columns(0).Resizable = DataGridViewTriState.False
        DGMenu.Columns(1).Resizable = DataGridViewTriState.False
        DGMenu.Columns(2).Resizable = DataGridViewTriState.False
        DGMenu.Columns(3).Resizable = DataGridViewTriState.False
        DGMenu.Columns(4).Resizable = DataGridViewTriState.False
        DGMenu.Columns(5).Resizable = DataGridViewTriState.False
        DGMenu.Columns(0).HeaderText = "ID MENU"
        DGMenu.Columns(1).HeaderText = "CATEGORY"
        DGMenu.Columns(2).HeaderText = "MENU NAME"
        DGMenu.Columns(3).HeaderText = "PRICE"
        DGMenu.Columns(4).HeaderText = "QTY"
        DGMenu.Columns(5).HeaderText = "TOTAL"
    End Sub

    Sub fillTable()
        cbTable.Items.Clear()
        Call connectdb()
        Dim str As String
        str = "SELECT no_table FROM tables WHERE status='1' AND isActive='1' ORDER BY no_table ASC"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cbTable.Items.Add(rd("no_table"))
            Loop
        Else
        End If
        closerd()
    End Sub

    Sub ClearText()
        cbTable.SelectedIndex = -1
        txtCustomer.Clear()
        txtIdMenu.Clear()
        txtCategory.Clear()
        txtMenu.Clear()
        txtPrice.Clear()
        txtQty.Clear()
        lblTotalQty.Text = "0"
        lblTotalPrice.Text = "0"
        lblPPN.Text = "0"
        lblGrandTotal.Text = "0"
        lblTerbilang.Text = "-"
        DGMenu.DataSource = Nothing
    End Sub

    Sub enabledObj()
        cbTable.Enabled = True
        txtIdMenu.Enabled = True
        btnSearch.Enabled = True
        txtQty.Enabled = True
        btnCart.Enabled = True
        btnDel.Enabled = True
    End Sub

    Sub disabledObj()
        cbTable.Enabled = False
        txtCustomer.Enabled = False
        txtIdMenu.Enabled = False
        btnSearch.Enabled = False
        txtQty.Enabled = False
        btnCart.Enabled = False
        btnDel.Enabled = False
    End Sub

    Private Sub frmTransactionOrdersEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atStart()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (btnAdd.Text = "&Add") Then
            Call clickAdd()
            DGMenu.Focus()
        Else
            saveorder()
        End If
    End Sub

    Sub saveorder()
        If cbTable.Text = "" Or lblGrandTotal.Text = "0" Then
            MsgBoxError("Fill data")
            cbTable.Focus()
        Else
            Call connectdb()
            str = "DELETE FROM ordersdetails WHERE id_order = '" & id_order & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()

            str = "DELETE FROM orders WHERE id_order = '" & id_order & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()

            Try
                Dim customer As String
                If (txtCustomer.Text = "Anonymous") Then
                    customer = ""
                Else
                    customer = txtCustomer.Text
                End If
                str = "INSERT INTO orders VALUES ('" & id_order & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '" & cbTable.Text & "', '" & customer & "', '" & total_qty & "', '" & total_price & "', '" & ppn & "', '" & grandtotal & "', '1', '" & frmMainMenu.lblUsername.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Try
                    str = "INSERT INTO ordersdetails (id_order, id_menu, qty, price_order, status) SELECT id_order, id_menu, qty, price_order, status FROM orderdetails_edit"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    closecmd()

                    MsgBoxInformation("Data order has been saved")
                    Call atStart()
                Catch ex As Exception
                    MsgBoxError("Data detail orders hasn't been saved")
                End Try
            Catch ex As Exception
                MsgBoxInformation("Data orders hasn't been saved")
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearchMenus.Show()
        frmMainMenu.Enabled = False
    End Sub

    Private Sub txtIdMenu_TextChanged(sender As Object, e As EventArgs) Handles txtIdMenu.TextChanged
        Call connectdb()
        str = "SELECT * FROM menus WHERE id_menu='" & txtIdMenu.Text & "' AND status_menu='1' AND isActive='1'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtCategory.Text = rd.Item("category")
            txtMenu.Text = rd.Item("menu")
            txtPrice.Text = rd.Item("price")
        Else
            txtCategory.Text = ""
            txtMenu.Text = ""
            txtPrice.Text = ""
        End If
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        If txtMenu.Text = "" Or txtQty.Text = "" Or txtQty.Text = "0" Then
            MsgBoxError("Fill data")
            txtIdMenu.Focus()
        Else
            Dim cek As Integer
            For cek = 0 To DGMenu.Rows.Count - 1
                If DGMenu.Rows(cek).Cells(0).Value = txtIdMenu.Text Then
                    MsgBoxError("Data already exist")
                    txtCategory.Clear()
                    txtMenu.Clear()
                    txtPrice.Clear()
                    txtIdMenu.Focus()
                    Exit Sub
                End If
            Next
            Call connectdb()
            str = "INSERT INTO orderdetails_edit VALUES ('" & id_order & "','" & txtIdMenu.Text & "', '" & txtQty.Text & "', '" & txtPrice.Text & "', '1')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            closecmd()
            Call showgrid()
            Call sizegrid()

            total_qty = 0
            For t As Integer = 0 To DGMenu.Rows.Count - 1
                total_qty = total_qty + Val(DGMenu.Rows(t).Cells(4).Value)
            Next
            lblTotalQty.Text = Format(Val(total_qty), "###,###")

            total_price = 0
            For t As Integer = 0 To DGMenu.Rows.Count - 1
                total_price = total_price + Val(DGMenu.Rows(t).Cells(5).Value)
            Next
            lblTotalPrice.Text = Format(Val(total_price), "###,###")

            ppn = 0
            ppn = (total_price * 10) / 100
            lblPPN.Text = Format(Val(ppn), "###,###")

            grandtotal = 0
            grandtotal = total_price + ppn
            lblGrandTotal.Text = Format(Val(grandtotal), "###,###")
            lblTerbilang.Text = Terbilang(grandtotal)

            txtIdMenu.Text = ""
            txtCategory.Text = ""
            txtMenu.Text = ""
            txtPrice.Text = ""
            txtQty.Text = ""
            txtIdMenu.Focus()
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim i As Integer
            i = Me.DGMenu.CurrentRow.Index
            With DGMenu.Rows.Item(i)
                Call connectdb()
                str = "DELETE FROM orderdetails_edit WHERE id_menu = '" & .Cells(0).Value & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                Call showgrid()
                Call sizegrid()
            End With

            total_qty = 0
            For t As Integer = 0 To DGMenu.Rows.Count - 1
                total_qty = total_qty + Val(DGMenu.Rows(t).Cells(4).Value)
            Next
            lblTotalQty.Text = Format(Val(total_qty), "###,###")

            total_price = 0
            For t As Integer = 0 To DGMenu.Rows.Count - 1
                total_price = total_price + Val(DGMenu.Rows(t).Cells(5).Value)
            Next
            lblTotalPrice.Text = Format(Val(total_price), "###,###")

            ppn = 0
            ppn = (total_price * 10) / 100
            lblPPN.Text = Format(Val(ppn), "###,###")

            grandtotal = 0
            grandtotal = total_price + ppn
            lblGrandTotal.Text = Format(Val(grandtotal), "###,###")
            lblTerbilang.Text = Terbilang(grandtotal)

            If (grandtotal = 0) Then
                lblTotalQty.Text = "0"
                lblTotalPrice.Text = "0"
                lblPPN.Text = "0"
                lblGrandTotal.Text = "0"
                lblTerbilang.Text = "-"
            End If
        Catch ex As Exception
            MsgBoxError("Sorry, no menu selected")
        End Try
    End Sub

    Sub atStart()
        btnAdd.Text = "&Add"
        btnBack.Text = "&Back"
        btnAdd.Enabled = True
        btnBack.Enabled = True
        Call disabledObj()
        btnBack.Focus()
        Call ClearText()
    End Sub

    Private Sub cbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTable.SelectedIndexChanged
        Call connectdb()

        str = "DELETE FROM orderdetails_edit"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        Call closecmd()

        str = "SELECT * FROM orders WHERE no_table='" & cbTable.Text & "' AND status_order='1'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            lblTotalQty.Text = rd.Item("total_qty")
            lblTotalPrice.Text = Format(Val(rd.Item("total_price")), "###,###")
            lblPPN.Text = Format(Val(rd.Item("ppn")), "###,###")
            lblGrandTotal.Text = Format(Val(rd.Item("grandtotal")), "###,###")
            lblTerbilang.Text = Terbilang(lblGrandTotal.Text)
            id_order = rd.Item("id_order")
            If (rd.Item("customer") = "") Then
                txtCustomer.Text = "Anonymous"
            Else
                txtCustomer.Text = rd.Item("customer")
            End If
            closerd()
            Try
                Dim simpan As String
                simpan = "INSERT INTO orderdetails_edit (id_order, id_menu, qty, price_order, status) SELECT id_order, id_menu, qty, price_order, status FROM ordersdetails WHERE id_order='" & id_order & "'"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                closecmd()
            Catch ex As Exception
                MsgBoxError("Data order not found")
            End Try
            Call showgrid()
            Call sizegrid()
        End If
    End Sub

    Sub clickAdd()
        btnAdd.Text = "&Order"
        btnBack.Text = "&Cancel"
        fillTable()
        Call enabledObj()
        cbTable.Focus()
        Call ClearText()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            frmMainMenu.IsMdiContainer = False
            frmMainMenu.IsMdiContainer = True
            frmTransactionOrders.Show()
            frmTransactionOrders.MdiParent = frmMainMenu
            frmMainMenu.Wallpaper.Visible = False
        ElseIf btnBack.Text = "&Cancel" Then
            Call atStart()
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class