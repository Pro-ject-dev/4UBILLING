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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Product))
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        Button10 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Button8 = New Button()
        Button9 = New Button()
        ComboBox3 = New ComboBox()
        TextBox3 = New TextBox()
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
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Button10)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Location = New Point(10, 10)
        GroupBox1.Margin = New Padding(2, 2, 2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 2, 2, 2)
        GroupBox1.Size = New Size(798, 434)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Product Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(22, 305)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 20)
        Label8.TabIndex = 18
        Label8.Text = "Retail Price        :"
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(13, 398)
        Button10.Margin = New Padding(2, 2, 2, 2)
        Button10.Name = "Button10"
        Button10.Size = New Size(296, 27)
        Button10.TabIndex = 16
        Button10.Text = "Update Product"
        Button10.UseVisualStyleBackColor = True
        Button10.Visible = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(482, 398)
        Button5.Margin = New Padding(2, 2, 2, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(296, 27)
        Button5.TabIndex = 15
        Button5.Text = "Delete Product"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(255, 398)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(296, 27)
        Button2.TabIndex = 14
        Button2.Text = "Add Product"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 263)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 9
        Label5.Text = "Actual Price       :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 222)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 7
        Label4.Text = "Quantity            :"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(153, 222)
        NumericUpDown1.Margin = New Padding(2, 2, 2, 2)
        NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(296, 27)
        NumericUpDown1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(153, 182)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(610, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 182)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 20)
        Label3.TabIndex = 4
        Label3.Text = "Product Name   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 94)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 20)
        Label2.TabIndex = 2
        Label2.Text = " Brand Name      :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 53)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 0
        Label1.Text = "Category           :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button9)
        GroupBox2.Controls.Add(ComboBox3)
        GroupBox2.Controls.Add(TextBox3)
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
        GroupBox2.Location = New Point(13, 24)
        GroupBox2.Margin = New Padding(2, 2, 2, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2, 2, 2, 2)
        GroupBox2.Size = New Size(771, 369)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "***"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 118)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 20)
        Label7.TabIndex = 23
        Label7.Text = "Size                   :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(140, 238)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(296, 27)
        TextBox1.TabIndex = 17
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(594, 114)
        Button8.Margin = New Padding(2, 2, 2, 2)
        Button8.Name = "Button8"
        Button8.Size = New Size(155, 27)
        Button8.TabIndex = 26
        Button8.Text = "Delete Size"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(441, 114)
        Button9.Margin = New Padding(2, 2, 2, 2)
        Button9.Name = "Button9"
        Button9.Size = New Size(147, 27)
        Button9.TabIndex = 25
        Button9.Text = "Add Size"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(140, 114)
        ComboBox3.Margin = New Padding(2, 2, 2, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(297, 28)
        ComboBox3.TabIndex = 24
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(140, 280)
        TextBox3.Margin = New Padding(2, 2, 2, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(296, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(594, 70)
        Button7.Margin = New Padding(2, 2, 2, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(155, 27)
        Button7.TabIndex = 19
        Button7.Text = "Delete Brand"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(594, 28)
        Button6.Margin = New Padding(2, 2, 2, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(155, 27)
        Button6.TabIndex = 18
        Button6.Text = "Delete Category"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(690, 317)
        PictureBox2.Margin = New Padding(2, 2, 2, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(441, 70)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 27)
        Button4.TabIndex = 16
        Button4.Text = "Add Brand"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(441, 29)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 27)
        Button3.TabIndex = 15
        Button3.Text = "Add Category"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(140, 70)
        ComboBox2.Margin = New Padding(2, 2, 2, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(297, 28)
        ComboBox2.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(481, 316)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(140, 319)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(296, 27)
        Button1.TabIndex = 12
        Button1.Text = "Generate "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 322)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 20)
        Label6.TabIndex = 11
        Label6.Text = "Barcode            :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(140, 29)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(297, 28)
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
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 453)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
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
    Friend WithEvents Button10 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
