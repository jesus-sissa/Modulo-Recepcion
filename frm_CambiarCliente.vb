Public Class frm_CambiarCliente
    Dim Tipo As Integer
    Dim TipoP As Integer
    Dim Cliente_Original As String

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub Buscar()
        If IsNumeric(tbx_Remision.Text) Then

            cmb_Cia.ValorParametro = CLng(tbx_Remision.Text)
            cmb_Cia.ValueMember = "Id_Remision"
            cmb_Cia.DisplayMember = "Alias"
            cmb_Cia.Actualizar()

            If cmb_Cia.Items.Count = 2 Then
                cmb_Cia.SelectedIndex = 1
            End If
        Else
            MsgBox("Capture un Número de Remisión válido.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub Validar()

        If cmb_Cia.SelectedValue = 0 Then
            btn_Guardar.Enabled = False
            Exit Sub
        End If

        If Not rb_Custodia.Checked And Not rb_Deposito.Checked Then
            btn_Guardar.Enabled = False
            Exit Sub
        End If

        If cmb_ClienteO.Enabled And cmb_ClienteO.SelectedValue = 0 Then
            btn_Guardar.Enabled = False
            Exit Sub
        End If

        If cmb_ClienteD.Enabled And cmb_ClienteD.SelectedValue = 0 Then
            btn_Guardar.Enabled = False
            Exit Sub
        End If

        btn_Guardar.Enabled = True
    End Sub

    Private Sub tbx_Remision_EnterPress() Handles tbx_Remision.EnterPress
        Call Buscar()
    End Sub

    Private Sub LimpiarDetalle()

        rb_Custodia.Checked = False
        rb_Deposito.Checked = False

        cmb_ClienteD.DataSource = Nothing
        cmb_ClienteO.DataSource = Nothing

    End Sub

    Private Sub cmb_Cia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cia.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Cia.DataSource Is Nothing Then Exit Sub

        If cmb_Cia.Items.Count = 0 Then Exit Sub

        If cmb_Cia.SelectedValue = "0" Then
            Call LimpiarDetalle()
            Exit Sub
        End If

        Dim row As DataRow = cn_Recepcion.fn_CambiarCliente_BuscarBoveda(cmb_Cia.SelectedValue)

        If row Is Nothing Then
            MsgBox("No se puede encontrar la Remision en Bóveda.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        Cliente_Original = "REM: " & tbx_Remision.Text & " ID: " & cmb_Cia.SelectedValue.ToString
        Select Case row("Tipo")
            Case 1
                rb_Custodia.Checked = True
                rb_Deposito.Checked = False
                Cliente_Original = Cliente_Original & " CUSTODIA: "
            Case 2
                rb_Custodia.Checked = False
                rb_Deposito.Checked = True
                Cliente_Original = Cliente_Original & " DEPOSITO: "
        End Select

        cmb_ClienteO.SelectedValue = row("Entidad_Origen")
        cmb_ClienteD.SelectedValue = row("Entidad_Destino")

        Call Validar()
        Select Case row("Tipo")
            Case 1
                Cliente_Original = Cliente_Original & cmb_ClienteO.Text & " A " & cmb_ClienteD.Text
            Case 2
                Cliente_Original = Cliente_Original & cmb_ClienteO.Text
        End Select

    End Sub

    Private Sub rb_Custodia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Custodia.CheckedChanged
        SegundosDesconexion = 0

        If rb_Custodia.Checked Then

            cmb_ClienteO.DataSource = Nothing
            cmb_ClienteO.Enabled = True
            cmb_ClienteO.StoredProcedure = "Cat_Clientes_ComboGet"
            cmb_ClienteO.ValueMember = "Id_Cliente"
            cmb_ClienteO.DisplayMember = "Nombre_Comercial"
            cmb_ClienteO.Pista = False
            cmb_ClienteO.Empresa = False
            cmb_ClienteO.Sucursal = False
            cmb_ClienteO.Actualizar()

            cmb_ClienteD.DataSource = Nothing
            cmb_ClienteD.Enabled = True
            cmb_ClienteD.StoredProcedure = "Cat_Clientes_ComboGet"
            cmb_ClienteD.ValueMember = "Id_Cliente"
            cmb_ClienteD.DisplayMember = "Nombre_Comercial"
            cmb_ClienteD.Pista = False
            cmb_ClienteD.Empresa = False
            cmb_ClienteD.Sucursal = False
            cmb_ClienteD.Actualizar()

            Tipo = 1
            TipoP = 0
        End If

        Call Validar()
    End Sub

    Private Sub rb_Deposito_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_Deposito.CheckedChanged
        SegundosDesconexion = 0

        If rb_Deposito.Checked Then

            cmb_ClienteO.DataSource = Nothing
            cmb_ClienteO.Enabled = True
            cmb_ClienteO.StoredProcedure = "Cat_ClientesProceso_ComboGet"
            cmb_ClienteO.ValueMember = "Id_ClienteP"
            cmb_ClienteO.DisplayMember = "ClienteP"
            cmb_ClienteO.Pista = False
            cmb_ClienteO.Empresa = False
            cmb_ClienteO.Sucursal = True
            cmb_ClienteO.Actualizar()

            cmb_ClienteD.Enabled = False
            cmb_ClienteD.DataSource = Nothing

            Tipo = 2
            TipoP = 1
        End If

        Call Validar()
    End Sub

    Private Sub cmb_ClienteO_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClienteO.SelectedValueChanged
        SegundosDesconexion = 0
        Call Validar()
    End Sub

    Private Sub cmb_ClienteD_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ClienteD.SelectedValueChanged
        SegundosDesconexion = 0

        Call Validar()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        Dim Entidad_Origen As Integer = cmb_ClienteO.SelectedValue
        Dim Entidad_Destino As Integer = If(rb_Deposito.Checked, 0, cmb_ClienteD.SelectedValue)
        Dim dr_OrigenDestino As DataRow

        If rb_Custodia.Checked Then
            Cliente_Original = Cliente_Original & " -> CUSTODIA: " & cmb_ClienteO.Text & " A " & cmb_ClienteD.Text
            cn_Recepcion.fn_CambiarCliente_ActualizarRemision(cmb_Cia.SelectedValue, Entidad_Origen, Entidad_Destino, 0)
        ElseIf rb_Deposito.Checked Then
            Cliente_Original = Cliente_Original & " -> DEPOSITO: " & cmb_ClienteO.Text
            dr_OrigenDestino = cn_Recepcion.fn_CambiarCliente_BuscarOrigenDestino(cmb_ClienteO.SelectedValue)
            If dr_OrigenDestino IsNot Nothing Then
                cn_Recepcion.fn_CambiarCliente_ActualizarRemision(cmb_Cia.SelectedValue, dr_OrigenDestino("ClienteOrigen"), dr_OrigenDestino("ClienteDestino"), cmb_ClienteO.SelectedValue)
            End If
        End If


        If cn_Recepcion.fn_CambiarCliente_Cambiar(cmb_Cia.SelectedValue, Tipo, TipoP, Entidad_Origen, Entidad_Destino) Then
            FuncionesGlobales.fn_GuardaBitacora(18, Cliente_Original, cmb_Cia.SelectedValue)
            MsgBox("El cliente se ha cambiado exitosamente", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Remision.Clear()
            cmb_Cia.DataSource = Nothing
            LimpiarDetalle()
        Else
            MsgBox("Ha ocurrido un error al intentar cambiar el cliente", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        Call Validar()
    End Sub

End Class