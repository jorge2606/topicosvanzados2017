Public Class Archivos_del_Gerente

  
    Private Sub BtnCategorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategorias.Click
        ABM_De_Categoriavb.ShowDialog()
    End Sub

    Private Sub BtnProvincias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProvincias.Click
        ABMDeProvincias.ShowDialog()
    End Sub

    Private Sub BtnLocalidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLocalidades.Click
        ABMLocalidadvb.ShowDialog()
    End Sub

    Private Sub BtnSexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSexo.Click
        ABMSexo.ShowDialog()
    End Sub

    Private Sub BtnFormaDePago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFormaDePago.Click
        ABMFormasDePago.ShowDialog()
    End Sub

    Private Sub BtnCodEmpleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCodEmpleo.Click
        ABMCodigoDeEmpleo.ShowDialog()
    End Sub

    Private Sub BtnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpresa.Click
        ABMEmpresa.ShowDialog()
    End Sub

    Private Sub BtnAutores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutores.Click
        ABMAutor.ShowDialog()
    End Sub

    Private Sub BtnFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFacturas.Click
        Facturas.ShowDialog()
    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        Ventas.ShowDialog()
    End Sub

    Private Sub LblCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCerrarSesion.Click
        If Libreria.cerrarSesion(TxtNombreDelGerente.Text) = True Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnFacturasYVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFacturasYVentas.Click
        VentasAtravezDeLaFactura.ShowDialog()
    End Sub

    Private Sub BtnFormularios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFormularios.Click
        Formularios.ShowDialog()
    End Sub

    Private Sub Archivos_del_Gerente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ingreso_al_Sistema.Hide()
    End Sub

    Private Sub BtnCrearBackUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBackUp.Click
        FrmBackup.Show()
    End Sub
End Class