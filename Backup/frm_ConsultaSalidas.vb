Public Class frm_ConsultaSalidas

    Dim ColR() As Integer = {5, 6, 7, 9}
    Dim ColE() As Integer = {4, 5, 6, 10}
    Dim ColP() As Integer = {4, 5, 6, 10}
    Dim ColC() As Integer = {6, 7, 8, 12}
    Dim ColRG() As Integer = {5, 6, 7, 9}
    Dim Nom() As String = {"Importe", "Envases", "EnvasesSN", "EnvasesTotal"}
    Private Frm() As String = {"n", "g", "g", "g"}
    Dim Fnc() As FuncionesGlobales.Func = {FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma, FuncionesGlobales.Func.Suma}

    Private Sub frm_ConsultaSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "T", 0)
        cmb_Boveda.Actualizar()

        'cmb_CiaRE.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_CiaRE.Actualizar()

        cmb_CiaProc.Actualizar()

        cmb_Rutas.AgregaParametro("@Tipo", "1", 1)
        cmb_Rutas.Actualizar()

        BanderA = True

        ''Pestaña Rutas
        'Lsv_RutasT.Columns.Add("Concepto")
        'Lsv_RutasT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        'Lsv_RutasT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        ''Pestaña RutasExternas
        'Lsv_RutasExternasT.Columns.Add("Concepto")
        'Lsv_RutasExternasT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        'Lsv_RutasExternasT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        ''Pestaña Proceso
        'Lsv_ProcesosT.Columns.Add("Concepto")
        'Lsv_ProcesosT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        'Lsv_ProcesosT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        'Pestaña Cajeros
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
    End Sub

    Private Sub TabPage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage.SelectedIndexChanged

        Call Exportar()

    End Sub

    Private Sub Btn_Consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consulta.Click
        SegundosDesconexion = 0
        If ValidaFecha() = True Then
            If cmb_Boveda.SelectedValue = 0 And Ckb_Bovedas.Checked = False Then
                MsgBox("Seleccione una Boveda o marque la casilla «Todas».", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                Call LlenaListas()
                Call Exportar()
            End If
        End If
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

    Private Sub LlenaListas()
        Lsv_Rutas.Items.Clear()
        Lsv_RutasExternas.Items.Clear()
        Lsv_Proceso.Items.Clear()
        Lsv_Cajeros.Items.Clear()
        lsv_Resguardos.Items.Clear()
        lbl_RegistrosR.Text = "Registros: 0"
        Lbl_RegistrosRE.Text = "Registros: 0"
        lbl_RegistrosP.Text = "Registros: 0"
        lbl_RegistrosC.Text = "Registros: 0"
        lbl_RegistrosRes.Text = "Registros: 0"

        If BanderA = True Then
            If cmb_Boveda.SelectedValue = 0 And Ckb_Bovedas.Checked = False Then
                Exit Sub
            Else
                Call cn_Recepcion.fn_ConsultaSalidasRutasLlenalista(Lsv_Rutas, cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaSalidasRutasExtLlenalista(Lsv_RutasExternas, cmb_Boveda.SelectedValue, cmb_CiaRE.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaSalidasLlenalista(Lsv_Proceso, cmb_Boveda.SelectedValue, 1, cmb_CiaProc.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaSalidasLlenalistaATMs(Lsv_Cajeros, cmb_Boveda.SelectedValue, 0, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                Call cn_Recepcion.fn_ConsultaSalidasLlenaResguardos(lsv_Resguardos, cmb_Boveda.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)

                Lsv_Rutas.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(7).TextAlign = HorizontalAlignment.Right
                'Lsv_Rutas.Columns(10).Width = 0
                'Lsv_Rutas.Columns(11).Width = 0

                Lsv_RutasExternas.Columns(4).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(10).Width = 0
                'Lsv_RutasExternas.Columns(11).Width = 0

                Lsv_Proceso.Columns(4).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(10).Width = 0
                'Lsv_Procesos.Columns(11).Width = 0

                Lsv_Cajeros.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Cajeros.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_Cajeros.Columns(8).TextAlign = HorizontalAlignment.Right
                Lsv_Cajeros.Columns(12).TextAlign = HorizontalAlignment.Right
                Lsv_Cajeros.Columns(10).Width = 0
                Lsv_Cajeros.Columns(11).Width = 0
                Lsv_Cajeros.Columns(12).Width = 100

                lsv_Resguardos.Columns(4).TextAlign = HorizontalAlignment.Right
                lsv_Resguardos.Columns(5).TextAlign = HorizontalAlignment.Right
                lsv_Resguardos.Columns(6).TextAlign = HorizontalAlignment.Right
                lsv_Resguardos.Columns(7).TextAlign = HorizontalAlignment.Right
                lsv_Resguardos.Columns(10).Width = 0
                'lsv_Resguardos.Columns(11).Width = 0

                lbl_RegistrosC.Text = "Registros: " & Lsv_Cajeros.Items.Count
                lbl_RegistrosP.Text = "Registros: " & Lsv_Proceso.Items.Count
                Lbl_RegistrosRE.Text = "Registros: " & Lsv_RutasExternas.Items.Count
                lbl_RegistrosRes.Text = "Registros: " & lsv_Resguardos.Items.Count
                lbl_RegistrosR.Text = "Registros: " & Lsv_Rutas.Items.Count

            End If

        End If

        Call FuncionesGlobales.fn_TotalesListView(Lsv_Rutas, Lsv_RutasT, ColR, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_RutasExternas, Lsv_RutasExternasT, ColE, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Proceso, Lsv_ProcesosT, ColP, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(Lsv_Cajeros, Lsv_CajerosT, ColC, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
        Call FuncionesGlobales.fn_TotalesListView(lsv_Resguardos, lsv_ResguardosT, ColRG, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)

    End Sub

    Private Sub cmb_Rutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedIndexChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub

            If cmb_Rutas.SelectedValue = 0 And Ckb_Rutas.Checked = False Then
                Lsv_Rutas.Items.Clear()
                lbl_RegistrosR.Text = "Registros: 0"
            Else
                Call cn_Recepcion.fn_ConsultaSalidasRutasLlenalista(Lsv_Rutas, cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
                Call FuncionesGlobales.fn_TotalesListView(Lsv_Rutas, Lsv_RutasT, ColR, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
                Lsv_Rutas.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Rutas.Columns(7).TextAlign = HorizontalAlignment.Right
                lbl_RegistrosR.Text = "Registros: " & Lsv_Rutas.Items.Count
            End If
        End If
    End Sub

    Private Sub cmb_CiaRE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CiaRE.SelectedIndexChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub

            If cmb_CiaRE.SelectedValue = 0 And ckb_CiaRE.Checked = False Then
                Lsv_RutasExternas.Items.Clear()
                Lbl_RegistrosRE.Text = "Registros: 0"
            Else
                Call cn_Recepcion.fn_ConsultaSalidasRutasExtLlenalista(Lsv_RutasExternas, cmb_Boveda.SelectedValue, cmb_CiaRE.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
                Call FuncionesGlobales.fn_TotalesListView(Lsv_RutasExternas, Lsv_RutasExternasT, ColE, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
                Lsv_RutasExternas.Columns(4).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_RutasExternas.Columns(10).TextAlign = HorizontalAlignment.Right
                Lbl_RegistrosRE.Text = "Registros: " & Lsv_RutasExternas.Items.Count
            End If
        End If
    End Sub

    Private Sub cmb_CiaProc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CiaProc.SelectedIndexChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            If cmb_Boveda.Enabled = True And cmb_Boveda.SelectedValue = 0 Then Exit Sub

            If cmb_CiaProc.SelectedValue = 0 And Ckb_TodosProc.Checked = False Then
                Lsv_Proceso.Items.Clear()
                lbl_RegistrosP.Text = "Registros: 0"
            Else
                Call cn_Recepcion.fn_ConsultaSalidasLlenalista(Lsv_Proceso, cmb_Boveda.SelectedValue, 7, cmb_CiaProc.SelectedValue, dtp_Desde.Value, dtp_Hasta.Value)
                Call FuncionesGlobales.fn_TotalesListView(Lsv_Proceso, Lsv_ProcesosT, ColP, Nom, Frm, Fnc, FuncionesGlobales.Modo.Total)
                Lsv_Proceso.Columns(4).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(5).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(6).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(7).TextAlign = HorizontalAlignment.Right
                Lsv_Proceso.Columns(10).TextAlign = HorizontalAlignment.Right
                lbl_RegistrosP.Text = "Registros: " & Lsv_Proceso.Items.Count
            End If
        End If
    End Sub

    Private Sub Ckb_Rutas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_Rutas.CheckedChanged
        SegundosDesconexion = 0

        If Ckb_Rutas.Checked = True Then
            cmb_Rutas.Enabled = False
            tbx_CveRuta.Enabled = False
            If cmb_Rutas.SelectedValue = 0 Then
                cmb_Rutas_SelectedIndexChanged(cmb_Rutas, e)
            Else
                cmb_Rutas.SelectedValue = 0
            End If
        Else
            cmb_Rutas.Enabled = True
            tbx_CveRuta.Enabled = True
        End If
    End Sub

    Private Sub Ckb_TodosProc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb_TodosProc.CheckedChanged
        SegundosDesconexion = 0

        If Ckb_TodosProc.Checked = True Then
            cmb_CiaProc.Enabled = False
            If cmb_CiaProc.SelectedValue = 0 Then
                cmb_CiaProc_SelectedIndexChanged(cmb_CiaProc, e)
            Else
                cmb_CiaProc.SelectedValue = 0
            End If
        Else
            cmb_CiaProc.Enabled = True
        End If
    End Sub

    Private Sub ckb_CiaRE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckb_CiaRE.CheckedChanged
        SegundosDesconexion = 0

        If ckb_CiaRE.Checked = True Then
            cmb_CiaRE.Enabled = False
            If cmb_CiaRE.SelectedValue = 0 Then
                cmb_CiaRE_SelectedIndexChanged(cmb_CiaRE, e)
            Else
                cmb_CiaRE.SelectedValue = 0
            End If
        Else
            cmb_CiaRE.Enabled = True
        End If
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
            FuncionesGlobales.fn_Exportar_Excel(Lsv_Proceso, 2, Me.Text, 0, 3, frm_MENU.prg_Barra)
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
            If Lsv_Proceso.Items.Count > 0 Then Btn_Exportar.Enabled = True
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
End Class