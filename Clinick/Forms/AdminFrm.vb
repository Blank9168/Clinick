Public Class AdminFrm

    ' Tracks which array index is currently selected/loaded into the edit fields
    Private selectedIndex As Integer = -1

    ' Updates the 4 summary count labels at the top of AdminFrm
    ' Called every time the grid refreshes or a patient is edited/deleted
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

        ' Also update the dashboard counters in GlobalModule for reference
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
        lblGeneral.Text = TotalGeneral.ToString()
        lblDental.Text = TotalDental.ToString()
        lblPedia.Text = TotalPedia.ToString()
    End Sub

    ' Fills the grid with all patients, respecting current filter and search
    Public Sub RefreshGrid()
        dgvAdmin.Rows.Clear()

        Dim filterStatus As String = ""
        If cmbFilter.SelectedIndex > 0 Then
            filterStatus = cmbFilter.SelectedItem.ToString().ToLower()
        End If

        Dim searchText As String = txtSearch.Text.Trim().ToLower()

        For i As Integer = 0 To CurrentCount - 1
            ' Filter by status
            If filterStatus <> "" Then
                If arrStatus(i).ToLower() <> filterStatus Then
                    Continue For
                End If
            End If

            ' Search by name or ID
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
        ClearEditFields()
    End Sub

    ' Clears the edit fields at the bottom and resets selectedIndex
    Private Sub ClearEditFields()
        selectedIndex = -1
        txtEditName.Clear()
        txtEditContact.Clear()
        txtEditSchedule.Clear()
        cmbEditStatus.SelectedIndex = -1
        lblEditID.Text = "No patient selected"
    End Sub

    ' Swap helper — keeps all parallel arrays in sync during sort
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
        ' Populate filter ComboBox
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All")
        cmbFilter.Items.Add("Pending")
        cmbFilter.Items.Add("Completed")
        cmbFilter.Items.Add("Cancelled")
        cmbFilter.SelectedIndex = 0

        ' Populate edit status ComboBox
        cmbEditStatus.Items.Clear()
        cmbEditStatus.Items.Add("Pending")
        cmbEditStatus.Items.Add("Completed")
        cmbEditStatus.Items.Add("Cancelled")

        ' Start live clock
        tmrClock.Interval = 1000
        tmrClock.Start()
    End Sub

    Private Sub AdminFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
        RefreshGrid()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs)
        LblDate.Text = Date.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        AdminFrm.Hide()
        LoginFrm.Show()
    End Sub

    ' Filter, Search, Sort 

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        RefreshGrid()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        RefreshGrid
    End Sub

    Private Sub btnSortName_Click(sender As Object, e As EventArgs)
        ' Bubble sort by patient name A → Z
        For i = 0 To CurrentCount - 2
            For j = 0 To CurrentCount - 2 - i
                If String.Compare(arrNames(j), arrNames(j + 1)) > 0 Then
                    SwapAllArrays(j, j + 1)
                End If
            Next
        Next
        RefreshGrid
    End Sub

    Private Sub btnSortSched_Click(sender As Object, e As EventArgs)
        ' Bubble sort by schedule, "Not Set" pushed to bottom
        For i = 0 To CurrentCount - 2
            For j = 0 To CurrentCount - 2 - i
                Dim a = arrSchedule(j)
                Dim b = arrSchedule(j + 1)
                Dim aNotSet = a = "Not Set"
                Dim bNotSet = b = "Not Set"

                If aNotSet AndAlso Not bNotSet Then
                    SwapAllArrays(j, j + 1)
                ElseIf Not aNotSet AndAlso Not bNotSet Then
                    If String.Compare(a, b) > 0 Then
                        SwapAllArrays(j, j + 1)
                    End If
                End If
            Next
        Next
        RefreshGrid
    End Sub

    ' Row Selection → Load Edit Fields 

    ' When admin clicks a row, load that patient's data into the edit fields below
    Private Sub dgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellClick
        If e.RowIndex >= 0 Then
            Dim clickedID As String = dgvAdmin.Rows(e.RowIndex).Cells(0).Value.ToString()

            ' Find the matching index in the parallel arrays
            For i As Integer = 0 To CurrentCount - 1
                If arrID(i) = clickedID Then
                    selectedIndex = i

                    ' Load data into edit fields
                    lblEditID.Text = arrID(i)
                    txtEditName.Text = arrNames(i)
                    txtEditContact.Text = arrContact(i)
                    txtEditSchedule.Text = arrSchedule(i)

                    ' Set the status dropdown to match current status
                    Dim statusIdx As Integer = cmbEditStatus.Items.IndexOf(arrStatus(i))
                    If statusIdx >= 0 Then
                        cmbEditStatus.SelectedIndex = statusIdx
                    End If

                    Exit For
                End If
            Next
        End If
    End Sub

    ' FEATURE: Edit Patient

    ' Saves the edited values from the bottom fields back into the parallel arrays
    ' Only updates name, contact, schedule, and status — ID and service are not editable
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If selectedIndex = -1 Then
            MessageBox.Show("Please select a patient from the grid first.")
            Return
        End If

        If txtEditName.Text.Trim() = "" Then
            MessageBox.Show("Patient name cannot be empty.")
            Return
        End If

        ' Save changes back to parallel arrays
        arrNames(selectedIndex) = txtEditName.Text.Trim()
        arrContact(selectedIndex) = txtEditContact.Text.Trim()
        arrSchedule(selectedIndex) = txtEditSchedule.Text.Trim()

        If cmbEditStatus.SelectedIndex >= 0 Then
            arrStatus(selectedIndex) = cmbEditStatus.SelectedItem.ToString()
        End If

        MessageBox.Show("Patient " & lblEditID.Text & " updated successfully.")
        RefreshGrid()
    End Sub

    ' FEATURE: Delete Patient

    ' Removes the selected patient by shifting all array values after it one step left
    ' This keeps the parallel arrays packed without gaps
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedIndex = -1 Then
            MessageBox.Show("Please select a patient from the grid first.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete patient " & lblEditID.Text & "?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            ' Shift all entries after selectedIndex one position to the left
            ' This fills the gap left by the deleted patient
            For i As Integer = selectedIndex To CurrentCount - 2
                arrID(i) = arrID(i + 1)
                arrNames(i) = arrNames(i + 1)
                arrContact(i) = arrContact(i + 1)
                arrSex(i) = arrSex(i + 1)
                arrService(i) = arrService(i + 1)
                arrStatus(i) = arrStatus(i + 1)
                arrSchedule(i) = arrSchedule(i + 1)
                arrCancelReason(i) = arrCancelReason(i + 1)
            Next

            ' Clear the last slot (now a duplicate after the shift)
            arrID(CurrentCount - 1) = ""
            arrNames(CurrentCount - 1) = ""
            arrContact(CurrentCount - 1) = ""
            arrSex(CurrentCount - 1) = ""
            arrService(CurrentCount - 1) = ""
            arrStatus(CurrentCount - 1) = ""
            arrSchedule(CurrentCount - 1) = ""
            arrCancelReason(CurrentCount - 1) = ""

            ' Decrease total patient count
            CurrentCount -= 1

            MessageBox.Show("Patient deleted successfully.")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnClearEdit_Click(sender As Object, e As EventArgs) Handles btnClearEdit.Click
        ClearEditFields()
    End Sub

End Class