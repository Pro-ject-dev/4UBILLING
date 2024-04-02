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
        BillNo.Location = New Point(12, 40)
        BillNo.Margin = New Padding(3, 4, 3, 4)
        BillNo.Name = "BillNo"
        BillNo.Size = New Size(153, 27)
        BillNo.TabIndex = 0
        ' 
        ' Barcode
        ' 
        Barcode.Location = New Point(199, 40)
        Barcode.Margin = New Padding(3, 4, 3, 4)
        Barcode.Name = "Barcode"
        Barcode.Size = New Size(153, 27)
        Barcode.TabIndex = 1
        ' 
        ' ReturnGrid
        ' 
        ReturnGrid.BackgroundColor = Color.White
        ReturnGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReturnGrid.GridColor = SystemColors.ActiveBorder
        ReturnGrid.Location = New Point(12, 91)
        ReturnGrid.Margin = New Padding(3, 4, 3, 4)
        ReturnGrid.Name = "ReturnGrid"
        ReturnGrid.ReadOnly = True
        ReturnGrid.RowHeadersWidth = 51
        ReturnGrid.RowTemplate.Height = 24
        ReturnGrid.Size = New Size(845, 384)
        ReturnGrid.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(546, 32)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 44)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(643, 31)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 44)
        Button2.TabIndex = 4
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(745, 32)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 44)
        Button3.TabIndex = 5
        Button3.Text = "RETURN"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GrandTotal
        ' 
        GrandTotal.Location = New Point(678, 482)
        GrandTotal.Name = "GrandTotal"
        GrandTotal.Size = New Size(179, 27)
        GrandTotal.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(583, 485)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 7
        Label1.Text = "GrandTotal :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(295, 485)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 9
        Label2.Text = "CurrentTotal :"
        ' 
        ' CurrentTotal
        ' 
        CurrentTotal.Location = New Point(398, 482)
        CurrentTotal.Name = "CurrentTotal"
        CurrentTotal.Size = New Size(179, 27)
        CurrentTotal.TabIndex = 8
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 521)
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
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
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
