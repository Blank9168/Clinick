<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatient_Frm
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
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        dtpBday = New DateTimePicker()
        txtAge = New TextBox()
        Label7 = New Label()
        PictureBox5 = New PictureBox()
        Label6 = New Label()
        btnClear = New Button()
        PictureBox4 = New PictureBox()
        btnAddPatient = New Button()
        txtContactInfo = New TextBox()
        Label4 = New Label()
        txtPatientName = New TextBox()
        lblPatientID = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnReturnMainPd = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(dtpBday)
        GroupBox2.Controls.Add(txtAge)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(PictureBox5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(btnClear)
        GroupBox2.Controls.Add(PictureBox4)
        GroupBox2.Controls.Add(btnAddPatient)
        GroupBox2.Controls.Add(txtContactInfo)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtPatientName)
        GroupBox2.Controls.Add(lblPatientID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(rbMale)
        GroupBox2.Controls.Add(rbFemale)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        GroupBox2.Location = New Point(129, 118)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(631, 364)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(33, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 47
        Label8.Text = "Date of Birth:"
        ' 
        ' dtpBday
        ' 
        dtpBday.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpBday.Location = New Point(33, 260)
        dtpBday.Margin = New Padding(3, 2, 3, 2)
        dtpBday.Name = "dtpBday"
        dtpBday.Size = New Size(233, 23)
        dtpBday.TabIndex = 46
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(33, 196)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(133, 26)
        txtAge.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(33, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 44
        Label7.Text = "Patient age:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox5.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_29__2026__02_47_47_PM
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(24, 9)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(54, 44)
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(84, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(214, 26)
        Label6.TabIndex = 43
        Label6.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Teal
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(519, 63)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 26)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(631, 25)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.Teal
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(33, 310)
        btnAddPatient.Margin = New Padding(3, 2, 3, 2)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(563, 33)
        btnAddPatient.TabIndex = 30
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(193, 140)
        txtContactInfo.Margin = New Padding(3, 2, 3, 2)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(411, 26)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(33, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 19
        Label4.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(193, 99)
        txtPatientName.Margin = New Padding(3, 2, 3, 2)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(411, 26)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(150, 67)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(105, 24)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "GEN-1001"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(33, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 6
        Label2.Text = "Patient Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(33, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 24)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(270, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 20)
        Label5.TabIndex = 11
        Label5.Text = "Patient Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 12F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(282, 196)
        rbMale.Margin = New Padding(3, 2, 3, 2)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(61, 24)
        rbMale.TabIndex = 12
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Font = New Font("Microsoft Sans Serif", 12F)
        rbFemale.ForeColor = Color.Black
        rbFemale.Location = New Point(354, 197)
        rbFemale.Margin = New Padding(3, 2, 3, 2)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(80, 24)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnReturnMainPd)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(880, 543)
        Panel1.TabIndex = 27
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Teal
        PictureBox1.BackgroundImage = My.Resources.Resources.curved_arrow_left_white_icon1
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(28, 18)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 23)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(311, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 30)
        Label1.TabIndex = 19
        Label1.Text = "Patient Registration"
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.Teal
        btnReturnMainPd.BackgroundImageLayout = ImageLayout.Center
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.White
        btnReturnMainPd.Location = New Point(12, 9)
        btnReturnMainPd.Margin = New Padding(3, 2, 3, 2)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(282, 42)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "    Back To Dashboard"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Teal
        PictureBox3.Location = New Point(129, 69)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(631, 46)
        PictureBox3.TabIndex = 31
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.resized_logo__1_
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(682, 0)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(208, 96)
        PictureBox2.TabIndex = 30
        PictureBox2.TabStop = False
        ' 
        ' AddPatient_Frm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(880, 541)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "AddPatient_Frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Patient"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpBday As DateTimePicker
    Friend WithEvents txtAge As TextBox
End Class
