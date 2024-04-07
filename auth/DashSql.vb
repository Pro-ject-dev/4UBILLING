Imports System.Data.SqlClient
Imports System.Windows.Input
Imports System.Xml.Schema


Module DashSql

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
                        'MsgBox(parameters.GetValueOrDefault("@year").ToString + "-" + parameters.GetValueOrDefault("@month").ToString)
                        While reader.Read()
                            If Not reader.IsDBNull(0) And Not reader.IsDBNull(1) And Not reader.IsDBNull(2) Then
                                Dim totalCost As Integer = reader.GetDouble(2)
                                Dim customerName As String = reader.GetString(0)
                                Dim place As String = reader.GetString(1)
                                returnDict.Add("custName", customerName)
                                returnDict.Add("custPlace", place)
                                returnDict.Add("custCost", totalCost)

                            Else
                                returnDict.Add("custName", "No Customer")
                                returnDict.Add("custPlace", "Place")
                                returnDict.Add("custCost", 0)

                            End If
                        End While
                    Else
                        returnDict.Add("custName", "No Customer")
                        returnDict.Add("custPlace", "Place")
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
                            If Not reader.IsDBNull(0) And Not reader.IsDBNull(1) And Not reader.IsDBNull(2) Then
                                Dim totalCost As Integer = reader.GetDouble(2)
                                Dim customerName As String = reader.GetString(0)
                                Dim place As String = reader.GetString(1)
                                returnDict.Add("custName", customerName)
                                returnDict.Add("custPlace", place)
                                returnDict.Add("custCost", totalCost)
                            Else
                                returnDict.Add("custName", "No Customer")
                                returnDict.Add("custPlace", "Place")
                                returnDict.Add("custCost", 0)
                            End If
                        End While
                    Else
                        returnDict.Add("custName", "No Customer")
                        returnDict.Add("custPlace", "Place")
                        returnDict.Add("custCost", 0)
                    End If

                    reader.Close()
                End Using
                connection.Close()
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
                            If Not reader.IsDBNull(0) And Not reader.IsDBNull(1) And Not reader.IsDBNull(2) Then
                                Dim productCost As String = reader.GetDouble(2)
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetInt32(1)
                                returnDict.Add("productName", productName)
                                returnDict.Add("productQty", productQty)
                                returnDict.Add("productCost", productCost)
                            Else
                                returnDict.Add("productName", "No Product")
                                returnDict.Add("productQty", 0)
                                returnDict.Add("productCost", 0)
                            End If
                        End While
                    Else
                        returnDict.Add("productName", "No Product")
                        returnDict.Add("productQty", 0)
                        returnDict.Add("productCost", 0)
                    End If

                    reader.Close()
                End Using
            End Using
            Return returnDict
        Catch ex As Exception
            MsgBox("err:" & ex.Message)

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
                            If Not reader.IsDBNull(0) And Not reader.IsDBNull(1) And Not reader.IsDBNull(2) Then
                                Dim productCost As Integer = reader.GetDouble(2)
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetInt32(1)
                                returnDict.Add("productName", productName)
                                returnDict.Add("productQty", productQty)
                                returnDict.Add("productCost", productCost)
                            Else
                                returnDict.Add("productName", "No Product")
                                returnDict.Add("productQty", 0)
                                returnDict.Add("productCost", 0)
                            End If
                        End While
                    Else
                        returnDict.Add("productName", "No Product")
                        returnDict.Add("productQty", 0)
                        returnDict.Add("productCost", 0)
                    End If

                    reader.Close()
                End Using
            End Using
            Return returnDict
        Catch ex As Exception
            MsgBox("err:" & ex.Message)
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
                    Dim i As Integer = 1
                    If reader.HasRows Then
                        While reader.Read()
                            If Not reader.IsDBNull(0) And Not reader.IsDBNull(1) Then
                                Dim productName As String = reader.GetString(0)
                                Dim productQty As String = reader.GetString(1)

                                returnDict.Add("prd" + (i.ToString()), productName)
                                returnDict.Add("qty" + (i.ToString()), Int32.Parse(productQty))
                                i += 1
                            Else
                                While i < 11
                                    returnDict.Add("prd" + (i.ToString()), "No Product")
                                    returnDict.Add("qty" + (i.ToString()), 0)
                                    i += 1
                                End While
                            End If
                        End While
                    Else
                        While i < 11
                            returnDict.Add("prd" + (i.ToString()), "No Product")
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
                        If Not reader.IsDBNull(0) Then
                            monthCost = reader.GetDouble(0)
                            returnDict.Add("monthCost", monthCost)
                        Else
                            returnDict.Add("monthCost", 0)
                        End If
                    Else
                        returnDict.Add("monthCost", 0)
                    End If
                    conn.Close()
                End Using
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(queryTotalSales, conn)
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    Dim totalCost As Integer = 0
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(0) Then
                            totalCost = reader.GetDouble(0)
                            returnDict.Add("totalCost", totalCost)
                        Else
                            returnDict.Add("totalCost", 0)
                        End If
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
                        If Not reader.IsDBNull(0) Then
                            YearCost = reader.GetDouble(0)
                            returnDict.Add("yearCost", YearCost)
                        Else
                            returnDict.Add("yearCost", 0)
                        End If
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
                        If Not reader.IsDBNull(0) Then
                            totalCost = reader.GetDouble(0)
                            returnDict.Add("totalCost", totalCost)
                        Else
                            returnDict.Add("totalCost", 0)
                        End If
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

    Public Function getCustomerMonth(queryCustQty As String, queryCustVisitQty As String, parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
        Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Try
            Using conn As SqlConnection = New SqlConnection(connectionString)
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(queryCustVisitQty, conn)
                    Command.Parameters.AddWithValue("@month", parameters.GetValueOrDefault("@month"))
                    Command.Parameters.AddWithValue("@year", parameters.GetValueOrDefault("@year"))
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    Dim custVisit As Integer = 0
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(0) Then
                            custVisit = reader.GetInt32(0)
                            returnDict.Add("custVisit", custVisit)
                        Else
                            returnDict.Add("custVisit", 0)
                        End If
                    Else
                        returnDict.Add("custVisit", 0)
                    End If
                    conn.Close()
                End Using
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(queryCustQty, conn)
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    Dim custQty As Integer = 0
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(0) Then
                            custQty = reader.GetInt32(0)
                            returnDict.Add("custQty", custQty)
                        Else
                            returnDict.Add("custQty", 0)
                        End If
                    Else
                        returnDict.Add("custQty", 0)
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
    Public Function getCustomerYear(queryCustQty As String, queryCustVisitQty As String, parameters As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
        Dim returnDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Try
            Using conn As SqlConnection = New SqlConnection(connectionString)
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(queryCustVisitQty, conn)
                    Command.Parameters.AddWithValue("@year", parameters.GetValueOrDefault("@year"))
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    Dim custVisit As Integer = 0
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(0) Then
                            custVisit = reader.GetInt32(0)
                            returnDict.Add("custVisit", custVisit)
                        Else
                            returnDict.Add("custVisit", 0)
                        End If
                    Else
                        returnDict.Add("custVisit", 0)
                    End If
                    conn.Close()
                End Using
                conn.Open()
                Using Command As SqlCommand = New SqlCommand(queryCustQty, conn)
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    Dim custQty As Integer = 0
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull(0) Then
                            custQty = reader.GetInt32(0)
                            returnDict.Add("custQty", custQty)
                        Else
                            returnDict.Add("custQty", 0)
                        End If
                    Else
                        returnDict.Add("custQty", 0)
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

    Public Function getSalesToday(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return dataTable
    End Function
End Module
