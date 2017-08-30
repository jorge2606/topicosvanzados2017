Public Class LibrosPorCategorias

    Private Sub LibrosPorCategorias_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas1.CategoriasMasVendidas' Puede moverla o quitarla según sea necesario.
        Me.CategoriasMasVendidasTableAdapter.FillCantidadDeLibrosPorCategoria(Me.Consultas1.CategoriasMasVendidas)
        Me.RtptvwLibrosPorCategorias.RefreshReport()
    End Sub
End Class