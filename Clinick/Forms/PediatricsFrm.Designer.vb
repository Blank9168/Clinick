<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PediatricsFrm
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
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(234, 177)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(332, 96)
        btnBack.TabIndex = 1
        btnBack.Text = "Button1"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' PediatricsFrm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Name = "PediatricsFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
End Class
