Public Class ClientesPorProvincias

    
    Private Sub ClientesPorProvincias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Provincias' Puede moverla o quitarla según sea necesario.
        Me.ProvinciasTableAdapter.Fill(Me.DataSet1.Provincias)
        'TODO: esta línea de código carga datos en la tabla 'Consultas.ClientesPorProvincias' Puede moverla o quitarla según sea necesario.
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Me.ClientesPorProvinciasTableAdapter.FillClientesPorProvincias(Me.Consultas.ClientesPorProvincias, CBOProvincias.SelectedValue)
        Me.RtvwClientesPorProvincias.RefreshReport()
    End Sub
End Class