Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_Pernoctas

    Private Sub frm_Pernoctas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_Desde.Value = Now.Date
        dtp_Hasta.Value = Now.Date

        dtp_InicioPernocta.Value = Now.Date
        dtp_FinPernocta.Value = Now.Date
        tbx_Dias.Text = 1

        cmb_CS.AgregaParametro("@Id_Cliente", -1, 1)
        cmb_CS.AgregaParametro("@Clave_Linea", "BOV", 0)
        cmb_CS.AgregaParametro("@MostrarPrecio", "N", 0)
        cmb_CS.Actualizar()

        cmb_Cliente.AgregaParametro("@Status", "T", 0)
        cmb_Cliente.Actualizar()

        cmb_Status.AgregarItem("A", "DENTRO")
        cmb_Status.AgregarItem("B", "FUERA")

        lsv_Custodia.Columns.Add("Remision")
        lsv_Custodia.Columns.Add("Caja")
        lsv_Custodia.Columns.Add("Cliente")
        lsv_Custodia.Columns.Add("FechaEntrada")
        lsv_Custodia.Columns.Add("FechaSalida")
        lsv_Custodia.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        lsv_Custodia.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        lsv_Custodia.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        lsv_Custodia.Columns.Add("Status")

        lsv_Proceso.Columns.Add("Remision")
        lsv_Proceso.Columns.Add("ClienteOrigen")
        lsv_Proceso.Columns.Add("ClienteDestino")
        lsv_Proceso.Columns.Add("FechaEntrada")
        lsv_Proceso.Columns.Add("FechaSalida")
        lsv_Proceso.Columns.Add("Importe").TextAlign = HorizontalAlignment.Right
        lsv_Proceso.Columns.Add("Envases").TextAlign = HorizontalAlignment.Right
        lsv_Proceso.Columns.Add("EnvasesSN").TextAlign = HorizontalAlignment.Right
        lsv_Proceso.Columns.Add("Status")

        lsv_Pernoctas.Columns.Add("Fecha")
        lsv_Pernoctas.Columns.Add("Miles").TextAlign = HorizontalAlignment.Right
        lsv_Pernoctas.Columns.Add("Observaciones")
        lsv_Pernoctas.Columns.Add("Status")
    End Sub

    Sub Limpiar()
        dtp_InicioPernocta.Value = Now.Date
        dtp_FinPernocta.Value = Now.Date
        tbx_Dias.Text = 1
        cmb_CS.SelectedValue = 0
        tbx_Observaciones.Clear()
    End Sub

    Sub Botones()
        btn_Editar.Enabled = False
        btn_Baja.Enabled = False
        btn_Cancelar.Enabled = False
        If lsv_Pernoctas.SelectedItems.Count > 0 Then
            btn_Editar.Enabled = lsv_Pernoctas.SelectedItems(0).SubItems(4).Text <> "VALIDADO"
            btn_Baja.Enabled = lsv_Pernoctas.SelectedItems(0).SubItems(4).Text <> "VALIDADO"
        End If
    End Sub

    Sub LlenarCustodia()
        lsv_Pernoctas.Items.Clear()
        lsv_Custodia.Items.Clear()
        Dim Status As Char = cmb_Status.SelectedValue
        If chk_Status.Checked Then Status = "T"
        If Not fn_Pernoctas_LlenarListas(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, cmb_Cliente.SelectedValue, 1, lsv_Custodia) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Custodia.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub LlenarProceso()
        lsv_Pernoctas.Items.Clear()
        lsv_Proceso.Items.Clear()
        Dim Status As Char = cmb_Status.SelectedValue
        If chk_Status.Checked Then Status = "T"
        If Not fn_Pernoctas_LlenarListas(dtp_Desde.Value.Date, dtp_Hasta.Value.Date, Status, cmb_Cliente.SelectedValue, 2, lsv_Proceso) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Proceso.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub LlenarPernoctas()
        lsv_Pernoctas.Items.Clear()
        Dim CargaCorrecta As Boolean

        Select Case tab_Pernoctas.SelectedTab.Name
            Case tab_Custodia.Name
                CargaCorrecta = fn_Pernoctas_LlenarPercnotas(lsv_Custodia.SelectedItems(0).Tag, lsv_Pernoctas)

            Case tab_Proceso.Name
                CargaCorrecta = fn_Pernoctas_LlenarPercnotas(lsv_Proceso.SelectedItems(0).Tag, lsv_Pernoctas)

        End Select

        If Not CargaCorrecta Then MsgBox("Ocurrio un error al intentar cargar la lista de Pernoctas.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub Controles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Hasta.ValueChanged, dtp_Desde.ValueChanged, cmb_Status.SelectedValueChanged, cmb_Cliente.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Proceso.Items.Clear()
        lsv_Custodia.Items.Clear()
        lsv_Pernoctas.Items.Clear()
        btn_Guardar.Enabled = False
        lsv_Pernoctas.Enabled = True
        Call Limpiar()
        Call Botones()
        'Cuando sea el combo de cliente se actualice el combo CS (cliente servicio)
        If sender.Equals(cmb_Cliente) Then
            If cmb_Cliente.SelectedValue > 0 Then
                cmb_CS.ActualizaValorParametro("@Id_Cliente", cmb_Cliente.SelectedValue)
                cmb_CS.Actualizar()
            ElseIf cmb_Cliente.Items.Count > 0 Then
                cmb_CS.ActualizaValorParametro("@Id_Cliente", -1)
                cmb_CS.Actualizar()
            End If
        End If
    End Sub

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_Cliente.Focus()
    End Sub

    Private Sub cmb_Cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Cliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Status.Enabled Then
                cmb_Status.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        btn_Guardar.Enabled = False
        lsv_Pernoctas.Enabled = True
        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        'Validar datos
        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicio no puede ser mayor al a Fecha Fin.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_Cliente.SelectedValue = 0 Then
            MsgBox("Seleccione un Cliente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Cliente.Focus()
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" AndAlso Not chk_Status.Checked Then
            MsgBox("Seleccione un Status o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Call LlenarCustodia()
        Call LlenarProceso()
        Select Case tab_Pernoctas.SelectedTab.Name
            Case tab_Custodia.Name
                btn_Guardar.Enabled = lsv_Custodia.Items.Count > 0

            Case tab_Proceso.Name
                btn_Guardar.Enabled = lsv_Proceso.Items.Count > 0

        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tab_Pernoctas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab_Pernoctas.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Custodia.SelectedItems.Clear()
        lsv_Proceso.SelectedItems.Clear()
        Select Case tab_Pernoctas.SelectedTab.Name
            Case tab_Custodia.Name
                btn_Guardar.Enabled = lsv_Custodia.Items.Count > 0

            Case tab_Proceso.Name
                btn_Guardar.Enabled = lsv_Proceso.Items.Count > 0
        End Select
    End Sub

    Private Sub lsv_CustodiaProceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Custodia.SelectedIndexChanged, lsv_Proceso.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Pernoctas.Items.Clear()
        lsv_Pernoctas.Enabled = True
        Call Limpiar()
        Call Botones()
        If (lsv_Custodia.SelectedItems.Count > 0 AndAlso lsv_Custodia.SelectedItems(0).SubItems(9).Text <> 0) _
        OrElse (lsv_Proceso.SelectedItems.Count > 0 AndAlso lsv_Proceso.SelectedItems(0).SubItems(9).Text <> 0) Then
            Call LlenarPernoctas()
        End If
    End Sub

    Private Sub dtp_InicioPernocta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_InicioPernocta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_FinPernocta.Focus()
    End Sub

    Private Sub dtp_FinPernocta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FinPernocta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_CS.Focus()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        'Validar Datos
        If lsv_Pernoctas.Enabled Then
            If dtp_InicioPernocta.Value.Date > dtp_FinPernocta.Value.Date Then
                MsgBox("La Fecha Inicio de la Pernocta no debe ser mayor que la Fecha Fin de la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
                dtp_InicioPernocta.Focus()
                Exit Sub
            End If
        End If

        If cmb_CS.SelectedValue = 0 Then
            MsgBox("Seleccione el Servicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_CS.Focus()
            Exit Sub
        End If

        If tbx_Observaciones.TextLength <= 10 Then
            MsgBox("Capture unas Observaciones más específicas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Observaciones.Focus()
            Exit Sub
        End If

        'Si la lista de pernoctas esta activa significa que se crearán pernoctas, sino es editar una pernocta.
        If lsv_Pernoctas.Enabled Then
            Select Case tab_Pernoctas.SelectedTab.Name
                Case tab_Custodia.Name
                    If lsv_Custodia.CheckedItems.Count > 0 Then
                        If fn_Pernoctas_Guardar(dtp_InicioPernocta.Value.Date, dtp_FinPernocta.Value.Date, cmb_Cliente.SelectedValue, cmb_CS.SelectedValue, tbx_Observaciones.Text, lsv_Custodia) Then
                            Call LlenarCustodia()
                            Call Limpiar()
                        Else
                            MsgBox("Ocurrio un error al Guardar la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Else
                        MsgBox("Debe Marcar las Remisiones de Custodia que se les generará la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                Case tab_Proceso.Name
                    If lsv_Proceso.CheckedItems.Count > 0 Then
                        If fn_Pernoctas_Guardar(dtp_InicioPernocta.Value.Date, dtp_FinPernocta.Value.Date, cmb_Cliente.SelectedValue, cmb_CS.SelectedValue, tbx_Observaciones.Text, lsv_Proceso) Then
                            Call LlenarProceso()
                            Call Limpiar()
                        Else
                            MsgBox("Ocurrio un error al Guardar la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                    Else
                        MsgBox("Debe Marcar las Remisiones de Proceso que se les generará la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
            End Select

            MsgBox("Se Guardo correctamente la información.", MsgBoxStyle.Information, frm_MENU.Text)

        Else
            'Obtener el valor en Miles
            Dim Miles As Decimal

            Select Case tab_Pernoctas.SelectedTab.Name
                Case tab_Custodia.Name
                    Miles = CDec(lsv_Custodia.SelectedItems(0).SubItems(5).Text)
                Case tab_Proceso.Name
                    Miles = CDec(lsv_Proceso.SelectedItems(0).SubItems(5).Text)
            End Select

            If (Miles Mod 1000) = 0 Then
                Miles = Miles \ 1000
            Else
                If (Miles Mod 1000) >= 999.5 Then
                    Miles = Miles \ 1000
                Else
                    Miles = (Miles \ 1000) + 1
                End If
            End If

            'Actualizar pernocta
            If fn_Pernoctas_Actualizar(lsv_Pernoctas.SelectedItems(0).Tag, dtp_InicioPernocta.Value.Date, cmb_CS.SelectedValue, Miles, tbx_Observaciones.Text) Then
                Call Botones()
                Call Limpiar()
                lsv_Pernoctas.Enabled = True
                dtp_FinPernocta.Enabled = True
                Call LlenarPernoctas()
                MsgBox("Se Actualizó la Pernocta correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ocurrio un error al intentar Actualizar la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub lsv_Pernoctas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Pernoctas.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Botones()
    End Sub

    Private Sub btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Editar.Click, lsv_Pernoctas.DoubleClick
        SegundosDesconexion = 0

        btn_Editar.Enabled = False
        btn_Baja.Enabled = False
        btn_Cancelar.Enabled = True
        lsv_Pernoctas.Enabled = False
        dtp_FinPernocta.Enabled = False

        dtp_InicioPernocta.Value = lsv_Pernoctas.SelectedItems(0).Text
        dtp_FinPernocta.Value = lsv_Pernoctas.SelectedItems(0).Text
        cmb_CS.SelectedValue = lsv_Pernoctas.SelectedItems(0).SubItems(4).Text
        tbx_Observaciones.Text = lsv_Pernoctas.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        If fn_Pernoctas_Eliminar(lsv_Pernoctas.SelectedItems(0).Tag) Then
            Select Case tab_Pernoctas.SelectedTab.Name
                Case tab_Custodia.Name
                    Call LlenarCustodia()
                Case tab_Proceso.Name
                    Call LlenarProceso()
            End Select
            Call Botones()
        Else
            MsgBox("Ocurrio un error al intentar Eliminar la Pernocta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        dtp_FinPernocta.Enabled = True
        lsv_Pernoctas.Enabled = True
        lsv_Pernoctas.SelectedItems.Clear()
        Call Limpiar()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub dtp_InicioPernocta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_InicioPernocta.ValueChanged, dtp_FinPernocta.ValueChanged
        tbx_Dias.Text = DateDiff(DateInterval.Day, dtp_InicioPernocta.Value.Date, dtp_FinPernocta.Value.Date) + 1
    End Sub

End Class