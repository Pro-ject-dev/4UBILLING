<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BillNo = New TextBox()
        Barcode = New TextBox()
        ReturnGrid = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GrandTotal = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CurrentTotal = New TextBox()
        CType(ReturnGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BillNo
        ' 
        BillNo.Location = New Point(15, 50)
        BillNo.Margin = New Padding(4, 5, 4, 5)
        BillNo.Name = "BillNo"
        BillNo.PlaceholderText = "Bill No"
        BillNo.Size = New Size(190, 31)
        BillNo.TabIndex = 0
        ' 
        ' Barcode
        ' 
        Barcode.Location = New Point(249, 50)
        Barcode.Margin = New Padding(4, 5, 4, 5)
        Barcode.Name = "Barcode"
        Barcode.PlaceholderText = "BarCode No"
        Barcode.Size = New Size(190, 31)
        Barcode.TabIndex = 1
        ' 
        ' ReturnGrid
        ' 
        ReturnGrid.BackgroundColor = Color.White
        ReturnGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReturnGrid.GridColor = SystemColors.ActiveBorder
        ReturnGrid.Location = New Point(15, 114)
        ReturnGrid.Margin = New Padding(4, 5, 4, 5)
        ReturnGrid.Name = "ReturnGrid"
        ReturnGrid.ReadOnly = True
        ReturnGrid.RowHeadersWidth = 51
        ReturnGrid.RowTemplate.Height = 24
        ReturnGrid.Size = New Size(1002, 480)
        ReturnGrid.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(635, 39)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 55)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(756, 38)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 55)
        Button2.TabIndex = 4
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(884, 39)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(134, 55)
        Button3.TabIndex = 5
        Button3.Text = "RETURN"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GrandTotal
        ' 
        GrandTotal.Location = New Point(794, 602)
        GrandTotal.Margin = New Padding(4, 4, 4, 4)
        GrandTotal.Name = "GrandTotal"
        GrandTotal.Size = New Size(223, 31)
        GrandTotal.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(675, 606)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 7
        Label1.Text = "GrandTotal :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(315, 606)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 25)
        Label2.TabIndex = 9
        Label2.Text = "CurrentTotal :"' 
        ' CurrentTotal
        ' 
        CurrentTotal.Location = New Point(444, 602)
        CurrentTotal.Margin = New Padding(4, 4, 4, 4)
        CurrentTotal.Name = "CurrentTotal"
        CurrentTotal.Size = New Size(223, 31)
        CurrentTotal.TabIndex = 8
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1030, 640)
        Controls.Add(Label2)
        Controls.Add(CurrentTotal)
        Controls.Add(Label1)
        Controls.Add(GrandTotal)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ReturnGrid)
        Controls.Add(Barcode)
        Controls.Add(BillNo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MaximumSize = New Size(1052, 696)
        MinimizeBox = False
        MinimumSize = New Size(1052, 696)
        Name = "ReturnForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REPLACE"
        CType(ReturnGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BillNo As TextBox
    Friend WithEvents Barcode As TextBox
    Friend WithEvents ReturnGrid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GrandTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentTotal As TextBox
End Class
