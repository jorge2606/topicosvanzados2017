Public Class ClientesPorEdad

    Private Sub ClientesPorEdad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Consultas.ClientesPorEdad' Puede moverla o quitarla según sea necesario.
        'Me.RptwClientesPorEdad.RefreshReport()
    End Sub

    Private Sub BtnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarCliente.Click
        Me.ClientesPorEdadTableAdapter.FillClientesPorEdad(Me.Consultas.ClientesPorEdad, CInt(TxtEdadDelCliente.Text))
        Me.RptwClientesPorEdad.RefreshReport()
    End Sub

    Private Sub TxtEdadDelCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEdadDelCliente.KeyPress
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "{" Or e.KeyChar.ToString = "'" Or e.KeyChar.ToString = "¿" Or e.KeyChar.ToString = "´" Or e.KeyChar.ToString = "+" Or e.KeyChar.ToString = "}" Or e.KeyChar.ToString = "-" Or e.KeyChar.ToString = "|" Or e.KeyChar.ToString = "[" Then
            e.Handled = True
            TxtEdadDelCliente.Focus()
        Else
            Libreria.soloNumero(e)
        End If
    End Sub
End Class