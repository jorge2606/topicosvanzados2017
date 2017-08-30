<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz_del_Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz_del_Administrador))
        Me.LblBienvenidoAdministrador = New System.Windows.Forms.Label()
        Me.TxtNombreDelAdministrador = New System.Windows.Forms.TextBox()
        Me.LblCerrarSesion = New System.Windows.Forms.Label()
        Me.BtnConsultarLibros = New System.Windows.Forms.Button()
        Me.BtnModificarLibros = New System.Windows.Forms.Button()
        Me.BtnEliminarLibros = New System.Windows.Forms.Button()
        Me.BtnRegistrarLibros = New System.Windows.Forms.Button()
        Me.PtbPerfilDelAdministrador = New System.Windows.Forms.PictureBox()
        CType(Me.PtbPerfilDelAdministrador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBienvenidoAdministrador
        '
        Me.LblBienvenidoAdministrador.AutoSize = True
        Me.LblBienvenidoAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.LblBienvenidoAdministrador.ForeColor = System.Drawing.Color.Black
        Me.LblBienvenidoAdministrador.Location = New System.Drawing.Point(30, 11)
        Me.LblBienvenidoAdministrador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBienvenidoAdministrador.Name = "LblBienvenidoAdministrador"
        Me.LblBienvenidoAdministrador.Size = New System.Drawing.Size(207, 13)
        Me.LblBienvenidoAdministrador.TabIndex = 0
        Me.LblBienvenidoAdministrador.Text = "Bienvenido Administrador: "
        '
        'TxtNombreDelAdministrador
        '
        Me.TxtNombreDelAdministrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombreDelAdministrador.Enabled = False
        Me.TxtNombreDelAdministrador.Location = New System.Drawing.Point(241, 8)
        Me.TxtNombreDelAdministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreDelAdministrador.Name = "TxtNombreDelAdministrador"
        Me.TxtNombreDelAdministrador.Size = New System.Drawing.Size(268, 20)
        Me.TxtNombreDelAdministrador.TabIndex = 1
        '
        'LblCerrarSesion
        '
        Me.LblCerrarSesion.AutoSize = True
        Me.LblCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.LblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCerrarSesion.Font = New System.Drawing.Font("Felix Titling", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCerrarSesion.ForeColor = System.Drawing.Color.Red
        Me.LblCerrarSesion.Location = New System.Drawing.Point(561, 126)
        Me.LblCerrarSesion.Name = "LblCerrarSesion"
        Me.LblCerrarSesion.Size = New System.Drawing.Size(109, 13)
        Me.LblCerrarSesion.TabIndex = 8
        Me.LblCerrarSesion.Text = "Cerrar Sesión"
        '
        'BtnConsultarLibros
        '
        Me.BtnConsultarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnConsultarLibros.ForeColor = System.Drawing.Color.Black
        Me.BtnConsultarLibros.Image = CType(resources.GetObject("BtnConsultarLibros.Image"), System.Drawing.Image)
        Me.BtnConsultarLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultarLibros.Location = New System.Drawing.Point(268, 284)
        Me.BtnConsultarLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnConsultarLibros.Name = "BtnConsultarLibros"
        Me.BtnConsultarLibros.Size = New System.Drawing.Size(220, 55)
        Me.BtnConsultarLibros.TabIndex = 5
        Me.BtnConsultarLibros.Text = "Consultar Libros"
        Me.BtnConsultarLibros.UseVisualStyleBackColor = False
        '
        'BtnModificarLibros
        '
        Me.BtnModificarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnModificarLibros.ForeColor = System.Drawing.Color.Black
        Me.BtnModificarLibros.Image = CType(resources.GetObject("BtnModificarLibros.Image"), System.Drawing.Image)
        Me.BtnModificarLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificarLibros.Location = New System.Drawing.Point(268, 206)
        Me.BtnModificarLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificarLibros.Name = "BtnModificarLibros"
        Me.BtnModificarLibros.Size = New System.Drawing.Size(220, 55)
        Me.BtnModificarLibros.TabIndex = 4
        Me.BtnModificarLibros.Text = "Modificar Libros"
        Me.BtnModificarLibros.UseVisualStyleBackColor = False
        '
        'BtnEliminarLibros
        '
        Me.BtnEliminarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnEliminarLibros.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminarLibros.Image = CType(resources.GetObject("BtnEliminarLibros.Image"), System.Drawing.Image)
        Me.BtnEliminarLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarLibros.Location = New System.Drawing.Point(268, 126)
        Me.BtnEliminarLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminarLibros.Name = "BtnEliminarLibros"
        Me.BtnEliminarLibros.Size = New System.Drawing.Size(220, 55)
        Me.BtnEliminarLibros.TabIndex = 3
        Me.BtnEliminarLibros.Text = "Eliminar Libros"
        Me.BtnEliminarLibros.UseVisualStyleBackColor = False
        '
        'BtnRegistrarLibros
        '
        Me.BtnRegistrarLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnRegistrarLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrarLibros.ForeColor = System.Drawing.Color.Black
        Me.BtnRegistrarLibros.Image = CType(resources.GetObject("BtnRegistrarLibros.Image"), System.Drawing.Image)
        Me.BtnRegistrarLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrarLibros.Location = New System.Drawing.Point(268, 45)
        Me.BtnRegistrarLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrarLibros.Name = "BtnRegistrarLibros"
        Me.BtnRegistrarLibros.Size = New System.Drawing.Size(220, 55)
        Me.BtnRegistrarLibros.TabIndex = 2
        Me.BtnRegistrarLibros.Text = "Registrar Libros"
        Me.BtnRegistrarLibros.UseVisualStyleBackColor = False
        '
        'PtbPerfilDelAdministrador
        '
        Me.PtbPerfilDelAdministrador.BackColor = System.Drawing.Color.Gray
        Me.PtbPerfilDelAdministrador.Location = New System.Drawing.Point(545, 8)
        Me.PtbPerfilDelAdministrador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PtbPerfilDelAdministrador.Name = "PtbPerfilDelAdministrador"
        Me.PtbPerfilDelAdministrador.Size = New System.Drawing.Size(140, 112)
        Me.PtbPerfilDelAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbPerfilDelAdministrador.TabIndex = 9
        Me.PtbPerfilDelAdministrador.TabStop = False
        '
        'Interfaz_del_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.PtbPerfilDelAdministrador)
        Me.Controls.Add(Me.LblCerrarSesion)
        Me.Controls.Add(Me.BtnConsultarLibros)
        Me.Controls.Add(Me.BtnModificarLibros)
        Me.Controls.Add(Me.BtnEliminarLibros)
        Me.Controls.Add(Me.BtnRegistrarLibros)
        Me.Controls.Add(Me.TxtNombreDelAdministrador)
        Me.Controls.Add(Me.LblBienvenidoAdministrador)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Interfaz_del_Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfaz del Administrador"
        CType(Me.PtbPerfilDelAdministrador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblBienvenidoAdministrador As System.Windows.Forms.Label
    Friend WithEvents TxtNombreDelAdministrador As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegistrarLibros As System.Windows.Forms.Button
    Friend WithEvents BtnEliminarLibros As System.Windows.Forms.Button
    Friend WithEvents BtnModificarLibros As System.Windows.Forms.Button
    Friend WithEvents BtnConsultarLibros As System.Windows.Forms.Button
    Friend WithEvents LblCerrarSesion As System.Windows.Forms.Label
    Friend WithEvents PtbPerfilDelAdministrador As System.Windows.Forms.PictureBox
End Class
