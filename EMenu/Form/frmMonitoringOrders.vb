Imports MySql.Data.MySqlClient

Public Class frmMonitoringOrders
    Sub ShowGrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT orders.id_order, ordersdetails.id_menu, menus.menu, menus.category, ordersdetails.qty, orders.no_table FROM orders INNER JOIN (menus INNER JOIN ordersdetails ON menus.id_menu = ordersdetails.id_menu) ON orders.id_order = ordersdetails.id_order WHERE orders.status_order='1' AND ordersdetails.status='1' ORDER BY ordersdetails.no ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "orders")
        DGMenu.DataSource = ds.Tables("orders")
    End Sub
    Sub SizeGrid()
        DGMenu.Columns(0).Width = 250
        DGMenu.Columns(1).Width = 140
        DGMenu.Columns(2).Width = 490
        DGMenu.Columns(3).Width = 250
        DGMenu.Columns(4).Width = 100
        DGMenu.Columns(5).Width = 100
        DGMenu.Columns(0).Resizable = DataGridViewTriState.False
        DGMenu.Columns(1).Resizable = DataGridViewTriState.False
        DGMenu.Columns(2).Resizable = DataGridViewTriState.False
        DGMenu.Columns(3).Resizable = DataGridViewTriState.False
        DGMenu.Columns(4).Resizable = DataGridViewTriState.False
        DGMenu.Columns(5).Resizable = DataGridViewTriState.False
        DGMenu.Columns(0).HeaderText = "ID ORDER"
        DGMenu.Columns(1).HeaderText = "ID MENU"
        DGMenu.Columns(2).HeaderText = "MENU"
        DGMenu.Columns(3).HeaderText = "CATEGORY"
        DGMenu.Columns(4).HeaderText = "QTY"
        DGMenu.Columns(5).HeaderText = "TABLE"
        DGMenu.Font = New Font("Arial", 20, FontStyle.Bold)
    End Sub

    Private Sub frmMonitoringOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            frmLogin.Show()
            frmLogin.txtUsername.Clear()
            frmLogin.txtPassword.Clear()
            frmLogin.txtUsername.Focus()
        End If
    End Sub

    Private Sub frmMonitoringOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ShowGrid()
        Call SizeGrid()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Call ShowGrid()
        Call SizeGrid()
    End Sub

    Private Sub DGMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellContentClick

    End Sub

    Private Sub DGMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellContentDoubleClick
        Call connectdb()
        Try
            Dim i As Integer
            i = Me.DGMenu.CurrentRow.Index
            With DGMenu.Rows.Item(i)
                str = "UPDATE ordersdetails SET status='0' WHERE id_order='" & .Cells(0).Value & "' AND id_menu='" & .Cells(1).Value & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                Call ShowGrid()
                Call SizeGrid()
            End With
        Catch ex As Exception
            MsgBoxWarning("Something went wrong")
        End Try
    End Sub

    Private Sub DGMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellClick

    End Sub

    Private Sub DGMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellDoubleClick
        Call connectdb()
        Try
            Dim i As Integer
            i = Me.DGMenu.CurrentRow.Index
            With DGMenu.Rows.Item(i)
                str = "UPDATE ordersdetails SET status='0' WHERE id_order='" & .Cells(0).Value & "' AND id_menu='" & .Cells(1).Value & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                Call ShowGrid()
                Call SizeGrid()
            End With
        Catch ex As Exception
            MsgBoxWarning("Something went wrong")
        End Try
    End Sub
End Class