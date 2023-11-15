Public Class frm_MovInt_Custodias
    Private dt_Dinero As New DataTable
    Private lc_CantEnvases As Integer = 0

    Private Sub frm_RecepcionRutasExternas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BanderA = False

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()

        cmb_ClienteOrigen.Actualizar()
        cmb_ClienteDestino.Actualizar()

        cmb_Ruta.Actualizar()

        BanderA = True

        dt_Dinero = cn_Recepcion.fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_Dinero
        FormatoGrid()
        Btn_Guardar.Enabled = False

        cmb_TipoEnvase.Actualizar()

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        End If

        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 50, 0, 0, 0, 0, 0, 0, 0, 0)

        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

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

        MsgBox("Dato no válido. Capture un Número.", MsgBoxStyle.Critical, frm_MENU.Text)

    End Sub


    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0

        If cmb_Boveda.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Bóveda", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Boveda.Focus()
            Exit Sub
        End If

        If cmb_ClienteOrigen.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Origen.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClienteOrigen.Focus()
            Exit Sub
        End If

        If cmb_ClienteDestino.SelectedValue = "0" Then
            MsgBox("Debe seleccionar un Destino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ClienteDestino.Focus()
            Exit Sub
        End If

        If cmb_Ruta.SelectedValue = "0" Then
            MsgBox("Debe seleccionar una Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ruta.Focus()
            Exit Sub
        End If
        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture el Número de Remisión.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        If cn_Recepcion.fn_Remision_Existe(CLng(tbx_Remision.Text), CiaId) Then
            MsgBox("El Número de Remisión ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        If ValidaGrid() > 0 Then
            If cn_Recepcion.fn_MovIntCustodias_Guardar(tbx_Remision.Text, lsv_Envases.Items.Count, tbx_EnvasesSn.Text, _
                                                   ValidaGrid(), CiaId, cmb_Boveda.SelectedValue, cmb_ClienteDestino.SelectedValue, cmb_ClienteOrigen.SelectedValue, _
                                                   dt_Dinero, lsv_Envases, cmb_Ruta.SelectedValue) Then
                MsgBox("Se guardó con exito", MsgBoxStyle.Information, frm_MENU.Text)
                limpiarpantalla()
            End If
        Else
            MsgBox("Debe indicar un Importe para la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If 'ValidaGrid
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
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = cmb_TipoEnvase.SelectedValue.ToString
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(tbx_Numero.Text)
            Else
                MsgBox("Envase ya capturado", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Numero.Focus()
                Exit Sub
            End If

        End If

        tbx_Numero.Clear()
        tbx_Numero.Focus()
        Btn_Agregar.Enabled = False
        CalculaEnvases()

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

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        lsv_Envases.Items(lsv_Envases.SelectedItems(0).Index).Remove()
        Call CalculaEnvases()
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Envases.SelectedItems.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If

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


        If lbl_TotalEnvases.Text > 0 Then

            Btn_Guardar.Enabled = True
        Else
            Btn_Guardar.Enabled = False

        End If

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

    Private Sub limpiarpantalla()

        tbx_Remision.Clear()

        dt_Dinero = cn_Recepcion.fn_ReRutasExternas_Monedas()
        dgDinero.DataSource = dt_Dinero
        FormatoGrid()

        lsv_Envases.Items.Clear()
        tbx_EnvasesSn.Text = ""

    End Sub


    Private Sub cmb_Cliente_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ClienteDestino.VisibleChanged
        SegundosDesconexion = 0

        cmb_ClienteDestino.SelectedValue = "0"
    End Sub

    Private Sub cmb_Banco_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClienteOrigen.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_ClienteOrigen.SelectedValue IsNot Nothing Then
            cmb_ClienteDestino.Actualizar()
        End If
    End Sub

End Class


