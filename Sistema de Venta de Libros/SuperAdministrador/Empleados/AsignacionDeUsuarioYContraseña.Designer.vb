<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionDeUsuarioYContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignacionDeUsuarioYContraseña))
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.DtgAsignacioDeUsuarioYContraseña = New System.Windows.Forms.DataGridView()
        Me.BtnModificarEstado = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RbtModificarEstado = New System.Windows.Forms.RadioButton()
        Me.RbtInsertar = New System.Windows.Forms.RadioButton()
        Me.RbtModificar = New System.Windows.Forms.RadioButton()
        Me.RbtEliminar = New System.Windows.Forms.RadioButton()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.EstadoTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter()
        Me.LblAyuda = New System.Windows.Forms.Label()
        CType(Me.DtgAsignacioDeUsuarioYContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtContrasena.Location = New System.Drawing.Point(236, 147)
        Me.TxtContrasena.MaxLength = 8
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(216, 22)
        Me.TxtContrasena.TabIndex = 27
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsuario.Location = New System.Drawing.Point(236, 119)
        Me.TxtUsuario.MaxLength = 8
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(216, 22)
        Me.TxtUsuario.TabIndex = 26
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblContrasena.ForeColor = System.Drawing.Color.Black
        Me.LblContrasena.Location = New System.Drawing.Point(128, 152)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(102, 13)
        Me.LblContrasena.TabIndex = 25
        Me.LblContrasena.Text = "Contraseña :"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblUsuario.ForeColor = System.Drawing.Color.Black
        Me.LblUsuario.Location = New System.Drawing.Point(159, 124)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 24
        Me.LblUsuario.Text = "Usuario :"
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Location = New System.Drawing.Point(236, 91)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(216, 22)
        Me.TxtDni.TabIndex = 29
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.BackColor = System.Drawing.Color.Transparent
        Me.LblDni.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblDni.ForeColor = System.Drawing.Color.Black
        Me.LblDni.Location = New System.Drawing.Point(188, 96)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(42, 13)
        Me.LblDni.TabIndex = 28
        Me.LblDni.Text = "Dni  :"
        '
        'DtgAsignacioDeUsuarioYContraseña
        '
        Me.DtgAsignacioDeUsuarioYContraseña.AllowUserToAddRows = False
        Me.DtgAsignacioDeUsuarioYContraseña.AllowUserToDeleteRows = False
        Me.DtgAsignacioDeUsuarioYContraseña.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgAsignacioDeUsuarioYContraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAsignacioDeUsuarioYContraseña.Location = New System.Drawing.Point(4, 266)
        Me.DtgAsignacioDeUsuarioYContraseña.Name = "DtgAsignacioDeUsuarioYContraseña"
        Me.DtgAsignacioDeUsuarioYContraseña.ReadOnly = True
        Me.DtgAsignacioDeUsuarioYContraseña.Size = New System.Drawing.Size(715, 220)
        Me.DtgAsignacioDeUsuarioYContraseña.TabIndex = 30
        '
        'BtnModificarEstado
        '
        Me.BtnModificarEstado.ForeColor = System.Drawing.Color.Black
        Me.BtnModificarEstado.Location = New System.Drawing.Point(229, 520)
        Me.BtnModificarEstado.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnModificarEstado.Name = "BtnModificarEstado"
        Me.BtnModificarEstado.Size = New System.Drawing.Size(161, 35)
        Me.BtnModificarEstado.TabIndex = 36
        Me.BtnModificarEstado.Text = "Modificar Estado"
        Me.BtnModificarEstado.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(314, 210)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 48)
        Me.BtnActualizar.TabIndex = 35
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(58, 520)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(161, 36)
        Me.BtnEliminar.TabIndex = 34
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(300, 580)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 36)
        Me.BtnCancelar.TabIndex = 33
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Location = New System.Drawing.Point(399, 520)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(131, 35)
        Me.BtnModificar.TabIndex = 32
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(539, 520)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(131, 36)
        Me.BtnGuardar.TabIndex = 31
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'RbtModificarEstado
        '
        Me.RbtModificarEstado.AutoSize = True
        Me.RbtModificarEstado.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificarEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RbtModificarEstado.ForeColor = System.Drawing.Color.Black
        Me.RbtModificarEstado.Location = New System.Drawing.Point(539, 30)
        Me.RbtModificarEstado.Margin = New System.Windows.Forms.Padding(5)
        Me.RbtModificarEstado.Name = "RbtModificarEstado"
        Me.RbtModificarEstado.Size = New System.Drawing.Size(157, 17)
        Me.RbtModificarEstado.TabIndex = 40
        Me.RbtModificarEstado.Text = "Modificar Estado "
        Me.RbtModificarEstado.UseVisualStyleBackColor = False
        '
        'RbtInsertar
        '
        Me.RbtInsertar.AutoSize = True
        Me.RbtInsertar.BackColor = System.Drawing.Color.Transparent
        Me.RbtInsertar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RbtInsertar.ForeColor = System.Drawing.Color.Black
        Me.RbtInsertar.Location = New System.Drawing.Point(376, 30)
        Me.RbtInsertar.Margin = New System.Windows.Forms.Padding(5)
        Me.RbtInsertar.Name = "RbtInsertar"
        Me.RbtInsertar.Size = New System.Drawing.Size(89, 17)
        Me.RbtInsertar.TabIndex = 39
        Me.RbtInsertar.Text = "Insertar"
        Me.RbtInsertar.UseVisualStyleBackColor = False
        '
        'RbtModificar
        '
        Me.RbtModificar.AutoSize = True
        Me.RbtModificar.BackColor = System.Drawing.Color.Transparent
        Me.RbtModificar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RbtModificar.ForeColor = System.Drawing.Color.Black
        Me.RbtModificar.Location = New System.Drawing.Point(229, 30)
        Me.RbtModificar.Margin = New System.Windows.Forms.Padding(5)
        Me.RbtModificar.Name = "RbtModificar"
        Me.RbtModificar.Size = New System.Drawing.Size(99, 17)
        Me.RbtModificar.TabIndex = 38
        Me.RbtModificar.Text = "Modificar"
        Me.RbtModificar.UseVisualStyleBackColor = False
        '
        'RbtEliminar
        '
        Me.RbtEliminar.AutoSize = True
        Me.RbtEliminar.BackColor = System.Drawing.Color.Transparent
        Me.RbtEliminar.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RbtEliminar.ForeColor = System.Drawing.Color.Black
        Me.RbtEliminar.Location = New System.Drawing.Point(65, 30)
        Me.RbtEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.RbtEliminar.Name = "RbtEliminar"
        Me.RbtEliminar.Size = New System.Drawing.Size(87, 17)
        Me.RbtEliminar.TabIndex = 37
        Me.RbtEliminar.Text = "Eliminar"
        Me.RbtEliminar.UseVisualStyleBackColor = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.Transparent
        Me.LblEstado.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblEstado.ForeColor = System.Drawing.Color.Black
        Me.LblEstado.Location = New System.Drawing.Point(166, 180)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(64, 13)
        Me.LblEstado.TabIndex = 47
        Me.LblEstado.Text = "Estado :"
        '
        'CboEstado
        '
        Me.CboEstado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CboEstado.DataSource = Me.EstadoBindingSource
        Me.CboEstado.DisplayMember = "descripcion"
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(236, 175)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(216, 23)
        Me.CboEstado.TabIndex = 46
        Me.CboEstado.ValueMember = "cod_estado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'LblAyuda
        '
        Me.LblAyuda.AutoSize = True
        Me.LblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.LblAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAyuda.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAyuda.ForeColor = System.Drawing.Color.Red
        Me.LblAyuda.Location = New System.Drawing.Point(458, 94)
        Me.LblAyuda.Name = "LblAyuda"
        Me.LblAyuda.Size = New System.Drawing.Size(42, 15)
        Me.LblAyuda.TabIndex = 48
        Me.LblAyuda.Text = "Ayuda"
        '
        'AsignacionDeUsuarioYContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(723, 658)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblAyuda)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.CboEstado)
        Me.Controls.Add(Me.RbtModificarEstado)
        Me.Controls.Add(Me.RbtInsertar)
        Me.Controls.Add(Me.RbtModificar)
        Me.Controls.Add(Me.RbtEliminar)
        Me.Controls.Add(Me.BtnModificarEstado)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DtgAsignacioDeUsuarioYContraseña)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.LblDni)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblContrasena)
        Me.Controls.Add(Me.LblUsuario)
        Me.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.GreenYellow
        Me.Name = "AsignacionDeUsuarioYContraseña"
        Me.Text = "Asignación De Usuario y Contraseña"
        CType(Me.DtgAsignacioDeUsuarioYContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContrasena As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents DtgAsignacioDeUsuarioYContraseña As System.Windows.Forms.DataGridView
    Friend WithEvents BtnModificarEstado As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents RbtModificarEstado As System.Windows.Forms.RadioButton
    Friend WithEvents RbtInsertar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModificar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtEliminar As System.Windows.Forms.RadioButton
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents CboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.EstadoTableAdapter
    Friend WithEvents LblAyuda As System.Windows.Forms.Label
End Class
