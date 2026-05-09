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
        btnBack = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnGeneralCons = New Button()
        btnDentalS = New Button()
        btnPediatrics = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Teal
        btnBack.Cursor = Cursors.Hand
        btnBack.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(34, 17)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(81, 28)
        btnBack.TabIndex = 1
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(34, 60)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(816, 112)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel3.Location = New Point(-3, 53)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(818, 10)
        Panel3.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnGeneralCons)
        Panel2.Controls.Add(btnDentalS)
        Panel2.Controls.Add(btnPediatrics)
        Panel2.Location = New Point(34, 60)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(816, 450)
        Panel2.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Image = My.Resources.Resources.Ipin
        PictureBox2.Location = New Point(331, 229)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Image = My.Resources.Resources.Checklist
        PictureBox3.Location = New Point(22, 230)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 39
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.Bear
        PictureBox1.Location = New Point(639, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' btnGeneralCons
        ' 
        btnGeneralCons.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnGeneralCons.Cursor = Cursors.Hand
        btnGeneralCons.Font = New Font("Microsoft Sans Serif", 10F)
        btnGeneralCons.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGeneralCons.Location = New Point(15, 225)
        btnGeneralCons.Margin = New Padding(2)
        btnGeneralCons.Name = "btnGeneralCons"
        btnGeneralCons.Size = New Size(189, 46)
        btnGeneralCons.TabIndex = 34
        btnGeneralCons.Text = "        General Consultation"
        btnGeneralCons.UseVisualStyleBackColor = False
        ' 
        ' btnDentalS
        ' 
        btnDentalS.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnDentalS.Cursor = Cursors.Hand
        btnDentalS.Font = New Font("Microsoft Sans Serif", 10F)
        btnDentalS.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnDentalS.Location = New Point(312, 225)
        btnDentalS.Margin = New Padding(2)
        btnDentalS.Name = "btnDentalS"
        btnDentalS.Size = New Size(189, 46)
        btnDentalS.TabIndex = 35
        btnDentalS.Text = "        Dental Service"
        btnDentalS.UseVisualStyleBackColor = False
        ' 
        ' btnPediatrics
        ' 
        btnPediatrics.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        btnPediatrics.Cursor = Cursors.Hand
        btnPediatrics.Font = New Font("Microsoft Sans Serif", 10F)
        btnPediatrics.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnPediatrics.Location = New Point(609, 225)
        btnPediatrics.Margin = New Padding(2)
        btnPediatrics.Name = "btnPediatrics"
        btnPediatrics.Size = New Size(189, 46)
        btnPediatrics.TabIndex = 36
        btnPediatrics.Text = "        Pediatrics"
        btnPediatrics.UseVisualStyleBackColor = False
        ' 
        ' SubMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        ClientSize = New Size(881, 541)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SubMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sub Menu"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGeneralCons As Button
    Friend WithEvents btnDentalS As Button
    Friend WithEvents btnPediatrics As Button
End Class
