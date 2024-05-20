Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sales_print
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
        ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ReportViewer1
        ' 
        ReportViewer1.Anchor = AnchorStyles.None
        ReportViewer1.Location = New Point(50, 50)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(1000, 600)
        ReportViewer1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(798, 7)
        Button1.Name = "Button1"
        Button1.Size = New Size(251, 34)
        Button1.TabIndex = 2
        Button1.Text = "Send Via Mail"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' sales_print
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1115, 672)
        Controls.Add(Button1)
        Controls.Add(ReportViewer1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "sales_print"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales Report - Print Preview"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Login As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
End Class
