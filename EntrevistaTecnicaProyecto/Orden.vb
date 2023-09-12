Imports EE
Imports BLL
Imports System.Text.RegularExpressions
Public Class Orden
    Dim BLLOrder As New BLLOrder
    Dim BLLCustomer As New BLLCustomer
    Dim BLLProduct As New BLLProduct
    Private Sub Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub enlazarCustomers(orden As Order)
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = BLLCustomer.TraerCustomers(orden)
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(2).Visible = False
        Me.DataGridView1.Columns(3).Visible = False
        Me.DataGridView1.Columns(5).Visible = False
        Me.DataGridView1.Columns(6).Visible = False
        Me.DataGridView1.Columns(7).Visible = False
        Me.DataGridView1.Columns(8).Visible = False
        Me.DataGridView1.Columns(9).Visible = False
        Me.DataGridView1.Columns(10).Visible = False
    End Sub

    Public Sub enlazarProductOrderDetail(orden As Order)
        Me.DataGridView2.DataSource = Nothing
        Me.DataGridView2.DataSource = BLLProduct.TraerProductOrderDetail(orden)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim orden As New Order

            Dim verificador As Boolean = Regex.IsMatch(TxtCodigo.Text, "^([0-9]+$)")

            If verificador = False Then
                MsgBox("Numero de Orden: Se escribio un texto", MsgBoxStyle.Information, "VALIDACION ERROR")
                Exit Sub
            Else
                orden.Id = TxtCodigo.Text
            End If

            If BLLOrder.VerificarExistencia(orden).Id = 0 Then

                MessageBox.Show(String.Format("Orden no valida, la orden {0} no existe", TxtCodigo.Text))

            Else

                MessageBox.Show(String.Format("Orden valida, orden seleccionada {0}", TxtCodigo.Text))

                enlazarCustomers(orden)

                enlazarProductOrderDetail(orden)

            End If



        Catch ex As Exception
            MessageBox.Show(String.Format("{0}"), ex.Message)
        End Try
    End Sub
End Class