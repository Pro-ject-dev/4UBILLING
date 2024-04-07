Imports System.Security.Cryptography

Public Class admin_panel
    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click
        Dim frm = Add_Product
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub UpdateProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProductsToolStripMenuItem.Click
        Dim frm = update_product
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Dim frm = Barcode
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim frm = Backup
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        Dim frm = salesreport
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub StocksReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksReportToolStripMenuItem.Click
        Dim frm = stock_report
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click
        Dim frm = New BILLING
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub admin_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm = Splash
        frm.ShowDialog()
        Dim frm1 = Loginscreen
        frm1.ShowDialog()
        user.Text = currentuser
        role.Text = currentrole
        Dim time As New Timer()
        time.Interval = 1000
        AddHandler time.Tick, AddressOf Timer_Tick
        time.Start()

        Me.WindowState = FormWindowState.Maximized
        If currentrole <> "ADMINISTRATOR" Then
            StockManagementToolStripMenuItem.Visible = False
            ReportsToolStripMenuItem.Visible = False
            ExitToolStripMenuItem1.Visible = False
            ExitToolStripMenuItem.Visible = False
            ExitToolStripMenuItem2.Visible = False
        End If
        Dim frm2 = New Dashboardd
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim frm = New Dashboardd
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Try
            d_t()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function d_t()
        Dim currentDate As DateTime = DateTime.Now
        Dim dates = currentDate.ToString("dd-MM-yyyy")
        Dim time = currentDate.ToString("hh:mm:ss tt")
        timet.Text = time.ToString
        datedt.Text = dates
    End Function
End Class
