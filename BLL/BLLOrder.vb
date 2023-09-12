Imports EE
Imports MPP
Public Class BLLOrder

    Public Function VerificarExistencia(order As Order) As Order
        Dim oMPP As New MPPOrder
        Return oMPP.VerificarExistencia(order)
    End Function

End Class
