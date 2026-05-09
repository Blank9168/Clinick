Public Class AddPatient_Frm
    Private Sub ClearPatientForm()
        txtPatientName.Clear()
        txtContactInfo.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        txtPatientName.Focus()
        txtAge.Clear()
        dtpBday.Value = New DateTime(2000, 1, 1)

    End Sub

    ' Activated fires every time the form gains focus (e.g. after a MessageBox closes),
    ' which was wiping the user's typed input. Load only fires once when the form first opens.
    Private Sub AddPatient_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearPatientForm()
        UpdateNextID()
    End Sub

    Private Sub UpdateNextID()
        lblPatientID.Text = "P-" & (1001 + CurrentCount).ToString()
    End Sub



    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        SubMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        If CurrentCount >= MaxPatients Then
            MessageBox.Show("Maximum patient limit reached. Cannot add more patients.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPatientName.Text) Then
            MessageBox.Show("Please enter a valid patient name.")
            txtPatientName.Focus()
            Return
        End If

        Dim ageVal As Integer
        If Not Integer.TryParse(txtAge.Text, ageVal) OrElse ageVal <= 0 Then
            MessageBox.Show("Please enter a valid age (numeric and greater than 0).")
            txtAge.Focus()
            Return
        End If


        If Not rbMale.Checked AndAlso Not rbFemale.Checked Then
            MessageBox.Show("Please select a gender.")
            Return
        End If


        If Not IsNumeric(txtContactInfo.Text) OrElse txtContactInfo.Text.Length < 7 Then
            MessageBox.Show("Please enter a valid numeric contact number.")
            txtContactInfo.Focus()
            Return
        End If


        arrID(CurrentCount) = lblPatientID.Text
        arrNames(CurrentCount) = txtPatientName.Text.Trim()
        arrContact(CurrentCount) = txtContactInfo.Text.Trim()
        arrSex(CurrentCount) = If(rbMale.Checked, "Male", "Female")


        arrService(CurrentCount) = Service
        arrStatus(CurrentCount) = "Pending"
        arrSchedule(CurrentCount) = "Not Set"
        arrCancelReason(CurrentCount) = "N/A"

        CurrentCount += 1

        MessageBox.Show("Patient " & arrID(CurrentCount - 1) & " added successfully.")


        ClearPatientForm()
        UpdateNextID()
        Me.Hide()
        SubMenu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearPatientForm()
    End Sub

End Class