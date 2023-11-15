Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_CancelarDespacho

    Private Sub frm_CancelarDespacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Despachos.Columns.Add("Fecha")
        lsv_Despachos.Columns.Add("Hora")
        lsv_Despachos.Columns.Add("Ruta")
        lsv_Despachos.Columns.Add("Empleado")
        lsv_Despachos.Columns.Add("ETV")
        lsv_Despachos.Columns.Add("Remisiones")
        lsv_Despachos.Columns.Add("Envases")
        lsv_Despachos.Columns.Add("Status")
        lsv_Despachos.Columns.Add("Pendiente")

        lsv_Detalle.Columns.Add("Remision")
        lsv_Detalle.Columns.Add("Cliente")
        lsv_Detalle.Columns.Add("Envases")
        lsv_Detalle.Columns.Add("Envases SN")
        
    End Sub

    Public Sub Actualizar()
        Dim Tipo As Integer
        lsv_Despachos.Items.Clear()
        lsv_Detalle.Items.Clear()
        Lbl_RegistrosR.Text = "Registros: 0"
        btn_Cancelar.Enabled = False

        If rdb_Internos.Checked Then
            Tipo = 1
        ElseIf rdb_Externos.Checked Then
            Tipo = 2
        ElseIf rdb_Todos.Checked Then
            Tipo = 0
        End If

        If Not fn_CancelarDespacho_LlenarLista(lsv_Despachos, Tipo) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_RegistrosD.Text = "Registros: " & lsv_Despachos.Items.Count

    End Sub

    Private Sub lsv_Despachos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Despachos.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Detalle.Items.Clear()
        If lsv_Despachos.SelectedItems.Count > 0 Then
            If Not fn_CancelarDespacho_LlenarDetalles(lsv_Detalle, lsv_Despachos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista de Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Lbl_RegistrosR.Text = "Registros: " & lsv_Detalle.Items.Count
        btn_Cancelar.Enabled = lsv_Despachos.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim Interno As Boolean = False
        If lsv_Despachos.SelectedItems(0).SubItems(9).Text = "1" Then
            Interno = True
        End If

        Dim Pendiente As Boolean = False
        If lsv_Despachos.SelectedItems(0).SubItems(9).Text = "S" Then
            Pendiente = True
        End If

        If lsv_Despachos.SelectedItems.Count > 0 Then
            Dim frm As New frm_FirmaElectronica
            frm.Bloquear = True
            frm.ShowDialog()
            If frm.Firma Then
                If fn_CancelarDespacho_Manual(lsv_Despachos.SelectedItems(0).Tag, Interno, Pendiente) Then
                    MsgBox("Las Remisiones ya están disponibles para ser despachadas de nuevo.", MsgBoxStyle.Information, frm_MENU.Text)
                    Call Actualizar()
                Else
                    MsgBox("Ocurrió un error al intentar cancelar el despacho. Las Remisiones aún se encuentran en la Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        Else
            MsgBox("Debe seleccionar al menos un Despacho.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub rdb_Internos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Internos.CheckedChanged
        SegundosDesconexion = 0

        Call Actualizar()
        Call ColorearPendientes()
    End Sub

    Private Sub rdb_Externos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Externos.CheckedChanged
        SegundosDesconexion = 0

        Call Actualizar()
    End Sub

    Private Sub rdb_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Todos.CheckedChanged
        SegundosDesconexion = 0

        Call Actualizar()
        Call ColorearPendientes()
    End Sub

    Sub ColorearPendientes()
        For Each item As ListViewItem In lsv_Despachos.Items
            If item.SubItems(10).Text = "S" And item.SubItems(9).Text = 1 Then
                item.ForeColor = Color.Blue
            End If
        Next
    End Sub

End Class