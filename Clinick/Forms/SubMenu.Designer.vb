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
        btnAddPatient = New Button()
        btnAddAppoint = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Teal
        btnBack.Cursor = Cursors.Hand
        btnBack.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(24, 22)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(107, 36)
        btnBack.TabIndex = 1
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lblServiceType)
        Panel1.Location = New Point(38, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(932, 149)
        Panel1.TabIndex = 2
        ' 
        ' lblServiceType
        ' 
        lblServiceType.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServiceType.ForeColor = Color.White
        lblServiceType.Location = New Point(41, 59)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(192, 43)
        lblServiceType.TabIndex = 2
        lblServiceType.Text = "Pediatrics"
        lblServiceType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAddPatient
        ' 
        btnAddPatient.BackColor = Color.Teal
        btnAddPatient.Cursor = Cursors.Hand
        btnAddPatient.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPatient.ForeColor = Color.White
        btnAddPatient.Location = New Point(441, 271)
        btnAddPatient.Name = "btnAddPatient"
        btnAddPatient.Size = New Size(435, 60)
        btnAddPatient.TabIndex = 24
        btnAddPatient.Text = "Add Patient"
        btnAddPatient.UseVisualStyleBackColor = False
        ' 
        ' btnAddAppoint
        ' 
        btnAddAppoint.BackColor = Color.Teal
        btnAddAppoint.Cursor = Cursors.Hand
        btnAddAppoint.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddAppoint.ForeColor = Color.White
        btnAddAppoint.Location = New Point(441, 412)
        btnAddAppoint.Name = "btnAddAppoint"
        btnAddAppoint.Size = New Size(435, 60)
        btnAddAppoint.TabIndex = 25
        btnAddAppoint.Text = "Add Appointment"
        btnAddAppoint.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel2.Controls.Add(btnAddAppoint)
        Panel2.Controls.Add(btnAddPatient)
        Panel2.Location = New Point(38, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(932, 600)
        Panel2.TabIndex = 26
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel3.Location = New Point(239, 77)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(693, 7)
        Panel3.TabIndex = 3
        ' 
        ' SubMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        ClientSize = New Size(1006, 721)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "SubMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sub Menu"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblServiceType As Label
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents btnAddAppoint As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
