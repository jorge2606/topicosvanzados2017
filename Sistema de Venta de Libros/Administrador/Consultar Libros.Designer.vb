<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Libros))
        Me.TxtNumeroDeLibro = New System.Windows.Forms.TextBox()
        Me.DtgConsultarLibros = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter()
        Me.CboBusqPorTipo = New System.Windows.Forms.ComboBox()
        Me.TxtBsquedaPorNombre = New System.Windows.Forms.TextBox()
        Me.TxtBusquedaPorCategoria = New System.Windows.Forms.TextBox()
        CType(Me.DtgConsultarLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNumeroDeLibro
        '
        Me.TxtNumeroDeLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumeroDeLibro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroDeLibro.Location = New System.Drawing.Point(437, 426)
        Me.TxtNumeroDeLibro.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumeroDeLibro.MaxLength = 8
        Me.TxtNumeroDeLibro.Name = "TxtNumeroDeLibro"
        Me.TxtNumeroDeLibro.Size = New System.Drawing.Size(315, 25)
        Me.TxtNumeroDeLibro.TabIndex = 1
        '
        'DtgConsultarLibros
        '
        Me.DtgConsultarLibros.AllowUserToAddRows = False
        Me.DtgConsultarLibros.AllowUserToDeleteRows = False
        Me.DtgConsultarLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgConsultarLibros.Location = New System.Drawing.Point(2, 2)
        Me.DtgConsultarLibros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtgConsultarLibros.Name = "DtgConsultarLibros"
        Me.DtgConsultarLibros.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DtgConsultarLibros.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgConsultarLibros.Size = New System.Drawing.Size(1070, 403)
        Me.DtgConsultarLibros.TabIndex = 14
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(513, 465)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(121, 50)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'CboBusqPorTipo
        '
        Me.CboBusqPorTipo.BackColor = System.Drawing.SystemColors.Highlight
        Me.CboBusqPorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqPorTipo.FormattingEnabled = True
        Me.CboBusqPorTipo.Items.AddRange(New Object() {"Nro de Libro", "Nombre", "Categoria"})
        Me.CboBusqPorTipo.Location = New System.Drawing.Point(236, 430)
        Me.CboBusqPorTipo.Name = "CboBusqPorTipo"
        Me.CboBusqPorTipo.Size = New System.Drawing.Size(175, 21)
        Me.CboBusqPorTipo.TabIndex = 34
        '
        'TxtBsquedaPorNombre
        '
        Me.TxtBsquedaPorNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBsquedaPorNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBsquedaPorNombre.Location = New System.Drawing.Point(437, 426)
        Me.TxtBsquedaPorNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBsquedaPorNombre.MaxLength = 50
        Me.TxtBsquedaPorNombre.Name = "TxtBsquedaPorNombre"
        Me.TxtBsquedaPorNombre.Size = New System.Drawing.Size(315, 25)
        Me.TxtBsquedaPorNombre.TabIndex = 35
        '
        'TxtBusquedaPorCategoria
        '
        Me.TxtBusquedaPorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBusquedaPorCategoria.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBusquedaPorCategoria.Location = New System.Drawing.Point(437, 426)
        Me.TxtBusquedaPorCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBusquedaPorCategoria.MaxLength = 50
        Me.TxtBusquedaPorCategoria.Name = "TxtBusquedaPorCategoria"
        Me.TxtBusquedaPorCategoria.Size = New System.Drawing.Size(315, 25)
        Me.TxtBusquedaPorCategoria.TabIndex = 36
        '
        'Consultar_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBusquedaPorCategoria)
        Me.Controls.Add(Me.TxtBsquedaPorNombre)
        Me.Controls.Add(Me.CboBusqPorTipo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DtgConsultarLibros)
        Me.Controls.Add(Me.TxtNumeroDeLibro)
        Me.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Consultar_Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Libros"
        CType(Me.DtgConsultarLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroDeLibro As System.Windows.Forms.TextBox
    Friend WithEvents DtgConsultarLibros As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.LibrosTableAdapter
    Friend WithEvents CboBusqPorTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBsquedaPorNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusquedaPorCategoria As System.Windows.Forms.TextBox
End Class
