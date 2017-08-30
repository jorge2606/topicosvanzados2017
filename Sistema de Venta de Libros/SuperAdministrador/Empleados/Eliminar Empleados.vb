Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Eliminar_Empleados
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader

    Private Sub TxtNumeroDeEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroDeEmpleado.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNumeroDeEmpleado.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub

    Private Sub DtgEliminarEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgEliminarEmpleados.CellContentClick
        'Dim respuesta As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(DtgEliminarEmpleados.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgEliminarEmpleados.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar"
                        Dim h As Integer
                        Dim nombre As String = ""
                        If Libreria.DeseaEliminarEmpleado() = 1 Then
                            h = CInt(DtgEliminarEmpleados.Rows(e.RowIndex).Cells(1).Value.ToString)
                            nombre = DtgEliminarEmpleados.Rows(e.RowIndex).Cells(2).Value.ToString
                            Try
                                miConexion.Open()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                Exit Sub
                            End Try
                            Dim actualizar As String
                            actualizar = "UPDATE Empleados SET estado=@estado WHERE dni = @dni"
                            Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
                            cmdActualizar.Parameters.AddWithValue("@dni", h)
                            cmdActualizar.Parameters.AddWithValue("@estado", 2)
                            Me.EmpleadosTableAdapter.Fill(Me.DataSet1.Empleados)
                            Try
                                cmdActualizar.ExecuteNonQuery()
                                miConexion.Close()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                                Exit Sub
                            End Try
                            MsgBox("El Empleado " & nombre & " fue Eliminado Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                            miConexion.Close()
                            Exit Select
                        End If
                End Select

            End If

        End If
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
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
        Dim buscarEmpleado As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarEmpleado = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.dni Like'" + "%" + p_dni + "%" + "' AND Empleados.estado = 1 AND Empleados.Empleo <> 2;"
        miAdaptador1 = New SqlDataAdapter(buscarEmpleado, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub MostrarTodosLosDatos()
        Dim buscarEmpleado As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarEmpleado = "SELECT Empleados.dni,Empleados.nombre,Empleados.apellido,Codigo_de_empleo.descripcion as Empleo,Provincias.descripcion as Provincias,Localidades.descripcion as Localidades,perfil,Sexo.descripcion as Sexo,Estado.descripcion as Estado,Empleados.fecha_registracion,Empleados.direccion,Empleados.telefono,Empleados.correoElectronico,Empleados.fechaNacimiento FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.estado = 1;"
        ' buscarEmpleado = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_dni & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscarEmpleado, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNumeroDeEmpleado.TextLength > 0 Then
            Dim nro As Integer = Convert.ToInt32(TxtNumeroDeEmpleado.Text)
            If ComprobacionExistencia(nro) = True Then
                consultaConInnerJoint(nro)
            Else
                dataset2.Clear()
                MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            End If
        Else
            MsgBox("Campo Vacio ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
        End If
    End Sub
    Private Sub MostrarTodoConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado where Empleados.estado=1 and Empleados.Empleo <> 2 ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub
    Private Sub Eliminar_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillByEmpleado(Me.DataSet1.Empleados, 1)
        ' MostrarTodosLosDatos()
        DtgEliminarEmpleados.RowTemplate.Height = 50
        MostrarTodoConInnerJoint()
        TxtBusquedaPorNombre.Visible = False
        '  BtnBusquedaPorNombre.Visible = False
        TxtNumeroDeEmpleado.Visible = False
        '  BtnBuscar.Visible = False
    End Sub

    'Private Sub TxtNumeroDeEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroDeEmpleado.TextChanged
    'Dim nro As Integer
    '   If TxtNumeroDeEmpleado.TextLength > 0 Then
    '      Try
    '         nro = Convert.ToInt32(TxtNumeroDeEmpleado.Text)
    '    Catch ex As Exception
    '       MsgBox("Ingrese un número", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
    '      Exit Sub
    ' End Try
    'If ComprobacionExistencia(nro) = True Then
    '   consultaConInnerJoint(nro)
    '      Else
    '         dataset2.Clear()
    '        MsgBox("El Libro no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
    '       MostrarTodoConInnerJoint()
    '  End If
    '    Else
    '       MostrarTodoConInnerJoint()
    '  End If
    'End Sub

    Private Sub TxtNumeroDeEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumeroDeEmpleado.TextChanged
        If TxtNumeroDeEmpleado.TextLength = 0 Then
            MostrarTodoConInnerJoint()
        Else
            Dim NRO As String
            If TxtNumeroDeEmpleado.TextLength > 0 Then
                Try
                    NRO = TxtNumeroDeEmpleado.Text
                Catch ex As Exception
                    MsgBox("Ingrese un Valor Erroneo", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Exit Sub
                End Try
                dataset2.Clear()
                consultaConInnerJoint(NRO)
                If DtgEliminarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("La Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
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
                TxtNumeroDeEmpleado.Visible = True
                ' BtnBuscar.Visible = True
                MostrarTodoConInnerJoint()
            Case "Nombre"
                TxtBusquedaPorNombre.Visible = True
                '  BtnBusquedaPorNombre.Visible = True
                TxtNumeroDeEmpleado.Visible = False
                '  BtnBuscar.Visible = False
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
        Dim buscar As String = "SELECT Empleados.dni AS DNI ,Empleados.nombre AS NOMBRE,Empleados.apellido AS APELLIDO,Codigo_de_empleo.descripcion as EMPLEO,Provincias.descripcion as PROVINCIA,Localidades.descripcion as LOCALIDAD,perfil AS PERFIL,Sexo.descripcion as SEXO,Estado.descripcion as ESTADO,Empleados.fecha_registracion AS REGISTRACION,Empleados.direccion AS DIRECCION,Empleados.telefono AS TELEFONO,Empleados.correoElectronico AS CORREO,Empleados.fechaNacimiento AS NACIMIENTO FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.nombre like '" + "%" + p_nombre + "%" + "' and Empleados.estado=1 and Empleados.Empleo <> 2;"
        ' Dim buscar As String = "SELECT dni,nombre,apellido,Codigo_de_empleo.descripcion FROM Empleados INNER JOIN Codigo_de_Empleo ON Empleados.Empleo = Codigo_de_Empleo.cod_empleo INNER JOIN Provincias ON Empleados.provincia = Provincias.cod_Provincia INNER JOIN Localidades ON Empleados.localidad = Localidades.cod_localidad INNER JOIN Sexo ON Empleados.sexo = Sexo.cod_sexo INNER JOIN Estado ON Empleados.estado = Estado.cod_estado WHERE Empleados.dni = '" & p_NroLibro & "' ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgEliminarEmpleados.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        dataset2.Clear()
        MostrarTodoConInnerJoint()
    End Sub

    Private Sub TxtBusquedaPorNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusquedaPorNombre.TextChanged
        If TxtBusquedaPorNombre.TextLength = 0 Then
            MostrarTodosLosDatos()
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
                If DtgEliminarEmpleados.Rows.Count = 0 Then
                    dataset2.Clear()
                    MsgBox("El Empleado no existe", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    MostrarTodosLosDatos()
                End If
            End If
        End If
    End Sub
End Class