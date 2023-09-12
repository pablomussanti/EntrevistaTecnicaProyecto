Imports MPP
Imports EE
Public Class BLLProduct
    Public Function TraerProductOrderDetail(orden As Order) As List(Of VistaProductOrderDetail)
        Dim lista As New List(Of VistaProductOrderDetail)
        Dim oMPP As New MPPProduct
        lista = oMPP.TraerProductOrderDetail(orden)
        Return lista
    End Function
End Class
