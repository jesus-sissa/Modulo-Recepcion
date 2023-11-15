Public Class frm_Kardex
    Private dt_CasetsEntradas As DataTable
    Public dr As DialogResult
    Public CasetCapturado As Integer = 0
    Public EntregoCaset As Boolean = False
    Public CasetEntrada As Integer = 0
    Public Ruta As Integer = 0
    Public esEntradaRuta As Boolean = False

    Private Sub frm_Kardex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SegundosDesconexion = 0

        lsv_Cartuchos.Columns.Add("Codigo Barra", 100)
        lsv_Cartuchos.Columns.Add("Descripcion", 200)
        lsv_Cartuchos.Columns.Add("Caset_SISSA", 100)
        lsv_Cartuchos.Enabled = False


        cmb_Movimiento.AgregarItem("1", "SALIDA A RUTA")
        cmb_Movimiento.AgregarItem("4", "ENTRADA A RUTA") '



        'cmb_Frecuencia.AgregarItem("1", "DOMINGO")
        'cmb_Frecuencia.AgregarItem("2", "LUNES")
        'cmb_Frecuencia.AgregarItem("3", "MARTES")
        'cmb_Frecuencia.AgregarItem("4", "MIERCOLES")
        'cmb_Frecuencia.AgregarItem("5", "JUEVES")
        'cmb_Frecuencia.AgregarItem("6", "VIERNES")
        'cmb_Frecuencia.AgregarItem("7", "SABADO")

        cmb_Empleado.Actualizar()

        'Aqui se llena el combo de Turnos
        'cmb_Turno.AgregarItem("1", "MATUTINO")
        'cmb_Turno.AgregarItem("2", "VESPERTINO")
        'cmb_Turno.AgregarItem("3", "NOCTURNO")
        BanderA = False
        cmb_Rutas.AgregaParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString), 2)
        cmb_Rutas.Actualizar()
        cmb_Rutas.SelectedValue = Ruta
        If esEntradaRuta Then
            cmb_Movimiento.SelectedValue = 4
            cmb_Movimiento.Enabled = esEntradaRuta
        End If
        BanderA = True
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0
        If cn_Recepcion.fn_Kardex_Caset_Read(tbx_CodigoBarra.Text) Then
            MsgBox("El código de Barra YA EXISTE!!!.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CodigoBarra.Focus()
            Exit Sub
        End If

        MsgBox("Se guardo con exito.", MsgBoxStyle.Information, frm_MENU.Text)

    End Sub

    Sub LlenarLista()
        SegundosDesconexion = 0
        SegundosDesconexion = 0
        lsv_Cartuchos.Items.Clear()

        lbl_Registros.Text = "Registros: 0"
        Btn_Guardar.Enabled = False

        lbl_Registros.Text = "Registros: '" & lsv_Cartuchos.Items.Count & "'"

    End Sub

    'Sub Buscar()
    '    SegundosDesconexion = 0

    '    Dim Fila_Inicio As Integer = 0
    '    If lsv_Cartuchos.SelectedItems.Count > 0 Then
    '        Fila_Inicio = lsv_Cartuchos.SelectedItems(0).Index + 1
    '    End If
    '    If FuncionesGlobales.fn_Buscar_enListView(lsv_Cartuchos, tbx_Buscar.Text, 0, Fila_Inicio) Then
    '        Btn_Guardar.Enabled = True
    '    Else
    '        Btn_Guardar.Enabled = True
    '    End If
    'End Sub

    'Private Sub Btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
    '    SegundosDesconexion = 0
    '    If lsv_Cartuchos.Items.Count = 0 Then Exit Sub
    '    cn_Recepcion.fn_Kardex_Catalogo_Baja(lsv_Cartuchos.SelectedItems(0).Tag)

    '    Call LlenarLista()
    'End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        If CasetCapturado <> CasetEntrada Then
            dr = Windows.Forms.DialogResult.No
        End If
        Me.Close()
    End Sub


    Private Sub cmb_Status_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        LlenarLista()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        CargarListaCartuchos()
        tbx_CodigoBarra.Focus()
    End Sub

    Public Sub CargarListaCartuchos()
        SegundosDesconexion = 0
        lsv_Cartuchos.Items.Clear()
        If Not validar() Then
            MsgBox("Faltan datos por registrar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not cn_Recepcion.fn_Kardex_Caset_Get(lsv_Cartuchos, dtp_Fecha.Value, cmb_Rutas.SelectedValue, cmb_Movimiento.SelectedValue) Then
            MsgBox("ERROR al cargar la Lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Movimiento.SelectedValue = 4 Then
            If Not CasetsEntradasConsultar() Then Exit Sub
        End If

        lbl_Registros.Text = "Registros: '" & lsv_Cartuchos.Items.Count & "'"
        tbx_CodigoBarra.Enabled = lsv_Cartuchos.Items.Count
    End Sub

    Private Sub dtp_Fecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            cmb_Rutas.ActualizaValorParametro("@Fecha", dtp_Fecha.Value)
            cmb_Rutas.Actualizar()
        End If
    End Sub

    Public Function BuscarCodigoBarra(ByVal IdCliente As Integer, ByVal CodigoBarra As String) As Boolean
        For Each elemento As ListViewItem In lsv_Cartuchos.Items
            If CInt(elemento.SubItems(3).Text) = IdCliente And elemento.Text = CodigoBarra Then
                elemento.Checked = True
                elemento.BackColor = Color.Green
                elemento.ForeColor = Color.GreenYellow
                Exit For
            End If
        Next
    End Function

    Private Sub tbx_CodigoBarra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_CodigoBarra.TextChanged
        If tbx_CodigoBarra.Text = "" Then Exit Sub

        If tbx_CodigoBarra.Text.Length > 7 Then

            If Not tbx_CodigoBarra.Text.Contains("'") Then
                MsgBox("Codigo de Barra incorrecto.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_CodigoBarra.SelectAll()
                Exit Sub
            End If

            If cmb_Movimiento.SelectedValue = 4 Then
                If Not CasetsEntradasValidar(tbx_CodigoBarra.Text) Then

                    MsgBox("Imposible recibir caset ya que  no tiene entrada.", MsgBoxStyle.Information, frm_MENU.Text)
                    tbx_CodigoBarra.SelectAll()
                    Exit Sub
                End If
            End If

            BuscarCodigoBarra(tbx_CodigoBarra.Text.Trim.Split("'")(1), tbx_CodigoBarra.Text.Trim)
            tbx_CodigoBarra.Text = ""
            CasetCapturado = lsv_Cartuchos.Items.Count
        End If
    End Sub

    Private Sub lsv_Cartuchos_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Cartuchos.ItemChecked
        SegundosDesconexion = 0
        Btn_Guardar.Enabled = lsv_Cartuchos.CheckedItems.Count > 0
    End Sub

    Private Sub Btn_Guardar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        SegundosDesconexion = 0
        If esEntradaRuta Then
            If lsv_Cartuchos.Items.Count <> CasetEntrada Then
                MsgBox("Faltan CASETS por capturar.", MsgBoxStyle.Information, frm_MENU.Text)
                Exit Sub
            End If
        End If
        
        If Not validar() Then
            MsgBox("Faltan datos por registrar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If

        If Not validar_E_S() Then
            Dim E_S As Integer = cmb_Movimiento.SelectedValue
            If E_S = 1 Then
                MsgBox("Imposible Efectuar movimiento. Cartuchos No estan en Kardex!!!", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                MsgBox("Imposible Efectuar movimiento. Cartuchos Ya estan en Kardex!!!", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            Exit Sub
        End If

        If Not cn_Recepcion.fn_Kardex_Movimientos_Insert(lsv_Cartuchos, cmb_Movimiento.SelectedValue, cmb_Empleado.SelectedValue) Then
            MsgBox("Ocurrió un error al guardar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        MsgBox("Se guardó con exito.", MsgBoxStyle.Information, frm_MENU.Text)
        dr = Windows.Forms.DialogResult.OK
        CargarListaCartuchos()
        If esEntradaRuta Then CasetCapturado = CasetEntradaObtener()
    End Sub

    Function validar() As Boolean
        If cmb_Empleado.SelectedValue = "0" Then Return False

        If cmb_Movimiento.SelectedValue = "0" Then Return False
        If cmb_Rutas.SelectedValue = "0" Then Return False
        Return True
    End Function

    Function validar_E_S() As Boolean
        Dim E_S As Integer = cmb_Movimiento.SelectedValue
        Dim ColumnE_S As Integer = 0

        If E_S = 1 Then
            ColumnE_S = 5
        Else
            ColumnE_S = 4
        End If

        For Each elemento As ListViewItem In lsv_Cartuchos.CheckedItems
            If E_S = 1 Then
                If CInt(elemento.SubItems(ColumnE_S).Text) = 1 Then
                    Return False
                End If

            ElseIf E_S = 4 Then
                If CInt(elemento.SubItems(ColumnE_S).Text) = 1 And elemento.SubItems(6).Text = 1 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub cmb_Movimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Movimiento.SelectedIndexChanged
        tbx_CodigoBarra.Focus()
        If cmb_Movimiento.SelectedValue <> 4 Then Exit Sub
        CasetsEntradasConsultar()
    End Sub


    Public Function CasetsEntradasValidar(ByVal Id_CodigoBarra As String) As Boolean
        SegundosDesconexion = 0
        Dim IdCliente As Integer = Id_CodigoBarra.Split("'")(1)

        If dt_CasetsEntradas.Rows.Count = 0 Then Return False

        For Each Caset As DataRow In dt_CasetsEntradas.Rows
            If CInt(Caset("Id_Cliente")) = IdCliente And Caset("Id_Codigo_Barra").ToString = tbx_CodigoBarra.Text Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function CasetsEntradasConsultar() As Boolean
        SegundosDesconexion = 0
        dt_CasetsEntradas = cn_Recepcion.fn_Kardex_Caset_GetEntradas(dtp_Fecha.Value, cmb_Rutas.SelectedValue, cmb_Movimiento.SelectedValue)

        If dt_CasetsEntradas Is Nothing Then
            MsgBox("Ocurrió un error al consultar CASSETS Entradas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Return True
    End Function

    Private Sub cmb_Rutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedIndexChanged
        SegundosDesconexion = 0
        If esEntradaRuta Then
            If cmb_Rutas.SelectedValue <> Ruta Then
                MsgBox("No se puede cambiar de Ruta.", MsgBoxStyle.Information, frm_MENU.Text)
                cmb_Rutas.SelectedValue = Ruta
            End If
        End If
    End Sub

    Function CasetEntradaObtener() As Integer
        SegundosDesconexion = 0
        Dim CasetEntrada As Integer = (From i As ListViewItem In lsv_Cartuchos.Items _
                             Where i.SubItems(4).Text = "1").Count()
        Return CasetEntrada
    End Function


End Class