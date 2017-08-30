Public Class Recaudacion

    Private Sub Recaudacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    
    Private Sub BtnRecActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecActual.Click
        'TODO: esta línea de código carga datos en la tabla 'Consultas.RecaudacioActual' Puede moverla o quitarla según sea necesario.
        Me.RptwRecaudacioDeHoy.Visible = True
        Me.RptvwRecaudacioMenstrual.Visible = False
        Me.RptwRecaudacionAnual.Visible = False
        Me.RecaudacioActualTableAdapter.FillRecaudacionDeHoy(Me.Consultas.RecaudacioActual)
        Me.RptwRecaudacioDeHoy.RefreshReport()
    End Sub

    Private Sub BtnMensual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMensual.Click
        Me.RptwRecaudacioDeHoy.Visible = False
        Me.RptvwRecaudacioMenstrual.Visible = True
        Me.RptwRecaudacionAnual.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'Consultas.RecaudacionMensual' Puede moverla o quitarla según sea necesario.
        Me.RecaudacionMensualTableAdapter.FillRecaudacionMensual(Me.Consultas.RecaudacionMensual)
        Me.RptvwRecaudacioMenstrual.RefreshReport()
    End Sub

    Private Sub BtnAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnual.Click
        Me.RptwRecaudacioDeHoy.Visible = False
        Me.RptvwRecaudacioMenstrual.Visible = False
        Me.RptwRecaudacionAnual.Visible = True
        Me.RecaudacionAnualTableAdapter.FillRecaudaciónAnual(Me.Consultas1.RecaudacionAnual)
        Me.RptwRecaudacionAnual.RefreshReport()
    End Sub
End Class