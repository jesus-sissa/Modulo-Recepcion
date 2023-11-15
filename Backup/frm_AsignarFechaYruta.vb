Imports System.Data.SqlClient
Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_AsignarFechaYruta

    Public tbl As DataTable
    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_AsignarServicios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_Boveda.Columns.Add("Remision")
        lsv_Boveda.Columns.Add("Ruta Salida")
        lsv_Boveda.Columns.Add("Fecha Salida")
        lsv_Boveda.Columns.Add("Origen")
        lsv_Boveda.Columns.Add("Destino")
        lsv_Boveda.Columns.Add("Importe")
        lsv_Boveda.Columns.Add("Envases")
        lsv_Boveda.Columns.Add("EnvasesSN")

        lsv_Atms.Columns.Add("Remision")
        lsv_Atms.Columns.Add("Ruta Salida")
        lsv_Atms.Columns.Add("Fecha Salida")
        lsv_Atms.Columns.Add("Caja")
        lsv_Atms.Columns.Add("Cajero")
        lsv_Atms.Columns.Add("Importe")
        lsv_Atms.Columns.Add("Envases")
        lsv_Atms.Columns.Add("EnvasesSN")

        lsv_EnvaseTv.Columns.Add("Tipo")
        lsv_EnvaseTv.Columns.Add("Numero Envase")

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "T", 0)
        cmb_Boveda.Actualizar()

        cmb_BovedaCajeros.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_BovedaCajeros.Actualizar()

        cmb_Ruta.Actualizar()
        cmb_Ruta2.Actualizar()
        cmb_NuevoOrigen.Actualizar(fn_SubCliente_LlenarLista(-1, "A", True))

    End Sub

    Private Sub cbx_Todas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_Todas.CheckedChanged
        SegundosDesconexion = 0

        cmb_Boveda.SelectedValue = "0"
        If cbx_Todas.Checked Then
            cmb_Boveda.Enabled = False
        Else
            cmb_Boveda.Enabled = True
        End If

        Call LlenarListaPro()
    End Sub

    Private Sub cmb_Boveda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Boveda.SelectedValueChanged
        SegundosDesconexion = 0

        Call LlenarListaPro()
    End Sub

    Private Sub cbx_TodasCajeros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_TodasCajeros.CheckedChanged
        SegundosDesconexion = 0

        cmb_BovedaCajeros.SelectedValue = "0"
        If cbx_TodasCajeros.Checked Then
            cmb_BovedaCajeros.Enabled = False
        Else
            cmb_BovedaCajeros.Enabled = True
        End If

        Call LlenarListaCaj()
    End Sub

    Private Sub cmb_BovedaCajeros_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_BovedaCajeros.SelectedValueChanged
        SegundosDesconexion = 0

        Call LlenarListaCaj()
    End Sub

    Sub LlenarListaPro()
        SegundosDesconexion = 0

        lsv_Boveda.Items.Clear()
        lsv_EnvaseTv.Items.Clear()
        lbl_RegistrosTV.Text = "Registros: 0"
        If cmb_Boveda.Enabled Then
            If cmb_Boveda.SelectedValue = 0 Then Exit Sub
        End If

        Call fn_Servicios_LlenarBovedas(lsv_Boveda, cmb_Boveda.SelectedValue)
        lsv_Boveda.Columns(5).TextAlign = HorizontalAlignment.Right
        lsv_Boveda.Columns(6).TextAlign = HorizontalAlignment.Right
        lsv_Boveda.Columns(7).TextAlign = HorizontalAlignment.Right

        lbl_RegistrosTV.Text = "Registros: " & lsv_Boveda.Items.Count

    End Sub

    Sub LlenarListaCaj()
        SegundosDesconexion = 0

        lsv_Atms.Items.Clear()
        Lbl_RegistrosAtm.Text = "Registros: 0"
        If cmb_BovedaCajeros.Enabled Then
            If cmb_BovedaCajeros.SelectedValue = 0 Then Exit Sub
        End If
        Call fn_Servicios_LlenarAtms(lsv_Atms, cmb_BovedaCajeros.SelectedValue)
        Lbl_RegistrosAtm.Text = "Registros: " & lsv_Atms.Items.Count
    End Sub

    Private Sub tbx_BuscarBoveda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarBoveda.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not BuscarBoveda() Then
                BusquedaBo()
            End If
        End If
    End Sub

    Private Sub tbx_BuscarCajeros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarCajeros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not BuscarCajeros() Then
                BusquedaCa()
            End If
        End If
    End Sub

    Private Sub btn_BuscarBoveda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarBoveda.Click
        'Call BuscarBoveda()
        If Not BuscarBoveda() Then
            BusquedaBo()
        End If
    End Sub
    Public Function BusquedaBo()
        tbl = cn_Recepcion.fn_Servicios_LlenarBovedasEnvase(lsv_Boveda, cmb_Boveda.SelectedValue)
        Buscar_Envase(tbx_BuscarBoveda.Text)
    End Function
    Public Function BusquedaCa()
        tbl = cn_Recepcion.fn_Servicios_LlenarAtmsEnvase(lsv_Atms, cmb_BovedaCajeros.SelectedValue)
        Buscar_Envase(tbx_BuscarCajeros.Text)
    End Function
    Private Sub btn_BuscarCajeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCajeros.Click
        If Not BuscarCajeros() Then
            BusquedaCa()
        End If
    End Sub

    Function BuscarBoveda() As Boolean
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Boveda.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Boveda.SelectedItems(0).Index + 1
        End If
        'fn_Buscar_enListView(lsv_Boveda, tbx_BuscarBoveda.Text, 0, Fila_Inicio)
        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Boveda, tbx_BuscarBoveda.Text.Trim, 1) Then
            Return False
        End If
        tbx_BuscarBoveda.SelectAll()
        tbx_BuscarBoveda.Focus()
        Return True
    End Function

    Function BuscarCajeros() As Boolean
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Atms.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Atms.SelectedItems(0).Index + 1
        End If
        'fn_Buscar_enListView(lsv_Atms, tbx_BuscarCajeros.Text, 0, Fila_Inicio)
        If Not fn_BuscarSeleccionarMarca_enListView(lsv_Atms, tbx_BuscarCajeros.Text.Trim, 1) Then
            Return False
        End If
        tbx_BuscarCajeros.SelectAll()
        tbx_BuscarCajeros.Focus()
        Return True
    End Function

    Private Sub btn_GuardarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarFecha.Click
        SegundosDesconexion = 0

        If tab_General.SelectedTab Is tab_Boveda Then
            If lsv_Boveda.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Fecha.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If Not fn_Servicios_Actualizar(lsv_Boveda, "F", dtp_Fecha.Value.Date) Then
                MsgBox("Ocurrió un error al intentar asignar la Fecha a los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarListaPro()
        ElseIf tab_General.SelectedTab Is Tab_Atms Then
            If lsv_Atms.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Fecha.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If Not fn_Servicios_Actualizar(lsv_Atms, "F", dtp_Fecha.Value.Date) Then
                MsgBox("Ocurrió un error al intentar asignar la Fecha a los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarListaCaj()
        End If
    End Sub

    Private Sub btn_GuardarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarRuta.Click
        SegundosDesconexion = 0

        If tab_General.SelectedTab Is tab_Boveda Then
            If lsv_Boveda.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If cmb_Ruta.SelectedValue = 0 Then
                MsgBox("Indique la Ruta que se asignará.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Ruta.Focus()
                Exit Sub
            End If
            If Not fn_Servicios_Actualizar(lsv_Boveda, "R", , cmb_Ruta.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar asignar la Ruta a los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarListaPro()
        ElseIf tab_General.SelectedTab Is Tab_Atms Then
            If lsv_Atms.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If cmb_Ruta2.SelectedValue = 0 Then
                MsgBox("Indique la Ruta que se asignará.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Ruta2.Focus()
                Exit Sub
            End If
            If Not fn_Servicios_Actualizar(lsv_Atms, "R", , cmb_Ruta2.SelectedValue) Then
                MsgBox("Ocurrió un error al intentar asignar la Ruta a los Servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarListaCaj()
        End If
    End Sub

    Private Sub btn_GuardarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarTodo.Click
        SegundosDesconexion = 0

        If tab_General.SelectedTab Is tab_Boveda Then
            If lsv_Boveda.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Fecha y Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If cmb_Ruta.SelectedValue = 0 Then
                MsgBox("Indique la Ruta que se asignará.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Ruta.Focus()
                Exit Sub
            End If
            fn_Servicios_Actualizar(lsv_Boveda, "FR", dtp_Fecha.Value.Date, cmb_Ruta.SelectedValue)
            Call LlenarListaPro()
        ElseIf tab_General.SelectedTab Is Tab_Atms Then
            If lsv_Atms.CheckedItems.Count = 0 Then
                MsgBox("No hay Remisiones seleccionadas para asignar Fecha y Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If cmb_Ruta2.SelectedValue = 0 Then
                MsgBox("Indique la Ruta que se asignará.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Ruta2.Focus()
                Exit Sub
            End If
            fn_Servicios_Actualizar(lsv_Atms, "FR", dtp_Fecha.Value.Date, cmb_Ruta2.SelectedValue)

            Call LlenarListaCaj()
        End If
    End Sub

    Private Sub tab_General_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_General.SelectedIndexChanged
        SegundosDesconexion = 0

        If tab_General.SelectedTab Is Tab_Atms Then
            cmb_Ruta2.Visible = True
            cmb_Ruta.Visible = False
            btn_Remanente.Visible = True

            Btn_NuevoO.Visible = False
            Lbl_NuevoO.Visible = False
            cmb_NuevoOrigen.Visible = False
            chk_Ctodos.Visible = False
        Else
            cmb_Ruta2.Visible = False
            cmb_Ruta.Visible = True
            btn_Remanente.Visible = False

            Lbl_NuevoO.Visible = True
            cmb_NuevoOrigen.Visible = True
            Btn_NuevoO.Visible = True
        End If
    End Sub

    Private Sub btn_Remanente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remanente.Click
        SegundosDesconexion = 0

        'Cambiarle Custodia_ATM = 'N' y Concentracion_ATM = 'S'
        If MsgBox("Está a punto de Convertir las CUSTODIAS seleccionadas en Remanentes para enviar a proceso. Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) <> MsgBoxResult.Yes Then Exit Sub
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()
        If frm.Firma Then
            If fn_Servicios_ActualizarTipos(lsv_Atms, 1, 0, "N", "N", "N", "N", "S", "N", "N") Then
                For Each Elemento As ListViewItem In lsv_Atms.CheckedItems
                    FuncionesGlobales.fn_GuardaBitacora(30, "REMISION: " & Elemento.Text & " CAJA: " & Elemento.SubItems(3).Text & " CAJERO: " & Elemento.SubItems(4).Text, CInt(Elemento.Tag))
                Next
                MsgBox("Las custodias se cambiaron correctamente. Ya las podrá ver en la pantalla de Enviar Servicios a Cajeros.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LlenarListaCaj()
            End If
        Else
            MsgBox("No se realizó ningún movimiento.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Atms_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Atms.ItemChecked
        SegundosDesconexion = 0

        Dim Cantidad As Integer = 0
        btn_Remanente.Enabled = False
        If lsv_Atms.CheckedItems.Count = 0 Then Exit Sub
        For Each Elemento As ListViewItem In lsv_Atms.CheckedItems
            If Elemento.SubItems(9).Text <> "CUS" Then
                Exit Sub
            End If
        Next

        If lsv_Atms.CheckedItems.Count > 0 Then
            btn_Remanente.Enabled = True
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarBoveda.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Boveda, Remision, 0)
            tbx_BuscarBoveda.Focus()
            tbx_BuscarBoveda.SelectAll()
        End If

        If tbx_BuscarCajeros.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Atms, Remision, 0)
            tbx_BuscarCajeros.Focus()
            tbx_BuscarCajeros.SelectAll()
        End If

    End Sub

    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Sub Seleccionar(ByVal Remision As String)

        If tbx_BuscarBoveda.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Boveda.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarCajeros.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Atms.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

    End Sub


    Private Sub lsv_Boveda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Boveda.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvaseTv.Items.Clear()

        If lsv_Boveda.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvaseTv, lsv_Boveda.SelectedItems(0).Tag)

        End If
    End Sub

    Private Sub lsv_Atms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Atms.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvaseCaj.Items.Clear()

        If lsv_Atms.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvaseCaj, lsv_Atms.SelectedItems(0).Tag)

        End If
    End Sub

    Private Sub lsv_Boveda_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Boveda.ItemChecked
        If lsv_Boveda.CheckedItems.Count > 0 Then
            Checked()
        Else
            cmb_NuevoOrigen.Actualizar(fn_SubCliente_LlenarLista(-1, "A", True))
        End If
    End Sub
    Sub Checked()
        If chk_Ctodos.Checked Then Exit Sub
        Dim Cliente As String = ""
        For Each item In lsv_Boveda.CheckedItems
            If Cliente = "" Then
                Cliente = item.SubItems(3).Text
                Continue For
            End If
            If Cliente <> "" AndAlso Cliente <> item.SubItems(3).Text Then
                'MsgBox("La seleccion no coincide.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                cmb_NuevoOrigen.Actualizar(fn_SubCliente_LlenarLista(-1, "A", True))
                Exit Sub
            End If
        Next
        cmb_NuevoOrigen.Actualizar(fn_SubCliente_LlenarLista(lsv_Boveda.CheckedItems(0).SubItems(9).Text, "A", True))
    End Sub

    Private Sub Btn_NuevoO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_NuevoO.Click
        If cmb_NuevoOrigen.SelectedValue > 0 Then
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Se cambiara el origen de: " + lsv_Boveda.CheckedItems.Count.ToString + " custodias.", "SIAC", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (opcion = DialogResult.Yes) Then
                For Each item In lsv_Boveda.CheckedItems
                    Nuevo_Origen(item.Tag, cmb_NuevoOrigen.SelectedValue)
                Next
                Call LlenarListaPro()
            End If

        End If
    End Sub

    Private Sub chk_Ctodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Ctodos.CheckedChanged
        SegundosDesconexion = 0
        If chk_Ctodos.Checked Then
            cmb_NuevoOrigen.Actualizar(fn_ListClientes())
        Else
            If lsv_Boveda.CheckedItems.Count = 0 Then
                cmb_NuevoOrigen.Actualizar(fn_SubCliente_LlenarLista(-1, "A", True))
                Exit Sub
            End If

            Checked()
        End If
    End Sub
End Class