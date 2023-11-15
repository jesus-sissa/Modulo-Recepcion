Imports Modulo_Recepcion.cn_Recepcion
Public Class frm_RecepcionCasetRuta
    Private Sub frm_RecepcionCasetRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0
        cmb_Rutas.AgregaParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString), 2)
        cmb_Rutas.Actualizar()
        'btn_Guardar.Enabled = False
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        cmb_Rutas.ActualizaValorParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString))
        cmb_Rutas.Actualizar()
        dgv_Casets.Rows.Clear()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        SegundosDesconexion = 0
        If cmb_Rutas.SelectedValue = 0 Then
            MsgBox("Seleccione un Ruta.", MsgBoxStyle.Information, frm_MENU.Text)
            cmb_Rutas.SelectAll()
            Return False
        End If
        Return True
    End Function

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If Not fn_Kardex_CasetGuardar(dgv_Casets, cmb_Rutas.SelectedValue) Then
            MsgBox("Ocurrió un error al intentar recibir Cassets", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        MostarCasetRuta()
        tbx_Remision.Focus()
        'btn_Guardar.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        If Not Validar() Then
            Exit Sub
        End If
        MostarCasetRuta()
        tbx_Remision.Focus()
    End Sub

    Public Sub MostarCasetRuta()
        SegundosDesconexion = 0
        dgv_Casets.DataSource = Nothing
        lbl_Registros.Text = "Registros: 0"

        Dim dt_Caset As DataTable = fn_Kardex_CasetAsinadoRuta_GetRecepcion(cmb_Rutas.SelectedValue, 0, 2)

        If dt_Caset Is Nothing Then
            MsgBox("Ocurrió un error al intentar consulta Casets. ", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If dt_Caset.Rows.Count > 0 Then
            dgv_Casets.DataSource = dt_Caset
            dgv_Casets.Columns(1).Visible = False
            dgv_Casets.Columns(7).Visible = False
            dgv_Casets.Columns(8).Visible = False
            dgv_Casets.Columns(9).Visible = False
            dgv_Casets.Columns(10).Visible = False
            dgv_Casets.Columns(2).Width = 200
            dgv_Casets.Columns(3).Width = 350
            dgv_Casets.Columns(4).Width = 200
            dgv_Casets.Columns(5).Width = 200
            dgv_Casets.Columns(6).Width = 200
        End If


        lbl_Registros.Text = "Registros: " & dgv_Casets.Rows.Count & ""
    End Sub


    Private Function BuscaRemision(ByVal NumeroRemision As String) As Boolean
        SegundosDesconexion = 0
        For Each dr As DataGridViewRow In dgv_Casets.Rows

            If dr.Cells("Numero_Remision").Value.ToString() = NumeroRemision Then
                If EsCasetTrasbordoNoValidado(dr) Then
                    MsgBox("El caset que esta intentando recibir no esta validado por el Cajero, para continuar validar el caset porfavor", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Function
                End If
                dr.Cells(0).Value = True
            End If

            If dr.Cells("CodigoBarra").Value.ToString() = NumeroRemision Then
                If EsCasetTrasbordoNoValidado(dr) Then
                    MsgBox("El caset que esta intentando recibir no esta validado por el Cajero, para continuar validar el caset por favor", MsgBoxStyle.Information, frm_MENU.Text)
                    Exit Function
                End If
                dr.Cells(0).Value = True
            End If
        Next
    End Function

    Private Function EsCasetTrasbordoNoValidado(ByVal dr As DataGridViewRow) As Boolean
        SegundosDesconexion = 0
        If dr.Cells("StatusCaset").Value.ToString() = "NV" Then 'NV Se trasbordo caset pero no esta validado
            Return True
        End If
        Return False
    End Function


    Function dgv_CasetCheckedCount() As Integer
        Return (From dr As DataGridViewRow In dgv_Casets.Rows _
                 Where dr.Cells(0).Value = True _
                 Select dr).Count()
    End Function

    Private Sub tbx_Remision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If tbx_Remision.Text = "" Then Exit Sub
            BuscaRemision(tbx_Remision.Text)
            tbx_Remision.Focus()
            tbx_Remision.Text = ""
            'btn_Guardar.Enabled = (dgv_Casets.Rows.Count = dgv_CasetCheckedCount())
            'btn_Guardar.Enabled = dgv_CasetCheckedCount()
        End If
    End Sub

    Private Sub cmb_Rutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedIndexChanged
        SegundosDesconexion = 0
        'If Not Validar() Then
        '    Exit Sub
        'End If
        If cmb_Rutas.SelectedValue = 0 Then Exit Sub
        MostarCasetRuta()
        tbx_Remision.Focus()
    End Sub
End Class