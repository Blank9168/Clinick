Public Class PatientRecords_Frm
    Private Sub PatientRecords_Frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadAllPatients()
        If CurrentUser = "Admin" Then
            ' Admin (Pepito) can see everything
            btnDelete.Visible = True
            btnClearAll.Visible = True
        Else
            ' Employee (Patrick) cannot delete or clear records
            btnDelete.Visible = False
            btnClearAll.Visible = False
        End If
    End Sub

    Public Sub LoadAllPatients()
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


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddPatient_Frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvPatientHistory.CurrentRow IsNot Nothing Then
            Dim selectedID As String = dgvPatientHistory.CurrentRow.Cells(0).Value.ToString()
            Dim result As DialogResult = MessageBox.Show("Deleting this patient will also remove all their appointments. Proceed?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                For i As Integer = CurrentCount - 1 To 0 Step -1
                    If arrID(i) = selectedID Then

                        For j As Integer = i To CurrentCount - 2
                            arrID(j) = arrID(j + 1)
                            arrNames(j) = arrNames(j + 1)
                            arrContact(j) = arrContact(j + 1)
                            arrService(j) = arrService(j + 1)
                            arrSchedule(j) = arrSchedule(j + 1)
                            arrStatus(j) = arrStatus(j + 1)

                        Next
                        CurrentCount -= 1
                    End If
                Next

                For i As Integer = 0 To MasterCount - 1
                    If arrMasterID(i) = selectedID Then

                        For j As Integer = i To MasterCount - 2
                            arrMasterID(j) = arrMasterID(j + 1)
                            arrMasterName(j) = arrMasterName(j + 1)
                            arrMasterContact(j) = arrMasterContact(j + 1)
                            arrMasterAge(j) = arrMasterAge(j + 1)
                            arrMasterSex(j) = arrMasterSex(j + 1)
                            arrMasterBday(j) = arrMasterBday(j + 1)
                        Next
                        MasterCount -= 1
                        Exit For
                    End If
                Next


                LoadAllPatients()
                MainFrm.RefreshSummaryGrid()
                MessageBox.Show("Patient and all related records deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a patient to delete.")
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE? This will permanently delete ALL patients and ALL appointments in the system.",
                                                   "Factory Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If result = DialogResult.Yes Then
            MasterCount = 0
            CurrentCount = 0
            LoadAllPatients()
            MainFrm.RefreshSummaryGrid()

            MessageBox.Show("All system records have been cleared.")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvPatientHistory.CurrentRow IsNot Nothing Then
            Dim i As Integer = dgvPatientHistory.CurrentRow.Index

            AddPatient_Frm.lblPatientID.Text = dgvPatientHistory.Rows(i).Cells(0).Value.ToString()
            AddPatient_Frm.txtPatientName.Text = dgvPatientHistory.Rows(i).Cells(1).Value.ToString()
            AddPatient_Frm.txtContactInfo.Text = dgvPatientHistory.Rows(i).Cells(2).Value.ToString()
            Dim genderVal As String = dgvPatientHistory.Rows(i).Cells(4).Value.ToString().Trim().ToUpper()

            If genderVal = "MALE" Then
                AddPatient_Frm.rbMale.Checked = True
                AddPatient_Frm.rbFemale.Checked = False
            ElseIf genderVal = "FEMALE" Then
                AddPatient_Frm.rbFemale.Checked = True
                AddPatient_Frm.rbMale.Checked = False
            Else
                AddPatient_Frm.rbMale.Checked = False
                AddPatient_Frm.rbFemale.Checked = False
            End If

            Try
                Dim dateString As String = dgvPatientHistory.Rows(i).Cells(5).Value.ToString()

                Dim bday As Date = DateTime.ParseExact(dateString, "MM/dd/yyyy", Nothing)

                AddPatient_Frm.dtpBday.Value = bday
            Catch ex As Exception
                AddPatient_Frm.dtpBday.Value = DateTime.Now
            End Try
            AddPatient_Frm.txtAge.Text = dgvPatientHistory.Rows(i).Cells(3).Value.ToString()

            AddPatient_Frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select a patient row from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class