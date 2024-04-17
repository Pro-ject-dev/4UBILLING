Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class update_product
    Public query As String
    Private Sub update_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(screenwidth / 1.35, screenheight / 1.42)
        ComboBox1.Items.Add("")
        ComboBox2.Items.Add("")
        ComboBox3.Items.Add("")
        ComboBox4.Items.Add("")
        Add_list("select product_id from products where status='1'", ComboBox1, "product_id")
        Add_list("select product_name from products where status='1'", ComboBox4, "product_name")
        Add_list("select category from category where status = '1' ", ComboBox2, "category")
        Add_list("select brand from brands where status = '1' ", ComboBox3, "brand")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        load_data()
    End Sub
    Public Sub load_data()
        query = "Select product_id as 'Product Id', product_name as 'Product Name', Category.Category as Category , brands.brand as 'Brand Name' , Quantity , Price, Barcode,Size.size from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id INNER JOIN Size ON products.size = Size.Size_id WHERE 1=1 and products.status='1'"
        If ComboBox1.SelectedItem <> "" Then
            query += " and product_id='" + ComboBox1.SelectedItem + "'"
        End If
        If ComboBox2.SelectedItem <> "" Then
            query += " and Products.cat_id = (select cat_id from category where category = '" + ComboBox2.SelectedItem + "' and status='1' )"
        End If
        If ComboBox3.SelectedItem <> "" Then
            query += " and brands.brand_id = (select brand_id from brands where brand= '" + ComboBox3.SelectedItem + "' and status='1')"
        End If
        If ComboBox4.SelectedItem <> "" Then
            query += " and product_name ='" + ComboBox4.SelectedItem + "'"
        End If

        If Len(ComboBox1.SelectedItem) <> 0 Or Len(ComboBox2.SelectedItem) Or Len(ComboBox3.SelectedItem) <> 0 Or Len(ComboBox4.SelectedItem) <> 0 Then
            Dim dataTable As DataTable = LoadDataTable(query)
            If dataTable IsNot Nothing Then
                DataGridView1.DataSource = dataTable
                DataGridView1.Columns(0).Width = screenwidth / 10
                DataGridView1.Columns(1).Width = screenwidth / 6
                DataGridView1.Columns(2).Width = screenwidth / 8
                DataGridView1.Columns(3).Width = screenwidth / 8
                DataGridView1.Columns(4).Width = screenwidth / 14
                DataGridView1.Columns(5).Width = screenwidth / 10.5
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.ClearSelection()
                DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
                DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
                DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                CenterDataGridViewHeader()
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
        update_size = selectedRow.Cells(7).Value.ToString
        common.update = "1"
        Dim frm = New Add_Product
        frm.ShowDialog()
        frm.MdiParent = admin_panel

    End Sub
    Private Sub CenterDataGridViewHeader()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub


End Class