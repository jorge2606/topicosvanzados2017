Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class VerFactura
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim reader As SqlDataReader
    'variables de la factura
    Dim nro_factura As Integer
    Dim cod_empresa As Integer
    Dim fechayhora As String
    Dim total As Double
    Dim cod_cliente As Integer
    Dim formaDePago As Integer
    Dim bonificacion As Double
    'variables de ña empresa
    Dim nombreEmp As String
    Dim direccionEmp As String
    'variables del cliente
    Dim dniCliente As Integer
    Dim nombreCliente As String
    Dim apellidoCliente As String
    Dim direccionCliente As String
    Dim localidadCliente As Integer
    Dim provinviaClinte As Integer
    Dim telefonoCliente As String
    Dim sexoCliente As Integer
    Dim correoCliente As String
    Dim vendedor As Integer
    Dim ApellidoVendedor As String
    Dim sexo1 As Integer
    Dim sexoVendedor As Integer
    Dim NombreVendedor As String
    'variables de forma de pago
    Dim formaPagoCadena As String
    'Public Sub AutoResizeRowHeadersWidth( _
    'ByVal rowIndex As Integer, _
    'ByVal rowHeadersWidthSizeMode As DataGridViewRowHeadersWidthSizeMode _
    ')

    ' End Sub
    Private Sub VerFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Compras' Puede moverla o quitarla según sea necesario.
        If nroFactura() <> Nothing Then
            Label1NroFactura.Text = nroFactura()
            'MsgBox("factura de afuera" & Label1NroFactura.Text)
            Empresa(cod_empresa)
            Cliente(cod_cliente)
            EmpleadoVendedor(vendedor)
            cargaDeDatos()
            consultaConInnerJoint(nro_factura)
            DtgVerFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DtgVerFacturas.AutoResizeColumns()
            'Me.ComprasTableAdapter.FillByMostrarEnFactura(Me.DataSet1.Compras, nro_factura)

        Else
            Label1NroFactura.Text = nroUltimaFactura()
            'MsgBox("factura de adentro" & Label1NroFactura.Text)
            Empresa(cod_empresa)
            Cliente(cod_cliente)
            EmpleadoVendedor(vendedor)
            cargaDeDatos()
            consultaConInnerJoint(nro_factura)
            'DtgVerFacturas.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
            DtgVerFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DtgVerFacturas.AutoResizeColumns()

            'Me.DtgVerFacturas.DefaultCellStyle.WrapMode = DataGridViewTriState.False
            Me.ComprasTableAdapter.FillByMostrarEnFactura(Me.DataSet1.Compras, nro_factura)
        End If
    End Sub
    Private Sub cargaDeDatos()
        Label2NomEmpresa.Text = nombreEmp
        Label3NomDireccion.Text = direccionEmp
        Label4DniCliente.Text = dniCliente
        Label5NomCliente.Text = nombreCliente
        Label6ApeCliente.Text = apellidoCliente
        Label7DirCliente.Text = direccionCliente
        Label8LocCliente.Text = Localidad(localidadCliente)
        Label9ProvinciaClient.Text = Provincia(provinviaClinte)
        Label10TelefonoClient.Text = telefonoCliente
        If sexoVendedor = 1 Then
            LblDatosDelVendedor.Text = "Datos del Vendedor"
        Else
            LblDatosDelVendedor.Text = "Datos de la Vendedora"
        End If
        Label12CorreoClient.Text = correoCliente
        Label13FormaDePago.Text = FormaDePagoCliente(formaDePago)
        LblMontoAPagar.Text = total + bonificacion
        LblMontoDeBonificacion.Text = bonificacion
        TotConBonificacion.Text = total
        LblFechaActual.Text = Convert.ToDateTime(fechayhora)
        LblDniVend.Text = vendedor
        LblNomVend.Text = NombreVendedor
        LblApeVende.Text = ApellidoVendedor
    End Sub
    Private Sub consultaConInnerJoint(ByVal p_nrofacturas As Integer)
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT cod_compra,Libros.nombre as Nombre_de_Libro,Compras.cantidad,Compras.precio FROM Compras INNER JOIN Libros ON Compras.cod_libro = Libros.ISBN WHERE Compras.cod_factura = '" & p_nrofacturas & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgVerFacturas.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Function nroUltimaFactura() As Integer
        Dim buscar As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Facturas WHERE cod_factura = (select max(cod_factura) from Facturas)"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nro_factura = reader.Item(0)
            cod_empresa = reader.Item(1)
            fechayhora = reader.Item(2)
            total = reader.Item(3)
            cod_cliente = reader.Item(4)
            formaDePago = reader.Item(5)
            bonificacion = reader.Item(6)
            vendedor = reader.Item(7)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return nro_factura
    End Function

    Function nroFactura() As Integer
        Dim buscar As String
        Dim nFaactura As Integer
        nro_factura = Nothing
        nFaactura = Facturas.nro_factura
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Facturas WHERE cod_factura= '" & nFaactura & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nro_factura = reader.Item(0)
            cod_empresa = reader.Item(1)
            fechayhora = reader.Item(2)
            total = reader.Item(3)
            cod_cliente = reader.Item(4)
            formaDePago = reader.Item(5)
            bonificacion = reader.Item(6)
            '  vendedor = reader.Item(7)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return nro_factura
    End Function


    Private Sub Empresa(ByVal p_codEmpresa As Integer)
        Dim buscar As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Empresa WHERE Nro = '" & p_codEmpresa & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nombreEmp = reader.Item(1)
            direccionEmp = reader.Item(2)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
    End Sub

    Private Sub Cliente(ByVal p_DniCliente As Integer)
        Dim buscar As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_DniCliente & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            dniCliente = reader.Item(0)
            nombreCliente = reader.Item(1)
            apellidoCliente = reader.Item(2)
            direccionCliente = reader.Item(3)
            localidadCliente = reader.Item(4)
            provinviaClinte = reader.Item(5)
            telefonoCliente = reader.Item(7)
            sexoCliente = reader.Item(10)
            correoCliente = reader.Item(11)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
    End Sub

    Function FormaDePagoCliente(ByVal p_formaDePago As Integer) As String
        Dim buscar As String
        Dim formPago As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        formPago = CInt(p_formaDePago)
        buscar = "SELECT cod_pago,descripcion FROM [Formas de Pago] WHERE cod_pago = '" & p_formaDePago & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            formaPagoCadena = reader.Item(1)

        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return formaPagoCadena
    End Function

    Function Localidad(ByVal p_nroLocalidad As Integer) As String
        Dim buscar As String
        Dim loc As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Localidades WHERE cod_localidad = '" & p_nroLocalidad & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            loc = reader.Item(2)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return loc
    End Function
    Function Provincia(ByVal p_provincia As Integer) As String
        Dim buscar As String
        Dim prov As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Provincias WHERE cod_Provincia = '" & p_provincia & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            prov = reader.Item(1)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return prov
    End Function
    Function Sexo(ByVal p_sexo As Integer) As String
        Dim buscar As String
        Dim sex As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Sexo WHERE cod_sexo = '" & p_sexo & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            sex = reader.Item(1)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return sex
    End Function

    Private Sub EmpleadoVendedor(ByVal p_dniEmpleado As Integer)
        Dim buscar As String
        Dim sex As String = ""
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT * FROM Empleados WHERE dni = '" & p_dniEmpleado & "' ;"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            vendedor = reader.Item(0)
            NombreVendedor = reader.Item(1)
            ApellidoVendedor = reader.Item(2)
            sexoVendedor = reader.Item(7)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
    End Sub

End Class

