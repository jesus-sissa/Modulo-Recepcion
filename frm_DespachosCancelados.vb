Imports Modulo_Recepcion.cn_Recepcion
Public Class frm_DespachosCancelados
    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas es incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If


        If Not fn_CancelarDespacho_LlenarLista(lsv_Despachos, 1, "C", dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Validar_Departamento) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_RegistrosD.Text = "Registros: " & lsv_Despachos.Items.Count
        btn_Exportar.Enabled = lsv_Despachos.Items.Count > 0
    End Sub
    Function Validar_Departamento() As String
        If (Cmb_Depto.SelectedIndex = 0) Then
            Return "P"
        ElseIf (Cmb_Depto.SelectedIndex = 1) Then
            Return "M"
        Else
            Return "T"
        End If
    End Function
    Private Sub lsv_Despachos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Despachos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Detalle.Items.Clear()
        If lsv_Despachos.SelectedItems.Count > 0 Then
            If Not fn_CancelarDespacho_LlenarDetalles(lsv_Detalle, lsv_Despachos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista de Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Lbl_RegistrosR.Text = "Registros: " & lsv_Detalle.Items.Count

    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        fn_ConsultaDespachos_Excel2(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Validar_Departamento)
    End Sub
End Class