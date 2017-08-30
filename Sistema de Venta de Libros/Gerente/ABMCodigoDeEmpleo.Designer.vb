<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCodigoDeEmpleo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCodigoDeEmpleo))
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.DtgABMCategoria = New System.Windows.Forms.DataGridView()
        Me.CodigodeEmpleoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.RbtInsertar = New System.Windows.Forms.RadioButton()
        Me.RbtModificar = New System.Windows.Forms.RadioButton()
        Me.RbtEliminar = New System.Windows.Forms.RadioButton()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Codigo_de_EmpleoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter()
        Me.RbtModificarEstado = New System.Windows.Forms.RadioButton()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.BtnModificarEstado = New System.Windows.Forms.Button()
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(423, 134)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(112, 32)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(423, 214)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancelar.TabIndex = 16
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(423, 174)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(112, 32)
        Me.BtnModificar.TabIndex = 15
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DtgABMCategoria
        '
        Me.DtgABMCategoria.AllowUserToAddRows = False
        Me.DtgABMCategoria.AllowUserToDeleteRows = False
        Me.DtgABMCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgABMCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgABMCategoria.Location = New System.Drawing.Point(4, 253)
        Me.DtgABMCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.DtgABMCategoria.Name = "DtgABMCategoria"
        Me.DtgABMCategoria.ReadOnly = True
        Me.DtgABMCategoria.Size = New System.Drawing.Size(560, 208)
        Me.DtgABMCategoria.TabIndex = 14
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
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(423, 94)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Location = New System.Drawing.Point(39, 101)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(101, 18)
        Me.LblDescripcion.TabIndex = 12
        Me.LblDescripcion.Text = "Descripción :"
        Me.LblDescripcion.Visible = False
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.Location = New System.Drawing.Point(73, 71)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(67, 18)
        Me.LblCodigo.TabIndex = 11
        Me.LblCodigo.Text = "Codigo :"
        Me.LblCodigo.Visible = False
        '
        'TxtCategoria
        '
        Me.TxtCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCategoria.Location = New System.Drawing.Point(143, 101)
        Me.TxtCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCategoria.MaxLength = 100
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(223, 25)
        Me.TxtCategoria.TabIndex = 10
        Me.TxtCategoria.Visible = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigo.Location = New System.Drawing.Point(143, 68)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.MaxLength = 3
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(223, 25)
        Me.TxtCodigo.TabIndex = 9
        Me.TxtCodigo.Visible = False
        '
        'RbtInsertar
        '
        Me.RbtInsertar.AutoSize = True
        Me.RbtInsertar.BackColor = System.Drawing.Color.Transparent
        Me.RbtInsertar.Location = New System.Drawing.Point(285, 23)
        Me.RbtInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtInsertar.Name = "RbtInsertar"
        Me.RbtInsertar.Size = New System.Drawing.Size(81, 22)
        Me.RbtInsertar.TabIndex = 20
        Me.RbtInsertar.Text = "Insertar"
        Me.RbtInsertar.UseVisualStyleBackColor = False
        '
        'RbtModificar
        '
        Me.RbtModificar.AutoSize = True
        Me.RbtModificar.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificar.Location = New System.Drawing.Point(159, 23)
        Me.RbtModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificar.Name = "RbtModificar"
        Me.RbtModificar.Size = New System.Drawing.Size(92, 22)
        Me.RbtModificar.TabIndex = 19
        Me.RbtModificar.Text = "Modificar"
        Me.RbtModificar.UseVisualStyleBackColor = False
        '
        'RbtEliminar
        '
        Me.RbtEliminar.AutoSize = True
        Me.RbtEliminar.BackColor = System.Drawing.Color.Transparent
        Me.RbtEliminar.Location = New System.Drawing.Point(42, 23)
        Me.RbtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtEliminar.Name = "RbtEliminar"
        Me.RbtEliminar.Size = New System.Drawing.Size(83, 22)
        Me.RbtEliminar.TabIndex = 18
        Me.RbtEliminar.Text = "Eliminar"
        Me.RbtEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(212, 204)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(86, 42)
        Me.BtnActualizar.TabIndex = 40
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Codigo_de_EmpleoTableAdapter
        '
        Me.Codigo_de_EmpleoTableAdapter.ClearBeforeFill = True
        '
        'RbtModificarEstado
        '
        Me.RbtModificarEstado.AutoSize = True
        Me.RbtModificarEstado.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificarEstado.Location = New System.Drawing.Point(386, 23)
        Me.RbtModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificarEstado.Name = "RbtModificarEstado"
        Me.RbtModificarEstado.Size = New System.Drawing.Size(149, 22)
        Me.RbtModificarEstado.TabIndex = 41
        Me.RbtModificarEstado.Text = "Modificar Estado "
        Me.RbtModificarEstado.UseVisualStyleBackColor = False
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(143, 133)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(223, 26)
        Me.CboEstado.TabIndex = 43
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
        Me.LblEstado.Location = New System.Drawing.Point(75, 133)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(65, 18)
        Me.LblEstado.TabIndex = 42
        Me.LblEstado.Text = "Estado :"
        Me.LblEstado.Visible = False
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'BtnModificarEstado
        '
        Me.BtnModificarEstado.Location = New System.Drawing.Point(407, 58)
        Me.BtnModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificarEstado.Name = "BtnModificarEstado"
        Me.BtnModificarEstado.Size = New System.Drawing.Size(139, 28)
        Me.BtnModificarEstado.TabIndex = 44
        Me.BtnModificarEstado.Text = "Modificar Estado"
        Me.BtnModificarEstado.UseVisualStyleBackColor = True
        '
        'ABMCodigoDeEmpleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(566, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnModificarEstado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.RbtModificarEstado)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.RbtInsertar)
        Me.Controls.Add(Me.RbtModificar)
        Me.Controls.Add(Me.RbtEliminar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DtgABMCategoria)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ABMCodigoDeEmpleo"
        Me.Text = "ABMCodigoDeEmpleo"
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigodeEmpleoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents DtgABMCategoria As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents CodEmpleoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RbtInsertar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents CodigodeEmpleoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Codigo_de_EmpleoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.Codigo_de_EmpleoTableAdapter
    Friend WithEvents RbtModificarEstado As System.Windows.Forms.RadioButton
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents BtnModificarEstado As System.Windows.Forms.Button
End Class
