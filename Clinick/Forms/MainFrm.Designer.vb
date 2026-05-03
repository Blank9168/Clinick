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
        lblPending = New Label()
        lblCompleted = New Label()
        lblCancelled = New Label()
        lblTotal = New Label()
        Panel14 = New Panel()
        Panel11 = New Panel()
        Label14 = New Label()
        Panel9 = New Panel()
        Label5 = New Label()
        Panel10 = New Panel()
        Label6 = New Label()
        dgvSummary = New DataGridView()
        Applied = New DataGridViewTextBoxColumn()
        PatientName = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        Sched = New DataGridViewTextBoxColumn()
        Status = New DataGridViewComboBoxColumn()
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        MarkToolStripMenuItem = New ToolStripMenuItem()
        Panel1.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel14.SuspendLayout()
        CType(dgvSummary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(42, 359)
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
        btnDentalS.Location = New Point(375, 359)
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
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(708, 359)
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
        lblWelcome.Location = New Point(169, 26)
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
        lblName.Location = New Point(296, 26)
        lblName.Name = "lblName"
        lblName.Size = New Size(214, 29)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend!"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(897, 95)
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
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(58, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 22)
        Label4.TabIndex = 22
        Label4.Text = "Total"
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
        Panel1.Controls.Add(LblDateTime)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(PicLogo)
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
        LblDate.Location = New Point(598, 31)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(0, 19)
        LblDate.TabIndex = 24
        ' 
        ' PicLogo
        ' 
        PicLogo.Image = My.Resources.Resources.logo_final__250_x_100_px___1_
        PicLogo.Location = New Point(16, -9)
        PicLogo.Name = "PicLogo"
        PicLogo.Size = New Size(216, 106)
        PicLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PicLogo.TabIndex = 23
        PicLogo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(13, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 25)
        Label2.TabIndex = 24
        Label2.Text = "Dashboard Summary | "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(lblCompleted)
        Panel2.Controls.Add(lblCancelled)
        Panel2.Controls.Add(lblTotal)
        Panel2.Controls.Add(Panel14)
        Panel2.Location = New Point(1, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1024, 150)
        Panel2.TabIndex = 25
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPending.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPending.Location = New Point(309, 82)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(37, 39)
        lblPending.TabIndex = 29
        lblPending.Text = "0"
        ' 
        ' lblCompleted
        ' 
        lblCompleted.AutoSize = True
        lblCompleted.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompleted.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblCompleted.Location = New Point(592, 82)
        lblCompleted.Name = "lblCompleted"
        lblCompleted.Size = New Size(37, 39)
        lblCompleted.TabIndex = 29
        lblCompleted.Text = "0"
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCancelled.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblCancelled.Location = New Point(875, 82)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Size = New Size(37, 39)
        lblCancelled.TabIndex = 29
        lblCancelled.Text = "0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblTotal.Location = New Point(68, 82)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(37, 39)
        lblTotal.TabIndex = 29
        lblTotal.Text = "0"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel14.Controls.Add(Panel11)
        Panel14.Controls.Add(Label14)
        Panel14.Controls.Add(Panel9)
        Panel14.Controls.Add(Label5)
        Panel14.Controls.Add(Panel10)
        Panel14.Controls.Add(Label6)
        Panel14.Controls.Add(Label4)
        Panel14.Location = New Point(0, 0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(1024, 53)
        Panel14.TabIndex = 36
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Orange
        Panel11.Location = New Point(267, 19)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(22, 22)
        Panel11.TabIndex = 31
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label14.Location = New Point(295, 19)
        Label14.Name = "Label14"
        Label14.Size = New Size(83, 22)
        Label14.TabIndex = 23
        Label14.Text = "Pending"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Green
        Panel9.Location = New Point(531, 19)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(22, 22)
        Panel9.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(559, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 22)
        Label5.TabIndex = 23
        Label5.Text = "Completed"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(254), CByte(26), CByte(28))
        Panel10.Location = New Point(817, 19)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(22, 22)
        Panel10.TabIndex = 31
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(845, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 22)
        Label6.TabIndex = 23
        Label6.Text = "Cancelled"
        ' 
        ' dgvSummary
        ' 
        dgvSummary.AllowUserToResizeColumns = False
        dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSummary.BackgroundColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        dgvSummary.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSummary.Columns.AddRange(New DataGridViewColumn() {Applied, PatientName, Contact, ServiceType, Sched, Status})
        dgvSummary.GridColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        dgvSummary.Location = New Point(20, 520)
        dgvSummary.Name = "dgvSummary"
        dgvSummary.RowHeadersVisible = False
        dgvSummary.RowHeadersWidth = 51
        dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSummary.Size = New Size(990, 196)
        dgvSummary.TabIndex = 27
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
        ' Contact
        ' 
        Contact.HeaderText = "Contact "
        Contact.MinimumWidth = 6
        Contact.Name = "Contact"
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
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Items.AddRange(New Object() {"Pending", "Completed", "Cancelled"})
        Status.MinimumWidth = 6
        Status.Name = "Status"
        Status.Resizable = DataGridViewTriState.True
        Status.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(232, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 25)
        Label1.TabIndex = 29
        Label1.Text = "Care is just a click away"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(10, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 25)
        Label8.TabIndex = 30
        Label8.Text = "New Appointment"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(10, 481)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 25)
        Label9.TabIndex = 31
        Label9.Text = "Recent"
        ' 
        ' MarkToolStripMenuItem
        ' 
        MarkToolStripMenuItem.Name = "MarkToolStripMenuItem"
        MarkToolStripMenuItem.Size = New Size(115, 24)
        MarkToolStripMenuItem.Text = "Mark "
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(1024, 768)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(dgvSummary)
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
        Panel2.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        CType(dgvSummary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents btnClose As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvSummary As DataGridView
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblCancelled As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents MarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Applied As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents Sched As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
End Class
