Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class salesreport
    Public query As String
    Private Sub update_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox2.Items.Add("")
        ComboBox3.Items.Add("")
        ComboBox4.Items.Add("")
        Add_list("select product_name from products where status='1'", ComboBox4, "product_name")
        Add_list("select category from category where status = '1' ", ComboBox2, "category")
        Add_list("select brand from brands where status = '1' ", ComboBox3, "brand")
    End Sub


    Public Sub load_data()
        query = "Select product_id as 'Product Id', product_name as 'Product Name', Category.Category as Category , brands.brand as 'Brand Name' , Quantity , Price, Barcode from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and products.status='1'"
        If ComboBox2.SelectedItem <> "" Then
            query += " and Products.cat_id = (select cat_id from category where category = '" + ComboBox2.SelectedItem + "' )"
        End If
        If ComboBox3.SelectedItem <> "" Then
            query += " and brands.brand_id = (select brand_id from brands where brand= '" + ComboBox3.SelectedItem + "' )"
        End If
        If ComboBox4.SelectedItem <> "" Then
            query += " and product_name ='" + ComboBox4.SelectedItem + "'"
        End If

        If Len(ComboBox2.SelectedItem) Or Len(ComboBox3.SelectedItem) <> 0 Or Len(ComboBox4.SelectedItem) <> 0 Then
            Dim dataTable As DataTable = LoadDataTable(query)
            If dataTable IsNot Nothing Then
                DataGridView1.DataSource = dataTable
                DataGridView1.Columns(0).Width = 180
                DataGridView1.Columns(1).Width = 330
                DataGridView1.Columns(2).Width = 300
                DataGridView1.Columns(3).Width = 200
                DataGridView1.Columns(4).Width = 100
                DataGridView1.Columns(5).Width = 213
                DataGridView1.Columns(6).Visible = False
                DataGridView1.ClearSelection()
                DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
                DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
                DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

            Else
            End If
        Else
            DataGridView1.DataSource = ""
        End If

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        load_data()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        load_data()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        load_data()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        DataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Outset
        DataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Outset
        DataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Inset
        If e.RowIndex Mod 2 = 0 Then

            e.CellStyle.BackColor = Color.DarkGray
        Else
            e.CellStyle.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
        update_productid = selectedRow.Cells(0).Value.ToString
        common.update_product = selectedRow.Cells(1).Value.ToString
        update_quantity = selectedRow.Cells(4).Value.ToString
        update_category = selectedRow.Cells(2).Value.ToString
        update_brand = selectedRow.Cells(3).Value.ToString
        update_barcode = selectedRow.Cells(6).Value.ToString
        update_price = selectedRow.Cells(5).Value.ToString
        common.update = "1"
        Dim frm = New Add_Product
        frm.ShowDialog()
        frm.MdiParent = Form1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
