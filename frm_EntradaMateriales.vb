Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_EntradaMateriales

    Private Columnas() As Integer = {1, 3}
    Private Nombres() As String = {"Remisiones", "Envases"}
    Private Formatos() As String = {"g", "g"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma}
    Public tbl As DataTable

    Private Sub frm_RecibirLotes_Boveda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista
        'cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        'cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()
        cmb_Boveda.SelectedIndex = 1
        cmb_Boveda.Enabled = False

        cn_Recepcion.fn_EntradaMateriales_LlenarLista(lsv_Ventas, 29)
        'fn_TotalesListView(lsv_Ventas, lsv_VentasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
        lsv_Ventas.CheckBoxes = True
        lsv_Ventas.Columns(2).TextAlign = HorizontalAlignment.Right
        lsv_Ventas.Columns(3).TextAlign = HorizontalAlignment.Right
        Lbl_Registros.Text = "Registros: " & lsv_Ventas.Items.Count

        lsv_VentasD.Columns.Add("Fecha")
        lsv_VentasD.Columns.Add("Hora")
        lsv_VentasD.Columns.Add("Clave")
        lsv_VentasD.Columns.Add("Cliente")
        lsv_VentasD.Columns.Add("Remision")
        lsv_VentasD.Columns.Add("Envases")
        lsv_VentasD.Columns.Add("Id Remision")

        lsv_Envases.Columns.Add("Tipo")
        lsv_Envases.Columns.Add("Numero Envase")



    End Sub

    Private Sub lsv_Ventas_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Ventas.ItemChecked
        SegundosDesconexion = 0

        If lsv_Ventas.CheckedItems.Count = 0 Then
            btn_Recibir.Enabled = False
        Else
            btn_Recibir.Enabled = True
        End If
    End Sub

    Private Sub lsv_Ventas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Ventas.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_Buscar.Enabled = True
        If lsv_Ventas.SelectedItems.Count = 0 Then
            btn_Buscar.Enabled = False
            lsv_VentasD.Items.Clear()
            lsv_Envases.Items.Clear()
            Exit Sub
        Else
            cn_Recepcion.fn_EnvioaBovedaD_LlenarLista(lsv_VentasD, lsv_VentasD.Lvs, lsv_Ventas.SelectedItems(0).Tag)
            tbl = cn_Recepcion.fn_EnvioaBovedaD_LlenarListaEnvase(lsv_VentasD, lsv_Ventas.SelectedItems(0).Tag)
            cn_Recepcion.fn_Get_Envases2(lsv_Envases, lsv_Ventas.SelectedItems(0).Tag)
            'fn_TotalesListView(lsv_Ventas, lsv_VentasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
        End If

    End Sub

    Private Sub btn_Recibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recibir.Click
        SegundosDesconexion = 0

        Dim Elementos As ListViewItem

        If lsv_Ventas.CheckedItems.Count = 0 Then
            MsgBox("Seleccione una Venta", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        For Each Elementos In lsv_Ventas.CheckedItems
            If cn_Recepcion.fn_RecLotesBoveda_Validar(Elementos.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponible, se actualizara la ventana", MsgBoxStyle.Critical, frm_MENU.Text)
                cn_Recepcion.fn_EnvioaBoveda_LlenarLista(lsv_Ventas, lsv_Ventas.Lvs)
                Exit Sub
            End If
        Next

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccion una Boveda", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            'Variables.Id_matventa = (lsv_VentasD.SelectedItems(0).SubItems(9).Text)
            If cn_Recepcion.fn_EntradaMateriales_Guardar(cmb_Boveda.SelectedValue, lsv_Ventas) = True Then
                MsgBox("Registro Guardado", MsgBoxStyle.Information, frm_MENU.Text)
                'cn_Recepcion.fn_EnvioaBoveda_LlenarLista(lsv_Ventas, lsv_Ventas.Lvs)
                lsv_Ventas.Items.Clear()
                lsv_VentasD.Items.Clear()
                lsv_Envases.Items.Clear()

                btn_Recibir.Enabled = False

                cn_Recepcion.fn_EntradaMateriales_LlenarLista(lsv_Ventas, 29)
                ' fn_TotalesListView(lsv_Ventas, lsv_VentasT, Columnas, Nombres, Formatos, Funciones, Modo.Total)
                lsv_Ventas.CheckBoxes = True
                lsv_Ventas.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv_Ventas.Columns(3).TextAlign = HorizontalAlignment.Right
                Lbl_Registros.Text = "Registros: " & lsv_Ventas.Items.Count
            End If
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_VentasD, tbx_Buscar) Then
            Call Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As cp_Listview, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function
    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_VentasD, Remision, 0)
            tbx_Buscar.Focus()
            tbx_Buscar.SelectAll()
        End If

    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In lsv_VentasD.Items
            If (item.SubItems(2).Text = Remision) Then
                item.Selected = True
            End If
        Next



    End Sub

    Private Sub tbx_Buscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not BuscarRemision(lsv_VentasD, tbx_Buscar) Then
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub
    'Private Sub Buscar(ByVal Remision As String)
    '    SegundosDesconexion = 0
    '    If tbx_Buscar.Text.Trim <> "" Then
    '        FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_VentasD, Remision, 0)
    '        tbx_Buscar.Focus()
    '        tbx_Buscar.SelectAll()
    '    End If

    'End Sub

    'Sub Buscar_Envase(ByVal Numero As String)
    '    For Each row As DataRow In tbl.Rows
    '        If (row(1).ToString() = Numero) Then
    '            Buscar(row(0).ToString())
    '            Seleccionar(row(0).ToString)
    '            Exit Sub
    '        End If
    '    Next
    'End Sub
    'Sub Seleccionar(ByVal Remision As String)
    '    For Each item As ListViewItem In lsv_VentasD.Items
    '        If (item.SubItems(4).Text = Remision) Then
    '            item.Selected = True
    '        End If
    '    Next
    'End Sub

    'Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Asc(e.KeyChar) = 13 Then
    '        Buscar_Envase(tbx_Buscar.Text)
    '    End If
    'End Sub

    'Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Buscar_Envase(tbx_Buscar.Text)
    'End Sub
End Class