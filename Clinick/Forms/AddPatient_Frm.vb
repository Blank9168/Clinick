Public Class AddPatient_Frm
    Private Sub ClearPatientForm()
        txtPatientName.Clear()
        txtContactInfo.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        txtPatientName.Focus()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        SubMenu.Show()
        Me.Close()
    End Sub

    Private Sub AddPatient_Frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ClearPatientForm()
        Dim prefix As String = " "
        If Service = "Pediatrics" Then
            prefix = "PED-"
        ElseIf Service = "General" Then
            prefix = "GEN-"
        ElseIf Service = "Dental" Then
            prefix = "DEN-"
        End If
        lblPatientID.Text = prefix & (1001 + CurrentCount).ToString()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        If CurrentCount < MaxPatients Then
            If txtPatientName.Text = "" Then
                MessageBox.Show("Please enter the patient's name.")
                Return
            End If

            arrID(CurrentCount) = lblPatientID.Text
            arrNames(CurrentCount) = txtPatientName.Text
            arrContact(CurrentCount) = txtContactInfo.Text
            arrSex(CurrentCount) = If(rbMale.Checked, "Male", "Female")

            arrService(CurrentCount) = Service
            arrStatus(CurrentCount) = "Pending"
            arrSchedule(CurrentCount) = "Not Set"
            arrCancelReason(CurrentCount) = "N/A"

            CurrentCount += 1

            MessageBox.Show("Patient " & lblPatientID.Text & " added successfully.")
            Me.Hide()
            SubMenu.Show()

        Else
            MessageBox.Show("Maximum patient limit reached. Cannot add more patients.")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearPatientForm()
    End Sub

End Class