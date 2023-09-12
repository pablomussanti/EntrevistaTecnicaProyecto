Public Class Product
    Inherits Entidad

    Private _ProductName As String
    Public Property ProductName() As String
        Get
            Return _ProductName
        End Get
        Set(ByVal value As String)
            _ProductName = value
        End Set
    End Property

    Private _SupplierID As Integer
    Public Property SupplierID() As Integer
        Get
            Return _SupplierID
        End Get
        Set(ByVal value As Integer)
            _SupplierID = value
        End Set
    End Property

    Private _CategoryID As Integer
    Public Property Category() As Integer
        Get
            Return _CategoryID
        End Get
        Set(ByVal value As Integer)
            _CategoryID = value
        End Set
    End Property

    Private _QuantityPerUnit As String
    Public Property QuantityPerUnit() As String
        Get
            Return _QuantityPerUnit
        End Get
        Set(ByVal value As String)
            _QuantityPerUnit = value
        End Set
    End Property

    Private _UnitPrice As Double
    Public Property UnitPrice() As Double
        Get
            Return _UnitPrice
        End Get
        Set(ByVal value As Double)
            _UnitPrice = value
        End Set
    End Property

    Private _UnitsInStock As Integer
    Public Property UnitsInStock() As Integer
        Get
            Return _UnitsInStock
        End Get
        Set(ByVal value As Integer)
            _UnitsInStock = value
        End Set
    End Property

    Private _UnitsOnOrder As Integer
    Public Property UnitsOnOrder() As Integer
        Get
            Return _UnitsOnOrder
        End Get
        Set(ByVal value As Integer)
            _UnitsOnOrder = value
        End Set
    End Property

    Private _ReorderLevel As Integer
    Public Property ReorderLevel() As Integer
        Get
            Return _ReorderLevel
        End Get
        Set(ByVal value As Integer)
            _ReorderLevel = value
        End Set
    End Property

    Private _Discontinued As Boolean
    Public Property Discontinued() As Boolean
        Get
            Return _Discontinued
        End Get
        Set(ByVal value As Boolean)
            _Discontinued = value
        End Set
    End Property
End Class
