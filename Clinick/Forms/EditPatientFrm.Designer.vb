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
        GroupBox2 = New GroupBox()
        btnClear = New Button()
        txtContactInfo = New TextBox()
        Label4 = New Label()
        txtPatientName = New TextBox()
        lblPatientID = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
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
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 136)
        Panel1.TabIndex = 28
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearchPrompt.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblSearchPrompt.Location = New Point(559, 62)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(153, 25)
        lblSearchPrompt.TabIndex = 46
        lblSearchPrompt.Text = "Enter Patient ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(188, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 42)
        Label1.TabIndex = 19
        Label1.Text = "Edit Patient"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnSearch.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnSearch.Location = New Point(896, 58)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(88, 33)
        btnSearch.TabIndex = 45
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(14, 12)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(107, 36)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "Return"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        txtSearchID.Location = New Point(710, 60)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(180, 30)
        txtSearchID.TabIndex = 44
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(36, 607)
        btnSaveEdit.Margin = New Padding(3, 4, 3, 4)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(170, 74)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(377, 619)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(168, 62)
        btnDelete.TabIndex = 34
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(816, 607)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(131, 84)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnClear)
        GroupBox2.Controls.Add(txtContactInfo)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtPatientName)
        GroupBox2.Controls.Add(lblPatientID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(rbMale)
        GroupBox2.Controls.Add(rbFemale)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox2.Location = New Point(14, 176)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(469, 307)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClear.Location = New Point(370, 23)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(97, 29)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(139, 155)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(152, 30)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(10, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 16)
        Label4.TabIndex = 19
        Label4.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(131, 103)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(160, 30)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 7.8F)
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(83, 45)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(18, 16)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(10, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 16)
        Label2.TabIndex = 6
        Label2.Text = "Patient Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(10, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 16)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(10, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 16)
        Label5.TabIndex = 11
        Label5.Text = "Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(10, 227)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(58, 20)
        rbMale.TabIndex = 12
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFemale.ForeColor = Color.Black
        rbFemale.Location = New Point(83, 227)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(74, 20)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbTimeSlots)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(506, 180)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(430, 94)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment Schedule"
        ' 
        ' cmbTimeSlots
        ' 
        cmbTimeSlots.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbTimeSlots.FormattingEnabled = True
        cmbTimeSlots.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"})
        cmbTimeSlots.Location = New Point(264, 50)
        cmbTimeSlots.Name = "cmbTimeSlots"
        cmbTimeSlots.Size = New Size(121, 24)
        cmbTimeSlots.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(261, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 16)
        Label8.TabIndex = 35
        Label8.Text = "Time: "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(6, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 16)
        Label10.TabIndex = 21
        Label10.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(6, 48)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(235, 22)
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
        grpGeneral.Location = New Point(512, 283)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Size = New Size(424, 221)
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
        grpPrimaryConcern.Location = New Point(177, 65)
        grpPrimaryConcern.Name = "grpPrimaryConcern"
        grpPrimaryConcern.Size = New Size(151, 135)
        grpPrimaryConcern.TabIndex = 35
        grpPrimaryConcern.TabStop = False
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(21, 89)
        rbPhysicalExam.Name = "rbPhysicalExam"
        rbPhysicalExam.Size = New Size(116, 20)
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
        rbInjury.Location = New Point(21, 56)
        rbInjury.Name = "rbInjury"
        rbInjury.Size = New Size(59, 20)
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
        rbFever.Location = New Point(21, 23)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(85, 20)
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
        grpUrgency.Location = New Point(40, 68)
        grpUrgency.Name = "grpUrgency"
        grpUrgency.Size = New Size(108, 135)
        grpUrgency.TabIndex = 34
        grpUrgency.TabStop = False
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(11, 88)
        rbFollowUp.Name = "rbFollowUp"
        rbFollowUp.Size = New Size(86, 20)
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
        rbUrgent.Location = New Point(11, 59)
        rbUrgent.Name = "rbUrgent"
        rbUrgent.Size = New Size(68, 20)
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
        rbRoutine.Location = New Point(11, 28)
        rbRoutine.Name = "rbRoutine"
        rbRoutine.Size = New Size(74, 20)
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
        Label6.Location = New Point(38, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 16)
        Label6.TabIndex = 25
        Label6.Text = "Urgency Level:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(177, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 16)
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
        grpDental.Location = New Point(506, 283)
        grpDental.Name = "grpDental"
        grpDental.Size = New Size(463, 203)
        grpDental.TabIndex = 41
        grpDental.TabStop = False
        grpDental.Text = "Dental"
        ' 
        ' grpPatientType
        ' 
        grpPatientType.Controls.Add(rbChild)
        grpPatientType.Controls.Add(rbAdult)
        grpPatientType.Location = New Point(204, 55)
        grpPatientType.Name = "grpPatientType"
        grpPatientType.Size = New Size(216, 89)
        grpPatientType.TabIndex = 33
        grpPatientType.TabStop = False
        ' 
        ' rbChild
        ' 
        rbChild.AutoSize = True
        rbChild.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(32, 52)
        rbChild.Name = "rbChild"
        rbChild.Size = New Size(58, 20)
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
        rbAdult.Location = New Point(32, 20)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(58, 20)
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
        grpProcedure.Size = New Size(140, 135)
        grpProcedure.TabIndex = 32
        grpProcedure.TabStop = False
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(25, 88)
        rbFilling.Name = "rbFilling"
        rbFilling.Size = New Size(63, 20)
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
        rbExtraction.Location = New Point(25, 53)
        rbExtraction.Name = "rbExtraction"
        rbExtraction.Size = New Size(86, 20)
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
        rbCleaning.Location = New Point(25, 19)
        rbCleaning.Name = "rbCleaning"
        rbCleaning.Size = New Size(81, 20)
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
        Label9.Location = New Point(38, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 16)
        Label9.TabIndex = 25
        Label9.Text = "Procedure Type:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(204, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 16)
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
        grpPedia.Location = New Point(512, 279)
        grpPedia.Name = "grpPedia"
        grpPedia.Size = New Size(454, 291)
        grpPedia.TabIndex = 34
        grpPedia.TabStop = False
        grpPedia.Text = "Pedia"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbVaccine)
        GroupBox3.Controls.Add(rbSickV)
        GroupBox3.Controls.Add(rbGrowth)
        GroupBox3.Location = New Point(252, 64)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(160, 135)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbVaccine.ForeColor = Color.Black
        rbVaccine.Location = New Point(25, 56)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(98, 20)
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
        rbSickV.Location = New Point(25, 91)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(82, 20)
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
        rbGrowth.Location = New Point(25, 21)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(110, 20)
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
        grpAgeGroup.Location = New Point(9, 63)
        grpAgeGroup.Name = "grpAgeGroup"
        grpAgeGroup.Size = New Size(194, 136)
        grpAgeGroup.TabIndex = 39
        grpAgeGroup.TabStop = False
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(22, 65)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(112, 20)
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
        rbSchool.Location = New Point(22, 95)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(130, 20)
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
        rbInfant.Location = New Point(22, 35)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(141, 20)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(5, 225)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(413, 30)
        txtParentGName.TabIndex = 38
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(38, 37)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 16)
        Label12.TabIndex = 25
        Label12.Text = "Age Group:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(239, 37)
        Label13.Name = "Label13"
        Label13.Size = New Size(70, 16)
        Label13.TabIndex = 23
        Label13.Text = "Visit Type:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label14.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label14.Location = New Point(10, 203)
        Label14.Name = "Label14"
        Label14.Size = New Size(162, 16)
        Label14.TabIndex = 37
        Label14.Text = "Name of Parent/Guardian:"
        ' 
        ' EditPatientFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 721)
        Controls.Add(grpPedia)
        Controls.Add(grpDental)
        Controls.Add(grpGeneral)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(btnSaveEdit)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "EditPatientFrm"
        Text = "EditPatientFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
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
End Class
