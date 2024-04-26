Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Metadata
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.ApiConfig

Public Class ReturnForm
    Public Currentot As Double = 0
    Public allow = 0
    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BillNo.Focus()
        LoadGrid("Summa")
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
        Dim gridSizes As New List(Of Double)

        If allow = 0 Then
            allow = 1
            gridSizes.AddRange({screenwidth / 100, screenwidth / 150, screenwidth / 100, screenwidth / 100, screenwidth / 100})
        Else
            gridSizes.AddRange({screenwidth / 100, screenwidth / 100, screenwidth / 150, screenwidth / 100, screenwidth / 100, screenwidth / 100})
        End If
        Dim objgrid As New GridClass
        objgrid.gridWithPram(ReturnGrid, Query, {0, 1, 2, 3, 4}.ToList, gridSizes, parameter)
        CalculateGrandTotal(Billno)
        CalculateCurrentTotal(Billno)
    End Sub
    Private Sub ReturnProduct()
        Dim Query As String = "select sum(convert(float,Total)) As 'Total' from  ReturnTable where Billing_no =@BillNo"
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
                                Currentot = Convert.ToDouble(Sum(Me.BillNo.Text))
                                If GenerateBill() = 1 Then
                                    If QueryProcess(UpdateQuery, UpdateQueryparameter) = 1 Then
                                        MsgBox("Return The Product")
                                        Me.BillNo.Clear()
                                        Me.BillNo.ReadOnly = False
                                        Me.BillNo.Focus()
                                        Me.Barcode.Clear()
                                        LoadGrid("Summa")
                                    End If
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
            Dim Query As String = "select sum(convert(float,Total)) As 'Total' from  ReturnTable where Billing_no =@BillNo"
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(Query, con)
                    command.Parameters.AddWithValue("@BillNo", BillNo)
                    con.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()

                                Dim GrandTot As Double = Convert.ToDouble(reader("Total").ToString)
                                Me.GrandTotal.Text = GrandTot.ToString("0.00")
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
            Dim Query As String = "select sum(convert(float,Total)) As 'Total' from  ReturnTable where Billing_no =@BillNo And Status=0"
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(Query, con)
                    command.Parameters.AddWithValue("@BillNo", BillNo)
                    con.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()

                                Dim GrandTot As Double = Convert.ToDouble(reader("Total").ToString)
                                Me.CurrentTotal.Text = GrandTot.ToString("0.00")
                            End While
                        End If
                    End Using

                End Using
                ' Execute the query
            Catch ex As Exception
                'MsgBox($"SQL Exception occurred CalculateCurrentTotal: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
                Me.CurrentTotal.Text = 0
            Finally
                con.Close()
            End Try
        End If

    End Sub
    Private Function GenerateBill()
        Try
            changelongpaper()
            Dim printDialog As New PrintDialog()
            printDialog.Document = PD
            If printDialog.ShowDialog() = DialogResult.OK Then
                PD.Print()
            End If
            Return 1
        Catch ex As Exception
            Return -1
        End Try

    End Function
    Dim WithEvents PD As New PrintDocument
    'Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = ReturnGrid.Rows.Count
        longpaper = rowcount * 70 + 300
        longpaper = longpaper + 200
    End Sub


    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim d As String = DateTime.Now.ToString("dd-MM-yyyy")
        Dim stat As String = TimeOfDay.ToString("h:mm:ss tt")
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        Dim rightmarginforto As Integer = PD.DefaultPageSettings.Margins.Right
        Dim rightmarginforpr As Integer = PD.DefaultPageSettings.Margins.Right

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim pr As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        pr.Alignment = StringAlignment.Near
        'RMS Complex , Near Canara Bank , Puduvalavu , Ponnamaravathi , Pudukkottai - Dt , Cell : 78712 93638.

        Dim line As String
        line = "--------------------------------------------------------------------------"
        Dim b As String
        b = Me.BillNo.Text
        'range from top
        e.Graphics.DrawString("4U FASHION LOOK", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("RMS Complex, Near Canara Bank, Puduvalavu", f10, Brushes.Black, centermargin + 1, 25, center)
        'e.Graphics.DrawString("RMS Complex, Near Canara Bank, Puduvalavu", f10, Brushes.Black, 10, 25, center)
        e.Graphics.DrawString("Pudukkottai - Dt,Cell : 78712 93638", f10, Brushes.Black, centermargin, 40, center)
        Dim BillAndDatehi As Integer = 70
        e.Graphics.DrawString(DateTime.Now(), f8, Brushes.Black, 120, BillAndDatehi)
        e.Graphics.DrawString("BillNo", f8, Brushes.Black, 0, BillAndDatehi)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, BillAndDatehi)
        e.Graphics.DrawString(b, f8, Brushes.Black, 70, BillAndDatehi)
        Dim CashierAndAdminhi As Integer = 80
        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, CashierAndAdminhi)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, CashierAndAdminhi)
        e.Graphics.DrawString("Admin", f8, Brushes.Black, 70, CashierAndAdminhi)
        'e.Graphics.DrawString(DateTime.Now(), f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)
        e.Graphics.DrawString("Product Name", f10b, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Quantity", f10b, Brushes.Black, 25, 135)
        e.Graphics.DrawString("Price", f10b, Brushes.Black, 85, 135)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, 150, 135)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 150)
        Dim height As Integer 'DGV Position
        ReturnGrid.AllowUserToAddRows = False
        'If DataGridView1.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        Dim hi As Integer
        height = 50
        hi = 0
        Dim initialval As Integer = 0
        Dim billingDetails As DataTable = GetBillingDetails(Me.BillNo.Text)
        For Each row As DataRow In billingDetails.Rows
            height += 20 + hi
            'MsgBox(row)
            'Product Name
            'hi = row * 2
            hi = 17 + initialval
            'MsgBox(row("ProductName").ToString())
            e.Graphics.DrawString(row("ProductName").ToString(), f10, Brushes.Black, 0, 100 + height)
            'Quantity
            e.Graphics.DrawString(row("Quantity").ToString(), f10, Brushes.Black, 25, 100 + height + hi)
            'price
            e.Graphics.DrawString(row("price").ToString(), f10, Brushes.Black, 80, 100 + height + hi)
            'Total
            e.Graphics.DrawString(row("Total").ToString(), f10, Brushes.Black, 150, 100 + height + hi)
            initialval += 1
        Next

        Dim height2 As Integer
        height2 = 110 + height + hi + 20
        'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        'e.Graphics.DrawString("0", f10b, Brushes.Black, 170, 10 + height2)
        e.Graphics.DrawString("Total Quantity:" + " " + Currentot.ToString, f10b, Brushes.Black, 10, 10 + height2)
        e.Graphics.DrawString("Net Amount:    " + " " + CurrentTotal.Text, f10b, Brushes.Black, 10, 10 + height2 + 20)
        e.Graphics.DrawString("~ Thanks for visting ~", f10, Brushes.Black, centermargin, 10 + height2 + 50, center)

        'e.Graphics.DrawString("~ Nosware Store ~", f10, Brushes.Black, centermargin, 50 + height2, center)
    End Sub
    Function Sum(BillNo)
        Dim Query As String = "select Sum(Quantity) as 'Quantity'  from ReturnTable where Status = 0 and Billing_no =@Billno and Returned = 0"
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            'MsgBox(reader("Quantity"))
                            Return Convert.ToInt32(reader("Quantity"))
                        End While
                    Else
                        Return 0
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            Return 0

        Finally
            con.Close()
        End Try
    End Function

    Private Function GetBillingDetails(billingNo As String) As DataTable
        Dim query As String = "select Products.Product_name As 'ProductName',sum(ReturnTable.Quantity) As 'Quantity', ReturnTable.Price As 'price',sum(convert(float,ReturnTable.Total)) As 'Total' from ReturnTable inner join Products on  Products.Product_id = ReturnTable.Product_id  where Billing_no=@BillingNo And  ReturnTable.Status =0 Group by Products.Product_name,ReturnTable.Price"
        Dim dataTable As New DataTable()
        'MsgBox(billingNo)
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
    Private Sub GetTheProduct(BillNo, Barcode)
        Dim Query As String = "select Bill.Barcode As 'BARCODE',Bill.Quantity As 'QUANTITY',Bill.Price As 'PRICE',Bill.Product_id As 'PRODUCT ID',Bill.Customer_id As 'CUSTOMER ID' from Billing AS Bill where Bill.Barcode =@Barcode And Bill.Billing_no =@BillNo And Status=1"
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
                            Dim Price As String = reader("PRICE").ToString
                            Dim productId As Int32 = Convert.ToInt32(reader("PRODUCT ID"))
                            Dim CustomerId As Int32 = Convert.ToInt32(reader("CUSTOMER ID"))

                            InsertReturnProduct(BillNo, BillQuantity, Barcodeval, Price, productId, CustomerId)
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

    Private Sub InsertReturnProduct(BillNo, BillQuantity, Barcodeval, Price, productId, CustomerId)
        Dim Query As String = "select Billing_no,sum(Quantity) As 'Quantity',Price from  ReturnTable where Billing_no =@BillNo and Barcode =@Barcodeval  GROUP BY Billing_no, Price"
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
                                Dim InsertQuery As String = "Insert into ReturnTable (Billing_no,Barcode,Quantity,Price,Total,GrandTotal,ReturnBy,Date,Status,Product_id,Returned,Customer_id) values(@Billingno,@Barcodeval,@Quantity,@Price,@Total,@GrandTotal,@ReturnBy,GETDATE(),0,@Product_id,0,@Customer_id)"
                                Dim FirstQuantity = 1
                                Dim FirstTotal = FirstQuantity * Price
                                Dim InsertParameter As New List(Of SqlParameter)
                                InsertParameter.Add(New SqlParameter("@Billingno", BillNo))
                                InsertParameter.Add(New SqlParameter("@Barcodeval", Barcodeval))
                                InsertParameter.Add(New SqlParameter("@Quantity", FirstQuantity))
                                InsertParameter.Add(New SqlParameter("@Price", Price.ToString))
                                InsertParameter.Add(New SqlParameter("@Total", FirstTotal.ToString))
                                InsertParameter.Add(New SqlParameter("@GrandTotal", 0))
                                InsertParameter.Add(New SqlParameter("@ReturnBy", UserId))
                                InsertParameter.Add(New SqlParameter("@Product_id", Convert.ToInt32(productId)))
                                InsertParameter.Add(New SqlParameter("@Customer_id", CustomerId))
                                If QueryProcess(InsertQuery, InsertParameter) = 1 Then
                                    LoadGrid(BillNo)
                                End If
                            Else
                                MsgBox("Already Added")
                            End If

                        End While

                    Else
                        Dim InsertQuery As String = "Insert into ReturnTable (Billing_no,Barcode,Quantity,Price,Total,GrandTotal,ReturnBy,Date,Status,Product_id,Returned,Customer_id) values(@Billingno,@Barcodeval,@Quantity,@Price,@Total,@GrandTotal,@ReturnBy,GETDATE(),0,@Product_id,0,@Customer_id)"
                        Dim FirstQuantity = 1
                        Dim FirstTotal = FirstQuantity * Price
                        Dim InsertParameter As New List(Of SqlParameter)
                        InsertParameter.Add(New SqlParameter("@Billingno", BillNo))
                        InsertParameter.Add(New SqlParameter("@Barcodeval", Barcodeval))
                        InsertParameter.Add(New SqlParameter("@Quantity", FirstQuantity))
                        InsertParameter.Add(New SqlParameter("@Price", Price.ToString))
                        InsertParameter.Add(New SqlParameter("@Total", FirstTotal.ToString))
                        InsertParameter.Add(New SqlParameter("@GrandTotal", 0))
                        InsertParameter.Add(New SqlParameter("@ReturnBy", UserId))
                        InsertParameter.Add(New SqlParameter("@Product_id", Convert.ToInt32(productId)))
                        InsertParameter.Add(New SqlParameter("@Customer_id", CustomerId))
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
        LoadGrid("Summa")
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
                LoadGrid("Summa")
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

    Private Sub ReturnForm_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dim Query As String = "Delete ReturnTable where Billing_no=@BillNo"
        BILLING.DeleteBillWhenFormClose(Me.BillNo.Text, Query)
    End Sub

    Private Sub BillNo_TextChanged(sender As Object, e As EventArgs) Handles BillNo.TextChanged

    End Sub
End Class