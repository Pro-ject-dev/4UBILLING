<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        BillingToolStripMenuItem = New ToolStripMenuItem()
        StockManagementToolStripMenuItem = New ToolStripMenuItem()
        AddProductsToolStripMenuItem = New ToolStripMenuItem()
        UpdateProductsToolStripMenuItem = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem2 = New ToolStripMenuItem()
        Panel1 = New Panel()
        Label9 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, BillingToolStripMenuItem, StockManagementToolStripMenuItem, ReportsToolStripMenuItem, ExitToolStripMenuItem1, ExitToolStripMenuItem2})
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
        ' BillingToolStripMenuItem
        ' 
        BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        BillingToolStripMenuItem.Size = New Size(75, 29)
        BillingToolStripMenuItem.Text = "Billing"' 
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
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(89, 29)
        ReportsToolStripMenuItem.Text = "Reports"' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(93, 29)
        ExitToolStripMenuItem1.Text = "Backups"' 
        ' ExitToolStripMenuItem2
        ' 
        ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        ExitToolStripMenuItem2.Size = New Size(158, 29)
        ExitToolStripMenuItem2.Text = "Barcode Printing"' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
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
        Label9.Location = New Point(725, 5)
        Label9.Name = "Label9"
        Label9.Size = New Size(246, 27)
        Label9.TabIndex = 8
        Label9.Text = "4U FASHIONS READYMADES"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(611, 5)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 27)
        Label7.TabIndex = 7
        Label7.Text = "10:47 AM"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(553, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 6
        Label8.Text = "Time :"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(416, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 27)
        Label5.TabIndex = 5
        Label5.Text = "07-03-2024"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(358, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 4
        Label6.Text = "Date :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(266, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 27)
        Label3.TabIndex = 3
        Label3.Text = "Admin"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(209, 5)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 2
        Label4.Text = "Role :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(69, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 27)
        Label2.TabIndex = 1
        Label2.Text = "Vasudevan N"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 0
        Label1.Text = "User :"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1924, 1040)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Name = "Form1"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProductsToolStripMenuItem As ToolStripMenuItem
End Class
