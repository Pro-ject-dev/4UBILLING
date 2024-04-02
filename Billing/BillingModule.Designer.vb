<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BILLING
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BILLING))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        MobileNo = New TextBox()
        AddUserbtn = New Button()
        Billbtn = New Button()
        Label7 = New Label()
        BarcodeCodetxt = New RichTextBox()
        Label1 = New Label()
        Label6 = New Label()
        Bill_no = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        ProductName = New RichTextBox()
        Label4 = New Label()
        Total = New RichTextBox()
        Label3 = New Label()
        Price = New RichTextBox()
        Label2 = New Label()
        Quantity = New RichTextBox()
        BillingGrid = New DataGridView()
        GroupBox3 = New GroupBox()
        GroupBox2 = New GroupBox()
        grandtot = New RichTextBox()
        GroupBox1.SuspendLayout()
        CType(BillingGrid, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MobileNo)
        GroupBox1.Controls.Add(AddUserbtn)
        GroupBox1.Controls.Add(Billbtn)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(BarcodeCodetxt)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Bill_no)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(ProductName)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Total)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Price)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Quantity)
        resources.ApplyResources(GroupBox1, "GroupBox1")
        GroupBox1.Name = "GroupBox1"
        GroupBox1.TabStop = False
        ' 
        ' MobileNo
        ' 
        MobileNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        MobileNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(MobileNo, "MobileNo")
        MobileNo.Name = "MobileNo"
        ' 
        ' AddUserbtn
        ' 
        resources.ApplyResources(AddUserbtn, "AddUserbtn")
        AddUserbtn.Name = "AddUserbtn"
        AddUserbtn.UseVisualStyleBackColor = True
        ' 
        ' Billbtn
        ' 
        resources.ApplyResources(Billbtn, "Billbtn")
        Billbtn.Name = "Billbtn"
        Billbtn.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.Name = "Label7"
        ' 
        ' BarcodeCodetxt
        ' 
        BarcodeCodetxt.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(BarcodeCodetxt, "BarcodeCodetxt")
        BarcodeCodetxt.Name = "BarcodeCodetxt"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.Name = "Label6"
        ' 
        ' Bill_no
        ' 
        Bill_no.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Bill_no, "Bill_no")
        Bill_no.Name = "Bill_no"
        Bill_no.ReadOnly = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.Name = "Label5"
        ' 
        ' ProductName
        ' 
        ProductName.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(ProductName, "ProductName")
        ProductName.Name = "ProductName"
        ProductName.ReadOnly = True
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' Total
        ' 
        Total.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Total, "Total")
        Total.Name = "Total"
        Total.ReadOnly = True
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Price
        ' 
        Price.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Price, "Price")
        Price.Name = "Price"
        Price.ReadOnly = True
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Quantity
        ' 
        Quantity.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Quantity, "Quantity")
        Quantity.Name = "Quantity"
        ' 
        ' BillingGrid
        ' 
        BillingGrid.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BillingGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(BillingGrid, "BillingGrid")
        BillingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Tahoma", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        BillingGrid.DefaultCellStyle = DataGridViewCellStyle2
        BillingGrid.Name = "BillingGrid"
        BillingGrid.ReadOnly = True
        BillingGrid.RowTemplate.Height = 40
        ' 
        ' GroupBox3
        ' 
        resources.ApplyResources(GroupBox3, "GroupBox3")
        GroupBox3.Name = "GroupBox3"
        GroupBox3.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(grandtot)
        resources.ApplyResources(GroupBox2, "GroupBox2")
        GroupBox2.Name = "GroupBox2"
        GroupBox2.TabStop = False
        ' 
        ' grandtot
        ' 
        grandtot.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(grandtot, "grandtot")
        grandtot.Name = "grandtot"
        grandtot.ReadOnly = True
        ' 
        ' BILLING
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(BillingGrid)
        Controls.Add(GroupBox1)
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "BILLING"
        ShowIcon = False
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(BillingGrid, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BillingGrid As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BarcodeCodetxt As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Price As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Quantity As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Total As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductName As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Bill_no As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Billbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grandtot As RichTextBox
    Friend WithEvents AddUserbtn As Button
    Friend WithEvents MobileNo As TextBox
End Class
