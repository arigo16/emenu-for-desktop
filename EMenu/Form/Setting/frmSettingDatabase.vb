Imports System.IO

Public Class frmSettingDatabase
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Wallpaper.Visible = True
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If txtBackup.Text = "" Then
            MsgBoxError("Please choose folder backup")
        Else
            Dim ask = MessageBox.Show("Are you sure want to backup ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim folder = txtBackup.Text

            If ask = Windows.Forms.DialogResult.Yes Then
                Dim tanggal = Format(Now, "ddMMMMyyyy")
                Dim nm = "db_emenu" & tanggal
                Dim myProcess As New Process()

                Process.Start("C:\xampp\mysql\bin\mysqldump.exe", " -u root db_emenu -r """ & folder & "\" & nm & ".sql""")
                myProcess.Close()
                MsgBoxInformation("Backup to " & folder & " finish")

            ElseIf ask = Windows.Forms.DialogResult.No Then : Exit Sub

            End If
        End If
    End Sub

    Private Sub btnChooseBackup_Click(sender As Object, e As EventArgs) Handles btnChooseBackup.Click
        Dim folder = ChooseBackup.ShowDialog
        If folder = Windows.Forms.DialogResult.OK Then
            txtBackup.Text = ChooseBackup.SelectedPath
        End If
    End Sub

    Private Sub btnChooseRestore_Click(sender As Object, e As EventArgs) Handles btnChooseRestore.Click
        Dim file = ChooseRestore.ShowDialog
        If file = Windows.Forms.DialogResult.OK Then
            txtRestore.Text = ChooseRestore.FileName
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If txtRestore.Text = "" Then
            MsgBoxError("Please choose file database for restore")
        Else
            Dim file = txtRestore.Text

            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root db_emenu < " & file & "")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            myProcess.Close()
            MsgBoxInformation("Restore database from " & file & " finish")
        End If
    End Sub
End Class