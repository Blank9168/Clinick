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
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
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
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(TextBox1)
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
        GroupBox2.Location = New Point(147, 157)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(721, 486)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F)
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(38, 317)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 25)
        Label8.TabIndex = 47
        Label8.Text = "Date of Birth:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(38, 347)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(266, 27)
        DateTimePicker1.TabIndex = 46
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(38, 262)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 30)
        TextBox1.TabIndex = 45
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F)
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(38, 234)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 44
        Label7.Text = "Patient age:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox5.BackgroundImage = My.Resources.Resources.ChatGPT_Image_Apr_29__2026__02_47_47_PM
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(28, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(62, 59)
        PictureBox5.TabIndex = 32
        PictureBox5.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(96, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(272, 32)
        Label6.TabIndex = 43
        Label6.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Teal
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(593, 84)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(97, 34)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(721, 33)
        PictureBox4.TabIndex = 42
        PictureBox4.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.Teal
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(38, 413)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(643, 44)
        btnAddPatient.TabIndex = 30
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(221, 186)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(469, 30)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(38, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 25)
        Label4.TabIndex = 19
        Label4.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(221, 132)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(469, 30)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(171, 89)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(133, 29)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "GEN-1001"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(38, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 6
        Label2.Text = "Patient Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(38, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 29)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(309, 234)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 25)
        Label5.TabIndex = 11
        Label5.Text = "Patient Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 12F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(322, 262)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(76, 29)
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
        rbFemale.Location = New Point(404, 263)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(98, 29)
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 723)
        Panel1.TabIndex = 27
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Teal
        PictureBox1.BackgroundImage = My.Resources.Resources.curved_arrow_left_white_icon1
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(32, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 31)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Teal
        Label1.Font = New Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(355, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 37)
        Label1.TabIndex = 19
        Label1.Text = "Patient Registration"
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.Teal
        btnReturnMainPd.BackgroundImageLayout = ImageLayout.Center
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.White
        btnReturnMainPd.Location = New Point(14, 12)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(322, 56)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "    Back To Dashboard"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Teal
        PictureBox3.Location = New Point(147, 92)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(721, 62)
        PictureBox3.TabIndex = 31
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.resized_logo__1_
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(779, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(238, 128)
        PictureBox2.TabIndex = 30
        PictureBox2.TabStop = False
        ' 
        ' AddPatient_Frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 721)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
End Class
