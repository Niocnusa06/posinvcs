Imports System.IO

Public Class backuprestore
    Private Sub BackupDatabase()
        Try
            Dim backupFolder As String = Application.StartupPath & "\backup\"
            If Not Directory.Exists(backupFolder) Then
                Directory.CreateDirectory(backupFolder)
            End If

            Dim fileName As String = "POSINV_BACKUP_" & DateTime.Now.ToString("yyyy-MM-dd_HHmmss") & ".sql"
            Dim backupPath As String = backupFolder & fileName

            Dim cmd As String = "C:\xampp\mysql\bin\mysqldump.exe"
            Dim args As String = "-u root -p --databases posinv --result-file=""" & backupPath & """"

            Dim psi As New ProcessStartInfo(cmd, args)
            psi.RedirectStandardInput = True
            psi.RedirectStandardOutput = True
            psi.UseShellExecute = False

            Dim process As Process = Process.Start(psi)


            Dim password As String = ""
            process.StandardInput.WriteLine(password)
            process.StandardInput.Flush()

            process.WaitForExit()

            MessageBox.Show("Database backup created successfully!" & vbCrLf & backupPath,
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Backup failed: " & ex.Message)
        End Try
    End Sub

    Private Sub RestoreDatabase()
        Try
            Dim ofd As New OpenFileDialog()
            ofd.Filter = "SQL Backup (*.sql)|*.sql"
            ofd.Title = "Select a Backup File"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim sqlFile As String = ofd.FileName

                Dim cmd As String = "C:\xampp\mysql\bin\mysql.exe"
                Dim args As String = "-u root -p posinv"

                Dim psi As New ProcessStartInfo(cmd)
                psi.Arguments = args
                psi.RedirectStandardInput = True
                psi.UseShellExecute = False

                Dim process As Process = Process.Start(psi)

                Dim password As String = ""
                process.StandardInput.WriteLine(password)


                Dim sqlText As String = File.ReadAllText(sqlFile)
                process.StandardInput.WriteLine(sqlText)

                process.StandardInput.Close()
                process.WaitForExit()

                MessageBox.Show("Database has been successfully restored!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Restore failed: " & ex.Message)
        End Try
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        RestoreDatabase()
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        BackupDatabase()
    End Sub

    Private Sub restorePicBox_Click(sender As Object, e As EventArgs) Handles restorePicBox.Click
        RestoreDatabase()
    End Sub

    Private Sub backupPicBox_Click(sender As Object, e As EventArgs) Handles backupPicBox.Click
        BackupDatabase()
    End Sub
End Class