<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtpReportDate = New DateTimePicker()
        cmbMonth = New ComboBox()
        btnGenerateDaily = New Button()
        btnGenerateMonthly = New Button()
        btnGeneratePatientRecords = New Button()
        btnPrint = New Button()
        btnExportPDF = New Button()
        btnExportExcel = New Button()
        btnClose = New Button()
        txtReportPreview = New TextBox()
        SuspendLayout()
        ' 
        ' dtpReportDate
        ' 
        dtpReportDate.Location = New Point(56, 78)
        dtpReportDate.Name = "dtpReportDate"
        dtpReportDate.Size = New Size(200, 23)
        dtpReportDate.TabIndex = 0
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(56, 133)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(121, 23)
        cmbMonth.TabIndex = 1
        ' 
        ' btnGenerateDaily
        ' 
        btnGenerateDaily.Location = New Point(32, 200)
        btnGenerateDaily.Name = "btnGenerateDaily"
        btnGenerateDaily.Size = New Size(96, 23)
        btnGenerateDaily.TabIndex = 2
        btnGenerateDaily.Text = "Generate Daily"
        btnGenerateDaily.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateMonthly
        ' 
        btnGenerateMonthly.Location = New Point(148, 200)
        btnGenerateMonthly.Name = "btnGenerateMonthly"
        btnGenerateMonthly.Size = New Size(123, 23)
        btnGenerateMonthly.TabIndex = 3
        btnGenerateMonthly.Text = "Generate Monthly"
        btnGenerateMonthly.UseVisualStyleBackColor = True
        ' 
        ' btnGeneratePatientRecords
        ' 
        btnGeneratePatientRecords.Location = New Point(286, 200)
        btnGeneratePatientRecords.Name = "btnGeneratePatientRecords"
        btnGeneratePatientRecords.Size = New Size(152, 23)
        btnGeneratePatientRecords.TabIndex = 4
        btnGeneratePatientRecords.Text = "Generate Patient Records"
        btnGeneratePatientRecords.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(32, 246)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 5
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExportPDF
        ' 
        btnExportPDF.Location = New Point(148, 246)
        btnExportPDF.Name = "btnExportPDF"
        btnExportPDF.Size = New Size(75, 23)
        btnExportPDF.TabIndex = 6
        btnExportPDF.Text = "Export PDF"
        btnExportPDF.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(286, 246)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(92, 23)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(32, 397)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' txtReportPreview
        ' 
        txtReportPreview.BorderStyle = BorderStyle.FixedSingle
        txtReportPreview.Location = New Point(32, 300)
        txtReportPreview.Multiline = True
        txtReportPreview.Name = "txtReportPreview"
        txtReportPreview.PlaceholderText = "Report Preview"
        txtReportPreview.Size = New Size(406, 81)
        txtReportPreview.TabIndex = 9
        ' 
        ' ReportsFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtReportPreview)
        Controls.Add(btnClose)
        Controls.Add(btnExportExcel)
        Controls.Add(btnExportPDF)
        Controls.Add(btnPrint)
        Controls.Add(btnGeneratePatientRecords)
        Controls.Add(btnGenerateMonthly)
        Controls.Add(btnGenerateDaily)
        Controls.Add(cmbMonth)
        Controls.Add(dtpReportDate)
        Name = "ReportsFrm"
        Text = "ReportsFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpReportDate As DateTimePicker
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents btnGenerateDaily As Button
    Friend WithEvents btnGenerateMonthly As Button
    Friend WithEvents btnGeneratePatientRecords As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExportPDF As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtReportPreview As TextBox
End Class
