Imports EE
Imports MPP
Public Class BLLOrder

    Public Function VerificarExistencia(orden As Order) As Order
        Dim oMPP As New MPPOrder
        Return oMPP.VerificarExistencia(orden)
    End Function

End Class
