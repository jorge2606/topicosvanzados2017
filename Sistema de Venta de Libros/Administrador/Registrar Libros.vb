Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    'Conectar a base de datos
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    'variables para guardar en el datagrid
    Dim directorioProyecto As String
    Dim extensionimagen As String
    Dim destino As String
    Dim origen As String
    Dim nombreImagen As String
    Dim extencion As String
    Dim Imagen1 As Image
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Private Sub TxtAno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAno.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtAno.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub TxtAutor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloLetrasSinEspacios(e)
    End Sub


    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            TxtAno.Text = ""
            TxtNombre.Text = ""
            'TxtAutor.Text = ""
            TxtCantidad.Text = ""
            TxtAno.Text = ""
            TxtPrecio.Text = ""
            CboCategoria.Text = ""
            Me.Close()
        End If
    End Sub
    Function ComprobacionExistencia(ByVal p_nombreLibro As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE nombre = '" & p_nombreLibro & "'"
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

    Private Sub BtnAgregarLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarLibros.Click
        If Libreria.vacioLibros() = True Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            Dim Nombrefoto As String = TxtNombre.Text
            'Es la carpeta destino donde voy a copiar los archivos  Se tiene que crear primero la carpeta “Fotos”
            nombreImagen = Nombrefoto
            destino = directorioProyecto + "\FotosLibros\" + nombreImagen + extensionimagen
            'Copio la imagen a la carpeta del proyecto "FotosLibros"
            Try
                System.IO.File.Copy(origen, destino, True)
            Catch ex As Exception
                MsgBox("Ingrese una imagen", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Dim NombreLib As String
            NombreLib = TxtNombre.Text
            Dim CategoriaLib As String
            Dim añoLib As Integer
            Dim CantidadLib As Integer
            ' Dim estado As Integer
            Dim autor As Integer
            Dim autor1 As Integer
            Dim isbn As Integer
            Dim autor2 As Integer
            Dim PrecioLib As Double
            Dim vDia As String = DtpRegistracionDelLibro.Value.Day
            Dim vMes As String = DtpRegistracionDelLibro.Value.Month
            Dim vAño As String = DtpRegistracionDelLibro.Value.Year

            Try
                PrecioLib = CStr(TxtPrecio.Text)
            Catch ex As Exception
                MsgBox("Ingreso un Caracter No permitido en el campo Precio", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try

            autor = CInt(TxtNroDeAutor.Text)
            autor1 = CInt(TxtNroDeAutor1.Text)
            autor2 = CInt(TxtNroDeAutor2.Text)
            Try
            Catch ex As Exception
                MsgBox("Caracter No permitido en el campo Autor", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Try
                isbn = CInt(TxtISBN.Text)
                añoLib = Convert.ToInt32(TxtAños.Text & TxtAno.Text)
            Catch ex As Exception
                MsgBox("Ingreso un Caracter No permitido en el campo año", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Try
                CantidadLib = Convert.ToInt32(TxtCantidad.Text)
            Catch ex As Exception
                MsgBox("Ingreso un Caracter No permitido en el campo cantidad", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            Try
                CategoriaLib = CInt(CboCategoria.SelectedValue)
            Catch ex As Exception
                MsgBox("Ingreso un Caracter No permitido en el campo categoria", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                Exit Sub
            End Try
            If (CInt(TxtNroDeAutor.Text) = CInt(TxtNroDeAutor1.Text) Or CInt(TxtNroDeAutor.Text) = CInt(TxtNroDeAutor2.Text) Or CInt(TxtNroDeAutor1.Text) = CInt(TxtNroDeAutor2.Text)) Then
                MsgBox("Ingreso los mismos autores", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                Exit Sub
            Else
                Dim ask As MsgBoxResult
                ask = MsgBox("Seguro que desea insertar nuevo Libro", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Confirmar Inserción")
                If MsgBoxResult.Yes = ask Then
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim insertar As String
                    insertar = "INSERT INTO Libros(ISBN,nombre, categoria,precio,estado,cantidad,imagen,año,autor,autor1,autor2,fecha_alta)" & "VALUES" & "(@ISBN,@nombre,@categoria,@precio,@estado,@cantidad,@imagen,@año,@autor,@autor1,@autor2,@fecha_alta)"
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    cmdInsertar.Parameters.AddWithValue("@ISBN", isbn)
                    cmdInsertar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(NombreLib))
                    cmdInsertar.Parameters.AddWithValue("@categoria", CategoriaLib)
                    cmdInsertar.Parameters.AddWithValue("@precio", PrecioLib)
                    cmdInsertar.Parameters.AddWithValue("@estado", 1)
                    cmdInsertar.Parameters.AddWithValue("@cantidad", CantidadLib)
                    cmdInsertar.Parameters.AddWithValue("@imagen", Libreria.TodoEnMayuscula(destino))
                    cmdInsertar.Parameters.AddWithValue("@año", añoLib)
                    cmdInsertar.Parameters.AddWithValue("@autor", autor)
                    cmdInsertar.Parameters.AddWithValue("@autor1", autor1)
                    cmdInsertar.Parameters.AddWithValue("@autor2", autor2)
                    cmdInsertar.Parameters.AddWithValue("@fecha_alta", Convert.ToString(vDia & "-" & vMes & "-" & vAño))
                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                        'consultaConInnerJoint_REGISTRARLIBRO(ultimolibro())
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        miConexion.Close()
                        Exit Sub
                    End Try
                    MsgBox("El Libro: " + TxtNombre.Text + " se inserto correctamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, " Guardar")
                    TxtAno.Clear()
                    TxtCantidad.Clear()
                    TxtNombre.Clear()
                    TxtPrecio.Clear()
                    TxtRuta.Clear()
                    CboCategoria.Text = Nothing
                    TxtNroDeAutor.Text = Nothing
                    TxtAutor.Clear()
                    TxtNroDeAutor1.Text = Nothing
                    TxtAutor1.Clear()
                    TxtNroDeAutor2.Text = Nothing
                    TxtAutor2.Clear()
                    PtBoxPerfil.Image = Nothing
                    TxtISBN.Clear()
                End If
            End If
            End If
    End Sub

    Private Sub limpiarCampos()
        TxtAno.Clear()
        TxtISBN.Clear()
        TxtCantidad.Clear()
        TxtNombre.Clear()
        TxtPrecio.Clear()
        TxtRuta.Clear()
        CboCategoria.Text = Nothing
        TxtNroDeAutor.Text = Nothing
        TxtAutor.Clear()
        TxtNroDeAutor1.Text = Nothing
        TxtAutor1.Clear()
        TxtNroDeAutor2.Text = Nothing
        TxtAutor2.Clear()
        PtBoxPerfil.Image = Nothing
    End Sub
    Function ultimolibro() As Integer
        Dim buscarq As String
        Dim nro_libros As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarq = "SELECT ISBN FROM Libros WHERE ISBN = (select max(ISBN) from Libros)"
        comando = New SqlCommand(buscarq, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nro_libros = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return nro_libros
    End Function
    Public Sub consultaConInnerJoint_REGISTRARLIBRO(ByVal p_nroLibro As Integer)
        Dim bus As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bus = "SELECT Libros.ISBN,nombre,Categorias.descripcion as Categoria,Libros.precio,Autores.nombreAutor as Autor,Autores1.nombreAutor as Autor,Autores2.nombreAutor as Autor,Estado.descripcion as Estado,Libros.cantidad,Libros.fecha_alta,Libros.año FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.ISBN = '" & p_nroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(bus, miConexion)
        ' dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgRegistrarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub


    Private Sub BtnQuitarLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DtgRegistrarLibros.Rows.Remove(Me.DtgRegistrarLibros.CurrentRow)
        Libreria.cantidadlineasLibros()
    End Sub
    Private Sub TxtAno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAno.LostFocus
        If TxtAños.TextAlign = 0 And TxtAno.TextLength > 0 Then
            If CInt(TxtAños.Text) = 20 And CInt(TxtAno.Text) > 15 Then
                MsgBox("Fuera de Rango solo el ingreso hasta el año Actual", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                TxtAno.Focus()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibrosTableAdapter.FillByLibros(Me.DataSet1.Libros, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        Me.AutoresTableAdapter.FillByAutores(Me.DataSet1.Autores, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.FillByActivos(Me.DataSet1.Categorias, 1)
        CboCategoria.Text = Nothing
        TxtNroDeAutor.Text = Nothing
        TxtAutor.Clear()
        TxtISBN.Focus()
        TxtNroDeAutor1.Text = Nothing
        TxtAutor1.Clear()
        TxtNroDeAutor2.Text = Nothing
        TxtAutor2.Clear()
        Libreria.cantidadlineasLibros()
        TxtAños.Text = 17
        'Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ' Me.LibrosTableAdapter.Fill(Me.DataSet1.Libros)
        'DataSet1.Clear()
        PtBoxPerfil.Image = Nothing
        Me.CboCategoria.Text = Nothing
        TxtRuta.Enabled = False
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        DtgRegistrarLibros.RowTemplate.Height = 40
        'Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch
        mostrarTodoConConInnerJoint()
    End Sub
    Private Sub mostrarTodoConConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre,Categorias.descripcion as Categoria,Libros.precio,Autores.nombreAutor as Autor,Autores1.nombreAutor as Autor,Autores2.nombreAutor as Autor,Estado.descripcion as Estado,Libros.cantidad,Libros.fecha_alta,Libros.año FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor where Libros.estado= 1 and Libros.cantidad > 0;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgRegistrarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila As Integer = Me.DtgRegistrarLibros.CurrentRow.Index
        TxtNombre.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(0).Value
        'TxtEdicion.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(1).Value
        'CboCategoria.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(2)
        TxtAno.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(3).Value
        TxtCantidad.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(4).Value
        CboCategoria.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(5).Value
        TxtPrecio.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(6).Value
        'TxtRuta.Text = Me.DtgRegistrarLibros.Rows(fila).Cells(7).value
    End Sub



    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Or e.KeyChar.ToString = "´" Then
            e.Handled = True
            TxtCantidad.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub DtgRegistrarLibros_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRegistrarLibros.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DtgRegistrarLibros.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgRegistrarLibros.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar"
                        If Libreria.DeseaEliminarLibros() = 1 Then
                            'DtgRegistrarLibros.Rows.RemoveAt(cell.RowIndex)
                            '  MsgBox("Los Datos Fueron Eliminados Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                            Eliminar_Libros.ShowDialog()
                        End If
                    Case "Modificar"
                        Modificar_Libros.ShowDialog()
                        Exit Select

                End Select

            End If

        End If
    End Sub

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Imagen1 As Image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Imagen1 = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        origen = OpenFileDialog1.FileName
        'nombreImagen = System.IO.Path.GetFileName(origen)
        PtBoxPerfil.Image = Imagen1
        nombreImagen = TxtNombre.Text
        extensionimagen = System.IO.Path.GetExtension(origen)
        'directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        destino = directorioProyecto + "\FotosLibros\" + nombreImagen + extensionimagen
        System.IO.File.Copy(origen, destino, True)
        Me.Close()
    End Sub


    Private Sub btnExaminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Imagen1 = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        PtBoxPerfil.Image = Imagen1
        origen = OpenFileDialog1.FileName
        extensionimagen = System.IO.Path.GetExtension(origen)
        TxtRuta.Text = origen
    End Sub

    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text)
        If ComprobacionExistencia(Libreria.TodoEnMayuscula(TxtNombre.Text)) = True Then
            MsgBox(TxtNombre.Text + " ya esta registrado ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            TxtNombre.Focus()
            Exit Sub
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

    Private Sub BtnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCambiar.Click
        If PtBoxPerfil.Image IsNot Nothing Then
            PtBoxPerfil.Image = Nothing
            TxtRuta.Text = Nothing
        Else
            MsgBox("No hay imagen para cambiar", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End If
    End Sub

    Private Sub BtnAgregarAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAño.Click
        If CInt(TxtAños.Text) >= 17 And CInt(TxtAños.Text) < 20 Then
            TxtAños.Text = CInt(TxtAños.Text) + 1
        Else
            MsgBox("Supera el rango permitido ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Rango Maximo")
        End If
    End Sub

    Private Sub BtnQuitarAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarAño.Click
        If CInt(TxtAños.Text) > 17 Then
            TxtAños.Text = CInt(TxtAños.Text) - 1
        Else
            MsgBox("Supera el rango permitido", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Rango Minimo")
        End If
    End Sub

    Private Sub TxtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPrecio.LostFocus
        If TxtPrecio.TextLength > 0 Then
        If InStr(TxtPrecio.Text, ",") = False Then
                MsgBox("Ingrese una Coma en el Campo Precio")
            TxtPrecio.Focus()
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        mostrarTodoConConInnerJoint()
    End Sub

    Private Sub TxtISBN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtISBN.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtPrecio.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtISBN_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtISBN.LostFocus
        If TxtISBN.TextLength > 0 Then
            If TxtISBN.TextLength < 8 Then
                TxtISBN.BackColor = Color.Red
                MsgBox("Ingrese los 8 caracteres correspondientes al ISBN del Libro ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                TxtISBN.Focus()
                Exit Sub
            ElseIf ComprobacionExistenciaISBN(CInt(TxtISBN.Text)) = True Then
                TxtISBN.BackColor = Color.Red
                MsgBox("El ISBN ingresado ya esta Registrado ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                TxtISBN.Focus()
                Exit Sub
            ElseIf TxtISBN.TextLength = 8 Then
                TxtISBN.BackColor = Color.LemonChiffon
                Exit Sub
            ElseIf ComprobacionExistenciaISBN(CInt(TxtISBN.Text)) = False Then
                TxtISBN.BackColor = Color.LemonChiffon
                Exit Sub
            End If
        End If
    End Sub
    Function ComprobacionExistenciaISBN(ByVal p_NroLibro As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE ISBN = '" & p_NroLibro & "' AND estado = 1"
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

    Private Sub BtnLimpiarCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarCampos.Click
        If Libreria.vacioLibros() = True Then
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea Limpiar todos los Campos? ", MsgBoxStyle.Question + MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Limpiar Campos")
            If ask = 1 Then
                limpiarCampos()
            End If
        End If
    End Sub

    Private Sub BtnAyudaAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAyudaAutor.Click
        ABMAutor.RbtEliminar.Visible = False
        ABMAutor.RbtInsertar.Visible = False
        ABMAutor.RbtModificar.Visible = False
        ABMAutor.RbtModificarEstado.Visible = False
        ABMAutor.LblEdad.Visible = False
        ABMAutor.LblEstado.Visible = False
        ABMAutor.LblNombre.Visible = False
        ABMAutor.LblNroAutor.Visible = False
        ABMAutor.LblNroLibro.Visible = False
        ABMAutor.CboEstado.Visible = False
        ABMAutor.TxtEdad.Visible = False
        ABMAutor.TxtNombre.Visible = False
        ABMAutor.TxtNroAutor.Visible = False
        ABMAutor.BtnActualizar.Visible = False
        ABMAutor.BtnCancelar.Visible = False
        ABMAutor.BtnEliminar.Visible = False
        ABMAutor.BtnGuardar.Visible = False
        ABMAutor.BtnModificar.Visible = False
        ABMAutor.BtnModificarEstado.Visible = False
        ABMAutor.BtnAgregarAutor.Visible = True
        ABMAutor.StartPosition=FormStartPosition.CenterScreen
        ABMAutor.Size = New Point(700, 500)
        ABMAutor.MaximumSize = New Point(600, 500)
        ABMAutor.MinimumSize = New Point(600, 500)
        ABMAutor.DtgABMCategoria.Size = New Point(600, 400)
        ABMAutor.BtnCancelarAutor.Visible = True
        ABMAutor.BtnCancelarAutor.Location = New Point(350, 420)
        ABMAutor.DtgABMCategoria.Location = New Point(2, 10)
        ABMAutor.BtnAgregarAutor.Location = New Point(125, 420)
        ABMAutor.ShowDialog()
    End Sub

    Private Sub BtnAyudaAutor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAyudaAutor1.Click
        ABMAutor.RbtEliminar.Visible = False
        ABMAutor.RbtInsertar.Visible = False
        ABMAutor.RbtModificar.Visible = False
        ABMAutor.RbtModificarEstado.Visible = False
        ABMAutor.LblEdad.Visible = False
        ABMAutor.LblEstado.Visible = False
        ABMAutor.LblNombre.Visible = False
        ABMAutor.LblNroAutor.Visible = False
        ABMAutor.LblNroLibro.Visible = False
        ABMAutor.CboEstado.Visible = False
        ABMAutor.TxtEdad.Visible = False
        ABMAutor.TxtNombre.Visible = False
        ABMAutor.TxtNroAutor.Visible = False
        ABMAutor.BtnActualizar.Visible = False
        ABMAutor.BtnCancelar.Visible = False
        ABMAutor.BtnEliminar.Visible = False
        ABMAutor.BtnGuardar.Visible = False
        ABMAutor.BtnModificar.Visible = False
        ABMAutor.BtnModificarEstado.Visible = False
        ABMAutor.BtnAgregarAutor1.Visible = True
        ABMAutor.StartPosition = FormStartPosition.CenterScreen
        ABMAutor.Size = New Point(700, 500)
        ABMAutor.MaximumSize = New Point(600, 500)
        ABMAutor.MinimumSize = New Point(600, 500)
        ABMAutor.DtgABMCategoria.Size = New Point(600, 400)
        ABMAutor.BtnCancelarAutor1.Visible = True
        ABMAutor.BtnCancelarAutor1.Location = New Point(350, 420)
        ABMAutor.DtgABMCategoria.Location = New Point(2, 10)
        ABMAutor.BtnAgregarAutor1.Location = New Point(125, 420)
        ABMAutor.ShowDialog()
    End Sub

    Private Sub BtnAyudaAutor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAyudaAutor2.Click
        ABMAutor.RbtEliminar.Visible = False
        ABMAutor.RbtInsertar.Visible = False
        ABMAutor.RbtModificar.Visible = False
        ABMAutor.RbtModificarEstado.Visible = False
        ABMAutor.LblEdad.Visible = False
        ABMAutor.LblEstado.Visible = False
        ABMAutor.LblNombre.Visible = False
        ABMAutor.LblNroAutor.Visible = False
        ABMAutor.LblNroLibro.Visible = False
        ABMAutor.CboEstado.Visible = False
        ABMAutor.TxtEdad.Visible = False
        ABMAutor.TxtNombre.Visible = False
        ABMAutor.TxtNroAutor.Visible = False
        ABMAutor.BtnActualizar.Visible = False
        ABMAutor.BtnCancelar.Visible = False
        ABMAutor.BtnEliminar.Visible = False
        ABMAutor.BtnGuardar.Visible = False
        ABMAutor.BtnModificar.Visible = False
        ABMAutor.BtnModificarEstado.Visible = False
        ABMAutor.BtnAgregarAutor2.Visible = True
        ABMAutor.StartPosition = FormStartPosition.CenterScreen
        ABMAutor.Size = New Point(700, 500)
        ABMAutor.MaximumSize = New Point(600, 500)
        ABMAutor.MinimumSize = New Point(600, 500)
        ABMAutor.DtgABMCategoria.Size = New Point(600, 400)
        ABMAutor.BtnCancelarAutor2.Visible = True
        ABMAutor.BtnCancelarAutor2.Location = New Point(350, 420)
        ABMAutor.DtgABMCategoria.Location = New Point(2, 10)
        ABMAutor.BtnAgregarAutor2.Location = New Point(125, 420)
        ABMAutor.ShowDialog()

    End Sub

    Private Sub BtnLimpiarAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarAutor.Click
        If TxtAutor.TextLength = 0 Or TxtNroDeAutor.TextLength = 0 Then
            MsgBox("El Campo esta vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea Limpiar el campo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Limpiar")
            If ask = 6 Then
                TxtAutor.Clear()
                TxtNroDeAutor.Clear()
                MsgBox("El Campo se limpio correctamente ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Limpiar")
            End If
        End If
    End Sub

    Private Sub BtnLimpiarAutor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarAutor1.Click
        If TxtAutor1.TextLength = 0 Or TxtNroDeAutor1.TextLength = 0 Then
            MsgBox("El Campo esta vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea Limpiar el campo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Limpiar")
            If ask = 6 Then
                TxtAutor1.Clear()
                TxtNroDeAutor1.Clear()
                MsgBox("El Campo se limpio correctamente ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Limpiar")
            End If
        End If
    End Sub

    Private Sub BtnLimpiarAutor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiarAutor2.Click
        If TxtAutor2.TextLength = 0 Or TxtNroDeAutor2.TextLength = 0 Then
            MsgBox("El Campo esta vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("¿Desea Limpiar el campo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Limpiar")
            If ask = 6 Then
                TxtAutor2.Clear()
                TxtNroDeAutor2.Clear()
                MsgBox("El Campo se limpio correctamente ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Limpiar")
            End If
        End If
    End Sub
End Class
