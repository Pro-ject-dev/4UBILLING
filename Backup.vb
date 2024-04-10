Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Intrinsics
Imports Telegram.Bot
Imports Telegram.Bot.Types
Imports Telegram.Bot.Types.InputFiles

Public Class Backup
    Dim backupFileName As String
    Dim chatId As String = "1465946175"
    Dim botClient As New TelegramBotClient("6575002610:AAEwBo7GBmg3VQCFvvETSa3jKDKQgqRxRjs")
    Dim frm = New waitingscreen

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backup_status As Boolean = GenerateBackup()
        If backup_status Then
            frm.Show()
            Try
                SendDocumentAsync(botClient, chatId, backupFileName)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub


    Public Function GenerateBackup() As Boolean




        Dim backupFolderPath As String = "C:\billing_backup"
        Dim databaseName As String = "4ufashion"

        If Not Directory.Exists(backupFolderPath) Then
            Directory.CreateDirectory(backupFolderPath)
        End If

        backupFileName = $"{backupFolderPath}\{databaseName}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.bak"

        Using connection As New SqlConnection(connectionString)
            Dim commandText As String = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFileName}'"
            Dim command As New SqlCommand(commandText, connection)

            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox($"Error during backup: {ex.Message}")
                Return False
            Finally
                connection.Close()
            End Try

            Try
                Return True
            Catch ex As Exception
                MsgBox($"Error during zipping: {ex.Message}")
                Return False
            End Try
        End Using
    End Function



    Public Async Function SendDocumentAsync(botClient As TelegramBotClient, chatId As Long, filePath As String) As Task
        Dim fileInfo As New FileInfo(filePath)
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
        Dim documentFile As InputOnlineFile = New InputOnlineFile(fileStream, fileInfo.Name)
        Dim sentDocument As Message = Await botClient.SendDocumentAsync(chatId, documentFile)
        fileStream.Close()
        frm.Close()
        MessageBox.Show("Successfully backed up the data!", "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Function

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class