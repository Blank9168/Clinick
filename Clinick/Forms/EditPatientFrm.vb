Public Class EditPatientFrm
    Dim foundIndex As Integer = -1

    ' Simplified navigation: Always returns to MainFrm
    Private Sub ReturnToCaller()
        foundIndex = -1
        MainFrm.RefreshSummaryGrid()
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub EditPatientFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize UI State
        ClearPanels()
        RefreshAvailableSlots()
    End Sub

    Private Sub EditPatientFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Auto-trigger search if an ID was passed (e.g., from double-clicking MainFrm grid)
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

        ' Search in parallel arrays
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

            ' 2. Load Basic Data
            lblPatientID.Text = arrID(foundIndex)
            txtPatientName.Text = arrNames(foundIndex)
            txtContactInfo.Text = arrContact(foundIndex)
            txtAge.Text = arrAge(foundIndex).ToString()
            dtpDOB.Value = arrBday(foundIndex)

            ' 3. Set Gender
            If arrSex(foundIndex) = "Male" Then rbMale.Checked = True Else rbFemale.Checked = True

            ' 4. Clear old radio button states
            ResetServiceRadios()

            ' 5. Parse Service Details String
            Dim serviceDetail As String = arrService(foundIndex)
            grpGeneral.Visible = False : grpDental.Visible = False : grpPedia.Visible = False

            If serviceDetail.Contains("General") Then
                grpGeneral.Visible = True
                If serviceDetail.Contains("Routine") Then rbRoutine.Checked = True
                If serviceDetail.Contains("Urgent") Then rbUrgent.Checked = True
                If serviceDetail.Contains("Follow-up") Then rbFollowUp.Checked = True
                ' New concerns
                If serviceDetail.Contains("Fever") Then rbFever.Checked = True
                If serviceDetail.Contains("Physical Exam") Then rbPhysicalExam.Checked = True
                If serviceDetail.Contains("Injury") Then rbInjury.Checked = True

            ElseIf serviceDetail.Contains("Dental") Then
                grpDental.Visible = True
                If serviceDetail.Contains("Adult") Then rbAdult.Checked = True
                If serviceDetail.Contains("Child") Then rbChild.Checked = True
                If serviceDetail.Contains("Cleaning") Then rbCleaning.Checked = True
                If serviceDetail.Contains("Extraction") Then rbExtraction.Checked = True
                If serviceDetail.Contains("Filling") Then rbFilling.Checked = True

            ElseIf serviceDetail.Contains("Pedia") Then
                grpPedia.Visible = True
                If serviceDetail.Contains("Infant") Then rbInfant.Checked = True
                If serviceDetail.Contains("Toddler") Then rbToddler.Checked = True
                If serviceDetail.Contains("School-Age") Then rbSchool.Checked = True
                If serviceDetail.Contains("Vaccination") Then rbVaccine.Checked = True
                If serviceDetail.Contains("Growth Check") Then rbGrowth.Checked = True
                If serviceDetail.Contains("Sick Visit") Then rbSickV.Checked = True
            End If

            ' 6. Parse Schedule String
            If arrSchedule(foundIndex).Contains("@") Then
                Dim parts() = arrSchedule(foundIndex).Split("@"c)
                dtpDate.Value = DateTime.Parse(parts(0).Trim())
                cmbTimeSlots.Text = parts(1).Trim()
            End If

            MessageBox.Show("Patient Record Located.")
        Else
            ClearPanels()
            MessageBox.Show("Patient ID not found.")
        End If
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If foundIndex = -1 Then Return

        If txtPatientName.Text.Trim() = "" Or txtContactInfo.Text.Trim() = "" Then
            MessageBox.Show("Patient Name and Contact Information cannot be empty.")
            Return
        End If

        arrNames(foundIndex) = txtPatientName.Text.Trim()
        arrContact(foundIndex) = txtContactInfo.Text.Trim()

        Dim serviceHeader As String = ""
        Dim details As String = ""

        If grpGeneral.Visible Then
            serviceHeader = "General"
            Dim condition As String = ""
            If rbFever.Checked Then condition = "Fever"
            If rbPhysicalExam.Checked Then condition = "Physical Exam"
            If rbInjury.Checked Then condition = "Injury"

            Dim urgency As String = ""
            If rbUrgent.Checked Then urgency = "Urgent"
            If rbFollowUp.Checked Then urgency = "Follow-up"
            If rbRoutine.Checked Then urgency = "Routine"

            details = " (" & condition & " - " & urgency & ")"
        ElseIf grpDental.Visible Then
            serviceHeader = "Dental"
            Dim dentalAge As String = ""
            If rbAdult.Checked Then dentalAge = "Adult" Else If rbChild.Checked Then dentalAge = "Child"

            Dim procedure As String = ""
            If rbCleaning.Checked Then procedure = "Cleaning"
            If rbExtraction.Checked Then procedure = "Extraction"
            If rbFilling.Checked Then procedure = "Filling"

            details = " (" & dentalAge & " - " & procedure & ")"
        ElseIf grpPedia.Visible Then
            serviceHeader = "Pediatrics"
            Dim ageGroup As String = ""
            If rbInfant.Checked Then ageGroup = "Infant"
            If rbToddler.Checked Then ageGroup = "Toddler"
            If rbSchool.Checked Then ageGroup = "School-Age"

            Dim visitType As String = ""
            If rbVaccine.Checked Then visitType = "Vaccination"
            If rbGrowth.Checked Then visitType = "Growth Check"
            If rbSickV.Checked Then visitType = "Sick Visit"

            details = " (" & ageGroup & " - " & visitType & ")"
        End If

        arrService(foundIndex) = serviceHeader & details

        Dim updatedSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.Text
        arrSchedule(foundIndex) = updatedSchedule

        MessageBox.Show("Changes saved successfully.")
        ReturnToCaller()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If foundIndex = -1 Then Return

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to permanently delete " & arrNames(foundIndex) & "?",
            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' CRITICAL: Shift ALL parallel arrays to maintain data integrity
            For i As Integer = foundIndex To CurrentCount - 2
                arrID(i) = arrID(i + 1)
                arrNames(i) = arrNames(i + 1)
                arrContact(i) = arrContact(i + 1)
                arrSex(i) = arrSex(i + 1)
                arrStatus(i) = arrStatus(i + 1)
                arrSchedule(i) = arrSchedule(i + 1)
                arrService(i) = arrService(i + 1)
                arrAge(i) = arrAge(i + 1)
                arrBday(i) = arrBday(i + 1)
                arrDateCreated(i) = arrDateCreated(i + 1)
                arrDateProcessed(i) = arrDateProcessed(i + 1)
                arrCancelReason(i) = arrCancelReason(i + 1)
            Next

            ' Clear the last index now that it's moved up
            arrID(CurrentCount - 1) = ""
            arrNames(CurrentCount - 1) = ""

            CurrentCount -= 1
            MessageBox.Show("Record deleted successfully.")
            ReturnToCaller()
        End If
    End Sub

    Private Sub ResetServiceRadios()
        ' General
        rbRoutine.Checked = False : rbUrgent.Checked = False : rbFollowUp.Checked = False
        rbFever.Checked = False : rbPhysicalExam.Checked = False : rbInjury.Checked = False
        ' Dental
        rbCleaning.Checked = False : rbExtraction.Checked = False : rbFilling.Checked = False
        rbAdult.Checked = False : rbChild.Checked = False
        ' Pedia
        rbVaccine.Checked = False : rbGrowth.Checked = False : rbSickV.Checked = False
        rbToddler.Checked = False : rbInfant.Checked = False : rbSchool.Checked = False
    End Sub

    Private Sub ClearPanels()
        grpPatientInfo.Visible = False
        panelBg.Visible = False
        lblPatientInfo.Visible = False
        grpAppointment.Visible = False
        grpGeneral.Visible = False
        grpDental.Visible = False
        grpPedia.Visible = False
        foundIndex = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToCaller()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        ReturnToCaller()
    End Sub
End Class