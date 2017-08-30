<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Cliente
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Cliente))
        Me.TxtNumeroCliente = New System.Windows.Forms.TextBox()
        Me.DtgConsultarClientes = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.DtgConsultarClie = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DtgConsultarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgConsultarClie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroCliente
        '
        Me.TxtNumeroCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroCliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroCliente.Location = New System.Drawing.Point(439, 344)
        Me.TxtNumeroCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumeroCliente.MaxLength = 8
        Me.TxtNumeroCliente.Name = "TxtNumeroCliente"
        Me.TxtNumeroCliente.Size = New System.Drawing.Size(237, 25)
        Me.TxtNumeroCliente.TabIndex = 1
        '
        'DtgConsultarClientes
        '
        Me.DtgConsultarClientes.AllowUserToAddRows = False
        Me.DtgConsultarClientes.AllowUserToDeleteRows = False
        Me.DtgConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgConsultarClientes.Location = New System.Drawing.Point(2, 2)
        Me.DtgConsultarClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgConsultarClientes.Name = "DtgConsultarClientes"
        Me.DtgConsultarClientes.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgConsultarClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgConsultarClientes.Size = New System.Drawing.Size(1069, 304)
        Me.DtgConsultarClientes.TabIndex = 15
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtgConsultarClie
        '
        Me.DtgConsultarClie.AllowUserToAddRows = False
        Me.DtgConsultarClie.AllowUserToDeleteRows = False
        Me.DtgConsultarClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgConsultarClie.Location = New System.Drawing.Point(2, -4)
        Me.DtgConsultarClie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgConsultarClie.Name = "DtgConsultarClie"
        Me.DtgConsultarClie.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DtgConsultarClie.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgConsultarClie.Size = New System.Drawing.Size(1069, 304)
        Me.DtgConsultarClie.TabIndex = 15
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(524, 389)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(120, 41)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(260, 348)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(163, 21)
        Me.CboBusqPorTipo.TabIndex = 17
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSet1
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(439, 344)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaPorNombre.MaxLength = 40
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(303, 25)
        Me.TxtBusquedaPorNombre.TabIndex = 18
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(774, 336)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(80, 40)
        Me.BtnActualizar.TabIndex = 52
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Consultar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1071, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DtgConsultarClientes)
        Me.Controls.Add(Me.TxtNumeroCliente)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Consultar_Cliente"
        Me.Text = "Consultar Cliente"
        CType(Me.DtgConsultarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgConsultarClie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents DtgConsultarClientes As System.Windows.Forms.DataGridView
    Friend WithEvents DtgConsultarClie As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
End Class
