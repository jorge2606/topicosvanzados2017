<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Me.DtgFacturas = New System.Windows.Forms.DataGridView()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.FacturasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.FacturasTableAdapter()
        Me.BtnVerFactura = New System.Windows.Forms.Button()
        CType(Me.DtgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgFacturas
        '
        Me.DtgFacturas.AllowUserToAddRows = False
        Me.DtgFacturas.AllowUserToDeleteRows = False
        Me.DtgFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgFacturas.Location = New System.Drawing.Point(0, 0)
        Me.DtgFacturas.Name = "DtgFacturas"
        Me.DtgFacturas.ReadOnly = True
        Me.DtgFacturas.Size = New System.Drawing.Size(782, 260)
        Me.DtgFacturas.TabIndex = 0
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'BtnVerFactura
        '
        Me.BtnVerFactura.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnVerFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BtnVerFactura.Location = New System.Drawing.Point(340, 286)
        Me.BtnVerFactura.Name = "BtnVerFactura"
        Me.BtnVerFactura.Size = New System.Drawing.Size(107, 34)
        Me.BtnVerFactura.TabIndex = 1
        Me.BtnVerFactura.Text = "Ver Factura"
        Me.BtnVerFactura.UseVisualStyleBackColor = False
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 332)
        Me.Controls.Add(Me.BtnVerFactura)
        Me.Controls.Add(Me.DtgFacturas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.DtgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents FacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.FacturasTableAdapter
    Friend WithEvents BtnVerFactura As System.Windows.Forms.Button
End Class
