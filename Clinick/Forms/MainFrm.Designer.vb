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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        btnClose = New Label()
        lblWelcome = New Label()
        lblName = New Label()
        btnLogout = New Button()
        LblDateTime = New Label()
        Panel1 = New Panel()
        LblDate = New Label()
        PicLogo = New PictureBox()
        Label2 = New Label()
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
        txtSearch = New TextBox()
        cmbFilter = New ComboBox()
        btnSortName = New Button()
        btnSortSched = New Button()
        tmrClock = New Timer(components)
        Panel1.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSummary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 12F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(46, 820)
        btnGeneralCons.Margin = New Padding(2, 3, 2, 3)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(287, 95)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnDentalS.Font = New Font("Microsoft Sans Serif", 12F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(378, 820)
        btnDentalS.Margin = New Padding(2, 3, 2, 3)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(287, 95)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 12F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(712, 820)
        btnPediatrics.Margin = New Padding(2, 3, 2, 3)
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
        lblWelcome.Location = New Point(169, 27)
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
        lblName.Location = New Point(296, 27)
        lblName.Name = "lblName"
        lblName.Size = New Size(214, 29)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend!"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnLogout.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnLogout.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnLogout.Location = New Point(897, 95)
        btnLogout.Margin = New Padding(2, 3, 2, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(117, 37)
        btnLogout.TabIndex = 18
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' LblDateTime
        ' 
        LblDateTime.AutoSize = True
        LblDateTime.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDateTime.Location = New Point(10, 5)
        LblDateTime.Margin = New Padding(2, 0, 2, 0)
        LblDateTime.Name = "LblDateTime"
        LblDateTime.Size = New Size(0, 18)
        LblDateTime.TabIndex = 22
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
        PicLogo.Size = New Size(216, 107)
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
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 24
        Label2.Text = "Dashboard  | "
        ' 
        ' dgvSummary
        ' 
        dgvSummary.AllowUserToResizeColumns = False
        dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSummary.BackgroundColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
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
        dgvSummary.Location = New Point(16, 268)
        dgvSummary.Name = "dgvSummary"
        dgvSummary.RowHeadersVisible = False
        dgvSummary.RowHeadersWidth = 51
        dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSummary.Size = New Size(990, 479)
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
        Label1.Location = New Point(154, 99)
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
        Label8.Location = New Point(14, 773)
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
        Label9.Location = New Point(8, 239)
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
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Microsoft Sans Serif", 12F)
        txtSearch.Location = New Point(21, 172)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "     Search by Name or ID"
        txtSearch.Size = New Size(381, 30)
        txtSearch.TabIndex = 32
        ' 
        ' cmbFilter
        ' 
        cmbFilter.Font = New Font("Microsoft Sans Serif", 12F)
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(431, 171)
        cmbFilter.Margin = New Padding(3, 4, 3, 4)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(186, 33)
        cmbFilter.TabIndex = 35
        ' 
        ' btnSortName
        ' 
        btnSortName.FlatStyle = FlatStyle.Flat
        btnSortName.Font = New Font("Microsoft Sans Serif", 12F)
        btnSortName.Location = New Point(637, 172)
        btnSortName.Margin = New Padding(3, 4, 3, 4)
        btnSortName.Name = "btnSortName"
        btnSortName.Size = New Size(160, 39)
        btnSortName.TabIndex = 37
        btnSortName.Text = "Sort By Name"
        btnSortName.UseVisualStyleBackColor = True
        ' 
        ' btnSortSched
        ' 
        btnSortSched.FlatStyle = FlatStyle.Flat
        btnSortSched.Font = New Font("Microsoft Sans Serif", 12F)
        btnSortSched.Location = New Point(823, 172)
        btnSortSched.Margin = New Padding(3, 4, 3, 4)
        btnSortSched.Name = "btnSortSched"
        btnSortSched.Size = New Size(177, 39)
        btnSortSched.TabIndex = 38
        btnSortSched.Text = "Sort by Schedule"
        btnSortSched.UseVisualStyleBackColor = True
        ' 
        ' tmrClock
        ' 
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(1024, 987)
        Controls.Add(btnSortSched)
        Controls.Add(btnSortName)
        Controls.Add(cmbFilter)
        Controls.Add(txtSearch)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(btnLogout)
        Controls.Add(Label1)
        Controls.Add(dgvSummary)
        Controls.Add(Label2)
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
    Friend WithEvents btnLogout As Button
    Friend WithEvents LblDateTime As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSummary As DataGridView
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents LblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Applied As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents Sched As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnSortName As Button
    Friend WithEvents btnSortSched As Button
    Friend WithEvents tmrClock As Timer
End Class
