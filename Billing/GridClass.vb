Imports System.Data.SqlClient

Public Class GridClass
    Public Sub gridWithPram(Grid As DataGridView, Sqlquery As String, GridColumn As List(Of Int32), Gridsize As List(Of Double), Parameters As List(Of SqlParameter))
        Try
            Dim con As SqlConnection = New SqlConnection(connectionString)
            Dim command1 As New SqlCommand(Sqlquery, con)

            ' Add parameters to the SqlCommand
            For Each parameter As SqlParameter In Parameters
                command1.Parameters.Add(parameter)
            Next

            Dim sda1 As New SqlDataAdapter(command1)
            Dim dt1 As New DataTable
            sda1.Fill(dt1)
            Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Grid.DataSource = dt1
            For i As Integer = 0 To GridColumn.Count - 1
                Grid.Columns(GridColumn(i)).Width = Gridsize(i)
            Next
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False
            Grid.AllowUserToResizeColumns = False
            Grid.Columns(0).Visible = True
            Grid.ColumnHeadersVisible = True
            Grid.ClearSelection()
            For Each row As DataGridViewRow In Grid.Rows
                If row.Index Mod 2 = 0 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
