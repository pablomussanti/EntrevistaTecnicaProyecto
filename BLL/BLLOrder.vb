Imports EE
Imports MPP
Public Class BLLOrder

    Public Function TraerOrden(order As Order) As Order
        Dim oMPP As New MPPOrder
        Return oMPP.TraerOrden(order)
    End Function

End Class
