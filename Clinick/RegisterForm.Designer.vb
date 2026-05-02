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
        lblDateTime = New Label()
        Label10 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button2 = New Button()
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
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        rbChild = New RadioButton()
        rbAdult = New RadioButton()
        rbFilling = New RadioButton()
        rbExtraction = New RadioButton()
        rbCleaning = New RadioButton()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox4 = New GroupBox()
        rbPhysicalExam = New RadioButton()
        rbInjury = New RadioButton()
        rbFever = New RadioButton()
        rbFollowUp = New RadioButton()
        rbUrgent = New RadioButton()
        rbRoutine = New RadioButton()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblDateTime)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(14, 161)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(961, 120)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment Schedule"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Microsoft Sans Serif", 12.0F)
        lblDateTime.ForeColor = Color.Black
        lblDateTime.Location = New Point(180, 44)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(78, 25)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "000000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(38, 44)
        Label10.Name = "Label10"
        Label10.Size = New Size(146, 25)
        Label10.TabIndex = 21
        Label10.Text = "Date and Time:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12.0F)
        DateTimePicker1.Location = New Point(54, 72)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(428, 30)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(73, 835)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 36)
        Button2.TabIndex = 40
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAppointPatient.Location = New Point(780, 824)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(195, 54)
        btnAppointPatient.TabIndex = 39
        btnAppointPatient.Text = "Appoint Patient"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(524, 64)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(413, 30)
        txtParentGName.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12.0F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(503, 32)
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
        Label4.Location = New Point(38, 32)
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
        rbInfant.Location = New Point(59, 64)
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
        rbSchool.Location = New Point(59, 134)
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
        rbToddler.Location = New Point(59, 99)
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
        rbSickV.Location = New Point(325, 138)
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
        rbVaccine.Location = New Point(325, 99)
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
        rbGrowth.Location = New Point(325, 60)
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
        Label9.Location = New Point(295, 32)
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbToddler)
        GroupBox2.Controls.Add(rbSchool)
        GroupBox2.Controls.Add(txtParentGName)
        GroupBox2.Controls.Add(rbInfant)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(rbVaccine)
        GroupBox2.Controls.Add(rbSickV)
        GroupBox2.Controls.Add(rbGrowth)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox2.Location = New Point(14, 287)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(961, 173)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pedia"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbChild)
        GroupBox3.Controls.Add(rbAdult)
        GroupBox3.Controls.Add(rbFilling)
        GroupBox3.Controls.Add(rbExtraction)
        GroupBox3.Controls.Add(rbCleaning)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox3.Location = New Point(14, 466)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(961, 173)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        GroupBox3.Text = "Dental"
        ' 
        ' rbChild
        ' 
        rbChild.AutoSize = True
        rbChild.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbChild.ForeColor = Color.Black
        rbChild.Location = New Point(524, 95)
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
        rbAdult.Location = New Point(524, 60)
        rbAdult.Name = "rbAdult"
        rbAdult.Size = New Size(78, 29)
        rbAdult.TabIndex = 30
        rbAdult.TabStop = True
        rbAdult.Text = "Adult"
        rbAdult.UseVisualStyleBackColor = True
        ' 
        ' rbFilling
        ' 
        rbFilling.AutoSize = True
        rbFilling.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbFilling.ForeColor = Color.Black
        rbFilling.Location = New Point(59, 133)
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
        rbExtraction.Location = New Point(59, 95)
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
        rbCleaning.Location = New Point(59, 60)
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
        Label2.Location = New Point(38, 32)
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
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(rbPhysicalExam)
        GroupBox4.Controls.Add(rbInjury)
        GroupBox4.Controls.Add(rbFever)
        GroupBox4.Controls.Add(rbFollowUp)
        GroupBox4.Controls.Add(rbUrgent)
        GroupBox4.Controls.Add(rbRoutine)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Font = New Font("Microsoft Sans Serif", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox4.Location = New Point(14, 645)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(961, 173)
        GroupBox4.TabIndex = 41
        GroupBox4.TabStop = False
        GroupBox4.Text = "General"
        ' 
        ' rbPhysicalExam
        ' 
        rbPhysicalExam.AutoSize = True
        rbPhysicalExam.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbPhysicalExam.ForeColor = Color.Black
        rbPhysicalExam.Location = New Point(522, 130)
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
        rbInjury.Location = New Point(524, 95)
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
        rbFever.Location = New Point(524, 60)
        rbFever.Name = "rbFever"
        rbFever.Size = New Size(116, 29)
        rbFever.TabIndex = 31
        rbFever.TabStop = True
        rbFever.Text = "Fever/Flu"
        rbFever.UseVisualStyleBackColor = True
        ' 
        ' rbFollowUp
        ' 
        rbFollowUp.AutoSize = True
        rbFollowUp.Font = New Font("Microsoft Sans Serif", 12.0F)
        rbFollowUp.ForeColor = Color.Black
        rbFollowUp.Location = New Point(61, 130)
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
        rbUrgent.Location = New Point(61, 95)
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
        rbRoutine.Location = New Point(61, 60)
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
        Label5.Location = New Point(38, 32)
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
        Label6.Location = New Point(503, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 25)
        Label6.TabIndex = 23
        Label6.Text = "Primary Concern:"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 883)
        Controls.Add(GroupBox4)
        Controls.Add(Button2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
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
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents rbSickV As RadioButton
    Friend WithEvents rbVaccine As RadioButton
    Friend WithEvents rbGrowth As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
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
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
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
End Class
