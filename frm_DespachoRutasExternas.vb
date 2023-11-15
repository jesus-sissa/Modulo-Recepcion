Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_DespachoRutasExternas

    Private tbx_TotalRemisiones, tbx_TotalEnvases, tbx_TotalImporte As String
    Private Columnas() As Integer = {1, 3, 4}
    Private Nombres() As String = {"Remisiones", "Importe", "Envases"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma}
    Private Formatos() As String = {"g", "n", "g"}

    Private Sub frm_DespachoRutasExternas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Cias.AgregaParametro("@Id_Cia", CiaId, 1)
        cmb_Cias.Actualizar()

        Lsv_Boveda.Columns.Add("Remision")
        Lsv_Boveda.Columns.Add("Caja")
        Lsv_Boveda.Columns.Add("Cliente")
        Lsv_Boveda.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_Boveda.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right

        Lsv_BovedaT.Columns.Add("Concepto")
        Lsv_BovedaT.Columns.Add("Remisiones").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        Lsv_BovedaT.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        Call LlenarLista()

    End Sub

    Sub LlenarLista()
        Lsv_Boveda.Items.Clear()
        Lbl_Registros.Text = "Registros: 0"
        If cmb_Cias.SelectedValue Is Nothing Then Exit Sub
        If cmb_Cias.SelectedValue = 0 Then Exit Sub
        Call cn_Recepcion.fn_DespachoProveedoresLlenalista(Lsv_Boveda, cmb_Cias.SelectedValue)
        Call fn_TotalesListView(Lsv_Boveda, Lsv_BovedaT, Columnas, Nombres, Formatos, Funciones, Modo.Total)

        Lsv_Boveda.CheckBoxes = True
        Lbl_Registros.Text = "Registros: " & Lsv_Boveda.Items.Count
        Call Calcula()
    End Sub

    Private Sub Lsv_Boveda_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Boveda.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Boveda.CheckedItems.Count > 0 Then
            Btn_Despachar.Enabled = True
        Else
            Btn_Despachar.Enabled = False
        End If
    End Sub

    Private Sub Calcula(Optional ByVal SoloChk As Boolean = False)
        Dim Elemento As ListViewItem

        If Lsv_Boveda.Items.Count > 0 Then

            Dim Importe As Decimal = 0
            Dim Envases As Decimal = 0

            If SoloChk = False Then

                For Each Elemento In Lsv_Boveda.Items
                    Importe += Elemento.SubItems(3).Text
                    Envases += Elemento.SubItems(4).Text
                Next
                tbx_TotalRemisiones = Lsv_Boveda.Items.Count
            Else
                For Each Elemento In Lsv_Boveda.CheckedItems
                    Importe += Elemento.SubItems(3).Text
                    Envases += Elemento.SubItems(4).Text
                Next
                tbx_TotalRemisiones = Lsv_Boveda.CheckedItems.Count
            End If

            tbx_TotalEnvases = Envases
            tbx_TotalImporte = Importe
        End If
    End Sub

    Private Sub Btn_Despachar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Despachar.Click
        SegundosDesconexion = 0

        If cmb_Cias.SelectedValue = 0 Then
            MsgBox("Debe de Seleccionar una Compañía de Traslado.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call Calcula(True)
            If cn_Recepcion.fn_DespachoProveedores_Create(Lsv_Boveda, cmb_Cias.SelectedValue, tbx_TotalRemisiones, tbx_TotalEnvases, tbx_TotalImporte, cmb_Cias.Text) Then
                MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
                Btn_Despachar.Enabled = False
                Call LlenarLista()
            End If
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Lsv_Boveda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Boveda.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Cias_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Cias.SelectedValueChanged
        SegundosDesconexion = 0
        Call LlenarLista()
    End Sub
End Class