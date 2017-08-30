Public Class EmpleadoDelMes

  
    Private Sub EmpleadoDelMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.FillEmpleadoDelMes(Me.Consultas.Empleados)
        Me.RptwEmpleadoDelMes.RefreshReport()
    End Sub
End Class