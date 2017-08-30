<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NominaDeLibrosEnStock
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
        Me.NominaDeLibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwLibrosEnStock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NominaDeLibrosTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeLibrosTableAdapter()
        CType(Me.NominaDeLibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NominaDeLibrosBindingSource
        '
        Me.NominaDeLibrosBindingSource.DataMember = "NominaDeLibros"
        Me.NominaDeLibrosBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwLibrosEnStock
        '
        Me.RptwLibrosEnStock.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NominaDeLibrosBindingSource
        Me.RptwLibrosEnStock.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwLibrosEnStock.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.NominaDeLibros.rdlc"
        Me.RptwLibrosEnStock.Location = New System.Drawing.Point(0, 0)
        Me.RptwLibrosEnStock.Name = "RptwLibrosEnStock"
        Me.RptwLibrosEnStock.Size = New System.Drawing.Size(1135, 682)
        Me.RptwLibrosEnStock.TabIndex = 0
        '
        'NominaDeLibrosTableAdapter
        '
        Me.NominaDeLibrosTableAdapter.ClearBeforeFill = True
        '
        'NominaDeLibrosEnStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 682)
        Me.Controls.Add(Me.RptwLibrosEnStock)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NominaDeLibrosEnStock"
        Me.Text = "NominaDeLibrosEnStock"
        CType(Me.NominaDeLibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwLibrosEnStock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NominaDeLibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents NominaDeLibrosTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeLibrosTableAdapter
End Class
