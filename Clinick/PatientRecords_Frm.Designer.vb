<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientRecords_Frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox5 = New PictureBox()
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchName
        ' 
        txtSearchName.BorderStyle = BorderStyle.FixedSingle
        txtSearchName.Location = New Point(41, 28)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(315, 23)
        txtSearchName.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Teal
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(365, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(120, 35)
        btnSearch.TabIndex = 1
        btnSearch.Text = "   Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvPatientHistory
        ' 
        dgvPatientHistory.AllowUserToAddRows = False
        dgvPatientHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPatientHistory.BackgroundColor = Color.FromArgb(CByte(221), CByte(240), CByte(243))
        dgvPatientHistory.BorderStyle = BorderStyle.None
        dgvPatientHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPatientHistory.Columns.AddRange(New DataGridViewColumn() {ID, Patient, Contact, Age, Sex, DOB})
        dgvPatientHistory.Location = New Point(20, 89)
        dgvPatientHistory.MultiSelect = False
        dgvPatientHistory.Name = "dgvPatientHistory"
        dgvPatientHistory.ReadOnly = True
        dgvPatientHistory.RowHeadersVisible = False
        dgvPatientHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPatientHistory.Size = New Size(814, 394)
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
        btnClose.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Teal
        btnClose.Location = New Point(713, 23)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(102, 34)
        btnClose.TabIndex = 3
        btnClose.Text = "   Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Reports_Banner__2_
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-4, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(961, 87)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtSearchName)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(dgvPatientHistory)
        Panel1.Location = New Point(12, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(856, 500)
        Panel1.TabIndex = 12
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(726, 28)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(13, 24)
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Teal
        PictureBox3.BackgroundImage = My.Resources.Resources.Iconsss__10_1
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(373, 27)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 24)
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        PictureBox2.Location = New Point(20, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(814, 65)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(78, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 32)
        Label2.TabIndex = 14
        Label2.Text = "Patient Records"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(82, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 13)
        Label1.TabIndex = 15
        Label1.Text = "View and manage all patient information"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(15, 15)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(60, 51)
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PatientRecords_Frm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(249), CByte(251), CByte(253))
        ClientSize = New Size(880, 595)
        Controls.Add(PictureBox5)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecords_Frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientRecords_Frm"
        CType(dgvPatientHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
