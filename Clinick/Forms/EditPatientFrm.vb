Public Class EditPatientFrm
    Dim foundIndex As Integer = -1

    ' Tracks which form opened EditPatientFrm so we return to the right one
    ' Set this to "Main" or "Admin" before calling EditPatientFrm.Show()
    Public CallerForm As String = "Main"

    Private Sub ReturnToCaller()
        ' Reset foundIndex so Activated auto-searches correctly next time this form opens
        foundIndex = -1
        If CallerForm = "Admin" Then
            AdminFrm.RefreshGrid()
            AdminFrm.Show()
        Else
            MainFrm.RefreshSummaryGrid()
            MainFrm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub EditPatientFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide all panels on first load
        grpPatientInfo.Visible = False
        panelBg.Visible = False
        lblPatientInfo.Visible = False
        grpAppointment.Visible = False
        grpDental.Visible = False
        grpPedia.Visible = False
        grpGeneral.Visible = False

        ' Populate time slots
        RefreshAvailableSlots()
    End Sub

    Private Sub EditPatientFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Auto-search every time the form becomes active
        ' txtSearchID is pre-filled by MainFrm or AdminFrm before Show() is called
        ' so the patient loads immediately without the admin needing to click Search
        If txtSearchID.Text.Trim() <> "" AndAlso foundIndex = -1 Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub RefreshAvailableSlots()
        cmbTimeSlots.Items.Clear()
        Dim masterSlots() As String = {
            "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM",
            "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM",
            "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM",
            "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"
        }
        For Each slot In masterSlots
            cmbTimeSlots.Items.Add(slot)
        Next
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
            ' 1. Show Main Panels
            grpPatientInfo.Visible = True
            panelBg.Visible = True
            lblPatientInfo.Visible = True
            grpAppointment.Visible = True

            ' 2. Load Basic Data from Parallel Arrays
            lblPatientID.Text = arrID(foundIndex)
            txtPatientName.Text = arrNames(foundIndex)
            txtContactInfo.Text = arrContact(foundIndex)
            txtAge.Text = arrAge(foundIndex).ToString()
            dtpDOB.Value = arrBday(foundIndex)

            ' 3. Set Control Permissions
            txtPatientName.ReadOnly = False
            txtContactInfo.ReadOnly = False
            txtAge.ReadOnly = False
            dtpDOB.Enabled = True
            rbMale.Enabled = True
            rbFemale.Enabled = True

            ' 4. Set Gender
            If arrSex(foundIndex) = "Male" Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If

            ' 5. Reset all specific Radio Buttons
            rbRoutine.Checked = False : rbUrgent.Checked = False : rbFollowUp.Checked = False
            rbFever.Checked = False : rbPhysicalExam.Checked = False : rbInjury.Checked = False
            rbCleaning.Checked = False : rbExtraction.Checked = False : rbFilling.Checked = False
            rbAdult.Checked = False : rbChild.Checked = False : rbVaccine.Checked = False
            rbGrowth.Checked = False : rbSickV.Checked = False : rbToddler.Checked = False
            rbInfant.Checked = False : rbSchool.Checked = False

            ' 6. Parse Service Details
            Dim serviceDetail As String = arrService(foundIndex)
            grpGeneral.Visible = False
            grpDental.Visible = False
            grpPedia.Visible = False

            If serviceDetail.Contains("General") Then
                grpGeneral.Visible = True
                If serviceDetail.Contains("Routine") Then rbRoutine.Checked = True
                If serviceDetail.Contains("Urgent") Then rbUrgent.Checked = True
                If serviceDetail.Contains("Follow-Up") Then rbFollowUp.Checked = True
                If serviceDetail.Contains("Fever") Then rbFever.Checked = True
                If serviceDetail.Contains("Physical Exam") Then rbPhysicalExam.Checked = True
                If serviceDetail.Contains("Injury") Then rbInjury.Checked = True

            ElseIf serviceDetail.Contains("Dental") Then
                grpDental.Visible = True
                If serviceDetail.Contains("Cleaning") Then rbCleaning.Checked = True
                If serviceDetail.Contains("Extraction") Then rbExtraction.Checked = True
                If serviceDetail.Contains("Filling") Then rbFilling.Checked = True
                If serviceDetail.Contains("Adult") Then rbAdult.Checked = True
                If serviceDetail.Contains("Child") Then rbChild.Checked = True

            ElseIf serviceDetail.Contains("Pedia") Then
                grpPedia.Visible = True
                If serviceDetail.Contains("Vaccine") Then rbVaccine.Checked = True
                If serviceDetail.Contains("Growth") Then rbGrowth.Checked = True
                If serviceDetail.Contains("Sick Visit") Then rbSickV.Checked = True
                If serviceDetail.Contains("Infant") Then rbInfant.Checked = True
                If serviceDetail.Contains("Toddler") Then rbToddler.Checked = True
                If serviceDetail.Contains("School") Then rbSchool.Checked = True
            End If

            ' 7. Parse Schedule
            If arrSchedule(foundIndex).Contains("@") Then
                Dim parts() = arrSchedule(foundIndex).Split("@")
                dtpDate.Value = DateTime.Parse(parts(0).Trim())
                cmbTimeSlots.Text = parts(1).Trim()
            End If

            MessageBox.Show("Patient Record Located.")
        Else
            ' Failed Search Logic
            grpPatientInfo.Visible = False
            panelBg.Visible = False
            lblPatientInfo.Visible = False
            grpAppointment.Visible = False
            foundIndex = -1
            MessageBox.Show("Patient ID not found.")
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

        ' Save changes back to parallel arrays
        arrNames(foundIndex) = txtPatientName.Text.Trim()
        arrContact(foundIndex) = txtContactInfo.Text.Trim()

        Dim updatedSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.Text
        arrSchedule(foundIndex) = updatedSchedule

        MessageBox.Show("Changes saved successfully for " & arrNames(foundIndex))

        ' Return to whichever form opened EditPatientFrm
        ReturnToCaller()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If foundIndex = -1 Then
            MessageBox.Show("Please search for a patient ID before attempting to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to permanently delete " & arrNames(foundIndex) & "?",
            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Shift all parallel arrays left from foundIndex to fill the gap
            For i As Integer = foundIndex To CurrentCount - 2
                arrID(i) = arrID(i + 1)
                arrNames(i) = arrNames(i + 1)
                arrContact(i) = arrContact(i + 1)
                arrSex(i) = arrSex(i + 1)
                arrStatus(i) = arrStatus(i + 1)
                arrSchedule(i) = arrSchedule(i + 1)
                arrService(i) = arrService(i + 1)
                arrCancelReason(i) = arrCancelReason(i + 1)
            Next

            ' Clear the last slot to remove the duplicate after shifting
            arrID(CurrentCount - 1) = ""
            arrNames(CurrentCount - 1) = ""
            arrContact(CurrentCount - 1) = ""
            arrSex(CurrentCount - 1) = ""
            arrStatus(CurrentCount - 1) = ""
            arrSchedule(CurrentCount - 1) = ""
            arrService(CurrentCount - 1) = ""
            arrCancelReason(CurrentCount - 1) = ""

            CurrentCount -= 1
            foundIndex = -1

            MessageBox.Show("Record deleted successfully.", "Success")

            ' Return to whichever form opened EditPatientFrm
            ReturnToCaller()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If panelBg.Visible = True Then
            Dim response As DialogResult = MessageBox.Show(
                "Are you sure you want to cancel? Any unsaved changes will be lost.",
                "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.No Then
                Return
            End If
        End If

        AdminFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        ReturnToCaller()
    End Sub

    ' Opens MedicalRecordsFrm for the currently loaded patient
    ' Only available after a patient has been searched and loaded
    'Private Sub btnMedicalRecords_Click(sender As Object, e As EventArgs)
    '    If foundIndex = -1 Then
    '        MessageBox.Show("Please search for a patient first.")
    '        Return
    '    End If

    '    MedicalRecordsFrm.TargetIndex = foundIndex
    '    MedicalRecordsFrm.CallerForm = "Edit"
    '    Hide()
    '    MedicalRecordsFrm.Show()
    'End Sub

End Class