Module SalesTracker

    Private _totalSales As Decimal = 0
    Private _itemsSold As Integer = 0
    Private _sales As New List(Of Decimal)
    Private _transactionItems As New List(Of Integer)

    Public ReadOnly Property TotalSales As Decimal
        Get
            Return _totalSales
        End Get
    End Property

    Public ReadOnly Property ItemsSold As Integer
        Get
            Return _itemsSold
        End Get
    End Property

    Public ReadOnly Property SaleAmounts As List(Of Decimal)
        Get
            Return _sales
        End Get
    End Property

    Public ReadOnly Property TransactionItems As List(Of Integer)
        Get
            Return _transactionItems
        End Get
    End Property

    Public Sub RecordSale(total As Decimal, items As Integer)
        _totalSales += total
        _itemsSold += items
        _sales.Add(total)
        _transactionItems.Add(items)
    End Sub

End Module