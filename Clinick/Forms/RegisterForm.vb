Public Class RegisterForm
    Dim targetIndex As Integer = -1

    Private Sub ClearForm()
        targetIndex = -1
        txtSearchID.Clear()
        lblPatientNameDisplay.Text = "No Patient Selected"
        rbRoutine.Checked = False
        rbUrgent.Checked = False
        rbFollowUp.Checked = False
        rbFever.Checked = False
        rbInjury.Checked = False
        rbPhysicalExam.Checked = False
        rbCleaning.Checked = False
        rbExtraction.Checked = False
        rbFilling.Checked = False
        rbAdult.Checked = False
        rbChild.Checked = False
        rbInfant.Checked = False
        rbToddler.Checked = False
        rbSchool.Checked = False
        rbVaccine.Checked = False
        rbGrowth.Checked = False
        rbSickV.Checked = False
        txtParentGName.Clear()
        txtSearchID.Focus()
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

        Dim selectedDate As String = dtpDate.Value.ToShortDateString
        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i).Contains(selectedDate) And arrService(i).Contains(Service) Then
                Dim takenTime As String = arrSchedule(i).Split("@")(1).Trim()
                If cmbTimeSlots.Items.Contains(takenTime) Then
                    cmbTimeSlots.Items.Remove(takenTime)
                End If
            End If
        Next
    End Sub


    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        RefreshAvailableSlots()
        grpPedia.Visible = False
        grpDental.Visible = False
        grpGeneral.Visible = False

        If Service.Contains("Pediatrics") Then
            grpPedia.Visible = True
        ElseIf Service.Contains("Dental") Then
            grpDental.Visible = True
        ElseIf Service.Contains("General") Then
            grpGeneral.Visible = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        targetIndex = -1
        For i As Integer = 0 To CurrentCount - 1
            If arrID(i) = txtSearchID.Text.Trim() Then
                targetIndex = i
                Exit For
            End If
        Next

        If targetIndex <> -1 Then
            lblPatientNameDisplay.Text = arrNames(targetIndex)
            MessageBox.Show("Patient Found! You can now select the schedule and details.")
        Else
            MessageBox.Show("ID not found. Please register the patient first.")
        End If
    End Sub

    Private Sub btnAppointPatient_Click(sender As Object, e As EventArgs) Handles btnAppointPatient.Click
        If targetIndex = -1 Then
            MessageBox.Show("Please search for and select a valid Patient ID first.")
            txtSearchID.Focus()
            Return
        End If

        If dtpDate.Value.Date < DateTime.Today Then
            MessageBox.Show("You cannot schedule an appointment for a past date.")
            Return
        End If

        If cmbTimeSlots.SelectedIndex = -1 Then
            MessageBox.Show("Please select an available time slot.")
            Return
        End If

        Dim details As String = ""

        If Service.Contains("Pediatrics") Then
            If rbVaccine.Checked = True Then
                details = " (Vaccination)"
            ElseIf rbGrowth.Checked = True Then
                details = " (Growth Check)"
            ElseIf rbSickV.Checked = True Then
                details = " (Sick Visit)"
            Else
                MessageBox.Show("Please select a Pediatric visit type.")
                Return
            End If

        ElseIf Service.Contains("Dental") Then
            If rbCleaning.Checked = True Then
                details = " (Cleaning)"
            ElseIf rbExtraction.Checked = True Then
                details = " (Extraction)"
            ElseIf rbFilling.Checked = True Then
                details = " (Filling)"
            Else
                MessageBox.Show("Please select a Dental procedure.")
                Return
            End If

        ElseIf Service.Contains("General") Then
            If rbUrgent.Checked = True Then
                details = " (Urgent)"
            ElseIf rbFollowUp.Checked = True Then
                details = " (Follow-up)"
            ElseIf rbRoutine.Checked = True Then
                details = " (Routine)"
            Else
                MessageBox.Show("Please select the urgency of the consultation.")
                Return
            End If
        End If

        Dim finalSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.SelectedItem.ToString
        arrSchedule(targetIndex) = finalSchedule
        arrStatus(targetIndex) = "Pending"
        arrService(targetIndex) = Service & details

        MessageBox.Show("Appointment successfully set for " & arrNames(targetIndex) & " on " & finalSchedule)
        Me.Close()
        SubMenu.Show()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshAvailableSlots()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        SubMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
End Class