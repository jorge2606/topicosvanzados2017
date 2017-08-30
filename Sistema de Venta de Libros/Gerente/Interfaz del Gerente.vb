Public Class Interfaz_del_Gerente

   

    Private Sub Interfaz_del_Gerente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Localidades' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.Fill(Me.DataSet1.Libros)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Chart1.Series("AGE").Points.AddXY("jorge", 33)
        Me.Chart1.Series("AGE").Points.AddXY("Luis", 12)
        Me.Chart1.Series("AGE").Points.AddXY("Mario", 56)
        Me.Chart1.Series("AGE").Points.AddXY("PEPE", 2)
        Me.Chart1.Series("AGE").Points.AddXY("Javier", 89)
    End Sub
End Class