Public Class VentasPorFecha

    Private Sub VentasPorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.VentasPorFecha' Puede moverla o quitarla según sea necesario.
        Me.RptwVentasPorfecha.RefreshReport()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Fecha Desde
        Dim vDia As String = DTPFechaDesde.Value.Day
        Dim vMes As String = DTPFechaDesde.Value.Month
        Dim vAño As String = DTPFechaDesde.Value.Year
        'Fecha Hasta
        Dim vDiaHasta As String = DTPFechaHasta.Value.Day
        Dim vMesHasta As String = DTPFechaHasta.Value.Month
        Dim vAñoHasta As String = DTPFechaHasta.Value.Year

        ' MsgBox("Fecha desde" & CDate(DTPFechaDesde.Text) & CDate(DTPFechaDesde.Text))
        If CDate(DTPFechaDesde.Text) > CDate(DTPFechaHasta.Text) Then
            MsgBox("La Fecha de Inicio debe ser Menor que la de Final", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        Else
            Me.VentasPorFechaTableAdapter.FillVentasPorFecha(Me.Consultas.VentasPorFecha, Convert.ToString(vDia & "-" & vMes & "-" & vAño), Convert.ToString(vDiaHasta & "-" & vMesHasta & "-" & vAñoHasta))
            Me.RptwVentasPorfecha.RefreshReport()
        End If
    End Sub
End Class