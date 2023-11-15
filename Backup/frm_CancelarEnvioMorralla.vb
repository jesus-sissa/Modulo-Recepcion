Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_CancelarEnvioMorralla

    Private Sub frm_CancelarEnvioMorralla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarLista()
    End Sub

#Region "Eventos Privados"

    Private Sub LlenarLista()
        BanderA = False
        btn_Cancelar.Enabled = False
        lsv_Envases.Items.Clear()
        lsv_Remisiones.Items.Clear()

        'destino M=Morralla
        If Not fn_CancelarEnvioProceso_LlenarListaNew(lsv_Remisiones, "M") Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_RegistrosDA.Text = "Registros: " & lsv_Remisiones.Items.Count
        BanderA = True
    End Sub

    Private Sub Buscar()
        SegundosDesconexion = 0

        'Marcar la remisión buscada
        fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, tbx_Buscar.Text, 0)
        tbx_Buscar.Focus()
    End Sub

#End Region

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then Call Buscar()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Call Buscar()
    End Sub

    Private Sub lsv_Remisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Remisiones.SelectedItems.Count > 0 Then
            If Not fn_CancelarEnvioProceso_Envases(lsv_Remisiones.SelectedItems(0).SubItems(8).Text, lsv_Envases) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista Detalles", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            lsv_Envases.SelectedItems.Clear()
        End If
    End Sub

    Private Sub lsv_Remisiones_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remisiones.ItemChecked
        SegundosDesconexion = 0

        btn_Cancelar.Enabled = lsv_Remisiones.CheckedItems.Count > 0
        If BanderA Then lsv_Remisiones.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        If lsv_Remisiones.CheckedItems.Count = 0 Then Exit Sub

        'verificar si estan disponibles los lotes a cancelar
        For Each Elemento As ListViewItem In lsv_Remisiones.CheckedItems
            If fn_RecLotesBoveda_ValidarNew(Elemento.Tag) = True Then
                MsgBox("Algunos lotes  ya no están disponibles, se actualizará la Lista.", MsgBoxStyle.Critical, Me.Text)
                Call LlenarLista()
                Exit Sub
            End If
        Next

        If fn_CancelarEnvioProceso_CancelarNew(lsv_Remisiones) Then
            MsgBox("Se Cancelaron los Envios correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrio un error al intentar Cancelar los Envios de morralla.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call LlenarLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class