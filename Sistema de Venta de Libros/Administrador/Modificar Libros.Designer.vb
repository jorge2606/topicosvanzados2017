<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Libros))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PBoxPerfilFoto = New System.Windows.Forms.PictureBox()
        Me.BtnImagen = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DtgModifcarLibros = New System.Windows.Forms.DataGridView()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter()
        Me.TxtNumeroDeLibro = New System.Windows.Forms.TextBox()
        Me.LblNroDeLibro = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.CboAutor = New System.Windows.Forms.ComboBox()
        Me.AutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CboAutor2 = New System.Windows.Forms.ComboBox()
        Me.AutoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblAutor2 = New System.Windows.Forms.Label()
        Me.CboAutor1 = New System.Windows.Forms.ComboBox()
        Me.AutoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblAutor1 = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtAños = New System.Windows.Forms.TextBox()
        Me.BtnQuitarAño = New System.Windows.Forms.Button()
        Me.BtnAgregarAño = New System.Windows.Forms.Button()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.TxtBusquedaPorCategoria = New System.Windows.Forms.TextBox()
        Me.TxtBsquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.AutoresTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter()
        CType(Me.PBoxPerfilFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgModifcarLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(37, 93)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre :"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LblCategoria.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCategoria.Location = New System.Drawing.Point(25, 171)
        Me.LblCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(89, 13)
        Me.LblCategoria.TabIndex = 2
        Me.LblCategoria.Text = "Categoría :"
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.BackColor = System.Drawing.Color.Transparent
        Me.LblAno.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblAno.Location = New System.Drawing.Point(63, 117)
        Me.LblAno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(43, 13)
        Me.LblAno.TabIndex = 3
        Me.LblAno.Text = "Año :"
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.BackColor = System.Drawing.Color.Transparent
        Me.LblAutor.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblAutor.Location = New System.Drawing.Point(379, 68)
        Me.LblAutor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(60, 13)
        Me.LblAutor.TabIndex = 4
        Me.LblAutor.Text = "Autor :"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNombre.Location = New System.Drawing.Point(111, 89)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(235, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCantidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtCantidad.Location = New System.Drawing.Point(440, 140)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCantidad.MaxLength = 3
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(244, 20)
        Me.TxtCantidad.TabIndex = 7
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(308, 492)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(92, 44)
        Me.BtnModificar.TabIndex = 10
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'TxtAno
        '
        Me.TxtAno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAno.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAno.Location = New System.Drawing.Point(167, 113)
        Me.TxtAno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAno.MaxLength = 2
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(71, 20)
        Me.TxtAno.TabIndex = 16
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCantidad.Location = New System.Drawing.Point(356, 143)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(83, 13)
        Me.LblCantidad.TabIndex = 17
        Me.LblCantidad.Text = "Cantidad :"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(491, 492)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 44)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Underline)
        Me.LblTitulo.ForeColor = System.Drawing.Color.Red
        Me.LblTitulo.Location = New System.Drawing.Point(345, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(174, 33)
        Me.LblTitulo.TabIndex = 20
        Me.LblTitulo.Text = "Datos del Libro"
        '
        'PBoxPerfilFoto
        '
        Me.PBoxPerfilFoto.BackColor = System.Drawing.Color.DarkGray
        Me.PBoxPerfilFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBoxPerfilFoto.Location = New System.Drawing.Point(712, 49)
        Me.PBoxPerfilFoto.Name = "PBoxPerfilFoto"
        Me.PBoxPerfilFoto.Size = New System.Drawing.Size(133, 101)
        Me.PBoxPerfilFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxPerfilFoto.TabIndex = 21
        Me.PBoxPerfilFoto.TabStop = False
        '
        'BtnImagen
        '
        Me.BtnImagen.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnImagen.ForeColor = System.Drawing.Color.Black
        Me.BtnImagen.Location = New System.Drawing.Point(728, 191)
        Me.BtnImagen.Name = "BtnImagen"
        Me.BtnImagen.Size = New System.Drawing.Size(104, 35)
        Me.BtnImagen.TabIndex = 22
        Me.BtnImagen.Text = "Imagen"
        Me.BtnImagen.UseVisualStyleBackColor = False
        '
        'TxtRuta
        '
        Me.TxtRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtRuta.Location = New System.Drawing.Point(709, 156)
        Me.TxtRuta.MaxLength = 200
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(146, 20)
        Me.TxtRuta.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusqueda.Location = New System.Drawing.Point(421, 228)
        Me.TxtBusqueda.MaxLength = 8
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(271, 20)
        Me.TxtBusqueda.TabIndex = 25
        '
        'DtgModifcarLibros
        '
        Me.DtgModifcarLibros.AllowUserToAddRows = False
        Me.DtgModifcarLibros.AllowUserToDeleteRows = False
        Me.DtgModifcarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgModifcarLibros.Location = New System.Drawing.Point(2, 254)
        Me.DtgModifcarLibros.Name = "DtgModifcarLibros"
        Me.DtgModifcarLibros.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgModifcarLibros.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgModifcarLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgModifcarLibros.Size = New System.Drawing.Size(853, 233)
        Me.DtgModifcarLibros.TabIndex = 37
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
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'TxtNumeroDeLibro
        '
        Me.TxtNumeroDeLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroDeLibro.Enabled = False
        Me.TxtNumeroDeLibro.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroDeLibro.Location = New System.Drawing.Point(111, 65)
        Me.TxtNumeroDeLibro.MaxLength = 8
        Me.TxtNumeroDeLibro.Name = "TxtNumeroDeLibro"
        Me.TxtNumeroDeLibro.Size = New System.Drawing.Size(234, 20)
        Me.TxtNumeroDeLibro.TabIndex = 38
        '
        'LblNroDeLibro
        '
        Me.LblNroDeLibro.AutoSize = True
        Me.LblNroDeLibro.BackColor = System.Drawing.Color.Transparent
        Me.LblNroDeLibro.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblNroDeLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNroDeLibro.Location = New System.Drawing.Point(59, 69)
        Me.LblNroDeLibro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNroDeLibro.Name = "LblNroDeLibro"
        Me.LblNroDeLibro.Size = New System.Drawing.Size(48, 13)
        Me.LblNroDeLibro.TabIndex = 39
        Me.LblNroDeLibro.Text = "Nro  :"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPrecio.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtPrecio.Location = New System.Drawing.Point(111, 138)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrecio.MaxLength = 6
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(235, 20)
        Me.TxtPrecio.TabIndex = 41
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LblPrecio.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblPrecio.Location = New System.Drawing.Point(41, 141)
        Me.LblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(65, 13)
        Me.LblPrecio.TabIndex = 40
        Me.LblPrecio.Text = "Precio  :"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEstado.Location = New System.Drawing.Point(41, 168)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(68, 13)
        Me.LblEstado.TabIndex = 42
        Me.LblEstado.Text = "Estado  :"
        Me.LblEstado.Visible = False
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(12, 222)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(235, 21)
        Me.CboEstado.TabIndex = 43
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
        'CboAutor
        '
        Me.CboAutor.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboAutor.DataSource = Me.AutoresBindingSource
        Me.CboAutor.DisplayMember = "nombreAutor"
        Me.CboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAutor.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboAutor.FormattingEnabled = True
        Me.CboAutor.Location = New System.Drawing.Point(440, 65)
        Me.CboAutor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboAutor.Name = "CboAutor"
        Me.CboAutor.Size = New System.Drawing.Size(244, 21)
        Me.CboAutor.TabIndex = 44
        Me.CboAutor.ValueMember = "nro_autor"
        '
        'AutoresBindingSource
        '
        Me.AutoresBindingSource.DataMember = "Autores"
        Me.AutoresBindingSource.DataSource = Me.DataSet1
        '
        'CboAutor2
        '
        Me.CboAutor2.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboAutor2.DataSource = Me.AutoresBindingSource2
        Me.CboAutor2.DisplayMember = "nombreAutor"
        Me.CboAutor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAutor2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboAutor2.FormattingEnabled = True
        Me.CboAutor2.Location = New System.Drawing.Point(440, 114)
        Me.CboAutor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboAutor2.Name = "CboAutor2"
        Me.CboAutor2.Size = New System.Drawing.Size(244, 21)
        Me.CboAutor2.TabIndex = 48
        Me.CboAutor2.ValueMember = "nro_autor"
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
        Me.LblAutor2.Location = New System.Drawing.Point(363, 118)
        Me.LblAutor2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAutor2.Name = "LblAutor2"
        Me.LblAutor2.Size = New System.Drawing.Size(75, 13)
        Me.LblAutor2.TabIndex = 47
        Me.LblAutor2.Text = "Autor 2  :"
        '
        'CboAutor1
        '
        Me.CboAutor1.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboAutor1.DataSource = Me.AutoresBindingSource1
        Me.CboAutor1.DisplayMember = "nombreAutor"
        Me.CboAutor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAutor1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboAutor1.FormattingEnabled = True
        Me.CboAutor1.Location = New System.Drawing.Point(440, 88)
        Me.CboAutor1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboAutor1.Name = "CboAutor1"
        Me.CboAutor1.Size = New System.Drawing.Size(244, 21)
        Me.CboAutor1.TabIndex = 46
        Me.CboAutor1.ValueMember = "nro_autor"
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
        Me.LblAutor1.Location = New System.Drawing.Point(365, 91)
        Me.LblAutor1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAutor1.Name = "LblAutor1"
        Me.LblAutor1.Size = New System.Drawing.Size(72, 13)
        Me.LblAutor1.TabIndex = 45
        Me.LblAutor1.Text = "Autor  1 :"
        '
        'CboCategoria
        '
        Me.CboCategoria.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboCategoria.DataSource = Me.CategoriasBindingSource
        Me.CboCategoria.DisplayMember = "descripcion"
        Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(111, 163)
        Me.CboCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(235, 21)
        Me.CboCategoria.TabIndex = 15
        Me.CboCategoria.ValueMember = "cod_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.DataSet1
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(145, 209)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(80, 40)
        Me.BtnActualizar.TabIndex = 49
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtAños
        '
        Me.TxtAños.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAños.Enabled = False
        Me.TxtAños.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtAños.Location = New System.Drawing.Point(111, 113)
        Me.TxtAños.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAños.MaxLength = 2
        Me.TxtAños.Name = "TxtAños"
        Me.TxtAños.Size = New System.Drawing.Size(50, 20)
        Me.TxtAños.TabIndex = 50
        '
        'BtnQuitarAño
        '
        Me.BtnQuitarAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnQuitarAño.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnQuitarAño.Image = CType(resources.GetObject("BtnQuitarAño.Image"), System.Drawing.Image)
        Me.BtnQuitarAño.Location = New System.Drawing.Point(285, 112)
        Me.BtnQuitarAño.Name = "BtnQuitarAño"
        Me.BtnQuitarAño.Size = New System.Drawing.Size(38, 26)
        Me.BtnQuitarAño.TabIndex = 52
        Me.BtnQuitarAño.UseVisualStyleBackColor = True
        '
        'BtnAgregarAño
        '
        Me.BtnAgregarAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAgregarAño.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregarAño.Image = CType(resources.GetObject("BtnAgregarAño.Image"), System.Drawing.Image)
        Me.BtnAgregarAño.Location = New System.Drawing.Point(244, 112)
        Me.BtnAgregarAño.Name = "BtnAgregarAño"
        Me.BtnAgregarAño.Size = New System.Drawing.Size(38, 26)
        Me.BtnAgregarAño.TabIndex = 51
        Me.BtnAgregarAño.UseVisualStyleBackColor = True
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nro de Libro", "Nombre", "Categoria"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(274, 228)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(141, 21)
        Me.CboBusqPorTipo.TabIndex = 53
        '
        'TxtBusquedaPorCategoria
        '
        Me.TxtBusquedaPorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorCategoria.Location = New System.Drawing.Point(421, 228)
        Me.TxtBusquedaPorCategoria.MaxLength = 25
        Me.TxtBusquedaPorCategoria.Name = "TxtBusquedaPorCategoria"
        Me.TxtBusquedaPorCategoria.Size = New System.Drawing.Size(271, 20)
        Me.TxtBusquedaPorCategoria.TabIndex = 56
        '
        'TxtBsquedaPorNombre
        '
        Me.TxtBsquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBsquedaPorNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBsquedaPorNombre.Location = New System.Drawing.Point(421, 228)
        Me.TxtBsquedaPorNombre.MaxLength = 40
        Me.TxtBsquedaPorNombre.Name = "TxtBsquedaPorNombre"
        Me.TxtBsquedaPorNombre.Size = New System.Drawing.Size(271, 20)
        Me.TxtBsquedaPorNombre.TabIndex = 57
        '
        'AutoresTableAdapter
        '
        Me.AutoresTableAdapter.ClearBeforeFill = True
        '
        'Modificar_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBsquedaPorNombre)
        Me.Controls.Add(Me.TxtBusquedaPorCategoria)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.BtnQuitarAño)
        Me.Controls.Add(Me.BtnAgregarAño)
        Me.Controls.Add(Me.TxtAños)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.CboAutor2)
        Me.Controls.Add(Me.LblAutor2)
        Me.Controls.Add(Me.CboAutor1)
        Me.Controls.Add(Me.LblAutor1)
        Me.Controls.Add(Me.CboAutor)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblNroDeLibro)
        Me.Controls.Add(Me.TxtNumeroDeLibro)
        Me.Controls.Add(Me.DtgModifcarLibros)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnImagen)
        Me.Controls.Add(Me.PBoxPerfilFoto)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.TxtAno)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblAutor)
        Me.Controls.Add(Me.LblAno)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.LblNombre)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Modificar_Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Libros"
        CType(Me.PBoxPerfilFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgModifcarLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents LblAno As System.Windows.Forms.Label
    Friend WithEvents LblAutor As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents TxtAno As System.Windows.Forms.TextBox
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents PBoxPerfilFoto As System.Windows.Forms.PictureBox
    Friend WithEvents BtnImagen As System.Windows.Forms.Button
    Friend WithEvents TxtRuta As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TxtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents DtgModifcarLibros As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents TxtNumeroDeLibro As System.Windows.Forms.TextBox
    Friend WithEvents LblNroDeLibro As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents CboAutor As System.Windows.Forms.ComboBox
    Friend WithEvents CboAutor2 As System.Windows.Forms.ComboBox
    Friend WithEvents LblAutor2 As System.Windows.Forms.Label
    Friend WithEvents CboAutor1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblAutor1 As System.Windows.Forms.Label
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents TxtAños As System.Windows.Forms.TextBox
    Friend WithEvents BtnQuitarAño As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarAño As System.Windows.Forms.Button
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusquedaPorCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxtBsquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents AutoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutoresTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter
    Friend WithEvents AutoresBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents AutoresBindingSource1 As System.Windows.Forms.BindingSource
End Class
