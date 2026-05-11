Public Class AdminFrm

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

        TotalGeneral = 0
        TotalDental = 0
        TotalPedia = 0
        For i As Integer = 0 To CurrentCount - 1
            If arrService(i) IsNot Nothing Then
                If arrService(i).Contains("General") Then TotalGeneral += 1
                If arrService(i).Contains("Dental") Then TotalDental += 1
                If arrService(i).Contains("Pedia") Then TotalPedia += 1
            End If
        Next

        lblTotal.Text = total.ToString()
        lblPending.Text = pending.ToString()
        lblCompleted.Text = completed.ToString()
        lblCancelled.Text = cancelled.ToString()
    End Sub

    Public Sub RefreshGrid()
        dgvAdmin.Rows.Clear()

        Dim filterStatus As String = ""
        If cmbFilter.SelectedIndex > 0 Then
            filterStatus = cmbFilter.SelectedItem.ToString().ToLower()
        End If

        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        For i As Integer = 0 To CurrentCount - 1
            If filterStatus <> "" Then
                If arrStatus(i).ToLower() <> filterStatus Then
                    Continue For
                End If
            End If

            If searchText <> "" Then
                Dim nameMatch As Boolean = arrNames(i).ToLower().Contains(searchText)
                Dim idMatch As Boolean = arrID(i).ToLower().Contains(searchText)
                If Not nameMatch AndAlso Not idMatch Then
                    Continue For
                End If
            End If

            dgvAdmin.Rows.Add(arrID(i), arrNames(i), arrContact(i), arrSex(i), arrService(i), arrSchedule(i), arrStatus(i))
        Next

        UpdateSummaryCounts()
    End Sub

    Private Sub SwapAllArrays(i As Integer, j As Integer)
        Dim tmpStr As String
        tmpStr = arrID(i) : arrID(i) = arrID(j) : arrID(j) = tmpStr
        tmpStr = arrNames(i) : arrNames(i) = arrNames(j) : arrNames(j) = tmpStr
        tmpStr = arrContact(i) : arrContact(i) = arrContact(j) : arrContact(j) = tmpStr
        tmpStr = arrSex(i) : arrSex(i) = arrSex(j) : arrSex(j) = tmpStr
        tmpStr = arrService(i) : arrService(i) = arrService(j) : arrService(j) = tmpStr
        tmpStr = arrStatus(i) : arrStatus(i) = arrStatus(j) : arrStatus(j) = tmpStr
        tmpStr = arrSchedule(i) : arrSchedule(i) = arrSchedule(j) : arrSchedule(j) = tmpStr
        tmpStr = arrCancelReason(i) : arrCancelReason(i) = arrCancelReason(j) : arrCancelReason(j) = tmpStr
    End Sub

    ' Form Events

    Private Sub AdminFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All")
        cmbFilter.Items.Add("Pending")
        cmbFilter.Items.Add("Completed")
        cmbFilter.Items.Add("Cancelled")
        cmbFilter.SelectedIndex = 0

        ' Set up Status ComboBox column items so values are valid when grid loads
        Dim statusCol As DataGridViewComboBoxColumn = CType(dgvAdmin.Columns("Status"), DataGridViewComboBoxColumn)
        statusCol.Items.Clear()
        statusCol.Items.Add("Pending")
        statusCol.Items.Add("Completed")
        statusCol.Items.Add("Cancelled")

        tmrClock.Interval = 1000
        tmrClock.Start()
    End Sub

    Private Sub AdminFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
        RefreshGrid()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
    End Sub

    ' Navigation

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginFrm.Show()
    End Sub

    ' Opens ReportsFrm — daily, monthly, patient records + print/PDF/Excel export
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Me.Hide()
        ReportsFrm.Show()
    End Sub

    ' Opens MedicalRecordsFrm for the selected patient row
    ' Admin must click a row first before clicking this button
    Private Sub btnMedicalRecords_Click(sender As Object, e As EventArgs) Handles btnMedicalRecords.Click
        If dgvAdmin.CurrentRow Is Nothing OrElse dgvAdmin.CurrentRow.Index < 0 Then
            MessageBox.Show("Please click on a patient row first.")
            Return
        End If

        Dim clickedID As String = dgvAdmin.CurrentRow.Cells(0).Value.ToString()
        For i As Integer = 0 To CurrentCount - 1
            If arrID(i) = clickedID Then
                MedicalRecordsFrm.TargetIndex = i
                MedicalRecordsFrm.CallerForm = "Admin"
                Me.Hide()
                MedicalRecordsFrm.Show()
                Exit For
            End If
        Next
    End Sub

    ' Filter, Search, Sort 

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        RefreshGrid()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshGrid()
    End Sub

    Private Sub btnSortName_Click(sender As Object, e As EventArgs) Handles btnSortName.Click
        For i As Integer = 0 To CurrentCount - 2
            For j As Integer = 0 To CurrentCount - 2 - i
                If String.Compare(arrNames(j), arrNames(j + 1)) > 0 Then
                    SwapAllArrays(j, j + 1)
                End If
            Next
        Next
        RefreshGrid()
    End Sub

    Private Sub btnSortSched_Click(sender As Object, e As EventArgs) Handles btnSortSched.Click
        For i As Integer = 0 To CurrentCount - 2
            For j As Integer = 0 To CurrentCount - 2 - i
                Dim a As String = arrSchedule(j)
                Dim b As String = arrSchedule(j + 1)
                Dim aNotSet As Boolean = (a = "Not Set")
                Dim bNotSet As Boolean = (b = "Not Set")

                If aNotSet AndAlso Not bNotSet Then
                    SwapAllArrays(j, j + 1)
                ElseIf Not aNotSet AndAlso Not bNotSet Then
                    If String.Compare(a, b) > 0 Then
                        SwapAllArrays(j, j + 1)
                    End If
                End If
            Next
        Next
        RefreshGrid()
    End Sub

    ' Status Change in Grid 

    Private Sub dgvAdmin_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvAdmin.CurrentCellDirtyStateChanged
        If dgvAdmin.IsCurrentCellDirty Then
            dgvAdmin.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvAdmin_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
            If dgvAdmin.Rows(e.RowIndex).Cells(0).Value IsNot Nothing AndAlso
               dgvAdmin.Rows(e.RowIndex).Cells(6).Value IsNot Nothing Then

                Dim selectedID As String = dgvAdmin.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim newStatus As String = dgvAdmin.Rows(e.RowIndex).Cells(6).Value.ToString

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

    Private Sub dgvAdmin_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvAdmin.DataError
        e.Cancel = True
    End Sub

    ' Row Click → Open EditPatientFrm 

    ' in EditPatientFrm so the admin doesn't have to type it manually.
    ' EditPatientFrm uses its own search approach so we just pass the ID as a string.
    Private Sub dgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellClick
        If e.RowIndex >= 0 Then
            Dim clickedID As String = dgvAdmin.Rows(e.RowIndex).Cells(0).Value.ToString()

            ' Pre-fill the search box in EditPatientFrm with the clicked patient's ID
            EditPatientFrm.txtSearchID.Text = clickedID


            Me.Hide()
            EditPatientFrm.Show()
        End If
    End Sub

End Class