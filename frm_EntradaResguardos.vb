Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_EntradaResguardos

    Private Columnas() As Integer = {1, 5}
    Private Nombres() As String = {"Remisiones", "Envases"}
    Private Formatos() As String = {"g", "g"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma}

    Private Sub frm_EntradaResguardos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        lsv_Envases.Columns.Add("Tipo")
        lsv_Envases.Columns.Add("Numero Envase")
        Call Llenalista()

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()
    End Sub

    Private Sub Lsv_Resguardos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Resguardos.SelectedIndexChanged
        SegundosDesconexion = 0

        Lsv_ResguardosD.Items.Clear()
        lsv_Envases.Items.Clear()
        If Lsv_Resguardos.SelectedItems.Count <> 0 Then
            cn_Recepcion.fn_EntradaResguardoDLlenalista(Lsv_ResguardosD, Lsv_Resguardos.SelectedItems(0).Tag)
            cn_Recepcion.fn_Get_Envases2(lsv_Envases, Lsv_Resguardos.SelectedItems(0).Tag)
            Lsv_ResguardosD.Columns(1).TextAlign = HorizontalAlignment.Right
            Lsv_ResguardosD.Columns(2).TextAlign = HorizontalAlignment.Right
        End If

    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Recibir.Click
        SegundosDesconexion = 0

        Dim Elemento As ListViewItem

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccion una Boveda", MsgBoxStyle.Critical, frm_MENU.Text)
        Else

            For Each Elemento In Lsv_Resguardos.CheckedItems
                If cn_Recepcion.fn_RecLotesBoveda_Validar(Elemento.Tag) Then
                    MsgBox("Algunos Lotes ya no son Válidos.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Call Llenalista()
                    Exit Sub
                End If
            Next
            Dim frm As New frm_FirmaElectronica
            frm.Bloquear = True
            frm.ShowDialog()
            If frm.Firma Then
                If cn_Recepcion.fn_EntradaResguardo_Guardar(cmb_Boveda.SelectedValue, Lsv_Resguardos) = True Then
                    MsgBox("Registro Guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                    cn_Recepcion.fn_EntradaResguardoLlenalista(Lsv_Resguardos)
                    fn_TotalesListView(Lsv_Resguardos, Lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                    Lsv_ResguardosD.Items.Clear()
                    Btn_Recibir.Enabled = False
                Else
                    MsgBox("Ocurrió un error al intentar Guardar los Resguardos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Lsv_Resguardos_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Resguardos.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Resguardos.CheckedItems.Count > 0 Then
            Btn_Recibir.Enabled = True
        Else
            Btn_Recibir.Enabled = False
        End If

    End Sub

    Private Sub Llenalista()
        cn_Recepcion.fn_EntradaResguardoLlenalista(Lsv_Resguardos)
        fn_TotalesListView(Lsv_Resguardos, Lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
        Lsv_Resguardos.CheckBoxes = True
        Lsv_Resguardos.Columns(4).TextAlign = HorizontalAlignment.Right
        Lsv_Resguardos.Columns(5).TextAlign = HorizontalAlignment.Right

        Lsv_ResguardosD.Columns.Add("Remision")
        Lsv_ResguardosD.Columns.Add("Caja")
        Lsv_ResguardosD.Columns.Add("Moneda")
        Lsv_ResguardosD.Columns.Add("Importe")
        Lsv_ResguardosD.Columns.Add("Envases")
    End Sub

End Class