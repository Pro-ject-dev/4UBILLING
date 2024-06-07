Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Barcode
    Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
    Dim barcodeimage As Image
    Dim RetailPrice
    Dim Category
    Dim BarcodeNo
    Private Sub Barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter the Product  :"
        PictureBox1.Visible = False
        load()
    End Sub


    Private Sub ButtonColumn_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim clickedRowIndex As Integer = e.RowIndex
            Dim barcodee = DataGridView1.CurrentRow.Cells(4).Value()
            BarcodeNo = DataGridView1.CurrentRow.Cells(4).Value()
            PictureBox1.Image = generate(barcodee)
            RetailPrice = DataGridView1.CurrentRow.Cells(5).Value()
            Category = DataGridView1.CurrentRow.Cells(2).Value()
            'MsgBox(RetailPrice)
            'MsgBox(Category)
            barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, barcodee.ToString))
            Dim print As New PrintDialog()
            print.Document = PrintDocument1
            Dim myPrinters = PrinterSettings.InstalledPrinters.OfType(Of String).
                     Where(Function(p) p.Contains("SNBC TVSE LP 46 NEO BPLE")).ToList()
            If Not myPrinters.Count > 0 Then
                MsgBox("printer Not Found!")
            Else
                Dim printerName As String = myPrinters(0)
                'MsgBox("Printer found: " & printerName)
                ' Set the printer for PrintDocument
                PrintDocument1.PrinterSettings.PrinterName = printerName
            End If

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            If print.ShowDialog() = DialogResult.OK Then
                PrintDocument1.PrinterSettings.Copies = print.PrinterSettings.Copies
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    'Public Function GetThePrice(ProductId As Int16)
    '    Dim Query As String = "Select Price from Products where Product_id=@ProductId"
    '    Dim con As SqlConnection = New SqlConnection(connectionString)
    '    Dim priceval As Int32 = 0
    '    MsgBox(ProductId)
    '    Try
    '        Using command As New SqlCommand(Query, con)
    '            command.Parameters.AddWithValue("@ProductId", ProductId)
    '            con.Open()
    '            Using reader As SqlDataReader = command.ExecuteReader()
    '                If reader.HasRows Then
    '                    While reader.Read()
    '                        priceval = Convert.ToInt32(reader("Price"))
    '                        MsgBox(priceval)
    '                        Return priceval

    '                    End While

    '                Else
    '                    Return 0
    '                    MessageBox.Show($"An error occurred ProductId : {ProductId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            End Using

    '        End Using
    '        ' Execute the query
    '    Catch ex As Exception
    '        MsgBox($"SQL Exception occurred FinalizeBill: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
    '    Finally
    '        con.Close()
    '    End Try
    'End Function
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        DataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Outset
        DataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Outset
        DataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Inset
        If e.RowIndex Mod 2 = 0 Then

            e.CellStyle.BackColor = Color.LightBlue
        Else
            e.CellStyle.BackColor = Color.GhostWhite
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim height2 = 0
        'e.Graphics.DrawImage(PictureBox1.Image, 4, 4)
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim center As New StringFormat
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)
        Dim f12b As New Font("Calibri", 12, FontStyle.Bold)
        Dim f11b As New Font("Calibri", 11, FontStyle.Bold)
        Dim f8b As New Font("Calibri", 8, FontStyle.Bold)
        'First Bill
        e.Graphics.DrawString("4U FASHION LOOK", f14, Brushes.Black, 10, 2, center)
        e.Graphics.DrawImage(barcodeimage, 25, 22, 100, 35)
        e.Graphics.DrawString(BarcodeNo.ToString, f11b, Brushes.Black, 40, 50, center)
        e.Graphics.DrawString(Category.ToString, f8b, Brushes.Black, 10, 65, center)
        e.Graphics.DrawString("MRP:" + " " + RetailPrice.ToString, f12b, Brushes.Black, 10, 75, center)
        'Second Bill
        e.Graphics.DrawString("4U FASHION LOOK", f14, Brushes.Black, 230, 2, center)
        e.Graphics.DrawImage(barcodeimage, 250, 22, 100, 35)
        e.Graphics.DrawString(BarcodeNo.ToString, f11b, Brushes.Black, 265, 50, center)
        e.Graphics.DrawString(Category.ToString, f8b, Brushes.Black, 230, 65, center)
        e.Graphics.DrawString("MRP:" + " " + RetailPrice.ToString, f12b, Brushes.Black, 230, 75, center)
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        load()
    End Sub

    Public Sub autocomplete()
        Dim query As String = "Select product_id as 'Product Id', product_name , Category.Category as Category , brands.brand as 'Brand Name',Barcode from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and ( products.product_name Like '%" & TextBox1.Text.Replace("'", "''") & "%' or products.product_id like '%" & TextBox1.Text.Replace("'", "''") & "%') and products.status='1' order by products.product_id"
        Dim dataTable As DataTable = LoadDataTable(query)

        If dataTable IsNot Nothing Then

            Dim col As New AutoCompleteStringCollection
            For Each row As DataRow In dataTable.Rows
                col.Add(row("product_name").ToString)
            Next
            TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBox1.AutoCompleteCustomSource = col
            TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        End If

    End Sub

    Public Sub load()
        Dim query As String = "Select product_id as 'Product Id', product_name as 'Product Name', Category.Category as Category , brands.brand as 'Brand Name',Barcode,products.price from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and (products.product_name Like '%" & TextBox1.Text.Replace("'", "''") & "%' or products.product_id like '%" & TextBox1.Text.Replace("'", "''") & "%') and products.status='1' order by products.product_id"
        Dim dataTable As DataTable = LoadDataTable(query)
        DataGridView1.DataSource = dataTable
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 110
        DataGridView1.Columns(5).Width = 110



    End Sub


End Class