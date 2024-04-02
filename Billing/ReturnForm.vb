Imports System.Data.SqlClient
Imports System.Reflection.Metadata
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.ApiConfig

Public Class ReturnForm
    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BillNo.Focus()
        LoadGrid("Nothing")
        Dim delete As New DataGridViewButtonColumn()
        With delete
            .Name = "del"
            .HeaderText = "DELETE"
            .Text = "DELETE"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        delete.UseColumnTextForButtonValue = True
        ReturnGrid.Columns.Add(delete)

    End Sub



    Private Sub LoadGrid(Billno)
        Dim Query As String = "SELECT Rt.ReturnId As 'RETURNID',PRO.Product_name As 'PRODUCT NAME',Rt.Quantity As 'QUANTITY',Rt.Price As 'PRICE',Rt.Total As 'TOTAL' FROM ReturnTable AS Rt  inner join Products As PRO on PRO.Barcode = Rt.Barcode where Rt.Billing_no = @BillNo and Rt.Status =0 "
        Dim parameter As New List(Of SqlParameter)
        parameter.Add(New SqlParameter("@BillNo", Billno))
        gridWithPram(ReturnGrid, Query, {0, 1, 2, 3, 4}.ToList, {80, 80, 180, 140, 100}.ToList, parameter)
        CalculateGrandTotal(Billno)
        CalculateCurrentTotal(Billno)
    End Sub
    Private Sub ReturnProduct()
        Dim Query As String = "select sum(Total) As 'Total' from  ReturnTable where Billing_no =@BillNo"
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", Me.BillNo.Text)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            If Len(Me.GrandTotal.Text) <> 0 And Me.GrandTotal.Text <> 0 And Len(Me.BillNo.Text) <> 0 Then
                                Dim UpdateQuery As String = "update ReturnTable set Status=1,GrandTotal=@GrandTotal where Billing_no = @BillNo "
                                Dim UpdateQueryparameter As New List(Of SqlParameter)
                                UpdateQueryparameter.Add(New SqlParameter("@GrandTotal", Convert.ToInt32(reader("Total"))))
                                UpdateQueryparameter.Add(New SqlParameter("@BillNo", Me.BillNo.Text))
                                If QueryProcess(UpdateQuery, UpdateQueryparameter) = 1 Then
                                    MsgBox("Return The Product")
                                    Me.BillNo.Clear()
                                    Me.BillNo.ReadOnly = False
                                    Me.BillNo.Focus()
                                    Me.Barcode.Clear()
                                    LoadGrid("Nothing")
                                End If
                            Else
                                MsgBox($"Please Add The Return Details", MsgBoxStyle.Information, "Info")

                            End If

                        End While
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred ReturnProduct: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
        Finally
            con.Close()
        End Try
    End Sub
    Sub CalculateGrandTotal(BillNo)
        If Len(Me.BillNo.Text) <> 0 Then
            Dim Query As String = "select sum(Total) As 'Total' from  ReturnTable where Billing_no =@BillNo"
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(Query, con)
                    command.Parameters.AddWithValue("@BillNo", BillNo)
                    con.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()

                                Dim GrandTot As Int32 = Convert.ToInt32(reader("Total").ToString)
                                Me.GrandTotal.Text = GrandTot
                            End While
                        End If
                    End Using

                End Using
                ' Execute the query
            Catch ex As Exception
                'MsgBox($"SQL Exception occurred CalculateGrandTotal: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
                Me.GrandTotal.Text = 0
            Finally
                con.Close()
            End Try
        End If

    End Sub


    Sub CalculateCurrentTotal(BillNo)
        If Len(Me.BillNo.Text) <> 0 Then
            Dim Query As String = "select sum(Total) As 'Total' from  ReturnTable where Billing_no =@BillNo And Status=0"
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(Query, con)
                    command.Parameters.AddWithValue("@BillNo", BillNo)
                    con.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()

                                Dim GrandTot As Int32 = Convert.ToInt32(reader("Total").ToString)
                                Me.CurrentTotal.Text = GrandTot
                            End While
                        End If
                    End Using

                End Using
                ' Execute the query
            Catch ex As Exception
                'MsgBox($"SQL Exception occurred CalculateGrandTotal: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
                Me.CurrentTotal.Text = 0
            Finally
                con.Close()
            End Try
        End If

    End Sub
    Private Sub GetTheProduct(BillNo, Barcode)
        Dim Query As String = "select Bill.Barcode As 'BARCODE',Bill.Quantity As 'QUANTITY',Bill.Price As 'PRICE',Bill.Product_id As 'PRODUCT ID' from Billing AS Bill where Bill.Barcode =@Barcode And Bill.Billing_no =@BillNo"
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                command.Parameters.AddWithValue("@Barcode", Barcode)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim Barcodeval As String = reader("BARCODE").ToString()
                            Dim BillQuantity As Int32 = Convert.ToInt32(reader("QUANTITY").ToString)
                            Dim Price As Int32 = Convert.ToInt32(reader("PRICE"))
                            InsertReturnProduct(BillNo, BillQuantity, Barcodeval, Price)
                        End While
                    Else
                        MsgBox("Provide Appropriate Details")
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred GetTheProduct: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub InsertReturnProduct(BillNo, BillQuantity, Barcodeval, Price)
        Dim Query As String = "select Billing_no,sum(Quantity) As 'Quantity',Price from  ReturnTable where Billing_no =@BillNo and Barcode =@Barcodeval GROUP BY Billing_no, Price"
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try

            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                command.Parameters.AddWithValue("@Barcodeval", Barcodeval)

                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()

                            Dim CurrentQuantity As Int32 = Convert.ToInt32(reader("Quantity"))
                            If CurrentQuantity < BillQuantity Then
                                Dim InsertQuery As String = "Insert into ReturnTable (Billing_no,Barcode,Quantity,Price,Total,GrandTotal,ReturnBy,Date,Status) values(@Billingno,@Barcodeval,@Quantity,@Price,@Total,@GrandTotal,@ReturnBy,GETDATE(),0)"
                                Dim FirstQuantity = 1
                                Dim FirstTotal = FirstQuantity * Price
                                Dim InsertParameter As New List(Of SqlParameter)
                                InsertParameter.Add(New SqlParameter("@Billingno", BillNo))
                                InsertParameter.Add(New SqlParameter("@Barcodeval", Barcodeval))
                                InsertParameter.Add(New SqlParameter("@Quantity", FirstQuantity))
                                InsertParameter.Add(New SqlParameter("@Price", Price))
                                InsertParameter.Add(New SqlParameter("@Total", FirstTotal))
                                InsertParameter.Add(New SqlParameter("@GrandTotal", 0))
                                InsertParameter.Add(New SqlParameter("@ReturnBy", UserId))
                                If QueryProcess(InsertQuery, InsertParameter) = 1 Then
                                    LoadGrid(BillNo)
                                End If
                            Else
                                MsgBox("Already Added")
                            End If

                        End While

                    Else
                        Dim InsertQuery As String = "Insert into ReturnTable (Billing_no,Barcode,Quantity,Price,Total,GrandTotal,ReturnBy,Date,Status) values(@Billingno,@Barcodeval,@Quantity,@Price,@Total,@GrandTotal,@ReturnBy,GETDATE(),0)"
                        Dim FirstQuantity = 1
                        Dim FirstTotal = FirstQuantity * Price
                        Dim InsertParameter As New List(Of SqlParameter)
                        InsertParameter.Add(New SqlParameter("@Billingno", BillNo))
                        InsertParameter.Add(New SqlParameter("@Barcodeval", Barcodeval))
                        InsertParameter.Add(New SqlParameter("@Quantity", FirstQuantity))
                        InsertParameter.Add(New SqlParameter("@Price", Price))
                        InsertParameter.Add(New SqlParameter("@Total", FirstTotal))
                        InsertParameter.Add(New SqlParameter("@GrandTotal", 0))
                        InsertParameter.Add(New SqlParameter("@ReturnBy", UserId))
                        If QueryProcess(InsertQuery, InsertParameter) = 1 Then
                            LoadGrid(BillNo)
                        End If

                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred InsertReturnProduct: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Function DeleteReturnProduct(Sqlquery As String, Parameters As List(Of SqlParameter))
        Try
            Using con As SqlConnection = New SqlConnection(connectionString)
                con.Open()
                Using command1 As New SqlCommand(Sqlquery, con)
                    ' Add parameters to the SqlCommand
                    For Each parameter As SqlParameter In Parameters
                        command1.Parameters.Add(parameter)
                    Next
                    command1.ExecuteNonQuery()
                End Using
            End Using
            ' If execution completes without errors, return 1
            Return 1
        Catch ex As Exception
            ' Log the exception or handle it appropriately
            Debug.WriteLine("An error occurred: " & ex.Message)
            ' If an error occurs, return -1
            Return -1
        End Try
    End Function



    Private Sub BillNo_KeyDown(sender As Object, e As KeyEventArgs) Handles BillNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Barcode.Focus()
            Me.BillNo.ReadOnly = True
        End If
    End Sub

    Private Sub Barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BillNo.ReadOnly = False
        Me.BillNo.Focus()
        LoadGrid("Nothing")
        CurrentTotal.Text = 0
        GrandTotal.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Me.Barcode.Text) <> 0 Then
            GetTheProduct(Me.BillNo.Text, Me.Barcode.Text)
            LoadGrid(Me.BillNo.Text)
            Me.BillNo.ReadOnly = True
            Me.Barcode.Clear()
            Me.Barcode.Focus()
            LoadGrid(Me.BillNo.Text)
        Else
            MsgBox("Please Enter The Barcode!")
            Me.Barcode.Focus()

        End If
    End Sub


    Private Sub Barcode_GotFocus(sender As Object, e As EventArgs) Handles Barcode.GotFocus
        If Len(Me.BillNo.Text) <> 0 Then
            Me.BillNo.ReadOnly = True
            Me.Barcode.Clear()
            Me.Barcode.Focus()
            LoadGrid(Me.BillNo.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.GrandTotal.Text > 0 Then
            If FinalizeReturnForIncreaseQuantity(Me.BillNo.Text) = 1 Then
                ReturnProduct()
                LoadGrid("Nothing")
                CurrentTotal.Text = 0
                GrandTotal.Text = 0
            Else
                MsgBox("Something Went Wrong!")
            End If

        Else
            MsgBox($"Please Add The Return Details", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub ReturnGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnGrid.CellContentClick
        If ReturnGrid.Columns(e.ColumnIndex).Name = "del" Then
            Dim ReturnId As String = ReturnGrid.Rows(e.RowIndex).Cells(1).Value.ToString()
            'MsgBox(ReturnId)
            Dim DeleteQuery As String = "DELETE FROM ReturnTable WHERE ReturnId=@ReturnId;"
            Dim parameters As New List(Of SqlParameter)
            parameters.Add(New SqlParameter("@ReturnId", Convert.ToInt32(ReturnId)))
            If DeleteReturnProduct(DeleteQuery, parameters) = 1 Then
                LoadGrid(Me.BillNo.Text)
            End If
        End If
    End Sub
End Class