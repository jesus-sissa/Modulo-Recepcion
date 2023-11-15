Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_CancelarEnvioCajeros

    Public tbl As DataTable

    Private Sub frm_CancelarEnvioProceso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_RemanentesD.Columns.Add("Remision")
        lsv_RemanentesD.Columns.Add("Caja Bancaria")
        lsv_RemanentesD.Columns.Add("Cajero")
        lsv_RemanentesD.Columns.Add("Importe")
        lsv_RemanentesD.Columns.Add("Envases")
        lsv_RemanentesD.Columns.Add("EnvasesSN")

        lsv_DotacionesD.Columns.Add("Remision")
        lsv_DotacionesD.Columns.Add("Caja Bancaria")
        lsv_DotacionesD.Columns.Add("Cajero")
        lsv_DotacionesD.Columns.Add("Importe")
        lsv_DotacionesD.Columns.Add("Envases")
        lsv_DotacionesD.Columns.Add("EnvasesSN")

        lsv_DotacionesAD.Columns.Add("Remision")
        lsv_DotacionesAD.Columns.Add("Caja Bancaria")
        lsv_DotacionesAD.Columns.Add("Cajero")
        lsv_DotacionesAD.Columns.Add("Importe")
        lsv_DotacionesAD.Columns.Add("Envases")
        lsv_DotacionesAD.Columns.Add("EnvasesSN")

        lsv_EnvasesR.Columns.Add("Tipo")
        lsv_EnvasesR.Columns.Add("Numero Envase")

        lsv_EnvasesDA.Columns.Add("Tipo")
        lsv_EnvasesDA.Columns.Add("Numero Envase")

        lsv_EnvasesDP.Columns.Add("Tipo")
        lsv_EnvasesDP.Columns.Add("Numero Envase")

        Call Actualizar()
    End Sub

    Public Sub Actualizar()
        SegundosDesconexion = 0
        lsv_Remanentes.Items.Clear()
        lsv_RemanentesD.Items.Clear()
        lsv_Dotaciones.Items.Clear()
        lsv_DotacionesD.Items.Clear()
        lsv_DotacionesA.Items.Clear()
        lsv_DotacionesAD.Items.Clear()
        lsv_EnvasesR.Items.Clear()

        btn_Cancelar.Enabled = False
        If Not fn_CancelarEnvioCajeros_LlenarListaRemanentes(lsv_Remanentes) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes de Remanentes.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not fn_CancelarEnvioCajeros_LlenarListaDotaciones(lsv_Dotaciones) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not fn_CancelarEnvioCajeros_LlenarListaDotacionesAuditoria(lsv_DotacionesA) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        lbl_RegistrosR.Text = "Registros: " & lsv_Remanentes.Items.Count
        Lbl_RegistrosDP.Text = "Registros: " & lsv_Dotaciones.Items.Count
        Lbl_RegistrosDA.Text = "Registros: " & lsv_DotacionesA.Items.Count
    End Sub

    Private Sub lsv_Remanentes_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remanentes.ItemChecked
        SegundosDesconexion = 0
        btn_Cancelar.Enabled = lsv_Remanentes.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Dotaciones_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotaciones.ItemChecked
        SegundosDesconexion = 0
        btn_Cancelar.Enabled = lsv_Dotaciones.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_DotacionesA_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_DotacionesA.ItemChecked
        SegundosDesconexion = 0
        btn_Cancelar.Enabled = lsv_DotacionesA.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Remanentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remanentes.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Remanentes.SelectedItems.Count = 0 Then Exit Sub
        If Not fn_CancelarEnvioCajeros_LlenarDetalles(lsv_RemanentesD, lsv_Remanentes.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Remanentes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub lsv_Dotaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotaciones.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Dotaciones.SelectedItems.Count = 0 Then Exit Sub
        If Not fn_CancelarEnvioCajeros_LlenarDetalles(lsv_DotacionesD, lsv_Dotaciones.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Dotaciones para Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub lsv_DotacionesA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionesA.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_DotacionesA.SelectedItems.Count = 0 Then Exit Sub
        If Not fn_CancelarEnvioCajeros_LlenarDetalles(lsv_DotacionesAD, lsv_DotacionesA.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Dotaciones para Auditoría.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        If tab_Principal.SelectedTab Is Tab_Remanentes Then
            fn_CancelarEnvioCajeros_Cancelar(lsv_Remanentes)
        ElseIf tab_Principal.SelectedTab Is tab_Dotaciones Then
            fn_CancelarEnvioCajeros_Cancelar(lsv_Dotaciones)
        ElseIf tab_Principal.SelectedTab Is tab_DotacionesA Then
            fn_CancelarEnvioCajeros_Cancelar(lsv_DotacionesA)
        End If
        Call Actualizar()
    End Sub

    Private Sub tab_Principal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Principal.SelectedIndexChanged
        For Each Elemento As ListViewItem In lsv_Remanentes.CheckedItems
            Elemento.Checked = False
        Next
        For Each Elemento As ListViewItem In lsv_Dotaciones.CheckedItems
            Elemento.Checked = False
        Next
        For Each Elemento As ListViewItem In lsv_DotacionesA.CheckedItems
            Elemento.Checked = False
        Next
        btn_Cancelar.Enabled = False
    End Sub

    Private Sub lsv_RemanentesD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_RemanentesD.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesR.Items.Clear()

        If lsv_RemanentesD.Items.Count > 0 AndAlso lsv_RemanentesD.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases4(lsv_EnvasesR, lsv_RemanentesD.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub lsv_DotacionesD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionesD.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesDP.Items.Clear()

        If lsv_DotacionesD.Items.Count > 0 AndAlso lsv_DotacionesD.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases4(lsv_EnvasesDP, lsv_DotacionesD.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub lsv_DotacionesAD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionesAD.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesDA.Items.Clear()

        If lsv_DotacionesD.Items.Count > 0 AndAlso lsv_DotacionesD.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases4(lsv_EnvasesDA, lsv_DotacionesAD.SelectedItems(0).Tag)
        End If
    End Sub


    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarR.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_RemanentesD, Remision, 0)
            tbx_BuscarR.Focus()
            tbx_BuscarR.SelectAll()
        End If

        If tbx_BuscarDP.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_DotacionesD, Remision, 0)
            tbx_BuscarDP.Focus()
            tbx_BuscarDP.SelectAll()
        End If

        If tbx_BuscarAD.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_DotacionesD, Remision, 0)
            tbx_BuscarAD.Focus()
            tbx_BuscarAD.SelectAll()
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

        If tbx_BuscarR.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_RemanentesD.Items
                If (item.SubItems(1).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarDP.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_DotacionesD.Items
                If (item.SubItems(1).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarAD.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_DotacionesAD.Items
                If (item.SubItems(1).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

    End Sub


    Private Sub tbx_BuscarR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarR.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If lsv_Remanentes.SelectedItems.Count > 0 Then
                If Not BuscarRemision(lsv_Remanentes, tbx_BuscarR) Then
                    tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_RemanentesD, lsv_Remanentes.SelectedItems(0).Tag)
                    Buscar_Envase(tbx_BuscarR.Text)
                End If
            End If           
        End If
    End Sub

    Private Sub tbx_BuscarDP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarDP.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If lsv_Dotaciones.SelectedItems.Count > 0 Then
                If Not BuscarRemision(lsv_Dotaciones, tbx_BuscarDP) Then
                    tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_DotacionesD, lsv_Dotaciones.SelectedItems(0).Tag)
                    Buscar_Envase(tbx_BuscarDP.Text)
                End If
            End If           
        End If
    End Sub


    Private Sub tbx_BuscarAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarAD.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If lsv_DotacionesA.SelectedItems.Count > 0 Then
                If Not BuscarRemision(lsv_DotacionesA, tbx_BuscarAD) Then
                    tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_DotacionesAD, lsv_DotacionesA.SelectedItems(0).Tag)
                    Buscar_Envase(tbx_BuscarAD.Text)
                End If
            End If
            
        End If
    End Sub

    Private Sub btn_BuscarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarR.Click
        If lsv_Remanentes.SelectedItems.Count > 0 Then
            If Not BuscarRemision(lsv_Remanentes, tbx_BuscarR) Then
                tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_RemanentesD, lsv_Remanentes.SelectedItems(0).Tag)
                Buscar_Envase(tbx_BuscarR.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarDP.Click
        If lsv_Dotaciones.SelectedItems.Count > 0 Then
            If Not BuscarRemision(lsv_Dotaciones, tbx_BuscarDP) Then
                tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_DotacionesD, lsv_Dotaciones.SelectedItems(0).Tag)
                Buscar_Envase(tbx_BuscarDP.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarAd.Click
        If lsv_DotacionesA.SelectedItems.Count > 0 Then
            If Not BuscarRemision(lsv_DotacionesA, tbx_BuscarAD) Then
                tbl = cn_Recepcion.fn_CancelarEnvioCajeros_LlenarDetallesEnvases(lsv_DotacionesAD, lsv_DotacionesA.SelectedItems(0).Tag)
                Buscar_Envase(tbx_BuscarAD.Text)
            End If
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As ListView, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function

End Class