Public Class frm_ComprobanteVmodal
    Public Id_Punto As Long
    Public Horario As String

    Private Sub frm_ComprobanteVmodal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'consultar y mostrar los datos
        Dim dt As DataTable = cn_Recepcion.fn_MonitoreoConsultaCV(Id_Punto)
        If dt Is Nothing Then
            MsgBox("Ocurrió un error al Intentar Consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            If dt.Rows.Count > 0 Then
                lbl_Folio.Text = dt.Rows(0)("Numero")
                tbx_Folio.Text = dt.Rows(0)("Numero")
                lbl_Fecha.Text = dt.Rows(0)("Fecha")
                lbl_Hora.Text = dt.Rows(0)("Hora")
                tbx_Hora.Text = dt.Rows(0)("Hora")
                lbl_Cliente.Text = dt.Rows(0)("Cliente") & "  " & dt.Rows(0)("Nombre")
                lbl_Horario.Text = Horario
                dt.Dispose()
            Else
                MsgBox("No se encontró el Comprobante de Visita.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        'validar si es numerico
        If Not IsNumeric(tbx_Folio.Text) Then
            MsgBox("Indique un Folio Válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Folio.Focus()
            Exit Sub
        End If
        If tbx_Folio.Text.Trim <> lbl_Folio.Text.Trim Then
            'Validar que el nuevo folio capturado no exista
            If cn_Recepcion.fn_RecRutaspropiasCVexiste(tbx_Folio.Text) Then
                MsgBox("El Folio del Comprobante de Visita ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Folio.Focus()
                Exit Sub
            End If
        End If

        'Validar el CV
        If cn_Recepcion.fn_RecRutaspropiasValidaCV(Id_Punto, tbx_Folio.Text.Trim, tbx_Hora.Text.Trim) Then
            MsgBox("Comprobante de Visita validado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        Else
            MsgBox("No se pudo validar el Comprobante de Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

End Class