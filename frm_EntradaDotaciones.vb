Imports Modulo_Recepcion.FuncionesGlobales


Public Class frm_EntradaDotaciones
    Public tbl As DataTable

    Private Sub frm_EntradaDotaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbl = New DataTable
        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()

        Call LlenaLista()

        lsv_DotacionD.Columns.Add("Remision")
        lsv_DotacionD.Columns.Add("Caja")
        lsv_DotacionD.Columns.Add("Moneda")
        lsv_DotacionD.Columns.Add("Importe")
        lsv_DotacionD.Columns.Add("Envases")

        lsv_Envase.Columns.Add("Tipo")
        lsv_Envase.Columns.Add("Numero Envase")

    End Sub

    Private Sub LlenaLista()
        btn_Recibir.Enabled = False
        lsv_DotacionD.Items.Clear()
        lsv_Envase.Items.Clear()
        Call cn_Recepcion.fn_EntradaDotacionesCajeros_LlenarLista(lsv_Dotacion, 0)
        lsv_Dotacion.CheckBoxes = True
        lsv_DotacionD.Items.Clear()
        Lbl_Registros.Text = "Registros: " & lsv_Dotacion.Items.Count

    End Sub

    Private Sub lsv_Dotacion_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Dotacion.ItemChecked
        SegundosDesconexion = 0

        If lsv_Dotacion.CheckedItems.Count = 0 Then
            btn_Recibir.Enabled = False
        Else
            btn_Recibir.Enabled = True
        End If
    End Sub

    Private Sub lsv_Dotacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Dotacion.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Buscar.Enabled = True
        lsv_DotacionD.Items.Clear()
        lsv_Envase.Items.Clear()
        If lsv_Dotacion.SelectedItems.Count = 0 Then
            btn_Buscar.Enabled = False
            Exit Sub
        End If
        If lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "CAJEROS" Or lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "AUDITORIA ATMS" Then
            cn_Recepcion.fn_EntradaDotacionesCajerosD_Llenalista(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)
            tbl = cn_Recepcion.fn_EntradaDotacionesCajerosD_LlenalistaEnvases(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)

        ElseIf lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "PROCESO" Then
            cn_Recepcion.fn_EntradaDotacionesCajerosDPro_Llenalista(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)
            tbl = cn_Recepcion.fn_EntradaDotacionesCajerosDPro_LlenalistaEnvases(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)

            'utiliza la misma funcion (Proceso - Morralla)26/05/14
        ElseIf lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "MORRALLA" Then
            cn_Recepcion.fn_EntradaDotacionesCajerosDPro_Llenalista(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)
            tbl = cn_Recepcion.fn_EntradaDotacionesCajerosDPro_LlenalistaEnvases(lsv_DotacionD, lsv_Dotacion.SelectedItems(0).Tag)

        End If

        btn_Buscar.Enabled = True
    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccion una Boveda", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Boveda.Focus()
            Exit Sub
        End If

        For Each Elemento As ListViewItem In lsv_Dotacion.CheckedItems
            If cn_Recepcion.fn_RecLotesBoveda_Validar(Elemento.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no están disponibles, se actualizara la ventana.", MsgBoxStyle.Critical, frm_MENU.Text)
                Call LlenaLista()
                Exit Sub
            End If
        Next

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()
        If frm.Firma Then
            If cn_Recepcion.fn_EntradaDotacionesCajeros_Guardar(cmb_Boveda.SelectedValue, lsv_Dotacion) = True Then
                MsgBox("Las Dotaciones se recibieron correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LlenaLista()
            Else
                MsgBox("Ocurrió un error al intentar Recibir las Dotaciones.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub



    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_DotacionD, tbx_Buscar) Then
            Call Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_DotacionD, tbx_Buscar) Then
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub

    'Private Sub Buscar()

    '    If tbx_Buscar.Text.Trim <> "" Then
    '        FuncionesGlobales.fn_BuscaryMarca_enListView(lsv_DotacionD, tbx_Buscar.Text, 1)
    '    End If

    'End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_DotacionD, Remision, 0)
            tbx_Buscar.Focus()
            tbx_Buscar.SelectAll()
        End If

    End Sub

    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_DotacionD.Items
            If (item.SubItems(2).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    Private Sub frm_EntradaDotacionesCajeros_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If lsv_Dotacion.SelectedItems.Count = 0 Then Exit Sub
        'If lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "CAJEROS" Or lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "AUDITORIA ATMS" Then
        '    lsv_DotacionD.Columns(0).Width = 100
        '    lsv_DotacionD.Columns(1).Width = 100
        '    lsv_DotacionD.Columns(2).Width = 100
        '    lsv_DotacionD.Columns(3).Width = 100
        '    lsv_DotacionD.Columns(4).Width = 300
        '    lsv_DotacionD.Columns(5).Width = 100
        '    lsv_DotacionD.Columns(6).Width = 100
        '    lsv_DotacionD.Columns(7).Width = 100
        '    lsv_DotacionD.Columns(8).Width = 0
        '    lsv_DotacionD.Columns(9).Width = 0
        '    lsv_DotacionD.Columns(10).Width = 0
        '    lsv_DotacionD.Columns(11).Width = 0
        'ElseIf lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "PROCESO" Then
        '    lsv_DotacionD.Columns(0).Width = 100
        '    lsv_DotacionD.Columns(1).Width = 100
        '    lsv_DotacionD.Columns(2).Width = 100
        '    lsv_DotacionD.Columns(3).Width = 0
        '    lsv_DotacionD.Columns(4).Width = 0
        '    lsv_DotacionD.Columns(5).Width = 0
        '    lsv_DotacionD.Columns(6).Width = 0
        '    lsv_DotacionD.Columns(7).Width = 0
        '    lsv_DotacionD.Columns(8).Width = 0
        '    lsv_DotacionD.Columns(9).Width = 0
        'End If
    End Sub


    Private Sub lsv_DotacionD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_DotacionD.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Envase.Items.Clear()

        If lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "CAJEROS" Or lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "AUDITORIA ATMS" Then
            If lsv_DotacionD.SelectedItems.Count > 0 Then
                cn_Recepcion.fn_Get_Envases(lsv_Envase, lsv_DotacionD.SelectedItems(0).Tag)
            End If

        ElseIf lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "PROCESO" Then
            If lsv_DotacionD.SelectedItems.Count > 0 Then
                cn_Recepcion.fn_Get_Envases2(lsv_Envase, lsv_DotacionD.SelectedItems(0).Tag)
            End If
            'utiliza la misma funcion (Proceso - Morralla)26/05/14
        ElseIf lsv_Dotacion.SelectedItems(0).SubItems(5).Text = "MORRALLA" Then
            If lsv_DotacionD.SelectedItems.Count > 0 Then
                cn_Recepcion.fn_Get_Envases2(lsv_Envase, lsv_DotacionD.SelectedItems(0).Tag)
            End If
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As ListView, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function
End Class