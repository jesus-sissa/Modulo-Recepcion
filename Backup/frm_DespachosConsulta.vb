Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_DespachosConsulta

    Private Sub frm_DespachosConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = DateTime.Now
        dtp_Hasta.Value = DateTime.Now
        lsv_Despachos.Columns.Add("Fecha")
        lsv_Despachos.Columns.Add("Hora")
        lsv_Despachos.Columns.Add("Compañía")
        lsv_Despachos.Columns.Add("Ruta")
        lsv_Despachos.Columns.Add("Empleado")
        lsv_Despachos.Columns.Add("Remisiones")
        lsv_Despachos.Columns.Add("Envases")
        lsv_Despachos.Columns.Add("Status")

        lsv_Detalle.Columns.Add("Remision")
        lsv_Detalle.Columns.Add("Destino")
        lsv_Detalle.Columns.Add("Envases")
        lsv_Detalle.Columns.Add("EnvasesSN")

        cmb_Cias.Actualizar()
        cmb_Ruta.Actualizar()
        cmb_Usuario.Actualizar()
        cmb_Status.AgregarItem("A", "DESPACHADO")
        cmb_Status.AgregarItem("C", "CANCELADO")
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_Hasta.Focus()
        End If
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cmb_Cias.Focus()
        End If
    End Sub

    Private Sub dtp_Hasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
    End Sub

    Private Sub cmb_Cias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cias.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Ruta.Enabled = (cmb_Cias.SelectedValue = CiaId Or cmb_Cias.SelectedValue = 0)
        chk_Ruta.Enabled = (cmb_Cias.SelectedValue = CiaId Or cmb_Cias.SelectedValue = 0)
        cmb_Ruta.SelectedValue = 0
    End Sub

    Private Sub chk_Cia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cia.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Cias.Enabled = Not chk_Cia.Checked
        chk_Ruta.Checked = chk_Cia.Checked
        cmb_Ruta.Enabled = Not chk_Cia.Checked
        chk_Ruta.Enabled = Not chk_Cia.Checked
        cmb_Cias.SelectedValue = 0
    End Sub

    Private Sub cmb_Ruta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ruta.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
    End Sub

    Private Sub chk_Ruta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Ruta.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Ruta.Enabled = Not chk_Ruta.Checked
        cmb_Ruta.SelectedValue = 0
    End Sub

    Private Sub cmb_Usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Usuario.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
    End Sub

    Private Sub chk_Usuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Usuario.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Usuario.Enabled = Not chk_Usuario.Checked
        cmb_Usuario.SelectedValue = 0
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarListas()
        cmb_Status.Enabled = Not chk_Status.Checked
        cmb_Status.SelectedValue = 0
    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SegundosDesconexion = 0

        If cmb_Cias.Enabled And cmb_Cias.SelectedValue = 0 Then
            MsgBox("Seleccione la Compañía.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cias.Focus()
            Exit Sub
        End If
        Dim Ruta As Integer = 0
        If chk_Ruta.Enabled Then
            If cmb_Ruta.Enabled And cmb_Ruta.SelectedValue = 0 Then
                MsgBox("Seleccione la Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Ruta.Focus()
                Exit Sub
            End If
            '    Ruta = cmb_Ruta.SelectedValue
            'Else
            '    Ruta = -1
        End If
        If cmb_Usuario.Enabled And cmb_Usuario.SelectedValue = 0 Then
            MsgBox("Seleccione el Usuario.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Usuario.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione el Estatus.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cias.Focus()
            Exit Sub
        End If
        Dim Status As Char = ""
        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        If Not fn_ConsultarDespacho_LlenarLista(lsv_Despachos, dtp_Desde.Value.Date, dtp_Hasta.Value.Date, cmb_Cias.SelectedValue, cmb_Ruta.SelectedValue, cmb_Usuario.SelectedValue, Status) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call ColorearCancelados()
        btn_Exportar.Enabled = lsv_Despachos.Items.Count > 0
        Lbl_Registros.Text = "Regtistros: " & lsv_Despachos.Items.Count
    End Sub

    Private Sub lsv_Despachos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Despachos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Detalle.Items.Clear()
        If lsv_Despachos.SelectedItems.Count > 0 Then
            If Not fn_CancelarDespacho_LlenarDetalles(lsv_Detalle, lsv_Despachos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista de Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Despachos, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Sub LimpiarListas()
        lsv_Despachos.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
    End Sub

    Sub ColorearCancelados()
        For Each item As ListViewItem In lsv_Despachos.Items
            If item.SubItems(7).Text = "CANCELADO" Then
                item.ForeColor = Color.Red
            End If
        Next
    End Sub

End Class