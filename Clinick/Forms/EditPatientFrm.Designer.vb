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
        grpAppointment = New GroupBox()
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
        grpPatientInfo = New GroupBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
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
        lblPatientInfo = New Label()
        panelBg = New PictureBox()
        Panel1.SuspendLayout()
        grpAppointment.SuspendLayout()
        grpGeneral.SuspendLayout()
        grpPrimaryConcern.SuspendLayout()
        grpUrgency.SuspendLayout()
        grpDental.SuspendLayout()
        grpPatientType.SuspendLayout()
        grpProcedure.SuspendLayout()
        grpPedia.SuspendLayout()
        GroupBox3.SuspendLayout()
        grpAgeGroup.SuspendLayout()
        grpPatientInfo.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(panelBg, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(881, 102)
        Panel1.TabIndex = 28
        ' 
        ' lblSearchPrompt
        ' 
        lblSearchPrompt.AutoSize = True
        lblSearchPrompt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSearchPrompt.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblSearchPrompt.Location = New Point(489, 47)
        lblSearchPrompt.Name = "lblSearchPrompt"
        lblSearchPrompt.Size = New Size(127, 20)
        lblSearchPrompt.TabIndex = 46
        lblSearchPrompt.Text = "Enter Patient ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(164, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 36)
        Label1.TabIndex = 19
        Label1.Text = "Edit Patient"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnSearch.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnSearch.Location = New Point(784, 43)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(77, 25)
        btnSearch.TabIndex = 45
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(13, 9)
        btnReturnMainPd.Margin = New Padding(3, 2, 3, 2)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(94, 27)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "Return"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        txtSearchID.Location = New Point(622, 45)
        txtSearchID.Margin = New Padding(3, 2, 3, 2)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(158, 26)
        txtSearchID.TabIndex = 44
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(32, 455)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(148, 55)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(334, 463)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(147, 47)
        btnDelete.TabIndex = 34
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(714, 455)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 63)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' grpAppointment
        ' 
        grpAppointment.Controls.Add(cmbTimeSlots)
        grpAppointment.Controls.Add(Label8)
        grpAppointment.Controls.Add(Label10)
        grpAppointment.Controls.Add(dtpDate)
        grpAppointment.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpAppointment.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpAppointment.Location = New Point(442, 135)
        grpAppointment.Margin = New Padding(3, 2, 3, 2)
        grpAppointment.Name = "grpAppointment"
        grpAppointment.Padding = New Padding(3, 2, 3, 2)
        grpAppointment.Size = New Size(377, 71)
        grpAppointment.TabIndex = 37
        grpAppointment.TabStop = False
        grpAppointment.Text = "Appointment Schedule"
        ' 
        ' cmbTimeSlots
        ' 
        cmbTimeSlots.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbTimeSlots.FormattingEnabled = True
        cmbTimeSlots.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM"})
        cmbTimeSlots.Location = New Point(231, 37)
        cmbTimeSlots.Margin = New Padding(3, 2, 3, 2)
        cmbTimeSlots.Name = "cmbTimeSlots"
        cmbTimeSlots.Size = New Size(106, 21)
        cmbTimeSlots.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(228, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 13)
        Label8.TabIndex = 35
        Label8.Text = "Time: "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(6, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 13)
        Label10.TabIndex = 21
        Label10.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(6, 36)
        dtpDate.Margin = New Padding(3, 2, 3, 2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(206, 19)
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
        grpGeneral.Location = New Point(448, 212)
        grpGeneral.Margin = New Padding(3, 2, 3, 2)
        grpGeneral.Name = "grpGeneral"
        grpGeneral.Padding = New Padding(3, 2, 3, 2)
        grpGeneral.Size = New Size(371, 166)
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
        grpPrimaryConcern.Location = New Point(155, 49)
        grpPrimaryConcern.Margin = New Padding(3, 2, 3, 2)
        grpPrimaryConcern.Name = "grpPrimaryConcern"
        grpPrimaryConcern.Padding = New Padding(3, 2, 3, 2)
        grpPrimaryConcern.Size = New Size(132, 101)
        grpPrimaryConcern.TabIndex = 35
        grpPrimaryConcern.TabStop = False
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(18, 67)
        rbPhysicalExam.Margin = New Padding(3, 2, 3, 2)
        rbPhysicalExam.Name = "rbPhysicalExam"
        rbPhysicalExam.Size = New Size(93, 17)
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
        rbInjury.Location = New Point(18, 42)
        rbInjury.Margin = New Padding(3, 2, 3, 2)
        rbInjury.Name = "rbInjury"
        rbInjury.Size = New Size(50, 17)
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
        rbFever.Location = New Point(18, 17)
        rbFever.Margin = New Padding(3, 2, 3, 2)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(71, 17)
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
        grpUrgency.Location = New Point(35, 51)
        grpUrgency.Margin = New Padding(3, 2, 3, 2)
        grpUrgency.Name = "grpUrgency"
        grpUrgency.Padding = New Padding(3, 2, 3, 2)
        grpUrgency.Size = New Size(94, 101)
        grpUrgency.TabIndex = 34
        grpUrgency.TabStop = False
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(10, 66)
        rbFollowUp.Margin = New Padding(3, 2, 3, 2)
        rbFollowUp.Name = "rbFollowUp"
        rbFollowUp.Size = New Size(70, 17)
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
        rbUrgent.Location = New Point(10, 44)
        rbUrgent.Margin = New Padding(3, 2, 3, 2)
        rbUrgent.Name = "rbUrgent"
        rbUrgent.Size = New Size(57, 17)
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
        rbRoutine.Location = New Point(10, 21)
        rbRoutine.Margin = New Padding(3, 2, 3, 2)
        rbRoutine.Name = "rbRoutine"
        rbRoutine.Size = New Size(62, 17)
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
        Label6.Location = New Point(34, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 13)
        Label6.TabIndex = 25
        Label6.Text = "Urgency Level:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(155, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 13)
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
        grpDental.Location = New Point(442, 212)
        grpDental.Margin = New Padding(3, 2, 3, 2)
        grpDental.Name = "grpDental"
        grpDental.Padding = New Padding(3, 2, 3, 2)
        grpDental.Size = New Size(405, 152)
        grpDental.TabIndex = 41
        grpDental.TabStop = False
        grpDental.Text = "Dental"
        ' 
        ' grpPatientType
        ' 
        grpPatientType.Controls.Add(rbChild)
        grpPatientType.Controls.Add(rbAdult)
        grpPatientType.Location = New Point(178, 41)
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
        rbChild.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(28, 39)
        rbChild.Margin = New Padding(3, 2, 3, 2)
        rbChild.Name = "rbChild"
        rbChild.Size = New Size(48, 17)
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
        rbAdult.Location = New Point(28, 15)
        rbAdult.Margin = New Padding(3, 2, 3, 2)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(49, 17)
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
        grpProcedure.Location = New Point(29, 41)
        grpProcedure.Margin = New Padding(3, 2, 3, 2)
        grpProcedure.Name = "grpProcedure"
        grpProcedure.Padding = New Padding(3, 2, 3, 2)
        grpProcedure.Size = New Size(122, 101)
        grpProcedure.TabIndex = 32
        grpProcedure.TabStop = False
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(22, 66)
        rbFilling.Margin = New Padding(3, 2, 3, 2)
        rbFilling.Name = "rbFilling"
        rbFilling.Size = New Size(51, 17)
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
        rbExtraction.Location = New Point(22, 40)
        rbExtraction.Margin = New Padding(3, 2, 3, 2)
        rbExtraction.Name = "rbExtraction"
        rbExtraction.Size = New Size(72, 17)
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
        rbCleaning.Location = New Point(22, 14)
        rbCleaning.Margin = New Padding(3, 2, 3, 2)
        rbCleaning.Name = "rbCleaning"
        rbCleaning.Size = New Size(66, 17)
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
        Label9.Location = New Point(34, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 13)
        Label9.TabIndex = 25
        Label9.Text = "Procedure Type:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(178, 26)
        Label11.Name = "Label11"
        Label11.Size = New Size(70, 13)
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
        grpPedia.Location = New Point(448, 209)
        grpPedia.Margin = New Padding(3, 2, 3, 2)
        grpPedia.Name = "grpPedia"
        grpPedia.Padding = New Padding(3, 2, 3, 2)
        grpPedia.Size = New Size(398, 218)
        grpPedia.TabIndex = 34
        grpPedia.TabStop = False
        grpPedia.Text = "Pedia"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbVaccine)
        GroupBox3.Controls.Add(rbSickV)
        GroupBox3.Controls.Add(rbGrowth)
        GroupBox3.Location = New Point(220, 48)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(140, 101)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbVaccine.ForeColor = Color.Black
        rbVaccine.Location = New Point(22, 42)
        rbVaccine.Margin = New Padding(3, 2, 3, 2)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(81, 17)
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
        rbSickV.Location = New Point(22, 68)
        rbSickV.Margin = New Padding(3, 2, 3, 2)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(68, 17)
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
        rbGrowth.Location = New Point(22, 16)
        rbGrowth.Margin = New Padding(3, 2, 3, 2)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(93, 17)
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
        grpAgeGroup.Location = New Point(8, 47)
        grpAgeGroup.Margin = New Padding(3, 2, 3, 2)
        grpAgeGroup.Name = "grpAgeGroup"
        grpAgeGroup.Padding = New Padding(3, 2, 3, 2)
        grpAgeGroup.Size = New Size(169, 102)
        grpAgeGroup.TabIndex = 39
        grpAgeGroup.TabStop = False
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 7.8F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(20, 49)
        rbToddler.Margin = New Padding(3, 2, 3, 2)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(90, 17)
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
        rbSchool.Location = New Point(20, 71)
        rbSchool.Margin = New Padding(3, 2, 3, 2)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(106, 17)
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
        rbInfant.Location = New Point(20, 26)
        rbInfant.Margin = New Padding(3, 2, 3, 2)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(119, 17)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(4, 169)
        txtParentGName.Margin = New Padding(3, 2, 3, 2)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(362, 26)
        txtParentGName.TabIndex = 38
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(34, 28)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 13)
        Label12.TabIndex = 25
        Label12.Text = "Age Group:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(209, 28)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 13)
        Label13.TabIndex = 23
        Label13.Text = "Visit Type:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 7.8F)
        Label14.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label14.Location = New Point(8, 152)
        Label14.Name = "Label14"
        Label14.Size = New Size(132, 13)
        Label14.TabIndex = 37
        Label14.Text = "Name of Parent/Guardian:"
        ' 
        ' grpPatientInfo
        ' 
        grpPatientInfo.BackColor = Color.White
        grpPatientInfo.Controls.Add(Label2)
        grpPatientInfo.Controls.Add(DateTimePicker1)
        grpPatientInfo.Controls.Add(TextBox1)
        grpPatientInfo.Controls.Add(PictureBox5)
        grpPatientInfo.Controls.Add(Label3)
        grpPatientInfo.Controls.Add(Label4)
        grpPatientInfo.Controls.Add(btnClear)
        grpPatientInfo.Controls.Add(PictureBox4)
        grpPatientInfo.Controls.Add(btnAddPatient)
        grpPatientInfo.Controls.Add(txtContactInfo)
        grpPatientInfo.Controls.Add(Label5)
        grpPatientInfo.Controls.Add(txtPatientName)
        grpPatientInfo.Controls.Add(lblPatientID)
        grpPatientInfo.Controls.Add(Label15)
        grpPatientInfo.Controls.Add(Label16)
        grpPatientInfo.Controls.Add(Label17)
        grpPatientInfo.Controls.Add(rbMale)
        grpPatientInfo.Controls.Add(rbFemale)
        grpPatientInfo.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPatientInfo.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        grpPatientInfo.Location = New Point(32, 172)
        grpPatientInfo.Margin = New Padding(3, 2, 3, 2)
        grpPatientInfo.Name = "grpPatientInfo"
        grpPatientInfo.Padding = New Padding(3, 2, 3, 2)
        grpPatientInfo.Size = New Size(379, 258)
        grpPatientInfo.TabIndex = 43
        grpPatientInfo.TabStop = False
        grpPatientInfo.Text = "Patient Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(127, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 13)
        Label2.TabIndex = 47
        Label2.Text = "Date of Birth:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(127, 120)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(234, 20)
        DateTimePicker1.TabIndex = 46
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(14, 120)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(85, 20)
        TextBox1.TabIndex = 45
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_29__2026__02_47_47_PM
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(14, 7)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 23)
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 8F)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(14, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 13)
        Label3.TabIndex = 44
        Label3.Text = " Patient age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(48, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 17)
        Label4.TabIndex = 43
        Label4.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClear.Location = New Point(193, 157)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 22)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(377, 25)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.Teal
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(6, 201)
        btnAddPatient.Margin = New Padding(3, 2, 3, 2)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(363, 47)
        btnAddPatient.TabIndex = 30
        btnAddPatient.Text = "ADD PATIENT AND CREATE RECORD"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(127, 85)
        txtContactInfo.Margin = New Padding(3, 2, 3, 2)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(227, 20)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(14, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 13)
        Label5.TabIndex = 19
        Label5.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(127, 67)
        txtPatientName.Margin = New Padding(3, 2, 3, 2)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(227, 20)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(92, 42)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(73, 15)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "GEN-1001"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 8F)
        Label15.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label15.Location = New Point(14, 67)
        Label15.Name = "Label15"
        Label15.Size = New Size(93, 13)
        Label15.TabIndex = 6
        Label15.Text = "Patient Full Name:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label16.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label16.Location = New Point(14, 42)
        Label16.Name = "Label16"
        Label16.Size = New Size(74, 15)
        Label16.TabIndex = 4
        Label16.Text = "Patient ID:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label17.Location = New Point(14, 147)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 13)
        Label17.TabIndex = 11
        Label17.Text = "Patient Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 8F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(14, 166)
        rbMale.Margin = New Padding(3, 2, 3, 2)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(48, 17)
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
        rbFemale.Location = New Point(67, 166)
        rbFemale.Margin = New Padding(3, 2, 3, 2)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(59, 17)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' lblPatientInfo
        ' 
        lblPatientInfo.AutoSize = True
        lblPatientInfo.BackColor = Color.PowderBlue
        lblPatientInfo.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientInfo.ForeColor = Color.DarkSlateGray
        lblPatientInfo.Location = New Point(80, 146)
        lblPatientInfo.Name = "lblPatientInfo"
        lblPatientInfo.Size = New Size(280, 26)
        lblPatientInfo.TabIndex = 44
        lblPatientInfo.Text = "PATIENT INFORMATION"
        ' 
        ' panelBg
        ' 
        panelBg.BackColor = Color.PowderBlue
        panelBg.Location = New Point(32, 135)
        panelBg.Margin = New Padding(3, 2, 3, 2)
        panelBg.Name = "panelBg"
        panelBg.Size = New Size(379, 40)
        panelBg.TabIndex = 45
        panelBg.TabStop = False
        ' 
        ' EditPatientFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 541)
        Controls.Add(lblPatientInfo)
        Controls.Add(grpPatientInfo)
        Controls.Add(grpPedia)
        Controls.Add(grpDental)
        Controls.Add(grpGeneral)
        Controls.Add(grpAppointment)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(btnSaveEdit)
        Controls.Add(Panel1)
        Controls.Add(panelBg)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditPatientFrm"
        Text = "EditPatientFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grpAppointment.ResumeLayout(False)
        grpAppointment.PerformLayout()
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
        grpPatientInfo.ResumeLayout(False)
        grpPatientInfo.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(panelBg, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpAppointment As GroupBox
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
    Friend WithEvents grpPatientInfo As GroupBox
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
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents panelBg As PictureBox

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles lblPatientInfo.Click

    End Sub
End Class
