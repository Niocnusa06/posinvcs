Imports System.IO
Imports System.Diagnostics

Public Class backuprestore

    Private ReadOnly mysqlBin As String = "D:\xampp\mysql\bin"
    Private ReadOnly dbName As String = "posinv"
    Private ReadOnly dbUser As String = "root"
    Private ReadOnly dbPassword As String = "" ' ← leave blank if none

    ' ================= BACKUP =================
    Private Sub BackupDatabase()

        Try
            Dim mysqlBin As String = "D:\xampp\mysql\bin\"
            Dim backupDir As String = Path.Combine(Application.StartupPath, "backup")

            If Not Directory.Exists(backupDir) Then
                Directory.CreateDirectory(backupDir)
            End If

            Dim fileName As String =
            $"datebackup_{DateTime.Now:yyyy-MM-dd_HHmmss}_MariaAthena_DB.sql"

            Dim backupPath As String = Path.Combine(backupDir, fileName)

            Dim psi As New ProcessStartInfo()
            psi.FileName = Path.Combine(mysqlBin, "mysqldump.exe")
            psi.Arguments = $"-u root -P 3307 posinv --result-file=""{backupPath}"""
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Dim proc As Process = Process.Start(psi)
            proc.WaitForExit()

            If proc.ExitCode = 0 AndAlso File.Exists(backupPath) Then
                MessageBox.Show(
                "Backup completed successfully!" & vbCrLf & backupPath,
                "Backup Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Else
                Throw New Exception("mysqldump execution failed.")
            End If

        Catch ex As Exception
            MessageBox.Show(
            "Backup failed: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
        End Try

    End Sub


    ' ================= RESTORE =================
    Private Sub RestoreDatabase()

        Try
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = Path.Combine(Application.StartupPath, "backup")
            ofd.Filter = "Maria Athena Backup|datebackup_*_MariaAthena_DB.sql"

            If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim confirm = MessageBox.Show(
            "This will overwrite the current database. Continue?",
            "Confirm Restore",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

            If confirm <> DialogResult.Yes Then Exit Sub

            Dim psi As New ProcessStartInfo()
            psi.FileName = "D:\xampp\mysql\bin\mysql.exe"
            psi.Arguments = "-u root -P 3307 posinv"
            psi.RedirectStandardInput = True
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Using proc As Process = Process.Start(psi)
                Using sw As StreamWriter = proc.StandardInput
                    sw.Write(File.ReadAllText(ofd.FileName))
                End Using
                proc.WaitForExit()
            End Using

            MessageBox.Show("Database restored successfully!", "Restore Success")

        Catch ex As Exception
            MessageBox.Show("Restore failed: " & ex.Message)
        End Try

    End Sub

    Private Sub AutoBackupDatabase()
        Try
            Dim mysqlBin As String = "D:\xampp\mysql\bin\"
            Dim backupDir As String = Path.Combine(Application.StartupPath, "autobackup")

            If Not Directory.Exists(backupDir) Then
                Directory.CreateDirectory(backupDir)
            End If

            Dim fileName As String =
            $"auto_{DateTime.Now:yyyy-MM-dd_HHmmss}_posinv.sql"

            Dim backupPath As String = Path.Combine(backupDir, fileName)

            Dim psi As New ProcessStartInfo()
            psi.FileName = Path.Combine(mysqlBin, "mysqldump.exe")
            psi.Arguments = "-u root -P 3307 posinv --single-transaction --quick --result-file=""" & backupPath & """"
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Using proc As Process = Process.Start(psi)
                proc.WaitForExit()
            End Using

        Catch

        End Try
    End Sub


    ' ================= BUTTON EVENTS =================
    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        BackupDatabase()
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        RestoreDatabase()
    End Sub

    Private Sub backupPicBox_Click(sender As Object, e As EventArgs) Handles backupPicBox.Click
        BackupDatabase()
    End Sub

    Private Sub restorePicBox_Click(sender As Object, e As EventArgs) Handles restorePicBox.Click
        RestoreDatabase()
    End Sub

End Class
