Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_DevolucionDotacion
    Private tbx_Remisiones, tbx_Envases, tbx_RemisionesN, tbx_EnvasesN As String
    Private tbx_RemisionesM, tbx_EnvasesM, tbx_RemisionesP, tbx_EnvasesP As String
    Private Columnas() As Integer = {1, 3, 4, 5}
    Private Nombres() As String = {"Remisiones", "Importe", "Envases", "Envases S/N"}
    Private Formatos() As String = {"g", "n", "g", "g"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma, Func.Suma}
    Private F As Boolean
    Private tbl As DataTable

    Private Sub frm_DevolucionDotacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbl = New DataTable
        F = True
        cmb_DevolverA.AgregarItem(21, "CAJEROS")
        cmb_DevolverA.AgregarItem(53, "AUDITORIA")

        lsv_Envase.Columns.Add("Tipo")
        lsv_Envase.Columns.Add("Numero Envase")

        lsv_EnvaseP.Columns.Add("Tipo")
        lsv_EnvaseP.Columns.Add("Numero Envase")

        lsv_EnvaseM.Columns.Add("Tipo")
        lsv_EnvaseM.Columns.Add("Numero Envase")

        lsv_EnvaseN.Columns.Add("Tipo")
        lsv_EnvaseN.Columns.Add("Numero Envase")

        'Aqui se llena la lista
        Call LlenaLista()
        F = False
    End Sub

    Private Sub lsv_Dotacion_ItemChecked(ByVal sender As cp_Listview, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotacion.ItemChecked, lsv_Morralla.ItemChecked, lsv_Nominas.ItemChecked, lsv_Proceso.ItemChecked
        SegundosDesconexion = 0

        Dim Destino As cp_Listview
        If sender Is lsv_Dotacion Then Destino = lsv_DotacionT
        If sender Is lsv_Morralla Then Destino = lsv_MorrallaT
        If sender Is lsv_Nominas Then Destino = lsv_NominasT
        If sender Is lsv_Proceso Then Destino = lsv_ProcesoT

        fn_TotalesListView(lsv_Dotacion, lsv_DotacionT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)
        fn_TotalesListView(lsv_Morralla, lsv_MorrallaT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)
        fn_TotalesListView(lsv_Nominas, lsv_NominasT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)
        fn_TotalesListView(lsv_Proceso, lsv_ProcesoT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        If sender.Columns.Count > Columnas.Max Then
            Call BotonDevolucion()
        End If
    End Sub

    Sub BotonDevolucion()
        Select Case Tab_Devolucion.SelectedTab.Name

            Case tab_Dotacion.Name
                btn_Devolucion.Enabled = lsv_Dotacion.CheckedItems.Count > 0

            Case Tab_Morralla.Name
                btn_Devolucion.Enabled = lsv_Morralla.CheckedItems.Count > 0

            Case Tab_Nominas.Name
                btn_Devolucion.Enabled = lsv_Nominas.CheckedItems.Count > 0

            Case Tab_Proceso.Name
                btn_Devolucion.Enabled = lsv_Proceso.CheckedItems.Count > 0

        End Select
    End Sub

    Private Sub btn_Devolucion_Click(ByVal sender As Button, ByVal e As System.EventArgs) Handles btn_Devolucion.Click
        SegundosDesconexion = 0

        Dim lsv As cp_Listview
        Dim TipoLote As Integer
        Dim Envases As Integer
        Dim Remisiones As Integer

        Select Case Tab_Devolucion.SelectedTab.Name
            Case tab_Dotacion.Name
                If cmb_DevolverA.SelectedValue = 0 Then
                    MsgBox("Seleccione a donde se devolverán las Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_DevolverA.Focus()
                    Exit Sub
                End If
                lsv = lsv_Dotacion
                TipoLote = cmb_DevolverA.SelectedValue
                Call calcula(lsv)
                Envases = tbx_Envases
                Remisiones = tbx_Remisiones
            Case Tab_Morralla.Name
                lsv = lsv_Morralla
                TipoLote = 22
                Call calcula(lsv)
                Envases = tbx_EnvasesM
                Remisiones = tbx_RemisionesM
            Case Tab_Nominas.Name
                lsv = lsv_Nominas
                TipoLote = 41
                Call calcula(lsv)
                Envases = tbx_EnvasesN
                Remisiones = tbx_RemisionesN
            Case Tab_Proceso.Name
                lsv = lsv_Proceso
                TipoLote = 20
                Call calcula(lsv)
                Envases = tbx_EnvasesP
                Remisiones = tbx_RemisionesP
        End Select

        For Each Elemento As ListViewItem In lsv.CheckedItems
            If cn_Recepcion.fn_DevolucionDotacion_Valida(Elemento.Tag) = True Then
                MsgBox("Algunas de las Dotaciones ya no están disponibles, se actualizara la ventana.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call LlenaLista()
                Exit Sub
            End If
        Next

        If cn_Recepcion.fn_DevolucionDotacion_Guardar(lsv, Remisiones, Envases, TipoLote) Then
            MsgBox("Las Dotaciones fueron regresadas correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenaLista()
            btn_Devolucion.Enabled = False
        Else
            MsgBox("Ocurrió un error al intentar regresar las Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        Call cn_Recepcion.fn_DevolucionDotacion_LlenarLista(lsv_Dotacion)
        Call fn_TotalesListView(lsv_Dotacion, lsv_DotacionT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        Call cn_Recepcion.fn_DevolucionDotacion_LlenarListaPro(lsv_Morralla, "M")
        Call fn_TotalesListView(lsv_Morralla, lsv_MorrallaT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        Call cn_Recepcion.fn_DevolucionDotacion_LlenarListaPro(lsv_Nominas, "N")
        Call fn_TotalesListView(lsv_Nominas, lsv_NominasT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        Call cn_Recepcion.fn_DevolucionDotacion_LlenarListaPro(lsv_Proceso, "P")
        Call fn_TotalesListView(lsv_Proceso, lsv_ProcesoT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        Lbl_RegistrosC.Text = "Registros: " & lsv_Dotacion.Items.Count
        Lbl_RegistrosM.Text = "Registros: " & lsv_Morralla.Items.Count
        Lbl_RegistrosN.Text = "Registros: " & lsv_Nominas.Items.Count
        Lbl_RegistrosP.Text = "Registros: " & lsv_Proceso.Items.Count

        Call calcula(lsv_Dotacion)
        Call calcula(lsv_Morralla)
        Call calcula(lsv_Nominas)
        Call calcula(lsv_Proceso)
    End Sub

    Private Sub calcula(ByVal lsv As cp_Listview)
        Dim Elemento As ListViewItem

        If lsv.Items.Count > 0 Then
            Dim Importe As Decimal = 0
            Dim Envases As Decimal = 0

            For Each Elemento In lsv.CheckedItems
                Importe += Elemento.SubItems(3).Text
                Envases += Elemento.SubItems(10).Text
            Next

            Select Case lsv.Name
                Case lsv_Dotacion.Name
                    tbx_Remisiones = lsv.CheckedItems.Count
                    tbx_Envases = Envases

                Case lsv_Morralla.Name
                    tbx_RemisionesM = lsv.CheckedItems.Count
                    tbx_EnvasesM = Envases

                Case lsv_Nominas.Name
                    tbx_RemisionesN = lsv.CheckedItems.Count
                    tbx_EnvasesN = Envases

                Case lsv_Proceso.Name
                    tbx_RemisionesP = lsv.CheckedItems.Count
                    tbx_EnvasesP = Envases

            End Select

            lsv_Envase.Items.Clear()
            lsv_EnvaseP.Items.Clear()
            lsv_EnvaseM.Items.Clear()
            lsv_EnvaseN.Items.Clear()

        End If
    End Sub

    Private Sub Tab_Devolucion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Devolucion.SelectedIndexChanged
        SegundosDesconexion = 0
        Call BotonDevolucion()
    End Sub

    Private Sub lsv_Dotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envase.Items.Clear()

        If lsv_Dotacion.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_Envase, lsv_Dotacion.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub lsv_Proceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Proceso.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_EnvaseP.Items.Clear()

        If lsv_Proceso.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvaseP, lsv_Proceso.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub lsv_Morralla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Morralla.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_EnvaseM.Items.Clear()

        If lsv_Morralla.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvaseM, lsv_Proceso.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub lsv_Nominas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Nominas.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_EnvaseM.Items.Clear()

        If lsv_Nominas.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvaseN, lsv_Proceso.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarC.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Dotacion, Remision, 0)
            tbx_BuscarC.Focus()
            tbx_BuscarC.SelectAll()
        End If

        If tbx_BuscarP.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Proceso, Remision, 0)
            tbx_BuscarC.Focus()
            tbx_BuscarC.SelectAll()
        End If

        If tbx_BuscarM.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Morralla, Remision, 0)
            tbx_BuscarC.Focus()
            tbx_BuscarC.SelectAll()
        End If

        If tbx_BuscarN.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Nominas, Remision, 0)
            tbx_BuscarC.Focus()
            tbx_BuscarC.SelectAll()
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

        If tbx_BuscarC.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Dotacion.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarP.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Proceso.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarM.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Morralla.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarN.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Nominas.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If


    End Sub

    Private Sub tbx_BuscarC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarC.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Dotacion, tbx_BuscarC) Then
                tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaEnvase(lsv_Dotacion)
                Buscar_Envase(tbx_BuscarC.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarC.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_Dotacion, tbx_BuscarC) Then
            tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaEnvase(lsv_Dotacion)
            Buscar_Envase(tbx_BuscarC.Text)
        End If
    End Sub

    Private Sub tbx_BuscarP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarP.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Proceso, tbx_BuscarP) Then
                tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Proceso, "P")
                Buscar_Envase(tbx_BuscarP.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarP.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_Proceso, tbx_BuscarP) Then
            tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Proceso, "P")
            Buscar_Envase(tbx_BuscarP.Text)
        End If
    End Sub

    Private Sub tbx_BuscarM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarM.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Morralla, tbx_BuscarM) Then
                tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Morralla, "M")
                Buscar_Envase(tbx_BuscarM.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarM.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_Morralla, tbx_BuscarM) Then
            tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Morralla, "M")
            Buscar_Envase(tbx_BuscarM.Text)
        End If
    End Sub

    Private Sub tbx_BuscarN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarN.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Nominas, tbx_BuscarN) Then
                tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Nominas, "N")
                Buscar_Envase(tbx_BuscarN.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarN.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_Nominas, tbx_BuscarN) Then
            tbl = cn_Recepcion.fn_DevolucionDotacion_LlenarListaProEnvase(lsv_Nominas, "N")
            Buscar_Envase(tbx_BuscarN.Text)
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