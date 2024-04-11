<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waitingscreen
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        statuss = New ProgressBar()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cloud_upload
        PictureBox1.Location = New Point(30, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 25)
        Label1.TabIndex = 1
        Label1.Text = "Please Wait Backuping ....."' 
        ' statuss
        ' 
        statuss.Location = New Point(133, 18)
        statuss.Name = "statuss"
        statuss.Size = New Size(222, 34)
        statuss.TabIndex = 2
        ' 
        ' waitingscreen
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(378, 89)
        Controls.Add(statuss)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "waitingscreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "waitingscreen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents statuss As ProgressBar
End Class
