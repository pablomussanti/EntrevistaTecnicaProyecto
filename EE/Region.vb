Public Class Region
    Inherits Entidad

    Private _RegionDescription As String
    Public Property RegionDescription() As String
        Get
            Return _RegionDescription
        End Get
        Set(ByVal value As String)
            _RegionDescription = value
        End Set
    End Property

End Class
