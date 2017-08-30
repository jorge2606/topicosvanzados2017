Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Modificar_Cliente
    Dim dataset As DataSet = New DataSet()
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    'variables para comparar si hubo modificacion o no
    Dim DniClient As Integer
    Dim NombreClient As String
    Dim ApellidoClient As String
    Dim DireccionClient As String
    Dim LocalidadClient As String
    Dim Provincia As String
    Dim FechaDeNacimientoClient As String
    Dim TelefonoClient As String
    Dim EstadoClient As String
    Dim FechaDeRegistracionClient As String
    Dim CorreoClient As String
    Dim SexoClient As String

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtApellido.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
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
    Private Sub TxyTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtTelefono.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub TxtCorreoElectronico_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCorreoElectronico.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtApellido.Focus()
        Else
            Libreria.soloLetrasSinEspaciosYconTeclaBorrar(e)
        End If
    End Sub

    Private Sub Modificar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.FillByProvincias(Me.DataSet1.Provincias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.FillBySexoActicvos(Me.DataSet1.Sexo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)
        Me.MaximizeBox = False
        DtgModifcarClientes.RowTemplate.Height = 30
        Libreria.limpiarCampos()
        TxtCorreoElectronico.Text = "@.com"
        If DtgModifcarClientes.RowCount = 0 Then
            BtnModificar.Enabled = False
        End If
        TxtBusquedaPorNombre.Visible = False
        'BtnBusquedaPorNombre.Visible = False
        TxtBusqueda.Visible = False
        '  BtnConsultar.Visible = False
        BtnModificar.Enabled = False
        mostrarTodosClientes()
    End Sub

    Private Sub DtgModifcarClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgModifcarClientes.Click
        If DtgModifcarClientes.SelectedRows.Count > 0 Then
            TxtDni.Text = DtgModifcarClientes.SelectedRows(0).Cells(0).Value.ToString()
            DniClient = DtgModifcarClientes.SelectedRows(0).Cells(0).Value.ToString()
            ' MsgBox(DniClient)
            TxtNombre.Text = DtgModifcarClientes.SelectedRows(0).Cells(1).Value.ToString()
            NombreClient = DtgModifcarClientes.SelectedRows(0).Cells(1).Value.ToString()
            'MsgBox(NombreClient)
            TxtApellido.Text = DtgModifcarClientes.SelectedRows(0).Cells(2).Value.ToString()
            ApellidoClient = DtgModifcarClientes.SelectedRows(0).Cells(2).Value.ToString()
            'MsgBox(ApellidoClient)
            TxtDireccion.Text = DtgModifcarClientes.SelectedRows(0).Cells(3).Value.ToString()
            DireccionClient = DtgModifcarClientes.SelectedRows(0).Cells(3).Value.ToString()
            'MsgBox(DireccionClient)
            CboLocalidad.SelectedValue = ComprobacionExistenciaLocalidad(DtgModifcarClientes.SelectedRows(0).Cells(4).Value.ToString())
            LocalidadClient = ComprobacionExistenciaLocalidad(DtgModifcarClientes.SelectedRows(0).Cells(4).Value.ToString())
            'MsgBox(LocalidadClient)
            CboProvincia.SelectedValue = ComprobacionExistenciaProvincia(DtgModifcarClientes.SelectedRows(0).Cells(5).Value.ToString())
            Provincia = ComprobacionExistenciaProvincia(DtgModifcarClientes.SelectedRows(0).Cells(5).Value.ToString())
            'MsgBox(Provincia)
            DtpFechaNacimiento.Text = DtgModifcarClientes.SelectedRows(0).Cells(6).Value.ToString()
            FechaDeNacimientoClient = DtpFechaNacimiento.Text
            'MsgBox(FechaDeNacimientoClient)
            TxtTelefono.Text = DtgModifcarClientes.SelectedRows(0).Cells(7).Value.ToString()
            TelefonoClient = DtgModifcarClientes.SelectedRows(0).Cells(7).Value.ToString()
            'MsgBox(TelefonoClient)
            CboEstado.SelectedValue = ComprobacionExistenciaEstado(DtgModifcarClientes.SelectedRows(0).Cells(8).Value)
            EstadoClient = ComprobacionExistenciaEstado(DtgModifcarClientes.SelectedRows(0).Cells(8).Value)

            'DtpRegistracion.Value = DtgModifcarClientes.SelectedRows(0).Cells(9).Value.ToString
            ' FechaDeRegistracionClient = DtpRegistracion.Text
            'MsgBox(DtgModifcarClientes.SelectedRows(0).Cells(9).Value.ToString)

            TxtCorreoElectronico.Text = DtgModifcarClientes.SelectedRows(0).Cells(10).Value.ToString()
            CorreoClient = DtgModifcarClientes.SelectedRows(0).Cells(10).Value.ToString()

            CboSexo.SelectedValue = ComprobacionExistenciaSexo(DtgModifcarClientes.SelectedRows(0).Cells(11).Value.ToString)
            SexoClient = ComprobacionExistenciaSexo(DtgModifcarClientes.SelectedRows(0).Cells(11).Value.ToString)
            'MsgBox(SexoClient)
            BtnModificar.Enabled = True
            'MessageBox.Show(DtgModifcarLibros.Rows(3).Cells(1).Value.ToString) '3=fila y 1 columna
        End If
    End Sub
    Function huboModificacionONo() As Boolean
        Dim modificacion As Boolean = False
        If TxtDni.TextLength > 0 Then
            If (DniClient <> CInt(TxtDni.Text)) Or (Libreria.TodoEnMayuscula(NombreClient) <> Libreria.TodoEnMayuscula(TxtNombre.Text)) Or (Libreria.TodoEnMayuscula(ApellidoClient) <> Libreria.TodoEnMayuscula(TxtApellido.Text)) Or (LocalidadClient <> CboLocalidad.SelectedValue) Or (Provincia <> CboProvincia.SelectedValue) Or (FechaDeNacimientoClient <> DtpFechaNacimiento.Value) Or (TelefonoClient <> TxtTelefono.Text) Or (CInt(EstadoClient) <> CboEstado.SelectedValue) Or (Libreria.TodoEnMayuscula(CorreoClient) <> Libreria.TodoEnMayuscula(TxtCorreoElectronico.Text)) Or (SexoClient <> CboSexo.SelectedValue) Then
                modificacion = True
                ' MsgBox(DniClient <> CInt(TxtDni.Text))
                'MsgBox(Libreria.TodoEnMayuscula(NombreClient) <> Libreria.TodoEnMayuscula(TxtNombre.Text))
                ' MsgBox(Libreria.TodoEnMayuscula(ApellidoClient) <> Libreria.TodoEnMayuscula(TxtApellido.Text))
                ' MsgBox(LocalidadClient <> CboLocalidad.SelectedValue)
                ' MsgBox((Provincia <> CboProvincia.SelectedValue))
                ' MsgBox(FechaDeNacimientoClient <> DtpFechaNacimiento.Text)
                ' MsgBox(FechaDeNacimientoClient)
                '  MsgBox(DtpFechaNacimiento.Text)
                '  MsgBox(TelefonoClient <> TxtTelefono.Text)
                'MsgBox(CInt(EstadoClient) <> CboEstado.SelectedValue)
                ' MsgBox(EstadoClient)
                'MsgBox(CboEstado.SelectedValue)
                '  MsgBox(FechaDeRegistracionClient <> DtpRegistracion.Text)
                '  MsgBox(Libreria.TodoEnMayuscula(CorreoClient) <> Libreria.TodoEnMayuscula(TxtCorreoElectronico.Text))
                ' MsgBox(SexoClient <> CboSexo.SelectedValue)
                Return modificacion
            Else
                Return modificacion
            End If
        Else
            Return modificacion
        End If
    End Function

    Public Sub ConfirmacionModificar()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Dim actualizar As String
        Dim vDia As String = DtpFechaNacimiento.Value.Day
        Dim vMes As String = DtpFechaNacimiento.Value.Month
        Dim vAño As String = DtpFechaNacimiento.Value.Year
        Dim nro As Integer = CInt(TxtDni.Text)
        actualizar = "UPDATE Clientes SET nombre=@nombre, apellido=@apellido,direccion=@direccion,localidad=@localidad,provincia=@provincia,fecha=@fecha,telefono=@telefono,estado=@estado,sexo=@sexo WHERE dni = @dni"
        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
        cmdActualizar.Parameters.AddWithValue("@dni", nro)
        cmdActualizar.Parameters.AddWithValue("@nombre", Me.TxtNombre.Text)
        cmdActualizar.Parameters.AddWithValue("@apellido", Me.TxtApellido.Text)
        cmdActualizar.Parameters.AddWithValue("@direccion", Me.TxtDireccion.Text)
        cmdActualizar.Parameters.AddWithValue("@localidad", CInt(CboLocalidad.SelectedValue))
        cmdActualizar.Parameters.AddWithValue("@provincia", CInt(CboProvincia.SelectedValue))
        cmdActualizar.Parameters.AddWithValue("@fecha", Convert.ToString(vDia & "-" & vMes & "-" & vAño))
        cmdActualizar.Parameters.AddWithValue("@telefono", Me.TxtTelefono.Text)
        cmdActualizar.Parameters.AddWithValue("@estado", CInt(CboEstado.SelectedValue))
        ' cmdActualizar.Parameters.AddWithValue("@fecha_de_registro", DtpRegistracion.Text)
        cmdActualizar.Parameters.AddWithValue("@sexo", CInt(CboSexo.SelectedValue))
        cmdActualizar.Parameters.AddWithValue("@correo", TxtCorreoElectronico.Text)
        Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)
        'MsgBox("El Cliente: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
        Try
            cmdActualizar.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Libreria.limpiarCampos()
        BtnModificar.Enabled = False
        mostrarTodosClientes()
    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If huboModificacionONo() = True Then
            Dim resp As Integer = Libreria.SalirYguardar()
            If resp = 6 Then
                ConfirmacionModificar()
                MsgBox("Datos Guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Libreria.limpiarCamposDeModificarLibros()
                Me.Close()
            ElseIf resp = 7 Then
                MsgBox("No se han Gurdado los datos modificados", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Libreria.limpiarCamposDeModificarLibros()
                Me.Close()
            End If
        Else
            If Libreria.Salir() = 1 Then
                Libreria.limpiarCampos()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        Libreria.soloNumeroConEspacios(e)
    End Sub

    Private Sub TxtCorreoElectronico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.TextChanged
        If TxtCorreoElectronico.TextLength = 0 Then
            TxtCorreoElectronico.Text = "@.com"
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnModificar.Click
        If TxtApellido.TextLength = 0 Or TxtCorreoElectronico.TextLength = 0 Or TxtDireccion.TextLength = 0 Or TxtDni.TextLength = 0 Or CboEstado.SelectedValue = Nothing Or TxtNombre.TextLength = 0 Or TxtTelefono.TextLength = 0 Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea Modificar Cliente", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                ' CONTROLAR QUE EL INGRESO DE LOS DATOS SEAN CORRECTOS. VALIDARLOS.
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                Dim actualizar As String
                Dim nro As Integer = CInt(TxtDni.Text)
                Dim vDia As String = DtpFechaNacimiento.Value.Day
                Dim vMes As String = DtpFechaNacimiento.Value.Month
                Dim vAño As String = DtpFechaNacimiento.Value.Year
                actualizar = "UPDATE Clientes SET nombre=@nombre, apellido=@apellido,direccion=@direccion,localidad=@localidad,provincia=@provincia,fecha=@fecha,telefono=@telefono,estado=@estado,sexo=@sexo,correo=@correo WHERE dni = @dni"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@dni", nro)
                cmdActualizar.Parameters.AddWithValue("@nombre", Me.TxtNombre.Text)
                cmdActualizar.Parameters.AddWithValue("@apellido", Me.TxtApellido.Text)
                cmdActualizar.Parameters.AddWithValue("@direccion", Me.TxtDireccion.Text)
                cmdActualizar.Parameters.AddWithValue("@localidad", CInt(CboLocalidad.SelectedValue))
                cmdActualizar.Parameters.AddWithValue("@provincia", CInt(CboProvincia.SelectedValue))
                cmdActualizar.Parameters.AddWithValue("@fecha", Convert.ToString(vDia & "-" & vMes & "-" & vAño))
                cmdActualizar.Parameters.AddWithValue("@telefono", Me.TxtTelefono.Text)
                cmdActualizar.Parameters.AddWithValue("@estado", CInt(CboEstado.SelectedValue))
                'cmdActualizar.Parameters.AddWithValue("@fecha_de_registro", DtpRegistracion.Text)
                cmdActualizar.Parameters.AddWithValue("@sexo", CInt(CboSexo.SelectedValue))
                cmdActualizar.Parameters.AddWithValue("@correo", TxtCorreoElectronico.Text)
                Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)
                MsgBox("El Cliente: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            Libreria.limpiarCampos()
            BtnModificar.Enabled = False
            mostrarTodosClientes()
        End If
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtApellido_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtApellido.LostFocus
        TxtApellido.Text = Libreria.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtBusqueda.TextLength > 0 Then
            Dim nro As Integer = Convert.ToInt32(TxtBusqueda.Text)
            If ComprobacionExistencia(nro) = True Then
                consultaConInnerJoint(nro)
            Else
                dataset2.Clear()
                MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                mostrarTodosClientes()
            End If
        Else
            MsgBox("Campo Vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            dataset2.Clear()
            mostrarTodosClientes()
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub
    Private Sub mostrarTodosClientes()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Function ComprobacionExistencia(ByVal p_dni As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_dni & "'"
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
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.dni like '" + "%" + p_dni + "%" + "' ;"
        ' Dim buscar As String = "SELECT Clientes.dni,Clientes.nombre,Clientes.apellido FROM Clientes INNER JOIN Localidades ON Clientes.localidad = Localidades.cod_localidad INNER JOIN Provincias ON Clientes.provincia = Provincias.cod_Provincia INNER JOIN Estado ON Clientes.estado = Estado.cod_estado INNER JOIN Sexo ON Clientes.sexo = Sexo.cod_sexo WHERE Clientes.dni = '" & p_dni & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Function ComprobacionExistenciaLocalidad(ByVal p_nombreLocalidad As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Localidades WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_nombreLocalidad) & "'"
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
    Function ComprobacionExistenciaProvincia(ByVal p_nombreProvincia As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Provincias WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_nombreProvincia) & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Function ComprobacionExistenciaEstado(ByVal p_estado As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Estado WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_estado) & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Function ComprobacionExistenciaSexo(ByVal p_sexo As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Sexo WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_sexo) & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function

    Private Sub DtgModifcarClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgModifcarClientes.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DtgModifcarClientes.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgModifcarClientes.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar"
                        Eliminar_Cliente.ShowDialog()
                End Select

            End If

        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtApellido.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub TxtBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusqueda.Focus()
        Else
            Libreria.soloNumero(e)
        End If
        If TxtBusqueda.TextLength = 0 Then
            mostrarTodosClientes()
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.TextLength = 0 Then
            mostrarTodosClientes()
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
                If DtgModifcarClientes.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Dni"
                TxtBusquedaPorNombre.Visible = False
                ' BtnBusquedaPorNombre.Visible = False
                TxtBusqueda.Visible = True
                ' BtnConsultar.Visible = True
                mostrarTodosClientes()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                ' BtnBusquedaPorNombre.Visible = True
                TxtBusqueda.Visible = False
                ' BtnConsultar.Visible = False
                mostrarTodosClientes()
            Case Else
                'MsgBox("No seleciono nada")
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
                MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                mostrarTodosClientes()
            End If
        Else
            mostrarTodosClientes()
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
        buscar = "SELECT * FROM Clientes WHERE nombre = '" & Libreria.TodoEnMayuscula(p_nombre) & "' and estado = 1"
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
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.nombre like '" + "%" + p_nombre + "%" + "' ;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtBusquedaPorNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusquedaPorNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
        If TxtBusquedaPorNombre.TextLength = 0 Then
            mostrarTodosClientes()
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        mostrarTodosClientes()
    End Sub

    Private Sub TxtBusquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorNombre.TextChanged
        If TxtBusquedaPorNombre.TextLength = 0 Then
            mostrarTodosClientes()
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
                If DtgModifcarClientes.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
    End Sub

End Class