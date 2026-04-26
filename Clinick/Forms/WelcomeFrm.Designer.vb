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
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(391, 18)
        btnClose.Margin = New Padding(4, 0, 4, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(36, 40)
        btnClose.TabIndex = 6
        btnClose.Text = "X"
        ' 
        ' btnGetStarted
        ' 
        btnGetStarted.Location = New Point(60, 459)
        btnGetStarted.Name = "btnGetStarted"
        btnGetStarted.Size = New Size(337, 62)
        btnGetStarted.TabIndex = 7
        btnGetStarted.Text = "GET STARTED"
        btnGetStarted.UseVisualStyleBackColor = True
        ' 
        ' WelcomeFrm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 600)
        Controls.Add(btnGetStarted)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "WelcomeFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnClose As Label
    Friend WithEvents btnGetStarted As Button
End Class
