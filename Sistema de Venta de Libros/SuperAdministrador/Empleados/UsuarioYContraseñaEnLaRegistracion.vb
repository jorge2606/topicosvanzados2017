Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class UsuarioYContraseñaEnLaRegistracion
    Dim comando As SqlCommand
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim reader As SqlDataReader



    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtUsuario.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtUsuario.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub UsuarioYContraseñaEnLaRegistracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.UsuariosDelSistema' Puede moverla o quitarla según sea necesario.
        ' Me.UsuariosDelSistemaTableAdapter.Fill(Me.DataSet1.UsuariosDelSistema)
        consultarTodoConInnerJoint()
        DtgUsuariosYContrasenas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'Me.DtgUsuariosYContrasenas.RowTemplate.Height = 120
        TxtDni.Text = Registrar_Empleados.TxtDni.Text
        TxtDni.Enabled = True
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtContrasena.TextLength = 0 Or TxtUsuario.TextLength = 0 Or TxtDni.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            'comprobamos que no exista en la base de datos
            If ComprobacionExistenciaEnLaTablaUsuariosDelSistema(TxtDni.Text) = True Then
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
                    cmdInsertar.Parameters.AddWithValue("@dni", TxtDni.Text)
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
        End If
    End Sub

    Private Sub consultarTodoConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT dni AS DNI,usuario AS USUARIO,contraseña AS CONTRASEÑA,Estado.descripcion as Estado FROM UsuariosDelSistema INNER JOIN Estado ON UsuariosDelSistema.estadoEnElSistema = Estado.cod_estado;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgUsuariosYContrasenas.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function ComprobacionExistencia(ByVal p_dni As String) As Boolean
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
    Function ComprobacionExistenciaEnLaTablaUsuariosDelSistema(ByVal p_dni As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
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

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        consultarTodoConInnerJoint()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ' MsgBox(Libreria.Salir())
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

   
    Private Sub TxtDni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDni.LostFocus
        If TxtDni.TextLength > 0 Then
            If TxtDni.TextLength < 8 Then
                TxtDni.BackColor = Color.Red
                MsgBox("Ingreso menos digitos de los que posee un dni", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                TxtDni.Focus()
            ElseIf ComprobacionExistencia(CInt(TxtDni.Text)) = False Then
                TxtDni.BackColor = Color.White
            End If
        End If
    End Sub
End Class