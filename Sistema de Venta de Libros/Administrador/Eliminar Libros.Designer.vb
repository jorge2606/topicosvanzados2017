<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Libros))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtNumeroDeLibro = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DtgEliminarLibros = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter()
        Me.TxtBusquedaPorCategoria = New System.Windows.Forms.TextBox()
        Me.TxtBsquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        CType(Me.DtgEliminarLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroDeLibro
        '
        Me.TxtNumeroDeLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroDeLibro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroDeLibro.Location = New System.Drawing.Point(333, 469)
        Me.TxtNumeroDeLibro.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumeroDeLibro.MaxLength = 10
        Me.TxtNumeroDeLibro.Name = "TxtNumeroDeLibro"
        Me.TxtNumeroDeLibro.Size = New System.Drawing.Size(294, 25)
        Me.TxtNumeroDeLibro.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(428, 498)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(124, 50)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'DtgEliminarLibros
        '
        Me.DtgEliminarLibros.AllowUserToAddRows = False
        Me.DtgEliminarLibros.AllowUserToDeleteRows = False
        Me.DtgEliminarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgEliminarLibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DtgEliminarLibros.Location = New System.Drawing.Point(2, 5)
        Me.DtgEliminarLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgEliminarLibros.Name = "DtgEliminarLibros"
        Me.DtgEliminarLibros.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgEliminarLibros.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgEliminarLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgEliminarLibros.Size = New System.Drawing.Size(936, 432)
        Me.DtgEliminarLibros.TabIndex = 13
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
        'TxtBusquedaPorCategoria
        '
        Me.TxtBusquedaPorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorCategoria.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorCategoria.Location = New System.Drawing.Point(333, 469)
        Me.TxtBusquedaPorCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaPorCategoria.MaxLength = 50
        Me.TxtBusquedaPorCategoria.Name = "TxtBusquedaPorCategoria"
        Me.TxtBusquedaPorCategoria.Size = New System.Drawing.Size(294, 25)
        Me.TxtBusquedaPorCategoria.TabIndex = 38
        '
        'TxtBsquedaPorNombre
        '
        Me.TxtBsquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBsquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBsquedaPorNombre.Location = New System.Drawing.Point(333, 469)
        Me.TxtBsquedaPorNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBsquedaPorNombre.MaxLength = 40
        Me.TxtBsquedaPorNombre.Name = "TxtBsquedaPorNombre"
        Me.TxtBsquedaPorNombre.Size = New System.Drawing.Size(294, 25)
        Me.TxtBsquedaPorNombre.TabIndex = 37
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nro de Libro", "Nombre", "Categoria"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(133, 473)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(176, 21)
        Me.CboBusqPorTipo.TabIndex = 41
        '
        'Eliminar_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.TxtBusquedaPorCategoria)
        Me.Controls.Add(Me.TxtBsquedaPorNombre)
        Me.Controls.Add(Me.DtgEliminarLibros)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtNumeroDeLibro)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eliminar_Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Libros"
        CType(Me.DtgEliminarLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroDeLibro As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DtgEliminarLibros As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TxtBusquedaPorCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxtBsquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
End Class
