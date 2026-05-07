<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnClose = New Label()
        PictureBox1 = New PictureBox()
        cbShowPass = New CheckBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Teal
        btnLogin.Font = New Font("Microsoft Sans Serif", 10F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(340, 583)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(237, 41)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Microsoft Sans Serif", 10.2F)
        txtUsername.Location = New Point(340, 377)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(237, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Microsoft Sans Serif", 10.2F)
        txtPassword.Location = New Point(340, 475)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(237, 27)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(340, 449)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 3
        Label1.Text = "Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(340, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 4
        Label2.Text = "Username:"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(975, 9)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(37, 26)
        btnClose.TabIndex = 5
        btnClose.Text = "x"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LOGO_PARA_SA_COMPROG__312_x_282_px_
        PictureBox1.Location = New Point(271, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(354, 361)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' cbShowPass
        ' 
        cbShowPass.AutoSize = True
        cbShowPass.Location = New Point(340, 513)
        cbShowPass.Margin = New Padding(3, 4, 3, 4)
        cbShowPass.Name = "cbShowPass"
        cbShowPass.Size = New Size(132, 24)
        cbShowPass.TabIndex = 7
        cbShowPass.Text = "Show Password"
        cbShowPass.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(cbShowPass)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(47, 51)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(928, 666)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Location = New Point(0, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(928, 65)
        Panel2.TabIndex = 8
        ' 
        ' LoginFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(194), CByte(231), CByte(242))
        ClientSize = New Size(1024, 768)
        Controls.Add(btnClose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "LoginFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbShowPass As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class
