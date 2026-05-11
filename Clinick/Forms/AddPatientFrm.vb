Public Class AddPatientFrm
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
    End Sub

    Private Sub UpdateNextID()
        lblPatientID.Text = "P-" & (1001 + MasterCount).ToString()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        Dim inputName As String = txtPatientName.Text.Trim()

        If String.IsNullOrWhiteSpace(inputName) Then
            MessageBox.Show("Please enter a patient name.")
            Return
        End If

        ' Duplicate Check before incrementing
        For i As Integer = 0 To MasterCount - 1
            If arrMasterName(i).Equals(inputName, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Patient '" & inputName & "' is already registered.", "Duplicate Entry")
                Return
            End If
        Next

        ' Increment and Save
        Dim targetID As String = lblPatientID.Text

        arrMasterID(MasterCount) = targetID
        arrMasterName(MasterCount) = inputName
        arrMasterContact(MasterCount) = txtContactInfo.Text.Trim()
        arrMasterSex(MasterCount) = If(rbMale.Checked, "Male", "Female")

        Dim ageVal As Integer = 0
        Integer.TryParse(txtAge.Text, ageVal)
        arrMasterAge(MasterCount) = ageVal
        arrMasterBday(MasterCount) = dtpBday.Value

        MasterCount += 1 ' ID increments here

        MessageBox.Show("New patient registered: " & targetID)

        ClearPatientForm()
        MainFrm.Show()
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