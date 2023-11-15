Imports Modulo_Recepcion.cn_Recepcion
Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_CancelarEnvioProceso2
    Public Depto As Char
    Public tbl As DataTable

    Private Sub frm_CancelarEnvioProceso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Remisiones.Columns.Add("Fecha")
        lsv_Remisiones.Columns.Add("Hora")
        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("Banco")
        lsv_Remisiones.Columns.Add("Cliente")
        lsv_Remisiones.Columns.Add("Envia")

        lsv_Envases.Columns.Add("Tipo de Envase")
        lsv_Envases.Columns.Add("Numero")

        Call LlenarLista()
        If Depto = "M" Then
            Me.Text = "Cancelar Envío a Morralla"
        End If
    End Sub

#Region "Eventos Privados"

    Private Sub LlenarLista()
        BanderA = False
        btn_Cancelar.Enabled = False
        lsv_Envases.Items.Clear()
        lsv_Remisiones.Items.Clear()

        'destino P=Proceso
        If Not fn_CancelarEnvioProceso_LlenarListaNew(lsv_Remisiones, Depto) Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Lbl_RegistrosDA.Text = "Registros: " & lsv_Remisiones.Items.Count
        BanderA = True
    End Sub

    'Private Sub Buscar()
    '    SegundosDesconexion = 0
    '    If Not fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, tbx_Buscar.Text.Trim, 3) Then
    '        MsgBox("No se encontró.", MsgBoxStyle.Exclamation, frm_MENU.Text)
    '    End If
    '    tbx_Buscar.SelectAll()
    '    tbx_Buscar.Focus()
    'End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_Buscar.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Remisiones, Remision, 0)
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

        If tbx_Buscar.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Remisiones.Items
                If (item.SubItems(3).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

    End Sub

#End Region

    Private Sub tbx_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not BuscarRemision(lsv_Remisiones, tbx_Buscar) Then
                tbl = cn_Recepcion.fn_CancelarEnvioProceso_LlenarListaNewEnvases(lsv_Remisiones, Depto)
                Call Buscar_Envase(tbx_Buscar.Text)
            End If
        End If
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0
        If Not BuscarRemision(lsv_Remisiones, tbx_Buscar) Then
            tbl = cn_Recepcion.fn_CancelarEnvioProceso_LlenarListaNewEnvases(lsv_Remisiones, Depto)
            Call Buscar_Envase(tbx_Buscar.Text)
        End If       
    End Sub

    Private Sub lsv_Remisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remisiones.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Remisiones.SelectedItems.Count > 0 Then
            If Not fn_CancelarEnvioProceso_Envases(lsv_Remisiones.SelectedItems(0).SubItems(8).Text, lsv_Envases) Then
                MsgBox("Ha ocurrido un error al intentar llenar la lista Detalles", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            lsv_Envases.Items.Clear()
        End If
    End Sub

    Private Sub lsv_Remisiones_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remisiones.ItemChecked
        SegundosDesconexion = 0

        btn_Cancelar.Enabled = lsv_Remisiones.CheckedItems.Count > 0
        If BanderA Then lsv_Remisiones.Items(e.Item.Index).Selected = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        If lsv_Remisiones.CheckedItems.Count = 0 Then Exit Sub

        'verificar si estan disponibles los lotes a cancelar
        For Each Elemento As ListViewItem In lsv_Remisiones.CheckedItems
            If fn_RecLotesBoveda_ValidarNew(Elemento.Tag) = True Then
                MsgBox("Algunos lotes  ya no están disponibles, se actualizará la Lista.", MsgBoxStyle.Critical, Me.Text)
                Call LlenarLista()
                Exit Sub
            End If
        Next

        If fn_CancelarEnvioProceso_CancelarNew(lsv_Remisiones) Then
            MsgBox("Se Cancelaron los Envios correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrio un error al intentar Cancelar los Envios.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call LlenarLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
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