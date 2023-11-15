Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_EntregaCaset
    Public dr As DialogResult
    Public Id_Programacion As Integer

    Private Sub Cp_Textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_CodigoBarra.TextChanged
        If tbx_CodigoBarra.Text = "" Then Exit Sub

        If tbx_CodigoBarra.Text.Length > 7 Then
            If Not tbx_CodigoBarra.Text.Contains("'") Then
                MsgBox("Codigo de Barra incorrecto.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_CodigoBarra.SelectAll()
                Exit Sub
            End If

            If cmb_Cliente.SelectedValue <> Split(tbx_CodigoBarra.Text, "'")(1) Then
                MsgBox("Este CASSET no le corresponde al cliente.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_CodigoBarra.SelectAll()
                Exit Sub
            End If


            If CasetExiste(tbx_CodigoBarra.Text) Then
                MsgBox("El CASET ya fue capturado.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If

            lsv_Casets.Items.Add(cmb_Cliente.Text)
            lsv_Casets.Items(lsv_Casets.Items.Count - 1).SubItems.Add(tbx_CodigoBarra.Text)
            lsv_Casets.Items(lsv_Casets.Items.Count - 1).SubItems.Add(cmb_Cliente.SelectedValue)

            tbx_CodigoBarra.Text = ""
        End If
    End Sub

    Function CasetExiste(ByVal CodigoBarra As String) As Boolean
        For Each item As ListViewItem In lsv_Casets.Items
            If item.SubItems(1).Text = tbx_CodigoBarra.Text Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub frm_EntregaCaset_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'rdb_EntregaCartucho.Checked = True
        'rdb_EntregaCartucho.Enabled = False
        'rdb_RecibeCartucho.Enabled = False
        'tbx_CodigoBarra.Enabled = False
        cmb_EmpleadoEntrega.Actualizar()
        cmb_Cliente.Actualizar()
        lsv_Casets.Columns.Add("Clientes", 200)
        lsv_Casets.Columns.Add("Codigo Barra", 100)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim Id_Cliente As Integer = lsv_Casets.SelectedItems(0).Text.Split("'")(1)
        Dim tipoMovimiento As Integer = If(rdb_EntregaCartucho.Checked, 11, 12)

        If rdb_EntregaCartucho.Checked Then

            Select Case fn_Kardex_MovimientosCaset_Insert(lsv_Casets, Id_Programacion, True, False, tipoMovimiento)
                Case -1
                    MsgBox("Ocurrió un error al entregar CASSET.", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Sub
                Case 2
                    MsgBox("Primero debe entregar los CASSET.", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Sub
                Case Else
                    rdb_EntregaCartucho.Checked = False
                    rdb_RecibeCartucho.Checked = True
            End Select

        ElseIf rdb_RecibeCartucho.Checked Then
            Select Case fn_Kardex_MovimientosCaset_Insert(lsv_Casets, Id_Programacion, False, True, tipoMovimiento)
                Case -1
                    MsgBox("Ocurrió un error al entregar CASSET.", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Sub
                Case 2
                    MsgBox("Primero debe entregar los CASSET.", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Sub
                Case Else
                    dr = Windows.Forms.DialogResult.OK
                    Me.Close()
            End Select
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        dr = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub cmb_Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cliente.SelectedIndexChanged
        If cmb_EmpleadoEntrega.SelectedValue > 0 Then
            tbx_CodigoBarra.Enabled = cmb_Cliente.SelectedValue > 0
            tbx_CodigoBarra.Focus()
        End If
    End Sub

    Private Sub cmb_EmpleadoEntrega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_EmpleadoEntrega.SelectedIndexChanged
        cmb_Cliente.Enabled = cmb_EmpleadoEntrega.SelectedValue > 0
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        If lsv_Casets.SelectedItems.Count > 0 Then
            lsv_Casets.Items(lsv_Casets.SelectedItems(0).Index).Remove()
        End If
    End Sub
End Class