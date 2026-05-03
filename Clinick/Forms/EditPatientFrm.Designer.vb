<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatientFrm
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
        Panel1 = New Panel()
        Label1 = New Label()
        btnReturnMainPd = New Button()
        lblEditID = New Label()
        txtEditName = New TextBox()
        txtEditContact = New TextBox()
        cmbEditStatus = New ComboBox()
        btnSaveEdit = New Button()
        btnDelete = New Button()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(218), CByte(240), CByte(242))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnReturnMainPd)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(880, 102)
        Panel1.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label1.Location = New Point(330, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 36)
        Label1.TabIndex = 19
        Label1.Text = "Edit Patient"
        ' 
        ' btnReturnMainPd
        ' 
        btnReturnMainPd.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(244))
        btnReturnMainPd.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturnMainPd.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        btnReturnMainPd.Location = New Point(12, 9)
        btnReturnMainPd.Margin = New Padding(3, 2, 3, 2)
        btnReturnMainPd.Name = "btnReturnMainPd"
        btnReturnMainPd.Size = New Size(94, 27)
        btnReturnMainPd.TabIndex = 28
        btnReturnMainPd.Text = "Return"
        btnReturnMainPd.UseVisualStyleBackColor = False
        ' 
        ' lblEditID
        ' 
        lblEditID.AutoSize = True
        lblEditID.Location = New Point(80, 140)
        lblEditID.Name = "lblEditID"
        lblEditID.Size = New Size(41, 15)
        lblEditID.TabIndex = 29
        lblEditID.Text = "Label2"
        ' 
        ' txtEditName
        ' 
        txtEditName.BorderStyle = BorderStyle.FixedSingle
        txtEditName.Location = New Point(90, 189)
        txtEditName.Name = "txtEditName"
        txtEditName.Size = New Size(100, 23)
        txtEditName.TabIndex = 30
        ' 
        ' txtEditContact
        ' 
        txtEditContact.BorderStyle = BorderStyle.FixedSingle
        txtEditContact.Location = New Point(90, 233)
        txtEditContact.Name = "txtEditContact"
        txtEditContact.Size = New Size(100, 23)
        txtEditContact.TabIndex = 31
        ' 
        ' cmbEditStatus
        ' 
        cmbEditStatus.FormattingEnabled = True
        cmbEditStatus.Location = New Point(90, 281)
        cmbEditStatus.Name = "cmbEditStatus"
        cmbEditStatus.Size = New Size(121, 23)
        cmbEditStatus.TabIndex = 32
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(80, 349)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(110, 23)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(238, 349)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 34
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(355, 349)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' EditPatientFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 541)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(btnSaveEdit)
        Controls.Add(cmbEditStatus)
        Controls.Add(txtEditContact)
        Controls.Add(txtEditName)
        Controls.Add(lblEditID)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditPatientFrm"
        Text = "EditPatientFrm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturnMainPd As Button
    Friend WithEvents lblEditID As Label
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents txtEditContact As TextBox
    Friend WithEvents cmbEditStatus As ComboBox
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
End Class
