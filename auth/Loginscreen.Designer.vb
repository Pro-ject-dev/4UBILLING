<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginscreen
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
        PictureLogin = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel8 = New Panel()
        dropdown = New ComboBox()
        Panel4 = New Panel()
        pass_holder = New Label()
        IconLoginPassword = New PictureBox()
        Panel7 = New Panel()
        password = New TextBox()
        passRequired = New Label()
        Panel3 = New Panel()
        user_holder = New Label()
        IconLoginUser = New PictureBox()
        username = New TextBox()
        Panel6 = New Panel()
        userRequired = New Label()
        Label3 = New Label()
        IconU = New PictureBox()
        IconFour = New PictureBox()
        Login = New Button()
        Panel1.SuspendLayout()
        CType(PictureLogin, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(IconLoginPassword, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(IconLoginUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconU, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconFour, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureLogin)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(13, 15)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 1282)
        Panel1.TabIndex = 0
        ' 
        ' PictureLogin
        ' 
        PictureLogin.Image = My.Resources.loginpage
        PictureLogin.Location = New Point(57, 223)
        PictureLogin.Margin = New Padding(3, 4, 3, 4)
        PictureLogin.Name = "PictureLogin"
        PictureLogin.Size = New Size(928, 718)
        PictureLogin.SizeMode = PictureBoxSizeMode.StretchImage
        PictureLogin.TabIndex = 2
        PictureLogin.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(335, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 29)
        Label2.TabIndex = 1
        Label2.Text = "choose your role to continue"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(363, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 37)
        Label1.TabIndex = 0
        Label1.Text = "Welcome! Login" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(IconU)
        Panel2.Controls.Add(IconFour)
        Panel2.Controls.Add(Login)
        Panel2.Location = New Point(1020, 15)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1000, 1282)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel8)
        Panel5.Controls.Add(dropdown)
        Panel5.Location = New Point(153, 628)
        Panel5.Margin = New Padding(0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(589, 132)
        Panel5.TabIndex = 12
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlDark
        Panel8.Location = New Point(3, 45)
        Panel8.Margin = New Padding(3, 4, 3, 4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(594, 1)
        Panel8.TabIndex = 15
        ' 
        ' dropdown
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
        ' Panel4
        ' 
        Panel4.Controls.Add(pass_holder)
        Panel4.Controls.Add(IconLoginPassword)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(password)
        Panel4.Controls.Add(passRequired)
        Panel4.Location = New Point(153, 448)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(589, 132)
        Panel4.TabIndex = 11
        ' 
        ' pass_holder
        ' 
        pass_holder.AutoSize = True
        pass_holder.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        pass_holder.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        pass_holder.Location = New Point(8, 18)
        pass_holder.Name = "pass_holder"
        pass_holder.Size = New Size(234, 25)
        pass_holder.TabIndex = 15
        pass_holder.Text = "Enter your password here"
        ' 
        ' IconLoginPassword
        ' 
        IconLoginPassword.Image = My.Resources.loginpassword
        IconLoginPassword.Location = New Point(543, 4)
        IconLoginPassword.Margin = New Padding(3, 4, 3, 4)
        IconLoginPassword.Name = "IconLoginPassword"
        IconLoginPassword.Size = New Size(43, 47)
        IconLoginPassword.SizeMode = PictureBoxSizeMode.StretchImage
        IconLoginPassword.TabIndex = 14
        IconLoginPassword.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ControlDark
        Panel7.Location = New Point(5, 69)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(595, 1)
        Panel7.TabIndex = 14
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.None
        password.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        password.ForeColor = Color.Black
        password.Location = New Point(3, 15)
        password.Margin = New Padding(3, 4, 3, 4)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(537, 46)
        password.TabIndex = 6
        ' 
        ' passRequired
        ' 
        passRequired.AutoSize = True
        passRequired.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        passRequired.ForeColor = Color.Red
        passRequired.Location = New Point(8, 79)
        passRequired.Name = "passRequired"
        passRequired.Size = New Size(209, 25)
        passRequired.TabIndex = 9
        passRequired.Text = "Password is required**"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(user_holder)
        Panel3.Controls.Add(IconLoginUser)
        Panel3.Controls.Add(username)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(userRequired)
        Panel3.Location = New Point(153, 271)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(589, 132)
        Panel3.TabIndex = 10
        ' 
        ' user_holder
        ' 
        user_holder.AutoSize = True
        user_holder.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        user_holder.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        user_holder.Location = New Point(8, 20)
        user_holder.Name = "user_holder"
        user_holder.Size = New Size(199, 25)
        user_holder.TabIndex = 14
        user_holder.Text = "Enter your name here"
        ' 
        ' IconLoginUser
        ' 
        IconLoginUser.Image = My.Resources.Resources.loginuser
        IconLoginUser.Location = New Point(543, 4)
        IconLoginUser.Margin = New Padding(3, 4, 3, 4)
        IconLoginUser.Name = "IconLoginUser"
        IconLoginUser.Size = New Size(43, 47)
        IconLoginUser.SizeMode = PictureBoxSizeMode.StretchImage
        IconLoginUser.TabIndex = 13
        IconLoginUser.TabStop = False
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        username.ForeColor = Color.Black
        username.Location = New Point(3, 15)
        username.Margin = New Padding(3, 4, 3, 4)
        username.Multiline = True
        username.Name = "username"
        username.Size = New Size(537, 46)
        username.TabIndex = 5
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlDark
        Panel6.Location = New Point(5, 69)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(595, 1)
        Panel6.TabIndex = 13
        ' 
        ' userRequired
        ' 
        userRequired.AutoSize = True
        userRequired.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        userRequired.ForeColor = Color.Red
        userRequired.Location = New Point(8, 81)
        userRequired.Name = "userRequired"
        userRequired.Size = New Size(213, 25)
        userRequired.TabIndex = 8
        userRequired.Text = "Username is required**"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(392, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 37)
        Label3.TabIndex = 3
        Label3.Text = "Fashion"
        ' 
        ' IconU
        ' 
        IconU.Anchor = AnchorStyles.None
        IconU.BackgroundImageLayout = ImageLayout.Stretch
        IconU.Image = My.Resources.Resources.letter_u
        IconU.Location = New Point(463, 64)
        IconU.Margin = New Padding(3, 4, 3, 4)
        IconU.Name = "IconU"
        IconU.Size = New Size(72, 88)
        IconU.SizeMode = PictureBoxSizeMode.StretchImage
        IconU.TabIndex = 2
        IconU.TabStop = False
        ' 
        ' IconFour
        ' 
        IconFour.BackgroundImageLayout = ImageLayout.Stretch
        IconFour.Image = My.Resources.Resources.four
        IconFour.Location = New Point(391, 64)
        IconFour.Margin = New Padding(3, 4, 3, 4)
        IconFour.Name = "IconFour"
        IconFour.Size = New Size(72, 88)
        IconFour.SizeMode = PictureBoxSizeMode.StretchImage
        IconFour.TabIndex = 1
        IconFour.TabStop = False
        ' 
        ' Login
        ' 
        Login.BackColor = Color.FromArgb(CByte(251), CByte(124), CByte(81))
        Login.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Login.ForeColor = SystemColors.ButtonHighlight
        Login.Location = New Point(509, 825)
        Login.Margin = New Padding(3, 4, 3, 4)
        Login.Name = "Login"
        Login.Size = New Size(233, 75)
        Login.TabIndex = 0
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1924, 1050)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureLogin, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(IconLoginPassword, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(IconLoginUser, ComponentModel.ISupportInitialize).EndInit()
        CType(IconU, ComponentModel.ISupportInitialize).EndInit()
        CType(IconFour, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureLogin As PictureBox
    Friend WithEvents Login As Button
    Friend WithEvents IconU As PictureBox
    Friend WithEvents IconFour As PictureBox
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
    Friend WithEvents IconLoginPassword As PictureBox
    Friend WithEvents IconLoginUser As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents user_holder As Label
    Friend WithEvents pass_holder As Label
End Class
