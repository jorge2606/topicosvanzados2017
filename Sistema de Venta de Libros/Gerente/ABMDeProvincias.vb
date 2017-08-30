Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ABMDeProvincias
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter


    Private Sub ABMDeProvincias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Estado' Puede moverla o quitarla según sea necesario.
        Me.EstadoTableAdapter.Fill(Me.DataSet1.Estado)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        'Me.ProvinciasTableAdapter.Fill(Me.DataSet1.Provincias)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        DtgProvincias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnAgregar.Enabled = False
        BtnQuitar.Enabled = False
        BtnModificar.Enabled = False
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
        consultaConInnerJoint()
    End Sub
    Private Sub consultaConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT cod_Provincia,Provincias.descripcion,Estado.descripcion as Estado FROM Provincias INNER JOIN Estado ON Provincias.estado = Estado.cod_estado;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgProvincias.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function ComprobacionExistencia(ByVal p_descripcion As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Provincias WHERE descripcion = '" & Libreria.TodoEnMayuscula(p_descripcion) & "'"
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
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If txtNombreProvincia.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionExistencia(Me.txtNombreProvincia.Text) = True Then
                MsgBox(Libreria.PrimeraLetraEnMayuscula(txtNombreProvincia.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            Else
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim ask As MsgBoxResult
                ask = MsgBox("¿Desea Insertar Provincia?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Guardar")
                If MsgBoxResult.Yes = ask Then
                    Dim insertar As String
                    insertar = "INSERT INTO Provincias(descripcion,estado)" & "VALUES" & "(@descripcion,@estado)"
                    Dim cmdInsertar As New SqlCommand(insertar, miConexion)
                    'cmdInsertar.Parameters.AddWithValue("@nro_libro", 1)
                    cmdInsertar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(txtNombreProvincia.Text))
                    cmdInsertar.Parameters.AddWithValue("@estado", CboEstado.SelectedValue)

                    Try
                        cmdInsertar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    consultaConInnerJoint()
                End If
            End If
        End If
    End Sub
    Function ComprobacionEstado(ByVal p_Provincias As Integer) As Integer
        Dim buscar As String
        Dim estado As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Provincias WHERE cod_Provincia= '" & p_Provincias & "'"
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
    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        If txtNroProvincia.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(txtNroProvincia.Text)) = 1 Then
                If Libreria.deseaEliminar() = 6 Then
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(txtNroProvincia.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim actualizar As String
                    actualizar = "UPDATE Provincias SET estado=@estado WHERE cod_Provincia = @cod_Provincia"
                    Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                    cmdActualizar.Parameters.AddWithValue("@cod_Provincia", nro)
                    cmdActualizar.Parameters.AddWithValue("@estado", 2)

                    Try
                        cmdActualizar.ExecuteNonQuery()
                        miConexion.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Exit Sub
                    End Try
                    consultaConInnerJoint()
                    MsgBox("La Provincia fue Eliminada Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                    miConexion.Close()
                End If
            Else
                MsgBox("La Provincia ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If txtNombreProvincia.TextLength = 0 Or txtNombreProvincia.TextLength = 0 Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If ComprobacionEstado(CInt(txtNroProvincia.Text)) = 1 Then
                If ComprobacionExistencia(Me.txtNombreProvincia.Text) = True Then
                    MsgBox(Libreria.PrimeraLetraEnMayuscula(txtNombreProvincia.Text) + " ya existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                Else
                    Try
                        miConexion.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim nro As Integer
                    Try
                        nro = CInt(txtNroProvincia.Text)
                    Catch ex As Exception
                        MsgBox("Ingreso un Valor incorrecto en el campo Codigo", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
                        Exit Sub
                    End Try
                    Dim ask As MsgBoxResult
                    ask = MsgBox("¿Desea Modificar Provincia?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Information, "Modificar")
                    If MsgBoxResult.Yes = ask Then
                        Dim actualizar As String
                        actualizar = "UPDATE Provincias SET descripcion = @descripcion WHERE cod_Provincia = @cod_Provincia"
                        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                        cmdActualizar.Parameters.AddWithValue("@cod_Provincia", nro)
                        cmdActualizar.Parameters.AddWithValue("@descripcion", Libreria.TodoEnMayuscula(Me.txtNombreProvincia.Text))

                        Try
                            cmdActualizar.ExecuteNonQuery()
                            miConexion.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Exit Sub
                            consultaConInnerJoint()
                        End Try
                    End If
                End If
            Else
                MsgBox("La Provincia ya fue Eliminada ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        txtNombreProvincia.Clear()
        txtNroProvincia.Clear()
        Me.Close()
    End Sub

    Private Sub RbtInsertar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtInsertar.CheckedChanged
        txtNombreProvincia.Visible = True
        LblNombreDeProvincia.Visible = True
        txtNroProvincia.Visible = False
        LblNroProvincia.Visible = False
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = True
        BtnQuitar.Enabled = False
        txtNombreProvincia.Clear()
        txtNroProvincia.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificar.CheckedChanged
        txtNombreProvincia.Visible = True
        LblNombreDeProvincia.Visible = True
        txtNroProvincia.Visible = True
        LblNroProvincia.Visible = True
        BtnModificar.Enabled = True
        BtnAgregar.Enabled = False
        BtnQuitar.Enabled = False
        txtNombreProvincia.Clear()
        txtNroProvincia.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub RbtEliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEliminar.CheckedChanged
        txtNombreProvincia.Visible = False
        LblNombreDeProvincia.Visible = False
        txtNroProvincia.Visible = True
        LblNroProvincia.Visible = True
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = False
        BtnQuitar.Enabled = True
        txtNombreProvincia.Clear()
        txtNroProvincia.Clear()
        BtnModificarEstado.Enabled = False
        CboEstado.Visible = False
        LblEstado.Visible = False
    End Sub

    Private Sub txtNroProvincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroProvincia.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            txtNroProvincia.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub txtNombreProvincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreProvincia.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            txtNombreProvincia.Focus()
        Else
            Libreria.soloLetras(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        consultaConInnerJoint()
    End Sub

    Private Sub BtnModificarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificarEstado.Click
        If txtNroProvincia.TextLength = 0 Or CboEstado.Text = "" Then
            MsgBox("Completar todos los Campos", MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton1, "Error")
        Else
            If Libreria.deseaModificar() = 6 Then
                Dim nro As Integer
                Try
                    nro = CInt(txtNroProvincia.Text)
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
                actualizar = "UPDATE Provincias SET estado = @estado WHERE cod_Provincia = @cod_Provincia"
                Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                cmdActualizar.Parameters.AddWithValue("@cod_Provincia", nro)
                cmdActualizar.Parameters.AddWithValue("@estado", CInt(CboEstado.SelectedValue))
                Try
                    cmdActualizar.ExecuteNonQuery()
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
                consultaConInnerJoint()
                MsgBox("Los datos fueron modificados correctamente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Éxito")
            End If
        End If
    End Sub

    Private Sub RbtModificarEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModificarEstado.CheckedChanged
        txtNombreProvincia.Visible = False
        LblNombreDeProvincia.Visible = False
        txtNroProvincia.Visible = True
        LblNroProvincia.Visible = True
        BtnModificar.Enabled = True
        BtnAgregar.Enabled = False
        BtnQuitar.Enabled = False
        txtNombreProvincia.Clear()
        txtNroProvincia.Clear()
        BtnModificarEstado.Enabled = True
        CboEstado.Visible = True
        LblEstado.Visible = True
        BtnAgregar.Enabled = False
        BtnModificar.Enabled = False
        BtnQuitar.Enabled = False
    End Sub
End Class