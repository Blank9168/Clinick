Public Class PatientRecords_Frm
    Private Sub PatientRecords_Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllPatients()
    End Sub

    Private Sub LoadAllPatients()
        dgvPatientHistory.Rows.Clear()

        For i As Integer = 0 To MasterCount - 1
            dgvPatientHistory.Rows.Add(
                arrMasterID(i),
                arrMasterName(i),
                arrMasterContact(i),
                arrMasterAge(i),
                arrMasterSex(i),
                arrMasterBday(i).ToString("MM/dd/yyyy")
            )
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchKey As String = txtSearchName.Text.Trim().ToLower()
        dgvPatientHistory.Rows.Clear()

        If String.IsNullOrWhiteSpace(searchKey) Then
            LoadAllPatients()
            Return
        End If

        Dim found As Boolean = False
        For i As Integer = 0 To MasterCount - 1
            If arrMasterID(i).ToLower().Contains(searchKey) OrElse
               arrMasterName(i).ToLower().Contains(searchKey) Then

                dgvPatientHistory.Rows.Add(
                    arrMasterID(i),
                    arrMasterName(i),
                    arrMasterContact(i),
                    arrMasterAge(i),
                    arrMasterSex(i),
                    arrMasterBday(i).ToString("MM/dd/yyyy")
                )
                found = True
            End If
        Next

        If Not found Then
            MessageBox.Show("No patient found with that Name or ID.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainFrm.Show
        Close
    End Sub
    Private Sub dgvPatientHistory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientHistory.CellDoubleClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            AddPatient_Frm.lblPatientID.Text = dgvPatientHistory.Rows(i).Cells(0).Value.ToString()
            AddPatient_Frm.txtPatientName.Text = dgvPatientHistory.Rows(i).Cells(1).Value.ToString()
            AddPatient_Frm.txtContactInfo.Text = dgvPatientHistory.Rows(i).Cells(2).Value.ToString()
            AddPatient_Frm.txtAge.Text = dgvPatientHistory.Rows(i).Cells(3).Value.ToString()

            If dgvPatientHistory.Rows(i).Cells(4).Value.ToString() = "Male" Then
                AddPatient_Frm.rbMale.Checked = True
            Else
                AddPatient_Frm.rbFemale.Checked = True
            End If

            AddPatient_Frm.dtpBday.Value = CDate(dgvPatientHistory.Rows(i).Cells(5).Value)

            AddPatient_Frm.Show()
            Me.Hide()
        End If
    End Sub
End Class