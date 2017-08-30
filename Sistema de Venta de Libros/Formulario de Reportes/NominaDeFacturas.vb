Public Class NominaDeFacturas

    Private Sub NominaDeFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeFacturas' Puede moverla o quitarla según sea necesario.
        Me.NominaDeFacturasTableAdapter.FillNominaDeFacturas(Me.Consultas.NominaDeFacturas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class