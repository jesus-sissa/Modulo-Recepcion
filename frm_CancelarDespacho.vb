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

        If Not fn_CancelarDespacho_LlenarLista(lsv_Despachos, Tipo, "A", Today.Date, Today.Date) Then
            MsgBox("Ha ocurrido un error al intentar llenar la lista de Lotes", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        lbl_RegistrosD.Text = "Registros: " & lsv_Despachos.Items.Count

    End Sub

    Private Sub lsv_Despachos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Despachos.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Cancelar.Enabled = False
        Btn_Individual.Enabled = False
        If lsv_Despachos.SelectedItems.Count = 0 Then Exit Sub
        lsv_Detalle.Items.Clear()
        If lsv_Despachos.SelectedItems.Count > 0 Then
            If Not fn_CancelarDespacho_LlenarDetalles(lsv_Detalle, lsv_Despachos.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista de Remisiones.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        ColorearCancelacionesIndividuales()
        'MessageBox.Show(lsv_Despachos.SelectedItems(0).SubItems(7).Text)
        'IIf(lsv_Despachos.SelectedItems(0).SubItems(7).Text = "CANCELADO", btn_Cancelar.Enabled = True, btn_Cancelar.Enabled = False)
        Lbl_RegistrosR.Text = "Registros: " & lsv_Detalle.Items.Count
        btn_Cancelar.Enabled = lsv_Despachos.SelectedItems.Count > 0 And (IIf(lsv_Despachos.SelectedItems(0).SubItems(7).Text = "CANCELADO", False, True))
        Btn_Individual.Enabled = False
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
            'frm.CancelarDespachoValidar = True
            frm.CancelarDespachoValidar = False
            frm.PedirObservaciones = True
            frm.Min_Caracteres_Obs = 50
            frm.ShowDialog()
            If frm.Firma Then
                If fn_CancelarDespacho_Manual(lsv_Despachos.SelectedItems(0).Tag, Interno, Pendiente) Then
                    MsgBox("Las Remisiones ya están disponibles para ser despachadas de nuevo.", MsgBoxStyle.Information, frm_MENU.Text)
                    'Crear_Mail(frm.Observaciones)
                    Call Actualizar()
                Else
                    MsgBox("Ocurrió un error al intentar cancelar el despacho. Las Remisiones aún se encuentran en la Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        Else
            MsgBox("Debe seleccionar al menos un Despacho.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub
    Sub Crear_Mail(Observaciones As String)
        Dim mailBody As System.Text.StringBuilder = New System.Text.StringBuilder()
        mailBody.AppendFormat("<html><body  style='font-family: Lucida Console, Courier New, monospace;'><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'>CANCELACION DE DESPACHO</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'>PROCESO</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'><br><hr /></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>RUTA:</b></label>" & lsv_Despachos.SelectedItems(0).SubItems(2).Text & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>USUARIO CANCELA:</b></label>" & UsuarioN & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>LISTA DE REMISIONES</b></label></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr>")


        mailBody.AppendFormat("<tr> <th align='left'> REMISION</th><th align='left'>ORIGEN</th><th align='left'>DESTINO</th><th align='left'>ETV</th></tr>")
        For Each item As ListViewItem In lsv_Detalle.Items
            mailBody.AppendFormat("<tr> <td>" & item.SubItems(0).Text & "</td><td>" & item.SubItems(1).Text & "</td><td>" & item.SubItems(2).Text & "</td><td>" & lsv_Despachos.SelectedItems(0).SubItems(4).Text & "</td></tr>")
            'mailBody.AppendFormat("<tr><td align='right'><label><b>" & item.SubItems(0).Text & "</b></label></td><td>" & "  " & item.SubItems(1).Text & "</td><td></td><td></td></tr>")
        Next
        mailBody.AppendFormat("<tr><td colspan='4'><hr /></td></tr><tr><td colspan='4' align='Left'><label><b>OBSERVACIONES:</b></label></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='left'>" & Observaciones & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr><tr><td colspan='4' align='center'>Fecha y hora:" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr><tr><td colspan='4' align='center'>Agente de Servicios SIAC</td></tr></table><br/><br/></body></html>")
        Enviar_Mail(mailBody, "CANCELACION DE DESPACHO")
    End Sub
    Sub Crear_Mail(Remision As String, Origen As String, Destino As String, ETV As String, Observaciones As String)
        Dim mailBody As System.Text.StringBuilder = New System.Text.StringBuilder()
        mailBody.AppendFormat("<html><body  style='font-family: Lucida Console, Courier New, monospace;'><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'>CANCELACION DE DESPACHO</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'>PROCESO</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'><br><hr /></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>RUTA:</b></label>" & lsv_Despachos.SelectedItems(0).SubItems(2).Text & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>USUARIO CANCELA:</b></label>" & UsuarioN & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='center'><label><b>LISTA DE REMISIONES</b></label></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr>")


        mailBody.AppendFormat("<tr> <th align='left'> REMISION</th><th align='left'>ORIGEN</th><th align='left'>DESTINO</th><th align='left'>ETV</th></tr>")

        mailBody.AppendFormat("<tr> <td>" & Remision & "</td><td>" & Origen & "</td><td>" & Destino & "</td><td>" & ETV & "</td></tr>")
        'mailBody.AppendFormat("<tr><td align='right'><label><b>" & item.SubItems(0).Text & "</b></label></td><td>" & "  " & item.SubItems(1).Text & "</td><td></td><td></td></tr>")

        mailBody.AppendFormat("<tr><td colspan='4'><hr /></td></tr><tr><td colspan='4' align='Left'><label><b>OBSERVACIONES:</b></label></td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4' align='left'>" & Observaciones & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr><tr><td colspan='4' align='center'>Fecha y hora:" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>")
        mailBody.AppendFormat("<tr><td colspan='4'></td></tr><tr><td colspan='4' align='center'>Agente de Servicios SIAC</td></tr></table><br/><br/></body></html>")
        Enviar_Mail(mailBody, "CANCELACION DE DESPACHO")
    End Sub
    Sub Enviar_Mail(DetalleHtml As System.Text.StringBuilder, Titulo As String)
        Dim ExistenDestinos As Boolean = False
        Dim Destinos As String = String.Empty
        Dim Dt_Destinos As DataTable = cn_Recepcion.fn_AlertasGeneradas_ObtenerMails("57")
        If Dt_Destinos IsNot Nothing Then
            For Each renglon As DataRow In Dt_Destinos.Rows
                ExistenDestinos = True
                Destinos += renglon("Mail") + ","
            Next
            If ExistenDestinos Then
                Cn_Mail.fn_Enviar_MailHTML(Destinos, Titulo, DetalleHtml.ToString(), "")
            End If
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

    Private Sub Btn_Individual_Click(sender As Object, e As EventArgs) Handles Btn_Individual.Click
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
            frm.CancelarDespachoValidar = True
            frm.PedirObservaciones = True
            frm.Min_Caracteres_Obs = 50
            frm.ShowDialog()
            If frm.Firma Then
                If fn_CancelarDespacho_Individual(lsv_Despachos.SelectedItems(0).Tag, lsv_Detalle.SelectedItems(0).Tag, Interno, Pendiente) Then
                    MsgBox("Las Remisiones ya están disponibles para ser despachadas de nuevo.", MsgBoxStyle.Information, frm_MENU.Text)
                    Crear_Mail(lsv_Detalle.SelectedItems(0).SubItems(0).Text, lsv_Detalle.SelectedItems(0).SubItems(1).Text, lsv_Detalle.SelectedItems(0).SubItems(2).Text, "SISSA", frm.Observaciones)
                    Call Actualizar()
                    Btn_Individual.Enabled = False
                Else
                    MsgBox("Ocurrió un error al intentar cancelar el despacho. Las Remisiones aún se encuentran en la Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        Else
            MsgBox("Debe seleccionar al menos un Despacho.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Detalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Detalle.SelectedIndexChanged
        Btn_Individual.Enabled = False
        Dim cont As Integer = 0
        If lsv_Detalle.SelectedItems.Count = 0 Then Exit Sub
        If lsv_Detalle.SelectedItems(0).SubItems(5).Text = "C" Then Exit Sub
        For Each item As ListViewItem In lsv_Detalle.Items
            If item.SubItems(5).Text = "A" Then
                cont += 1
            End If
        Next
        If cont > 1 And btn_Cancelar.Enabled = True Then Btn_Individual.Enabled = True
    End Sub
    Sub ColorearCancelacionesIndividuales()
        For Each item As ListViewItem In lsv_Detalle.Items
            If item.SubItems(5).Text = "C" Then
                item.ForeColor = Color.Red
            End If
        Next
    End Sub
End Class