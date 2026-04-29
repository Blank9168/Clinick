<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        btnClose = New Label()
        lblUsername = New Label()
        Label1 = New Label()
        lblName = New Label()
        PictureBox1 = New PictureBox()
        lblDate = New Label()
        Button2 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        LblDateTime = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Label9 = New Label()
        Applied = New DataGridViewTextBoxColumn()
        PatientName = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        Sched = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Doctor = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(21, 339)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(253, 69)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(192), CByte(228), CByte(231))
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(291, 339)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(253, 69)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(164), CByte(215), CByte(219))
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(561, 339)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(253, 69)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(786, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(37, 26)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Microsoft Sans Serif", 9F)
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(97, 64)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(90, 18)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Employee01"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(97, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 18)
        Label1.TabIndex = 6
        Label1.Text = "Welcome!"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 9F)
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(97, 82)
        lblName.Name = "lblName"
        lblName.Size = New Size(116, 18)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.a81550e786150a070aea73896e641a21
        PictureBox1.Location = New Point(18, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(11, 410)
        lblDate.Margin = New Padding(2, 0, 2, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 20)
        lblDate.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(698, 54)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 37)
        Button2.TabIndex = 18
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(66, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 22
        Label4.Text = "Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 18)
        Label3.TabIndex = 21
        Label3.Text = "Appointments Summary:"
        ' 
        ' LblDateTime
        ' 
        LblDateTime.AutoSize = True
        LblDateTime.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDateTime.Location = New Point(10, 6)
        LblDateTime.Margin = New Padding(2, 0, 2, 0)
        LblDateTime.Name = "LblDateTime"
        LblDateTime.Size = New Size(0, 18)
        LblDateTime.TabIndex = 22
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(LblDateTime)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(lblUsername)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(826, 121)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 18)
        Label2.TabIndex = 24
        Label2.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 172)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(827, 101)
        Panel2.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(719, 58)
        Label13.Name = "Label13"
        Label13.Size = New Size(18, 20)
        Label13.TabIndex = 32
        Label13.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(490, 58)
        Label12.Name = "Label12"
        Label12.Size = New Size(18, 20)
        Label12.TabIndex = 31
        Label12.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(278, 58)
        Label11.Name = "Label11"
        Label11.Size = New Size(18, 20)
        Label11.TabIndex = 30
        Label11.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(82, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 20)
        Label10.TabIndex = 29
        Label10.Text = "0"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(254), CByte(26), CByte(28))
        Panel5.Location = New Point(662, 19)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(19, 20)
        Panel5.TabIndex = 28
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(145), CByte(207), CByte(4))
        Panel4.Location = New Point(430, 19)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(19, 20)
        Panel4.TabIndex = 27
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(170), CByte(26))
        Panel3.Location = New Point(228, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(19, 20)
        Panel3.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label7.Location = New Point(687, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 20)
        Label7.TabIndex = 25
        Label7.Text = "Cancelled"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label6.Location = New Point(455, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 20)
        Label6.TabIndex = 24
        Label6.Text = "Completed"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label5.Location = New Point(253, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 23
        Label5.Text = "Pending"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(22, 305)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 18)
        Label8.TabIndex = 26
        Label8.Text = "New Appointment"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Applied, PatientName, ServiceType, Sched, Status, Doctor})
        DataGridView1.Location = New Point(22, 453)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(792, 95)
        DataGridView1.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(22, 422)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 18)
        Label9.TabIndex = 28
        Label9.Text = "Recents:"
        ' 
        ' Applied
        ' 
        Applied.HeaderText = "Applied"
        Applied.MinimumWidth = 6
        Applied.Name = "Applied"
        Applied.Width = 125
        ' 
        ' PatientName
        ' 
        PatientName.HeaderText = "Patient Name"
        PatientName.MinimumWidth = 6
        PatientName.Name = "PatientName"
        PatientName.Width = 125
        ' 
        ' ServiceType
        ' 
        ServiceType.HeaderText = "Service Type"
        ServiceType.MinimumWidth = 6
        ServiceType.Name = "ServiceType"
        ServiceType.Width = 125
        ' 
        ' Sched
        ' 
        Sched.HeaderText = "Schedule"
        Sched.MinimumWidth = 6
        Sched.Name = "Sched"
        Sched.Width = 125
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Width = 125
        ' 
        ' Doctor
        ' 
        Doctor.HeaderText = "Doctor"
        Doctor.MinimumWidth = 6
        Doctor.Name = "Doctor"
        Doctor.Width = 125
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(826, 570)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(btnPediatrics)
        Controls.Add(Panel1)
        Controls.Add(btnDentalS)
        Controls.Add(btnGeneralCons)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents btnClose As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Applied As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents Sched As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
End Class
