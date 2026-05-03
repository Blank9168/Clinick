<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForPic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForPic))
        PictureDental = New PictureBox()
        PictureGeneral = New PictureBox()
        PicturePedia = New PictureBox()
        CType(PictureDental, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureGeneral, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicturePedia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureDental
        ' 
        PictureDental.Image = My.Resources.Resources.Ipin
        PictureDental.Location = New Point(120, 50)
        PictureDental.Name = "PictureDental"
        PictureDental.Size = New Size(84, 77)
        PictureDental.SizeMode = PictureBoxSizeMode.StretchImage
        PictureDental.TabIndex = 4
        PictureDental.TabStop = False
        ' 
        ' PictureGeneral
        ' 
        PictureGeneral.Image = My.Resources.Resources.Checklist
        PictureGeneral.Location = New Point(253, 50)
        PictureGeneral.Name = "PictureGeneral"
        PictureGeneral.Size = New Size(84, 77)
        PictureGeneral.SizeMode = PictureBoxSizeMode.StretchImage
        PictureGeneral.TabIndex = 5
        PictureGeneral.TabStop = False
        ' 
        ' PicturePedia
        ' 
        PicturePedia.Image = CType(resources.GetObject("PicturePedia.Image"), Image)
        PicturePedia.Location = New Point(385, 50)
        PicturePedia.Name = "PicturePedia"
        PicturePedia.Size = New Size(84, 77)
        PicturePedia.SizeMode = PictureBoxSizeMode.StretchImage
        PicturePedia.TabIndex = 6
        PicturePedia.TabStop = False
        ' 
        ' ForPic
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PicturePedia)
        Controls.Add(PictureGeneral)
        Controls.Add(PictureDental)
        Name = "ForPic"
        Text = "ForPic"
        CType(PictureDental, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureGeneral, ComponentModel.ISupportInitialize).EndInit()
        CType(PicturePedia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureDental As PictureBox
    Friend WithEvents PictureGeneral As PictureBox
    Friend WithEvents PicturePedia As PictureBox
End Class
