Imports DAL
Imports EE
Public Class MPPCustomer
    Public Function TraerCustomers(orden As Order) As List(Of Customer)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Customer)
        Dim nuevoDato As Customer
        Dim hdatos As New Hashtable

        hdatos.Add("@orderid", orden.Id)

        DS = oDatos.Leer("s_Customers_TraerPorOrden", hdatos)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                nuevoDato = New Customer
                'nuevoDato.Id = Item("RegionID")
                nuevoDato.CompanyName = Item("CompanyName")
                nuevoDato.Address = Item("Address")
                lista.Add(nuevoDato)
            Next

            Return lista
        Else
            Return Nothing
        End If
    End Function
End Class
