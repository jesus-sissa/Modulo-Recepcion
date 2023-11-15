Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_RechazarRemision
    Public Id_Compania As Byte

    Private Sub frm_RechazarRemision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Cia.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_Cia.Actualizar()

        cmb_Cia.SelectedValue = Id_Compania
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0
        Id_Compania = 0
        Me.Close()
    End Sub

    Sub LipiarObjetos()
        cmb_Cia.SelectedValue = 0
        tbx_NoRemision.Clear()
        tbx_totalEnvases.Clear()
        tbx_totalImporte.Clear()
        rtb_Observaciones.Clear()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0

        If cmb_Cia.SelectedValue = 0 Then
            MsgBox("Seleccione la Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Exit Sub
        End If
        If tbx_NoRemision.Text.Trim = "" Then
            MsgBox("Capture el Número Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NoRemision.Focus()
            Exit Sub
        End If

        If tbx_totalEnvases.Text.Trim = "" Or CInt(tbx_totalEnvases.Text) = 0 Then
            MsgBox("Capture el Total de envases Rechazados.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_totalEnvases.Focus()
            Exit Sub
        End If
        If tbx_totalImporte.Text.Trim = "" Or CDec(tbx_totalImporte.Text) = 0 Then
            MsgBox("Capture el Importe Total de las Remision Rechazada.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_totalImporte.Focus()
            Exit Sub
        End If
        If rtb_Observaciones.Text.Trim = "" Then
            MsgBox("Capture las Observaciones sobre el porque se Rechazó la Remisión", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Observaciones.Focus()
            Exit Sub
        End If
        Dim dt_Rechazo As DataTable = cn_Recepcion.fn_Consultar_RemisionesRechazadas(tbx_NoRemision.Text, cmb_Cia.SelectedValue)
        If dt_Rechazo IsNot Nothing Then
            If dt_Rechazo.Rows.Count > 0 Then
                MsgBox(" La Remisión " & dt_Rechazo(0)("Numero_Remision") & " ya se encuentra registrada en la base de datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_NoRemision.Focus()
                Exit Sub
            End If
        End If

        If (fn_Guarada_RemisionesRechazadas(cmb_Cia.SelectedValue, tbx_NoRemision.Text, tbx_totalEnvases.Text, tbx_totalImporte.Text, rtb_Observaciones.Text)) Then
            MsgBox("La Remisión Rechazada se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LipiarObjetos()
            cmb_Cia.Focus()
        Else
            MsgBox("Ocurrió un error al intentar guardar la Remisión Rechazada.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class