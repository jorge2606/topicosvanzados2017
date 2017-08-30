<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMAutor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMAutor))
        Me.RbtInsertar = New System.Windows.Forms.RadioButton()
        Me.RbtModificar = New System.Windows.Forms.RadioButton()
        Me.RbtEliminar = New System.Windows.Forms.RadioButton()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNroAutor = New System.Windows.Forms.TextBox()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.DtgABMCategoria = New System.Windows.Forms.DataGridView()
        Me.NombreAutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblNroAutor = New System.Windows.Forms.Label()
        Me.LblNroLibro = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.RbtModificarEstado = New System.Windows.Forms.RadioButton()
        Me.BtnModificarEstado = New System.Windows.Forms.Button()
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.AutoresTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter()
        Me.BtnAgregarAutor = New System.Windows.Forms.Button()
        Me.BtnCancelarAutor = New System.Windows.Forms.Button()
        Me.BtnAgregarAutor1 = New System.Windows.Forms.Button()
        Me.BtnCancelarAutor1 = New System.Windows.Forms.Button()
        Me.BtnCancelarAutor2 = New System.Windows.Forms.Button()
        Me.BtnAgregarAutor2 = New System.Windows.Forms.Button()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbtInsertar
        '
        Me.RbtInsertar.AutoSize = True
        Me.RbtInsertar.BackColor = System.Drawing.Color.Transparent
        Me.RbtInsertar.Location = New System.Drawing.Point(393, 15)
        Me.RbtInsertar.Margin = New System.Windows.Forms.Padding(6)
        Me.RbtInsertar.Name = "RbtInsertar"
        Me.RbtInsertar.Size = New System.Drawing.Size(81, 22)
        Me.RbtInsertar.TabIndex = 32
        Me.RbtInsertar.Text = "Insertar"
        Me.RbtInsertar.UseVisualStyleBackColor = False
        '
        'RbtModificar
        '
        Me.RbtModificar.AutoSize = True
        Me.RbtModificar.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificar.Location = New System.Drawing.Point(197, 15)
        Me.RbtModificar.Margin = New System.Windows.Forms.Padding(6)
        Me.RbtModificar.Name = "RbtModificar"
        Me.RbtModificar.Size = New System.Drawing.Size(92, 22)
        Me.RbtModificar.TabIndex = 31
        Me.RbtModificar.Text = "Modificar"
        Me.RbtModificar.UseVisualStyleBackColor = False
        '
        'RbtEliminar
        '
        Me.RbtEliminar.AutoSize = True
        Me.RbtEliminar.BackColor = System.Drawing.Color.Transparent
        Me.RbtEliminar.Location = New System.Drawing.Point(21, 15)
        Me.RbtEliminar.Margin = New System.Windows.Forms.Padding(6)
        Me.RbtEliminar.Name = "RbtEliminar"
        Me.RbtEliminar.Size = New System.Drawing.Size(83, 22)
        Me.RbtEliminar.TabIndex = 30
        Me.RbtEliminar.Text = "Eliminar"
        Me.RbtEliminar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(571, 104)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(168, 44)
        Me.BtnEliminar.TabIndex = 29
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(571, 269)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(168, 44)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(571, 159)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(168, 44)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(571, 49)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(168, 44)
        Me.BtnGuardar.TabIndex = 25
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Location = New System.Drawing.Point(53, 114)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(72, 18)
        Me.LblNombre.TabIndex = 23
        Me.LblNombre.Text = "Nombre :"
        Me.LblNombre.Visible = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombre.Location = New System.Drawing.Point(126, 110)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtNombre.MaxLength = 40
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(332, 25)
        Me.TxtNombre.TabIndex = 21
        Me.TxtNombre.Visible = False
        '
        'TxtNroAutor
        '
        Me.TxtNroAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNroAutor.Location = New System.Drawing.Point(126, 78)
        Me.TxtNroAutor.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtNroAutor.MaxLength = 5
        Me.TxtNroAutor.Name = "TxtNroAutor"
        Me.TxtNroAutor.Size = New System.Drawing.Size(332, 25)
        Me.TxtNroAutor.TabIndex = 33
        Me.TxtNroAutor.Visible = False
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.BackColor = System.Drawing.Color.Transparent
        Me.LblEdad.Location = New System.Drawing.Point(73, 145)
        Me.LblEdad.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(52, 18)
        Me.LblEdad.TabIndex = 36
        Me.LblEdad.Text = "Edad :"
        Me.LblEdad.Visible = False
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtEdad.Location = New System.Drawing.Point(125, 141)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtEdad.MaxLength = 3
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(332, 25)
        Me.TxtEdad.TabIndex = 35
        Me.TxtEdad.Visible = False
        '
        'DtgABMCategoria
        '
        Me.DtgABMCategoria.AllowUserToAddRows = False
        Me.DtgABMCategoria.AllowUserToDeleteRows = False
        Me.DtgABMCategoria.AutoGenerateColumns = False
        Me.DtgABMCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgABMCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgABMCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreAutorDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.EstadoDataGridViewTextBoxColumn})
        Me.DtgABMCategoria.DataSource = Me.AutoresBindingSource
        Me.DtgABMCategoria.Location = New System.Drawing.Point(18, 352)
        Me.DtgABMCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.DtgABMCategoria.Name = "DtgABMCategoria"
        Me.DtgABMCategoria.ReadOnly = True
        Me.DtgABMCategoria.Size = New System.Drawing.Size(814, 263)
        Me.DtgABMCategoria.TabIndex = 37
        '
        'NombreAutorDataGridViewTextBoxColumn
        '
        Me.NombreAutorDataGridViewTextBoxColumn.DataPropertyName = "nombreAutor"
        Me.NombreAutorDataGridViewTextBoxColumn.HeaderText = "nombreAutor"
        Me.NombreAutorDataGridViewTextBoxColumn.Name = "NombreAutorDataGridViewTextBoxColumn"
        Me.NombreAutorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nro_autor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nro_autor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutoresBindingSource
        '
        Me.AutoresBindingSource.DataMember = "Autores"
        Me.AutoresBindingSource.DataSource = Me.DataSet1
        '
        'LblNroAutor
        '
        Me.LblNroAutor.AutoSize = True
        Me.LblNroAutor.BackColor = System.Drawing.Color.Transparent
        Me.LblNroAutor.Location = New System.Drawing.Point(21, 82)
        Me.LblNroAutor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNroAutor.Name = "LblNroAutor"
        Me.LblNroAutor.Size = New System.Drawing.Size(105, 18)
        Me.LblNroAutor.TabIndex = 38
        Me.LblNroAutor.Text = "Nro de Autor :"
        '
        'LblNroLibro
        '
        Me.LblNroLibro.AutoSize = True
        Me.LblNroLibro.BackColor = System.Drawing.Color.Transparent
        Me.LblNroLibro.Location = New System.Drawing.Point(8, 82)
        Me.LblNroLibro.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblNroLibro.Name = "LblNroLibro"
        Me.LblNroLibro.Size = New System.Drawing.Size(105, 18)
        Me.LblNroLibro.TabIndex = 34
        Me.LblNroLibro.Text = "Nro de Libro :"
        Me.LblNroLibro.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(362, 284)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(129, 58)
        Me.BtnActualizar.TabIndex = 39
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(125, 171)
        Me.CboEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(332, 26)
        Me.CboEstado.TabIndex = 41
        Me.CboEstado.ValueMember = "cod_estado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Location = New System.Drawing.Point(61, 173)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(65, 18)
        Me.LblEstado.TabIndex = 40
        Me.LblEstado.Text = "Estado :"
        Me.LblEstado.Visible = False
        '
        'RbtModificarEstado
        '
        Me.RbtModificarEstado.AutoSize = True
        Me.RbtModificarEstado.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificarEstado.Location = New System.Drawing.Point(552, 15)
        Me.RbtModificarEstado.Margin = New System.Windows.Forms.Padding(6)
        Me.RbtModificarEstado.Name = "RbtModificarEstado"
        Me.RbtModificarEstado.Size = New System.Drawing.Size(149, 22)
        Me.RbtModificarEstado.TabIndex = 42
        Me.RbtModificarEstado.Text = "Modificar Estado "
        Me.RbtModificarEstado.UseVisualStyleBackColor = False
        '
        'BtnModificarEstado
        '
        Me.BtnModificarEstado.Location = New System.Drawing.Point(571, 216)
        Me.BtnModificarEstado.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnModificarEstado.Name = "BtnModificarEstado"
        Me.BtnModificarEstado.Size = New System.Drawing.Size(168, 43)
        Me.BtnModificarEstado.TabIndex = 43
        Me.BtnModificarEstado.Text = "Modificar Estado"
        Me.BtnModificarEstado.UseVisualStyleBackColor = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'AutoresTableAdapter
        '
        Me.AutoresTableAdapter.ClearBeforeFill = True
        '
        'BtnAgregarAutor
        '
        Me.BtnAgregarAutor.Location = New System.Drawing.Point(156, 623)
        Me.BtnAgregarAutor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregarAutor.Name = "BtnAgregarAutor"
        Me.BtnAgregarAutor.Size = New System.Drawing.Size(112, 32)
        Me.BtnAgregarAutor.TabIndex = 44
        Me.BtnAgregarAutor.Text = "Agregar"
        Me.BtnAgregarAutor.UseVisualStyleBackColor = True
        Me.BtnAgregarAutor.Visible = False
        '
        'BtnCancelarAutor
        '
        Me.BtnCancelarAutor.Location = New System.Drawing.Point(114, 623)
        Me.BtnCancelarAutor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelarAutor.Name = "BtnCancelarAutor"
        Me.BtnCancelarAutor.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancelarAutor.TabIndex = 45
        Me.BtnCancelarAutor.Text = "Cancelar"
        Me.BtnCancelarAutor.UseVisualStyleBackColor = True
        Me.BtnCancelarAutor.Visible = False
        '
        'BtnAgregarAutor1
        '
        Me.BtnAgregarAutor1.Location = New System.Drawing.Point(674, 623)
        Me.BtnAgregarAutor1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregarAutor1.Name = "BtnAgregarAutor1"
        Me.BtnAgregarAutor1.Size = New System.Drawing.Size(112, 32)
        Me.BtnAgregarAutor1.TabIndex = 46
        Me.BtnAgregarAutor1.Text = "Agregar"
        Me.BtnAgregarAutor1.UseVisualStyleBackColor = True
        Me.BtnAgregarAutor1.Visible = False
        '
        'BtnCancelarAutor1
        '
        Me.BtnCancelarAutor1.Location = New System.Drawing.Point(674, 640)
        Me.BtnCancelarAutor1.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelarAutor1.Name = "BtnCancelarAutor1"
        Me.BtnCancelarAutor1.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancelarAutor1.TabIndex = 47
        Me.BtnCancelarAutor1.Text = "Cancelar"
        Me.BtnCancelarAutor1.UseVisualStyleBackColor = True
        Me.BtnCancelarAutor1.Visible = False
        '
        'BtnCancelarAutor2
        '
        Me.BtnCancelarAutor2.Location = New System.Drawing.Point(405, 640)
        Me.BtnCancelarAutor2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelarAutor2.Name = "BtnCancelarAutor2"
        Me.BtnCancelarAutor2.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancelarAutor2.TabIndex = 49
        Me.BtnCancelarAutor2.Text = "Cancelar"
        Me.BtnCancelarAutor2.UseVisualStyleBackColor = True
        Me.BtnCancelarAutor2.Visible = False
        '
        'BtnAgregarAutor2
        '
        Me.BtnAgregarAutor2.Location = New System.Drawing.Point(405, 623)
        Me.BtnAgregarAutor2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregarAutor2.Name = "BtnAgregarAutor2"
        Me.BtnAgregarAutor2.Size = New System.Drawing.Size(112, 32)
        Me.BtnAgregarAutor2.TabIndex = 48
        Me.BtnAgregarAutor2.Text = "Agregar"
        Me.BtnAgregarAutor2.UseVisualStyleBackColor = True
        Me.BtnAgregarAutor2.Visible = False
        '
        'ABMAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelarAutor2)
        Me.Controls.Add(Me.BtnAgregarAutor2)
        Me.Controls.Add(Me.BtnCancelarAutor1)
        Me.Controls.Add(Me.BtnAgregarAutor1)
        Me.Controls.Add(Me.BtnCancelarAutor)
        Me.Controls.Add(Me.BtnAgregarAutor)
        Me.Controls.Add(Me.BtnModificarEstado)
        Me.Controls.Add(Me.RbtModificarEstado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.LblNroAutor)
        Me.Controls.Add(Me.DtgABMCategoria)
        Me.Controls.Add(Me.LblEdad)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.LblNroLibro)
        Me.Controls.Add(Me.TxtNroAutor)
        Me.Controls.Add(Me.RbtInsertar)
        Me.Controls.Add(Me.RbtModificar)
        Me.Controls.Add(Me.RbtEliminar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "ABMAutor"
        Me.Text = "ABMAutor"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbtInsertar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroAutor As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents NroautorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblEdad As System.Windows.Forms.Label
    Friend WithEvents TxtEdad As System.Windows.Forms.TextBox
    Friend WithEvents DtgABMCategoria As System.Windows.Forms.DataGridView
    Friend WithEvents LblNroAutor As System.Windows.Forms.Label
    Friend WithEvents LblNroLibro As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents RbtModificarEstado As System.Windows.Forms.RadioButton
    Friend WithEvents BtnModificarEstado As System.Windows.Forms.Button
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents AutoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutoresTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.AutoresTableAdapter
    Friend WithEvents NombreAutorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregarAutor As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarAutor As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarAutor1 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarAutor1 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarAutor2 As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarAutor2 As System.Windows.Forms.Button
End Class
