Public Class SubMenu


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnDentalS_Click(sender As Object, e As EventArgs) Handles btnDentalS.Click
        Service = "Dental"
        AppointmentFrm.Show()
        Me.Hide()

    End Sub

    Private Sub btnGeneralCons_Click(sender As Object, e As EventArgs) Handles btnGeneralCons.Click
        Service = "General"
        AppointmentFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPediatrics_Click(sender As Object, e As EventArgs) Handles btnPediatrics.Click
        Service = "Pediatrics"
        AppointmentFrm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
