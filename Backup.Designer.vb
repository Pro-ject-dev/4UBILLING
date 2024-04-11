<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Backup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(124, 499)
        Button1.Name = "Button1"
        Button1.Size = New Size(377, 35)
        Button1.TabIndex = 0
        Button1.Text = "Backup"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(355, 25)
        Label1.TabIndex = 1
        Label1.Text = "Safeguard your data with our backup form."' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cloud_data_storage_rack_concept_glass_cube_cloudscape_digital_metaverse_server_global_network_business_web_database_backup_computer_private_infrastructure_technology
        PictureBox1.Location = New Point(20, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(583, 374)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(20, 428)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(583, 34)
        ProgressBar1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(228, 468)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 4
        Label2.Text = "Backuping..........."' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(358, 469)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 25)
        Label3.TabIndex = 5
        Label3.Text = "0 %"' 
        ' Backup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 544)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Backup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Backup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class