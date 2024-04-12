
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Microsoft.Identity.Client.ApiConfig

Public Class Loginscreen
    Public allow = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IconU.Size = New System.Drawing.Size(65, 70)
        Me.IconFour.Size = New System.Drawing.Size(65, 70)
        Me.Label3.Size = New System.Drawing.Size(66, 29)
        Me.Login.FlatStyle = FlatStyle.Flat
        Me.Login.FlatAppearance.BorderSize = 0
        Me.dropdown.FlatStyle = FlatStyle.Flat
        passRequired.Visible = False
        userRequired.Visible = False
        If Len(password.Text) < 1 Then
            pass_holder.Visible = True

        End If
        If Len(username.Text) < 1 Then
            user_holder.Visible = True

        End If
        password.PasswordChar = "*"

        If dropdown.Items.Count > 0 Then
            dropdown.SelectedIndex = 0
        End If


        'Image Load
        Me.PictureLogin.Image = My.Resources.loginpage
        Me.IconFour.Image = My.Resources.four
        Me.IconU.Image = My.Resources.letter_u
        Me.IconLoginUser.Image = My.Resources.loginuser
        Me.IconLoginPassword.Image = My.Resources.loginpassword

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        If Len(password.Text) > 0 Then
            pass_holder.Visible = False
            passRequired.Visible = False
        Else
            pass_holder.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        If Len(username.Text) > 0 Then
            user_holder.Visible = False
            userRequired.Visible = False
        Else
            user_holder.Visible = True
        End If
    End Sub
    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            password.Select()


        End If

    End Sub

    Private Sub pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            dropdown.Select()
        End If
    End Sub
    Private Sub role_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dropdown.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Login.Select()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Dim queryString As String = "select * from Login where UserName = @user and Password = @pass and Role = @role"
        If Len(username.Text) > 0 And Len(password.Text) > 0 Then
            userRequired.Visible = False
            passRequired.Visible = False
            parameters.Add("@user", username.Text.Trim)
            parameters.Add("@pass", EncryptData(password.Text.Trim))
            parameters.Add("@role", dropdown.SelectedItem)
            If getLoginData(queryString, parameters) Then
                allow = True
                currentuser = username.Text.Trim.ToString.ToUpper
                currentrole = dropdown.SelectedItem.ToString.ToUpper
                Me.Close()
            Else
                MsgBox("Incorrect Credentials")
            End If
        ElseIf Len(username.Text) < 1 And Len(password.Text) > 0 Then
            userRequired.Visible = True
            passRequired.Visible = False
        ElseIf Len(password.Text) < 1 And Len(username.Text) > 0 Then
            passRequired.Visible = True
            userRequired.Visible = False
        Else
            userRequired.Visible = True
            passRequired.Visible = True
        End If


    End Sub



    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If allow = False Then
            Application.Exit()

        End If
    End Sub

    Private Sub user_holder_Click(sender As Object, e As EventArgs) Handles user_holder.Click
        username.Select()
        username.Focus()
    End Sub
    Private Sub pass_holder_Click(sender As Object, e As EventArgs) Handles pass_holder.Click
        password.Select()
        password.Focus()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class

