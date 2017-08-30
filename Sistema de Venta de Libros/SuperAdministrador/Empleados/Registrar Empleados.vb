Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Registrar_Empleados
    Dim dataset As DataSet = New DataSet()
    Dim dataset2 As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim directorioProyecto As String
    Dim extensionimagen As String
    Dim destino As String
    Dim origen As String
    Dim nombreImagen As String
    Dim extencion As String
    Dim imagen1 As Image
    Dim DniUsu As Integer



    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If (Libreria.vacioEmpleadosRegis() = True) Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            Dim Nombrefoto As String = TxtNombre.Text
            'Es la carpeta destino donde voy a copiar los archivos  Se tiene que crear primero la carpeta “Fotos”
            nombreImagen = Nombrefoto
            destino = directorioProyecto + "\FotosEmpleados\" + nombreImagen + extensionimagen
            'Copio la imagen a la carpeta del proyecto "Fotos"
            Try
                System.IO.File.Copy(origen, destino, True)
            Catch ex As Exception
                MsgBox("Ingrese una imagen", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Me.DtgRegistrarEmpleados.ForeColor = Color.Black
            Dim NombreUsu As String
            Dim ApellidoUsu As String

            Dim UsuarioUsu As String = " "
            Dim ContrasenaUsu As String = " "
            Dim DirecciónUsu As String
            Dim TelefonoUsu As String
            Dim CorreoElectronicoUsu As String
            ' Dim cod_Empleo As Integer
            Dim vDia As String = DtpFechaDeNacimiento.Value.Day
            Dim vMes As String = DtpFechaDeNacimiento.Value.Month
            Dim vAño As String = DtpFechaDeNacimiento.Value.Year
            Dim vDia1 As String = DtpFechaRegistracion.Value.Day
            Dim vMes1 As String = DtpFechaRegistracion.Value.Month
            Dim vAño1 As String = DtpFechaRegistracion.Value.Year

            Dim sexo As Integer
            'excepcion para las viariables que van a ingresar en el datagrid
            Try
                NombreUsu = TxtNombre.Text
                ApellidoUsu = TxtApellido.Text
                DniUsu = Convert.ToInt32(TxtDni.Text)
                DirecciónUsu = TxtDireccion.Text
                TelefonoUsu = TxtTelefono.Text
                sexo = CboSexo.SelectedValue
                CorreoElectronicoUsu = TxtCorreoElectronico.Text
            Catch ex As Exception
                MsgBox("Ingreso mal un valor en un campo, verifique y continue", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End Try
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar nuevo Empleado", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim insertar As String
                insertar = "INSERT INTO Empleados(dni, nombre,apellido,Empleo,provincia,localidad,perfil,sexo,estado,fecha_registracion,direccion,telefono,correoElectronico,fechaNacimiento)" & "VALUES" & "(@dni, @nombre,@apellido,@Empleo,@provincia,@localidad,@perfil,@sexo,@estado,@fecha_registracion,@direccion,@telefono,@correoElectronico,@fechaNacimiento)"
                Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                cmdInsertar.Parameters.AddWithValue("@dni", DniUsu)
                cmdInsertar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(NombreUsu))
                cmdInsertar.Parameters.AddWithValue("@apellido", Libreria.TodoEnMayuscula(ApellidoUsu))
                cmdInsertar.Parameters.AddWithValue("@Empleo", CboEmpleo.SelectedValue)
                cmdInsertar.Parameters.AddWithValue("@provincia", CboProvincia.SelectedValue)
                cmdInsertar.Parameters.AddWithValue("@localidad", CboLocalidad.SelectedValue)
                cmdInsertar.Parameters.AddWithValue("@perfil", Libreria.TodoEnMayuscula(destino))
                cmdInsertar.Parameters.AddWithValue("@sexo", sexo)
                cmdInsertar.Parameters.AddWithValue("@estado", 1)
                cmdInsertar.Parameters.AddWithValue("@fecha_registracion", Convert.ToString(vDia1 & "-" & vMes1 & "-" & vAño1))
                cmdInsertar.Parameters.AddWithValue("@direccion", Libreria.TodoEnMayuscula(DirecciónUsu))
                cmdInsertar.Parameters.AddWithValue("@telefono", Libreria.TodoEnMayuscula(TelefonoUsu))
                cmdInsertar.Parameters.AddWithValue("@correoElectronico", Libreria.TodoEnMayuscula(CorreoElectronicoUsu))
                cmdInsertar.Parameters.AddWithValue("@fechaNacimiento", Convert.ToString(vDia & "-" & vMes & "-" & vAño))
                Try
                    cmdInsertar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                consultaConInnerJoint_REGISTRAREMPLEADO(DniUsu)
                MsgBox("El Empleado: " + TxtNombre.Text + " " + TxtApellido.Text + " se inserto correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Guardar")
                TxtApellido.Clear()
                ' TxtContrasena.Clear()
                TxtCorreoElectronico.Clear()
                TxtDireccion.Clear()
                TxtDni.Clear()
                TxtNombre.Clear()
                TxtRutaDeFoto.Clear()
                TxtTelefono.Clear()
                'TxtUsuario.Clear()
                PtboxPerfilEmpleado.Image = Nothing
                CboEmpleo.Text = Nothing
                CboLocalidad.Text = Nothing
                CboProvincia.Text = Nothing
                CboSexo.Text = Nothing
            End If
            consultaConInnerJoint_REGISTRARLIBRO()
        End If

    End Sub
    Public Sub consultaConInnerJoint_REGISTRAREMPLEADO(ByVal P_dni As Integer)
        Dim buscarv As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarv = "SELECT Empleados.dni,Empleados.nombre,Empleados.apellido,Codigo_de_empleo.descripcion,Provincias.descripcion,Localidades.descripcion,perfil,Sexo.descripcion,Estado.descripcion,Empleados.fecha_registracion,Empleados.direccion,Empleados.telefono,Empleados.correoElectronico,Empleados.fechaNacimiento FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & P_dni & "' and Empleados.estado=1 ;"
        miAdaptador1 = New SqlDataAdapter(buscarv, miConexion)
        ' dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgRegistrarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click

        Dim Imagen1 As Image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Imagen1 = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        origen = OpenFileDialog1.FileName
        nombreImagen = System.IO.Path.GetFileName(origen)
        PtboxPerfilEmpleado.Image = Imagen1
        nombreImagen = TxtNombre.Text
        extensionimagen = System.IO.Path.GetExtension(origen)
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        destino = directorioProyecto + "\FotosEmpleados\" + nombreImagen + extensionimagen
        System.IO.File.Copy(origen, destino, True)
        TxtRutaDeFoto.Text = origen
    End Sub

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtApellido.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub

    ' Private Sub TxtCorreoElectronico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCorreoElectronico.KeyPress
    '     Libreria.soloLetrasSinEspacios(e)
    'End Sub

    'Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress

    'End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDni.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNombre.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtTelefono.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DtgRegistrarEmpleados.Rows.Remove(Me.DtgRegistrarEmpleados.CurrentRow)
        Libreria.cantidadlineas()
    End Sub

    Private Sub Registrar_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.FillByProvincias(Me.DataSet1.Provincias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.FillBySexoActicvos(Me.DataSet1.Sexo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Codigo_de_Empleo' Puede moverla o quitarla según sea necesario.
        Me.Codigo_de_EmpleoTableAdapter.FillByCodigoDeEmpleo(Me.DataSet1.Codigo_de_Empleo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillByEmpleado(Me.DataSet1.Empleados, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadosTableAdapter.Fill(Me.DataSet1.Empleados)
        Libreria.cantidadlineas()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CboEmpleo.Text = Nothing
        CboLocalidad.Text = Nothing
        CboProvincia.Text = Nothing
        CboSexo.Text = Nothing
        'Obtiene la ruta del directorio donde esta el proyecto
        TxtNombre.Focus()
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        DtgRegistrarEmpleados.RowTemplate.Height = 50
        TxtRutaDeFoto.Visible = True
        'Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch
        MostrarTodoConInnerJoint()
        'DtpFechaDeNacimiento.Value = Convert.ToDateTime(0 / 0 / 0)
        ' DtpFechaDeNacimiento.Text = 0 / 0 / 0
    End Sub
    Private Sub MostrarTodoConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni,Empleados.nombre,Empleados.apellido,Codigo_de_empleo.descripcion as Empleo,Provincias.descripcion as Provincias,Localidades.descripcion as Localidades,perfil,Sexo.descripcion as Sexo,Estado.descripcion as Estado,Empleados.fecha_registracion,Empleados.direccion,Empleados.telefono,Empleados.correoElectronico,Empleados.fechaNacimiento FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        Me.DtgRegistrarEmpleados.ClearSelection()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgRegistrarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub DtgRegistrarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRegistrarEmpleados.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DtgRegistrarEmpleados.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgRegistrarEmpleados.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar_Empleado"
                        If Libreria.DeseaEliminarLibros() = 1 Then
                            Eliminar_Empleados.ShowDialog()
                        End If
                    Case "Modificar_Empl"
                        Modificar_Empleados.ShowDialog()
                        Exit Select
                End Select

            End If

        End If
    End Sub

    Private Sub BntSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntSalir.Click
        If Libreria.Salir() = 1 Then
            AsignacionDeUsuarioYContraseña.TxtDni.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub TxtCorreoElectronico_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCorreoElectronico.KeyPress
        If e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtCorreoElectronico.Focus()
        Else
            Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
        End If
    End Sub

    Private Sub TxtCorreoElectronico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.LostFocus
        If TxtCorreoElectronico.TextLength > 0 Then
            If InStr(TxtCorreoElectronico.Text, "@") = False Or InStr(TxtCorreoElectronico.Text, ".com") = False Then
                TxtCorreoElectronico.BackColor = Color.Red
                MsgBox("Ingrese el caracter @ seguido de su cuenta y finalmente .com", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Advertencia")
                TxtCorreoElectronico.Focus()
            Else
                TxtCorreoElectronico.BackColor = Color.Lavender
            End If
        End If
    End Sub

    Private Sub TxtCorreoElectronico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.TextChanged
        If TxtCorreoElectronico.TextLength = 0 Then
            TxtCorreoElectronico.Text = "@.com"
        End If
    End Sub


    Private Sub TxtApellido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtApellido.LostFocus
        TxtApellido.Text = Libreria.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    
    Private Sub BtnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiar.Click
        If PtboxPerfilEmpleado.Image IsNot Nothing Then
            PtboxPerfilEmpleado.Image = Nothing
            TxtRutaDeFoto.Text = Nothing
        Else
            MsgBox("No hay imagen para cambiar", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
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
        buscar = "SELECT * FROM Empleados WHERE dni = '" & p_dni & "' AND estado = 1"
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
    Private Sub TxtDni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDni.LostFocus
        If TxtDni.TextLength > 0 Then
            Try
                If ComprobacionExistencia(CInt(TxtDni.Text)) = True Then
                    TxtDni.BackColor = Color.Red
                    MsgBox(TxtNombre.Text + " ya esta registrado", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    TxtDni.Focus()
                    Exit Sub
                ElseIf TxtDni.TextLength < 8 Then
                    MsgBox("Ingreso menos digitos de los que posee un dni", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                    TxtDni.Focus()
                ElseIf TxtDni.Text > "50000000" Or TxtDni.Text < "20000000" Then
                    MsgBox("DNI fuera de Rango", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    TxtDni.BackColor = Color.Red
                    TxtDni.Focus()
                ElseIf TxtDni.TextLength = 8 Then
                    TxtDni.BackColor = Color.LemonChiffon
                ElseIf ComprobacionExistencia(CInt(TxtDni.Text)) = False Then
                    TxtDni.BackColor = Color.LemonChiffon
                End If
            Catch ex As Exception
                MsgBox("Ingrese Dni", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End Try
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDireccion.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        MostrarTodoConInnerJoint()
    End Sub

    Private Sub LblNuevoUsuarioDelSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNuevoUsuarioDelSistema.Click
        If (Libreria.vacioEmpleadosRegis() = True) Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            UsuarioYContraseñaEnLaRegistracion.ShowDialog()
        End If
    End Sub

    Private Sub TxtDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDni.TextChanged

    End Sub
End Class