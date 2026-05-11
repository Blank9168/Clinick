Public Class AddPatient_Frm
    Private Sub ClearPatientForm()
        txtPatientName.Clear()
        txtContactInfo.Clear()
        rbMale.Checked = False
        rbFemale.Checked = False
        txtAge.Clear()
        dtpBday.Value = New DateTime(2000, 1, 1)
        txtPatientName.Focus()
        UpdateNextID()
    End Sub

    Private Sub AddPatient_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Only generate a new ID if we aren't editing someone from the records list
        If lblPatientID.Text = "[ID]" Or lblPatientID.Text = "" Then
            UpdateNextID()
        End If
    End Sub

    Private Sub UpdateNextID()

        lblPatientID.Text = "P-" & (1001 + MasterCount).ToString()
    End Sub

    Private Sub btnReturnMainPd_Click(sender As Object, e As EventArgs) Handles btnReturnMainPd.Click
        MainFrm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click

        If MasterCount >= 1000 Then ' Use the size of your Master Array
            MessageBox.Show("Maximum registration limit reached.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPatientName.Text) Then
            MessageBox.Show("Please enter a valid patient name.")
            Return
        End If


        Dim targetID As String = lblPatientID.Text
        Dim isNew As Boolean = True
        Dim masterIndex As Integer = -1


        For i As Integer = 0 To MasterCount - 1
            If arrMasterID(i) = targetID Then
                isNew = False
                masterIndex = i
                Exit For
            End If
        Next

        If isNew Then

            arrMasterID(MasterCount) = targetID
            arrMasterName(MasterCount) = txtPatientName.Text.Trim()
            arrMasterContact(MasterCount) = txtContactInfo.Text.Trim()
            arrMasterSex(MasterCount) = If(rbMale.Checked, "Male", "Female")
            arrMasterAge(MasterCount) = CInt(txtAge.Text)
            arrMasterBday(MasterCount) = dtpBday.Value

            MasterCount += 1
            MessageBox.Show("New patient registered successfully: " & targetID)
        Else

            arrMasterName(masterIndex) = txtPatientName.Text.Trim()
            arrMasterContact(masterIndex) = txtContactInfo.Text.Trim()
            arrMasterSex(masterIndex) = If(rbMale.Checked, "Male", "Female")
            arrMasterAge(masterIndex) = CInt(txtAge.Text)
            arrMasterBday(masterIndex) = dtpBday.Value

            MessageBox.Show("Patient profile updated for " & targetID)
        End If

        ClearPatientForm()
        Me.Close()
        MainFrm.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearPatientForm()
    End Sub

    Private Sub dtpBday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBday.ValueChanged
        Dim today As Date = Date.Today
        Dim bday As Date = dtpBday.Value
        Dim age As Integer = today.Year - bday.Year
        If bday.Month > today.Month OrElse (bday.Month = today.Month AndAlso bday.Day > today.Day) Then
            age -= 1
        End If
        txtAge.Text = age.ToString()
    End Sub
End Class