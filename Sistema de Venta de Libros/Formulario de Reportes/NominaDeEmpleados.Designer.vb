<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NominaDeEmpleados
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
        Me.NominaDeEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwNominaDeEmpleados = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NominaDeEmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeEmpleadosTableAdapter()
        CType(Me.NominaDeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NominaDeEmpleadosBindingSource
        '
        Me.NominaDeEmpleadosBindingSource.DataMember = "NominaDeEmpleados"
        Me.NominaDeEmpleadosBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwNominaDeEmpleados
        '
        Me.RptwNominaDeEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NominaDeEmpleadosBindingSource
        Me.RptwNominaDeEmpleados.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwNominaDeEmpleados.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.NominaDeEmpleados.rdlc"
        Me.RptwNominaDeEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.RptwNominaDeEmpleados.Name = "RptwNominaDeEmpleados"
        Me.RptwNominaDeEmpleados.Size = New System.Drawing.Size(1179, 632)
        Me.RptwNominaDeEmpleados.TabIndex = 0
        '
        'NominaDeEmpleadosTableAdapter
        '
        Me.NominaDeEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'NominaDeEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 632)
        Me.Controls.Add(Me.RptwNominaDeEmpleados)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NominaDeEmpleados"
        Me.Text = "NominaDeEmpleados"
        CType(Me.NominaDeEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwNominaDeEmpleados As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NominaDeEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents NominaDeEmpleadosTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeEmpleadosTableAdapter
End Class
