Imports BLL
Imports EE
Public Class Prueba
    Dim region As New BLLPrueba
    Private Sub Enlazar()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = region.ListarRegion()
        'Me.DataGridView1.Columns(1).Visible = False
    End Sub

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Enlazar()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim l As DataGridViewSelectedRowCollection = Me.DataGridView1.SelectedRows

        If l.Count = 1 Then
            TextBox2.Text = DataGridView1.CurrentRow.Cells.Item(0).Value.ToString
            TextBox1.Text = DataGridView1.CurrentRow.Cells.Item(1).Value.ToString
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim oRegion As New Region

            If TextBox1.Text = "" Then
                oRegion.RegionDescription = TextBox2.Text
                region.CrearRegion(oRegion)
            Else
                oRegion.Id = TextBox1.Text
                oRegion.RegionDescription = TextBox2.Text
                region.ModificarRegion(oRegion)
            End If

            Enlazar()

            MessageBox.Show("Region Creada/Modificada")

        Catch ex As Exception
            MessageBox.Show(String.Format("Creacion/Modificacion Fallida, {0}", ex.Message))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim oRegion As New Region

            If TextBox1.Text = "" Then
                Throw New Exception()
            Else
                oRegion.Id = TextBox1.Text
                region.EliminarRegion(oRegion)
            End If

            Enlazar()

            MessageBox.Show("Region Eliminada")


        Catch ex As Exception
            MessageBox.Show(String.Format("Eliminacion Fallida, {0}", ex.Message))
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class