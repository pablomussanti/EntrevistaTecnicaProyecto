﻿Imports BLL

Public Class Menu
    Private Sub AlgoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlgoToolStripMenuItem.Click
        Dim ventana As New Prueba
        ventana.MdiParent = Me
        ventana.Show()
    End Sub

    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesToolStripMenuItem.Click
        Dim ventana As New Orden
        ventana.MdiParent = Me
        ventana.Show()
    End Sub
End Class
