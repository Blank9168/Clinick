<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeFrm
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
        btnGetStarted = New Button()
        PictureBox1 = New PictureBox()
        btnClose = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGetStarted
        ' 
        btnGetStarted.BackColor = Color.Teal
        btnGetStarted.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGetStarted.ForeColor = Color.White
        btnGetStarted.Location = New Point(390, 625)
        btnGetStarted.Margin = New Padding(2)
        btnGetStarted.Name = "btnGetStarted"
        btnGetStarted.Size = New Size(237, 41)
        btnGetStarted.TabIndex = 7
        btnGetStarted.Text = "Get Started"
        btnGetStarted.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.CLINICKONLY
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.InitialImage = My.Resources.Resources.LOGO_PARA_SA_COMPROG__312_x_282_px_
        PictureBox1.Location = New Point(249, 172)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(518, 448)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Enabled = False
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.Teal
        btnClose.Location = New Point(975, 9)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(37, 26)
        btnClose.TabIndex = 6
        btnClose.Text = "x"
        ' 
        ' WelcomeFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(1024, 768)
        Controls.Add(btnClose)
        Controls.Add(btnGetStarted)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "WelcomeFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGetStarted As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Label
End Class
