Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmBackup
    Dim Imagen1 As Image
    Dim origen As String
    Dim extensionimagen As String
    Dim directorioProyecto As String
    Dim miConexion As SqlConnection = New SqlConnection(My.Settings.Venta_de_librosConnectionString)
    Private Sub CrearBackUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        directorioProyecto = My.Computer.FileSystem.CurrentDirectory
        '  Timer1.Start()
        PgbBackUp.Visible = False
        LblLoading.Visible = False
        LblProcentaje.Visible = False
        STRPBarraDeCarga.Visible = False
    End Sub

    Private Sub BtnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRuta.Click
        Dim OFDElegirRuta As New FolderBrowserDialog

        If OFDElegirRuta.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        origen = OFDElegirRuta.SelectedPath.ToString
        TxtRuta.Text = origen
        'Dim fecha As Date = Date.Now
        '  Dim fecha2 As String = Format(fecha, "dd-MM-y-H-mm-ss")
        ' MsgBox(fecha2)
    End Sub

    Private Sub BtnCrearBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearBackup.Click
        If Libreria.deseaCrearBackup() = 7 Then
            MsgBox("No se ha Generado la Copia de Seguridad", MsgBoxStyle.Information, "Información")
        ElseIf TxtRuta.TextLength = 0 Then
            MsgBox("No se ha ingresado una Ruta Valida", MsgBoxStyle.Exclamation, "Información")
        ElseIf TxtRuta.Text = "C:\" Then
            MsgBox("La Dirección 'C:\' esta restringida por el Sistema Operativo ", MsgBoxStyle.Exclamation, "Información")
        Else
            'If Libreria.deseaCrearBackup() = 6 Then
            BloquearControles()
            Dim fecha As Date = Date.Now
            Dim fecha2 As String = Format(fecha, "dd-MM-y-H-mm-ss")
            ' MsgBox(fecha2)
            Dim NombreBaseDeDatos As String = "Venta_de_libros"
            Dim Ruta As String = TxtRuta.Text + "\" + Me.TxtNombreBackup.Text + " " + fecha2 + ".bak"
            Try
                Dim cmdbackup As SqlCommand = New SqlCommand("BackUpCompleto2", miConexion)
                miConexion.Open()
                cmdbackup.CommandType = CommandType.StoredProcedure
                cmdbackup.Parameters.AddWithValue("@Ruta", Ruta)
                cmdbackup.Parameters.AddWithValue("@BD", NombreBaseDeDatos)
                cmdbackup.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                miConexion.Close()
                Exit Sub
            End Try
            miConexion.Close()
            Timer1.Start()
            ' PgbBackUp.Visible = True
            ' LblLoading.Visible = True
            'LblProcentaje.Visible = True
            STRPBarraDeCarga.Visible = True
        End If
        'DesBloquearControles()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TSPBBarra.Increment(2)
        If TSPBBarra.Value > 99 Then
            Timer1.Stop()
            TSSLPorcentaje.Text = 100
            MsgBox("La Copia de Seguridad se ha generado con Exito ", MsgBoxStyle.Information, " Exito")
            STRPBarraDeCarga.Visible = False
        End If
        TSSLPorcentaje.Text = TSPBBarra.Value
        DesBloquearControles()
    End Sub

    Private Sub BloquearControles()
        BtnCrearBackup.Enabled = False
        BtnRuta.Enabled = False
        BtnSalir.Enabled = False
    End Sub
    Private Sub DesBloquearControles()
        BtnCrearBackup.Enabled = True
        BtnRuta.Enabled = True
        BtnSalir.Enabled = True
    End Sub

    Private Sub TxtRuta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRuta.LostFocus
        If TxtRuta.TextLength = 0 Then
            TxtRuta.Text = "C:\Back-Up"
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Libreria.Salir() = 1 Then
            Me.Close()
        End If
    End Sub
End Class