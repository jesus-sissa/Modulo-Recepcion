Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_AsignarProceso
    Public Destino As Char
    Dim Session_Activa As Integer
    Dim tbl As DataTable

    Private Sub frm_AsignarProceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbl = New DataTable
        cmb_Caja.Actualizar()
        cmb_Cia.Actualizar()

        lsv_Servicios.Columns.Add("Remision")
        lsv_Servicios.Columns.Add("Caja")
        lsv_Servicios.Columns.Add("Cliente")
        lsv_Servicios.Columns.Add("Importe")
        lsv_Servicios.Columns.Add("Envases")

        lsv_ServiciosD.Columns.Add("Concepto")
        lsv_ServiciosD.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        lsv_ServiciosD.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        lsv_ServiciosD.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        Lsv_Retenidos.Columns.Add("Remision")
        Lsv_Retenidos.Columns.Add("Caja")
        Lsv_Retenidos.Columns.Add("Cliente")
        Lsv_Retenidos.Columns.Add("Importe")
        Lsv_Retenidos.Columns.Add("Envases")

        Lsv_RetenidosT.Columns.Add("Concepto")
        Lsv_RetenidosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_RetenidosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_RetenidosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        lsv_EnvasesSer.Columns.Add("Tipo")
        lsv_EnvasesSer.Columns.Add("Numero Envase")

        lsv_EnvasesSer.Columns.Add("Tipo")
        lsv_EnvasesRet.Columns.Add("Numero Envase")

        If Destino = "M" Then
            btn_Asignar.Text = "Asignar a Morralla"
            Me.Text = "Asignar a Morralla"

        End If
        btn_Morralla.Visible = MorrallaRecibeRuta
    End Sub

    Private Sub Calcula(Optional ByVal SoloChk As Boolean = False)
        Dim Elemento As ListViewItem
        tbx_TotalRemisiones.Text = 0 'FormatNumber("0")
        tbx_TotalEnvases.Text = 0 'FormatNumber("0")
        tbx_TotalImporte.Text = FormatCurrency("0.0")
        If Tab_Servicios.SelectedTab Is Servicios Then
            If lsv_Servicios.Items.Count > 0 Then
                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0
                If SoloChk = False Then
                    For Each Elemento In lsv_Servicios.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = lsv_Servicios.Items.Count 'FormatNumber(Lsv_Boveda.Items.Count)
                Else
                    For Each Elemento In lsv_Servicios.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = lsv_Servicios.CheckedItems.Count 'FormatNumber(Lsv_Boveda.CheckedItems.Count)
                End If

                tbx_TotalEnvases.Text = Envases ' FormatNumber(Envases)
                tbx_TotalImporte.Text = FormatCurrency(Importe)
            End If
        End If
        If Tab_Servicios.SelectedTab Is Retenidos Then
            If Lsv_Retenidos.Items.Count > 0 Then
                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0
                If SoloChk = False Then
                    For Each Elemento In Lsv_Retenidos.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = Lsv_Retenidos.Items.Count 'FormatNumber(Lsv_Retenidos.Items.Count)
                Else
                    For Each Elemento In Lsv_Retenidos.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = Lsv_Retenidos.CheckedItems.Count 'FormatNumber(Lsv_Retenidos.CheckedItems.Count)
                End If
                tbx_TotalEnvases.Text = Envases 'FormatNumber(Envases)
                tbx_TotalImporte.Text = FormatCurrency(Importe)
            End If
        End If
    End Sub

    Private Sub LLenarLista()
        btn_Facturacion.Enabled = False
        btn_Asignar.Enabled = False
        btn_Morralla.Enabled = False
        btn_Devolucion.Enabled = False
        btn_CambiarRemision.Enabled = False
        lsv_Servicios.Items.Clear()
        lbl_RegistrosS.Text = "Registros: 0"
        lsv_ServiciosD.Items.Clear()
        Lsv_Retenidos.Items.Clear()
        lbl_RegistrosR.Text = "Registros: 0"
        Lsv_RetenidosT.Items.Clear()
        tbx_NuevaRemision.Clear()
        tbx_TotalEnvases.Clear()
        tbx_TotalImporte.Clear()
        tbx_TotalRemisiones.Clear()
        lsv_EnvasesRet.Items.Clear()
        lsv_EnvasesSer.Items.Clear()

        If cmb_Caja.SelectedValue = 0 Then Exit Sub
        If cmb_Cia.Enabled And cmb_Cia.SelectedValue = 0 Then Exit Sub

        'depto Registro =B boveda 24/05/2014
        cn_Recepcion.fn_AsignarProcesoLlenalista(lsv_Servicios, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
        lsv_Servicios.CheckBoxes = True

        cn_Recepcion.fn_AsignarProcesoRetenidosLlenalista(Lsv_Retenidos, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
        Lsv_Retenidos.CheckBoxes = True
       
        Dim Col() As Integer = {1, 3, 4}
        Dim Nom() As String = {"Remisiones", "Importe", "Envases"}
        Dim Frm() As String = {"g", "n", "g"}
        Dim Fnc() As FuncionesGlobales.Func = {FuncionesGlobales.Func.Conteo, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma}

        FuncionesGlobales.fn_TotalesListView(lsv_Servicios, lsv_ServiciosD, Col, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        FuncionesGlobales.fn_TotalesListView(Lsv_Retenidos, Lsv_RetenidosT, Col, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call Calcula(True)
        lbl_RegistrosS.Text = "Registros: " & lsv_Servicios.Items.Count
        lbl_RegistrosR.Text = "Registros: " & Lsv_Retenidos.Items.Count

    End Sub

    Private Sub cmb_Caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Caja.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LLenarLista()
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0
        Call LLenarLista()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        cmb_Cia.SelectedValue = 0
        If chk_Todos.Checked = True Then
            cmb_Cia.Enabled = False
        Else
            cmb_Cia.Enabled = True
        End If
        Call LLenarLista()
    End Sub

    Private Function Validar() As Boolean
        If Tab_Servicios.SelectedTab Is Servicios Then
            Return lsv_Servicios.CheckedItems.Count > 0
        ElseIf Tab_Servicios.SelectedTab Is Retenidos Then
            Return Lsv_Retenidos.CheckedItems.Count > 0
        Else
            Return False
        End If
    End Function

    Private Sub btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar.Click
        SegundosDesconexion = 0
        Call Calcula(True)
        If Tab_Servicios.SelectedTab Is Servicios Then
            Session_Activa = GetSession()
            If Session_Activa = 0 Then
                MsgBox("No es posible asignar Servicios ya que no hay Sesion abierta en Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If fn_AsignarProceso_ValidaStatus(lsv_Servicios) = False Then
                MsgBox("Algunas de las Remisiones Seleccionadas ya no estan disponibles. Se actualizará la lista.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenarLista()
                Exit Sub
            End If
            'Destino M si se asignará a Morralla o P si es para Proceso
            If fn_AsignarProceso_Guardar_Nuevo(lsv_Servicios, tbx_TotalRemisiones.Text, tbx_TotalEnvases.Text, Destino) = True Then
                MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenarLista()
            Else
                If Destino = "P" Then
                    MsgBox("Ocurrió un error al intentar asignar los Servicios a Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
                ElseIf Destino = "M" Then
                    MsgBox("Ocurrió un error al intentar asignar los Servicios a Morralla.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Exit Sub
            End If
        End If
        If Tab_Servicios.SelectedTab Is Retenidos Then
            Dim TipoLote As Integer = 26 '26 Bov -Proc
            If Destino = "M" Then TipoLote = 28 '28 boveda a morralla

            If fn_AsignarProceso_Guardar(Lsv_Retenidos, tbx_TotalRemisiones.Text, tbx_TotalEnvases.Text, TipoLote) = True Then
                MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenarLista()
            Else
                MsgBox("Ocurrió un error al intentar asignar los Servicios a Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cbx_Todos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_Todos.Click
        SegundosDesconexion = 0
        For Each it As ListViewItem In lsv_Servicios.Items
            it.Checked = cbx_Todos.Checked
        Next
    End Sub

    Private Sub Tab_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Asignar.Enabled = Validar()
        btn_Facturacion.Enabled = btn_Asignar.Enabled
    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Servicios.ItemChecked
        SegundosDesconexion = 0
        Call Calcula(True)
        btn_Asignar.Enabled = Validar()
        btn_Facturacion.Enabled = btn_Asignar.Enabled
        btn_Morralla.Enabled = lsv_Servicios.CheckedItems.Count > 0
        btn_Devolucion.Enabled = lsv_Servicios.CheckedItems.Count > 0
    End Sub

    Private Sub Lsv_Retenidos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Retenidos.ItemChecked
        SegundosDesconexion = 0
        Call Calcula(True)
        btn_Asignar.Enabled = Validar()
        btn_Facturacion.Enabled = btn_Asignar.Enabled
    End Sub

    Private Sub lsv_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_CambiarRemision.Enabled = lsv_Servicios.SelectedItems.Count > 0
        tbx_NuevaRemision.Enabled = lsv_Servicios.SelectedItems.Count > 0

        lsv_EnvasesSer.Items.Clear()

        If lsv_Servicios.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesSer, lsv_Servicios.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub btn_CambiarRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CambiarRemision.Click
        SegundosDesconexion = 0

        If tbx_NuevaRemision.Text = "" Then
            MsgBox("Número de Remisión Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NuevaRemision.Focus()
            Exit Sub
        End If
        If CLng(tbx_NuevaRemision.Text) = 0 Then
            MsgBox("Número de Remisión Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NuevaRemision.Focus()
            Exit Sub
        End If
        Dim Observa As String = ""
        Dim frm As New frm_Observaciones
        frm.ShowDialog()
        Observa = frm.Observaciones
        frm.Dispose()
        If Observa = "-1" Then
            MsgBox("No se realizó el cambio.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        'Sacar el Id_Cia de la Remisión Seleccionada
        Dim dt As DataTable = fn_RemisionRead(CLng(lsv_Servicios.SelectedItems(0).SubItems(6).Text))
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim Cia As Integer = CInt(dt.Rows(0)("Id_Cia"))
                If fn_Remision_Existe(tbx_NuevaRemision.Text, Cia) Then
                    MsgBox("El Número de Remisión indicado ya existe, capture otro por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NuevaRemision.SelectAll()
                    tbx_NuevaRemision.Focus()
                    Exit Sub
                End If
                'Cambiar el Número de la Remisión Seleccionada en la lista por el del tbx_NuevaRemision
                If fn_RemisionUpdateNumero(CLng(lsv_Servicios.SelectedItems(0).SubItems(6).Text), CLng(tbx_NuevaRemision.Text.Trim), Observa) Then
                    MsgBox("Remisión cambiada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    'Guardar en Bitacora
                    fn_GuardaBitacora(13, "REMISION: " & lsv_Servicios.SelectedItems(0).Text & " CIA_PROP: " & Cia & " -> REMISION: " & tbx_NuevaRemision.Text, CInt(lsv_Servicios.SelectedItems(0).SubItems(6).Text))
                    Call LLenarLista()
                    tbx_NuevaRemision.Clear()
                Else
                    MsgBox("Ocurrió un error al intentar cambiar el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                'No se encontró
                MsgBox("Ocurrió un error al intentar consultar los datos de la Remisión Seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            'No se encontró
            MsgBox("Ocurrió un error al intentar consultar los datos de la Remisión Seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Morralla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Morralla.Click
        SegundosDesconexion = 0

        If lsv_Servicios.CheckedItems.Count = 0 Then Exit Sub
        If fn_AsignarMorralla_Guardar(lsv_Servicios) = True Then
            MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            btn_Asignar.Enabled = False
            btn_Morralla.Enabled = False
            btn_Facturacion.Enabled = btn_Asignar.Enabled
            'chk_Todos.Checked = False
            Call LLenarLista()
        Else
            MsgBox("Ocurrió un error al intentar asignar los Servicios a Morralla.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

    End Sub

    Private Sub btn_Devolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolucion.Click
        SegundosDesconexion = 0

        If lsv_Servicios.CheckedItems.Count = 0 Then Exit Sub

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.Max_Caracteres_Obs = 150
        frm.ShowDialog()
        If Not frm.Firma Then Exit Sub

        If fn_AsignarDevolucion_Guardar(lsv_Servicios, frm.Observaciones) = True Then
            MsgBox("Los Servicios se marcaron correctamente para Devolución.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LLenarLista()
        Else
            MsgBox("Ocurrió un error al intentar marcar los servicios para Devolución.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub

    Private Sub Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Servicios.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Facturacion.Click
        SegundosDesconexion = 0
        Dim FechaActual As DateTime = DateTime.Now

        If lsv_Servicios.Items.Count = 0 Then
            MsgBox("No existen Remisiones para guardar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fn_AsignarProceso_ValidaStatus(lsv_Servicios) = False Then
            MsgBox("Algunas de las Remisiones Seleccionadas ya no estan disponibles. Se actualizará la lista.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LLenarLista()
            Exit Sub
        End If

        If fn_AsignarProceso_ValidaStatus(lsv_Servicios) = False Then
            MsgBox("Algunas de las Remisiones Seleccionadas ya no estan disponibles. Se actualizará la lista.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LLenarLista()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim ct As Integer = cn_Recepcion.fn_RecRutasExternas_GuardarXRemision(1, 0, lsv_Servicios, FechaActual, 0)

        If ct = -1 Then
            MsgBox("Ocurrió un error al grabar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Me.Cursor = Cursors.Default

        If ct = -2 Then
            MsgBox("Se grabaron los servicios correctamente. Los registros para Facturación no se pudieron Generar.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        ElseIf ct > 0 Then
            MsgBox(ct & " Servicio(s) grabado(s) correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        ElseIf ct = 0 Then
            MsgBox("No se afectó ningun servicio, Verifique estatus de la remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If
        Call LLenarLista()

    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarSer.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Servicios, Remision, 0)
            tbx_BuscarSer.Focus()
            tbx_BuscarSer.SelectAll()
        End If

        If tbx_BuscarRet.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Retenidos, Remision, 0)
            tbx_BuscarRet.Focus()
            tbx_BuscarRet.SelectAll()
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

        If tbx_BuscarSer.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Servicios.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarRet.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Retenidos.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If


    End Sub

    Private Sub Lsv_Retenidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Retenidos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesRet.Items.Clear()

        If lsv_EnvasesRet.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesRet, Lsv_Retenidos.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarRet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarRet.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Retenidos, tbx_BuscarRet) Then
                tbl = cn_Recepcion.fn_AsignarProcesoRetenidosLlenalistaEnvase(Lsv_Retenidos, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
                Buscar_Envase(tbx_BuscarRet.Text)
            End If
        End If
    End Sub

    Private Sub tbx_BuscarSer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarSer.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Servicios, tbx_BuscarSer) Then
                tbl = cn_Recepcion.fn_AsignarProcesoLlenalistaEnvase(lsv_Servicios, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
                Buscar_Envase(tbx_BuscarSer.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarSer.Click
        If Not BuscarRemision(lsv_Servicios, tbx_BuscarSer) Then
            tbl = cn_Recepcion.fn_AsignarProcesoLlenalistaEnvase(lsv_Servicios, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
            Buscar_Envase(tbx_BuscarSer.Text)
        End If
    End Sub

    Private Sub btn_BuscarRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarRet.Click
        If Not BuscarRemision(Lsv_Retenidos, tbx_BuscarRet) Then
            tbl = cn_Recepcion.fn_AsignarProcesoRetenidosLlenalistaEnvase(Lsv_Retenidos, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
            Buscar_Envase(tbx_BuscarRet.Text)
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As ListView, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv.SelectedItems(0).Index + 1
        End If
        'fn_Buscar_enListView(lsv_Boveda, tbx_BuscarBoveda.Text, 0, Fila_Inicio)
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function
End Class