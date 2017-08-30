<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaPorFecha
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DTPFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.RptwFacturaPorFecha = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable3TableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.DataTable3TableAdapter()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.LblDesde = New System.Windows.Forms.Label()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable3BindingSource
        '
        Me.DataTable3BindingSource.DataMember = "DataTable3"
        Me.DataTable3BindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(800, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DTPFechaDesde
        '
        Me.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDesde.Location = New System.Drawing.Point(278, 15)
        Me.DTPFechaDesde.Name = "DTPFechaDesde"
        Me.DTPFechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaDesde.TabIndex = 1
        '
        'DTPFechaHasta
        '
        Me.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaHasta.Location = New System.Drawing.Point(541, 14)
        Me.DTPFechaHasta.Name = "DTPFechaHasta"
        Me.DTPFechaHasta.Size = New System.Drawing.Size(236, 20)
        Me.DTPFechaHasta.TabIndex = 2
        '
        'RptwFacturaPorFecha
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable3BindingSource
        Me.RptwFacturaPorFecha.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwFacturaPorFecha.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.FacturaPorFecha.rdlc"
        Me.RptwFacturaPorFecha.Location = New System.Drawing.Point(3, 41)
        Me.RptwFacturaPorFecha.Name = "RptwFacturaPorFecha"
        Me.RptwFacturaPorFecha.Size = New System.Drawing.Size(1112, 698)
        Me.RptwFacturaPorFecha.TabIndex = 3
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(491, 17)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(44, 13)
        Me.LblHasta.TabIndex = 4
        Me.LblHasta.Text = "Hasta : "
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(225, 17)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(47, 13)
        Me.LblDesde.TabIndex = 5
        Me.LblDesde.Text = "Desde : "
        '
        'FacturaPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 733)
        Me.Controls.Add(Me.LblDesde)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.RptwFacturaPorFecha)
        Me.Controls.Add(Me.DTPFechaHasta)
        Me.Controls.Add(Me.DTPFechaDesde)
        Me.Controls.Add(Me.BtnBuscar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacturaPorFecha"
        Me.Text = "FacturaPorFecha"
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents DTPFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents RptwFacturaPorFecha As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents DataTable3TableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.DataTable3TableAdapter
    Friend WithEvents LblHasta As System.Windows.Forms.Label
    Friend WithEvents LblDesde As System.Windows.Forms.Label
End Class
