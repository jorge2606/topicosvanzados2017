<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtNumeroDeEmpleado = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DtgEliminarEmpleados = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.EmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DtgEliminarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroDeEmpleado
        '
        Me.TxtNumeroDeEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroDeEmpleado.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroDeEmpleado.Location = New System.Drawing.Point(391, 401)
        Me.TxtNumeroDeEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNumeroDeEmpleado.MaxLength = 8
        Me.TxtNumeroDeEmpleado.Name = "TxtNumeroDeEmpleado"
        Me.TxtNumeroDeEmpleado.Size = New System.Drawing.Size(306, 25)
        Me.TxtNumeroDeEmpleado.TabIndex = 1
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(496, 443)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 46)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'DtgEliminarEmpleados
        '
        Me.DtgEliminarEmpleados.AllowUserToAddRows = False
        Me.DtgEliminarEmpleados.AllowUserToDeleteRows = False
        Me.DtgEliminarEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DtgEliminarEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DtgEliminarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgEliminarEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DtgEliminarEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DtgEliminarEmpleados.Location = New System.Drawing.Point(2, 2)
        Me.DtgEliminarEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgEliminarEmpleados.Name = "DtgEliminarEmpleados"
        Me.DtgEliminarEmpleados.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgEliminarEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgEliminarEmpleados.Size = New System.Drawing.Size(1061, 359)
        Me.DtgEliminarEmpleados.TabIndex = 17
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(391, 401)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtBusquedaPorNombre.MaxLength = 40
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(306, 25)
        Me.TxtBusquedaPorNombre.TabIndex = 39
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(202, 401)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(182, 21)
        Me.CboBusqPorTipo.TabIndex = 37
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(87, 391)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(80, 40)
        Me.BtnActualizar.TabIndex = 51
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Eliminar_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.DtgEliminarEmpleados)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtNumeroDeEmpleado)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimizeBox = False
        Me.Name = "Eliminar_Empleados"
        Me.Text = "Eliminar Empleados"
        CType(Me.DtgEliminarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroDeEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DtgEliminarEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
End Class
