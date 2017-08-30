<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _5LibrosMasVendidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_5LibrosMasVendidos))
        Me.RptwCincoLibrosMasVendidos = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.LibrosTableAdapter()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptwCincoLibrosMasVendidos
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LibrosBindingSource
        Me.RptwCincoLibrosMasVendidos.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwCincoLibrosMasVendidos.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.Cinco.rdlc"
        Me.RptwCincoLibrosMasVendidos.Location = New System.Drawing.Point(0, 0)
        Me.RptwCincoLibrosMasVendidos.Name = "RptwCincoLibrosMasVendidos"
        Me.RptwCincoLibrosMasVendidos.Size = New System.Drawing.Size(1065, 537)
        Me.RptwCincoLibrosMasVendidos.TabIndex = 0
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Gray
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(505, 554)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(82, 39)
        Me.BtnActualizar.TabIndex = 1
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.Consultas
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        '_5LibrosMasVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1066, 594)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.RptwCincoLibrosMasVendidos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_5LibrosMasVendidos"
        Me.Text = "Libros Mas Vendidos"
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwCincoLibrosMasVendidos As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents LibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents LibrosTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.LibrosTableAdapter
End Class
