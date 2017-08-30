Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Consultar_Empleados
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader


    Private Sub Consultar_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSet1.Empleados)
        DtgConsultarEmpleados.RowTemplate.Height = 50
        TxtBusquedaPorNombre.Visible = False
        'BtnBusquedaPorNombre.Visible = False
        TxtNumeroEmpleado.Visible = False
        'BtnConsultar.Visible = False
        MostrarTodoConInnerJoint()
    End Sub
    'Public Sub DtgRegistrarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgConsultarEmpleados.CellContentClick
    Public Sub DtgRegistrarEmpleados_CellContentClick()
        '   Dim cell As DataGridViewButtonCell = TryCast(DtgConsultarEmpleados.CurrentCell, DataGridViewButtonCell)
        '   If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
        'Dim bc As DataGridViewButtonColumn = TryCast(DtgConsultarEmpleados.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
        '  If bc IsNot Nothing Then
        'Dim s As String = Convert.ToString(cell.Value)

        ' Select Case bc.Name
        '     Case "Eliminar_Empleado"
        'Eliminar_Empleados.ShowDialog()
        '      Case "Modificar_Empl"
        ' Modificar_Empleados.ShowDialog()
        '   Exit Select
        '  End Select

        ' End If

        '  End If
        Me.Close()
    End Sub

    Function ComprobacionExistencia(ByVal p_NroLibro As Integer) As Boolean
        Dim buscar As String
        Dim existe As Boolean
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Empleados WHERE dni = '" & p_NroLibro & "'"
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
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni Like'" + "%" + p_dni + "%" + "';"
        ' Dim buscar As String = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_NroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNumeroEmpleado.TextLength > 0 Then
            Dim nro As Integer = Convert.ToInt32(TxtNumeroEmpleado.Text)
            If ComprobacionExistencia(nro) = True Then
                consultaConInnerJoint(nro)
            Else
                MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        Else
            dataset2.Clear()
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub MostrarTodoConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.estado = 1;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarEmpleados.DataSource = dataset2.Tables(0)
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
            MostrarTodoConInnerJoint()
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
                If DtgConsultarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Categoria no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    MostrarTodoConInnerJoint()
                End If
            End If
        End If
    End Sub

    Private Sub CboBusqPorTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBusqPorTipo.SelectedIndexChanged
        Select Case CboBusqPorTipo.SelectedItem
            Case "Dni"
                TxtBusquedaPorNombre.Visible = False
                'BtnBusquedaPorNombre.Visible = False
                TxtNumeroEmpleado.Visible = True
                ' BtnConsultar.Visible = True
                MostrarTodoConInnerJoint()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                'BtnBusquedaPorNombre.Visible = True
                TxtNumeroEmpleado.Visible = False
                '  BtnConsultar.Visible = False
                MostrarTodoConInnerJoint()
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
                MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                MostrarTodoConInnerJoint()
            End If
        Else
            MostrarTodoConInnerJoint()
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
        buscar = "SELECT * FROM Empleados WHERE nombre = '" & Libreria.TodoEnMayuscula(p_nombre) & "' and estado = 1"
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
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.nombre like '" + "%" + p_nombre + "%" + "' ;"
        ' Dim buscar As String = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_NroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgConsultarEmpleados.DataSource = dataset2.Tables(0)
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
            Libreria.BusquedaPorNombre(e)
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        MostrarTodoConInnerJoint()
    End Sub

    Private Sub TxtBusquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorNombre.TextChanged
        If TxtBusquedaPorNombre.TextLength = 0 Then
            MostrarTodoConInnerJoint()
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
                If DtgConsultarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    MostrarTodoConInnerJoint()
                End If
            End If
        End If
    End Sub
End Class