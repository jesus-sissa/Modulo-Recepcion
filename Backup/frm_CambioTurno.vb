Public Class frm_CambioTurno

    Private Sub frm_CambioTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LLenaLsv()
    End Sub

    Private Sub LLenaLsv()

        Dim Arreglo() As Object
        Arreglo = cn_Recepcion.fn_CambioTurnoH()
        If Arreglo Is Nothing Then Exit Sub
        tbx_Turno.Tag = Arreglo(0)
        tbx_Turno.Text = Arreglo(1)
        tbx_Responsable.Text = Arreglo(2)
        tbx_FechaInicio.Text = Arreglo(3)
        tbx_Hora.Text = Arreglo(4)

        cn_Recepcion.fn_CambioTurno_LlenarLista(Lsv_Turno, Arreglo(0))

        'Totales
        tbx_RemisionesE.Text = 0
        tbx_EnvasesE.Text = 0
        tbx_RemisionesS.Text = 0
        tbx_EnvasesS.Text = 0

        For I As Integer = 0 To Lsv_Turno.Items.Count - 1
            tbx_RemisionesE.Text = Val(tbx_RemisionesE.Text) + Val(Lsv_Turno.Items(I).SubItems(2).Text)
            tbx_EnvasesE.Text = Val(tbx_EnvasesE.Text) + Val(Lsv_Turno.Items(I).SubItems(3).Text)
            tbx_RemisionesS.Text = Val(tbx_RemisionesS.Text) + Val(Lsv_Turno.Items(I).SubItems(4).Text)
            tbx_EnvasesS.Text = Val(tbx_EnvasesS.Text) + Val(Lsv_Turno.Items(I).SubItems(5).Text)
        Next
        lbl_Registros.Text = "Registros: " & Lsv_Turno.Items.Count
        btn_Cambio.Enabled = True
    End Sub

    Private Sub btn_Cambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cambio.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica2

        frm.lbl_Empleado.Text = "Usuario Entrega"
        frm.Lbl_UsuarioSeg.Text = "Usuario Recibe"
        frm.ShowDialog()

        If frm.Firma = True Then
            If cn_Recepcion.fn_CambioTurno_Nuevo(Lsv_Turno, tbx_Turno.Tag, tbx_Turno.Text, frm.tbx_Empleado.Text, frm.tbx_UsuarioSeg.Text) Then
                MsgBox("El Cambio de Turno se ha realizado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ocurrió un error al intentar realizar el Cambio de Turno.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            frm.Dispose()
            Exit Sub
        End If
        frm.Dispose()
        Call LLenaLsv()

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
End Class