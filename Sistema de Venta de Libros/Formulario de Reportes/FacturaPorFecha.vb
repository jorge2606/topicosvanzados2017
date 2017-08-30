Public Class FacturaPorFecha

  

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Fecha Desde
        Dim vDia As String = DTPFechaDesde.Value.Day
        Dim vMes As String = DTPFechaDesde.Value.Month
        Dim vAño As String = DTPFechaDesde.Value.Year
        'Fecha Hasta
        Dim vDiaHasta As String = DTPFechaHasta.Value.Day
        Dim vMesHasta As String = DTPFechaHasta.Value.Month
        Dim vAñoHasta As String = DTPFechaHasta.Value.Year
        If CDate(DTPFechaDesde.Text) > CDate(DTPFechaHasta.Text) Then
            MsgBox("La Fecha de Inicio debe ser Menor que la de Final", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        Else
            '  MsgBox("Fecha desde" & DTPFechaDesde.Text & DTPFechaHasta.Text)
            Me.DataTable3TableAdapter.FillFacturaPorFecha(Me.Consultas.DataTable3, Convert.ToString(vDia & "-" & vMes & "-" & vAño), Convert.ToString(vDiaHasta & "-" & vMesHasta & "-" & vAñoHasta))
            Me.RptwFacturaPorFecha.RefreshReport()
        End If
    End Sub

    
    Private Sub FacturaPorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.DataTable3' Puede moverla o quitarla según sea necesario.
        Me.RptwFacturaPorFecha.RefreshReport()
    End Sub
End Class