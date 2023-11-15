Public Class frm_CambioServiciosBoveda

    Private Sub frm_CambioServiciosBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_BovedaOrigen.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_BovedaOrigen.AgregaParametro("@Status", "A", 0)
        cmb_BovedaOrigen.Actualizar()

        cmb_BovedaDestino.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_BovedaDestino.AgregaParametro("@Status", "A", 0)
        cmb_BovedaDestino.Actualizar()

        lsv_Servicios.Columns.Add("Fecha", 100)
        lsv_Servicios.Columns.Add("Hora", 100)
        lsv_Servicios.Columns.Add("Remisión", 100)
        lsv_Servicios.Columns.Add("Compañia", 100)
        lsv_Servicios.Columns.Add("Importe", 100)
        lsv_Servicios.Columns.Add("Envases", 100)
        lsv_Servicios.Columns.Add("EnvasesSN", 100)

    End Sub

    Private Sub cmb_BovedaOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BovedaOrigen.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Servicios.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        Call Llenalista()
    End Sub

    Sub Llenalista()
        SegundosDesconexion = 0
        lbl_Registros.Text = "Registros: 0"
        If Not cn_Recepcion.fn_Bo_BovedaLlenaListaServicios(lsv_Servicios, CInt(cmb_BovedaOrigen.SelectedValue)) Then
            MsgBox("No se pudieron Cargar los Servicios de la Boveda Seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_Registros.Text = "Registros: " & lsv_Servicios.Items.Count
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        If lsv_Servicios.CheckedItems.Count = 0 Then
            MsgBox("Seleccione las Remisiones que desea cambiar de Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Servicios.Focus()
            Exit Sub
        End If

        If cmb_BovedaDestino.SelectedValue = 0 Then
            MsgBox("Seleccione la Bóveda Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_BovedaDestino.Focus()
            Exit Sub
        End If

        If cmb_BovedaOrigen.SelectedValue = cmb_BovedaDestino.SelectedValue Then
            MsgBox("La Bóveda Destino debe ser diferente a la Bóveda Origen.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_BovedaDestino.Focus()
            Exit Sub
        End If

        If Not cn_Recepcion.fn_Bo_BovedaCambioBovedaServicio(lsv_Servicios, CInt(cmb_BovedaDestino.SelectedValue)) Then
            MsgBox("Ocurrió un error al intentar cambiar las Remisiones de Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call Llenalista()
        cmb_BovedaDestino.SelectedValue = 0
        chk_Todos.Checked = False

    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0
        If chk_Todos.Checked Then
            Call Marcar()
        Else
            Call Desmarcar()
        End If
    End Sub

    Sub Marcar()
        SegundosDesconexion = 0
        For Each Elem As ListViewItem In lsv_Servicios.Items
            Elem.Checked = True
        Next
    End Sub

    Sub Desmarcar()
        SegundosDesconexion = 0
        For Each Elem As ListViewItem In lsv_Servicios.Items
            Elem.Checked = False
        Next
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

End Class