<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubMenu))
        btnBack = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnGeneralCons = New Button()
        PictureBox1 = New PictureBox()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.Teal
        btnBack.Location = New Point(24, 11)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 37)
        btnBack.TabIndex = 1
        btnBack.Text = "       Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(197), CByte(229), CByte(232))
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(107, 64)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(696, 111)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkSlateGray
        Label5.Location = New Point(122, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(207, 40)
        Label5.TabIndex = 41
        Label5.Text = "DEPARTMENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(125, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 28)
        Label1.TabIndex = 40
        Label1.Text = "Select Consultation Type"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(btnGeneralCons)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnDentalS)
        Panel2.Controls.Add(btnPediatrics)
        Panel2.Location = New Point(107, 64)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(696, 430)
        Panel2.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label2.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkSlateGray
        Label2.Location = New Point(194, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 26)
        Label2.TabIndex = 40
        Label2.Text = "Book a general health consultation " & vbCrLf & "with our medical professionals " & vbCrLf
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Image = My.Resources.Resources.Checklist
        PictureBox3.Location = New Point(140, 149)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 39
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Image = My.Resources.Resources.Ipin
        PictureBox2.Location = New Point(140, 247)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnGeneralCons.Cursor = Cursors.Hand
        btnGeneralCons.FlatStyle = FlatStyle.Flat
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10F)
        btnGeneralCons.ForeColor = Color.LightSeaGreen
        btnGeneralCons.Location = New Point(125, 134)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(415, 76)
        btnGeneralCons.TabIndex = 34
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.Bear
        PictureBox1.Location = New Point(140, 335)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnDentalS.Cursor = Cursors.Hand
        btnDentalS.FlatStyle = FlatStyle.Flat
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10F)
        btnDentalS.ForeColor = Color.LightSeaGreen
        btnDentalS.Location = New Point(125, 224)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(415, 76)
        btnDentalS.TabIndex = 35
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnPediatrics.Cursor = Cursors.Hand
        btnPediatrics.FlatStyle = FlatStyle.Flat
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10F)
        btnPediatrics.ForeColor = Color.LightSeaGreen
        btnPediatrics.Location = New Point(125, 315)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(415, 76)
        btnPediatrics.TabIndex = 36
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(188, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 25)
        Label6.TabIndex = 43
        Label6.Text = "General Consultation"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(193, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(139, 25)
        Label7.TabIndex = 44
        Label7.Text = "Dental Service"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label8.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkSlateGray
        Label8.Location = New Point(197, 262)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 26)
        Label8.TabIndex = 45
        Label8.Text = "Schedule an appointment" & vbCrLf & "with our dentist" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(193, 326)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 46
        Label3.Text = "Pediatrics"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Label9.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkSlateGray
        Label9.Location = New Point(197, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(166, 26)
        Label9.TabIndex = 47
        Label9.Text = "Expert care for children's health" & vbCrLf & "and development" & vbCrLf
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox4.BackgroundImage = My.Resources.Resources.Iconsss__6_
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(503, 161)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(16, 26)
        PictureBox4.TabIndex = 48
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox5.BackgroundImage = My.Resources.Resources.Iconsss__6_
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(503, 249)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(16, 26)
        PictureBox5.TabIndex = 49
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox6.BackgroundImage = My.Resources.Resources.Iconsss__6_
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(503, 341)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(16, 26)
        PictureBox6.TabIndex = 50
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(252))
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(36, 16)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 26)
        PictureBox7.TabIndex = 51
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = My.Resources.Resources.Iconsss__8_
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Location = New Point(23, 17)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(91, 75)
        PictureBox8.TabIndex = 42
        PictureBox8.TabStop = False
        ' 
        ' SubMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(250), CByte(252))
        ClientSize = New Size(881, 541)
        Controls.Add(PictureBox7)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "SubMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sub Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
