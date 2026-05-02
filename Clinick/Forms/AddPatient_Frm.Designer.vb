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
        btnClear = New Button()
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
        Label1 = New Label()
        btnReturnMainPd = New Button()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnClear)
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
        GroupBox2.Location = New Point(25, 166)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(955, 532)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Patient Information"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnClear.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClear.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClear.Location = New Point(842, 20)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 36)
        btnClear.TabIndex = 41
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddPatient.Location = New Point(18, 451)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(913, 54)
        btnAddPatient.TabIndex = 30
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContactInfo.Location = New Point(211, 245)
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(416, 30)
        txtContactInfo.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(18, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 25)
        Label4.TabIndex = 19
        Label4.Text = "Contact Information:"
        ' 
        ' txtPatientName
        ' 
        txtPatientName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPatientName.Location = New Point(195, 183)
        txtPatientName.Name = "txtPatientName"
        txtPatientName.Size = New Size(432, 30)
        txtPatientName.TabIndex = 5
        ' 
        ' lblPatientID
        ' 
        lblPatientID.AutoSize = True
        lblPatientID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPatientID.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPatientID.Location = New Point(137, 126)
        lblPatientID.Name = "lblPatientID"
        lblPatientID.Size = New Size(29, 25)
        lblPatientID.TabIndex = 18
        lblPatientID.Text = "id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(18, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 6
        Label2.Text = "Patient Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(18, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 25)
        Label3.TabIndex = 4
        Label3.Text = "Patient ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(678, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 25)
        Label5.TabIndex = 11
        Label5.Text = "Sex:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Font = New Font("Microsoft Sans Serif", 12F)
        rbMale.ForeColor = Color.Black
        rbMale.Location = New Point(743, 186)
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
        rbFemale.Location = New Point(831, 186)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(98, 29)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnReturnMainPd)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1011, 136)
        Panel1.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(377, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 42)
        Label1.TabIndex = 19
        Label1.Text = "Add Patient"
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
        ' AddPatient_Frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 721)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Name = "AddPatient_Frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Patient"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
End Class
