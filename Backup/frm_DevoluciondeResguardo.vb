Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_DevoluciondeResguardo
    Private Columnas() As Integer = {1, 3, 4}
    Private Nombres() As String = {"Remisiones", "Importe", "Envases"}
    Private Formatos() As String = {"g", "n", "g"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma}
    Private tbx_TotalRemisiones, tbx_TotalEnvases As String

    Public tbl As DataTable

    Private Sub frm_DevoluciondeResguardo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbl = New DataTable
        BanderA = False
        cmb_Caja.Actualizar()
        BanderA = True

        'Pestaña Proceso
        Lsv_Procesos.Columns.Add("Remision")
        Lsv_Procesos.Columns.Add("FechaEntrada")
        Lsv_Procesos.Columns.Add("Moneda").TextAlign = HorizontalAlignment.Right
        Lsv_Procesos.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Procesos.Columns.Add("Envase").TextAlign = HorizontalAlignment.Right

        Lsv_ProcesosT.Columns.Add("Concepto")
        Lsv_ProcesosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_ProcesosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_ProcesosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesP.Columns.Add("Tipo")
        lsv_EnvasesP.Columns.Add("Numero Envase")

        'Pestaña Cajeros
        Lsv_Cajeros.Columns.Add("Remision")
        Lsv_Cajeros.Columns.Add("FechaEntrada")
        Lsv_Cajeros.Columns.Add("Moneda").TextAlign = HorizontalAlignment.Right
        Lsv_Cajeros.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Cajeros.Columns.Add("Envase").TextAlign = HorizontalAlignment.Right

        Lsv_CajerosT.Columns.Add("Concepto")
        Lsv_CajerosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_CajerosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_CajerosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesC.Columns.Add("Tipo")
        lsv_EnvasesC.Columns.Add("Numero Envase")

        'Pestaña Morralla
        Lsv_Morralla.Columns.Add("Remision")
        Lsv_Morralla.Columns.Add("FechaEntrada")
        Lsv_Morralla.Columns.Add("Moneda").TextAlign = HorizontalAlignment.Right
        Lsv_Morralla.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Morralla.Columns.Add("Envase").TextAlign = HorizontalAlignment.Right

        Lsv_MorrallaT.Columns.Add("Concepto")
        Lsv_MorrallaT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_MorrallaT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_MorrallaT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesM.Columns.Add("Tipo")
        lsv_EnvasesM.Columns.Add("Numero Envase")

        'Pestaña Clasificados
        Lsv_Clasificados.Columns.Add("Remision")
        Lsv_Clasificados.Columns.Add("FechaEntrada")
        Lsv_Clasificados.Columns.Add("Moneda").TextAlign = HorizontalAlignment.Right
        Lsv_Clasificados.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Clasificados.Columns.Add("Envase").TextAlign = HorizontalAlignment.Right

        Lsv_ClasificadosT.Columns.Add("Concepto")
        Lsv_ClasificadosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_ClasificadosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_ClasificadosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesCl.Columns.Add("Tipo")
        lsv_EnvasesCl.Columns.Add("Numero Envase")

        'Pestaña Nóminas
        Lsv_Nominas.Columns.Add("Remision")
        Lsv_Nominas.Columns.Add("FechaEntrada")
        Lsv_Nominas.Columns.Add("Moneda").TextAlign = HorizontalAlignment.Right
        Lsv_Nominas.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Nominas.Columns.Add("Envase").TextAlign = HorizontalAlignment.Right

        Lsv_NominasT.Columns.Add("Concepto")
        Lsv_NominasT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_NominasT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_NominasT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesNom.Columns.Add("Tipo")
        lsv_EnvasesNom.Columns.Add("Numero Envase")
    End Sub

    Private Sub Calcula(Optional ByVal SoloChk As Boolean = False)
        Dim Elemento As ListViewItem

        If TabPage.SelectedTab Is Procesos Then

            If Lsv_Procesos.Items.Count > 0 Then

                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                If SoloChk = False Then

                    For Each Elemento In Lsv_Procesos.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Procesos.Items.Count
                Else

                    For Each Elemento In Lsv_Procesos.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Procesos.CheckedItems.Count
                End If

                tbx_TotalEnvases = Envases

            End If

        End If

        If TabPage.SelectedTab Is Cajas Then

            If Lsv_Cajeros.Items.Count > 0 Then

                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                If SoloChk = False Then

                    For Each Elemento In Lsv_Cajeros.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Cajeros.Items.Count
                Else

                    For Each Elemento In Lsv_Cajeros.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Cajeros.CheckedItems.Count
                End If

                tbx_TotalEnvases = Envases

            End If

        End If

        If TabPage.SelectedTab Is Morralla Then

            If Lsv_Morralla.Items.Count > 0 Then

                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                If SoloChk = False Then

                    For Each Elemento In Lsv_Morralla.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Morralla.Items.Count
                Else

                    For Each Elemento In Lsv_Morralla.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Morralla.CheckedItems.Count
                End If

                tbx_TotalEnvases = Envases

            End If

        End If

        If TabPage.SelectedTab Is Clasificados Then

            If Lsv_Clasificados.Items.Count > 0 Then

                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                If SoloChk = False Then

                    For Each Elemento In Lsv_Clasificados.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Clasificados.Items.Count
                Else

                    For Each Elemento In Lsv_Clasificados.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Clasificados.CheckedItems.Count
                End If

                tbx_TotalEnvases = Envases

            End If

        End If

        If TabPage.SelectedTab Is Tab_Nominas Then

            If Lsv_Nominas.Items.Count > 0 Then

                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                If SoloChk = False Then

                    For Each Elemento In Lsv_Nominas.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Nominas.Items.Count
                Else

                    For Each Elemento In Lsv_Nominas.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(9).Text
                    Next
                    tbx_TotalRemisiones = Lsv_Nominas.CheckedItems.Count
                End If

                tbx_TotalEnvases = Envases

            End If

        End If

    End Sub

    Private Sub LLenaLsv()

        If cmb_Caja.SelectedValue <> 0 Then

            If BanderA = True Then

                Call cn_Recepcion.fn_DevolucionResguardoLlenalista(Lsv_Procesos, cmb_Caja.SelectedValue, 5)
                Call fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                Lsv_Procesos.CheckBoxes = True

                Call cn_Recepcion.fn_DevolucionResguardoLlenalista(Lsv_Cajeros, cmb_Caja.SelectedValue, 8)
                Call fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                Lsv_Cajeros.CheckBoxes = True

                Call cn_Recepcion.fn_DevolucionResguardoLlenalista(Lsv_Morralla, cmb_Caja.SelectedValue, 6)
                Call fn_TotalesListView(Lsv_Morralla, Lsv_MorrallaT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                Lsv_Morralla.CheckBoxes = True

                Call cn_Recepcion.fn_DevolucionResguardoLlenalista(Lsv_Clasificados, cmb_Caja.SelectedValue, 7)
                Call fn_TotalesListView(Lsv_Clasificados, Lsv_ClasificadosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                Lsv_Clasificados.CheckBoxes = True

                Call cn_Recepcion.fn_DevolucionResguardoLlenalista(Lsv_Nominas, cmb_Caja.SelectedValue, 9)
                Call fn_TotalesListView(Lsv_Nominas, Lsv_NominasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                Lsv_Nominas.CheckBoxes = True

                Call Calcula()
                Lbl_RegistrosP.Text = "Registros: " & Lsv_Procesos.Items.Count
                Lbl_RegistrosC.Text = "Registros: " & Lsv_Cajeros.Items.Count
                Lbl_RegistrosM.Text = "Registros: " & Lsv_Morralla.Items.Count
                Lbl_RegistrosCl.Text = "Registros: " & Lsv_Clasificados.Items.Count
                Lbl_RegistrosN.Text = "Registros: " & Lsv_Nominas.Items.Count
            End If
        End If


    End Sub

    Private Sub cmb_Caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Caja.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LLenaLsv()
    End Sub

    Private Sub btn_Devolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolucion.Click
        SegundosDesconexion = 0

        Call Calcula(True)
        If TabPage.SelectedTab Is Procesos Then

            If cn_Recepcion.fn_DevolucionResguardo_Guardar(Lsv_Procesos, tbx_TotalRemisiones, tbx_TotalEnvases, 12) = True Then
                MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        If TabPage.SelectedTab Is Cajas Then

            If cn_Recepcion.fn_DevolucionResguardo_Guardar(Lsv_Cajeros, tbx_TotalRemisiones, tbx_TotalEnvases, 13) = True Then
                MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        If TabPage.SelectedTab Is Morralla Then

            If cn_Recepcion.fn_DevolucionResguardo_Guardar(Lsv_Morralla, tbx_TotalRemisiones, tbx_TotalEnvases, 15) = True Then
                MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        If TabPage.SelectedTab Is Clasificados Then

            If cn_Recepcion.fn_DevolucionResguardo_Guardar(Lsv_Clasificados, tbx_TotalRemisiones, tbx_TotalEnvases, 14) = True Then
                MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        If TabPage.SelectedTab Is Tab_Nominas Then

            If cn_Recepcion.fn_DevolucionResguardo_Guardar(Lsv_Nominas, tbx_TotalRemisiones, tbx_TotalEnvases, 16) = True Then
                MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        Call LLenaLsv()
        btn_Devolucion.Enabled = False

    End Sub

    Private Sub TabPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Calcula()
    End Sub

    Private Sub Lsv_Procesos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Procesos.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Procesos.CheckedItems.Count > 0 Then
            btn_Devolucion.Enabled = True
        Else
            btn_Devolucion.Enabled = False
        End If
    End Sub

    Private Sub Lsv_Caja_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Cajeros.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Cajeros.CheckedItems.Count > 0 Then
            btn_Devolucion.Enabled = True
        Else
            btn_Devolucion.Enabled = False
        End If
    End Sub

    Private Sub Lsv_Morralla_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Morralla.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Morralla.CheckedItems.Count > 0 Then
            btn_Devolucion.Enabled = True
        Else
            btn_Devolucion.Enabled = False
        End If
    End Sub

    Private Sub Lsv_Clasificados_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Clasificados.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Clasificados.CheckedItems.Count > 0 Then
            btn_Devolucion.Enabled = True
        Else
            btn_Devolucion.Enabled = False
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Lsv_Nominas_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Nominas.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Nominas.CheckedItems.Count > 0 Then
            btn_Devolucion.Enabled = True
        Else
            btn_Devolucion.Enabled = False
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarP.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Procesos, Remision, 0)
            tbx_BuscarP.Focus()
            tbx_BuscarP.SelectAll()
        End If

        If tbx_BuscarCaj.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Cajeros, Remision, 0)
            tbx_BuscarCaj.Focus()
            tbx_BuscarCaj.SelectAll()
        End If

        If tbx_BuscarMor.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Morralla, Remision, 0)
            tbx_BuscarMor.Focus()
            tbx_BuscarMor.SelectAll()
        End If

        If tbx_BuscarCla.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Clasificados, Remision, 0)
            tbx_BuscarCla.Focus()
            tbx_BuscarCla.SelectAll()
        End If

        If tbx_BuscarNom.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Nominas, Remision, 0)
            tbx_BuscarNom.Focus()
            tbx_BuscarNom.SelectAll()
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

        If tbx_BuscarP.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Procesos.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarCaj.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Cajeros.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarMor.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Morralla.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarCla.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Clasificados.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarNom.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Nominas.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If


    End Sub

    Private Sub tbx_BuscarP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarP.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Procesos, tbx_BuscarP) Then
                tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Procesos, cmb_Caja.SelectedValue, 5)
                Buscar_Envase(tbx_BuscarP.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarP.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Procesos, tbx_BuscarP) Then
            tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Procesos, cmb_Caja.SelectedValue, 5)
            Buscar_Envase(tbx_BuscarP.Text)
        End If
    End Sub

    Private Sub Lsv_Procesos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Procesos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesP.Items.Clear()

        If Lsv_Procesos.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesP, Lsv_Procesos.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarCaj_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarCaj.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Cajeros, tbx_BuscarCaj) Then
                tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Cajeros, cmb_Caja.SelectedValue, 8)
                Buscar_Envase(tbx_BuscarCaj.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarCaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCaj.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Cajeros, tbx_BuscarCaj) Then
            tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Cajeros, cmb_Caja.SelectedValue, 8)
            Buscar_Envase(tbx_BuscarCaj.Text)
        End If

    End Sub

    Private Sub Lsv_Cajeros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Cajeros.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesC.Items.Clear()

        If lsv_EnvasesC.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesC, Lsv_Procesos.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarMor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarMor.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Morralla, tbx_BuscarMor) Then
                tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Morralla, cmb_Caja.SelectedValue, 6)
                Buscar_Envase(tbx_BuscarMor.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarMor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarMor.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Morralla, tbx_BuscarMor) Then
            tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Morralla, cmb_Caja.SelectedValue, 6)
            Buscar_Envase(tbx_BuscarMor.Text)
        End If
    End Sub

    Private Sub Lsv_Morralla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Morralla.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesM.Items.Clear()

        If Lsv_Morralla.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesM, Lsv_Morralla.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarCla_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarCla.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Clasificados, tbx_BuscarCla) Then
                tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Clasificados, cmb_Caja.SelectedValue, 7)
                Buscar_Envase(tbx_BuscarCla.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarCla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCla.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Clasificados, tbx_BuscarCla) Then
            tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Clasificados, cmb_Caja.SelectedValue, 7)
            Buscar_Envase(tbx_BuscarCla.Text)
        End If

    End Sub

    Private Sub Lsv_Clasificados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Clasificados.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesCl.Items.Clear()

        If Lsv_Morralla.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesCl, Lsv_Morralla.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarNom.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Nominas, tbx_BuscarNom) Then
                tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Nominas, cmb_Caja.SelectedValue, 9)
                Buscar_Envase(tbx_BuscarNom.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarNom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarNom.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Nominas, tbx_BuscarNom) Then
            tbl = cn_Recepcion.fn_DevolucionResguardoLlenalistaEnvase(Lsv_Nominas, cmb_Caja.SelectedValue, 9)
            Buscar_Envase(tbx_BuscarNom.Text)
        End If
    End Sub

    Private Sub Lsv_Nominas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Nominas.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesNom.Items.Clear()

        If Lsv_Nominas.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesNom, Lsv_Nominas.SelectedItems(0).Tag)
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