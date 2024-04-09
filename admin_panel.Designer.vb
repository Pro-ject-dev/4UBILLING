<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_panel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        StockManagementToolStripMenuItem = New ToolStripMenuItem()
        AddProductsToolStripMenuItem = New ToolStripMenuItem()
        UpdateProductsToolStripMenuItem = New ToolStripMenuItem()
        BillingToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        SalesReportToolStripMenuItem = New ToolStripMenuItem()
        StocksReportToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem2 = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        user = New ToolStripStatusLabel()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        role = New ToolStripStatusLabel()
        ToolStripStatusLabel6 = New ToolStripStatusLabel()
        datedt = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        timet = New ToolStripStatusLabel()
        ToolStripStatusLabel8 = New ToolStripStatusLabel()
        ReturnManagementToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, StockManagementToolStripMenuItem, BillingToolStripMenuItem, ReportsToolStripMenuItem, ExitToolStripMenuItem2, ExitToolStripMenuItem1, ReturnManagementToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1539, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, ExitToolStripMenuItem})
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(64, 24)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(165, 26)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(165, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' StockManagementToolStripMenuItem
        ' 
        StockManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddProductsToolStripMenuItem, UpdateProductsToolStripMenuItem})
        StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem"
        StockManagementToolStripMenuItem.Size = New Size(151, 24)
        StockManagementToolStripMenuItem.Text = "Stock Management"
        ' 
        ' AddProductsToolStripMenuItem
        ' 
        AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        AddProductsToolStripMenuItem.Size = New Size(202, 26)
        AddProductsToolStripMenuItem.Text = "Add Products"
        ' 
        ' UpdateProductsToolStripMenuItem
        ' 
        UpdateProductsToolStripMenuItem.Name = "UpdateProductsToolStripMenuItem"
        UpdateProductsToolStripMenuItem.Size = New Size(202, 26)
        UpdateProductsToolStripMenuItem.Text = "Update Products"
        ' 
        ' BillingToolStripMenuItem
        ' 
        BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        BillingToolStripMenuItem.Size = New Size(65, 24)
        BillingToolStripMenuItem.Text = "Billing"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalesReportToolStripMenuItem, StocksReportToolStripMenuItem})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(74, 24)
        ReportsToolStripMenuItem.Text = "Reports"
        ' 
        ' SalesReportToolStripMenuItem
        ' 
        SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        SalesReportToolStripMenuItem.Size = New Size(183, 26)
        SalesReportToolStripMenuItem.Text = "Sales Report"
        ' 
        ' StocksReportToolStripMenuItem
        ' 
        StocksReportToolStripMenuItem.Name = "StocksReportToolStripMenuItem"
        StocksReportToolStripMenuItem.Size = New Size(183, 26)
        StocksReportToolStripMenuItem.Text = "Stocks Report"
        ' 
        ' ExitToolStripMenuItem2
        ' 
        ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        ExitToolStripMenuItem2.Size = New Size(133, 24)
        ExitToolStripMenuItem2.Text = "Barcode Printing"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(77, 24)
        ExitToolStripMenuItem1.Text = "Backups"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, user, ToolStripStatusLabel4, role, ToolStripStatusLabel6, datedt, ToolStripStatusLabel3, timet, ToolStripStatusLabel8})
        StatusStrip1.Location = New Point(0, 788)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 11, 0)
        StatusStrip1.Size = New Size(1539, 44)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.BackColor = SystemColors.Control
        ToolStripStatusLabel1.Margin = New Padding(10)
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(45, 24)
        ToolStripStatusLabel1.Text = "User :"
        ' 
        ' user
        ' 
        user.BackColor = Color.White
        user.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        user.Margin = New Padding(0, 10, 10, 10)
        user.Name = "user"
        user.Padding = New Padding(0, 2, 0, 2)
        user.Size = New Size(4, 24)
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.BackColor = SystemColors.Control
        ToolStripStatusLabel4.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(46, 24)
        ToolStripStatusLabel4.Text = "Role :"
        ' 
        ' role
        ' 
        role.BackColor = Color.White
        role.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        role.Margin = New Padding(0, 10, 10, 10)
        role.Name = "role"
        role.Padding = New Padding(0, 2, 0, 2)
        role.Size = New Size(4, 24)
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.BackColor = SystemColors.Control
        ToolStripStatusLabel6.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(48, 24)
        ToolStripStatusLabel6.Text = "Date :"
        ' 
        ' datedt
        ' 
        datedt.BackColor = Color.White
        datedt.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        datedt.Margin = New Padding(0, 10, 10, 10)
        datedt.Name = "datedt"
        datedt.RightToLeft = RightToLeft.No
        datedt.Size = New Size(4, 24)
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.BackColor = SystemColors.Control
        ToolStripStatusLabel3.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(49, 24)
        ToolStripStatusLabel3.Text = "Time :"
        ' 
        ' timet
        ' 
        timet.BackColor = Color.White
        timet.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        timet.Margin = New Padding(0, 10, 10, 10)
        timet.Name = "timet"
        timet.Size = New Size(4, 24)
        ' 
        ' ToolStripStatusLabel8
        ' 
        ToolStripStatusLabel8.BackColor = Color.White
        ToolStripStatusLabel8.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        ToolStripStatusLabel8.Margin = New Padding(10)
        ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        ToolStripStatusLabel8.Size = New Size(196, 24)
        ToolStripStatusLabel8.Text = "4U FASHION READYMADES"
        ' 
        ' ReturnManagementToolStripMenuItem
        ' 
        ReturnManagementToolStripMenuItem.Name = "ReturnManagementToolStripMenuItem"
        ReturnManagementToolStripMenuItem.Size = New Size(154, 24)
        ReturnManagementToolStripMenuItem.Text = "ReturnManagement"
        ' 
        ' admin_panel
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1539, 832)
        Controls.Add(MenuStrip1)
        Controls.Add(StatusStrip1)
        IsMdiContainer = True
        Margin = New Padding(2, 2, 2, 2)
        Name = "admin_panel"
        Text = "4U Fashions - Billing Management Application"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents user As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents role As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents datedt As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents timet As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents ReturnManagementToolStripMenuItem As ToolStripMenuItem
End Class
