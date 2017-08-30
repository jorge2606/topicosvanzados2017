Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class AsignacionDeUsuarioYContraseña
    Dim comando As SqlCommand
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim reader As SqlDataReader

    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        TxtDni.Focus()
        TxtContrasena.Visible = False
        TxtUsuario.Visible = False
        TxtDni.Visible = True
        LblContrasena.Visible = False
        LblUsuario.Visible = False
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        LblDni.Visible = True
        BtnModificarEstado.Enabled = False
        BtnEliminar.Enabled = True
        TxtDni.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtDni.Clear()
    End Sub

    Private Sub RbtModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificar.CheckedChanged
        TxtDni.Focus()
        TxtContrasena.Visible = True
        TxtDni.Visible = True
        TxtUsuario.Visible = True
        LblContrasena.Visible = True
        LblDni.Visible = True
        LblUsuario.Visible = True
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnModificarEstado.Enabled = False
        BtnGuardar.Enabled = False
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = True
        LblAyuda.Visible = False
        TxtDni.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtDni.Clear()
    End Sub

    Private Sub RbtInsertar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtInsertar.CheckedChanged
        TxtDni.Focus()
        TxtContrasena.Visible = True
        TxtDni.Visible = True
        TxtUsuario.Visible = True
        LblContrasena.Visible = True
        LblDni.Visible = True
        LblUsuario.Visible = True
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Enabled = False
        BtnEliminar.Enabled = False
        LblAyuda.Visible = True
        BtnGuardar.Enabled = True
        TxtDni.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtDni.Clear()
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        TxtDni.Focus()
        TxtContrasena.Visible = False
        TxtDni.Visible = True
        TxtUsuario.Visible = False
        LblContrasena.Visible = False
        LblDni.Visible = True
        LblUsuario.Visible = False
        LblEstado.Visible = True
        CboEstado.Visible = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnModificarEstado.Enabled = True
        LblAyuda.Visible = True
        TxtDni.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtDni.Clear()
    End Sub

    Private Sub AsignacionDeUsuarioYContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        DtgAsignacioDeUsuarioYContraseña.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        consultarTodoConInnerJoint()
        LblAyuda.Visible = False
        LblContrasena.Visible = False
        LblDni.Visible = False
        LblEstado.Visible = False
        LblUsuario.Visible = False
        TxtContrasena.Visible = False
        TxtDni.Visible = False
        TxtUsuario.Visible = False
        CboEstado.Visible = False
        TxtDni.Clear()
        TxtContrasena.Clear()
        TxtUsuario.Clear()
        TxtDni.Clear()
        ' Me.DtgAsignacioDeUsuarioYContraseña.RowTemplate.Height = 80
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub
    Function ComprobacionExistencia(ByVal p_dni As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empleados WHERE dni = '" & p_dni & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = True
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Function ComprobacionExistenciaEnLaTablaUsuariosDelSistema(ByVal p_dni As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM UsuariosDelSistema WHERE dni = '" & p_dni & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = True
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Function ExistenciaEnLaTablaUsuariosDelSistemaString(ByVal p_usuario As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM UsuariosDelSistema WHERE usuario = '" & p_usuario & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = True
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtContrasena.TextLength = 0 Or TxtUsuario.TextLength = 0 Or TxtDni.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            'comprobamos que no exista en la base de datos
            If ComprobacionExistencia(CInt(TxtDni.Text)) = True Then
                If ComprobacionExistenciaEnLaTablaUsuariosDelSistema(CInt(TxtDni.Text)) = True Then
                    MsgBox("El Usuario " + TxtDni.Text + " Ya Posee Usuario y Contraseña", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    TxtDni.Clear()
                    TxtUsuario.Clear()
                    TxtContrasena.Clear()
                Else
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                    End Try
                    If Libreria.deseaGuardar() = 6 Then
                        Dim insertar As String
                        insertar = "INSERT INTO  UsuariosDelSistema(dni,usuario,contraseña,estadoEnElSistema)" & "VALUES" & " (@dni,@usuario,@contraseña,@estadoEnElSistema) "
                        Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                        cmdInsertar.Parameters.AddWithValue("@dni", CInt(TxtDni.Text))
                        cmdInsertar.Parameters.AddWithValue("@usuario", Libreria.TodoEnMayuscula(Me.TxtUsuario.Text))
                        cmdInsertar.Parameters.AddWithValue("@contraseña", Libreria.TodoEnMayuscula(Me.TxtContrasena.Text))
                        cmdInsertar.Parameters.AddWithValue("@estadoEnElSistema", 1)
                        Try
                            cmdInsertar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        MsgBox("El Usuario fue Registrado exitosamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Exito")
                        consultarTodoConInnerJoint()
                    End If
                End If
            Else
                MsgBox("El Empleado con el dni '" & TxtDni.Text & "' no Existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        End If
    End Sub
    Private Sub consultarTodoConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT dni,usuario,contraseña,Estado.descripcion as Estado FROM UsuariosDelSistema INNER JOIN Estado ON UsuariosDelSistema.estadoEnElSistema = Estado.cod_estado;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgAsignacioDeUsuarioYContraseña.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        consultarTodoConInnerJoint()
    End Sub

    Private Sub LblAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblAyuda.Click
        Try
            TxtDni.Clear()
            TxtUsuario.Clear()
            TxtContrasena.Clear()
            Consultar_Empleados.BtnSalir.Visible = False
            Consultar_Empleados.ControlBox = True
            Consultar_Empleados.MinimizeBox = False
            Consultar_Empleados.MaximizeBox = False
            Consultar_Empleados.ShowDialog()
            OrdenarFormularioDeEmpleado()
            Me.TxtDni.Text = Consultar_Empleados.DtgConsultarEmpleados.SelectedRows(0).Cells(0).Value.ToString()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub OrdenarFormularioDeEmpleado()
        Consultar_Empleados.BtnSalir.Visible = True
        Consultar_Empleados.ControlBox = False
        Consultar_Empleados.MinimizeBox = False
        Consultar_Empleados.MaximizeBox = False
    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDni.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtUsuario.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub
    Function ComprobacionEstado(ByVal p_dni As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM UsuariosDelSistema WHERE dni = '" & p_dni & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            estado = reader.Item(3)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return estado
    End Function

    Function StringEstado(ByVal p_estado As Integer) As String
        Dim buscar As String
        Dim estado As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Estado WHERE cod_estado = '" & p_estado & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            estado = reader.Item(1)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return estado
    End Function

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtDni.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistenciaEnLaTablaUsuariosDelSistema(CInt(TxtDni.Text)) = True Then
                If ComprobacionEstado(CInt(TxtDni.Text)) = 1 Then
                    If Libreria.deseaEliminar() = 6 Then
                        Try
                            miConexion.Open()
                        Catch ex As Exception
                            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                        End Try
                        Dim nro As Integer
                        Try
                            nro = CInt(TxtDni.Text)
                        Catch ex As Exception
                            MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                            Exit Sub
                        End Try
                        Dim actualizar As String
                        actualizar = "UPDATE UsuariosDelSistema SET estadoEnElSistema=@estadoEnElSistema WHERE dni = @dni"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@dni", nro)
                        cmdActualizar.Parameters.AddWithValue("@estadoEnElSistema", 2)
                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        consultarTodoConInnerJoint()
                        MsgBox("La Usuario fue Eliminado Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                        miConexion.Close()
                    End If
                Else
                    MsgBox("El Usuario ya fue Eliminado ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
                End If
            Else
                MsgBox("El Usuario No Existe ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        End If
    End Sub

    Private Sub DtgAsignacioDeUsuarioYContraseña_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgAsignacioDeUsuarioYContraseña.Click
        Try
            TxtDni.Text = DtgAsignacioDeUsuarioYContraseña.SelectedRows(0).Cells(0).Value.ToString()
            TxtUsuario.Text = DtgAsignacioDeUsuarioYContraseña.SelectedRows(0).Cells(1).Value.ToString()
            TxtContrasena.Text = DtgAsignacioDeUsuarioYContraseña.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub BtnModificarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEstado.Click
        If TxtDni.TextLength = 0 Or CboEstado.Text = "" Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If Libreria.deseaModificar() = 6 Then
                If CboEstado.SelectedValue = ComprobacionEstado(CInt(TxtDni.Text)) Then
                    MsgBox("El Empleado ya fue dado de " + Libreria.PrimeraLetraEnMayuscula(StringEstado(CboEstado.SelectedValue)) + " ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Error")
                Else
                    Dim nro As Integer
                    Try
                        nro = CInt(TxtDni.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                    End Try
                    Dim actualizar As String
                    actualizar = "UPDATE UsuariosDelSistema SET estadoEnElSistema = @estadoEnElSistema WHERE dni = @dni"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@dni", nro)
                    cmdActualizar.Parameters.AddWithValue("@estadoEnElSistema", CInt(CboEstado.SelectedValue))
                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    MsgBox("El Estado fue modificado correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Éxito")
                    consultarTodoConInnerJoint()
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtDni.TextLength = 0 Or TxtContrasena.TextLength = 0 Or TxtUsuario.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ExistenciaEnLaTablaUsuariosDelSistemaString(TxtUsuario.Text) = True Then
                MsgBox("El Usuario " + Libreria.PrimeraLetraEnMayuscula(TxtUsuario.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                If ComprobacionEstado(CInt(TxtDni.Text)) = 1 Then
                    If Libreria.deseaModificar() = 6 Then
                        Dim nro As Integer
                        Try
                            nro = CInt(TxtDni.Text)
                        Catch ex As Exception
                            MsgBox("Ingreso un Valor incorrecto en el campo Dni", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                            Exit Sub
                        End Try
                        Try
                            miConexion.Open()
                        Catch ex As Exception
                            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                        End Try
                        Dim actualizar As String
                        actualizar = "UPDATE UsuariosDelSistema SET usuario = @usuario,contraseña=@contraseña WHERE dni = @dni"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@dni", nro)
                        cmdActualizar.Parameters.AddWithValue("@usuario", Libreria.TodoEnMayuscula(Me.TxtUsuario.Text))
                        cmdActualizar.Parameters.AddWithValue("@contraseña", Libreria.TodoEnMayuscula(TxtContrasena.Text))

                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        MsgBox("La Categoria fue modificada correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Éxito")
                        consultarTodoConInnerJoint()
                    End If
                Else
                    MsgBox("La Categoria ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
                End If
            End If
        End If
    End Sub
End Class