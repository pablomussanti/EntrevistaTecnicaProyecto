Imports DAL
Imports EE
Public Class MPPProduct
    Public Function TraerProductOrderDetail(orden As Order) As List(Of VistaProductOrderDetail)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of VistaProductOrderDetail)
        Dim nuevoDato As VistaProductOrderDetail
        Dim hdatos As New Hashtable

        hdatos.Add("@orderid", orden.Id)

        DS = oDatos.Leer("s_Products_TraerProductosOrden", hdatos)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                nuevoDato = New VistaProductOrderDetail
                nuevoDato.ProductName = Item("ProductName")
                nuevoDato.Quantity = Item("Quantity")
                nuevoDato.UnitPrice = Item("UnitPrice")
                nuevoDato.Contador = Item("Contador")
                lista.Add(nuevoDato)
            Next

            Return lista
        Else
            Return Nothing
        End If
    End Function
End Class
