<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBPedIcon
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
        lblUsername = New Label()
        Label1 = New Label()
        lblName = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label7 = New Label()
        lblGenApt = New Label()
        Label9 = New Label()
        Label10 = New Label()
        lblDenApt = New Label()
        lblPedApt = New Label()
        lblTotalApt = New Label()
        PBGcIcon = New PictureBox()
        PBDenIcon = New PictureBox()
        PictureBox4 = New PictureBox()
        PBLogo = New PictureBox()
        PBClinick = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClinick, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 453)
        Panel1.TabIndex = 0
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(91, 68)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(126, 23)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Employee01"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SansSerif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label1.Location = New Point(11, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 6
        Label1.Text = "Welcome!"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("SansSerif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(92, 92)
        lblName.Name = "lblName"
        lblName.Size = New Size(132, 20)
        lblName.TabIndex = 7
        lblName.Text = "Pepito M. Friend"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.a81550e786150a070aea73896e641a21
        PictureBox1.Location = New Point(13, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("SansSerif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label4.Location = New Point(68, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 9
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        btnGeneralCons.Font = New Font("SansSerif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
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
        btnDentalS.Font = New Font("SansSerif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
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
        btnPediatrics.Font = New Font("SansSerif", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(339, 320)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(443, 66)
        btnPediatrics.TabIndex = 10
        btnPediatrics.Text = "Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("SansSerif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(11, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 20)
        Label5.TabIndex = 10
        Label5.Text = "Total Appointments:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("SansSerif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(13, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 20)
        Label6.TabIndex = 11
        Label6.Text = "Total Appointments"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel2.Controls.Add(lblGenApt)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(3, 198)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(229, 56)
        Panel2.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel3.Controls.Add(lblDenApt)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(3, 264)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(229, 56)
        Panel3.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        Panel4.Controls.Add(lblPedApt)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(3, 330)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(229, 56)
        Panel4.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(11, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 17)
        Label7.TabIndex = 15
        Label7.Text = "General Consultation:"
        ' 
        ' lblGenApt
        ' 
        lblGenApt.AutoSize = True
        lblGenApt.Font = New Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblGenApt.ForeColor = Color.Black
        lblGenApt.Location = New Point(193, 17)
        lblGenApt.Name = "lblGenApt"
        lblGenApt.Size = New Size(21, 23)
        lblGenApt.TabIndex = 15
        lblGenApt.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(11, 18)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 17)
        Label9.TabIndex = 16
        Label9.Text = "Dental Service:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(11, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 17)
        Label10.TabIndex = 17
        Label10.Text = "Pediatrics:"
        ' 
        ' lblDenApt
        ' 
        lblDenApt.AutoSize = True
        lblDenApt.Font = New Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblDenApt.ForeColor = Color.Black
        lblDenApt.Location = New Point(193, 18)
        lblDenApt.Name = "lblDenApt"
        lblDenApt.Size = New Size(21, 23)
        lblDenApt.TabIndex = 16
        lblDenApt.Text = "0"
        ' 
        ' lblPedApt
        ' 
        lblPedApt.AutoSize = True
        lblPedApt.Font = New Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblPedApt.ForeColor = Color.Black
        lblPedApt.Location = New Point(193, 19)
        lblPedApt.Name = "lblPedApt"
        lblPedApt.Size = New Size(21, 23)
        lblPedApt.TabIndex = 17
        lblPedApt.Text = "0"
        ' 
        ' lblTotalApt
        ' 
        lblTotalApt.AutoSize = True
        lblTotalApt.Font = New Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        lblTotalApt.ForeColor = Color.Black
        lblTotalApt.Location = New Point(196, 166)
        lblTotalApt.Name = "lblTotalApt"
        lblTotalApt.Size = New Size(21, 23)
        lblTotalApt.TabIndex = 16
        lblTotalApt.Text = "0"
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
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(271, 329)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(47, 42)
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' PBLogo
        ' 
        PBLogo.Location = New Point(196, 12)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(21, 22)
        PBLogo.TabIndex = 14
        PBLogo.TabStop = False
        ' 
        ' PBClinick
        ' 
        PBClinick.Location = New Point(384, 12)
        PBClinick.Name = "PBClinick"
        PBClinick.Size = New Size(353, 42)
        PBClinick.TabIndex = 15
        PBClinick.TabStop = False
        ' 
        ' PBPedIcon
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(822, 450)
        Controls.Add(PBClinick)
        Controls.Add(PBLogo)
        Controls.Add(PictureBox4)
        Controls.Add(PBDenIcon)
        Controls.Add(PBGcIcon)
        Controls.Add(btnPediatrics)
        Controls.Add(btnDentalS)
        Controls.Add(btnGeneralCons)
        Controls.Add(Panel1)
        Name = "PBPedIcon"
        Text = "MainFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PBGcIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDenIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClinick, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents PBClinick As PictureBox
End Class
