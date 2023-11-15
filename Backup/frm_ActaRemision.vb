Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_ActaRemision
    Private dt_Dinero As New DataTable
    Private dt_Envases As New DataTable
    Public dt_Paso As New DataTable
    Private lc_CantEnvases As Integer = 0
    Dim ClienteDestino As Integer = 0
    Dim dr_Programacion As DataRow
    Dim dt_Custodios As DataTable
    Dim ActaID As Integer = 0

    Private Sub frm_AnomaliasEnvases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Cia.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_Cia.Actualizar()
        cmb_Cia.SelectedValue = 1

        BanderA = True

        dt_Paso = fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_Paso
        FormatoGrid()
        Btn_Guardar.Enabled = False

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        End If

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)

        cmb_Rutas.ValorParametro = 0
        cmb_Rutas.Actualizar()

        cmb_Cliente.Actualizar()
        cmb_Operador.Actualizar()
        cmb_Custodio.Actualizar()

    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub FormatoGrid()
        With dgDinero.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(dgDinero.Font, FontStyle.Bold)
        End With

        With dgDinero
            .Name = "dgDinero"

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .Columns(0).Name = "Id_Moneda"
            .Columns(0).Visible = False

            .Columns(1).Name = "Moneda"
            .Columns(1).Width = 70
            .Columns(1).ReadOnly = True

            .Columns(2).Name = "Importe Efectivo"
            .Columns(2).ReadOnly = False
            .Columns(2).Width = 120 '145
            .Columns(2).DefaultCellStyle.Format = "N2"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).Name = "Importe Documentos"
            .Columns(3).ReadOnly = False
            .Columns(3).Width = 120 '150
            .Columns(3).DefaultCellStyle.Format = "N2"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(4).Name = "TipoCambio"
            .Columns(4).ReadOnly = True
            .Columns(4).Width = 80
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .MultiSelect = False
        End With
    End Sub

    Private Sub dgDinero_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgDinero.CellFormatting
        If Me.dgDinero.Columns(e.ColumnIndex).Name = "Importe Efectivo" Then
            If e IsNot Nothing Then
                If e.Value IsNot Nothing Then
                    Try
                        e.Value = Integer.Parse(e.Value.ToString).ToString
                        e.FormattingApplied = True
                    Catch ex As FormatException
                        Console.WriteLine("{0} is not a valid date.", e.Value.ToString())
                    End Try
                End If
            End If
        End If
    End Sub



    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
    End Sub

    Private Sub CalculaEnvases()
        Dim lc_TotalEnvases As Integer = 0
        lc_CantEnvases = lsv_Envases.Items.Count

        If tbx_EnvasesSn.Text.Trim = "" Then
            tbx_EnvasesSn.Text = 0
        End If
        lc_TotalEnvases = tbx_EnvasesSn.Text + lc_CantEnvases
        lbl_TotalEnvases.Text = lc_TotalEnvases
    End Sub

    Private Function ValidaGrid() As Decimal
        Dim lc_Dr As DataRow
        Dim lc_Efectivo As Decimal = 0.0
        Dim lc_Documento As Decimal = 0.0

        For Each lc_Dr In dt_Dinero.Rows
            lc_Efectivo += lc_Dr(2)
            lc_Documento += lc_Dr(3)
        Next
        Return lc_Efectivo + lc_Documento
    End Function

    Private Sub LimpiarPantalla()
        Btn_Guardar.Enabled = False
        dt_paso = cn_Recepcion.fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_paso
        FormatoGrid()
        lsv_Envases.Items.Clear()
        tbx_EnvasesSn.Text = ""
        lbl_TotalEnvases.Text = ""

        tbx_Hora.Clear()
        tbx_Min.Clear()
        tbx_TotalRemision.Clear()

        cmb_Rutas.SelectedValue = 0
        cmb_Operador.SelectedValue = 0
        cmb_Custodio.SelectedValue = 0
        lsv_Custodios.Items.Clear()
        cmb_Cliente.SelectedValue = 0

        tbx_Esclusa.Text = 0
        dtp_FechaActa.Value = Today.ToShortDateString
        tbx_HoraActa.Text = "00"
        tbx_MinActa.Text = "00"
        rtb_Motivo.Clear()
        rtb_Observaciones.Clear()

        tbx_Remision.Focus()

    End Sub

    Private Sub grbEnvases_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Envases.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If cmb_Cia.SelectedValue = 0 Then
            MsgBox("Seleccione la Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Exit Sub
        End If

        If tbx_Remision.Text = "" Then
            MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If

        LimpiarPantalla()

        Dim dr_Remision As DataRow = fn_ComprobarRemision_ObtenerID(tbx_Remision.Text, cmb_Cia.SelectedValue)

        If dr_Remision IsNot Nothing Then
            tbx_Remision.Tag = dr_Remision("Id_Remision")
            tbx_Hora.Text = Microsoft.VisualBasic.Left(dr_Remision("Hora_Remision"), 2)
            tbx_Min.Text = Microsoft.VisualBasic.Right(dr_Remision("Hora_Remision"), 2)
            tbx_EnvasesSn.Text = dr_Remision("EnvasesSN")
            If dr_Remision("Status") = "FUERA" Then
                MsgBox("Esta Remisión no se encuentra disponible en Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
                Btn_Guardar.Enabled = False
            ElseIf dr_Remision("Status") = "DENTRO" Then
                Btn_Guardar.Enabled = True
            End If
        Else
            MsgBox("La Remisión no existe o no corresponde a la Compañía de Traslado mostrada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        dt_Dinero = fn_ComprobarRemision_RemisionesD(tbx_Remision.Tag)
        If dt_Dinero IsNot Nothing Then
            CargaDatosEnvases()
            CalculaEnvases()
            LlenaGridDinero()
            CalculaImporteTotal()
        Else
            MsgBox("No se encontraron los Importes por Moneda de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        dr_Programacion = fn_AnomaliasEnvases_ObtenerDatos(tbx_Remision.Tag)
        If dr_Programacion IsNot Nothing Then
            CargaDatosTripulacion()
        Else
            MsgBox("La Remisión no es un depósito o custodia de cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            LimpiarPantalla()
            tbx_Remision.Focus()
            Exit Sub
        End If

        If Not fn_AnomaliasEnvases_ObtenerCustodios(dr_Programacion("Id_Programacion"), lsv_Custodios) Then
            MsgBox("Ha ocurrido un error al intentar cargar los Custodios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        tbx_Esclusa.Focus()
    End Sub

    Private Sub CargaDatosEnvases()
        dt_Envases = fn_ComprobarRemision_LlenarEnvases(tbx_Remision.Tag)
        If dt_Envases IsNot Nothing Then
            If dt_Envases.Rows.Count > 0 Then
                Dim dr_e As DataRow
                For Each dr_e In dt_Envases.Rows
                    lsv_Envases.Items.Add(dr_e(1).ToString)                                         'Descripcion
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = dr_e(0).ToString           'Id_Envase
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(dr_e(2).ToString)   'Numero
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(dr_e(3).ToString)   'Id_TipoE
                Next
            End If
        End If
    End Sub

    Private Sub LlenaGridDinero()
        Dim lc_dr As DataRow
        Dim lc_drD As DataRow

        For Each lc_dr In dt_paso.Rows
            For Each lc_drD In dt_Dinero.Rows
                If lc_dr("Id_Moneda") = lc_drD("Id_Moneda") Then
                    lc_dr("Importe Efectivo") = lc_drD("Efectivo")
                    lc_dr("Importe Documentos") = lc_drD("Documentos")
                    lc_dr("TipoCambio") = lc_drD("Tipo Cambio")
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub CalculaImporteTotal()
        If dt_paso.Rows.Count > 0 Then
            Dim DR_lc As DataRow
            Dim Efectivo As Decimal = 0
            Dim Documentos As Decimal = 0

            For Each DR_lc In dt_paso.Rows
                Efectivo += CDec(DR_lc("Importe Efectivo").ToString) * CDec(DR_lc("TipoCambio").ToString)
                Documentos += CDec(DR_lc("Importe Documentos").ToString) * CDec(DR_lc("TipoCambio").ToString)
            Next

            tbx_TotalRemision.Text = Efectivo + Documentos
        Else
            tbx_TotalRemision.Text = 0
        End If

        tbx_TotalRemision.Text = Format(CDec(tbx_TotalRemision.Text), "N2")

    End Sub

    Sub CargaDatosTripulacion()
        cmb_Rutas.SelectedValue = dr_Programacion("Id_Ruta")
        cmb_Cliente.SelectedValue = dr_Programacion("Cliente_Origen")
        cmb_Operador.SelectedValue = dr_Programacion("Operador")
        cmb_Custodio.SelectedValue = dr_Programacion("Cajero")
    End Sub

    Private Sub tbx_HoraActa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_HoraActa.Leave
        If tbx_HoraActa.Text.Trim = "" Then
            MsgBox("Capture las Horas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraActa.Focus()
            Exit Sub
        End If
        If CInt(tbx_HoraActa.Text) > 23 Or tbx_HoraActa.Text.Trim = "" Then
            MsgBox("La Hora debe ser menor de 23.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_HoraActa.Focus()
            Exit Sub
        End If
        If CInt(tbx_HoraActa.Text) = 0 Then tbx_HoraActa.Text = "00"

    End Sub

    Private Sub tbx_MinActa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_MinActa.Leave
        If tbx_MinActa.Text.Trim = "" Then
            MsgBox("Capture los Minutos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_MinActa.Focus()
            Exit Sub
        End If
        If CInt(tbx_MinActa.Text) > 59 Then
            MsgBox("Los Minutos deben ser menor de 59.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_MinActa.Focus()
            Exit Sub
        End If
        If CInt(tbx_MinActa.Text) = 0 Then tbx_MinActa.Text = "00"
    End Sub

    Private Sub rtb_Motivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb_Motivo.TextChanged

        'rtb_Motivo.Text = rtb_Motivo.Text.ToUpper
    End Sub

    Private Sub rtb_Motivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Motivo.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If Integer.Parse(tbx_Esclusa.Text) = 0 Then
            MsgBox("Capture el Número de Esclusa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Esclusa.Focus()
            Exit Sub
        End If
        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número Remisión.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        If CDec(tbx_HoraActa.Text) = 0 And CDec(tbx_MinActa.Text) = 0 Then
            MsgBox("Indíque la Hora de captura de la Acta.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_HoraActa.Focus()
            Exit Sub
        End If
        If tbx_HoraActa.Text.Trim = "" Or tbx_MinActa.Text.Trim = "" Then
            MsgBox("Indíque la Hora de captura de la Acta.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_HoraActa.Focus()
            Exit Sub
        End If
        If rtb_Motivo.Text = "" Or rtb_Motivo.Text.Length <= 10 Then
            MsgBox("Capture el Motivo del Acta, sea explícito.", MsgBoxStyle.Information, frm_MENU.Text)
            rtb_Motivo.Focus()
            Exit Sub
        End If
        If rtb_Observaciones.Text = "" Or rtb_Observaciones.Text.Length < 10 Then
            MsgBox("Capture las Observaciones del Acta, sea explícito.", MsgBoxStyle.Information, frm_MENU.Text)
            rtb_Observaciones.Focus()
            Exit Sub
        End If

        Dim HoraActa As String = tbx_HoraActa.Text & ":" & tbx_MinActa.Text
        ActaID = fn_AnomaliasEnvases_GuardarActa(tbx_Remision.Tag, dr_Programacion("Id_Punto"), dtp_FechaActa.Value.Date, HoraActa, tbx_Esclusa.Text, cmb_Cliente.SelectedValue, rtb_Motivo.Text, rtb_Observaciones.Text)
        If ActaID > 0 Then
            'Guardar en Bitacora
            'FuncionesGlobales.fn_GuardaBitacora(15, "REMISION: " & tbx_Remision.Text & " CIA_PROP: " & cmb_Cia.Text, tbx_Remision.Tag)
            Cn_Login.fn_Log_Create("CAPTURA DE ACTA DE ANOMALIAS EN ENVASES: " & tbx_Remision.Text & " CIA: " & cmb_Cia.Text & "IMPORTE: " & tbx_TotalRemision.Text.Trim)
            MsgBox("El Acta se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Btn_Guardar.Enabled = False
        Else
            MsgBox("Ocurrió un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'Se muestra el Acta para imprimirla
        If Not fn_AnomaliasEnvases_MostrarActa(ActaID, tbx_Remision.Tag, dr_Programacion("Id_Programacion")) Then
            MsgBox("El Acta se generó pero ocurrió un error al intentar Imprimirla.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        'Se limpia la pantalla
        tbx_Remision.Clear()
        Call LimpiarPantalla()

    End Sub

    Private Sub dtp_FechaActa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaActa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_Hora.Focus()
        End If
    End Sub
End Class


