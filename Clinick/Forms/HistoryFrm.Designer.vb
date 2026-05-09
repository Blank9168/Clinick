<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryFrm
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
        dgvHistory = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        cmbFilterEvent = New ComboBox()
        lblEventCount = New Label()
        btnClose = New Button()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvHistory.Location = New Point(43, 21)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.Size = New Size(443, 224)
        dgvHistory.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Time"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Event"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Patient"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Details"
        Column4.Name = "Column4"
        ' 
        ' cmbFilterEvent
        ' 
        cmbFilterEvent.FormattingEnabled = True
        cmbFilterEvent.Location = New Point(157, 293)
        cmbFilterEvent.Name = "cmbFilterEvent"
        cmbFilterEvent.Size = New Size(121, 23)
        cmbFilterEvent.TabIndex = 1
        ' 
        ' lblEventCount
        ' 
        lblEventCount.AutoSize = True
        lblEventCount.Location = New Point(145, 376)
        lblEventCount.Name = "lblEventCount"
        lblEventCount.Size = New Size(41, 15)
        lblEventCount.TabIndex = 2
        lblEventCount.Text = "Label1"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(364, 343)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' HistoryFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(lblEventCount)
        Controls.Add(cmbFilterEvent)
        Controls.Add(dgvHistory)
        Name = "HistoryFrm"
        Text = "HistoryFrm"
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cmbFilterEvent As ComboBox
    Friend WithEvents lblEventCount As Label
    Friend WithEvents btnClose As Button
End Class
