
Imports System.Data.SqlClient

Module SqlCon


    Public Function getLoginData(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            Using conn As SqlConnection = New SqlConnection(connectionString)
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(query, conn)
                    For Each parameter In parameters
                        Command.Parameters.AddWithValue(parameter.Key, parameter.Value)
                    Next
                    Dim LoginValue As SqlDataReader = Command.ExecuteReader()
                    LoginValue.Read()
                    If LoginValue.HasRows Then
                        Return True
                    Else
                        Return False
                    End If
                    conn.Close()


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try


    End Function
End Module
