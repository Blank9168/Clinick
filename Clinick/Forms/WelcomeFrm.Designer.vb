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
        btnClose = New Label()
        btnGetStarted = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.FromArgb(CByte(120), CByte(169), CByte(176))
        btnClose.Location = New Point(369, 9)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(25, 27)
        btnClose.TabIndex = 6
        btnClose.Text = "x"
        ' 
        ' btnGetStarted
        ' 
        btnGetStarted.BackColor = Color.FromArgb(CByte(180), CByte(217), CByte(222))
        btnGetStarted.Font = New Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(2))
        btnGetStarted.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.Location = New Point(61, 377)
        btnGetStarted.Margin = New Padding(2, 2, 2, 2)
        btnGetStarted.Name = "btnGetStarted"
        btnGetStarted.Size = New Size(270, 44)
        btnGetStarted.TabIndex = 7
        btnGetStarted.Text = "Get Started"
        btnGetStarted.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(43, 187)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(312, 106)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' WelcomeFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        ClientSize = New Size(406, 536)
        Controls.Add(PictureBox1)
        Controls.Add(btnGetStarted)
        Controls.Add(btnClose)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "WelcomeFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClose As Label
    Friend WithEvents btnGetStarted As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
