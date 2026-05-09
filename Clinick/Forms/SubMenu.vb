Public Class SubMenu


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnDentalS_Click(sender As Object, e As EventArgs) Handles btnDentalS.Click
        Service = "Dental"
        RegisterForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnGeneralCons_Click(sender As Object, e As EventArgs) Handles btnGeneralCons.Click
        Service = "General"
        RegisterForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPediatrics_Click(sender As Object, e As EventArgs) Handles btnPediatrics.Click
        Service = "Pediatrics"
        RegisterForm.Show()
        Me.Hide()
    End Sub
End Class
