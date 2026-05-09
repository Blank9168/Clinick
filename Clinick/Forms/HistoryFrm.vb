Public Class HistoryFrm

    ' Fills dgvHistory with all logged events, newest first
    ' Optionally filtered by event type via cmbFilterEvent
    Public Sub RefreshHistory()
        dgvHistory.Rows.Clear()

        Dim filterEvent As String = ""
        If cmbFilterEvent.SelectedIndex > 0 Then
            filterEvent = cmbFilterEvent.SelectedItem.ToString().ToLower()
        End If

        ' Loop backwards so newest events appear at the top
        For i As Integer = HistoryCount - 1 To 0 Step -1
            If filterEvent <> "" Then
                If Not arrHistoryEvent(i).ToLower().Contains(filterEvent) Then
                    Continue For
                End If
            End If

            dgvHistory.Rows.Add(
                arrHistoryTime(i),
                arrHistoryEvent(i),
                arrHistoryPatient(i),
                arrHistoryDetails(i)
            )
        Next

        ' Show total event count
        lblEventCount.Text = "Total Events: " & HistoryCount.ToString()
    End Sub

    Private Sub HistoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate filter ComboBox with all event types
        cmbFilterEvent.Items.Clear()
        cmbFilterEvent.Items.Add("All")
        cmbFilterEvent.Items.Add("Patient Added")
        cmbFilterEvent.Items.Add("Appointment Set")
        cmbFilterEvent.Items.Add("Status Changed")
        cmbFilterEvent.Items.Add("Patient Edited")
        cmbFilterEvent.Items.Add("Patient Deleted")
        cmbFilterEvent.SelectedIndex = 0

        RefreshHistory()
    End Sub

    Private Sub cmbFilterEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterEvent.SelectedIndexChanged
        RefreshHistory()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        AdminFrm.Show()
        Me.Close()
    End Sub

End Class