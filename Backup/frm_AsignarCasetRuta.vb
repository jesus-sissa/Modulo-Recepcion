Imports Modulo_Recepcion.cn_Recepcion
Public Class frm_AsignarCasetRuta
    Dim dt_ClienteEnPunto As DataTable

    Private Sub frm_AsignarCasetRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        cmb_Rutas.AgregaParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString), 2)
        cmb_Rutas.Actualizar()

    End Sub


    Private Sub cmb_Rutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_CasetAsignadoRuta.Items.Clear()
        dgv_Casets.DataSource = Nothing
        If cmb_Rutas.SelectedValue = "0" Then Exit Sub
        'CargarClienteEnPunto()
        CargarCasetClientesAsignados()
        CargarCasetAsignadoRuta()
        tbx_Codigo.Focus()

    End Sub

    Private Sub CargarCasetClientesAsignados()
        SegundosDesconexion = 0
        dgv_Casets.DataSource = Nothing
        lbl_RegistroCaset.Text = "Registros: 0"
        Dim dt_Caset As DataTable = fn_Kardex_Caset_GetClienteAsigando(cmb_Rutas.SelectedValue)


        If dt_Caset Is Nothing Then
            MsgBox("Ocurrió un error al intentar intentar cargat Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dt_Caset.Rows.Count > 0 Then
            dgv_Casets.DataSource = dt_Caset
            CheckSoloLectura()
            dgv_Casets.Columns(1).Visible = False
            dgv_Casets.Columns(2).Width = 300
            dgv_Casets.Columns(3).Width = 200
            dgv_Casets.Columns(4).Width = 200
            dgv_Casets.Columns(5).Visible = False

            dgv_Casets.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_Casets.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            dgv_Casets.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            lbl_RegistroCaset.Text = "Registros: " & dt_Caset.Rows.Count & ""
        End If



    End Sub

    Private Sub CheckSoloLectura()
        SegundosDesconexion = 0
        For Each gvr As DataGridViewRow In dgv_Casets.Rows
            gvr.Cells(0).ReadOnly = True
        Next
    End Sub

    Private Sub btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar.Click
        SegundosDesconexion = 0
        If cmb_Rutas.SelectedValue = "0" Then
            MsgBox("Seleccione una Ruta.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If dgv_CasetCheckedCount() = 0 Then
            MsgBox("Seleccione al menos un Caset.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If Not fn_Kardex_CasetAsignaRuta(cmb_Rutas.SelectedValue, dgv_Casets) Then
            MsgBox("Ocurrió un error al intentar asignar Caset a Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        CargarCasetClientesAsignados()
        CargarCasetAsignadoRuta()
        lbl_Regsitros1.Text = "Regsitros: " & lsv_CasetAsignadoRuta.Items.Count()
        tbx_Codigo.Focus()
    End Sub

    Function dgv_CasetCheckedCount() As Integer
        Return (From dr As DataGridViewRow In dgv_Casets.Rows _
                 Where dr.Cells(0).Value = True _
                 Select dr).Count()
    End Function

    Private Sub CargarCasetAsignadoRuta()
        SegundosDesconexion = 0
        lbl_Regsitros1.Text = "Registros: 0 "
        If Not fn_Kardex_CasetAsinadoRuta_Get(lsv_CasetAsignadoRuta, cmb_Rutas.SelectedValue, 0, 1) Then
            MsgBox("Ocurrió un error al intentar Caset asignados a Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Regsitros1.Text = "Registros: " & lsv_CasetAsignadoRuta.Items.Count & ""
    End Sub


    'Private Sub CargarClienteEnPunto()

    '    dt_ClienteEnPunto = fn_Kardex_Caset_GetClienteEnPunto(cmb_Rutas.SelectedValue)

    '    If dt_ClienteEnPunto Is Nothing Then
    '        MsgBox("Ocurrió un error al intentar consultar Clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
    '        Exit Sub
    '    End If

    'End Sub


    'Private Function ValidarClienteEnPunto() As Boolean
    '    If dt_ClienteEnPunto Is Nothing Then Return False
    '    For Each dr As DataRow In dt_ClienteEnPunto.Rows
    '        If cmb_Cliente.SelectedValue = dr("Id_Cliente") Then
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function


    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0
        cmb_Rutas.ActualizaValorParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString))
        cmb_Rutas.Actualizar()
        lsv_CasetAsignadoRuta.Items.Clear()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub tbx_Codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Codigo.TextChanged
        SegundosDesconexion = 0
        If tbx_Codigo.Text.Length > 7 Then
            If Not tbx_Codigo.Text.Contains("'") Then
                MensajeCodigoBarra()
                Exit Sub
            End If

            Dim ArrPartesCaset As String() = tbx_Codigo.Text.Split("'")

            If Not IsNumeric(ArrPartesCaset(1)) Then
                MensajeCodigoBarra()
                Exit Sub
            End If
            BuscarCaset(Split(tbx_Codigo.Text, "'")(1), tbx_Codigo.Text)
        End If
    End Sub


    Private Sub MensajeCodigoBarra()
        SegundosDesconexion = 0
        MsgBox("Codigo de barra no valido.", MsgBoxStyle.Information, frm_MENU.Text)
        tbx_Codigo.Text = ""
        tbx_Codigo.Focus()
    End Sub

    Private Sub BuscarCaset(ByVal Id_Cliente As Integer, ByVal Codigo As String)
        For Each gvr As DataGridViewRow In dgv_Casets.Rows
            If gvr.Cells("CodigoBarra").Value.ToString() = Codigo Then
                gvr.Cells(0).Value = True
                tbx_Codigo.Text = ""
                Exit For
            End If
        Next
        tbx_Codigo.Text = ""
    End Sub

End Class