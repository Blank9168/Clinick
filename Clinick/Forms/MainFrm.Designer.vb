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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        btnClose = New Label()
        lblWelcome = New Label()
        lblName = New Label()
        Button2 = New Button()
        Label4 = New Label()
        LblDateTime = New Label()
        Panel1 = New Panel()
        LblDate = New Label()
        PicLogo = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel10 = New Panel()
        Label6 = New Label()
        Panel13 = New Panel()
        Label11 = New Label()
        Panel4 = New Panel()
        Panel9 = New Panel()
        Label5 = New Label()
        Panel12 = New Panel()
        Label7 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Label10 = New Label()
        Panel3 = New Panel()
        Panel11 = New Panel()
        Label14 = New Label()
        Panel8 = New Panel()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Applied = New DataGridViewTextBoxColumn()
        PatientName = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        Sched = New DataGridViewTextBoxColumn()
        Doctor = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel13.SuspendLayout()
        Panel4.SuspendLayout()
        Panel12.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(44, 342)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(287, 95)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(192), CByte(228), CByte(231))
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(377, 342)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(287, 95)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(164), CByte(215), CByte(219))
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(710, 342)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(287, 95)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(975, 21)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(37, 26)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(155, 23)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(136, 29)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome, "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(282, 23)
        lblName.Name = "lblName"
        lblName.Size = New Size(214, 29)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend!"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(844, 15)
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
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(31, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 22)
        Label4.TabIndex = 22
        Label4.Text = "TOTAL"
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
        Panel1.Controls.Add(LblDate)
        Panel1.Controls.Add(PicLogo)
        Panel1.Controls.Add(LblDateTime)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 80)
        Panel1.TabIndex = 0
        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDate.Location = New Point(577, 28)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(0, 19)
        LblDate.TabIndex = 24
        ' 
        ' PicLogo
        ' 
        PicLogo.Image = My.Resources.Resources.logo_final__250_x_100_px___1_
        PicLogo.Location = New Point(12, -10)
        PicLogo.Name = "PicLogo"
        PicLogo.Size = New Size(134, 87)
        PicLogo.TabIndex = 23
        PicLogo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 25)
        Label2.TabIndex = 24
        Label2.Text = "Dashboard Summary | "
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(0, 132)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1024, 150)
        Panel2.TabIndex = 25
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel5.Controls.Add(Panel10)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Panel13)
        Panel5.Location = New Point(756, 14)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(173, 112)
        Panel5.TabIndex = 35
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(254), CByte(26), CByte(28))
        Panel10.Location = New Point(8, 5)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(22, 22)
        Panel10.TabIndex = 31
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(36, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 22)
        Label6.TabIndex = 23
        Label6.Text = "CANCELLED"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Controls.Add(Label11)
        Panel13.Location = New Point(0, 30)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(173, 82)
        Panel13.TabIndex = 30
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(76, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 39)
        Label11.TabIndex = 29
        Label11.Text = "0"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel4.Controls.Add(Panel9)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Panel12)
        Panel4.Location = New Point(537, 14)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(173, 112)
        Panel4.TabIndex = 34
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Green
        Panel9.Location = New Point(8, 5)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(22, 22)
        Panel9.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(36, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 22)
        Label5.TabIndex = 23
        Label5.Text = "COMPLETED"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(Label7)
        Panel12.Location = New Point(0, 30)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(173, 82)
        Panel12.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(67, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 39)
        Label7.TabIndex = 29
        Label7.Text = "0"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(125, 14)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(173, 112)
        Panel6.TabIndex = 33
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label10)
        Panel7.Location = New Point(-1, 30)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(174, 82)
        Panel7.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(70, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(37, 39)
        Label10.TabIndex = 29
        Label10.Text = "0"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel3.Controls.Add(Panel11)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Panel8)
        Panel3.Location = New Point(334, 14)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(173, 112)
        Panel3.TabIndex = 26
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Orange
        Panel11.Location = New Point(8, 5)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(22, 22)
        Panel11.TabIndex = 31
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(36, 5)
        Label14.Name = "Label14"
        Label14.Size = New Size(98, 22)
        Label14.TabIndex = 23
        Label14.Text = "PENDING"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(Label3)
        Panel8.Location = New Point(0, 30)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(173, 82)
        Panel8.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(79, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 39)
        Label3.TabIndex = 29
        Label3.Text = "0"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Applied, PatientName, ServiceType, Sched, Doctor, Status})
        DataGridView1.Location = New Point(22, 495)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(990, 204)
        DataGridView1.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(231, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 25)
        Label1.TabIndex = 29
        Label1.Text = "Care is just a click away"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 25)
        Label8.TabIndex = 30
        Label8.Text = "New Appointment"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 457)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 25)
        Label9.TabIndex = 31
        Label9.Text = "Recent"
        ' 
        ' Applied
        ' 
        Applied.HeaderText = "Patient ID"
        Applied.MinimumWidth = 6
        Applied.Name = "Applied"
        ' 
        ' PatientName
        ' 
        PatientName.HeaderText = "Patient Name"
        PatientName.MinimumWidth = 6
        PatientName.Name = "PatientName"
        ' 
        ' ServiceType
        ' 
        ServiceType.HeaderText = "Service Type"
        ServiceType.MinimumWidth = 6
        ServiceType.Name = "ServiceType"
        ' 
        ' Sched
        ' 
        Sched.HeaderText = "Schedule"
        Sched.MinimumWidth = 6
        Sched.Name = "Sched"
        ' 
        ' Doctor
        ' 
        Doctor.HeaderText = "Doctor"
        Doctor.MinimumWidth = 6
        Doctor.Name = "Doctor"
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.MinimumWidth = 6
        Status.Name = "Status"
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1024, 768)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents btnClose As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Applied As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents Sched As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
