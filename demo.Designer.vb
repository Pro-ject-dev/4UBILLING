<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class demo
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel8 = New Panel()
        dropdown = New ComboBox()
        Panel4 = New Panel()
        pass_holder = New Label()
        PictureBox5 = New PictureBox()
        Panel7 = New Panel()
        password = New TextBox()
        passRequired = New Label()
        Panel3 = New Panel()
        user_holder = New Label()
        username = New TextBox()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        userRequired = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'Panel1
        '
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(13, 15)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 1282)
        Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        PictureBox1.Location = New Point(58, 219)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(861, 724)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(309, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 29)
        Label2.TabIndex = 1
        Label2.Text = "choose your role to continue"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(335, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 37)
        Label1.TabIndex = 0
        Label1.Text = "Welcome! Login" & vbCrLf
        '
        'Panel2
        '
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(1020, 15)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1000, 1282)
        Panel2.TabIndex = 1
        '
        'Panel5
        '
        Panel5.Controls.Add(Panel8)
        Panel5.Controls.Add(dropdown)
        Panel5.Location = New Point(93, 634)
        Panel5.Margin = New Padding(0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(589, 105)
        Panel5.TabIndex = 12
        '
        'Panel8
        '
        Panel8.BackColor = SystemColors.ControlDark
        Panel8.Location = New Point(0, 45)
        Panel8.Margin = New Padding(3, 4, 3, 4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(597, 1)
        Panel8.TabIndex = 15
        '
        'dropdown
        '
        dropdown.BackColor = Color.White
        dropdown.DropDownStyle = ComboBoxStyle.DropDownList
        dropdown.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        dropdown.FormattingEnabled = True
        dropdown.ItemHeight = 29
        dropdown.Items.AddRange(New Object() {"Administrator", "Employee"})
        dropdown.Location = New Point(3, 0)
        dropdown.Margin = New Padding(3, 4, 3, 4)
        dropdown.MaxDropDownItems = 10
        dropdown.Name = "dropdown"
        dropdown.Size = New Size(582, 37)
        dropdown.TabIndex = 7
        '
        'Panel4
        '
        Panel4.Controls.Add(pass_holder)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(password)
        Panel4.Controls.Add(passRequired)
        Panel4.Location = New Point(93, 467)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(589, 105)
        Panel4.TabIndex = 11
        '
        'pass_holder
        '
        pass_holder.AutoSize = True
        pass_holder.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        pass_holder.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        pass_holder.Location = New Point(5, 13)
        pass_holder.Name = "pass_holder"
        pass_holder.Size = New Size(234, 25)
        pass_holder.TabIndex = 15
        pass_holder.Text = "Enter your password here"
        '
        'PictureBox5
        '
        PictureBox5.Location = New Point(541, 1)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(44, 46)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        '
        'Panel7
        '
        Panel7.BackColor = SystemColors.ControlDark
        Panel7.Location = New Point(3, 59)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(597, 1)
        Panel7.TabIndex = 14
        '
        'password
        '
        password.BorderStyle = BorderStyle.None
        password.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        password.ForeColor = Color.Black
        password.Location = New Point(3, 13)
        password.Margin = New Padding(3, 4, 3, 4)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(532, 46)
        password.TabIndex = 6
        '
        'passRequired
        '
        passRequired.AutoSize = True
        passRequired.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        passRequired.ForeColor = Color.Red
        passRequired.Location = New Point(5, 66)
        passRequired.Name = "passRequired"
        passRequired.Size = New Size(209, 25)
        passRequired.TabIndex = 9
        passRequired.Text = "Password is required**"
        '
        'Panel3
        '
        Panel3.Controls.Add(user_holder)
        Panel3.Controls.Add(username)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(userRequired)
        Panel3.Location = New Point(93, 296)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(589, 105)
        Panel3.TabIndex = 10
        '
        'user_holder
        '
        user_holder.AutoSize = True
        user_holder.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        user_holder.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        user_holder.Location = New Point(5, 13)
        user_holder.Name = "user_holder"
        user_holder.Size = New Size(199, 25)
        user_holder.TabIndex = 14
        user_holder.Text = "Enter your name here"
        '
        'username
        '
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        username.ForeColor = Color.Black
        username.Location = New Point(0, 13)
        username.Margin = New Padding(3, 4, 3, 4)
        username.Multiline = True
        username.Name = "username"
        username.Size = New Size(532, 46)
        username.TabIndex = 5
        '
        'PictureBox4
        '
        PictureBox4.Location = New Point(541, 1)
        PictureBox4.Margin = New Padding(3, 4, 3, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(44, 46)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        '
        'Panel6
        '
        Panel6.BackColor = SystemColors.ControlDark
        Panel6.Location = New Point(3, 59)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(597, 1)
        Panel6.TabIndex = 13
        '
        'userRequired
        '
        userRequired.AutoSize = True
        userRequired.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        userRequired.ForeColor = Color.Red
        userRequired.Location = New Point(5, 66)
        userRequired.Name = "userRequired"
        userRequired.Size = New Size(213, 25)
        userRequired.TabIndex = 8
        userRequired.Text = "Username is required**"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(263, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 37)
        Label3.TabIndex = 3
        Label3.Text = "Fashion"
        '
        'PictureBox3
        '
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(334, 67)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(72, 80)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(262, 67)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(72, 80)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        '
        'demo
        '
        AutoScaleDimensions = New SizeF(10.0!, 25.0!)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1032, 1310)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "demo"
        Text = "demo"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents dropdown As ComboBox
    Friend WithEvents passRequired As Label
    Friend WithEvents userRequired As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents user_holder As Label
    Friend WithEvents pass_holder As Label
End Class
