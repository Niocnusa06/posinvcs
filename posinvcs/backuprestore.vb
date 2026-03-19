Imports System.IO
Imports System.Diagnostics

Public Class backuprestore

    Private ReadOnly mysqlBin As String = "D:\xampp\mysql\bin"
    Private ReadOnly dbName As String = "posinv"
    Private ReadOnly dbUser As String = "root"
    Private ReadOnly dbPassword As String = ""

    ' ================= BACKUP =================
    Private Sub BackupDatabase()
        Try
            Dim backupDir As String = Path.Combine(Application.StartupPath, "backup")

            If Not Directory.Exists(backupDir) Then
                Directory.CreateDirectory(backupDir)
            End If

            Dim fileName As String =
                $"datebackup_{DateTime.Now:yyyy-MM-dd_HHmmss}_MariaAthena_DB.sql"

            Dim backupPath As String = Path.Combine(backupDir, fileName)

            Dim psi As New ProcessStartInfo()
            psi.FileName = Path.Combine(mysqlBin, "mysqldump.exe")


            psi.Arguments = $"-u {dbUser} -P 3307 --databases {dbName} --routines --events --result-file=""{backupPath}"""

            psi.UseShellExecute = False
            psi.CreateNoWindow = True
            psi.RedirectStandardError = True

            Using proc As Process = Process.Start(psi)
                Dim err = proc.StandardError.ReadToEnd()
                proc.WaitForExit()

                If proc.ExitCode = 0 AndAlso File.Exists(backupPath) Then
                    MessageBox.Show("Backup completed!" & vbCrLf & backupPath, "Success")
                Else
                    Throw New Exception(err)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Backup failed: " & ex.Message)
        End Try
    End Sub

    ' ================= RESTORE =================
    Private Sub RestoreDatabase()
        Try
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = Path.Combine(Application.StartupPath, "backup")
            ofd.Filter = "SQL Backup|*.sql"

            If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim confirm = MessageBox.Show(
                "This will OVERWRITE your database. Continue?",
                "Confirm Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If confirm <> DialogResult.Yes Then Exit Sub

            ' ================= STEP 1: DROP + CREATE DATABASE =================
            Dim dropCmd As New ProcessStartInfo()
            dropCmd.FileName = Path.Combine(mysqlBin, "mysql.exe")
            dropCmd.Arguments = $"-u {dbUser} -P 3307 -e ""DROP DATABASE IF EXISTS {dbName}; CREATE DATABASE {dbName};"""
            dropCmd.UseShellExecute = False
            dropCmd.CreateNoWindow = True
            dropCmd.RedirectStandardError = True

            Using procDrop As Process = Process.Start(dropCmd)
                Dim err = procDrop.StandardError.ReadToEnd()
                procDrop.WaitForExit()

                If procDrop.ExitCode <> 0 Then
                    Throw New Exception("Drop/Create DB Error: " & err)
                End If
            End Using

            ' ================= STEP 2: RESTORE DATABASE =================
            Dim psi As New ProcessStartInfo()
            psi.FileName = Path.Combine(mysqlBin, "mysql.exe")
            psi.Arguments = $"-u {dbUser} -P 3307 {dbName}"
            psi.UseShellExecute = False
            psi.RedirectStandardInput = True
            psi.RedirectStandardError = True
            psi.CreateNoWindow = True

            Using proc As Process = Process.Start(psi)
                Using sw As StreamWriter = proc.StandardInput
                    sw.Write(File.ReadAllText(ofd.FileName))
                End Using

                Dim err = proc.StandardError.ReadToEnd()
                proc.WaitForExit()

                If proc.ExitCode <> 0 Then
                    Throw New Exception("Restore Error: " & err)
                End If
            End Using

            MessageBox.Show("Database restored successfully!", "Success")

        Catch ex As Exception
            MessageBox.Show("Restore failed: " & ex.Message, "Error")
        End Try
    End Sub

    ' ================= AUTO BACKUP =================
    Public Sub AutoBackupDatabase()
        Try
            Dim backupDir As String = Path.Combine(Application.StartupPath, "autobackup")

            If Not Directory.Exists(backupDir) Then
                Directory.CreateDirectory(backupDir)
            End If

            Dim fileName As String =
                $"auto_{DateTime.Now:yyyy-MM-dd_HHmmss}_{dbName}.sql"

            Dim backupPath As String = Path.Combine(backupDir, fileName)

            Dim psi As New ProcessStartInfo()
            psi.FileName = Path.Combine(mysqlBin, "mysqldump.exe")
            psi.Arguments = $"-u {dbUser} -P 3307 --databases {dbName} --result-file=""{backupPath}"""
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            Using proc As Process = Process.Start(psi)
                proc.WaitForExit()
            End Using

        Catch
            ' silent
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