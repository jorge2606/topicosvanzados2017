Public Class NominaDeClientes

    Private Sub NominaDeClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeClientes' Puede moverla o quitarla según sea necesario.
        Me.NominaDeClientesTableAdapter.FillNominaDeClientes(Me.Consultas.NominaDeClientes)

        Me.RptwNominaDeClientes.RefreshReport()
    End Sub
End Class