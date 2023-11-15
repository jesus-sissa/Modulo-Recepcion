Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_ConsultaSaldo
    Private TotalRemisiones As Integer = 0
    Private TotalImporte As Integer = 0
    Private TotalEnvases As Integer = 0
    Private Columnas() As Integer = {1, 5}
    Private Nombres() As String = {"Remisiones", "Importe"}
    Private Formatos() As String = {"g", "n"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma}

    Private Sub frm_ConsultaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "T", 0)
        cmb_Boveda.Actualizar()
        BanderA = True

        'Pestaña Custodias
        Lsv_Custodias.Columns.Add("FechaEntrada")
        Lsv_Custodias.Columns.Add("Hora")
        Lsv_Custodias.Columns.Add("Remision").TextAlign = HorizontalAlignment.Right
        Lsv_Custodias.Columns.Add("Origen")
        Lsv_Custodias.Columns.Add("Destino")
        Lsv_Custodias.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Custodias.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        Lsv_CustodiasT.Columns.Add("Concepto")
        Lsv_CustodiasT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_CustodiasT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        'Pestaña Procesos
        Lsv_Procesos.Columns.Add("FechaEntrada")
        Lsv_Procesos.Columns.Add("Hora")
        Lsv_Procesos.Columns.Add("Remision").TextAlign = HorizontalAlignment.Right
        Lsv_Procesos.Columns.Add("Caja")
        Lsv_Procesos.Columns.Add("Tipo")
        Lsv_Procesos.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        Lsv_ProcesosT.Columns.Add("Concepto")
        Lsv_ProcesosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_ProcesosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        'Pestaña Cajeros
        Lsv_Cajeros.Columns.Add("FechaEntrada")
        Lsv_Cajeros.Columns.Add("Hora")
        Lsv_Cajeros.Columns.Add("Remision").TextAlign = HorizontalAlignment.Right
        Lsv_Cajeros.Columns.Add("Origen")
        Lsv_Cajeros.Columns.Add("Destino")
        Lsv_Cajeros.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        Lsv_CajerosT.Columns.Add("Concepto")
        Lsv_CajerosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_CajerosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        'Pestaña Resguardos
        Lsv_Resguardos.Columns.Add("FechaEntrada")
        Lsv_Resguardos.Columns.Add("Hora")
        Lsv_Resguardos.Columns.Add("Remision").TextAlign = HorizontalAlignment.Right
        Lsv_Resguardos.Columns.Add("Caja")
        Lsv_Resguardos.Columns.Add("Tipo")
        Lsv_Resguardos.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        Lsv_ResguardosT.Columns.Add("Concepto")
        Lsv_ResguardosT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_ResguardosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        'Pestaña Materiales
        Lsv_Materiales.Columns.Add("FechaEntrada")
        Lsv_Materiales.Columns.Add("Hora")
        Lsv_Materiales.Columns.Add("Remision").TextAlign = HorizontalAlignment.Right
        Lsv_Materiales.Columns.Add("Destino")
        Lsv_Materiales.Columns.Add("Tipo")
        Lsv_Materiales.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        Lsv_MaterialesT.Columns.Add("Concepto")
        Lsv_MaterialesT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_MaterialesT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right

        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Boveda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Boveda.SelectedIndexChanged
        SegundosDesconexion = 0

        Call LlenaListView()
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Todos.CheckedChanged
        SegundosDesconexion = 0

        cmb_Boveda.SelectedValue = 0
        If chk_Todos.Checked Then
            cmb_Boveda.Enabled = False
            tbx_Cve_Boveda.Enabled = False
        Else
            cmb_Boveda.Enabled = True
            tbx_Cve_Boveda.Enabled = True
        End If
        Call LlenaListView()
    End Sub

    Private Sub LlenaListView()
        SegundosDesconexion = 0

        Lsv_Cajeros.Items.Clear()
        lbl_RegistrosAtm.Text = "Registros: 0"
        Lsv_CajerosT.Items.Clear()

        Lsv_Custodias.Items.Clear()
        lbl_RegistrosC.Text = "Registros: 0"
        Lsv_CustodiasT.Items.Clear()

        Lsv_Materiales.Items.Clear()
        lbl_RegistrosM.Text = "Registros: 0"
        Lsv_MaterialesT.Items.Clear()

        Lsv_Procesos.Items.Clear()
        lbl_RegistrosP.Text = "Registros: 0"
        Lsv_ProcesosT.Items.Clear()

        Lsv_Resguardos.Items.Clear()
        lbl_RegistrosRS.Text = "Reigstros: 0"
        Lsv_ResguardosT.Items.Clear()
        btn_ReemplazarRemision.Enabled = False
        btn_Baja.Enabled = False
        btn_Exportar.Enabled = False

        If BanderA = True Then
            If cmb_Boveda.Enabled Then
                If cmb_Boveda.SelectedValue = 0 Then Exit Sub
            End If
            If chk_Todos.Checked = True Then
                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1)
                Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Procesos, 2)
                Call fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Cajeros, 1, Tipop:=0)
                Call fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Resguardos, 2, Tipop:=1)
                Call fn_TotalesListView(Lsv_Resguardos, Lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaMatSaldosLlenalista(Lsv_Materiales)
                Call fn_TotalesListView(Lsv_Materiales, Lsv_MaterialesT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
            Else
                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1, cmb_Boveda.SelectedValue)
                Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Procesos, 2, cmb_Boveda.SelectedValue)
                Call fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Cajeros, 1, cmb_Boveda.SelectedValue, 0)
                Call fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Resguardos, 2, cmb_Boveda.SelectedValue, 1)
                Call fn_TotalesListView(Lsv_Resguardos, Lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

                Call cn_Recepcion.fn_ConsultaMatSaldosLlenalista(Lsv_Materiales, cmb_Boveda.SelectedValue)
                Call fn_TotalesListView(Lsv_Materiales, Lsv_MaterialesT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
            End If
            lbl_RegistrosC.Text = "Registros: " & Lsv_Custodias.Items.Count
            lbl_RegistrosP.Text = "Registros: " & Lsv_Procesos.Items.Count
            lbl_RegistrosAtm.Text = "Registros: " & Lsv_Cajeros.Items.Count
            lbl_RegistrosRS.Text = "Registros: " & Lsv_Resguardos.Items.Count
            lbl_RegistrosM.Text = "Registros: " & Lsv_Materiales.Items.Count
            Call HabilitaExportarBaja()
        End If

        If Lsv_Custodias.Columns.Count > 0 Then
            Lsv_Custodias.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_Custodias.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Custodias.Columns(6).TextAlign = HorizontalAlignment.Right
        End If
        If Lsv_Cajeros.Columns.Count > 0 Then
            Lsv_Cajeros.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_Cajeros.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Cajeros.Columns(6).TextAlign = HorizontalAlignment.Right
        End If
        If Lsv_Procesos.Columns.Count > 0 Then
            Lsv_Procesos.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_Procesos.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Procesos.Columns(6).TextAlign = HorizontalAlignment.Right
        End If
        If Lsv_Resguardos.Columns.Count > 0 Then
            Lsv_Resguardos.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_Resguardos.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Resguardos.Columns(6).TextAlign = HorizontalAlignment.Right
        End If
        If Lsv_Materiales.Columns.Count > 0 Then
            Lsv_Materiales.Columns(2).TextAlign = HorizontalAlignment.Right
            Lsv_Materiales.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Materiales.Columns(6).TextAlign = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        SegundosDesconexion = 0

        Dim Elemento As ListViewItem

        For Each Elemento In Lsv_Custodias.Items
            If tbx_Remision.Text.Trim = Elemento.SubItems(2).Text Then
                TabControl.SelectedTab = Tab_Custodias
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            Else
                Elemento.Selected = False
            End If
        Next

        For Each Elemento In Lsv_Cajeros.Items
            If tbx_Remision.Text.Trim = Elemento.SubItems(2).Text Then
                TabControl.SelectedTab = Tab_Cajeros
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            Else
                Elemento.Selected = False
            End If
        Next

        For Each Elemento In Lsv_Procesos.Items
            If tbx_Remision.Text.Trim = Elemento.SubItems(2).Text Then
                TabControl.SelectedTab = Tab_Procesos
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            Else
                Elemento.Selected = False
            End If
        Next

        For Each Elemento In Lsv_Resguardos.Items
            If tbx_Remision.Text.Trim = Elemento.SubItems(2).Text Then
                TabControl.SelectedTab = Tab_Resguardos
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            Else
                Elemento.Selected = False
            End If
        Next

        For Each Elemento In Lsv_Materiales.Items
            If tbx_Remision.Text.Trim = Elemento.SubItems(2).Text Then
                TabControl.SelectedTab = Tab_Materiales
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            Else
                Elemento.Selected = False
            End If
        Next

        MsgBox("No se encontro la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)

    End Sub

    Private Sub tbx_Remision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Btn_Buscar_Click(Btn_Buscar, e)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Lsv_Custodias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Custodias.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_CambiarRemision.Enabled = Lsv_Custodias.SelectedItems.Count > 0
        tbx_NuevaRemision.Enabled = Lsv_Custodias.SelectedItems.Count > 0
        btn_ReemplazarRemision.Enabled = Lsv_Custodias.SelectedItems.Count > 0
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
        Dim Id_Bo As Long = CLng(Lsv_Custodias.SelectedItems(0).Tag)
        Dim dt As DataTable = cn_Recepcion.fn_RemisionReadByIdBo(Id_Bo)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim Cia As Integer = CInt(dt.Rows(0)("Id_CiaProp"))
                Dim Id_Remision As Long = CLng(dt.Rows(0)("Id_Remision"))
                dt.Dispose()
                If cn_Recepcion.fn_Remision_Existe(tbx_NuevaRemision.Text, Cia) Then
                    MsgBox("El Número de Remisión indicado ya existe, capture otro por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NuevaRemision.SelectAll()
                    tbx_NuevaRemision.Focus()
                    Exit Sub
                End If
                'Cambiar el Número de la Remisión Seleccionada en la lista por el del tbx_NuevaRemision
                If cn_Recepcion.fn_RemisionUpdateNumero(Id_Remision, CLng(tbx_NuevaRemision.Text.Trim), Observa) Then
                    MsgBox("Remisión cambiada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    'Guardar en Bitacora
                    FuncionesGlobales.fn_GuardaBitacora(13, "REMISION: " & Lsv_Custodias.SelectedItems(0).SubItems(2).Text & " CIA_PROP: " & Cia & " -> REMISION: " & tbx_NuevaRemision.Text, Id_Remision)
                    tbx_NuevaRemision.Clear()
                    Call LlenaListView()
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

    Private Sub Lsv_Cajeros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Cajeros.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_CambiarRemisionCaj.Enabled = Lsv_Cajeros.SelectedItems.Count > 0
        tbx_NuevaRemisionCaj.Enabled = Lsv_Cajeros.SelectedItems.Count > 0
    End Sub

    Private Sub btn_CambiarRemisionCaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CambiarRemisionCaj.Click
        SegundosDesconexion = 0

        If tbx_NuevaRemisionCaj.Text = "" Then
            MsgBox("Número de Remisión Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NuevaRemisionCaj.Focus()
            Exit Sub
        End If
        If CLng(tbx_NuevaRemisionCaj.Text) = 0 Then
            MsgBox("Número de Remisión Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NuevaRemisionCaj.Focus()
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
        Dim Id_Bo As Long = CLng(Lsv_Cajeros.SelectedItems(0).Tag)
        Dim dt As DataTable = cn_Recepcion.fn_RemisionReadByIdBo(Id_Bo)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                Dim Cia As Integer = CInt(dt.Rows(0)("Id_CiaProp"))
                Dim Id_Remision As Long = CLng(dt.Rows(0)("Id_Remision"))
                dt.Dispose()
                If cn_Recepcion.fn_Remision_Existe(tbx_NuevaRemisionCaj.Text, Cia) Then
                    MsgBox("El Número de Remisión indicado ya existe, capture otro por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_NuevaRemisionCaj.SelectAll()
                    tbx_NuevaRemisionCaj.Focus()
                    Exit Sub
                End If
                'Cambiar el Número de la Remisión Seleccionada en la lista por el del tbx_NuevaRemision
                If cn_Recepcion.fn_RemisionUpdateNumero(Id_Remision, CLng(tbx_NuevaRemisionCaj.Text.Trim), Observa) Then
                    btn_CambiarRemisionCaj.Enabled = False
                    tbx_NuevaRemisionCaj.Clear()
                    tbx_NuevaRemisionCaj.Enabled = False
                    MsgBox("Remisión cambiada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                    'Guardar en Bitacora
                    FuncionesGlobales.fn_GuardaBitacora(13, "REMISION: " & Lsv_Cajeros.SelectedItems(0).SubItems(2).Text & " CIA_PROP: " & Cia & " -> REMISION: " & tbx_NuevaRemisionCaj.Text, Id_Remision)

                    Call LlenaListView()
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

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        Select Case TabControl.SelectedTab.Name
            Case Tab_Custodias.Name '"Tab_Custodias"
                FuncionesGlobales.fn_Exportar_Excel(Lsv_Custodias, 2, "CUSTODIAS DE CLIENTES", 0, 0, frm_MENU.prg_Barra)

            Case Tab_Procesos.Name '"Tab_Procesos"
                FuncionesGlobales.fn_Exportar_Excel(Lsv_Procesos, 2, "SERVICIOS PARA PROCESO", 0, 0, frm_MENU.prg_Barra)

            Case Tab_Cajeros.Name '"Tab_Cajeros"
                FuncionesGlobales.fn_Exportar_Excel(Lsv_Cajeros, 2, "SERVICIOS DE CAJEROS", 0, 0, frm_MENU.prg_Barra)

            Case Tab_Resguardos.Name '"Tab_Resguardos"
                FuncionesGlobales.fn_Exportar_Excel(Lsv_Resguardos, 2, "RESGUARDOS DE SALDO", 0, 0, frm_MENU.prg_Barra)

            Case Tab_Materiales.Name '"Tab_Materiales"
                FuncionesGlobales.fn_Exportar_Excel(Lsv_Materiales, 2, "MATERIALES", 0, 0, frm_MENU.prg_Barra)

        End Select
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        SegundosDesconexion = 0

        Call HabilitaExportarBaja()
    End Sub

    Sub HabilitaExportarBaja()
        btn_Baja.Enabled = False
        btn_Exportar.Enabled = False

        Select Case TabControl.SelectedTab.Name
            Case Tab_Custodias.Name '"Tab_Custodias"
                btn_Exportar.Enabled = Lsv_Custodias.Items.Count > 0
                btn_Baja.Enabled = Lsv_Custodias.CheckedItems.Count > 0

            Case Tab_Procesos.Name '"Tab_Procesos"
                btn_Exportar.Enabled = Lsv_Procesos.Items.Count > 0
                btn_Baja.Enabled = Lsv_Procesos.CheckedItems.Count > 0

            Case Tab_Cajeros.Name '"Tab_Cajeros"
                btn_Exportar.Enabled = Lsv_Cajeros.Items.Count > 0

            Case Tab_Resguardos.Name '"Tab_Resguardos"
                btn_Exportar.Enabled = Lsv_Resguardos.Items.Count > 0

            Case Tab_Materiales.Name '"Tab_Materiales"
                btn_Exportar.Enabled = Lsv_Materiales.Items.Count > 0
        End Select
    End Sub

    Private Sub Lsv_Custodias_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Custodias.ItemChecked, Lsv_Procesos.ItemChecked
        SegundosDesconexion = 0

        Call HabilitaExportarBaja()
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma Then
            Select Case TabControl.SelectedTab.Name

                Case Tab_Custodias.Name '"Tab_Custodias"
                    If cn_Recepcion.fn_Remision_Baja(Lsv_Custodias) Then
                        'Escribir en el Log el Movimiento realizado
                        For Each Elemento As ListViewItem In Lsv_Custodias.CheckedItems
                            FuncionesGlobales.fn_GuardaBitacora(37, Elemento.SubItems(2).Text & " " & Elemento.SubItems(3).Text & " -> " & Elemento.SubItems(4).Text, Elemento.Tag)
                        Next

                        'Volver a cargar la Información
                        Lsv_Custodias.Items.Clear()
                        Lsv_CustodiasT.Items.Clear()
                        If chk_Todos.Checked Then
                            Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1)
                            Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                        Else
                            Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1, cmb_Boveda.SelectedValue)
                            Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                        End If
                        lbl_RegistrosC.Text = "Registros: " & Lsv_Custodias.Items.Count
                    Else
                        MsgBox("Ocurrio un error al intentar dar de Baja las Remisiones marcadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                Case Tab_Procesos.Name '"Tab_Procesos"
                    If cn_Recepcion.fn_Remision_Baja(Lsv_Procesos) Then
                        'Escribir en el Log el Movimiento realizado
                        For Each Elemento As ListViewItem In Lsv_Procesos.CheckedItems
                            FuncionesGlobales.fn_GuardaBitacora(37, Elemento.SubItems(2).Text & " " & Elemento.SubItems(3).Text, Elemento.Tag)
                        Next

                        'Volver a cargar la Información
                        Lsv_Procesos.Items.Clear()
                        Lsv_ProcesosT.Items.Clear()
                        If chk_Todos.Checked Then
                            Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Procesos, 2)
                            Call fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                        Else
                            Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Procesos, 2, cmb_Boveda.SelectedValue)
                            Call fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                        End If
                        lbl_RegistrosP.Text = "Registros: " & Lsv_Procesos.Items.Count
                    Else
                        MsgBox("Ocurrio un error al intentar dar de Baja las Remisiones marcadas.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
            End Select

            Call HabilitaExportarBaja()
        End If
    End Sub

    Private Sub btn_ReemplazarRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReemplazarRemision.Click
        SegundosDesconexion = 0

        'Obtener el Id_Remision de la Remisión
        Dim dr_Remision As DataRow = cn_Recepcion.fn_ConsultaSaldo_ObtenerDatosRemision(Lsv_Custodias.SelectedItems(0).Tag)
        If dr_Remision IsNot Nothing Then
            Dim frm As New frm_Dialogo
            frm.Reemplazar = True
            frm.tbx_Remision.Text = Lsv_Custodias.SelectedItems(0).SubItems(2).Text
            frm.tbx_Remision.Tag = dr_Remision("Id_Remision")
            frm.Id_Bo = Lsv_Custodias.SelectedItems(0).Tag
            frm.ShowDialog()

            'Volver a cargar la Información de las Custodias
            Lsv_Custodias.Items.Clear()
            Lsv_CustodiasT.Items.Clear()
            btn_ReemplazarRemision.Enabled = False
            If chk_Todos.Checked Then
                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1)
                Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
            Else
                Call cn_Recepcion.fn_ConsultaSaldosLlenalista(Lsv_Custodias, 1, cmb_Boveda.SelectedValue)
                Call fn_TotalesListView(Lsv_Custodias, Lsv_CustodiasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
            End If
            lbl_RegistrosC.Text = "Registros: " & Lsv_Custodias.Items.Count
    
        Else
            MsgBox("Ha ocurrido un error al intentar obtener los datos de la Remisión seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
    End Sub
End Class