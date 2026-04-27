<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PediatricsFrm
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
        btnBack = New Button()
        Panel1 = New Panel()
        Patients = New ListBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        txtPatientName = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        rbInfant = New RadioButton()
        rbToddler = New RadioButton()
        rbSchool = New RadioButton()
        Label5 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        lblPatientID = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox1 = New GroupBox()
        TextBox4 = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label9 = New Label()
        btnAddPatient = New Button()
        GroupBox2 = New GroupBox()
        rbGuardian = New RadioButton()
        rbGuradian = New RadioButton()
        rbGrowth = New RadioButton()
        rbVaccine = New RadioButton()
        rbSickV = New RadioButton()
        Label8 = New Label()
        Label15 = New Label()
        lblAppStatus = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnBack.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnBack.Location = New Point(14, 615)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(204, 35)
        btnBack.TabIndex = 1
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Patients)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnBack)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(239, 663)
        Panel1.TabIndex = 2
        ' 
        ' Patients
        ' 
        Patients.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Patients.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Patients.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Patients.FormattingEnabled = True
        Patients.Location = New Point(14, 74)
        Patients.Name = "Patients"
        Patients.Size = New Size(204, 508)
        Patients.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(14, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 38)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(59, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 25)
        Label1.TabIndex = 2
        Label1.Text = "Pediatrics"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(9, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 20)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Location = New Point(121, 69)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(408, 27)
        txtPatientName.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(9, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 6
        Label2.Text = "Patient Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(9, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 20)
        Label4.TabIndex = 7
        Label4.Text = "Age Group:"
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(104, 116)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(181, 24)
        rbInfant.TabIndex = 8
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(104, 146)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(135, 24)
        rbToddler.TabIndex = 9
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
        ' 
        ' rbSchool
        ' 
        rbSchool.AutoSize = True
        rbSchool.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(104, 176)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(159, 24)
        rbSchool.TabIndex = 10
        rbSchool.TabStop = True
        rbSchool.Text = "School Age (4y+)"
        rbSchool.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(310, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 11
        Label5.Text = "Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(362, 116)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(66, 24)
        rbMale.TabIndex = 12
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbFemale.ForeColor = Color.Black
        rbFemale.Location = New Point(434, 116)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(85, 24)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(9, 257)
        Label6.Name = "Label6"
        Label6.Size = New Size(229, 20)
        Label6.TabIndex = 14
        Label6.Text = "Parent/Guardian Contact No.:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(244, 256)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(285, 27)
        TextBox2.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(9, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 20)
        Label7.TabIndex = 16
        Label7.Text = "Name of Parent/Guradian:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(219, 215)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(310, 27)
        TextBox3.TabIndex = 17
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(114, 35)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(22, 20)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "id"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(244, 115)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(285, 27)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(244, 82)
        Label10.Name = "Label10"
        Label10.Size = New Size(124, 20)
        Label10.TabIndex = 21
        Label10.Text = "Date and Time:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(16, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(160, 20)
        Label11.TabIndex = 22
        Label11.Text = "Appointment Status:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblAppStatus)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(rbSickV)
        GroupBox1.Controls.Add(rbVaccine)
        GroupBox1.Controls.Add(rbGrowth)
        GroupBox1.Controls.Add(rbGuradian)
        GroupBox1.Controls.Add(rbGuardian)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(253, 327)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(547, 278)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Microsoft Sans Serif", 10.2F)
        TextBox4.Location = New Point(16, 231)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(498, 27)
        TextBox4.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(244, 163)
        Label13.Name = "Label13"
        Label13.Size = New Size(145, 20)
        Label13.TabIndex = 25
        Label13.Text = "Guardian Present:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(17, 208)
        Label12.Name = "Label12"
        Label12.Size = New Size(128, 20)
        Label12.TabIndex = 24
        Label12.Text = "Cancel Reason:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(17, 62)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 20)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAddPatient.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddPatient.Location = New Point(671, 612)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(129, 40)
        btnAddPatient.TabIndex = 24
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtPatientName)
        GroupBox2.Controls.Add(lblPatientID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(rbInfant)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(rbMale)
        GroupBox2.Controls.Add(rbSchool)
        GroupBox2.Controls.Add(rbFemale)
        GroupBox2.Controls.Add(rbToddler)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox2.Location = New Point(253, 21)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(547, 297)
        GroupBox2.TabIndex = 25
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' rbGuardian
        ' 
        rbGuardian.AutoSize = True
        rbGuardian.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbGuardian.Location = New Point(254, 189)
        rbGuardian.Name = "rbGuardian"
        rbGuardian.Size = New Size(79, 24)
        rbGuardian.TabIndex = 26
        rbGuardian.TabStop = True
        rbGuardian.Text = "Parent"
        rbGuardian.UseVisualStyleBackColor = True
        ' 
        ' rbGuradian
        ' 
        rbGuradian.AutoSize = True
        rbGuradian.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbGuradian.Location = New Point(350, 189)
        rbGuradian.Name = "rbGuradian"
        rbGuradian.Size = New Size(98, 24)
        rbGuradian.TabIndex = 27
        rbGuradian.TabStop = True
        rbGuradian.Text = "Guardian"
        rbGuradian.UseVisualStyleBackColor = True
        ' 
        ' rbGrowth
        ' 
        rbGrowth.AutoSize = True
        rbGrowth.Font = New Font("Microsoft Sans Serif", 10.2F)
        rbGrowth.Location = New Point(36, 95)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(136, 24)
        rbGrowth.TabIndex = 29
        rbGrowth.TabStop = True
        rbGrowth.Text = "Growth Check"
        rbGrowth.UseVisualStyleBackColor = True
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 10.2F)
        rbVaccine.Location = New Point(36, 129)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(117, 24)
        rbVaccine.TabIndex = 30
        rbVaccine.TabStop = True
        rbVaccine.Text = "Vaccination"
        rbVaccine.UseVisualStyleBackColor = True
        ' 
        ' rbSickV
        ' 
        rbSickV.AutoSize = True
        rbSickV.Font = New Font("Microsoft Sans Serif", 10.2F)
        rbSickV.Location = New Point(36, 163)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(100, 24)
        rbSickV.TabIndex = 31
        rbSickV.TabStop = True
        rbSickV.Text = "Sick Visit"
        rbSickV.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(244, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 20)
        Label8.TabIndex = 32
        Label8.Text = "Appointment Schedule:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(370, 82)
        Label15.Name = "Label15"
        Label15.Size = New Size(68, 20)
        Label15.TabIndex = 34
        Label15.Text = "Label15"
        ' 
        ' lblAppStatus
        ' 
        lblAppStatus.AutoSize = True
        lblAppStatus.Font = New Font("Microsoft Sans Serif", 10.2F)
        lblAppStatus.ForeColor = Color.Black
        lblAppStatus.Location = New Point(175, 29)
        lblAppStatus.Name = "lblAppStatus"
        lblAppStatus.Size = New Size(45, 20)
        lblAppStatus.TabIndex = 35
        lblAppStatus.Text = "aaaa"
        ' 
        ' PediatricsFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(812, 663)
        Controls.Add(btnAddPatient)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "PediatricsFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Patients As ListBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbInfant As RadioButton
    Friend WithEvents rbToddler As RadioButton
    Friend WithEvents rbSchool As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbGuardian As RadioButton
    Friend WithEvents rbGuradian As RadioButton
    Friend WithEvents rbVaccine As RadioButton
    Friend WithEvents rbGrowth As RadioButton
    Friend WithEvents rbSickV As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblAppStatus As Label
End Class
