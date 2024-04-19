Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class stock_report
    Public query As String
    Dim dataTable As DataTable
    Private Sub update_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(screenwidth / 1.145, screenheight / 1.62)

        pro_filter.Checked = True
        date_filter.Checked = True
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
        Dim st_dt = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Dim end_dt = DateTimePicker2.Value.ToString("dd-MM-yyyy")
        If date_filter.Checked = True Then
            query += " and convert(varchar,date,105) between '" + st_dt + "' and '" + end_dt.ToString + "'"
        End If
        If pro_filter.Checked = True Then
            If ComboBox2.SelectedItem <> "" Then
                query += " and Products.cat_id = (select cat_id from category where category = '" + ComboBox2.SelectedItem + "' and Category.status='1' )"
            End If
            If ComboBox3.SelectedItem <> "" Then
                query += " and brands.brand_id = (select brand_id from brands where brand= '" + ComboBox3.SelectedItem + "'  and  brands.status='1' )"
            End If
            If ComboBox4.SelectedItem <> "" Then
                query += " and product_name ='" + ComboBox4.SelectedItem + "'"
            End If
        End If
        If CheckBox1.Checked = True Then
            query += " order by Products.Price desc"
        Else
            query += "order by Products.Product_id"
        End If

        dataTable = LoadDataTable(query)
        If dataTable IsNot Nothing Then
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns(0).Width = screenwidth / 18
            DataGridView1.Columns(1).Width = screenwidth / 15
            DataGridView1.Columns(2).Width = screenwidth / 6
            DataGridView1.Columns(3).Width = screenwidth / 10
            DataGridView1.Columns(4).Width = screenwidth / 10
            DataGridView1.Columns(5).Width = screenwidth / 20
            DataGridView1.Columns(6).Width = screenwidth / 19
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



    Private Sub pro_filter_CheckedChanged(sender As Object, e As EventArgs) Handles pro_filter.CheckedChanged
        If pro_filter.Checked <> True Then
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
        Else
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
        End If
        load_data()
    End Sub

    Private Sub date_filter_CheckedChanged(sender As Object, e As EventArgs) Handles date_filter.CheckedChanged
        If date_filter.Checked <> True Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        Else
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
        load_data()
    End Sub


End Class
