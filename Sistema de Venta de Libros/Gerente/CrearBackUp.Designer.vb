<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackup
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
        Me.OFDElegirRuta = New System.Windows.Forms.OpenFileDialog()
        Me.BtnRuta = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.LblRuta = New System.Windows.Forms.Label()
        Me.BtnCrearBackup = New System.Windows.Forms.Button()
        Me.TxtNombreBackup = New System.Windows.Forms.TextBox()
        Me.LblBackUp = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblServidor = New System.Windows.Forms.Label()
        Me.DTPFehaDeHoy = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaDeHoy = New System.Windows.Forms.Label()
        Me.DTPHoraDelSistema = New System.Windows.Forms.DateTimePicker()
        Me.LblHoraDelSistema = New System.Windows.Forms.Label()
        Me.PgbBackUp = New System.Windows.Forms.ProgressBar()
        Me.LblProcentaje = New System.Windows.Forms.Label()
        Me.LblLoading = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.STRPBarraDeCarga = New System.Windows.Forms.StatusStrip()
        Me.TSPBBarra = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSLCargando = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLPorcentaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.STRPBarraDeCarga.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFDElegirRuta
        '
        Me.OFDElegirRuta.FileName = "OpenFileDialog1"
        '
        'BtnRuta
        '
        Me.BtnRuta.BackColor = System.Drawing.Color.Teal
        Me.BtnRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BtnRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRuta.Location = New System.Drawing.Point(612, 179)
        Me.BtnRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRuta.Name = "BtnRuta"
        Me.BtnRuta.Size = New System.Drawing.Size(103, 33)
        Me.BtnRuta.TabIndex = 0
        Me.BtnRuta.Text = "Examinar. .. "
        Me.BtnRuta.UseVisualStyleBackColor = False
        '
        'TxtRuta
        '
        Me.TxtRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.TxtRuta.Location = New System.Drawing.Point(185, 184)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(419, 23)
        Me.TxtRuta.TabIndex = 1
        Me.TxtRuta.Text = "C:\Back-Up"
        '
        'LblRuta
        '
        Me.LblRuta.AutoSize = True
        Me.LblRuta.BackColor = System.Drawing.Color.Transparent
        Me.LblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblRuta.Location = New System.Drawing.Point(381, 156)
        Me.LblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(53, 24)
        Me.LblRuta.TabIndex = 2
        Me.LblRuta.Text = "Ruta "
        '
        'BtnCrearBackup
        '
        Me.BtnCrearBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BtnCrearBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCrearBackup.Location = New System.Drawing.Point(339, 238)
        Me.BtnCrearBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCrearBackup.Name = "BtnCrearBackup"
        Me.BtnCrearBackup.Size = New System.Drawing.Size(137, 52)
        Me.BtnCrearBackup.TabIndex = 3
        Me.BtnCrearBackup.Text = "Crear BackUp"
        Me.BtnCrearBackup.UseVisualStyleBackColor = True
        '
        'TxtNombreBackup
        '
        Me.TxtNombreBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNombreBackup.Enabled = False
        Me.TxtNombreBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtNombreBackup.Location = New System.Drawing.Point(545, 96)
        Me.TxtNombreBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombreBackup.Name = "TxtNombreBackup"
        Me.TxtNombreBackup.Size = New System.Drawing.Size(205, 29)
        Me.TxtNombreBackup.TabIndex = 4
        Me.TxtNombreBackup.Text = "Venta_de_libros"
        '
        'LblBackUp
        '
        Me.LblBackUp.AutoSize = True
        Me.LblBackUp.BackColor = System.Drawing.Color.Transparent
        Me.LblBackUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblBackUp.Location = New System.Drawing.Point(349, 99)
        Me.LblBackUp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBackUp.Name = "LblBackUp"
        Me.LblBackUp.Size = New System.Drawing.Size(188, 24)
        Me.LblBackUp.TabIndex = 5
        Me.LblBackUp.Text = "Nombre Del Back-Up"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TextBox1.Location = New System.Drawing.Point(208, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 29)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "JORGE-PC"
        '
        'LblServidor
        '
        Me.LblServidor.AutoSize = True
        Me.LblServidor.BackColor = System.Drawing.Color.Transparent
        Me.LblServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServidor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblServidor.Location = New System.Drawing.Point(12, 99)
        Me.LblServidor.Name = "LblServidor"
        Me.LblServidor.Size = New System.Drawing.Size(190, 24)
        Me.LblServidor.TabIndex = 7
        Me.LblServidor.Text = "Nombre del Servidor "
        '
        'DTPFehaDeHoy
        '
        Me.DTPFehaDeHoy.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DTPFehaDeHoy.Enabled = False
        Me.DTPFehaDeHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DTPFehaDeHoy.Location = New System.Drawing.Point(97, 13)
        Me.DTPFehaDeHoy.Name = "DTPFehaDeHoy"
        Me.DTPFehaDeHoy.Size = New System.Drawing.Size(337, 29)
        Me.DTPFehaDeHoy.TabIndex = 8
        '
        'LblFechaDeHoy
        '
        Me.LblFechaDeHoy.AutoSize = True
        Me.LblFechaDeHoy.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaDeHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline)
        Me.LblFechaDeHoy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblFechaDeHoy.Location = New System.Drawing.Point(12, 17)
        Me.LblFechaDeHoy.Name = "LblFechaDeHoy"
        Me.LblFechaDeHoy.Size = New System.Drawing.Size(69, 24)
        Me.LblFechaDeHoy.TabIndex = 9
        Me.LblFechaDeHoy.Text = "Fecha "
        '
        'DTPHoraDelSistema
        '
        Me.DTPHoraDelSistema.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DTPHoraDelSistema.Enabled = False
        Me.DTPHoraDelSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DTPHoraDelSistema.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPHoraDelSistema.Location = New System.Drawing.Point(545, 13)
        Me.DTPHoraDelSistema.Name = "DTPHoraDelSistema"
        Me.DTPHoraDelSistema.Size = New System.Drawing.Size(205, 29)
        Me.DTPHoraDelSistema.TabIndex = 10
        '
        'LblHoraDelSistema
        '
        Me.LblHoraDelSistema.AutoSize = True
        Me.LblHoraDelSistema.BackColor = System.Drawing.Color.Transparent
        Me.LblHoraDelSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline)
        Me.LblHoraDelSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblHoraDelSistema.Location = New System.Drawing.Point(460, 17)
        Me.LblHoraDelSistema.Name = "LblHoraDelSistema"
        Me.LblHoraDelSistema.Size = New System.Drawing.Size(56, 24)
        Me.LblHoraDelSistema.TabIndex = 11
        Me.LblHoraDelSistema.Text = "Hora "
        '
        'PgbBackUp
        '
        Me.PgbBackUp.Location = New System.Drawing.Point(16, 310)
        Me.PgbBackUp.Name = "PgbBackUp"
        Me.PgbBackUp.Size = New System.Drawing.Size(638, 25)
        Me.PgbBackUp.TabIndex = 12
        Me.PgbBackUp.Visible = False
        '
        'LblProcentaje
        '
        Me.LblProcentaje.AutoSize = True
        Me.LblProcentaje.BackColor = System.Drawing.Color.Transparent
        Me.LblProcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblProcentaje.ForeColor = System.Drawing.Color.Snow
        Me.LblProcentaje.Location = New System.Drawing.Point(774, 311)
        Me.LblProcentaje.Name = "LblProcentaje"
        Me.LblProcentaje.Size = New System.Drawing.Size(35, 24)
        Me.LblProcentaje.TabIndex = 13
        Me.LblProcentaje.Text = "0%"
        Me.LblProcentaje.Visible = False
        '
        'LblLoading
        '
        Me.LblLoading.AutoSize = True
        Me.LblLoading.BackColor = System.Drawing.Color.Transparent
        Me.LblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoading.ForeColor = System.Drawing.Color.Snow
        Me.LblLoading.Location = New System.Drawing.Point(660, 311)
        Me.LblLoading.Name = "LblLoading"
        Me.LblLoading.Size = New System.Drawing.Size(108, 24)
        Me.LblLoading.TabIndex = 14
        Me.LblLoading.Text = "Cargando..."
        Me.LblLoading.Visible = False
        '
        'Timer1
        '
        '
        'STRPBarraDeCarga
        '
        Me.STRPBarraDeCarga.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSPBBarra, Me.TSSLCargando, Me.TSSLPorcentaje})
        Me.STRPBarraDeCarga.Location = New System.Drawing.Point(0, 292)
        Me.STRPBarraDeCarga.Name = "STRPBarraDeCarga"
        Me.STRPBarraDeCarga.Size = New System.Drawing.Size(812, 22)
        Me.STRPBarraDeCarga.TabIndex = 15
        Me.STRPBarraDeCarga.Text = "StatusStrip1"
        '
        'TSPBBarra
        '
        Me.TSPBBarra.Name = "TSPBBarra"
        Me.TSPBBarra.Size = New System.Drawing.Size(100, 16)
        '
        'TSSLCargando
        '
        Me.TSSLCargando.Enabled = False
        Me.TSSLCargando.Name = "TSSLCargando"
        Me.TSSLCargando.Size = New System.Drawing.Size(68, 17)
        Me.TSSLCargando.Text = "Cargando..."
        '
        'TSSLPorcentaje
        '
        Me.TSSLPorcentaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TSSLPorcentaje.Name = "TSSLPorcentaje"
        Me.TSSLPorcentaje.Size = New System.Drawing.Size(23, 17)
        Me.TSSLPorcentaje.Text = "0%"
        '
        'BtnSalir
        '
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Location = New System.Drawing.Point(716, 258)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 31)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.STRPBarraDeCarga)
        Me.Controls.Add(Me.LblLoading)
        Me.Controls.Add(Me.LblProcentaje)
        Me.Controls.Add(Me.PgbBackUp)
        Me.Controls.Add(Me.LblHoraDelSistema)
        Me.Controls.Add(Me.DTPHoraDelSistema)
        Me.Controls.Add(Me.LblFechaDeHoy)
        Me.Controls.Add(Me.DTPFehaDeHoy)
        Me.Controls.Add(Me.LblServidor)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblBackUp)
        Me.Controls.Add(Me.TxtNombreBackup)
        Me.Controls.Add(Me.BtnCrearBackup)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnRuta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.ForeColor = System.Drawing.Color.GreenYellow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBackup"
        Me.Text = "Crear Back-Up"
        Me.STRPBarraDeCarga.ResumeLayout(False)
        Me.STRPBarraDeCarga.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFDElegirRuta As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnRuta As System.Windows.Forms.Button
    Friend WithEvents TxtRuta As System.Windows.Forms.TextBox
    Friend WithEvents LblRuta As System.Windows.Forms.Label
    Friend WithEvents BtnCrearBackup As System.Windows.Forms.Button
    Friend WithEvents TxtNombreBackup As System.Windows.Forms.TextBox
    Friend WithEvents LblBackUp As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LblServidor As System.Windows.Forms.Label
    Friend WithEvents DTPFehaDeHoy As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaDeHoy As System.Windows.Forms.Label
    Friend WithEvents DTPHoraDelSistema As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblHoraDelSistema As System.Windows.Forms.Label
    Friend WithEvents PgbBackUp As System.Windows.Forms.ProgressBar
    Friend WithEvents LblProcentaje As System.Windows.Forms.Label
    Friend WithEvents LblLoading As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents STRPBarraDeCarga As System.Windows.Forms.StatusStrip
    Friend WithEvents TSPBBarra As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TSSLCargando As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLPorcentaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class
