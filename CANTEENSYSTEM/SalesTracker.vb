Module SalesTracker

    Private _totalSales As Decimal = 0
    Private _itemsSold As Integer = 0
    Private _sales As New List(Of Decimal)
    Private _transactionItems As New List(Of Integer)

    ' Employee storage for salary deduction
    Public Class Employee
        Public Property EmpNo As String
        Public Property FullName As String
        Public Property Position As String
        Public Property SDRemaining As Decimal
        Public Property Status As String
        Public Property DeductionStatus As String

        Public Sub New(empNo As String, fullName As String, position As String, sdRemaining As Decimal, status As String, deductionStatus As String)
            Me.EmpNo = empNo
            Me.FullName = fullName
            Me.Position = position
            Me.SDRemaining = sdRemaining
            Me.Status = status
            Me.DeductionStatus = deductionStatus
        End Sub
    End Class

    Private _employees As New List(Of Employee)

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

    Public ReadOnly Property Employees As List(Of Employee)
        Get
            Return _employees
        End Get
    End Property

    Public Sub RecordSale(total As Decimal, items As Integer)
        _totalSales += total
        _itemsSold += items
        _sales.Add(total)
        _transactionItems.Add(items)
    End Sub

    Public Sub AddEmployee(empNo As String, fullName As String, position As String, sdRemaining As Decimal, status As String, deductionStatus As String)
        ' Check if employee already exists (by EmpNo)
        Dim existing = _employees.FirstOrDefault(Function(e) e.EmpNo = empNo)
        If existing IsNot Nothing Then
            ' Update existing
            existing.FullName = fullName
            existing.Position = position
            existing.SDRemaining = sdRemaining
            existing.Status = status
            existing.DeductionStatus = deductionStatus
        Else
            _employees.Add(New Employee(empNo, fullName, position, sdRemaining, status, deductionStatus))
        End If
    End Sub

End Module