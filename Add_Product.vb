Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing.Design
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MessagingToolkit.Barcode.Client.Results
Imports ZXing.Client.Result

Public Class Add_Product


    Dim barcode As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        common.status = "brand"
        Dim frm = New Add_dialogue
        frm.Show()
        frm.MdiParent = Form1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        common.status = "category"
        Dim frm = New Add_dialogue
        frm.Show()
        frm.MdiParent = Form1


    End Sub

    Public Sub Add_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If common.update = "1" Then
            Button2.Location = New Point(12, 400)
            Button5.Visible = True

        End If
        loaded()

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String = "SELECT barcode FROM products WHERE Product_id = (SELECT MAX(Product_id) FROM products)"
        Dim dataTable As DataTable = GetTableData(query)
        If dataTable.Rows.Count > 0 Then
            Dim firstRow As DataRow = dataTable.Rows(0)
            Dim value As Object = firstRow(0)
            Dim code As Integer = Integer.Parse(value)
            code = code + 1
            barcode = code.ToString
        Else
            barcode = "10000001"
        End If
        PictureBox1.Image = generate(barcode)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("Please Select the Category...")
        ElseIf ComboBox2.SelectedItem = Nothing Then
            MsgBox("Please Select the Brand...")
        ElseIf TextBox2.Text.Trim = "" Then
            MsgBox("Please Enter the Product Name...")
        ElseIf NumericUpDown1.Value = 0 Then
            MsgBox("Please Enter the Quantity...")
        ElseIf TextBox3.Text.Trim = "" Then
            MsgBox("Please Enter the Price...")
        ElseIf PictureBox1.Image Is Nothing Then
            MsgBox("Please Generate Barcode..")
        Else
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("Please Select the Category...")
        ElseIf ComboBox2.SelectedItem = Nothing Then
            MsgBox("Please Select the Brand...")
        ElseIf TextBox2.Text.Trim = "" Then
            MsgBox("Please Enter the Product Name...")
        ElseIf NumericUpDown1.Value = 0 Then
            MsgBox("Please Enter the Quantity...")
        ElseIf TextBox3.Text.Trim = "" Then
            MsgBox("Please Enter the Price...")
        ElseIf PictureBox1.Image Is Nothing Then
            MsgBox("Please Generate Barcode..")
        Else
            e.Graphics.DrawImage(PictureBox1.Image, 0, 0)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem = Nothing Then
            MsgBox("Please Select the Category...")
        ElseIf ComboBox2.SelectedItem = Nothing Then
            MsgBox("Please Select the Brand...")
        ElseIf TextBox2.Text.Trim = "" Then
            MsgBox("Please Enter the Product Name...")
        ElseIf NumericUpDown1.Value = 0 Then
            MsgBox("Please Enter the Quantity...")
        ElseIf TextBox3.Text.Trim = "" Then
            MsgBox("Please Enter the Price...")
        Else
            If common.update = "1" Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Update this Product ? ")

                If state Then


                    Dim updateQuery As String = "UPDATE products SET Cat_id=(select Cat_id from Category where Category=@value1), Product_name=@value2, Quantity=@value3, Price=@value4, Barcode=@value5, Brand_id=(select brand_id from Brands where Brand=@value6) WHERE product_id=@value7"

                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@value1", ComboBox1.SelectedItem)
                    valuesToInsert.Add("@value2", TextBox2.Text)
                    valuesToInsert.Add("@value3", NumericUpDown1.Value)
                    valuesToInsert.Add("@value4", TextBox3.Text)
                    valuesToInsert.Add("@value5", update_barcode)
                    valuesToInsert.Add("@value6", ComboBox2.SelectedItem)
                    valuesToInsert.Add("@value7", update_productid)

                    InsertData(updateQuery, valuesToInsert)
                    common.update = "0"
                    MsgBox("Product is updated successful !")
                    Dim dataTable As DataTable = LoadDataTable(update_product.query)
                    update_product.DataGridView1.DataSource = dataTable
                    update_product.DataGridView1.ClearSelection()


                    Me.Close()
                End If

            Else
                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Product ?")
                If state Then
                    Dim insertquery As String = "insert into products (Cat_id,Product_name,Quantity,Price,Barcode,Brand_id,Status )values((select Cat_id from Category where Category=@value1),@value2,@value3,@value4,@value5,(select brand_id from Brands where Brand=@value6),'1')"
                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@value1", ComboBox1.SelectedItem)
                    valuesToInsert.Add("@value2", TextBox2.Text)
                    valuesToInsert.Add("@value3", NumericUpDown1.Value)
                    valuesToInsert.Add("@value4", TextBox3.Text)
                    valuesToInsert.Add("@value5", barcode)
                    valuesToInsert.Add("@value6", ComboBox2.SelectedItem)
                    InsertData(insertquery, valuesToInsert)
                    MsgBox("Product is Added Successful !")
                End If
                clear()
            End If






        End If
    End Sub

    Public Sub clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        NumericUpDown1.Value = 0
        TextBox2.Text = ""
        TextBox3.Text = ""
        PictureBox1.Image = Nothing
        barcode = ""
        loaded()
    End Sub

    Public Sub loaded()
        Add_list("select * from category  where status='1' order by cat_id", ComboBox1, "category")
        Add_list("select * from brands  where status='1' order by brand_id", ComboBox2, "brand")
        If (common.update = "1") Then
            Button2.Text = "Update Product"
            Me.Text = "Update Products"
            ComboBox1.SelectedItem = update_category
            ComboBox2.SelectedItem = update_brand
            TextBox2.Text = common.update_product
            NumericUpDown1.Value = update_quantity
            TextBox3.Text = update_price
            Button1.Enabled = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False

        End If

    End Sub

    Private Sub Add_Product_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        common.update = "0"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim state As Boolean = ShowConfirmation("Are You Sure to Delete this Product ?")
        If state Then
            Dim deleteQuery As String = "UPDATE products Set status=0 where product_id = @value1"
            Dim valuesToInsert As New Dictionary(Of String, Object)
            valuesToInsert.Add("@value1", update_productid)
            InsertData(deleteQuery, valuesToInsert)
            MsgBox("Products Deleted Successful !")
            Me.Close()
            Dim dataTable As DataTable = LoadDataTable(update_product.query)
            update_product.DataGridView1.DataSource = dataTable
            update_product.DataGridView1.ClearSelection()
        End If



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ComboBox1.SelectedItem <> "" Then
            Dim count As Integer = GetRowCount("Select * From products where cat_id = (select Cat_id From Category where Category=@value1) and status='1'", New SqlParameter("@value1", ComboBox1.SelectedItem))
            MsgBox(count.ToString)

            If count = 0 Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Delete this Category ?")
                If state Then
                    Dim deleteQuery As String = "UPDATE Category Set status=0 where cat_id = (select Cat_id From Category where Category=@value1 and status='1')"
                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@value1", ComboBox1.SelectedItem)
                    InsertData(deleteQuery, valuesToInsert)
                    MsgBox("Category is Deleted Successful !")
                    ComboBox1.Items.Clear()
                    Add_list("select * from category  where status='1' order by cat_id", ComboBox1, "category")
                End If
            Else
                MsgBox("This Category is Added with Some Products !")
            End If
        Else

            MsgBox("Category is Not Selected")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox2.SelectedItem <> "" Then
            Dim count As Integer = GetRowCount("Select * From Products where brand_id = (select brand_id From brands where brand=@value1) and status='1'", New SqlParameter("@value1", ComboBox2.SelectedItem))

            MsgBox(count.ToString)
            If count = 0 Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Delete this Brand ?")
                If state Then
                    Dim deleteQuery As String = "UPDATE brands Set status=0 where brand_id  = (select brand_id From brands where brand=@value1 and status='1')"
                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@value1", ComboBox2.SelectedItem)
                    InsertData(deleteQuery, valuesToInsert)
                    MsgBox("Brand is Deleted Successful !")
                    ComboBox2.Items.Clear()
                    Add_list("select * from brands where status = '1' order by brand_id", ComboBox2, "brand")
                End If
            Else
                MsgBox("This Brand is Added with Some Products !")
            End If
        Else

            MsgBox("Brand is Not Selected")
        End If
    End Sub
End Class