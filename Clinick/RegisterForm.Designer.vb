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
        cmbTimeSlots = New ComboBox()
        Label8 = New Label()
        Label10 = New Label()
        dtpDate = New DateTimePicker()
        btnClear = New Button()
        btnAppointPatient = New Button()
        txtParentGName = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        rbInfant = New RadioButton()
        rbSchool = New RadioButton()
        rbToddler = New RadioButton()
        rbSickV = New RadioButton()
        rbVaccine = New RadioButton()
        rbGrowth = New RadioButton()
        Label9 = New Label()
        Label1 = New Label()
        btnReturnMainPd = New Button()
        Panel1 = New Panel()
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
        grpPedia = New GroupBox()
        GroupBox3 = New GroupBox()
        grpAgeGroup = New GroupBox()
        txtSearchID = New MaskedTextBox()
        btnSearch = New Button()
        lblSearchPrompt = New Label()
        lblPatientNameDisplay = New Label()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        grpGeneral.SuspendLayout()
        grpPrimaryConcern.SuspendLayout()
        grpUrgency.SuspendLayout()
        grpDental.SuspendLayout()
        grpPatientType.SuspendLayout()
        grpProcedure.SuspendLayout()
        grpPedia.SuspendLayout()
        GroupBox3.SuspendLayout()
        grpAgeGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbTimeSlots)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(14, 181)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(961, 120)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment Schedule"
        ' 
        ' cmbTimeSlots
        ' 
        cmbTimeSlots.FormattingEnabled = True
        cmbTimeSlots.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"})
        cmbTimeSlots.Location = New Point(534, 70)
        cmbTimeSlots.Name = "cmbTimeSlots"
        cmbTimeSlots.Size = New Size(399, 37)
        cmbTimeSlots.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(528, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 25)
        Label8.TabIndex = 35
        Label8.Text = "Time: "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(38, 44)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 25)
        Label10.TabIndex = 21
        Label10.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 12.0F)
        dtpDate.Location = New Point(37, 72)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(332, 30)
        dtpDate.TabIndex = 20
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClear.Location = New Point(10, 636)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 36)
        btnClear.TabIndex = 40
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAppointPatient.Location = New Point(780, 625)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(195, 54)
        btnAppointPatient.TabIndex = 39
        btnAppointPatient.Text = "Appoint Patient"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(524, 82)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(413, 30)
        txtParentGName.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(546, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(239, 25)
        Label7.TabIndex = 37
        Label7.Text = "Name of Parent/Guardian:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(38, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 25
        Label4.Text = "Age Group:"
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(22, 35)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(209, 29)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' rbSchool
        ' 
        rbSchool.AutoSize = True
        rbSchool.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(22, 95)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(187, 29)
        rbSchool.TabIndex = 28
        rbSchool.TabStop = True
        rbSchool.Text = "School Age (4y+)"
        rbSchool.UseVisualStyleBackColor = True
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(22, 65)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(158, 29)
        rbToddler.TabIndex = 27
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
        ' 
        ' rbSickV
        ' 
        rbSickV.AutoSize = True
        rbSickV.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbSickV.ForeColor = Color.Black
        rbSickV.Location = New Point(25, 91)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(113, 29)
        rbSickV.TabIndex = 31
        rbSickV.TabStop = True
        rbSickV.Text = "Sick Visit"
        rbSickV.UseVisualStyleBackColor = True
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbVaccine.ForeColor = Color.Black
        rbVaccine.Location = New Point(25, 56)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(135, 29)
        rbVaccine.TabIndex = 30
        rbVaccine.TabStop = True
        rbVaccine.Text = "Vaccination"
        rbVaccine.UseVisualStyleBackColor = True
        ' 
        ' rbGrowth
        ' 
        rbGrowth.AutoSize = True
        rbGrowth.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbGrowth.ForeColor = Color.Black
        rbGrowth.Location = New Point(25, 21)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(157, 29)
        rbGrowth.TabIndex = 29
        rbGrowth.TabStop = True
        rbGrowth.Text = "Growth Check"
        rbGrowth.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(296, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 25)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(358, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 42)
        Label1.TabIndex = 19
        Label1.Text = "Appoint Patient"
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(14, 12)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(108, 36)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "Return"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnReturnMainPd)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 135)
        Panel1.TabIndex = 36
        ' 
        ' grpGeneral
        ' 
        grpGeneral.Controls.Add(grpPrimaryConcern)
        grpGeneral.Controls.Add(grpUrgency)
        grpGeneral.Controls.Add(Label5)
        grpGeneral.Controls.Add(Label6)
        grpGeneral.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpGeneral.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpGeneral.Location = New Point(14, 316)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Size = New Size(961, 222)
        grpGeneral.TabIndex = 41
        grpGeneral.TabStop = False
        grpGeneral.Text = "General"
        ' 
        ' grpPrimaryConcern
        ' 
        grpPrimaryConcern.Controls.Add(rbPhysicalExam)
        grpPrimaryConcern.Controls.Add(rbInjury)
        grpPrimaryConcern.Controls.Add(rbFever)
        grpPrimaryConcern.Location = New Point(507, 67)
        grpPrimaryConcern.Name = "grpPrimaryConcern"
        grpPrimaryConcern.Size = New Size(216, 135)
        grpPrimaryConcern.TabIndex = 35
        grpPrimaryConcern.TabStop = False
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(21, 89)
        rbPhysicalExam.Name = "rbPhysicalExam"
        rbPhysicalExam.Size = New Size(161, 29)
        rbPhysicalExam.TabIndex = 33
        rbPhysicalExam.TabStop = True
        rbPhysicalExam.Text = "Physical Exam"
        rbPhysicalExam.UseVisualStyleBackColor = True
        ' 
        ' rbInjury
        ' 
        rbInjury.AutoSize = True
        rbInjury.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbInjury.ForeColor = Color.Black
        rbInjury.Location = New Point(21, 56)
        rbInjury.Name = "rbInjury"
        rbInjury.Size = New Size(80, 29)
        rbInjury.TabIndex = 32
        rbInjury.TabStop = True
        rbInjury.Text = "Injury"
        rbInjury.UseVisualStyleBackColor = True
        ' 
        ' rbFever
        ' 
        rbFever.AutoSize = True
        rbFever.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbFever.ForeColor = Color.Black
        rbFever.Location = New Point(21, 23)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(116, 29)
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
        grpUrgency.Location = New Point(37, 67)
        grpUrgency.Name = "grpUrgency"
        grpUrgency.Size = New Size(216, 135)
        grpUrgency.TabIndex = 34
        grpUrgency.TabStop = False
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(12, 88)
        rbFollowUp.Name = "rbFollowUp"
        rbFollowUp.Size = New Size(118, 29)
        rbFollowUp.TabIndex = 30
        rbFollowUp.TabStop = True
        rbFollowUp.Text = "Follow-up"
        rbFollowUp.UseVisualStyleBackColor = True
        ' 
        ' rbUrgent
        ' 
        rbUrgent.AutoSize = True
        rbUrgent.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbUrgent.ForeColor = Color.Black
        rbUrgent.Location = New Point(12, 58)
        rbUrgent.Name = "rbUrgent"
        rbUrgent.Size = New Size(91, 29)
        rbUrgent.TabIndex = 29
        rbUrgent.TabStop = True
        rbUrgent.Text = "Urgent"
        rbUrgent.UseVisualStyleBackColor = True
        ' 
        ' rbRoutine
        ' 
        rbRoutine.AutoSize = True
        rbRoutine.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbRoutine.ForeColor = Color.Black
        rbRoutine.Location = New Point(12, 28)
        rbRoutine.Name = "rbRoutine"
        rbRoutine.Size = New Size(99, 29)
        rbRoutine.TabIndex = 28
        rbRoutine.TabStop = True
        rbRoutine.Text = "Routine"
        rbRoutine.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(38, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 25)
        Label5.TabIndex = 25
        Label5.Text = "Urgency Level:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(513, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 25)
        Label6.TabIndex = 23
        Label6.Text = "Primary Concern:"
        ' 
        ' grpDental
        ' 
        grpDental.Controls.Add(grpPatientType)
        grpDental.Controls.Add(grpProcedure)
        grpDental.Controls.Add(Label2)
        grpDental.Controls.Add(Label3)
        grpDental.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpDental.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpDental.Location = New Point(14, 316)
        grpDental.Name = "grpDental"
        grpDental.Size = New Size(961, 203)
        grpDental.TabIndex = 40
        grpDental.TabStop = False
        grpDental.Text = "Dental"
        ' 
        ' grpPatientType
        ' 
        grpPatientType.Controls.Add(rbChild)
        grpPatientType.Controls.Add(rbAdult)
        grpPatientType.Location = New Point(492, 58)
        grpPatientType.Name = "grpPatientType"
        grpPatientType.Size = New Size(216, 89)
        grpPatientType.TabIndex = 33
        grpPatientType.TabStop = False
        ' 
        ' rbChild
        ' 
        rbChild.AutoSize = True
        rbChild.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(32, 52)
        rbChild.Name = "rbChild"
        rbChild.Size = New Size(78, 29)
        rbChild.TabIndex = 31
        rbChild.TabStop = True
        rbChild.Text = "Child"
        rbChild.UseVisualStyleBackColor = True
        ' 
        ' rbAdult
        ' 
        rbAdult.AutoSize = True
        rbAdult.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbAdult.ForeColor = Color.Black
        rbAdult.Location = New Point(32, 20)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(78, 29)
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
        grpProcedure.Location = New Point(34, 55)
        grpProcedure.Name = "grpProcedure"
        grpProcedure.Size = New Size(216, 135)
        grpProcedure.TabIndex = 32
        grpProcedure.TabStop = False
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(25, 88)
        rbFilling.Name = "rbFilling"
        rbFilling.Size = New Size(83, 29)
        rbFilling.TabIndex = 29
        rbFilling.TabStop = True
        rbFilling.Text = "Filling"
        rbFilling.UseVisualStyleBackColor = True
        ' 
        ' rbExtraction
        ' 
        rbExtraction.AutoSize = True
        rbExtraction.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbExtraction.ForeColor = Color.Black
        rbExtraction.Location = New Point(25, 53)
        rbExtraction.Name = "rbExtraction"
        rbExtraction.Size = New Size(119, 29)
        rbExtraction.TabIndex = 28
        rbExtraction.TabStop = True
        rbExtraction.Text = "Extraction"
        rbExtraction.UseVisualStyleBackColor = True
        ' 
        ' rbCleaning
        ' 
        rbCleaning.AutoSize = True
        rbCleaning.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbCleaning.ForeColor = Color.Black
        rbCleaning.Location = New Point(25, 18)
        rbCleaning.Name = "rbCleaning"
        rbCleaning.Size = New Size(111, 29)
        rbCleaning.TabIndex = 27
        rbCleaning.TabStop = True
        rbCleaning.Text = "Cleaning"
        rbCleaning.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(38, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 25)
        Label2.TabIndex = 25
        Label2.Text = "Procedure Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(503, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 23
        Label3.Text = "Patient Type:"
        ' 
        ' grpPedia
        ' 
        grpPedia.Controls.Add(GroupBox3)
        grpPedia.Controls.Add(grpAgeGroup)
        grpPedia.Controls.Add(txtParentGName)
        grpPedia.Controls.Add(Label4)
        grpPedia.Controls.Add(Label9)
        grpPedia.Controls.Add(Label7)
        grpPedia.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPedia.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpPedia.Location = New Point(10, 328)
        grpPedia.Name = "grpPedia"
        grpPedia.Size = New Size(961, 291)
        grpPedia.TabIndex = 24
        grpPedia.TabStop = False
        grpPedia.Text = "Pedia"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbVaccine)
        GroupBox3.Controls.Add(rbSickV)
        GroupBox3.Controls.Add(rbGrowth)
        GroupBox3.Location = New Point(295, 62)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(216, 135)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        ' 
        ' grpAgeGroup
        ' 
        grpAgeGroup.Controls.Add(rbToddler)
        grpAgeGroup.Controls.Add(rbSchool)
        grpAgeGroup.Controls.Add(rbInfant)
        grpAgeGroup.Location = New Point(9, 63)
        grpAgeGroup.Name = "grpAgeGroup"
        grpAgeGroup.Size = New Size(234, 136)
        grpAgeGroup.TabIndex = 39
        grpAgeGroup.TabStop = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Location = New Point(744, 148)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(156, 27)
        txtSearchID.TabIndex = 29
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(913, 148)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(69, 28)
        btnSearch.TabIndex = 42
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Location = New Point(623, 152)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(114, 20)
        lblSearchPrompt.TabIndex = 43
        lblSearchPrompt.Text = "Enter Patient ID:"
        ' 
        ' lblPatientNameDisplay
        ' 
        lblPatientNameDisplay.AutoSize = True
        lblPatientNameDisplay.Location = New Point(383, 155)
        lblPatientNameDisplay.Name = "lblPatientNameDisplay"
        lblPatientNameDisplay.Size = New Size(0, 20)
        lblPatientNameDisplay.TabIndex = 44
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 721)
        Controls.Add(lblPatientNameDisplay)
        Controls.Add(lblSearchPrompt)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchID)
        Controls.Add(grpGeneral)
        Controls.Add(grpDental)
        Controls.Add(btnClear)
        Controls.Add(grpPedia)
        Controls.Add(Panel1)
        Controls.Add(btnAppointPatient)
        Controls.Add(GroupBox1)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpGeneral.ResumeLayout(False)
        grpGeneral.PerformLayout()
        grpPrimaryConcern.ResumeLayout(False)
        grpPrimaryConcern.PerformLayout()
        grpUrgency.ResumeLayout(False)
        grpUrgency.PerformLayout()
        grpDental.ResumeLayout(False)
        grpDental.PerformLayout()
        grpPatientType.ResumeLayout(False)
        grpPatientType.PerformLayout()
        grpProcedure.ResumeLayout(False)
        grpProcedure.PerformLayout()
        grpPedia.ResumeLayout(False)
        grpPedia.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        grpAgeGroup.ResumeLayout(False)
        grpAgeGroup.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents Panel1 As Panel
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
End Class
