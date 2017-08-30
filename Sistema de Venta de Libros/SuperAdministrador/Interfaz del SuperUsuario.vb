Public Class Interfaz_del_SuperUsuario

    Private Sub BtnRegistrarEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrarEmpleados.Click
        Registrar_Empleados.ShowDialog()

    End Sub

    Private Sub BtnEliminarEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarEmpleados.Click
        Eliminar_Empleados.ShowDialog()

    End Sub

    Private Sub BtnModificarEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEmpleados.Click
        Modificar_Empleados.ShowDialog()

    End Sub

    Private Sub BtnConsultarEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultarEmpleados.Click
        Consultar_Empleados.ShowDialog()

    End Sub

    Private Sub BtnEliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarCliente.Click
        Eliminar_Cliente.ShowDialog()

    End Sub

    Private Sub BtnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarCliente.Click
        Modificar_Cliente.ShowDialog()

    End Sub

    Private Sub BtnConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultarCliente.Click
        Consultar_Cliente.ShowDialog()
    End Sub

    Private Sub Interfaz_del_SuperUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ingreso_al_Sistema.Hide()
    End Sub

    Private Sub BtnRegistrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrarCliente.Click
        Registrar_Clientes.ShowDialog()
    End Sub

    Private Sub LblCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCerrarSesion.Click
        If Libreria.cerrarSesion(TxtNombreDelSuperUsuario.Text) = True Then
            ' MsgBox("")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AsignacionDeUsuarioYContraseña.ShowDialog()
    End Sub
End Class