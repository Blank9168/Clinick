Public Class MainFrm
    Public Sub UpdateSummaryCounts()
        Dim total As Integer = CurrentCount
        Dim pending As Integer = 0
        Dim completed As Integer = 0
        Dim cancelled As Integer = 0

        For i As Integer = 0 To CurrentCount - 1
            If arrStatus(i) IsNot Nothing Then
                Select Case arrStatus(i).ToLower()
                    Case "pending"
                        pending += 1
                    Case "completed"
                        completed += 1
                    Case "cancelled"
                        cancelled += 1
                End Select
            End If
        Next
        lblTotal.Text = total.ToString()
        lblPending.Text = pending.ToString()
        lblCompleted.Text = completed.ToString()
        lblCancelled.Text = cancelled.ToString()
    End Sub

    Public Sub RefreshSummaryGrid()
        dgvSummary.Rows.Clear()

        For i As Integer = 0 To CurrentCount - 1
            dgvSummary.Rows.Add(arrID(i), arrNames(i), arrContact(i), arrService(i), arrSchedule(i), arrStatus(i))
        Next
        UpdateSummaryCounts()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub MainFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
        RefreshSummaryGrid()
    End Sub


    Private Sub btnDentalS_Click(sender As Object, e As EventArgs) Handles btnDentalS.Click
        Service = "Dental"
        SubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnGeneralCons_Click(sender As Object, e As EventArgs) Handles btnGeneralCons.Click
        Service = "General"
        SubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnPediatrics_Click(sender As Object, e As EventArgs) Handles btnPediatrics.Click
        Service = "Pediatrics"
        SubMenu.Show()
        Me.Hide()
    End Sub



    Private Sub dgvSummary_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSummary.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
            If dgvSummary.Rows(e.RowIndex).Cells(0).Value IsNot Nothing AndAlso
           dgvSummary.Rows(e.RowIndex).Cells(5).Value IsNot Nothing Then

                Dim selectedID As String = dgvSummary.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim newStatus As String = dgvSummary.Rows(e.RowIndex).Cells(5).Value.ToString

                For i As Integer = 0 To CurrentCount - 1
                    If arrID(i) = selectedID Then
                        arrStatus(i) = newStatus
                        Exit For
                    End If
                Next
                UpdateSummaryCounts()
            End If
        End If
    End Sub
End Class