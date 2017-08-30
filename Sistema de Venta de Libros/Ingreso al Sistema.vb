Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Ingreso_al_Sistema
    Dim dataset As DataSet = New DataSet()
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim empleoDelEmpleado As String
    'variables que toman los valores de las tablas de empleados
    Dim dni As Integer
    Dim nombre As String
    Dim apellido As String
    Dim cod_empleo As Integer
    Dim provincia As String
    Dim localidad As String
    Dim perfil As String
    Dim sexo As Integer
    Dim usuario As String
    Dim contraseña As String
    Dim estado As Integer
    ' Dim fecha_registracion As DateTimePicker
    Dim direccion As String
    Dim telefono As String
    Dim usuario1 As String
    Dim contraseña1 As String
    Dim correo As String
    Dim estadoEnLaTablaUsuario As Integer
    '  Dim fecha_nacimiento As DateTimePicker
    Dim i As Integer = 3

    Private Sub BTnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnIngresar.Click
        If TxtContrasena.TextLength = 0 And TxtUsuario.TextLength = 0 Then
            MsgBox("Completar todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Try
                usuario1 = Libreria.TodoEnMayuscula(TxtUsuario.Text)
                contraseña1 = Libreria.TodoEnMayuscula(TxtContrasena.Text)
                miConexion.Close()
            Catch ex As Exception
                MsgBox("Ingreso una valor incorrecto en el/los campos Usuario y Contraseña ", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            If ComprobacionExistenciaUsuario(usuario1, contraseña1) = True Then
                cargarVariablesPertenecientesalUsuario(CInt(dni))
                If estadoEnLaTablaUsuario = 2 And estado = 2 Then
                    MsgBox("Usted, su usuario y contraseña fueron dados de baja del Sistema contactese con el superadministrado", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                ElseIf estadoEnLaTablaUsuario = 1 And estado = 2 Then
                    MsgBox("Usted fue dado de baja, por lo tanto su usuario y contraseña son invalidos, Contactese con el SuperAdministrador", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Ingreso Restringido")
                    TxtContrasena.Clear()
                    TxtUsuario.Clear()
                ElseIf estado = 1 And estadoEnLaTablaUsuario = 2 Then
                    MsgBox("Su Usuario y Contraseña fueron dados de baja, Contactese con el SuperAdministrador", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Ingreso Restringido")
                    TxtContrasena.Clear()
                    TxtUsuario.Clear()
                Else
                    'MsgBox("Existe")
                    cargarVariablesPertenecientesalUsuario(CInt(dni))
                    Try
                        ' MsgBox(Empleo(cod_empleo))
                        empleoDelEmpleado = Empleo(cod_empleo)
                        ' MsgBox(empleoDelEmpleado)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Select Case empleoDelEmpleado
                        Case "ADMINISTRADOR"
                            Interfaz_del_Administrador.TxtNombreDelAdministrador.Text = Libreria.PrimeraLetraEnMayuscula(nombre + " " + apellido)
                            Interfaz_del_Administrador.PtbPerfilDelAdministrador.Image = System.Drawing.Image.FromFile(perfil)
                            Interfaz_del_Administrador.ShowDialog()
                            ' MsgBox("Bienvenido Administrador")
                        Case "SUPERADMINISTRADOR"
                            Interfaz_del_SuperUsuario.TxtNombreDelSuperUsuario.Text = Libreria.PrimeraLetraEnMayuscula(nombre + " " + apellido)
                            Interfaz_del_SuperUsuario.PBoxPerfil.Image = System.Drawing.Image.FromFile(perfil)
                            Interfaz_del_SuperUsuario.ShowDialog()
                            ' MsgBox("Bienvenido SuperAdministrador")
                        Case "GERENTE"
                            Archivos_del_Gerente.TxtNombreDelGerente.Text = Libreria.PrimeraLetraEnMayuscula(nombre + " " + apellido)
                            Archivos_del_Gerente.PtbPerfilDelAdministrador.Image = System.Drawing.Image.FromFile(perfil)
                            Archivos_del_Gerente.ShowDialog()
                            ' MsgBox("Bienvenido Gerente")
                        Case "VENDEDOR"
                            Interfaz_del_Vendedor.TxtNombreDelVendedor.Text = Libreria.PrimeraLetraEnMayuscula(nombre + " " + apellido)
                            Ingresar_Compras.TxtDni.Text = dni
                            Interfaz_del_Vendedor.PtbPerfilDelVendedor.Image = System.Drawing.Image.FromFile(perfil)
                            Interfaz_del_Vendedor.ShowDialog()
                            ' MsgBox("Bienvenido Vendedor")
                        Case Else
                            MsgBox("nueva categoria")
                    End Select
                    Exit Sub
                End If
            Else
                MsgBox("Usuario y Contraseña Invalidos le quedan", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Ingreso")
                TxtContrasena.Clear()
                TxtUsuario.Clear()
            End If
        End If
    End Sub

    Function ComprobacionExistenciaUsuario(ByVal p_usuario As String, ByVal p_contraseña As String) As Boolean
        Dim buscar As String
        Dim existeUsuario As Boolean
        'MsgBox(Libreria.TodoEnMayuscula(p_contraseña))
        buscar = "SELECT * FROM UsuariosDelSistema WHERE contraseña = '" & p_contraseña & "' and usuario = '" & p_usuario & "'"
        comando = New SqlCommand(buscar, miConexion)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        reader = comando.ExecuteReader()
        While reader.Read()
            dni = reader.Item(0)
            estadoEnLaTablaUsuario = reader.Item(3)
            'MsgBox("Estado" & estadoEnLaTablaUsuario)
            existeUsuario = True
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existeUsuario
    End Function

    Private Sub cargarVariablesPertenecientesalUsuario(ByVal p_dni As Integer)
        Dim buscarppp As String
        Dim dni1 As Integer = p_dni
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscarppp = "SELECT * FROM Empleados WHERE dni ='" & p_dni & "'"
        comando = New SqlCommand(buscarppp, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nombre = reader.Item(1)
            'MsgBox(nombre)
            apellido = reader.Item(2)
            cod_empleo = reader.Item(3)
            ' MsgBox(cod_empleo)
            provincia = reader.Item(4)
            'MsgBox(provincia)
            localidad = reader.Item(5)
            perfil = reader.Item(6)
            sexo = reader.Item(7)
            estado = reader.Item(8)
            ' MsgBox(reader.Item(8))
            'fecha_registracion = reader.Item(11)
            direccion = reader.Item(9)
            telefono = reader.Item(10)
            correo = reader.Item(11)
            'fecha_nacimiento = reader.Item(15)
            '   existeUsuario = True
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        'Return existeUsuario
    End Sub
    Function Empleo(ByVal p_cod_Empleo As Integer) As String
        Dim buscar As String
        Dim existe As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Codigo_de_Empleo WHERE cod_empleo = '" & p_cod_Empleo & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(1)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Private Sub TxtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContrasena.KeyPress
        Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
    End Sub

    Private Sub TxtUsario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtContrasena.LostFocus
        If TxtContrasena.MaxLength = 0 Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical, vbReadOnly)
        End If
    End Sub

    Private Sub Ingreso_al_Sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
    End Sub


End Class