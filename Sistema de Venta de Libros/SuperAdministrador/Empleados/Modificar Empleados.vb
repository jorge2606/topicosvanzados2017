Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Modificar_Empleados
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    'Variable para imagenes
    Dim directorioProyecto As String
    Dim extensionimagen As String
    Dim destino As String
    Dim origen As String
    Dim nombreImagen As String
    Dim extencion As String
    Dim imagen As Image
    'variables para comparar si hubo modificacion o no
    Dim DniEmpleado As String
    Dim NombreEmpleado As String
    Dim ApellidoEmpleado As String
    Dim Empleo As String
    Dim ProvinciaEmpleado As String
    Dim LocalidadEmpleado As String
    Dim rutaFotoEmpleado As String
    Dim SexoEmpleado As String
    Dim UsuarioEmpleado As String
    Dim ContraseñaEmpleado As String
    Dim EstadoEmpleado As String
    Dim DireccionEmpleado As String
    Dim TelefonoEmpleado As String
    Dim CorreoEmpleado As String
    Dim FechaNacimiento As String

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        Libreria.soloNumeroConEspacios(e)
    End Sub

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        Libreria.soloLetrasSinEspacios(e)
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        Libreria.soloLetrasSinEspacios(e)
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Libreria.soloNumeroConEspacios(e)
    End Sub

    Private Sub MostrarTodoConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.Empleo <> 2;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModificarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub Modificar_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Codigo_de_Empleo' Puede moverla o quitarla según sea necesario.
        Me.Codigo_de_EmpleoTableAdapter.FillByCodigoDeEmpleo(Me.DataSet1.Codigo_de_Empleo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.FillByProvincias(Me.DataSet1.Provincias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadosTableAdapter.FillByEmpleado(Me.DataSet1.Empleados, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.FillBySexoActicvos(Me.DataSet1.Sexo, 1)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.MaximizeBox = False
        Me.DtpNacimiento.Text = Nothing
        TxtBusquedaPorNombre.Visible = False
        'BtnBusquedaPorNombre.Visible = False
        TxtBusqueda.Visible = False
        ' BtnConsultar.Visible = False
        MostrarTodoConInnerJoint()
        Libreria.LimpiarCampoModificarEmpleados()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Width = 1277
        Me.Height = 589
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Width = 482
        Me.Height = 434
        Me.MaximizeBox = False
    End Sub
    Function huboModificacionONo() As Boolean
        Dim modificacion As Boolean = False
        If TxtDni.TextLength > 0 Then
            If (CInt(DniEmpleado) <> CInt(TxtDni.Text) Or (NombreEmpleado <> TxtNombre.Text) Or (ApellidoEmpleado <> TxtApellido.Text) Or (Empleo <> CboEmpleo.Text) Or (CboProvincia.Text <> ProvinciaEmpleado) Or (CboLocalidad.Text <> LocalidadEmpleado) Or (rutaFotoEmpleado <> TxtRuta.Text) Or (CboSexo.Text <> SexoEmpleado) Or (CboEstados.Text <> EstadoEmpleado) Or (DtpNacimiento.Text <> FechaNacimiento) Or (TxtDireccion.Text <> DireccionEmpleado) Or (txtTelefono.Text <> TelefonoEmpleado) Or (TxtCorreoElectronico.Text <> CorreoEmpleado)) Then
                modificacion = True
                Return modificacion
            Else
                Return modificacion
            End If
        Else
            Return modificacion
        End If
    End Function
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If huboModificacionONo() = True Then
            Dim resp As Integer = Libreria.SalirYguardar()
            If resp = 6 Then
                ConfirmacionModificar()
                MsgBox("Datos Guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Libreria.LimpiarCampoModificarEmpleados()
                Me.Close()
            ElseIf resp = 7 Then
                MsgBox("No se han Gurdado los datos modificados", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Libreria.LimpiarCampoModificarEmpleados()
                Me.Close()
            End If
        Else
            If Libreria.Salir() = 1 Then
                BtnModificar.Enabled = False
                Libreria.LimpiarCampoModificarEmpleados()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub ConfirmacionModificar()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim vDia As String = DtpNacimiento.Value.Day
        Dim vMes As String = DtpNacimiento.Value.Month
        Dim vAño As String = DtpNacimiento.Value.Year

        Dim vDiaREG As String = DtpRegistracion.Value.Day
        Dim vMesREG As String = DtpRegistracion.Value.Month
        Dim vAñoREG As String = DtpRegistracion.Value.Year
        ' CONTROLAR QUE EL INGRESO DE LOS DATOS SEAN CORRECTOS. VALIDARLOS.
        Dim actualizar As String
        Dim nro As Integer = CInt(TxtDni.Text)
        actualizar = "UPDATE Empleados SET fecha_registracion=@fecha_registracion,fechaNacimiento=@fechaNacimiento,nombre=@nombre, apellido=@apellido,Empleo=@Empleo,provincia=@provincia,localidad=@localidad,perfil=@perfil,sexo=@sexo,estado=@estado WHERE dni = @dni"
        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
        cmdActualizar.Parameters.AddWithValue("@dni", nro)
        cmdActualizar.Parameters.AddWithValue("@nombre", Me.TxtNombre.Text)
        cmdActualizar.Parameters.AddWithValue("@apellido", Me.TxtApellido.Text)
        cmdActualizar.Parameters.AddWithValue("@Empleo", CboEmpleo.SelectedValue)
        cmdActualizar.Parameters.AddWithValue("@provincia", CboProvincia.SelectedValue)
        cmdActualizar.Parameters.AddWithValue("@localidad", CboLocalidad.SelectedValue)
        cmdActualizar.Parameters.AddWithValue("@perfil", TxtRuta.Text)
        cmdActualizar.Parameters.AddWithValue("@sexo", CboSexo.SelectedValue)
        cmdActualizar.Parameters.AddWithValue("@estado", CboEstados.SelectedValue)
        cmdActualizar.Parameters.AddWithValue("@direccion", Me.TxtDireccion.Text)
        cmdActualizar.Parameters.AddWithValue("@telefono", txtTelefono.Text)
        cmdActualizar.Parameters.AddWithValue("@correoElectronico", TxtCorreoElectronico.Text)
        cmdActualizar.Parameters.AddWithValue("@fechaNacimiento", Convert.ToString(vDia & "-" & vMes & "-" & vAño))
        cmdActualizar.Parameters.AddWithValue("@fecha_registracion", Convert.ToString(vDiaREG & "-" & vMesREG & "-" & vAñoREG))

        Me.EmpleadosTableAdapter.Fill(Me.DataSet1.Empleados)
        MsgBox("El Empleado: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
        Try
            cmdActualizar.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub BtnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png"
        'Permite filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos 
        imagen = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)

        PBoxPerfilEmpleado.Image = imagen

        origen = OpenFileDialog1.FileName

        extensionimagen = System.IO.Path.GetExtension(origen)
        TxtRuta.Text = origen


    End Sub

    Private Sub TxtCorreoElectronico_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCorreoElectronico.KeyPress
        Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
    End Sub

    Private Sub TxtCorreoElectronico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.TextChanged
        If TxtCorreoElectronico.TextLength = 0 Then
            TxtCorreoElectronico.Text = "@.com"
        End If
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtApellido_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtApellido.LostFocus
        TxtApellido.Text = Libreria.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtContrasena_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
    End Sub


    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtApellido.TextLength = 0 Or TxtCorreoElectronico.TextLength = 0 Or TxtDni.TextLength = 0 Or
            TxtDireccion.TextLength = 0 Or TxtNombre.TextLength = 0 Or TxtRuta.TextLength = 0 Or txtTelefono.TextLength = 0 Then
            MsgBox("Complete todos los Campos o rellenelos con '0000'", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Dim localidad As Integer
            Dim provincia As Integer
            Dim telefono As String
            Dim estados As Integer
            Dim sexo As Integer
            Dim cod_empleo As Integer
            Dim vDiaNAC As String = DtpNacimiento.Value.Day
            Dim vMesNAC As String = DtpNacimiento.Value.Month
            Dim vAñoNAC As String = DtpNacimiento.Value.Year

            Dim vDia As String = DtpRegistracion.Value.Day
            Dim vMes As String = DtpRegistracion.Value.Month
            Dim vAño As String = DtpRegistracion.Value.Year
            Try
                cod_empleo = CboEmpleo.SelectedValue
                localidad = CboLocalidad.SelectedValue
                telefono = Me.txtTelefono.Text
                provincia = CboProvincia.SelectedValue
                estados = CboEstados.SelectedValue
                sexo = CboSexo.SelectedValue
            Catch ex As Exception
                MsgBox("Ingreso un valor incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea Modificar Empleado", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ' CONTROLAR QUE EL INGRESO DE LOS DATOS SEAN CORRECTOS. VALIDARLOS.
                Dim actualizar As String
                Dim nro As Integer = CInt(TxtDni.Text)
                actualizar = "UPDATE Empleados SET fecha_registracion=@fecha_registracion,fechaNacimiento=@fechaNacimiento, nombre=@nombre, apellido=@apellido,Empleo=@Empleo,provincia=@provincia,localidad=@localidad,perfil=@perfil,sexo=@sexo,estado=@estado,direccion=@direccion,telefono=@telefono,correoElectronico=@correoElectronico WHERE dni = @dni"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@dni", nro)
                cmdActualizar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(Me.TxtNombre.Text))
                cmdActualizar.Parameters.AddWithValue("@apellido", Libreria.TodoEnMayuscula(Me.TxtApellido.Text))
                cmdActualizar.Parameters.AddWithValue("@Empleo", cod_empleo)
                cmdActualizar.Parameters.AddWithValue("@provincia", provincia)
                cmdActualizar.Parameters.AddWithValue("@localidad", localidad)
                cmdActualizar.Parameters.AddWithValue("@perfil", Libreria.TodoEnMayuscula(TxtRuta.Text))
                cmdActualizar.Parameters.AddWithValue("@sexo", sexo)
                cmdActualizar.Parameters.AddWithValue("@estado", estados)
                cmdActualizar.Parameters.AddWithValue("@direccion", Libreria.TodoEnMayuscula(Me.TxtDireccion.Text))
                cmdActualizar.Parameters.AddWithValue("@telefono", telefono)
                cmdActualizar.Parameters.AddWithValue("@correoElectronico", Libreria.TodoEnMayuscula(TxtCorreoElectronico.Text))
                cmdActualizar.Parameters.AddWithValue("@fechaNacimiento", Convert.ToString(vDiaNAC & "-" & vMesNAC & "-" & vAñoNAC))
                cmdActualizar.Parameters.AddWithValue("@fecha_registracion", Convert.ToString(vDia & "-" & vMes & "-" & vAño))

                Me.EmpleadosTableAdapter.Fill(Me.DataSet1.Empleados)
                MsgBox("El Empleado: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            Libreria.LimpiarCampoModificarEmpleados()
        End If
        Libreria.LimpiarCampoModificarEmpleados()
    End Sub

    Private Sub DtgModificarEmpleados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgModificarEmpleados.Click
        '  Dim h As String
        If DtgModificarEmpleados.SelectedRows.Count > 0 Then
            TxtDni.Text = DtgModificarEmpleados.SelectedRows(0).Cells(0).Value.ToString()
            DniEmpleado = TxtDni.Text
            TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(DtgModificarEmpleados.SelectedRows(0).Cells(1).Value.ToString())
            NombreEmpleado = TxtNombre.Text
            TxtApellido.Text = Libreria.PrimeraLetraEnMayuscula(DtgModificarEmpleados.SelectedRows(0).Cells(2).Value.ToString())
            ApellidoEmpleado = TxtApellido.Text
            CboEmpleo.Text = DtgModificarEmpleados.SelectedRows(0).Cells(3).Value.ToString()
            Empleo = CboEmpleo.Text
            CboProvincia.Text = DtgModificarEmpleados.SelectedRows(0).Cells(4).Value.ToString()
            ProvinciaEmpleado = CboProvincia.Text
            CboLocalidad.Text = DtgModificarEmpleados.SelectedRows(0).Cells(5).Value.ToString()
            LocalidadEmpleado = CboLocalidad.Text
            TxtRuta.Text = DtgModificarEmpleados.SelectedRows(0).Cells(6).Value.ToString()
            rutaFotoEmpleado = TxtRuta.Text
            CboSexo.Text = DtgModificarEmpleados.SelectedRows(0).Cells(7).Value.ToString()
            SexoEmpleado = CboSexo.Text
            CboEstados.Text = DtgModificarEmpleados.SelectedRows(0).Cells(8).Value.ToString()
            EstadoEmpleado = CboEstados.Text
            DtpRegistracion.Text = DtgModificarEmpleados.SelectedRows(0).Cells(9).Value.ToString
            TxtDireccion.Text = Libreria.PrimeraLetraEnMayuscula(DtgModificarEmpleados.SelectedRows(0).Cells(10).Value.ToString())
            DireccionEmpleado = Libreria.PrimeraLetraEnMayuscula(TxtDireccion.Text)
            txtTelefono.Text = DtgModificarEmpleados.SelectedRows(0).Cells(11).Value.ToString()
            TelefonoEmpleado = txtTelefono.Text
            TxtCorreoElectronico.Text = Libreria.PrimeraLetraEnMayuscula(DtgModificarEmpleados.SelectedRows(0).Cells(12).Value.ToString())
            CorreoEmpleado = TxtCorreoElectronico.Text
            DtpNacimiento.Text = DtgModificarEmpleados.SelectedRows(0).Cells(13).Value.ToString()
            FechaNacimiento = DtpNacimiento.Text
            Try
                PBoxPerfilEmpleado.Image = System.Drawing.Image.FromFile(rutaFotoEmpleado)
            Catch ex As Exception
                MsgBox("La imagen no existe posiblemente haya sido eliminada", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                PBoxPerfilEmpleado.Image = Nothing
                Exit Sub
            End Try
            BtnModificar.Enabled = True
            'MessageBox.Show(DtgModifcarLibros.Rows(3).Cells(1).Value.ToString) '3=fila y 1 columna
        End If
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtBusqueda.TextLength > 0 Then
            Dim nro As Integer = Convert.ToInt32(TxtBusqueda.Text)
            If ComprobacionExistencia(nro) = True Then
                consultaConInnerJoint(nro)
            Else
                dataset2.Clear()
                MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        Else
            dataset2.Clear()
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub
    Function ComprobacionExistencia(ByVal p_NroLibro As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empleados WHERE dni = '" & p_NroLibro & "'"
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
    Private Sub consultaConInnerJoint(ByVal p_dni As String)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni Like'" + "%" + p_dni + "%" + "' and Empleados.Empleo <> 2;"
        ' Dim buscar As String = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_NroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModificarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusqueda.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.TextLength = 0 Then
            MostrarTodoConInnerJoint()
        Else
            Dim NRO As String
            If TxtBusqueda.TextLength > 0 Then
                Try
                    NRO = TxtBusqueda.Text
                Catch ex As Exception
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJoint(NRO)
                If DtgModificarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Categoria no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    MostrarTodoConInnerJoint()
                End If
            End If
        End If
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Dni"
                TxtBusquedaPorNombre.Visible = False
                '  BtnBusquedaPorNombre.Visible = False
                TxtBusqueda.Visible = True
                '  BtnConsultar.Visible = True
                MostrarTodoConInnerJoint()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                '   BtnBusquedaPorNombre.Visible = True
                TxtBusqueda.Visible = False
                '    BtnConsultar.Visible = False
                MostrarTodoConInnerJoint()
            Case Else
                MsgBox("No seleciono nada")
        End Select
    End Sub

    Private Sub BtnBusquedaPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Nombre As String
        If TxtBusquedaPorNombre.TextLength > 0 Then
            Nombre = TxtBusquedaPorNombre.Text
            If ComprobacionExistenciaNombre(Nombre) = True Then
                consultaConInnerJointNombre(Nombre)
            Else
                dataset2.Clear()
                MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                MostrarTodoConInnerJoint()
            End If
        Else
            MostrarTodoConInnerJoint()
        End If
    End Sub
    Function ComprobacionExistenciaNombre(ByVal p_nombre As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empleados WHERE nombre = '" & Libreria.TodoEnMayuscula(p_nombre) & "'"
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
    Private Sub consultaConInnerJointNombre(ByVal p_nombre As String)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.nombre like '" + "%" + p_nombre + "%" + "' and Empleados.Empleo <> 2;"
        ' Dim buscar As String = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_NroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModificarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub DtgModificarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgModificarEmpleados.CellContentClick

    End Sub

    Private Sub TxtBusquedaPorNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusquedaPorNombre.Focus()
        Else
            Libreria.BusquedaPorNombre(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        MostrarTodoConInnerJoint()
    End Sub

    Private Sub TxtBusquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorNombre.TextChanged
        If TxtBusquedaPorNombre.TextLength = 0 Then
            MostrarTodoConInnerJoint()
        Else
            Dim nombre As String
            If TxtBusquedaPorNombre.TextLength > 0 Then
                Try
                    nombre = TxtBusquedaPorNombre.Text
                Catch ex As Exception
                    MsgBox("Ingreso un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointNombre(nombre)
                If DtgModificarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    MostrarTodoConInnerJoint()
                End If
            End If
        End If
    End Sub
End Class