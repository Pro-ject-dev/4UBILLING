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
        Panel1 = New Panel()
        Label9 = New Label()
        timet = New Label()
        Label8 = New Label()
        datedt = New Label()
        Label6 = New Label()
        role = New Label()
        Label4 = New Label()
        User = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, StockManagementToolStripMenuItem, BillingToolStripMenuItem, ReportsToolStripMenuItem, ExitToolStripMenuItem2, ExitToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1924, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, ExitToolStripMenuItem})
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(77, 29)
        HomeToolStripMenuItem.Text = "Home"' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(202, 34)
        DashboardToolStripMenuItem.Text = "Dashboard"' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(202, 34)
        ExitToolStripMenuItem.Text = "Exit"' 
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
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(timet)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(datedt)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(role)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(User)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 1005)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 37)
        Panel1.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Location = New Point(878, 5)
        Label9.Name = "Label9"
        Label9.Size = New Size(246, 27)
        Label9.TabIndex = 8
        Label9.Text = "4U FASHIONS READYMADES"' 
        ' timet
        ' 
        timet.AutoSize = True
        timet.BackColor = Color.White
        timet.BorderStyle = BorderStyle.Fixed3D
        timet.Location = New Point(727, 5)
        timet.MaximumSize = New Size(130, 0)
        timet.MinimumSize = New Size(130, 0)
        timet.Name = "timet"
        timet.Size = New Size(130, 27)
        timet.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(669, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 6
        Label8.Text = "Time :"' 
        ' datedt
        ' 
        datedt.AutoSize = True
        datedt.BackColor = Color.White
        datedt.BorderStyle = BorderStyle.Fixed3D
        datedt.Location = New Point(517, 5)
        datedt.MaximumSize = New Size(130, 0)
        datedt.MinimumSize = New Size(130, 0)
        datedt.Name = "datedt"
        datedt.Size = New Size(130, 27)
        datedt.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(449, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 4
        Label6.Text = "Date :"' 
        ' role
        ' 
        role.AutoSize = True
        role.BackColor = Color.White
        role.BorderStyle = BorderStyle.Fixed3D
        role.Location = New Point(276, 4)
        role.MaximumSize = New Size(160, 0)
        role.MinimumSize = New Size(160, 0)
        role.Name = "role"
        role.Size = New Size(160, 27)
        role.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(219, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 2
        Label4.Text = "Role :"' 
        ' User
        ' 
        User.AutoSize = True
        User.BackColor = Color.White
        User.BorderStyle = BorderStyle.Fixed3D
        User.Location = New Point(69, 3)
        User.MaximumSize = New Size(140, 0)
        User.MinimumSize = New Size(140, 0)
        User.Name = "User"
        User.Size = New Size(140, 27)
        User.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 0
        Label1.Text = "User :"' 
        ' admin_panel
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1924, 1040)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Name = "admin_panel"
        Text = "4U Fashions - Billing Management Application"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents User As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents role As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents timet As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents datedt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksReportToolStripMenuItem As ToolStripMenuItem
End Class
