Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.Drawing.Printing

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

End Class
