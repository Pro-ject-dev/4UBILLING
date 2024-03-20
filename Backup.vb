Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FireSharp
Imports FireSharp.Config
Imports FireSharp.Response

Public Class Backup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim backupPath As String = "C:\Backups\4ufashion.bak"
        Dim compressedFile As String = "C:\Users\Vasudevan.N\Downloads\4ufashion.zip"

        ' Check if the file is in use before proceeding
        If Not IsFileInUse(compressedFile) Then
            ' If the file is not in use, proceed with zipping and sending the email
            Try
                ZipFile.CreateFromDirectory(Path.GetDirectoryName(backupPath), compressedFile)

                ' Rest of your email sending code...
                ' Email details
                Dim fromAddress As String = "Vasudevan180603@gmail.com"
                Dim toAddress As String = "Vasudevan7941@mountzion.ac.in"
                Dim subject As String = "File attachment"
                Dim body As String = "This email contains an attached compressed file."
                Dim timeout As Integer = 1000000

                ' Create a new mail message
                Dim message As New MailMessage(fromAddress, toAddress, subject, body)

                ' Attach the compressed file
                Dim attachment As New Attachment(compressedFile)
                message.Attachments.Add(attachment)
                Dim smtpClient As New SmtpClient("smtp.elasticemail.com", 2525)
                smtpClient.Credentials = New NetworkCredential("vasudevan180603@gmail.com", "0C2BE7FBB046A986F354D0D99F2EC1E750BC")
                smtpClient.EnableSsl = True
                smtpClient.Timeout = timeout

                ' Send the email
                smtpClient.Send(message)

                ' Display a message box
                MsgBox("Mail Sent Successfully!")

                ' Cleanup: delete the backup file
                File.Delete(backupPath)
            Catch ex As Exception
                Console.WriteLine("An error occurred: " & ex.Message)
            End Try
        Else
            Console.WriteLine("The file is currently in use by another process.")
        End If
    End Sub

    Function IsFileInUse(filePath As String) As Boolean
        If Not File.Exists(filePath) Then
            Return False
        End If

        Try
            Using fileStream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None)
                ' If the file can be opened, it's not in use
                Return False
            End Using
        Catch ex As Exception
            ' If there's an exception while opening the file, it's in use
            Return True
        End Try
    End Function









    Private Sub Backup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
End Class