<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtgRegistrarLibros = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PtBoxPerfil = New System.Windows.Forms.PictureBox()
        Me.BtnAgregarLibros = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter()
        Me.CategoriasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.AutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoresTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.AutoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblAutor1 = New System.Windows.Forms.Label()
        Me.AutoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblAutor2 = New System.Windows.Forms.Label()
        Me.TxtAños = New System.Windows.Forms.TextBox()
        Me.BtnAgregarAño = New System.Windows.Forms.Button()
        Me.BtnQuitarAño = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtISBN = New System.Windows.Forms.TextBox()
        Me.LblISBN = New System.Windows.Forms.Label()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.TxtAutor = New System.Windows.Forms.TextBox()
        Me.TxtAutor1 = New System.Windows.Forms.TextBox()
        Me.TxtAutor2 = New System.Windows.Forms.TextBox()
        Me.BtnAyudaAutor = New System.Windows.Forms.Button()
        Me.TxtNroDeAutor = New System.Windows.Forms.TextBox()
        Me.TxtNroDeAutor1 = New System.Windows.Forms.TextBox()
        Me.TxtNroDeAutor2 = New System.Windows.Forms.TextBox()
        Me.BtnAyudaAutor1 = New System.Windows.Forms.Button()
        Me.BtnAyudaAutor2 = New System.Windows.Forms.Button()
        Me.BtnLimpiarAutor = New System.Windows.Forms.Button()
        Me.BtnLimpiarAutor1 = New System.Windows.Forms.Button()
        Me.BtnLimpiarAutor2 = New System.Windows.Forms.Button()
        Me.DtpRegistracionDelLibro = New System.Windows.Forms.DateTimePicker()
        Me.LblImagen = New System.Windows.Forms.Label()
        CType(Me.DtgRegistrarLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtBoxPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(37, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(18, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoría :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(63, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Año :"
        '
        'TxtAno
        '
        Me.TxtAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAno.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAno.Location = New System.Drawing.Point(173, 128)
        Me.TxtAno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtAno.MaxLength = 2
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(54, 20)
        Me.TxtAno.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNombre.Location = New System.Drawing.Point(112, 75)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNombre.MaxLength = 35
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(213, 20)
        Me.TxtNombre.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(355, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Autor :"
        '
        'DtgRegistrarLibros
        '
        Me.DtgRegistrarLibros.AllowUserToAddRows = False
        Me.DtgRegistrarLibros.AllowUserToDeleteRows = False
        Me.DtgRegistrarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRegistrarLibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Modificar})
        Me.DtgRegistrarLibros.Location = New System.Drawing.Point(2, 301)
        Me.DtgRegistrarLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgRegistrarLibros.Name = "DtgRegistrarLibros"
        Me.DtgRegistrarLibros.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgRegistrarLibros.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgRegistrarLibros.Size = New System.Drawing.Size(861, 290)
        Me.DtgRegistrarLibros.TabIndex = 12
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseColumnTextForButtonValue = True
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExaminar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExaminar.ForeColor = System.Drawing.Color.Black
        Me.btnExaminar.Image = CType(resources.GetObject("btnExaminar.Image"), System.Drawing.Image)
        Me.btnExaminar.Location = New System.Drawing.Point(766, 170)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(73, 46)
        Me.btnExaminar.TabIndex = 17
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'TxtRuta
        '
        Me.TxtRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtRuta.Location = New System.Drawing.Point(416, 150)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRuta.MaxLength = 200
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(175, 20)
        Me.TxtRuta.TabIndex = 18
        '
        'CboCategoria
        '
        Me.CboCategoria.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboCategoria.DataSource = Me.BindingSource2
        Me.CboCategoria.DisplayMember = "descripcion"
        Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(112, 102)
        Me.CboCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(213, 21)
        Me.CboCategoria.TabIndex = 19
        Me.CboCategoria.ValueMember = "cod_categoria"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Categorias"
        Me.BindingSource2.DataSource = Me.DataSet1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(25, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cantidad :"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCantidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCantidad.Location = New System.Drawing.Point(111, 153)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCantidad.MaxLength = 3
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(115, 20)
        Me.TxtCantidad.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(354, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Precio : "
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPrecio.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtPrecio.Location = New System.Drawing.Point(415, 47)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPrecio.MaxLength = 6
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(175, 20)
        Me.TxtPrecio.TabIndex = 24
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(444, 595)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(79, 55)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PtBoxPerfil
        '
        Me.PtBoxPerfil.BackColor = System.Drawing.Color.DarkGray
        Me.PtBoxPerfil.Location = New System.Drawing.Point(730, 60)
        Me.PtBoxPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PtBoxPerfil.Name = "PtBoxPerfil"
        Me.PtBoxPerfil.Size = New System.Drawing.Size(133, 101)
        Me.PtBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtBoxPerfil.TabIndex = 15
        Me.PtBoxPerfil.TabStop = False
        '
        'BtnAgregarLibros
        '
        Me.BtnAgregarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAgregarLibros.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregarLibros.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregarLibros.Image = CType(resources.GetObject("BtnAgregarLibros.Image"), System.Drawing.Image)
        Me.BtnAgregarLibros.Location = New System.Drawing.Point(412, 245)
        Me.BtnAgregarLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarLibros.Name = "BtnAgregarLibros"
        Me.BtnAgregarLibros.Size = New System.Drawing.Size(79, 51)
        Me.BtnAgregarLibros.TabIndex = 13
        Me.BtnAgregarLibros.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'BtnCambiar
        '
        Me.BtnCambiar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCambiar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCambiar.ForeColor = System.Drawing.Color.Black
        Me.BtnCambiar.Location = New System.Drawing.Point(670, 187)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(90, 29)
        Me.BtnCambiar.TabIndex = 25
        Me.BtnCambiar.Text = "Cambiar"
        Me.BtnCambiar.UseVisualStyleBackColor = False
        '
        'AutoresBindingSource
        '
        Me.AutoresBindingSource.DataMember = "Autores"
        Me.AutoresBindingSource.DataSource = Me.DataSet1
        '
        'AutoresTableAdapter
        '
        Me.AutoresTableAdapter.ClearBeforeFill = True
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
        'AutoresBindingSource1
        '
        Me.AutoresBindingSource1.DataMember = "Autores"
        Me.AutoresBindingSource1.DataSource = Me.DataSet1
        '
        'LblAutor1
        '
        Me.LblAutor1.AutoSize = True
        Me.LblAutor1.BackColor = System.Drawing.Color.Transparent
        Me.LblAutor1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAutor1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblAutor1.Location = New System.Drawing.Point(343, 102)
        Me.LblAutor1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAutor1.Name = "LblAutor1"
        Me.LblAutor1.Size = New System.Drawing.Size(76, 13)
        Me.LblAutor1.TabIndex = 29
        Me.LblAutor1.Text = "Autor  1 : "
        '
        'AutoresBindingSource2
        '
        Me.AutoresBindingSource2.DataMember = "Autores"
        Me.AutoresBindingSource2.DataSource = Me.DataSet1
        '
        'LblAutor2
        '
        Me.LblAutor2.AutoSize = True
        Me.LblAutor2.BackColor = System.Drawing.Color.Transparent
        Me.LblAutor2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAutor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblAutor2.Location = New System.Drawing.Point(341, 129)
        Me.LblAutor2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAutor2.Name = "LblAutor2"
        Me.LblAutor2.Size = New System.Drawing.Size(75, 13)
        Me.LblAutor2.TabIndex = 31
        Me.LblAutor2.Text = "Autor 2  :"
        '
        'TxtAños
        '
        Me.TxtAños.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAños.Enabled = False
        Me.TxtAños.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAños.Location = New System.Drawing.Point(111, 128)
        Me.TxtAños.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtAños.MaxLength = 2
        Me.TxtAños.Name = "TxtAños"
        Me.TxtAños.Size = New System.Drawing.Size(54, 20)
        Me.TxtAños.TabIndex = 33
        '
        'BtnAgregarAño
        '
        Me.BtnAgregarAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAgregarAño.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregarAño.Image = CType(resources.GetObject("BtnAgregarAño.Image"), System.Drawing.Image)
        Me.BtnAgregarAño.Location = New System.Drawing.Point(234, 124)
        Me.BtnAgregarAño.Name = "BtnAgregarAño"
        Me.BtnAgregarAño.Size = New System.Drawing.Size(35, 26)
        Me.BtnAgregarAño.TabIndex = 34
        Me.BtnAgregarAño.UseVisualStyleBackColor = True
        '
        'BtnQuitarAño
        '
        Me.BtnQuitarAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnQuitarAño.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuitarAño.Image = CType(resources.GetObject("BtnQuitarAño.Image"), System.Drawing.Image)
        Me.BtnQuitarAño.Location = New System.Drawing.Point(275, 124)
        Me.BtnQuitarAño.Name = "BtnQuitarAño"
        Me.BtnQuitarAño.Size = New System.Drawing.Size(35, 26)
        Me.BtnQuitarAño.TabIndex = 35
        Me.BtnQuitarAño.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(256, 251)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(89, 45)
        Me.BtnActualizar.TabIndex = 50
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtISBN
        '
        Me.TxtISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtISBN.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtISBN.Location = New System.Drawing.Point(112, 51)
        Me.TxtISBN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtISBN.MaxLength = 8
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.Size = New System.Drawing.Size(213, 20)
        Me.TxtISBN.TabIndex = 52
        '
        'LblISBN
        '
        Me.LblISBN.AutoSize = True
        Me.LblISBN.BackColor = System.Drawing.Color.Transparent
        Me.LblISBN.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblISBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblISBN.Location = New System.Drawing.Point(60, 54)
        Me.LblISBN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblISBN.Name = "LblISBN"
        Me.LblISBN.Size = New System.Drawing.Size(45, 13)
        Me.LblISBN.TabIndex = 51
        Me.LblISBN.Text = "ISBN  :"
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiarCampos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarCampos.Image = CType(resources.GetObject("BtnLimpiarCampos.Image"), System.Drawing.Image)
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(535, 251)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(89, 45)
        Me.BtnLimpiarCampos.TabIndex = 53
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'TxtAutor
        '
        Me.TxtAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAutor.Enabled = False
        Me.TxtAutor.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAutor.Location = New System.Drawing.Point(416, 75)
        Me.TxtAutor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAutor.MaxLength = 6
        Me.TxtAutor.Name = "TxtAutor"
        Me.TxtAutor.Size = New System.Drawing.Size(175, 20)
        Me.TxtAutor.TabIndex = 55
        '
        'TxtAutor1
        '
        Me.TxtAutor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAutor1.Enabled = False
        Me.TxtAutor1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAutor1.Location = New System.Drawing.Point(414, 100)
        Me.TxtAutor1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAutor1.MaxLength = 6
        Me.TxtAutor1.Name = "TxtAutor1"
        Me.TxtAutor1.Size = New System.Drawing.Size(175, 20)
        Me.TxtAutor1.TabIndex = 56
        '
        'TxtAutor2
        '
        Me.TxtAutor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAutor2.Enabled = False
        Me.TxtAutor2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAutor2.Location = New System.Drawing.Point(415, 126)
        Me.TxtAutor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAutor2.MaxLength = 6
        Me.TxtAutor2.Name = "TxtAutor2"
        Me.TxtAutor2.Size = New System.Drawing.Size(175, 20)
        Me.TxtAutor2.TabIndex = 57
        '
        'BtnAyudaAutor
        '
        Me.BtnAyudaAutor.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAyudaAutor.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAyudaAutor.ForeColor = System.Drawing.Color.Black
        Me.BtnAyudaAutor.Location = New System.Drawing.Point(647, 65)
        Me.BtnAyudaAutor.Name = "BtnAyudaAutor"
        Me.BtnAyudaAutor.Size = New System.Drawing.Size(67, 28)
        Me.BtnAyudaAutor.TabIndex = 58
        Me.BtnAyudaAutor.Text = "Buscar"
        Me.BtnAyudaAutor.UseVisualStyleBackColor = False
        '
        'TxtNroDeAutor
        '
        Me.TxtNroDeAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNroDeAutor.Enabled = False
        Me.TxtNroDeAutor.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNroDeAutor.Location = New System.Drawing.Point(415, 74)
        Me.TxtNroDeAutor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNroDeAutor.MaxLength = 6
        Me.TxtNroDeAutor.Name = "TxtNroDeAutor"
        Me.TxtNroDeAutor.Size = New System.Drawing.Size(173, 20)
        Me.TxtNroDeAutor.TabIndex = 59
        Me.TxtNroDeAutor.Visible = False
        '
        'TxtNroDeAutor1
        '
        Me.TxtNroDeAutor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNroDeAutor1.Enabled = False
        Me.TxtNroDeAutor1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNroDeAutor1.Location = New System.Drawing.Point(415, 100)
        Me.TxtNroDeAutor1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNroDeAutor1.MaxLength = 6
        Me.TxtNroDeAutor1.Name = "TxtNroDeAutor1"
        Me.TxtNroDeAutor1.Size = New System.Drawing.Size(177, 20)
        Me.TxtNroDeAutor1.TabIndex = 60
        Me.TxtNroDeAutor1.Visible = False
        '
        'TxtNroDeAutor2
        '
        Me.TxtNroDeAutor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNroDeAutor2.Enabled = False
        Me.TxtNroDeAutor2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNroDeAutor2.Location = New System.Drawing.Point(416, 126)
        Me.TxtNroDeAutor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNroDeAutor2.MaxLength = 6
        Me.TxtNroDeAutor2.Name = "TxtNroDeAutor2"
        Me.TxtNroDeAutor2.Size = New System.Drawing.Size(175, 20)
        Me.TxtNroDeAutor2.TabIndex = 61
        Me.TxtNroDeAutor2.Visible = False
        '
        'BtnAyudaAutor1
        '
        Me.BtnAyudaAutor1.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAyudaAutor1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAyudaAutor1.ForeColor = System.Drawing.Color.Black
        Me.BtnAyudaAutor1.Location = New System.Drawing.Point(647, 96)
        Me.BtnAyudaAutor1.Name = "BtnAyudaAutor1"
        Me.BtnAyudaAutor1.Size = New System.Drawing.Size(67, 28)
        Me.BtnAyudaAutor1.TabIndex = 62
        Me.BtnAyudaAutor1.Text = "Buscar"
        Me.BtnAyudaAutor1.UseVisualStyleBackColor = False
        '
        'BtnAyudaAutor2
        '
        Me.BtnAyudaAutor2.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAyudaAutor2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAyudaAutor2.ForeColor = System.Drawing.Color.Black
        Me.BtnAyudaAutor2.Location = New System.Drawing.Point(647, 123)
        Me.BtnAyudaAutor2.Name = "BtnAyudaAutor2"
        Me.BtnAyudaAutor2.Size = New System.Drawing.Size(68, 31)
        Me.BtnAyudaAutor2.TabIndex = 63
        Me.BtnAyudaAutor2.Text = "Buscar"
        Me.BtnAyudaAutor2.UseVisualStyleBackColor = False
        '
        'BtnLimpiarAutor
        '
        Me.BtnLimpiarAutor.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiarAutor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiarAutor.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarAutor.Image = CType(resources.GetObject("BtnLimpiarAutor.Image"), System.Drawing.Image)
        Me.BtnLimpiarAutor.Location = New System.Drawing.Point(597, 66)
        Me.BtnLimpiarAutor.Name = "BtnLimpiarAutor"
        Me.BtnLimpiarAutor.Size = New System.Drawing.Size(44, 30)
        Me.BtnLimpiarAutor.TabIndex = 64
        Me.BtnLimpiarAutor.UseVisualStyleBackColor = False
        '
        'BtnLimpiarAutor1
        '
        Me.BtnLimpiarAutor1.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiarAutor1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiarAutor1.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarAutor1.Image = CType(resources.GetObject("BtnLimpiarAutor1.Image"), System.Drawing.Image)
        Me.BtnLimpiarAutor1.Location = New System.Drawing.Point(598, 94)
        Me.BtnLimpiarAutor1.Name = "BtnLimpiarAutor1"
        Me.BtnLimpiarAutor1.Size = New System.Drawing.Size(43, 34)
        Me.BtnLimpiarAutor1.TabIndex = 65
        Me.BtnLimpiarAutor1.UseVisualStyleBackColor = False
        '
        'BtnLimpiarAutor2
        '
        Me.BtnLimpiarAutor2.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiarAutor2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiarAutor2.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiarAutor2.Image = CType(resources.GetObject("BtnLimpiarAutor2.Image"), System.Drawing.Image)
        Me.BtnLimpiarAutor2.Location = New System.Drawing.Point(598, 124)
        Me.BtnLimpiarAutor2.Name = "BtnLimpiarAutor2"
        Me.BtnLimpiarAutor2.Size = New System.Drawing.Size(43, 32)
        Me.BtnLimpiarAutor2.TabIndex = 66
        Me.BtnLimpiarAutor2.UseVisualStyleBackColor = False
        '
        'DtpRegistracionDelLibro
        '
        Me.DtpRegistracionDelLibro.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtpRegistracionDelLibro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpRegistracionDelLibro.Location = New System.Drawing.Point(615, 18)
        Me.DtpRegistracionDelLibro.Name = "DtpRegistracionDelLibro"
        Me.DtpRegistracionDelLibro.Size = New System.Drawing.Size(200, 20)
        Me.DtpRegistracionDelLibro.TabIndex = 67
        Me.DtpRegistracionDelLibro.Visible = False
        '
        'LblImagen
        '
        Me.LblImagen.AutoSize = True
        Me.LblImagen.BackColor = System.Drawing.Color.Transparent
        Me.LblImagen.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblImagen.Location = New System.Drawing.Point(348, 153)
        Me.LblImagen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblImagen.Name = "LblImagen"
        Me.LblImagen.Size = New System.Drawing.Size(68, 13)
        Me.LblImagen.TabIndex = 68
        Me.LblImagen.Text = "Imagen  :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(878, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblImagen)
        Me.Controls.Add(Me.DtpRegistracionDelLibro)
        Me.Controls.Add(Me.BtnLimpiarAutor2)
        Me.Controls.Add(Me.BtnLimpiarAutor1)
        Me.Controls.Add(Me.BtnLimpiarAutor)
        Me.Controls.Add(Me.BtnAyudaAutor2)
        Me.Controls.Add(Me.BtnAyudaAutor1)
        Me.Controls.Add(Me.TxtNroDeAutor2)
        Me.Controls.Add(Me.TxtNroDeAutor1)
        Me.Controls.Add(Me.TxtNroDeAutor)
        Me.Controls.Add(Me.BtnAyudaAutor)
        Me.Controls.Add(Me.TxtAutor2)
        Me.Controls.Add(Me.TxtAutor1)
        Me.Controls.Add(Me.TxtAutor)
        Me.Controls.Add(Me.BtnLimpiarCampos)
        Me.Controls.Add(Me.TxtISBN)
        Me.Controls.Add(Me.LblISBN)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnQuitarAño)
        Me.Controls.Add(Me.BtnAgregarAño)
        Me.Controls.Add(Me.TxtAños)
        Me.Controls.Add(Me.LblAutor2)
        Me.Controls.Add(Me.LblAutor1)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.PtBoxPerfil)
        Me.Controls.Add(Me.BtnAgregarLibros)
        Me.Controls.Add(Me.DtgRegistrarLibros)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtAno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Libros"
        CType(Me.DtgRegistrarLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtBoxPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAno As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtgRegistrarLibros As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAgregarLibros As System.Windows.Forms.Button
    Friend WithEvents PtBoxPerfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents TxtRuta As System.Windows.Forms.TextBox
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnCambiar As System.Windows.Forms.Button
    Friend WithEvents AutoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutoresTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents LblAutor1 As System.Windows.Forms.Label
    Friend WithEvents LblAutor2 As System.Windows.Forms.Label
    Friend WithEvents AutoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AutoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TxtAños As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregarAño As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarAño As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents TxtISBN As System.Windows.Forms.TextBox
    Friend WithEvents LblISBN As System.Windows.Forms.Label
    Friend WithEvents BtnLimpiarCampos As System.Windows.Forms.Button
    Friend WithEvents TxtAutor As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutor1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutor2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnAyudaAutor As System.Windows.Forms.Button
    Friend WithEvents TxtNroDeAutor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroDeAutor1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroDeAutor2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnAyudaAutor1 As System.Windows.Forms.Button
    Friend WithEvents BtnAyudaAutor2 As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiarAutor As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiarAutor1 As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiarAutor2 As System.Windows.Forms.Button
    Friend WithEvents DtpRegistracionDelLibro As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblImagen As System.Windows.Forms.Label

End Class
