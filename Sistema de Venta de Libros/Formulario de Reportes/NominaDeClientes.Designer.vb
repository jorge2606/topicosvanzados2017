<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NominaDeClientes
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
        Me.NominaDeClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwNominaDeClientes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NominaDeClientesTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeClientesTableAdapter()
        CType(Me.NominaDeClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NominaDeClientesBindingSource
        '
        Me.NominaDeClientesBindingSource.DataMember = "NominaDeClientes"
        Me.NominaDeClientesBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwNominaDeClientes
        '
        Me.RptwNominaDeClientes.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NominaDeClientesBindingSource
        Me.RptwNominaDeClientes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwNominaDeClientes.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.NominsDeClientes.rdlc"
        Me.RptwNominaDeClientes.Location = New System.Drawing.Point(0, 0)
        Me.RptwNominaDeClientes.Name = "RptwNominaDeClientes"
        Me.RptwNominaDeClientes.Size = New System.Drawing.Size(1157, 675)
        Me.RptwNominaDeClientes.TabIndex = 0
        '
        'NominaDeClientesTableAdapter
        '
        Me.NominaDeClientesTableAdapter.ClearBeforeFill = True
        '
        'NominaDeClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 675)
        Me.Controls.Add(Me.RptwNominaDeClientes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NominaDeClientes"
        Me.Text = "NominaDeClientes"
        CType(Me.NominaDeClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwNominaDeClientes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NominaDeClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents NominaDeClientesTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeClientesTableAdapter
End Class
