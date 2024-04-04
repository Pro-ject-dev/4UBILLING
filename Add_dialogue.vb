
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_dialogue
    Private Sub Add_dialogue_Load(sender As Object, e As EventArgs) Handles Me.Load

        If common.status = "category" Then
            GroupBox1.Text = "Category"
            Label1.Text = "Enter Your Category Name :"
            Me.Text = "Add Category"
        ElseIf status = "brand" Then
            GroupBox1.Text = "Brand"
            Label1.Text = "Enter Your Brand Name :"
            Me.Text = "Add Brand"
        Else
            GroupBox1.Text = "Size"
            Label1.Text = "Enter Your Size :"
            Me.Text = "Add Size"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If common.status = "category" Then
            If TextBox1.Text.Trim.Length <> 0 Then

                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Category ?")

                If state Then


                    Dim insertQuery As String = "If Not EXISTS (Select 1 FROM Category WHERE Category = @value1 and status=1) BEGIN INSERT INTO Category (Category,Status) values(@value1,1) END ELSE BEGIN RAISERROR ('Category with name %s already exists', 16, 1, @value1) END"
                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@Value1", TextBox1.Text.ToUpper)

                    If common.InsertData(insertQuery, valuesToInsert) Then
                        Add_Product.ComboBox1.Items.Clear()
                        Add_list("select * from category  where status='1' order by cat_id", Add_Product.ComboBox1, "category")
                        MsgBox("Category is Successfully Added !")

                        Me.Close()
                    Else


                    End If
                Else
                    MsgBox("Please Enter Category Name")

                End If
            End If
        ElseIf status = "brand" Then

            If TextBox1.Text.Trim.Length <> 0 Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Brand ?")

                If state Then


                    Dim insertQuery As String = "If Not EXISTS (Select 1 FROM brands WHERE brand = @value1 and status=1) BEGIN INSERT INTO Brands (brand,Status) values(@value1,1) END ELSE BEGIN RAISERROR ('Brand with name %s already exists', 16, 1, @value1) END"
                    Dim valuesToInsert As New Dictionary(Of String, Object)()
                    valuesToInsert.Add("@Value1", TextBox1.Text.ToUpper)

                    If common.InsertData(insertQuery, valuesToInsert) Then
                        Add_Product.ComboBox2.Items.Clear()
                        Add_list("select * from brands where status='1' order by brand_id", Add_Product.ComboBox2, "brand")
                        MsgBox("Brand Name is Successfully Added !")
                        Me.Close()


                    End If
                Else
                    MsgBox("Please Enter Brand Name")
                End If
            End If
        Else
            If TextBox1.Text.Trim.Length <> 0 Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Size ?")

                If state Then


                    Dim insertQuery As String = "If Not EXISTS (Select 1 FROM Size WHERE Size = @value1 and status=1) BEGIN INSERT INTO Size (Size,Status) values(@value1,1) END ELSE BEGIN RAISERROR ('Size of %s is already exists', 16, 1, @value1) END"
                    Dim valuesToInsert As New Dictionary(Of String, Object)()
                    valuesToInsert.Add("@Value1", TextBox1.Text.ToUpper)

                    If common.InsertData(insertQuery, valuesToInsert) Then
                        Add_Product.ComboBox3.Items.Clear()
                        Add_list("select * from size where status='1' order by size_id", Add_Product.ComboBox3, "size")
                        MsgBox("Size is Successfully Added !")
                        Me.Close()


                    End If
                Else
                    MsgBox("Please Enter Size")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class