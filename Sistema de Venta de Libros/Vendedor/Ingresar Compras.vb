Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Ingresar_Compras
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dia As Date
    Dim comando As SqlCommand
    Dim comando1 As SqlCommand
    Dim reader As SqlDataReader
    Dim nro_factura As Integer = 0
    Dim nroCompra As Integer
    Dim precio As Double = 0.0
    Dim totalAPagar As Double
    Dim nro As Integer
    Dim nombreLib As String
    Dim PrecioLib As String
    Dim nro_lib As Integer = 0
    Dim stock As Integer
    Dim cantidadDeLibros As Integer
    Dim i As Integer = 0



    Private Sub TxtProvincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloLetras(e)
    End Sub

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloLetrasSinEspacios(e)
    End Sub

    Private Sub TxtDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloNumero(e)
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloNumeroConEspacios(e)
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloLetrasSinEspacios(e)
    End Sub

    Private Sub TxtLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Libreria.soloLetrasSinEspacios(e)
    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If TxtNroLibro.TextLength = 0 Or CInt(TxtCantidadDeLibro.Text) = 0 Then
            MsgBox("Complete el campo Nro de Libro y/o ingrese una cantidad ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Completar")
        Else
            Dim ask As MsgBoxResult
            ask = MsgBox("Seguro que desea insertar Nueva Compra", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Confirmar Inserción")
            If MsgBoxResult.Yes = ask Then
                nro = Convert.ToInt32(TxtNroLibro.Text)
                'buscar precio y guardarlo en la variable nro_factura
                PrecioLib = "SELECT * FROM Libros WHERE ISBN = '" & nro & "'"
                Try
                    miConexion.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                comando = New SqlCommand(PrecioLib, miConexion)
                reader = comando.ExecuteReader()
                While reader.Read()
                    nro_lib = reader.Item(0)
                    nombreLib = reader.Item(1)
                    precio = reader.Item(3)
                    stock = reader.Item(5)
                End While
                reader.Close()
                Try
                    miConexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim PPrecioPorCantidad As Double = Libreria.PrecioPorcantidad(precio, stock)
                Dim agregarONoAlDatgarid As Integer
                agregarONoAlDatgarid = recorrerdatagridParaModificar(nro_lib, CInt(TxtCantidadDeLibro.Text), PPrecioPorCantidad)
                If agregarONoAlDatgarid = 1 Then
                    If stock >= CInt(TxtCantidadDeLibro.Text) Then
                        DtgRegistrarCompra.Rows.Add(nombreLib, CInt(TxtCantidadDeLibro.Text), "", precio, Libreria.PrecioPorcantidad(precio, CInt(TxtCantidadDeLibro.Text)))
                        ' totalAPagar = totalAPagar + Libreria.PrecioPorcantidad(precio, CInt(TxtCantidadDeLibro.Text))
                        TxtTotalAPagar.Clear()
                        recorrerdatagridParaObtenerPrecioPorCantidad()
                        TxtTotalAPagar.Text = totalAPagar
                        cantidadDeLibros = cantidadDeLibros + CInt(TxtCantidadDeLibro.Text)
                        Me.ComprasTableAdapter.Fill(Me.DataSet1.Compras)
                        MsgBox("Su pedido se agrego correctamente ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                        CboFormaPago.Enabled = True
                        BtnComprar.Enabled = True
                    End If
                ElseIf agregarONoAlDatgarid = 0 Then
                    MsgBox("Su pedido ha exedido el Stock, en el stock hay " & stock - CInt(TxtCantidadDeLibro.Text) & " Libros", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                    Me.ComprasTableAdapter.Fill(Me.DataSet1.Compras)
                ElseIf agregarONoAlDatgarid = 2 Then
                    TxtTotalAPagar.Clear()
                    recorrerdatagridParaObtenerPrecioPorCantidad()
                    TxtTotalAPagar.Text = totalAPagar
                    MsgBox("Su pedido se agrego correctamente ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
                End If
            End If
        End If
    End Sub
    Function recorrerdatagridParaModificar(ByVal p_nroLibro As Integer, ByVal p_cantidad As Integer, ByVal p_PrecioPorCantidad As Double) As Integer
        Dim cantidadFilas As Integer
        Dim Existe As Integer = 0
        Dim k As Integer = 0
        cantidadFilas = DtgRegistrarCompra.Rows.Count
        If cantidadFilas <= 0 Then
            Existe = 1
        Else
            While k < cantidadFilas
                'nro de libro
                If (p_nroLibro = NroLibro(DtgRegistrarCompra.Rows(k).Cells(0).Value.ToString())) Then
                    If (CInt(DtgRegistrarCompra.Rows(k).Cells(1).Value.ToString) + p_cantidad) <= stock Then
                        'cantidad
                        DtgRegistrarCompra.Rows(k).Cells(1).Value = (CInt(DtgRegistrarCompra.Rows(k).Cells(1).Value.ToString) + p_cantidad)
                        'Precio Por Cantidad
                        DtgRegistrarCompra.Rows(k).Cells(4).Value = (Convert.ToDouble(DtgRegistrarCompra.Rows(k).Cells(3).Value.ToString) * CInt(DtgRegistrarCompra.Rows(k).Cells(1).Value.ToString))
                        Existe = 2
                        k = cantidadFilas
                    Else
                        Existe = 0
                    End If
                Else
                    Existe = 1
                End If
                k = k + 1
            End While
        End If
        Return Existe
    End Function

    Public Sub recorrerdatagridParaObtenerPrecioPorCantidad()
        Dim cantidadFilas As Integer
        Dim k As Double = 0
        totalAPagar = 0
        cantidadFilas = DtgRegistrarCompra.Rows.Count
        While k < cantidadFilas
            'Precio Por Cantidad
            totalAPagar = totalAPagar + Convert.ToDouble(DtgRegistrarCompra.Rows(k).Cells(4).Value.ToString)
            ' MsgBox(totalAPagar)
            k = k + 1
        End While
    End Sub
    Function nroFactura() As Integer
        Dim buscar As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        buscar = "SELECT cod_factura FROM Facturas WHERE cod_factura = (select max(cod_factura) from Facturas)"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nro_factura = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas con la conexión")
        End Try
        Return nro_factura
    End Function
    Function formaPago(ByVal p_formaPago As Integer) As String
        Dim buscar1 As String
        Dim formPago As String = ""
        buscar1 = "SELECT * FROM [Formas de Pago] WHERE cod_pago = '" & p_formaPago & "'"
        comando = New SqlCommand(buscar1, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            formPago = reader.Item(1)
        End While
        reader.Close()
        Return formPago
    End Function
    Function nroCompras() As Integer
        Dim buscar1 As String
        Dim nrocompras1 As Integer
        buscar1 = "SELECT * FROM Compras WHERE cod_compra = (select max(cod_compra) from Compras)"
        comando = New SqlCommand(buscar1, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            nrocompras1 = reader.Item(2)
        End While
        reader.Close()
        Return nrocompras1
    End Function

    Private Sub Ingresar_Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Formas_de_Pago' Puede moverla o quitarla según sea necesario.
        Me.Formas_de_PagoTableAdapter.FillByFormaDePago(Me.DataSet1.Formas_de_Pago, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sexo' Puede moverla o quitarla según sea necesario.
        Me.SexoTableAdapter.FillBySexoActicvos(Me.DataSet1.Sexo, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Compras' Puede moverla o quitarla según sea necesario.
        ' Me.ComprasTableAdapter.Fill(Me.DataSet1.Compras)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.FillByLocalidades(Me.DataSet1.Localidades, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.FillByProvincias(Me.DataSet1.Provincias, 1)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Libreria.cantidadlineasCompras()
        LblNuevoCliente.Visible = False
        BtnVerFactura.Enabled = False
        BtnAyuda.Enabled = False
        TxtDniCliente.Focus()
        DtgRegistrarCompra.RowTemplate.Height = 80
        TxtDniCliente.Enabled = True

    End Sub

    Private Sub DtgRegistrarCompra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgRegistrarCompra.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DtgRegistrarCompra.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DtgRegistrarCompra.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)

                Select Case bc.Name
                    Case "Eliminar"
                        If Libreria.DeseaEliminarLibros() = 1 Then
                            DtgRegistrarCompra.Rows.RemoveAt(cell.RowIndex)
                            MsgBox("Los Datos Fueron Eliminados Exitosamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Operación")
                            If DtgRegistrarCompra.Rows.Count = 0 Then
                                TxtTotalAPagar.Clear()
                                CboFormaPago.Enabled = False
                                BtnComprar.Enabled = False
                            End If
                        End If

                        Exit Select
                End Select

            End If

        End If
    End Sub
    Function DescuentoDeStock(ByVal p_NroLibro As Integer, ByVal p_cantidad As Integer) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE ISBN = '" & p_NroLibro & "' and estado = 1"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(5) - p_cantidad
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
    Private Sub actualizarStock(ByVal p_nro_libro As Integer, ByVal p_cantidad As Integer)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas con la conexion")
        End Try
        Dim actualizar As String
        actualizar = "UPDATE Libros SET cantidad=@cantidad WHERE ISBN = @ISBN"
        Dim cmdActualizar As New SqlCommand(actualizar, miConexion)
        cmdActualizar.Parameters.AddWithValue("@ISBN", p_nro_libro)
        cmdActualizar.Parameters.AddWithValue("@cantidad", p_cantidad)
        Try
            cmdActualizar.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Function NroLibro(ByVal p_NombreLibro As String) As Integer
        Dim buscar As String
        Dim existe As Integer
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE nombre = '" & p_NombreLibro & "' and estado = 1"
        comando = New SqlCommand(buscar, miConexion)
        reader = comando.ExecuteReader()
        While reader.Read()
            existe = reader.Item(0)
        End While
        reader.Close()
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        Return existe
    End Function
  
    Private Sub BtnComprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComprar.Click
        Dim j As Integer = 0
        If (DtgRegistrarCompra.Rows.Count = 0) Then
            MsgBox("No ingreso Ningúna venta ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Aviso")
        ElseIf (CboFormaPago.SelectedValue = Nothing) Then
            MsgBox("No ingreso Ningúna Forma De Pago ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Aviso")
        Else
            '  Try
            'miConexion.Close()
            miConexion.Open()
            '   Catch ex As Exception
            'MsgBox(ex.Message)
            '   MsgBox("HOla")
            ' Exit Sub
            '  End Try
            Dim bonificacioParaCliente As Double
            bonificacioParaCliente = Libreria.bonificacion(CboFormaPago.SelectedValue, totalAPagar)
            Try
                Dim vDia As String = DtpFechaActual.Value.Day
                Dim vMes As String = DtpFechaActual.Value.Month
                Dim vAño As String = DtpFechaActual.Value.Year
                factura.factura(6, Convert.ToString(vDia & "-" & vMes & "-" & vAño), bonificacioParaCliente, CInt(TxtDniCliente.Text), CboFormaPago.SelectedValue, totalAPagar - bonificacioParaCliente, CInt(TxtDni.Text))
            Catch ex As Exception
                MsgBox("Ingrese Dni del Cliente", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
                miConexion.Close()
                Exit Sub
            End Try

            Dim cantidadFilas As Integer
            cantidadFilas = DtgRegistrarCompra.Rows.Count
            Dim cantidad As Integer
            Dim nro As Integer
            Dim descuento As Integer
            Try
                miConexion.Close()
            Catch ex As Exception
                MsgBox("Problemas con la conexión")
            End Try
            Dim fact As Integer = nroFactura()
            While j < cantidadFilas
                nro = NroLibro(DtgRegistrarCompra.Rows(j).Cells(0).Value.ToString())
                cantidad = DtgRegistrarCompra.Rows(j).Cells(1).Value.ToString()
                descuento = DescuentoDeStock(nro, cantidad)
                precio = DtgRegistrarCompra.Rows(j).Cells(3).Value.ToString()
                actualizarStock(nro, descuento)
                Dim vDia As String = DtpFechaActual.Value.Day
                Dim vMes As String = DtpFechaActual.Value.Month
                Dim vAño As String = DtpFechaActual.Value.Year
                compra.Compras(fact, nro, cantidad, precio, Convert.ToString(vDia & "-" & vMes & "-" & vAño))
                j = j + 1
            End While
            MsgBox("Su Compra Fue Registrada Con Exito", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Exito")
            DtgRegistrarCompra.Rows.Clear()
            TxtDniCliente.Enabled = True
            BtnGuardarCliente.Enabled = True
            TxtDniCliente.Clear()
            TxtNroLibro.Enabled = False
            BtnAyuda.Enabled = False
            BtnDisminuir.Enabled = False
            BtnIncrementar.Enabled = False
            TxtTotalAPagar.Clear()
            TxtCantidadDeLibro.Clear()
            TxtNroLibro.Clear()
            BtnComprar.Enabled = False
            CboFormaPago.Text = Nothing
            BtnVerFactura.Enabled = True
        End If
        ' Try
        '  miConexion.Close()
        'Catch ex As Exception
        '  MsgBox(ex.Message)
        'Exit Sub
        ' End Try
    End Sub

    Private Sub TxtNroLibro_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtNroLibro.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtNroLibro.Focus()
        Else
            Libreria.soloNumeroConEspacios(e)
        End If
    End Sub

    Private Sub TxtCantidadDeLibro_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtCantidadDeLibro.KeyPress
        Libreria.soloNumeroConEspacios(e)
    End Sub

    Private Sub TxtCantidadDeLibro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCantidadDeLibro.LostFocus
        TxtCantidadDeLibro.Enabled = False
    End Sub

    Private Sub TxtCantidadDeLibro_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtCantidadDeLibro.TextChanged
        If TxtCantidadDeLibro.TextLength = 0 Then
            TxtCantidadDeLibro.Text = 1
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnDisminuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisminuir.Click
        If CInt(TxtCantidadDeLibro.Text) > 1 Then
            TxtCantidadDeLibro.Text = CInt(TxtCantidadDeLibro.Text) - 1
        Else
            MsgBox("Ya no se Puede Disminuir, porque 1 es la cantidad minima a comprar", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
        End If
    End Sub

    Private Sub BtnIncrementar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIncrementar.Click
        If CInt(TxtCantidadDeLibro.Text) >= 0 And CInt(TxtCantidadDeLibro.Text) < 1000 Then
            TxtCantidadDeLibro.Text = CInt(TxtCantidadDeLibro.Text) + 1
        Else
            MsgBox("El Campo esta Vacio o el valor ingresado supera el rango permitido (1000 libros)", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Campo Vacio")
        End If
    End Sub

    Private Sub TxtDniCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDniCliente.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtDniCliente.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub
    Function ComprobacionExistencia(ByVal p_dni As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Clientes WHERE dni = '" & p_dni & "' and Clientes.estado = 1"
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
    Private Sub BtnGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarCliente.Click
        If TxtDniCliente.TextLength <> 0 Then
            If ComprobacionExistencia(CInt(TxtDniCliente.Text)) = True Then
                LblNuevoCliente.Visible = False
                CboFormaPago.Enabled = False
                'TxtDniCliente.Enabled = True
                TxtNroLibro.Enabled = True
                TxtCantidadDeLibro.Enabled = False
                BtnDisminuir.Enabled = True
                BtnIncrementar.Enabled = True
                DtgRegistrarCompra.Enabled = True
                BtnComprar.Enabled = True
                BtnAgregar.Enabled = True
                BtnGuardarCliente.Enabled = False
                BtnAyuda.Enabled = True
                TxtDniCliente.Enabled = False
                MsgBox("El Cliente fue ingresado con exito", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Información")
            Else
                MsgBox("El Cliente Aún no esta Registrado, Registrelo", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information, "Información")
                LblNuevoCliente.Visible = True
                TxtDniCliente.Focus()
            End If
        Else
            MsgBox("No ingreso ningún Dni", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation, "Información")
        End If
    End Sub

    Private Sub TxtDniCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDniCliente.LostFocus
        If TxtDniCliente.TextLength = 0 Then
            TxtDniCliente.Focus()
            CboFormaPago.Enabled = False
            TxtNroLibro.Enabled = False
            TxtCantidadDeLibro.Enabled = False
            BtnDisminuir.Enabled = False
            BtnIncrementar.Enabled = False
            DtgRegistrarCompra.Enabled = False
            BtnComprar.Enabled = False
            BtnAgregar.Enabled = False
        ElseIf TxtDniCliente.TextLength < 8 Then
            TxtDniCliente.BackColor = Color.Red
            MsgBox("El número ingresado posee menos números de los que posee un dni ", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            TxtDniCliente.Focus()
        ElseIf TxtDniCliente.TextLength = 8 Then
            TxtDniCliente.BackColor = Color.LemonChiffon
        End If
    End Sub

    
    Private Sub LblNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNuevoCliente.Click
        Registrar_Clientes.ShowDialog()
    End Sub

    Private Sub TxtNroLibro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNroLibro.LostFocus
        If TxtNroLibro.TextLength > 0 Then
            If ComprobacionExistenciaLibro(CInt(TxtNroLibro.Text)) = False Then
                TxtNroLibro.BackColor = Color.Red
                MsgBox("El Libro Ingresado No existe, verifique y vuelva a ingresar", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "Advertencia")
                TxtNroLibro.Focus()
            Else
                TxtNroLibro.BackColor = Color.White
            End If
            End If
    End Sub
    Function ComprobacionExistenciaLibro(ByVal p_nroLibro As String) As Boolean
        Dim buscar As String
        Dim existe As Boolean = False
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox("Problemas en la conexión", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Error")
        End Try
        buscar = "SELECT * FROM Libros WHERE ISBN = '" & p_nroLibro & "' and Libros.cantidad > 0  and Libros.estado = 1"
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

    Private Sub BtnVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerFactura.Click
        VerFactura.ShowDialog()
    End Sub


    Private Sub BtnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAyuda.Click
        AyudaLibro.ShowDialog()
    End Sub
   

    Private Sub TxtNroLibro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroLibro.TextChanged

    End Sub

    Private Sub TxtDni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDni.LostFocus
        If TxtDni.Text > "50000000" Or TxtDni.Text < "20000000" Then
            MsgBox("DNI fuera de Rango", MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "Aviso")
            TxtDni.BackColor = Color.Red
            TxtDni.Focus()
        ElseIf TxtDni.Text < "50000000" Or TxtDni.Text > "20000000" Then
            TxtDni.BackColor = Color.LemonChiffon
        End If
    End Sub
End Class