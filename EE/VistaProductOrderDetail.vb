Public Class VistaProductOrderDetail

    Private _ProductName As String
    Public Property ProductName() As String
        Get
            Return _ProductName
        End Get
        Set(ByVal value As String)
            _ProductName = value
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

    Private _Contador As Integer
    Public Property Contador() As Integer
        Get
            Return _Contador
        End Get
        Set(ByVal value As Integer)
            _Contador = value
        End Set
    End Property

End Class
