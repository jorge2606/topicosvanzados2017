Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Consultar_Libros
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader

    Private Sub TxtNumeroDeLibro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroDeLibro.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumeroDeLibro.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub Consultar_Libros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LibrosTableAdapter.FillByLibros(Me.DataSet1.Libros, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Libros' Puede moverla o quitarla según sea necesario.
        'Me.LibrosTableAdapter.Fill(Me.DataSet1.Libros)
        DtgConsultarLibros.RowTemplate.Height = 80
        ' Me.DtgConsultarLibros.Columns(4).Visible = False
        TxtBsquedaPorNombre.Visible = False
        TxtBusquedaPorCategoria.Visible = False
        TxtNumeroDeLibro.Visible = False
        ' BtnBusquedaPorCategoria.Visible = False
        'btnBusquedaPorNombre.Visible = False
        'BtnConsultar.Visible = False
        mostrarTodoConConInnerJoint()
        CboBusqPorTipo.Text = "Nombre"
    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

    
    Public Sub DtgRegistrarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgConsultarLibros.CellContentClick
        ' Dim cell As DataGridViewButtonCell = TryCast(DtgConsultarLibros.CurrentCell, DataGridViewButtonCell)
        '   If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
        'Dim bc As DataGridViewButtonColumn = TryCast(DtgConsultarLibros.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
        '  If bc IsNot Nothing Then
        'Dim s As String = Convert.ToString(cell.Value)
        '  Select Case bc.Name
        '      Case "Eliminar"
        '   Eliminar_Libros.ShowDialog()
        '       Case "Modificar"
        '   Modificar_Libros.CboBusqPorTipo.Visible = False
        '   Modificar_Libros.TxtBusqueda.Visible = False
        '   Modificar_Libros.BtnConsultar.Visible = False
        '  Modificar_Libros.ShowDialog()
        '   Exit Select
        '   End Select
        '
        '  End If

        '   End If
    End Sub

    Private Sub TxtNumeroDeLibro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroDeLibro.TextChanged
        If TxtNumeroDeLibro.TextLength = 0 Then
            mostrarTodoConConInnerJoint()
        Else
            Dim NRO As String
            If TxtNumeroDeLibro.TextLength > 0 Then
                Try
                    NRO = TxtNumeroDeLibro.Text
                Catch ex As Exception
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJoint(NRO)
                If DtgConsultarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
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
        buscar = "SELECT * FROM Libros WHERE ISBN = '" & p_NroLibro & "' and estado = 1"
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
        Dim buscar As String = "SELECT Libros.ISBN,nombre AS NOMBRE,Categorias.descripcion as CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor as AUTOR,Autores1.nombreAutor as AUTOR1,Autores2.nombreAutor as AUTOR2,Estado.descripcion as ESTADO,Libros.cantidad AS CANTIDAD,Libros.imagen AS IMAGEN,Libros.año AS AÑO,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.ISBN Like '" + "%" + p_NroLibro + "%" + "' AND Libros.estado = 1 and Libros.cantidad > 0;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        DtgConsultarLibros.ClearSelection()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarTodoConConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre AS NOMBRE,Categorias.descripcion as CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor as AUTOR,Autores1.nombreAutor as AUTOR1,Autores2.nombreAutor as AUTOR2,Estado.descripcion as ESTADO,Libros.cantidad AS CANTIDAD,Libros.imagen AS IMAGEN,Libros.año AS AÑO,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor where Libros.estado= 1 and Libros.cantidad > 0;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtBsquedaPorNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBsquedaPorNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBsquedaPorNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub TxtBusquedaPorCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorCategoria.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBsquedaPorNombre.Focus()
        Else
            Libreria.BusquedaPorNombre(e)
        End If
    End Sub

    Function ComprobacionExistenciaPorNombre(ByVal p_nombre As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE nombre like 'p_nombre%' and estado = 1"
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
        Dim buscar As String = "SELECT Libros.ISBN,nombre AS NOMBRE ,CAT.descripcion CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor AS AUTOR,Autores1.nombreAutor AS AUTOR1,Autores2.nombreAutor AS AUTOR2,EST.descripcion AS ESTADO,Libros.cantidad AS CANTIDAD,Libros.fecha_alta,Libros.año AS AÑO FROM Libros INNER JOIN Categorias AS CAT ON Libros.categoria = CAT.cod_categoria INNER JOIN Estado AS EST ON Libros.estado = EST.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor  WHERE Libros.nombre like '" + "%" + p_nombre + "%" + "'  and Libros.estado= 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBusquedaPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged

        Select Case CboBusqPorTipo.SelectedItem
            Case "Nro de Libro"
                TxtBsquedaPorNombre.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtNumeroDeLibro.Visible = True
                '  BtnBusquedaPorCategoria.Visible = False
                ' btnBusquedaPorNombre.Visible = False
                'BtnConsultar.Visible = True
                mostrarTodoConConInnerJoint()
            Case "Nombre"
                TxtNumeroDeLibro.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtBsquedaPorNombre.Visible = True
                'BtnBusquedaPorCategoria.Visible = False
                'btnBusquedaPorNombre.Visible = True
                'BtnConsultar.Visible = False
                mostrarTodoConConInnerJoint()
            Case "Categoria"
                TxtBsquedaPorNombre.Visible = False
                TxtNumeroDeLibro.Visible = False
                TxtBusquedaPorCategoria.Visible = True
                ' BtnBusquedaPorCategoria.Visible = True
                'btnBusquedaPorNombre.Visible = False
                'BtnConsultar.Visible = False
                mostrarTodoConConInnerJoint()
            Case Else
                MsgBox("No seleciono nada")
        End Select
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
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                ' dataset2.Clear()
                consultaConInnerJointNombre(nombre)
                If DtgConsultarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub





    Function nroDeCategoria(ByVal p_categoria As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Categorias WHERE descripcion = '" & p_categoria & "' and estado = 1"
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
        nroDeCategoria1 = nroDeCategoria(p_categoria)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria WHERE Categorias.descripcion = '" & p_categoria & "';"
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

    Private Sub BtnBusquedaPorCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointCategoria(nombre)
                If DtgConsultarLibros.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Categoria no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub
    Private Sub consultaConInnerJointCategoria(ByVal p_categoria As String)
        Dim buscarConinnerJoint As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarConinnerJoint = "SELECT Libros.ISBN,nombre AS NOMBRE ,CAT.descripcion CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor AS AUTOR,Autores1.nombreAutor AS AUTOR1,Autores2.nombreAutor AS AUTOR2,EST.descripcion AS ESTADO,Libros.cantidad AS CANTIDAD,Libros.fecha_alta,Libros.año AS AÑO FROM Libros INNER JOIN Categorias AS CAT ON Libros.categoria = CAT.cod_categoria INNER JOIN Estado AS EST ON Libros.estado = EST.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor where CAT.descripcion Like'" + "%" + p_categoria + "%" + "' and Libros.cantidad > 0 and Libros.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarConinnerJoint, miConexion)
        dataset2.Clear()     
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarLibros.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
