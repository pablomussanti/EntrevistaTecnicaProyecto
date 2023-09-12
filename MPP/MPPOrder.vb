Imports EE
Imports DAL
Public Class MPPOrder
    Public Function VerificarExistencia(orden As Order) As Order

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Region)
        Dim nuevoDato As New Order
        Dim hdatos As New Hashtable

        hdatos.Add("@orderid", orden.Id)

        DS = oDatos.Leer("s_Order_Traer", hdatos)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows

                nuevoDato.Id = Item("OrderId")

            Next

            Return nuevoDato
        Else
            Return nuevoDato
        End If
    End Function
End Class
