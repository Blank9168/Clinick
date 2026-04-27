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
        lblTotalApt = New Label()
        Panel4 = New Panel()
        lblPedApt = New Label()
        Label10 = New Label()
        Panel3 = New Panel()
        lblDenApt = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        lblGenApt = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
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
        PBClinick = New PictureBox()
        btnClose = New Label()
        lblDate = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClinick, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(lblTotalApt)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblUsername)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(290, 566)
        Panel1.TabIndex = 0
        ' 
        ' lblTotalApt
        ' 
        lblTotalApt.AutoSize = True
        lblTotalApt.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalApt.ForeColor = Color.Black
        lblTotalApt.Location = New Point(245, 208)
        lblTotalApt.Margin = New Padding(4, 0, 4, 0)
        lblTotalApt.Name = "lblTotalApt"
        lblTotalApt.Size = New Size(27, 29)
        lblTotalApt.TabIndex = 16
        lblTotalApt.Text = "0"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel4.Controls.Add(lblPedApt)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(4, 412)
        Panel4.Margin = New Padding(4, 4, 4, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(286, 70)
        Panel4.TabIndex = 14
        ' 
        ' lblPedApt
        ' 
        lblPedApt.AutoSize = True
        lblPedApt.Font = New Font("Microsoft Sans Serif", 10.2F)
        lblPedApt.ForeColor = Color.Black
        lblPedApt.Location = New Point(241, 24)
        lblPedApt.Margin = New Padding(4, 0, 4, 0)
        lblPedApt.Name = "lblPedApt"
        lblPedApt.Size = New Size(24, 25)
        lblPedApt.TabIndex = 17
        lblPedApt.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 8F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(14, 25)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 20)
        Label10.TabIndex = 17
        Label10.Text = "Pediatrics:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel3.Controls.Add(lblDenApt)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(4, 330)
        Panel3.Margin = New Padding(4, 4, 4, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(286, 70)
        Panel3.TabIndex = 13
        ' 
        ' lblDenApt
        ' 
        lblDenApt.AutoSize = True
        lblDenApt.Font = New Font("Microsoft Sans Serif", 10.2F)
        lblDenApt.ForeColor = Color.Black
        lblDenApt.Location = New Point(241, 22)
        lblDenApt.Margin = New Padding(4, 0, 4, 0)
        lblDenApt.Name = "lblDenApt"
        lblDenApt.Size = New Size(24, 25)
        lblDenApt.TabIndex = 16
        lblDenApt.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 8F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(14, 22)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 20)
        Label9.TabIndex = 16
        Label9.Text = "Dental Service:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel2.Controls.Add(lblGenApt)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(4, 248)
        Panel2.Margin = New Padding(4, 4, 4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(286, 70)
        Panel2.TabIndex = 12
        ' 
        ' lblGenApt
        ' 
        lblGenApt.AutoSize = True
        lblGenApt.Font = New Font("Microsoft Sans Serif", 10.2F)
        lblGenApt.ForeColor = Color.Black
        lblGenApt.Location = New Point(241, 21)
        lblGenApt.Margin = New Padding(4, 0, 4, 0)
        lblGenApt.Name = "lblGenApt"
        lblGenApt.Size = New Size(24, 25)
        lblGenApt.TabIndex = 15
        lblGenApt.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 8F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(14, 25)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 20)
        Label7.TabIndex = 15
        Label7.Text = "General Consultation:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(16, 272)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(323, 23)
        Label6.TabIndex = 11
        Label6.Text = "Total Appointments"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 8F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(14, 208)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 10
        Label5.Text = "Total Appointments:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label4.Location = New Point(85, 255)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 23)
        Label4.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.a81550e786150a070aea73896e641a21
        PictureBox1.Location = New Point(16, 51)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Microsoft Sans Serif", 8F)
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(115, 115)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(124, 20)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8F)
        Label1.Location = New Point(14, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 6
        Label1.Text = "Welcome!"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Microsoft Sans Serif", 8F)
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(114, 85)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(97, 20)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Employee01"
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 11F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(424, 168)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(554, 82)
        btnGeneralCons.TabIndex = 8
        btnGeneralCons.Text = "General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(192), CByte(228), CByte(231))
        btnDentalS.Font = New Font("Microsoft Sans Serif", 11F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(424, 284)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(554, 82)
        btnDentalS.TabIndex = 9
        btnDentalS.Text = "Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(164), CByte(215), CByte(219))
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 11F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(424, 400)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(554, 82)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' PBGcIcon
        ' 
        PBGcIcon.Location = New Point(339, 184)
        PBGcIcon.Margin = New Padding(4, 4, 4, 4)
        PBGcIcon.Name = "PBGcIcon"
        PBGcIcon.Size = New Size(59, 52)
        PBGcIcon.TabIndex = 11
        PBGcIcon.TabStop = False
        ' 
        ' PBDenIcon
        ' 
        PBDenIcon.Location = New Point(339, 298)
        PBDenIcon.Margin = New Padding(4, 4, 4, 4)
        PBDenIcon.Name = "PBDenIcon"
        PBDenIcon.Size = New Size(59, 52)
        PBDenIcon.TabIndex = 12
        PBDenIcon.TabStop = False
        ' 
        ' PbPdIcon
        ' 
        PbPdIcon.Location = New Point(339, 411)
        PbPdIcon.Margin = New Padding(4, 4, 4, 4)
        PbPdIcon.Name = "PbPdIcon"
        PbPdIcon.Size = New Size(59, 52)
        PbPdIcon.TabIndex = 13
        PbPdIcon.TabStop = False
        ' 
        ' PBLogo
        ' 
        PBLogo.Location = New Point(245, 15)
        PBLogo.Margin = New Padding(4, 4, 4, 4)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(26, 28)
        PBLogo.TabIndex = 14
        PBLogo.TabStop = False
        ' 
        ' PBClinick
        ' 
        PBClinick.Location = New Point(480, 15)
        PBClinick.Margin = New Padding(4, 4, 4, 4)
        PBClinick.Name = "PBClinick"
        PBClinick.Size = New Size(441, 52)
        PBClinick.TabIndex = 15
        PBClinick.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(966, 8)
        btnClose.Margin = New Padding(4, 0, 4, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(45, 31)
        btnClose.TabIndex = 16
        btnClose.Text = "x"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(14, 512)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 25)
        lblDate.TabIndex = 17
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1028, 562)
        Controls.Add(btnClose)
        Controls.Add(PBClinick)
        Controls.Add(PBLogo)
        Controls.Add(PbPdIcon)
        Controls.Add(PBDenIcon)
        Controls.Add(PBGcIcon)
        Controls.Add(btnPediatrics)
        Controls.Add(btnDentalS)
        Controls.Add(btnGeneralCons)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PbPdIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClinick, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalApt As Label
    Friend WithEvents lblPedApt As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDenApt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGenApt As Label
    Friend WithEvents PBGcIcon As PictureBox
    Friend WithEvents PBDenIcon As PictureBox
    Friend WithEvents PbPdIcon As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PBClinick As PictureBox
    Friend WithEvents btnClose As Label
    Friend WithEvents lblDate As Label
End Class
