Imports System.Data.SqlClient
Imports System.IO
Imports Telegram.Bot
Imports Telegram.Bot.Types
Imports Telegram.Bot.Types.InputFiles

Public Class Backup
    Dim backupFileName As String
    Dim chatId As String = "1465946175"
    Dim botClient As New TelegramBotClient("6575002610:AAEwBo7GBmg3VQCFvvETSa3jKDKQgqRxRjs")


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable Then
            Label2.Visible = True
            Label3.Visible = True
            Dim backup_status = GenerateBackup(ProgressBar1)
            If backup_status Then
                SendDocumentAsync(botClient, chatId, backupFileName, ProgressBar1)
            End If
        Else
            MessageBox.Show("Please Make Sure Your Internet !", "Network Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Public Function GenerateBackup(progress As ProgressBar) As Boolean
        Dim backupFolderPath As String = "C:\billing_backup"
        Dim databaseName As String = "4ufashion"

        If Not Directory.Exists(backupFolderPath) Then
            Directory.CreateDirectory(backupFolderPath)
        End If
        progress.Value = 10
        Label3.Text = "10 %"

        backupFileName = $"{backupFolderPath}\{databaseName}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.bak"

        Using connection As New SqlConnection(connectionString)
            progress.Value = 20
            Label3.Text = "20 %"
            Dim commandText As String = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFileName}'"
            progress.Value = 30
            Label3.Text = "30 %"
            Dim command As New SqlCommand(commandText, connection)

            Try
                progress.Value = 40
                Label3.Text = "40 %"
                connection.Open()
                command.ExecuteNonQuery()
                progress.Value = 50
                Label3.Text = "50 %"
                Return True
            Catch ex As Exception
                MsgBox($"Error during backup: {ex.Message}")
                Return False
            Finally
                connection.Close()
            End Try

        End Using
    End Function

    Public Async Function SendDocumentAsync(botClient As TelegramBotClient, chatId As Long, filePath As String, progress As ProgressBar) As Task
        progress.Value = 60
        Label3.Text = "60 %"
        Dim fileInfo As New FileInfo(filePath)
        progress.Value = 70
        Label3.Text = "70 %"
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
        progress.Value = 80
        Label3.Text = "80 %"
        Dim documentFile As InputOnlineFile = New InputOnlineFile(fileStream, fileInfo.Name)
        progress.Value = 90
        Label3.Text = "90 %"
        Dim sentDocument As Message = Await botClient.SendDocumentAsync(chatId, documentFile)
        fileStream.Close()
        progress.Value = 100
        Label3.Text = "100 %"
        MessageBox.Show("Backup successfully sent!", "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Function

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        Label3.Visible = False
    End Sub
End Class