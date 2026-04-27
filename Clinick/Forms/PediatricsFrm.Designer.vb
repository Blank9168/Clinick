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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Patients = New ListBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label5 = New Label()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        TextBox4 = New TextBox()
        btnAddPatient = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnBack.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnBack.Location = New Point(14, 488)
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
        Panel1.Size = New Size(239, 592)
        Panel1.TabIndex = 2
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
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(14, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 38)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(260, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 20)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' Patients
        ' 
        Patients.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Patients.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Patients.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Patients.FormattingEnabled = True
        Patients.Location = New Point(14, 74)
        Patients.Name = "Patients"
        Patients.Size = New Size(204, 382)
        Patients.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(394, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(260, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 20)
        Label2.TabIndex = 6
        Label2.Text = "Patient Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(260, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 20)
        Label4.TabIndex = 7
        Label4.Text = "Age Group:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(370, 114)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(181, 24)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Infant (0-12 months)"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(370, 144)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(135, 24)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Toddler (1-3y)"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(370, 174)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(159, 24)
        RadioButton3.TabIndex = 10
        RadioButton3.TabStop = True
        RadioButton3.Text = "School Age (4y+)"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(568, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 11
        Label5.Text = "Sex:"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(620, 114)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(66, 24)
        RadioButton4.TabIndex = 12
        RadioButton4.TabStop = True
        RadioButton4.Text = "Male"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton5.Location = New Point(692, 114)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(85, 24)
        RadioButton5.TabIndex = 13
        RadioButton5.TabStop = True
        RadioButton5.Text = "Female"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(260, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(257, 20)
        Label6.TabIndex = 14
        Label6.Text = "Parent/Guardian Contact No.:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(523, 262)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 27)
        TextBox2.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(260, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(228, 20)
        Label7.TabIndex = 16
        Label7.Text = "Name of Parent/Guradian:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(494, 221)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(283, 27)
        TextBox3.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(365, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(24, 20)
        Label8.TabIndex = 18
        Label8.Text = "id"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(16, 69)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(297, 24)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(16, 39)
        Label10.Name = "Label10"
        Label10.Size = New Size(138, 20)
        Label10.TabIndex = 21
        Label10.Text = "Date and Time:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(16, 107)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 22
        Label11.Text = "Status:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox1.Location = New Point(253, 324)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(535, 210)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Appointment Schedule"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(325, 39)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 20)
        Label9.TabIndex = 23
        Label9.Text = "Visit Type:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label12.Location = New Point(16, 139)
        Label12.Name = "Label12"
        Label12.Size = New Size(142, 20)
        Label12.TabIndex = 24
        Label12.Text = "Cancel Reason:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(325, 107)
        Label13.Name = "Label13"
        Label13.Size = New Size(162, 20)
        Label13.TabIndex = 25
        Label13.Text = "Guardian Present:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(16, 168)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(297, 27)
        TextBox4.TabIndex = 24
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAddPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddPatient.Location = New Point(659, 540)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(129, 40)
        btnAddPatient.TabIndex = 24
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' PediatricsFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(800, 592)
        Controls.Add(btnAddPatient)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(Label5)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Name = "PediatricsFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Patients As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnAddPatient As Button
End Class
