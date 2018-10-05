Imports MySql.Data.MySqlClient

Public Class frmSearchMenus
    Sub showGrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE status_menu='1' AND isActive='1' ORDER BY id_menu ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "menus")
        DGMenu.DataSource = ds.Tables("menus")
    End Sub

    Sub sizegrid()
        DGMenu.Columns(0).Width = 90
        DGMenu.Columns(1).Width = 150
        DGMenu.Columns(2).Width = 250
        DGMenu.Columns(3).Width = 100
        DGMenu.Columns(4).Width = 300
        DGMenu.Columns(0).Resizable = DataGridViewTriState.False
        DGMenu.Columns(1).Resizable = DataGridViewTriState.False
        DGMenu.Columns(2).Resizable = DataGridViewTriState.False
        DGMenu.Columns(3).Resizable = DataGridViewTriState.False
        DGMenu.Columns(4).Resizable = DataGridViewTriState.False
        DGMenu.Columns(0).HeaderText = "ID Menu"
        DGMenu.Columns(1).HeaderText = "Category"
        DGMenu.Columns(2).HeaderText = "Menu Names"
        DGMenu.Columns(3).HeaderText = "Price"
        DGMenu.Columns(4).HeaderText = "Description"
    End Sub

    Sub filtergrid()
        Call connectdb()
        If cbSearch.SelectedIndex = 0 Then
            da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE (menu like '%" & txtSearch.Text & "%') AND (isActive='1') AND (status_menu='1')", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "menus")
            DGMenu.DataSource = ds.Tables("menus")
        Else
            da = New MySqlDataAdapter("SELECT id_menu, category, menu, price, description FROM menus WHERE (category='" & cbSearch.Text & "') AND (menu like '%" & txtSearch.Text & "%') AND (isActive='1') AND (status_menu='1')", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "menus")
            DGMenu.DataSource = ds.Tables("menus")
        End If
    End Sub

    Sub fillcategory()
        Call connectdb()
        Dim str As String
        str = "SELECT category FROM categories WHERE isActive='1' ORDER BY category ASC"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            cbSearch.Items.Add("All")
            Do While rd.Read
                cbSearch.Items.Add(rd("category"))
            Loop
        Else
        End If
        closerd()
    End Sub

    Private Sub frmSearchMenus_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frmMainMenu.Enabled = True
        frmMainMenu.Focus()
    End Sub

    Private Sub frmSearchMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call showGrid()
        Call sizegrid()
        Call fillcategory()
        cbSearch.SelectedIndex = 0
    End Sub

    Private Sub cbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged
        Call filtergrid()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call filtergrid()
    End Sub

    Private Sub DGMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellContentClick
        frmMainMenu.Enabled = True
        Dim i As Integer
        i = Me.DGMenu.CurrentRow.Index
        With DGMenu.Rows.Item(i)
            frmTransactionOrders.txtIdMenu.Text = .Cells(0).Value
            frmTransactionOrdersEdit.txtIdMenu.Text = .Cells(0).Value
            frmReportOrders.txtMenu.Text = .Cells(0).Value
            frmTransactionOrders.txtQty.Focus()
            Me.Dispose()
        End With
    End Sub

    Private Sub DGMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellContentDoubleClick
        frmMainMenu.Enabled = True
        Dim i As Integer
        i = Me.DGMenu.CurrentRow.Index
        With DGMenu.Rows.Item(i)
            frmTransactionOrders.txtIdMenu.Text = .Cells(0).Value
            frmTransactionOrdersEdit.txtIdMenu.Text = .Cells(0).Value
            frmReportOrders.txtMenu.Text = .Cells(0).Value
            frmTransactionOrders.txtQty.Focus()
            Me.Dispose()
        End With
    End Sub

    Private Sub DGMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMenu.CellClick
        frmMainMenu.Enabled = True
        Dim i As Integer
        i = Me.DGMenu.CurrentRow.Index
        With DGMenu.Rows.Item(i)
            frmTransactionOrders.txtIdMenu.Text = .Cells(0).Value
            frmTransactionOrdersEdit.txtIdMenu.Text = .Cells(0).Value
            frmReportOrders.txtMenu.Text = .Cells(0).Value
            frmTransactionOrders.txtQty.Focus()
            Me.Dispose()
        End With
    End Sub
End Class