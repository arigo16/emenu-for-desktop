Imports MySql.Data.MySqlClient
Public Class frmTransactionOrders
    Private id_order_auto As String
    Public total_qty, total_price, ppn, grandtotal As Long

    Sub autonumber()
        Call connectdb()
        cmd = New MySqlCommand("SELECT id_order FROM orders WHERE id_order IN(SELECT MAX(id_order)FROM orders)", conn)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "ORD" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                urutan = "ORD" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 2) + 1
                urutan = "ORD" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        id_order_auto = urutan
        closerd()
    End Sub

    Sub fillTable()
        cbTable.Items.Clear()
        Call connectdb()
        Dim str As String
        str = "SELECT no_table FROM tables WHERE status='0' AND isActive='1' ORDER BY no_table ASC"
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
        DGMenu.Rows.Clear()
    End Sub

    Sub enabledObj()
        cbTable.Enabled = True
        txtCustomer.Enabled = True
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

    Sub atStart()
        btnAdd.Text = "&Add"
        btnBack.Text = "&Back"
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnBack.Enabled = True
        Call disabledObj()
        btnBack.Focus()
        Call ClearText()
    End Sub

    Sub clickAdd()
        btnAdd.Text = "&Order"
        btnEdit.Enabled = False
        btnBack.Text = "&Cancel"
        fillTable()
        Call enabledObj()
        cbTable.Focus()
        Call ClearText()
    End Sub

    Private Sub frmTransactionOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Call autonumber()
            Try
                Dim simpan As String
                simpan = "INSERT INTO orders VALUES ('" & id_order_auto & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "', '" & cbTable.Text & "', '" & txtCustomer.Text & "', '" & total_qty & "', '" & total_price & "', '" & ppn & "', '" & grandtotal & "', '1', '" & frmMainMenu.lblUsername.Text & "')"
                cmd = New MySqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Try
                    Dim str As String
                    Dim var_id_menu, var_qty, var_price_order As String
                    str = "INSERT INTO ordersdetails (no, id_order, id_menu, qty, price_order, status) VALUES (NULL, '" & id_order_auto & "', @id_menu, @qty, @price_order, '1')"
                    cmd = New MySqlCommand(str, conn)

                    For i As Integer = 0 To (DGMenu.Rows.Count - 2)

                        var_id_menu = DGMenu.Rows(i).Cells(0).Value
                        var_qty = DGMenu.Rows(i).Cells(4).Value
                        var_price_order = DGMenu.Rows(i).Cells(3).Value

                        cmd.Parameters.AddWithValue("@id_menu", var_id_menu)
                        cmd.Parameters.AddWithValue("@qty", var_qty)
                        cmd.Parameters.AddWithValue("@price_order", var_price_order)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Next
                    MsgBoxInformation("Data orders has been saved")
                    Call atStart()
                Catch ex As Exception
                    MsgBoxError("Data detail orders hasn't been saved")
                End Try
            Catch ex As Exception
                MsgBoxInformation("Data orders hasn't been saved")
            End Try
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            frmMainMenu.Wallpaper.Visible = True
        ElseIf btnBack.Text = "&Cancel" Then
            Call atStart()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmMainMenu.IsMdiContainer = False
        frmMainMenu.IsMdiContainer = True
        frmTransactionOrdersEdit.Show()
        frmTransactionOrdersEdit.MdiParent = frmMainMenu
        frmMainMenu.Wallpaper.Visible = False
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
            DGMenu.RowCount = DGMenu.RowCount + 1
            DGMenu(0, DGMenu.RowCount - 2).Value = txtIdMenu.Text
            DGMenu(1, DGMenu.RowCount - 2).Value = txtCategory.Text
            DGMenu(2, DGMenu.RowCount - 2).Value = txtMenu.Text
            DGMenu(3, DGMenu.RowCount - 2).Value = txtPrice.Text
            DGMenu(4, DGMenu.RowCount - 2).Value = txtQty.Text
            DGMenu(5, DGMenu.RowCount - 2).Value = Val(txtPrice.Text) * Val(txtQty.Text)

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
        If DGMenu.CurrentRow.Index <> DGMenu.NewRowIndex Then
            DGMenu.Rows.RemoveAt(DGMenu.CurrentCell.RowIndex)
            'intBaris = intBaris - 1
        End If

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
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class