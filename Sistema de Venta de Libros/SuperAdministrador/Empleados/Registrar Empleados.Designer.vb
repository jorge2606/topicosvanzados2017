<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblEmpleo = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.TxtRutaDeFoto = New System.Windows.Forms.TextBox()
        Me.CboEmpleo = New System.Windows.Forms.ComboBox()
        Me.CodigodeEmpleoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PBoxPerfilEmpleado = New System.Windows.Forms.PictureBox()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefóno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_Electronico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Fecha_de_Nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtgRegistrarEmpleados = New System.Windows.Forms.DataGridView()
        Me.Eliminar_Empleado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar_Empl = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BntSalir = New System.Windows.Forms.Button()
        Me.EmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboLocalidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PtboxPerfilEmpleado = New System.Windows.Forms.PictureBox()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.DtpFechaRegistracion = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaRegistracion = New System.Windows.Forms.Label()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.LblNuevoUsuarioDelSistema = New System.Windows.Forms.Label()
        Me.Codigo_de_EmpleoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter()
        Me.SexoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.LocalidadesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter()
        Me.LblImagen = New System.Windows.Forms.Label()
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxPerfilEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgRegistrarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtboxPerfilEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(16, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(10, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(45, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dni :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(-2, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(5, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefóno :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(336, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Correo Electroníco :"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNombre.Location = New System.Drawing.Point(89, 72)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(241, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtApellido.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtApellido.Location = New System.Drawing.Point(89, 94)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(241, 20)
        Me.TxtApellido.TabIndex = 8
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Location = New System.Drawing.Point(89, 51)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(241, 20)
        Me.TxtDni.TabIndex = 9
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDireccion.Location = New System.Drawing.Point(89, 144)
        Me.TxtDireccion.MaxLength = 35
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(241, 20)
        Me.TxtDireccion.TabIndex = 10
        '
        'TxtCorreoElectronico
        '
        Me.TxtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCorreoElectronico.Location = New System.Drawing.Point(503, 54)
        Me.TxtCorreoElectronico.MaxLength = 35
        Me.TxtCorreoElectronico.Name = "TxtCorreoElectronico"
        Me.TxtCorreoElectronico.Size = New System.Drawing.Size(246, 20)
        Me.TxtCorreoElectronico.TabIndex = 11
        Me.TxtCorreoElectronico.Text = "@.com"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTelefono.Location = New System.Drawing.Point(89, 170)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(241, 20)
        Me.TxtTelefono.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(324, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Datos del futuro Empleado"
        '
        'LblEmpleo
        '
        Me.LblEmpleo.AutoSize = True
        Me.LblEmpleo.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpleo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEmpleo.Location = New System.Drawing.Point(22, 123)
        Me.LblEmpleo.Name = "LblEmpleo"
        Me.LblEmpleo.Size = New System.Drawing.Size(63, 13)
        Me.LblEmpleo.TabIndex = 14
        Me.LblEmpleo.Text = "Empleo :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(347, 77)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Feha de Nacimiento :"
        '
        'DtpFechaDeNacimiento
        '
        Me.DtpFechaDeNacimiento.CalendarFont = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaDeNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.DtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDeNacimiento.Location = New System.Drawing.Point(502, 77)
        Me.DtpFechaDeNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpFechaDeNacimiento.MaxDate = New Date(2015, 12, 12, 0, 0, 0, 0)
        Me.DtpFechaDeNacimiento.MinDate = New Date(1935, 1, 1, 0, 0, 0, 0)
        Me.DtpFechaDeNacimiento.Name = "DtpFechaDeNacimiento"
        Me.DtpFechaDeNacimiento.Size = New System.Drawing.Size(247, 20)
        Me.DtpFechaDeNacimiento.TabIndex = 21
        Me.DtpFechaDeNacimiento.Value = New Date(2015, 10, 4, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(455, 102)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sexo :"
        '
        'BtnImagen
        '
        Me.BtnImagen.BackColor = System.Drawing.Color.White
        Me.BtnImagen.ForeColor = System.Drawing.Color.Black
        Me.BtnImagen.Image = CType(resources.GetObject("BtnImagen.Image"), System.Drawing.Image)
        Me.BtnImagen.Location = New System.Drawing.Point(817, 164)
        Me.BtnImagen.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(65, 36)
        Me.BtnImagen.TabIndex = 27
        Me.BtnImagen.UseVisualStyleBackColor = False
        '
        'TxtRutaDeFoto
        '
        Me.TxtRutaDeFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRutaDeFoto.Enabled = False
        Me.TxtRutaDeFoto.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtRutaDeFoto.Location = New System.Drawing.Point(500, 170)
        Me.TxtRutaDeFoto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRutaDeFoto.MaxLength = 200
        Me.TxtRutaDeFoto.Name = "TxtRutaDeFoto"
        Me.TxtRutaDeFoto.Size = New System.Drawing.Size(249, 20)
        Me.TxtRutaDeFoto.TabIndex = 28
        '
        'CboEmpleo
        '
        Me.CboEmpleo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboEmpleo.DataSource = Me.CodigodeEmpleoBindingSource
        Me.CboEmpleo.DisplayMember = "descripcion"
        Me.CboEmpleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmpleo.FormattingEnabled = True
        Me.CboEmpleo.Location = New System.Drawing.Point(89, 118)
        Me.CboEmpleo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboEmpleo.Name = "CboEmpleo"
        Me.CboEmpleo.Size = New System.Drawing.Size(241, 21)
        Me.CboEmpleo.TabIndex = 29
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
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.White
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(431, 262)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(78, 36)
        Me.BtnAgregar.TabIndex = 30
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PBoxPerfilEmpleado
        '
        Me.PBoxPerfilEmpleado.BackColor = System.Drawing.Color.Silver
        Me.PBoxPerfilEmpleado.Location = New System.Drawing.Point(1006, 15)
        Me.PBoxPerfilEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBoxPerfilEmpleado.Name = "PBoxPerfilEmpleado"
        Me.PBoxPerfilEmpleado.Size = New System.Drawing.Size(176, 123)
        Me.PBoxPerfilEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxPerfilEmpleado.TabIndex = 17
        Me.PBoxPerfilEmpleado.TabStop = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Dni
        '
        Me.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Dni.HeaderText = "Dni"
        Me.Dni.Name = "Dni"
        '
        'Empleo
        '
        Me.Empleo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Empleo.HeaderText = "Empleo"
        Me.Empleo.Name = "Empleo"
        '
        'Dirección
        '
        Me.Dirección.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        '
        'Telefóno
        '
        Me.Telefóno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Telefóno.HeaderText = "Telefóno"
        Me.Telefóno.Name = "Telefóno"
        '
        'Correo_Electronico
        '
        Me.Correo_Electronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Correo_Electronico.HeaderText = "Correo Electronico"
        Me.Correo_Electronico.Name = "Correo_Electronico"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Text = "Midificar"
        Me.Modificar.UseColumnTextForButtonValue = True
        '
        'Fecha_de_Nacimiento
        '
        Me.Fecha_de_Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha_de_Nacimiento.HeaderText = "Fecha de Nacimiento"
        Me.Fecha_de_Nacimiento.Name = "Fecha_de_Nacimiento"
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        '
        'Sexo
        '
        Me.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'DtgRegistrarEmpleados
        '
        Me.DtgRegistrarEmpleados.AllowUserToAddRows = False
        Me.DtgRegistrarEmpleados.AllowUserToDeleteRows = False
        Me.DtgRegistrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRegistrarEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar_Empleado, Me.Modificar_Empl})
        Me.DtgRegistrarEmpleados.Location = New System.Drawing.Point(-4, 302)
        Me.DtgRegistrarEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.DtgRegistrarEmpleados.Name = "DtgRegistrarEmpleados"
        Me.DtgRegistrarEmpleados.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgRegistrarEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgRegistrarEmpleados.Size = New System.Drawing.Size(946, 233)
        Me.DtgRegistrarEmpleados.TabIndex = 31
        '
        'Eliminar_Empleado
        '
        Me.Eliminar_Empleado.HeaderText = "Eliminar"
        Me.Eliminar_Empleado.Name = "Eliminar_Empleado"
        Me.Eliminar_Empleado.ReadOnly = True
        Me.Eliminar_Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar_Empleado.Text = "Eliminar"
        Me.Eliminar_Empleado.UseColumnTextForButtonValue = True
        '
        'Modificar_Empl
        '
        Me.Modificar_Empl.HeaderText = "Modificar"
        Me.Modificar_Empl.Name = "Modificar_Empl"
        Me.Modificar_Empl.ReadOnly = True
        Me.Modificar_Empl.Text = "Modificar"
        Me.Modificar_Empl.UseColumnTextForButtonValue = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DataSet1
        '
        'BntSalir
        '
        Me.BntSalir.BackColor = System.Drawing.Color.White
        Me.BntSalir.ForeColor = System.Drawing.Color.Black
        Me.BntSalir.Image = CType(resources.GetObject("BntSalir.Image"), System.Drawing.Image)
        Me.BntSalir.Location = New System.Drawing.Point(633, 262)
        Me.BntSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BntSalir.Name = "BntSalir"
        Me.BntSalir.Size = New System.Drawing.Size(74, 34)
        Me.BntSalir.TabIndex = 34
        Me.BntSalir.UseVisualStyleBackColor = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'CboSexo
        '
        Me.CboSexo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboSexo.DataSource = Me.SexoBindingSource
        Me.CboSexo.DisplayMember = "descripcion"
        Me.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(500, 99)
        Me.CboSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(249, 21)
        Me.CboSexo.TabIndex = 35
        Me.CboSexo.ValueMember = "cod_sexo"
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.DataSet1
        '
        'CboProvincia
        '
        Me.CboProvincia.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboProvincia.DataSource = Me.ProvinciasBindingSource
        Me.CboProvincia.DisplayMember = "descripcion"
        Me.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvincia.FormattingEnabled = True
        Me.CboProvincia.Location = New System.Drawing.Point(500, 124)
        Me.CboProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.CboProvincia.Name = "CboProvincia"
        Me.CboProvincia.Size = New System.Drawing.Size(249, 21)
        Me.CboProvincia.TabIndex = 36
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
        Me.CboLocalidad.Location = New System.Drawing.Point(500, 147)
        Me.CboLocalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.CboLocalidad.Name = "CboLocalidad"
        Me.CboLocalidad.Size = New System.Drawing.Size(249, 21)
        Me.CboLocalidad.TabIndex = 37
        Me.CboLocalidad.ValueMember = "cod_localidad"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.DataSet1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(415, 127)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Provincia :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(412, 151)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Localidad :"
        '
        'PtboxPerfilEmpleado
        '
        Me.PtboxPerfilEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.PtboxPerfilEmpleado.Location = New System.Drawing.Point(769, 54)
        Me.PtboxPerfilEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.PtboxPerfilEmpleado.Name = "PtboxPerfilEmpleado"
        Me.PtboxPerfilEmpleado.Size = New System.Drawing.Size(173, 102)
        Me.PtboxPerfilEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtboxPerfilEmpleado.TabIndex = 40
        Me.PtboxPerfilEmpleado.TabStop = False
        '
        'BtnCambiar
        '
        Me.BtnCambiar.ForeColor = System.Drawing.Color.Black
        Me.BtnCambiar.Location = New System.Drawing.Point(792, 204)
        Me.BtnCambiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(125, 19)
        Me.BtnCambiar.TabIndex = 41
        Me.BtnCambiar.Text = "Cambiar imagen"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'DtpFechaRegistracion
        '
        Me.DtpFechaRegistracion.Enabled = False
        Me.DtpFechaRegistracion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaRegistracion.Location = New System.Drawing.Point(758, 25)
        Me.DtpFechaRegistracion.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpFechaRegistracion.Name = "DtpFechaRegistracion"
        Me.DtpFechaRegistracion.Size = New System.Drawing.Size(178, 20)
        Me.DtpFechaRegistracion.TabIndex = 42
        Me.DtpFechaRegistracion.Value = New Date(2015, 10, 4, 0, 0, 0, 0)
        Me.DtpFechaRegistracion.Visible = False
        '
        'LblFechaRegistracion
        '
        Me.LblFechaRegistracion.AutoSize = True
        Me.LblFechaRegistracion.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaRegistracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblFechaRegistracion.Location = New System.Drawing.Point(759, 9)
        Me.LblFechaRegistracion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaRegistracion.Name = "LblFechaRegistracion"
        Me.LblFechaRegistracion.Size = New System.Drawing.Size(176, 13)
        Me.LblFechaRegistracion.TabIndex = 43
        Me.LblFechaRegistracion.Text = "Fecha de Registración :"
        Me.LblFechaRegistracion.Visible = False
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
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(211, 264)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(74, 34)
        Me.BtnActualizar.TabIndex = 50
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'LblNuevoUsuarioDelSistema
        '
        Me.LblNuevoUsuarioDelSistema.AutoSize = True
        Me.LblNuevoUsuarioDelSistema.BackColor = System.Drawing.Color.Transparent
        Me.LblNuevoUsuarioDelSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblNuevoUsuarioDelSistema.Font = New System.Drawing.Font("Felix Titling", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevoUsuarioDelSistema.ForeColor = System.Drawing.Color.Red
        Me.LblNuevoUsuarioDelSistema.Location = New System.Drawing.Point(415, 230)
        Me.LblNuevoUsuarioDelSistema.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNuevoUsuarioDelSistema.Name = "LblNuevoUsuarioDelSistema"
        Me.LblNuevoUsuarioDelSistema.Size = New System.Drawing.Size(185, 13)
        Me.LblNuevoUsuarioDelSistema.TabIndex = 51
        Me.LblNuevoUsuarioDelSistema.Text = "Registrar Como Usuario"
        '
        'Codigo_de_EmpleoTableAdapter
        '
        Me.Codigo_de_EmpleoTableAdapter.ClearBeforeFill = True
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'LblImagen
        '
        Me.LblImagen.AutoSize = True
        Me.LblImagen.BackColor = System.Drawing.Color.Transparent
        Me.LblImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblImagen.Location = New System.Drawing.Point(432, 175)
        Me.LblImagen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblImagen.Name = "LblImagen"
        Me.LblImagen.Size = New System.Drawing.Size(64, 13)
        Me.LblImagen.TabIndex = 52
        Me.LblImagen.Text = "Imagen :"
        '
        'Registrar_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblImagen)
        Me.Controls.Add(Me.LblNuevoUsuarioDelSistema)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LblFechaRegistracion)
        Me.Controls.Add(Me.DtpFechaRegistracion)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.PtboxPerfilEmpleado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboLocalidad)
        Me.Controls.Add(Me.CboProvincia)
        Me.Controls.Add(Me.CboSexo)
        Me.Controls.Add(Me.BntSalir)
        Me.Controls.Add(Me.DtgRegistrarEmpleados)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.CboEmpleo)
        Me.Controls.Add(Me.TxtRutaDeFoto)
        Me.Controls.Add(Me.BtnImagen)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DtpFechaDeNacimiento)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblEmpleo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCorreoElectronico)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Registrar_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxPerfilEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgRegistrarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtboxPerfilEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblEmpleo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaDeNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents TxtRutaDeFoto As System.Windows.Forms.TextBox
    Friend WithEvents CboEmpleo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PBoxPerfilEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dirección As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefóno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo_Electronico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Fecha_de_Nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtgRegistrarEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents BntSalir As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents EmpleadosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents CodEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodempleoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents CboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents CboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Eliminar_Empleado As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Modificar_Empl As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PtboxPerfilEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents DtpFechaRegistracion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaRegistracion As System.Windows.Forms.Label
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents LblNuevoUsuarioDelSistema As System.Windows.Forms.Label
    Friend WithEvents CodigodeEmpleoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Codigo_de_EmpleoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.SexoTableAdapter
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents LocalidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LocalidadesTableAdapter
    Friend WithEvents LblImagen As System.Windows.Forms.Label
End Class
