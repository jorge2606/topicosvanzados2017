Public Class Formularios

    Private Sub Formularios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
    

    Private Sub BtnCincoLibrosMasVendidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCincoLibrosMasVendidos.Click
        _5LibrosMasVendidos.Show()
    End Sub

    Private Sub BtnClientesPorEdad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientesPorEdad.Click
        ClientesPorEdad.Show()
    End Sub

    Private Sub BtnClientesPorProvincias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientesPorProvincias.Click
        ClientesPorProvincias.Show()
    End Sub

    Private Sub BtnEmpleadosDelMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleadosDelMes.Click
        EmpleadoDelMes.Show()
    End Sub

    Private Sub BtnFacturaPorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFacturaPorFecha.Click
        FacturaPorFecha.Show()
    End Sub

    Private Sub BtnCategoriasMasVendidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategoriasMasVendidas.Click
        LibrosPorCategorias.Show()
    End Sub

    Private Sub BtnNominaDeClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNominaDeClientes.Click
        NominaDeClientes.Show()
    End Sub

    Private Sub BtnNominaDeEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNominaDeEmpleados.Click
        NominaDeEmpleados.Show()
    End Sub

    Private Sub NominaDeFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNominaDeFacturas.Click
        NominaDeFacturas.Show()
    End Sub

    Private Sub NominaDeLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNominaDeLibros.Click
        NominaDeLibrosEnStock.Show()
    End Sub

    Private Sub BtnRecaudaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRecaudaciones.Click
        Recaudacion.Show()
    End Sub

    Private Sub BtnRecaudaciones_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnRecaudaciones.MouseMove
        LblNominaDeRecaudaciones.Visible = True
        LblNominaDeRecaudaciones.Text = "Actual, Mensual y Anual"
    End Sub

    Private Sub BtnCategoriasMasVendidas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCategoriasMasVendidas.MouseMove
        LblCategoriasMasVendidas.Visible = True
        LblCategoriasMasVendidas.Text = "Categorias mas vendidas"
    End Sub

    Private Sub BtnCincoLibrosMasVendidos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnCincoLibrosMasVendidos.MouseMove
        LblLibrosMasVendidos.Text = "5 Libros mas Vendidos"
        LblLibrosMasVendidos.Visible = True
    End Sub

    Private Sub BtnClientesPorEdad_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClientesPorEdad.MouseHover
        LblClientesPorEdad.Visible = True
        LblClientesPorEdad.Text = "Nomina de Clientes Por Edad"
    End Sub

   
    Private Sub BtnEmpleadosDelMes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnEmpleadosDelMes.MouseMove
        LblEmpleadoDelMes.Visible = True
        LblEmpleadoDelMes.Text = "Los 5 Primeros Vendedores con mas ventas"
    End Sub

    Private Sub BtnClientesPorProvincias_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnClientesPorProvincias.MouseMove
        LblClientesPorProvincias.Visible = True
        LblClientesPorProvincias.Text = "Busqueda de clientes por sus provincias"
    End Sub

    Private Sub Formularios_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        LblCategoriasMasVendidas.Visible = False
        LblClientesPorEdad.Visible = False
        LblClientesPorProvincias.Visible = False
        LblEmpleadoDelMes.Visible = False
        LblFacturaPorFecha.Visible = False
        LblLibrosMasVendidos.Visible = False
        LblNominaDeClientes.Visible = False
        LblNominaDeEmpleados.Visible = False
        LblNominaDeFacturas.Visible = False
        LblNominaDeLibros.Visible = False
        LblNominaDeRecaudaciones.Visible = False
        LblVentasPorFecha.Visible = False
    End Sub

    Private Sub BtnNominaDeClientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnNominaDeClientes.MouseMove
        LblNominaDeClientes.Visible = True
        LblNominaDeClientes.Text = "Todos los Clientes Registrados"
    End Sub

    Private Sub BtnNominaDeFacturas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnNominaDeFacturas.MouseMove
        LblNominaDeFacturas.Visible = True
        LblNominaDeFacturas.Text = "Todas las Facturas Emitidas hasta la fecha"
    End Sub

    Private Sub BtnNominaDeEmpleados_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnNominaDeEmpleados.MouseMove
        LblNominaDeEmpleados.Visible = True
        LblNominaDeEmpleados.Text = "Todos los Empleados Activos"
    End Sub

    Private Sub BtnNominaDeLibros_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnNominaDeLibros.MouseMove
        LblNominaDeLibros.Visible = True
        LblNominaDeLibros.Text = "Todos los libros en stock"
    End Sub

    Private Sub BtnFacturaPorFecha_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnFacturaPorFecha.MouseMove
        LblFacturaPorFecha.Visible = True
        LblFacturaPorFecha.Text = "Busqueda de factura por intervalos de fechas"
    End Sub

    Private Sub BtnVentasPorFecha_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnVentasPorFecha.MouseMove
        LblVentasPorFecha.Visible = True
        LblVentasPorFecha.Text = "Busqueda de Ventas por intervalos de fechas"
    End Sub

    Private Sub BtnVentasPorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentasPorFecha.Click
        VentasPorFecha.Show()
    End Sub
End Class