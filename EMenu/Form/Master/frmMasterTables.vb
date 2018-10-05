Imports MySql.Data.MySqlClient

Public Class frmMasterTables
    Sub showgrid()
        Call connectdb()
        da = New MySqlDataAdapter("SELECT no_table, quota FROM tables WHERE isActive='1' ORDER BY no_table ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tables")
        DGTable.DataSource = ds.Tables("tables")
        Call closecmd()
        Call counttable()
        Call countcapacity()
    End Sub
    Sub sizegrid()
        DGTable.Columns(0).Width = 110
        DGTable.Columns(1).Width = 160
        DGTable.Columns(0).Resizable = DataGridViewTriState.False
        DGTable.Columns(1).Resizable = DataGridViewTriState.False
        DGTable.Columns(0).HeaderText = "No Table"
        DGTable.Columns(1).HeaderText = "Qouta"
    End Sub
    Sub counttable()
        Dim rs As Integer
        rs = DGTable.RowCount
        lblTotalTable.Text = rs
    End Sub
    Sub countcapacity()
        Call connectdb()
        If DGTable.RowCount > 0 Then
            Dim str As String
            str = "SELECT SUM(quota) FROM tables"
            cmd = New MySqlCommand(str, conn)
            Dim rs As Integer
            rs = cmd.ExecuteScalar
            lblCapacity.Text = rs
            Call closecmd()
        Else
            lblCapacity.Text = "0"
        End If
    End Sub
    Sub savetable()
        Call connectdb()
        Try
            If txtNo.Text = "" Or txtQuota.Text = "" Or txtNo.Text = "0" Or txtQuota.Text = "0" Then
                MsgBoxError("Fill data")
                txtNo.Focus()
            Else
                Dim str As String
                str = "SELECT * FROM tables WHERE no_table='" & txtNo.Text & "'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    If rd.Item("isActive") = "1" Then
                        closerd()
                        MsgBoxError("Data table exist")
                        Call atstart()
                    Else
                        closerd()
                        str = "UPDATE tables SET isActive='1', quota='" & txtQuota.Text & "' WHERE no_table='" & txtNo.Text & "'"
                        cmd = New MySqlCommand(str, conn)
                        cmd.ExecuteNonQuery()
                        Call closecmd()
                        MsgBoxInformation("Data table has been saved")
                        Call atstart()
                    End If
                Else
                    closerd()
                    str = "INSERT INTO tables VALUES ('" & txtNo.Text & "', '" & txtQuota.Text & "', '0', '1', '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP, '" & frmMainMenu.lblUsername.Text & "', CURRENT_TIMESTAMP)"
                    cmd = New MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()
                    closecmd()
                    MsgBoxInformation("Data table has been saved")
                    Call atstart()
                End If
            End If
        Catch ex As Exception
            MsgBoxError("Data table hasn't been saved")
            Call atstart()
        End Try
    End Sub
    Sub updatetable()
        Call connectdb()
        Try
            If txtNo.Text = "" Or txtQuota.Text = "" Or txtNo.Text = "0" Or txtQuota.Text = "0" Then
                MsgBoxError("Fill data")
                txtNo.Focus()
            Else
                str = "UPDATE tables SET quota='" & txtQuota.Text & "' WHERE no_table='" & txtNo.Text & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                Call closecmd()
                MsgBoxInformation("Data table has been updated")
                Call atstart()
            End If
        Catch ex As Exception
            MsgBoxError("Data table hasn't been updated")
            Call atstart()
        End Try
    End Sub
    Sub deletetable()
        Call connectdb()
        Try
            str = "DELETE FROM tables WHERE no_table='" & txtNo.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data table has been deleted")
            Call atstart()
        Catch ex As Exception
            str = "UPDATE tables SET isActive='0' WHERE no_table='" & txtNo.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            Call closecmd()
            MsgBoxInformation("Data table has been deleted")
            Call atstart()
        End Try
    End Sub
    Sub cleartext()
        txtNo.Clear()
        txtQuota.Clear()
    End Sub
    Sub disabletext()
        txtNo.Enabled = False
        txtQuota.Enabled = False
    End Sub
    Sub enabletext()
        txtNo.Enabled = True
        txtQuota.Enabled = True
    End Sub
    Sub atstart()
        btnAdd.Text = "&Add"
        btnEdit.Text = "&Edit"
        btnDelete.Text = "&Delete"
        btnBack.Text = "&Back"
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnBack.Enabled = True
        Call disabletext()
        Call showgrid()
        Call counttable()
        Call countcapacity()
        Call cleartext()
    End Sub
    Sub clickadd()
        btnAdd.Text = "&Save"
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        Call enabletext()
        txtNo.Focus()
        Call cleartext()
    End Sub
    Sub clickedit()
        btnEdit.Text = "&Update"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtNo.Enabled = True
        txtNo.Focus()
        Call cleartext()
    End Sub
    Sub clickdelete()
        btnDelete.Text = "&Yes"
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnBack.Text = "&Cancel"
        txtNo.Enabled = True
        txtNo.Focus()
        Call cleartext()
    End Sub
    Private Sub frmMasterTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call atstart()
        Call sizegrid()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Call clickadd()
        ElseIf btnAdd.Text = "&Save" Then
            Call savetable()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "&Back" Then
            frmMainMenu.Wallpaper.Visible = True
        ElseIf btnBack.Text = "&Cancel" Then
            Call atstart()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            Call clickedit()
        ElseIf btnEdit.Text = "&Update" Then
            Call updatetable()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            Call clickdelete()
        ElseIf btnDelete.Text = "&Yes" And (txtNo.Text = "0" Or txtNo.Text = "") Then
            MsgBoxWarning("Fill no table")
            txtNo.Focus()
        Else
            Call deletetable()
        End If
    End Sub
    Private Sub txtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNo.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If (e.KeyChar = Chr(13)) Then
            If (btnAdd.Text <> "&Save") Then
                Call connectdb()
                Dim str As String
                str = "SELECT * FROM tables WHERE no_table='" & txtNo.Text & "' AND isActive='1'"
                cmd = New MySqlCommand(str, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    txtQuota.Text = rd.Item("quota")
                    closerd()
                    If btnEdit.Text = "&Update" Then
                        Call enabletext()
                        btnEdit.Enabled = True
                        txtNo.Enabled = False
                    ElseIf btnDelete.Text = "&Yes" Then
                        Call disabletext()
                        btnDelete.Enabled = True
                    End If
                Else
                    MsgBoxWarning("Data table doesn't exist")
                    txtNo.Focus()
                    closerd()
                End If
            End If
        End If
    End Sub
    Private Sub txtQuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuota.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class