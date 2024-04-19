Public Class updateAccounts

    Private Sub updateAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load()



    End Sub


    Private Sub ButtonColumn_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim clickedRowIndex As Integer = e.RowIndex
        updateuserid = DataGridView1.Rows(clickedRowIndex).Cells("User ID").Value.ToString()
        updateusername = DataGridView1.Rows(clickedRowIndex).Cells("Username").Value.ToString()
        updatepass = DecryptData(DataGridView1.Rows(clickedRowIndex).Cells("Password").Value.ToString())
        updaterole = DataGridView1.Rows(clickedRowIndex).Cells("Role").Value.ToString()
        userstatus = "0"
        Dim frm = New registration
        frm.ShowDialog()
        frm.MdiParent = admin_panel
        Me.Close()
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


    Public Sub load()
        Me.Size = New Size(screenwidth / 2.4, screenheight / 2.3)
        DataGridView1.Width = screenwidth / 2.6
        DataGridView1.Height = screenheight / 3
        GroupBox1.Width = screenwidth / 2.5
        GroupBox1.Height = screenheight / 2.65
        Dim query As String = "Select userid As 'User ID',Username,Password,Role from login"
        Dim dataTable As DataTable = LoadDataTable(query)
        DataGridView1.DataSource = dataTable
        DataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.Columns(0).Width = screenwidth / 10
        DataGridView1.Columns(1).Width = screenwidth / 5
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Width = screenwidth / 9
    End Sub

End Class