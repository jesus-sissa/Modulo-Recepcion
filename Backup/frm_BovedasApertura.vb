Imports System.Data.SqlClient
Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_BovedasApertura
    Dim TipoMov As Integer = 0

    Private Sub frm_Bovedas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Descripcion")
        lsv_Catalogo.Columns.Add("H.Apertura")
        lsv_Catalogo.Columns.Add("H.Cierre")
        lsv_Catalogo.Columns.Add("Moneda")
        lsv_Catalogo.Columns.Add("LineaRoja")
        lsv_Catalogo.Columns.Add("Tipo")
        lsv_Catalogo.Columns.Add("Status")

        Call LlenarLista()
    End Sub

    Sub LimpiarPantalla()
        tbx_Observaciones.Text = ""
        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        dtp_Fecha.Value = Today
        dtp_FechaApertura.Value = Today
        tbx_Hora.Text = "00"
        tbx_Min.Text = "00"
        tbx_HoraAp.Text = "00"
        tbx_MinAp.Text = "00"
        btn_Guardar.Text = ""
        lbl_Registros.Text = "Registros: 0"
        btn_Imprimir.Enabled = False
        btn_Guardar.Enabled = False
    End Sub

    Sub LlenarLista()
        Call LimpiarPantalla()
        If Not fn_Bovedas_LlenarLista(lsv_Catalogo, lsv_Catalogo.Lvs) Then
            MsgBox("Ocurrió un Error al intentar consultar el Catálogo de Bóvedas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count

    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        If FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            btn_Guardar.Enabled = True
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Imprimir.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Guardar.Text = ""
        btn_Guardar.Enabled = False
        If lsv_Catalogo.SelectedItems.Count = 0 Then Exit Sub

        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ABIERTA" Then
            btn_Guardar.Text = "Ce&rrar Bóveda"
            lbl_FechaPA.Enabled = True
            dtp_FechaApertura.Enabled = True
            lbl_HoraPA.Enabled = True
            tbx_HoraAp.Enabled = True
            tbx_MinAp.Enabled = True
        ElseIf lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "CERRADA" Then
            btn_Guardar.Text = "&Abrir Bóveda"
            lbl_FechaPA.Enabled = False
            dtp_FechaApertura.Enabled = False
            lbl_HoraPA.Enabled = False
            tbx_HoraAp.Enabled = False
            tbx_MinAp.Enabled = False
        End If
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        If fn_Bovedas_ReporteCierre(lsv_Catalogo.SelectedItems(0).Tag) Then
            btn_Guardar.Enabled = True
        End If
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim ActaID As Integer = 0
        Dim Tipo As Integer = 0

        If lsv_Catalogo.SelectedItems.Count = 0 Then Exit Sub

        If dtp_Fecha.Value.Date < DateAdd(DateInterval.Day, -1, Today) Then
            MsgBox("La Fecha no puede ser menor a un día apartir de la fecha actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Fecha.Focus()
            Exit Sub
        End If
        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "CERRADA" Then
            If CDec(tbx_Hora.Text) = 0 And CDec(tbx_Min.Text) = 0 Then
                MsgBox("Indíque la Hora de Apertura.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Hora.Focus()
                Exit Sub
            End If
        End If

        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ABIERTA" Then
            If CDec(tbx_Hora.Text) = 0 And CDec(tbx_Min.Text) = 0 Then
                MsgBox("Indíque la Hora de Cierre.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Hora.Focus()
                Exit Sub
            End If
            If dtp_FechaApertura.Value.ToShortDateString < dtp_Fecha.Value.ToShortDateString Then
                MsgBox("La Fecha de Apertura debe ser mayor a la Fecha de Cierre.", MsgBoxStyle.Information, frm_MENU.Text)
                dtp_FechaApertura.Focus()
                Exit Sub
            End If
            If CDec(tbx_HoraAp.Text) = 0 And CDec(tbx_MinAp.Text) = 0 Then
                MsgBox("Indíque la Hora de próxima Apertura.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_HoraAp.Focus()
                Exit Sub
            End If
        End If

        Dim Hora As String = tbx_Hora.Text & ":" & tbx_Min.Text
        Dim HoraProxA As String = tbx_HoraAp.Text & ":" & tbx_MinAp.Text
        Dim Frm As New frm_FirmaElectronica2
        'Aqui se filtra cuando la Bóveda está ABIERTA o CERRADA
        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ABIERTA" Then
            Tipo = 2
            Frm.Empleado = EmpresaId
            Frm.ShowDialog()
            If Frm.Firma = True Then
                ActaID = fn_Bovedas_Apertura(lsv_Catalogo.SelectedItems(0).Tag, Tipo, Frm.tbx_Empleado.Text, Frm.tbx_UsuarioSeg.Text, dtp_Fecha.Value, Hora, dtp_FechaApertura.Value, HoraProxA, tbx_Observaciones.Text.ToUpper)
                If ActaID > 0 Then
                    fn_Bovedas_Cerrar(lsv_Catalogo.SelectedItems(0).Tag)
                    MsgBox("La Bóveda se ha CERRADO correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Else
                Frm.Dispose()
                Exit Sub
            End If

        ElseIf lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "CERRADA" Then
            Tipo = 1
            Frm.Empleado = EmpresaId
            Frm.ShowDialog()

            If Frm.Firma = True Then
                ActaID = fn_Bovedas_Apertura(lsv_Catalogo.SelectedItems(0).Tag, Tipo, Frm.tbx_Empleado.Text, Frm.tbx_UsuarioSeg.Text, dtp_Fecha.Value, Hora, dtp_FechaApertura.Value, HoraProxA, tbx_Observaciones.Text)
                If ActaID > 0 Then
                    fn_Bovedas_Abrir(lsv_Catalogo.SelectedItems(0).Tag)
                    MsgBox("La Bóveda se ha ABIERTO correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
            Else
                Frm.Dispose()
                Exit Sub
            End If

        End If
        Frm.Dispose()

        'Se muestra el Acta para imprimirla
        fn_Bovedas_MostrarActa(ActaID, Tipo)

        'Se actualiza la variable Global
        TurnoId = Cn_Login.fn_ObtenTurno

        Call LlenarLista()

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub tbx_Hora_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Hora.Leave
        If tbx_Hora.Text.Trim = "" Then
            MsgBox("Capture las Horas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If
        If CInt(tbx_Hora.Text) > 23 Or tbx_Hora.Text.Trim = "" Then
            MsgBox("La Hora debe ser menor de 23.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If
        If CInt(tbx_Hora.Text) = 0 Then tbx_Hora.Text = "00"
    End Sub

    Private Sub tbx_Min_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Min.Leave
        If tbx_Min.Text.Trim = "" Then
            MsgBox("Capture los Minutos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Min.Focus()
            Exit Sub
        End If
        If CInt(tbx_Min.Text) > 59 Then
            MsgBox("Los Minutos deben ser menor de 59.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Min.Focus()
            Exit Sub
        End If
        If CInt(tbx_Min.Text) = 0 Then tbx_Min.Text = "00"
    End Sub

    Private Sub tbx_HoraAp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_HoraAp.Leave
        If tbx_HoraAp.Text.Trim = "" Then
            MsgBox("Capture las Horas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraAp.Focus()
            Exit Sub
        End If
        If CInt(tbx_HoraAp.Text) > 23 Or tbx_HoraAp.Text.Trim = "" Then
            MsgBox("La Hora debe ser menor de 23.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraAp.Focus()
            Exit Sub
        End If
        If CInt(tbx_HoraAp.Text) = 0 Then tbx_HoraAp.Text = "00"
    End Sub

    Private Sub tbx_MinAp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_MinAp.Leave
        If tbx_MinAp.Text.Trim = "" Then
            MsgBox("Capture los Minutos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_MinAp.Focus()
            Exit Sub
        End If
        If CInt(tbx_MinAp.Text) > 59 Then
            MsgBox("Los Minutos deben ser menor de 59.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_MinAp.Focus()
            Exit Sub
        End If
        If CInt(tbx_MinAp.Text) = 0 Then tbx_MinAp.Text = "00"
    End Sub

End Class