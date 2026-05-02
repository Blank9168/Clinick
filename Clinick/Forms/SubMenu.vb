Public Class SubMenu
    Private Sub SubMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblServiceType.Text = Service

        If Service = "Dental" Then
            PicServiceIcon.Image = ForPic.PictureDental.Image
        ElseIf Service = "Pediatrics" Then
            PicServiceIcon.Image = ForPic.PicturePedia.Image
        ElseIf Service = "General" Then
            PicServiceIcon.Image = ForPic.PictureGeneral.Image
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainFrm.Show()
        Me.Close()
    End Sub
    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        AddPatient_Frm.Show()
        Me.Close()
    End Sub

    Private Sub btnAppointPatient_Click(sender As Object, e As EventArgs) Handles btnAppointPatient.Click
        RegisterForm.Show()
        Me.Close()
    End Sub
End Class