Imports System.Data.SqlClient

Public Class frm_Bovedas

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()

    End Sub

    Private Sub frm_Bovedas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmb_Moneda.Actualizar()

        cmb_Tipo.AgregarItem("P", "PROCESO")
        cmb_Tipo.AgregarItem("M", "MORRALLA")
        cmb_Tipo.AgregarItem("C", "CAJEROS")

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Descripcion")
        lsv_Catalogo.Columns.Add("H.Apertura")
        lsv_Catalogo.Columns.Add("H.Cierre")
        lsv_Catalogo.Columns.Add("Moneda")
        lsv_Catalogo.Columns.Add("LineaRoja")
        lsv_Catalogo.Columns.Add("Tipo")
        lsv_Catalogo.Columns.Add("Status")

        Call LlenarLista()

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        lsv_Catalogo.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        BTN_Exportar.Enabled = False

        Call cn_Recepcion.fn_Bovedas_Catalogo_LlenarLista(lsv_Catalogo, "P")

        BTN_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        lbl_Registros.Text = "Registros: " & lsv_Catalogo.Items.Count
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click

        tbx_Descripcion.Clear()
        tbx_Clave.Clear()
        tbx_Clave.Tag = ""
        tbx_Descripcion.Clear()
        dtp_Apertura.Text = CDate("00:00")
        dtp_cierre.Text = CDate("00:00")
        tbx_Importe.Clear()
        cmb_Moneda.SelectedValue = 0

        Tab_Catalogo.SelectedTab = tab_Listado

        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_Clave.Text = "" Then
            MsgBox("Indique una Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If
        If tbx_Descripcion.Text = "" Then
            MsgBox("Indique una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If
        If cmb_Moneda.SelectedValue = 0 Then
            MsgBox("Seleccione la Moneda de la Línea Roja.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Moneda.Focus()
            Exit Sub
        End If
        If tbx_Importe.Text = "" Then
            MsgBox("Indique el Importe de la Línea Roja.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Importe.Focus()
            Exit Sub
        End If
        If cmb_Tipo.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo de Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If


        If Not cn_Recepcion.fn_Bovedas_Catalogo_ValidarClave(tbx_Clave.Text.Trim, tbx_Clave.Tag) Then
            'En caso de que haya campos en blanco
            MsgBox("La Clave ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            'En caso de que todo sea valido
            If Tab_Nuevo.Text = "Nuevo" Then

                'Si se esta Insertando
                If cn_Recepcion.fn_Bovedas_Catalogo_Nuevo(tbx_Clave.Text, tbx_Descripcion.Text, dtp_Apertura.Text, dtp_cierre.Text, cmb_Moneda.SelectedValue, tbx_Importe.Text, cmb_Tipo.SelectedValue) Then

                    'En caso de que se haya hecho la transaccion
                    FuncionesGlobales.fn_Menu_Progreso(30)

                    'Aqui se limpian los textbox
                    tbx_Descripcion.Clear()
                    tbx_Clave.Clear()
                    tbx_Clave.Tag = ""
                    tbx_Descripcion.Clear()
                    dtp_Apertura.Text = CDate("00:00")
                    dtp_cierre.Text = CDate("00:00")
                    tbx_Importe.Clear()
                    cmb_Moneda.SelectedValue = 0

                    'Aqui se Ajusta el titulo de la pestaña
                    Tab_Nuevo.Text = "Nuevo"
                    FuncionesGlobales.fn_Menu_Progreso(40)
                    tbx_Clave.Focus()
                Else

                    'En caso de que no se haya hecho la transaccion
                    MsgBox("No se puede agregar el nuevo elemento", MsgBoxStyle.Critical, frm_MENU.Text)
                    FuncionesGlobales.fn_Menu_Progreso(0)

                End If
            Else
                'Si se esta actualizando
                If cn_Recepcion.fn_Bovedas_Catalogo_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Clave.Text, tbx_Descripcion.Text, dtp_Apertura.Text, dtp_cierre.Text, cmb_Moneda.SelectedValue, tbx_Importe.Text, cmb_Tipo.SelectedValue) Then

                    'En caso de que se haya hecho la transaccion
                    FuncionesGlobales.fn_Menu_Progreso(30)

                    'Aqui se limpian los textbox
                    tbx_Descripcion.Clear()
                    tbx_Clave.Clear()
                    tbx_Clave.Tag = ""
                    tbx_Descripcion.Clear()
                    dtp_Apertura.Text = CDate("00:00")
                    dtp_cierre.Text = CDate("00:00")
                    tbx_Importe.Clear()
                    cmb_Moneda.SelectedValue = 0
                    Tab_Nuevo.Text = "Nuevo"

                    'Aqui se cambia la pestaña seleccionada
                    Tab_Catalogo.SelectedTab = tab_Listado
                    FuncionesGlobales.fn_Menu_Progreso(40)

                Else
                    'En caso de que no se haya hecho la transaccion
                    MsgBox("No se puede editar el elemento", MsgBoxStyle.Critical, frm_MENU.Text)
                    FuncionesGlobales.fn_Menu_Progreso(0)

                End If

            End If
            FuncionesGlobales.fn_Menu_Progreso(60)
            Call LlenarLista()
            FuncionesGlobales.fn_Menu_Progreso(100)
            'Aqui se limpia el contador de progreso
            FuncionesGlobales.fn_Menu_Progreso(0)
        End If

    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Buscar.Click
        Call Buscar()
    End Sub

    Sub Buscar()
        SegundosDesconexion = 0

        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        If FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            Btn_Baja.Enabled = True
            BTN_Modificar.Enabled = True
        Else
            Btn_Baja.Enabled = True
            BTN_Modificar.Enabled = True
        End If
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0

        Dim Dr As DataRow = cn_Recepcion.fn_Bovedas_Catalogo_ObtenValores(lsv_Catalogo.SelectedItems(0).Tag)
        If Not Dr Is Nothing Then
            tbx_Clave.Tag = Dr("Clave")
            tbx_Descripcion.Text = Dr("Descripcion")
            tbx_Clave.Text = Dr("Clave")
            dtp_Apertura.Text = CDate(Dr("Hora_Apertura"))
            dtp_cierre.Text = CDate(Dr("Hora_Cierre"))
            tbx_Importe.Text = Dr("Importe_LR")
            cmb_Moneda.SelectedValue = Dr("Moneda_LR")
            cmb_Tipo.SelectedValue = Dr("Tipo_Boveda")
        End If

        Tab_Nuevo.Text = "Modificar"
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Baja.Click
        SegundosDesconexion = 0
        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ACTIVO" Then
            cn_Recepcion.fn_Bovedas_Catalogo_BajaAlta(lsv_Catalogo.SelectedItems(0).Tag, "B")
        ElseIf lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "BAJA" Then
            cn_Recepcion.fn_Bovedas_Catalogo_BajaAlta(lsv_Catalogo.SelectedItems(0).Tag, "A")
        End If

        Call LlenarLista()

    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub dtp_Apertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Apertura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_cierre.Focus()
        End If
    End Sub

    Private Sub dtp_cierre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_cierre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmb_Moneda.Focus()
        End If
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Buscar()
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        'Aqui se desactivan los botones de edicion
        Btn_Baja.Enabled = False
        BTN_Modificar.Enabled = False
        If lsv_Catalogo.SelectedItems.Count = 0 Then Exit Sub
        If lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "ACTIVO" Or lsv_Catalogo.SelectedItems(0).SubItems(7).Text = "BAJA" Then
            Btn_Baja.Enabled = True
        End If
        BTN_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0
        tbx_Clave.Focus()
    End Sub
End Class