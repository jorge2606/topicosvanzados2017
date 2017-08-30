Public Class NominaDeLibrosBajas

    Private Sub NominaDeLibrosBajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.NominaDeBajasLibros' Puede moverla o quitarla según sea necesario.
        Me.NominaDeBajasLibrosTableAdapter.FillNominaDeBajasdeLibros(Me.Consultas.NominaDeBajasLibros)
        Me.RptwNominaBajasDeLibros.RefreshReport()
    End Sub
End Class