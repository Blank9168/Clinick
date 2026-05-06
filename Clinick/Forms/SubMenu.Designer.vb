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
        btnAddAppoint = New Button()
        Panel1.SuspendLayout()
        CType(PicServiceIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnBack.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnBack.Location = New Point(24, 22)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(107, 36)
        btnBack.TabIndex = 1
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        Panel1.Controls.Add(lblServiceType)
        Panel1.Controls.Add(PicServiceIcon)
        Panel1.Location = New Point(38, 165)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(932, 167)
        Panel1.TabIndex = 2
        ' 
        ' lblServiceType
        ' 
        lblServiceType.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServiceType.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        lblServiceType.Location = New Point(422, 67)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(192, 43)
        lblServiceType.TabIndex = 2
        lblServiceType.Text = "Pediatrics"
        lblServiceType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicServiceIcon
        ' 
        PicServiceIcon.Image = My.Resources.Resources.Bear
        PicServiceIcon.Location = New Point(343, 47)
        PicServiceIcon.Name = "PicServiceIcon"
        PicServiceIcon.Size = New Size(85, 77)
        PicServiceIcon.SizeMode = PictureBoxSizeMode.StretchImage
        PicServiceIcon.TabIndex = 3
        PicServiceIcon.TabStop = False
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddPatient.Location = New Point(381, 382)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(287, 59)
        btnAddPatient.TabIndex = 24
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' btnAddAppoint
        ' 
        btnAddAppoint.BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        btnAddAppoint.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddAppoint.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnAddAppoint.Location = New Point(381, 509)
        btnAddAppoint.Name = "btnAddAppoint"
        btnAddAppoint.Size = New Size(287, 59)
        btnAddAppoint.TabIndex = 25
        btnAddAppoint.Text = "Add Appointment"
        btnAddAppoint.UseVisualStyleBackColor = False
        ' 
        ' SubMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(1006, 721)
        Controls.Add(btnAddAppoint)
        Controls.Add(btnBack)
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
    Friend WithEvents btnAddAppoint As Button
End Class
