<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadoDelMes
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
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwEmpleadoDelMes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EmpleadosTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.EmpleadosTableAdapter()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwEmpleadoDelMes
        '
        Me.RptwEmpleadoDelMes.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EmpleadosBindingSource
        Me.RptwEmpleadoDelMes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwEmpleadoDelMes.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.EmpleadoDelMes.rdlc.rdlc"
        Me.RptwEmpleadoDelMes.Location = New System.Drawing.Point(0, 0)
        Me.RptwEmpleadoDelMes.Name = "RptwEmpleadoDelMes"
        Me.RptwEmpleadoDelMes.Size = New System.Drawing.Size(1075, 652)
        Me.RptwEmpleadoDelMes.TabIndex = 0
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoDelMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 652)
        Me.Controls.Add(Me.RptwEmpleadoDelMes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmpleadoDelMes"
        Me.Text = "EmpleadoDelMes"
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwEmpleadoDelMes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents EmpleadosTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.EmpleadosTableAdapter
End Class
