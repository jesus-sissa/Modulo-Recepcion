Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_DevolucionReciboResgLotesBoveda

    Private Columnas() As Integer = {1, 1, 2, 3}
    Private Nombres() As String = {"Remisiones", "Importe", "Envases", "Envases S/N"}
    Private Formatos() As String = {"g", "n", "g", "g"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma, Func.Suma}
    Private tbx_Remisiones, tbx_Envases As String

    Private Sub frm_DevolucionReciboResgLotesBoveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenaLista()
    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Resguardos.ItemChecked
        SegundosDesconexion = 0

        fn_TotalesListView(lsv_Resguardos, lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)
        If lsv_Resguardos.CheckedItems.Count = 0 Then
            btn_Devolucion.Enabled = False
        Else
            btn_Devolucion.Enabled = True
        End If
    End Sub

    Private Sub btn_Devolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Devolucion.Click
        SegundosDesconexion = 0

        Dim Elemento As ListViewItem

        For Each Elemento In lsv_Resguardos.CheckedItems
            If cn_Recepcion.fn_DevolucionResguardos_Valida(Elemento.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Next

        If cn_Recepcion.fn_DevolucionResguardos_Guardar(lsv_Resguardos, tbx_Remisiones, tbx_Envases, 13) = True Then
            MsgBox("Registro guardado", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        Call LlenaLista()
        btn_Devolucion.Enabled = False
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LlenaLista()
        Call cn_Recepcion.fn_DevolucionResguardos_LlenarLista(lsv_Resguardos)
        fn_TotalesListView(lsv_Resguardos, lsv_ResguardosT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)
        lsv_Resguardos.CheckBoxes = True
        Call Calcula()
        Lbl_Registros.Text = "Registros: " & lsv_Resguardos.Items.Count
    End Sub

    Private Sub Calcula()
        Dim Elemento As ListViewItem

        If lsv_Resguardos.Items.Count > 0 Then
            Dim Importe As Decimal = 0
            Dim Envases As Decimal = 0

            For Each Elemento In lsv_Resguardos.Items
                Importe += Elemento.SubItems(1).Text
                Envases += Elemento.SubItems(8).Text
            Next
            tbx_Remisiones = lsv_Resguardos.Items.Count
            tbx_Envases = Envases
        End If
    End Sub

End Class