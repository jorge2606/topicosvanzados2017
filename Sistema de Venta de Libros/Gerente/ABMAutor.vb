Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ABMAutor
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miAdaptador1 As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet

    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        TxtNombre.Visible = False
        TxtEdad.Visible = False
        TxtNombre.Visible = False
        LblNombre.Visible = False
        ' LblNroLibro.Visible = True
        LblNroAutor.Visible = True
        TxtNroAutor.Visible = True
        BtnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        LblEdad.Visible = False
        BtnModificar.Enabled = False
        TxtNroAutor.Clear()
        TxtNombre.Clear()
        TxtEdad.Clear()
        TxtNroAutor.Clear()
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificar.CheckedChanged
        TxtNroAutor.Visible = True
        TxtNombre.Visible = True
        TxtNroAutor.Visible = True
        LblNroAutor.Visible = True
        LblNroLibro.Visible = False
        LblNombre.Visible = True
        LblEdad.Visible = True
        TxtEdad.Visible = True
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        TxtNroAutor.Clear()
        TxtNombre.Clear()
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnModificarEstado.Enabled = False
    End Sub

    Private Sub RbtInsertar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtInsertar.CheckedChanged
        'TxtNroLibro.Visible = True
        LblNroAutor.Visible = False
        TxtNombre.Visible = True
        TxtEdad.Visible = True
        LblNombre.Visible = True
        'LblNroLibro.Visible = True
        LblEdad.Visible = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        TxtNroAutor.Clear()
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        CboEstado.Visible = False
        LblEstado.Visible = False
        BtnModificarEstado.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtEdad.TextLength = 0 Or TxtNombre.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(Me.TxtNombre.Text) = True Then
                MsgBox("El Autor " + Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                End Try
                'guardar
                Dim edad As Integer
                ' Dim nro As Integer
                Try
                    edad = CInt(TxtEdad.Text)
                    ' nro = CInt(TxtNroAutor.Text)
                Catch ex As Exception
                    MsgBox("Ingreso un Valor No valido en el/los campos Edad y Nro de Libro", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea Insertar Autor?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                If MsgBoxResult.Yes = ask Then
                    Dim insertar As String
                    insertar = "INSERT INTO Autores(nombreAutor,Edad,estado)" & "VALUES" & " (@nombreAutor,@Edad,@estado) "
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    cmdInsertar.Parameters.AddWithValue("@nombreAutor", Libreria.TodoEnMayuscula(TxtNombre.Text))
                    cmdInsertar.Parameters.AddWithValue("@Edad", edad)
                    cmdInsertar.Parameters.AddWithValue("@estado", 1)
                    ' Me.AutoresTableAdapter.Fill(Me.DataSet1.Autores)
                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    consultaConInnerJoint()
                    MsgBox("El Autor fue Insertada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Insertado")
                    TxtEdad.Clear()
                    TxtNombre.Clear()
                End If
            End If
        End If
    End Sub

    Function ComprobacionExistencia(ByVal p_descripcion As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Autores WHERE nombreAutor = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Function ComprobacionEstado(ByVal p_Autor As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Autores WHERE nro_autor = '" & p_Autor & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            estado = reader.Item(3)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return estado
    End Function
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If TxtNroAutor.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtNroAutor.Text)) = 1 Then
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox("Error al intentar abrir la base de datos")
                End Try
                Dim nro As Integer
                Try
                    nro = CInt(TxtNroAutor.Text)
                Catch ex As Exception
                    MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea Eliminar Autor?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                If MsgBoxResult.Yes = ask Then
                    Dim actualizar As String
                    actualizar = "UPDATE Autores SET estado=@estado WHERE nro_autor = @nro_autor"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@nro_autor", nro)
                    cmdActualizar.Parameters.AddWithValue("@estado", 2)
                    ' Me.DtgABMCategoria.Fill(Me.DataSet1.Libros)
                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    MsgBox("El Autor fue Eliminado Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                    consultaConInnerJoint()
                    miConexion.Close()
                End If
            Else
                MsgBox("El Autor ya fue Eliminado ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtEdad.TextLength = 0 Or TxtNombre.TextLength = 0 Or TxtNroAutor.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtNroAutor.Text)) = 1 Then
                If ComprobacionExistencia(CInt(Me.TxtNombre.Text)) = True Then
                    MsgBox("El Autor " + Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                Else
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox("Error al intentar abrir la base de datos")
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(TxtNroAutor.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim ask As MsgBoxResult
                    ask = MsgBox("¿Desea Modificar Autor?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                    If MsgBoxResult.Yes = ask Then
                        Dim actualizar As String
                        actualizar = "UPDATE Autores SET nombreAutor = @nombreAutor, Edad=@Edad  WHERE nro_autor = @nro_autor"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@nro_autor", nro)
                        cmdActualizar.Parameters.AddWithValue("@Edad", CInt(TxtEdad.Text))
                        cmdActualizar.Parameters.AddWithValue("@nombreAutor", Libreria.TodoEnMayuscula(TxtNombre.Text))
                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        consultaConInnerJoint()
                    End If
                End If
            Else
                MsgBox("La Categoria Ya Fue Eliminada", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Error")
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        Me.Close()
    End Sub
    Private Sub consultaConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT nro_autor,nombreAutor,Edad,Estado.descripcion as Estado FROM Autores INNER JOIN Estado ON Autores.estado = Estado.cod_estado;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgABMCategoria.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub ABMAutor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        Me.AutoresTableAdapter.Fill(Me.DataSet1.Autores)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        consultaConInnerJoint()
        'TODO: esta línea de código carga datos en la tabla 'DataSet11.Autores' Puede moverla o quitarla según sea necesario.
        'Me.AutoresTableAdapter.Fill(Me.DataSet11.Autores)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Autores' Puede moverla o quitarla según sea necesario.
        DtgABMCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        LblNroAutor.Visible = False
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNombre.Focus()
        Else
            Libreria.soloLetrasSinEspacios(e)
        End If
    End Sub


    Private Sub TxtNroLibro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNroAutor.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNroAutor.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEdad.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtEdad.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Me.AutoresTableAdapter.Fill(Me.DataSet1.Autores)
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        TxtNombre.Visible = False
        LblNombre.Visible = False
        TxtEdad.Visible = False
        LblEdad.Visible = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Visible = True
        BtnModificarEstado.Enabled = True
        TxtNroAutor.Clear()
        TxtNroAutor.Visible = True
        LblNroAutor.Visible = True
        CboEstado.Visible = True
        LblEstado.Visible = True
    End Sub

    Private Sub BtnModificarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEstado.Click
        If TxtNroAutor.TextLength = 0 Or CboEstado.Text = "" Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If Libreria.deseaModificar() = 6 Then
                Dim nro As Integer
                Try
                    nro = CInt(TxtNroAutor.Text)
                Catch ex As Exception
                    MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                End Try
                Dim actualizar As String
                actualizar = "UPDATE Autores SET estado = @estado WHERE nro_autor = @nro_autor"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@nro_autor", nro)
                cmdActualizar.Parameters.AddWithValue("@estado", CInt(CboEstado.SelectedValue))
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                MsgBox("Los datos fueron modificados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Éxito")
            End If
        End If
        consultaConInnerJoint()
    End Sub

    Private Sub BtnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultar_Libros.ShowDialog()
    End Sub

    Private Sub BtnAgregarAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAutor.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Desea Agregar nuevo Autor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Autor")
        If ask = 6 Then
            Try
                Form1.TxtNroDeAutor.Text = DtgABMCategoria.SelectedRows(0).Cells(2).Value.ToString
                Form1.TxtAutor.Text = DtgABMCategoria.SelectedRows(0).Cells(0).Value.ToString
            Catch ex As Exception
                MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancelarAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarAutor.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        If Form1.TxtNroDeAutor1.Text = Nothing And Form1.TxtAutor1.Text = Nothing Then
            Try
                Form1.TxtNroDeAutor.Text = Nothing
                Form1.TxtAutor.Text = Nothing
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnAgregarAutor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAutor2.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Desea Agregar nuevo Autor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Autor")
        If ask = 6 Then
            Try
                Form1.TxtNroDeAutor2.Text = DtgABMCategoria.SelectedRows(0).Cells(2).Value.ToString
                Form1.TxtAutor2.Text = DtgABMCategoria.SelectedRows(0).Cells(0).Value.ToString
            Catch ex As Exception
                MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub BtnAgregarAutor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarAutor1.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Desea Agregar nuevo Autor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Autor")
        If ask = 6 Then
            Try
                Form1.TxtNroDeAutor1.Text = DtgABMCategoria.SelectedRows(0).Cells(2).Value.ToString
                Form1.TxtAutor1.Text = DtgABMCategoria.SelectedRows(0).Cells(0).Value.ToString
            Catch ex As Exception
                MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancelarAutor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarAutor2.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        If Form1.TxtNroDeAutor1.Text = Nothing And Form1.TxtAutor1.Text = Nothing Then
            Try
                Form1.TxtNroDeAutor2.Text = Nothing
                Form1.TxtAutor2.Text = Nothing
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancelarAutor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarAutor1.Click
        TxtEdad.Clear()
        TxtNombre.Clear()
        TxtNroAutor.Clear()
        If Form1.TxtNroDeAutor1.Text = Nothing And Form1.TxtAutor1.Text = Nothing Then
            Try
                Form1.TxtNroDeAutor1.Text = Nothing
                Form1.TxtAutor1.Text = Nothing
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub
End Class