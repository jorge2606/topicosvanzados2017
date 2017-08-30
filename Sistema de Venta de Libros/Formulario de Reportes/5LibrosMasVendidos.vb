Public Class _5LibrosMasVendidos
   

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Me.RptwCincoLibrosMasVendidos.RefreshReport()
    End Sub

 
    Private Sub _5LibrosMasVendidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.FillCincoLibrosMasVendidos(Me.Consultas.Libros)
    End Sub
End Class