Public Class frm_StatusRutas

    Private Sub frm_StatusRutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Rutas.Columns.Add("Clave")
        lsv_Rutas.Columns.Add("Descripcion")
        lsv_Rutas.Columns.Add("Turno")
        lsv_Rutas.Columns.Add("PuntosFaltantes")
        Call LLenarListaRutasPendientes()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0
        Call LLenarListaRutasPendientes()
    End Sub

    Private Sub LLenarListaRutasPendientes()
        lbl_TotalRutas.Text = "Total Rutas: 0"
        lbl_Dentro.Text = "Recibidos: 0"
        lbl_Fuera.Text = "Pendientes: 0"
        lsv_Rutas.Items.Clear()
        Dim RutasRecibidas As Integer = cn_Recepcion.fn_RecRutasPropias_LlenarListaRutasPendientes(lsv_Rutas, dtp_Fecha.Value.Date)
        If RutasRecibidas = -1 Then
            MsgBox("Ocurrió un error al consultar las rutas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_TotalRutas.Text = "Total Rutas: " & lsv_Rutas.Items.Count
        lbl_Dentro.Text = "Recibidos: " & RutasRecibidas
        lbl_Fuera.Text = "Pendientes: " & (CInt(lsv_Rutas.Items.Count) - RutasRecibidas)
    End Sub

    Private Sub frm_StatusRutas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        SegundosDesconexion = 0
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class