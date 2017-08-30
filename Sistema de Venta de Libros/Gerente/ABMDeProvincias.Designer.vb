<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMDeProvincias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMDeProvincias))
        Me.LblNroProvincia = New System.Windows.Forms.Label()
        Me.LblNombreDeProvincia = New System.Windows.Forms.Label()
        Me.txtNroProvincia = New System.Windows.Forms.TextBox()
        Me.txtNombreProvincia = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.DtgProvincias = New System.Windows.Forms.DataGridView()
        Me.CodProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RbtInsertar = New System.Windows.Forms.RadioButton()
        Me.RbtModificar = New System.Windows.Forms.RadioButton()
        Me.RbtEliminar = New System.Windows.Forms.RadioButton()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.RbtModificarEstado = New System.Windows.Forms.RadioButton()
        Me.BtnModificarEstado = New System.Windows.Forms.Button()
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgProvincias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNroProvincia
        '
        Me.LblNroProvincia.AutoSize = True
        Me.LblNroProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LblNroProvincia.Location = New System.Drawing.Point(35, 63)
        Me.LblNroProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNroProvincia.Name = "LblNroProvincia"
        Me.LblNroProvincia.Size = New System.Drawing.Size(42, 18)
        Me.LblNroProvincia.TabIndex = 0
        Me.LblNroProvincia.Text = "Nro :"
        Me.LblNroProvincia.Visible = False
        '
        'LblNombreDeProvincia
        '
        Me.LblNombreDeProvincia.AutoSize = True
        Me.LblNombreDeProvincia.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreDeProvincia.Location = New System.Drawing.Point(9, 99)
        Me.LblNombreDeProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombreDeProvincia.Name = "LblNombreDeProvincia"
        Me.LblNombreDeProvincia.Size = New System.Drawing.Size(72, 18)
        Me.LblNombreDeProvincia.TabIndex = 1
        Me.LblNombreDeProvincia.Text = "Nombre :"
        Me.LblNombreDeProvincia.Visible = False
        '
        'txtNroProvincia
        '
        Me.txtNroProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroProvincia.Location = New System.Drawing.Point(89, 59)
        Me.txtNroProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroProvincia.MaxLength = 3
        Me.txtNroProvincia.Name = "txtNroProvincia"
        Me.txtNroProvincia.Size = New System.Drawing.Size(238, 25)
        Me.txtNroProvincia.TabIndex = 2
        Me.txtNroProvincia.Visible = False
        '
        'txtNombreProvincia
        '
        Me.txtNombreProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombreProvincia.Location = New System.Drawing.Point(89, 95)
        Me.txtNombreProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProvincia.MaxLength = 100
        Me.txtNombreProvincia.Name = "txtNombreProvincia"
        Me.txtNombreProvincia.Size = New System.Drawing.Size(238, 25)
        Me.txtNombreProvincia.TabIndex = 3
        Me.txtNombreProvincia.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(393, 99)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(141, 36)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(534, 53)
        Me.BtnQuitar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(128, 36)
        Me.BtnQuitar.TabIndex = 6
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(543, 143)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 36)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(534, 99)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(128, 36)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtgProvincias
        '
        Me.DtgProvincias.AllowUserToAddRows = False
        Me.DtgProvincias.AllowUserToDeleteRows = False
        Me.DtgProvincias.AutoGenerateColumns = False
        Me.DtgProvincias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProvincias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProvinciaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DtgProvincias.DataSource = Me.ProvinciasBindingSource
        Me.DtgProvincias.Location = New System.Drawing.Point(3, 214)
        Me.DtgProvincias.Margin = New System.Windows.Forms.Padding(4)
        Me.DtgProvincias.Name = "DtgProvincias"
        Me.DtgProvincias.ReadOnly = True
        Me.DtgProvincias.Size = New System.Drawing.Size(659, 246)
        Me.DtgProvincias.TabIndex = 9
        '
        'CodProvinciaDataGridViewTextBoxColumn
        '
        Me.CodProvinciaDataGridViewTextBoxColumn.DataPropertyName = "cod_Provincia"
        Me.CodProvinciaDataGridViewTextBoxColumn.HeaderText = "cod_Provincia"
        Me.CodProvinciaDataGridViewTextBoxColumn.Name = "CodProvinciaDataGridViewTextBoxColumn"
        Me.CodProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodProvinciaDataGridViewTextBoxColumn.Width = 200
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 200
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.DataSet1
        '
        'RbtInsertar
        '
        Me.RbtInsertar.AutoSize = True
        Me.RbtInsertar.BackColor = System.Drawing.Color.Transparent
        Me.RbtInsertar.Location = New System.Drawing.Point(304, 22)
        Me.RbtInsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtInsertar.Name = "RbtInsertar"
        Me.RbtInsertar.Size = New System.Drawing.Size(81, 22)
        Me.RbtInsertar.TabIndex = 14
        Me.RbtInsertar.Text = "Insertar"
        Me.RbtInsertar.UseVisualStyleBackColor = False
        '
        'RbtModificar
        '
        Me.RbtModificar.AutoSize = True
        Me.RbtModificar.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificar.Location = New System.Drawing.Point(178, 22)
        Me.RbtModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificar.Name = "RbtModificar"
        Me.RbtModificar.Size = New System.Drawing.Size(92, 22)
        Me.RbtModificar.TabIndex = 13
        Me.RbtModificar.Text = "Modificar"
        Me.RbtModificar.UseVisualStyleBackColor = False
        '
        'RbtEliminar
        '
        Me.RbtEliminar.AutoSize = True
        Me.RbtEliminar.BackColor = System.Drawing.Color.Transparent
        Me.RbtEliminar.Location = New System.Drawing.Point(38, 22)
        Me.RbtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtEliminar.Name = "RbtEliminar"
        Me.RbtEliminar.Size = New System.Drawing.Size(83, 22)
        Me.RbtEliminar.TabIndex = 12
        Me.RbtEliminar.Text = "Eliminar"
        Me.RbtEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(323, 165)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(86, 42)
        Me.BtnActualizar.TabIndex = 44
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(89, 127)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(238, 26)
        Me.CboEstado.TabIndex = 46
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
        Me.LblEstado.Location = New System.Drawing.Point(19, 134)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(65, 18)
        Me.LblEstado.TabIndex = 45
        Me.LblEstado.Text = "Estado :"
        Me.LblEstado.Visible = False
        '
        'RbtModificarEstado
        '
        Me.RbtModificarEstado.AutoSize = True
        Me.RbtModificarEstado.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificarEstado.Location = New System.Drawing.Point(393, 22)
        Me.RbtModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.RbtModificarEstado.Name = "RbtModificarEstado"
        Me.RbtModificarEstado.Size = New System.Drawing.Size(149, 22)
        Me.RbtModificarEstado.TabIndex = 47
        Me.RbtModificarEstado.Text = "Modificar Estado "
        Me.RbtModificarEstado.UseVisualStyleBackColor = False
        '
        'BtnModificarEstado
        '
        Me.BtnModificarEstado.Location = New System.Drawing.Point(393, 54)
        Me.BtnModificarEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificarEstado.Name = "BtnModificarEstado"
        Me.BtnModificarEstado.Size = New System.Drawing.Size(141, 37)
        Me.BtnModificarEstado.TabIndex = 48
        Me.BtnModificarEstado.Text = "Modificar Estado"
        Me.BtnModificarEstado.UseVisualStyleBackColor = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'ABMDeProvincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnModificarEstado)
        Me.Controls.Add(Me.RbtModificarEstado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.RbtInsertar)
        Me.Controls.Add(Me.RbtModificar)
        Me.Controls.Add(Me.RbtEliminar)
        Me.Controls.Add(Me.DtgProvincias)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.txtNombreProvincia)
        Me.Controls.Add(Me.txtNroProvincia)
        Me.Controls.Add(Me.LblNombreDeProvincia)
        Me.Controls.Add(Me.LblNroProvincia)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ABMDeProvincias"
        Me.Text = "ABMDeProvincias"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgProvincias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNroProvincia As System.Windows.Forms.Label
    Friend WithEvents LblNombreDeProvincia As System.Windows.Forms.Label
    Friend WithEvents txtNroProvincia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProvincia As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents DescricpionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents DtgProvincias As System.Windows.Forms.DataGridView
    Friend WithEvents RbtInsertar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents RbtModificarEstado As System.Windows.Forms.RadioButton
    Friend WithEvents CodProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnModificarEstado As System.Windows.Forms.Button
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
End Class
