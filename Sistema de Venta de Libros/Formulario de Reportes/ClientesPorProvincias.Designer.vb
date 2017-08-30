<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesPorProvincias
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
        Me.ClientesPorProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultas = New Sitema_de_Venta_de_Libros.Consultas()
        Me.RtvwClientesPorProvincias = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClientesPorProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.ConsultasTableAdapters.ClientesPorProvinciasTableAdapter()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CBOProvincias = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sitema_de_Venta_de_Libros.DataSet1()
        Me.ProvinciasTableAdapter = New Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter()
        Me.LblProvincias = New System.Windows.Forms.Label()
        CType(Me.ClientesPorProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesPorProvinciasBindingSource
        '
        Me.ClientesPorProvinciasBindingSource.DataMember = "ClientesPorProvincias"
        Me.ClientesPorProvinciasBindingSource.DataSource = Me.Consultas
        '
        'Consultas
        '
        Me.Consultas.DataSetName = "Consultas"
        Me.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RtvwClientesPorProvincias
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClientesPorProvinciasBindingSource
        Me.RtvwClientesPorProvincias.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RtvwClientesPorProvincias.LocalReport.ReportEmbeddedResource = "Sitema_de_Venta_de_Libros.ClientesPorProvincias.rdlc"
        Me.RtvwClientesPorProvincias.Location = New System.Drawing.Point(2, 59)
        Me.RtvwClientesPorProvincias.Name = "RtvwClientesPorProvincias"
        Me.RtvwClientesPorProvincias.Size = New System.Drawing.Size(1068, 616)
        Me.RtvwClientesPorProvincias.TabIndex = 0
        '
        'ClientesPorProvinciasTableAdapter
        '
        Me.ClientesPorProvinciasTableAdapter.ClearBeforeFill = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(617, 19)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CBOProvincias
        '
        Me.CBOProvincias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CBOProvincias.DataSource = Me.ProvinciasBindingSource
        Me.CBOProvincias.DisplayMember = "descripcion"
        Me.CBOProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOProvincias.FormattingEnabled = True
        Me.CBOProvincias.Location = New System.Drawing.Point(405, 21)
        Me.CBOProvincias.Name = "CBOProvincias"
        Me.CBOProvincias.Size = New System.Drawing.Size(206, 21)
        Me.CBOProvincias.TabIndex = 2
        Me.CBOProvincias.ValueMember = "cod_Provincia"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvinciasTableAdapter
        '
        Me.ProvinciasTableAdapter.ClearBeforeFill = True
        '
        'LblProvincias
        '
        Me.LblProvincias.AutoSize = True
        Me.LblProvincias.Location = New System.Drawing.Point(334, 24)
        Me.LblProvincias.Name = "LblProvincias"
        Me.LblProvincias.Size = New System.Drawing.Size(65, 13)
        Me.LblProvincias.TabIndex = 3
        Me.LblProvincias.Text = "Provincias : "
        '
        'ClientesPorProvincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1071, 677)
        Me.Controls.Add(Me.LblProvincias)
        Me.Controls.Add(Me.CBOProvincias)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.RtvwClientesPorProvincias)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClientesPorProvincias"
        Me.Text = "Clientes Por Provincias"
        CType(Me.ClientesPorProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RtvwClientesPorProvincias As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesPorProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consultas As Sitema_de_Venta_de_Libros.Consultas
    Friend WithEvents ClientesPorProvinciasTableAdapter As Sitema_de_Venta_de_Libros.ConsultasTableAdapters.ClientesPorProvinciasTableAdapter
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CBOProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As Sitema_de_Venta_de_Libros.DataSet1
    Friend WithEvents ProvinciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciasTableAdapter As Sitema_de_Venta_de_Libros.DataSet1TableAdapters.ProvinciasTableAdapter
    Friend WithEvents LblProvincias As System.Windows.Forms.Label
End Class
