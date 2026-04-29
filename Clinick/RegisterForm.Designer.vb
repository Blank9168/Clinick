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
        lblAppStatus = New Label()
        lblDateTime = New Label()
        Label8 = New Label()
        rbSickV = New RadioButton()
        rbVaccine = New RadioButton()
        rbGrowth = New RadioButton()
        rbGuradian = New RadioButton()
        rbGuardian = New RadioButton()
        txtCancelReason = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        rbInfant = New RadioButton()
        rbSchool = New RadioButton()
        rbToddler = New RadioButton()
        Label1 = New Label()
        btnReturnMainPd = New Button()
        Panel1 = New Panel()
        txtParentGName = New TextBox()
        Label7 = New Label()
        btnAppointPatient = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(btnAppointPatient)
        GroupBox1.Controls.Add(txtParentGName)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(rbInfant)
        GroupBox1.Controls.Add(lblAppStatus)
        GroupBox1.Controls.Add(rbSchool)
        GroupBox1.Controls.Add(lblDateTime)
        GroupBox1.Controls.Add(rbToddler)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(rbSickV)
        GroupBox1.Controls.Add(rbVaccine)
        GroupBox1.Controls.Add(rbGrowth)
        GroupBox1.Controls.Add(rbGuradian)
        GroupBox1.Controls.Add(rbGuardian)
        GroupBox1.Controls.Add(txtCancelReason)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(33, 160)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(943, 539)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment"
        ' 
        ' lblAppStatus
        ' 
        lblAppStatus.AutoSize = True
        lblAppStatus.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppStatus.ForeColor = Color.Black
        lblAppStatus.Location = New Point(217, 91)
        lblAppStatus.Name = "lblAppStatus"
        lblAppStatus.Size = New Size(56, 25)
        lblAppStatus.TabIndex = 35
        lblAppStatus.Text = "aaaa"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Microsoft Sans Serif", 12F)
        lblDateTime.ForeColor = Color.Black
        lblDateTime.Location = New Point(635, 131)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(78, 25)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "000000"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(492, 91)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 25)
        Label8.TabIndex = 32
        Label8.Text = "Appointment Schedule:"
        ' 
        ' rbSickV
        ' 
        rbSickV.AutoSize = True
        rbSickV.Font = New Font("Microsoft Sans Serif", 12F)
        rbSickV.Location = New Point(48, 353)
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
        rbVaccine.Font = New Font("Microsoft Sans Serif", 12F)
        rbVaccine.Location = New Point(48, 314)
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
        rbGrowth.Font = New Font("Microsoft Sans Serif", 12F)
        rbGrowth.Location = New Point(48, 275)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(157, 29)
        rbGrowth.TabIndex = 29
        rbGrowth.TabStop = True
        rbGrowth.Text = "Growth Check"
        rbGrowth.UseVisualStyleBackColor = True
        ' 
        ' rbGuradian
        ' 
        rbGuradian.AutoSize = True
        rbGuradian.Font = New Font("Microsoft Sans Serif", 12F)
        rbGuradian.Location = New Point(598, 275)
        rbGuradian.Name = "rbGuradian"
        rbGuradian.Size = New Size(113, 29)
        rbGuradian.TabIndex = 27
        rbGuradian.TabStop = True
        rbGuradian.Text = "Guardian"
        rbGuradian.UseVisualStyleBackColor = True
        ' 
        ' rbGuardian
        ' 
        rbGuardian.AutoSize = True
        rbGuardian.Font = New Font("Microsoft Sans Serif", 12F)
        rbGuardian.Location = New Point(502, 275)
        rbGuardian.Name = "rbGuardian"
        rbGuardian.Size = New Size(90, 29)
        rbGuardian.TabIndex = 26
        rbGuardian.TabStop = True
        rbGuardian.Text = "Parent"
        rbGuardian.UseVisualStyleBackColor = True
        ' 
        ' txtCancelReason
        ' 
        txtCancelReason.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCancelReason.Location = New Point(172, 425)
        txtCancelReason.Name = "txtCancelReason"
        txtCancelReason.Size = New Size(748, 30)
        txtCancelReason.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 12F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(492, 238)
        Label13.Name = "Label13"
        Label13.Size = New Size(170, 25)
        Label13.TabIndex = 25
        Label13.Text = "Guardian Present:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 12F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(22, 428)
        Label12.Name = "Label12"
        Label12.Size = New Size(152, 25)
        Label12.TabIndex = 24
        Label12.Text = "Cancel Reason:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(22, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 25)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(22, 91)
        Label11.Name = "Label11"
        Label11.Size = New Size(189, 25)
        Label11.TabIndex = 22
        Label11.Text = "Appointment Status:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(492, 131)
        Label10.Name = "Label10"
        Label10.Size = New Size(146, 25)
        Label10.TabIndex = 21
        Label10.Text = "Date and Time:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F)
        DateTimePicker1.Location = New Point(492, 178)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(428, 30)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(22, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 25
        Label4.Text = "Age Group:"
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 12F)
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(143, 131)
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
        rbSchool.Font = New Font("Microsoft Sans Serif", 12F)
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(143, 201)
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
        rbToddler.Font = New Font("Microsoft Sans Serif", 12F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(143, 166)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(158, 29)
        rbToddler.TabIndex = 27
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
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
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(502, 364)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(418, 30)
        txtParentGName.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(492, 327)
        Label7.Name = "Label7"
        Label7.Size = New Size(239, 25)
        Label7.TabIndex = 37
        Label7.Text = "Name of Parent/Guardian:"
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAppointPatient.Location = New Point(22, 471)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(898, 54)
        btnAppointPatient.TabIndex = 39
        btnAppointPatient.Text = "Appoint Patient"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(830, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 36)
        Button2.TabIndex = 40
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 721)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Name = "RegisterForm"
        Text = "RegisterForm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAppStatus As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbSickV As RadioButton
    Friend WithEvents rbVaccine As RadioButton
    Friend WithEvents rbGrowth As RadioButton
    Friend WithEvents rbGuradian As RadioButton
    Friend WithEvents rbGuardian As RadioButton
    Friend WithEvents txtCancelReason As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
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
End Class
