<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Mobiletxt = New TextBox()
        placetxt = New TextBox()
        Nametxt = New TextBox()
        addbtn = New Button()
        clearbtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 1
        Label2.Text = "Mobile No :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "Place :"
        ' 
        ' Mobiletxt
        ' 
        Mobiletxt.Location = New Point(93, 104)
        Mobiletxt.Margin = New Padding(3, 4, 3, 4)
        Mobiletxt.Name = "Mobiletxt"
        Mobiletxt.Size = New Size(186, 27)
        Mobiletxt.TabIndex = 3
        ' 
        ' placetxt
        ' 
        placetxt.Location = New Point(93, 149)
        placetxt.Margin = New Padding(3, 4, 3, 4)
        placetxt.Name = "placetxt"
        placetxt.Size = New Size(186, 27)
        placetxt.TabIndex = 4
        ' 
        ' Nametxt
        ' 
        Nametxt.Location = New Point(93, 58)
        Nametxt.Margin = New Padding(3, 4, 3, 4)
        Nametxt.Name = "Nametxt"
        Nametxt.Size = New Size(186, 27)
        Nametxt.TabIndex = 0
        ' 
        ' addbtn
        ' 
        addbtn.Location = New Point(93, 222)
        addbtn.Margin = New Padding(3, 4, 3, 4)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(75, 48)
        addbtn.TabIndex = 6
        addbtn.Text = "ADD"
        addbtn.UseVisualStyleBackColor = True
        ' 
        ' clearbtn
        ' 
        clearbtn.Location = New Point(193, 222)
        clearbtn.Margin = New Padding(3, 4, 3, 4)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(75, 48)
        clearbtn.TabIndex = 7
        clearbtn.Text = "CLEAR"
        clearbtn.UseVisualStyleBackColor = True
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 285)
        Controls.Add(clearbtn)
        Controls.Add(addbtn)
        Controls.Add(Nametxt)
        Controls.Add(placetxt)
        Controls.Add(Mobiletxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MaximumSize = New Size(335, 332)
        MinimizeBox = False
        MinimumSize = New Size(335, 332)
        Name = "AddUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mobiletxt As TextBox
    Friend WithEvents placetxt As TextBox
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents clearbtn As Button
End Class
