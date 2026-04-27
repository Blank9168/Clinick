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
        PBGcIcon = New PictureBox()
        PBDenIcon = New PictureBox()
        PbPdIcon = New PictureBox()
        btnClose = New Label()
        lblUsername = New Label()
        Label1 = New Label()
        lblName = New Label()
        PictureBox1 = New PictureBox()
        lblDate = New Label()
        PBLogo = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        lblDenApt = New Label()
        lblPedApt = New Label()
        lblGenApt = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        LblDateTime = New Label()
        lblTotal = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(348, 205)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(443, 66)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(192), CByte(228), CByte(231))
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(348, 297)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(443, 66)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(164), CByte(215), CByte(219))
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(348, 389)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(443, 66)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' PBGcIcon
        ' 
        PBGcIcon.Location = New Point(282, 217)
        PBGcIcon.Name = "PBGcIcon"
        PBGcIcon.Size = New Size(47, 42)
        PBGcIcon.TabIndex = 11
        PBGcIcon.TabStop = False
        ' 
        ' PBDenIcon
        ' 
        PBDenIcon.Location = New Point(282, 309)
        PBDenIcon.Name = "PBDenIcon"
        PBDenIcon.Size = New Size(47, 42)
        PBDenIcon.TabIndex = 12
        PBDenIcon.TabStop = False
        ' 
        ' PbPdIcon
        ' 
        PbPdIcon.Location = New Point(282, 401)
        PbPdIcon.Name = "PbPdIcon"
        PbPdIcon.Size = New Size(47, 42)
        PbPdIcon.TabIndex = 13
        PbPdIcon.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(790, 6)
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
        lblUsername.Location = New Point(101, 78)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(90, 18)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Employee01"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 49)
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
        lblName.Location = New Point(101, 104)
        lblName.Name = "lblName"
        lblName.Size = New Size(116, 18)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.a81550e786150a070aea73896e641a21
        PictureBox1.Location = New Point(22, 78)
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
        ' PBLogo
        ' 
        PBLogo.Location = New Point(532, 86)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(67, 62)
        PBLogo.TabIndex = 14
        PBLogo.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Button1.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button1.Location = New Point(15, 361)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 42)
        Button1.TabIndex = 17
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Button2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(15, 471)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 42)
        Button2.TabIndex = 18
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel2.Controls.Add(lblDenApt)
        Panel2.Controls.Add(lblPedApt)
        Panel2.Controls.Add(lblGenApt)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 231)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(239, 112)
        Panel2.TabIndex = 20
        ' 
        ' lblDenApt
        ' 
        lblDenApt.AutoSize = True
        lblDenApt.Font = New Font("Microsoft Sans Serif", 9F)
        lblDenApt.Location = New Point(196, 49)
        lblDenApt.Name = "lblDenApt"
        lblDenApt.Size = New Size(16, 18)
        lblDenApt.TabIndex = 28
        lblDenApt.Text = "0"
        ' 
        ' lblPedApt
        ' 
        lblPedApt.AutoSize = True
        lblPedApt.Font = New Font("Microsoft Sans Serif", 9F)
        lblPedApt.Location = New Point(196, 76)
        lblPedApt.Name = "lblPedApt"
        lblPedApt.Size = New Size(16, 18)
        lblPedApt.TabIndex = 27
        lblPedApt.Text = "0"
        ' 
        ' lblGenApt
        ' 
        lblGenApt.AutoSize = True
        lblGenApt.Font = New Font("Microsoft Sans Serif", 9F)
        lblGenApt.Location = New Point(196, 22)
        lblGenApt.Name = "lblGenApt"
        lblGenApt.Size = New Size(16, 18)
        lblGenApt.TabIndex = 25
        lblGenApt.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9F)
        Label6.Location = New Point(14, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 18)
        Label6.TabIndex = 24
        Label6.Text = "Pediatrics:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9F)
        Label5.Location = New Point(14, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 18)
        Label5.TabIndex = 23
        Label5.Text = "Dental Service:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9F)
        Label4.Location = New Point(14, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 18)
        Label4.TabIndex = 22
        Label4.Text = "General Consultation:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 18)
        Label3.TabIndex = 21
        Label3.Text = "Total Appointments:"
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
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(195, 205)
        lblTotal.Margin = New Padding(2, 0, 2, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(17, 18)
        lblTotal.TabIndex = 23
        lblTotal.Text = "0"
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblTotal)
        Panel1.Controls.Add(LblDateTime)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblUsername)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(239, 537)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 18)
        Label2.TabIndex = 24
        Label2.Text = "TIME"
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(830, 537)
        Controls.Add(btnClose)
        Controls.Add(PbPdIcon)
        Controls.Add(PBDenIcon)
        Controls.Add(PBGcIcon)
        Controls.Add(btnPediatrics)
        Controls.Add(btnDentalS)
        Controls.Add(btnGeneralCons)
        Controls.Add(PBLogo)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        CType(PBGcIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents PBGcIcon As PictureBox
    Friend WithEvents PBDenIcon As PictureBox
    Friend WithEvents PbPdIcon As PictureBox
    Friend WithEvents btnClose As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDenApt As Label
    Friend WithEvents lblPedApt As Label
    Friend WithEvents lblGenApt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
