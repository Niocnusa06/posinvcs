Imports System.Security.Cryptography
Imports System.Text
Imports DocumentFormat.OpenXml.Office2010.CustomUI
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class LoginForm


    Private failedAttempts As Integer = 0
    Private lockStage As Integer = 0

    Private lockTimer As New Timer()
    Private countdownTimer As New Timer()
    Private remainingSeconds As Integer = 0



    Dim connectionString As String = "server=localhost;port=3307;user id=root;password=;database=posinv;"
    Dim conn As New MySqlConnection("server=localhost;port=3307;user id=root;password=;database=posinv;")

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FPasswordPanel.Visible = False
    End Sub
    '-------------------------------------------------------------------------
    '  HASH FUNCTION (SHA256)
    Private Function HashText(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
    '-------------------------------------------------------------------------
    '  LOGIN BUTTON
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim username = usernametb.Text.Trim
        Dim password = passwordtb.Text.Trim

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hashedPassword = HashText(password)

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query = "SELECT account_type FROM user WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", hashedPassword)

                    Dim reader = cmd.ExecuteReader

                    If reader.Read Then

                        failedAttempts = 0
                        lockStage = 0


                        Dim accountType = reader("account_type").ToString.ToLower


                        usernametb.Text = ""
                        passwordtb.Text = ""

                        If accountType = "admin" Then
                            MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            main.Show()
                            Me.Hide()
                            main.Focus()

                        ElseIf accountType = "cashier" Then
                            MessageBox.Show("Welcome, Cashier!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form1.Show()
                            Me.Hide()
                            Form1.Focus()
                        End If
                    Else
                        failedAttempts += 1

                        MessageBox.Show(
        "Invalid username or password.",
        "Access Denied",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error
    )

                        Select Case lockStage

        ' Stage 0 → 3 failures = 30 seconds
                            Case 0
                                If failedAttempts >= 3 Then
                                    lockStage = 1
                                    LockLogin(30)
                                End If

        ' Stage 1 → 1 failure = 1 minute
                            Case 1
                                lockStage = 2
                                LockLogin(60)

        ' Stage 2 → 1 failure = 3 minutes
                            Case 2
                                lockStage = 3
                                LockLogin(180)

        ' Stage 3 → 1 failure = 5 minutes
                            Case 3
                                lockStage = 4
                                LockLogin(300)

        ' Stage 4 → 1 failure = 30 minutes
                            Case 4
                                lockStage = 5
                                LockLogin(1800)

        ' Stage 5 → 1 failure = 1 hour
                            Case 5
                                lockStage = 6
                                LockLogin(3600)
                        End Select
                    End If



                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '----------------------------------------CLEAR FIELDS WHEN FORM IS VISIBLE AGAIN-----------------------------
    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            usernametb.Clear()
            passwordtb.Clear()
        End If
    End Sub

    '-------------------------------------------------------------------------
    '  PANEL CONTROL
    Private Sub fpassbtn_Click(sender As Object, e As EventArgs) Handles fpassbtn.Click
        ShowPanelSmooth(FPasswordPanel)
        RPasswordPanel.Visible = False
        LoginPanel.Visible = False
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        FPasswordPanel.Visible = False
        ShowPanelSmooth(LoginPanel)
    End Sub

    Private Sub ShowPanelSmooth(target As Panel)
        ' Hide all panels first
        For Each pnl As Panel In {LoginPanel, FPasswordPanel, RPasswordPanel}
            pnl.Visible = False
        Next

        ' Start fade-out
        For fadeOut As Double = 1.0 To 0.7 Step -0.05
            Me.Opacity = fadeOut
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Next

        ' Show the selected panel
        target.Visible = True
        target.BringToFront()

        ' Fade back in smoothly
        For fadeIn As Double = 0.7 To 1.0 Step 0.05
            Me.Opacity = fadeIn
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Next
    End Sub
    '-------------------------------------------------------------------------
    '  BUTTON HOVER EFFECTS
    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler loginbtn.MouseHover, AddressOf ButtonHover
        AddHandler loginbtn.MouseLeave, AddressOf ButtonLeave
        AddHandler closebtn.MouseHover, AddressOf ButtonHover
        AddHandler closebtn.MouseLeave, AddressOf ButtonLeave
        AddHandler Backbtn.MouseHover, AddressOf ButtonHover
        AddHandler Backbtn.MouseLeave, AddressOf ButtonLeave
        AddHandler Backbtn2.MouseHover, AddressOf ButtonHover
        AddHandler Backbtn2.MouseLeave, AddressOf ButtonLeave

        '  Attach toggle event for password fields
        AddHandler ShowPassBtn.Click, AddressOf TogglePasswordVisibility
        AddHandler ShowNewPassBtn.Click, AddressOf TogglePasswordVisibility
        AddHandler ShowConfirmPassBtn.Click, AddressOf TogglePasswordVisibility

        passwordtb.UseSystemPasswordChar = True
        NewPassTB.UseSystemPasswordChar = True
        ConfirmPasswordTB.UseSystemPasswordChar = True

    End Sub

    Private Sub ButtonHover(sender As Object, e As EventArgs)
        Dim btn As System.Windows.Forms.Button =
    CType(sender, System.Windows.Forms.Button)

        If btn.Name.Contains("close") Then
            btn.BackColor = Color.Red
            btn.ForeColor = Color.White
        Else
            btn.BackColor = Color.Blue
            btn.ForeColor = Color.White
        End If
    End Sub

    Private Sub ButtonLeave(sender As Object, e As EventArgs)
        Dim btn As System.Windows.Forms.Button =
    CType(sender, System.Windows.Forms.Button)

        If btn.Name.Contains("close") Then
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        Else
            btn.BackColor = Color.Black
            btn.ForeColor = Color.White
        End If
    End Sub
    '-------------------------------------------------------------------------
    'FOR THE SHOW/HIDE PASSWORD BUTTONS
    Private Sub TogglePasswordVisibility(sender As Object, e As EventArgs)
        Dim btn As System.Windows.Forms.Button =
    CType(sender, System.Windows.Forms.Button)


        Select Case btn.Name
            Case "ShowPassBtn"
                ToggleVisibility(passwordtb, ShowPassBtn)

            Case "ShowNewPassBtn"
                ToggleVisibility(NewPassTB, ShowNewPassBtn)

            Case "ShowConfirmPassBtn"
                ToggleVisibility(ConfirmPasswordTB, ShowConfirmPassBtn)
        End Select
    End Sub

    Private Sub ToggleVisibility(
    tb As TextBox,
    btn As System.Windows.Forms.Button
)

        If tb.UseSystemPasswordChar Then
            tb.UseSystemPasswordChar = False
            btn.Text = "🙈"
        Else
            tb.UseSystemPasswordChar = True
            btn.Text = "👁"
        End If
    End Sub
    '-------------------------------------------------------------------------
    'FORGOT PASSWORD FUNCTIONALITY
    Private Sub UNFPasstb_Leave(sender As Object, e As EventArgs) Handles UNFPasstb.Leave
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT account_type, security_question FROM user WHERE username=@username", conn)
            cmd.Parameters.AddWithValue("@username", UNFPasstb.Text)
            Dim reader = cmd.ExecuteReader

            If reader.Read Then
                Dim accType As String = reader("account_type").ToString.ToLower()

                If accType = "cashier" Then
                    MessageBox.Show("Cashiers are not allowed to use Forgot Password. Please contact the admin.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    SSQcb.Text = ""
                    UNFPasstb.Clear()
                    reader.Close()
                    conn.Close()
                    Exit Sub
                End If

                ' If admin, show security question
                SSQcb.Text = reader("security_question").ToString
            Else
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SSQcb.Text = ""
            End If

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    '-------------------------------------------------------------------------
    'VERIFY SECURITY QUESTION AND ANSWER
    Private Sub Continuebtn_Click(sender As Object, e As EventArgs) Handles Continuebtn.Click
        Dim username As String = UNFPasstb.Text.Trim()
        Dim question As String = SSQcb.Text.Trim()
        Dim answer As String = Answertb.Text.Trim()

        If username = "" Or question = "" Or answer = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim hashedAnswer As String = HashText(answer)
                Dim query As String = "SELECT * FROM user WHERE username=@username AND security_question=@question AND security_answer=@answer"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@question", question)
                    cmd.Parameters.AddWithValue("@answer", hashedAnswer)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        currentUsername = username
                        MessageBox.Show("Security answer verified. Please reset your password.", "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Hide forgot fields, show reset panel
                        UNFPasstb.Text = ""
                        SSQcb.Text = ""
                        Answertb.Text = ""
                        ShowPanelSmooth(RPasswordPanel)
                        RPasswordPanel.Location = New Point(0, 0)
                    Else
                        MessageBox.Show("Incorrect information. Please try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
        End Try
    End Sub
    '-------------------------------------------------------------------------
    'MD5 HASH FUNCTION (FOR SECURITY ANSWER)
    Private Function GetMd5Hash(input As String) As String
        Using md5 As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function
    '-------------------------------------------------------------------------
    'SET NEW PASSWORD
    Dim currentUsername As String = ""

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim newPass As String = NewPassTB.Text.Trim()
        Dim confirmPass As String = ConfirmPasswordTB.Text.Trim()

        If newPass = "" Or confirmPass = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim hashedPass As String = HashText(newPass)
                Dim query As String = "UPDATE user SET password=@password WHERE username=@username"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@password", hashedPass)
                    cmd.Parameters.AddWithValue("@username", currentUsername)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NewPassTB.Text = ""
            ConfirmPasswordTB.Text = ""
            RPasswordPanel.Visible = False
            LoginPanel.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        End Try
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
    End Sub

    Private Sub LockLogin(seconds As Integer)

        remainingSeconds = seconds

        loginbtn.Enabled = False
        usernametb.Enabled = False
        passwordtb.Enabled = False

        lblLockCountdown.Visible = True
        UpdateCountdownLabel()


        countdownTimer.Interval = 1000
        AddHandler countdownTimer.Tick, AddressOf CountdownTick
        countdownTimer.Start()

        ' Timer for unlock
        lockTimer.Interval = seconds * 1000
        AddHandler lockTimer.Tick, AddressOf UnlockLogin
        lockTimer.Start()
    End Sub

    Private Sub CountdownTick(sender As Object, e As EventArgs)
        remainingSeconds -= 1

        If remainingSeconds <= 0 Then
            countdownTimer.Stop()
            RemoveHandler countdownTimer.Tick, AddressOf CountdownTick
            lblLockCountdown.Visible = False
            Exit Sub
        End If

        UpdateCountdownLabel()
    End Sub
    Private Sub UpdateCountdownLabel()
        lblLockCountdown.Text =
        "Login failed. Try again in " & FormatRemainingTime(remainingSeconds)
    End Sub


    Private Function FormatRemainingTime(seconds As Integer) As String


        If seconds < 60 Then
            Return $"{seconds} second{If(seconds = 1, "", "s")}"
        End If

        If seconds < 3600 AndAlso seconds Mod 60 = 0 Then
            Dim mins As Integer = seconds \ 60
            Return $"{mins} minute{If(mins = 1, "", "s")}"
        End If


        If seconds < 3600 Then
            Dim mins As Integer = seconds \ 60
            Dim secs As Integer = seconds Mod 60
            Return $"{mins}:{secs:00}"
        End If


        Dim hours As Integer = Math.Ceiling(seconds / 3600.0)
        Return $"{hours} hour{If(hours = 1, "", "s")}"

    End Function



    Private Sub UnlockLogin(sender As Object, e As EventArgs)

        lockTimer.Stop()
        RemoveHandler lockTimer.Tick, AddressOf UnlockLogin

        loginbtn.Enabled = True
        usernametb.Enabled = True
        passwordtb.Enabled = True

        lblLockCountdown.Visible = False

        failedAttempts = 0
    End Sub

    Private Sub LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles LoginPanel.Paint

    End Sub

    Private Sub lblLockCountdown_Click(sender As Object, e As EventArgs) Handles lblLockCountdown.Click

    End Sub
End Class
