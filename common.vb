Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit
Imports MessagingToolkit.Barcode



Module common
    Public update As String = "0"
    Public update_productid As String = ""
    Public update_product As String = ""
    Public update_category As String = ""
    Public update_brand As String = ""
    Public update_price As String = ""
    Public update_quantity As String = ""
    Public update_barcode As String = ""
    Public status As String = ""
    Public connectionString As String = "Data Source=vasu\SQLEXPRESS;Initial Catalog=4ufashion;Integrated Security=True"

    Public Function InsertData(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using cmd As New SqlCommand(query, connection)
                    For Each parameter In parameters
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value)
                    Next
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Add_list(query, combobox_name, column_name)
        Dim con As New SqlConnection(connectionString)
        con.Open()
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            combobox_name.Items.Add(reader(column_name).ToString())
        End While
        reader.Close()
        con.Close()
    End Function

    Public Function generate(num)
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = False
        Generator.CustomLabel = num
        Try
            Dim encodedBitmap As Bitmap = Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, num)
            Dim desiredWidth As Integer = 400
            Dim desiredHeight As Integer = 50
            Dim resizedBitmap As New Bitmap(desiredWidth, desiredHeight)
            Dim graphics As Graphics = Graphics.FromImage(resizedBitmap)
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics.DrawImage(encodedBitmap, 0, 0, desiredWidth, desiredHeight)
            graphics.Dispose()
            Return resizedBitmap
            encodedBitmap.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function GetTableData(ByVal query As String) As DataTable

        Dim dataTable As New DataTable
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        Try
            connection.Open()

            Dim command As SqlCommand = New SqlCommand(query, connection)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

            adapter.Fill(dataTable)

        Catch ex As Exception
            Throw ex
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        Return dataTable
    End Function


    Public Function LoadDataTable(ByVal sqlQuery As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(sqlQuery, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

        Return dt
    End Function


    Public Function ShowConfirmation(message As String) As DialogResult
        Dim result As DialogResult = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetRowCount(query As String, ParamArray parameters() As SqlParameter) As Integer
        Dim count As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddRange(parameters)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                count = CInt(reader(0))
            End If

            reader.Close()
        End Using

        Return count
    End Function


End Module
