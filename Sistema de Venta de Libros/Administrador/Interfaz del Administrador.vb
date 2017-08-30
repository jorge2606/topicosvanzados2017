Public Class Interfaz_del_Administrador

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrarLibros.Click
        Form1.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarLibros.Click
        Eliminar_Libros.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarLibros.Click
        Modificar_Libros.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultarLibros.Click
        Consultar_Libros.ShowDialog()

    End Sub

    Private Sub LblCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCerrarSesion.Click
        If Libreria.cerrarSesion(TxtNombreDelAdministrador.Text) = True Then
            Me.Close()
            'Ingreso_al_Sistema.ShowDialog()
        Else
        End If
    End Sub

    Private Sub Interfaz_del_Administrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ingreso_al_Sistema.Hide()
    End Sub
End Class