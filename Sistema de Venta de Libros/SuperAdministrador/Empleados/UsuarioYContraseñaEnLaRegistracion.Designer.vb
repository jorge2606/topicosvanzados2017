<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioYContraseñaEnLaRegistracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuarioYContraseñaEnLaRegistracion))
        Me.DtgUsuariosYContrasenas = New System.Windows.Forms.DataGridView()
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoEnElSistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosDelSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.UsuariosDelSistemaTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.UsuariosDelSistemaTableAdapter()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.DtgUsuariosYContrasenas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDelSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgUsuariosYContrasenas
        '
        Me.DtgUsuariosYContrasenas.AllowUserToAddRows = False
        Me.DtgUsuariosYContrasenas.AllowUserToDeleteRows = False
        Me.DtgUsuariosYContrasenas.AutoGenerateColumns = False
        Me.DtgUsuariosYContrasenas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgUsuariosYContrasenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgUsuariosYContrasenas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DniDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.EstadoEnElSistemaDataGridViewTextBoxColumn})
        Me.DtgUsuariosYContrasenas.DataSource = Me.UsuariosDelSistemaBindingSource
        Me.DtgUsuariosYContrasenas.Location = New System.Drawing.Point(16, 168)
        Me.DtgUsuariosYContrasenas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DtgUsuariosYContrasenas.Name = "DtgUsuariosYContrasenas"
        Me.DtgUsuariosYContrasenas.ReadOnly = True
        Me.DtgUsuariosYContrasenas.Size = New System.Drawing.Size(680, 223)
        Me.DtgUsuariosYContrasenas.TabIndex = 0
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoEnElSistemaDataGridViewTextBoxColumn
        '
        Me.EstadoEnElSistemaDataGridViewTextBoxColumn.DataPropertyName = "estadoEnElSistema"
        Me.EstadoEnElSistemaDataGridViewTextBoxColumn.HeaderText = "estadoEnElSistema"
        Me.EstadoEnElSistemaDataGridViewTextBoxColumn.Name = "EstadoEnElSistemaDataGridViewTextBoxColumn"
        Me.EstadoEnElSistemaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuariosDelSistemaBindingSource
        '
        Me.UsuariosDelSistemaBindingSource.DataMember = "UsuariosDelSistema"
        Me.UsuariosDelSistemaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosDelSistemaTableAdapter
        '
        Me.UsuariosDelSistemaTableAdapter.ClearBeforeFill = True
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDni.Location = New System.Drawing.Point(219, 30)
        Me.TxtDni.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(287, 20)
        Me.TxtDni.TabIndex = 35
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.BackColor = System.Drawing.Color.Transparent
        Me.LblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDni.Location = New System.Drawing.Point(175, 34)
        Me.LblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(42, 13)
        Me.LblDni.TabIndex = 34
        Me.LblDni.Text = "Dni  :"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtContrasena.Location = New System.Drawing.Point(219, 82)
        Me.TxtContrasena.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtContrasena.MaxLength = 8
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(287, 20)
        Me.TxtContrasena.TabIndex = 33
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsuario.Location = New System.Drawing.Point(219, 56)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtUsuario.MaxLength = 8
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(287, 20)
        Me.TxtUsuario.TabIndex = 32
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblContrasena.Location = New System.Drawing.Point(114, 86)
        Me.LblContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(102, 13)
        Me.LblContrasena.TabIndex = 31
        Me.LblContrasena.Text = "Contraseña :"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblUsuario.Location = New System.Drawing.Point(146, 59)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 13)
        Me.LblUsuario.TabIndex = 30
        Me.LblUsuario.Text = "Usuario :"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(395, 120)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(66, 42)
        Me.BtnActualizar.TabIndex = 36
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(279, 120)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(66, 42)
        Me.BtnGuardar.TabIndex = 37
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(338, 404)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(66, 42)
        Me.BtnCancelar.TabIndex = 38
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'UsuarioYContraseñaEnLaRegistracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(703, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.LblDni)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblContrasena)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.DtgUsuariosYContrasenas)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UsuarioYContraseñaEnLaRegistracion"
        Me.Text = "Usuario y Contraseña en la Registración"
        CType(Me.DtgUsuariosYContrasenas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDelSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtgUsuariosYContrasenas As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents UsuariosDelSistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosDelSistemaTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.UsuariosDelSistemaTableAdapter
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoEnElSistemaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents TxtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContrasena As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
