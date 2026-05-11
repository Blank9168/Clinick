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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeFrm))
        btnGetStarted = New Button()
        btnClose = New Label()
        SuspendLayout()
        ' 
        ' btnGetStarted
        ' 
        btnGetStarted.BackColor = Color.FromArgb(CByte(208), CByte(230), CByte(230))
        btnGetStarted.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGetStarted.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnGetStarted.Location = New Point(347, 437)
        btnGetStarted.Margin = New Padding(2)
        btnGetStarted.Name = "btnGetStarted"
        btnGetStarted.Size = New Size(207, 31)
        btnGetStarted.TabIndex = 7
        btnGetStarted.Text = "Get Started"
        btnGetStarted.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = Color.FromArgb(CByte(179), CByte(225), CByte(222))
        btnClose.Cursor = Cursors.Hand
        btnClose.Enabled = False
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.Teal
        btnClose.Location = New Point(857, 7)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(31, 21)
        btnClose.TabIndex = 6
        btnClose.Text = "x"
        ' 
        ' WelcomeFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(896, 576)
        Controls.Add(btnClose)
        Controls.Add(btnGetStarted)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "WelcomeFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGetStarted As Button
    Friend WithEvents btnClose As Label
End Class
