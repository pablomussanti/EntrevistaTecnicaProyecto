Imports DAL
Imports EE
Public Class MPPPrueba
    Public Function CrearRegion(region As Region) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Region_Crear"

        hdatos.Add("@regiondescription", region.RegionDescription)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado
    End Function

    Public Function ModificarRegion(region As Region) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Region_Modificar"

        hdatos.Add("@regionid", region.Id)
        hdatos.Add("@regiondescription", region.RegionDescription)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado
    End Function

    Public Function EliminarRegion(region As Region) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean

        hdatos.Add("@regionid", region.Id)

        resultado = oDatos.Escribir("s_Region_Eliminar", hdatos)

        Return resultado
    End Function

    Public Function ListarRegion() As List(Of Region)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Region)
        Dim nuevoDato As Region

        DS = oDatos.Leer("s_Region_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                nuevoDato = New Region
                nuevoDato.Id = Item("RegionID")
                nuevoDato.RegionDescription = Item("RegionDescription")
                lista.Add(nuevoDato)
            Next

            Return lista
        Else
            Return Nothing
        End If
    End Function
End Class
