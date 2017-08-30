<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasPorFecha
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
        Me.VentasPorFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwVentasPorfecha = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DTPFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.VentasPorFechaTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.VentasPorFechaTableAdapter()
        CType(Me.VentasPorFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasPorFechaBindingSource
        '
        Me.VentasPorFechaBindingSource.DataMember = "VentasPorFecha"
        Me.VentasPorFechaBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwVentasPorfecha
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VentasPorFechaBindingSource
        Me.RptwVentasPorfecha.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwVentasPorfecha.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.VentasPorFecha.rdlc"
        Me.RptwVentasPorfecha.Location = New System.Drawing.Point(6, 51)
        Me.RptwVentasPorfecha.Name = "RptwVentasPorfecha"
        Me.RptwVentasPorfecha.Size = New System.Drawing.Size(1215, 683)
        Me.RptwVentasPorfecha.TabIndex = 0
        '
        'DTPFechaDesde
        '
        Me.DTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDesde.Location = New System.Drawing.Point(349, 25)
        Me.DTPFechaDesde.Name = "DTPFechaDesde"
        Me.DTPFechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaDesde.TabIndex = 1
        '
        'DTPFechaHasta
        '
        Me.DTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaHasta.Location = New System.Drawing.Point(656, 25)
        Me.DTPFechaHasta.Name = "DTPFechaHasta"
        Me.DTPFechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaHasta.TabIndex = 2
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(881, 22)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'VentasPorFechaTableAdapter
        '
        Me.VentasPorFechaTableAdapter.ClearBeforeFill = True
        '
        'VentasPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 730)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DTPFechaHasta)
        Me.Controls.Add(Me.DTPFechaDesde)
        Me.Controls.Add(Me.RptwVentasPorfecha)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VentasPorFecha"
        Me.Text = "VentasPorFecha"
        CType(Me.VentasPorFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwVentasPorfecha As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DTPFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents VentasPorFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents VentasPorFechaTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.VentasPorFechaTableAdapter
End Class
