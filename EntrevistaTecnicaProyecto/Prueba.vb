Imports BLL
Imports EE
Public Class Prueba
    Dim region As New BLLPrueba
    Private Sub Enlazar()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = region.ListarRegion()
        'Me.DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlazar()
    End Sub
End Class