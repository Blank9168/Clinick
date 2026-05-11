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
        dtpReportDate.Location = New Point(129, 16)
        dtpReportDate.Margin = New Padding(3, 4, 3, 4)
        dtpReportDate.Name = "dtpReportDate"
        dtpReportDate.Size = New Size(228, 27)
        dtpReportDate.TabIndex = 0
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(161, 55)
        cmbMonth.Margin = New Padding(3, 4, 3, 4)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(138, 28)
        cmbMonth.TabIndex = 1
        ' 
        ' btnGenerateDaily
        ' 
        btnGenerateDaily.Location = New Point(13, 16)
        btnGenerateDaily.Margin = New Padding(3, 4, 3, 4)
        btnGenerateDaily.Name = "btnGenerateDaily"
        btnGenerateDaily.Size = New Size(110, 31)
        btnGenerateDaily.TabIndex = 2
        btnGenerateDaily.Text = "Generate Daily"
        btnGenerateDaily.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateMonthly
        ' 
        btnGenerateMonthly.Location = New Point(14, 55)
        btnGenerateMonthly.Margin = New Padding(3, 4, 3, 4)
        btnGenerateMonthly.Name = "btnGenerateMonthly"
        btnGenerateMonthly.Size = New Size(141, 31)
        btnGenerateMonthly.TabIndex = 3
        btnGenerateMonthly.Text = "Generate Monthly"
        btnGenerateMonthly.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(13, 145)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(86, 31)
        btnPrint.TabIndex = 5
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(118, 145)
        btnExportExcel.Margin = New Padding(3, 4, 3, 4)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(105, 31)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(261, 145)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(86, 31)
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
        dgvReports.Location = New Point(23, 213)
        dgvReports.Margin = New Padding(3, 4, 3, 4)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersWidth = 51
        dgvReports.Size = New Size(946, 557)
        dgvReports.TabIndex = 9
        ' 
        ' colID
        ' 
        colID.HeaderText = "ID"
        colID.MinimumWidth = 6
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colPatient
        ' 
        colPatient.HeaderText = "Patient"
        colPatient.MinimumWidth = 6
        colPatient.Name = "colPatient"
        colPatient.ReadOnly = True
        ' 
        ' colService
        ' 
        colService.HeaderText = "Service Type"
        colService.MinimumWidth = 6
        colService.Name = "colService"
        colService.ReadOnly = True
        ' 
        ' colSchedule
        ' 
        colSchedule.HeaderText = "Scheduled For"
        colSchedule.MinimumWidth = 6
        colSchedule.Name = "colSchedule"
        colSchedule.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colProcessed
        ' 
        colProcessed.HeaderText = "Completed/Cancelled On"
        colProcessed.MinimumWidth = 6
        colProcessed.Name = "colProcessed"
        colProcessed.ReadOnly = True
        ' 
        ' ReportsFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 793)
        Controls.Add(dgvReports)
        Controls.Add(btnClose)
        Controls.Add(btnExportExcel)
        Controls.Add(btnPrint)
        Controls.Add(btnGenerateMonthly)
        Controls.Add(btnGenerateDaily)
        Controls.Add(cmbMonth)
        Controls.Add(dtpReportDate)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
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
