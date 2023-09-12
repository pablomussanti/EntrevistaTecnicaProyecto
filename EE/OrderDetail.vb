Public Class OrderDetail
    Private _OrderID As Integer
    Public Property OrderID() As Integer
        Get
            Return _OrderID
        End Get
        Set(ByVal value As Integer)
            _OrderID = value
        End Set
    End Property

    Private _ProductID As Integer
    Public Property ProductID() As Integer
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Integer)
            _ProductID = value
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

    Private _Quantity As Integer
    Public Property Quantity() As Integer
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Integer)
            _Quantity = value
        End Set
    End Property

    Private _Discount As Double
    Public Property Discount() As Double
        Get
            Return _Discount
        End Get
        Set(ByVal value As Double)
            _Discount = value
        End Set
    End Property

End Class
