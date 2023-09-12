Public Class Customer

    Private _CustomerID As String
    Public Property CustomerID() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
        End Set
    End Property

    Private _CompanyName As String
    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Private _ContactName As String
    Public Property ContactName() As String
        Get
            Return _ContactName
        End Get
        Set(ByVal value As String)
            _ContactName = value
        End Set
    End Property

    Private _ContactTitle As String
    Public Property ContactTitle() As String
        Get
            Return _ContactTitle
        End Get
        Set(ByVal value As String)
            _ContactTitle = value
        End Set
    End Property

    Private _Address As String
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    Private _City As String
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    Private _Region As String
    Public Property Region() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property

    Private _PostalCode As String
    Public Property PostalCode() As String
        Get
            Return _PostalCode
        End Get
        Set(ByVal value As String)
            _PostalCode = value
        End Set
    End Property

    Private _Country As String
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property

    Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property

    Private _Fax As String
    Public Property Fax() As String
        Get
            Return _Fax
        End Get
        Set(ByVal value As String)
            _Fax = value
        End Set
    End Property

End Class
