Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Eliminar_Cliente
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter

   

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub Eliminar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.FillByClientes(Me.DataSet1.Clientes, 1)
        TxtBusquedaPorNombre.Visible = False
        DtgEliminarCliente.RowTemplate.Height = 50
        'BtnBusquedaPorNombre.Visible = False
        TxtNumeroEmpleado.Visible = False
        ' BtnBuscar.Visible = False
        mostrarTodosClientes()
    End Sub

    Private Sub DtgEliminarCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgEliminarCliente.CellContentClick
        'Dim respuesta As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(DtgEliminarCliente.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgEliminarCliente.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar"
                        Dim h As Integer
                        Dim nombre As String = ""
                        If Libreria.DeseaEliminarCliente() = 1 Then
                            ' MsgBox(e.ColumnIndex)
                            h = CInt(DtgEliminarCliente.Rows(e.RowIndex).Cells(1).Value.ToString)
                            nombre = DtgEliminarCliente.Rows(e.RowIndex).Cells(2).Value.ToString
                            Try
                                miConexion.Open()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                Exit Sub
                            End Try
                            Dim actualizar As String
                            actualizar = "UPDATE Clientes SET estado=@estado WHERE dni = @dni"
                            Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                            cmdActualizar.Parameters.AddWithValue("@dni", h)
                            cmdActualizar.Parameters.AddWithValue("@estado", 2)
                            Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)
                            Try
                                cmdActualizar.ExecuteNonQuery()
                                miConexion.Close()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                Exit Sub
                            End Try
                            MsgBox("El Cliente " & nombre & " fue Eliminado Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                            miConexion.Close()
                            Exit Select
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNumeroEmpleado.TextLength > 0 Then
            Dim nro As Integer = Convert.ToInt32(TxtNumeroEmpleado.Text)
            If ComprobacionExistencia(nro) = True Then
                consultaConInnerJoint(nro)
            Else
                dataset2.Clear()
                MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        Else
            MsgBox("Campo Vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub
   Function ComprobacionExistencia(ByVal p_dni As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_dni & "'"
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
    Private Sub mostrarTodosClientes()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarCliente.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub consultaConInnerJoint(ByVal p_dni As String)
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.dni Like'" + "%" + p_dni + "%" + "' AND Clientes.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarCliente.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtNumeroEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroEmpleado.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumeroEmpleado.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub TxtNumeroEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroEmpleado.TextChanged
        If TxtNumeroEmpleado.TextLength = 0 Then
            mostrarTodosClientes()
        Else
            Dim NRO As String
            If TxtNumeroEmpleado.TextLength > 0 Then
                Try
                    NRO = TxtNumeroEmpleado.Text
                Catch ex As Exception
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJoint(NRO)
                If DtgEliminarCliente.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Dni"
                TxtBusquedaPorNombre.Visible = False
                ' BtnBusquedaPorNombre.Visible = False
                TxtNumeroEmpleado.Visible = True
                ' BtnBuscar.Visible = True
                mostrarTodosClientes()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                ' BtnBusquedaPorNombre.Visible = True
                TxtNumeroEmpleado.Visible = False
                '  BtnBuscar.Visible = False
                mostrarTodosClientes()
            Case Else
                MsgBox("No seleciono nada")
        End Select
    End Sub

    Private Sub BtnBusquedaPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Nombre As String
        If TxtBusquedaPorNombre.TextLength > 0 Then
            Nombre = TxtBusquedaPorNombre.Text
            If ComprobacionExistenciaNombre(Nombre) = True Then
                consultaConInnerJointNombre(Nombre)
            Else
                dataset2.Clear()
                MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                mostrarTodosClientes()
            End If
        Else
            mostrarTodosClientes()
        End If
    End Sub
    Function ComprobacionExistenciaNombre(ByVal p_nombre As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Clientes WHERE nombre = '" & Libreria.TodoEnMayuscula(p_nombre) & "' and estado = 1"
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
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.nombre like '" + "%" + p_nombre + "%" + "' AND Clientes.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarCliente.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtBusquedaPorNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusquedaPorNombre.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtBusquedaPorNombre.Focus()
        Else
            Libreria.nombreDelLibro(e)
        End If
        If TxtBusquedaPorNombre.TextLength = 0 Then
            mostrarTodosClientes()
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        mostrarTodosClientes()
    End Sub

    Private Sub TxtBusquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorNombre.TextChanged
        If TxtBusquedaPorNombre.TextLength = 0 Then
            mostrarTodosClientes()
        Else
            Dim nombre As String
            If TxtBusquedaPorNombre.TextLength > 0 Then
                Try
                    nombre = TxtBusquedaPorNombre.Text
                Catch ex As Exception
                    MsgBox("Ingreso un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJointNombre(nombre)
                If DtgEliminarCliente.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
    End Sub
End Class