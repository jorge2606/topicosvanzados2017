<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Cliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblCorreoElectronico = New System.Windows.Forms.Label()
        Me.LblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.DtgModifcarClientes = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ClientesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.CboLocalidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.SexoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.SexoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgModifcarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Gray
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(290, 458)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(70, 42)
        Me.BtnModificar.TabIndex = 0
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Silver
        Me.LblNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(26, 71)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre :"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Silver
        Me.LblApellido.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblApellido.Location = New System.Drawing.Point(20, 97)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(75, 13)
        Me.LblApellido.TabIndex = 3
        Me.LblApellido.Text = "Apellido :"
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.BackColor = System.Drawing.Color.Silver
        Me.LblDni.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDni.Location = New System.Drawing.Point(50, 50)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(38, 13)
        Me.LblDni.TabIndex = 4
        Me.LblDni.Text = "Dni :"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.BackColor = System.Drawing.Color.Silver
        Me.LblProvincia.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblProvincia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblProvincia.Location = New System.Drawing.Point(6, 119)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(86, 13)
        Me.LblProvincia.TabIndex = 5
        Me.LblProvincia.Text = "Provincia :"
        '
        'LblCorreoElectronico
        '
        Me.LblCorreoElectronico.AutoSize = True
        Me.LblCorreoElectronico.BackColor = System.Drawing.Color.Silver
        Me.LblCorreoElectronico.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCorreoElectronico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCorreoElectronico.Location = New System.Drawing.Point(327, 50)
        Me.LblCorreoElectronico.Name = "LblCorreoElectronico"
        Me.LblCorreoElectronico.Size = New System.Drawing.Size(169, 13)
        Me.LblCorreoElectronico.TabIndex = 6
        Me.LblCorreoElectronico.Text = "Correo  Electronico :"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.BackColor = System.Drawing.Color.Silver
        Me.LblFechaDeNacimiento.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblFechaDeNacimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(334, 95)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(162, 13)
        Me.LblFechaDeNacimiento.TabIndex = 8
        Me.LblFechaDeNacimiento.Text = "Fecha de Nacimiento :"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.BackColor = System.Drawing.Color.Silver
        Me.LblLocalidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblLocalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblLocalidad.Location = New System.Drawing.Point(407, 121)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(89, 13)
        Me.LblLocalidad.TabIndex = 9
        Me.LblLocalidad.Text = "Localidad :"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Location = New System.Drawing.Point(97, 71)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(224, 20)
        Me.TxtNombre.TabIndex = 10
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtApellido.Location = New System.Drawing.Point(97, 95)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(224, 20)
        Me.TxtApellido.TabIndex = 11
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Enabled = False
        Me.TxtDni.Location = New System.Drawing.Point(97, 47)
        Me.TxtDni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(224, 20)
        Me.TxtDni.TabIndex = 12
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(516, 50)
        Me.TxtCorreoElectronico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCorreoElectronico.MaxLength = 35
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(280, 20)
        Me.TxtCorreoElectronico.TabIndex = 14
        Me.TxtCorreoElectronico.Text = "@.com"
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(517, 95)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(280, 20)
        Me.DtpFechaNacimiento.TabIndex = 18
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Underline)
        Me.LblTitulo.ForeColor = System.Drawing.Color.Red
        Me.LblTitulo.Location = New System.Drawing.Point(348, 6)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(194, 33)
        Me.LblTitulo.TabIndex = 19
        Me.LblTitulo.Text = "Datos del Cliente"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Silver
        Me.LblSexo.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblSexo.Location = New System.Drawing.Point(50, 167)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(45, 13)
        Me.LblSexo.TabIndex = 23
        Me.LblSexo.Text = "Sexo :"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(472, 458)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(70, 42)
        Me.BtnSalir.TabIndex = 26
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CboProvincia
        '
        Me.CboProvincia.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.CboProvincia.DisplayMember = "descripcion"
        Me.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvincia.FormattingEnabled = True
        Me.CboProvincia.Location = New System.Drawing.Point(97, 116)
        Me.CboProvincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboProvincia.Name = "CboProvincia"
        Me.CboProvincia.Size = New System.Drawing.Size(224, 21)
        Me.CboProvincia.TabIndex = 27
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
        'DtgModifcarClientes
        '
        Me.DtgModifcarClientes.AllowUserToAddRows = False
        Me.DtgModifcarClientes.AllowUserToDeleteRows = False
        Me.DtgModifcarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgModifcarClientes.Location = New System.Drawing.Point(9, 239)
        Me.DtgModifcarClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgModifcarClientes.Name = "DtgModifcarClientes"
        Me.DtgModifcarClientes.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgModifcarClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgModifcarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgModifcarClientes.Size = New System.Drawing.Size(828, 214)
        Me.DtgModifcarClientes.TabIndex = 45
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSet1
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusqueda.Location = New System.Drawing.Point(383, 207)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBusqueda.MaxLength = 8
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(195, 20)
        Me.TxtBusqueda.TabIndex = 42
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDireccion.Location = New System.Drawing.Point(97, 142)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDireccion.MaxLength = 25
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(224, 20)
        Me.TxtDireccion.TabIndex = 47
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.BackColor = System.Drawing.Color.Silver
        Me.LblDireccion.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDireccion.Location = New System.Drawing.Point(6, 144)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(91, 13)
        Me.LblDireccion.TabIndex = 46
        Me.LblDireccion.Text = "Dirección  :"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEstado.Location = New System.Drawing.Point(428, 143)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(68, 13)
        Me.LblEstado.TabIndex = 48
        Me.LblEstado.Text = "Estado  :"
        Me.LblEstado.Visible = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTelefono.Location = New System.Drawing.Point(516, 73)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.MaxLength = 9
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(280, 20)
        Me.TxtTelefono.TabIndex = 51
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Silver
        Me.LblTelefono.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTelefono.Location = New System.Drawing.Point(412, 73)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(84, 13)
        Me.LblTelefono.TabIndex = 50
        Me.LblTelefono.Text = "Telefóno  :"
        '
        'CboLocalidad
        '
        Me.CboLocalidad.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboLocalidad.DataSource = Me.LocalidadesBindingSource
        Me.CboLocalidad.DisplayMember = "descripcion"
        Me.CboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLocalidad.FormattingEnabled = True
        Me.CboLocalidad.Location = New System.Drawing.Point(516, 115)
        Me.CboLocalidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboLocalidad.Name = "CboLocalidad"
        Me.CboLocalidad.Size = New System.Drawing.Size(280, 21)
        Me.CboLocalidad.TabIndex = 52
        Me.CboLocalidad.ValueMember = "cod_localidad"
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
        'CboSexo
        '
        Me.CboSexo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboSexo.DataSource = Me.SexoBindingSource1
        Me.CboSexo.DisplayMember = "descripcion"
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(97, 164)
        Me.CboSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(224, 21)
        Me.CboSexo.TabIndex = 56
        Me.CboSexo.ValueMember = "cod_sexo"
        '
        'SexoBindingSource1
        '
        Me.SexoBindingSource1.DataMember = "Sexo"
        Me.SexoBindingSource1.DataSource = Me.DataSet1
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.DataSet1
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(516, 141)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(280, 21)
        Me.CboEstado.TabIndex = 57
        Me.CboEstado.ValueMember = "cod_estado"
        Me.CboEstado.Visible = False
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(383, 207)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBusquedaPorNombre.MaxLength = 40
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(195, 20)
        Me.TxtBusquedaPorNombre.TabIndex = 58
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(216, 207)
        Me.CboBusqPorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(153, 21)
        Me.CboBusqPorTipo.TabIndex = 60
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(660, 195)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(65, 40)
        Me.BtnActualizar.TabIndex = 61
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Modificar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.CboSexo)
        Me.Controls.Add(Me.CboLocalidad)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.DtgModifcarClientes)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboProvincia)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.TxtCorreoElectronico)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblFechaDeNacimiento)
        Me.Controls.Add(Me.LblCorreoElectronico)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblDni)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnModificar)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Modificar_Cliente"
        Me.Text = "Modificar Cliente"
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgModifcarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents LblFechaDeNacimiento As System.Windows.Forms.Label
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblSexo As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents DtgModifcarClientes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents CboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents CboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents SexoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
End Class
