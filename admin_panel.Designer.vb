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
        StockManagementToolStripMenuItem = New ToolStripMenuItem()
        AddProductsToolStripMenuItem = New ToolStripMenuItem()
        UpdateProductsToolStripMenuItem = New ToolStripMenuItem()
        BillingToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        SalesReportToolStripMenuItem = New ToolStripMenuItem()
        StocksReportToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem2 = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        ReturnManagementToolStripMenuItem = New ToolStripMenuItem()
        UserAccountsToolStripMenuItem = New ToolStripMenuItem()
        RegisterUserAccountToolStripMenuItem = New ToolStripMenuItem()
        UpdateUserAccountToolStripMenuItem = New ToolStripMenuItem()
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
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, StockManagementToolStripMenuItem, BillingToolStripMenuItem, ReportsToolStripMenuItem, ExitToolStripMenuItem2, ExitToolStripMenuItem1, ReturnManagementToolStripMenuItem, UserAccountsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1924, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DashboardToolStripMenuItem})
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(77, 29)
        HomeToolStripMenuItem.Text = "Home"' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(270, 34)
        DashboardToolStripMenuItem.Text = "Dashboard"' 
        ' StockManagementToolStripMenuItem
        ' 
        StockManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddProductsToolStripMenuItem, UpdateProductsToolStripMenuItem})
        StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem"
        StockManagementToolStripMenuItem.Size = New Size(181, 29)
        StockManagementToolStripMenuItem.Text = "Stock Management"' 
        ' AddProductsToolStripMenuItem
        ' 
        AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        AddProductsToolStripMenuItem.Size = New Size(247, 34)
        AddProductsToolStripMenuItem.Text = "Add Products"' 
        ' UpdateProductsToolStripMenuItem
        ' 
        UpdateProductsToolStripMenuItem.Name = "UpdateProductsToolStripMenuItem"
        UpdateProductsToolStripMenuItem.Size = New Size(247, 34)
        UpdateProductsToolStripMenuItem.Text = "Update Products"' 
        ' BillingToolStripMenuItem
        ' 
        BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        BillingToolStripMenuItem.Size = New Size(75, 29)
        BillingToolStripMenuItem.Text = "Billing"' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalesReportToolStripMenuItem, StocksReportToolStripMenuItem})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(89, 29)
        ReportsToolStripMenuItem.Text = "Reports"' 
        ' SalesReportToolStripMenuItem
        ' 
        SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        SalesReportToolStripMenuItem.Size = New Size(223, 34)
        SalesReportToolStripMenuItem.Text = "Sales Report"' 
        ' StocksReportToolStripMenuItem
        ' 
        StocksReportToolStripMenuItem.Name = "StocksReportToolStripMenuItem"
        StocksReportToolStripMenuItem.Size = New Size(223, 34)
        StocksReportToolStripMenuItem.Text = "Stocks Report"' 
        ' ExitToolStripMenuItem2
        ' 
        ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        ExitToolStripMenuItem2.Size = New Size(158, 29)
        ExitToolStripMenuItem2.Text = "Barcode Printing"' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(93, 29)
        ExitToolStripMenuItem1.Text = "Backups"' 
        ' ReturnManagementToolStripMenuItem
        ' 
        ReturnManagementToolStripMenuItem.Name = "ReturnManagementToolStripMenuItem"
        ReturnManagementToolStripMenuItem.Size = New Size(184, 29)
        ReturnManagementToolStripMenuItem.Text = "ReturnManagement"' 
        ' UserAccountsToolStripMenuItem
        ' 
        UserAccountsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegisterUserAccountToolStripMenuItem, UpdateUserAccountToolStripMenuItem})
        UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        UserAccountsToolStripMenuItem.Size = New Size(141, 29)
        UserAccountsToolStripMenuItem.Text = "User Accounts"' 
        ' RegisterUserAccountToolStripMenuItem
        ' 
        RegisterUserAccountToolStripMenuItem.Name = "RegisterUserAccountToolStripMenuItem"
        RegisterUserAccountToolStripMenuItem.Size = New Size(287, 34)
        RegisterUserAccountToolStripMenuItem.Text = "Register User Account"' 
        ' UpdateUserAccountToolStripMenuItem
        ' 
        UpdateUserAccountToolStripMenuItem.Name = "UpdateUserAccountToolStripMenuItem"
        UpdateUserAccountToolStripMenuItem.Size = New Size(287, 34)
        UpdateUserAccountToolStripMenuItem.Text = "Update User Account"' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, user, ToolStripStatusLabel4, role, ToolStripStatusLabel6, datedt, ToolStripStatusLabel3, timet, ToolStripStatusLabel8})
        StatusStrip1.Location = New Point(0, 991)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1924, 49)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.BackColor = SystemColors.Control
        ToolStripStatusLabel1.Margin = New Padding(10)
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(56, 29)
        ToolStripStatusLabel1.Text = "User :"' 
        ' user
        ' 
        user.BackColor = Color.White
        user.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        user.Margin = New Padding(0, 10, 10, 10)
        user.Name = "user"
        user.Padding = New Padding(0, 2, 0, 2)
        user.Size = New Size(4, 29)
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.BackColor = SystemColors.Control
        ToolStripStatusLabel4.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(55, 29)
        ToolStripStatusLabel4.Text = "Role :"' 
        ' role
        ' 
        role.BackColor = Color.White
        role.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        role.Margin = New Padding(0, 10, 10, 10)
        role.Name = "role"
        role.Padding = New Padding(0, 2, 0, 2)
        role.Size = New Size(4, 29)
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.BackColor = SystemColors.Control
        ToolStripStatusLabel6.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(58, 29)
        ToolStripStatusLabel6.Text = "Date :"' 
        ' datedt
        ' 
        datedt.BackColor = Color.White
        datedt.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        datedt.Margin = New Padding(0, 10, 10, 10)
        datedt.Name = "datedt"
        datedt.RightToLeft = RightToLeft.No
        datedt.Size = New Size(4, 29)
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.BackColor = SystemColors.Control
        ToolStripStatusLabel3.Margin = New Padding(0, 10, 10, 10)
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(59, 29)
        ToolStripStatusLabel3.Text = "Time :"' 
        ' timet
        ' 
        timet.BackColor = Color.White
        timet.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        timet.Margin = New Padding(0, 10, 10, 10)
        timet.Name = "timet"
        timet.Size = New Size(4, 29)
        ' 
        ' ToolStripStatusLabel8
        ' 
        ToolStripStatusLabel8.BackColor = Color.White
        ToolStripStatusLabel8.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        ToolStripStatusLabel8.Margin = New Padding(10)
        ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        ToolStripStatusLabel8.Size = New Size(238, 29)
        ToolStripStatusLabel8.Text = "4U FASHION READYMADES"' 
        ' admin_panel
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1924, 1040)
        Controls.Add(MenuStrip1)
        Controls.Add(StatusStrip1)
        IsMdiContainer = True
        Margin = New Padding(2)
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
    Friend WithEvents UserAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterUserAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserAccountToolStripMenuItem As ToolStripMenuItem
End Class
