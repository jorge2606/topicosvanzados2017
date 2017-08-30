Public Class Interfaz_del_Vendedor

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresarCompra.Click
        Ingresar_Compras.ShowDialog()

    End Sub

    Private Sub LblCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCerrarSesion.Click
        If Libreria.cerrarSesion(TxtNombreDelVendedor.Text) = True Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub BtnConsultarLibros_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultarLibros.Click
        Consultar_Libros.ShowDialog()
    End Sub

    Private Sub BtnonsultarClientes_Click(sender As System.Object, e As System.EventArgs) Handles BtnonsultarClientes.Click
        Consultar_Cliente.ShowDialog()
    End Sub

    Private Sub Interfaz_del_Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ingreso_al_Sistema.Hide()
    End Sub
End Class