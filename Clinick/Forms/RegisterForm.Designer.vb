<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        GroupBox1 = New GroupBox()
        lblPatientName = New Label()
        Label1 = New Label()
        cmbTimeSlots = New ComboBox()
        Label8 = New Label()
        grpPedia = New GroupBox()
        GroupBox3 = New GroupBox()
        rbVaccine = New RadioButton()
        rbSickV = New RadioButton()
        rbGrowth = New RadioButton()
        grpAgeGroup = New GroupBox()
        rbToddler = New RadioButton()
        rbSchool = New RadioButton()
        rbInfant = New RadioButton()
        txtParentGName = New TextBox()
        Label4 = New Label()
        grpDental = New GroupBox()
        grpPatientType = New GroupBox()
        rbChild = New RadioButton()
        rbAdult = New RadioButton()
        grpProcedure = New GroupBox()
        rbFilling = New RadioButton()
        rbExtraction = New RadioButton()
        rbCleaning = New RadioButton()
        Label2 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        grpGeneral = New GroupBox()
        grpPrimaryConcern = New GroupBox()
        rbPhysicalExam = New RadioButton()
        rbInjury = New RadioButton()
        rbFever = New RadioButton()
        grpUrgency = New GroupBox()
        rbFollowUp = New RadioButton()
        rbUrgent = New RadioButton()
        rbRoutine = New RadioButton()
        Label5 = New Label()
        Label6 = New Label()
        btnSearch = New Button()
        lblSearchPrompt = New Label()
        btnAppointPatient = New Button()
        txtSearchID = New MaskedTextBox()
        dtpDate = New DateTimePicker()
        btnClear = New Button()
        lblPatientNameDisplay = New Label()
        btnReturnMainPd = New Button()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        grpPedia.SuspendLayout()
        GroupBox3.SuspendLayout()
        grpAgeGroup.SuspendLayout()
        grpDental.SuspendLayout()
        grpPatientType.SuspendLayout()
        grpProcedure.SuspendLayout()
        grpGeneral.SuspendLayout()
        grpPrimaryConcern.SuspendLayout()
        grpUrgency.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(lblPatientName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbTimeSlots)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(grpDental)
        GroupBox1.Controls.Add(grpPedia)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(grpGeneral)
        GroupBox1.Controls.Add(btnSearch)
        GroupBox1.Controls.Add(lblSearchPrompt)
        GroupBox1.Controls.Add(btnAppointPatient)
        GroupBox1.Controls.Add(txtSearchID)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(85, 76)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(685, 374)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "PATIENT APPOINTMENT"
        ' 
        ' lblPatientName
        ' 
        lblPatientName.AutoSize = True
        lblPatientName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientName.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientName.Location = New Point(186, 44)
        lblPatientName.Name = "lblPatientName"
        lblPatientName.Size = New Size(0, 20)
        lblPatientName.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 44
        Label1.Text = "Appointment for:"
        ' 
        ' cmbTimeSlots
        ' 
        cmbTimeSlots.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbTimeSlots.FormattingEnabled = True
        cmbTimeSlots.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"})
        cmbTimeSlots.Location = New Point(408, 111)
        cmbTimeSlots.Margin = New Padding(3, 2, 3, 2)
        cmbTimeSlots.Name = "cmbTimeSlots"
        cmbTimeSlots.Size = New Size(201, 28)
        cmbTimeSlots.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(408, 87)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 35
        Label8.Text = "Time: "
        ' 
        ' grpPedia
        ' 
        grpPedia.BackColor = Color.White
        grpPedia.Controls.Add(GroupBox3)
        grpPedia.Controls.Add(grpAgeGroup)
        grpPedia.Controls.Add(txtParentGName)
        grpPedia.Controls.Add(Label4)
        grpPedia.Controls.Add(Label9)
        grpPedia.Controls.Add(Label7)
        grpPedia.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPedia.ForeColor = Color.Black
        grpPedia.Location = New Point(29, 150)
        grpPedia.Margin = New Padding(3, 2, 3, 2)
        grpPedia.Name = "grpPedia"
        grpPedia.Padding = New Padding(3, 2, 3, 2)
        grpPedia.Size = New Size(624, 174)
        grpPedia.TabIndex = 24
        grpPedia.TabStop = False
        grpPedia.Text = "PEDIA"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbVaccine)
        GroupBox3.Controls.Add(rbSickV)
        GroupBox3.Controls.Add(rbGrowth)
        GroupBox3.Location = New Point(389, 69)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(189, 101)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 12F)
        rbVaccine.ForeColor = Color.Black
        rbVaccine.Location = New Point(22, 42)
        rbVaccine.Margin = New Padding(3, 2, 3, 2)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(110, 24)
        rbVaccine.TabIndex = 30
        rbVaccine.TabStop = True
        rbVaccine.Text = "Vaccination"
        rbVaccine.UseVisualStyleBackColor = True
        ' 
        ' rbSickV
        ' 
        rbSickV.AutoSize = True
        rbSickV.Font = New Font("Microsoft Sans Serif", 12F)
        rbSickV.ForeColor = Color.Black
        rbSickV.Location = New Point(22, 68)
        rbSickV.Margin = New Padding(3, 2, 3, 2)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(91, 24)
        rbSickV.TabIndex = 31
        rbSickV.TabStop = True
        rbSickV.Text = "Sick Visit"
        rbSickV.UseVisualStyleBackColor = True
        ' 
        ' rbGrowth
        ' 
        rbGrowth.AutoSize = True
        rbGrowth.Font = New Font("Microsoft Sans Serif", 12F)
        rbGrowth.ForeColor = Color.Black
        rbGrowth.Location = New Point(22, 16)
        rbGrowth.Margin = New Padding(3, 2, 3, 2)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(128, 24)
        rbGrowth.TabIndex = 29
        rbGrowth.TabStop = True
        rbGrowth.Text = "Growth Check"
        rbGrowth.UseVisualStyleBackColor = True
        ' 
        ' grpAgeGroup
        ' 
        grpAgeGroup.Controls.Add(rbToddler)
        grpAgeGroup.Controls.Add(rbSchool)
        grpAgeGroup.Controls.Add(rbInfant)
        grpAgeGroup.Location = New Point(4, 56)
        grpAgeGroup.Margin = New Padding(3, 2, 3, 2)
        grpAgeGroup.Name = "grpAgeGroup"
        grpAgeGroup.Padding = New Padding(3, 2, 3, 2)
        grpAgeGroup.Size = New Size(205, 118)
        grpAgeGroup.TabIndex = 39
        grpAgeGroup.TabStop = False
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 12F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(19, 49)
        rbToddler.Margin = New Padding(3, 2, 3, 2)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(124, 24)
        rbToddler.TabIndex = 27
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
        ' 
        ' rbSchool
        ' 
        rbSchool.AutoSize = True
        rbSchool.Font = New Font("Microsoft Sans Serif", 12F)
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(19, 71)
        rbSchool.Margin = New Padding(3, 2, 3, 2)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(148, 24)
        rbSchool.TabIndex = 28
        rbSchool.TabStop = True
        rbSchool.Text = "School Age (4y+)"
        rbSchool.UseVisualStyleBackColor = True
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 12F)
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(19, 26)
        rbInfant.Margin = New Padding(3, 2, 3, 2)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(172, 24)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(343, 14)
        txtParentGName.Margin = New Padding(3, 2, 3, 2)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(249, 26)
        txtParentGName.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(6, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 25
        Label4.Text = "Age Group:"
        ' 
        ' grpDental
        ' 
        grpDental.BackColor = Color.White
        grpDental.Controls.Add(grpPatientType)
        grpDental.Controls.Add(grpProcedure)
        grpDental.Controls.Add(Label2)
        grpDental.Controls.Add(Label3)
        grpDental.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpDental.ForeColor = Color.Black
        grpDental.Location = New Point(23, 154)
        grpDental.Margin = New Padding(3, 2, 3, 2)
        grpDental.Name = "grpDental"
        grpDental.Padding = New Padding(3, 2, 3, 2)
        grpDental.Size = New Size(630, 177)
        grpDental.TabIndex = 40
        grpDental.TabStop = False
        grpDental.Text = "DENTAL"
        ' 
        ' grpPatientType
        ' 
        grpPatientType.Controls.Add(rbChild)
        grpPatientType.Controls.Add(rbAdult)
        grpPatientType.Location = New Point(407, 61)
        grpPatientType.Margin = New Padding(3, 2, 3, 2)
        grpPatientType.Name = "grpPatientType"
        grpPatientType.Padding = New Padding(3, 2, 3, 2)
        grpPatientType.Size = New Size(189, 67)
        grpPatientType.TabIndex = 33
        grpPatientType.TabStop = False
        ' 
        ' rbChild
        ' 
        rbChild.AutoSize = True
        rbChild.Font = New Font("Microsoft Sans Serif", 12F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(28, 39)
        rbChild.Margin = New Padding(3, 2, 3, 2)
        rbChild.Name = "rbChild"
        rbChild.Size = New Size(62, 24)
        rbChild.TabIndex = 31
        rbChild.TabStop = True
        rbChild.Text = "Child"
        rbChild.UseVisualStyleBackColor = True
        ' 
        ' rbAdult
        ' 
        rbAdult.AutoSize = True
        rbAdult.Font = New Font("Microsoft Sans Serif", 12F)
        rbAdult.ForeColor = Color.Black
        rbAdult.Location = New Point(28, 15)
        rbAdult.Margin = New Padding(3, 2, 3, 2)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(64, 24)
        rbAdult.TabIndex = 30
        rbAdult.TabStop = True
        rbAdult.Text = "Adult"
        rbAdult.UseVisualStyleBackColor = True
        ' 
        ' grpProcedure
        ' 
        grpProcedure.Controls.Add(rbFilling)
        grpProcedure.Controls.Add(rbExtraction)
        grpProcedure.Controls.Add(rbCleaning)
        grpProcedure.Location = New Point(58, 61)
        grpProcedure.Margin = New Padding(3, 2, 3, 2)
        grpProcedure.Name = "grpProcedure"
        grpProcedure.Padding = New Padding(3, 2, 3, 2)
        grpProcedure.Size = New Size(189, 101)
        grpProcedure.TabIndex = 32
        grpProcedure.TabStop = False
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 12F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(22, 66)
        rbFilling.Margin = New Padding(3, 2, 3, 2)
        rbFilling.Name = "rbFilling"
        rbFilling.Size = New Size(67, 24)
        rbFilling.TabIndex = 29
        rbFilling.TabStop = True
        rbFilling.Text = "Filling"
        rbFilling.UseVisualStyleBackColor = True
        ' 
        ' rbExtraction
        ' 
        rbExtraction.AutoSize = True
        rbExtraction.Font = New Font("Microsoft Sans Serif", 12F)
        rbExtraction.ForeColor = Color.Black
        rbExtraction.Location = New Point(22, 40)
        rbExtraction.Margin = New Padding(3, 2, 3, 2)
        rbExtraction.Name = "rbExtraction"
        rbExtraction.Size = New Size(98, 24)
        rbExtraction.TabIndex = 28
        rbExtraction.TabStop = True
        rbExtraction.Text = "Extraction"
        rbExtraction.UseVisualStyleBackColor = True
        ' 
        ' rbCleaning
        ' 
        rbCleaning.AutoSize = True
        rbCleaning.Font = New Font("Microsoft Sans Serif", 12F)
        rbCleaning.ForeColor = Color.Black
        rbCleaning.Location = New Point(22, 14)
        rbCleaning.Margin = New Padding(3, 2, 3, 2)
        rbCleaning.Name = "rbCleaning"
        rbCleaning.Size = New Size(89, 24)
        rbCleaning.TabIndex = 27
        rbCleaning.TabStop = True
        rbCleaning.Text = "Cleaning"
        rbCleaning.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(55, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 20)
        Label2.TabIndex = 25
        Label2.Text = "Procedure Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(408, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 23
        Label3.Text = "Patient Type:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(395, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 20)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(143, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(194, 20)
        Label7.TabIndex = 37
        Label7.Text = "Name of Parent/Guardian:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(70, 82)
        Label10.Name = "Label10"
        Label10.Size = New Size(231, 25)
        Label10.TabIndex = 21
        Label10.Text = "Appointment Time Slot"
        ' 
        ' grpGeneral
        ' 
        grpGeneral.Controls.Add(grpPrimaryConcern)
        grpGeneral.Controls.Add(grpUrgency)
        grpGeneral.Controls.Add(Label5)
        grpGeneral.Controls.Add(Label6)
        grpGeneral.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpGeneral.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpGeneral.Location = New Point(29, 143)
        grpGeneral.Margin = New Padding(3, 2, 3, 2)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Padding = New Padding(3, 2, 3, 2)
        grpGeneral.Size = New Size(624, 173)
        grpGeneral.TabIndex = 41
        grpGeneral.TabStop = False
        grpGeneral.Text = "General"
        ' 
        ' grpPrimaryConcern
        ' 
        grpPrimaryConcern.Controls.Add(rbPhysicalExam)
        grpPrimaryConcern.Controls.Add(rbInjury)
        grpPrimaryConcern.Controls.Add(rbFever)
        grpPrimaryConcern.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        grpPrimaryConcern.Location = New Point(373, 55)
        grpPrimaryConcern.Margin = New Padding(3, 2, 3, 2)
        grpPrimaryConcern.Name = "grpPrimaryConcern"
        grpPrimaryConcern.Padding = New Padding(3, 2, 3, 2)
        grpPrimaryConcern.Size = New Size(189, 101)
        grpPrimaryConcern.TabIndex = 35
        grpPrimaryConcern.TabStop = False
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 12F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(18, 67)
        rbPhysicalExam.Margin = New Padding(3, 2, 3, 2)
        rbPhysicalExam.Name = "rbPhysicalExam"
        rbPhysicalExam.Size = New Size(128, 24)
        rbPhysicalExam.TabIndex = 33
        rbPhysicalExam.TabStop = True
        rbPhysicalExam.Text = "Physical Exam"
        rbPhysicalExam.UseVisualStyleBackColor = True
        ' 
        ' rbInjury
        ' 
        rbInjury.AutoSize = True
        rbInjury.Font = New Font("Microsoft Sans Serif", 12F)
        rbInjury.ForeColor = Color.Black
        rbInjury.Location = New Point(18, 42)
        rbInjury.Margin = New Padding(3, 2, 3, 2)
        rbInjury.Name = "rbInjury"
        rbInjury.Size = New Size(65, 24)
        rbInjury.TabIndex = 32
        rbInjury.TabStop = True
        rbInjury.Text = "Injury"
        rbInjury.UseVisualStyleBackColor = True
        ' 
        ' rbFever
        ' 
        rbFever.AutoSize = True
        rbFever.Font = New Font("Microsoft Sans Serif", 12F)
        rbFever.ForeColor = Color.Black
        rbFever.Location = New Point(18, 17)
        rbFever.Margin = New Padding(3, 2, 3, 2)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(93, 24)
        rbFever.TabIndex = 31
        rbFever.TabStop = True
        rbFever.Text = "Fever/Flu"
        rbFever.UseVisualStyleBackColor = True
        ' 
        ' grpUrgency
        ' 
        grpUrgency.Controls.Add(rbFollowUp)
        grpUrgency.Controls.Add(rbUrgent)
        grpUrgency.Controls.Add(rbRoutine)
        grpUrgency.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        grpUrgency.Location = New Point(58, 54)
        grpUrgency.Margin = New Padding(3, 2, 3, 2)
        grpUrgency.Name = "grpUrgency"
        grpUrgency.Padding = New Padding(3, 2, 3, 2)
        grpUrgency.Size = New Size(189, 101)
        grpUrgency.TabIndex = 34
        grpUrgency.TabStop = False
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 12F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(10, 66)
        rbFollowUp.Margin = New Padding(3, 2, 3, 2)
        rbFollowUp.Name = "rbFollowUp"
        rbFollowUp.Size = New Size(95, 24)
        rbFollowUp.TabIndex = 30
        rbFollowUp.TabStop = True
        rbFollowUp.Text = "Follow-up"
        rbFollowUp.UseVisualStyleBackColor = True
        ' 
        ' rbUrgent
        ' 
        rbUrgent.AutoSize = True
        rbUrgent.Font = New Font("Microsoft Sans Serif", 12F)
        rbUrgent.ForeColor = Color.Black
        rbUrgent.Location = New Point(10, 44)
        rbUrgent.Margin = New Padding(3, 2, 3, 2)
        rbUrgent.Name = "rbUrgent"
        rbUrgent.Size = New Size(76, 24)
        rbUrgent.TabIndex = 29
        rbUrgent.TabStop = True
        rbUrgent.Text = "Urgent"
        rbUrgent.UseVisualStyleBackColor = True
        ' 
        ' rbRoutine
        ' 
        rbRoutine.AutoSize = True
        rbRoutine.Font = New Font("Microsoft Sans Serif", 12F)
        rbRoutine.ForeColor = Color.Black
        rbRoutine.Location = New Point(10, 21)
        rbRoutine.Margin = New Padding(3, 2, 3, 2)
        rbRoutine.Name = "rbRoutine"
        rbRoutine.Size = New Size(83, 24)
        rbRoutine.TabIndex = 28
        rbRoutine.TabStop = True
        rbRoutine.Text = "Routine"
        rbRoutine.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(43, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 20)
        Label5.TabIndex = 25
        Label5.Text = "Urgency Level:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F)
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(355, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 20)
        Label6.TabIndex = 23
        Label6.Text = "Primary Concern:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Teal
        btnSearch.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(594, 45)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(77, 25)
        btnSearch.TabIndex = 42
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearchPrompt.ForeColor = Color.Black
        lblSearchPrompt.Location = New Point(349, 45)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(84, 20)
        lblSearchPrompt.TabIndex = 43
        lblSearchPrompt.Text = "Patient ID:"
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.Teal
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.White
        btnAppointPatient.Location = New Point(206, 335)
        btnAppointPatient.Margin = New Padding(3, 2, 3, 2)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(264, 34)
        btnAppointPatient.TabIndex = 39
        btnAppointPatient.Text = "     Schedule Appointment"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        txtSearchID.Location = New Point(430, 42)
        txtSearchID.Margin = New Padding(3, 2, 3, 2)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(158, 26)
        txtSearchID.TabIndex = 29
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 12F)
        dtpDate.Location = New Point(70, 111)
        dtpDate.Margin = New Padding(3, 2, 3, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(291, 26)
        dtpDate.TabIndex = 20
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Teal
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(714, 11)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(138, 34)
        btnClear.TabIndex = 40
        btnClear.Text = "Clear Fields"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblPatientNameDisplay
        ' 
        lblPatientNameDisplay.AutoSize = True
        lblPatientNameDisplay.Location = New Point(335, 116)
        lblPatientNameDisplay.Name = "lblPatientNameDisplay"
        lblPatientNameDisplay.Size = New Size(0, 15)
        lblPatientNameDisplay.TabIndex = 44
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.Teal
        btnReturnMainPd.BackgroundImageLayout = ImageLayout.Center
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.White
        btnReturnMainPd.Location = New Point(12, 11)
        btnReturnMainPd.Margin = New Padding(3, 2, 3, 2)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(282, 42)
        btnReturnMainPd.TabIndex = 45
        btnReturnMainPd.Text = "     Back To Dashboard"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Teal
        PictureBox2.BackgroundImage = My.Resources.Resources.curved_arrow_left_white_icon1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(29, 22)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 23)
        PictureBox2.TabIndex = 46
        PictureBox2.TabStop = False
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        ClientSize = New Size(864, 504)
        Controls.Add(PictureBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnReturnMainPd)
        Controls.Add(lblPatientNameDisplay)
        Controls.Add(btnClear)
        Margin = New Padding(3, 2, 3, 2)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpPedia.ResumeLayout(False)
        grpPedia.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        grpAgeGroup.ResumeLayout(False)
        grpAgeGroup.PerformLayout()
        grpDental.ResumeLayout(False)
        grpDental.PerformLayout()
        grpPatientType.ResumeLayout(False)
        grpPatientType.PerformLayout()
        grpProcedure.ResumeLayout(False)
        grpProcedure.PerformLayout()
        grpGeneral.ResumeLayout(False)
        grpGeneral.PerformLayout()
        grpPrimaryConcern.ResumeLayout(False)
        grpPrimaryConcern.PerformLayout()
        grpUrgency.ResumeLayout(False)
        grpUrgency.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSickV As RadioButton
    Friend WithEvents rbVaccine As RadioButton
    Friend WithEvents rbGrowth As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents rbInfant As RadioButton
    Friend WithEvents rbSchool As RadioButton
    Friend WithEvents rbToddler As RadioButton
    Friend WithEvents txtParentGName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAppointPatient As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpPedia As GroupBox
    Friend WithEvents grpDental As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpGeneral As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbChild As RadioButton
    Friend WithEvents rbAdult As RadioButton
    Friend WithEvents rbFilling As RadioButton
    Friend WithEvents rbExtraction As RadioButton
    Friend WithEvents rbCleaning As RadioButton
    Friend WithEvents rbPhysicalExam As RadioButton
    Friend WithEvents rbInjury As RadioButton
    Friend WithEvents rbFever As RadioButton
    Friend WithEvents rbFollowUp As RadioButton
    Friend WithEvents rbUrgent As RadioButton
    Friend WithEvents rbRoutine As RadioButton
    Friend WithEvents grpUrgency As GroupBox
    Friend WithEvents grpPrimaryConcern As GroupBox
    Friend WithEvents grpProcedure As GroupBox
    Friend WithEvents grpPatientType As GroupBox
    Friend WithEvents grpAgeGroup As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSearchID As MaskedTextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSearchPrompt As Label
    Friend WithEvents lblPatientNameDisplay As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbTimeSlots As ComboBox
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label1 As Label
End Class
