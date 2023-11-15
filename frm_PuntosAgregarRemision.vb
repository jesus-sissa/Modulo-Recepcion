Public Class frm_PuntosAgregarRemision
    Public Id_Programacion As Integer = 0

    Private Sub frm_PuntosAgregarRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenaPuntosRemisiones()
    End Sub

    Sub LlenaPuntosRemisiones()
        lsv_Puntos.Items.Clear()
        Lbl_RegistrosPuntos.Text = "Registros: 0"
        If Id_Programacion > 0 Then
            cn_Recepcion.fn_RecRutasPropiasLlenalistaPuntos(lsv_Puntos, Id_Programacion)
            Lbl_RegistrosPuntos.Text = "Registros: " & lsv_Puntos.Items.Count
        End If
    End Sub

    Private Sub lsv_Puntos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puntos.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_CapturaRemision.Enabled = False
        If lsv_Puntos.SelectedItems.Count = 0 Then Exit Sub
        If lsv_Puntos.SelectedItems.Count > 0 Then
            If lsv_Puntos.SelectedItems(0).SubItems(5).Text.Trim = "RU" Then
                btn_CapturaRemision.Enabled = True
            End If
        End If

    End Sub

    Private Sub btn_CapturaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CapturaRemision.Click
        Call Validar()
    End Sub

    Private Sub lsv_Puntos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puntos.DoubleClick
        If lsv_Puntos.SelectedItems.Count > 0 Then
            If btn_CapturaRemision.Enabled Then Call Validar()
        End If
    End Sub

    Sub Validar()
        SegundosDesconexion = 0
        Dim frm_Remision As New frm_Dialogo

        If lsv_Puntos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un punto.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            frm_Remision.Id_Punto = lsv_Puntos.SelectedItems(0).Tag
            frm_Remision.Nuevo = True
            frm_Remision.lbl_OrigenNombre.Text = lsv_Puntos.SelectedItems(0).Text
            frm_Remision.lbl_DestinoNombre.Text = lsv_Puntos.SelectedItems(0).SubItems(1).Text
            frm_Remision.ShowDialog()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_PuntosAgregarRemision_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        SegundosDesconexion = 0
        Select Case e.KeyCode
            Case Keys.F3
                If btn_CapturaRemision.Enabled Then Call Validar()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

End Class