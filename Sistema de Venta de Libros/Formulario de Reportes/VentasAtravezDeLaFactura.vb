Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class VentasAtravezDeLaFactura
    Dim dataset As DataSet = New DataSet()
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim comando As SqlCommand
    Dim reader As SqlDataReader

    Private Sub VentasAtravezDeLaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeFacturas' Puede moverla o quitarla según sea necesario.
        Me.NominaDeFacturasTableAdapter.FillNominaDeFacturas(Me.Consultas.NominaDeFacturas)
        DtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DtgVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If DtgFacturas.RowCount = 0 Then
            BtnVerVentas.Enabled = False
        Else
            BtnVerVentas.Enabled = True
        End If
    End Sub

    Private Sub DtgFacturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DtgFacturas.CellContentClick
        
    End Sub

    Private Sub consultaConInnerJoint(ByVal p_nrofactura As Integer)
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT cod_compra AS [Nro Compra],LIB.nombre AS Libro,COM.cantidad AS Cantidad, COM.Precio AS Precio,fechaDeVenta AS [Fecha de Venta] FROM Compras AS COM INNER JOIN Libros AS LIB ON COM.cod_libro = LIB.ISBN WHERE cod_factura = " & p_nrofactura & "  ORDER BY cod_factura ASC ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        ' DtgVentas.ClearSelection()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgVentas.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mostrarTodoConConInnerJoint()
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim buscar As String = "SELECT cod_factura,cod_compra,LIB.nombre,COM.cantidad,COM.Precio,fechaDeVenta FROM Compras AS COM INNER JOIN Libros AS LIB ON COM.cod_libro = LIB.ISBN ORDER BY cod_factura ASC ;"
        miAdaptador1 = New SqlDataAdapter(buscar, miConexion)
        dataset2.Clear()
        'ME GENERA MI DATSET        
        miAdaptador1.Fill(dataset2)
        Me.DtgVentas.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub BtnVerVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerVentas.Click
        Dim h As Integer
        Try
            h = CInt(DtgFacturas.SelectedRows(0).Cells(0).Value.ToString())
        Catch ex As Exception
            MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
        Try
            consultaConInnerJoint(h)
        Catch ex As Exception
            MsgBox("Error al pasar en parametro Nro de factura para la busqueda ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try

        
    End Sub

    Private Sub BtnVerVentas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnVerVentas.LostFocus
        If DtgFacturas.RowCount = 0 Then
            BtnVerVentas.Enabled = False
        Else
            BtnVerVentas.Enabled = True
        End If
    End Sub
End Class