Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_EntradaServiciosReg

    Private Sub frm_EntradaResguardos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_serviciosProD.Columns.Add("Remision")
        lsv_serviciosProD.Columns.Add("Caja")
        lsv_serviciosProD.Columns.Add("Importe", 120, HorizontalAlignment.Right)
        lsv_serviciosProD.Columns.Add("Envases", 120, HorizontalAlignment.Right)
        lsv_serviciosProD.Columns.Add("EnvasesSN", 120, HorizontalAlignment.Right)

        lsv_serviciosMorD.Columns.Add("Remision")
        lsv_serviciosMorD.Columns.Add("Caja")
        lsv_serviciosMorD.Columns.Add("Importe", 120, HorizontalAlignment.Right)
        lsv_serviciosMorD.Columns.Add("Envases", 120, HorizontalAlignment.Right)
        lsv_serviciosMorD.Columns.Add("EnvasesSN", 120, HorizontalAlignment.Right)

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()

        Call LlenalistaProceso()

        If Not MorrallaRecibeRuta Then
            Call LlenalistaMorralla()
        Else
            tab_ServiciosRegresados.TabPages.Remove(tab_Morralla)
        End If


    End Sub

    Private Sub LlenalistaProceso()
        SegundosDesconexion = 0
        lsv_serviciosProD.Items.Clear()
        btn_Recibir.Enabled = False
        lbl_registrosPro.Text = "Registros: 0"

        '(mostrar Regresados)4 = Proceso --> Boveda
        If Not fn_EntradaServiciosRegLlenalista(lsv_ServiciosPro, 4, "A") Then
            MsgBox("Ocurrio un error al llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lsv_ServiciosPro.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_ServiciosPro.Columns(4).TextAlign = HorizontalAlignment.Right

        lbl_registrosPro.Text = "Registros: " & lsv_ServiciosPro.Items.Count
    End Sub

    Private Sub LlenalistaMorralla()
        SegundosDesconexion = 0
        lsv_serviciosMorD.Items.Clear()
        btn_Recibir.Enabled = False
        lbl_registrosMor.Text = "Registros: 0"

        '(mostrar Regresados)6 = Morralla --> Boveda
        If Not fn_EntradaServiciosRegLlenalista(lsv_serviciosMor, 6, "A") Then
            MsgBox("Ocurrio un error al llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lsv_serviciosMor.Columns(3).TextAlign = HorizontalAlignment.Right
        lsv_serviciosMor.Columns(4).TextAlign = HorizontalAlignment.Right

        lbl_registrosMor.Text = "Registros: " & lsv_serviciosMor.Items.Count
    End Sub

    Private Sub lsv_serviciosPro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ServiciosPro.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_serviciosProD.Items.Clear()
        If lsv_ServiciosPro.SelectedItems.Count <> 0 Then
            If fn_EntradaResguardoD_Llenalista(lsv_serviciosProD, lsv_ServiciosPro.SelectedItems(0).Tag) Then
                lsv_serviciosProD.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv_serviciosProD.Columns(3).TextAlign = HorizontalAlignment.Right
                lsv_serviciosProD.Columns(4).TextAlign = HorizontalAlignment.Right
            Else
                MsgBox("Ocurrió un error al intentar consultar las Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub lsv_serviciosMor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_serviciosMor.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_serviciosMorD.Items.Clear()
        If lsv_serviciosMor.SelectedItems.Count <> 0 Then
            If fn_EntradaResguardoD_Llenalista(lsv_serviciosMorD, lsv_serviciosMor.SelectedItems(0).Tag) Then
                lsv_serviciosMorD.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv_serviciosMorD.Columns(3).TextAlign = HorizontalAlignment.Right
                lsv_serviciosMorD.Columns(4).TextAlign = HorizontalAlignment.Right
            Else
                MsgBox("Ocurrió un error al intentar consultar las Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub lsv_serviciosPro_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_ServiciosPro.ItemChecked
        SegundosDesconexion = 0

        btn_Recibir.Enabled = lsv_ServiciosPro.CheckedItems.Count > 0
        If BanderA Then lsv_ServiciosPro.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub lsv_serviciosMor_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_serviciosMor.ItemChecked
        SegundosDesconexion = 0

        btn_Recibir.Enabled = lsv_serviciosMor.CheckedItems.Count > 0
        If BanderA Then lsv_serviciosMor.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0
        Dim Elemento As ListViewItem
        Dim frm As New frm_FirmaElectronica

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccione una Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Boveda.Focus()
            Exit Sub
        End If

        Select Case tab_ServiciosRegresados.SelectedTab.Name
            Case tab_Proceso.Name
                '--proceso
                For Each Elemento In lsv_ServiciosPro.CheckedItems
                    If fn_RecLotesBoveda_Validar(Elemento.Tag) Then
                        MsgBox("Algunos Lotes ya no estan disponibles, se actualizará la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Call LlenalistaProceso()
                        Exit Sub
                    End If
                Next

                frm.Bloquear = True
                frm.ShowDialog()
                If frm.Firma Then
                    If fn_EntradaServiciosReg_Guardar(cmb_Boveda.SelectedValue, lsv_ServiciosPro, UsuarioId) = True Then
                        MsgBox("Servicios recibidos correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Call LlenalistaProceso()
                        btn_Recibir.Enabled = False
                    Else
                        MsgBox("Ocurrió un error al intentar guardar los servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                End If

            Case tab_Morralla.Name
                '--Morralla, cuando este no recibe Ruta 28/05/2014

                For Each Elemento In lsv_serviciosMor.CheckedItems
                    If fn_RecLotesBoveda_Validar(Elemento.Tag) Then
                        MsgBox("Algunos Lotes ya no estan disponibles, se actualizará la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Call LlenalistaMorralla()
                        Exit Sub
                    End If
                Next

                frm.Bloquear = True
                frm.ShowDialog()
                If frm.Firma Then
                    If fn_EntradaServiciosReg_Guardar(cmb_Boveda.SelectedValue, lsv_serviciosMor, UsuarioId) = True Then
                        MsgBox("Servicios recibidos correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                        Call LlenalistaMorralla()
                        btn_Recibir.Enabled = False
                    Else
                        MsgBox("Ocurrió un error al intentar guardar los servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                End If
        End Select
    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        SegundosDesconexion = 0

        Select Case tab_ServiciosRegresados.SelectedTab.Name

            Case tab_Proceso.Name
                Call LlenalistaProceso()
            Case tab_Morralla.Name
                Call LlenalistaMorralla()
        End Select

    End Sub

    Private Sub tab_ServiciosRegresados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_ServiciosRegresados.SelectedIndexChanged
        SegundosDesconexion = 0

        If tab_ServiciosRegresados.SelectedIndex = 1 Then
            For Each listaPro As ListViewItem In lsv_ServiciosPro.CheckedItems
                listaPro.Checked = False
            Next
        Else
            For Each listaMor As ListViewItem In lsv_serviciosMor.CheckedItems
                listaMor.Checked = False
            Next
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class