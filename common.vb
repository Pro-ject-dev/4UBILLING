Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Text
Imports MessagingToolkit.Barcode



Module common
    Public currentuser As String = ""
    Public currentrole As String = ""
    Public update As String = "0"
    Public update_productid As String = ""
    Public update_product As String = ""
    Public update_category As String = ""
    Public update_size As String = ""
    Public update_brand As String = ""
    Public update_price As String = ""
    Public update_quantity As String = ""
    Public update_barcode As String = ""
    Public status As String = ""
    Public stock_query As String = ""
    Public sales_query As String = ""
    Public userID As String = ""
    Public userstatus As String = "1"
    Public updateuserid As String = ""
    Public updateusername As String = ""
    Public updatepass As String = ""
    Public updaterole As String = ""
    'Public screenwidth = Screen.PrimaryScreen.Bounds.Width
    'Public screenheight = Screen.PrimaryScreen.Bounds.Height
    Public validate As New DataGridViewButtonColumn()
    Public delete As New DataGridViewButtonColumn()

    Private ReadOnly key As Byte() = Encoding.UTF8.GetBytes("ThisIsA16ByteKey")
    Private ReadOnly iv As Byte() = Encoding.UTF8.GetBytes("1234567890123456")
    'Public connectionString As String = "Data Source=mssql-168791-0.cloudclusters.net,10058;Initial Catalog=4ufashion;User ID=vasudev;Password=Vasu@12345"
    'Public connectionString As String = "Data Source=DESKTOP-3FLJO23\SQLEXPRESS;Initial Catalog=4ufashion;Integrated Security=True"
    'Public connectionString As String = "Data Source=VASU\SQLEXPRESS;Initial Catalog=4ufashion;Integrated Security=True"

    Public connectionString As String = "Data Source=(localdb)\local;Initial Catalog=4ufashion;Integrated Security=True"

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
            MessageBox.Show(ex.Message, "Unable to Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim graphics As Graphics = graphics.FromImage(resizedBitmap)
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


    Function ModifystockColumnNames(ByVal query As String) As String
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("'Product ID'", "'product_id'")
        columnMappings.Add("'Created Date'", "'date'")
        columnMappings.Add("'Product Name'", "'product_name'")
        columnMappings.Add("'Category'", "'cat_id'")
        columnMappings.Add("'Brand Name'", "'brand_id'")

        For Each kvp As KeyValuePair(Of String, String) In columnMappings
            query = query.Replace(kvp.Key, kvp.Value)
        Next

        Return query
    End Function

    Function ModifysalesColumnNames(ByVal query As String) As String
        Dim columnMappings As New Dictionary(Of String, String)()
        columnMappings.Add("'Billing No.'", "'Billing_no'")
        columnMappings.Add("'Customer Name'", "'ref_id'")
        columnMappings.Add("'Mobile No.'", "'Customer_id'")
        columnMappings.Add("'Product'", "'Product_id'")
        columnMappings.Add("'Billed by'", "'Billed_by'")

        For Each kvp As KeyValuePair(Of String, String) In columnMappings
            query = query.Replace(kvp.Key, kvp.Value)
        Next

        Return query
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

    Public Function GetSuggestions(searchText As String, query As String) As AutoCompleteStringCollection
        Dim suggestions As New AutoCompleteStringCollection
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@searchText", searchText)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    suggestions.Add(reader.GetString(0))
                End While
            End Using
        End Using

        Return suggestions
    End Function


    Public Function EncryptData(data As String) As String
        Using aesAlg As New AesCryptoServiceProvider()
            aesAlg.Key = key
            aesAlg.IV = iv

            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Dim msEncrypt As New System.IO.MemoryStream()
            Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                Using swEncrypt As New System.IO.StreamWriter(csEncrypt)
                    swEncrypt.Write(data)
                End Using
            End Using
            Return Convert.ToBase64String(msEncrypt.ToArray())
        End Using
    End Function

    Public Function DecryptData(encryptedData As String) As String
        Dim cipherText As Byte() = Convert.FromBase64String(encryptedData)
        Using aesAlg As New AesCryptoServiceProvider()
            aesAlg.Key = key
            aesAlg.IV = iv
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Dim msDecrypt As New System.IO.MemoryStream(cipherText)
            Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                Using srDecrypt As New System.IO.StreamReader(csDecrypt)
                    Return srDecrypt.ReadToEnd()
                End Using
            End Using
        End Using
    End Function


End Module




