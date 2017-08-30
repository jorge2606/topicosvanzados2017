<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CboLocalidades = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.DtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblCorreoElectronico = New System.Windows.Forms.Label()
        Me.LblDatosDelCliente = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.dtgRegistarClientes = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SexoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter()
        Me.LblFechaDeRegistracion = New System.Windows.Forms.Label()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.LocalidadesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgRegistarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.LblDireccion.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDireccion.Location = New System.Drawing.Point(22, 162)
        Me.LblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(87, 13)
        Me.LblDireccion.TabIndex = 55
        Me.LblDireccion.Text = "Dirección :"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccion.Location = New System.Drawing.Point(115, 159)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtDireccion.MaxLength = 25
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(244, 20)
        Me.txtDireccion.TabIndex = 54
        '
        'CboProvincia
        '
        Me.CboProvincia.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.CboProvincia.DisplayMember = "descripcion"
        Me.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvincia.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboProvincia.FormattingEnabled = True
        Me.CboProvincia.Location = New System.Drawing.Point(115, 134)
        Me.CboProvincia.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CboProvincia.Name = "CboProvincia"
        Me.CboProvincia.Size = New System.Drawing.Size(244, 21)
        Me.CboProvincia.TabIndex = 53
        Me.CboProvincia.ValueMember = "cod_Provincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LblProvincia.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblProvincia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblProvincia.Location = New System.Drawing.Point(19, 137)
        Me.LblProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(90, 13)
        Me.LblProvincia.TabIndex = 52
        Me.LblProvincia.Text = "Provincia : "
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDni.Location = New System.Drawing.Point(115, 57)
        Me.TxtDni.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(244, 20)
        Me.TxtDni.TabIndex = 51
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtApellido.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtApellido.Location = New System.Drawing.Point(115, 109)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(244, 20)
        Me.TxtApellido.TabIndex = 50
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNombre.Location = New System.Drawing.Point(115, 83)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(244, 20)
        Me.TxtNombre.TabIndex = 49
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.BackColor = System.Drawing.Color.Transparent
        Me.LblDni.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDni.Location = New System.Drawing.Point(63, 60)
        Me.LblDni.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(42, 13)
        Me.LblDni.TabIndex = 48
        Me.LblDni.Text = "Dni : "
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblApellido.Location = New System.Drawing.Point(30, 112)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(75, 13)
        Me.LblApellido.TabIndex = 47
        Me.LblApellido.Text = "Apellido :"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(33, 86)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(73, 13)
        Me.LblNombre.TabIndex = 46
        Me.LblNombre.Text = "Nombre : "
        '
        'CboSexo
        '
        Me.CboSexo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboSexo.DataSource = Me.SexoBindingSource
        Me.CboSexo.DisplayMember = "descripcion"
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(581, 159)
        Me.CboSexo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(244, 21)
        Me.CboSexo.TabIndex = 67
        Me.CboSexo.ValueMember = "cod_sexo"
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.DataSet1
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(581, 184)
        Me.DtpFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(244, 20)
        Me.DtpFecha.TabIndex = 66
        Me.DtpFecha.Visible = False
        '
        'CboLocalidades
        '
        Me.CboLocalidades.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboLocalidades.DataSource = Me.LocalidadesBindingSource
        Me.CboLocalidades.DisplayMember = "descripcion"
        Me.CboLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLocalidades.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboLocalidades.FormattingEnabled = True
        Me.CboLocalidades.Location = New System.Drawing.Point(581, 132)
        Me.CboLocalidades.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CboLocalidades.Name = "CboLocalidades"
        Me.CboLocalidades.Size = New System.Drawing.Size(244, 21)
        Me.CboLocalidades.TabIndex = 65
        Me.CboLocalidades.ValueMember = "cod_localidad"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.DataSet1
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.LblLocalidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblLocalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblLocalidad.Location = New System.Drawing.Point(480, 137)
        Me.LblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(93, 13)
        Me.LblLocalidad.TabIndex = 64
        Me.LblLocalidad.Text = "Localidad : "
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblSexo.Location = New System.Drawing.Point(526, 162)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(45, 13)
        Me.LblSexo.TabIndex = 63
        Me.LblSexo.Text = "Sexo :"
        '
        'DtpFechaDeNacimiento
        '
        Me.DtpFechaDeNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.DtpFechaDeNacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DtpFechaDeNacimiento.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeNacimiento.Location = New System.Drawing.Point(581, 109)
        Me.DtpFechaDeNacimiento.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DtpFechaDeNacimiento.Name = "DtpFechaDeNacimiento"
        Me.DtpFechaDeNacimiento.Size = New System.Drawing.Size(244, 20)
        Me.DtpFechaDeNacimiento.TabIndex = 62
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaNacimiento.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(409, 112)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(162, 13)
        Me.LblFechaNacimiento.TabIndex = 61
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento :"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTelefono.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTelefono.Location = New System.Drawing.Point(581, 83)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(244, 20)
        Me.TxtTelefono.TabIndex = 60
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCorreoElectronico.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(581, 57)
        Me.TxtCorreoElectronico.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TxtCorreoElectronico.MaxLength = 35
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(244, 20)
        Me.TxtCorreoElectronico.TabIndex = 59
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTelefono.Location = New System.Drawing.Point(491, 86)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(80, 13)
        Me.LblTelefono.TabIndex = 58
        Me.LblTelefono.Text = "Telefóno :"
        '
        'LblCorreoElectronico
        '
        Me.LblCorreoElectronico.AutoSize = True
        Me.LblCorreoElectronico.BackColor = System.Drawing.Color.Transparent
        Me.LblCorreoElectronico.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCorreoElectronico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCorreoElectronico.Location = New System.Drawing.Point(406, 60)
        Me.LblCorreoElectronico.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblCorreoElectronico.Name = "LblCorreoElectronico"
        Me.LblCorreoElectronico.Size = New System.Drawing.Size(165, 13)
        Me.LblCorreoElectronico.TabIndex = 57
        Me.LblCorreoElectronico.Text = "Correo Electronico :"
        '
        'LblDatosDelCliente
        '
        Me.LblDatosDelCliente.AutoSize = True
        Me.LblDatosDelCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblDatosDelCliente.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosDelCliente.ForeColor = System.Drawing.Color.Red
        Me.LblDatosDelCliente.Location = New System.Drawing.Point(313, 9)
        Me.LblDatosDelCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblDatosDelCliente.Name = "LblDatosDelCliente"
        Me.LblDatosDelCliente.Size = New System.Drawing.Size(194, 33)
        Me.LblDatosDelCliente.TabIndex = 56
        Me.LblDatosDelCliente.Text = "Datos del Cliente"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.BackColor = System.Drawing.Color.Gray
        Me.btnGuardarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarCliente.Image = CType(resources.GetObject("btnGuardarCliente.Image"), System.Drawing.Image)
        Me.btnGuardarCliente.Location = New System.Drawing.Point(381, 209)
        Me.btnGuardarCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(112, 47)
        Me.btnGuardarCliente.TabIndex = 68
        Me.btnGuardarCliente.UseVisualStyleBackColor = False
        '
        'dtgRegistarClientes
        '
        Me.dtgRegistarClientes.AllowUserToAddRows = False
        Me.dtgRegistarClientes.AllowUserToDeleteRows = False
        Me.dtgRegistarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistarClientes.Location = New System.Drawing.Point(6, 262)
        Me.dtgRegistarClientes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtgRegistarClientes.Name = "dtgRegistarClientes"
        Me.dtgRegistarClientes.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dtgRegistarClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRegistarClientes.Size = New System.Drawing.Size(819, 243)
        Me.dtgRegistarClientes.TabIndex = 69
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(409, 510)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(70, 42)
        Me.BtnSalir.TabIndex = 70
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'LblFechaDeRegistracion
        '
        Me.LblFechaDeRegistracion.AutoSize = True
        Me.LblFechaDeRegistracion.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaDeRegistracion.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblFechaDeRegistracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblFechaDeRegistracion.Location = New System.Drawing.Point(395, 188)
        Me.LblFechaDeRegistracion.Name = "LblFechaDeRegistracion"
        Me.LblFechaDeRegistracion.Size = New System.Drawing.Size(176, 13)
        Me.LblFechaDeRegistracion.TabIndex = 71
        Me.LblFechaDeRegistracion.Text = "Fecha de Registración :"
        Me.LblFechaDeRegistracion.Visible = False
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(203, 211)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(71, 40)
        Me.BtnActualizar.TabIndex = 72
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Registrar_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LblFechaDeRegistracion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.dtgRegistarClientes)
        Me.Controls.Add(Me.btnGuardarCliente)
        Me.Controls.Add(Me.CboSexo)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.CboLocalidades)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.DtpFechaDeNacimiento)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCorreoElectronico)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblCorreoElectronico)
        Me.Controls.Add(Me.LblDatosDelCliente)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.CboProvincia)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblDni)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Registrar_Clientes"
        Me.Text = "Registrar Clientes"
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgRegistarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents CboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents CboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboLocalidades As System.Windows.Forms.ComboBox
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents LblSexo As System.Windows.Forms.Label
    Friend WithEvents DtpFechaDeNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents LblDatosDelCliente As System.Windows.Forms.Label
    Friend WithEvents btnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents dtgRegistarClientes As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents SexoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter
    Friend WithEvents LblFechaDeRegistracion As System.Windows.Forms.Label
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
End Class
