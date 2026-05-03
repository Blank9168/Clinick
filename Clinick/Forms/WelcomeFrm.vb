Public Class WelcomeFrm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnGetStarted_Click_1(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        LoginFrm.Show()
        Me.Hide()
    End Sub

    Private Sub WelcomeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class