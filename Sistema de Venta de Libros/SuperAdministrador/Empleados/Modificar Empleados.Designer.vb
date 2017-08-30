<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.PBoxPerfilEmpleado = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.CboEmpleo = New System.Windows.Forms.ComboBox()
        Me.CodigodeEmpleoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.DtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblTituloEmpleado = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.DtpRegistracion = New System.Windows.Forms.DateTimePicker()
        Me.DtgModificarEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.EmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter()
        Me.CboEstados = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboLocalidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.LocalidadesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.Codigo_de_EmpleoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.DtpFechaRegistracion = New System.Windows.Forms.DateTimePicker()
        Me.LblImagen = New System.Windows.Forms.Label()
        CType(Me.PBoxPerfilEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgModificarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(335, 464)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(79, 35)
        Me.BtnModificar.TabIndex = 0
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(17, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(54, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dni :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(29, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Empleo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(474, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Dirección :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(481, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Telefóno :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(396, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Correo Electronico :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(401, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fecha de Nacimiento :"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Location = New System.Drawing.Point(92, 45)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(284, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtApellido.Location = New System.Drawing.Point(92, 67)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(285, 20)
        Me.TxtApellido.TabIndex = 13
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Enabled = False
        Me.TxtDni.Location = New System.Drawing.Point(92, 90)
        Me.TxtDni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(284, 20)
        Me.TxtDni.TabIndex = 14
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDireccion.Location = New System.Drawing.Point(569, 44)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDireccion.MaxLength = 30
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(265, 20)
        Me.TxtDireccion.TabIndex = 17
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(569, 66)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(265, 20)
        Me.txtTelefono.TabIndex = 18
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(569, 89)
        Me.TxtCorreoElectronico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCorreoElectronico.MaxLength = 35
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(265, 20)
        Me.TxtCorreoElectronico.TabIndex = 19
        '
        'PBoxPerfilEmpleado
        '
        Me.PBoxPerfilEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.PBoxPerfilEmpleado.Location = New System.Drawing.Point(841, 45)
        Me.PBoxPerfilEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBoxPerfilEmpleado.Name = "PBoxPerfilEmpleado"
        Me.PBoxPerfilEmpleado.Size = New System.Drawing.Size(146, 109)
        Me.PBoxPerfilEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxPerfilEmpleado.TabIndex = 22
        Me.PBoxPerfilEmpleado.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(47, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Sexo :"
        '
        'BtnImagen
        '
        Me.BtnImagen.ForeColor = System.Drawing.Color.Black
        Me.BtnImagen.Image = CType(resources.GetObject("BtnImagen.Image"), System.Drawing.Image)
        Me.BtnImagen.Location = New System.Drawing.Point(887, 157)
        Me.BtnImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(54, 44)
        Me.BtnImagen.TabIndex = 26
        Me.BtnImagen.UseVisualStyleBackColor = True
        '
        'TxtRuta
        '
        Me.TxtRuta.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Font = New System.Drawing.Font("Felix Titling", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtRuta.Location = New System.Drawing.Point(569, 180)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRuta.MaxLength = 200
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(266, 25)
        Me.TxtRuta.TabIndex = 27
        '
        'CboEmpleo
        '
        Me.CboEmpleo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboEmpleo.DataSource = Me.CodigodeEmpleoBindingSource
        Me.CboEmpleo.DisplayMember = "descripcion"
        Me.CboEmpleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmpleo.FormattingEnabled = True
        Me.CboEmpleo.Location = New System.Drawing.Point(93, 112)
        Me.CboEmpleo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboEmpleo.Name = "CboEmpleo"
        Me.CboEmpleo.Size = New System.Drawing.Size(283, 21)
        Me.CboEmpleo.TabIndex = 28
        Me.CboEmpleo.ValueMember = "cod_empleo"
        '
        'CodigodeEmpleoBindingSource
        '
        Me.CodigodeEmpleoBindingSource.DataMember = "Codigo_de_Empleo"
        Me.CodigodeEmpleoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtpNacimiento
        '
        Me.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpNacimiento.Location = New System.Drawing.Point(569, 111)
        Me.DtpNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpNacimiento.Name = "DtpNacimiento"
        Me.DtpNacimiento.Size = New System.Drawing.Size(265, 20)
        Me.DtpNacimiento.TabIndex = 29
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(527, 464)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(79, 35)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblTituloEmpleado
        '
        Me.LblTituloEmpleado.AutoSize = True
        Me.LblTituloEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.LblTituloEmpleado.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Underline)
        Me.LblTituloEmpleado.ForeColor = System.Drawing.Color.Red
        Me.LblTituloEmpleado.Location = New System.Drawing.Point(378, -1)
        Me.LblTituloEmpleado.Name = "LblTituloEmpleado"
        Me.LblTituloEmpleado.Size = New System.Drawing.Size(228, 33)
        Me.LblTituloEmpleado.TabIndex = 34
        Me.LblTituloEmpleado.Text = "Datos del Empleado"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CboSexo
        '
        Me.CboSexo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboSexo.DataSource = Me.SexoBindingSource
        Me.CboSexo.DisplayMember = "descripcion"
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(93, 135)
        Me.CboSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(167, 21)
        Me.CboSexo.TabIndex = 35
        Me.CboSexo.ValueMember = "cod_sexo"
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
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.LblLocalidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblLocalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblLocalidad.Location = New System.Drawing.Point(476, 162)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(89, 13)
        Me.LblLocalidad.TabIndex = 37
        Me.LblLocalidad.Text = "Localidad :"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LblProvincia.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblProvincia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblProvincia.Location = New System.Drawing.Point(479, 140)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(86, 13)
        Me.LblProvincia.TabIndex = 36
        Me.LblProvincia.Text = "Provincia :"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEstado.Location = New System.Drawing.Point(24, 163)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(68, 13)
        Me.LblEstado.TabIndex = 40
        Me.LblEstado.Text = "Estado  :"
        Me.LblEstado.Visible = False
        '
        'DtpRegistracion
        '
        Me.DtpRegistracion.Enabled = False
        Me.DtpRegistracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpRegistracion.Location = New System.Drawing.Point(12, 329)
        Me.DtpRegistracion.Name = "DtpRegistracion"
        Me.DtpRegistracion.Size = New System.Drawing.Size(298, 20)
        Me.DtpRegistracion.TabIndex = 42
        '
        'DtgModificarEmpleados
        '
        Me.DtgModificarEmpleados.AllowUserToAddRows = False
        Me.DtgModificarEmpleados.AllowUserToDeleteRows = False
        Me.DtgModificarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgModificarEmpleados.Location = New System.Drawing.Point(1, 261)
        Me.DtgModificarEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgModificarEmpleados.Name = "DtgModificarEmpleados"
        Me.DtgModificarEmpleados.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DtgModificarEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgModificarEmpleados.Size = New System.Drawing.Size(978, 199)
        Me.DtgModificarEmpleados.TabIndex = 44
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DataSet1
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(494, 228)
        Me.TxtBusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(143, 20)
        Me.TxtBusqueda.TabIndex = 45
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'CboEstados
        '
        Me.CboEstados.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboEstados.DataSource = Me.EstadoBindingSource
        Me.CboEstados.DisplayMember = "descripcion"
        Me.CboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstados.FormattingEnabled = True
        Me.CboEstados.Location = New System.Drawing.Point(94, 160)
        Me.CboEstados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboEstados.Name = "CboEstados"
        Me.CboEstados.Size = New System.Drawing.Size(167, 21)
        Me.CboEstados.TabIndex = 48
        Me.CboEstados.ValueMember = "cod_estado"
        Me.CboEstados.Visible = False
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'CboProvincia
        '
        Me.CboProvincia.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.CboProvincia.DisplayMember = "descripcion"
        Me.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvincia.FormattingEnabled = True
        Me.CboProvincia.Location = New System.Drawing.Point(569, 135)
        Me.CboProvincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboProvincia.Name = "CboProvincia"
        Me.CboProvincia.Size = New System.Drawing.Size(265, 21)
        Me.CboProvincia.TabIndex = 49
        Me.CboProvincia.ValueMember = "cod_Provincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.DataSet1
        '
        'CboLocalidad
        '
        Me.CboLocalidad.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboLocalidad.DataSource = Me.LocalidadesBindingSource
        Me.CboLocalidad.DisplayMember = "descripcion"
        Me.CboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLocalidad.FormattingEnabled = True
        Me.CboLocalidad.Location = New System.Drawing.Point(569, 157)
        Me.CboLocalidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboLocalidad.Name = "CboLocalidad"
        Me.CboLocalidad.Size = New System.Drawing.Size(265, 21)
        Me.CboLocalidad.TabIndex = 50
        Me.CboLocalidad.ValueMember = "cod_localidad"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.DataSet1
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(252, 227)
        Me.CboBusqPorTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(162, 21)
        Me.CboBusqPorTipo.TabIndex = 51
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(431, 228)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(222, 20)
        Me.TxtBusquedaPorNombre.TabIndex = 54
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'Codigo_de_EmpleoTableAdapter
        '
        Me.Codigo_de_EmpleoTableAdapter.ClearBeforeFill = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(679, 222)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(71, 29)
        Me.BtnActualizar.TabIndex = 55
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'DtpFechaRegistracion
        '
        Me.DtpFechaRegistracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaRegistracion.Location = New System.Drawing.Point(570, 181)
        Me.DtpFechaRegistracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpFechaRegistracion.Name = "DtpFechaRegistracion"
        Me.DtpFechaRegistracion.Size = New System.Drawing.Size(265, 20)
        Me.DtpFechaRegistracion.TabIndex = 57
        Me.DtpFechaRegistracion.Visible = False
        '
        'LblImagen
        '
        Me.LblImagen.AutoSize = True
        Me.LblImagen.BackColor = System.Drawing.Color.Transparent
        Me.LblImagen.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblImagen.Location = New System.Drawing.Point(497, 187)
        Me.LblImagen.Name = "LblImagen"
        Me.LblImagen.Size = New System.Drawing.Size(64, 13)
        Me.LblImagen.TabIndex = 58
        Me.LblImagen.Text = "Imagen :"
        '
        'Modificar_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblImagen)
        Me.Controls.Add(Me.DtpFechaRegistracion)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.CboLocalidad)
        Me.Controls.Add(Me.CboProvincia)
        Me.Controls.Add(Me.CboEstados)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.DtgModificarEmpleados)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.CboSexo)
        Me.Controls.Add(Me.LblTituloEmpleado)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DtpNacimiento)
        Me.Controls.Add(Me.CboEmpleo)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnImagen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PBoxPerfilEmpleado)
        Me.Controls.Add(Me.TxtCorreoElectronico)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Modificar_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Empleados"
        CType(Me.PBoxPerfilEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgModificarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents PBoxPerfilEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents TxtRuta As System.Windows.Forms.TextBox
    Friend WithEvents CboEmpleo As System.Windows.Forms.ComboBox
    Friend WithEvents DtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblTituloEmpleado As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents DtpRegistracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtgModificarEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents EmpleadosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents CboEstados As System.Windows.Forms.ComboBox
    Friend WithEvents CboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents CboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents CodigodeEmpleoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Codigo_de_EmpleoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents DtpFechaRegistracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblImagen As System.Windows.Forms.Label
End Class
