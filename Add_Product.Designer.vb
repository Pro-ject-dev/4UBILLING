<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Product
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_Product))
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Button8 = New Button()
        Button9 = New Button()
        ComboBox3 = New ComboBox()
        Button7 = New Button()
        Button6 = New Button()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        ComboBox2 = New ComboBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(997, 485)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Product Details"' 
        ' Button5
        ' 
        Button5.Location = New Point(602, 441)
        Button5.Name = "Button5"
        Button5.Size = New Size(370, 34)
        Button5.TabIndex = 15
        Button5.Text = "Delete Product"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(319, 441)
        Button2.Name = "Button2"
        Button2.Size = New Size(370, 34)
        Button2.TabIndex = 14
        Button2.Text = "Add Product"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 25)
        Label5.TabIndex = 9
        Label5.Text = "Price                  :"' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(191, 327)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(370, 31)
        TextBox3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 25)
        Label4.TabIndex = 7
        Label4.Text = "Quantity            :"' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(191, 277)
        NumericUpDown1.Maximum = New [Decimal](New Integer() {1000000, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(370, 31)
        NumericUpDown1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(191, 228)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(762, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 25)
        Label3.TabIndex = 4
        Label3.Text = "Product Name   :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 25)
        Label2.TabIndex = 2
        Label2.Text = " Brand Name      :"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 25)
        Label1.TabIndex = 0
        Label1.Text = "Category           :"' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button9)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Location = New Point(16, 30)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(956, 405)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "***"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 25)
        Label7.TabIndex = 23
        Label7.Text = "Size                   :"' 
        ' Button8
        ' 
        Button8.Location = New Point(743, 142)
        Button8.Name = "Button8"
        Button8.Size = New Size(194, 34)
        Button8.TabIndex = 26
        Button8.Text = "Delete Size"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(551, 143)
        Button9.Name = "Button9"
        Button9.Size = New Size(184, 34)
        Button9.TabIndex = 25
        Button9.Text = "Add Size"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(175, 143)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(370, 33)
        ComboBox3.TabIndex = 24
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(743, 87)
        Button7.Name = "Button7"
        Button7.Size = New Size(194, 34)
        Button7.TabIndex = 19
        Button7.Text = "Delete Brand"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(743, 35)
        Button6.Name = "Button6"
        Button6.Size = New Size(194, 34)
        Button6.TabIndex = 18
        Button6.Text = "Delete Category"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(863, 343)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 45)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(551, 88)
        Button4.Name = "Button4"
        Button4.Size = New Size(184, 34)
        Button4.TabIndex = 16
        Button4.Text = "Add Brand"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(551, 36)
        Button3.Name = "Button3"
        Button3.Size = New Size(184, 34)
        Button3.TabIndex = 15
        Button3.Text = "Add Category"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(175, 88)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(370, 33)
        ComboBox2.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(601, 342)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(175, 346)
        Button1.Name = "Button1"
        Button1.Size = New Size(370, 34)
        Button1.TabIndex = 12
        Button1.Text = "Generate "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 349)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 25)
        Label6.TabIndex = 11
        Label6.Text = "Barcode             :"' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(175, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(370, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Add_Product
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1021, 509)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Add_Product"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Product"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox3 As ComboBox
End Class
