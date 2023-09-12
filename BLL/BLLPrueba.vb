Imports EE
Imports MPP
Public Class BLLPrueba
    Public Function CrearRegion(region As Region) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPPrueba
        resultado = oMPP.CrearRegion(region)
        Return resultado
    End Function

    Public Function ModificarRegion(region As Region) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPPrueba
        resultado = oMPP.ModificarRegion(region)
        Return resultado
    End Function

    Public Function EliminarRegion(region As Region) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPPrueba
        resultado = oMPP.EliminarRegion(region)
        Return resultado
    End Function

    Public Function ListarRegion() As List(Of Region)
        Dim lista As New List(Of Region)
        Dim oMPP As New MPPPrueba
        lista = oMPP.ListarRegion()
        Return lista
    End Function
End Class
