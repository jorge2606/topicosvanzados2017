Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class Libreria
   
    Dim miConexion As SqlConnection
    Shared Function deseaGuardar() As Integer
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea Guardar", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
        Return ask
    End Function
    Shared Function deseaEliminar() As Integer
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea Eliminar", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminar")
        Return ask
    End Function
    Shared Function deseaCrearBackup() As Integer
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Desea Generar Copia de Seguridad de su Base De Datos? ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Copia de Seguridad")
        Return ask
    End Function
    Shared Function deseaModificar() As Integer
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea Modificar", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Modificar")
        Return ask
    End Function
    Public Sub conectar()
        miConexion = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Venta_de_libros;Integrated Security=True")
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub limpiarCampos()
        Modificar_Cliente.CboBusqPorTipo.Text = Nothing
        Modificar_Cliente.CboEstado.Text = Nothing
        Modificar_Cliente.CboLocalidad.Text = Nothing
        Modificar_Cliente.CboProvincia.Text = Nothing
        Modificar_Cliente.CboSexo.Text = Nothing
        Modificar_Cliente.TxtApellido.Text = Nothing
        Modificar_Cliente.TxtBusqueda.Text = Nothing
        Modificar_Cliente.TxtCorreoElectronico.Text = Nothing
        Modificar_Cliente.TxtDireccion.Text = Nothing
        Modificar_Cliente.TxtDni.Text = Nothing
        Modificar_Cliente.TxtNombre.Text = Nothing
        Modificar_Cliente.TxtTelefono.Text = Nothing
    End Sub
    Public Shared Sub limpiarCamposRegistrarCliente()
        Registrar_Clientes.TxtApellido.Text = Nothing
        Registrar_Clientes.TxtCorreoElectronico.Text = Nothing
        Registrar_Clientes.txtDireccion.Text = Nothing
        Registrar_Clientes.TxtDni.Text = Nothing
        Registrar_Clientes.TxtNombre.Text = Nothing
        Registrar_Clientes.TxtTelefono.Text = Nothing
        Registrar_Clientes.CboLocalidades.Text = Nothing
        Registrar_Clientes.CboProvincia.Text = Nothing
        Registrar_Clientes.CboSexo.Text = Nothing
        Registrar_Clientes.DtpFechaDeNacimiento.Text = Nothing
    End Sub
    Shared Function bonificacion(ByVal p_formaDePago As Integer, ByVal p_totalAPagar As Double) As Double
        Dim bonificacion1 As Double
        Dim total As Double = p_totalAPagar
        Dim formadePago As Integer = p_formaDePago
        Select Case formadePago
            Case 1
                Debug.WriteLine("Tarjeta Visa")
                bonificacion1 = (10 * total) / 100
                total = total - bonificacion1
            Case 2
                Debug.WriteLine("Tarjeta Mastercard")
                bonificacion1 = (20 * total) / 100
                total = total - bonificacion1
            Case 3
                Debug.WriteLine("Tarjeta Naranja")
                bonificacion1 = (30 * total) / 100
                total = total - bonificacion1
            Case Else
                Debug.WriteLine("Esta Tarjeta ingresada no accede a ningun tipo de beneficios aún")
        End Select
        Return total
    End Function

    Shared Function Descuento(ByVal p_formaDePago As Integer) As String
        Dim descuento1 As String

        Select Case p_formaDePago
            Case 1
                descuento1 = "10 %"
            Case 2
                descuento1 = "20 %"
            Case 3
                descuento1 = "30 %"
            Case Else
                descuento1 = "0 %"
        End Select
        Return descuento1
    End Function
    Shared Function TodoEnMayuscula(ByVal p_texto As String) As String
        Dim UpperCase As String = UCase(p_texto)
        Return UpperCase
    End Function
    Shared Function fechaActual() As String
        Dim dia As String = DatePart(DateInterval.Day, Registrar_Clientes.DtpFecha.Value)
        Dim mes As String = DatePart(DateInterval.Month, Registrar_Clientes.DtpFecha.Value)
        Dim año As String = DatePart(DateInterval.Year, Registrar_Clientes.DtpFecha.Value)
        Return dia + "-" + mes + "-" + año + HoraActual()
    End Function
    Shared Function HoraActual() As String
        Dim hora As String = DatePart(DateInterval.Hour, Registrar_Clientes.DtpFecha.Value)
        Dim minutos As String = DatePart(DateInterval.Minute, Registrar_Clientes.DtpFecha.Value)
        Dim segundos As String = DatePart(DateInterval.Second, Registrar_Clientes.DtpFecha.Value)
        '1955-12-13 12:43:10'
        Return hora + ":" + minutos + ":" + segundos
    End Function

    Shared Function fechaNacimiento() As String
        Dim dia As String = DatePart(DateInterval.Day, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        Dim mes As String = DatePart(DateInterval.Month, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        Dim año As String = DatePart(DateInterval.Year, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        Return dia + "-" + mes + "-" + año + HoraNacimiento()
    End Function


    Shared Function HoraNacimiento() As String
        Dim hora As String = DatePart(DateInterval.Hour, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        Dim minutos As String = DatePart(DateInterval.Minute, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        Dim segundos As String = DatePart(DateInterval.Second, Registrar_Clientes.DtpFechaDeNacimiento.Value)
        '1955-12-13 12:43:10'
        Return hora + ":" + minutos + ":" + segundos
    End Function
    Public Sub Actualizar(ByVal id As Integer, ByVal descripcion As String)
        Dim act As String
        act = "UPDATE productos set id_prod = @id, descrip = @descipcion where id_producto = @id"
        Dim cmd As New SqlCommand(act, miConexion)
        cmd.Parameters.AddWithValue("@id_producto", id)
        cmd.Parameters.AddWithValue("@descripcion", descripcion)
        Try
            miConexion.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)

            Exit Sub
        End Try

    End Sub
    Public Shared Sub soloNumero(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Shared Sub soloNumeroConComa(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Public Shared Sub soloNumeroConEspacios(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
   
    Shared Function PrimeraLetraEnMayuscula(ByVal p_string As String) As String
        Return StrConv(p_string, VbStrConv.ProperCase)
    End Function

    Public Shared Sub soloLetrasSinEspacios(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Shared Sub soloLetrasSinEspaciosYsinSimbolos(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Public Shared Sub soloLetrasSinEspaciosYconTeclaBorrar(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Public Shared Sub BusquedaPorNombre(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Public Shared Sub limpiarCamposDeModificarLibros()
        Modificar_Libros.TxtAno.Clear()
        Modificar_Libros.TxtNombre.Clear()
        Modificar_Libros.TxtAno.Clear()
        Modificar_Libros.TxtAños.Clear()
        Modificar_Libros.TxtPrecio.Clear()
        Modificar_Libros.TxtCantidad.Clear()
        Modificar_Libros.TxtRuta.Clear()
        Modificar_Libros.TxtBusqueda.Clear()
        Modificar_Libros.TxtCantidad.Clear()
        Modificar_Libros.CboAutor1.Text = Nothing
        Modificar_Libros.CboAutor.Text = Nothing
        Modificar_Libros.CboAutor2.Text = Nothing
        Modificar_Libros.CboEstado.Text = Nothing
        Modificar_Libros.CboCategoria.Text = Nothing
        Modificar_Libros.TxtNombre.Clear()
        Modificar_Libros.TxtNumeroDeLibro.Clear()
        Modificar_Libros.TxtPrecio.Clear()
        Modificar_Libros.TxtRuta.Clear()
        Modificar_Libros.PBoxPerfilFoto.BackgroundImage = Nothing
    End Sub


    Public Shared Sub bloqueo()
        Modificar_Libros.TxtNombre.Enabled = False
        Modificar_Libros.TxtAños.Enabled = False
        Modificar_Libros.TxtAno.Enabled = False
        Modificar_Libros.BtnAgregarAño.Enabled = False
        Modificar_Libros.BtnQuitarAño.Enabled = False
        Modificar_Libros.TxtPrecio.Enabled = False
        Modificar_Libros.CboEstado.Enabled = False
        Modificar_Libros.CboCategoria.Enabled = False
        Modificar_Libros.CboAutor.Enabled = False
        Modificar_Libros.CboAutor1.Enabled = False
        Modificar_Libros.CboAutor2.Enabled = False
        Modificar_Libros.BtnImagen.Enabled = False
        Modificar_Libros.TxtCantidad.Enabled = False
        Modificar_Libros.BtnModificar.Enabled = False
        Modificar_Libros.BtnActualizar.Enabled = False
    End Sub
    Public Shared Sub debloqueo()
        Modificar_Libros.TxtNombre.Enabled = True
        Modificar_Libros.TxtAños.Enabled = False
        Modificar_Libros.TxtAno.Enabled = True
        Modificar_Libros.BtnAgregarAño.Enabled = True
        Modificar_Libros.BtnQuitarAño.Enabled = True
        Modificar_Libros.TxtPrecio.Enabled = True
        Modificar_Libros.CboEstado.Enabled = True
        Modificar_Libros.CboCategoria.Enabled = True
        Modificar_Libros.CboAutor.Enabled = True
        Modificar_Libros.CboAutor1.Enabled = True
        Modificar_Libros.CboAutor2.Enabled = True
        Modificar_Libros.BtnImagen.Enabled = True
        Modificar_Libros.TxtCantidad.Enabled = True
        Modificar_Libros.BtnModificar.Enabled = True
        Modificar_Libros.BtnActualizar.Enabled = True
    End Sub
    Public Shared Sub nombreDelLibro(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    Public Shared Sub soloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Shared Function Salir() As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Desea Salir? ", MsgBoxStyle.Information + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton1, " Salir")
        Return respuesta
    End Function
    Shared Function SalirYguardar() As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Se han realizado modificaciones desea Guardarlos ahora?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3, " Salir")
        Return respuesta
    End Function
    Shared Function DeseaEliminarLibros() As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Desea Eliminar el Libro? ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, " Eliminar")
        Return respuesta
    End Function

    Shared Function DeseaEliminarEmpleado() As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Desea Eliminar Empleado? ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, " Eliminar")
        Return respuesta
    End Function

    Shared Function DeseaEliminarCliente() As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Desea Eliminar Cliente? ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, " Eliminar")
        Return respuesta
    End Function

    Public Shared Sub cantidadlineas()
        Dim linea As Integer
        linea = Registrar_Empleados.DtgRegistrarEmpleados.Rows.Count
        If linea = 0 Then
            ' Registrar_Empleados.BtnQuitar.Enabled = False
            'Registrar_Empleados.BtnModificar.Enabled = False
        End If
    End Sub

    Shared Function cantidadlineasCompras() As Boolean
        Dim linea As Integer
        Dim vacio As Boolean = False
        linea = Ingresar_Compras.DtgRegistrarCompra.Rows.Count
        If linea = 0 Then
            vacio = True
            'Ingresar_Compras.BtnComprar.Enabled = False
            'Ingresar_Compras.TxtVuelto.Enabled = False
            'Ingresar_Compras.TxtTotalAPagar.Enabled = False
        End If
        Return vacio
    End Function

    Shared Function NroYcantidadDeLibro() As Boolean
        Dim vacio As Boolean = False
        If (Ingresar_Compras.TxtNroLibro.TextLength = 0) Or (Ingresar_Compras.TxtCantidadDeLibro.TextLength = 0) Then
            vacio = True
        End If
        Return vacio
    End Function

    Public Shared Sub cantidadlineasLibros()
        Dim linea As Integer
        linea = Form1.DtgRegistrarLibros.Rows.Count
        If linea = 0 Then

        End If
    End Sub

    Shared Function PrecioPorcantidad(ByVal P_Precio As Double, ByVal P_Cantidad As Double) As Double
        Return P_Precio * P_Cantidad
    End Function

    Public Shared Sub bloquearControles()
        Modificar_Libros.LblAno.Visible = False
        Modificar_Libros.LblAutor.Visible = False
        Modificar_Libros.LblCantidad.Visible = False
        Modificar_Libros.LblCategoria.Visible = False
        ' Modificar_Libros.LblEdicion.Visible = False
        Modificar_Libros.LblNombre.Visible = False
        Modificar_Libros.LblCategoria.Visible = False
        Modificar_Libros.TxtAno.Visible = False
        Modificar_Libros.CboAutor.Visible = False
        Modificar_Libros.TxtCantidad.Visible = False
        ' Modificar_Libros.TxtEdicion.Visible = False
        Modificar_Libros.TxtNombre.Visible = False
        Modificar_Libros.BtnModificar.Visible = False
        ' Modificar_Libros.BtnCancelar.Visible = False
        Modificar_Libros.CboCategoria.Visible = False
    End Sub


    Public Shared Sub desbloquearControles()
        Modificar_Libros.LblAno.Visible = True
        Modificar_Libros.LblAutor.Visible = True
        Modificar_Libros.LblCantidad.Visible = True
        Modificar_Libros.LblCategoria.Visible = True
        ' Modificar_Libros.LblEdicion.Visible = True
        Modificar_Libros.LblNombre.Visible = True
        Modificar_Libros.TxtAno.Visible = True
        Modificar_Libros.CboAutor.Visible = True
        Modificar_Libros.TxtCantidad.Visible = True
        'Modificar_Libros.TxtEdicion.Visible = True
        Modificar_Libros.TxtNombre.Visible = True
        Modificar_Libros.BtnModificar.Visible = True
        ' Modificar_Libros.BtnCancelar.Visible = True
        Modificar_Libros.CboCategoria.Visible = True
    End Sub

    Shared Function vacioEmpleados() As Boolean
        Dim vacio = False
        If ((Modificar_Empleados.TxtApellido.TextLength = 0) Or
            (Modificar_Empleados.TxtCorreoElectronico.TextLength = 0) Or (Modificar_Empleados.TxtDireccion.TextLength = 0) Or
            (Modificar_Empleados.TxtDni.TextLength = 0) Or (Modificar_Empleados.TxtNombre.TextLength = 0) Or
            (Modificar_Empleados.TxtRuta.TextLength = 0) Or (Modificar_Empleados.txtTelefono.TextLength = 0)) Then
            vacio = True
        Else
            vacio = False
        End If
        Return vacio
    End Function
    Public Shared Sub LimpiarCampoModificarEmpleados()
        Dim vacio = False
        Modificar_Empleados.TxtApellido.Clear()
        'Modificar_Empleados.TxtContrasena.Clear()
        Modificar_Empleados.CboEmpleo.Text = Nothing
        'Modificar_Empleados.TxtUsuario.Clear()
        Modificar_Empleados.CboSexo.Text = Nothing
        Modificar_Empleados.CboEstados.Text = Nothing
        ' Modificar_Empleados.TxtContrasena.Clear()
        Modificar_Empleados.CboProvincia.Text = Nothing
        Modificar_Empleados.CboLocalidad.Text = Nothing
        Modificar_Empleados.TxtRuta.Clear()
        Modificar_Empleados.PBoxPerfilEmpleado.Image = Nothing
        'Modificar_Empleados.DtpFechaRegistracion.Text = Nothing
        Modificar_Empleados.TxtCorreoElectronico.Clear()
        Modificar_Empleados.TxtDireccion.Clear()
        Modificar_Empleados.TxtDni.Clear()
        Modificar_Empleados.TxtNombre.Clear()
        Modificar_Empleados.TxtRuta.Clear()
        Modificar_Empleados.txtTelefono.Clear()
        ' Modificar_Empleados.TxtUsuario.Clear()
        Modificar_Empleados.TxtBusqueda.Clear()
        Modificar_Empleados.TxtBusquedaPorNombre.Clear()
        Modificar_Empleados.CboBusqPorTipo.Text = Nothing
        Modificar_Empleados.CboEmpleo.Text = Nothing
        Modificar_Empleados.CboEstados.Text = Nothing
        Modificar_Empleados.CboLocalidad.Text = Nothing
        Modificar_Empleados.CboProvincia.Text = Nothing
        Modificar_Empleados.CboSexo.Text = Nothing
    End Sub


    Shared Function vacioEmpleadosRegis() As Boolean
        Dim vacio = False
        If ((Registrar_Empleados.TxtApellido.TextLength = 0) Or (Registrar_Empleados.TxtCorreoElectronico.TextLength = 0) Or (Registrar_Empleados.TxtDireccion.TextLength = 0) Or (Registrar_Empleados.TxtDni.TextLength = 0) Or (Registrar_Empleados.TxtNombre.TextLength = 0) Or (Registrar_Empleados.CboEmpleo.Text = Nothing) Or (Registrar_Empleados.CboLocalidad.Text = Nothing) Or (Registrar_Empleados.CboProvincia.Text = Nothing) Or (Registrar_Empleados.CboSexo.Text = Nothing) Or (Registrar_Empleados.TxtTelefono.TextLength = 0)) Then
            vacio = True
        Else
            vacio = False
        End If

        Return vacio
    End Function

    Shared Function vacioLibros() As Boolean
        Dim vacio = False
        If ((Form1.TxtISBN.TextLength = 0) Or (Form1.TxtAno.TextLength = 0) Or (Form1.TxtCantidad.TextLength = 0) Or
            (Form1.TxtNombre.TextLength = 0) Or (Form1.TxtPrecio.Text.Length = 0) Or (Form1.CboCategoria.Text = Nothing) Or (Form1.TxtAños.TextLength = 0) Or (Form1.TxtRuta.TextLength = 0) Or (Form1.TxtAutor.TextLength = 0) Or (Form1.TxtAutor1.TextLength = 0) Or (Form1.TxtAutor2.TextLength = 0)) Then
            vacio = True
        Else
            vacio = False
        End If

        Return vacio
    End Function

    Shared Function cerrarSesion(ByVal p_nombre As String) As Boolean
        Dim cerrarSesion_1 As Integer
        Dim cerrar As Boolean
        cerrarSesion_1 = MsgBox("¿Desea cerrar Sesión " + PrimeraLetraEnMayuscula(p_nombre) + " ? ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Cerrar Sesión")
        If cerrarSesion_1 = 2 Then
            cerrar = False
        Else
            cerrar = True
            Ingreso_al_Sistema.TxtContrasena.Text = Nothing
            Ingreso_al_Sistema.TxtUsuario.Text = Nothing
            Ingreso_al_Sistema.Show()
            Interfaz_del_Administrador.Close()
            Interfaz_del_SuperUsuario.Close()
            Interfaz_del_Administrador.Close()
            Interfaz_del_Vendedor.Close()
        End If
        Return cerrar
    End Function


End Class
