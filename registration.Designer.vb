<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Label4 = New Label()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox1 = New MaskedTextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter the Username :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 25)
        Label2.TabIndex = 1
        Label2.Text = "Enter the Password :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 25)
        Label3.TabIndex = 2
        Label3.Text = "Select the Role :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 25)
        Label4.TabIndex = 3
        Label4.Text = "Confirm Password :"' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(17, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(412, 31)
        TextBox1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(MaskedTextBox2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(MaskedTextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(446, 401)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "***"' 
        ' Button1
        ' 
        Button1.Location = New Point(17, 344)
        Button1.Name = "Button1"
        Button1.Size = New Size(412, 38)
        Button1.TabIndex = 8
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Administrator", "Employee"})
        ComboBox1.Location = New Point(17, 286)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(412, 33)
        ComboBox1.TabIndex = 7
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.BorderStyle = BorderStyle.FixedSingle
        MaskedTextBox2.Location = New Point(17, 206)
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.PasswordChar = "*"c
        MaskedTextBox2.Size = New Size(412, 31)
        MaskedTextBox2.TabIndex = 6
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BorderStyle = BorderStyle.FixedSingle
        MaskedTextBox1.Location = New Point(17, 128)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.PasswordChar = "*"c
        MaskedTextBox1.Size = New Size(412, 31)
        MaskedTextBox1.TabIndex = 5
        ' 
        ' registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 409)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MaximumSize = New Size(488, 465)
        MinimizeBox = False
        MinimumSize = New Size(488, 465)
        Name = "registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register User Account"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
