Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ABMLocalidadvb
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter

    Function ComprobacionExistencia(ByVal p_descripcion As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Localidades WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Private Sub ABMLocalidadvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.DataSet1.Localidades)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.DataSet1.Provincias)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.DataSet1.Localidades)
        DtgABMCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        CboEstado.Visible = False
        BtnModificarEstado.Enabled = False
        consultaConInnerJoint()
    End Sub

    Private Sub consultaConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT cod_localidad,Provincias.descripcion as Provincia,Localidades.descripcion,Estado.descripcion as Estado FROM Localidades INNER JOIN Estado ON Localidades.estado = Estado.cod_estado INNER JOIN Provincias ON Localidades.cod_provincia = Provincias.cod_Provincia;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgABMCategoria.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function ComprobacionEstado(ByVal p_Localidad As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Localidades WHERE cod_localidad = '" & p_Localidad & "'"
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
        If TxtCodigo.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtCodigo.Text)) = 1 Then
                If Libreria.deseaEliminar() = 6 Then
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(TxtCodigo.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim actualizar As String
                    actualizar = "UPDATE Localidades SET estado=@estado WHERE cod_localidad = @cod_localidad"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@cod_localidad", nro)
                    cmdActualizar.Parameters.AddWithValue("@estado", 2)
                    ' Me.DtgABMCategoria.Fill(Me.DataSet1.Libros)
                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    consultaConInnerJoint()
                    MsgBox("La Localidad fue Eliminada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                    miConexion.Close()
                End If
            Else
                MsgBox("La Localidad ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtCategoria.TextLength = 0 Or cboProvincias.SelectedValue = Nothing Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(TxtCategoria.Text) = True Then
                MsgBox("Localidad " + Libreria.PrimeraLetraEnMayuscula(TxtCategoria.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim prov As Integer
                Try
                    prov = CInt(cboProvincias.SelectedValue)
                Catch ex As Exception
                    MsgBox("Ingreso un Valor incorrecto en el campo Codigo de Provincia", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                    Exit Sub
                End Try
                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea Insertar Localidad?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                If MsgBoxResult.Yes = ask Then
                    Dim insertar As String
                    insertar = "INSERT INTO  Localidades(cod_provincia,descripcion,estado)" & "VALUES" & " (@cod_provincia,@descripcion,@estado) "
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    cmdInsertar.Parameters.AddWithValue("@cod_provincia", prov)
                    cmdInsertar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(Me.TxtCategoria.Text))
                    cmdInsertar.Parameters.AddWithValue("@estado", CboEstado.SelectedValue)
                    Me.LocalidadesTableAdapter.Fill(Me.DataSet1.Localidades)
                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtCategoria.TextLength = 0 Or TxtCodigo.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(Me.TxtCategoria.Text) = True Then
                MsgBox("Localidad " + Libreria.PrimeraLetraEnMayuscula(TxtCategoria.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                If Libreria.deseaModificar() = 6 Then
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Dim prov As Integer
                    Try
                        nro = CInt(TxtCodigo.Text)
                        prov = CInt(cboProvincias.SelectedValue)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo Localidad", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    ' Dim ask As MsgBoxResult
                    '  ask = MsgBox("¿Desea Modificar Localidad?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Modificar")
                    '  MsgBox(ask)
                    ' If MsgBoxResult.Yes = ask Then
                    Dim actualizar As String
                    actualizar = "UPDATE Localidades SET cod_provincia=@cod_provincia, descripcion = @descripcion WHERE cod_localidad = @cod_localidad"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@cod_localidad", nro)
                    cmdActualizar.Parameters.AddWithValue("@cod_provincia", prov)
                    cmdActualizar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(Me.TxtCategoria.Text))

                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    MsgBox("La Localidad fue Modificada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificado")
                End If
            End If
            End If
        ' End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        Me.Close()
    End Sub

    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        TxtCategoria.Visible = False
        LblDescripcion.Visible = False
        TxtCodigo.Visible = True
        LblCodigo.Visible = True
        BtnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        LblProvincias.Visible = False
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        cboProvincias.Visible = False
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificar.CheckedChanged
        TxtCategoria.Visible = True
        LblDescripcion.Visible = True
        TxtCodigo.Visible = True
        LblCodigo.Visible = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        cboProvincias.Visible = True
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtInsertar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtInsertar.CheckedChanged
        TxtCategoria.Visible = True
        LblDescripcion.Visible = True
        TxtCodigo.Visible = False
        LblCodigo.Visible = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        cboProvincias.Visible = True
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtCodigo.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCategoria.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtCategoria.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        consultaConInnerJoint()
    End Sub

    Private Sub BtnModificarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEstado.Click
        If TxtCodigo.TextLength = 0 Or CboEstado.Text = "" Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If Libreria.deseaModificar() = 6 Then
                Dim nro As Integer
                Try
                    nro = CInt(TxtCodigo.Text)
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
                actualizar = "UPDATE Localidades SET estado = @estado WHERE cod_localidad = @cod_localidad"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@cod_localidad", nro)
                cmdActualizar.Parameters.AddWithValue("@estado", CInt(CboEstado.SelectedValue))
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                MsgBox("Los datos fueron modificados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Éxito")
                consultaConInnerJoint()
            End If
        End If
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        TxtCategoria.Visible = False
        LblDescripcion.Visible = False
        TxtCodigo.Visible = True
        LblCodigo.Visible = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Enabled = True
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        cboProvincias.Visible = False
        CboEstado.Visible = True
        LblEstado.Visible = True
    End Sub
End Class