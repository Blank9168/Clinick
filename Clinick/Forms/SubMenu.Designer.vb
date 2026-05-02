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
        lblServiceType = New Label()
        PicServiceIcon = New PictureBox()
        btnAddPatient = New Button()
        btnAppointPatient = New Button()
        Panel1.SuspendLayout()
        CType(PicServiceIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnBack.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(107, 36)
        btnBack.TabIndex = 1
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(lblServiceType)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(PicServiceIcon)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1006, 228)
        Panel1.TabIndex = 2
        ' 
        ' lblServiceType
        ' 
        lblServiceType.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServiceType.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblServiceType.Location = New Point(422, 98)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(192, 42)
        lblServiceType.TabIndex = 2
        lblServiceType.Text = "Pediatrics"
        lblServiceType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicServiceIcon
        ' 
        PicServiceIcon.Image = My.Resources.Resources.Bear
        PicServiceIcon.Location = New Point(343, 79)
        PicServiceIcon.Name = "PicServiceIcon"
        PicServiceIcon.Size = New Size(84, 77)
        PicServiceIcon.SizeMode = PictureBoxSizeMode.StretchImage
        PicServiceIcon.TabIndex = 3
        PicServiceIcon.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddPatient.Location = New Point(244, 331)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(549, 115)
        btnAddPatient.TabIndex = 24
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' btnAppointPatient
        ' 
        btnAppointPatient.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnAppointPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAppointPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAppointPatient.Location = New Point(244, 519)
        btnAppointPatient.Name = "btnAppointPatient"
        btnAppointPatient.Size = New Size(549, 115)
        btnAppointPatient.TabIndex = 25
        btnAppointPatient.Text = "Appoint Patient"
        btnAppointPatient.UseVisualStyleBackColor = False
        ' 
        ' SubMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(1006, 721)
        Controls.Add(btnAppointPatient)
        Controls.Add(btnAddPatient)
        Controls.Add(Panel1)
        Name = "SubMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sub Menu"
        Panel1.ResumeLayout(False)
        CType(PicServiceIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblServiceType As Label
    Friend WithEvents PicServiceIcon As PictureBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents btnAppointPatient As Button
End Class
