Public Class NominaDeEmpleados

    Private Sub NominaDeEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeEmpleados' Puede moverla o quitarla según sea necesario.
        Me.NominaDeEmpleadosTableAdapter.FillNominaDeEmpleados(Me.Consultas.NominaDeEmpleados)
        Me.RptwNominaDeEmpleados.RefreshReport()
    End Sub
End Class