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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRecords_Frm))
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchName
        ' 
        txtSearchName.BorderStyle = BorderStyle.FixedSingle
        txtSearchName.Location = New Point(53, 124)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(315, 23)
        txtSearchName.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Teal
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(383, 117)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 35)
        btnSearch.TabIndex = 1
        btnSearch.Text = "    Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvPatientHistory
        ' 
        dgvPatientHistory.AllowUserToAddRows = False
        dgvPatientHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPatientHistory.BackgroundColor = Color.FromArgb(CByte(221), CByte(240), CByte(243))
        dgvPatientHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPatientHistory.Columns.AddRange(New DataGridViewColumn() {ID, Patient, Contact, Age, Sex, DOB})
        dgvPatientHistory.Location = New Point(28, 184)
        dgvPatientHistory.MultiSelect = False
        dgvPatientHistory.Name = "dgvPatientHistory"
        dgvPatientHistory.ReadOnly = True
        dgvPatientHistory.RowHeadersVisible = False
        dgvPatientHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPatientHistory.Size = New Size(828, 376)
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
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Teal
        btnClose.Location = New Point(738, 116)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(95, 34)
        btnClose.TabIndex = 3
        btnClose.Text = "     Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Reports_Banner__2_
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-3, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(961, 87)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        PictureBox2.Location = New Point(28, 99)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(828, 70)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(79, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 32)
        Label2.TabIndex = 14
        Label2.Text = "Patient Records"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.Iconsss__9_
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(12, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(58, 50)
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(749, 121)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(14, 25)
        PictureBox6.TabIndex = 16
        PictureBox6.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Teal
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(394, 122)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(21, 25)
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' PatientRecords_Frm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        ClientSize = New Size(880, 595)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox3)
        Controls.Add(Label2)
        Controls.Add(btnClose)
        Controls.Add(dgvPatientHistory)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchName)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecords_Frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientRecords_Frm"
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
