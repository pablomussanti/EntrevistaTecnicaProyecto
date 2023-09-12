Imports MPP
Imports EE
Public Class BLLCustomer
    Public Function TraerCustomers(orden As Order) As List(Of Customer)
        Dim lista As New List(Of Customer)
        Dim oMPP As New MPPCustomer
        lista = oMPP.TraerCustomers(orden)
        Return lista
    End Function

End Class
