Public Class MainFrm
    Public Sub RefreshSummaryGrid()
        dgvSummary.Rows.Clear()

        Dim filterStatus As String = ""
        ' cmbFilter is the filter ComboBox added to the form
        If cmbFilter.SelectedIndex > 0 Then
            filterStatus = cmbFilter.SelectedItem.ToString().ToLower()
        End If

        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        For i As Integer = 0 To CurrentCount - 1
            ' Filter by status 
            If filterStatus <> "" Then
                If arrStatus(i).ToLower() <> filterStatus Then
                    Continue For  ' skip rows that don't match filter
                End If
            End If

            ' Search by patient name or ID
            If searchText <> "" Then
                Dim nameMatch As Boolean = arrNames(i).ToLower().Contains(searchText)
                Dim idMatch As Boolean = arrID(i).ToLower().Contains(searchText)
                If Not nameMatch AndAlso Not idMatch Then
                    Continue For  ' skip rows that don't match search
                End If
            End If

            dgvSummary.Rows.Add(arrID(i), arrNames(i), arrContact(i), arrService(i), arrSchedule(i), arrStatus(i))
        Next

    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the filter ComboBox
        ' "All" shows every record; the rest filter by status
        UpdateSummaryCounts()

        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All")
        cmbFilter.Items.Add("Pending")
        cmbFilter.Items.Add("Completed")
        cmbFilter.Items.Add("Cancelled")
        cmbFilter.SelectedIndex = 0  ' default: show All

        ' Set up Status ComboBox column items so values are valid when grid loads
        Dim statusCol As DataGridViewComboBoxColumn = CType(dgvSummary.Columns("Status"), DataGridViewComboBoxColumn)
        statusCol.Items.Clear()
        statusCol.Items.Add("Pending")
        statusCol.Items.Add("Completed")
        statusCol.Items.Add("Cancelled")

        ' Start the live clock timer (ticks every second)
        tmrClock.Interval = 1000
        tmrClock.Start()
    End Sub

    Private Sub MainFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
        RefreshSummaryGrid()
        UpdateSummaryCounts()

    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
    End Sub

    ' Navigation Buttons 

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginFrm.Show()
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

    Private Sub dgvSummary_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvSummary.CurrentCellDirtyStateChanged
        If dgvSummary.IsCurrentCellDirty Then
            dgvSummary.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
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

    ' Silences the "value is not valid" ComboBox error dialog
    Private Sub dgvSummary_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSummary.DataError
        e.Cancel = True
    End Sub

    ' Filter by Status 
    ' When the user picks a status from cmbFilter, the grid immediately
    ' shows only patients with that status. Picking "All" shows everyone.
    ' cmbFilter must be added to MainFrm in the designer (ComboBox, DropDownStyle = DropDownList)
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        RefreshSummaryGrid()
    End Sub

    ' Search by Name or ID 
    ' Typing in txtSearch filters the grid in real time.
    ' It matches against both Patient Name and Patient ID columns.
    ' txtSearch must be added to MainFrm in the designer (TextBox)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RefreshSummaryGrid()
    End Sub

    ' Sort by Name or Schedule
    ' btnSortName and btnSortSched are two buttons added to MainFrm in the designer.
    ' They perform a simple bubble sort on the parallel arrays, then refresh the grid.

    Private Sub btnSortName_Click(sender As Object, e As EventArgs) Handles btnSortName.Click
        ' Bubble sort all parallel arrays by patient name (A → Z)
        For i As Integer = 0 To CurrentCount - 2
            For j As Integer = 0 To CurrentCount - 2 - i
                If String.Compare(arrNames(j), arrNames(j + 1)) > 0 Then
                    SwapAllArrays(j, j + 1)
                End If
            Next
        Next
        RefreshSummaryGrid()
    End Sub

    Private Sub btnSortSched_Click(sender As Object, e As EventArgs) Handles btnSortSched.Click
        ' Bubble sort all parallel arrays by schedule date/time (earliest first)
        ' "Not Set" entries are pushed to the bottom
        For i As Integer = 0 To CurrentCount - 2
            For j As Integer = 0 To CurrentCount - 2 - i
                Dim a As String = arrSchedule(j)
                Dim b As String = arrSchedule(j + 1)

                ' Push "Not Set" to the bottom
                Dim aIsNotSet As Boolean = (a = "Not Set")
                Dim bIsNotSet As Boolean = (b = "Not Set")

                If aIsNotSet AndAlso Not bIsNotSet Then
                    SwapAllArrays(j, j + 1)
                ElseIf Not aIsNotSet AndAlso Not bIsNotSet Then
                    If String.Compare(a, b) > 0 Then
                        SwapAllArrays(j, j + 1)
                    End If
                End If
            Next
        Next
        RefreshSummaryGrid()
    End Sub

    ' Helper Sub: swaps all parallel array values at positions i and j
    ' This keeps all arrays in sync during sorting so no patient data gets mixed up
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

    Private Sub btnEditPatient_Click(sender As Object, e As EventArgs) Handles btnEditPatient.Click
        EditPatientFrm.Show()
        Me.Hide()
    End Sub

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


End Class