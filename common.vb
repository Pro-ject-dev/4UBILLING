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
    Public stock_query As String = ""
    Public sales_query As String = ""
    Public UserId As Int32 = 1
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


    Function ModifyColumnNames(ByVal query As String) As String
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



    Public Function getLeaderMonth(parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Dim query As String = "EXECUTE leaderMonth @Year = @Year, @Month = @Month"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Year", parameters.GetValueOrDefault("@year"))
                        command.Parameters.AddWithValue("@Month", parameters.GetValueOrDefault("@month"))

                        connection.Open()

                        Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            Dim totalCost As Integer = reader.GetInt32(0)
                            Dim customerName As String = reader.GetString(1)
                            Dim place As String = reader.GetString(2)
                            returnDict.Add("custName", customerName)
                            returnDict.Add("custPlace", place)
                            returnDict.Add("custCost", totalCost)

                        End While
                    Else
                        MsgBox("No date found on your preference")

                        returnDict.Add("custName", 0)
                        returnDict.Add("custPlace", 0)
                        returnDict.Add("custCost", 0)
                    End If

                    reader.Close()
                    End Using
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function

        Public Function getLeaderYear(parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Dim query As String = "EXECUTE leaderYear @Year = @Year"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Year", parameters.GetValueOrDefault("@year"))

                        connection.Open()

                        Dim reader As SqlDataReader = command.ExecuteReader()

                        If reader.HasRows Then
                            While reader.Read()
                                Dim totalCost As Integer = reader.GetInt32(0)
                                Dim customerName As String = reader.GetString(1)
                                Dim place As String = reader.GetString(2)
                                returnDict.Add("custName", customerName)
                                returnDict.Add("custPlace", place)
                                returnDict.Add("custCost", totalCost)

                            End While
                        Else
                            returnDict.Add("custName", 0)
                            returnDict.Add("custPlace", 0)
                            returnDict.Add("custCost", 0)
                            MsgBox("No date found on your preference")
                        End If

                        reader.Close()
                    End Using
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function

        Public Function getProductMonth(parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Dim query As String = "EXECUTE sellingMonth @year = @Year, @month = @Month"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Year", parameters.GetValueOrDefault("@year"))
                        command.Parameters.AddWithValue("@Month", parameters.GetValueOrDefault("@month"))

                        connection.Open()

                        Dim reader As SqlDataReader = command.ExecuteReader()

                        If reader.HasRows Then
                            While reader.Read()
                                Dim productCost As Integer = reader.GetInt32(1)
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetInt32(2)
                                returnDict.Add("productName", productName)
                                returnDict.Add("productQty", productQty)
                                returnDict.Add("productCost", productCost)

                            End While
                        Else
                            returnDict.Add("productName", 0)
                            returnDict.Add("productQty", 0)
                            returnDict.Add("productCost", 0)
                            MsgBox("No date found on your preference")
                        End If

                        reader.Close()
                    End Using
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function

        Public Function getProductYear(parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Dim query As String = "EXECUTE sellingYear @year = @Year"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Year", parameters.GetValueOrDefault("@year"))

                        connection.Open()

                        Dim reader As SqlDataReader = command.ExecuteReader()

                        If reader.HasRows Then
                            While reader.Read()
                                Dim productCost As Integer = reader.GetInt32(1)
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetInt32(2)
                                returnDict.Add("productName", productName)
                                returnDict.Add("productQty", productQty)
                                returnDict.Add("productCost", productCost)

                            End While
                        Else
                            returnDict.Add("productName", 0)
                            returnDict.Add("productQty", 0)
                            returnDict.Add("productCost", 0)
                            MsgBox("No date found on your preference")
                        End If

                        reader.Close()
                    End Using
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function

        Public Function getStockList(queryStockList As String) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Using conn As SqlConnection = New SqlConnection(connectionString)
                    Using Command As SqlCommand = New SqlCommand(queryStockList, conn)
                        conn.Open()
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        If reader.HasRows Then
                            Dim i As Integer = 1
                            While reader.Read()
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetString(1)
                                returnDict.Add("prd" + (i.ToString()), productName)
                                returnDict.Add("qty" + (i.ToString()), productQty)
                                i += 1
                            End While
                        Else
                            Dim i As Integer = 1
                            While i < 11
                                returnDict.Add("prd" + (i.ToString()), 0)
                                returnDict.Add("qty" + (i.ToString()), 0)
                                i += 1
                            End While
                        End If
                    End Using
                    conn.Close()
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function


        Public Function getSalesMonth(queryMonthSales As String, queryTotalSales As String, parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Using conn As SqlConnection = New SqlConnection(connectionString)
                    conn.Open()
                    Using Command As SqlCommand = New SqlCommand(queryMonthSales, conn)
                        Command.Parameters.AddWithValue("@month", parameters.GetValueOrDefault("@month"))
                        Command.Parameters.AddWithValue("@year", parameters.GetValueOrDefault("@year"))
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        Dim monthCost As Integer = 0
                        If reader.HasRows Then
                            reader.Read()
                            monthCost = reader.GetInt32(0)
                            returnDict.Add("monthCost", monthCost)
                        Else
                            returnDict.Add("monthCost", 2)
                        End If
                        conn.Close()
                    End Using
                    conn.Open()
                    Using Command As SqlCommand = New SqlCommand(queryTotalSales, conn)
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        Dim totalCost As Integer = 0
                        If reader.HasRows Then
                            reader.Read()
                            totalCost = reader.GetInt32(0)
                            returnDict.Add("totalCost", totalCost)
                        Else
                            returnDict.Add("totalCost", 2)
                        End If
                    End Using
                    conn.Close()
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function
        Public Function getSalesYear(queryYearSales As String, queryTotalSales As String, parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Try
                Using conn As SqlConnection = New SqlConnection(connectionString)
                    conn.Open()
                    Using Command As SqlCommand = New SqlCommand(queryYearSales, conn)
                        Command.Parameters.AddWithValue("@year", parameters.GetValueOrDefault("@year"))
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        Dim YearCost As Integer = 0
                        If reader.HasRows Then
                            reader.Read()
                            YearCost = reader.GetInt32(0)
                            returnDict.Add("yearCost", YearCost)
                        Else
                            returnDict.Add("yearCost", 0)
                        End If
                        conn.Close()
                    End Using
                    conn.Open()
                    Using Command As SqlCommand = New SqlCommand(queryTotalSales, conn)
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        Dim totalCost As Integer = 0
                        If reader.HasRows Then
                            reader.Read()
                            totalCost = reader.GetInt32(0)
                            returnDict.Add("totalCost", totalCost)
                        Else
                            returnDict.Add("totalCost", 0)
                        End If
                    End Using
                    conn.Close()
                End Using
                Return returnDict
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return returnDict
            End Try
        End Function
    End Module




