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
        Panel1 = New Panel()
        lblDate = New Label()
        PictureBox1 = New PictureBox()
        lblName = New Label()
        Label1 = New Label()
        lblUsername = New Label()
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        PBGcIcon = New PictureBox()
        PBDenIcon = New PictureBox()
        PbPdIcon = New PictureBox()
        PBLogo = New PictureBox()
        btnClose = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PBLogo)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblUsername)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 453)
        Panel1.TabIndex = 0
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
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 8F)
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(101, 104)
        lblName.Name = "lblName"
        lblName.Size = New Size(111, 17)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 16)
        Label1.TabIndex = 6
        Label1.Text = "Welcome!"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Microsoft Sans Serif", 8F)
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(101, 78)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(86, 17)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Employee01"
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 11F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(339, 134)
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
        btnDentalS.Font = New Font("Microsoft Sans Serif", 11F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(339, 227)
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
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 11F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(339, 320)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(443, 66)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' PBGcIcon
        ' 
        PBGcIcon.Location = New Point(271, 147)
        PBGcIcon.Name = "PBGcIcon"
        PBGcIcon.Size = New Size(47, 42)
        PBGcIcon.TabIndex = 11
        PBGcIcon.TabStop = False
        ' 
        ' PBDenIcon
        ' 
        PBDenIcon.Location = New Point(271, 238)
        PBDenIcon.Name = "PBDenIcon"
        PBDenIcon.Size = New Size(47, 42)
        PBDenIcon.TabIndex = 12
        PBDenIcon.TabStop = False
        ' 
        ' PbPdIcon
        ' 
        PbPdIcon.Location = New Point(271, 329)
        PbPdIcon.Name = "PbPdIcon"
        PbPdIcon.Size = New Size(47, 42)
        PbPdIcon.TabIndex = 13
        PbPdIcon.TabStop = False
        ' 
        ' PBLogo
        ' 
        PBLogo.Location = New Point(196, 12)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(21, 22)
        PBLogo.TabIndex = 14
        PBLogo.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(773, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(37, 26)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Button1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button1.Location = New Point(12, 333)
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
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Button2.Location = New Point(12, 388)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 42)
        Button2.TabIndex = 18
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 19
        Label2.Text = "TIME"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 205)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(232, 112)
        Panel2.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 16)
        Label3.TabIndex = 21
        Label3.Text = "Total Appointments:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 8F)
        Label4.Location = New Point(14, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 17)
        Label4.TabIndex = 22
        Label4.Text = "General Consultation:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.Location = New Point(14, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 17)
        Label5.TabIndex = 23
        Label5.Text = "Dental Service:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 8F)
        Label6.Location = New Point(14, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 17)
        Label6.TabIndex = 24
        Label6.Text = "Pediatrics:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8F)
        Label7.Location = New Point(196, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(16, 17)
        Label7.TabIndex = 25
        Label7.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 8F)
        Label8.Location = New Point(196, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(16, 17)
        Label8.TabIndex = 26
        Label8.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8F)
        Label9.Location = New Point(196, 76)
        Label9.Name = "Label9"
        Label9.Size = New Size(16, 17)
        Label9.TabIndex = 27
        Label9.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(196, 183)
        Label10.Name = "Label10"
        Label10.Size = New Size(15, 16)
        Label10.TabIndex = 28
        Label10.Text = "0"
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(822, 450)
        Controls.Add(btnClose)
        Controls.Add(PbPdIcon)
        Controls.Add(PBDenIcon)
        Controls.Add(PBGcIcon)
        Controls.Add(btnPediatrics)
        Controls.Add(btnDentalS)
        Controls.Add(btnGeneralCons)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents PBGcIcon As PictureBox
    Friend WithEvents PBDenIcon As PictureBox
    Friend WithEvents PbPdIcon As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents btnClose As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
