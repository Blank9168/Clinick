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
        btnLogout = New Button()
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
        lblTotal = New Label()
        Label5 = New Label()
        Panel7 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel8 = New Panel()
        Panel15 = New Panel()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        Panel11 = New Panel()
        PictureBox5 = New PictureBox()
        Label11 = New Label()
        lblPending = New Label()
        Label10 = New Label()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel14 = New Panel()
        Panel16 = New Panel()
        Panel2 = New Panel()
        PictureBox6 = New PictureBox()
        Label4 = New Label()
        lblCompleted = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel17 = New Panel()
        PictureBox7 = New PictureBox()
        Label13 = New Label()
        lblCancelled = New Label()
        Label15 = New Label()
        Panel18 = New Panel()
        Panel19 = New Panel()
        Panel20 = New Panel()
        Panel21 = New Panel()
        PicLogo = New PictureBox()
        btnClose = New Label()
        lblWelcome = New Label()
        lblName = New Label()
        LblDateTime = New Label()
        LblDate = New Label()
        Panel1 = New Panel()
        Panel22 = New Panel()
        Panel23 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnEditPatient = New Button()
        CType(dgvSummary, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        Panel15.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel17.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel18.SuspendLayout()
        Panel19.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel23.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnGeneralCons.Cursor = Cursors.Hand
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(69, 52)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(189, 46)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "        General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnDentalS.Cursor = Cursors.Hand
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(366, 52)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(189, 46)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "        Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnPediatrics.Cursor = Cursors.Hand
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(663, 52)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(189, 46)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "        Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnLogout.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnLogout.Location = New Point(776, 77)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(96, 28)
        btnLogout.TabIndex = 18
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(19, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 20)
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
        dgvSummary.Location = New Point(38, 302)
        dgvSummary.Margin = New Padding(3, 2, 3, 2)
        dgvSummary.Name = "dgvSummary"
        dgvSummary.RowHeadersVisible = False
        dgvSummary.RowHeadersWidth = 51
        dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSummary.Size = New Size(824, 288)
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
        Label1.Location = New Point(136, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 20)
        Label1.TabIndex = 29
        Label1.Text = "Care is just a click away"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label8.Location = New Point(19, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(150, 20)
        Label8.TabIndex = 30
        Label8.Text = "New Appointment"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label9.Location = New Point(32, 270)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 20)
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
        txtSearch.Font = New Font("Microsoft Sans Serif", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        txtSearch.Location = New Point(42, 237)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "     Search by Name or ID"
        txtSearch.Size = New Size(268, 23)
        txtSearch.TabIndex = 32
        ' 
        ' cmbFilter
        ' 
        cmbFilter.Font = New Font("Microsoft Sans Serif", 10F)
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(316, 236)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(148, 24)
        cmbFilter.TabIndex = 35
        ' 
        ' btnSortName
        ' 
        btnSortName.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnSortName.Cursor = Cursors.Hand
        btnSortName.Font = New Font("Microsoft Sans Serif", 10F)
        btnSortName.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnSortName.Location = New Point(470, 230)
        btnSortName.Name = "btnSortName"
        btnSortName.Size = New Size(140, 30)
        btnSortName.TabIndex = 37
        btnSortName.Text = "Sort by Name"
        btnSortName.UseVisualStyleBackColor = False
        ' 
        ' btnSortSched
        ' 
        btnSortSched.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnSortSched.Cursor = Cursors.Hand
        btnSortSched.Font = New Font("Microsoft Sans Serif", 10F)
        btnSortSched.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnSortSched.Location = New Point(616, 230)
        btnSortSched.Name = "btnSortSched"
        btnSortSched.Size = New Size(140, 30)
        btnSortSched.TabIndex = 38
        btnSortSched.Text = "Sort by Schedule"
        btnSortSched.UseVisualStyleBackColor = False
        ' 
        ' tmrClock
        ' 
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.Black
        lblTotal.Location = New Point(55, 48)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(30, 31)
        lblTotal.TabIndex = 29
        lblTotal.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label5.Location = New Point(55, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 18)
        Label5.TabIndex = 22
        Label5.Text = "Total"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Panel7.Controls.Add(Panel9)
        Panel7.Controls.Add(Panel8)
        Panel7.ForeColor = SystemColors.ControlDarkDark
        Panel7.Location = New Point(46, 135)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(13, 77)
        Panel7.TabIndex = 40
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Panel10)
        Panel9.Location = New Point(23, 0)
        Panel9.Margin = New Padding(3, 2, 3, 2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(145, 94)
        Panel9.TabIndex = 42
        ' 
        ' Panel10
        ' 
        Panel10.Location = New Point(23, 0)
        Panel10.Margin = New Padding(3, 2, 3, 2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(164, 94)
        Panel10.TabIndex = 41
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(23, 0)
        Panel8.Margin = New Padding(3, 2, 3, 2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(164, 94)
        Panel8.TabIndex = 41
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.White
        Panel15.Controls.Add(PictureBox4)
        Panel15.Controls.Add(Label5)
        Panel15.Controls.Add(lblTotal)
        Panel15.Controls.Add(Label6)
        Panel15.ForeColor = SystemColors.ControlDarkDark
        Panel15.Location = New Point(61, 124)
        Panel15.Margin = New Padding(3, 2, 3, 2)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(169, 88)
        Panel15.TabIndex = 44
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.BackgroundImageLayout = ImageLayout.Center
        'PictureBox4.Image = My.Resources.Resources.papel
        PictureBox4.Location = New Point(12, 25)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 34
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label6.Location = New Point(55, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 18)
        Label6.TabIndex = 23
        Label6.Text = "Appointments"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(PictureBox5)
        Panel11.Controls.Add(Label11)
        Panel11.Controls.Add(lblPending)
        Panel11.Controls.Add(Label10)
        Panel11.ForeColor = SystemColors.ControlDarkDark
        Panel11.Location = New Point(278, 124)
        Panel11.Margin = New Padding(3, 2, 3, 2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(169, 88)
        Panel11.TabIndex = 46
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.BackgroundImageLayout = ImageLayout.Center
        PictureBox5.Image = My.Resources.Resources.hourglass
        PictureBox5.Location = New Point(7, 25)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(38, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 35
        PictureBox5.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label11.Location = New Point(54, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 18)
        Label11.TabIndex = 22
        Label11.Text = "Pending"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPending.ForeColor = Color.Black
        lblPending.Location = New Point(51, 48)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(30, 31)
        lblPending.TabIndex = 29
        lblPending.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label10.Location = New Point(54, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 18)
        Label10.TabIndex = 23
        Label10.Text = "Appointments"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Orange
        Panel12.Controls.Add(Panel13)
        Panel12.Controls.Add(Panel16)
        Panel12.ForeColor = SystemColors.ControlDarkDark
        Panel12.Location = New Point(262, 135)
        Panel12.Margin = New Padding(3, 2, 3, 2)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(13, 77)
        Panel12.TabIndex = 45
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(Panel14)
        Panel13.Location = New Point(23, 0)
        Panel13.Margin = New Padding(3, 2, 3, 2)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(145, 94)
        Panel13.TabIndex = 42
        ' 
        ' Panel14
        ' 
        Panel14.Location = New Point(23, 0)
        Panel14.Margin = New Padding(3, 2, 3, 2)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(164, 94)
        Panel14.TabIndex = 41
        ' 
        ' Panel16
        ' 
        Panel16.Location = New Point(23, 0)
        Panel16.Margin = New Padding(3, 2, 3, 2)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(164, 94)
        Panel16.TabIndex = 41
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(lblCompleted)
        Panel2.Controls.Add(Label3)
        Panel2.ForeColor = SystemColors.ControlDarkDark
        Panel2.Location = New Point(489, 124)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(169, 88)
        Panel2.TabIndex = 48
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.BackgroundImageLayout = ImageLayout.Center
        PictureBox6.Image = My.Resources.Resources.check
        PictureBox6.Location = New Point(7, 25)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(38, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 36
        PictureBox6.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label4.Location = New Point(51, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 18)
        Label4.TabIndex = 22
        Label4.Text = "Completed"
        ' 
        ' lblCompleted
        ' 
        lblCompleted.AutoSize = True
        lblCompleted.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompleted.ForeColor = Color.Black
        lblCompleted.Location = New Point(51, 48)
        lblCompleted.Name = "lblCompleted"
        lblCompleted.Size = New Size(30, 31)
        lblCompleted.TabIndex = 29
        lblCompleted.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label3.Location = New Point(51, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 18)
        Label3.TabIndex = 23
        Label3.Text = "Appointments"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.YellowGreen
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Panel6)
        Panel3.ForeColor = SystemColors.ControlDarkDark
        Panel3.Location = New Point(473, 135)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(13, 77)
        Panel3.TabIndex = 47
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(23, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(145, 94)
        Panel4.TabIndex = 42
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(23, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(164, 94)
        Panel5.TabIndex = 41
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(23, 0)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(164, 94)
        Panel6.TabIndex = 41
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.White
        Panel17.Controls.Add(PictureBox7)
        Panel17.Controls.Add(Label13)
        Panel17.Controls.Add(lblCancelled)
        Panel17.Controls.Add(Label15)
        Panel17.ForeColor = SystemColors.ControlDarkDark
        Panel17.Location = New Point(694, 124)
        Panel17.Margin = New Padding(3, 2, 3, 2)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(169, 88)
        Panel17.TabIndex = 50
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.BackgroundImageLayout = ImageLayout.Center
        PictureBox7.Image = My.Resources.Resources.ekis
        PictureBox7.Location = New Point(10, 26)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(40, 39)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 37
        PictureBox7.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label13.Location = New Point(56, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(82, 18)
        Label13.TabIndex = 22
        Label13.Text = "Cancelled"
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCancelled.ForeColor = Color.Black
        lblCancelled.Location = New Point(53, 49)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Size = New Size(30, 31)
        lblCancelled.TabIndex = 29
        lblCancelled.Text = "0"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label15.Location = New Point(56, 27)
        Label15.Name = "Label15"
        Label15.Size = New Size(110, 18)
        Label15.TabIndex = 23
        Label15.Text = "Appointments"
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.Red
        Panel18.Controls.Add(Panel19)
        Panel18.Controls.Add(Panel21)
        Panel18.ForeColor = SystemColors.ControlDarkDark
        Panel18.Location = New Point(678, 135)
        Panel18.Margin = New Padding(3, 2, 3, 2)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(13, 77)
        Panel18.TabIndex = 49
        ' 
        ' Panel19
        ' 
        Panel19.Controls.Add(Panel20)
        Panel19.Location = New Point(23, 0)
        Panel19.Margin = New Padding(3, 2, 3, 2)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(145, 94)
        Panel19.TabIndex = 42
        ' 
        ' Panel20
        ' 
        Panel20.Location = New Point(23, 0)
        Panel20.Margin = New Padding(3, 2, 3, 2)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(164, 94)
        Panel20.TabIndex = 41
        ' 
        ' Panel21
        ' 
        Panel21.Location = New Point(23, 0)
        Panel21.Margin = New Padding(3, 2, 3, 2)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(164, 94)
        Panel21.TabIndex = 41
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
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnClose.Location = New Point(853, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(31, 21)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(141, 20)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(110, 24)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome, "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(252, 20)
        lblName.Name = "lblName"
        lblName.Size = New Size(171, 24)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend!"
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
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDate.Location = New Point(523, 23)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(0, 16)
        LblDate.TabIndex = 24
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
        Panel1.TabIndex = 0
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        Panel22.Location = New Point(107, 277)
        Panel22.Margin = New Padding(3, 2, 3, 2)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(756, 8)
        Panel22.TabIndex = 51
        ' 
        ' Panel23
        ' 
        Panel23.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        Panel23.Controls.Add(PictureBox2)
        Panel23.Controls.Add(PictureBox3)
        Panel23.Controls.Add(PictureBox1)
        Panel23.Controls.Add(Label8)
        Panel23.Controls.Add(btnGeneralCons)
        Panel23.Controls.Add(btnDentalS)
        Panel23.Controls.Add(btnPediatrics)
        Panel23.Location = New Point(0, 610)
        Panel23.Margin = New Padding(3, 2, 3, 2)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(896, 131)
        Panel23.TabIndex = 52
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Image = My.Resources.Resources.Ipin
        PictureBox2.Location = New Point(385, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Image = My.Resources.Resources.Checklist
        PictureBox3.Location = New Point(76, 57)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.Bear
        PictureBox1.Location = New Point(693, 57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' btnEditPatient
        ' 
        btnEditPatient.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnEditPatient.Cursor = Cursors.Hand
        btnEditPatient.Font = New Font("Microsoft Sans Serif", 10F)
        btnEditPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnEditPatient.Location = New Point(762, 230)
        btnEditPatient.Name = "btnEditPatient"
        btnEditPatient.Size = New Size(100, 30)
        btnEditPatient.TabIndex = 53
        btnEditPatient.Text = "Edit Patient"
        btnEditPatient.UseVisualStyleBackColor = False
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(896, 740)
        Controls.Add(btnEditPatient)
        Controls.Add(Label9)
        Controls.Add(Panel17)
        Controls.Add(Panel18)
        Controls.Add(Panel2)
        Controls.Add(Panel11)
        Controls.Add(Panel3)
        Controls.Add(Panel12)
        Controls.Add(Panel15)
        Controls.Add(Panel7)
        Controls.Add(btnSortSched)
        Controls.Add(btnSortName)
        Controls.Add(cmbFilter)
        Controls.Add(txtSearch)
        Controls.Add(btnLogout)
        Controls.Add(Label1)
        Controls.Add(dgvSummary)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Panel22)
        Controls.Add(Panel23)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        CType(dgvSummary, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel12.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel18.ResumeLayout(False)
        Panel19.ResumeLayout(False)
        CType(PicLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel23.ResumeLayout(False)
        Panel23.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSummary As DataGridView
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
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lblPending As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents btnClose As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEditPatient As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
