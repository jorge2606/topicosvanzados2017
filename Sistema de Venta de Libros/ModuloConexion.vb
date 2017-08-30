Imports System
Imports System.Data
Imports System.Data.SqlClient

Module ModuloConexion
    
    Dim miConexion As SqlConnection
    Public Sub conectar()
        miConexion = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Venta_de_libros;Integrated Security=True")
        miConexion.Open()
    End Sub
End Module
Module empresa
    Public Sub Empresa()
        Dim miConexion As SqlConnection
        miConexion = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Venta_de_libros;Integrated Security=True")
        Dim miAdaptador As SqlDataAdapter
        Dim buscar As String
        Dim nro As Integer = 5
        buscar = "SELECT * FROM Empresa WHERE ISBN = '" & nro & "'"
        miAdaptador = New SqlDataAdapter(buscar, miConexion)
    End Sub
End Module
Module factura
    Public Sub factura(ByVal cod_empresa As Integer, ByVal p_fechaYhora As String, ByVal p_total As Double, ByVal cod_cliente As Integer, ByVal p_formaPago As Integer, ByVal p_bonificacion As Double, ByVal p_vendedor As Integer)
        Dim miConexion As SqlConnection
        miConexion = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Venta_de_libros;Integrated Security=True")
        Dim insertar As String
        insertar = "INSERT INTO Facturas(cod_empresa,fechaYhora,total,cod_cliente,formaDePago,bonificacion,vendedor)" & "VALUES" & "(@cod_empresa,@fechaYhora,@total,@cod_cliente,@formaDePago,@bonificacion,@vendedor)"
        Dim cmdInsertar As New SqlCommand(insertar, miConexion)
        cmdInsertar.Parameters.AddWithValue("@cod_empresa", cod_empresa)
        cmdInsertar.Parameters.AddWithValue("@fechaYhora", p_fechaYhora)
        cmdInsertar.Parameters.AddWithValue("@total", p_total)
        cmdInsertar.Parameters.AddWithValue("@cod_cliente", cod_cliente)
        cmdInsertar.Parameters.AddWithValue("@formaDePago", p_formaPago)
        cmdInsertar.Parameters.AddWithValue("@bonificacion", p_bonificacion)
        cmdInsertar.Parameters.AddWithValue("@vendedor", p_vendedor)
        Try
            miConexion.Open()
            cmdInsertar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Module
Module compra
    Public Sub Compras(ByVal p_cod_factura As Integer, ByVal p_cod_libro As Integer, ByVal p_cantidad As Integer, ByVal p_Precio As Double, ByVal p_fecha As String)
        Dim miConexion As SqlConnection
        miConexion = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=Venta_de_libros;Integrated Security=True")
        Dim insertar As String
        insertar = "INSERT INTO Compras(cod_factura,cod_libro,cantidad,Precio,fechaDeVenta)" & "VALUES" & "(@cod_factura,@cod_libro,@cantidad,@Precio,@fechaDeVenta)"
        Dim cmdInsertar As New SqlCommand(insertar, miConexion)
        ' cmdInsertar.Parameters.AddWithValue("@cod_factura", )
        cmdInsertar.Parameters.AddWithValue("@cod_factura", p_cod_factura)
        cmdInsertar.Parameters.AddWithValue("@cod_libro", p_cod_libro)
        cmdInsertar.Parameters.AddWithValue("@cantidad", p_cantidad)
        cmdInsertar.Parameters.AddWithValue("@Precio", p_Precio)
        cmdInsertar.Parameters.AddWithValue("@fechaDeVenta", p_fecha)
        Try
            miConexion.Open()
            cmdInsertar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Module
Module ultimolibroregistrado
    Dim dataset2 As DataSet = New DataSet()
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim buscar As String
    Dim ISBNs As Integer
    Public Sub consultaConInnerJoint_REGISTRARLIBRO()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar = "SELECT ISBN FROM Libros WHERE ISBN = (select max(ISBN) from Libros)"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            ISBNs = reader.Item(0)
        End While
        reader.Close()
        Dim buscar1 As String = "SELECT Libros.ISBN,nombre,Categorias.descripcion,Libros.precio,Autores.nombreAutor,Autores1.nombreAutor,Autores2.nombreAutor,Estado.descripcion,Libros.cantidad,Libros.imagen,Libros.año FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.ISBN = '" & ISBNs & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar1, miConexion)
        'dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        'Dim filas As Integer = Form1.DtgRegistrarLibros.Rows.Count
        Form1.DtgRegistrarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

End Module
