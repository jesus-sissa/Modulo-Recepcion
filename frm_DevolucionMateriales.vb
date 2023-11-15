Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_DevolucionMateriales

    Private Columnas() As Integer = {1, 3, 4, 5}
    Private Nombres() As String = {"Remisiones", "Envases", "Envases S/N", "Importe"}
    Private Formatos() As String = {"g", "g", "g", "n"}
    Private Funciones() As Func = {Func.Conteo, Func.Suma, Func.Suma, Func.Suma}

    Public tbl As DataTable

    Private Sub frm_DevolucionMateriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        tbl = New DataTable
        lsv_Envase.Columns.Add("Tipo")
        lsv_Envase.Columns.Add("Numero Envase")

        Call LlenaLista()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        Dim TRemisiones As Integer = 0
        Dim CEnvases As Integer = 0
        Dim Elemento As ListViewItem

        If Lsv_Materiales.CheckedItems.Count > 0 Then

            TRemisiones = Lsv_Materiales.CheckedItems.Count

            For Each Elemento In Lsv_Materiales.CheckedItems
                CEnvases += Elemento.SubItems(6).Text
            Next

            If cn_Recepcion.fn_DevolucionMateriales_Guardar(Lsv_Materiales, TRemisiones, CEnvases, 30) = True Then
                MsgBox("Registro guardado ", MsgBoxStyle.Information, frm_MENU.Text)
            End If

            Call LlenaLista()
            btn_Validar.Enabled = False
        End If

    End Sub

    Private Sub LlenaLista()
        Call cn_Recepcion.fn_DevolucionMateriales_LlenarLista(Lsv_Materiales, Lsv_Materiales.Lvs)
        tbl = cn_Recepcion.fn_DevolucionMateriales_LlenarListaEnvase(Lsv_Materiales, Lsv_Materiales.Lvs)
        Call fn_TotalesListView(Lsv_Materiales, Lsv_MaterialesT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        Lbl_Registros.Text = "Registros: " & Lsv_Materiales.Items.Count
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Lsv_Materiales_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Materiales.ItemChecked
        SegundosDesconexion = 0

        fn_TotalesListView(Lsv_Materiales, Lsv_MaterialesT, Columnas, Nombres, Formatos, Funciones, Modo.TotalySeleccionados)

        If Lsv_Materiales.CheckedItems.Count > 0 Then
            btn_Validar.Enabled = True
        Else
            btn_Validar.Enabled = False
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0
        If tbx_Buscar.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Materiales, Remision, 0)
            tbx_Buscar.Focus()
            tbx_Buscar.SelectAll()
        End If

    End Sub

    Sub Buscar_Envase(ByVal Numero As String)
        For Each row As DataRow In tbl.Rows
            If (row(1).ToString() = Numero) Then
                Buscar(row(0).ToString())
                Seleccionar(row(0).ToString)
                Exit Sub
            End If
        Next
    End Sub
    Sub Seleccionar(ByVal Remision As String)
        For Each item As ListViewItem In Lsv_Materiales.Items
            If (item.SubItems(2).Text = Remision) Then
                item.Selected = True
            End If
        Next
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Materiales, tbx_Buscar) Then
                Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(Lsv_Materiales, tbx_Buscar) Then
            Buscar_Envase(tbx_Buscar.Text)
        End If
    End Sub

    Private Sub Lsv_Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Materiales.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_Envase.Items.Clear()

        If Lsv_Materiales.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_Envase, Lsv_Materiales.SelectedItems(0).Tag)
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As ListView, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function
End Class