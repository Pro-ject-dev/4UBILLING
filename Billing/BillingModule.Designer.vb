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
        Label9 = New Label()
        Label10 = New Label()
        ReturnAmount = New RichTextBox()
        MobileNo = New TextBox()
        BarcodeCodetxt = New RichTextBox()
        Return_billno = New RichTextBox()
        AddUserbtn = New Button()
        Billbtn = New Button()
        Label7 = New Label()
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
        BillingGridsumma = New DataGridView()
        GroupBox3 = New GroupBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Balance = New RichTextBox()
        Label12 = New Label()
        Amount = New RichTextBox()
        Label11 = New Label()
        Label8 = New Label()
        grandtot = New RichTextBox()
        GroupBox1.SuspendLayout()
        CType(BillingGridsumma, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(ReturnAmount)
        GroupBox1.Controls.Add(MobileNo)
        GroupBox1.Controls.Add(BarcodeCodetxt)
        GroupBox1.Controls.Add(Return_billno)
        GroupBox1.Controls.Add(AddUserbtn)
        GroupBox1.Controls.Add(Billbtn)
        GroupBox1.Controls.Add(Label7)
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
        ' Label9
        ' 
        resources.ApplyResources(Label9, "Label9")
        Label9.Name = "Label9"' 
        ' Label10
        ' 
        resources.ApplyResources(Label10, "Label10")
        Label10.Name = "Label10"' 
        ' ReturnAmount
        ' 
        ReturnAmount.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(ReturnAmount, "ReturnAmount")
        ReturnAmount.Name = "ReturnAmount"
        ReturnAmount.ReadOnly = True
        ' 
        ' MobileNo
        ' 
        MobileNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        MobileNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(MobileNo, "MobileNo")
        MobileNo.Name = "MobileNo"' 
        ' BarcodeCodetxt
        ' 
        BarcodeCodetxt.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(BarcodeCodetxt, "BarcodeCodetxt")
        BarcodeCodetxt.Name = "BarcodeCodetxt"' 
        ' Return_billno
        ' 
        Return_billno.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Return_billno, "Return_billno")
        Return_billno.Name = "Return_billno"' 
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
        Label7.Name = "Label7"' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.Name = "Label6"' 
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
        Label5.Name = "Label5"' 
        ' ProductName
        ' 
        resources.ApplyResources(ProductName, "ProductName")
        ProductName.Name = "ProductName"
        ProductName.ReadOnly = True
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"' 
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
        Label3.Name = "Label3"' 
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
        Label2.BackColor = Color.Transparent
        Label2.Name = "Label2"' 
        ' Quantity
        ' 
        Quantity.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Quantity, "Quantity")
        Quantity.Name = "Quantity"' 
        ' BillingGridsumma
        ' 
        BillingGridsumma.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BillingGridsumma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(BillingGridsumma, "BillingGridsumma")
        BillingGridsumma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        BillingGridsumma.DefaultCellStyle = DataGridViewCellStyle2
        BillingGridsumma.Name = "BillingGridsumma"
        BillingGridsumma.ReadOnly = True
        BillingGridsumma.RowTemplate.Height = 40
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Balance)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Amount)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(grandtot)
        resources.ApplyResources(GroupBox3, "GroupBox3")
        GroupBox3.Name = "GroupBox3"
        GroupBox3.TabStop = False
        ' 
        ' Label15
        ' 
        resources.ApplyResources(Label15, "Label15")
        Label15.Name = "Label15"' 
        ' Label14
        ' 
        resources.ApplyResources(Label14, "Label14")
        Label14.Name = "Label14"' 
        ' Label13
        ' 
        resources.ApplyResources(Label13, "Label13")
        Label13.Name = "Label13"' 
        ' Balance
        ' 
        Balance.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Balance, "Balance")
        Balance.Name = "Balance"
        Balance.ReadOnly = True
        ' 
        ' Label12
        ' 
        resources.ApplyResources(Label12, "Label12")
        Label12.Name = "Label12"' 
        ' Amount
        ' 
        Amount.BorderStyle = BorderStyle.FixedSingle
        resources.ApplyResources(Amount, "Amount")
        Amount.Name = "Amount"' 
        ' Label11
        ' 
        resources.ApplyResources(Label11, "Label11")
        Label11.Name = "Label11"' 
        ' Label8
        ' 
        resources.ApplyResources(Label8, "Label8")
        Label8.Name = "Label8"' 
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
        AutoScaleMode = AutoScaleMode.Dpi
        Controls.Add(GroupBox3)
        Controls.Add(BillingGridsumma)
        Controls.Add(GroupBox1)
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "BILLING"
        ShowIcon = False
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(BillingGridsumma, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BillingGridsumma As DataGridView
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
    Friend WithEvents AddUserbtn As Button
    Friend WithEvents MobileNo As TextBox
    Friend WithEvents Return_billno As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grandtot As RichTextBox
    Friend WithEvents ReturnAmount As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Balance As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Amount As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
