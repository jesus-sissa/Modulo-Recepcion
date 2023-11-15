Imports Modulo_Recepcion.cn_Recepcion
Public Class frm_Dialogo

    Public dt_Dinero As DataTable
    Public dt_Monedas As DataTable
    Public Id_Punto As Long
    Public Id_Remision As Long
    Public Id_CiaProp As Integer
    Private dt_Envases As DataTable
    Public Nuevo As Boolean = False
    Public Validar As Boolean = False
    Public RR As Boolean = False
    Public Bloqueado As Boolean = False
    Public Reemplazar As Boolean = False ' Se utiliza cuando una Remision amparará otra
    Public Id_Bo As Integer = 0
    Public Hora_Remision As String = "00:00"
    ''Remisiones digitales
    Public T As Boolean = False
    Public Cant_env As Integer = 0
    Public Numero_env As String = 0
    Public Cant_env_scan As Integer = 0
    Public NuevoD As Boolean = False
    Public CPadre As String = "0"
    ''>>
    Dim Id_R As Integer
    Dim Numero As Integer
    Public faltante As Boolean = False
    ''25/08/2020
    Public tipoRemision As Integer
    Public UtilizaRd As String = "N" 'Jesus 27/10/2021
    Public Id_CO As Integer
    Public Function Obtener_Co()
        Dim data As DataTable
        data = fn_Cliente_Padre(Id_CO)
        If data.Rows.Count > 0 Then
            CPadre = data.Rows(0)("Clave")
            UtilizaRd = data.Rows(0)("UtilizaRemisionD")
        End If
    End Function

    Private Sub frm_Dialago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Obtenemos la clave del cliente origen y si trabaja con remision digital 01/12/21
        Obtener_Co()
        If UtilizaRd = "S" Then
            Gbx_NRemision.Enabled = False
            dgDinero.Enabled = False
            GpoDatos.Enabled = False
        Else
            Gbx_NRemision.Enabled = True
            dgDinero.Enabled = True
            GpoDatos.Enabled = True
        End If
        Dim dt As DataTable = cmb_CiasProp.DataSource
        If dt Is Nothing OrElse dt.Columns.Count <= 2 Then
            cmb_CiasProp.AgregaParametro("@Id_Cia", 0, 1)
            cmb_CiasProp.AgregaParametro("@Status", "A", 0)
        Else
            cmb_CiasProp.ActualizaValorParametro("@Id_Cia", 0)
            cmb_CiasProp.ActualizaValorParametro("@Status", "A")
        End If
        cmb_CiasProp.Actualizar()
        cmb_CiasProp.SelectedValue = Id_CiaProp
        tbx_Horas.Text = Microsoft.VisualBasic.Left(Hora_Remision, 2)
        tbx_Minutos.Text = Microsoft.VisualBasic.Right(Hora_Remision, 2)

        If RR = True Then
            btn_Regresa.Visible = True
        Else
            btn_Regresa.Visible = False
        End If
        Btn_Agregar.Enabled = False
        btn_Eliminar.Enabled = False
        cmb_TipoEnvase.Actualizar()

        dt_Monedas = cn_Recepcion.fn_ReRutasExternas_Monedas

        If dt_Monedas Is Nothing Then
            MsgBox("Ocurrió un error al cargar las Monedas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Monedas.Rows.Count = 0 Then
            MsgBox("Es probable que no haya tipo de cambio para la fecha actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        dgDinero.DataSource = dt_Monedas

        If lsv_Envases.Columns.Count = 0 Then
            lsv_Envases.Columns.Add("Tipo de Envase")
            lsv_Envases.Columns.Add("Numero de Envase")
        Else
            lsv_Envases.Items.Clear()
        End If

        If Nuevo Then
            Gbx_NRemision.Enabled = True
            dgDinero.Enabled = True
            GpoDatos.Enabled = True
            tbx_Remision.Enabled = True
            cmb_CiasProp.Enabled = True
            'Se comento por que indicaron que se utilizaran comprobantes de traslado con numeros de remision 01/12/2021
            'If UtilizaRd = "S" Then
            '    Obtener_NumeroRemision() ''Generar el numero de remision por el sistema.
            'End If
            btn_Guardar.Enabled = True
        Else
            'cmb_CiasProp.Enabled = False
            cmb_CiasProp.Enabled = True
            dt_Dinero = cn_Recepcion.fn_RecRutasRemisionesDById(tbx_Remision.Tag) 'Ahora se manda el Id_Remision

            If Validar = True Then
                tbx_Remision.Enabled = True
            Else
                tbx_Remision.Enabled = False
            End If
            Call CargaDatosEnvases()
            Call LlenaGridDinero()
            Call CalculaImporteTotal()
        End If

        If Bloqueado Then
            btn_Guardar.Enabled = False
            btn_Regresa.Enabled = False
            Btn_Agregar.Enabled = False
            btn_Eliminar.Enabled = False
        Else
            btn_Guardar.Enabled = True
            btn_Regresa.Enabled = True
            Btn_Agregar.Enabled = True
        End If

        'Si se está Reemplazando una Remisión
        If Reemplazar Then
            tbx_RemisionOriginal.Visible = False
            lbl_RemisionReemplazo.Visible = True
            tbx_RemisionReemplazo.Visible = True
            tbx_RemisionReemplazo.Enabled = True
        End If

        Call FormatoGrid()
        FuncionesGlobales.fn_Columna(lsv_Envases, 50, 49, 0, 0, 0, 0, 0, 0, 0, 0)
        tbx_Remision.Focus()
        'Remision digital 01/12/21
        If UtilizaRd = "S" Then
            If Nuevo = False And tipoRemision <> 2 Then
                Buscar_Numero()
                'ElseIf Nuevo And Remision <> Nothing Then 'Se quito esta parte por que ya no se utilizara la tabla remoisionesGenera
                '    tbx_Remision.Text = Remision
                '    tbx_Remision.Enabled = False
            End If
            If tipoRemision = 2 Then btn_Guardar.Enabled = True
        End If
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
        If cont <> Cant_env Then btn_Guardar.Enabled = False
        If cont = Cant_env Then btn_Guardar.Enabled = True
    End Function
    Private Sub Obtener_NumeroRemision()
        Dim tbl As DataTable
        tbl = cn_Recepcion.fn_VerificarNr(CPadre)
        If tbl Is Nothing Then Exit Sub
        If (tbl.Rows.Count > 0 And tbl.Rows(0)("Minn").ToString() <> "" And tbl.Rows(0)("ID").ToString() <> "") Then
            tbx_Remision.Text = tbl.Rows(0)("Num").ToString()
            Numero = tbl.Rows(0)("Minn").ToString()
            Id_R = CInt(tbl.Rows(0)("ID").ToString())
            faltante = True
        Else
            Dim table As DataTable = cn_Recepcion.fn_NumeroR(CPadre)
            tbx_Remision.Text = table.Rows(0)(0).ToString()
            Numero = CInt(table.Rows(0)("Num").ToString())
        End If
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click

        If cmb_TipoEnvase.SelectedValue = 0 Or tbx_NumeroEnvase.Text.Trim = "" Then
            MsgBox("Capture un Número de Envase.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            If ValidaEnvase() = True Then
                lsv_Envases.Items.Add(cmb_TipoEnvase.Text)
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).Tag = cmb_TipoEnvase.SelectedValue.ToString
                lsv_Envases.Items(lsv_Envases.Items.Count - 1).SubItems.Add(tbx_NumeroEnvase.Text)
            Else
                MsgBox("Envase ya capturado.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_NumeroEnvase.Focus()
                Exit Sub
            End If

        End If

        tbx_NumeroEnvase.Clear()
        tbx_NumeroEnvase.Focus()
        Btn_Agregar.Enabled = False

    End Sub

    Private Function ValidaEnvase() As Boolean
        Dim Elemento As ListViewItem
        For Each Elemento In lsv_Envases.Items
            If Elemento.SubItems(1).Text = tbx_NumeroEnvase.Text Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        'Me.Dispose()
        'If Nuevo AndAlso UtilizaRd = "S" Then Regresar_StatusRemision()
        Me.Close()
    End Sub

    Private Sub btn_Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Regresa.Click
        SegundosDesconexion = 0

        If cn_Recepcion.fn_PuntosRemisiones_Regresar(tbx_Remision.Tag, Id_Punto, "R") = True Then
            MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        Else
            MsgBox("Ocurrió un error al intentar marcar la Remisión para regresar.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        Dim Hora As String

        'cn_Recepcion.fn_FacturacionActualizarRemision(Id_RemisionFacturacion)

        If dt_Monedas Is Nothing Then
            MsgBox("Ocurrió un error al cargar las Monedas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Monedas.Rows.Count = 0 Then
            MsgBox("Es probable que no haya tipo de cambio para la fecha actual.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Reemplazar Then
            Call GuardarReemplazo()
            Exit Sub
        End If

        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If lsv_Envases.Items IsNot Nothing Then
            Envases = lsv_Envases.Items.Count
        End If

        If tbx_EnvasesSN.Text.Trim <> "" Then
            EnvasesSN = Integer.Parse(tbx_EnvasesSN.Text)
        End If

        If Nuevo = True Then
            If cmb_CiasProp.SelectedValue = 0 Then
                MsgBox("Seleccione la Compañía Propietaria de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_CiasProp.Focus()
                Exit Sub
            End If

            If tbx_Remision.Text.Trim = "" Then
                MsgBox("Indique el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Remision.Focus()
                Exit Sub
            End If
            If CInt(tbx_Horas.Text.Trim) < 0 Or CInt(tbx_Horas.Text.Trim) > 23 Then
                MsgBox("La hora capturada parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Horas.Focus()
                Exit Sub
            End If
            If CInt(tbx_Minutos.Text.Trim) < 0 Or CInt(tbx_Minutos.Text.Trim) > 59 Then
                MsgBox("La hora capturada parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Minutos.Focus()
                Exit Sub
            End If
            'Modificar para que mande el Id_CiaProp
            If cn_Recepcion.fn_Remision_Existe(tbx_Remision.Text, cmb_CiasProp.SelectedValue) Then
                MsgBox("El Número de Remisión ya existe para la Compañía " & cmb_CiasProp.Text, MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Remision.SelectAll()
                tbx_Remision.Focus()
                Exit Sub
            End If
            Hora = FuncionesGlobales.fn_PonerCeros(tbx_Horas.Text.Trim, 2) & ":" & FuncionesGlobales.fn_PonerCeros(tbx_Minutos.Text.Trim, 2)
            If cn_Recepcion.fn_RecRutasPropias_Create(tbx_Remision.Text.Trim, Envases, EnvasesSN, tbx_TotalRemision.Text.Trim, Id_Punto, dt_Monedas, CiaId, cmb_CiasProp.SelectedValue, Hora, lsv_Envases) = True Then
                MsgBox("La Remisión se ha guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                'recalcular Tv_puntos-Tv_Programacion 6Sep2014
                cn_Recepcion.fn_Recalcular_TVPuntos_TVProgramacion(Id_Punto)
                cn_Recepcion.fn_deleteT(Id_R)
            End If
            '**Falta recalcular el movimiento al cual pertenezca la remisión capturada

        Else
            If CInt(tbx_Horas.Text.Trim) < 0 Or CInt(tbx_Horas.Text.Trim) > 23 Then
                MsgBox("La hora capturada parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Horas.Focus()
                Exit Sub
            End If
            If CInt(tbx_Minutos.Text.Trim) < 0 Or CInt(tbx_Minutos.Text.Trim) > 59 Then
                MsgBox("La hora capturada parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Minutos.Focus()
                Exit Sub
            End If
            Hora = FuncionesGlobales.fn_PonerCeros(tbx_Horas.Text.Trim, 2) & ":" & FuncionesGlobales.fn_PonerCeros(tbx_Minutos.Text.Trim, 2)
            Dim ActualizarRemision As Boolean = False


            If Validar = True And Val(tbx_Remision.Text.Trim) <> Val(tbx_RemisionOriginal.Text.Trim) Then
                'El numero cambió, revisar si el Numero de Remisión ya existe
                If cn_Recepcion.fn_Remision_Existe(tbx_Remision.Text.Trim, cmb_CiasProp.SelectedValue) Then
                    MsgBox("El Número de Remisión indicado ya existe para la Compañía " & cmb_CiasProp.Text, MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Remision.SelectAll()
                    tbx_Remision.Focus()
                    Exit Sub
                End If
                ActualizarRemision = True
            ElseIf Validar = True And cmb_CiasProp.SelectedValue <> Id_CiaProp Then
                'La Compañía cambió, revisar si el Numero de Remisión ya existe
                If cn_Recepcion.fn_Remision_Existe(tbx_Remision.Text.Trim, cmb_CiasProp.SelectedValue) Then
                    MsgBox("El Número de Remisión indicado ya existe para la Compañía " & cmb_CiasProp.Text, MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Remision.SelectAll()
                    tbx_Remision.Focus()
                    Exit Sub
                End If
                ActualizarRemision = True
            Else
                ActualizarRemision = False
            End If

            If cn_Recepcion.fn_RecRutasPropias_Update(tbx_Remision.Tag, tbx_Remision.Text.Trim, Envases, EnvasesSN, tbx_TotalRemision.Text.Trim, Id_Punto, dt_Monedas, lsv_Envases, ActualizarRemision, cmb_CiasProp.SelectedValue, Hora) = True Then
                MsgBox("Datos de la Remisión actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                'recalcular Tv_puntos-Tv_Programacion 6Sep2014
                cn_Recepcion.fn_Recalcular_TVPuntos_TVProgramacion(Id_Punto)
            Else
                MsgBox("Ocurrió un error al intentar guardar los datos de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Me.Close()

    End Sub

    Private Sub cmb_TipoEnvase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoEnvase.SelectedIndexChanged
        SegundosDesconexion = 0
        Call validabotonagregar()
    End Sub

    Private Sub tbx_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_NumeroEnvase.TextChanged
        SegundosDesconexion = 0
        Call validabotonagregar()
    End Sub

    Private Sub validabotonagregar()
        If cmb_TipoEnvase.SelectedValue <> 0 Then
            If tbx_NumeroEnvase.Text.Trim <> "" Then
                Btn_Agregar.Enabled = True
            End If
        Else
            Btn_Agregar.Enabled = False
        End If
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0
        If lsv_Envases.SelectedItems.Count > 0 Then
            lsv_Envases.Items(lsv_Envases.SelectedItems(0).Index).Remove()
        End If
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
            .Columns(2).Width = 150
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
            .Columns(4).Width = 120
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            .MultiSelect = False
        End With
    End Sub

    Private Sub CargaDatosEnvases()
        dt_Envases = cn_Recepcion.fn_RecRutasPropiasEnvases(tbx_Remision.Tag)
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
        If dt_Monedas.Rows.Count > 0 Then
            Dim DR_lc As DataRow
            Dim Efectivo As Decimal = 0
            Dim Documentos As Decimal = 0

            For Each DR_lc In dt_Monedas.Rows
                Efectivo += DR_lc(2).ToString * DR_lc(4).ToString
                Documentos += DR_lc(3).ToString
            Next
            tbx_TotalRemision.Text = Efectivo + Documentos
        Else
            tbx_TotalRemision.Text = 0
        End If

    End Sub

    Private Sub dgDinero_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDinero.CellValueChanged
        Call CalculaImporteTotal()
    End Sub

    Private Sub dgDinero_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDinero.DataError
        MsgBox("Valor Inválido, Capture un Número.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub LlenaGridDinero()
        Dim lc_dr As DataRow
        Dim lc_drD As DataRow

        For Each lc_dr In dt_Monedas.Rows
            For Each lc_drD In dt_Dinero.Rows
                If lc_dr(0) = lc_drD(0) Then
                    lc_dr(2) = lc_drD(2)
                    lc_dr(3) = lc_drD(3)
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub GuardarReemplazo()
        Dim Envases As Integer = 0
        Dim EnvasesSN As Integer = 0

        If lsv_Envases.Items IsNot Nothing Then
            Envases = lsv_Envases.Items.Count
        End If

        If tbx_EnvasesSN.Text.Trim <> "" Then
            EnvasesSN = Integer.Parse(tbx_EnvasesSN.Text)
        End If

        If tbx_RemisionReemplazo.Text.Trim = "" Then
            MsgBox("Indique el Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Remision.Focus()
            Exit Sub
        End If
        If cn_Recepcion.fn_Remision_Existe(tbx_RemisionReemplazo.Text, CiaId) Then
            MsgBox("El Número de Remisión ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_RemisionReemplazo.SelectAll()
            tbx_RemisionReemplazo.Focus()
            Exit Sub
        End If

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma Then

            If cn_Recepcion.fn_ConsultaSaldo_GuardarRemisionReemplazo(tbx_Remision.Tag, tbx_RemisionReemplazo.Text, Envases, EnvasesSN, dt_Monedas, lsv_Envases, Id_Bo) = True Then
                MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ha ocurrido un error al intentar guardar la información.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Guardar en Bitacora el Movimiento realizado
            FuncionesGlobales.fn_GuardaBitacora(16, "La Remisión " & tbx_RemisionReemplazo.Text & " ampara a la Remisión " & tbx_Remision.Text, tbx_Remision.Tag)

            Me.Close()
        End If
    End Sub

    Private Sub frm_Dialogo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                btn_Guardar_Click(btn_Guardar, New EventArgs)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frm_Dialogo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'SegundosDesconexion = 0
        'If Nuevo AndAlso UtilizaRd = "S" Then Regresar_StatusRemision()
    End Sub
End Class