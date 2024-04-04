Public Class Barcode

    Private Sub Barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter the Product  :"
        PictureBox1.Visible = False
        load()
        Dim View_button = New DataGridViewButtonColumn()
        With View_button
            .Name = "Edit"
            .HeaderText = "Print"
            .Text = "Print"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        View_button.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(View_button)
        DataGridView1.SelectionMode = False


    End Sub


    Private Sub ButtonColumn_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim clickedRowIndex As Integer = e.RowIndex
        Dim barcodee = DataGridView1.CurrentRow.Cells(5).Value()
        PictureBox1.Image = generate(barcodee)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub
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
        e.Graphics.DrawImage(PictureBox1.Image, 4, 4)
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        load()
    End Sub

    Public Sub autocomplete()
        Dim query As String = "Select product_id as 'Product Id', product_name , Category.Category as Category , brands.brand as 'Brand Name',Barcode from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and products.product_name Like '%" & TextBox1.Text.Replace("'", "''") & "%' and products.status='1'"
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
        Dim query As String = "Select product_id as 'Product Id', product_name as 'Product Name', Category.Category as Category , brands.brand as 'Brand Name',Barcode from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and products.product_name Like '%" & TextBox1.Text.Replace("'", "''") & "%' and products.status='1'"
        Dim dataTable As DataTable = LoadDataTable(query)
        DataGridView1.DataSource = dataTable
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Purple
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub



End Class