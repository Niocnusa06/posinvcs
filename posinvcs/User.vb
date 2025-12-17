Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class User
    ' ✅ Connection string
    Dim connectionString As String = "server=localhost;port=3307;user id=root;password=;database=posinv;"

    ' 🔐 Hash function
    Private Function HashText(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' 🔄 Load form
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        squestioncombob.Items.AddRange(New String() {
            "What is your favorite color?",
            "What is your pet's name?",
            "What is your mother's maiden name?",
            "What city were you born in?"
        })

        accountcombob.Items.AddRange(New String() {"Admin", "Cashier"})
        LoadUsers()
        UpdateCountLabel()
    End Sub

    ' 💡 Change account type
    Private Sub accountcombob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles accountcombob.SelectedIndexChanged
        If accountcombob.Text = "Cashier" Then
            squestioncombob.Enabled = False
            sanswertxtb.Enabled = False
            squestioncombob.SelectedIndex = -1
            sanswertxtb.Clear()
        ElseIf accountcombob.Text = "Admin" Then
            squestioncombob.Enabled = True
            sanswertxtb.Enabled = True
        End If
    End Sub

    ' 🧹 Clear inputs
    Private Sub ClearInputs()
        usernametxtb.Clear()
        passwordtxtb.Clear()
        sanswertxtb.Clear()
        squestioncombob.SelectedIndex = -1
        accountcombob.SelectedIndex = -1
        UserDGV.ClearSelection()
    End Sub
    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        ClearInputs()
    End Sub

    ' 🔁 Load users
    Private Sub LoadUsers()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT user_id AS 'User ID', username AS 'Username', security_question AS 'Security Question', account_type AS 'Account Type' FROM user"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                UserDGV.DataSource = dt
            End Using
            UserDGV.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    ' 🔍 Live search
    Private Sub usernametxtb_TextChanged(sender As Object, e As EventArgs) Handles usernametxtb.TextChanged
        Dim searchText As String = usernametxtb.Text.Trim()
        Dim dt As DataTable = CType(UserDGV.DataSource, DataTable)

        If dt IsNot Nothing Then
            dt.DefaultView.RowFilter = String.Format("[Username] LIKE '%{0}%'", searchText.Replace("'", "''"))
            UpdateCountLabel()
        End If

        For Each row As DataGridViewRow In UserDGV.Rows
            If row.Cells("Username").Value.ToString().ToLower() = searchText.ToLower() Then
                row.Selected = True
                UserDGV.FirstDisplayedScrollingRowIndex = row.Index
                LoadUserData(searchText)
                Exit Sub
            End If
        Next
    End Sub

    ' 📋 Load selected user info
    Private Sub LoadUserData(username As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM user WHERE username=@u"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            passwordtxtb.Text = ""
                            squestioncombob.Text = reader("security_question").ToString()
                            sanswertxtb.Text = ""
                            accountcombob.Text = reader("account_type").ToString()

                            If accountcombob.Text = "Cashier" Then
                                squestioncombob.Enabled = False
                                sanswertxtb.Enabled = False
                            Else
                                squestioncombob.Enabled = True
                                sanswertxtb.Enabled = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message)
        End Try
    End Sub

    ' ✏️ Update user
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim username As String = usernametxtb.Text.Trim()
        If username = "" Then
            MessageBox.Show("Select a user to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' First: check user exists
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM user WHERE username=@u"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@u", username)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If exists = 0 Then
                        MessageBox.Show("User not found. You can only update existing users.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Now prepare fields
                Dim password As String = passwordtxtb.Text.Trim()
                Dim question As String = squestioncombob.Text.Trim()
                Dim answer As String = sanswertxtb.Text.Trim()
                Dim accountType As String = accountcombob.Text.Trim()

                If accountType = "Admin" AndAlso (question = "" Or answer = "") Then
                    MessageBox.Show("Admin must have a security question and answer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                If accountType = "Cashier" Then
                    question = ""
                    answer = ""
                End If

                ' Prevent downgrading Admin -> Cashier
                Dim typeQuery As String = "SELECT account_type FROM user WHERE username=@u"
                Using typeCmd As New MySqlCommand(typeQuery, conn)
                    typeCmd.Parameters.AddWithValue("@u", username)
                    Dim currentType As String = typeCmd.ExecuteScalar()?.ToString()
                    If currentType = "Admin" AndAlso accountType = "Cashier" Then
                        MessageBox.Show("Admin cannot be changed to Cashier.", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Build update SQL (only include password if provided)
                Dim updateSql As String = "UPDATE user SET account_type=@t, security_question=@q, security_answer=@a"
                If password <> "" Then updateSql &= ", password=@p"
                updateSql &= " WHERE username=@u"

                Using cmd As New MySqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@t", accountType)
                    cmd.Parameters.AddWithValue("@q", question)
                    cmd.Parameters.AddWithValue("@a", If(answer <> "", HashText(answer), ""))

                    If password <> "" Then
                        cmd.Parameters.AddWithValue("@p", HashText(password))
                    End If

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("User updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were saved. (No rows affected)", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

            ' refresh and reset
            ClearInputs()
            LoadUsers()
            UpdateCountLabel()

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

    ' 🗑️ Delete user
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If usernametxtb.Text.Trim = "" Then
            MessageBox.Show("Select a user first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim username = usernametxtb.Text.Trim

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim typeQuery = "SELECT account_type FROM user WHERE username=@u"
                Using typeCmd As New MySqlCommand(typeQuery, conn)
                    typeCmd.Parameters.AddWithValue("@u", username)
                    Dim accType = typeCmd.ExecuteScalar?.ToString

                    If accType = "Admin" Then
                        MessageBox.Show("Admin accounts cannot be deleted!", "Protected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                Dim result = MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim delQuery = "DELETE FROM user WHERE username=@u"
                    Using delCmd As New MySqlCommand(delQuery, conn)
                        delCmd.Parameters.AddWithValue("@u", username)
                        delCmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearInputs()
                    LoadUsers()
                    UpdateCountLabel()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message)
        End Try
    End Sub
    ' 🧾 Count visible users
    Private Sub UpdateCountLabel()
        recordCountLbl.Text = "Showing " & UserDGV.Rows.GetRowCount(DataGridViewElementStates.Visible) & " user(s)"
    End Sub

    ' 💾 Add user
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim username As String = usernametxtb.Text.Trim()
        Dim password As String = passwordtxtb.Text.Trim()
        Dim question As String = squestioncombob.Text.Trim()
        Dim answer As String = sanswertxtb.Text.Trim()
        Dim accountType As String = accountcombob.Text.Trim()

        If username = "" Or password = "" Or accountType = "" Then
            MessageBox.Show("Please fill in username, password, and account type.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If accountType = "Admin" AndAlso (question = "" Or answer = "") Then
            MessageBox.Show("Admin accounts require a security question and answer.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If accountType = "Cashier" Then
            question = ""
            answer = ""
        End If

        Dim hashedPass As String = HashText(password)
        Dim hashedAnswer As String = If(answer <> "", HashText(answer), "")

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Check for duplicates
                Dim checkQuery As String = "SELECT COUNT(*) FROM user WHERE username=@u"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@u", username)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username already exists!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Insert user
                Dim query As String = "INSERT INTO user (username, password, security_question, security_answer, account_type) VALUES (@u, @p, @q, @a, @t)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", hashedPass)
                    cmd.Parameters.AddWithValue("@q", question)
                    cmd.Parameters.AddWithValue("@a", hashedAnswer)
                    cmd.Parameters.AddWithValue("@t", accountType)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            LoadUsers()
            UpdateCountLabel()
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message)
        End Try
    End Sub


End Class