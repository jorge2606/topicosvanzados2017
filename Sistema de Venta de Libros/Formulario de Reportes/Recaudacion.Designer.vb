<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recaudacion
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RecaudacioActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RecaudacionMensualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecaudacionAnualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas1 = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwRecaudacioDeHoy = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnRecActual = New System.Windows.Forms.Button()
        Me.RecaudacioActualTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacioActualTableAdapter()
        Me.RptvwRecaudacioMenstrual = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnMensual = New System.Windows.Forms.Button()
        Me.RecaudacionMensualTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacionMensualTableAdapter()
        Me.BtnAnual = New System.Windows.Forms.Button()
        Me.RptwRecaudacionAnual = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RecaudacionAnualTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacionAnualTableAdapter()
        CType(Me.RecaudacioActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecaudacionMensualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecaudacionAnualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecaudacioActualBindingSource
        '
        Me.RecaudacioActualBindingSource.DataMember = "RecaudacioActual"
        Me.RecaudacioActualBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecaudacionMensualBindingSource
        '
        Me.RecaudacionMensualBindingSource.DataMember = "RecaudacionMensual"
        Me.RecaudacionMensualBindingSource.DataSource = Me.Consultas
        '
        'RecaudacionAnualBindingSource
        '
        Me.RecaudacionAnualBindingSource.DataMember = "RecaudacionAnual"
        Me.RecaudacionAnualBindingSource.DataSource = Me.Consultas1
        '
        'Consultas1
        '
        Me.Consultas1.DataSetName = "Consultas"
        Me.Consultas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwRecaudacioDeHoy
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RecaudacioActualBindingSource
        Me.RptwRecaudacioDeHoy.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwRecaudacioDeHoy.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.RecaudacionDeHoy.rdlc"
        Me.RptwRecaudacioDeHoy.Location = New System.Drawing.Point(8, 51)
        Me.RptwRecaudacioDeHoy.Name = "RptwRecaudacioDeHoy"
        Me.RptwRecaudacioDeHoy.Size = New System.Drawing.Size(803, 397)
        Me.RptwRecaudacioDeHoy.TabIndex = 0
        '
        'BtnRecActual
        '
        Me.BtnRecActual.Location = New System.Drawing.Point(290, 12)
        Me.BtnRecActual.Name = "BtnRecActual"
        Me.BtnRecActual.Size = New System.Drawing.Size(75, 23)
        Me.BtnRecActual.TabIndex = 1
        Me.BtnRecActual.Text = "Actual"
        Me.BtnRecActual.UseVisualStyleBackColor = True
        '
        'RecaudacioActualTableAdapter
        '
        Me.RecaudacioActualTableAdapter.ClearBeforeFill = True
        '
        'RptvwRecaudacioMenstrual
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.RecaudacionMensualBindingSource
        Me.RptvwRecaudacioMenstrual.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RptvwRecaudacioMenstrual.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.RecaudacionMensual.rdlc"
        Me.RptvwRecaudacioMenstrual.Location = New System.Drawing.Point(8, 51)
        Me.RptvwRecaudacioMenstrual.Name = "RptvwRecaudacioMenstrual"
        Me.RptvwRecaudacioMenstrual.Size = New System.Drawing.Size(803, 397)
        Me.RptvwRecaudacioMenstrual.TabIndex = 2
        '
        'BtnMensual
        '
        Me.BtnMensual.Location = New System.Drawing.Point(551, 12)
        Me.BtnMensual.Name = "BtnMensual"
        Me.BtnMensual.Size = New System.Drawing.Size(75, 23)
        Me.BtnMensual.TabIndex = 3
        Me.BtnMensual.Text = "Mensual"
        Me.BtnMensual.UseVisualStyleBackColor = True
        '
        'RecaudacionMensualTableAdapter
        '
        Me.RecaudacionMensualTableAdapter.ClearBeforeFill = True
        '
        'BtnAnual
        '
        Me.BtnAnual.Location = New System.Drawing.Point(771, 12)
        Me.BtnAnual.Name = "BtnAnual"
        Me.BtnAnual.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnual.TabIndex = 5
        Me.BtnAnual.Text = "Anual"
        Me.BtnAnual.UseVisualStyleBackColor = True
        '
        'RptwRecaudacionAnual
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.RecaudacionAnualBindingSource
        Me.RptwRecaudacionAnual.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RptwRecaudacionAnual.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.RecaudacionAnual.rdlc"
        Me.RptwRecaudacionAnual.Location = New System.Drawing.Point(-1, 51)
        Me.RptwRecaudacionAnual.Name = "RptwRecaudacionAnual"
        Me.RptwRecaudacionAnual.Size = New System.Drawing.Size(1166, 646)
        Me.RptwRecaudacionAnual.TabIndex = 6
        '
        'RecaudacionAnualTableAdapter
        '
        Me.RecaudacionAnualTableAdapter.ClearBeforeFill = True
        '
        'Recaudacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1166, 697)
        Me.Controls.Add(Me.RptwRecaudacionAnual)
        Me.Controls.Add(Me.BtnAnual)
        Me.Controls.Add(Me.BtnMensual)
        Me.Controls.Add(Me.RptvwRecaudacioMenstrual)
        Me.Controls.Add(Me.BtnRecActual)
        Me.Controls.Add(Me.RptwRecaudacioDeHoy)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Recaudacion"
        Me.Text = "Recaudacion"
        CType(Me.RecaudacioActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecaudacionMensualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecaudacionAnualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptwRecaudacioDeHoy As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RecaudacioActualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents RecaudacioActualTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacioActualTableAdapter
    Friend WithEvents BtnRecActual As System.Windows.Forms.Button
    Friend WithEvents RptvwRecaudacioMenstrual As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtnMensual As System.Windows.Forms.Button
    Friend WithEvents RecaudacionMensualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecaudacionMensualTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacionMensualTableAdapter
    Friend WithEvents BtnAnual As System.Windows.Forms.Button
    Friend WithEvents RptwRecaudacionAnual As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Consultas1 As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents RecaudacionAnualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecaudacionAnualTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.RecaudacionAnualTableAdapter
End Class
