
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_dialogue
    Private Sub Add_dialogue_Load(sender As Object, e As EventArgs) Handles Me.Load

        If common.status = "category" Then
            GroupBox1.Text = "Category"
            Label1.Text = "Enter Your Category Name :"
            Me.Text = "Add Category"
        Else
            GroupBox1.Text = "Brand"
            Label1.Text = "Enter Your Brand Name :"
            Me.Text = "Add Brand"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If common.status = "category" Then
            If TextBox1.Text.Trim.Length <> 0 Then

                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Category ?")

                If state Then


                    Dim insertQuery As String = " INSERT INTO Category (category,Status)values( (SELECT @Value1 WHERE NOT EXISTS (SELECT 1 FROM Category WHERE category = @Value1 and status ='1')),1)"
                    Dim valuesToInsert As New Dictionary(Of String, Object)
                    valuesToInsert.Add("@Value1", TextBox1.Text)

                    If common.InsertData(insertQuery, valuesToInsert) Then
                        Add_Product.ComboBox1.Items.Clear()
                        Add_list("select * from category  where status='1' order by cat_id", Add_Product.ComboBox1, "category")
                        MsgBox("Category is Successfully Added !")

                        Me.Close()
                    Else
                        MsgBox("Something Went Wrong !")
                        Me.Close()
                    End If
                Else
                    MsgBox("Please Enter Category Name")

                End If
            End If
        Else
            If TextBox1.Text.Trim.Length <> 0 Then
                Dim state As Boolean = ShowConfirmation("Are You Sure to Add this Brand ?")

                If state Then


                    Dim insertQuery As String = "INSERT INTO Brands (brand,Status) values((SELECT @Value1 WHERE NOT EXISTS (SELECT 1 FROM Brands WHERE brand = @Value1 and status ='1')),1)"
                    Dim valuesToInsert As New Dictionary(Of String, Object)()
                    valuesToInsert.Add("@Value1", TextBox1.Text)

                    If common.InsertData(insertQuery, valuesToInsert) Then
                        Add_Product.ComboBox2.Items.Clear()
                        Add_list("select * from brands where status='1' order by brand_id", Add_Product.ComboBox2, "brand")
                        MsgBox("Brand Name is Successfully Added !")
                        Me.Close()
                    Else
                        MsgBox("Something Went Wrong !")
                        Me.Close()
                    End If
                Else
                    MsgBox("Please Enter Brand Name")
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class