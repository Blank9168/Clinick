Public Class MedicalRecordsFrm

    ' Tracks which patient is currently loaded
    ' Set by EditPatientFrm or AdminFrm before opening this form
    Public TargetIndex As Integer = -1
    Public CallerForm As String = "Admin"

    ' Load 

    Private Sub MedicalRecordsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TargetIndex = -1 Then
            MessageBox.Show("No patient selected. Please select a patient first.")
            Me.Close()
            Return
        End If
        LoadPatientRecord()
    End Sub

    ' Fills all fields with the selected patient's data
    Private Sub LoadPatientRecord()
        ' Patient info (read-only display)
        lblPatientID.Text = arrID(TargetIndex)
        lblPatientName.Text = arrNames(TargetIndex)
        lblAge.Text = arrAge(TargetIndex).ToString()
        lblSex.Text = arrSex(TargetIndex)
        lblService.Text = arrService(TargetIndex)
        lblSchedule.Text = arrSchedule(TargetIndex)
        lblStatus.Text = arrStatus(TargetIndex)

        ' Medical record fields (editable)
        ' Show existing data if already filled, otherwise show placeholder
        txtDiagnosis.Text = If(arrDiagnosis(TargetIndex) <> "" AndAlso
                               arrDiagnosis(TargetIndex) IsNot Nothing,
                               arrDiagnosis(TargetIndex), "")

        txtPrescription.Text = If(arrPrescription(TargetIndex) <> "" AndAlso
                                  arrPrescription(TargetIndex) IsNot Nothing,
                                  arrPrescription(TargetIndex), "")

        txtConsultNotes.Text = If(arrConsultNotes(TargetIndex) <> "" AndAlso
                                  arrConsultNotes(TargetIndex) IsNot Nothing,
                                  arrConsultNotes(TargetIndex), "")

        txtMedHistory.Text = If(arrMedHistory(TargetIndex) <> "" AndAlso
                                arrMedHistory(TargetIndex) IsNot Nothing,
                                arrMedHistory(TargetIndex), "")
    End Sub

    ' Saves all four medical record fields back into the parallel arrays
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TargetIndex = -1 Then
            MessageBox.Show("No patient selected.")
            Return
        End If

        arrDiagnosis(TargetIndex) = txtDiagnosis.Text.Trim()
        arrPrescription(TargetIndex) = txtPrescription.Text.Trim()
        arrConsultNotes(TargetIndex) = txtConsultNotes.Text.Trim()
        arrMedHistory(TargetIndex) = txtMedHistory.Text.Trim()

        MessageBox.Show("Medical record saved for " & arrNames(TargetIndex) & ".")
    End Sub

    ' Clear Fields 

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Clear all medical record fields for " & arrNames(TargetIndex) & "? " &
            "This will not delete the patient.",
            "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            txtDiagnosis.Clear()
            txtPrescription.Clear()
            txtConsultNotes.Clear()
            txtMedHistory.Clear()
        End If
    End Sub

    ' Patient History View 

    ' Refreshes dgvHistory with all patients who share the same name
    ' (i.e. returning patients with multiple visits)
    ' Shows ID, service, schedule, status, and diagnosis for each visit
    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        dgvPatientHistory.Rows.Clear()

        Dim patientName As String = arrNames(TargetIndex).ToLower().Trim()
        Dim recordsFound As Integer = 0

        For i As Integer = 0 To CurrentCount - 1
            If arrNames(i).ToLower().Trim() = patientName Then
                dgvPatientHistory.Rows.Add(
                    arrID(i),
                    arrSchedule(i),
                    arrService(i),
                    arrStatus(i),
                    If(arrDiagnosis(i) <> "" AndAlso arrDiagnosis(i) IsNot Nothing,
                       arrDiagnosis(i), "No diagnosis recorded")
                )
                recordsFound += 1
            End If
        Next

        If recordsFound = 0 Then
            MessageBox.Show("No visit history found for this patient.")
        Else
            MessageBox.Show(recordsFound.ToString() & " visit(s) found for " & arrNames(TargetIndex) & ".")
        End If
    End Sub

    ' Navigation 

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Reset TargetIndex so the form is clean next time it opens
        TargetIndex = -1
        If CallerForm = "Edit" Then
            EditPatientFrm.Show()
        Else
            AdminFrm.Show()
        End If
        Me.Close()
    End Sub

End Class