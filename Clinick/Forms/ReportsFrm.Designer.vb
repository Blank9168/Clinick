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
        btnPrint = New Button()
        btnExportExcel = New Button()
        btnClose = New Button()
        dgvReports = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colPatient = New DataGridViewTextBoxColumn()
        colService = New DataGridViewTextBoxColumn()
        colSchedule = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colProcessed = New DataGridViewTextBoxColumn()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpReportDate
        ' 
        dtpReportDate.Location = New Point(113, 12)
        dtpReportDate.Name = "dtpReportDate"
        dtpReportDate.Size = New Size(200, 23)
        dtpReportDate.TabIndex = 0
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(141, 41)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(121, 23)
        cmbMonth.TabIndex = 1
        ' 
        ' btnGenerateDaily
        ' 
        btnGenerateDaily.Location = New Point(11, 12)
        btnGenerateDaily.Name = "btnGenerateDaily"
        btnGenerateDaily.Size = New Size(96, 23)
        btnGenerateDaily.TabIndex = 2
        btnGenerateDaily.Text = "Generate Daily"
        btnGenerateDaily.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateMonthly
        ' 
        btnGenerateMonthly.Location = New Point(12, 41)
        btnGenerateMonthly.Name = "btnGenerateMonthly"
        btnGenerateMonthly.Size = New Size(123, 23)
        btnGenerateMonthly.TabIndex = 3
        btnGenerateMonthly.Text = "Generate Monthly"
        btnGenerateMonthly.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(11, 109)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 5
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(103, 109)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(92, 23)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(228, 109)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Columns.AddRange(New DataGridViewColumn() {colID, colPatient, colService, colSchedule, colStatus, colProcessed})
        dgvReports.Location = New Point(20, 160)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.Size = New Size(828, 418)
        dgvReports.TabIndex = 9
        ' 
        ' colID
        ' 
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colPatient
        ' 
        colPatient.HeaderText = "Patient"
        colPatient.Name = "colPatient"
        colPatient.ReadOnly = True
        ' 
        ' colService
        ' 
        colService.HeaderText = "Service Type"
        colService.Name = "colService"
        colService.ReadOnly = True
        ' 
        ' colSchedule
        ' 
        colSchedule.HeaderText = "Scheduled For"
        colSchedule.Name = "colSchedule"
        colSchedule.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colProcessed
        ' 
        colProcessed.HeaderText = "Date Processed"
        colProcessed.Name = "colProcessed"
        colProcessed.ReadOnly = True
        ' 
        ' ReportsFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 595)
        Controls.Add(dgvReports)
        Controls.Add(btnClose)
        Controls.Add(btnExportExcel)
        Controls.Add(btnPrint)
        Controls.Add(btnGenerateMonthly)
        Controls.Add(btnGenerateDaily)
        Controls.Add(cmbMonth)
        Controls.Add(dtpReportDate)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReportsFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReportsFrm"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtpReportDate As DateTimePicker
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents btnGenerateDaily As Button
    Friend WithEvents btnGenerateMonthly As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtReportPreview As TextBox
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colPatient As DataGridViewTextBoxColumn
    Friend WithEvents colService As DataGridViewTextBoxColumn
    Friend WithEvents colSchedule As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colProcessed As DataGridViewTextBoxColumn
End Class
