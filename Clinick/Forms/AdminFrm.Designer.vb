<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFrm
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        LblDate = New Label()
        LblDateTime = New Label()
        lblName = New Label()
        lblWelcome = New Label()
        btnClose = New Label()
        PicLogo = New PictureBox()
        btnLogout = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        lblPending = New Label()
        lblCompleted = New Label()
        lblCancelled = New Label()
        lblTotal = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label3 = New Label()
        Panel5 = New Panel()
        Label7 = New Label()
        Panel6 = New Panel()
        Label8 = New Label()
        Label9 = New Label()
        btnSortSched = New Button()
        btnSortName = New Button()
        cmbFilter = New ComboBox()
        txtSearch = New TextBox()
        dgvAdmin = New DataGridView()
        Applied = New DataGridViewTextBoxColumn()
        PatientName = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        Sched = New DataGridViewTextBoxColumn()
        Status = New DataGridViewComboBoxColumn()
        tmrClock = New Timer(components)
        btnHistory = New Button()
        btnReports = New Button()
        btnMedicalRecords = New Button()
        Panel1.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvAdmin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        Panel1.Controls.Add(LblDate)
        Panel1.Controls.Add(LblDateTime)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblWelcome)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(PicLogo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(896, 60)
        Panel1.TabIndex = 1
        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDate.Location = New Point(523, 23)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(0, 16)
        LblDate.TabIndex = 24
        ' 
        ' LblDateTime
        ' 
        LblDateTime.AutoSize = True
        LblDateTime.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDateTime.Location = New Point(9, 4)
        LblDateTime.Margin = New Padding(2, 0, 2, 0)
        LblDateTime.Name = "LblDateTime"
        LblDateTime.Size = New Size(0, 15)
        LblDateTime.TabIndex = 22
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(259, 20)
        lblName.Name = "lblName"
        lblName.Size = New Size(70, 24)
        lblName.TabIndex = 7
        lblName.Text = "Admin"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(148, 20)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(110, 24)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome, "
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(853, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(31, 21)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' PicLogo
        ' 
        PicLogo.Image = My.Resources.Resources.logo_final__250_x_100_px___1_
        PicLogo.Location = New Point(14, -7)
        PicLogo.Margin = New Padding(3, 2, 3, 2)
        PicLogo.Name = "PicLogo"
        PicLogo.Size = New Size(189, 80)
        PicLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PicLogo.TabIndex = 23
        PicLogo.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnLogout.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnLogout.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnLogout.Location = New Point(791, 67)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(102, 28)
        btnLogout.TabIndex = 30
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(209, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 20)
        Label1.TabIndex = 32
        Label1.Text = "Care is just a click away"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(17, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 20)
        Label2.TabIndex = 31
        Label2.Text = "Dashboard Summary | "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(lblCompleted)
        Panel2.Controls.Add(lblCancelled)
        Panel2.Controls.Add(lblTotal)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(0, 99)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(896, 112)
        Panel2.TabIndex = 38
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPending.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblPending.Location = New Point(270, 62)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(30, 31)
        lblPending.TabIndex = 29
        lblPending.Text = "0"
        ' 
        ' lblCompleted
        ' 
        lblCompleted.AutoSize = True
        lblCompleted.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompleted.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblCompleted.Location = New Point(518, 62)
        lblCompleted.Name = "lblCompleted"
        lblCompleted.Size = New Size(30, 31)
        lblCompleted.TabIndex = 29
        lblCompleted.Text = "0"
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCancelled.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblCancelled.Location = New Point(766, 62)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Size = New Size(30, 31)
        lblCancelled.TabIndex = 29
        lblCancelled.Text = "0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblTotal.Location = New Point(60, 62)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(30, 31)
        lblTotal.TabIndex = 29
        lblTotal.Text = "0"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(896, 40)
        Panel3.TabIndex = 36
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Orange
        Panel4.Location = New Point(234, 14)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(19, 16)
        Panel4.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(258, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 18)
        Label3.TabIndex = 23
        Label3.Text = "Pending"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Green
        Panel5.Location = New Point(465, 14)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(19, 16)
        Panel5.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label7.Location = New Point(489, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 18)
        Label7.TabIndex = 23
        Label7.Text = "Completed"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(254), CByte(26), CByte(28))
        Panel6.Location = New Point(715, 14)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(19, 16)
        Panel6.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(739, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 18)
        Label8.TabIndex = 23
        Label8.Text = "Cancelled"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(51, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 18)
        Label9.TabIndex = 22
        Label9.Text = "Total"
        ' 
        ' btnSortSched
        ' 
        btnSortSched.FlatStyle = FlatStyle.Flat
        btnSortSched.Font = New Font("Segoe UI", 12F)
        btnSortSched.Location = New Point(721, 226)
        btnSortSched.Name = "btnSortSched"
        btnSortSched.Size = New Size(155, 29)
        btnSortSched.TabIndex = 44
        btnSortSched.Text = "Sort by Schedule"
        btnSortSched.UseVisualStyleBackColor = True
        ' 
        ' btnSortName
        ' 
        btnSortName.FlatStyle = FlatStyle.Flat
        btnSortName.Font = New Font("Segoe UI", 12F)
        btnSortName.Location = New Point(558, 226)
        btnSortName.Name = "btnSortName"
        btnSortName.Size = New Size(140, 29)
        btnSortName.TabIndex = 43
        btnSortName.Text = "Sort By Name"
        btnSortName.UseVisualStyleBackColor = True
        ' 
        ' cmbFilter
        ' 
        cmbFilter.Font = New Font("Segoe UI", 12F)
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(378, 225)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(163, 29)
        cmbFilter.TabIndex = 42
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 12F)
        txtSearch.Location = New Point(27, 225)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "     Search by Name or ID"
        txtSearch.Size = New Size(334, 29)
        txtSearch.TabIndex = 41
        ' 
        ' dgvAdmin
        ' 
        dgvAdmin.AllowUserToResizeColumns = False
        dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAdmin.BackgroundColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAdmin.Columns.AddRange(New DataGridViewColumn() {Applied, PatientName, Contact, ServiceType, Sched, Status})
        dgvAdmin.GridColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        dgvAdmin.Location = New Point(189, 270)
        dgvAdmin.Margin = New Padding(3, 2, 3, 2)
        dgvAdmin.Name = "dgvAdmin"
        dgvAdmin.RowHeadersVisible = False
        dgvAdmin.RowHeadersWidth = 51
        dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAdmin.Size = New Size(691, 237)
        dgvAdmin.TabIndex = 39
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
        ' tmrClock
        ' 
        ' 
        ' btnHistory
        ' 
        btnHistory.Location = New Point(27, 284)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(75, 23)
        btnHistory.TabIndex = 45
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(27, 339)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(75, 23)
        btnReports.TabIndex = 46
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnMedicalRecords
        ' 
        btnMedicalRecords.Location = New Point(17, 394)
        btnMedicalRecords.Name = "btnMedicalRecords"
        btnMedicalRecords.Size = New Size(107, 23)
        btnMedicalRecords.TabIndex = 47
        btnMedicalRecords.Text = "Medical Records"
        btnMedicalRecords.UseVisualStyleBackColor = True
        ' 
        ' AdminFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(896, 634)
        Controls.Add(btnMedicalRecords)
        Controls.Add(btnReports)
        Controls.Add(btnHistory)
        Controls.Add(btnSortSched)
        Controls.Add(btnSortName)
        Controls.Add(cmbFilter)
        Controls.Add(txtSearch)
        Controls.Add(dgvAdmin)
        Controls.Add(Panel2)
        Controls.Add(btnLogout)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminFrm"
        Text = "AdminFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDate As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSortSched As Button
    Friend WithEvents btnSortName As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvAdmin As DataGridView
    Friend WithEvents Applied As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents Sched As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents tmrClock As Timer
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnMedicalRecords As Button
End Class
