Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class AppointmentFrm
    Dim targetMasterIndex As Integer = -1

    Private Sub ClearForm()
        targetMasterIndex = -1
        txtSearchName.Clear()
        lblPatientID.Text = "---"
        txtPatientName.Text = ""
        txtContactInfo.Text = ""
        txtAge.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        dtpDate.Value = DateTime.Now

        rbRoutine.Checked = False
        rbUrgent.Checked = False
        rbFollowUp.Checked = False

        rbFever.Checked = False
        rbPhysicalExam.Checked = False
        rbInjury.Checked = False

        rbCleaning.Checked = False
        rbExtraction.Checked = False
        rbFilling.Checked = False

        rbAdult.Checked = False
        rbChild.Checked = False

        rbVaccine.Checked = False
        rbGrowth.Checked = False
        rbSickV.Checked = False

        rbToddler.Checked = False
        rbInfant.Checked = False
        rbSchool.Checked = False

        txtPatientName.ReadOnly = False
        txtContactInfo.ReadOnly = False
        txtAge.ReadOnly = False
        dtpDOB.Enabled = True
        rbMale.Enabled = True
        rbFemale.Enabled = True
        txtParentGName.Clear()
        txtSearchName.Focus()
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
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i).Contains("@") Then
                If arrSchedule(i).Contains(selectedDate) Then
                    If arrService(i) <> "" AndAlso arrService(i).Contains(Service) Then
                        Dim parts() As String = arrSchedule(i).Split("@")
                        If parts.Length > 1 Then
                            Dim takenTime As String = parts(1).Trim()
                            If cmbTimeSlots.Items.Contains(takenTime) Then
                                cmbTimeSlots.Items.Remove(takenTime)
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        RefreshAvailableSlots()
    End Sub

    Private Sub RegisterForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
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
        targetMasterIndex = -1
        Dim searchInput As String = txtSearchName.Text.Trim().ToLower()

        For i As Integer = 0 To MasterCount - 1
            If arrMasterName(i).Trim().ToLower() = searchInput Then
                targetMasterIndex = i
                Exit For
            End If
        Next

        If targetMasterIndex <> -1 Then
            lblPatientID.Text = arrMasterID(targetMasterIndex)
            txtPatientName.Text = arrMasterName(targetMasterIndex)
            txtContactInfo.Text = arrMasterContact(targetMasterIndex)
            txtAge.Text = arrMasterAge(targetMasterIndex).ToString()
            dtpDOB.Value = arrMasterBday(targetMasterIndex)

            If arrMasterSex(targetMasterIndex) = "Male" Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If

            txtPatientName.ReadOnly = True
            txtAge.ReadOnly = True
            dtpDOB.Enabled = False
            txtContactInfo.ReadOnly = True
            rbMale.Enabled = False
            rbFemale.Enabled = False

            MessageBox.Show("Patient Record Verified.")
        Else
            MessageBox.Show("Patient name not found in Registration.")
            ClearForm()
        End If
    End Sub

    Private Sub btnAppointPatient_Click(sender As Object, e As EventArgs) Handles btnAppointPAtient.Click
        If CurrentCount >= MaxPatients Then
            MessageBox.Show("Maximum appointment limit reached.")
            Return
        End If

        If targetMasterIndex = -1 Then
            MessageBox.Show("Please verify a patient first.")
            Return
        End If

        If dtpDate.Value.Date < DateTime.Today Then
            MessageBox.Show("Cannot schedule for a past date.")
            Return
        End If

        If cmbTimeSlots.SelectedIndex = -1 Then
            MessageBox.Show("Please select a time slot.")
            Return
        End If

        Dim details As String = ""

        If Service.Contains("Pediatrics") Then
            Dim ageGroup As String = ""
            If rbInfant.Checked Then
                ageGroup = "Infant"
            ElseIf rbToddler.Checked Then
                ageGroup = "Toddler"
            ElseIf rbSchool.Checked Then
                ageGroup = "School-Age"
            Else
                MessageBox.Show("Please select a Pediatric age group.")
                Return
            End If

            Dim visitType As String = ""
            If rbVaccine.Checked Then
                visitType = "Vaccination"
            ElseIf rbGrowth.Checked Then
                visitType = "Growth Check"
            ElseIf rbSickV.Checked Then
                visitType = "Sick Visit"
            Else
                MessageBox.Show("Select a pediatric visit type.")
                Return
            End If

            details = " (" & ageGroup & " - " & visitType & ")"

        ElseIf Service.Contains("Dental") Then
            Dim dentalAge As String = ""
            If rbAdult.Checked Then
                dentalAge = "Adult"
            ElseIf rbChild.Checked Then
                dentalAge = "Child"
            Else
                MessageBox.Show("Please select Adult or Child for Dental.")
                Return
            End If

            Dim procedure As String = ""
            If rbCleaning.Checked Then
                procedure = "Cleaning"
            ElseIf rbExtraction.Checked Then
                procedure = "Extraction"
            ElseIf rbFilling.Checked Then
                procedure = "Filling"
            Else
                MessageBox.Show("Select a dental procedure.")
                Return
            End If

            details = " (" & dentalAge & " - " & procedure & ")"

        ElseIf Service.Contains("General") Then
            Dim condition As String = ""
            If rbFever.Checked Then
                condition = "Fever"
            ElseIf rbPhysicalExam.Checked Then
                condition = "Physical Exam"
            ElseIf rbInjury.Checked Then
                condition = "Injury"
            Else
                MessageBox.Show("Select a Primary Concern type.")
                Return
            End If

            Dim urgency As String = ""
            If rbUrgent.Checked Then
                urgency = "Urgent"
            ElseIf rbFollowUp.Checked Then
                urgency = "Follow-up"
            ElseIf rbRoutine.Checked Then
                urgency = "Routine"
            Else
                MessageBox.Show("Select a Urgency Level.")
                Return
            End If

            details = " (" & condition & " - " & urgency & ")"
        End If

        arrID(CurrentCount) = lblPatientID.Text
        arrNames(CurrentCount) = txtPatientName.Text
        arrContact(CurrentCount) = txtContactInfo.Text
        arrSex(CurrentCount) = If(rbMale.Checked, "Male", "Female")
        arrAge(CurrentCount) = CInt(txtAge.Text)
        arrBday(CurrentCount) = dtpDOB.Value

        Dim finalSchedule As String = dtpDate.Value.ToShortDateString & " @ " & cmbTimeSlots.SelectedItem.ToString
        arrSchedule(CurrentCount) = finalSchedule
        arrStatus(CurrentCount) = "Pending"
        arrService(CurrentCount) = Service & details
        arrDateCreated(CurrentCount) = DateTime.Now.ToString("MM/dd/yyyy")
        arrDateProcessed(CurrentCount) = ""

        CurrentCount += 1

        MessageBox.Show("Appointment set for " & txtPatientName.Text)

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
End Class