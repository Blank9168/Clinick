Public Class WelcomeFrm
    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        LoginFrm.Show()
        Me.Hide()
    End Sub
End Class