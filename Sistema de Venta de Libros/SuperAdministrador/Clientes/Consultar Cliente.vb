Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Consultar_Cliente
    Dim dataset As DataSet = New DataSet()
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)


    Private Sub DtgRegistrarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgConsultarClientes.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DtgConsultarClientes.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgConsultarClientes.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar"
                        Eliminar_Cliente.ShowDialog()
                    Case "Modificar"
                        Modificar_Cliente.ShowDialog()
                        Exit Select
                End Select

            End If

        End If
    End Sub
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nro1 As Integer
        If TxtNumeroCliente.TextLength > 0 Then
            nro1 = Convert.ToInt32(TxtNumeroCliente.Text)
            If ComprobacionExistencia(nro1) = True Then
                consultaConInnerJoint(nro1)
            Else
                dataset2.Clear()
                MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        Else
            mostrarTodosClientes()
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub

    Private Sub Consultar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.FillByClientes(Me.DataSet1.Clientes, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        '  Me.ClientesTableAdapter.FillByClientes(Me.DataSet1.Clientes, 1)
        DtgConsultarClientes.RowTemplate.Height = 40
        mostrarTodosClientes()
        TxtBusquedaPorNombre.Visible = False
        'BtnBusquedaPorNombre.Visible = False
        TxtNumeroCliente.Visible = False
        'BtnConsultar.Visible = False
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
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
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_dni & "' and estado = 1"
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
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub mostrarTodosClientes()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.estado = '1';"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub TxtNumeroCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroCliente.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumeroCliente.Focus()
        Else
            Libreria.soloNumero(e)
        End If
        If TxtNumeroCliente.TextLength = 0 Then
            mostrarTodosClientes()
        End If
    End Sub

    Private Sub TxtNumeroCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroCliente.TextChanged
        If TxtNumeroCliente.TextLength = 0 Then
            mostrarTodosClientes()
        Else
            Dim NRO As String
            If TxtNumeroCliente.TextLength > 0 Then
                Try
                    NRO = TxtNumeroCliente.Text
                Catch ex As Exception
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJoint(NRO)
                If DtgConsultarClientes.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Categoria no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
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
        buscarw = "SELECT Clientes.dni AS DNI,nombre AS NOMBRE,apellido AS APELLIDO,direccion AS DIRECCION,LOC.descripcion as LOCALIDAD,PROV.descripcion as PROVINCIA,fecha AS FECHA,telefono AS TELEFONO,EST.descripcion as ESTADO,fecha_de_registro AS [FECHA DE REGISTRACION],correo AS CORREO,SEX.descripcion as SEXO FROM Clientes INNER JOIN Localidades AS LOC ON Clientes.localidad = LOC.cod_localidad INNER JOIN Provincias AS PROV ON Clientes.provincia = PROV.cod_Provincia INNER JOIN Estado AS EST ON Clientes.estado = EST.cod_estado INNER JOIN Sexo AS SEX ON Clientes.sexo = SEX.cod_sexo  WHERE Clientes.nombre like '" + "%" + p_nombre + "%" + "'AND Clientes.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarClientes.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Dni"
                TxtBusquedaPorNombre.Visible = False
                ' BtnBusquedaPorNombre.Visible = False
                TxtNumeroCliente.Visible = True
                '  BtnConsultar.Visible = True
                mostrarTodosClientes()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                ' BtnBusquedaPorNombre.Visible = True
                TxtNumeroCliente.Visible = False
                'BtnConsultar.Visible = False
                mostrarTodosClientes()
            Case Else
                MsgBox("No seleciono nada")
        End Select
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
                If DtgConsultarClientes.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Cliente no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    mostrarTodosClientes()
                End If
            End If
        End If
    End Sub
End Class