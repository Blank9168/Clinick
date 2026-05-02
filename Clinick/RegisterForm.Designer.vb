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
        Button2 = New Button()
        btnAppointPatient = New Button()
        txtParentGName = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        rbInfant = New RadioButton()
        lblAppStatus = New Label()
        rbSchool = New RadioButton()
        lblDateTime = New Label()
        rbToddler = New RadioButton()
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
        Label1 = New Label()
        btnReturnMainPd = New Button()
        Panel1 = New Panel()
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
        GroupBox1.Location = New Point(41, 200)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(1179, 674)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(1038, 28)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 45)
        Button2.TabIndex = 40
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAppointPatient.Location = New Point(28, 589)
        btnAppointPatient.Margin = New Padding(4, 4, 4, 4)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(1122, 68)
        btnAppointPatient.TabIndex = 39
        btnAppointPatient.Text = "Appoint Patient"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' txtParentGName
        ' 
        txtParentGName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtParentGName.Location = New Point(628, 455)
        txtParentGName.Margin = New Padding(4, 4, 4, 4)
        txtParentGName.Name = "txtParentGName"
        txtParentGName.Size = New Size(522, 35)
        txtParentGName.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(615, 409)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(291, 29)
        Label7.TabIndex = 37
        Label7.Text = "Name of Parent/Guardian:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(28, 168)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 29)
        Label4.TabIndex = 25
        Label4.Text = "Age Group:"
        ' 
        ' rbInfant
        ' 
        rbInfant.AutoSize = True
        rbInfant.Font = New Font("Microsoft Sans Serif", 12F)
        rbInfant.ForeColor = Color.Black
        rbInfant.Location = New Point(179, 164)
        rbInfant.Margin = New Padding(4, 4, 4, 4)
        rbInfant.Name = "rbInfant"
        rbInfant.Size = New Size(248, 33)
        rbInfant.TabIndex = 26
        rbInfant.TabStop = True
        rbInfant.Text = "Infant (0-12 months)"
        rbInfant.UseVisualStyleBackColor = True
        ' 
        ' lblAppStatus
        ' 
        lblAppStatus.AutoSize = True
        lblAppStatus.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAppStatus.ForeColor = Color.Black
        lblAppStatus.Location = New Point(271, 114)
        lblAppStatus.Margin = New Padding(4, 0, 4, 0)
        lblAppStatus.Name = "lblAppStatus"
        lblAppStatus.Size = New Size(65, 29)
        lblAppStatus.TabIndex = 35
        lblAppStatus.Text = "aaaa"
        ' 
        ' rbSchool
        ' 
        rbSchool.AutoSize = True
        rbSchool.Font = New Font("Microsoft Sans Serif", 12F)
        rbSchool.ForeColor = Color.Black
        rbSchool.Location = New Point(179, 251)
        rbSchool.Margin = New Padding(4, 4, 4, 4)
        rbSchool.Name = "rbSchool"
        rbSchool.Size = New Size(222, 33)
        rbSchool.TabIndex = 28
        rbSchool.TabStop = True
        rbSchool.Text = "School Age (4y+)"
        rbSchool.UseVisualStyleBackColor = True
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Microsoft Sans Serif", 12F)
        lblDateTime.ForeColor = Color.Black
        lblDateTime.Location = New Point(794, 164)
        lblDateTime.Margin = New Padding(4, 0, 4, 0)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(91, 29)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "000000"
        ' 
        ' rbToddler
        ' 
        rbToddler.AutoSize = True
        rbToddler.Font = New Font("Microsoft Sans Serif", 12F)
        rbToddler.ForeColor = Color.Black
        rbToddler.Location = New Point(179, 208)
        rbToddler.Margin = New Padding(4, 4, 4, 4)
        rbToddler.Name = "rbToddler"
        rbToddler.Size = New Size(191, 33)
        rbToddler.TabIndex = 27
        rbToddler.TabStop = True
        rbToddler.Text = "Toddler (1-3y)"
        rbToddler.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(615, 114)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(262, 29)
        Label8.TabIndex = 32
        Label8.Text = "Appointment Schedule:"
        ' 
        ' rbSickV
        ' 
        rbSickV.AutoSize = True
        rbSickV.Font = New Font("Microsoft Sans Serif", 12F)
        rbSickV.Location = New Point(60, 441)
        rbSickV.Margin = New Padding(4, 4, 4, 4)
        rbSickV.Name = "rbSickV"
        rbSickV.Size = New Size(135, 33)
        rbSickV.TabIndex = 31
        rbSickV.TabStop = True
        rbSickV.Text = "Sick Visit"
        rbSickV.UseVisualStyleBackColor = True
        ' 
        ' rbVaccine
        ' 
        rbVaccine.AutoSize = True
        rbVaccine.Font = New Font("Microsoft Sans Serif", 12F)
        rbVaccine.Location = New Point(60, 392)
        rbVaccine.Margin = New Padding(4, 4, 4, 4)
        rbVaccine.Name = "rbVaccine"
        rbVaccine.Size = New Size(161, 33)
        rbVaccine.TabIndex = 30
        rbVaccine.TabStop = True
        rbVaccine.Text = "Vaccination"
        rbVaccine.UseVisualStyleBackColor = True
        ' 
        ' rbGrowth
        ' 
        rbGrowth.AutoSize = True
        rbGrowth.Font = New Font("Microsoft Sans Serif", 12F)
        rbGrowth.Location = New Point(60, 344)
        rbGrowth.Margin = New Padding(4, 4, 4, 4)
        rbGrowth.Name = "rbGrowth"
        rbGrowth.Size = New Size(189, 33)
        rbGrowth.TabIndex = 29
        rbGrowth.TabStop = True
        rbGrowth.Text = "Growth Check"
        rbGrowth.UseVisualStyleBackColor = True
        ' 
        ' rbGuradian
        ' 
        rbGuradian.AutoSize = True
        rbGuradian.Font = New Font("Microsoft Sans Serif", 12F)
        rbGuradian.Location = New Point(748, 344)
        rbGuradian.Margin = New Padding(4, 4, 4, 4)
        rbGuradian.Name = "rbGuradian"
        rbGuradian.Size = New Size(136, 33)
        rbGuradian.TabIndex = 27
        rbGuradian.TabStop = True
        rbGuradian.Text = "Guardian"
        rbGuradian.UseVisualStyleBackColor = True
        ' 
        ' rbGuardian
        ' 
        rbGuardian.AutoSize = True
        rbGuardian.Font = New Font("Microsoft Sans Serif", 12F)
        rbGuardian.Location = New Point(628, 344)
        rbGuardian.Margin = New Padding(4, 4, 4, 4)
        rbGuardian.Name = "rbGuardian"
        rbGuardian.Size = New Size(108, 33)
        rbGuardian.TabIndex = 26
        rbGuardian.TabStop = True
        rbGuardian.Text = "Parent"
        rbGuardian.UseVisualStyleBackColor = True
        ' 
        ' txtCancelReason
        ' 
        txtCancelReason.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCancelReason.Location = New Point(215, 531)
        txtCancelReason.Margin = New Padding(4, 4, 4, 4)
        txtCancelReason.Name = "txtCancelReason"
        txtCancelReason.Size = New Size(934, 35)
        txtCancelReason.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 12F)
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(615, 298)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(206, 29)
        Label13.TabIndex = 25
        Label13.Text = "Guardian Present:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 12F)
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(28, 535)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(183, 29)
        Label12.TabIndex = 24
        Label12.Text = "Cancel Reason:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F)
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(28, 298)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(125, 29)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F)
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(28, 114)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(226, 29)
        Label11.TabIndex = 22
        Label11.Text = "Appointment Status:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F)
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(615, 164)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(177, 29)
        Label10.TabIndex = 21
        Label10.Text = "Date and Time:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F)
        DateTimePicker1.Location = New Point(615, 222)
        DateTimePicker1.Margin = New Padding(4, 4, 4, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(534, 35)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(448, 65)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 52)
        Label1.TabIndex = 19
        Label1.Text = "Appoint Patient"
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(18, 15)
        btnReturnMainPd.Margin = New Padding(4, 4, 4, 4)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(135, 45)
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
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1258, 169)
        Panel1.TabIndex = 36
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1258, 901)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
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
