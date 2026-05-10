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
        Panel22 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel22.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvHistory
        ' 
        dgvHistory.BackgroundColor = Color.FromArgb(CByte(221), CByte(240), CByte(243))
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvHistory.Location = New Point(64, 165)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.RowHeadersWidth = 51
        dgvHistory.Size = New Size(485, 270)
        dgvHistory.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Time"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Event"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Patient"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Details"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' cmbFilterEvent
        ' 
        cmbFilterEvent.Font = New Font("Microsoft Sans Serif", 10F)
        cmbFilterEvent.FormattingEnabled = True
        cmbFilterEvent.Location = New Point(64, 120)
        cmbFilterEvent.Name = "cmbFilterEvent"
        cmbFilterEvent.Size = New Size(171, 24)
        cmbFilterEvent.TabIndex = 1
        ' 
        ' lblEventCount
        ' 
        lblEventCount.AutoSize = True
        lblEventCount.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEventCount.Location = New Point(90, 173)
        lblEventCount.Name = "lblEventCount"
        lblEventCount.Size = New Size(67, 25)
        lblEventCount.TabIndex = 2
        lblEventCount.Text = "Label1"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(221), CByte(240), CByte(243))
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Microsoft Sans Serif", 10.2F)
        btnClose.Location = New Point(762, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(107, 27)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = Color.Teal
        Panel22.Controls.Add(PictureBox3)
        Panel22.Controls.Add(PictureBox2)
        Panel22.Controls.Add(PictureBox1)
        Panel22.Controls.Add(Panel3)
        Panel22.Controls.Add(Label1)
        Panel22.Dock = DockStyle.Top
        Panel22.Location = New Point(0, 0)
        Panel22.Margin = New Padding(3, 2, 3, 2)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(881, 71)
        Panel22.TabIndex = 52
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.umiiyakangpusokongsumisigaw
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(616, -24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(105, 106)
        PictureBox2.TabIndex = 56
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.recorsds
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(12, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 67)
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        Panel3.Location = New Point(206, 36)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(691, 5)
        Panel3.TabIndex = 54
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(73, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 37)
        Label1.TabIndex = 0
        Label1.Text = "Records"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 485)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(881, 56)
        Panel1.TabIndex = 53
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(107), CByte(128))
        Label2.Location = New Point(47, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 32)
        Label2.TabIndex = 54
        Label2.Text = "Total Events"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lblEventCount)
        Panel2.Location = New Point(634, 70)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(247, 430)
        Panel2.TabIndex = 55
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.umiiyakangpusokongsumisigaw
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(335, -24)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(105, 106)
        PictureBox3.TabIndex = 57
        PictureBox3.TabStop = False
        ' 
        ' HistoryFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(254), CByte(255))
        ClientSize = New Size(881, 541)
        Controls.Add(Panel1)
        Controls.Add(Panel22)
        Controls.Add(cmbFilterEvent)
        Controls.Add(dgvHistory)
        Controls.Add(Panel2)
        Name = "HistoryFrm"
        Text = "HistoryFrm"
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel22.ResumeLayout(False)
        Panel22.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cmbFilterEvent As ComboBox
    Friend WithEvents lblEventCount As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
