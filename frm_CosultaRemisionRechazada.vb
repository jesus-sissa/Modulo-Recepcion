Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_CosultaRemisionRechazada

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_CosultaRemisionRechazada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Cia.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_Cia.Actualizar()

        With lsv_RemisionesRechazadas.Columns
            .Add("Compañia")
            .Add("Remision")
            .Add("Cantidad Envases")
            .Add("Importe")
            .Add("Observaciones")
            .Add("Fecha Registro")
            .Add("Usuario Registro")
            .Add("Estacion Registro")
            .Add("Usuario Autoriza")
        End With
    End Sub

    Private Sub Ckb_Bovedas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_Cia.CheckedChanged
        SegundosDesconexion = 0

        If Ckb_Cia.Checked = True Then
            cmb_Cia.Enabled = False
        Else
            cmb_Cia.Enabled = True
            btn_Exportar.Enabled = False
            If lsv_RemisionesRechazadas.Items.Count > 0 Then lsv_RemisionesRechazadas.Items.Clear()
        End If
        Lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SegundosDesconexion = 0
        dtp_Hasta.Focus()
        Dim cia As Integer

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La fecha inicial Desde Debe Ser menor que la Fecha Hasta", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Cia.SelectedValue = 0 AndAlso Ckb_Cia.Checked = False Then
            MsgBox("Seleccione una Unidad o Marque el check <<Todos>>", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Exit Sub
        End If

        If Ckb_Cia.Checked Then
            cia = 0
        Else
            cia = cmb_Cia.SelectedValue
        End If
        If Not fn_ConsultaRemisionesRechazadas(lsv_RemisionesRechazadas, cia, dtp_Desde.Value.Date, dtp_Hasta.Value.Date) Then
            MsgBox("Ocurrió un error al intentar Cargar los Datos de la Consulta", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_RemisionesRechazadas.Items.Count > 0 Then btn_Exportar.Enabled = True

        For h As Byte = 0 To lsv_RemisionesRechazadas.Columns.Count - 1
            lsv_RemisionesRechazadas.Columns(h).Width = -2
        Next
        Lbl_Registros.Text = "Registros: " & lsv_RemisionesRechazadas.Items.Count
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_RemisionesRechazadas, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class