<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesPorEdad
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
        Me.ClientesPorEdadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RptwClientesPorEdad = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClientesPorEdadTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.ClientesPorEdadTableAdapter()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtEdadDelCliente = New System.Windows.Forms.TextBox()
        Me.LblEdad = New System.Windows.Forms.Label()
        CType(Me.ClientesPorEdadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesPorEdadBindingSource
        '
        Me.ClientesPorEdadBindingSource.DataMember = "ClientesPorEdad"
        Me.ClientesPorEdadBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptwClientesPorEdad
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClientesPorEdadBindingSource
        Me.RptwClientesPorEdad.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptwClientesPorEdad.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.ClientesPorEdad.rdlc"
        Me.RptwClientesPorEdad.Location = New System.Drawing.Point(0, 52)
        Me.RptwClientesPorEdad.Name = "RptwClientesPorEdad"
        Me.RptwClientesPorEdad.Size = New System.Drawing.Size(1073, 627)
        Me.RptwClientesPorEdad.TabIndex = 0
        '
        'ClientesPorEdadTableAdapter
        '
        Me.ClientesPorEdadTableAdapter.ClearBeforeFill = True
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(617, 23)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarCliente.TabIndex = 1
        Me.BtnBuscarCliente.Text = "Buscar"
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'TxtEdadDelCliente
        '
        Me.TxtEdadDelCliente.Location = New System.Drawing.Point(425, 23)
        Me.TxtEdadDelCliente.MaxLength = 3
        Me.TxtEdadDelCliente.Name = "TxtEdadDelCliente"
        Me.TxtEdadDelCliente.Size = New System.Drawing.Size(186, 20)
        Me.TxtEdadDelCliente.TabIndex = 2
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.BackColor = System.Drawing.Color.Transparent
        Me.LblEdad.Location = New System.Drawing.Point(385, 26)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(38, 13)
        Me.LblEdad.TabIndex = 3
        Me.LblEdad.Text = "Edad :"
        '
        'ClientesPorEdad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 680)
        Me.Controls.Add(Me.LblEdad)
        Me.Controls.Add(Me.TxtEdadDelCliente)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.RptwClientesPorEdad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClientesPorEdad"
        Me.Text = "ClientesPorEdad"
        CType(Me.ClientesPorEdadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RptwClientesPorEdad As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesPorEdadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents ClientesPorEdadTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.ClientesPorEdadTableAdapter
    Friend WithEvents BtnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents TxtEdadDelCliente As System.Windows.Forms.TextBox
    Friend WithEvents LblEdad As System.Windows.Forms.Label
End Class
