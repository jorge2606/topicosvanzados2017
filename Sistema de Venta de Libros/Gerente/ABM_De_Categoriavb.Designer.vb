<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_De_Categoriavb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABM_De_Categoriavb))
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DtgABMCategoria = New System.Windows.Forms.DataGridView()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.CategoriasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.RbtEliminar = New System.Windows.Forms.RadioButton()
        Me.RbtModificar = New System.Windows.Forms.RadioButton()
        Me.RbtInsertar = New System.Windows.Forms.RadioButton()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.RbtModificarEstado = New System.Windows.Forms.RadioButton()
        Me.BtnModificarEstado = New System.Windows.Forms.Button()
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCodigo.Location = New System.Drawing.Point(99, 82)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodigo.MaxLength = 3
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(223, 25)
        Me.TxtCodigo.TabIndex = 0
        Me.TxtCodigo.Visible = False
        '
        'TxtCategoria
        '
        Me.TxtCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCategoria.Location = New System.Drawing.Point(99, 117)
        Me.TxtCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCategoria.MaxLength = 30
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(223, 25)
        Me.TxtCategoria.TabIndex = 1
        Me.TxtCategoria.Visible = False
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.LblCodigo.Location = New System.Drawing.Point(27, 82)
        Me.LblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(67, 18)
        Me.LblCodigo.TabIndex = 2
        Me.LblCodigo.Text = "Codigo :"
        Me.LblCodigo.Visible = False
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LblCategoria.Location = New System.Drawing.Point(13, 120)
        Me.LblCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(85, 18)
        Me.LblCategoria.TabIndex = 3
        Me.LblCategoria.Text = "Categoria :"
        Me.LblCategoria.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(546, 82)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DtgABMCategoria
        '
        Me.DtgABMCategoria.AllowUserToAddRows = False
        Me.DtgABMCategoria.AllowUserToDeleteRows = False
        Me.DtgABMCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgABMCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgABMCategoria.Location = New System.Drawing.Point(3, 255)
        Me.DtgABMCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.DtgABMCategoria.Name = "DtgABMCategoria"
        Me.DtgABMCategoria.ReadOnly = True
        Me.DtgABMCategoria.Size = New System.Drawing.Size(665, 208)
        Me.DtgABMCategoria.TabIndex = 5
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(546, 131)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(112, 31)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(546, 170)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 32)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(401, 82)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(138, 32)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'RbtEliminar
        '
        Me.RbtEliminar.AutoSize = True
        Me.RbtEliminar.BackColor = System.Drawing.Color.Transparent
        Me.RbtEliminar.Location = New System.Drawing.Point(22, 32)
        Me.RbtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtEliminar.Name = "RbtEliminar"
        Me.RbtEliminar.Size = New System.Drawing.Size(83, 22)
        Me.RbtEliminar.TabIndex = 9
        Me.RbtEliminar.Text = "Eliminar"
        Me.RbtEliminar.UseVisualStyleBackColor = False
        '
        'RbtModificar
        '
        Me.RbtModificar.AutoSize = True
        Me.RbtModificar.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificar.Location = New System.Drawing.Point(162, 32)
        Me.RbtModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificar.Name = "RbtModificar"
        Me.RbtModificar.Size = New System.Drawing.Size(92, 22)
        Me.RbtModificar.TabIndex = 10
        Me.RbtModificar.Text = "Modificar"
        Me.RbtModificar.UseVisualStyleBackColor = False
        '
        'RbtInsertar
        '
        Me.RbtInsertar.AutoSize = True
        Me.RbtInsertar.BackColor = System.Drawing.Color.Transparent
        Me.RbtInsertar.Location = New System.Drawing.Point(288, 32)
        Me.RbtInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtInsertar.Name = "RbtInsertar"
        Me.RbtInsertar.Size = New System.Drawing.Size(81, 22)
        Me.RbtInsertar.TabIndex = 11
        Me.RbtInsertar.Text = "Insertar"
        Me.RbtInsertar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(321, 206)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(86, 42)
        Me.BtnActualizar.TabIndex = 12
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Location = New System.Drawing.Point(29, 156)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(65, 18)
        Me.LblEstado.TabIndex = 14
        Me.LblEstado.Text = "Estado :"
        Me.LblEstado.Visible = False
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(99, 149)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(223, 26)
        Me.CboEstado.TabIndex = 15
        Me.CboEstado.ValueMember = "cod_estado"
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
        'RbtModificarEstado
        '
        Me.RbtModificarEstado.AutoSize = True
        Me.RbtModificarEstado.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificarEstado.Location = New System.Drawing.Point(390, 32)
        Me.RbtModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificarEstado.Name = "RbtModificarEstado"
        Me.RbtModificarEstado.Size = New System.Drawing.Size(149, 22)
        Me.RbtModificarEstado.TabIndex = 16
        Me.RbtModificarEstado.Text = "Modificar Estado "
        Me.RbtModificarEstado.UseVisualStyleBackColor = False
        '
        'BtnModificarEstado
        '
        Me.BtnModificarEstado.Location = New System.Drawing.Point(401, 131)
        Me.BtnModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificarEstado.Name = "BtnModificarEstado"
        Me.BtnModificarEstado.Size = New System.Drawing.Size(138, 31)
        Me.BtnModificarEstado.TabIndex = 17
        Me.BtnModificarEstado.Text = "Modificar Estado"
        Me.BtnModificarEstado.UseVisualStyleBackColor = True
        '
        'ABM_De_Categoriavb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnModificarEstado)
        Me.Controls.Add(Me.RbtModificarEstado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.RbtInsertar)
        Me.Controls.Add(Me.RbtModificar)
        Me.Controls.Add(Me.RbtEliminar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DtgABMCategoria)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.TxtCategoria)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ABM_De_Categoriavb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM_De_Categoriavb"
        CType(Me.DtgABMCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents DtgABMCategoria As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents CategoriasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.CategoriasTableAdapter
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents RbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtInsertar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents RbtModificarEstado As System.Windows.Forms.RadioButton
    Friend WithEvents BtnModificarEstado As System.Windows.Forms.Button
End Class
