<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        components = New ComponentModel.Container()
        PictureSplash = New PictureBox()
        Label1 = New Label()
        PictureLogo = New PictureBox()
        Label2 = New Label()
        Load1 = New PictureBox()
        Load3 = New PictureBox()
        Load2 = New PictureBox()
        labelBrandt = New Label()
        labelBrandb = New Label()
        iconMustache = New PictureBox()
        lableVersion = New Label()
        Timer1 = New Timer(components)
        Label3 = New Label()
        CType(PictureSplash, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Load1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Load3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Load2, ComponentModel.ISupportInitialize).BeginInit()
        CType(iconMustache, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureSplash
        ' 
        PictureSplash.Location = New Point(29, 52)
        PictureSplash.Margin = New Padding(4)
        PictureSplash.Name = "PictureSplash"
        PictureSplash.Size = New Size(536, 535)
        PictureSplash.SizeMode = PictureBoxSizeMode.StretchImage
        PictureSplash.TabIndex = 0
        PictureSplash.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.AppWorkspace
        Label1.Location = New Point(1712, 843)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 1
        Label1.Text = "v.1.0.0"
        ' 
        ' PictureLogo
        ' 
        PictureLogo.Location = New Point(663, 119)
        PictureLogo.Name = "PictureLogo"
        PictureLogo.Size = New Size(213, 165)
        PictureLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureLogo.TabIndex = 2
        PictureLogo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(712, 415)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 10
        Label2.Text = "Loading..."
        ' 
        ' Load1
        ' 
        Load1.Image = My.Resources.Resources.loginloadingrose
        Load1.Location = New Point(688, 459)
        Load1.Name = "Load1"
        Load1.Size = New Size(28, 27)
        Load1.SizeMode = PictureBoxSizeMode.StretchImage
        Load1.TabIndex = 11
        Load1.TabStop = False
        ' 
        ' Load3
        ' 
        Load3.Image = My.Resources.Resources.loginloadingrose
        Load3.Location = New Point(794, 459)
        Load3.Name = "Load3"
        Load3.Size = New Size(28, 27)
        Load3.SizeMode = PictureBoxSizeMode.StretchImage
        Load3.TabIndex = 12
        Load3.TabStop = False
        ' 
        ' Load2
        ' 
        Load2.Image = My.Resources.Resources.loginloadingrose
        Load2.Location = New Point(741, 459)
        Load2.Name = "Load2"
        Load2.Size = New Size(28, 27)
        Load2.SizeMode = PictureBoxSizeMode.StretchImage
        Load2.TabIndex = 13
        Load2.TabStop = False
        ' 
        ' labelBrandt
        ' 
        labelBrandt.AutoSize = True
        labelBrandt.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        labelBrandt.ForeColor = Color.FromArgb(CByte(237), CByte(20), CByte(99))
        labelBrandt.Location = New Point(663, 304)
        labelBrandt.Name = "labelBrandt"
        labelBrandt.Size = New Size(181, 26)
        labelBrandt.TabIndex = 14
        labelBrandt.Text = "4ufashion look"
        ' 
        ' labelBrandb
        ' 
        labelBrandb.AutoSize = True
        labelBrandb.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        labelBrandb.ForeColor = Color.FromArgb(CByte(0), CByte(173), CByte(239))
        labelBrandb.Location = New Point(669, 334)
        labelBrandb.Name = "labelBrandb"
        labelBrandb.Size = New Size(140, 26)
        labelBrandb.TabIndex = 16
        labelBrandb.Text = "Men's wear"
        ' 
        ' iconMustache
        ' 
        iconMustache.Image = My.Resources.Resources.moustache
        iconMustache.Location = New Point(827, 330)
        iconMustache.Name = "iconMustache"
        iconMustache.Size = New Size(40, 40)
        iconMustache.SizeMode = PictureBoxSizeMode.StretchImage
        iconMustache.TabIndex = 17
        iconMustache.TabStop = False
        ' 
        ' lableVersion
        ' 
        lableVersion.AutoSize = True
        lableVersion.ForeColor = SystemColors.ButtonShadow
        lableVersion.Location = New Point(882, 588)
        lableVersion.Name = "lableVersion"
        lableVersion.Size = New Size(56, 20)
        lableVersion.TabIndex = 18
        lableVersion.Text = "v.1.0.0"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(610, 585)
        Label3.Name = "Label3"
        Label3.Size = New Size(266, 20)
        Label3.TabIndex = 19
        Label3.Text = "A SustainNova Tech Labs Product"
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        ClientSize = New Size(964, 622)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(lableVersion)
        Controls.Add(iconMustache)
        Controls.Add(labelBrandb)
        Controls.Add(labelBrandt)
        Controls.Add(Load2)
        Controls.Add(Load3)
        Controls.Add(Load1)
        Controls.Add(Label2)
        Controls.Add(PictureLogo)
        Controls.Add(Label1)
        Controls.Add(PictureSplash)
        Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        CType(PictureSplash, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(Load1, ComponentModel.ISupportInitialize).EndInit()
        CType(Load3, ComponentModel.ISupportInitialize).EndInit()
        CType(Load2, ComponentModel.ISupportInitialize).EndInit()
        CType(iconMustache, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureSplash As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Load1 As PictureBox
    Friend WithEvents Load3 As PictureBox
    Friend WithEvents Load2 As PictureBox
    Friend WithEvents labelBrandt As Label
    Friend WithEvents labelBrandb As Label
    Friend WithEvents iconMustache As PictureBox
    Friend WithEvents lableVersion As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
End Class
