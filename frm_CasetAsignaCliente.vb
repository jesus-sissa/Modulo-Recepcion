Imports Modulo_Recepcion.cn_Recepcion
Public Class frm_CasetAsignaCliente
    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_CasetAsignaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        cmb_Cliente.AgregaParametro("@Status", "T", 0)
        cmb_Cliente.Actualizar()

        CargarCasetsDisponibles()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetDisponiblesSeguridadInterna()
        Ocultar(False)
    End Sub

    Private Sub CargarCasetsDisponibles()
        SegundosDesconexion = 0
        lbl_CasetsAsignados.Text = "0 Caset disponibles"

        If Not fn_Kardex_Caset_Disponibles(lsv_CasetDisponibles) Then
            MsgBox("Ocurrió un error al intentar consultar Caset Disponibles.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_CasetsDisponibles.Text = ObtenerElmentosCantidad(lsv_CasetDisponibles) & " Casets disponibles"

        ActivarModoCodigoBarra(ObtenerElmentosCantidad(lsv_CasetDisponibles))

    End Sub

    Private Sub CargarCasetAsiganClienteDisponibles()
        SegundosDesconexion = 0
        If Not fn_Kardex_CasetAsignaCliente_Disponibles(lsv_CasetAsignados) Then
            MsgBox("Ocurrió un error al intentar consultar Caset asignado al cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_CasetsAsignados.Text = ObtenerElmentosCantidad(lsv_CasetAsignados) & " Casets disponibles"
    End Sub

    Private Sub CargarCasetDisponiblesSeguridadInterna()
        SegundosDesconexion = 0
        If Not fn_Kardex_Caset_getSeguridad(lsv_Seguridad) Then
            MsgBox("Ocurrió un error al intentar cargar Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_CasetsDisponibles.Text = ObtenerElmentosCantidad(lsv_Seguridad) & " Casets disponibles"

        ActivarModoCodigoBarra(ObtenerElmentosCantidad(lsv_Seguridad))
    End Sub

    Private Function ObtenerElmentosCantidad(ByVal lsv As cp_Listview) As Integer
        Return lsv.Items.Count
    End Function

    Private Sub ActivarModoCodigoBarra(ByVal Elementos As Integer)
        SegundosDesconexion = 0
        tbx_CodigoBarra.Enabled = Elementos
    End Sub

    Private Sub btn_Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignar.Click
        SegundosDesconexion = 0
        If Not ValidarDatosUsuario() Then
            Exit Sub
        End If

        'If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then
        '    If Not ValidarCasetSeleccionadoContraCliente() Then
        '        MsgBox("Codigo de barra del cliente seleccionado, no es igual al cliente que se intenta asignar.", MsgBoxStyle.Information, frm_MENU.Text)
        '        Exit Sub
        '    End If
        'End If


        If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then


            If Not fn_Kardex_Caset_AsignaCliente(lsv_CasetDisponibles, dtp_Fecha_Asignacion.Value) Then
                MsgBox("Ocurrió un error al intentar asinar Cassets.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


        ElseIf Tab_CasetDisponibles.SelectedTab Is tbp_SeguridadInterna Then


            If cmb_Cliente.SelectedValue = "0" Then
                MsgBox("Debe selecccionar un cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If


            If Not fn_Kardex_Caset_AsignaSeguridadInterna(lsv_Seguridad.SelectedItems(0).Tag, cmb_Cliente.SelectedValue, dtp_Fecha_Asignacion.Value) Then
                MsgBox("Ocurrió un error al intentar asinar Cassets.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        cmb_Cliente.SelectedValue = 0
        MsgBox("Se asigno con exito.", MsgBoxStyle.Information, frm_MENU.Text)

        CargarCasetsDisponibles()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetDisponiblesSeguridadInterna()
    End Sub

    Public Function ValidarDatosUsuario() As Boolean
        SegundosDesconexion = 0
        If Tab_CasetDisponibles.SelectedTab Is tbp_CasetNorma Then
            If lsv_CasetDisponibles.CheckedItems.Count = 0 Then
                MsgBox("Seleccione por lo menos un Caset para asignar.", MsgBoxStyle.Information, frm_MENU.Text)
                Return False
            End If

        ElseIf Tab_CasetDisponibles.SelectedTab Is tbp_SeguridadInterna Then
            If lsv_Seguridad.SelectedItems.Count = 0 Then
                MsgBox("Seleccione un Caset para asignar.", MsgBoxStyle.Information, frm_MENU.Text)
                Return False
            End If
        End If

        'If cmb_Cliente.SelectedValue = 0 Then
        '    MsgBox("Seleccione un Cliente.", MsgBoxStyle.Information, frm_MENU.Text)
        '    Return False
        'End If
        Return True
    End Function

    Private Function ValidarCasetSeleccionadoContraCliente()
        SegundosDesconexion = 0
        For Each item As ListViewItem In lsv_CasetDisponibles.CheckedItems
            If CInt(item.SubItems(8).Text) <> CInt(cmb_Cliente.SelectedValue) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub lsv_CasetDisponibles_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_CasetDisponibles.ItemChecked
        SegundosDesconexion = 0
        e.Item.ForeColor = Color.Black
        If e.Item.Checked Then
            e.Item.ForeColor = Color.Green
        End If
    End Sub

    Private Sub tbx_CodigoBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_CodigoBarra.TextChanged
        SegundosDesconexion = 0
        If tbx_CodigoBarra.Text.Length > 7 Then
            If Not tbx_CodigoBarra.Text.Contains("'") Then
                MsgBox("Código no valido.", MsgBoxStyle.Critical)
                tbx_CodigoBarra.Text = ""
                tbx_CodigoBarra.Focus()
                Exit Sub
            End If
            SeleccionarClientes(tbx_CodigoBarra.Text)
            tbx_CodigoBarra.Text = ""
            tbx_CodigoBarra.Focus()
        End If
    End Sub

    Public Function SeleccionarClientes(ByVal CodigoBarra As String) As Boolean
        SegundosDesconexion = 0
        For Each item As ListViewItem In lsv_CasetDisponibles.Items
            If item.SubItems(0).Text = CodigoBarra Then
                cmb_Cliente.SelectedValue = item.SubItems(0).Text.Split("'")(1)
                item.Checked = True
                item.ForeColor = Color.Green
                item.EnsureVisible()
                Exit For
            End If
        Next
    End Function

    Private Sub btn_Retirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Retirar.Click
        SegundosDesconexion = 0
        If lsv_CasetAsignados.CheckedItems.Count = 0 Then
            MsgBox("Seleccione por lo menos un caset a cancelar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_Observaciones.Text = "" Then
            MsgBox("Capture una obaservación.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If


        If Not fn_Kardex_CasetAsignaCliente_Cancelar(lsv_CasetAsignados, tbx_Observaciones.Text) Then
            MsgBox("Ocurrió un error al intentar cancelar Caset.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        CargarCasetDisponiblesSeguridadInterna()
        CargarCasetAsiganClienteDisponibles()
        CargarCasetsDisponibles()
    End Sub

    Private Sub Tab_CasetDisponibles_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles Tab_CasetDisponibles.Selecting
        Ocultar(e.TabPage Is tbp_SeguridadInterna)
    End Sub

    Private Sub Ocultar(ByVal valor As Boolean)
        SegundosDesconexion = 0
        cmb_Cliente.Enabled = valor
        dtp_Fecha_Asignacion.Enabled = valor
        lbl_Fecha_Asignacion.Enabled = valor
        lbl_ClienteAsignar.Enabled = valor
    End Sub
End Class