
Imports System.Windows.Forms

Module AlertFormMngr
    Public Sub ShowAlert(alertForm As Form, parentForm As Form)

        alertForm.TopLevel = False
        alertForm.FormBorderStyle = FormBorderStyle.None
        alertForm.StartPosition = FormStartPosition.Manual
        alertForm.Opacity = 0

        parentForm.Controls.Add(alertForm)
        alertForm.BringToFront()

        CenterAlert(alertForm, parentForm)
        alertForm.Show()
        FadeIn(alertForm)

    End Sub

    Private Sub CenterAlert(alertForm As Form, parentForm As Form)
        Dim x As Integer = (parentForm.ClientSize.Width - alertForm.Width) \ 2
        Dim y As Integer = (parentForm.ClientSize.Height - alertForm.Height) \ 2
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

