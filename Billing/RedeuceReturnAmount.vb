Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module RedeuceReturnAmount

    Public Function GetTheReturnAmount(BillNo) As Double
        Dim Query As String = "select Sum(convert(float,Total)) As 'Total' from ReturnTable where Status=1 and Returned=0 and Billing_no=@BillNo"
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            If reader("Total").ToString = "" Then
                                Return Convert.ToDouble(0)
                            Else
                                Dim totalValue As Double = Convert.ToDouble(reader("Total"))
                                Dim roundedTotal As Double = Math.Round(totalValue)
                                Dim roundedTotalAsString As String = roundedTotal.ToString()
                                Return totalValue
                            End If
                        End While
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred CalculateGrandTotal: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return Convert.ToDouble(0)
        Finally
            con.Close()
        End Try
    End Function
End Module
