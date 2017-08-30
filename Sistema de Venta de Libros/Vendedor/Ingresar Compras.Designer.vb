<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Compras
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresar_Compras))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTotalAPagar = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.DtgRegistrarCompra = New System.Windows.Forms.DataGridView()
        Me.Nombre_Libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_por_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblFormaDePago = New System.Windows.Forms.Label()
        Me.TxtNroLibro = New System.Windows.Forms.TextBox()
        Me.LblNroDeLibro = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.TxtCantidadDeLibro = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnDisminuir = New System.Windows.Forms.Button()
        Me.BtnIncrementar = New System.Windows.Forms.Button()
        Me.CboFormaPago = New System.Windows.Forms.ComboBox()
        Me.FormasDePagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnGuardarCliente = New System.Windows.Forms.Button()
        Me.TxtDniCliente = New System.Windows.Forms.TextBox()
        Me.LblNumeroDni = New System.Windows.Forms.Label()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter()
        Me.ComprasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ComprasTableAdapter()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter()
        Me.Formas_de_PagoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Formas_de_PagoTableAdapter()
        Me.LblNuevoCliente = New System.Windows.Forms.Label()
        Me.BtnVerFactura = New System.Windows.Forms.Button()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.DtpFechaActual = New System.Windows.Forms.DateTimePicker()
        CType(Me.DtgRegistrarCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasDePagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(683, 499)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Total a Pagar"
        '
        'TxtTotalAPagar
        '
        Me.TxtTotalAPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAPagar.Enabled = False
        Me.TxtTotalAPagar.Location = New System.Drawing.Point(799, 492)
        Me.TxtTotalAPagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAPagar.Name = "TxtTotalAPagar"
        Me.TxtTotalAPagar.Size = New System.Drawing.Size(150, 20)
        Me.TxtTotalAPagar.TabIndex = 33
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.White
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(423, 176)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(73, 51)
        Me.BtnAgregar.TabIndex = 15
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnComprar
        '
        Me.BtnComprar.BackColor = System.Drawing.Color.White
        Me.BtnComprar.Enabled = False
        Me.BtnComprar.ForeColor = System.Drawing.Color.Black
        Me.BtnComprar.Image = CType(resources.GetObject("BtnComprar.Image"), System.Drawing.Image)
        Me.BtnComprar.Location = New System.Drawing.Point(427, 602)
        Me.BtnComprar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(111, 64)
        Me.BtnComprar.TabIndex = 13
        Me.BtnComprar.UseVisualStyleBackColor = False
        '
        'DtgRegistrarCompra
        '
        Me.DtgRegistrarCompra.AllowUserToAddRows = False
        Me.DtgRegistrarCompra.AllowUserToDeleteRows = False
        Me.DtgRegistrarCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgRegistrarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRegistrarCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_Libro, Me.cantidad, Me.Eliminar, Me.Precio_unitario, Me.Precio_por_Cantidad})
        Me.DtgRegistrarCompra.Location = New System.Drawing.Point(4, 241)
        Me.DtgRegistrarCompra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgRegistrarCompra.Name = "DtgRegistrarCompra"
        Me.DtgRegistrarCompra.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DtgRegistrarCompra.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgRegistrarCompra.Size = New System.Drawing.Size(945, 239)
        Me.DtgRegistrarCompra.TabIndex = 35
        '
        'Nombre_Libro
        '
        Me.Nombre_Libro.HeaderText = "Nombre del Libro"
        Me.Nombre_Libro.Name = "Nombre_Libro"
        Me.Nombre_Libro.ReadOnly = True
        Me.Nombre_Libro.Width = 500
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'Eliminar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'Precio_unitario
        '
        Me.Precio_unitario.HeaderText = "Precio Unitario"
        Me.Precio_unitario.Name = "Precio_unitario"
        Me.Precio_unitario.ReadOnly = True
        '
        'Precio_por_Cantidad
        '
        Me.Precio_por_Cantidad.HeaderText = "Precio * Cantidad"
        Me.Precio_por_Cantidad.Name = "Precio_por_Cantidad"
        Me.Precio_por_Cantidad.ReadOnly = True
        '
        'LblFormaDePago
        '
        Me.LblFormaDePago.AutoSize = True
        Me.LblFormaDePago.BackColor = System.Drawing.Color.Transparent
        Me.LblFormaDePago.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaDePago.ForeColor = System.Drawing.Color.Red
        Me.LblFormaDePago.Location = New System.Drawing.Point(419, 521)
        Me.LblFormaDePago.Name = "LblFormaDePago"
        Me.LblFormaDePago.Size = New System.Drawing.Size(119, 23)
        Me.LblFormaDePago.TabIndex = 38
        Me.LblFormaDePago.Text = "Forma de Pago"
        '
        'TxtNroLibro
        '
        Me.TxtNroLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNroLibro.Enabled = False
        Me.TxtNroLibro.Location = New System.Drawing.Point(254, 124)
        Me.TxtNroLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNroLibro.MaxLength = 3
        Me.TxtNroLibro.Name = "TxtNroLibro"
        Me.TxtNroLibro.Size = New System.Drawing.Size(150, 20)
        Me.TxtNroLibro.TabIndex = 38
        '
        'LblNroDeLibro
        '
        Me.LblNroDeLibro.AutoSize = True
        Me.LblNroDeLibro.BackColor = System.Drawing.Color.Transparent
        Me.LblNroDeLibro.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroDeLibro.ForeColor = System.Drawing.Color.Black
        Me.LblNroDeLibro.Location = New System.Drawing.Point(174, 121)
        Me.LblNroDeLibro.Name = "LblNroDeLibro"
        Me.LblNroDeLibro.Size = New System.Drawing.Size(72, 20)
        Me.LblNroDeLibro.TabIndex = 39
        Me.LblNroDeLibro.Text = "N° de Libro"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.Black
        Me.LblCantidad.Location = New System.Drawing.Point(419, 124)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(59, 20)
        Me.LblCantidad.TabIndex = 40
        Me.LblCantidad.Text = "Cantidad"
        '
        'TxtCantidadDeLibro
        '
        Me.TxtCantidadDeLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCantidadDeLibro.Enabled = False
        Me.TxtCantidadDeLibro.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadDeLibro.Location = New System.Drawing.Point(489, 122)
        Me.TxtCantidadDeLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCantidadDeLibro.MaxLength = 12
        Me.TxtCantidadDeLibro.Name = "TxtCantidadDeLibro"
        Me.TxtCantidadDeLibro.Size = New System.Drawing.Size(100, 25)
        Me.TxtCantidadDeLibro.TabIndex = 41
        Me.TxtCantidadDeLibro.Text = "1"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(12, 601)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(111, 64)
        Me.BtnSalir.TabIndex = 43
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnDisminuir
        '
        Me.BtnDisminuir.Enabled = False
        Me.BtnDisminuir.Image = CType(resources.GetObject("BtnDisminuir.Image"), System.Drawing.Image)
        Me.BtnDisminuir.Location = New System.Drawing.Point(595, 113)
        Me.BtnDisminuir.Name = "BtnDisminuir"
        Me.BtnDisminuir.Size = New System.Drawing.Size(45, 37)
        Me.BtnDisminuir.TabIndex = 49
        Me.BtnDisminuir.UseVisualStyleBackColor = True
        '
        'BtnIncrementar
        '
        Me.BtnIncrementar.Enabled = False
        Me.BtnIncrementar.Image = CType(resources.GetObject("BtnIncrementar.Image"), System.Drawing.Image)
        Me.BtnIncrementar.Location = New System.Drawing.Point(651, 113)
        Me.BtnIncrementar.Name = "BtnIncrementar"
        Me.BtnIncrementar.Size = New System.Drawing.Size(45, 37)
        Me.BtnIncrementar.TabIndex = 50
        Me.BtnIncrementar.UseVisualStyleBackColor = True
        '
        'CboFormaPago
        '
        Me.CboFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboFormaPago.DataSource = Me.FormasDePagoBindingSource
        Me.CboFormaPago.DisplayMember = "descripcion"
        Me.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaPago.Enabled = False
        Me.CboFormaPago.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFormaPago.FormattingEnabled = True
        Me.CboFormaPago.Location = New System.Drawing.Point(339, 559)
        Me.CboFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboFormaPago.Name = "CboFormaPago"
        Me.CboFormaPago.Size = New System.Drawing.Size(278, 28)
        Me.CboFormaPago.TabIndex = 51
        Me.CboFormaPago.ValueMember = "cod_pago"
        '
        'FormasDePagoBindingSource
        '
        Me.FormasDePagoBindingSource.DataMember = "Formas de Pago"
        Me.FormasDePagoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnGuardarCliente
        '
        Me.BtnGuardarCliente.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardarCliente.Location = New System.Drawing.Point(389, 61)
        Me.BtnGuardarCliente.Name = "BtnGuardarCliente"
        Me.BtnGuardarCliente.Size = New System.Drawing.Size(146, 42)
        Me.BtnGuardarCliente.TabIndex = 52
        Me.BtnGuardarCliente.Text = "Guardar"
        Me.BtnGuardarCliente.UseVisualStyleBackColor = True
        '
        'TxtDniCliente
        '
        Me.TxtDniCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDniCliente.Location = New System.Drawing.Point(358, 35)
        Me.TxtDniCliente.MaxLength = 8
        Me.TxtDniCliente.Name = "TxtDniCliente"
        Me.TxtDniCliente.Size = New System.Drawing.Size(231, 20)
        Me.TxtDniCliente.TabIndex = 53
        '
        'LblNumeroDni
        '
        Me.LblNumeroDni.AutoSize = True
        Me.LblNumeroDni.BackColor = System.Drawing.Color.Transparent
        Me.LblNumeroDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNumeroDni.Location = New System.Drawing.Point(355, 19)
        Me.LblNumeroDni.Name = "LblNumeroDni"
        Me.LblNumeroDni.Size = New System.Drawing.Size(234, 13)
        Me.LblNumeroDni.TabIndex = 54
        Me.LblNumeroDni.Text = "Ingrese Nro de Dni del Cliente :"
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.DataSet1
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.DataSet1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Clientes"
        Me.BindingSource1.DataSource = Me.DataSet1
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.DataSet1
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.DataSet1
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'Formas_de_PagoTableAdapter
        '
        Me.Formas_de_PagoTableAdapter.ClearBeforeFill = True
        '
        'LblNuevoCliente
        '
        Me.LblNuevoCliente.AutoSize = True
        Me.LblNuevoCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblNuevoCliente.Font = New System.Drawing.Font("Felix Titling", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevoCliente.ForeColor = System.Drawing.Color.Red
        Me.LblNuevoCliente.Location = New System.Drawing.Point(175, 19)
        Me.LblNuevoCliente.Name = "LblNuevoCliente"
        Me.LblNuevoCliente.Size = New System.Drawing.Size(108, 13)
        Me.LblNuevoCliente.TabIndex = 56
        Me.LblNuevoCliente.Text = "Nuevo Cliente"
        '
        'BtnVerFactura
        '
        Me.BtnVerFactura.BackColor = System.Drawing.Color.White
        Me.BtnVerFactura.BackgroundImage = CType(resources.GetObject("BtnVerFactura.BackgroundImage"), System.Drawing.Image)
        Me.BtnVerFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVerFactura.ForeColor = System.Drawing.Color.Black
        Me.BtnVerFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVerFactura.Location = New System.Drawing.Point(838, 602)
        Me.BtnVerFactura.Name = "BtnVerFactura"
        Me.BtnVerFactura.Size = New System.Drawing.Size(111, 64)
        Me.BtnVerFactura.TabIndex = 57
        Me.BtnVerFactura.UseVisualStyleBackColor = False
        '
        'BtnAyuda
        '
        Me.BtnAyuda.ForeColor = System.Drawing.Color.Black
        Me.BtnAyuda.Location = New System.Drawing.Point(254, 149)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(150, 38)
        Me.BtnAyuda.TabIndex = 58
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.UseVisualStyleBackColor = True
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Location = New System.Drawing.Point(693, 73)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 59
        Me.TxtDni.Visible = False
        '
        'DtpFechaActual
        '
        Me.DtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaActual.Location = New System.Drawing.Point(648, 32)
        Me.DtpFechaActual.Name = "DtpFechaActual"
        Me.DtpFechaActual.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaActual.TabIndex = 60
        Me.DtpFechaActual.Visible = False
        '
        'Ingresar_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.DtpFechaActual)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.BtnAyuda)
        Me.Controls.Add(Me.BtnVerFactura)
        Me.Controls.Add(Me.LblNuevoCliente)
        Me.Controls.Add(Me.LblNumeroDni)
        Me.Controls.Add(Me.TxtDniCliente)
        Me.Controls.Add(Me.BtnGuardarCliente)
        Me.Controls.Add(Me.CboFormaPago)
        Me.Controls.Add(Me.BtnIncrementar)
        Me.Controls.Add(Me.BtnDisminuir)
        Me.Controls.Add(Me.LblFormaDePago)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtCantidadDeLibro)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblNroDeLibro)
        Me.Controls.Add(Me.TxtNroLibro)
        Me.Controls.Add(Me.DtgRegistrarCompra)
        Me.Controls.Add(Me.TxtTotalAPagar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnComprar)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Ingresar_Compras"
        Me.Text = "Ingresar Compras"
        CType(Me.DtgRegistrarCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasDePagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnComprar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalAPagar As System.Windows.Forms.TextBox
    Friend WithEvents DtgRegistrarCompra As System.Windows.Forms.DataGridView
    Friend WithEvents LblFormaDePago As System.Windows.Forms.Label
    Friend WithEvents TxtNroLibro As System.Windows.Forms.TextBox
    Friend WithEvents LblNroDeLibro As System.Windows.Forms.Label
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents TxtCantidadDeLibro As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ClientesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents ComprasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ComprasTableAdapter
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnDisminuir As System.Windows.Forms.Button
    Friend WithEvents BtnIncrementar As System.Windows.Forms.Button
    Friend WithEvents CodpagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents FormasDePagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Formas_de_PagoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Formas_de_PagoTableAdapter
    Friend WithEvents BtnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents TxtDniCliente As System.Windows.Forms.TextBox
    Friend WithEvents LblNumeroDni As System.Windows.Forms.Label
    Friend WithEvents LblNuevoCliente As System.Windows.Forms.Label
    Friend WithEvents BtnVerFactura As System.Windows.Forms.Button
    Friend WithEvents BtnAyuda As System.Windows.Forms.Button
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_Libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_por_Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtpFechaActual As System.Windows.Forms.DateTimePicker
End Class
