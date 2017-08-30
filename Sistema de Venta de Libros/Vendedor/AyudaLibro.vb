Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class AyudaLibro

    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader

    Private Sub AyudaLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.FillByLibrosDeAlta(Me.DataSet1.Libros, 1)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnTomar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTomar.Click
        Try
            Ingresar_Compras.TxtNroLibro.Text = DtgAyudaLibro.SelectedRows(0).Cells(0).Value.ToString()
            Me.Close()
        Catch ex As Exception
            MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Me.LibrosTableAdapter.FillByLibrosDeAlta(Me.DataSet1.Libros, 1)
    End Sub

    Private Sub TxtBusquedaPorCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorCategoria.KeyPress
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
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointCategoria(nombre)
                If DtgAyudaLibro.Rows.Count = 0 Then
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
        Me.DtgAyudaLibro.DataSource = dataset2.Tables(0)
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
        Me.DtgAyudaLibro.DataSource = dataset2.Tables(0)
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
                If DtgAyudaLibro.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub
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
        Me.DtgAyudaLibro.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtNumeroDeLibro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroDeLibro.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumeroDeLibro.Focus()
        Else
            Libreria.soloNumero(e)
        End If
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
                If DtgAyudaLibro.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodoConConInnerJoint()
                End If
            End If
        End If
    End Sub
    Private Sub consultaConInnerJoint(ByVal p_NroLibro As String)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Libros.ISBN,nombre AS NOMBRE,Categorias.descripcion as CATEGORIA,Libros.precio AS PRECIO,Autores.nombreAutor as AUTOR,Autores1.nombreAutor as AUTOR1,Autores2.nombreAutor as AUTOR2,Estado.descripcion as ESTADO,Libros.cantidad AS CANTIDAD,Libros.imagen AS IMAGEN,Libros.año AS AÑO,Libros.fecha_alta FROM Libros INNER JOIN Categorias ON Libros.categoria = Categorias.cod_categoria INNER JOIN Estado ON Libros.estado = Estado.cod_estado INNER JOIN Autores ON Libros.autor = Autores.nro_autor INNER JOIN Autores as Autores1 ON Libros.autor1 = Autores1.nro_autor INNER JOIN Autores as Autores2 ON Libros.autor2 = Autores2.nro_autor WHERE Libros.ISBN Like '" + "%" + p_NroLibro + "%" + "' AND Libros.estado = 1 and Libros.cantidad > 0;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        DtgAyudaLibro.ClearSelection()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgAyudaLibro.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Nro de Libro"
                TxtBsquedaPorNombre.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtNumeroDeLibro.Visible = True
                'limpiar campos
                TxtBsquedaPorNombre.Clear()
                TxtBusquedaPorCategoria.Clear()
                TxtNumeroDeLibro.Clear()
                mostrarTodoConConInnerJoint()
            Case "Nombre"
                TxtNumeroDeLibro.Visible = False
                TxtBusquedaPorCategoria.Visible = False
                TxtBsquedaPorNombre.Visible = True
                TxtBsquedaPorNombre.Clear()
                TxtBusquedaPorCategoria.Clear()
                TxtNumeroDeLibro.Clear()
                mostrarTodoConConInnerJoint()
            Case "Categoria"
                TxtBsquedaPorNombre.Visible = False
                TxtNumeroDeLibro.Visible = False
                TxtBusquedaPorCategoria.Visible = True
                TxtBsquedaPorNombre.Clear()
                TxtBusquedaPorCategoria.Clear()
                TxtNumeroDeLibro.Clear()
                mostrarTodoConConInnerJoint()
            Case Else
                MsgBox("No seleciono nada")
        End Select
    End Sub
End Class