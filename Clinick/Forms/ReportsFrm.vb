Imports System.IO
Imports System.Drawing.Printing

Public Class ReportsFrm

    Private currentReportTitle As String = ""

    Private Sub ReportsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonth.Items.Clear()
        cmbMonth.Items.Add("January") : cmbMonth.Items.Add("February")
        cmbMonth.Items.Add("March") : cmbMonth.Items.Add("April")
        cmbMonth.Items.Add("May") : cmbMonth.Items.Add("June")
        cmbMonth.Items.Add("July") : cmbMonth.Items.Add("August")
        cmbMonth.Items.Add("September") : cmbMonth.Items.Add("October")
        cmbMonth.Items.Add("November") : cmbMonth.Items.Add("December")
        cmbMonth.SelectedIndex = DateTime.Now.Month - 1

        dtpReportDate.Value = DateTime.Today

        btnPrint.Enabled = False
        btnExportPDF.Enabled = False
        btnExportExcel.Enabled = False
    End Sub

    Private Sub btnGenerateDaily_Click(sender As Object, e As EventArgs) Handles btnGenerateDaily.Click
        Dim selectedDate As String = dtpReportDate.Value.ToShortDateString()
        Dim rows As New List(Of Integer)

        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i).Contains(selectedDate) Then
                rows.Add(i)
            End If
        Next

        currentReportTitle = "Daily Report - " & selectedDate
        BuildReport(currentReportTitle, rows)
        MessageBox.Show(rows.Count & " appointment(s) found.")
    End Sub

    Private Sub btnGenerateMonthly_Click(sender As Object, e As EventArgs) Handles btnGenerateMonthly.Click
        Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
        Dim selectedYear As Integer = DateTime.Now.Year
        Dim monthName As String = cmbMonth.SelectedItem.ToString()
        Dim rows As New List(Of Integer)

        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i) <> "Not Set" Then
                Try
                    Dim schedulePart As String = arrSchedule(i).Split("@"c)(0).Trim()
                    Dim schedDate As DateTime = DateTime.Parse(schedulePart)
                    If schedDate.Month = selectedMonth AndAlso schedDate.Year = selectedYear Then
                        rows.Add(i)
                    End If
                Catch
                End Try
            End If
        Next

        currentReportTitle = "Monthly Report - " & monthName & " " & selectedYear
        BuildReport(currentReportTitle, rows)
        MessageBox.Show(rows.Count & " appointment(s) found.")
    End Sub

    Private Sub btnGeneratePatientRecords_Click(sender As Object, e As EventArgs) Handles btnGeneratePatientRecords.Click
        Dim rows As New List(Of Integer)
        For i As Integer = 0 To CurrentCount - 1
            rows.Add(i)
        Next

        currentReportTitle = "Full Patient Records"
        BuildReport(currentReportTitle, rows)
        MessageBox.Show(rows.Count & " record(s) found.")
    End Sub

    Private Sub BuildReport(title As String, rows As List(Of Integer))
        dgvReports.Rows.Clear()
        dgvReports.Columns.Clear()

        dgvReports.Columns.Add("id", "ID")
        dgvReports.Columns.Add("name", "Patient")
        dgvReports.Columns.Add("service", "Service Type")
        dgvReports.Columns.Add("sched", "Scheduled For")
        dgvReports.Columns.Add("status", "Status")
        dgvReports.Columns.Add("finish", "Date Processed")

        For Each i In rows
            If arrID(i) <> "" Then

                Dim finishDate As String = If(arrDateProcessed(i) <> "", arrDateProcessed(i), "---")

                dgvReports.Rows.Add(arrID(i), arrNames(i), arrService(i), arrSchedule(i), arrStatus(i), finishDate)
            End If
        Next

        currentReportTitle = title
        btnPrint.Enabled = True
        btnExportPDF.Enabled = True
        btnExportExcel.Enabled = True
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReports.Rows.Count = 0 Then Return

        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "CSV File (*.csv)|*.csv"
        saveDlg.FileName = currentReportTitle.Replace(" ", "_") & ".csv"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Dim csv As New System.Text.StringBuilder()
            csv.AppendLine("ID,Patient,Service Type,Scheduled On,Status,Completed On")

            For Each row As DataGridViewRow In dgvReports.Rows
                If Not row.IsNewRow Then
                    csv.AppendLine(String.Format("{0},{1},{2},{3},{4},{5}",
                        CsvEscape(row.Cells(0).Value?.ToString()),
                        CsvEscape(row.Cells(1).Value?.ToString()),
                        CsvEscape(row.Cells(2).Value?.ToString()),
                        CsvEscape(row.Cells(3).Value?.ToString()),
                        CsvEscape(row.Cells(4).Value?.ToString()),
                        CsvEscape(row.Cells(5).Value?.ToString())))
                End If
            Next

            File.WriteAllText(saveDlg.FileName, csv.ToString())
            MessageBox.Show("Export Successful!")
            Process.Start(saveDlg.FileName)
        End If
    End Sub

    Private Function CsvEscape(value As String) As String
        If value Is Nothing Then Return """" & """"
        Return """" & value.Replace("""", """""") & """"
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainFrm.Show()
        Me.Close()
    End Sub

End Class