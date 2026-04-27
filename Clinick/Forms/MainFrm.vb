Public Class MainFrm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnGeneralCons_Click(sender As Object, e As EventArgs) Handles btnGeneralCons.Click
        GeneralConsultationFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDentalS_Click(sender As Object, e As EventArgs) Handles btnDentalS.Click
        DentalServicesFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPediatrics_Click(sender As Object, e As EventArgs) Handles btnPediatrics.Click
        PediatricsFrm.Show()
        Me.Hide()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalApt.Text = RecordCount.ToString()
        lblGenApt.Text = TotalGeneral.ToString()
        lblDenApt.Text = TotalDental.ToString()
        lblPedApt.Text = TotalPedia.ToString()

    End Sub
End Class