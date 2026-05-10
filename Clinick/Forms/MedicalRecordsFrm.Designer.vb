<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecordsFrm
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
        txtDiagnosis = New TextBox()
        txtPrescription = New TextBox()
        txtConsultNotes = New TextBox()
        txtMedHistory = New TextBox()
        dgvPatientHistory = New DataGridView()
        btnSave = New Button()
        btnClear = New Button()
        btnViewHistory = New Button()
        btnClose = New Button()
        colHistID = New DataGridViewTextBoxColumn()
        colHistSchedule = New DataGridViewTextBoxColumn()
        colHistService = New DataGridViewTextBoxColumn()
        colHistStatus = New DataGridViewTextBoxColumn()
        colHistDiagnosis = New DataGridViewTextBoxColumn()
        lblPatientID = New Label()
        lblPatientName = New Label()
        lblAge = New Label()
        lblSex = New Label()
        lblService = New Label()
        lblSchedule = New Label()
        lblStatus = New Label()
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDiagnosis
        ' 
        txtDiagnosis.BorderStyle = BorderStyle.FixedSingle
        txtDiagnosis.Location = New Point(27, 28)
        txtDiagnosis.Multiline = True
        txtDiagnosis.Name = "txtDiagnosis"
        txtDiagnosis.PlaceholderText = "Diagnosis"
        txtDiagnosis.Size = New Size(100, 23)
        txtDiagnosis.TabIndex = 0
        ' 
        ' txtPrescription
        ' 
        txtPrescription.BorderStyle = BorderStyle.FixedSingle
        txtPrescription.Location = New Point(27, 68)
        txtPrescription.Multiline = True
        txtPrescription.Name = "txtPrescription"
        txtPrescription.PlaceholderText = "Prescription"
        txtPrescription.Size = New Size(100, 23)
        txtPrescription.TabIndex = 1
        ' 
        ' txtConsultNotes
        ' 
        txtConsultNotes.BorderStyle = BorderStyle.FixedSingle
        txtConsultNotes.Location = New Point(27, 104)
        txtConsultNotes.Multiline = True
        txtConsultNotes.Name = "txtConsultNotes"
        txtConsultNotes.PlaceholderText = "Consult Notes"
        txtConsultNotes.Size = New Size(100, 23)
        txtConsultNotes.TabIndex = 2
        ' 
        ' txtMedHistory
        ' 
        txtMedHistory.BorderStyle = BorderStyle.FixedSingle
        txtMedHistory.Location = New Point(27, 144)
        txtMedHistory.Multiline = True
        txtMedHistory.Name = "txtMedHistory"
        txtMedHistory.PlaceholderText = "Medical History"
        txtMedHistory.Size = New Size(100, 23)
        txtMedHistory.TabIndex = 3
        ' 
        ' dgvPatientHistory
        ' 
        dgvPatientHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPatientHistory.Columns.AddRange(New DataGridViewColumn() {colHistID, colHistSchedule, colHistService, colHistStatus, colHistDiagnosis})
        dgvPatientHistory.Location = New Point(246, 53)
        dgvPatientHistory.Name = "dgvPatientHistory"
        dgvPatientHistory.Size = New Size(542, 129)
        dgvPatientHistory.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(60, 260)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(176, 260)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.Location = New Point(295, 260)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(75, 23)
        btnViewHistory.TabIndex = 7
        btnViewHistory.Text = "View History"
        btnViewHistory.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(405, 260)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 8
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' colHistID
        ' 
        colHistID.HeaderText = "ID"
        colHistID.Name = "colHistID"
        colHistID.ReadOnly = True
        ' 
        ' colHistSchedule
        ' 
        colHistSchedule.HeaderText = "Schedule"
        colHistSchedule.Name = "colHistSchedule"
        colHistSchedule.ReadOnly = True
        ' 
        ' colHistService
        ' 
        colHistService.HeaderText = "Service"
        colHistService.Name = "colHistService"
        colHistService.ReadOnly = True
        ' 
        ' colHistStatus
        ' 
        colHistStatus.HeaderText = "Status"
        colHistStatus.Name = "colHistStatus"
        colHistStatus.ReadOnly = True
        ' 
        ' colHistDiagnosis
        ' 
        colHistDiagnosis.HeaderText = "Diagnosis"
        colHistDiagnosis.Name = "colHistDiagnosis"
        colHistDiagnosis.ReadOnly = True
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Location = New Point(164, 398)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(68, 15)
        lblPatientID.TabIndex = 9
        lblPatientID.Text = "lblPatientID"
        ' 
        ' lblPatientName
        ' 
        lblPatientName.AutoSize = True
        lblPatientName.Location = New Point(296, 399)
        lblPatientName.Name = "lblPatientName"
        lblPatientName.Size = New Size(89, 15)
        lblPatientName.TabIndex = 10
        lblPatientName.Text = "lblPatientName"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(439, 399)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(41, 15)
        lblAge.TabIndex = 11
        lblAge.Text = "lblAge"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Location = New Point(511, 399)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(37, 15)
        lblSex.TabIndex = 12
        lblSex.Text = "lblSex"
        ' 
        ' lblService
        ' 
        lblService.AutoSize = True
        lblService.Location = New Point(610, 399)
        lblService.Name = "lblService"
        lblService.Size = New Size(57, 15)
        lblService.TabIndex = 13
        lblService.Text = "lblService"
        ' 
        ' lblSchedule
        ' 
        lblSchedule.AutoSize = True
        lblSchedule.Location = New Point(164, 452)
        lblSchedule.Name = "lblSchedule"
        lblSchedule.Size = New Size(68, 15)
        lblSchedule.TabIndex = 14
        lblSchedule.Text = "lblSchedule"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(296, 452)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(52, 15)
        lblStatus.TabIndex = 15
        lblStatus.Text = "lblStatus"
        ' 
        ' MedicalRecordsFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 733)
        Controls.Add(lblStatus)
        Controls.Add(lblSchedule)
        Controls.Add(lblService)
        Controls.Add(lblSex)
        Controls.Add(lblAge)
        Controls.Add(lblPatientName)
        Controls.Add(lblPatientID)
        Controls.Add(btnClose)
        Controls.Add(btnViewHistory)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(dgvPatientHistory)
        Controls.Add(txtMedHistory)
        Controls.Add(txtConsultNotes)
        Controls.Add(txtPrescription)
        Controls.Add(txtDiagnosis)
        Name = "MedicalRecordsFrm"
        Text = "MedicalRecordsFrm"
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents txtPrescription As TextBox
    Friend WithEvents txtConsultNotes As TextBox
    Friend WithEvents txtMedHistory As TextBox
    Friend WithEvents dgvPatientHistory As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents colHistID As DataGridViewTextBoxColumn
    Friend WithEvents colHistSchedule As DataGridViewTextBoxColumn
    Friend WithEvents colHistService As DataGridViewTextBoxColumn
    Friend WithEvents colHistStatus As DataGridViewTextBoxColumn
    Friend WithEvents colHistDiagnosis As DataGridViewTextBoxColumn
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblStatus As Label
End Class
