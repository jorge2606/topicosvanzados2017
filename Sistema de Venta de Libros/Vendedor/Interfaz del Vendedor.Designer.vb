<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz_del_Vendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnIngresarCompra = New System.Windows.Forms.Button()
        Me.BtnConsultarLibros = New System.Windows.Forms.Button()
        Me.BtnonsultarClientes = New System.Windows.Forms.Button()
        Me.LblBienvenidoVendedor = New System.Windows.Forms.Label()
        Me.TxtNombreDelVendedor = New System.Windows.Forms.TextBox()
        Me.PtbPerfilDelVendedor = New System.Windows.Forms.PictureBox()
        Me.LblCerrarSesion = New System.Windows.Forms.Label()
        Me.BtnConsultarVentas = New System.Windows.Forms.Button()
        Me.BtnConsultarFacturas = New System.Windows.Forms.Button()
        CType(Me.PtbPerfilDelVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIngresarCompra
        '
        Me.BtnIngresarCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnIngresarCompra.Location = New System.Drawing.Point(316, 47)
        Me.BtnIngresarCompra.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnIngresarCompra.Name = "BtnIngresarCompra"
        Me.BtnIngresarCompra.Size = New System.Drawing.Size(204, 55)
        Me.BtnIngresarCompra.TabIndex = 1
        Me.BtnIngresarCompra.Text = "Ingresar Compras"
        Me.BtnIngresarCompra.UseVisualStyleBackColor = False
        '
        'BtnConsultarLibros
        '
        Me.BtnConsultarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnConsultarLibros.Location = New System.Drawing.Point(316, 120)
        Me.BtnConsultarLibros.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultarLibros.Name = "BtnConsultarLibros"
        Me.BtnConsultarLibros.Size = New System.Drawing.Size(204, 55)
        Me.BtnConsultarLibros.TabIndex = 2
        Me.BtnConsultarLibros.Text = "Consultar Libros"
        Me.BtnConsultarLibros.UseVisualStyleBackColor = False
        '
        'BtnonsultarClientes
        '
        Me.BtnonsultarClientes.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnonsultarClientes.Location = New System.Drawing.Point(316, 191)
        Me.BtnonsultarClientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnonsultarClientes.Name = "BtnonsultarClientes"
        Me.BtnonsultarClientes.Size = New System.Drawing.Size(204, 55)
        Me.BtnonsultarClientes.TabIndex = 3
        Me.BtnonsultarClientes.Text = "Consultar Cliente"
        Me.BtnonsultarClientes.UseVisualStyleBackColor = False
        '
        'LblBienvenidoVendedor
        '
        Me.LblBienvenidoVendedor.AutoSize = True
        Me.LblBienvenidoVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LblBienvenidoVendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblBienvenidoVendedor.Location = New System.Drawing.Point(97, 19)
        Me.LblBienvenidoVendedor.Name = "LblBienvenidoVendedor"
        Me.LblBienvenidoVendedor.Size = New System.Drawing.Size(182, 13)
        Me.LblBienvenidoVendedor.TabIndex = 4
        Me.LblBienvenidoVendedor.Text = "Bienvenido Vendedor/a :"
        '
        'TxtNombreDelVendedor
        '
        Me.TxtNombreDelVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombreDelVendedor.Enabled = False
        Me.TxtNombreDelVendedor.Location = New System.Drawing.Point(285, 16)
        Me.TxtNombreDelVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombreDelVendedor.Name = "TxtNombreDelVendedor"
        Me.TxtNombreDelVendedor.Size = New System.Drawing.Size(306, 20)
        Me.TxtNombreDelVendedor.TabIndex = 5
        '
        'PtbPerfilDelVendedor
        '
        Me.PtbPerfilDelVendedor.BackColor = System.Drawing.Color.Gray
        Me.PtbPerfilDelVendedor.Location = New System.Drawing.Point(607, 16)
        Me.PtbPerfilDelVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PtbPerfilDelVendedor.Name = "PtbPerfilDelVendedor"
        Me.PtbPerfilDelVendedor.Size = New System.Drawing.Size(173, 109)
        Me.PtbPerfilDelVendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbPerfilDelVendedor.TabIndex = 6
        Me.PtbPerfilDelVendedor.TabStop = False
        '
        'LblCerrarSesion
        '
        Me.LblCerrarSesion.AutoSize = True
        Me.LblCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.LblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCerrarSesion.Font = New System.Drawing.Font("Felix Titling", 10.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.LblCerrarSesion.ForeColor = System.Drawing.Color.Red
        Me.LblCerrarSesion.Location = New System.Drawing.Point(625, 138)
        Me.LblCerrarSesion.Name = "LblCerrarSesion"
        Me.LblCerrarSesion.Size = New System.Drawing.Size(135, 16)
        Me.LblCerrarSesion.TabIndex = 7
        Me.LblCerrarSesion.Text = "Cerrar Sesión"
        '
        'BtnConsultarVentas
        '
        Me.BtnConsultarVentas.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultarVentas.Location = New System.Drawing.Point(316, 265)
        Me.BtnConsultarVentas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultarVentas.Name = "BtnConsultarVentas"
        Me.BtnConsultarVentas.Size = New System.Drawing.Size(204, 55)
        Me.BtnConsultarVentas.TabIndex = 8
        Me.BtnConsultarVentas.Text = "Consultar Ventas"
        Me.BtnConsultarVentas.UseVisualStyleBackColor = False
        Me.BtnConsultarVentas.Visible = False
        '
        'BtnConsultarFacturas
        '
        Me.BtnConsultarFacturas.BackColor = System.Drawing.Color.Gray
        Me.BtnConsultarFacturas.Location = New System.Drawing.Point(316, 341)
        Me.BtnConsultarFacturas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnConsultarFacturas.Name = "BtnConsultarFacturas"
        Me.BtnConsultarFacturas.Size = New System.Drawing.Size(204, 55)
        Me.BtnConsultarFacturas.TabIndex = 9
        Me.BtnConsultarFacturas.Text = "Consultar Facturas"
        Me.BtnConsultarFacturas.UseVisualStyleBackColor = False
        Me.BtnConsultarFacturas.Visible = False
        '
        'Interfaz_del_Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnConsultarFacturas)
        Me.Controls.Add(Me.BtnConsultarVentas)
        Me.Controls.Add(Me.LblCerrarSesion)
        Me.Controls.Add(Me.PtbPerfilDelVendedor)
        Me.Controls.Add(Me.TxtNombreDelVendedor)
        Me.Controls.Add(Me.LblBienvenidoVendedor)
        Me.Controls.Add(Me.BtnonsultarClientes)
        Me.Controls.Add(Me.BtnConsultarLibros)
        Me.Controls.Add(Me.BtnIngresarCompra)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Interfaz_del_Vendedor"
        Me.Text = "Interfaz del Vendedor"
        CType(Me.PtbPerfilDelVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIngresarCompra As System.Windows.Forms.Button
    Friend WithEvents BtnConsultarLibros As System.Windows.Forms.Button
    Friend WithEvents BtnonsultarClientes As System.Windows.Forms.Button
    Friend WithEvents LblBienvenidoVendedor As System.Windows.Forms.Label
    Friend WithEvents TxtNombreDelVendedor As System.Windows.Forms.TextBox
    Friend WithEvents PtbPerfilDelVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents LblCerrarSesion As System.Windows.Forms.Label
    Friend WithEvents BtnConsultarVentas As System.Windows.Forms.Button
    Friend WithEvents BtnConsultarFacturas As System.Windows.Forms.Button
End Class
