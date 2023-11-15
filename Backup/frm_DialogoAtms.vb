Public Class frm_DialogoAtms

    Public dt_Dinero As DataTable
    Public dt_paso As DataTable
    Public Id_PuntoC As Integer
    Public Id_Falla As Integer
    Public DotacionID As Integer
    Public ProgramacionID As Integer
    Public COrigen As String
    Public CDestino As String
    Public IDBoveda As Integer = 0
    Public RemisionID As Integer = 0
    Public Cancelado As Boolean = True
    Public Es_Falla As Boolean = False
    Public Es_NoAplicada As Boolean = False

    Public Nuevo As Boolean = False
    Private dt_Envases As DataTable
    Public Status As String
    Public Utiliza_Rd As String = "N"
    Public Clave_Cliente As String = "0"
    Dim Id_R As Integer
    Dim Numero As Integer
    Public faltante As Boolean = False
    Private Sub Regresar_StatusRemision()
        If faltante Then
            cn_Recepcion.fn_RegresarSta(Id_R)
        Else
            cn_Recepcion.fn_Des_Remision(Clave_Cliente, Numero)
        End If
    End Sub

    Private Sub Obtener_NumeroRemision()
        Dim tbl As DataTable
        tbl = cn_Recepcion.fn_VerificarNr(Clave_Cliente)
        If tbl Is Nothing Then Exit Sub
        If (tbl.Rows.Count > 0 And tbl.Rows(0)("Minn").ToString() <> "" And tbl.Rows(0)("ID").ToString() <> "") Then
            tbx_Remision.Text = tbl.Rows(0)("Num").ToString()
            Numero = tbl.Rows(0)("Minn").ToString()
            Id_R = CInt(tbl.Rows(0)("ID").ToString())
            faltante = True
        Else
            Dim table As DataTable = cn_Recepcion.fn_NumeroR(Clave_Cliente)
            tbx_Remision.Text = table.Rows(0)(0).ToString()
            Numero = CInt(table.Rows(0)("Num").ToString())
        End If
    End Sub
    Private Sub frm_DialogoAtms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_TipoEnvase.Actualizar()
        dt_paso = cn_Recepcion.fn_ReRutasExternas_Monedas
        dgDinero.DataSource = dt_paso
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        Else
            lsv_Envases.Items.Clear()
        End If

        If Nuevo = True Then
            tbx_Remision.Enabled = True
            If Utiliza_Rd = "S" Then
                Obtener_NumeroRemision()
            End If
        Else
            dt_Dinero = cn_Recepcion.fn_RecRutasRemisionesDById(RemisionID)
            tbx_Remision.Enabled = False
            Call CargaDatosEnvases()
            If dt_Dinero IsNot Nothing Then
                Call LlenaGridDinero()
                Call CalculaImporteTotal()
            End If
        End If

        Call FormatoGrid()
        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 49, 0, 0, 0, 0, 0, 0, 0, 0)
        If Utiliza_Rd = "S" Then Buscar_Numero() ''Color_Item(lsv_Envases) ''Activa el boton de guardar si ya se escaneron el total de envases
        tbx_Remision.Focus()

    End Sub

    Function Buscar_Numero() As Boolean
        Dim cont As Integer
        For Each Elemento As ListViewItem In lsv_Envases.Items
            For Each NumeroE As String In List_Envases
                If NumeroE = Elemento.SubItems(1).Text Then
                    Elemento.BackColor = Color.LightGreen
                    cont += 1
                    Exit For
                End If
            Next
        Next
        If cont <> lsv_Envases.Items.Count Then btn_Guardar.Enabled = False
        If cont = lsv_Envases.Items.Count Then btn_Guardar.Enabled = True
    End Function

    Sub Color_Item(ByVal lsv As ListView)
        Dim cont As Integer
        For Each elemento As ListViewItem In lsv.Items
            If List_Envases.BinarySearch(elemento.SubItems(1).Text) >= 0 Then
                elemento.BackColor = Color.LightGreen
                cont += 1
            End If
        Next
        btn_Guardar.Enabled = (cont = lsv_Envases.Items.Count)
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        SegundosDesconexion = 0
        If cmb_TipoEnvase.SelectedValue = 0 Or tbx_Numero.Text.Trim = "" Then
            MsgBox("Capture un numero de Envase", MsgBoxStyle.Critical, frm_MENU.Text)
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

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        If Utiliza_Rd = "S" AndAlso Nuevo Then
            Regresar_StatusRemision()
        End If
        Cancelado = True
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If tbx_Envases.Text = "" Then tbx_Envases.Text = 0

        If Val(tbx_TotalRemision.Text) = 0 Then
            MsgBox("Debe capturar los Importes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Envases.Items.Count = 0 And Val(tbx_Envases.Text) = 0 Then
            MsgBox("Capture por lo menos un Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Envases.Items IsNot Nothing Then
            Envases = lsv_Envases.Items.Count
        End If

        EnvasesSN += tbx_Envases.Text.Trim

        If Nuevo = True Then
            If tbx_Remision.Text.Trim = "" Then
                MsgBox("Número de Remisión no válido.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Remision.Focus()
                Exit Sub
            End If
            If cn_Recepcion.fn_Remision_Existe(tbx_Remision.Text, CiaId) Then
                MsgBox("El Número de Remisión ya existe", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If Es_Falla Then
                If cn_Recepcion.fn_RecRutasPropiasCustodiaAtmsFallas(tbx_Remision.Text, ProgramacionID, Envases, EnvasesSN, tbx_TotalRemision.Text, Id_Falla, dt_paso, lsv_Envases, IDBoveda, CDestino, COrigen) = True Then
                    MsgBox("Registro Guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ocurrió un error al intentar guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                'Aqui se guarda cuando es Remanente o No Aplicada
                If cn_Recepcion.fn_RecRutasPropiasRemanentesAtms(tbx_Remision.Text.Trim, ProgramacionID, Envases, EnvasesSN, tbx_TotalRemision.Text.Trim, Id_PuntoC, DotacionID, dt_paso, lsv_Envases, IDBoveda, CDestino, COrigen) = True Then
                    MsgBox("Registro Guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ocurrió un error al intentar guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            End If
        Else
            If Es_Falla Then
                If cn_Recepcion.fn_RecRutasPropiasCustodiaAtmsFallas_Update(RemisionID, tbx_Remision.Text, Envases, EnvasesSN, tbx_TotalRemision.Text, Id_Falla, dt_paso, lsv_Envases, IDBoveda, CDestino, COrigen) = True Then
                    MsgBox("Registro Actualizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ocurrió un error al intentar guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                'Aqui se actualiza cuando es Remanente o No Aplicada
                If cn_Recepcion.fn_RecRutasPropiasAtmsRemanentes_Update(RemisionID, tbx_Remision.Text.Trim, Envases, EnvasesSN, CDec(tbx_TotalRemision.Text), Id_PuntoC, dt_paso, lsv_Envases, DotacionID, IDBoveda, CDestino, COrigen) = True Then
                    MsgBox("Registro Actualizado.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    MsgBox("Ocurrió un error al intentar guardar la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            End If
        End If

        Cancelado = False
        Me.Close()
    End Sub

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
    End Sub

    Private Sub lsv_Envases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Envases.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Envases.SelectedItems.Count > 0 Then
            btn_Eliminar.Enabled = True
        Else
            btn_Eliminar.Enabled = False
        End If

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
            '.GridColor = Color.Black
            .RowHeadersVisible = False

            .Columns(0).Name = "Id_Moneda"
            .Columns(0).Visible = False
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(1).Name = "Moneda"
            .Columns(1).Width = 70
            .Columns(1).ReadOnly = True
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(2).Name = "Importe Efectivo"
            .Columns(2).ReadOnly = False
            .Columns(2).Width = 100
            .Columns(2).DefaultCellStyle.Format = "N2"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).Name = "Importe Documentos"
            .Columns(3).ReadOnly = False
            .Columns(3).Width = 100
            .Columns(3).DefaultCellStyle.Format = "N2"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(4).Name = "TipoCambio"
            .Columns(4).ReadOnly = True
            .Columns(4).Width = 80
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            .MultiSelect = False
        End With
    End Sub

    Private Sub CargaDatosEnvases()
        dt_Envases = cn_Recepcion.fn_RecRutasPropiasEnvases(RemisionID)
        If dt_Envases IsNot Nothing Then
            If dt_Envases.Rows.Count > 0 Then
                Dim dr_e As DataRow
                For Each dr_e In dt_Envases.Rows
                    lsv_Envases.Items.Add(dr_e(1).ToString)
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = dr_e(0).ToString
                    lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(dr_e(2).ToString)
                Next
            End If
        End If
    End Sub

    Private Sub CalculaImporteTotal()

        If dt_paso.Rows.Count > 0 Then

            Dim DR_lc As DataRow
            Dim Efectivo As Decimal = 0
            Dim Documentos As Decimal = 0

            For Each DR_lc In dt_paso.Rows
                Efectivo += DR_lc(2).ToString * DR_lc(4).ToString
                Documentos += DR_lc(3).ToString
            Next

            tbx_TotalRemision.Text = Efectivo + Documentos
        Else
            tbx_TotalRemision.Text = 0
        End If

    End Sub

    Private Sub dgDinero_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellValueChanged
        SegundosDesconexion = 0

        Call CalculaImporteTotal()
    End Sub

    Private Sub dgDinero_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDinero.DataError

        MsgBox("Valor Inválido, Capture un  Número", MsgBoxStyle.Critical, frm_MENU.Text)

    End Sub

    Private Sub LlenaGridDinero()
        Dim lc_dr As DataRow
        Dim lc_drD As DataRow
        For Each lc_dr In dt_paso.Rows
            For Each lc_drD In dt_Dinero.Rows
                If lc_dr(0) = lc_drD(0) Then
                    lc_dr(2) = lc_drD(2)
                    lc_dr(3) = lc_drD(3)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub frm_DialogoAtms_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SegundosDesconexion = 0
        If Utiliza_Rd = "S" AndAlso Nuevo Then
            Regresar_StatusRemision()
        End If
    End Sub
End Class