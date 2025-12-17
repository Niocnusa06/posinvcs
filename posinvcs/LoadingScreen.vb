Imports System.Windows.Forms

Public Class LoadingScreen
    Private loadingImages(23) As PictureBox
    Private currentImageIndex As Integer = 0
    Private loadProgress As Integer = 0
    Private WithEvents Timer As New Timer()

    Private Sub LoadingScreen_Load(sender As Object, a As EventArgs) Handles MyBase.Load
        Panel2.Width = 0

        loadingImages(0) = icon1
        loadingImages(1) = icon2
        loadingImages(2) = icon3
        loadingImages(3) = icon4
        loadingImages(4) = icon5
        loadingImages(5) = icon6
        loadingImages(6) = icon7
        loadingImages(7) = icon8
        loadingImages(8) = icon9
        loadingImages(9) = icon10
        loadingImages(10) = icon11
        loadingImages(11) = icon12
        loadingImages(12) = icon13
        loadingImages(13) = icon14
        loadingImages(14) = icon15
        loadingImages(15) = icon16
        loadingImages(16) = icon17
        loadingImages(17) = icon18
        loadingImages(18) = icon19
        loadingImages(19) = icon20
        loadingImages(20) = icon21
        loadingImages(21) = icon22
        loadingImages(22) = icon23

        Timer1.Interval = 100
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 1 To 23
            Dim pic As PictureBox = CType(Me.Controls.Find("icon" & i.ToString(), True)(0), PictureBox)
            pic.Visible = False
        Next
        Dim mainIndex As Integer = currentImageIndex + 1
        Dim mainPic As PictureBox = CType(Me.Controls.Find("icon" & mainIndex.ToString(), True)(0), PictureBox)
        mainPic.Visible = True

        loadProgress += 2
        If loadProgress <= 50 Then
            Panel2.Width = CInt((loadProgress / 50) * (Panel1.Width / 2))
        Else
            Panel2.Width = CInt(((loadProgress - 50) / 50) * (Panel1.Width / 2)) + Panel1.Width / 2
        End If
        'Panel2.Width += CInt(Panel1.Width / 23)
        'If Panel2.Width > Panel1.Width Then
        '    Panel2.Width = Panel1.Width
        'End If

        Dim percent As Integer = CInt((Panel2.Width / Panel1.Width) * 100)
            percentlbl.Text = "Loading... " & percent.ToString() & "%"
        If percent >= 100 Then
            Timer.Stop()
            Me.Hide()
            LoginForm.Show()
        End If

        currentImageIndex = (currentImageIndex + 1) Mod 23
    End Sub

End Class
