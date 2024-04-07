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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(210, 484)
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
        Label1.Text = "Safeguard your data with our backup form." ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cloud_data_storage_rack_concept_glass_cube_cloudscape_digital_metaverse_server_global_network_business_web_database_backup_computer_private_infrastructure_technology
        PictureBox1.Location = New Point(20, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(760, 426)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Backup
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 529)
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
End Class