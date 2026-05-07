Public Class EditPatientFrm
    Dim foundIndex As Integer = -1
    Private Sub EditPatientFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpPatientInfo.Visible() = False
        panelBg.Visible() = False
        lblPatientInfo.Visible() = False

        grpAppointment.Visible() = False
        grpDental.Visible() = False
        grpPedia.Visible() = False
        grpGeneral.Visible() = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchID As String = txtSearchID.Text.Trim()
        Dim isFound As Boolean = False

        If searchID = "" Then
            MessageBox.Show("Please enter a Patient ID to search.")
            Return
        End If

        For i As Integer = 0 To CurrentCount - 1
            If arrID(i).Equals(searchID, StringComparison.OrdinalIgnoreCase) Then
                foundIndex = i
                isFound = True
                Exit For
            End If
        Next

        If isFound Then

            grpGeneral.Visible = False
            grpDental.Visible = False
            grpPedia.Visible = False

            grpPatientInfo.Visible() = True
            panelBg.Visible = True
            lblPatientInfo.Visible = True
            grpAppointment.Visible = True

            lblPatientID.Text = arrID(foundIndex)
            txtPatientName.Text = arrNames(foundIndex)
            txtContactInfo.Text = arrContact(foundIndex)

            If arrSchedule(foundIndex).Contains("@") Then
                Dim scheduleParts() As String = arrSchedule(foundIndex).Split("@")
                dtpDate.Value = DateTime.Parse(scheduleParts(0).Trim())
                cmbTimeSlots.Text = scheduleParts(1).Trim()
            End If


            If arrService(foundIndex).Contains("General") Then
                grpGeneral.Visible = True
                'will need to add the logic for each service appointment details'
            ElseIf arrService(foundIndex).Contains("Dental") Then
                grpDental.Visible = True
                'will need to add the logic for each service appointment details'
            ElseIf arrService(foundIndex).Contains("Pedia") Then
                grpPedia.Visible = True
                'will need to add the logic for each service appointment details'
            End If

            MessageBox.Show("Patient Record Located.")
        Else

            panelBg.Visible = False
            lblPatientInfo.Visible = False
            grpGeneral.Visible = False
            grpDental.Visible = False
            grpPedia.Visible = False

            MessageBox.Show("Patient ID not found.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If foundIndex = -1 Then
            MessageBox.Show("Please search for a patient ID before attempting to delete.")
            Return
        End If


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete " & arrNames(foundIndex) & "?",
                                                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            For i As Integer = foundIndex To CurrentCount - 2
                arrID(i) = arrID(i + 1)
                arrNames(i) = arrNames(i + 1)
                arrContact(i) = arrContact(i + 1)
                arrStatus(i) = arrStatus(i + 1)
                arrSchedule(i) = arrSchedule(i + 1)
                arrService(i) = arrService(i + 1)
            Next
            CurrentCount -= 1
            MessageBox.Show("Record deleted successfully.", "Success")
            foundIndex = -1

            MainFrm.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If panelBg.Visible = True Then
            Dim response As DialogResult = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.",
                                                           "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.No Then
                Return
            End If

            SubMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If foundIndex = -1 Then
            MessageBox.Show("Please search for a patient before saving changes.")
            Return
        End If


        If txtPatientName.Text.Trim() = "" Or txtContactInfo.Text.Trim() = "" Then
            MessageBox.Show("Patient Name and Contact Information cannot be empty.")
            Return
        End If

        arrNames(foundIndex) = txtPatientName.Text.Trim()
        arrContact(foundIndex) = txtContactInfo.Text.Trim()

        Dim updatedSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.Text
        arrSchedule(foundIndex) = updatedSchedule

        If arrService(foundIndex).Contains("Pedia") Then
            ' UPDATE FEILDS SPECIFIC TO EACH SERVICES!'
        End If

        MessageBox.Show("Changes saved successfully for " & arrNames(foundIndex))

        MainFrm.Show()
        Me.Close()


    End Sub


    '    ' Stores the array index of the patient being edited
    '    ' Set by AdminFrm before opening this form
    '    Public TargetIndex As Integer = -1

    '    Private Sub EditPatientFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        If TargetIndex = -1 Then
    '            MessageBox.Show("No patient selected.")
    '            Me.Close()
    '            Return
    '        End If

    '        ' Load the selected patient's data into the fields
    '        lblEditID.Text = arrID(TargetIndex)
    '        txtEditName.Text = arrNames(TargetIndex)
    '        txtEditContact.Text = arrContact(TargetIndex)

    '        ' Populate and set the status dropdown
    '        cmbEditStatus.Items.Clear()
    '        cmbEditStatus.Items.Add("Pending")
    '        cmbEditStatus.Items.Add("Completed")
    '        cmbEditStatus.Items.Add("Cancelled")

    '        Dim statusIdx As Integer = cmbEditStatus.Items.IndexOf(arrStatus(TargetIndex))
    '        If statusIdx >= 0 Then
    '            cmbEditStatus.SelectedIndex = statusIdx
    '        End If
    '    End Sub

    '    ' Save Edit

    '    ' Writes the updated values back into the parallel arrays at TargetIndex
    '    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
    '        If txtEditName.Text.Trim() = "" Then
    '            MessageBox.Show("Patient name cannot be empty.")
    '            Return
    '        End If

    '        arrNames(TargetIndex) = txtEditName.Text.Trim()
    '        arrContact(TargetIndex) = txtEditContact.Text.Trim()

    '        If cmbEditStatus.SelectedIndex >= 0 Then
    '            arrStatus(TargetIndex) = cmbEditStatus.SelectedItem.ToString()
    '        End If

    '        MessageBox.Show("Patient " & lblEditID.Text & " updated successfully.")

    '        ' Refresh AdminFrm grid and close this form
    '        AdminFrm.RefreshGrid()
    '        Me.Close()
    '    End Sub

    '    ' Delete Patient 

    '    ' Removes the patient by shifting all entries after TargetIndex one step left
    '    ' This keeps the parallel arrays packed with no empty gaps in the middle
    '    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '        Dim confirm As DialogResult = MessageBox.Show(
    '            "Are you sure you want to delete patient " & lblEditID.Text & "?",
    '            "Confirm Delete",
    '            MessageBoxButtons.YesNo,
    '            MessageBoxIcon.Warning)

    '        If confirm = DialogResult.Yes Then
    '            ' Shift all entries after the deleted patient one position left
    '            For i As Integer = TargetIndex To CurrentCount - 2
    '                arrID(i) = arrID(i + 1)
    '                arrNames(i) = arrNames(i + 1)
    '                arrContact(i) = arrContact(i + 1)
    '                arrSex(i) = arrSex(i + 1)
    '                arrService(i) = arrService(i + 1)
    '                arrStatus(i) = arrStatus(i + 1)
    '                arrSchedule(i) = arrSchedule(i + 1)
    '                arrCancelReason(i) = arrCancelReason(i + 1)
    '            Next

    '            ' Clear the last slot (duplicate after shift)
    '            arrID(CurrentCount - 1) = ""
    '            arrNames(CurrentCount - 1) = ""
    '            arrContact(CurrentCount - 1) = ""
    '            arrSex(CurrentCount - 1) = ""
    '            arrService(CurrentCount - 1) = ""
    '            arrStatus(CurrentCount - 1) = ""
    '            arrSchedule(CurrentCount - 1) = ""
    '            arrCancelReason(CurrentCount - 1) = ""

    '            ' Decrease total count
    '            CurrentCount -= 1

    '            MessageBox.Show("Patient deleted successfully.")

    '            ' Refresh AdminFrm grid and close this form
    '            AdminFrm.RefreshGrid()
    '            Me.Close()
    '        End If
    '    End Sub

    '    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    '        Me.Close()
    '    End Sub

    '    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    '    End Sub
End Class