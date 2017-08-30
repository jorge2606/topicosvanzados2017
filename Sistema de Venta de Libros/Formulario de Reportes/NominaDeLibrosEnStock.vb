Public Class NominaDeLibrosEnStock

    Private Sub NominaDeLibrosEnStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeLibros' Puede moverla o quitarla según sea necesario.
        Me.NominaDeLibrosTableAdapter.FillNominaDeLibros(Me.Consultas.NominaDeLibros)

        Me.RptwLibrosEnStock.RefreshReport()
    End Sub
End Class