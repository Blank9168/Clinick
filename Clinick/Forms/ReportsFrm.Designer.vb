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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsFrm))
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpReportDate
        ' 
        dtpReportDate.Location = New Point(151, 37)
        dtpReportDate.Name = "dtpReportDate"
        dtpReportDate.Size = New Size(200, 23)
        dtpReportDate.TabIndex = 0
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(535, 37)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(121, 23)
        cmbMonth.TabIndex = 1
        ' 
        ' btnGenerateDaily
        ' 
        btnGenerateDaily.BackColor = Color.Teal
        btnGenerateDaily.FlatStyle = FlatStyle.Flat
        btnGenerateDaily.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerateDaily.ForeColor = Color.Transparent
        btnGenerateDaily.Location = New Point(29, 31)
        btnGenerateDaily.Name = "btnGenerateDaily"
        btnGenerateDaily.Size = New Size(111, 35)
        btnGenerateDaily.TabIndex = 2
        btnGenerateDaily.Text = "Generate Daily"
        btnGenerateDaily.UseVisualStyleBackColor = False
        ' 
        ' btnGenerateMonthly
        ' 
        btnGenerateMonthly.BackColor = Color.Teal
        btnGenerateMonthly.FlatStyle = FlatStyle.Flat
        btnGenerateMonthly.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerateMonthly.ForeColor = Color.Transparent
        btnGenerateMonthly.Location = New Point(388, 31)
        btnGenerateMonthly.Name = "btnGenerateMonthly"
        btnGenerateMonthly.Size = New Size(136, 35)
        btnGenerateMonthly.TabIndex = 3
        btnGenerateMonthly.Text = "Generate Monthly"
        btnGenerateMonthly.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.Teal
        btnPrint.Location = New Point(29, 101)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(88, 33)
        btnPrint.TabIndex = 5
        btnPrint.Text = "       Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportExcel.ForeColor = Color.Teal
        btnExportExcel.Location = New Point(135, 101)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(136, 33)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "    Export Excel"
        btnExportExcel.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Teal
        btnClose.Location = New Point(749, 101)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(84, 33)
        btnClose.TabIndex = 8
        btnClose.Text = "    Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' dgvReports
        ' 
        dgvReports.AllowUserToAddRows = False
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReports.BackgroundColor = Color.FromArgb(CByte(221), CByte(240), CByte(243))
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Columns.AddRange(New DataGridViewColumn() {colID, colPatient, colService, colSchedule, colStatus, colProcessed})
        dgvReports.Location = New Point(15, 149)
        dgvReports.Name = "dgvReports"
        dgvReports.ReadOnly = True
        dgvReports.RowHeadersWidth = 51
        dgvReports.Size = New Size(828, 340)
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
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Reports_Banner__2_
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(961, 87)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnExportExcel)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(cmbMonth)
        Panel1.Controls.Add(dtpReportDate)
        Panel1.Controls.Add(btnGenerateMonthly)
        Panel1.Controls.Add(btnGenerateDaily)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(dgvReports)
        Panel1.Location = New Point(12, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(856, 497)
        Panel1.TabIndex = 11
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        PictureBox2.Location = New Point(15, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(828, 70)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        PictureBox3.Location = New Point(15, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(828, 52)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(84, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 13)
        Label1.TabIndex = 12
        Label1.Text = "View and export appointment reports"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(80, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 32)
        Label2.TabIndex = 13
        Label2.Text = "Reports"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources.Iconsss__3_
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(38, 105)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(23, 25)
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(145, 105)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(23, 25)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(759, 106)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(14, 25)
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' ReportsFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        ClientSize = New Size(880, 595)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReportsFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReportsFrm"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
