Public Class AddPatient_Frm
    Private Sub ClearPatientForm()
        txtPatientName.Clear()
        txtContactInfo.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        txtAge.Clear()
        dtpBday.Value = DateTime.Now
        UpdateNextID()
        txtPatientName.Focus()
    End Sub

    Private Sub AddPatient_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateNextID()
        txtAge.ReadOnly = True
    End Sub

    Private Sub UpdateNextID()
        If lblPatientID.Text = "[ID]" OrElse lblPatientID.Text = "" OrElse lblPatientID.Text.StartsWith("P-") = False Then
            lblPatientID.Text = "P-" & (1001 + MasterCount).ToString()
        End If
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim inputName As String = txtPatientName.Text.Trim()
        Dim targetID As String = lblPatientID.Text
        Dim foundIndex As Integer = -1

        If String.IsNullOrWhiteSpace(inputName) Then
            MessageBox.Show("Please enter a patient name.")
            Return
        End If


        For i As Integer = 0 To MasterCount - 1
            If arrMasterID(i) = targetID Then
                foundIndex = i
                Exit For
            End If
        Next


        If foundIndex = -1 Then
            For i As Integer = 0 To MasterCount - 1
                If arrMasterName(i).Equals(inputName, StringComparison.OrdinalIgnoreCase) Then
                    MessageBox.Show("Patient '" & inputName & "' is already registered.", "Duplicate Entry")
                    Return
                End If
            Next

            foundIndex = MasterCount
        End If

        arrMasterID(foundIndex) = targetID
        arrMasterName(foundIndex) = inputName
        arrMasterContact(foundIndex) = txtContactInfo.Text.Trim()
        arrMasterSex(foundIndex) = If(rbMale.Checked, "Male", "Female")

        Dim ageVal As Integer = 0
        Integer.TryParse(txtAge.Text, ageVal)
        arrMasterAge(foundIndex) = ageVal
        arrMasterBday(foundIndex) = dtpBday.Value


        If foundIndex = MasterCount Then
            MasterCount += 1
            MessageBox.Show("New patient registered: " & targetID)
        Else
            MessageBox.Show("Patient record updated successfully: " & targetID)
        End If

        ClearPatientForm()
        PatientRecords_Frm.LoadAllPatients()
        PatientRecords_Frm.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearPatientForm()
    End Sub

    Private Sub dtpBday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBday.ValueChanged
        Dim today As Date = Date.Today
        Dim bday As Date = dtpBday.Value
        Dim age As Integer = today.Year - bday.Year
        If bday > today.AddYears(-age) Then age -= 1
        txtAge.Text = age.ToString()
    End Sub


End Class