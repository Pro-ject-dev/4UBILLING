Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Public Class registration
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim.ToString = "" Or MaskedTextBox1.Text.Trim.ToString = "" Or MaskedTextBox2.Text.ToString = "" Then
            MessageBox.Show("All Fields Are Manditory !", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Len(MaskedTextBox1.Text.Trim) > 8) And (Len(MaskedTextBox2.Text.Trim) > 8) Then

                If (MaskedTextBox1.Text.Trim = MaskedTextBox2.Text.Trim) Then
                    If userstatus = "1" Then
                        Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Account ? ")
                        If state Then
                            Dim query = "insert into login (username,password,role) values(@value1,@value2,'" + ComboBox1.SelectedItem.ToString + "')"
                            Dim valuesToInsert As New Dictionary(Of String, Object)
                            valuesToInsert.Add("@value1", TextBox1.Text.ToString.Trim)
                            valuesToInsert.Add("@value2", EncryptData(MaskedTextBox1.Text.Trim.ToString))
                            Dim stat = InsertData(query, valuesToInsert)
                            If stat Then
                                MessageBox.Show("User Account is Successfully Added !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            End If
                        End If
                    Else
                        Dim state As Boolean = ShowConfirmation("Are You Sure to Update this Account ? ")
                        If state Then
                            Dim query = "update login set username=@value1,password=@value2,role='" + ComboBox1.SelectedItem.ToString + "' where userid='" + updateuserid + "'"
                            Dim valuesToInsert As New Dictionary(Of String, Object)
                            valuesToInsert.Add("@value1", TextBox1.Text.ToString.Trim)
                            valuesToInsert.Add("@value2", EncryptData(MaskedTextBox1.Text.Trim.ToString))
                            Dim stat = InsertData(query, valuesToInsert)
                            If stat Then
                                MessageBox.Show("User Account is Successfully Updated !", "Update Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            End If
                        End If
                    End If

                Else
                    MessageBox.Show("Password is not Matched !", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Password Minimum Length is 8", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If userstatus = "0" Then
            Button1.Text = "Update Account"
            TextBox1.Text = updateusername
            MaskedTextBox1.Text = updatepass
            MaskedTextBox2.Text = updatepass
            ComboBox1.SelectedItem = updaterole
        End If
    End Sub

    Private Sub registration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        userstatus = "1"
    End Sub
End Class