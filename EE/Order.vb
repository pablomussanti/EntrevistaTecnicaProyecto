Public Class Order
    Inherits Entidad

    Private _CustomerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Integer)
            _CustomerID = value
        End Set
    End Property

    Private _OrderDate As DateTime
    Public Property OrderDate() As DateTime
        Get
            Return _OrderDate
        End Get
        Set(ByVal value As DateTime)
            _OrderDate = value
        End Set
    End Property

    Private _EmployeeID As Integer
    Public Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
        End Set
    End Property

    Private _RequiredDate As DateTime
    Public Property RequiredDate() As DateTime
        Get
            Return _RequiredDate
        End Get
        Set(ByVal value As DateTime)
            _RequiredDate = value
        End Set
    End Property

    Private _ShippedDate As DateTime
    Public Property ShippedDate() As DateTime
        Get
            Return _ShippedDate
        End Get
        Set(ByVal value As DateTime)
            _ShippedDate = value
        End Set
    End Property

    Private _ShipVia As Integer
    Public Property ShipVia() As Integer
        Get
            Return _ShipVia
        End Get
        Set(ByVal value As Integer)
            _ShipVia = value
        End Set
    End Property

    Private _Freight As Double
    Public Property Freight() As Double
        Get
            Return _Freight
        End Get
        Set(ByVal value As Double)
            _Freight = value
        End Set
    End Property

    Private _ShipName As String
    Public Property ShipName() As String
        Get
            Return _ShipName
        End Get
        Set(ByVal value As String)
            _ShipName = value
        End Set
    End Property

    Private _ShipAdress As String
    Public Property ShipAdress() As String
        Get
            Return _ShipAdress
        End Get
        Set(ByVal value As String)
            _ShipAdress = value
        End Set
    End Property

    Private _ShipCity As String
    Public Property ShipCity() As String
        Get
            Return _ShipCity
        End Get
        Set(ByVal value As String)
            _ShipCity = value
        End Set
    End Property

    Private _ShipRegion As String
    Public Property ShipRegion() As String
        Get
            Return _ShipRegion
        End Get
        Set(ByVal value As String)
            _ShipRegion = value
        End Set
    End Property

    Private _ShipPostalCode As String
    Public Property ShipPostalCode() As String
        Get
            Return _ShipPostalCode
        End Get
        Set(ByVal value As String)
            _ShipPostalCode = value
        End Set
    End Property

    Private _ShipCountry As String
    Public Property ShipCountry() As String
        Get
            Return _ShipCountry
        End Get
        Set(ByVal value As String)
            _ShipCountry = value
        End Set
    End Property
End Class
