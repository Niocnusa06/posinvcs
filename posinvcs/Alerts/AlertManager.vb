Imports System.Windows.Forms

Module AlertManager


    Public Sub ShowAlert(alertForm As Form, container As Panel)


        alertForm.TopLevel = False
        alertForm.FormBorderStyle = FormBorderStyle.None
        alertForm.Dock = DockStyle.None
        alertForm.Opacity = 0
        container.Controls.Add(alertForm)
        alertForm.BringToFront()
        CenterAlert(alertForm, container)
        alertForm.Show()
        FadeIn(alertForm)

    End Sub



    Private Sub CenterAlert(alertForm As Form, container As Panel)
        Dim x As Integer = (container.Width - alertForm.Width) \ 2
        Dim y As Integer = (container.Height - alertForm.Height) \ 2

        alertForm.Location = New Point(x, y)
    End Sub



    Private Sub FadeIn(frm As Form)
        Dim t As New Timer()
        t.Interval = 15

        AddHandler t.Tick,
            Sub()
                If frm.Opacity < 1 Then
                    frm.Opacity += 0.08
                Else
                    t.Stop()
                End If
            End Sub

        t.Start()
    End Sub

End Module
