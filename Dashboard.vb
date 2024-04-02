Imports System.Windows

Public Class Dashboard

    Private Sub Dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim queryStockList As String = "SELECT TOP(10) Product_name, Quantity FROM Products ORDER BY CAST(Quantity As INT) ASC"
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
                MsgBox("no label")
                i += 1
            End If

        End While


        BtnLeaderMonth.PerformClick()
        BtnProductMonth.PerformClick()
        BtnSalesMonth.PerformClick()
    End Sub

    Private Function getParameters() As Dictionary(Of String, Object)
        Dim dateString As String = (Date.Now).ToString
        Dim array As String() = dateString.Split(" ")
        array = array(0).Split("/")
        MsgBox(array(0).ToString)
        Dim monthInteger As Integer = Convert.ToInt32(array(1))
        Dim yearInteger As Integer = Convert.ToInt32(array(2))
        Dim parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        parameters.Add("@month", monthInteger)
        parameters.Add("@year", yearInteger)
        Return parameters
    End Function


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
        LProductQty.Text = result.GetValueOrDefault("productQty")
        LProductAmount.Text = result.GetValueOrDefault("productCost")
    End Sub

    Private Sub BtnProductYear_Click(sender As Object, e As EventArgs) Handles BtnProductYear.Click
        Dim result As Dictionary(Of String, Object) = getProductYear(getParameters())
        LProductName.Text = result.GetValueOrDefault("productName")
        LProductQty.Text = result.GetValueOrDefault("productQty")
        LProductAmount.Text = result.GetValueOrDefault("productCost")
    End Sub

    Private Sub BtnSalesMonth_Click(sender As Object, e As EventArgs) Handles BtnSalesMonth.Click
        Dim queryMonthSales As String = "SELECT SUM(Convert(float,Total)) FROM Billing WHERE MONTH(Date) = @month AND YEAR(Date) = @year"
        Dim queryTotalSales As String = "SELECT SUM(Convert(float,Total)) FROM Billing"
        Dim result As Dictionary(Of String, Object) = getSalesMonth(queryMonthSales, queryTotalSales, getParameters())
        LTotalSales.Text = (result.GetValueOrDefault("totalCost")).ToString
        LChangeSales.Text = (result.GetValueOrDefault("monthCost")).ToString
    End Sub

    Private Sub BtnSalesYear_Click(sender As Object, e As EventArgs) Handles BtnSalesYear.Click
        Dim queryYearSales As String = "SELECT SUM(Convert(float,Total)) FROM Billing WHERE YEAR(Date) = @year"
        Dim queryTotalSales As String = "SELECT SUM(Convert(float,Total)) FROM Billing"
        Dim result As Dictionary(Of String, Object) = getSalesYear(queryYearSales, queryTotalSales, getParameters())
        LTotalSales.Text = (result.GetValueOrDefault("totalCost")).ToString
        LChangeSales.Text = (result.GetValueOrDefault("yearCost")).ToString
    End Sub

    Private Sub BtnGrowthMonth_Click(sender As Object, e As EventArgs) Handles BtnGrowthMonth.Click
        Dim queryCustQty As String = "select COUNT(Customer_id) from Customer"
        Dim queryCustVisitQty As String = "select COUNT(DISTINCT Customer_id) from Billing where MONTH(Date) = @month AND YEAR(Date) = @year"
        'Dim result As Dictionary(Of String, Object) = getCustomerMonth(queryCustQty, queryCustVisitQty, getParameters())
    End Sub

    Private Sub BtnGrowthYear_Click(sender As Object, e As EventArgs) Handles BtnGrowthYear.Click
        Dim queryCustQty As String = "select COUNT(Customer_id) from Customer"
        Dim queryCustVisitQty As String = "select COUNT(DISTINCT Customer_id) from Billing where YEAR(Date) = @year"
        'Dim result As Dictionary(Of String, Object) = getCustomerYear(queryCustQty, queryCustVisitQty, getParameters())
    End Sub
End Class