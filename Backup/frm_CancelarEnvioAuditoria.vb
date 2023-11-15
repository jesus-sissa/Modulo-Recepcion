Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_CancelarEnvioAuditoria

    Private Sub frm_CancelarEnvioAuditoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Envios.Columns.Add("Fecha")
        lsv_Envios.Columns.Add("Envia")
        lsv_Envios.Columns.Add("Hora")
        lsv_Envios.Columns.Add("Remisiones")
        lsv_Envios.Columns.Add("Envases")
        lsv_Envios.Columns.Add("Status")

        lsv_Detalles.Columns.Add("Remision")
        lsv_Detalles.Columns.Add("Caja Bancaria")
        lsv_Detalles.Columns.Add("Cajero")
        lsv_Detalles.Columns.Add("Importe")
        lsv_Detalles.Columns.Add("Envases")
        lsv_Detalles.Columns.Add("EnvasesSN")

        Call Actualizar()
    End Sub

    Public Sub Actualizar()
        btn_Cancelar.Enabled = False
        lbl_Registros.Text = "Registros: 0"
        lsv_Envios.Items.Clear()
        lsv_Detalles.Items.Clear()

        If Not fn_CancelarEnvioAuditoria_LlenarLista(lsv_Envios) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_Registros.Text = "Registros: " & lsv_Envios.Items.Count
    End Sub

    Private Sub lsv_Envios_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Envios.ItemChecked
        SegundosDesconexion = 0

        btn_Cancelar.Enabled = lsv_Envios.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Envios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envios.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Envios.SelectedItems.Count > 0 Then
            If Not fn_CancelarEnvioAuditoria_LlenarDetalles(lsv_Detalles, lsv_Envios.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista Detalles", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        If lsv_Envios.CheckedItems.Count = 0 Then
            MsgBox("Debe seleccionar al menos un Lote", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        Dim Id_Lotes() As Integer = (From lsv As ListViewItem In lsv_Envios.Items Where lsv.Checked Select CInt(lsv.Tag)).ToArray

        fn_CancelarEnvioAuditoria_Cancelar(Id_Lotes)
        Call Actualizar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class