<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Empleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Empleados))
        Me.TxtNumeroEmpleado = New System.Windows.Forms.TextBox()
        Me.DtgConsultarEmpleados = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.EmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter()
        Me.TxtBusquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DtgConsultarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroEmpleado
        '
        Me.TxtNumeroEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroEmpleado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNumeroEmpleado.Location = New System.Drawing.Point(506, 351)
        Me.TxtNumeroEmpleado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNumeroEmpleado.MaxLength = 8
        Me.TxtNumeroEmpleado.Name = "TxtNumeroEmpleado"
        Me.TxtNumeroEmpleado.Size = New System.Drawing.Size(283, 20)
        Me.TxtNumeroEmpleado.TabIndex = 1
        '
        'DtgConsultarEmpleados
        '
        Me.DtgConsultarEmpleados.AllowUserToAddRows = False
        Me.DtgConsultarEmpleados.AllowUserToDeleteRows = False
        Me.DtgConsultarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgConsultarEmpleados.Location = New System.Drawing.Point(3, 3)
        Me.DtgConsultarEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgConsultarEmpleados.Name = "DtgConsultarEmpleados"
        Me.DtgConsultarEmpleados.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgConsultarEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgConsultarEmpleados.Size = New System.Drawing.Size(1246, 299)
        Me.DtgConsultarEmpleados.TabIndex = 32
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(621, 405)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(77, 41)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nombre", "Dni"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(317, 350)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(182, 21)
        Me.CboBusqPorTipo.TabIndex = 34
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TxtBusquedaPorNombre
        '
        Me.TxtBusquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorNombre.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtBusquedaPorNombre.Location = New System.Drawing.Point(506, 351)
        Me.TxtBusquedaPorNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtBusquedaPorNombre.MaxLength = 40
        Me.TxtBusquedaPorNombre.Name = "TxtBusquedaPorNombre"
        Me.TxtBusquedaPorNombre.Size = New System.Drawing.Size(283, 20)
        Me.TxtBusquedaPorNombre.TabIndex = 36
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(122, 351)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(80, 40)
        Me.BtnActualizar.TabIndex = 51
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Consultar_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1251, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtBusquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DtgConsultarEmpleados)
        Me.Controls.Add(Me.TxtNumeroEmpleado)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Consultar_Empleados"
        Me.Text = "Consultar Empleados"
        CType(Me.DtgConsultarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents DtgConsultarEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents EmpleadosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents TxtBusquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
End Class
