<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRecords_Frm
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
        txtSearchName = New MaskedTextBox()
        btnSearch = New Button()
        dgvPatientHistory = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Patient = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        DOB = New DataGridViewTextBoxColumn()
        btnClose = New Button()
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchName
        ' 
        txtSearchName.Location = New Point(168, 70)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(315, 23)
        txtSearchName.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(566, 63)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(120, 35)
        btnSearch.TabIndex = 1
        btnSearch.Text = "search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvPatientHistory
        ' 
        dgvPatientHistory.AllowUserToAddRows = False
        dgvPatientHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPatientHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPatientHistory.Columns.AddRange(New DataGridViewColumn() {ID, Patient, Contact, Age, Sex, DOB})
        dgvPatientHistory.Location = New Point(102, 161)
        dgvPatientHistory.MultiSelect = False
        dgvPatientHistory.Name = "dgvPatientHistory"
        dgvPatientHistory.ReadOnly = True
        dgvPatientHistory.RowHeadersVisible = False
        dgvPatientHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPatientHistory.Size = New Size(648, 376)
        dgvPatientHistory.TabIndex = 2
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' Patient
        ' 
        Patient.HeaderText = "Patient Name"
        Patient.Name = "Patient"
        Patient.ReadOnly = True
        ' 
        ' Contact
        ' 
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        Contact.ReadOnly = True
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.Name = "Age"
        Age.ReadOnly = True
        ' 
        ' Sex
        ' 
        Sex.HeaderText = "Sex"
        Sex.Name = "Sex"
        Sex.ReadOnly = True
        ' 
        ' DOB
        ' 
        DOB.HeaderText = "Date of Birth"
        DOB.Name = "DOB"
        DOB.ReadOnly = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(746, 49)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(53, 34)
        btnClose.TabIndex = 3
        btnClose.Text = "close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' PatientRecords_Frm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 595)
        Controls.Add(btnClose)
        Controls.Add(dgvPatientHistory)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchName)
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecords_Frm"
        Text = "PatientRecords_Frm"
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearchName As MaskedTextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvPatientHistory As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Patient As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
End Class
