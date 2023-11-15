Imports Modulo_Recepcion.FuncionesGlobales

Public Class frm_AsignarATM
    Private tbx_Remisiones As String
    Private tbx_Envases As String
    Dim tbl As DataTable

    Private Sub frm_ConcentracionATM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Remanentes.Columns.Add("FechaEntrada")
        lsv_Remanentes.Columns.Add("Hora")
        lsv_Remanentes.Columns.Add("Remision")
        lsv_Remanentes.Columns.Add("Caja")
        lsv_Remanentes.Columns.Add("Importe")
        lsv_Remanentes.Columns.Add("Envases")
        lsv_Remanentes.Columns.Add("EnvasesSN")

        Lsv_Servicios.Columns.Add("FechaEntrada")
        Lsv_Servicios.Columns.Add("Hora")
        Lsv_Servicios.Columns.Add("Remision")
        Lsv_Servicios.Columns.Add("Caja")
        Lsv_Servicios.Columns.Add("Importe")
        Lsv_Servicios.Columns.Add("Envases")
        Lsv_Servicios.Columns.Add("EnvasesSN")

        lsv_EnvasesRem.Columns.Add("Tipo")
        lsv_EnvasesRem.Columns.Add("Numero Envase")

        Call LlenaLista()

    End Sub

    Private Sub LlenaLista()
        SegundosDesconexion = 0

        Btn_Custodia.Enabled = False
        btn_Enviar.Enabled = False
        lsv_Remanentes.Items.Clear()
        Lsv_Servicios.Items.Clear()
        Call cn_Recepcion.fn_ConcentracionesLlenalista(lsv_Remanentes)
        Call cn_Recepcion.fn_Servicios_Llenalista(Lsv_Servicios)

        lbl_RegistrosR.Text = "Registros: " & lsv_Remanentes.Items.Count
        Lbl_RegistrosS.Text = "Registros: " & Lsv_Servicios.Items.Count
    End Sub


    Private Sub lsv_Remanentes_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Remanentes.ItemChecked
        SegundosDesconexion = 0

        If lsv_Remanentes.CheckedItems.Count = 0 Then
            btn_Enviar.Enabled = False
            Btn_Custodia.Enabled = False
        Else
            btn_Enviar.Enabled = True
            Btn_Custodia.Enabled = True
            Call Calcula()
        End If
    End Sub

    Private Sub lsv_Servicios_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lsv_Servicios.ItemChecked
        SegundosDesconexion = 0

        If Lsv_Servicios.CheckedItems.Count = 0 Then
            btn_Enviar.Enabled = False
            tbx_Envases = 0
            tbx_Remisiones = 0
        Else
            btn_Enviar.Enabled = True
            Call Calcula()
        End If

    End Sub

    Private Sub btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Enviar.Click
        SegundosDesconexion = 0

        lsv_EnvaseSer.Items.Clear()
        lsv_EnvasesRem.Items.Clear()

        Dim Elemento As ListViewItem
        Call Calcula()

        For Each Elemento In lsv_Remanentes.CheckedItems
            If cn_Recepcion.fn_DevolucionDotacion_Valida(Elemento.Tag) = True Then
                MsgBox("Algunos de los Lotes ya no esta disponibles, se actualizará la ventana.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Next

        If Tab_Control.SelectedTab Is Tab_Concentracion Then
            If cn_Recepcion.fn_DevConcentracionATS_Guardar(lsv_Remanentes, tbx_Remisiones, tbx_Envases, 39) = True Then
                MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
            End If

        Else
            If cn_Recepcion.fn_DevConcentracionATS_Guardar(Lsv_Servicios, tbx_Remisiones, tbx_Envases, 2) = True Then
                MsgBox("Registro guardado.", MsgBoxStyle.Information, frm_MENU.Text)
            End If

        End If

        Call LlenaLista()

    End Sub

    Private Sub Btn_Custodia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Custodia.Click
        SegundosDesconexion = 0

        If Tab_Control.SelectedTab Is Tab_Servicios Then
            MsgBox("Solo es posible realizar esta acción en la sección «Remanentes».", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        'Cambiarle Custodia_ATM = 'S' y Concentracion_ATM = 'N'
        If MsgBox("Está a punto de Convertir los REMANENTES seleccionados en Custodias. Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) <> MsgBoxResult.Yes Then Exit Sub
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()
        If frm.Firma Then
            If cn_Recepcion.fn_Servicios_ActualizarTipos(lsv_Remanentes, 1, 0, "N", "N", "N", "N", "N", "S", "N") Then
                'Hacer un ciclo para la bitacora
                For Each Elemento As ListViewItem In lsv_Remanentes.CheckedItems
                    FuncionesGlobales.fn_GuardaBitacora(38, "REMISION: " & Elemento.SubItems(2).Text & " CAJA: " & Elemento.SubItems(3).Text & " IMPORTE: " & Elemento.SubItems(4).Text, CInt(Elemento.Tag))
                Next
                MsgBox("Los Remanentes se cambiaron correctamente. Ya las podrá ver en la pantalla de Asignar Fecha y Ruta a Servicios.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LlenaLista()
            End If
        Else
            MsgBox("No se realizó ningún movimiento.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Calcula()
        Dim Elemento As ListViewItem

        If Tab_Control.SelectedTab Is Tab_Concentracion Then

            If lsv_Remanentes.CheckedItems.Count > 0 Then
                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                For Each Elemento In lsv_Remanentes.CheckedItems
                    Importe += Elemento.SubItems(4).Text
                    Envases += CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text)
                Next

                tbx_Remisiones = lsv_Remanentes.CheckedItems.Count
                tbx_Envases = Envases

            End If

        Else 'Tab_Servicios

            If Lsv_Servicios.CheckedItems.Count > 0 Then
                Dim Importe As Decimal = 0
                Dim Envases As Decimal = 0

                For Each Elemento In Lsv_Servicios.CheckedItems
                    Importe += Elemento.SubItems(4).Text
                    Envases += CInt(Elemento.SubItems(5).Text) + CInt(Elemento.SubItems(6).Text)
                Next

                tbx_Remisiones = Lsv_Servicios.CheckedItems.Count
                tbx_Envases = Envases

            End If
        End If

    End Sub

    Private Sub Tab_Control_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Control.SelectedIndexChanged
        SegundosDesconexion = 0

        If Tab_Control.SelectedTab Is Tab_Concentracion Then
            Btn_Custodia.Visible = True
        Else
            Btn_Custodia.Visible = False
        End If
    End Sub

    Private Sub Buscar(ByVal Remision As String)
        SegundosDesconexion = 0

        If tbx_BuscarRem.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(lsv_Remanentes, Remision, 0)
            tbx_BuscarRem.Focus()
            tbx_BuscarRem.SelectAll()
        End If

        If tbx_BuscarSer.Text.Trim <> "" Then
            FuncionesGlobales.fn_BuscarSeleccionarMarca_enListView(Lsv_Servicios, Remision, 0)
            tbx_BuscarSer.Focus()
            tbx_BuscarSer.SelectAll()
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

        If tbx_BuscarRem.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In lsv_Remanentes.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

        If tbx_BuscarSer.Text = "" Then
            Exit Sub
        Else
            For Each item As ListViewItem In Lsv_Servicios.Items
                If (item.SubItems(2).Text = Remision) Then
                    item.Selected = True
                End If
            Next
        End If

    End Sub


    Private Sub lsv_Remanentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Remanentes.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_EnvasesRem.Items.Clear()

        If lsv_Remanentes.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_Get_Envases3(lsv_EnvasesRem, lsv_Remanentes.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub tbx_BuscarRem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarRem.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(lsv_Remanentes, tbx_BuscarRem) Then
                tbl = cn_Recepcion.fn_ConcentracionesLlenalistaEnvases(lsv_Remanentes)
                Buscar_Envase(tbx_BuscarRem.Text)
            End If
        End If
    End Sub

    Private Sub tbx_BuscarSer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_BuscarSer.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = 13 Then
            If Not BuscarRemision(Lsv_Servicios, tbx_BuscarSer) Then
                tbl = cn_Recepcion.fn_Servicios_LlenalistaEnvases(Lsv_Servicios)
                Buscar_Envase(tbx_BuscarSer.Text)
            End If
        End If
    End Sub

    Private Sub btn_BuscarRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarRem.Click
        If Not BuscarRemision(lsv_Remanentes, tbx_BuscarRem) Then
            tbl = cn_Recepcion.fn_ConcentracionesLlenalistaEnvases(lsv_Remanentes)
            Buscar_Envase(tbx_BuscarRem.Text)
        End If
    End Sub

    Private Sub btn_BuscarSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarSer.Click
        If Not BuscarRemision(Lsv_Servicios, tbx_BuscarSer) Then
            tbl = cn_Recepcion.fn_Servicios_LlenalistaEnvases(Lsv_Servicios)
            Buscar_Envase(tbx_BuscarSer.Text)
        End If
    End Sub
    Function BuscarRemision(ByVal lsv As ListView, ByVal txt As TextBox) As Boolean
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv.SelectedItems(0).Index + 1
        End If
        'fn_Buscar_enListView(lsv_Boveda, tbx_BuscarBoveda.Text, 0, Fila_Inicio)
        If Not fn_BuscarSeleccionarMarca_enListView(lsv, txt.Text.Trim, 1) Then
            Return False
        End If
        txt.SelectAll()
        txt.Focus()
        Return True
    End Function
End Class