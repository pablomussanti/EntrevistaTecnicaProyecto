Imports EE
Imports BLL
Public Class Orden
    Dim BLLOrder As New BLLOrder
    Private Sub Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazar()
    End Sub

    Public Sub enlazar()
        Me.DataGridView1.DataSource = Nothing

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim order As New Order
            order.Id = TxtCodigo.Text

            If BLLOrder.TraerOrden(order).Id = 0 Then

                MessageBox.Show("Orden no valida")

            Else

                MessageBox.Show("Orden valida")

            End If



        Catch ex As Exception

        End Try
    End Sub
End Class