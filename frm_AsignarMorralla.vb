Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_AsignarMorralla

    Dim Session_Activa As Integer

    Private Sub frm_AsignarMorralla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Caja.Actualizar()
        cmb_Cia.Actualizar()

        BanderA = True

        Lsv_Boveda.Columns.Add("Remision")
        Lsv_Boveda.Columns.Add("Caja")
        Lsv_Boveda.Columns.Add("Cliente")
        Lsv_Boveda.Columns.Add("Importe")
        Lsv_Boveda.Columns.Add("Envases")
        FuncionesGlobales.fn_Columna(Lsv_Boveda, 10, 10, 10, 10, 10, 0, 0, 0, 0, 0)

        Lsv_BovedaT.Columns.Add("Concepto")
        Lsv_BovedaT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        Lsv_Retenidos.Columns.Add("Remision")
        Lsv_Retenidos.Columns.Add("Caja")
        Lsv_Retenidos.Columns.Add("Cliente")
        Lsv_Retenidos.Columns.Add("Importe")
        Lsv_Retenidos.Columns.Add("Envases")
        FuncionesGlobales.fn_Columna(Lsv_Retenidos, 10, 10, 10, 10, 10, 0, 0, 0, 0, 0)

        Lsv_RetenidosT.Columns.Add("Concepto")
        Lsv_RetenidosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_RetenidosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_RetenidosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub Calcula(Optional ByVal SoloChk As Boolean = False)
        Dim Elemento As ListViewItem
        tbx_TotalRemisiones.Text = 0 'FormatNumber("0")
        tbx_TotalEnvases.Text = 0 'FormatNumber("0")
        tbx_TotalImporte.Text = FormatCurrency("0.0")
        If Tab_Servicios.SelectedTab Is Servicios Then
            If Lsv_Boveda.Items.Count > 0 Then
                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0
                If SoloChk = False Then
                    For Each Elemento In Lsv_Boveda.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = Lsv_Boveda.Items.Count 'FormatNumber(Lsv_Boveda.Items.Count)
                Else
                    For Each Elemento In Lsv_Boveda.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += Elemento.SubItems(4).Text
                    Next
                    tbx_TotalRemisiones.Text = Lsv_Boveda.CheckedItems.Count 'FormatNumber(Lsv_Boveda.CheckedItems.Count)
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

    Private Sub LLenaLsv()
        btn_Asignar.Enabled = False
        btn_Morralla.Enabled = False
        btn_Devolucion.Enabled = False
        btn_CambiarRemision.Enabled = False
        Lsv_Boveda.Items.Clear()
        lbl_RegistrosS.Text = "Registros: 0"
        Lsv_BovedaT.Items.Clear()
        Lsv_Retenidos.Items.Clear()
        lbl_RegistrosR.Text = "Registros: 0"
        Lsv_RetenidosT.Items.Clear()
        tbx_NuevaRemision.Clear()
        tbx_TotalEnvases.Clear()
        tbx_TotalImporte.Clear()
        tbx_TotalRemisiones.Clear()
        If cmb_Caja.SelectedValue = 0 Then Exit Sub
        If cmb_Cia.Enabled And cmb_Cia.SelectedValue = 0 Then Exit Sub

        If BanderA = True Then
            'depto registro = M morralla
            'este será parametrizado se usa 'B' de momento
            cn_Recepcion.fn_AsignarProcesoLlenalista(Lsv_Boveda, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
            Lsv_Boveda.CheckBoxes = True
            Lsv_Boveda.Columns(0).TextAlign = HorizontalAlignment.Right
            Lsv_Boveda.Columns(3).TextAlign = HorizontalAlignment.Right
            Lsv_Boveda.Columns(4).TextAlign = HorizontalAlignment.Right

            cn_Recepcion.fn_AsignarProcesoRetenidosLlenalista(Lsv_Retenidos, cmb_Caja.SelectedValue, cmb_Cia.SelectedValue, "B")
            Lsv_Retenidos.CheckBoxes = True
            Lsv_Retenidos.Columns(0).TextAlign = HorizontalAlignment.Right
            Lsv_Retenidos.Columns(3).TextAlign = HorizontalAlignment.Right
            Lsv_Retenidos.Columns(4).TextAlign = HorizontalAlignment.Right

            Dim Col() As Integer = {1, 3, 4}
            Dim Nom() As String = {"Remisiones", "Importe", "Envases"}
            Dim Frm() As String = {"g", "n", "g"}
            Dim Fnc() As FuncionesGlobales.Func = {FuncionesGlobales.Func.Conteo, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma}
            FuncionesGlobales.fn_TotalesListView(Lsv_Boveda, Lsv_BovedaT, Col, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
            FuncionesGlobales.fn_TotalesListView(Lsv_Retenidos, Lsv_RetenidosT, Col, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
            Call Calcula(True)
            lbl_RegistrosS.Text = "Registros: " & Lsv_Boveda.Items.Count
            lbl_RegistrosR.Text = "Registros: " & Lsv_Retenidos.Items.Count
        End If
    End Sub

    Private Sub cmb_Caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Caja.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LLenaLsv()
    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LLenaLsv()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        cmb_Cia.SelectedValue = 0
        If chk_Todos.Checked = True Then
            cmb_Cia.Enabled = False
        Else
            cmb_Cia.Enabled = True
        End If
        Call LLenaLsv()
    End Sub

    Private Function Validar() As Boolean
        If Tab_Servicios.SelectedTab Is Servicios Then
            Return Lsv_Boveda.CheckedItems.Count > 0
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

            If fn_AsignarProceso_ValidaStatus(Lsv_Boveda) = False Then
                MsgBox("Algunas de las Remisiones Seleccionadas ya no estan disponibles. Se actualizará la lista.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenaLsv()
                Exit Sub
            End If

            If fn_AsignarProceso_Guardar_Nuevo(Lsv_Boveda, tbx_TotalRemisiones.Text, tbx_TotalEnvases.Text, "M") = True Then
                MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenaLsv()
            Else
                MsgBox("Ocurrió un error al intentar asignar los Servicios a Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        If Tab_Servicios.SelectedTab Is Retenidos Then
            ' 28 boveda a morralla
            If fn_AsignarProceso_Guardar(Lsv_Retenidos, tbx_TotalRemisiones.Text, tbx_TotalEnvases.Text, 28) = True Then
                MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LLenaLsv()
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

        For Each it As ListViewItem In Lsv_Boveda.Items
            it.Checked = cbx_Todos.Checked
        Next
    End Sub

    Private Sub Tab_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Servicios.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Asignar.Enabled = Validar()
    End Sub

    Private Sub Lsv_Boveda_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Boveda.ItemChecked
        SegundosDesconexion = 0

        Call Calcula(True)
        btn_Asignar.Enabled = Validar()
        btn_Morralla.Enabled = Lsv_Boveda.CheckedItems.Count > 0
        btn_Devolucion.Enabled = Lsv_Boveda.CheckedItems.Count > 0
    End Sub

    Private Sub Lsv_Retenidos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Retenidos.ItemChecked
        SegundosDesconexion = 0

        Call Calcula(True)
        btn_Asignar.Enabled = Validar()
    End Sub

    Private Sub Lsv_Boveda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Boveda.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_CambiarRemision.Enabled = Lsv_Boveda.SelectedItems.Count > 0
        tbx_NuevaRemision.Enabled = Lsv_Boveda.SelectedItems.Count > 0
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
        Dim dt As DataTable = fn_RemisionRead(CLng(Lsv_Boveda.SelectedItems(0).SubItems(6).Text))
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
                If fn_RemisionUpdateNumero(CLng(Lsv_Boveda.SelectedItems(0).SubItems(6).Text), CLng(tbx_NuevaRemision.Text), Observa) Then
                    MsgBox("Remisión cambiada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    'Guardar en Bitacora
                    fn_GuardaBitacora(13, "REMISION: " & Lsv_Boveda.SelectedItems(0).Text & " CIA_PROP: " & Cia & " -> REMISION: " & tbx_NuevaRemision.Text, CInt(Lsv_Boveda.SelectedItems(0).SubItems(6).Text))
                    Call LLenaLsv()
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
        'SegundosDesconexion = 0

        'If Lsv_Boveda.CheckedItems.Count = 0 Then Exit Sub
        'If fn_AsignarMorralla_Guardar(Lsv_Boveda) = True Then
        '    MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        '    btn_Asignar.Enabled = False
        '    btn_Morralla.Enabled = False
        '    'chk_Todos.Checked = False
        '    Call LLenaLsv()
        'Else
        '    MsgBox("Ocurrió un error al intentar asignar los Servicios a Morralla.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    Exit Sub
        'End If

    End Sub

    Private Sub btn_Devolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolucion.Click
        SegundosDesconexion = 0

        If Lsv_Boveda.CheckedItems.Count = 0 Then Exit Sub
        'If fn_AsignarDevolucion_Guardar(Lsv_Boveda, 2, 4) = True Then
        '    fn_GuardaBitacora(31, "REMISION: " & Lsv_Boveda.SelectedItems(0).Text & " CLIENTE: " & Lsv_Boveda.SelectedItems(0).SubItems(1).Text, CInt(Lsv_Boveda.SelectedItems(0).SubItems(6).Text))
        '    MsgBox("Los Servicios se asignaron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

        '    'chk_Todos.Checked = False
        '    Call LLenaLsv()
        'Else
        '    MsgBox("Ocurrió un error al intentar realizar la devolución.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    Exit Sub
        'End If
    End Sub

    Private Sub Servicios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Servicios.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class