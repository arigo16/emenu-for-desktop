Imports MySql.Data.MySqlClient

Module ConMySQL
    Public conn As MySqlConnection
    Public cmd, cmd2 As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub connectdb()
        Dim server = My.Settings.dbServer
        Dim user = My.Settings.dbUser
        Dim port = My.Settings.dbPort
        Dim password = My.Settings.dbPass
        Dim database = My.Settings.dbName

        If password = "" Then
            Try
                Dim str As String = "server=" & server & ";userid=" & user & ";database=" & database & ";port=" & port & ";"
                conn = New MySqlConnection(str)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Dim str As String = "server=" & server & ";userid=" & user & ";database=" & database & ";port=" & port & ";password=" & password & ""
                conn = New MySqlConnection(str)
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub closecmd()
        cmd.Dispose()
    End Sub
    Sub closerd()
        rd.Close()
        cmd.Dispose()
    End Sub
End Module
