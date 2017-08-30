Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Registrar_Clientes
    Dim dataset As DataSet = New DataSet()
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim dia As Date
    Dim nro_factura As Integer = 0
    Dim precio As Double = 0.0
    Dim nro_lib As Integer = 0

    Function ComprobacionExistenciaCliente(ByVal p_dni As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
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
    Private Sub btnGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCliente.Click
        If TxtApellido.TextLength = 0 Or TxtNombre.TextLength = 0 Or TxtTelefono.TextLength = 0 Or CboProvincia.Text = Nothing Or TxtCorreoElectronico.TextLength = 0 Or
            TxtTelefono.TextLength = 0 Or DtpFechaDeNacimiento.Text = Nothing Or CboLocalidades.Text = Nothing Or CboSexo.Text = Nothing Or txtDireccion.TextLength = 0 Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            Dim dni As Integer
            Dim nombre As String = TxtNombre.Text
            Dim apellido As String = TxtApellido.Text
            Dim provincia As Integer = CboProvincia.SelectedValue
            Dim correo As String = TxtCorreoElectronico.Text
            Dim telefono As String
            Dim fecha As String = ""
            Dim fechaRegistracion As String = ""
            Try
                Dim vDia As String = DtpFechaDeNacimiento.Value.Day
                Dim vMes As String = DtpFechaDeNacimiento.Value.Month
                Dim vAño As String = DtpFechaDeNacimiento.Value.Year
                fecha = Convert.ToString(vDia & "-" & vMes & "-" & vAño)
            Catch ex As Exception
                MsgBox("fecha de nacimineto" + fecha)
            End Try
            Try
                Dim vDia As String = DtpFecha.Value.Day
                Dim vMes As String = DtpFecha.Value.Month
                Dim vAño As String = DtpFecha.Value.Year
                fechaRegistracion = Convert.ToString(vDia & "-" & vMes & "-" & vAño)
            Catch ex As Exception

            End Try
            Dim localidad As Integer = CboLocalidades.SelectedValue
            Dim sexo As Integer = CboSexo.SelectedValue
            Dim direccion As String = txtDireccion.Text
            Dim estado As Integer = 1

            Try
                dni = Convert.ToInt32(TxtDni.Text)
            Catch ex As Exception
                MsgBox("Ingreso un Caracter No permitido en el campo Dni", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            telefono = TxtTelefono.Text
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar nuevo Cliente", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Confirmar Inserción")

            If MsgBoxResult.Yes = ask Then
                If ComprobacionExistenciaCliente(dni) = True Then
                    MsgBox("El Cliente " + nombre + " " + apellido + " ya esta registrado", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                Else
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    Dim insertar As String
                    insertar = "INSERT INTO Clientes(dni, nombre,apellido,direccion,localidad,provincia,fecha,telefono,estado,fecha_de_registro,sexo,correo)" & "VALUES" & "(@dni, @nombre,@apellido,@direccion,@localidad,@provincia,@fecha,@telefono,@estado,@fecha_de_registro,@sexo,@correo)"
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    cmdInsertar.Parameters.AddWithValue("@dni", dni)
                    cmdInsertar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(nombre))
                    cmdInsertar.Parameters.AddWithValue("@apellido", Libreria.TodoEnMayuscula(apellido))
                    cmdInsertar.Parameters.AddWithValue("@direccion", Libreria.TodoEnMayuscula(direccion))
                    cmdInsertar.Parameters.AddWithValue("@localidad", localidad)
                    cmdInsertar.Parameters.AddWithValue("@provincia", provincia)
                    cmdInsertar.Parameters.AddWithValue("@fecha", fecha)
                    cmdInsertar.Parameters.AddWithValue("@telefono", telefono)
                    cmdInsertar.Parameters.AddWithValue("@estado", estado)
                    cmdInsertar.Parameters.AddWithValue("@fecha_de_registro", fechaRegistracion)
                    cmdInsertar.Parameters.AddWithValue("@sexo", sexo)
                    cmdInsertar.Parameters.AddWithValue("@correo", correo)
                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                        consultaConInnerJoint_REGISTRARCLIENTE(dni)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    MsgBox("El Cliente: " + TxtNombre.Text + " " + TxtApellido.Text + " se inserto correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Guardar")
                    ' btnGuardarCliente.Visible = False
                End If
                Libreria.limpiarCamposRegistrarCliente()
            End If
        End If
    End Sub
    Public Sub consultaConInnerJoint_REGISTRARCLIENTE(ByVal p_dni As Integer)
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.dni = '" & p_dni & "' ;"
        'Dim buscar As String = "SELECT Libros.nro_libro,nombre,Categorias.descripcion,Libros.precio,Autores.nombreAutor,Autores1.nombreAutor,Autores2.nombreAutor,Estado.descripcion,Libros.cantidad,Libros.imagen,Libros.año FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.nro_libro = '" & _ & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        'dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.dtgRegistarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub consultaConInnerJoint_REGISTRARCLIENTE()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo where Clientes.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        'dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.dtgRegistarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            dataset2.Clear()
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
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_dni & "' AND estado = 1"
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
    Private Sub consultaConInnerJoint(ByVal p_dni As Integer)

        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.dni = '" & p_dni & "' ;"
         miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.dtgRegistarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub Registrar_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.FillByProvincias(Me.DataSet1.Provincias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.FillBySexoActicvos(Me.DataSet1.Sexo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        ' Me.LocalidadesTableAdapter.Fill(Me.DataSet1.Localidades)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        TxtCorreoElectronico.Text = "@.com"
        Libreria.limpiarCamposRegistrarCliente()
        consultaConInnerJoint_REGISTRARCLIENTE()
    End Sub

    Private Sub TxtCorreoElectronico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.LostFocus
        If TxtCorreoElectronico.TextLength > 0 Then
            If InStr(TxtCorreoElectronico.Text, "@") = False Or InStr(TxtCorreoElectronico.Text, ".com") = False Then
                MsgBox("Ingrese el caracter @ seguido de su cuenta y finalmente .com", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Advertencia")
                TxtCorreoElectronico.Focus()
            End If
        End If
    End Sub
    Private Sub TxtCorreoElectronico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorreoElectronico.TextChanged
        If TxtCorreoElectronico.TextLength = 0 Then
            TxtCorreoElectronico.Text = "@.com"
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            txtDireccion.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
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

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtApellido.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub
    Private Sub TxtApellido_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtApellido.LostFocus
        TxtApellido.Text = Libreria.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNombre.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If

    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDni.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDni.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtTelefono.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtDni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDni.LostFocus
        If TxtDni.TextLength > 0 Then
                If ComprobacionExistencia(CInt(TxtDni.Text)) = True Then
                MsgBox(TxtNombre.Text + " ya esta registrado", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                TxtDni.BackColor = Color.Red
                    TxtDni.Focus()
                    Exit Sub
            ElseIf TxtDni.TextLength < 8 Then
                TxtDni.BackColor = Color.Red
                MsgBox("Ingreso menos digitos de los que poosee un número de Dni", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Advertencia")
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
        Else
            TxtDni.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub txtDireccion_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            txtDireccion.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        consultaConInnerJoint_REGISTRARCLIENTE()
    End Sub

End Class