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
        MainFrm.Show()
        Me.Close()
    End Sub
    Private Sub dgvPatientHistory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatientHistory.CellDoubleClick
        Dim i As Integer = e.RowIndex
        If i >= 0 Then
            AddPatientFrm.lblPatientID.Text = dgvPatientHistory.Rows(i).Cells(0).Value.ToString()
            AddPatientFrm.txtPatientName.Text = dgvPatientHistory.Rows(i).Cells(1).Value.ToString()
            AddPatientFrm.txtContactInfo.Text = dgvPatientHistory.Rows(i).Cells(2).Value.ToString()
            AddPatientFrm.txtAge.Text = dgvPatientHistory.Rows(i).Cells(3).Value.ToString()

            If dgvPatientHistory.Rows(i).Cells(4).Value.ToString() = "Male" Then
                AddPatientFrm.rbMale.Checked = True
            Else
                AddPatientFrm.rbFemale.Checked = True
            End If

            AddPatientFrm.dtpBday.Value = CDate(dgvPatientHistory.Rows(i).Cells(5).Value)

            AddPatientFrm.Show()
            Me.Hide()
        End If
    End Sub
End Class