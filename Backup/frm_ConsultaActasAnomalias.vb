Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_ConsultaActasAnomalias

    Private Sub frm_ConsultaActasAnomalias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("Hora")
        lsv_Listado.Columns.Add("Remision", 10, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Esclusa", 10, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Cliente")
        lsv_Listado.Columns.Add("Motivo")

        btn_Reimprimir.Enabled = False
    End Sub

    Private Sub btn_Reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reimprimir.Click, lsv_Listado.DoubleClick
        SegundosDesconexion = 0

        fn_AnomaliasEnvases_MostrarActa(lsv_Listado.SelectedItems(0).Tag, lsv_Listado.SelectedItems(0).SubItems(8).Text, lsv_Listado.SelectedItems(0).SubItems(9).Text)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If rdb_PorFecha.Checked Then
            If dtp_FechaInicio.Value.ToShortDateString > dtp_FechaFin.Value.ToShortDateString Then
                MsgBox("La Fecha Fin debe ser mayor a la Fecha Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_FechaFin.Focus()
                Exit Sub
            End If
        Else
            If tbx_Remision.Text = "" Or tbx_Remision.Text = "0" Then
                MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Remision.Focus()
                Exit Sub
            End If
        End If

        fn_ConsultaActasAnomalias_LlenarLista(dtp_FechaInicio.Value, dtp_FechaFin.Value, lsv_Listado, tbx_Remision.Text)
        lbl_Registros.Text = "Registros: " & lsv_Listado.Items.Count
    End Sub

    Private Sub dtp_FechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaInicio.ValueChanged
        SegundosDesconexion = 0

        LimpiarLista()
    End Sub

    Private Sub dtp_FechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaFin.ValueChanged
        SegundosDesconexion = 0

        LimpiarLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Listado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Listado.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Reimprimir.Enabled = lsv_Listado.SelectedItems.Count > 0
    End Sub

    Private Sub rdb_PorFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PorFecha.CheckedChanged
        SegundosDesconexion = 0

        dtp_FechaInicio.Value = Today.ToShortDateString
        dtp_FechaFin.Value = Today.ToShortDateString
        dtp_FechaInicio.Enabled = True
        dtp_FechaFin.Enabled = True
        tbx_Remision.Text = 0
        tbx_Remision.Enabled = False

        LimpiarLista()

    End Sub

    Private Sub rdb_PorRemision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PorRemision.CheckedChanged
        SegundosDesconexion = 0

        dtp_FechaInicio.Value = Today.ToShortDateString
        dtp_FechaFin.Value = Today.ToShortDateString
        dtp_FechaInicio.Enabled = False
        dtp_FechaFin.Enabled = False
        tbx_Remision.Enabled = True

        LimpiarLista()
    End Sub

    Sub LimpiarLista()
        SegundosDesconexion = 0

        lsv_Listado.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        btn_Reimprimir.Enabled = False
    End Sub
End Class