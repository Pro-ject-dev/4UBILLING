Imports Microsoft.Reporting.WinForms
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
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filePath As String = Path.Combine("C:\sales_report", "report.pdf")
            Dim dir As String = Path.GetDirectoryName(filePath)

            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "YourNamespace.Report2.rdlc"
            Dim renderedBytes As Byte() = Me.ReportViewer1.LocalReport.Render("PDF")
            File.WriteAllBytes(filePath, renderedBytes)
            MessageBox.Show("Report saved successfully.")
            sendmail("Sales Report", "4U Fashions Sales Report", filePath)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class
