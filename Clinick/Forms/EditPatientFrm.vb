Public Class EditPatientFrm

    ' Stores the array index of the patient being edited
    ' Set by AdminFrm before opening this form
    Public TargetIndex As Integer = -1

    Private Sub EditPatientFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TargetIndex = -1 Then
            MessageBox.Show("No patient selected.")
            Me.Close()
            Return
        End If

        ' Load the selected patient's data into the fields
        lblEditID.Text = arrID(TargetIndex)
        txtEditName.Text = arrNames(TargetIndex)
        txtEditContact.Text = arrContact(TargetIndex)

        ' Populate and set the status dropdown
        cmbEditStatus.Items.Clear()
        cmbEditStatus.Items.Add("Pending")
        cmbEditStatus.Items.Add("Completed")
        cmbEditStatus.Items.Add("Cancelled")

        Dim statusIdx As Integer = cmbEditStatus.Items.IndexOf(arrStatus(TargetIndex))
        If statusIdx >= 0 Then
            cmbEditStatus.SelectedIndex = statusIdx
        End If
    End Sub

    ' Save Edit

    ' Writes the updated values back into the parallel arrays at TargetIndex
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If txtEditName.Text.Trim() = "" Then
            MessageBox.Show("Patient name cannot be empty.")
            Return
        End If

        arrNames(TargetIndex) = txtEditName.Text.Trim()
        arrContact(TargetIndex) = txtEditContact.Text.Trim()

        If cmbEditStatus.SelectedIndex >= 0 Then
            arrStatus(TargetIndex) = cmbEditStatus.SelectedItem.ToString()
        End If

        MessageBox.Show("Patient " & lblEditID.Text & " updated successfully.")

        ' Refresh AdminFrm grid and close this form
        AdminFrm.RefreshGrid()
        Me.Close()
    End Sub

    ' Delete Patient 

    ' Removes the patient by shifting all entries after TargetIndex one step left
    ' This keeps the parallel arrays packed with no empty gaps in the middle
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete patient " & lblEditID.Text & "?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            ' Shift all entries after the deleted patient one position left
            For i As Integer = TargetIndex To CurrentCount - 2
                arrID(i) = arrID(i + 1)
                arrNames(i) = arrNames(i + 1)
                arrContact(i) = arrContact(i + 1)
                arrSex(i) = arrSex(i + 1)
                arrService(i) = arrService(i + 1)
                arrStatus(i) = arrStatus(i + 1)
                arrSchedule(i) = arrSchedule(i + 1)
                arrCancelReason(i) = arrCancelReason(i + 1)
            Next

            ' Clear the last slot (duplicate after shift)
            arrID(CurrentCount - 1) = ""
            arrNames(CurrentCount - 1) = ""
            arrContact(CurrentCount - 1) = ""
            arrSex(CurrentCount - 1) = ""
            arrService(CurrentCount - 1) = ""
            arrStatus(CurrentCount - 1) = ""
            arrSchedule(CurrentCount - 1) = ""
            arrCancelReason(CurrentCount - 1) = ""

            ' Decrease total count
            CurrentCount -= 1

            MessageBox.Show("Patient deleted successfully.")

            ' Refresh AdminFrm grid and close this form
            AdminFrm.RefreshGrid()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class