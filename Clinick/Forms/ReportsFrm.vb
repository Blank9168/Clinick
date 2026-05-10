Imports System.IO
Imports System.Drawing.Printing

Public Class ReportsFrm

    ' Stores the currently generated report as plain text (for printing)
    ' and as HTML (for PDF export)
    Private currentReportText As String = ""
    Private currentReportHTML As String = ""
    Private currentReportTitle As String = ""

    ' Form Load

    Private Sub ReportsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate month picker for monthly report
        cmbMonth.Items.Clear()
        cmbMonth.Items.Add("January") : cmbMonth.Items.Add("February")
        cmbMonth.Items.Add("March") : cmbMonth.Items.Add("April")
        cmbMonth.Items.Add("May") : cmbMonth.Items.Add("June")
        cmbMonth.Items.Add("July") : cmbMonth.Items.Add("August")
        cmbMonth.Items.Add("September") : cmbMonth.Items.Add("October")
        cmbMonth.Items.Add("November") : cmbMonth.Items.Add("December")
        cmbMonth.SelectedIndex = DateTime.Now.Month - 1

        ' Set date picker default to today
        dtpReportDate.Value = DateTime.Today

        ' Disable export buttons until a report is generated
        btnPrint.Enabled = False
        btnExportPDF.Enabled = False
        btnExportExcel.Enabled = False
    End Sub

    ' Helper: Build summary counts

    Private Function CountByStatus(rows As List(Of Integer), status As String) As Integer
        Dim count As Integer = 0
        For Each i In rows
            If arrStatus(i) IsNot Nothing AndAlso
               arrStatus(i).ToLower() = status.ToLower() Then
                count += 1
            End If
        Next
        Return count
    End Function

    ' REPORT 1: Daily Appointments 
    ' Shows all appointments scheduled on the selected date
    Private Sub btnGenerateDaily_Click(sender As Object, e As EventArgs) Handles btnGenerateDaily.Click
        Dim selectedDate As String = dtpReportDate.Value.ToShortDateString()
        Dim rows As New List(Of Integer)

        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i).Contains(selectedDate) Then
                rows.Add(i)
            End If
        Next

        currentReportTitle = "Daily Appointments Report — " & selectedDate
        BuildReport(currentReportTitle, rows, "daily")
        MessageBox.Show(rows.Count & " appointment(s) found for " & selectedDate)
    End Sub

    ' REPORT 2: Monthly Report 
    ' Shows all appointments in the selected month
    Private Sub btnGenerateMonthly_Click(sender As Object, e As EventArgs) Handles btnGenerateMonthly.Click
        Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
        Dim selectedYear As Integer = DateTime.Now.Year
        Dim monthName As String = cmbMonth.SelectedItem.ToString()
        Dim rows As New List(Of Integer)

        For i As Integer = 0 To CurrentCount - 1
            If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i) <> "Not Set" Then
                Try
                    Dim schedulePart As String = arrSchedule(i).Split("@")(0).Trim()
                    Dim schedDate As DateTime = DateTime.Parse(schedulePart)
                    If schedDate.Month = selectedMonth AndAlso schedDate.Year = selectedYear Then
                        rows.Add(i)
                    End If
                Catch
                    ' Skip unparseable dates
                End Try
            End If
        Next

        currentReportTitle = "Monthly Report — " & monthName & " " & selectedYear
        BuildReport(currentReportTitle, rows, "monthly")
        MessageBox.Show(rows.Count & " appointment(s) found for " & monthName & " " & selectedYear)
    End Sub

    ' REPORT 3: Patient Records
    ' Shows full records for ALL patients including medical record fields
    Private Sub btnGeneratePatientRecords_Click(sender As Object, e As EventArgs) Handles btnGeneratePatientRecords.Click
        Dim rows As New List(Of Integer)
        For i As Integer = 0 To CurrentCount - 1
            rows.Add(i)
        Next

        currentReportTitle = "Patient Records Report — All Patients"
        BuildReport(currentReportTitle, rows, "patient")
        MessageBox.Show(rows.Count & " patient record(s) found.")
    End Sub

    ' Build Report (plain text + HTML)
    ' Builds both a plain-text version (for printing and the preview textbox)
    ' and an HTML version (for the PDF export)
    Private Sub BuildReport(title As String, rows As List(Of Integer), reportType As String)
        Dim txt As New System.Text.StringBuilder()
        Dim html As New System.Text.StringBuilder()

        Dim generatedOn As String = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt")
        Dim pending As Integer = CountByStatus(rows, "Pending")
        Dim completed As Integer = CountByStatus(rows, "Completed")
        Dim cancelled As Integer = CountByStatus(rows, "Cancelled")

        ' ── Plain text ──
        txt.AppendLine("================================================")
        txt.AppendLine("  CLINICK CLINIC MANAGEMENT SYSTEM")
        txt.AppendLine("  " & title)
        txt.AppendLine("  Generated: " & generatedOn)
        txt.AppendLine("================================================")
        txt.AppendLine("")
        txt.AppendLine("SUMMARY")
        txt.AppendLine("  Total Records : " & rows.Count)
        txt.AppendLine("  Pending       : " & pending)
        txt.AppendLine("  Completed     : " & completed)
        txt.AppendLine("  Cancelled     : " & cancelled)
        txt.AppendLine("")
        txt.AppendLine("RECORDS")
        txt.AppendLine("------------------------------------------------")

        ' ── HTML header ──
        html.AppendLine("<!DOCTYPE html><html><head>")
        html.AppendLine("<meta charset='utf-8'>")
        html.AppendLine("<title>" & title & "</title>")
        html.AppendLine("<style>")
        html.AppendLine("  body { font-family: Arial, sans-serif; margin: 30px; font-size: 13px; }")
        html.AppendLine("  h1 { color: #1a5c6e; font-size: 18px; }")
        html.AppendLine("  h2 { color: #1a5c6e; font-size: 14px; margin-top: 20px; }")
        html.AppendLine("  .meta { color: #666; font-size: 12px; margin-bottom: 20px; }")
        html.AppendLine("  .summary { background: #eaf7f9; padding: 10px; border-radius: 6px; margin-bottom: 20px; }")
        html.AppendLine("  table { width: 100%; border-collapse: collapse; margin-top: 10px; }")
        html.AppendLine("  th { background: #1a5c6e; color: white; padding: 8px; text-align: left; font-size: 12px; }")
        html.AppendLine("  td { padding: 7px 8px; border-bottom: 1px solid #ddd; font-size: 12px; }")
        html.AppendLine("  tr:nth-child(even) { background: #f5f5f5; }")
        html.AppendLine("  .pending { color: #cc8800; font-weight: bold; }")
        html.AppendLine("  .completed { color: #007700; font-weight: bold; }")
        html.AppendLine("  .cancelled { color: #cc0000; font-weight: bold; }")
        html.AppendLine("  @media print { body { margin: 15px; } }")
        html.AppendLine("</style></head><body>")
        html.AppendLine("<h1>CLINICK Clinic Management System</h1>")
        html.AppendLine("<h2>" & title & "</h2>")
        html.AppendLine("<div class='meta'>Generated: " & generatedOn & "</div>")
        html.AppendLine("<div class='summary'>")
        html.AppendLine("<strong>Total Records:</strong> " & rows.Count & " &nbsp;&nbsp; ")
        html.AppendLine("<strong>Pending:</strong> " & pending & " &nbsp;&nbsp; ")
        html.AppendLine("<strong>Completed:</strong> " & completed & " &nbsp;&nbsp; ")
        html.AppendLine("<strong>Cancelled:</strong> " & cancelled)
        html.AppendLine("</div>")

        If reportType = "patient" Then
            ' Patient records report — include medical record fields
            html.AppendLine("<table><tr>")
            html.AppendLine("<th>#</th><th>ID</th><th>Name</th><th>Age</th><th>Sex</th>")
            html.AppendLine("<th>Contact</th><th>Service</th><th>Schedule</th><th>Status</th>")
            html.AppendLine("<th>Diagnosis</th><th>Prescription</th><th>Notes</th></tr>")

            For Each i In rows
                Dim statusClass As String = arrStatus(i).ToLower()
                txt.AppendLine("")
                txt.AppendLine("  ID       : " & arrID(i))
                txt.AppendLine("  Name     : " & arrNames(i))
                txt.AppendLine("  Age/Sex  : " & arrAge(i) & " / " & arrSex(i))
                txt.AppendLine("  Contact  : " & arrContact(i))
                txt.AppendLine("  Service  : " & arrService(i))
                txt.AppendLine("  Schedule : " & arrSchedule(i))
                txt.AppendLine("  Status   : " & arrStatus(i))
                txt.AppendLine("  Diagnosis: " & If(arrDiagnosis(i) <> "" AndAlso arrDiagnosis(i) IsNot Nothing, arrDiagnosis(i), "N/A"))
                txt.AppendLine("  Rx       : " & If(arrPrescription(i) <> "" AndAlso arrPrescription(i) IsNot Nothing, arrPrescription(i), "N/A"))
                txt.AppendLine("  Notes    : " & If(arrConsultNotes(i) <> "" AndAlso arrConsultNotes(i) IsNot Nothing, arrConsultNotes(i), "N/A"))
                txt.AppendLine("  History  : " & If(arrMedHistory(i) <> "" AndAlso arrMedHistory(i) IsNot Nothing, arrMedHistory(i), "N/A"))
                txt.AppendLine("  ----------------------------------------")

                html.AppendLine("<tr>")
                html.AppendLine("<td>" & (rows.IndexOf(i) + 1) & "</td>")
                html.AppendLine("<td>" & arrID(i) & "</td>")
                html.AppendLine("<td>" & arrNames(i) & "</td>")
                html.AppendLine("<td>" & arrAge(i) & "</td>")
                html.AppendLine("<td>" & arrSex(i) & "</td>")
                html.AppendLine("<td>" & arrContact(i) & "</td>")
                html.AppendLine("<td>" & arrService(i) & "</td>")
                html.AppendLine("<td>" & arrSchedule(i) & "</td>")
                html.AppendLine("<td class='" & statusClass & "'>" & arrStatus(i) & "</td>")
                html.AppendLine("<td>" & If(arrDiagnosis(i) <> "" AndAlso arrDiagnosis(i) IsNot Nothing, arrDiagnosis(i), "N/A") & "</td>")
                html.AppendLine("<td>" & If(arrPrescription(i) <> "" AndAlso arrPrescription(i) IsNot Nothing, arrPrescription(i), "N/A") & "</td>")
                html.AppendLine("<td>" & If(arrConsultNotes(i) <> "" AndAlso arrConsultNotes(i) IsNot Nothing, arrConsultNotes(i), "N/A") & "</td>")
                html.AppendLine("</tr>")
            Next
        Else
            ' Daily / Monthly report — appointment-focused
            html.AppendLine("<table><tr>")
            html.AppendLine("<th>#</th><th>ID</th><th>Name</th><th>Age</th><th>Sex</th>")
            html.AppendLine("<th>Service</th><th>Schedule</th><th>Status</th></tr>")

            For Each i In rows
                Dim statusClass As String = arrStatus(i).ToLower()
                txt.AppendLine("")
                txt.AppendLine("  ID       : " & arrID(i))
                txt.AppendLine("  Name     : " & arrNames(i))
                txt.AppendLine("  Age/Sex  : " & arrAge(i) & " / " & arrSex(i))
                txt.AppendLine("  Service  : " & arrService(i))
                txt.AppendLine("  Schedule : " & arrSchedule(i))
                txt.AppendLine("  Status   : " & arrStatus(i))
                txt.AppendLine("  ----------------------------------------")

                html.AppendLine("<tr>")
                html.AppendLine("<td>" & (rows.IndexOf(i) + 1) & "</td>")
                html.AppendLine("<td>" & arrID(i) & "</td>")
                html.AppendLine("<td>" & arrNames(i) & "</td>")
                html.AppendLine("<td>" & arrAge(i) & "</td>")
                html.AppendLine("<td>" & arrSex(i) & "</td>")
                html.AppendLine("<td>" & arrService(i) & "</td>")
                html.AppendLine("<td>" & arrSchedule(i) & "</td>")
                html.AppendLine("<td class='" & statusClass & "'>" & arrStatus(i) & "</td>")
                html.AppendLine("</tr>")
            Next
        End If

        txt.AppendLine("")
        txt.AppendLine("================================================")
        txt.AppendLine("  END OF REPORT")
        txt.AppendLine("================================================")

        html.AppendLine("</table>")
        html.AppendLine("<br><hr><p style='color:#999;font-size:11px;'>End of Report — CLINICK Clinic Management System</p>")
        html.AppendLine("</body></html>")

        ' Store for export
        currentReportText = txt.ToString()
        currentReportHTML = html.ToString()

        ' Show preview in the textbox
        txtReportPreview.Text = currentReportText

        ' Enable export buttons now that a report exists
        btnPrint.Enabled = True
        btnExportPDF.Enabled = True
        btnExportExcel.Enabled = True
    End Sub

    ' EXPORT: Print

    Private printContent As String = ""

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If currentReportText = "" Then
            MessageBox.Show("Please generate a report first.")
            Return
        End If

        printContent = currentReportText

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        Dim dlg As New PrintDialog()
        dlg.Document = pd

        If dlg.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    ' Handles printing page by page
    ' Splits the report text into lines and draws them onto the page
    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Courier New", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim lineHeight As Single = font.GetHeight(e.Graphics)
        Dim y As Single = e.MarginBounds.Top
        Dim x As Single = e.MarginBounds.Left
        Dim lines() As String = printContent.Split(vbNewLine)
        Dim maxLines As Integer = CInt((e.MarginBounds.Height) / lineHeight)
        Dim lineIndex As Integer = 0

        For Each line In lines
            If lineIndex >= maxLines Then Exit For
            e.Graphics.DrawString(line, font, brush, x, y)
            y += lineHeight
            lineIndex += 1
        Next

        e.HasMorePages = False
        font.Dispose()
        brush.Dispose()
    End Sub

    ' EXPORT: PDF (via HTML file → open in browser → print to PDF)
    ' Saves the report as a styled HTML file and opens it in the default browser
    ' The user then uses Ctrl+P → Save as PDF in the browser
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        If currentReportHTML = "" Then
            MessageBox.Show("Please generate a report first.")
            Return
        End If

        Dim saveDlg As New SaveFileDialog()
        saveDlg.Title = "Save Report as HTML (for PDF)"
        saveDlg.Filter = "HTML File (*.html)|*.html"
        saveDlg.FileName = currentReportTitle.Replace(" ", "_").Replace("—", "-") & ".html"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveDlg.FileName, currentReportHTML, System.Text.Encoding.UTF8)

            ' Open in default browser so user can print to PDF
            Process.Start(saveDlg.FileName)

            MessageBox.Show("Report saved as HTML." & vbNewLine &
                            "In your browser, press Ctrl+P → choose 'Save as PDF'." & vbNewLine &
                            "This gives you a properly formatted PDF export.")
        End If
    End Sub

    ' EXPORT: Excel (CSV)
    ' Saves the report as a .csv file which Excel opens directly
    ' CSV uses commas to separate columns — no library needed
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If currentReportText = "" Then
            MessageBox.Show("Please generate a report first.")
            Return
        End If

        Dim saveDlg As New SaveFileDialog()
        saveDlg.Title = "Export Report to Excel (CSV)"
        saveDlg.Filter = "CSV File (*.csv)|*.csv"
        saveDlg.FileName = currentReportTitle.Replace(" ", "_").Replace("—", "-") & ".csv"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Dim csv As New System.Text.StringBuilder()

            ' Write report title and generated date
            csv.AppendLine("CLINICK Clinic Management System")
            csv.AppendLine(currentReportTitle)
            csv.AppendLine("Generated:," & DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"))
            csv.AppendLine("")

            ' Determine which columns to write based on report type
            If currentReportTitle.Contains("Patient Records") Then
                csv.AppendLine("No,ID,Name,Age,Sex,Contact,Service,Schedule,Status,Diagnosis,Prescription,Consult Notes,Medical History")
                For i As Integer = 0 To CurrentCount - 1
                    csv.AppendLine(
                        (i + 1) & "," &
                        CsvEscape(arrID(i)) & "," &
                        CsvEscape(arrNames(i)) & "," &
                        arrAge(i) & "," &
                        CsvEscape(arrSex(i)) & "," &
                        CsvEscape(arrContact(i)) & "," &
                        CsvEscape(arrService(i)) & "," &
                        CsvEscape(arrSchedule(i)) & "," &
                        CsvEscape(arrStatus(i)) & "," &
                        CsvEscape(If(arrDiagnosis(i) IsNot Nothing, arrDiagnosis(i), "N/A")) & "," &
                        CsvEscape(If(arrPrescription(i) IsNot Nothing, arrPrescription(i), "N/A")) & "," &
                        CsvEscape(If(arrConsultNotes(i) IsNot Nothing, arrConsultNotes(i), "N/A")) & "," &
                        CsvEscape(If(arrMedHistory(i) IsNot Nothing, arrMedHistory(i), "N/A"))
                    )
                Next
            Else
                ' Daily or Monthly — appointment columns only
                csv.AppendLine("No,ID,Name,Age,Sex,Service,Schedule,Status")
                For i As Integer = 0 To CurrentCount - 1
                    ' Only include rows that match the report
                    Dim include As Boolean = False
                    If currentReportTitle.Contains("Daily") Then
                        Dim selectedDate As String = dtpReportDate.Value.ToShortDateString()
                        If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i).Contains(selectedDate) Then
                            include = True
                        End If
                    ElseIf currentReportTitle.Contains("Monthly") Then
                        Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
                        If arrSchedule(i) IsNot Nothing AndAlso arrSchedule(i) <> "Not Set" Then
                            Try
                                Dim schedDate As DateTime = DateTime.Parse(arrSchedule(i).Split("@")(0).Trim())
                                If schedDate.Month = selectedMonth Then include = True
                            Catch
                            End Try
                        End If
                    End If

                    If include Then
                        csv.AppendLine(
                            (i + 1) & "," &
                            CsvEscape(arrID(i)) & "," &
                            CsvEscape(arrNames(i)) & "," &
                            arrAge(i) & "," &
                            CsvEscape(arrSex(i)) & "," &
                            CsvEscape(arrService(i)) & "," &
                            CsvEscape(arrSchedule(i)) & "," &
                            CsvEscape(arrStatus(i))
                        )
                    End If
                Next
            End If

            File.WriteAllText(saveDlg.FileName, csv.ToString(), System.Text.Encoding.UTF8)
            MessageBox.Show("Report exported to CSV." & vbNewLine &
                            "Open the file with Microsoft Excel.")

            ' Open the file directly in Excel
            Process.Start(saveDlg.FileName)
        End If
    End Sub

    ' Wraps a value in quotes and escapes internal quotes for valid CSV
    Private Function CsvEscape(value As String) As String
        If value Is Nothing Then Return """"""""
        Return """" & value.Replace("""", """""") & """"
    End Function

    ' Navigation 

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        AdminFrm.Show()
        Me.Close()
    End Sub

End Class