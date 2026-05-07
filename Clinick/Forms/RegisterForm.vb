Public Class RegisterForm

    Private Sub ClearForm()
        targetIndex = -1
        txtSearchID.Clear()
        lblPatientNameDisplay.Text = "No Patient Selected"

        ' General Attributes
        rbRoutine.Checked = False
        rbUrgent.Checked = False
        rbFollowUp.Checked = False
        rbFever.Checked = False
        rbInjury.Checked = False
        rbPhysicalExam.Checked = False

        ' Dental Attributes
        rbCleaning.Checked = False
        rbExtraction.Checked = False
        rbFilling.Checked = False
        rbAdult.Checked = False
        rbChild.Checked = False

        ' Pediatrics Attributes
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

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        SubMenu.Show()
        Me.Close()
    End Sub

    Private Sub RegisterForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshAvailableSlots()
        ClearForm()

        grpPedia.Visible = False
        grpDental.Visible = False
        grpGeneral.Visible = False

        If Service.Contains("Pedia") Then
            grpPedia.Visible = True
        ElseIf Service.Contains("Dental") Then
            grpDental.Visible = True
        ElseIf Service.Contains("General") Then
            grpGeneral.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Dim targetIndex As Integer = -1

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        targetIndex = -1

        For i As Integer = 0 To CurrentCount - 1
            If arrID(i) = txtSearchID.Text.Trim() Then
                targetIndex = i
                Exit For
            End If
        Next

        If targetIndex <> -1 Then
            lblPatientNameDisplay.Text = "Appointing: " & arrNames(targetIndex)
            MessageBox.Show("Patient Found!")
        Else
            MessageBox.Show("ID not found. Please register the patient first.")
        End If
    End Sub

    Private Sub btnAppointPatient_Click(sender As Object, e As EventArgs) Handles btnAppointPatient.Click
        If targetIndex <> -1 Then
            If cmbTimeSlots.SelectedIndex = -1 Then
                MessageBox.Show("Please select an available time slot.")
                Return
            End If

            Dim finalSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.SelectedItem.ToString
            arrSchedule(targetIndex) = finalSchedule
            arrStatus(targetIndex) = "Pending"

            Dim details As String = ""
            If Service.Contains("Pedia") Then
                Dim visitType As String = ""
                If rbVaccine.Checked Then
                    visitType = "Vaccination"
                ElseIf rbGrowth.Checked Then
                    visitType = "Growth Check"
                ElseIf rbSickV.Checked Then
                    visitType = "Sick Visit"
                Else
                    visitType = "Routine Pedia"
                End If
                details = " (" & visitType & ")"

            ElseIf Service.Contains("Dental") Then
                Dim proc As String = ""
                If rbCleaning.Checked Then
                    proc = "Cleaning"
                ElseIf rbExtraction.Checked Then
                    proc = "Extraction"
                ElseIf rbFilling.Checked Then
                    proc = "Filling"
                End If
                details = " (" & proc & ")"

            ElseIf Service.Contains("General") Then
                Dim urgency As String = ""
                If rbUrgent.Checked Then
                    urgency = "Urgent"
                ElseIf rbFollowUp.Checked Then
                    urgency = "Follow-up"
                Else
                    urgency = "Routine"
                End If
                details = " (" & urgency & ")"
            End If

            arrService(targetIndex) = Service & details
            MessageBox.Show("Appointment successfully set for " & arrNames(targetIndex) & " on " & finalSchedule)

            Me.Close()
            SubMenu.Show()
        Else
            MessageBox.Show("Please search for a Patient ID before confirming.")
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshAvailableSlots()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class