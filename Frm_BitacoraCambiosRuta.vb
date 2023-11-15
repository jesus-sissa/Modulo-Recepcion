Imports Modulo_Recepcion.cn_Recepcion

Public Class Frm_BitacoraCambiosRuta

    Private Sub Frm_BitacoraCambiosRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Lsv_Listado.Columns.Add("Remision")
        Lsv_Listado.Columns.Add("Destino")
        Lsv_Listado.Columns.Add("Movimiento")
        Lsv_Listado.Columns.Add("Fecha Asignada")
        Lsv_Listado.Columns.Add("Ruta Asignada")
        Lsv_Listado.Columns.Add("Usuario Asigna")
        Lsv_Listado.Columns.Add("Fecha Asigna")
    End Sub

    Sub LimpiarLista()
        SegundosDesconexion = 0

        Lsv_Listado.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        Btn_Exportar.Enabled = False
    End Sub

    Private Sub Rdb_Remision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdb_Remision.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarLista()
        Tbx_Remision.Text = ""
        If Rdb_Remision.Checked Then
            Gbx_Fecha.Enabled = False
            Gbx_Remision.Enabled = True
        End If
    End Sub

    Private Sub Rdb_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdb_Fecha.CheckedChanged
        SegundosDesconexion = 0

        Call LimpiarLista()
        Tbx_Remision.Text = ""
        If Rdb_Fecha.Checked Then
            Gbx_Remision.Enabled = False
            Gbx_Fecha.Enabled = True
        End If
    End Sub

    Private Sub Dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Desde.ValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub Dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Hasta.ValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub Tbx_Remision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbx_Remision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Mostrar()
        End If
    End Sub

    Private Sub Btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Mostrar.Click
        Call Mostrar()
    End Sub

    Private Sub Mostrar()
        Call LimpiarLista()

        If Rdb_Fecha.Checked = False And Rdb_Remision.Checked = False Then
            MsgBox("Por favor seleccione un Método de Filtrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Rdb_Remision.Checked And Tbx_Remision.Text.Trim = "" Then
            MsgBox("Indique el Número de Remision a buscar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Remision.Focus()
            Exit Sub
        End If

        If Rdb_Fecha.Checked And Dtp_Desde.Value.Date > Dtp_Hasta.Value.Date Then
            MsgBox("El rango de fechas seleccionado parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If
        If Rdb_Fecha.Checked Then
            If DateDiff(DateInterval.Day, Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date) > 20 Then
                If MsgBox("Al seleccionar un periodo muy amplio, la consulta puede tardar algunos segundos extra, incluso minutos. Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If
        End If
        If Fn_MostrarVitacora(Lsv_Listado, IIf(Tbx_Remision.Text = "", 0, Tbx_Remision.Text), Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date) = False Then
            MsgBox("Ocurrió un error al intentar consultar la información.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Lbl_Registros.Text = "Registros: " & Lsv_Listado.Items.Count
        Btn_Exportar.Enabled = Lsv_Listado.Items.Count > 0
    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(Lsv_Listado, 0, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class