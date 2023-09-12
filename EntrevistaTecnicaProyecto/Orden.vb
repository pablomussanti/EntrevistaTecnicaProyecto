Imports EE
Imports BLL
Imports System.Text.RegularExpressions
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

            Dim verificador As Boolean = Regex.IsMatch(TxtCodigo.Text, "^([0-9]+$)")

            If verificador = False Then
                MsgBox("Numero de Orden: Se escribio un texto", MsgBoxStyle.Information, "VALIDACION ERROR")
                Exit Sub
            Else
                order.Id = TxtCodigo.Text
            End If

            If BLLOrder.VerificarExistencia(order).Id = 0 Then

                MessageBox.Show(String.Format("Orden no valida, la orden {0} no existe", TxtCodigo.Text))

            Else

                MessageBox.Show(String.Format("Orden valida, orden seleccionada {0}", TxtCodigo.Text))

            End If



        Catch ex As Exception
            MessageBox.Show(String.Format("{0}"), ex.Message)
        End Try
    End Sub
End Class