<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stock_report
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        CheckBox1 = New CheckBox()
        ComboBox4 = New ComboBox()
        Label4 = New Label()
        Label2 = New Label()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Panel3 = New Panel()
        date_filter = New CheckBox()
        Panel5 = New Panel()
        pro_filter = New CheckBox()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(461, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1190, 660)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Stocks Details"' 
        ' Button1
        ' 
        Button1.Location = New Point(442, 613)
        Button1.Name = "Button1"
        Button1.Size = New Size(328, 34)
        Button1.TabIndex = 12
        Button1.Text = "Generate Report"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersHeight = 50
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(20, 77)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 89
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.RowTemplate.Height = 50
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1150, 529)
        DataGridView1.TabIndex = 11
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(1004, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(168, 29)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Order Cost Wise"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(29, 75)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(343, 33)
        ComboBox4.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(28, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 9
        Label4.Text = "Brand :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(25, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 5
        Label2.Text = "Products :"' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(29, 237)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(343, 33)
        ComboBox3.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(29, 158)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(343, 33)
        ComboBox2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(25, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 25)
        Label3.TabIndex = 7
        Label3.Text = "Category :"' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(49, 222)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(344, 31)
        DateTimePicker2.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(44, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 11
        Label5.Text = "To Date"' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(49, 138)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(344, 31)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(43, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 3
        Label1.Text = "From Date"' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(Panel3)
        GroupBox1.Controls.Add(Panel5)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(443, 660)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "***"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 25)
        Label6.TabIndex = 21
        Label6.Text = "Select the Filters :"' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(date_filter)
        Panel3.Location = New Point(20, 82)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(405, 204)
        Panel3.TabIndex = 20
        ' 
        ' date_filter
        ' 
        date_filter.AutoSize = True
        date_filter.Location = New Point(374, 7)
        date_filter.Name = "date_filter"
        date_filter.Size = New Size(22, 21)
        date_filter.TabIndex = 0
        date_filter.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(ComboBox3)
        Panel5.Controls.Add(ComboBox2)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(ComboBox4)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(20, 316)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(405, 320)
        Panel5.TabIndex = 19
        ' 
        ' pro_filter
        ' 
        pro_filter.AutoSize = True
        pro_filter.Location = New Point(407, 337)
        pro_filter.Name = "pro_filter"
        pro_filter.Size = New Size(22, 21)
        pro_filter.TabIndex = 1
        pro_filter.UseVisualStyleBackColor = True
        ' 
        ' stock_report
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1663, 708)
        Controls.Add(pro_filter)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "stock_report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stocks Report"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents date_filter As CheckBox
    Friend WithEvents pro_filter As CheckBox
End Class
