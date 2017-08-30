Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ABMEmpresa
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Function ComprobacionExistenciaDireccion(ByVal p_descripcion As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empresa WHERE direccion = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Function ComprobacionExistencia(ByVal p_descripcion As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empresa WHERE nombre = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        TxtDireccion.Visible = False
        LblDireccion.Visible = False
        LblNumero.Visible = True
        TxtNumero.Visible = True
        TxtNombre.Visible = False
        LblNombre.Visible = False
        BtnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        TxtNumero.Enabled = True
        TxtDireccion.Clear()
        TxtNombre.Clear()
        TxtNumero.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificar.CheckedChanged
        TxtDireccion.Visible = True
        LblDireccion.Visible = True
        LblNumero.Visible = True
        TxtNumero.Visible = True
        TxtNombre.Visible = True
        LblNombre.Visible = True
        TxtNumero.Enabled = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        TxtDireccion.Clear()
        TxtNombre.Clear()
        TxtNumero.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtInsertar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtInsertar.CheckedChanged
        TxtDireccion.Visible = True
        LblDireccion.Visible = True
        LblNumero.Visible = False
        TxtNumero.Visible = False
        TxtNumero.Enabled = True
        TxtNombre.Visible = True
        LblNombre.Visible = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        TxtDireccion.Clear()
        TxtNombre.Clear()
        TxtNumero.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub
    Private Sub consultaConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Nro,nombre,Estado.descripcion as Estado,direccion FROM Empresa INNER JOIN Estado ON Empresa.estado = Estado.cod_estado;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgABMEmpresa.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function ComprobacionEstado(ByVal p_Empresa As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empresa WHERE Nro = '" & p_Empresa & "'"
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
        If TxtNumero.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtNumero.Text)) = 1 Then
                If Libreria.deseaEliminar() = 6 Then
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(TxtNumero.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim ask As MsgBoxResult
                    ask = MsgBox("¿Desea Eliminar Empresa?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Eliminar")
                    If MsgBoxResult.Yes = ask Then
                        Dim actualizar As String
                        actualizar = "UPDATE Empresa SET estado=@estado WHERE Nro = @Nro"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@Nro", nro)
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
                        MsgBox("La Empresa fue Eliminada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                        miConexion.Close()
                    End If
                End If
            Else
                MsgBox("La Empresa ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtDireccion.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(Me.TxtNombre.Text) = True Or ComprobacionExistenciaDireccion(TxtDireccion.Text) = True Then
                MsgBox("Empresa " + Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                End Try
                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea Insertar Empresa?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                If MsgBoxResult.Yes = ask Then
                    Dim insertar As String
                    insertar = "INSERT INTO  Empresa(nombre,direccion,estado)" & "VALUES" & " (@nombre,@direccion,@estado) "
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    cmdInsertar.Parameters.AddWithValue("@Nombre", Libreria.TodoEnMayuscula(Me.TxtNombre.Text))
                    cmdInsertar.Parameters.AddWithValue("@direccion", Libreria.TodoEnMayuscula(Me.TxtDireccion.Text))
                    cmdInsertar.Parameters.AddWithValue("@estado", CboEstado.SelectedValue)
                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    consultaConInnerJoint()
                    '  miConexion.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtDireccion.TextLength = 0 Or TxtNombre.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtNumero.Text)) = 1 Then
                If ComprobacionExistencia(Me.TxtNombre.Text) = True Or ComprobacionExistenciaDireccion(TxtDireccion.Text) = True Then
                    MsgBox("Empresa " + Libreria.PrimeraLetraEnMayuscula(TxtNombre.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                Else
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(TxtNumero.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim ask As MsgBoxResult
                    ask = MsgBox("¿Desea Modificar Empresa?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Modificar")
                    If MsgBoxResult.Yes = ask Then
                        Dim actualizar As String
                        actualizar = "UPDATE Empresa SET nombre = @nombre, direccion=@direccion WHERE Nro = @Nro"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@Nro", nro)
                        cmdActualizar.Parameters.AddWithValue("@nombre", Libreria.TodoEnMayuscula(Me.TxtNombre.Text))
                        cmdActualizar.Parameters.AddWithValue("@direccion", Libreria.TodoEnMayuscula(Me.TxtDireccion.Text))

                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                        End Try
                        MsgBox("La Empresa fue Modificada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificado")
                    End If
                End If
            Else
                MsgBox("La Empresa ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
            End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtDireccion.Clear()
        TxtNombre.Clear()
        TxtNumero.Clear()
        Me.Close()
    End Sub

    Private Sub ABMEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.DataSet1.Empresa)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.DataSet1.Empresa)
        DtgABMEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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
        consultaConInnerJoint()
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDireccion.Focus()
        Else
            Libreria.nombreDelLibro(e)
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

    Private Sub TxtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumero.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumero.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        consultaConInnerJoint()
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        LblNombre.Visible = False
        TxtNombre.Visible = False
        LblDireccion.Visible = False
        TxtDireccion.Visible = False
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = False
        LblNumero.Visible = True
        TxtNumero.Visible = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Visible = True
        BtnModificarEstado.Enabled = True
        TxtNumero.Clear()
        CboEstado.Visible = True
        LblEstado.Visible = True
        CboEstado.Visible = True
    End Sub

    Private Sub BtnModificarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEstado.Click
        If TxtNumero.TextLength = 0 Or CboEstado.Text = "" Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If Libreria.deseaModificar() = 6 Then
                Dim nro As Integer
                Try
                    nro = CInt(TxtNumero.Text)
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
                actualizar = "UPDATE Empresa SET estado = @estado WHERE Nro = @Nro"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@Nro", nro)
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

End Class