Partial Class DataSet1
    Partial Class FacturasDataTable

        Private Sub FacturasDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.fechaYhoraColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

Namespace DataSet1TableAdapters
    
    Partial Class EmpleadosTableAdapter

    End Class

    Partial Class ComprasTableAdapter

    End Class

    Partial Class CategoriasTableAdapter

    End Class

    Partial Class LocalidadesTableAdapter

    End Class

    Partial Public Class ClientesTableAdapter
    End Class
End Namespace
