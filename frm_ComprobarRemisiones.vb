Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_ComprobarRemisiones
    Private dt_Dinero As New DataTable
    Private dt_Envases As New DataTable
    Public dt_Paso As New DataTable
    Private lc_CantEnvases As Integer = 0
    Dim ClienteDestino As Integer = 0

    Private Sub frm_ComprobarRemisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Cia.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_Cia.Actualizar()

        cmb_CiaProp.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_CiaProp.Actualizar()

        BanderA = True

        dt_Paso = fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_paso
        FormatoGrid()
        Btn_Guardar.Enabled = False

        cmb_TipoEnvase.Actualizar()

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        End If

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)
        cmb_Cia.SelectedValue = CiaId
        btn_Modificar.Enabled = False
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False
        tbx_Remision.Focus()

    End Sub

    Private Sub cmb_Cia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedIndexChanged
        SegundosDesconexion = 0

        LimpiarPantalla()
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub FormatoGrid()
        If dgDinero.Columns.Count = 0 Then Exit Sub
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
            .Columns(2).Width = 145
            .Columns(2).DefaultCellStyle.Format = "N2"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).Name = "Importe Documentos"
            .Columns(3).ReadOnly = False
            .Columns(3).Width = 150
            .Columns(3).DefaultCellStyle.Format = "N2"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(4).Name = "TipoCambio"
            .Columns(4).ReadOnly = True
            .Columns(4).Width = 80
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            '.Columns(4).DefaultCellStyle.Font = _
            '    New Font(Me.dgDinero.DefaultCellStyle.Font, FontStyle.Italic)

            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .MultiSelect = False
        End With
    End Sub

    Private Sub dgDinero_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgDinero.CellFormatting
        If Me.dgDinero.Columns(e.ColumnIndex).Name = "Importe Efectivo" Then
            If e IsNot Nothing Then
                If e.Value IsNot Nothing Then
                    Try
                        'e.Value = DateTime.Parse(e.Value.ToString()).ToLongDateString()
                        e.Value = Integer.Parse(e.Value.ToString).ToString
                        e.FormattingApplied = True
                    Catch ex As FormatException
                        Console.WriteLine("{0} is not a valid date.", e.Value.ToString())
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub dgDinero_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDinero.DataError
        MsgBox("Valor Inválido, Capture un Número", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If lsv_Envases.Items IsNot Nothing Then
            Envases = lsv_Envases.Items.Count
        End If

        If tbx_EnvasesSn.Text.Trim <> "" Then
            EnvasesSN = Integer.Parse(tbx_EnvasesSn.Text)
        End If

        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número Remisión.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        If cmb_CiaProp.SelectedIndex = 0 Then
            MsgBox("Seleccione la Compañía Propietaria de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CiaProp.Focus()
            Exit Sub
        End If
        If tbx_Hora.Text.Trim = "" Or tbx_Min.Text.Trim = "" Then
            MsgBox("Capture la Hora de la Remisión.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If

        Dim HoraRemision As String = tbx_Hora.Text.Trim & ":" & tbx_Min.Text.Trim

        If CDec(tbx_TotalRemision.Text.Trim) > 0 Then
            If fn_ComprobarRemision_Update(tbx_Remision.Tag, cmb_Cia.SelectedValue, cmb_CiaProp.SelectedValue, Envases, EnvasesSN, CDec(tbx_TotalRemision.Text), dt_Paso, lsv_Envases, HoraRemision) = True Then
                Cn_Login.fn_Log_Create("MODIFICACIÓN DE REMISIÓN: " & tbx_Remision.Text & " CIA: " & cmb_Cia.Text & " CIA NUEVA: " & cmb_CiaProp.Text)
                Call Mostrar()

                MsgBox("Remisión actualizada correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If

        End If
        tbx_Remision.SelectAll()
        tbx_Remision.Focus()

    End Sub

    Private Sub lbl_TotalEnvases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lbl_TotalEnvases.Text = 0 Then
            Btn_Guardar.Enabled = False
        Else
            If tbx_Remision.Text.Trim <> "" Then
                Btn_Guardar.Enabled = True
            End If
        End If
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        SegundosDesconexion = 0

        If cmb_TipoEnvase.SelectedValue = 0 Or tbx_Numero.Text.Trim = "" Then
            Exit Sub
        Else
            If ValidaEnvase() = True Then
                lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
                If tbx_Numero.Tag Is Nothing Then tbx_Numero.Tag = 0
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = tbx_Numero.Tag
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(tbx_Numero.Text)
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(cmb_TipoEnvase.SelectedValue)
            Else
                MsgBox("Envase ya capturado.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Numero.Focus()
                Exit Sub
            End If
        End If
        tbx_Numero.Clear()
        tbx_Numero.Tag = 0
        tbx_Numero.Focus()
        cmb_TipoEnvase.SelectedValue = 0
        Btn_Agregar.Enabled = False
        btn_Modificar.Enabled = False
        Btn_Guardar.Enabled = True
        Call CalculaEnvases()
    End Sub

    Private Function ValidaEnvase() As Boolean
        Dim Elemento As ListViewItem
        For Each Elemento In lsv_Envases.Items
            If Elemento.SubItems(1).Text = tbx_Numero.Text Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub cmb_TipoEnvase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEnvase.SelectedIndexChanged
        SegundosDesconexion = 0

        Call validabotonagregar()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Numero.TextChanged
        SegundosDesconexion = 0

        Call validabotonagregar()
    End Sub

    Private Sub validabotonagregar()
        If cmb_TipoEnvase.SelectedValue <> 0 Then
            If tbx_Numero.Text.Trim <> "" Then
                Btn_Agregar.Enabled = True
            End If
        Else
            Btn_Agregar.Enabled = False
        End If
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Eliminar.Enabled = lsv_Envases.SelectedItems.Count > 0
        btn_Modificar.Enabled = lsv_Envases.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        If Not fn_ComprobarRemision_BorrarEnvase(lsv_Envases.SelectedItems(0).Tag) Then
            MsgBox("Ha ocurrido un error al intentar eliminar el Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        CargaDatosEnvases()
        CalculaEnvases()
    End Sub

    Private Sub tbx_EnvasesSn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_EnvasesSn.TextChanged
        SegundosDesconexion = 0

        Call CalculaEnvases()
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

        dt_paso = cn_Recepcion.fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_paso
        FormatoGrid()
        tbx_Numero.Clear()
        tbx_Numero.Tag = 0
        tbx_Remision.Tag = 0
        cmb_TipoEnvase.SelectedValue = 0
        lsv_Envases.Items.Clear()
        tbx_EnvasesSn.Text = ""

        tbx_Hora.Clear()
        tbx_Min.Clear()
        tbx_TotalRemision.Clear()
        cmb_CiaProp.SelectedValue = 0
        Btn_Guardar.Enabled = False

    End Sub

    Private Sub grbEnvases_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grbEnvases.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Sub InicializarBotones()
        btn_Modificar.Enabled = False
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Call Mostrar()
    End Sub

    Private Sub tbx_Remision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Mostrar()
        End If
    End Sub

    Sub Mostrar()
        SegundosDesconexion = 0

        Call LimpiarPantalla()
        Call InicializarBotones()

        If cmb_Cia.SelectedValue = 0 Then
            MsgBox("Seleccione la Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cia.Focus()
            Exit Sub
        End If

        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        'Se consulta por la Compañía de Traslado
        Dim dr_Remision As DataRow = fn_ComprobarRemision_ObtenerID(tbx_Remision.Text.Trim, cmb_Cia.SelectedValue)

        If dr_Remision IsNot Nothing Then
            tbx_Remision.Tag = dr_Remision("Id_Remision")
            cmb_CiaProp.SelectedValue = dr_Remision("IDCP")
            tbx_Hora.Text = Microsoft.VisualBasic.Left(dr_Remision("Hora_Remision"), 2)
            tbx_Min.Text = Microsoft.VisualBasic.Right(dr_Remision("Hora_Remision"), 2)
            tbx_EnvasesSn.Text = dr_Remision("EnvasesSN")
            If dr_Remision("Status") = "FUERA" Then
                MsgBox("Esta Remisión no se encuentra disponible en Bóveda, por lo que no podrá ser modificada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Btn_Guardar.Enabled = False
                grbEnvases.Enabled = False
                gbx_Total.Enabled = False
                dgDinero.Enabled = False
                cmb_CiaProp.Enabled = False
            ElseIf dr_Remision("Status") = "DENTRO" Then
                Btn_Guardar.Enabled = True
                grbEnvases.Enabled = True
                gbx_Total.Enabled = True
                dgDinero.Enabled = True
                cmb_CiaProp.Enabled = True
            End If
        Else
            MsgBox("La Remisión no existe o no corresponde a la Compañía de Traslado seleccionada.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        dt_Dinero = cn_Recepcion.fn_ComprobarRemision_RemisionesD(tbx_Remision.Tag)
        If dt_Dinero IsNot Nothing Then
            CargaDatosEnvases()
            CalculaEnvases()
            LlenaGridDinero()
            CalculaImporteTotal()
        Else
            MsgBox("No se encontraron los Importes por Moneda de la Remisión", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        tbx_Remision.SelectAll()
        tbx_Remision.Focus()
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

        For Each lc_dr In dt_Paso.Rows
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
        If dt_Paso.Rows.Count > 0 Then
            Dim DR_lc As DataRow
            Dim Efectivo As Decimal = 0
            Dim Documentos As Decimal = 0

            For Each DR_lc In dt_Paso.Rows
                Efectivo += CDec(DR_lc("Importe Efectivo").ToString) * CDec(DR_lc("TipoCambio").ToString)
                Documentos += CDec(DR_lc("Importe Documentos").ToString) * CDec(DR_lc("TipoCambio").ToString)
            Next

            tbx_TotalRemision.Text = Efectivo + Documentos
        Else
            tbx_TotalRemision.Text = 0
        End If

        tbx_TotalRemision.Text = Format(CDec(tbx_TotalRemision.Text), "N2")

    End Sub

    Private Sub dgDinero_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellValueChanged
        CalculaImporteTotal()
    End Sub

    Private Sub tbx_Hora_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Hora.Leave
        If CInt(tbx_Hora.Text) > 23 Then
            MsgBox("La Hora debe ser menor de 23.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Hora.Focus()
            Exit Sub
        End If
        If CInt(tbx_Hora.Text) = 0 Then tbx_Hora.Text = "00"

    End Sub

    Private Sub tbx_Min_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Min.Leave
        If CInt(tbx_Min.Text) > 59 Then
            MsgBox("Los Minutos deben ser menor de 59.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Min.Focus()
            Exit Sub
        End If
        If CInt(tbx_Min.Text) = 0 Then tbx_Min.Text = "00"
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        tbx_Numero.Text = lsv_Envases.SelectedItems(0).SubItems(1).Text
        tbx_Numero.Tag = lsv_Envases.SelectedItems(0).Tag
        cmb_TipoEnvase.SelectedValue = lsv_Envases.SelectedItems(0).SubItems(2).Text
        lsv_Envases.SelectedItems(0).Remove()
        Btn_Guardar.Enabled = False
    End Sub

    Private Sub tbx_Hora_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Hora.GotFocus
        tbx_Hora.SelectAll()
    End Sub

    Private Sub tbx_Min_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Min.GotFocus
        tbx_Min.SelectAll()
    End Sub


End Class


