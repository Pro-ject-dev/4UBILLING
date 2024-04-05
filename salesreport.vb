Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class salesreport
    Public query As String
    Dim dataTable As DataTable
    Private Sub update_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pro_filter.Checked = True
        cust_filter.Checked = True
        date_filter.Checked = True
        ComboBox2.Items.Add("")
        ComboBox3.Items.Add("")
        ComboBox4.Items.Add("")
        Add_list("select product_name from products where status='1'", ComboBox4, "product_name")
        Add_list("select category from category where status = '1' ", ComboBox2, "category")
        Add_list("select brand from brands where status = '1' ", ComboBox3, "brand")
        load_data()
    End Sub


    Public Sub load_data()
        query = "SELECT CONVERT(varchar, b.date, 105) AS Date, b.billing_no AS 'Billing No.', cus.customername AS 'Customer Name', cus.mobileno AS 'Mobile No.', p.product_name AS 'Product', b.quantity - ISNULL((SELECT SUM(r.quantity) FROM ReturnTable r WHERE r.Product_id = b.Product_id AND r.Billing_no = b.billing_no), 0) AS 'Quantity', b.price AS 'Price', convert(DECIMAL(10, 2),b.total)- ISNULL((SELECT SUM(r.quantity * CAST(r.price AS DECIMAL(10, 2))) FROM ReturnTable r JOIN Products p ON r.Product_id = p.Product_id WHERE r.Product_id = b.Product_id AND r.Billing_no = b.billing_no), 0) AS 'Total', (select username from login where userid=b.billed_by) AS 'Billed by'  FROM billing AS b INNER JOIN customer AS cus ON b.customer_id = cus.customer_id INNER JOIN products AS p ON b.Product_id = p.Product_id WHERE b.status = 1"
        Dim st_dt = DateTimePicker1.Value.ToString.Split(" ")(0).Split("/")
        Dim end_dt = DateTimePicker2.Value.ToString.Split(" ")(0).Split("/")
        Dim ac_st_dt = st_dt(2) & "-" & st_dt(0) & "-" & st_dt(1)
        Dim ac_end_dt = end_dt(2) & "-" & end_dt(0) & "-" & end_dt(1)
        If date_filter.Checked = True Then
            query += " and b.date between '" + ac_st_dt.ToString + "' and '" + ac_end_dt.ToString + "'"
        End If

        If pro_filter.Checked = True Then
            If ComboBox2.SelectedItem <> "" Then
                query += " and p.cat_id = (select cat_id from category where category = '" + ComboBox2.SelectedItem + "' )"
            End If
            If ComboBox3.SelectedItem <> "" Then
                query += " and p.brand_id = (select brand_id from brands where brand= '" + ComboBox3.SelectedItem + "' )"
            End If
            If ComboBox4.SelectedItem <> "" Then
                query += " and p.product_name ='" + ComboBox4.SelectedItem + "'"
            End If
        End If
        If cust_filter.Checked = True Then
            If TextBox1.Text <> "" Then

                query += " and cus.mobileno Like '" + TextBox1.Text + "%' "

            End If

            If TextBox2.Text <> "" Then
                query += " and b.billing_no Like '" + TextBox2.Text + "%' "
            End If
        End If
        query += "order by b.billing_no"



        dataTable = LoadDataTable(query)
        If dataTable IsNot Nothing Then
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 180
            DataGridView1.Columns(2).Width = 180
            DataGridView1.Columns(3).Width = 180
            DataGridView1.Columns(4).Width = 180
            DataGridView1.Columns(5).Width = 180
            DataGridView1.Columns(6).Width = 180
            DataGridView1.ClearSelection()
            DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        Else
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





    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        load_data()

        Dim query = "SELECT billing_no FROM billing WHERE billing_no LIKE @searchText + '%'"
        TextBox2.AutoCompleteCustomSource = GetSuggestions(TextBox2.Text, query)
        TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        load_data()
        Dim query = "SELECT mobileno FROM customer WHERE mobileno LIKE @searchText + '%'"
        TextBox1.AutoCompleteCustomSource = GetSuggestions(TextBox1.Text, query)
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
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

    Private Sub cust_filter_CheckedChanged(sender As Object, e As EventArgs) Handles cust_filter.CheckedChanged
        If cust_filter.Checked <> True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        Else
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        End If
        load_data()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dataTable.Rows.Count = 0 Then
            MsgBox("Please Select Any of the Fields !")
        Else
            sales_query = ModifysalesColumnNames(query)
            Dim frm = New sales_print
            frm.ShowDialog()
        End If

    End Sub
End Class
