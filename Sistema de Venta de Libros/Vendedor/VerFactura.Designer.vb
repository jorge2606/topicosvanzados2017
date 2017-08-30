<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerFactura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.DtgVerFacturas = New System.Windows.Forms.DataGridView()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblNombreEmpresa = New System.Windows.Forms.Label()
        Me.lbldireccionempresa = New System.Windows.Forms.Label()
        Me.LblGraciasPorSuCompra = New System.Windows.Forms.Label()
        Me.Lblraya = New System.Windows.Forms.Label()
        Me.LblNroDeFactura = New System.Windows.Forms.Label()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ComprasTableAdapter()
        Me.LblFormaDePago = New System.Windows.Forms.Label()
        Me.Label1NroFactura = New System.Windows.Forms.Label()
        Me.Label2NomEmpresa = New System.Windows.Forms.Label()
        Me.Label3NomDireccion = New System.Windows.Forms.Label()
        Me.Label4DniCliente = New System.Windows.Forms.Label()
        Me.Label5NomCliente = New System.Windows.Forms.Label()
        Me.Label6ApeCliente = New System.Windows.Forms.Label()
        Me.Label7DirCliente = New System.Windows.Forms.Label()
        Me.Label8LocCliente = New System.Windows.Forms.Label()
        Me.Label9ProvinciaClient = New System.Windows.Forms.Label()
        Me.Label10TelefonoClient = New System.Windows.Forms.Label()
        Me.Label12CorreoClient = New System.Windows.Forms.Label()
        Me.Label13FormaDePago = New System.Windows.Forms.Label()
        Me.LblTotalAPagar = New System.Windows.Forms.Label()
        Me.LblMontoAPagar = New System.Windows.Forms.Label()
        Me.LblBonificacion = New System.Windows.Forms.Label()
        Me.LblMontoDeBonificacion = New System.Windows.Forms.Label()
        Me.LblTotalAPagarConBonificacion = New System.Windows.Forms.Label()
        Me.TotConBonificacion = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblFechaActual = New System.Windows.Forms.Label()
        Me.LblDatosCliente = New System.Windows.Forms.Label()
        Me.LblDatosDelVendedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblApeVende = New System.Windows.Forms.Label()
        Me.LblNomVend = New System.Windows.Forms.Label()
        Me.LblDniVend = New System.Windows.Forms.Label()
        Me.LblNombreVendedor = New System.Windows.Forms.Label()
        Me.LblApellidoVendedor = New System.Windows.Forms.Label()
        Me.LblDniVendedor = New System.Windows.Forms.Label()
        Me.LblAstericoTitulo = New System.Windows.Forms.Label()
        CType(Me.DtgVerFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.Red
        Me.LblTitulo.Location = New System.Drawing.Point(318, 22)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(107, 31)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Factura"
        '
        'DtgVerFacturas
        '
        Me.DtgVerFacturas.AllowUserToAddRows = False
        Me.DtgVerFacturas.AllowUserToDeleteRows = False
        Me.DtgVerFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgVerFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgVerFacturas.Location = New System.Drawing.Point(4, 412)
        Me.DtgVerFacturas.Name = "DtgVerFacturas"
        Me.DtgVerFacturas.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgVerFacturas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgVerFacturas.Size = New System.Drawing.Size(789, 150)
        Me.DtgVerFacturas.TabIndex = 1
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblDni.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDni.Location = New System.Drawing.Point(39, 192)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(34, 16)
        Me.lblDni.TabIndex = 2
        Me.lblDni.Text = "Dni :"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblLocalidad.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblLocalidad.Location = New System.Drawing.Point(581, 217)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(74, 16)
        Me.LblLocalidad.TabIndex = 3
        Me.LblLocalidad.Text = "Localidad :"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblDireccion.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDireccion.Location = New System.Drawing.Point(321, 192)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 16)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección :"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblProvincia.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblProvincia.Location = New System.Drawing.Point(321, 217)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(70, 16)
        Me.LblProvincia.TabIndex = 5
        Me.LblProvincia.Text = "Provincia :"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblCorreo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblCorreo.Location = New System.Drawing.Point(336, 244)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(55, 16)
        Me.LblCorreo.TabIndex = 7
        Me.LblCorreo.Text = "Correo :"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblTelefono.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblTelefono.Location = New System.Drawing.Point(581, 192)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(68, 16)
        Me.LblTelefono.TabIndex = 9
        Me.LblTelefono.Text = "Telefóno :"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblApellido.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblApellido.Location = New System.Drawing.Point(13, 244)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(64, 16)
        Me.LblApellido.TabIndex = 10
        Me.LblApellido.Text = "Apellido :"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblNombre.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNombre.Location = New System.Drawing.Point(13, 217)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(63, 16)
        Me.LblNombre.TabIndex = 11
        Me.LblNombre.Text = "Nombre :"
        '
        'LblNombreEmpresa
        '
        Me.LblNombreEmpresa.AutoSize = True
        Me.LblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblNombreEmpresa.ForeColor = System.Drawing.Color.Crimson
        Me.LblNombreEmpresa.Location = New System.Drawing.Point(16, 75)
        Me.LblNombreEmpresa.Name = "LblNombreEmpresa"
        Me.LblNombreEmpresa.Size = New System.Drawing.Size(157, 16)
        Me.LblNombreEmpresa.TabIndex = 12
        Me.LblNombreEmpresa.Text = "Nombre de la Empresa  :"
        '
        'lbldireccionempresa
        '
        Me.lbldireccionempresa.AutoSize = True
        Me.lbldireccionempresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lbldireccionempresa.ForeColor = System.Drawing.Color.Crimson
        Me.lbldireccionempresa.Location = New System.Drawing.Point(16, 97)
        Me.lbldireccionempresa.Name = "lbldireccionempresa"
        Me.lbldireccionempresa.Size = New System.Drawing.Size(71, 16)
        Me.lbldireccionempresa.TabIndex = 13
        Me.lbldireccionempresa.Text = "Dirección :"
        '
        'LblGraciasPorSuCompra
        '
        Me.LblGraciasPorSuCompra.AutoSize = True
        Me.LblGraciasPorSuCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGraciasPorSuCompra.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblGraciasPorSuCompra.Location = New System.Drawing.Point(263, 648)
        Me.LblGraciasPorSuCompra.Name = "LblGraciasPorSuCompra"
        Me.LblGraciasPorSuCompra.Size = New System.Drawing.Size(278, 29)
        Me.LblGraciasPorSuCompra.TabIndex = 14
        Me.LblGraciasPorSuCompra.Text = "Gracias Por Su Compra!!"
        '
        'Lblraya
        '
        Me.Lblraya.AutoSize = True
        Me.Lblraya.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Lblraya.Location = New System.Drawing.Point(17, 113)
        Me.Lblraya.Name = "Lblraya"
        Me.Lblraya.Size = New System.Drawing.Size(768, 26)
        Me.Lblraya.TabIndex = 15
        Me.Lblraya.Text = "---------------------------------------------------------------------------------" & _
            "---------------------------"
        '
        'LblNroDeFactura
        '
        Me.LblNroDeFactura.AutoSize = True
        Me.LblNroDeFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroDeFactura.ForeColor = System.Drawing.Color.Red
        Me.LblNroDeFactura.Location = New System.Drawing.Point(18, 51)
        Me.LblNroDeFactura.Name = "LblNroDeFactura"
        Me.LblNroDeFactura.Size = New System.Drawing.Size(56, 24)
        Me.LblNroDeFactura.TabIndex = 16
        Me.LblNroDeFactura.Text = "Nro. :"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.DataSet1
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'LblFormaDePago
        '
        Me.LblFormaDePago.AutoSize = True
        Me.LblFormaDePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaDePago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblFormaDePago.Location = New System.Drawing.Point(32, 384)
        Me.LblFormaDePago.Name = "LblFormaDePago"
        Me.LblFormaDePago.Size = New System.Drawing.Size(171, 25)
        Me.LblFormaDePago.TabIndex = 17
        Me.LblFormaDePago.Text = "Forma de Pago :"
        '
        'Label1NroFactura
        '
        Me.Label1NroFactura.AutoSize = True
        Me.Label1NroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1NroFactura.ForeColor = System.Drawing.Color.Red
        Me.Label1NroFactura.Location = New System.Drawing.Point(96, 51)
        Me.Label1NroFactura.Name = "Label1NroFactura"
        Me.Label1NroFactura.Size = New System.Drawing.Size(28, 24)
        Me.Label1NroFactura.TabIndex = 18
        Me.Label1NroFactura.Text = "---"
        '
        'Label2NomEmpresa
        '
        Me.Label2NomEmpresa.AutoSize = True
        Me.Label2NomEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2NomEmpresa.ForeColor = System.Drawing.Color.Crimson
        Me.Label2NomEmpresa.Location = New System.Drawing.Point(179, 75)
        Me.Label2NomEmpresa.Name = "Label2NomEmpresa"
        Me.Label2NomEmpresa.Size = New System.Drawing.Size(28, 16)
        Me.Label2NomEmpresa.TabIndex = 19
        Me.Label2NomEmpresa.Text = "-----"
        '
        'Label3NomDireccion
        '
        Me.Label3NomDireccion.AutoSize = True
        Me.Label3NomDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3NomDireccion.ForeColor = System.Drawing.Color.Crimson
        Me.Label3NomDireccion.Location = New System.Drawing.Point(97, 97)
        Me.Label3NomDireccion.Name = "Label3NomDireccion"
        Me.Label3NomDireccion.Size = New System.Drawing.Size(24, 16)
        Me.Label3NomDireccion.TabIndex = 20
        Me.Label3NomDireccion.Text = "----"
        '
        'Label4DniCliente
        '
        Me.Label4DniCliente.AutoSize = True
        Me.Label4DniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4DniCliente.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4DniCliente.Location = New System.Drawing.Point(86, 192)
        Me.Label4DniCliente.Name = "Label4DniCliente"
        Me.Label4DniCliente.Size = New System.Drawing.Size(24, 16)
        Me.Label4DniCliente.TabIndex = 21
        Me.Label4DniCliente.Text = "----"
        '
        'Label5NomCliente
        '
        Me.Label5NomCliente.AutoSize = True
        Me.Label5NomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label5NomCliente.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5NomCliente.Location = New System.Drawing.Point(82, 217)
        Me.Label5NomCliente.Name = "Label5NomCliente"
        Me.Label5NomCliente.Size = New System.Drawing.Size(24, 16)
        Me.Label5NomCliente.TabIndex = 22
        Me.Label5NomCliente.Text = "----"
        '
        'Label6ApeCliente
        '
        Me.Label6ApeCliente.AutoSize = True
        Me.Label6ApeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label6ApeCliente.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6ApeCliente.Location = New System.Drawing.Point(79, 244)
        Me.Label6ApeCliente.Name = "Label6ApeCliente"
        Me.Label6ApeCliente.Size = New System.Drawing.Size(24, 16)
        Me.Label6ApeCliente.TabIndex = 23
        Me.Label6ApeCliente.Text = "----"
        '
        'Label7DirCliente
        '
        Me.Label7DirCliente.AutoSize = True
        Me.Label7DirCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label7DirCliente.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7DirCliente.Location = New System.Drawing.Point(405, 192)
        Me.Label7DirCliente.Name = "Label7DirCliente"
        Me.Label7DirCliente.Size = New System.Drawing.Size(32, 16)
        Me.Label7DirCliente.TabIndex = 24
        Me.Label7DirCliente.Text = "------"
        '
        'Label8LocCliente
        '
        Me.Label8LocCliente.AutoSize = True
        Me.Label8LocCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label8LocCliente.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8LocCliente.Location = New System.Drawing.Point(655, 217)
        Me.Label8LocCliente.Name = "Label8LocCliente"
        Me.Label8LocCliente.Size = New System.Drawing.Size(36, 16)
        Me.Label8LocCliente.TabIndex = 25
        Me.Label8LocCliente.Text = "-------"
        '
        'Label9ProvinciaClient
        '
        Me.Label9ProvinciaClient.AutoSize = True
        Me.Label9ProvinciaClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label9ProvinciaClient.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9ProvinciaClient.Location = New System.Drawing.Point(405, 217)
        Me.Label9ProvinciaClient.Name = "Label9ProvinciaClient"
        Me.Label9ProvinciaClient.Size = New System.Drawing.Size(44, 16)
        Me.Label9ProvinciaClient.TabIndex = 26
        Me.Label9ProvinciaClient.Text = "---------"
        '
        'Label10TelefonoClient
        '
        Me.Label10TelefonoClient.AutoSize = True
        Me.Label10TelefonoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label10TelefonoClient.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10TelefonoClient.Location = New System.Drawing.Point(655, 192)
        Me.Label10TelefonoClient.Name = "Label10TelefonoClient"
        Me.Label10TelefonoClient.Size = New System.Drawing.Size(36, 16)
        Me.Label10TelefonoClient.TabIndex = 27
        Me.Label10TelefonoClient.Text = "-------"
        '
        'Label12CorreoClient
        '
        Me.Label12CorreoClient.AutoSize = True
        Me.Label12CorreoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label12CorreoClient.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12CorreoClient.Location = New System.Drawing.Point(404, 244)
        Me.Label12CorreoClient.Name = "Label12CorreoClient"
        Me.Label12CorreoClient.Size = New System.Drawing.Size(56, 16)
        Me.Label12CorreoClient.TabIndex = 29
        Me.Label12CorreoClient.Text = "------------"
        '
        'Label13FormaDePago
        '
        Me.Label13FormaDePago.AutoSize = True
        Me.Label13FormaDePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13FormaDePago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13FormaDePago.Location = New System.Drawing.Point(213, 384)
        Me.Label13FormaDePago.Name = "Label13FormaDePago"
        Me.Label13FormaDePago.Size = New System.Drawing.Size(117, 25)
        Me.Label13FormaDePago.TabIndex = 30
        Me.Label13FormaDePago.Text = "---------------"
        '
        'LblTotalAPagar
        '
        Me.LblTotalAPagar.AutoSize = True
        Me.LblTotalAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAPagar.Location = New System.Drawing.Point(23, 580)
        Me.LblTotalAPagar.Name = "LblTotalAPagar"
        Me.LblTotalAPagar.Size = New System.Drawing.Size(150, 24)
        Me.LblTotalAPagar.TabIndex = 31
        Me.LblTotalAPagar.Text = "Total a Pagar $ : "
        '
        'LblMontoAPagar
        '
        Me.LblMontoAPagar.AutoSize = True
        Me.LblMontoAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoAPagar.Location = New System.Drawing.Point(178, 580)
        Me.LblMontoAPagar.Name = "LblMontoAPagar"
        Me.LblMontoAPagar.Size = New System.Drawing.Size(70, 24)
        Me.LblMontoAPagar.TabIndex = 32
        Me.LblMontoAPagar.Text = "----------"
        '
        'LblBonificacion
        '
        Me.LblBonificacion.AutoSize = True
        Me.LblBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBonificacion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblBonificacion.Location = New System.Drawing.Point(433, 384)
        Me.LblBonificacion.Name = "LblBonificacion"
        Me.LblBonificacion.Size = New System.Drawing.Size(159, 25)
        Me.LblBonificacion.TabIndex = 33
        Me.LblBonificacion.Text = "Bonificación $ :"
        '
        'LblMontoDeBonificacion
        '
        Me.LblMontoDeBonificacion.AutoSize = True
        Me.LblMontoDeBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoDeBonificacion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblMontoDeBonificacion.Location = New System.Drawing.Point(608, 384)
        Me.LblMontoDeBonificacion.Name = "LblMontoDeBonificacion"
        Me.LblMontoDeBonificacion.Size = New System.Drawing.Size(47, 25)
        Me.LblMontoDeBonificacion.TabIndex = 34
        Me.LblMontoDeBonificacion.Text = "-----"
        '
        'LblTotalAPagarConBonificacion
        '
        Me.LblTotalAPagarConBonificacion.AutoSize = True
        Me.LblTotalAPagarConBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAPagarConBonificacion.Location = New System.Drawing.Point(24, 613)
        Me.LblTotalAPagarConBonificacion.Name = "LblTotalAPagarConBonificacion"
        Me.LblTotalAPagarConBonificacion.Size = New System.Drawing.Size(297, 24)
        Me.LblTotalAPagarConBonificacion.TabIndex = 35
        Me.LblTotalAPagarConBonificacion.Text = "Total a Pagar Con Bonificación $ : "
        '
        'TotConBonificacion
        '
        Me.TotConBonificacion.AutoSize = True
        Me.TotConBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotConBonificacion.Location = New System.Drawing.Point(320, 613)
        Me.TotConBonificacion.Name = "TotConBonificacion"
        Me.TotConBonificacion.Size = New System.Drawing.Size(76, 24)
        Me.TotConBonificacion.TabIndex = 36
        Me.TotConBonificacion.Text = "-----------"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblFecha.ForeColor = System.Drawing.Color.Crimson
        Me.LblFecha.Location = New System.Drawing.Point(415, 62)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(55, 16)
        Me.LblFecha.TabIndex = 37
        Me.LblFecha.Text = "Fecha  :"
        '
        'LblFechaActual
        '
        Me.LblFechaActual.AutoSize = True
        Me.LblFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblFechaActual.ForeColor = System.Drawing.Color.Crimson
        Me.LblFechaActual.Location = New System.Drawing.Point(476, 62)
        Me.LblFechaActual.Name = "LblFechaActual"
        Me.LblFechaActual.Size = New System.Drawing.Size(28, 16)
        Me.LblFechaActual.TabIndex = 38
        Me.LblFechaActual.Text = "-----"
        '
        'LblDatosCliente
        '
        Me.LblDatosCliente.AutoSize = True
        Me.LblDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosCliente.ForeColor = System.Drawing.Color.Blue
        Me.LblDatosCliente.Location = New System.Drawing.Point(268, 150)
        Me.LblDatosCliente.Name = "LblDatosCliente"
        Me.LblDatosCliente.Size = New System.Drawing.Size(221, 31)
        Me.LblDatosCliente.TabIndex = 39
        Me.LblDatosCliente.Text = "Datos del Cliente"
        '
        'LblDatosDelVendedor
        '
        Me.LblDatosDelVendedor.AutoSize = True
        Me.LblDatosDelVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosDelVendedor.ForeColor = System.Drawing.Color.Chocolate
        Me.LblDatosDelVendedor.Location = New System.Drawing.Point(259, 285)
        Me.LblDatosDelVendedor.Name = "LblDatosDelVendedor"
        Me.LblDatosDelVendedor.Size = New System.Drawing.Size(258, 31)
        Me.LblDatosDelVendedor.TabIndex = 40
        Me.LblDatosDelVendedor.Text = "Datos Del Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label1.Location = New System.Drawing.Point(17, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(768, 26)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "---------------------------------------------------------------------------------" & _
            "---------------------------"
        '
        'LblApeVende
        '
        Me.LblApeVende.AutoSize = True
        Me.LblApeVende.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblApeVende.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblApeVende.Location = New System.Drawing.Point(497, 334)
        Me.LblApeVende.Name = "LblApeVende"
        Me.LblApeVende.Size = New System.Drawing.Size(24, 16)
        Me.LblApeVende.TabIndex = 47
        Me.LblApeVende.Text = "----"
        '
        'LblNomVend
        '
        Me.LblNomVend.AutoSize = True
        Me.LblNomVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblNomVend.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNomVend.Location = New System.Drawing.Point(265, 334)
        Me.LblNomVend.Name = "LblNomVend"
        Me.LblNomVend.Size = New System.Drawing.Size(24, 16)
        Me.LblNomVend.TabIndex = 46
        Me.LblNomVend.Text = "----"
        '
        'LblDniVend
        '
        Me.LblDniVend.AutoSize = True
        Me.LblDniVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblDniVend.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblDniVend.Location = New System.Drawing.Point(86, 334)
        Me.LblDniVend.Name = "LblDniVend"
        Me.LblDniVend.Size = New System.Drawing.Size(24, 16)
        Me.LblDniVend.TabIndex = 45
        Me.LblDniVend.Text = "----"
        '
        'LblNombreVendedor
        '
        Me.LblNombreVendedor.AutoSize = True
        Me.LblNombreVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblNombreVendedor.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNombreVendedor.Location = New System.Drawing.Point(196, 334)
        Me.LblNombreVendedor.Name = "LblNombreVendedor"
        Me.LblNombreVendedor.Size = New System.Drawing.Size(63, 16)
        Me.LblNombreVendedor.TabIndex = 44
        Me.LblNombreVendedor.Text = "Nombre :"
        '
        'LblApellidoVendedor
        '
        Me.LblApellidoVendedor.AutoSize = True
        Me.LblApellidoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblApellidoVendedor.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblApellidoVendedor.Location = New System.Drawing.Point(427, 334)
        Me.LblApellidoVendedor.Name = "LblApellidoVendedor"
        Me.LblApellidoVendedor.Size = New System.Drawing.Size(64, 16)
        Me.LblApellidoVendedor.TabIndex = 43
        Me.LblApellidoVendedor.Text = "Apellido :"
        '
        'LblDniVendedor
        '
        Me.LblDniVendedor.AutoSize = True
        Me.LblDniVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblDniVendedor.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblDniVendedor.Location = New System.Drawing.Point(39, 334)
        Me.LblDniVendedor.Name = "LblDniVendedor"
        Me.LblDniVendedor.Size = New System.Drawing.Size(34, 16)
        Me.LblDniVendedor.TabIndex = 42
        Me.LblDniVendedor.Text = "Dni :"
        '
        'LblAstericoTitulo
        '
        Me.LblAstericoTitulo.AutoSize = True
        Me.LblAstericoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LblAstericoTitulo.Location = New System.Drawing.Point(82, 366)
        Me.LblAstericoTitulo.Name = "LblAstericoTitulo"
        Me.LblAstericoTitulo.Size = New System.Drawing.Size(584, 18)
        Me.LblAstericoTitulo.TabIndex = 48
        Me.LblAstericoTitulo.Text = "*********************************************************************************" & _
            "***************"
        '
        'VerFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 691)
        Me.Controls.Add(Me.LblAstericoTitulo)
        Me.Controls.Add(Me.LblApeVende)
        Me.Controls.Add(Me.LblNomVend)
        Me.Controls.Add(Me.LblDniVend)
        Me.Controls.Add(Me.LblNombreVendedor)
        Me.Controls.Add(Me.LblApellidoVendedor)
        Me.Controls.Add(Me.LblDniVendedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDatosDelVendedor)
        Me.Controls.Add(Me.LblDatosCliente)
        Me.Controls.Add(Me.LblFechaActual)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TotConBonificacion)
        Me.Controls.Add(Me.LblTotalAPagarConBonificacion)
        Me.Controls.Add(Me.LblMontoDeBonificacion)
        Me.Controls.Add(Me.LblBonificacion)
        Me.Controls.Add(Me.LblMontoAPagar)
        Me.Controls.Add(Me.LblTotalAPagar)
        Me.Controls.Add(Me.Label13FormaDePago)
        Me.Controls.Add(Me.Label12CorreoClient)
        Me.Controls.Add(Me.Label10TelefonoClient)
        Me.Controls.Add(Me.Label9ProvinciaClient)
        Me.Controls.Add(Me.Label8LocCliente)
        Me.Controls.Add(Me.Label7DirCliente)
        Me.Controls.Add(Me.Label6ApeCliente)
        Me.Controls.Add(Me.Label5NomCliente)
        Me.Controls.Add(Me.Label4DniCliente)
        Me.Controls.Add(Me.Label3NomDireccion)
        Me.Controls.Add(Me.Label2NomEmpresa)
        Me.Controls.Add(Me.Label1NroFactura)
        Me.Controls.Add(Me.LblFormaDePago)
        Me.Controls.Add(Me.LblNroDeFactura)
        Me.Controls.Add(Me.Lblraya)
        Me.Controls.Add(Me.LblGraciasPorSuCompra)
        Me.Controls.Add(Me.lbldireccionempresa)
        Me.Controls.Add(Me.LblNombreEmpresa)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.DtgVerFacturas)
        Me.Controls.Add(Me.LblTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerFactura"
        Me.Text = "VerFactura"
        CType(Me.DtgVerFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents DtgVerFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblCorreo As System.Windows.Forms.Label
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblNombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents lbldireccionempresa As System.Windows.Forms.Label
    Friend WithEvents LblGraciasPorSuCompra As System.Windows.Forms.Label
    Friend WithEvents Lblraya As System.Windows.Forms.Label
    Friend WithEvents LblNroDeFactura As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ComprasTableAdapter
    Friend WithEvents LblFormaDePago As System.Windows.Forms.Label
    Friend WithEvents Label1NroFactura As System.Windows.Forms.Label
    Friend WithEvents Label2NomEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label3NomDireccion As System.Windows.Forms.Label
    Friend WithEvents Label4DniCliente As System.Windows.Forms.Label
    Friend WithEvents Label5NomCliente As System.Windows.Forms.Label
    Friend WithEvents Label6ApeCliente As System.Windows.Forms.Label
    Friend WithEvents Label7DirCliente As System.Windows.Forms.Label
    Friend WithEvents Label8LocCliente As System.Windows.Forms.Label
    Friend WithEvents Label9ProvinciaClient As System.Windows.Forms.Label
    Friend WithEvents Label10TelefonoClient As System.Windows.Forms.Label
    Friend WithEvents Label12CorreoClient As System.Windows.Forms.Label
    Friend WithEvents Label13FormaDePago As System.Windows.Forms.Label
    Friend WithEvents LblTotalAPagar As System.Windows.Forms.Label
    Friend WithEvents LblMontoAPagar As System.Windows.Forms.Label
    Friend WithEvents LblBonificacion As System.Windows.Forms.Label
    Friend WithEvents LblMontoDeBonificacion As System.Windows.Forms.Label
    Friend WithEvents LblTotalAPagarConBonificacion As System.Windows.Forms.Label
    Friend WithEvents TotConBonificacion As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblFechaActual As System.Windows.Forms.Label
    Friend WithEvents LblDatosCliente As System.Windows.Forms.Label
    Friend WithEvents LblDatosDelVendedor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblApeVende As System.Windows.Forms.Label
    Friend WithEvents LblNomVend As System.Windows.Forms.Label
    Friend WithEvents LblDniVend As System.Windows.Forms.Label
    Friend WithEvents LblNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents LblApellidoVendedor As System.Windows.Forms.Label
    Friend WithEvents LblDniVendedor As System.Windows.Forms.Label
    Friend WithEvents LblAstericoTitulo As System.Windows.Forms.Label
End Class
