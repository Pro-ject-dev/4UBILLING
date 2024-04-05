Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class stock_report
    Public query As String
    Dim dataTable As DataTable
    Private Sub update_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
        ComboBox2.Items.Add("")
        ComboBox3.Items.Add("")
        ComboBox4.Items.Add("")
        Add_list("select product_name from products where status='1'", ComboBox4, "product_name")
        Add_list("select category from category where status = '1' ", ComboBox2, "category")
        Add_list("select brand from brands where status = '1' ", ComboBox3, "brand")
        DataGridView1.ClearSelection()

    End Sub


    Public Sub load_data()
        query = "Select product_id as 'Product ID',CONVERT(varchar,date,105) AS 'Created Date' , product_name as 'Product Name', Category.Category as 'Category' , brands.brand as 'Brand Name' , Quantity , Price, Barcode from products INNER JOIN Category ON products.cat_id = Category.cat_id INNER JOIN brands ON brands.brand_id = products.brand_id WHERE 1=1 and products.status='1'"
        Dim st_dt = DateTimePicker1.Value.ToString.Split(" ")(0).Split("/")
        Dim end_dt = DateTimePicker2.Value.ToString.Split(" ")(0).Split("/")
        Dim ac_st_dt = st_dt(2) & "-" & st_dt(0) & "-" & st_dt(1)
        Dim ac_end_dt = end_dt(2) & "-" & end_dt(0) & "-" & end_dt(1)

        query += " and date between '" + ac_st_dt.ToString + "' and '" + ac_end_dt.ToString + "'"
        If ComboBox2.SelectedItem <> "" Then
            query += " and Products.cat_id = (select cat_id from category where category = '" + ComboBox2.SelectedItem + "' and Category.status='1' )"
        End If
        If ComboBox3.SelectedItem <> "" Then
            query += " and brands.brand_id = (select brand_id from brands where brand= '" + ComboBox3.SelectedItem + "'  and  brands.status='1' )"
        End If
        If ComboBox4.SelectedItem <> "" Then
            query += " and product_name ='" + ComboBox4.SelectedItem + "'"
        End If
        If CheckBox1.Checked = True Then
            query += " order by Products.Price desc"
        Else
            query += "order by Products.Product_id"
        End If

        dataTable = LoadDataTable(query)
        If dataTable IsNot Nothing Then
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns(0).Width = 140
            DataGridView1.Columns(1).Width = 140
            DataGridView1.Columns(2).Width = 230
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(4).Width = 180
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 158
            DataGridView1.Columns(7).Visible = False
            DataGridView1.ClearSelection()
            DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
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
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        load_data()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dataTable.Rows.Count = 0 Then
            MsgBox("Please Select Any of the Fields !")
        Else

            stock_query = ModifystockColumnNames(query)
            Dim frm = New stock_print
            frm.ShowDialog()
            frm.MdiParent = admin_panel
        End If
    End Sub
End Class
