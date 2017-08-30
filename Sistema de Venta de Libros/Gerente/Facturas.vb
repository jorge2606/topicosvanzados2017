Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Facturas
    Dim dataset2 As DataSet = New DataSet
    Dim miAdaptador1 As SqlDataAdapter
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Dim miAdaptador As SqlDataAdapter
    Public nro_factura As Integer
    Private Sub Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.DataSet1.Facturas)
        DtgFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        consultaConInnerJoint()
    End Sub
    Private Sub consultaConInnerJoint()
        Dim buscarw As String
        Try
            miConexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscarw = "SELECT cod_factura AS [Codigo de Factura],Empresa.nombre as Empresa,fechaYhora AS [Fecha y Hora],total as Total,Clientes.dni as [Dni Cliente],[Formas de Pago].descripcion as [Formas de Pago],bonificacion as Bonificacion FROM Facturas INNER JOIN Empresa ON Facturas.cod_empresa = Empresa.Nro INNER JOIN Clientes ON Facturas.cod_cliente = Clientes.dni  INNER JOIN [Formas de Pago] ON Facturas.formaDePago = [Formas de Pago].cod_pago;"
        miAdaptador1 = New SqlDataAdapter(buscarw, miConexion)
        dataset2.Clear()
        miAdaptador1.Fill(dataset2)
        Me.DtgFacturas.DataSource = dataset2.Tables(0)
        Try
            miConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DIM MAXX AS INTEGER =DATSETCLIENTE.TABLES("CLIENTES").COMPUTE("SUM(CLIENTE)","")
    End Sub

    Private Sub BtnVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerFactura.Click
        Try
            nro_factura = CInt(DtgFacturas.SelectedRows(0).Cells(0).Value.ToString())
        Catch ex As Exception
            MsgBox("Seleccione el Registro Completo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
        VerFactura.nroFactura()
        VerFactura.ShowDialog()
    End Sub
End Class