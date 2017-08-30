Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Modificar_Libros
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim directorioProyecto As String
    Dim extensionimagen As String
    Dim destino As String
    Dim origen As String
    Dim nombreImagen As String
    Dim extencion As String
    Dim imagen As Image
    Dim dataset2 As DataSet = New DataSet()
    Dim miAdaptador1 As SqlDataAdapter
    'variables para verificar si hubo alguna modificacion
    Dim numeroDeLibro As Integer
    Dim nombredelLibro As String
    Dim categoriaLibro As Integer
    Dim precio As Double
    Dim autor As Integer
    Dim autor1 As Integer
    Dim autor2 As Integer
    Dim estadoLibro As Integer
    Dim cantidad As Integer
    Dim ruta As String
    Dim añoPrimeraParte As Integer
    Dim añoSegundaParte As Integer
    Dim anio As String


    Private Sub TxtAutor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtPrecio.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtCantidad.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub Modificar_Libros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        TxtAños.Text = 17
        'Me.LibrosTableAdapter.FillByLibros(Me.DataSet1.Libros, 1)
        Me.CategoriasTableAdapter.FillByActivos(Me.DataSet1.Categorias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Categorias' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        Me.AutoresTableAdapter.FillByAutores(Me.DataSet1.Autores, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.FillByLibros(Me.DataSet1.Libros, 1)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        Me.MaximizeBox = False
        CboAutor.Text = Nothing
        CboEstado.Text = Nothing
        CboCategoria.Text = Nothing
        CboAutor1.Text = Nothing
        CboAutor2.Text = Nothing
        mostrarTodoConConInnerJoint()
        'Libreria.bloqueo()
        TxtBsquedaPorNombre.Visible = False
        TxtBusquedaPorCategoria.Visible = False
        TxtBusqueda.Visible = False
        'BtnBusquedaPorCategoria.Visible = False
        ' btnBusquedaPorNombre.Visible = False
        ' BtnConsultar.Visible = False
        BtnModificar.Enabled = False
        Libreria.limpiarCamposDeModificarLibros()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Libreria.desbloquearControles()
        Me.Width = 1230
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If huboModificacionONo() = True Then
            Dim resp As Integer = Libreria.SalirYguardar()
            If resp = 6 Then
                ConfirmacionModificar()
                Libreria.limpiarCamposDeModificarLibros()
                MsgBox("Datos Guardados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Me.Close()
            ElseIf resp = 7 Then
                Libreria.limpiarCamposDeModificarLibros()
                MsgBox("No se han Gurdado los datos modificados", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Información")
                BtnModificar.Enabled = False
                Me.Close()
            End If
        Else
            If Libreria.Salir() = 1 Then
                Libreria.limpiarCamposDeModificarLibros()
                BtnModificar.Enabled = False
                Me.Close()
            End If
        End If
    End Sub

    '  Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim Imagen1 As Image
    '     If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
    '          Exit Sub
    '      End If
    '     Imagen1 = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    '      origen = OpenFileDialog1.FileName
    'nombreImagen = System.IO.Path.GetFileName(origen)
    '      PBoxPerfilFoto.Image = Imagen1
    '     nombreImagen = TxtNombre.Text
    '     extensionimagen = System.IO.Path.GetExtension(origen)
    'directorioProyecto = My.Computer.FileSystem.CurrentDirectory
    '     destino = directorioProyecto + "\FotosLibros\" + nombreImagen + extensionimagen
    '    System.IO.File.Copy(origen, destino, True)
    '      Me.Close()
    '  End Sub

    Private Sub BtnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        imagen = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        PBoxPerfilFoto.Image = imagen
        nombreImagen = TxtNombre.Text
        origen = OpenFileDialog1.FileName
        extensionimagen = System.IO.Path.GetExtension(origen)
        TxtRuta.Text = origen
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        destino = directorioProyecto + "\FotosLibros\" + nombreImagen + extensionimagen
        System.IO.File.Copy(origen, destino, True)
        'Me.Close()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtNombre.TextLength = 0 Or CboCategoria.Text = Nothing Or TxtAno.Text = Nothing Or CboAutor.Text = Nothing Or TxtCantidad.TextLength = 0 Or TxtRuta.TextLength = 0 Or TxtPrecio.TextLength = 0 Or TxtAños.TextLength = 0 Or TxtNumeroDeLibro.TextLength = 0 Or CboAutor1.Text = Nothing Or CboAutor2.Text = Nothing Or CboEstado.Text = Nothing Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Try
                Convert.ToInt32(TxtAno.Text)
                Convert.ToInt32(TxtCantidad.Text)
            Catch ex As Exception
                MsgBox("Ingreso un valor incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea Modificar Libro", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ' CONTROLAR QUE EL INGRESO DE LOS DATOS SEAN CORRECTOS. VALIDARLOS.
                Dim actualizar As String
                Dim nro As Integer
                Dim autor As Integer
                Dim autor1 As Integer
                Dim autor2 As Integer
                Dim precio As Double
                Dim categoria As Integer
                Dim estado As Integer
                Dim cantidad As Integer
                Dim ruta As String
                Dim año As Integer
                Try
                    nro = CInt(TxtNumeroDeLibro.Text)
                    autor = CInt(CboAutor.SelectedValue)
                    precio = CDec(Me.TxtPrecio.Text)
                    categoria = CInt(CboCategoria.SelectedValue)
                    estado = CInt(CboEstado.SelectedValue)
                    cantidad = CInt(TxtCantidad.Text)
                    ruta = Me.TxtRuta.Text
                    autor1 = CInt(CboAutor1.SelectedValue)
                    autor2 = CInt(CboAutor2.SelectedValue)
                    año = CInt(TxtAños.Text + TxtAno.Text)
                Catch ex As Exception
                    MsgBox("Ingreso un valor Incorrecto, Verifique los valores de los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                actualizar = "UPDATE Libros SET nombre =@nombre, categoria = @categoria, autor = @autor, precio = @precio, estado = @estado, cantidad = @cantidad, imagen = @imagen, año = @año,autor1 = @autor1,autor2 = @autor2 WHERE ISBN = @ISBN"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@ISBN", nro)
                cmdActualizar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(TxtNombre.Text))
                cmdActualizar.Parameters.AddWithValue("@categoria", categoria)
                cmdActualizar.Parameters.AddWithValue("@precio", precio)
                cmdActualizar.Parameters.AddWithValue("@estado", estado)
                cmdActualizar.Parameters.AddWithValue("@cantidad", cantidad)
                cmdActualizar.Parameters.AddWithValue("@imagen", Libreria.TodoEnMayuscula(ruta))
                cmdActualizar.Parameters.AddWithValue("@año", año)
                cmdActualizar.Parameters.AddWithValue("@autor", autor)
                cmdActualizar.Parameters.AddWithValue("@autor1", autor1)
                cmdActualizar.Parameters.AddWithValue("@autor2", autor2)
                MsgBox("El Libro: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            Libreria.limpiarCamposDeModificarLibros()
            BtnModificar.Enabled = False
        End If
    End Sub
    Public Sub ConfirmacionModificar()
        If TxtNombre.TextLength = 0 Or CboCategoria.Text.Length = 0 Or TxtAno.TextLength = 0 Or CboAutor.SelectedValue = Nothing Or TxtCantidad.TextLength = 0 Or TxtRuta.TextLength = 0 Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Try
                Convert.ToInt32(TxtAno.Text)
                Convert.ToInt32(TxtCantidad.Text)
            Catch ex As Exception
                MsgBox("Ingreso un valor incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea Modificar Libro", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ' CONTROLAR QUE EL INGRESO DE LOS DATOS SEAN CORRECTOS. VALIDARLOS.
                Dim actualizar As String
                Dim nro As Integer
                Dim autor As Integer
                Dim autor1 As Integer
                Dim autor2 As Integer
                Dim precio As Double
                Dim categoria As Integer
                Dim estado As Integer
                Dim cantidad As Integer
                Dim ruta As String
                Dim año As Integer
                Try
                    nro = CInt(TxtNumeroDeLibro.Text)
                    autor = CInt(CboAutor.SelectedValue)
                    precio = CDec(Me.TxtPrecio.Text)
                    categoria = CInt(CboCategoria.SelectedValue)
                    estado = CInt(CboEstado.SelectedValue)
                    cantidad = CInt(TxtCantidad.Text)
                    ruta = Me.TxtRuta.Text
                    autor1 = CInt(CboAutor1.SelectedValue)
                    autor2 = CInt(CboAutor2.SelectedValue)
                    año = CInt(TxtAños.Text + TxtAno.Text)
                Catch ex As Exception
                    MsgBox("Ingreso un valor Incorrecto, Verifique los valores de los campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                actualizar = "UPDATE Libros SET nombre =@nombre, categoria = @categoria, autor = @autor, precio = @precio, estado = @estado, cantidad = @cantidad, imagen = @imagen, año = @año,autor1 = @autor1,autor2 = @autor2 WHERE ISBN = @ISBN"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@ISBN", nro)
                cmdActualizar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(TxtNombre.Text))
                cmdActualizar.Parameters.AddWithValue("@categoria", categoria)
                cmdActualizar.Parameters.AddWithValue("@precio", precio)
                cmdActualizar.Parameters.AddWithValue("@estado", estado)
                cmdActualizar.Parameters.AddWithValue("@cantidad", cantidad)
                cmdActualizar.Parameters.AddWithValue("@imagen", Libreria.TodoEnMayuscula(ruta))
                cmdActualizar.Parameters.AddWithValue("@año", año)
                cmdActualizar.Parameters.AddWithValue("@autor", autor)
                cmdActualizar.Parameters.AddWithValue("@autor1", autor1)
                cmdActualizar.Parameters.AddWithValue("@autor2", autor2)
                MsgBox("El Libro: " + TxtNombre.Text + " se Modifico correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Actualización")
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            TxtAno.Clear()
            TxtBusqueda.Clear()
            TxtCantidad.Clear()
            CboAutor.Text = Nothing
            CboEstado.Text = Nothing
            CboCategoria.Text = Nothing
            CboAutor1.Text = Nothing
            CboAutor2.Text = Nothing
            TxtNombre.Clear()
            TxtNumeroDeLibro.Clear()
            TxtPrecio.Clear()
            TxtRuta.Clear()
            PBoxPerfilFoto.Image = Nothing
        End If
    End Sub

    Private Sub TxtAno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAno.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtAno.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Function ComprobacionExistencia(ByVal p_NroLibro As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE ISBN = '" & p_NroLibro & "'"
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
    Private Sub consultaConInnerJoint(ByVal p_NroLibro As String)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre,Categorias.descripcion as Categoria,Libros.precio,Autores.nombreAutor as Autor,Autores1.nombreAutor as Autor,Autores2.nombreAutor as Autor,Estado.descripcion as Estado,Libros.cantidad,Libros.imagen,Libros.año,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.ISBN Like'" + "%" + p_NroLibro + "%" + "' and Libros.estado= 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub CboBusqPorTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If CboBusqPorTipo.Text = "Categoria" Or CboBusqPorTipo.Text = "Nombre" Then
            Dim buscar As String
            If TxtBusqueda.TextLength > 0 Then
                Dim nro As Integer = Convert.ToInt32(TxtBusqueda.Text)
                buscar = "SELECT * FROM Libros WHERE ISBN like '" & nro & "'"
                miAdaptador = New SqlDataAdapter(buscar, miConexion)
                dataset.Clear()
                miAdaptador.Fill(dataset)
                Me.DtgModifcarLibros.DataSource = dataset.Tables(0)
            End If
        ElseIf CboBusqPorTipo.Text = "Nro de Libro" Or CboBusqPorTipo.Text = "Año" Then
            Try
                Convert.ToInt32(TxtBusqueda.Text)
            Catch ex As Exception
                MsgBox("Ingrese un número o cambie la opción")
                Exit Sub
            End Try
            If TxtNumeroDeLibro.TextLength > 0 Then
                Dim nro As Integer = Convert.ToInt32(TxtNumeroDeLibro.Text)
                If ComprobacionExistencia(nro) = True Then
                    consultaConInnerJoint(nro)
                Else
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                End If
            Else
                dataset2.Clear()
                'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
            End If
        End If
    End Sub
    Function huboModificacionONo() As Boolean
        Dim modificacion As Boolean = False
        If TxtNumeroDeLibro.TextLength > 0 Then
            If (CInt(numeroDeLibro) <> CInt(TxtNumeroDeLibro.Text)) Or (nombredelLibro <> TxtNombre.Text) Or (CInt(categoriaLibro) <> CboCategoria.SelectedValue) Or (Convert.ToDouble(precio) <> Convert.ToDouble(TxtPrecio.Text)) Or (CInt(autor) <> CboAutor.SelectedValue) Or (CInt(autor1) <> CboAutor1.SelectedValue) Or (CInt(autor2) <> CboAutor2.SelectedValue) Or (CInt(estadoLibro) <> CboEstado.SelectedValue) Or (CInt(cantidad) <> CInt(TxtCantidad.Text)) Or (ruta <> TxtRuta.Text) Or (CInt(añoPrimeraParte) <> CInt(TxtAños.Text)) Or (CInt(añoSegundaParte) <> CInt(TxtAno.Text)) Then
                modificacion = True
                Return modificacion
            Else
                Return modificacion
            End If
        End If
        Return modificacion
    End Function

    Private Sub DtgModifcarLibros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgModifcarLibros.Click
        If DtgModifcarLibros.SelectedRows.Count > 0 Then
            TxtNumeroDeLibro.Text = DtgModifcarLibros.SelectedRows(0).Cells(0).Value.ToString()
            numeroDeLibro = TxtNumeroDeLibro.Text
            TxtNombre.Text = DtgModifcarLibros.SelectedRows(0).Cells(1).Value.ToString()
            nombredelLibro = TxtNombre.Text
            CboCategoria.SelectedValue = ComprobacionExistenciaCategoria(DtgModifcarLibros.SelectedRows(0).Cells(2).Value)
            categoriaLibro = CboCategoria.SelectedValue
            TxtPrecio.Text = DtgModifcarLibros.SelectedRows(0).Cells(3).Value.ToString()
            precio = TxtPrecio.Text
            CboAutor.SelectedValue = ComprobacionExistenciaAutor(DtgModifcarLibros.SelectedRows(0).Cells(4).Value)
            autor = CboAutor.SelectedValue
            CboAutor1.SelectedValue = ComprobacionExistenciaAutor(DtgModifcarLibros.SelectedRows(0).Cells(5).Value)
            autor1 = CboAutor1.SelectedValue
            CboAutor2.SelectedValue = ComprobacionExistenciaAutor(DtgModifcarLibros.SelectedRows(0).Cells(6).Value)
            autor2 = CboAutor2.SelectedValue
            CboEstado.SelectedValue = ComprobacionExistenciaEstado(DtgModifcarLibros.SelectedRows(0).Cells(7).Value)
            estadoLibro = CboEstado.SelectedValue
            TxtCantidad.Text = DtgModifcarLibros.SelectedRows(0).Cells(8).Value.ToString()
            cantidad = TxtCantidad.Text
            TxtRuta.Text = DtgModifcarLibros.SelectedRows(0).Cells(9).Value.ToString()
            ruta = TxtRuta.Text
            anio = DtgModifcarLibros.SelectedRows(0).Cells(10).Value.ToString()
            Dim FirstWord As String = Mid(anio, 1, 2)
            Dim LastWord As String = Mid(anio, 3, 4)
            añoPrimeraParte = FirstWord
            añoSegundaParte = LastWord
            TxtAno.Text = añoSegundaParte
            TxtAños.Text = añoPrimeraParte

            Try
                PBoxPerfilFoto.BackgroundImage = System.Drawing.Image.FromFile(TxtRuta.Text)
            Catch ex As Exception
                MsgBox("La imagen fue eliminada o no existe", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                PBoxPerfilFoto.Image = Nothing
                TxtRuta.Text = ""
                BtnModificar.Enabled = True
                Exit Sub
            End Try
            BtnModificar.Enabled = True
            'Libreria.debloqueo()
            'Exit Sub
            'MessageBox.Show(DtgModifcarLibros.Rows(3).Cells(1).Value.ToString) '3=fila y 1 columna
        End If
    End Sub
   
    Function ComprobacionExistenciaAutor(ByVal p_NombreAutor As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Autores WHERE nombreAutor = '" & Libreria.TodoEnMayuscula(p_NombreAutor) & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(2)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Function ComprobacionExistenciaEstado(ByVal p_NombreEstado As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Estado WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_NombreEstado) & "'"
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

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        mostrarTodoConConInnerJoint()
    End Sub

    Private Sub BtnAgregarAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAño.Click
        If CInt(TxtAños.Text) >= 17 And CInt(TxtAños.Text) < 20 Then
            TxtAños.Text = CInt(TxtAños.Text) + 1
        Else
            MsgBox("Supera el rango permitido ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Campo Vacio")
        End If
    End Sub

    Private Sub BtnQuitarAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarAño.Click
        If CInt(TxtAños.Text) > 17 Then
            TxtAños.Text = CInt(TxtAños.Text) - 1
        Else
            MsgBox("Fuera de Rango solo el ingreso hasta el año Actual", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Campo Vacio")
        End If
    End Sub

    Private Sub TxtAno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAno.LostFocus
        If TxtAños.TextAlign = 0 And TxtAno.TextLength > 0 Then
            If CInt(TxtAños.Text) = 20 And CInt(TxtAno.Text) > 15 Then
                MsgBox("Fuera de Rango solo el ingreso hasta el año Actual", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                TxtAno.Focus()
            End If
        End If
    End Sub


    Private Sub TxtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtPrecio.Focus()
        Else
            Libreria.soloNumeroConComa(e)
        End If
    End Sub

    Private Sub mostrarTodoConConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre,Categorias.descripcion as Categoria,Libros.precio,Autores.nombreAutor as Autor,Autores1.nombreAutor as Autor,Autores2.nombreAutor as Autor,Estado.descripcion as Estado,Libros.cantidad,Libros.imagen,Libros.año,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor where Libros.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Function ComprobacionExistenciaPorNombre(ByVal p_nombre As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE nombre Like '" + "%" + p_nombre + "%" + "' and estado = 1"
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
        Dim buscar As String = "SELECT Libros.ISBN,nombre AS NOMBRE,Categorias.descripcion as CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor as AUTOR,Autores1.nombreAutor as AUTOR1,Autores2.nombreAutor as AUTOR2,Estado.descripcion as ESTADO,Libros.cantidad AS CANTIDAD,Libros.imagen AS IMAGEN,Libros.año AS AÑO,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.nombre like '" + "%" + p_nombre + "%" + "' and Libros.estado= 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged

        Select Case CboBusqPorTipo.SelectedItem
            Case "Nro de Libro"
                TxtBsquedaPorNombre.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtBusqueda.Visible = True
                'BtnBusquedaPorCategoria.Visible = False
                '  btnBusquedaPorNombre.Visible = False
                ' BtnConsultar.Visible = True
                mostrarTodoConConInnerJoint()
            Case "Nombre"
                TxtBusqueda.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtBsquedaPorNombre.Visible = True
                mostrarTodoConConInnerJoint()
            Case "Categoria"
                TxtBsquedaPorNombre.Visible = False
                TxtBusqueda.Visible = False
                TxtBusquedaPorCategoria.Visible = True
                mostrarTodoConConInnerJoint()
            Case Else
                MsgBox("No seleciono nada")
        End Select
    End Sub

    Function ComprobacionExistenciaCategoria(ByVal p_NombreCategoria As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Categorias WHERE descripcion = '" & p_NombreCategoria & "'"
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
    Function ComprobacionExistenciaPorcategoria(ByVal p_categoria As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Dim nroDeCategoria1 As Integer
        nroDeCategoria1 = ComprobacionExistenciaCategoria(p_categoria)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE categoria = '" & nroDeCategoria1 & "' and estado = 1"
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

    Private Sub consultaConInnerJointCategoria(ByVal p_categoria As String)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre,Categorias.descripcion as Categoria,Libros.precio,Autores.nombreAutor as Autor,Autores1.nombreAutor as Autor,Autores2.nombreAutor as Autor,Estado.descripcion as Estado,Libros.cantidad,Libros.imagen,Libros.año,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Categorias.descripcion like '" + "%" + p_categoria + "%" + "' and Libros.estado = 1;"
         miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgModifcarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtBsquedaPorNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBsquedaPorNombre.KeyPress
        If TxtBsquedaPorNombre.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBsquedaPorNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub TxtBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        If TxtBusqueda.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "]" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusqueda.Focus()
        Else
            Libreria.soloNumero(e)
        End If

    End Sub

    Private Sub TxtBusquedaPorCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorCategoria.KeyPress
        If TxtBusquedaPorCategoria.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusquedaPorCategoria.Focus()
        Else
            Libreria.soloLetras(e)
        End If
    End Sub


    Private Sub TxtBusquedaPorCategoria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorCategoria.TextChanged
        If TxtBusquedaPorCategoria.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        Else
            Dim nombre As String
            If TxtBusquedaPorCategoria.TextLength > 0 Then
                Try
                    nombre = TxtBusquedaPorCategoria.Text
                Catch ex As Exception
                    MsgBox("Ingreso un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointCategoria(nombre)
                If DtgModifcarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Categoria no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub

    Private Sub TxtBsquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBsquedaPorNombre.TextChanged
        If TxtBsquedaPorNombre.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        Else
            Dim nombre As String
            If TxtBsquedaPorNombre.TextLength > 0 Then
                Try
                    nombre = TxtBsquedaPorNombre.Text
                Catch ex As Exception
                    MsgBox("Ingreso un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointNombre(nombre)
                If DtgModifcarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
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
                If DtgModifcarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub
End Class