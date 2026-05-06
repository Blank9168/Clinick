<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatientFrm
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
        Panel1 = New Panel()
        lblSearchPrompt = New Label()
        Label1 = New Label()
        btnSearch = New Button()
        btnReturnMainPd = New Button()
        txtSearchID = New MaskedTextBox()
        btnSaveEdit = New Button()
        btnDelete = New Button()
        btnCancel = New Button()
        GroupBox1 = New GroupBox()
        cmbTimeSlots = New ComboBox()
        Label8 = New Label()
        Label10 = New Label()
        dtpDate = New DateTimePicker()
        grpGeneral = New GroupBox()
        grpPrimaryConcern = New GroupBox()
        rbPhysicalExam = New RadioButton()
        rbInjury = New RadioButton()
        rbFever = New RadioButton()
        grpUrgency = New GroupBox()
        rbFollowUp = New RadioButton()
        rbUrgent = New RadioButton()
        rbRoutine = New RadioButton()
        Label6 = New Label()
        Label7 = New Label()
        grpDental = New GroupBox()
        grpPatientType = New GroupBox()
        rbChild = New RadioButton()
        rbAdult = New RadioButton()
        grpProcedure = New GroupBox()
        rbFilling = New RadioButton()
        rbExtraction = New RadioButton()
        rbCleaning = New RadioButton()
        Label9 = New Label()
        Label11 = New Label()
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
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label3 = New Label()
        PictureBox5 = New PictureBox()
        Label4 = New Label()
        btnClear = New Button()
        PictureBox4 = New PictureBox()
        btnAddPatient = New Button()
        txtContactInfo = New TextBox()
        Label5 = New Label()
        txtPatientName = New TextBox()
        lblPatientID = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        Label18 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        grpGeneral.SuspendLayout()
        grpPrimaryConcern.SuspendLayout()
        grpUrgency.SuspendLayout()
        grpDental.SuspendLayout()
        grpPatientType.SuspendLayout()
        grpProcedure.SuspendLayout()
        grpPedia.SuspendLayout()
        GroupBox3.SuspendLayout()
        grpAgeGroup.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(lblSearchPrompt)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(btnReturnMainPd)
        Panel1.Controls.Add(txtSearchID)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1258, 170)
        Panel1.TabIndex = 28
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearchPrompt.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblSearchPrompt.Location = New Point(699, 78)
        lblSearchPrompt.Margin = New Padding(4, 0, 4, 0)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(185, 29)
        lblSearchPrompt.TabIndex = 46
        lblSearchPrompt.Text = "Enter Patient ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(235, 60)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 52)
        Label1.TabIndex = 19
        Label1.Text = "Edit Patient"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnSearch.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnSearch.Location = New Point(1120, 72)
        btnSearch.Margin = New Padding(4, 4, 4, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(110, 41)
        btnSearch.TabIndex = 45
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(18, 15)
        btnReturnMainPd.Margin = New Padding(4, 4, 4, 4)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(134, 45)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "Return"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        txtSearchID.Location = New Point(888, 75)
        txtSearchID.Margin = New Padding(4, 4, 4, 4)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(224, 35)
        txtSearchID.TabIndex = 44
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(45, 759)
        btnSaveEdit.Margin = New Padding(4, 5, 4, 5)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(212, 92)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(471, 774)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(210, 78)
        btnDelete.TabIndex = 34
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(1020, 759)
        btnCancel.Margin = New Padding(4, 5, 4, 5)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(164, 105)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbTimeSlots)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(632, 225)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(538, 118)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment Schedule"
        ' 
        ' cmbTimeSlots
        ' 
        cmbTimeSlots.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbTimeSlots.FormattingEnabled = True
        cmbTimeSlots.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"})
        cmbTimeSlots.Location = New Point(330, 62)
        cmbTimeSlots.Margin = New Padding(4, 4, 4, 4)
        cmbTimeSlots.Name = "cmbTimeSlots"
        cmbTimeSlots.Size = New Size(150, 28)
        cmbTimeSlots.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(326, 36)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 35
        Label8.Text = "Time: "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(8, 36)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 20)
        Label10.TabIndex = 21
        Label10.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(8, 60)
        dtpDate.Margin = New Padding(4, 4, 4, 4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(293, 25)
        dtpDate.TabIndex = 20
        ' 
        ' grpGeneral
        ' 
        grpGeneral.Controls.Add(grpPrimaryConcern)
        grpGeneral.Controls.Add(grpUrgency)
        grpGeneral.Controls.Add(Label6)
        grpGeneral.Controls.Add(Label7)
        grpGeneral.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpGeneral.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpGeneral.Location = New Point(640, 354)
        grpGeneral.Margin = New Padding(4, 4, 4, 4)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Padding = New Padding(4, 4, 4, 4)
        grpGeneral.Size = New Size(530, 276)
        grpGeneral.TabIndex = 42
        grpGeneral.TabStop = False
        grpGeneral.Text = "General"
        ' 
        ' grpPrimaryConcern
        ' 
        grpPrimaryConcern.Controls.Add(rbPhysicalExam)
        grpPrimaryConcern.Controls.Add(rbInjury)
        grpPrimaryConcern.Controls.Add(rbFever)
        grpPrimaryConcern.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold)
        grpPrimaryConcern.Location = New Point(221, 81)
        grpPrimaryConcern.Margin = New Padding(4, 4, 4, 4)
        grpPrimaryConcern.Name = "grpPrimaryConcern"
        grpPrimaryConcern.Padding = New Padding(4, 4, 4, 4)
        grpPrimaryConcern.Size = New Size(189, 169)
        grpPrimaryConcern.TabIndex = 35
        grpPrimaryConcern.TabStop = False
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(26, 111)
        rbPhysicalExam.Margin = New Padding(4, 4, 4, 4)
        rbPhysicalExam.Name = "rbPhysicalExam"
        rbPhysicalExam.Size = New Size(135, 24)
        rbPhysicalExam.TabIndex = 33
        rbPhysicalExam.TabStop = True
        rbPhysicalExam.Text = "Physical Exam"
        rbPhysicalExam.UseVisualStyleBackColor = True
        ' 
        ' rbInjury
        ' 
        rbInjury.AutoSize = True
        rbInjury.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbInjury.ForeColor = Color.Black
        rbInjury.Location = New Point(26, 70)
        rbInjury.Margin = New Padding(4, 4, 4, 4)
        rbInjury.Name = "rbInjury"
        rbInjury.Size = New Size(72, 24)
        rbInjury.TabIndex = 32
        rbInjury.TabStop = True
        rbInjury.Text = "Injury"
        rbInjury.UseVisualStyleBackColor = True
        ' 
        ' rbFever
        ' 
        rbFever.AutoSize = True
        rbFever.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFever.ForeColor = Color.Black
        rbFever.Location = New Point(26, 29)
        rbFever.Margin = New Padding(4, 4, 4, 4)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(100, 24)
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
        grpUrgency.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold)
        grpUrgency.Location = New Point(50, 85)
        grpUrgency.Margin = New Padding(4, 4, 4, 4)
        grpUrgency.Name = "grpUrgency"
        grpUrgency.Padding = New Padding(4, 4, 4, 4)
        grpUrgency.Size = New Size(135, 169)
        grpUrgency.TabIndex = 34
        grpUrgency.TabStop = False
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(14, 110)
        rbFollowUp.Margin = New Padding(4, 4, 4, 4)
        rbFollowUp.Name = "rbFollowUp"
        rbFollowUp.Size = New Size(102, 24)
        rbFollowUp.TabIndex = 30
        rbFollowUp.TabStop = True
        rbFollowUp.Text = "Follow-up"
        rbFollowUp.UseVisualStyleBackColor = True
        ' 
        ' rbUrgent
        ' 
        rbUrgent.AutoSize = True
        rbUrgent.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbUrgent.ForeColor = Color.Black
        rbUrgent.Location = New Point(14, 74)
        rbUrgent.Margin = New Padding(4, 4, 4, 4)
        rbUrgent.Name = "rbUrgent"
        rbUrgent.Size = New Size(83, 24)
        rbUrgent.TabIndex = 29
        rbUrgent.TabStop = True
        rbUrgent.Text = "Urgent"
        rbUrgent.UseVisualStyleBackColor = True
        ' 
        ' rbRoutine
        ' 
        rbRoutine.AutoSize = True
        rbRoutine.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbRoutine.ForeColor = Color.Black
        rbRoutine.Location = New Point(14, 35)
        rbRoutine.Margin = New Padding(4, 4, 4, 4)
        rbRoutine.Name = "rbRoutine"
        rbRoutine.Size = New Size(90, 24)
        rbRoutine.TabIndex = 28
        rbRoutine.TabStop = True
        rbRoutine.Text = "Routine"
        rbRoutine.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(48, 50)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 25
        Label6.Text = "Urgency Level:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(221, 50)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 20)
        Label7.TabIndex = 23
        Label7.Text = "Primary Concern:"
        ' 
        ' grpDental
        ' 
        grpDental.Controls.Add(grpPatientType)
        grpDental.Controls.Add(grpProcedure)
        grpDental.Controls.Add(Label9)
        grpDental.Controls.Add(Label11)
        grpDental.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpDental.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpDental.Location = New Point(632, 354)
        grpDental.Margin = New Padding(4, 4, 4, 4)
        grpDental.Name = "grpDental"
        grpDental.Padding = New Padding(4, 4, 4, 4)
        grpDental.Size = New Size(579, 254)
        grpDental.TabIndex = 41
        grpDental.TabStop = False
        grpDental.Text = "Dental"
        ' 
        ' grpPatientType
        ' 
        grpPatientType.Controls.Add(rbChild)
        grpPatientType.Controls.Add(rbAdult)
        grpPatientType.Location = New Point(255, 69)
        grpPatientType.Margin = New Padding(4, 4, 4, 4)
        grpPatientType.Name = "grpPatientType"
        grpPatientType.Padding = New Padding(4, 4, 4, 4)
        grpPatientType.Size = New Size(270, 111)
        grpPatientType.TabIndex = 33
        grpPatientType.TabStop = False
        ' 
        ' rbChild
        ' 
        rbChild.AutoSize = True
        rbChild.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(40, 65)
        rbChild.Margin = New Padding(4, 4, 4, 4)
        rbChild.Name = "rbChild"
        rbChild.Size = New Size(69, 24)
        rbChild.TabIndex = 31
        rbChild.TabStop = True
        rbChild.Text = "Child"
        rbChild.UseVisualStyleBackColor = True
        ' 
        ' rbAdult
        ' 
        rbAdult.AutoSize = True
        rbAdult.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbAdult.ForeColor = Color.Black
        rbAdult.Location = New Point(40, 25)
        rbAdult.Margin = New Padding(4, 4, 4, 4)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(71, 24)
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
        grpProcedure.Location = New Point(42, 69)
        grpProcedure.Margin = New Padding(4, 4, 4, 4)
        grpProcedure.Name = "grpProcedure"
        grpProcedure.Padding = New Padding(4, 4, 4, 4)
        grpProcedure.Size = New Size(175, 169)
        grpProcedure.TabIndex = 32
        grpProcedure.TabStop = False
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(31, 110)
        rbFilling.Margin = New Padding(4, 4, 4, 4)
        rbFilling.Name = "rbFilling"
        rbFilling.Size = New Size(74, 24)
        rbFilling.TabIndex = 29
        rbFilling.TabStop = True
        rbFilling.Text = "Filling"
        rbFilling.UseVisualStyleBackColor = True
        ' 
        ' rbExtraction
        ' 
        rbExtraction.AutoSize = True
        rbExtraction.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbExtraction.ForeColor = Color.Black
        rbExtraction.Location = New Point(31, 66)
        rbExtraction.Margin = New Padding(4, 4, 4, 4)
        rbExtraction.Name = "rbExtraction"
        rbExtraction.Size = New Size(105, 24)
        rbExtraction.TabIndex = 28
        rbExtraction.TabStop = True
        rbExtraction.Text = "Extraction"
        rbExtraction.UseVisualStyleBackColor = True
        ' 
        ' rbCleaning
        ' 
        rbCleaning.AutoSize = True
        rbCleaning.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbCleaning.ForeColor = Color.Black
        rbCleaning.Location = New Point(31, 24)
        rbCleaning.Margin = New Padding(4, 4, 4, 4)
        rbCleaning.Name = "rbCleaning"
        rbCleaning.Size = New Size(96, 24)
        rbCleaning.TabIndex = 27
        rbCleaning.TabStop = True
        rbCleaning.Text = "Cleaning"
        rbCleaning.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(48, 44)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 20)
        Label9.TabIndex = 25
        Label9.Text = "Procedure Type:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(255, 44)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 20)
        Label11.TabIndex = 23
        Label11.Text = "Patient Type:"
        ' 
        ' grpPedia
        ' 
        grpPedia.Controls.Add(GroupBox3)
        grpPedia.Controls.Add(grpAgeGroup)
        grpPedia.Controls.Add(txtParentGName)
        grpPedia.Controls.Add(Label12)
        grpPedia.Controls.Add(Label13)
        grpPedia.Controls.Add(Label14)
        grpPedia.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPedia.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpPedia.Location = New Point(640, 349)
        grpPedia.Margin = New Padding(4, 4, 4, 4)
        grpPedia.Name = "grpPedia"
        grpPedia.Padding = New Padding(4, 4, 4, 4)
        grpPedia.Size = New Size(568, 364)
        grpPedia.TabIndex = 34
        grpPedia.TabStop = False
        grpPedia.Text = "Pedia"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbVaccine)
        GroupBox3.Controls.Add(rbSickV)
        GroupBox3.Controls.Add(rbGrowth)
        GroupBox3.Location = New Point(315, 80)
        GroupBox3.Margin = New Padding(4, 4, 4, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 4, 4, 4)
        GroupBox3.Size = New Size(200, 169)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbVaccine.ForeColor = Color.Black
        rbVaccine.Location = New Point(31, 70)
        rbVaccine.Margin = New Padding(4, 4, 4, 4)
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
        rbSickV.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbSickV.ForeColor = Color.Black
        rbSickV.Location = New Point(31, 114)
        rbSickV.Margin = New Padding(4, 4, 4, 4)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(98, 24)
        rbSickV.TabIndex = 31
        rbSickV.TabStop = True
        rbSickV.Text = "Sick Visit"
        rbSickV.UseVisualStyleBackColor = True
        ' 
        ' rbGrowth
        ' 
        rbGrowth.AutoSize = True
        rbGrowth.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbGrowth.ForeColor = Color.Black
        rbGrowth.Location = New Point(31, 26)
        rbGrowth.Margin = New Padding(4, 4, 4, 4)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(135, 24)
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
        grpAgeGroup.Location = New Point(11, 79)
        grpAgeGroup.Margin = New Padding(4, 4, 4, 4)
        grpAgeGroup.Name = "grpAgeGroup"
        grpAgeGroup.Padding = New Padding(4, 4, 4, 4)
        grpAgeGroup.Size = New Size(242, 170)
        grpAgeGroup.TabIndex = 39
        grpAgeGroup.TabStop = False
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(28, 81)
        rbToddler.Margin = New Padding(4, 4, 4, 4)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(131, 24)
        rbToddler.TabIndex = 27
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
        ' 
        ' rbSchool
        ' 
        rbSchool.AutoSize = True
        rbSchool.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(28, 119)
        rbSchool.Margin = New Padding(4, 4, 4, 4)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(155, 24)
        rbSchool.TabIndex = 28
        rbSchool.TabStop = True
        rbSchool.Text = "School Age (4y+)"
        rbSchool.UseVisualStyleBackColor = True
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(28, 44)
        rbInfant.Margin = New Padding(4, 4, 4, 4)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(179, 24)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(6, 281)
        txtParentGName.Margin = New Padding(4, 4, 4, 4)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(515, 35)
        txtParentGName.TabIndex = 38
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(48, 46)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 20)
        Label12.TabIndex = 25
        Label12.Text = "Age Group:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(299, 46)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(81, 20)
        Label13.TabIndex = 23
        Label13.Text = "Visit Type:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label14.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label14.Location = New Point(12, 254)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(194, 20)
        Label14.TabIndex = 37
        Label14.Text = "Name of Parent/Guardian:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(PictureBox5)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(btnClear)
        GroupBox2.Controls.Add(PictureBox4)
        GroupBox2.Controls.Add(btnAddPatient)
        GroupBox2.Controls.Add(txtContactInfo)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtPatientName)
        GroupBox2.Controls.Add(lblPatientID)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(rbMale)
        GroupBox2.Controls.Add(rbFemale)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox2.Location = New Point(45, 287)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(542, 430)
        GroupBox2.TabIndex = 43
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(182, 176)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 47
        Label2.Text = "Date of Birth:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(182, 200)
        DateTimePicker1.Margin = New Padding(4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(332, 26)
        DateTimePicker1.TabIndex = 46
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(20, 200)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(120, 26)
        TextBox1.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8F)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(20, 176)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 44
        Label3.Text = " Patient age:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_29__2026__02_47_47_PM
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(20, 12)
        PictureBox5.Margin = New Padding(4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 38)
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(69, 19)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 25)
        Label4.TabIndex = 43
        Label4.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClear.Location = New Point(276, 262)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(229, 37)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(538, 41)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.Teal
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(8, 335)
        btnAddPatient.Margin = New Padding(4)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(518, 79)
        btnAddPatient.TabIndex = 30
        btnAddPatient.Text = "ADD PATIENT AND CREATE RECORD"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(182, 142)
        txtContactInfo.Margin = New Padding(4)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(323, 26)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(20, 145)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 20)
        Label5.TabIndex = 19
        Label5.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(182, 111)
        txtPatientName.Margin = New Padding(4)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(323, 26)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(132, 70)
        lblPatientID.Margin = New Padding(4, 0, 4, 0)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(103, 22)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "GEN-1001"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 8F)
        Label15.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label15.Location = New Point(20, 111)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(138, 20)
        Label15.TabIndex = 6
        Label15.Text = "Patient Full Name:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label16.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label16.Location = New Point(20, 70)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(104, 22)
        Label16.TabIndex = 4
        Label16.Text = "Patient ID:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label17.Location = New Point(20, 245)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(94, 20)
        Label17.TabIndex = 11
        Label17.Text = "Patient Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 8F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(20, 277)
        rbMale.Margin = New Padding(4)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(68, 24)
        rbMale.TabIndex = 12
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Font = New Font("Microsoft Sans Serif", 8F)
        rbFemale.ForeColor = Color.Black
        rbFemale.Location = New Point(96, 277)
        rbFemale.Margin = New Padding(4)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(87, 24)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.PowderBlue
        Label18.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.DarkSlateGray
        Label18.Location = New Point(114, 244)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(405, 37)
        Label18.TabIndex = 44
        Label18.Text = "PATIENT INFORMATION"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.PowderBlue
        PictureBox3.Location = New Point(45, 225)
        PictureBox3.Margin = New Padding(4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(542, 66)
        PictureBox3.TabIndex = 45
        PictureBox3.TabStop = False
        ' 
        ' EditPatientFrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 901)
        Controls.Add(Label18)
        Controls.Add(GroupBox2)
        Controls.Add(grpPedia)
        Controls.Add(grpDental)
        Controls.Add(grpGeneral)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(btnSaveEdit)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "EditPatientFrm"
        Text = "EditPatientFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSearchPrompt As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchID As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbTimeSlots As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents grpGeneral As GroupBox
    Friend WithEvents grpPrimaryConcern As GroupBox
    Friend WithEvents rbPhysicalExam As RadioButton
    Friend WithEvents rbInjury As RadioButton
    Friend WithEvents rbFever As RadioButton
    Friend WithEvents grpUrgency As GroupBox
    Friend WithEvents rbFollowUp As RadioButton
    Friend WithEvents rbUrgent As RadioButton
    Friend WithEvents rbRoutine As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grpDental As GroupBox
    Friend WithEvents grpPatientType As GroupBox
    Friend WithEvents rbChild As RadioButton
    Friend WithEvents rbAdult As RadioButton
    Friend WithEvents grpProcedure As GroupBox
    Friend WithEvents rbFilling As RadioButton
    Friend WithEvents rbExtraction As RadioButton
    Friend WithEvents rbCleaning As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grpPedia As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbVaccine As RadioButton
    Friend WithEvents rbSickV As RadioButton
    Friend WithEvents rbGrowth As RadioButton
    Friend WithEvents grpAgeGroup As GroupBox
    Friend WithEvents rbToddler As RadioButton
    Friend WithEvents rbSchool As RadioButton
    Friend WithEvents rbInfant As RadioButton
    Friend WithEvents txtParentGName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class
