Imports System.IO
Public Class Investment
    Enum InvestmentType
        Stock
        MutualFunds
        Commodity
        MoneyMarket
    End Enum


    Class PriceType
    Public Property Ticker As String
    Public Property Price As Double
End Class

Public Property Type As InvestmentType
Public Property PurchaseDate As Date
    Public Property PricePerShare As Integer
    Public Property NumOfShares As Integer
    Public Property Ticker As String
    Private Shared prices As New Collection

    Private Shared priceAdpter As New InvestTrackDataSetTableAdapters.PricesTableAdapter
    Private Shared investAdpter As New InvestTrackDataSetTableAdapters.InvestmentsTableAdapter
    Public ReadOnly Property PurchaseAmount As Double
        Get
            Return PricePerShare * NumOfShares
        End Get
    End Property
    Public Shared Sub LoadPrices()
        Dim table As InvestTrackDataSet.PricesDataTable = priceAdpter.GetData()
        For Each row As DataRow In table
            prices.Add(row("Price"), row("Ticker").ToString())
        Next

    End Sub

    Public Shared Function GetCurrentPrice(ticker As String) As Double
        If prices.Contains(ticker) Then
            Return CType(prices.Item(ticker), PriceType).Price
        Else
            Return -1.0
        End If
    End Function

    Public Shared Sub Insert(inv As Investment)
        Dim rowToInsert As Integer = investAdpter.Insert(inv.Ticker, CShort(inv.Type), CDec(inv.PricePerShare),
                                                         inv.PurchaseDate, CShort(inv.NumOfShares))
    End Sub

End Class


