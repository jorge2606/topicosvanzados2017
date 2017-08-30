<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Cliente))
        Me.TxtNumeroEmpleado = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DtgEliminarCliente = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.ClientesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DtgEliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroEmpleado
        '
        Me.TxtNumeroEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroEmpleado.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroEmpleado.Location = New System.Drawing.Point(370, 326)
        Me.TxtNumeroEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNumeroEmpleado.MaxLength = 8
        Me.TxtNumeroEmpleado.Name = "TxtNumeroEmpleado"
        Me.TxtNumeroEmpleado.Size = New System.Drawing.Size(294, 25)
        Me.TxtNumeroEmpleado.TabIndex = 2
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(463, 367)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(120, 41)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'DtgEliminarCliente
        '
        Me.DtgEliminarCliente.AllowUserToAddRows = False
        Me.DtgEliminarCliente.AllowUserToDeleteRows = False
        Me.DtgEliminarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgEliminarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DtgEliminarCliente.Location = New System.Drawing.Point(2, 2)
        Me.DtgEliminarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgEliminarCliente.Name = "DtgEliminarCliente"
        Me.DtgEliminarCliente.ReadOnly = True
        Me.DtgEliminarCliente.Size = New System.Drawing.Size(947, 293)
        Me.DtgEliminarCliente.TabIndex = 37
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 300.0!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(370, 326)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaPorNombre.MaxLength = 40
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(294, 25)
        Me.TxtBusquedaPorNombre.TabIndex = 39
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(161, 330)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(172, 21)
        Me.CboBusqPorTipo.TabIndex = 41
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(702, 318)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(80, 40)
        Me.BtnActualizar.TabIndex = 53
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Eliminar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.DtgEliminarCliente)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtNumeroEmpleado)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Eliminar_Cliente"
        Me.Text = "Eliminar Cliente"
        CType(Me.DtgEliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DtgEliminarCliente As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
