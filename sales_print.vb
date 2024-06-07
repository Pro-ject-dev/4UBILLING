Imports Microsoft.Reporting.WinForms
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class sales_print

    Private Sub demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            Using con As New SqlConnection(connectionString)
                con.Open()

                Using cmd As New SqlCommand(sales_query, con)
                    Dim da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    da.Fill(dt)
                End Using
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "Report2.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dataset", dt))
            End With
            Dim ps As New PageSettings()
            ps.PaperSize = New PaperSize("A4", 827, 1169)
            ps.Landscape = False
            Me.ReportViewer1.SetPageSettings(ps)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal)
            Me.ReportViewer1.RefreshReport()


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    'Private Sub demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        Dim dt As New DataTable
    '        Using con As New SqlConnection(connectionString)
    '            con.Open()

    '            Using cmd As New SqlCommand(sales_query, con)
    '                Dim da As New SqlDataAdapter
    '                da.SelectCommand = cmd
    '                da.Fill(dt)
    '            End Using
    '        End Using

    '        With Me.ReportViewer1.LocalReport
    '            .DataSources.Clear()
    '            .ReportPath = "Report2.rdlc"
    '            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dataset", dt))
    '        End With

    '        Dim ps As New PageSettings()
    '        ps.PaperSize = New PaperSize("A4", 827, 1169)
    '        ps.Landscape = False
    '        Me.ReportViewer1.SetPageSettings(ps)
    '        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal)

    '        ' Adjust the ReportViewer height based on the content
    '        Dim rowCount As Integer = dt.Rows.Count
    '        Dim rowHeight As Integer = 30 ' Assuming each row roughly takes 30 pixels in height
    '        Dim reportHeight As Integer = rowCount * rowHeight

    '        ' Ensure the height is within a reasonable range
    '        If reportHeight < 500 Then
    '            reportHeight = 500 ' Minimum height
    '        ElseIf reportHeight > 1500 Then
    '            reportHeight = 1500 ' Maximum height
    '        End If

    '        Me.ReportViewer1.Height = reportHeight

    '        Me.ReportViewer1.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Try
    '        Dim filePath As String = Path.Combine("C:\sales_report", "report.pdf")
    '        Dim dir As String = Path.GetDirectoryName(filePath)

    '        If Not Directory.Exists(dir) Then
    '            Directory.CreateDirectory(dir)
    '        End If

    '        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "YourNamespace.Report2.rdlc"
    '        Dim renderedBytes As Byte() = Me.ReportViewer1.LocalReport.Render("PDF")
    '        File.WriteAllBytes(filePath, renderedBytes)
    '        sendmail("Sales Report", "4U Fashions Sales Report", filePath)

    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = Path.Combine("C:\sales_report", "report.pdf")
            Dim dir As String = Path.GetDirectoryName(filePath)

            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            ' Generate the PDF report
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "YourNamespace.Report2.rdlc"
            Dim renderedBytes As Byte() = Me.ReportViewer1.LocalReport.Render("PDF")
            File.WriteAllBytes(filePath, renderedBytes)

            ' Process the PDF to remove even pages
            Dim opfilepath As String = RemoveEvenPages(filePath)

            ' Send the modified PDF
            sendmail("Sales Report", "4U Fashions Sales Report", opfilepath)

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
