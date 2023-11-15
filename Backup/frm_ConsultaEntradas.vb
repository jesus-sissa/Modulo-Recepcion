Public Class frm_ConsultaEntradas

    Dim ColR() As Integer = {5, 6, 7, 9}
    Dim ColE() As Integer = {4, 5, 6, 10}
    Dim ColP() As Integer = {4, 5, 6, 10}
    Dim ColC() As Integer = {6, 7, 8, 12}
    Dim ColRG() As Integer = {5, 6, 7, 9}
    Private Nom() As String = {"Importe", "Envases", "Envases SN", "EnvasesTotal"}
    Private Frm() As String = {"n", "g", "g", "g"}
    Private Fnc() As FuncionesGlobales.Func = {FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma}

    Private Sub frm_ConsultaEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Boveda.Actualizar()

        'cmb_CiaRE.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_CiaRE.Actualizar()

        cmb_CiaProc.Actualizar()

        cmb_Rutas.AgregaParametro("@Tipo", "1", 1)
        cmb_Rutas.Actualizar()

        ''Pestaña Rutas
        Lsv_Rutas.Columns.Add("Remision")
        Lsv_Rutas.Columns.Add("FechaEntrada")
        Lsv_Rutas.Columns.Add("HoraEntrada")
        Lsv_Rutas.Columns.Add("Origen")
        Lsv_Rutas.Columns.Add("Destino")
        Lsv_Rutas.Columns.Add("Importe")
        Lsv_Rutas.Columns.Add("Envases")
        Lsv_Rutas.Columns.Add("Envases SN")

        Lsv_RutasT.Columns.Add("Concepto")
        Lsv_RutasT.Columns.Add("Importe")
        Lsv_RutasT.Columns.Add("Envases")
        Lsv_RutasT.Columns.Add("EnvasesSN")
        Lsv_RutasT.Columns.Add("EnvasesTotal")

        ''Pestaña RutasExternas
        Lsv_RutasExternas.Columns.Add("Remision")
        Lsv_RutasExternas.Columns.Add("FechaEntrada")
        Lsv_RutasExternas.Columns.Add("HoraEntrada")
        Lsv_RutasExternas.Columns.Add("Cliente")
        Lsv_RutasExternas.Columns.Add("Importe")
        Lsv_RutasExternas.Columns.Add("Envases")
        Lsv_RutasExternas.Columns.Add("Envases SN")
        Lsv_RutasExternas.Columns.Add("Status")

        Lsv_RutasExternasT.Columns.Add("Concepto")
        Lsv_RutasExternasT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_RutasExternasT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_RutasExternasT.Columns.Add("Envases SN").TextAlign = HorizontalAlignment.Right
        Lsv_RutasExternasT.Columns.Add("EnvasesTotal").TextAlign = HorizontalAlignment.Right

        ''Pestaña Proceso
        Lsv_Procesos.Columns.Add("Remision")
        Lsv_Procesos.Columns.Add("FechaEntrada")
        Lsv_Procesos.Columns.Add("HoraEntrada")
        Lsv_Procesos.Columns.Add("Cliente")
        Lsv_Procesos.Columns.Add("Importe")
        Lsv_Procesos.Columns.Add("Envases")
        Lsv_Procesos.Columns.Add("Envases SN")
        Lsv_Procesos.Columns.Add("Status")

        Lsv_ProcesosT.Columns.Add("Concepto")
        Lsv_ProcesosT.Columns.Add("Importe")
        Lsv_ProcesosT.Columns.Add("Envases")
        Lsv_ProcesosT.Columns.Add("Envases SN")
        Lsv_ProcesosT.Columns.Add("EnvasesTotal")
       
        ' Pestaña(Cajeros)
        Lsv_Cajeros.Columns.Add("Remision")
        Lsv_Cajeros.Columns.Add("FechaEntrada")
        Lsv_Cajeros.Columns.Add("HoraEntrada")
        Lsv_Cajeros.Columns.Add("Cliente")
        Lsv_Cajeros.Columns.Add("Importe")
        Lsv_Cajeros.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_Cajeros.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        Lsv_Cajeros.Columns.Add("Status").TextAlign = HorizontalAlignment.Right

        Lsv_CajerosT.Columns.Add("Concepto")
        Lsv_CajerosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_CajerosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        'Pestaña Resguardo
        lsv_Resguardos.Columns.Add("Remision")
        lsv_Resguardos.Columns.Add("FechaEntrada")
        lsv_Resguardos.Columns.Add("HoraEntrada")
        lsv_Resguardos.Columns.Add("Cliente")
        lsv_Resguardos.Columns.Add("Importe")
        lsv_Resguardos.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        lsv_Resguardos.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        lsv_Resguardos.Columns.Add("Status").TextAlign = HorizontalAlignment.Right

        lsv_ResguardosT.Columns.Add("Concepto")
        lsv_ResguardosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        lsv_ResguardosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        BanderA = True
    End Sub

    Private Sub TabPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Exportar()
    End Sub

    Private Function ValidaFecha() As Boolean
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha de Inicio no puede ser mayor a la fecha final ", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Value = Now.Date
            dtp_Hasta.Value = Now.Date
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SegundosDesconexion = 0

        If ValidaFecha() = True Then
            If cmb_Boveda.SelectedValue = 0 And Ckb_Bovedas.Checked = False Then
                MsgBox("Seleccione una Boveda ", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Call LlenaListas()
                Call Exportar()
            End If
        End If
    End Sub

    Private Sub LlenaListas()
        If BanderA = True Then
            Cursor = Cursors.WaitCursor
            Lsv_Rutas.Items.Clear()
            Lsv_RutasExternas.Items.Clear()
            Lsv_Procesos.Items.Clear()
            Lsv_Cajeros.Items.Clear()
            lsv_Resguardos.Items.Clear()
            lbl_RegistrosR.Text = "Registros: 0"
            lbl_RegistrosRE.Text = "Registros: 0"
            Lbl_RegistrosP.Text = "Registros: 0"
            Lbl_RegistrosC.Text = "Registros: 0"
            Lbl_RegistrosRes.Text = "Registros: 0"

            If cmb_Boveda.SelectedValue <> 0 OrElse Ckb_Bovedas.Checked = True Then

                Call cn_Recepcion.fn_ConsultaEntradasRutasLlenalista(Lsv_Rutas, cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaEntradasRutasExtLlenalista(Lsv_RutasExternas, cmb_Boveda.SelectedValue, cmb_CiaRE.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaEntradasLlenalista(Lsv_Procesos, cmb_Boveda.SelectedValue, 1, cmb_CiaProc.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaEntradasLlenalistaATMs(Lsv_Cajeros, cmb_Boveda.SelectedValue, 0, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaEntradasLlenaResguardos(lsv_Resguardos, cmb_Boveda.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                lbl_RegistrosR.Text = "Registros: " & Lsv_Rutas.Items.Count
                lbl_RegistrosRE.Text = "Registros: " & Lsv_RutasExternas.Items.Count
                Lbl_RegistrosP.Text = "Registros: " & Lsv_ProcesosT.Items.Count
                Lbl_RegistrosC.Text = "Registros: " & Lsv_Cajeros.Items.Count
                Lbl_RegistrosRes.Text = "Registros: " & lsv_Resguardos.Items.Count
            End If
        End If

        Call FuncionesGlobales.fn_TotalesListView(Lsv_Rutas, Lsv_RutasT, ColR, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_RutasExternas, Lsv_RutasExternasT, ColE, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, ColP, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, ColC, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(lsv_Resguardos, lsv_ResguardosT, ColRG, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)

        Cursor = Cursors.Default
    End Sub

    Private Sub Ckb_Bovedas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_Bovedas.CheckedChanged
        SegundosDesconexion = 0

        If Ckb_Bovedas.Checked = True Then
            cmb_Boveda.Enabled = False
            tbx_Cve_Boveda.Enabled = False
            cmb_Boveda.SelectedValue = 0
        Else
            cmb_Boveda.Enabled = True
            tbx_Cve_Boveda.Enabled = True
        End If

    End Sub

    Private Sub Btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exportar.Click
        SegundosDesconexion = 0

        If TabPage.SelectedTab Is RutasExternas Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_RutasExternas, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        ElseIf TabPage.SelectedTab Is Rutas Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Rutas, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        ElseIf TabPage.SelectedTab Is Procesos Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Procesos, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        ElseIf TabPage.SelectedTab Is Cajas Then
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Cajeros, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        ElseIf TabPage.SelectedTab Is TabResguardo Then
            FuncionesGlobales.fn_Exportar_Excel(lsv_Resguardos, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
        End If
    End Sub

    Private Sub Exportar()
        Btn_Exportar.Enabled = False
        If TabPage.SelectedTab Is RutasExternas Then
            If Lsv_RutasExternas.Items.Count > 0 Then Btn_Exportar.Enabled = True
        ElseIf TabPage.SelectedTab Is Rutas Then
            If Lsv_Rutas.Items.Count > 0 Then Btn_Exportar.Enabled = True
        ElseIf TabPage.SelectedTab Is Procesos Then
            If Lsv_Procesos.Items.Count > 0 Then Btn_Exportar.Enabled = True
        ElseIf TabPage.SelectedTab Is Cajas Then
            If Lsv_Cajeros.Items.Count > 0 Then Btn_Exportar.Enabled = True
        ElseIf TabPage.SelectedTab Is TabResguardo Then
            If lsv_Resguardos.Items.Count > 0 Then Btn_Exportar.Enabled = True
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub ckb_CiaRE_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_CiaRE.CheckedChanged
        SegundosDesconexion = 0

        cmb_CiaRE.Enabled = Not ckb_CiaRE.Checked

        If ckb_CiaRE.Checked Then cmb_CiaRE.SelectedValue = "0"
    End Sub

    Private Sub Ckb_TodosProc_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_TodosProc.CheckedChanged
        SegundosDesconexion = 0

        cmb_CiaProc.Enabled = Not Ckb_TodosProc.Checked

        If Ckb_TodosProc.Checked Then cmb_CiaProc.SelectedValue = "0"
    End Sub

    Private Sub Ckb_Rutas_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_Rutas.CheckedChanged
        SegundosDesconexion = 0
        cmb_Rutas.Enabled = Not Ckb_Rutas.Checked
        tbx_CveRuta.Enabled = Not Ckb_Rutas.Checked

        If Ckb_Rutas.Checked Then cmb_Rutas.SelectedValue = "0"
    End Sub

    Private Sub dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged, dtp_Desde.ValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
    End Sub

    Private Sub Limpiar()

        Lsv_Rutas.Items.Clear()
        Lsv_RutasExternas.Items.Clear()
        Lsv_Procesos.Items.Clear()
        Lsv_Cajeros.Items.Clear()
        lsv_Resguardos.Items.Clear()
        lbl_RegistrosR.Text = "Registros: 0"
        lbl_RegistrosRE.Text = "Registros: 0"
        Lbl_RegistrosP.Text = "Registros: 0"
        Lbl_RegistrosC.Text = "Registros: 0"
        Lbl_RegistrosRes.Text = "Registros: 0"

        Call FuncionesGlobales.fn_TotalesListView(Lsv_Rutas, Lsv_RutasT, ColR, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_RutasExternas, Lsv_RutasExternasT, ColE, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, ColP, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, ColC, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(lsv_Resguardos, lsv_ResguardosT, ColRG, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)

        Ckb_Rutas.Checked = True
        Ckb_Rutas.Enabled = False

        ckb_CiaRE.Checked = True
        ckb_CiaRE.Enabled = False

        Ckb_TodosProc.Checked = True
        Ckb_TodosProc.Enabled = False

    End Sub

    Private Sub Lsv_Rutas_AlActualizar() Handles Lsv_Rutas.AlActualizar
        Ckb_Rutas.Enabled = True
    End Sub

    Private Sub Lsv_RutasExternas_AlActualizar() Handles Lsv_RutasExternas.AlActualizar
        ckb_CiaRE.Enabled = True
    End Sub

    Private Sub Lsv_Procesos_AlActualizar() Handles Lsv_Procesos.AlActualizar
        Ckb_TodosProc.Enabled = True
    End Sub

    Private Sub cmb_Rutas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedValueChanged, Ckb_Rutas.CheckedChanged
        SegundosDesconexion = 0
        If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub
        If cmb_Rutas.SelectedValue <> 0 Or Ckb_Rutas.Checked Then
            cn_Recepcion.fn_ConsultaEntradasRutasLlenalista(Lsv_Rutas, cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
            FuncionesGlobales.fn_TotalesListView(Lsv_Rutas, Lsv_RutasT, ColR, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
            Lsv_Rutas.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Rutas.Columns(6).TextAlign = HorizontalAlignment.Right
            Lsv_Rutas.Columns(7).TextAlign = HorizontalAlignment.Right
            'Lsv_Rutas.Columns(10).Width = 0
            'Lsv_Rutas.Columns(11).Width = 0
            lbl_RegistrosR.Text = "Registros: " & Lsv_Rutas.Items.Count
        Else
            Lsv_Rutas.Items.Clear()
            lbl_RegistrosR.Text = "Registros: 0"
        End If
    End Sub

    Private Sub cmb_CiaRE_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CiaRE.SelectedValueChanged, ckb_CiaRE.CheckedChanged
        SegundosDesconexion = 0
        If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub
        If cmb_CiaRE.SelectedValue <> 0 Or ckb_CiaRE.Checked Then
            cn_Recepcion.fn_ConsultaEntradasRutasExtLlenalista(Lsv_RutasExternas, cmb_Boveda.SelectedValue, cmb_CiaRE.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
            FuncionesGlobales.fn_TotalesListView(Lsv_RutasExternas, Lsv_RutasExternasT, ColE, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
            Lsv_RutasExternas.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv_RutasExternas.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_RutasExternas.Columns(6).TextAlign = HorizontalAlignment.Right
            Lsv_RutasExternas.Columns(9).Width = 0
            Lsv_RutasExternas.Columns(10).Width = 0
            lbl_RegistrosRE.Text = "Registros: " & Lsv_RutasExternas.Items.Count
        Else
            Lsv_RutasExternas.Items.Clear()
            lbl_RegistrosRE.Text = "Registros: 0"
        End If
    End Sub

    Private Sub cmb_CiaProc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CiaProc.SelectedValueChanged, Ckb_TodosProc.CheckedChanged
        SegundosDesconexion = 0
        If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub
        If cmb_CiaProc.SelectedValue <> 0 Or Ckb_TodosProc.Checked Then
            cn_Recepcion.fn_ConsultaEntradasLlenalista(Lsv_Procesos, cmb_Boveda.SelectedValue, 5, cmb_CiaProc.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
            FuncionesGlobales.fn_TotalesListView(Lsv_Procesos, Lsv_ProcesosT, ColP, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
            Lsv_Procesos.Columns(4).TextAlign = HorizontalAlignment.Right
            Lsv_Procesos.Columns(5).TextAlign = HorizontalAlignment.Right
            Lsv_Procesos.Columns(6).TextAlign = HorizontalAlignment.Right
            Lsv_Procesos.Columns(9).Width = 0
            Lsv_Procesos.Columns(10).Width = 0
            Lbl_RegistrosP.Text = "Registros: " & Lsv_Procesos.Items.Count
        Else
            Lbl_RegistrosP.Text = "Registros: 0"
            Lsv_Procesos.Items.Clear()
        End If
    End Sub

End Class