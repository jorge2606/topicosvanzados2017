Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ABMSexo
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
        buscar = "SELECT * FROM Sexo WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Private Sub ABMSexo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        '  Me.SexoTableAdapter.Fill(Me.DataSet1.Sexo)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        ' Me.SexoTableAdapter.Fill(Me.DataSet1.Sexo)
        DtgABMCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BtnEliminar.Enabled = False
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
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
        buscarw = "SELECT cod_sexo,Sexo.descripcion,Estado.descripcion as Estado FROM Sexo INNER JOIN Estado ON Sexo.estado = Estado.cod_estado;"
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
    Function ComprobacionEstado(ByVal p_Sexo As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Sexo WHERE cod_sexo = '" & p_Sexo & "'"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            estado = reader.Item(2)
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
                    actualizar = "UPDATE Sexo SET estado=@estado WHERE cod_sexo = @cod_sexo"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@cod_sexo", nro)
                    cmdActualizar.Parameters.AddWithValue("@estado", 2)
                    ' Me.DtgABMCategoria.Fill(Me.DataSet1.Libros)
                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    MsgBox("El Sexo fue Eliminado Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                    miConexion.Close()
                End If
                consultaConInnerJoint()
            Else
                MsgBox("El Sexo ya fue Eliminado ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        TxtCategoria.Visible = False
        LblDescripcion.Visible = False
        TxtCodigo.Visible = True
        LblCodigo.Visible = True
        BtnEliminar.Enabled = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        TxtCategoria.Clear()
        TxtCodigo.Clear()
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
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If TxtCategoria.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(Me.TxtCategoria.Text) = True Then
                MsgBox("El Sexo " + Libreria.PrimeraLetraEnMayuscula(TxtCategoria.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else

                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim insertar As String
                insertar = "INSERT INTO  Sexo(descripcion,estado)" & "VALUES" & " (@descripcion,@estado) "
                Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                cmdInsertar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(Me.TxtCategoria.Text))
                cmdInsertar.Parameters.AddWithValue("@estado", CboEstado.SelectedValue)
                Me.SexoTableAdapter.Fill(Me.DataSet1.Sexo)
                Try
                    cmdInsertar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                'Codigo para que me muestre al instante
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If TxtCategoria.TextLength = 0 Or TxtCodigo.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(TxtCodigo.Text)) = 1 Then
                If ComprobacionExistencia(Me.TxtCategoria.Text) = True Then
                    MsgBox("El Sexo " + Libreria.PrimeraLetraEnMayuscula(TxtCategoria.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                Else
                    If Libreria.deseaModificar() = 6 Then
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
                        actualizar = "UPDATE Sexo SET descripcion = @descripcion WHERE cod_sexo = @cod_sexo"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@cod_sexo", nro)
                        cmdActualizar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(Me.TxtCategoria.Text))

                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)

                            Exit Sub
                            MsgBox("La modificación se realizo con exito", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Modificación")
                        End Try
                    End If
                End If
            Else
                MsgBox("El Sexo ya fue Eliminado ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        Me.Close()
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
            Libreria.soloLetras(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        consultaConInnerJoint()
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        TxtCategoria.Visible = False
        LblDescripcion.Visible = False
        TxtCodigo.Visible = True
        LblCodigo.Visible = True
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Visible = True
        BtnModificarEstado.Enabled = True
        TxtCategoria.Clear()
        TxtCodigo.Clear()
        CboEstado.Visible = True
        LblEstado.Visible = True
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
                actualizar = "UPDATE Sexo SET estado = @estado WHERE cod_sexo = @cod_sexo"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@cod_sexo", nro)
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
    End Sub
End Class