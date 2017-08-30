<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrosPorCategorias
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
        Me.CategoriasMasVendidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas1 = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RtptvwLibrosPorCategorias = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CategoriasMasVendidasTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.CategoriasMasVendidasTableAdapter()
        CType(Me.CategoriasMasVendidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoriasMasVendidasBindingSource
        '
        Me.CategoriasMasVendidasBindingSource.DataMember = "CategoriasMasVendidas"
        Me.CategoriasMasVendidasBindingSource.DataSource = Me.Consultas1
        '
        'Consultas1
        '
        Me.Consultas1.DataSetName = "Consultas"
        Me.Consultas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RtptvwLibrosPorCategorias
        '
        Me.RtptvwLibrosPorCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CategoriasMasVendidasBindingSource
        Me.RtptvwLibrosPorCategorias.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RtptvwLibrosPorCategorias.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.LibrosPorCategorias.rdlc"
        Me.RtptvwLibrosPorCategorias.Location = New System.Drawing.Point(0, 0)
        Me.RtptvwLibrosPorCategorias.Name = "RtptvwLibrosPorCategorias"
        Me.RtptvwLibrosPorCategorias.Size = New System.Drawing.Size(1125, 597)
        Me.RtptvwLibrosPorCategorias.TabIndex = 0
        '
        'CategoriasMasVendidasTableAdapter
        '
        Me.CategoriasMasVendidasTableAdapter.ClearBeforeFill = True
        '
        'LibrosPorCategorias
        '
        Me.ClientSize = New System.Drawing.Size(1125, 597)
        Me.Controls.Add(Me.RtptvwLibrosPorCategorias)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LibrosPorCategorias"
        CType(Me.CategoriasMasVendidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CantidadDeLibrosPorCategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents CantidadDeLibrosPorCategoriaTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.CantidadDeLibrosPorCategoriaTableAdapter
    Friend WithEvents RtptvwLibrosPorCategorias As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Consultas1 As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents CategoriasMasVendidasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasMasVendidasTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.CategoriasMasVendidasTableAdapter
End Class
