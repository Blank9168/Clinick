Public Class AddPatient_Frm
    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        SubMenu.Show()
        Me.Close()
    End Sub

    Private Sub AddPatient_Frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim prefix As String = " "

        If Service = "Pediatrics " Then
            prefix = "PED-"
        ElseIf Service = "General Consultation" Then
            prefix = "GEN-"
        ElseIf Service = "Dental Services" Then
            prefix = "DEN-"
        End If

        lblPatientID.Text = prefix & (1001 + CurrentCount).ToString()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        If CurrentCount < MaxPatients Then
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

        Else
            MessageBox.Show("Maximum patient limit reached. Cannot add more patients.")
        End If

    End Sub
End Class