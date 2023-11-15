Imports Modulo_Recepcion.FuncionesGlobales
Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_DespachoRutasPropias
    Dim dt_Rutas As DataTable = Nothing
    Private tbx_TotalRemisiones As String
    Private tbx_TotalEnvases As String
    Private tbx_TotalImporte As String

    Private Sub frm_DespachoRutasPropias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Ruta.AgregaParametro("@Fecha", Now.Date.ToShortDateString, 2)
        cmb_Ruta.AgregaParametro("@Id_Sucursal", SucursalId, 1)
        cmb_Ruta.Actualizar()
        dt_Rutas = cmb_Ruta.DataSource
        cmb_Ruta.Tag = 0
        BanderA = True

        'Columnas del listview Boveda
        Lsv_Boveda.Columns.Add("Remision")
        Lsv_Boveda.Columns.Add("Origen")
        Lsv_Boveda.Columns.Add("Destino")
        Lsv_Boveda.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Boveda.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_Boveda.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        Lsv_Boveda.Columns.Add("Status")

        'Columnas del listview Boveda Totales
        Lsv_BovedaT.Columns.Add("Concepto")
        Lsv_BovedaT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        'Columnas del listvies ATMS
        Lsv_Atms.Columns.Add("Remision")
        Lsv_Atms.Columns.Add("Caja")
        Lsv_Atms.Columns.Add("Cajero")
        Lsv_Atms.Columns.Add("Moneda")
        Lsv_Atms.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Atms.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_Atms.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        Lsv_Atms.Columns.Add("Status")

        'Columnas del listview ATMS Totales
        Lsv_AtmsT.Columns.Add("Remisiones")
        Lsv_AtmsT.Columns.Add("Importes").TextAlign = HorizontalAlignment.Right
        Lsv_AtmsT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_AtmsT.Columns.Add("Envases S/N").TextAlign = HorizontalAlignment.Right

        'Columnas del listview Materiales
        Lsv_Materiales.Columns.Add("Remision")
        Lsv_Materiales.Columns.Add("Cliente")
        Lsv_Materiales.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Materiales.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_Materiales.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        Lsv_Materiales.Columns.Add("Status")

        'Columnas del listview Materiales Totales
        Lsv_MaterialesT.Columns.Add("Remisiones")
        Lsv_MaterialesT.Columns.Add("Importes").TextAlign = HorizontalAlignment.Right
        Lsv_MaterialesT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Lsv_MaterialesT.Columns.Add("Envases S/N").TextAlign = HorizontalAlignment.Right

        ''Buscar si hay despachos pendientes por Finalizar
        'If fn_DespachoPropias_Pendientes(Today.Date, Today.Date, 1) Then
        '    MsgBox("Hay Despachos pendientes por Finalizar.", MsgBoxStyle.Information, frm_MENU.Text)
        'End If

    End Sub

    Private Sub Lsv_Boveda_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Boveda.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Boveda.CheckedItems.Count > 0 Then
            Btn_Despachar.Enabled = True
        Else
            Btn_Despachar.Enabled = False
        End If
    End Sub

    Private Sub Lsv_Materiales_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Materiales.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Materiales.CheckedItems.Count > 0 Then
            Btn_Despachar.Enabled = True
        Else
            Btn_Despachar.Enabled = False
        End If
    End Sub

    Private Sub Lsv_Atms_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Atms.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Atms.CheckedItems.Count > 0 Then
            Btn_Despachar.Enabled = True
        Else
            Btn_Despachar.Enabled = False
        End If
    End Sub

    Private Sub Calcula(Optional ByVal SoloChk As Boolean = False)
        Dim Elemento As ListViewItem
        Dim Importe As Decimal = 0
        Dim Envases As Decimal = 0
        Dim NumeroRem As Integer = 0

        Select Case TC_Servicios.SelectedTab.Name.ToUpper
            Case Tab_Clientes.Name.ToString.ToUpper
                If SoloChk = False Then
                    For Each Elemento In Lsv_Boveda.Items
                        Importe += Elemento.SubItems(3).Text
                        Envases += CInt(Elemento.SubItems(4).Text) + CInt(Elemento.SubItems(5).Text)
                    Next
                    NumeroRem = Lsv_Boveda.Items.Count
                Else
                    For Each Elemento In Lsv_Boveda.CheckedItems
                        Importe += Elemento.SubItems(3).Text
                        Envases += CInt(Elemento.SubItems(4).Text) + CInt(Elemento.SubItems(5).Text)
                    Next
                    NumeroRem = Lsv_Boveda.CheckedItems.Count
                End If
            Case Tab_Atms.Name.ToString.ToUpper
                If SoloChk = False Then
                    For Each Elemento In Lsv_Atms.Items
                        Importe += Elemento.SubItems(4).Text
                        Envases += CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text)
                    Next
                    NumeroRem = Lsv_Atms.Items.Count
                Else
                    For Each Elemento In Lsv_Atms.CheckedItems
                        Importe += Elemento.SubItems(4).Text
                        Envases += CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text)
                    Next
                    NumeroRem = Lsv_Atms.CheckedItems.Count
                End If
            Case Tab_Materiales.Name.ToString.ToUpper
                If SoloChk = False Then
                    For Each Elemento In Lsv_Materiales.Items
                        Importe += Elemento.SubItems(2).Text
                        Envases += CInt(Elemento.SubItems(3).Text) + CInt(Elemento.SubItems(4).Text)
                    Next
                    NumeroRem = Lsv_Materiales.Items.Count
                Else
                    For Each Elemento In Lsv_Materiales.CheckedItems
                        Importe += Elemento.SubItems(2).Text
                        Envases += CInt(Elemento.SubItems(3).Text) + CInt(Elemento.SubItems(4).Text)
                    Next
                    NumeroRem = Lsv_Materiales.CheckedItems.Count
                End If
        End Select

        tbx_TotalEnvases = Envases
        tbx_TotalImporte = Importe
        tbx_TotalRemisiones = NumeroRem

    End Sub

    Private Sub Btn_Despachar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Despachar.Click
        SegundosDesconexion = 0
        If cmb_Ruta.Tag = 0 Then
            MsgBox("No se puede realizar el despacho porque no se genero el identificador de Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Select Case TC_Servicios.SelectedTab.Name.ToUpper
            Case Tab_Clientes.Name.ToString.ToUpper
                'comprobar que estén disponibles las Remisiones
                If Not cn_Recepcion.fn_Despacho_ValidaStatus(Lsv_Boveda) Then
                    MsgBox("Algunas Remisiones ya no están disponibles. Puede ser que ya se hayan despachado desde otra Estación de Trabajo." & Chr(13) & Chr(13) & "Se actualizará la lista para que intente el despacho de nuevo...", MsgBoxStyle.Information, frm_MENU.Text)
                    BanderA = True
                    Call LLenaLsv()
                    Btn_Despachar.Enabled = False
                    Exit Sub
                End If
                'Realizar el Despacho
                Call Calcula(True)
                Call Calcula(True)
                Cargar_Data(Lsv_Boveda, lsv_envases, 4, "")
                DespacharTrue()
                If (Lsv_Boveda.CheckedItems.Count > 0) Then
                    If cn_Recepcion.fn_DespachoPropias_Create(Lsv_Boveda, cmb_Ruta.SelectedValue, CInt(tbx_TotalRemisiones), CInt(tbx_TotalEnvases), tbx_TotalImporte, cmb_Ruta.Text, DTP_Fecha.Value.ToShortDateString, CInt(cmb_Ruta.Tag)) Then
                        'Recalcular las Remisiones y Envases en Tv_Programacion 
                        Call cn_Recepcion.fn_Despacho_RecalcularEnvases(cmb_Ruta.Tag)
                        MsgBox("Despacho realizado correctamente, registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                        BanderA = True
                        tbx_Envase.Text = String.Empty
                    Else
                        MsgBox("Ocurrió un Error al Realizar el Despacho o fué cancelado por el Usuario. Las Remisiones aún permanecen en Bóveda, intente despacharlas de nuevo.", MsgBoxStyle.Critical, frm_MENU.Text)
                        BanderA = False
                    End If                 
                Else
                    tbx_Envase.Focus()
                End If
            Case Tab_Atms.Name.ToString.ToUpper
                'comprobar que estén disponibles las Remisiones
                If Not cn_Recepcion.fn_Despacho_ValidaStatus(Lsv_Atms) Then
                    MsgBox("Algunas Remisiones ya no están disponibles. Puede ser que ya se hayan despachado desde otra Estación de Trabajo." & Chr(13) & Chr(13) & "Se actualizará la lista para que intente el despacho de nuevo...", MsgBoxStyle.Information, frm_MENU.Text)
                    BanderA = True
                    Call LLenaLsv()
                    Btn_Despachar.Enabled = False
                    Exit Sub
                End If
                'Realizar el Despacho
                Call Calcula(True)
                Cargar_Data(Lsv_Atms, lsv_envasesatm, 5, "")
                'DespacharTrue() ' Comprueba las remisiones que tienes todos los envases scaneados 
                If (Lsv_Atms.CheckedItems.Count > 0) Then ' si existe una remision completada continua
                    If cn_Recepcion.fn_DespachoAtms_Create(Lsv_Atms, cmb_Ruta.SelectedValue, tbx_TotalRemisiones, tbx_TotalEnvases, tbx_TotalImporte, DTP_Fecha.Value.ToShortDateString, cmb_Ruta.Text) = True Then
                        MsgBox("Despacho realizado correctamente, registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                        BanderA = True
                        tbx_Envase1.Text = String.Empty
                    Else                      
                        MsgBox("Ocurrió un Error al Realizar el Despacho o fué cancelado por el Usuario. Las Remisiones aún permanecen en Bóveda, intente despacharlas de nuevo.", MsgBoxStyle.Critical, frm_MENU.Text)
                        BanderA = False
                    End If

                Else
                    tbx_Envase1.Focus()
                End If

                ' remisiones_digitales
            Case Tab_Materiales.Name.ToString.ToUpper
                Call Calcula(True)
                Cargar_Data(Lsv_Materiales, Lsv_EnvasesMat, 3, "")
                'DespacharTrue()
                If (Lsv_Materiales.CheckedItems.Count > 0) Then
                    If cn_Recepcion.fn_DespachoMateriales_Create(Lsv_Materiales, cmb_Ruta.SelectedValue, tbx_TotalRemisiones, tbx_TotalEnvases, tbx_TotalImporte, DTP_Fecha.Value.ToShortDateString, cmb_Ruta.Text) = True Then
                        MsgBox("Despacho realizado correctamente, registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                        txt_envasemat.Text = String.Empty
                        BanderA = True
                    End If
                Else
                    txt_envasemat.Focus()
                End If
        End Select
        Call LLenaLsv()
        'Btn_Despachar.Enabled = False
    End Sub

    Private Sub LLenaLsv()
        If BanderA = True Then
            Dim Columnas() As Integer = {1, 3, 4}
            Dim Nombres() As String = {"Remisiones", "Importe", "Envases"}
            Dim Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma}
            Dim Formatos() As String = {"g", "n", "g"}

            Call cn_Recepcion.fn_DespachoPropiasLlenalista(Lsv_Boveda, cmb_Ruta.SelectedValue, DTP_Fecha.Value)
            Call fn_TotalesListView(Lsv_Boveda, Lsv_BovedaT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

            Dim Columnas1() As Integer = {1, 4, 5, 6}
            Dim Nombres1() As String = {"Remisiones", "Importes", "Envases", "Envases S/N"}
            Dim Formatos1() As String = {"g", "n", "g", "g"}
            Dim Funciones1() As Func = {Func.Conteo, Func.Suma, Func.Suma, Func.Suma}

            Call cn_Recepcion.fn_DespachoAtmsLlenalista(Lsv_Atms, cmb_Ruta.SelectedValue, DTP_Fecha.Value)
            Call fn_TotalesListView(Lsv_Atms, Lsv_AtmsT, Columnas1, Nombres1, Formatos1, Funciones1, Modo.Total)

            Dim Columnas2() As Integer = {1, 2, 3, 4}
            Dim Nombres2() As String = {"Remisiones", "Importes", "Envases", "Envases S/N"}
            Dim Formatos2() As String = {"g", "n", "g", "g"}
            Dim Funciones2() As Func = {Func.Conteo, Func.Suma, Func.Suma, Func.Suma}

            Call cn_Recepcion.fn_DespachoMaterialesLlenalista(Lsv_Materiales, cmb_Ruta.SelectedValue, DTP_Fecha.Value.Date, CInt(cmb_Ruta.Tag))
            Call fn_TotalesListView(Lsv_Materiales, Lsv_MaterialesT, Columnas2, Nombres2, Formatos2, Funciones2, Modo.Total)

            Tab_Clientes.Text = "Clientes" + " (" + Str(Lsv_Boveda.Items.Count).Trim + ")"
            Tab_Materiales.Text = "Materiales" + " (" + Str(Lsv_Materiales.Items.Count).Trim + ")"
            Tab_Atms.Text = "ATM's" + " (" + Str(Lsv_Atms.Items.Count).Trim + ")"

            Lsv_Boveda.CheckBoxes = True
            Lsv_Atms.CheckBoxes = True
            Lsv_Materiales.CheckBoxes = True

            Call Calcula()
            Lbl_RegistrosC.Text = "Registros: " & Lsv_Boveda.Items.Count
            Lbl_RegistrosATMs.Text = "Registros: " & Lsv_Atms.Items.Count
            Lbl_RegistrosM.Text = "Registros: " & Lsv_Materiales.Items.Count
            NumerosXremision() ''Remision digital 20/08/2020
        End If

    End Sub

    Private Sub NumerosXremision()
        cn_Recepcion.fn_EnvasesXremision(lsv_envases, cmb_Ruta.SelectedValue, DTP_Fecha.Value)
        cn_Recepcion.fn_EnvasesXremisionAtm(lsv_envasesatm, cmb_Ruta.SelectedValue, DTP_Fecha.Value)
        cn_Recepcion.fn_EnvasesXremisionMat(Lsv_EnvasesMat, cmb_Ruta.SelectedValue)
    End Sub

    Private Sub cmb_Ruta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ruta.SelectedIndexChanged
        SegundosDesconexion = 0
        If cmb_Ruta.Items.Count <= 1 Then Exit Sub
        If cmb_Ruta.SelectedIndex = 0 Then Exit Sub

        If DTP_Fecha.Value.Date < Today.Date Then
            MsgBox("La Fecha debe ser igual o mayor al día actual.", MsgBoxStyle.Information, frm_MENU.Text)
            DTP_Fecha.Focus()
            Exit Sub
        End If
        Call LLenaLsv()

        If dt_Rutas Is Nothing Then
            MsgBox("Ocurrió un error al consultar los datos de las rutas", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dt_Rutas.Rows.Count > 0 Then
            cmb_Ruta.Tag = dt_Rutas.Rows(cmb_Ruta.SelectedIndex)("Id_Programacion")
        Else
            cmb_Ruta.Tag = 0
            MsgBox("No se pudo obtener el identificador de ruta para el despacho.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        tbx_Envase.Focus()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub DTP_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_Fecha.ValueChanged
        SegundosDesconexion = 0

        BanderA = False
        dt_Rutas = Nothing
        cmb_Ruta.ActualizaValorParametro("@Fecha", DTP_Fecha.Value.Date)
        cmb_Ruta.Actualizar()
        dt_Rutas = cmb_Ruta.DataSource
        BanderA = True

        cmb_Ruta.SelectedValue = 0
    End Sub

    Private Sub Lsv_Boveda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Boveda.MouseHover, Lsv_Atms.MouseHover
        SegundosDesconexion = 0
    End Sub

    Dim lsv_General As ListView
    Dim lsv_EnvasesT As ListView
    Dim scan As String
    Dim pos As Integer

    Sub Buscar_Env()      
        For Each row In lsv_EnvasesT.Items
            If (row.SubItems(1).Text = scan) Then
                row.SubItems(2).Text = "S"
                row.BackColor = Color.LightGreen
                Exit For
            End If
        Next
        Seleccionar()
    End Sub
    Sub Seleccionar()
        Dim Cont As Integer
        For Each Elemento In lsv_General.Items
            Cont = 0
            For Each row In lsv_EnvasesT.Items
                If (row.SubItems(0).Text = Elemento.SubItems(0).Text AndAlso row.SubItems(2).Text = "S") Then
                    Cont += 1
                    Elemento.Selected = True
                End If
            Next
            If (CInt(Elemento.SubItems(pos).Text) = Cont) Then
                Elemento.Checked = True
            End If
        Next
    End Sub
    Sub Cargar_Data(ByVal Gvg As ListView, ByVal GvE As ListView, ByVal Posicion As Integer, ByVal Scanner As String)
        lsv_General = Gvg
        lsv_EnvasesT = GvE
        scan = Scanner
        pos = Posicion
    End Sub
    Sub DespacharTrue()
        Dim Cont As Integer
        For Each Elemento In lsv_General.CheckedItems
            Cont = 0
            For Each row In lsv_EnvasesT.Items
                If (row.SubItems(0).Text = Elemento.SubItems(0).Text AndAlso row.SubItems(2).Text = "S") Then
                    Cont += 1
                End If
            Next
            If (CInt(Elemento.SubItems(pos).Text) <> Cont) Then
                Elemento.Checked = False
            End If
            'validamos si no esta utlizando remision digital y procedemos a generar el reporte
            If Elemento.SubItems(10).Text = "N" Then
                Elemento.Checked = True
            End If
        Next
    End Sub

    Private Sub Lsv_Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Materiales.SelectedIndexChanged
        If Lsv_Materiales.SelectedItems.Count > 0 Then
            Variables.Id_matventa = (Lsv_Materiales.SelectedItems(0).SubItems(9).Text)
        End If
    End Sub

    Private Sub tbx_Envase1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Envase1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ValidarNumeroRemision(lsv_envasesatm)
            Cargar_Data(Lsv_Atms, lsv_envasesatm, 5, tbx_Envase1.Text)
            Buscar_Env()
        End If
    End Sub

    Private Sub tbx_Envase_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            Cargar_Data(Lsv_Boveda, lsv_envases, 4, tbx_Envase.Text)
            Buscar_Env()
        End If
    End Sub

    Private Sub TC_Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TC_Servicios.SelectedIndexChanged
        If (TC_Servicios.SelectedTab.Name = "Tab_Clientes") Then
            tbx_Envase.Focus()
        ElseIf (TC_Servicios.SelectedTab.Name = "Tab_Atms") Then
            tbx_Envase1.Focus()
        Else
            txt_envasemat.Focus()
        End If
    End Sub

    Private Sub txt_envasemat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_envasemat.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ValidarNumeroRemision(Lsv_Materiales)
            Cargar_Data(Lsv_Materiales, Lsv_EnvasesMat, 3, txt_envasemat.Text)
            Buscar_Env()
        End If
    End Sub

    Private Sub Lsv_EnvasesMat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_EnvasesMat.Click
        txt_envasemat.Focus()
    End Sub

    Private Sub lsv_envases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_envases.Click
        tbx_Envase.Focus()
    End Sub

    Private Sub lsv_envasesatm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_envasesatm.Click
        tbx_Envase1.Focus()
    End Sub

    Private Sub Cp_Textbox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Envase.KeyPress
        'If Asc(e.KeyChar) = Keys.Enter Then
        '    Cargar_Data(Lsv_Boveda, lsv_envases, 4, tbx_Envase.Text)
        '    Buscar_Env()
        'End If
        If Asc(e.KeyChar) = Keys.Enter Then
            ValidarNumeroRemision(Lsv_Boveda)
            Cargar_Data(Lsv_Boveda, lsv_envases, 4, tbx_Envase.Text)
            Buscar_Env()
        End If
    End Sub
    Function ValidarNumeroRemision(ByVal list As cp_Listview) As Boolean

        If tbx_Envase.Text.Trim = "" Then
            'MsgBox("Capture un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        For Each Elemento As ListViewItem In list.Items
            If Elemento.Text = tbx_Envase.Text.Trim Then
                Elemento.Checked = True
                Elemento.EnsureVisible()
                Return True
            End If
        Next
        Return False
        'MsgBox("No se encontró la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Function
End Class