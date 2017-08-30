<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AyudaLibro
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
        Me.DtgAyudaLibro = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter()
        Me.BtnTomar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtBusquedaPorCategoria = New System.Windows.Forms.TextBox()
        Me.TxtBsquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.TxtNumeroDeLibro = New System.Windows.Forms.TextBox()
        CType(Me.DtgAyudaLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgAyudaLibro
        '
        Me.DtgAyudaLibro.AllowUserToAddRows = False
        Me.DtgAyudaLibro.AllowUserToDeleteRows = False
        Me.DtgAyudaLibro.AutoGenerateColumns = False
        Me.DtgAyudaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAyudaLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn, Me.AutorDataGridViewTextBoxColumn, Me.Autor1DataGridViewTextBoxColumn, Me.Autor2DataGridViewTextBoxColumn, Me.FechaaltaDataGridViewTextBoxColumn})
        Me.DtgAyudaLibro.DataSource = Me.LibrosBindingSource
        Me.DtgAyudaLibro.Location = New System.Drawing.Point(4, 4)
        Me.DtgAyudaLibro.Name = "DtgAyudaLibro"
        Me.DtgAyudaLibro.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgAyudaLibro.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgAyudaLibro.Size = New System.Drawing.Size(899, 305)
        Me.DtgAyudaLibro.TabIndex = 0
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorDataGridViewTextBoxColumn
        '
        Me.AutorDataGridViewTextBoxColumn.DataPropertyName = "autor"
        Me.AutorDataGridViewTextBoxColumn.HeaderText = "Autor"
        Me.AutorDataGridViewTextBoxColumn.Name = "AutorDataGridViewTextBoxColumn"
        Me.AutorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Autor1DataGridViewTextBoxColumn
        '
        Me.Autor1DataGridViewTextBoxColumn.DataPropertyName = "autor1"
        Me.Autor1DataGridViewTextBoxColumn.HeaderText = "Autor 1"
        Me.Autor1DataGridViewTextBoxColumn.Name = "Autor1DataGridViewTextBoxColumn"
        Me.Autor1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Autor2DataGridViewTextBoxColumn
        '
        Me.Autor2DataGridViewTextBoxColumn.DataPropertyName = "autor2"
        Me.Autor2DataGridViewTextBoxColumn.HeaderText = "Autor 2"
        Me.Autor2DataGridViewTextBoxColumn.Name = "Autor2DataGridViewTextBoxColumn"
        Me.Autor2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaaltaDataGridViewTextBoxColumn
        '
        Me.FechaaltaDataGridViewTextBoxColumn.DataPropertyName = "fecha_alta"
        Me.FechaaltaDataGridViewTextBoxColumn.HeaderText = "Fecha Alta"
        Me.FechaaltaDataGridViewTextBoxColumn.Name = "FechaaltaDataGridViewTextBoxColumn"
        Me.FechaaltaDataGridViewTextBoxColumn.ReadOnly = True
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
        'BtnTomar
        '
        Me.BtnTomar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnTomar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnTomar.Location = New System.Drawing.Point(183, 394)
        Me.BtnTomar.Name = "BtnTomar"
        Me.BtnTomar.Size = New System.Drawing.Size(99, 29)
        Me.BtnTomar.TabIndex = 1
        Me.BtnTomar.Text = "Obtener"
        Me.BtnTomar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(417, 394)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(103, 29)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnActualizar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.Location = New System.Drawing.Point(613, 394)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(109, 29)
        Me.BtnActualizar.TabIndex = 3
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtBusquedaPorCategoria
        '
        Me.TxtBusquedaPorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorCategoria.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorCategoria.Location = New System.Drawing.Point(352, 338)
        Me.TxtBusquedaPorCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaPorCategoria.MaxLength = 50
        Me.TxtBusquedaPorCategoria.Name = "TxtBusquedaPorCategoria"
        Me.TxtBusquedaPorCategoria.Size = New System.Drawing.Size(315, 25)
        Me.TxtBusquedaPorCategoria.TabIndex = 40
        Me.TxtBusquedaPorCategoria.Visible = False
        '
        'TxtBsquedaPorNombre
        '
        Me.TxtBsquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBsquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBsquedaPorNombre.Location = New System.Drawing.Point(352, 339)
        Me.TxtBsquedaPorNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBsquedaPorNombre.MaxLength = 50
        Me.TxtBsquedaPorNombre.Name = "TxtBsquedaPorNombre"
        Me.TxtBsquedaPorNombre.Size = New System.Drawing.Size(315, 25)
        Me.TxtBsquedaPorNombre.TabIndex = 39
        Me.TxtBsquedaPorNombre.Visible = False
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.Color.Lime
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nro de Libro", "Nombre", "Categoria"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(172, 342)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(175, 21)
        Me.CboBusqPorTipo.TabIndex = 38
        '
        'TxtNumeroDeLibro
        '
        Me.TxtNumeroDeLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroDeLibro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroDeLibro.Location = New System.Drawing.Point(352, 338)
        Me.TxtNumeroDeLibro.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumeroDeLibro.MaxLength = 8
        Me.TxtNumeroDeLibro.Name = "TxtNumeroDeLibro"
        Me.TxtNumeroDeLibro.Size = New System.Drawing.Size(315, 25)
        Me.TxtNumeroDeLibro.TabIndex = 37
        Me.TxtNumeroDeLibro.Visible = False
        '
        'AyudaLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(906, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBusquedaPorCategoria)
        Me.Controls.Add(Me.TxtBsquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.TxtNumeroDeLibro)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnTomar)
        Me.Controls.Add(Me.DtgAyudaLibro)
        Me.Name = "AyudaLibro"
        Me.Text = "AyudaLibro"
        CType(Me.DtgAyudaLibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtgAyudaLibro As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter
    Friend WithEvents BtnTomar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents TxtBusquedaPorCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxtBsquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNumeroDeLibro As System.Windows.Forms.TextBox
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
