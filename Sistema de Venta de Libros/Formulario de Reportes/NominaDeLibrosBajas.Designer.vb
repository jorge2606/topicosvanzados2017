<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NominaDeLibrosBajas
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
        Me.NominaDeBajasLibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwNominaBajasDeLibros = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NominaDeBajasLibrosTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeBajasLibrosTableAdapter()
        CType(Me.NominaDeBajasLibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NominaDeBajasLibrosBindingSource
        '
        Me.NominaDeBajasLibrosBindingSource.DataMember = "NominaDeBajasLibros"
        Me.NominaDeBajasLibrosBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwNominaBajasDeLibros
        '
        Me.RptwNominaBajasDeLibros.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.NominaDeBajasLibrosBindingSource
        Me.RptwNominaBajasDeLibros.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwNominaBajasDeLibros.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.NominaDeLibrosBajas.rdlc"
        Me.RptwNominaBajasDeLibros.Location = New System.Drawing.Point(0, 0)
        Me.RptwNominaBajasDeLibros.Name = "RptwNominaBajasDeLibros"
        Me.RptwNominaBajasDeLibros.Size = New System.Drawing.Size(1273, 732)
        Me.RptwNominaBajasDeLibros.TabIndex = 0
        '
        'NominaDeBajasLibrosTableAdapter
        '
        Me.NominaDeBajasLibrosTableAdapter.ClearBeforeFill = True
        '
        'NominaDeLibrosBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 732)
        Me.Controls.Add(Me.RptwNominaBajasDeLibros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NominaDeLibrosBajas"
        Me.Text = "NominaDeLibrosBajas"
        CType(Me.NominaDeBajasLibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwNominaBajasDeLibros As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NominaDeBajasLibrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents NominaDeBajasLibrosTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.NominaDeBajasLibrosTableAdapter
End Class
