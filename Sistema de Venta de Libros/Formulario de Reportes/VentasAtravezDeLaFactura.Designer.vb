<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasAtravezDeLaFactura
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
        Me.NROFACTURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAYHORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNICLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMAPAGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BONIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDEDORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIEMPLEADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NominaDeFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.DtgVentas = New System.Windows.Forms.DataGridView()
        Me.NominaDeFacturasTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeFacturasTableAdapter()
        Me.BtnVerVentas = New System.Windows.Forms.Button()
        CType(Me.DtgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominaDeFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgFacturas
        '
        Me.DtgFacturas.AllowUserToAddRows = False
        Me.DtgFacturas.AllowUserToDeleteRows = False
        Me.DtgFacturas.AutoGenerateColumns = False
        Me.DtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROFACTURADataGridViewTextBoxColumn, Me.EMPRESADataGridViewTextBoxColumn, Me.FECHAYHORADataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn, Me.DNICLIENTEDataGridViewTextBoxColumn, Me.FORMAPAGODataGridViewTextBoxColumn, Me.BONIFICACIONDataGridViewTextBoxColumn, Me.VENDEDORDataGridViewTextBoxColumn, Me.DNIEMPLEADODataGridViewTextBoxColumn})
        Me.DtgFacturas.DataSource = Me.NominaDeFacturasBindingSource
        Me.DtgFacturas.Location = New System.Drawing.Point(1, 23)
        Me.DtgFacturas.Name = "DtgFacturas"
        Me.DtgFacturas.ReadOnly = True
        Me.DtgFacturas.Size = New System.Drawing.Size(1054, 253)
        Me.DtgFacturas.TabIndex = 0
        '
        'NROFACTURADataGridViewTextBoxColumn
        '
        Me.NROFACTURADataGridViewTextBoxColumn.DataPropertyName = "NROFACTURA"
        Me.NROFACTURADataGridViewTextBoxColumn.HeaderText = "NROFACTURA"
        Me.NROFACTURADataGridViewTextBoxColumn.Name = "NROFACTURADataGridViewTextBoxColumn"
        Me.NROFACTURADataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPRESADataGridViewTextBoxColumn
        '
        Me.EMPRESADataGridViewTextBoxColumn.DataPropertyName = "EMPRESA"
        Me.EMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA"
        Me.EMPRESADataGridViewTextBoxColumn.Name = "EMPRESADataGridViewTextBoxColumn"
        Me.EMPRESADataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHAYHORADataGridViewTextBoxColumn
        '
        Me.FECHAYHORADataGridViewTextBoxColumn.DataPropertyName = "FECHAYHORA"
        Me.FECHAYHORADataGridViewTextBoxColumn.HeaderText = "FECHAYHORA"
        Me.FECHAYHORADataGridViewTextBoxColumn.Name = "FECHAYHORADataGridViewTextBoxColumn"
        Me.FECHAYHORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNICLIENTEDataGridViewTextBoxColumn
        '
        Me.DNICLIENTEDataGridViewTextBoxColumn.DataPropertyName = "DNICLIENTE"
        Me.DNICLIENTEDataGridViewTextBoxColumn.HeaderText = "DNICLIENTE"
        Me.DNICLIENTEDataGridViewTextBoxColumn.Name = "DNICLIENTEDataGridViewTextBoxColumn"
        Me.DNICLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FORMAPAGODataGridViewTextBoxColumn
        '
        Me.FORMAPAGODataGridViewTextBoxColumn.DataPropertyName = "FORMAPAGO"
        Me.FORMAPAGODataGridViewTextBoxColumn.HeaderText = "FORMAPAGO"
        Me.FORMAPAGODataGridViewTextBoxColumn.Name = "FORMAPAGODataGridViewTextBoxColumn"
        Me.FORMAPAGODataGridViewTextBoxColumn.ReadOnly = True
        '
        'BONIFICACIONDataGridViewTextBoxColumn
        '
        Me.BONIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "BONIFICACION"
        Me.BONIFICACIONDataGridViewTextBoxColumn.HeaderText = "BONIFICACION"
        Me.BONIFICACIONDataGridViewTextBoxColumn.Name = "BONIFICACIONDataGridViewTextBoxColumn"
        Me.BONIFICACIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VENDEDORDataGridViewTextBoxColumn
        '
        Me.VENDEDORDataGridViewTextBoxColumn.DataPropertyName = "VENDEDOR"
        Me.VENDEDORDataGridViewTextBoxColumn.HeaderText = "VENDEDOR"
        Me.VENDEDORDataGridViewTextBoxColumn.Name = "VENDEDORDataGridViewTextBoxColumn"
        Me.VENDEDORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIEMPLEADODataGridViewTextBoxColumn
        '
        Me.DNIEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "DNIEMPLEADO"
        Me.DNIEMPLEADODataGridViewTextBoxColumn.HeaderText = "DNIEMPLEADO"
        Me.DNIEMPLEADODataGridViewTextBoxColumn.Name = "DNIEMPLEADODataGridViewTextBoxColumn"
        Me.DNIEMPLEADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NominaDeFacturasBindingSource
        '
        Me.NominaDeFacturasBindingSource.DataMember = "NominaDeFacturas"
        Me.NominaDeFacturasBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtgVentas
        '
        Me.DtgVentas.AllowUserToAddRows = False
        Me.DtgVentas.AllowUserToDeleteRows = False
        Me.DtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgVentas.Location = New System.Drawing.Point(1, 358)
        Me.DtgVentas.Name = "DtgVentas"
        Me.DtgVentas.ReadOnly = True
        Me.DtgVentas.Size = New System.Drawing.Size(1054, 188)
        Me.DtgVentas.TabIndex = 1
        '
        'NominaDeFacturasTableAdapter
        '
        Me.NominaDeFacturasTableAdapter.ClearBeforeFill = True
        '
        'BtnVerVentas
        '
        Me.BtnVerVentas.Location = New System.Drawing.Point(476, 295)
        Me.BtnVerVentas.Name = "BtnVerVentas"
        Me.BtnVerVentas.Size = New System.Drawing.Size(114, 48)
        Me.BtnVerVentas.TabIndex = 2
        Me.BtnVerVentas.Text = "Ver Ventas"
        Me.BtnVerVentas.UseVisualStyleBackColor = True
        '
        'VentasAtravezDeLaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 558)
        Me.Controls.Add(Me.BtnVerVentas)
        Me.Controls.Add(Me.DtgVentas)
        Me.Controls.Add(Me.DtgFacturas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentasAtravezDeLaFactura"
        Me.Text = "Ventas A travez De Factura"
        CType(Me.DtgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominaDeFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents DtgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents NominaDeFacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NominaDeFacturasTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeFacturasTableAdapter
    Friend WithEvents NROFACTURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPRESADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAYHORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNICLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORMAPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BONIFICACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENDEDORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIEMPLEADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnVerVentas As System.Windows.Forms.Button
End Class
