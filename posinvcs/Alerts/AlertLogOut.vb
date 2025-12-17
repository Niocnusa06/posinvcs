Public Class AlertLogOut
    Public Event LogoutConfirmed()

    Private Sub btnyeslo_Click(sender As Object, e As EventArgs) Handles btnyeslo.Click
        RaiseEvent LogoutConfirmed()
        Me.Close()
    End Sub

    Private Sub btnnolo_Click(sender As Object, e As EventArgs) Handles btnnolo.Click
        Me.Close()
    End Sub
End Class