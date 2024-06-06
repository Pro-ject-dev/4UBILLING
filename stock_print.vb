Imports Microsoft.Reporting.WinForms
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class stock_print

    Private Sub demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable

            Using con As New SqlConnection(connectionString)
                con.Open()

                Using cmd As New SqlCommand(stock_query, con)
                    Dim da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    da.Fill(dt)
                End Using
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "Report1.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Dim ps As New PageSettings()
            ps.PaperSize = New PaperSize("A4", 827, 1169)
            ps.Landscape = False
            Me.ReportViewer1.SetPageSettings(ps)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = Path.Combine("C:\stock_report", "report.pdf")
            Dim dir As String = Path.GetDirectoryName(filePath)
            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "YourNamespace.Report1.rdlc"
            Dim renderedBytes As Byte() = Me.ReportViewer1.LocalReport.Render("PDF")
            Dim opfilepath As String = RemoveEvenPages(filePath)
            MessageBox.Show("Report saved successfully.")
            sendmail("Stocks Report", "4U Fashions Stocks Report", opfilepath)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Function RemoveEvenPages(filePath As String)
        ' Define input and output file paths
        Dim OpfilePath As String = Path.Combine("C:\sales_report", "opreport.pdf")
        Dim inputFilePath As String = filePath
        Dim outputFilePath As String = OpfilePath
        Dim doc As PdfDocument = PdfReader.Open(inputFilePath, PdfDocumentOpenMode.Modify)
        Dim pageIndexes As New List(Of Integer)()
        For i As Integer = 0 To doc.PageCount - 1
            If (i + 1) Mod 2 = 0 Then
                pageIndexes.Add(i)
            End If
        Next
        'MsgBox(String.Join(", ", pageIndexes))
        For i As Integer = pageIndexes.Count - 1 To 0 Step -1
            doc.Pages.RemoveAt(pageIndexes(i))
        Next

        doc.Save(outputFilePath)
        doc.Close()
        'MsgBox("completed")
        Return OpfilePath
    End Function
End Class
