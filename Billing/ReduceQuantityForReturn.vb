Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module ReduceQuantityForReturn
    Private Function GetReturnDetails(billingNo As String) As DataTable
        Dim query As String = "  SELECT pr.Product_id, Rt.Quantity FROM ReturnTable As Rt inner join Products As pr on pr.Barcode = Rt.Barcode  WHERE Rt.Billing_no =@BillingNo and Rt.Status =0"
        Dim dataTable As New DataTable()

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BillingNo", billingNo)
                con.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function


    Public Function FinalizeReturnForIncreaseQuantity(billingNo As String) As Integer
        Try
            Dim billingDetails As DataTable = GetReturnDetails(billingNo)
            For Each row As DataRow In billingDetails.Rows
                Dim productId As String = row("Product_id").ToString()
                Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
                'Dim Quantitycheckdata As Int32 = QuantityCheck(Convert.ToInt32(productId), Convert.ToInt32(quantity))
                UpdateProductQuantityForReturn(productId, quantity)
            Next
            Return 1

        Catch ex As Exception
            MsgBox($"SQL Exception occurred FinalizeReturnForIncreaseQuantity: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return -1
        End Try
    End Function

    Public Sub UpdateProductQuantityForReturn(productId As String, quantity As Integer)
        Dim query As String = "UPDATE Products SET Quantity = Quantity + @Quantity WHERE Product_id = @ProductId"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(productId))
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
