﻿Imports System.Windows

Public Class Dashboardd

    Public Sub Dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1120, 560)

        timer_tick()
        Me.IconRupee.Image = My.Resources.rupee
        Me.IconQuantity.Image = My.Resources.totalcustomer
        Me.IconChangeCost.Image = My.Resources.changecostqty
        Me.IconChangeQty.Image = My.Resources.changecostqty
    End Sub

    Private Function getParameters() As Dictionary(Of String, Object)
        Dim dateString As String = (Date.Now).ToString("MM/dd/yyyy")
        Try
            Dim array As String() = dateString.Split("-")
            Dim monthInteger As Integer = Convert.ToInt32(array(0))
            Dim yearInteger As Integer = Convert.ToInt32(array(2))
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            parameters.Add("@month", monthInteger)
            parameters.Add("@year", yearInteger)
            Return parameters
        Catch ex As Exception
            Dim array As String() = dateString.Split("/")
            Dim monthInteger As Integer = Convert.ToInt32(array(0))
            Dim yearInteger As Integer = Convert.ToInt32(array(2))
            Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            parameters.Add("@month", monthInteger)
            parameters.Add("@year", yearInteger)
            Return parameters
        End Try




    End Function

    Public Sub timer_tick()
        Dim queryStockList As String = "SELECT TOP(10) Product_name, convert(varchar,Quantity) FROM Products ORDER BY Quantity ASC"
        Dim result As Dictionary(Of String, Object) = getStockList(queryStockList)
        Dim i As Integer = 1
        While i < 11
            Dim textPrd As String = "LStock" + (i.ToString())
            Dim textQty As String = "LQty" + (i.ToString())
            Dim lblPrd As Label = Me.Controls.Find(textPrd, True).FirstOrDefault()
            Dim lblQty As Label = Me.Controls.Find(textQty, True).FirstOrDefault()
            If lblPrd IsNot Nothing And TypeOf lblPrd Is Label And lblQty IsNot Nothing And TypeOf lblQty Is Label Then
                lblPrd.Text = result.GetValueOrDefault("prd" + (i.ToString()))
                lblQty.Text = result.GetValueOrDefault("qty" + (i.ToString()))
                i += 1
            Else
                i += 1
            End If

        End While
        BtnLeaderMonth.PerformClick()
        BtnProductMonth.PerformClick()
        BtnSalesMonth.PerformClick()
        BtnGrowthMonth.PerformClick()
        Button1.PerformClick()
        Button1.Select()
    End Sub


    Private Sub BtnLeaderMonth_Click(sender As Object, e As EventArgs) Handles BtnLeaderMonth.Click
        Dim result As Dictionary(Of String, Object) = getLeaderMonth(getParameters())
        LLeaderCustomer.Text = result.GetValueOrDefault("custName")
        LLeaderPlace.Text = result.GetValueOrDefault("custPlace")
        LLeaderAmount.Text = result.GetValueOrDefault("custCost")
    End Sub

    Private Sub BtnLeaderYear_Click(sender As Object, e As EventArgs) Handles BtnLeaderYear.Click
        Dim result As Dictionary(Of String, Object) = getLeaderYear(getParameters())
        LLeaderCustomer.Text = result.GetValueOrDefault("custName")
        LLeaderPlace.Text = result.GetValueOrDefault("custPlace")
        LLeaderAmount.Text = result.GetValueOrDefault("custCost")
    End Sub

    Private Sub BtnProductMonth_Click(sender As Object, e As EventArgs) Handles BtnProductMonth.Click
        Dim result As Dictionary(Of String, Object) = getProductMonth(getParameters())
        LProductName.Text = result.GetValueOrDefault("productName")
        LProductQty.Text = (result.GetValueOrDefault("productQty")).ToString + " " + "Qty"
        LProductAmount.Text = result.GetValueOrDefault("productCost")
    End Sub

    Private Sub BtnProductYear_Click(sender As Object, e As EventArgs) Handles BtnProductYear.Click
        Dim result As Dictionary(Of String, Object) = getProductYear(getParameters())
        LProductName.Text = result.GetValueOrDefault("productName")
        LProductQty.Text = (result.GetValueOrDefault("productQty")).ToString + " " + "Qty"
        LProductAmount.Text = result.GetValueOrDefault("productCost")
    End Sub

    Private Sub BtnSalesMonth_Click(sender As Object, e As EventArgs) Handles BtnSalesMonth.Click
        Dim queryMonthSales As String = "SELECT (SELECT SUM(CONVERT(FLOAT, Total)) FROM Billing WHERE status=1 and MONTH(Date) = @month AND YEAR(Date) = @year) - isnull((SELECT SUM(CONVERT(FLOAT, Total)) FROM ReturnTable WHERE status=1 and MONTH(Date) = @month AND YEAR(Date) = @year),0)"
        Dim queryTotalSales As String = "SELECT (SELECT SUM(CONVERT(FLOAT, Total)) FROM Billing where status=1) -  isnull((SELECT SUM(CONVERT(FLOAT, Total)) FROM ReturnTable where status=1),0)"
        Dim result As Dictionary(Of String, Object) = getSalesMonth(queryMonthSales, queryTotalSales, getParameters())
        LTotalSales.Text = (result.GetValueOrDefault("totalCost")).ToString
        LChangeSales.Text = (result.GetValueOrDefault("monthCost")).ToString
    End Sub

    Private Sub BtnSalesYear_Click(sender As Object, e As EventArgs) Handles BtnSalesYear.Click
        Dim queryYearSales As String = "SELECT (SELECT SUM(CAST(Total AS DECIMAL(10,2))) FROM Billing WHERE status=1 and  YEAR(Date) = @year) - isnull((SELECT SUM(CONVERT(FLOAT, Total)) FROM ReturnTable WHERE YEAR(Date) = @year),0)"
        Dim queryTotalSales As String = "SELECT (SELECT SUM(CAST(Total AS DECIMAL(10,2))) FROM Billing where status=1) -  isnull((SELECT SUM(CONVERT(FLOAT, Total)) FROM ReturnTable where status=1),0)"
        Dim result As Dictionary(Of String, Object) = getSalesYear(queryYearSales, queryTotalSales, getParameters())
        LTotalSales.Text = (result.GetValueOrDefault("totalCost")).ToString
        LChangeSales.Text = (result.GetValueOrDefault("yearCost")).ToString
    End Sub

    Private Sub BtnGrowthMonth_Click(sender As Object, e As EventArgs) Handles BtnGrowthMonth.Click
        Dim queryCustQty As String = "select COUNT(Customer_id) from Customer"
        Dim queryCustVisitQty As String = "select COUNT(DISTINCT Customer_id) from Billing where status=1 and MONTH(Date) = @month AND YEAR(Date) = @year"
        Dim result As Dictionary(Of String, Object) = getCustomerMonth(queryCustQty, queryCustVisitQty, getParameters())
        LTotalCustomer.Text = result.GetValueOrDefault("custQty")
        LChangeCustomer.Text = result.GetValueOrDefault("custVisit")
    End Sub

    Private Sub BtnGrowthYear_Click(sender As Object, e As EventArgs) Handles BtnGrowthYear.Click
        Dim queryCustQty As String = "select COUNT(Customer_id) from Customer"
        Dim queryCustVisitQty As String = "select COUNT(DISTINCT Customer_id) from Billing where YEAR(Date) = @year"
        Dim result As Dictionary(Of String, Object) = getCustomerYear(queryCustQty, queryCustVisitQty, getParameters())
        LTotalCustomer.Text = result.GetValueOrDefault("custQty")
        LChangeCustomer.Text = result.GetValueOrDefault("custVisit")
    End Sub

    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Double
        Dim dtString As String = (Date.Now).ToString("dd-MM-yyyy")
        Dim querytodaysales As String = "select (select sum(CAST(Total AS DECIMAL(10,2))) from billing where status=1 and convert(varchar,date,105) = '" + dtString + "' ) - isnull((select sum(convert(float, total)) from returntable where status=1 and convert(varchar,date,105)='" + dtString + "'),0 )as tot"
        Dim datatable As DataTable = getSalesToday(querytodaysales)
        Try
            If datatable.Rows.Count <> 0 Then
                For Each row As DataRow In datatable.Rows
                    If Not IsDBNull(row("tot")) Then
                        amount = Convert.ToInt32(row("tot"))
                    Else
                        amount = 0.0
                    End If
                Next
                LChangeSales.Text = amount.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        timer_tick()
    End Sub
End Class