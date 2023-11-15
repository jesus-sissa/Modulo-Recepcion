Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_ConsultaAperturasCierres
    Dim Bo_Status As Char = ""

    Private Sub frm_ConsultaAperturaCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Listado.Columns.Add("Fecha")
        lsv_Listado.Columns.Add("Hora")
        lsv_Listado.Columns.Add("Boveda")
        lsv_Listado.Columns.Add("Envases", 10, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Importe", 10, HorizontalAlignment.Right)
        lsv_Listado.Columns.Add("Tipo")

        cmb_Bovedas.AgregaParametro("@Tipo_Boveda", "P", 0)
        cmb_Bovedas.AgregaParametro("@Status", "A", 0)
        cmb_Bovedas.Actualizar()

        btn_Reimprimir.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_FechaInicio.Value.ToShortDateString > dtp_FechaFin.Value.ToShortDateString Then
            MsgBox("La Fecha Fin debe ser mayor a la Fecha Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaFin.Focus()
            Exit Sub
        End If
        If cmb_Bovedas.SelectedValue = 0 Then
            MsgBox("Seleccione la Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Bovedas.Focus()
            Exit Sub
        End If

        fn_ConsultaAperturasCierres_LlenarLista(cmb_Bovedas.SelectedValue, dtp_FechaInicio.Value, dtp_FechaFin.Value, lsv_Listado)
    End Sub

    Private Sub lsv_Listado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Listado.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Reimprimir.Enabled = lsv_Listado.SelectedItems.Count > 0
    End Sub

    Private Sub cmb_Bovedas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Bovedas.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Listado.Items.Clear()
        btn_Reimprimir.Enabled = False
    End Sub

    Private Sub dtp_FechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaInicio.ValueChanged
        SegundosDesconexion = 0

        lsv_Listado.Items.Clear()
        btn_Reimprimir.Enabled = False
    End Sub

    Private Sub dtp_FechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaFin.ValueChanged
        SegundosDesconexion = 0

        lsv_Listado.Items.Clear()
        btn_Reimprimir.Enabled = False
    End Sub

    Private Sub btn_Reimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reimprimir.Click, lsv_Listado.DoubleClick
        SegundosDesconexion = 0

        Dim Tipo As Integer
        If lsv_Listado.SelectedItems(0).SubItems(5).Text = "APERTURA" Then
            Tipo = 1
        Else
            Tipo = 2
        End If
        fn_Bovedas_MostrarActa(lsv_Listado.SelectedItems(0).Tag, Tipo)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub
End Class