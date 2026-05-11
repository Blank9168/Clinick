Imports System.IO
Imports System.Drawing.Printing

Public Class ReportsFrm

    Private currentReportTitle As String = ""
    Private WithEvents prntDoc As New PrintDocument

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
    End Sub

    Private Sub ReportsFrm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadAllRecords()
    End Sub

    Private Sub LoadAllRecords()
        Dim rows As New List(Of Integer)
        For i As Integer = 0 To CurrentCount - 1
            rows.Add(i)
        Next
        currentReportTitle = "Full Patient Records"
        BuildReport(currentReportTitle, rows)
    End Sub

    Private Sub btnGenerateDaily_Click(sender As Object, e As EventArgs) Handles btnGenerateDaily.Click
        ' Format match for Daily Filter
        Dim selectedDate As String = dtpReportDate.Value.ToString("MM/dd/yyyy")
        Dim rows As New List(Of Integer)
        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i).Contains(selectedDate) Then
                rows.Add(i)
            End If
        Next
        currentReportTitle = "Daily Report - " & selectedDate
        BuildReport(currentReportTitle, rows)
    End Sub

    Private Sub btnGenerateMonthly_Click(sender As Object, e As EventArgs) Handles btnGenerateMonthly.Click
        Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
        Dim selectedYear As Integer = DateTime.Now.Year
        Dim monthName As String = cmbMonth.SelectedItem.ToString()
        Dim rows As New List(Of Integer)
        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i) <> "Not Set" Then
                Try
                    ' Split at "@" to get the date part for parsing
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
    End Sub

    Private Sub BuildReport(title As String, rows As List(Of Integer))
        dgvReports.Rows.Clear()

        For Each i In rows
            If arrID(i) <> "" Then
                ' Now finishDate will match the long format saved in MainFrm
                Dim finishDate As String = If(arrDateProcessed(i) <> "", arrDateProcessed(i), "---")
                dgvReports.Rows.Add(arrID(i), arrNames(i), arrService(i), arrSchedule(i), arrStatus(i), finishDate)
            End If
        Next

        currentReportTitle = title
        btnPrint.Enabled = True
        btnExportExcel.Enabled = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim prntDlg As New PrintDialog
        prntDlg.Document = prntDoc
        If prntDlg.ShowDialog = DialogResult.OK Then
            prntDoc.Print()
        End If
    End Sub

    Private Sub prntDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles prntDoc.PrintPage
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 8, FontStyle.Regular)

        Dim startX As Integer = 30
        Dim startY As Integer = 40
        Dim yPos As Integer = startY

        e.Graphics.DrawString(currentReportTitle, fontTitle, Brushes.Black, startX, yPos)
        yPos += 40

        Dim xPos As Integer = startX
        Dim colWidths As Integer() = {50, 100, 220, 160, 70, 160}
        Dim headers As String() = {"ID", "Patient", "Service", "Schedule", "Status", "Processed"}

        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawString(headers(i), fontHeader, Brushes.Black, xPos, yPos)
            xPos += colWidths(i)
        Next

        yPos += 25
        e.Graphics.DrawLine(Pens.Black, startX, yPos, startX + 760, yPos)
        yPos += 10

        For Each row As DataGridViewRow In dgvReports.Rows
            If Not row.IsNewRow Then
                xPos = startX
                For j As Integer = 0 To 5
                    Dim cellValue As String = If(row.Cells(j).Value?.ToString(), "")
                    e.Graphics.DrawString(cellValue, fontBody, Brushes.Black, xPos, yPos)
                    xPos += colWidths(j)
                Next
                yPos += 20
            End If
        Next
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
            Me.Activate()
            Me.Focus()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class