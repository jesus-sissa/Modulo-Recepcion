Imports Modulo_Recepcion.cn_Recepcion
Imports System.IO

Public Class frm_RecepcionRutasInternas
    Private frm_Dialog As New frm_Dialogo
    Private indice As Integer = 0

    Private Sub frm_RecepcionRutasInternas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CasetCapturado = 1
        'desactivarBotonesEntradas()
        BanderA = False
        cmb_Rutas.AgregaParametro("@Fecha", FuncionesGlobales.fn_Fecha102(dtp_Fecha.Value.ToShortDateString), 2)
        cmb_Rutas.Actualizar()

        cmb_Boveda.AgregaParametro("@Tipo_Boveda", BovedaTipo, 0)
        cmb_Boveda.AgregaParametro("@Status", "A", 0)
        cmb_Boveda.Actualizar()

        BanderA = True

        Lsv_Puntos.Columns.Add("Cliente Origen")
        Lsv_Puntos.Columns.Add("Cliente Destino")
        Lsv_Puntos.Columns.Add("Status Punto")

        lsv_Remisiones.Columns.Add("Primer Origen")
        lsv_Remisiones.Columns.Add("Remision")
        lsv_Remisiones.Columns.Add("Status")
        lsv_Remisiones.Columns.Add("Envases")
        lsv_Remisiones.Columns.Add("EnvasesSN")
        lsv_Remisiones.Columns.Add("Depto Valida")
        lsv_Remisiones.Columns.Add("Nombre")
        lsv_Remisiones.Columns.Add("Fecha")
        lsv_Remisiones.Columns.Add("Hora")

        '--PuntosyRemisiones(Nueva)
        lsv_PuntosyRemisiones.Columns.Add("Remision")
        lsv_PuntosyRemisiones.Columns.Add("PrimerOrigen")
        lsv_PuntosyRemisiones.Columns.Add("ClienteOrigen")
        lsv_PuntosyRemisiones.Columns.Add("ClienteDestino")
        lsv_PuntosyRemisiones.Columns.Add("StatusPunto")
        lsv_PuntosyRemisiones.Columns.Add("StatusRem")
        lsv_PuntosyRemisiones.Columns.Add("Envases")
        lsv_PuntosyRemisiones.Columns.Add("EnvasesSN")
        lsv_PuntosyRemisiones.Columns.Add("DeptoValida")
        lsv_PuntosyRemisiones.Columns.Add("UsuarioValida")
        lsv_PuntosyRemisiones.Columns.Add("Fecha")
        lsv_PuntosyRemisiones.Columns.Add("Hora")

        Lsv_CVisita.Columns.Add("Folio")
        Lsv_CVisita.Columns.Add("Hora")
        Lsv_CVisita.Columns.Add("Cliente Origen")
        Lsv_CVisita.Columns.Add("Cliente Destino")
        Lsv_CVisita.Columns.Add("StatusCV")
        Lsv_CVisita.Columns.Add("Recoleccion")

        Lsv_Pendientes.Columns.Add("Cliente Origen")
        Lsv_Pendientes.Columns.Add("Cliente Destino")
        Lsv_Pendientes.Columns.Add("Status Punto")

        Lsv_Todos.Columns.Add("Cliente Origen")
        Lsv_Todos.Columns.Add("Cliente Destino")
        Lsv_Todos.Columns.Add("Status Punto")

        Lsv_Resumen.Columns.Add("Status")
        Lsv_Resumen.Columns.Add("Remisiones")
        Lsv_Resumen.Columns.Add("Envases")
        Lsv_Resumen.Columns.Add("Puntos")

        Lsv_Materiales.Columns.Add("Remision")
        Lsv_Materiales.Columns.Add("CantidadEnvases")
        Lsv_Materiales.Columns.Add("Status")

        Lsv_Atms.Columns.Add("Remision")
        Lsv_Atms.Columns.Add("Caja")
        Lsv_Atms.Columns.Add("Cajero")
        Lsv_Atms.Columns.Add("Envases")
        Lsv_Atms.Columns.Add("EnvasesSN")
        Lsv_Atms.Columns.Add("Importe")
        Lsv_Atms.Columns.Add("Status")

        lsv_AtmsD.Columns.Add("Moneda")
        lsv_AtmsD.Columns.Add("Efectivo")
        lsv_AtmsD.Columns.Add("Documentos")
        lsv_AtmsD.Columns.Add("TipoCambio")

        lsv_TodosD.Columns.Add("Primer Origen")
        lsv_TodosD.Columns.Add("Remision")
        lsv_TodosD.Columns.Add("Status")
        lsv_TodosD.Columns.Add("Envases")
        lsv_TodosD.Columns.Add("EnvasesSN")
        lsv_TodosD.Columns.Add("Depto Valida")
        lsv_TodosD.Columns.Add("Usuario Valida")
        lsv_TodosD.Columns.Add("Fecha")
        lsv_TodosD.Columns.Add("Hora")

        lsv_AtmsFallas.Columns.Add("Caja")
        lsv_AtmsFallas.Columns.Add("Cajero")
        lsv_AtmsFallas.Columns.Add("RemRetiro").TextAlign = HorizontalAlignment.Right
        lsv_AtmsFallas.Columns.Add("Status")

        lsv_AtmsFallasD.Columns.Add("Moneda")
        lsv_AtmsFallasD.Columns.Add("Efectivo").TextAlign = HorizontalAlignment.Right
        lsv_AtmsFallasD.Columns.Add("Documentos")
        lsv_AtmsFallasD.Columns.Add("Tipo Cambio").TextAlign = HorizontalAlignment.Right

        tbx_Remision.Focus()

        Lbl_RegistrosR.Text = "Registros: " & Lsv_Puntos.Items.Count
        Lbl_RegistrosP.Text = "Registros: " & Lsv_Pendientes.Items.Count
        Lbl_RegistrosCV.Text = "Registros: " & Lsv_CVisita.Items.Count
        Lbl_RegistrosT.Text = "Registros: " & Lsv_Todos.Items.Count
        Lbl_RegistrosRes.Text = "Registros: " & Lsv_Resumen.Items.Count
        Lbl_RegistrosM.Text = "Registros: " & Lsv_Materiales.Items.Count
        Lbl_RegistrosAtms.Text = "Registros: " & Lsv_Atms.Items.Count
        Lbl_RegistrosAtmsF.Text = "Registros: " & lsv_AtmsFallas.Items.Count

        btn_VerCV.Enabled = False
        tbx_ValidarRemision.Focus()
    End Sub

    'Public Sub desactivarBotonesEntradas()
    '    tbx_Cve_Boveda.Enabled = CasetCapturado
    '    cmb_Boveda.Enabled = CasetCapturado
    '    btn_Actualizar.Enabled = CasetCapturado
    '    Btn_Validar.Enabled = CasetCapturado
    '    Tab_General.Enabled = CasetCapturado

    'End Sub



    Private Sub dtp_Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fecha.ValueChanged
        SegundosDesconexion = 0

        If BanderA = True Then
            cmb_Rutas.ActualizaValorParametro("@Fecha", dtp_Fecha.Value)
            cmb_Rutas.Actualizar()
        End If

    End Sub

    Private Sub cmb_Rutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Rutas.SelectedIndexChanged
        SegundosDesconexion = 0

        Btn_Validar.Enabled = False
        btn_GrabarServicio.Enabled = False
        btn_AgregaRemision.Enabled = False
        btn_cuadreruta.Enabled = False
        SegundosDesconexion = 0


        'tbx_ValidarRemision.Enabled = False
        'btn_ValidarRemision.Enabled = False
        'btn_AgregarNuevaRemision.Enabled = False
        'btn_GrabarServicios.Enabled = False
        'lsv_PuntosyRemisiones.Enabled = False

        Call LlenarListas()

        'PuntoCasetRecibidoValidar()
        btn_AgregarNuevaRemision.Enabled = (cmb_Rutas.SelectedValue <> 0)

    End Sub

    Private Sub btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualizar.Click
        SegundosDesconexion = 0
        Call LlenarListas()
    End Sub

    Sub LlenarListas()
        If Not BanderA Then Exit Sub
        If cmb_Rutas.SelectedValue = 0 Then
            MsgBox("Primero debe seleccionar una Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Lsv_Puntos.Items.Clear()
        lsv_PuntosyRemisiones.Items.Clear() 'New
        lsv_Remisiones.Items.Clear()
        Lsv_Atms.Items.Clear()
        lsv_AtmsFallas.Items.Clear()
        lsv_AtmsFallasD.Items.Clear()
        Lsv_CVisita.Items.Clear()
        Lsv_Materiales.Items.Clear()
        Lsv_Pendientes.Items.Clear()
        Lsv_Resumen.Items.Clear()
        Lsv_Todos.Items.Clear()
        tbx_ValidarRemision.Clear()

        Lbl_RegistrosR.Text = "Registros: 0"
        Lbl_RegistrosP.Text = "Registros: 0"
        Lbl_RegistrosCV.Text = "Registros: 0"
        Lbl_RegistrosT.Text = "Registros: 0"
        Lbl_RegistrosRes.Text = "Registros: 0"
        Lbl_RegistrosM.Text = "Registros: 0"
        Lbl_RegistrosAtms.Text = "Registros: 0"
        Lbl_RegistrosAtmsF.Text = "Registros: 0"

        Tab_RemisionesM.Text = "RemisionesM" 'New
        Tab_Remisiones.Text = "Remisiones"
        Tab_CVisita.Text = "Comprobante Visita"
        Tab_Pendientes.Text = "Pendientes"
        Tab_Todos.Text = "Todos"
        Tab_Resumen.Text = "Resumen"
        Tab_Materiales.Text = "Materiales"
        Tab_Atms.Text = "ATM's"
        Tab_AtmsFallas.Text = "ATM's Fallas"
        btn_GrabarServicio.Enabled = False
        btn_GrabarServicios.Enabled = False 'new
        Btn_RBovedaAtmsF.Enabled = False
        Btn_RBovedaAtms.Enabled = False

        Btn_RBovedaAtmsF.Enabled = False
        Btn_RBovedaAtms.Enabled = False
        'Botones de Materiales
        Btn_RegresarAb.Enabled = False
        Btn_ValidarM.Enabled = False

        lsv_Remisiones.Items.Clear()
        btn_VerCV.Enabled = False
        Me.Cursor = Cursors.Default
        If cmb_Rutas.SelectedValue = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        'Puntos que ya traen remisiones
        cn_Recepcion.fn_RecRutasPropiasLlenalistaPuntos(Lsv_Puntos, cmb_Rutas.SelectedValue)

        '11/08/2014 nueva pestaña de Puntos y remisiones
        cn_Recepcion.fn_RecRutasPropias_LlenarListaPuntosyRemisiones(lsv_PuntosyRemisiones, cmb_Rutas.SelectedValue)

        'puntos pendientes
        cn_Recepcion.fn_RecRutasPropiasLlenalistaPuntosPendientes(Lsv_Pendientes, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaCompVisitas(Lsv_CVisita, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaPuntosTodos(Lsv_Todos, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaPuntosResumen(Lsv_Resumen, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaMateriales(Lsv_Materiales, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaAtms(Lsv_Atms, cmb_Rutas.SelectedValue)
        cn_Recepcion.fn_RecRutasPropiasLlenalistaAtmsFallas(lsv_AtmsFallas, cmb_Rutas.SelectedValue)
        ''Lista de envases 19/08/20
        'ColorDot() 'Colorea de azul todas las dotaciones para poder identificarlas
        fn_RecRutasPropiastvEnvases(lsv_tv, cmb_Rutas.SelectedValue)
        Color_Item(lsv_tv)
        ''
        'fn_Mat_PuntosEnvases(Lsv_MatEnvases, cmb_Rutas.SelectedValue)
        'Color_Item(Lsv_MatEnvases)
        ''
        fn_RecRutasPropiasLlenalistaEnvasesAtms(lsv_envases, cmb_Rutas.SelectedValue)
        Color_Item(lsv_envases)
        fn_RecRutasPropiasLlenalistaEnvasesAtmsFallas(lsv_fallas, cmb_Rutas.SelectedValue)
        Color_Item(lsv_fallas)
        ''

        Tab_Remisiones.Text = "Remisiones" + " (" + Str(Lsv_Puntos.Items.Count).Trim + ")"
        Tab_RemisionesM.Text = "RemisionesM" + " (" + Str(lsv_PuntosyRemisiones.Items.Count).Trim + ")"

        Tab_CVisita.Text = "Comprobante Visita" + " (" + Str(Lsv_CVisita.Items.Count).Trim + ")"
        Tab_Pendientes.Text = "Pendientes" + " (" + Str(Lsv_Pendientes.Items.Count).Trim + ")"
        Tab_Todos.Text = "Todos" + " (" + Str(Lsv_Todos.Items.Count).Trim + ")"
        Dim res = From it As ListViewItem In Lsv_Resumen.Items Select it
        Tab_Resumen.Text = "Resumen" + " (" + res.Sum(Function(item As ListViewItem) CInt(item.SubItems(3).Text)).ToString + ")"
        Tab_Materiales.Text = "Materiales" + " (" + Str(Lsv_Materiales.Items.Count).Trim + ")"
        Tab_Atms.Text = "ATM's" + " (" + Str(Lsv_Atms.Items.Count).Trim + ")"
        Tab_AtmsFallas.Text = "ATM's Fallas" + " (" + Str(lsv_AtmsFallas.Items.Count).Trim + ")"
        Call Colorear()

        lbl_PuntosyRemisiones.Text = "Registros: " & lsv_PuntosyRemisiones.Items.Count
        Dim Contador As Integer = 0
        For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If Elemento.SubItems(5).Text.Trim = "VALIDADO" And Microsoft.VisualBasic.Left(Elemento.SubItems(8).Text.Trim.ToUpper, 1) = "B" Then
                Contador += 1
            End If
        Next
        lbl_PuntosyRemisionesV.Text = "Validados: " & Contador.ToString

        Lbl_RegistrosR.Text = "Registros: " & Lsv_Puntos.Items.Count
        Lbl_RegistrosP.Text = "Registros: " & Lsv_Pendientes.Items.Count
        Lbl_RegistrosCV.Text = "Registros: " & Lsv_CVisita.Items.Count
        Lbl_RegistrosT.Text = "Registros: " & Lsv_Todos.Items.Count
        Lbl_RegistrosRes.Text = "Registros: " & Lsv_Resumen.Items.Count
        Lbl_RegistrosM.Text = "Registros: " & Lsv_Materiales.Items.Count
        Lbl_RegistrosAtms.Text = "Registros: " & Lsv_Atms.Items.Count
        Lbl_RegistrosAtmsF.Text = "Registros: " & lsv_AtmsFallas.Items.Count
        Lbl_envases.Text = "Registros: " & lsv_tv.Items.Count
        Lbl_MatEnvasesCount.Text = "Registros: " & Lsv_MatEnvases.Items.Count
        btn_cuadreruta.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Colorear()
        For Each item As ListViewItem In Lsv_Atms.Items
            If item.SubItems(9).Text = "RB" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
        For Each item As ListViewItem In lsv_AtmsFallas.Items
            If item.SubItems(4).Text = "RB" Then
                item.ForeColor = Color.Red
            Else
                item.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub Lsv_Puntos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Puntos.SelectedIndexChanged

        'Btn_Validar.Enabled = True
        'btn_GrabarServicio.Enabled = True
        'btn_AgregaRemision.Enabled = True
        'btn_cuadreruta.Enabled = True
        'SegundosDesconexion = 0

        'tbx_ValidarRemision.Enabled = True
        'btn_ValidarRemision.Enabled = True
        'btn_AgregarNuevaRemision.Enabled = True
        'btn_GrabarServicios.Enabled = True
        'lsv_PuntosyRemisiones.Enabled = True

        'If Lsv_Puntos.SelectedItems.Count > 0 Then
        '    Lsv_Puntos.SelectedItems(0).SubItems(1).Tag = 0 'significa que no es ruta de inicio, si lo es mas adelante se asigna un 1
        '    'se puede dar el caso en una programación haya un solo punto que utiliza caset y ese sea cancelado, obligar al usuario que lo reciba en recepcion

        '    If Not PuntoTieneCaset(Lsv_Puntos.SelectedItems(0).SubItems(7).Text, Lsv_Puntos.SelectedItems(0).SubItems(10).Text, Lsv_Puntos.SelectedItems(0).SubItems(9).Text, Lsv_Puntos.SelectedItems(0).SubItems(11).Text, Lsv_Puntos.SelectedItems(0).SubItems(8).Text, Lsv_Puntos.SelectedItems(0).SubItems(3).Text, Lsv_Puntos) Then
        '        DesactivarControles()
        '        Exit Sub
        '    End If

        '    Call LlenaRemisiones()
        '    btn_AgregaRemision.Enabled = Lsv_Puntos.SelectedItems(0).SubItems(2).Text.ToUpper = "EN RUTA"
        '    tbx_Remision.Focus()
        'Else
        '    lsv_Remisiones.Items.Clear()
        '    btn_AgregaRemision.Enabled = False
        'End If

        ' MessageBox.Show(Lsv_Puntos.Items(0).Tag.ToString() + "  " + Lsv_Puntos.Items(0).SubItems(0).Text)

        'Remision = Nothing '08/08/2021
        Btn_Validar.Enabled = True
        btn_GrabarServicio.Enabled = True
        btn_AgregaRemision.Enabled = True
        btn_cuadreruta.Enabled = True
        SegundosDesconexion = 0

        tbx_ValidarRemision.Enabled = True
        btn_ValidarRemision.Enabled = True
        btn_AgregarNuevaRemision.Enabled = True
        btn_GrabarServicios.Enabled = True
        lsv_PuntosyRemisiones.Enabled = True
        Dim Dt As New DataTable
        If Lsv_Puntos.SelectedItems.Count > 0 Then
            Lsv_Puntos.SelectedItems(0).SubItems(1).Tag = 0 'significa que no es ruta de inicio, si lo es mas adelante se asigna un 1
            'se puede dar el caso en una programación haya un solo punto que utiliza caset y ese sea cancelado, obligar al usuario que lo reciba en recepcion
            'Remision digital 07/07/21
            'Dt = cn_Recepcion.fn_TvNumeroRemision(Lsv_Puntos.SelectedItems(0).Tag) 'Verica que el punto tenga un numero de remision cargado desde tv si encuentra omite la validacion de caset
            'If Dt.Rows.Count > 0 Then
            ' Remision = Dt.Rows(0)("Remision").ToString()
            'Else ' 
            If Not PuntoTieneCaset(Lsv_Puntos.SelectedItems(0).SubItems(7).Text, Lsv_Puntos.SelectedItems(0).SubItems(10).Text, Lsv_Puntos.SelectedItems(0).SubItems(9).Text, Lsv_Puntos.SelectedItems(0).SubItems(11).Text, Lsv_Puntos.SelectedItems(0).SubItems(8).Text, Lsv_Puntos.SelectedItems(0).SubItems(3).Text, Lsv_Puntos) Then
                DesactivarControles()
                Exit Sub
            End If
            'End If

            Call LlenaRemisiones()
            btn_AgregaRemision.Enabled = Lsv_Puntos.SelectedItems(0).SubItems(2).Text.ToUpper = "EN RUTA"
            tbx_Remision.Focus()
        Else
            lsv_Remisiones.Items.Clear()
            btn_AgregaRemision.Enabled = False
        End If

    End Sub

    Private Sub Btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Validar.Click, lsv_Remisiones.DoubleClick
        SegundosDesconexion = 0
        Call Validar()
        Call LlenarListas()
    End Sub

    Sub Validar()

        Dim Elemento As ListViewItem
        If tbx_Remision.Text.Trim = "" Then
            MsgBox("Capture un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Lsv_Puntos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un punto de la Lista", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If



        For Each Elemento In lsv_Remisiones.Items
            If Elemento.SubItems(1).Text = tbx_Remision.Text.Trim Then
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Call MostrarDialogo()
                Call LlenaRemisiones()
                tbx_Remision.Clear()
                Exit Sub
            End If
        Next


        MsgBox("No se encontró la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Public Function PuntoTieneCaset(ByVal UtilizaCaset As String, ByVal EntregoCas As String, ByVal RetiroCas As String, ByVal Propio As String, ByVal Especial As String, ByVal Id_Cliente As String, ByVal lsv As cp_Listview) As Boolean
        If PuntoUtilizaCaset(UtilizaCaset) Then


            If EsPuntoEspecial(Especial) Then
                If Not RetiroCaseT(RetiroCas) Then
                    MsgBox("Imposible continuar, ya que no se retiro el Caset en el punto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
            Else

                If Not EntregoCaset(EntregoCas) Then
                    MsgBox("Imposible continuar, ya que no se entregó el Caset en el punto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If

                If Not RetiroCaseT(RetiroCas) Then
                    MsgBox("Imposible continuar, ya que no se retiró el Caset en el punto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If


            End If

            If Not RecibioCaset(Propio, Especial, Id_Cliente, lsv) Then
                DesactivarControles()
                Exit Function
            End If

        End If
        Return True
    End Function

    Private Sub MostrarDialogo()
        frm_Dialog.btn_Guardar.Enabled = True
        frm_Dialog.Validar = True

        If Lsv_Puntos.SelectedItems(0).SubItems(5).Text = "EN" Then
            frm_Dialog.RR = True
        Else
            frm_Dialog.RR = False
        End If

        Select Case lsv_Remisiones.SelectedItems(0).SubItems(2).Text
            Case "MARCADO PARA REGRESAR", "RECIBIDO EN BOVEDA", "REGRESADO"
                frm_Dialog.Bloqueado = True
            Case Else
                frm_Dialog.Bloqueado = False
        End Select

        ''frm_Dialog.tbx_Envases.Text = CInt(lsv_Remisiones.SelectedItems(0).SubItems(3).Text) + CInt(lsv_Remisiones.SelectedItems(0).SubItems(4).Text)
        'frm_Dialog.tbx_EnvasesSN.Text = CInt(lsv_Remisiones.SelectedItems(0).SubItems(4).Text)
        'frm_Dialog.Id_Remision = lsv_Remisiones.SelectedItems(0).SubItems(9).Text
        'frm_Dialog.tbx_Remision.Tag = lsv_Remisiones.SelectedItems(0).SubItems(9).Text
        'frm_Dialog.tbx_Remision.Text = tbx_Remision.Text.Trim
        'frm_Dialog.tbx_RemisionOriginal.Tag = lsv_Remisiones.SelectedItems(0).SubItems(9).Text 'Id_Remision
        'frm_Dialog.Id_CiaProp = lsv_Remisiones.SelectedItems(0).SubItems(11).Text 'Id_CiaProp
        'frm_Dialog.Hora_Remision = lsv_Remisiones.SelectedItems(0).SubItems(12).Text 'Hora_Remision
        'frm_Dialog.tbx_RemisionOriginal.Text = tbx_Remision.Text.Trim
        'frm_Dialog.Id_Punto = Lsv_Puntos.SelectedItems(0).Tag

        'frm_Dialog.tbx_Envases.Text = CInt(lsv_Remisiones.SelectedItems(0).SubItems(3).Text) + CInt(lsv_Remisiones.SelectedItems(0).SubItems(4).Text)
        frm_Dialog.tbx_EnvasesSN.Text = CInt(lsv_Remisiones.SelectedItems(0).SubItems(4).Text)
        frm_Dialog.Id_Remision = lsv_Remisiones.SelectedItems(0).SubItems(9).Text
        frm_Dialog.tbx_Remision.Tag = lsv_Remisiones.SelectedItems(0).SubItems(9).Text
        frm_Dialog.tbx_Remision.Text = lsv_Remisiones.SelectedItems(0).SubItems(1).Text 'tbx_Remision.Text.Trim
        frm_Dialog.tbx_RemisionOriginal.Tag = lsv_Remisiones.SelectedItems(0).SubItems(9).Text 'Id_Remision
        frm_Dialog.Id_CiaProp = lsv_Remisiones.SelectedItems(0).SubItems(11).Text 'Id_CiaProp
        frm_Dialog.Hora_Remision = lsv_Remisiones.SelectedItems(0).SubItems(12).Text 'Hora_Remision
        frm_Dialog.tbx_RemisionOriginal.Text = lsv_Remisiones.SelectedItems(0).SubItems(1).Text 'tbx_Remision.Text.Trim
        frm_Dialog.Id_Punto = Lsv_Puntos.SelectedItems(0).Tag
        frm_Dialog.Id_CO = Lsv_Puntos.SelectedItems(0).SubItems(3).Text
        frm_Dialog.lbl_OrigenNombre.Text = Lsv_Puntos.SelectedItems(0).Text
        If Lsv_Puntos.SelectedItems(0).Text.Trim = "" Then
            frm_Dialog.lbl_OrigenNombre.Text = Lsv_Puntos.SelectedItems(0).SubItems(1).Text
        End If
        frm_Dialog.lbl_DestinoNombre.Text = Lsv_Puntos.SelectedItems(0).SubItems(1).Text
        If (Tab_General.SelectedTab.Name() = "Tab_Remisiones") Then
            If (lsv_Remisiones.SelectedItems(0).SubItems(2).Text = "VALIDADO") Then
                frm_Dialog.T = True
            Else
                frm_Dialog.T = False
            End If
            frm_Dialog.Cant_env = CInt(lsv_Remisiones.SelectedItems(0).SubItems(3).Text)
            frm_Dialog.Numero_env = tbx_Remision.Text
        End If
        frm_Dialog.tipoRemision = lsv_Remisiones.SelectedItems(0).SubItems(13).Text
        frm_Dialog.Nuevo = False
        frm_Dialog.ShowDialog()

    End Sub

    Sub LlenaRemisiones()
        If Lsv_Puntos.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_ReRutasPropiasLlenaListaRemisiones(lsv_Remisiones, Lsv_Puntos.SelectedItems(0).Tag)
            lsv_Remisiones.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_Remisiones.Columns(4).TextAlign = HorizontalAlignment.Right
            btn_AgregaRemision.Enabled = Lsv_Puntos.SelectedItems(0).SubItems(2).Text.ToUpper = "EN RUTA"
            If lsv_Remisiones.Items.Count > 0 Then lsv_Remisiones.Items(0).Selected = True
            'MessageBox.Show(lsv_Remisiones.SelectedItems(0).SubItems(13).Text)
        Else
            btn_AgregaRemision.Enabled = False
        End If
    End Sub
    Sub LlenaRemisionesMatDetalle()
        cn_Recepcion.fn_ReRutasPropiasLlenaListaRemisionesMateriales(Lsv_MatEnvases, Lsv_Materiales.SelectedItems(0).Tag)
        Btn_RegresarAb.Enabled = Lsv_Materiales.SelectedItems(0).SubItems(2).Text.ToUpper = "EN RUTA"
    End Sub

    Private Sub btn_GrabarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabarServicio.Click
        SegundosDesconexion = 0

        Dim Elemento As New ListViewItem
        Dim dr As DataRow

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccione una Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Boveda.Focus()
            Exit Sub
        End If

        'Las Remisiones deben de estar validadas y el Punto Recibido.
        For Each Elemento In Lsv_Puntos.Items
            dr = cn_Recepcion.fn_RecRutasValidaRD(Elemento.Tag)
            If dr("Capturadas").ToString = 0 Then
                MsgBox("Se esperaban " + dr("Remisiones").ToString + " Remisiones. Debe capturar al menos una.", MsgBoxStyle.Critical, frm_MENU.Text)
                'Elemento.Selected = True
                Lsv_Puntos.Focus()
                Lsv_Puntos.Items(Elemento.Index).Selected = True
                Elemento.EnsureVisible()
                Exit Sub
            End If
        Next

        Dim ct As Integer = cn_Recepcion.fn_RecRutasPropias_Guardar(cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, Lsv_Puntos)

        If ct > 0 Then MsgBox(ct & " Registros guardados.", MsgBoxStyle.Information, frm_MENU.Text)

        'Verificar los movimientos para cuando no hubo movil y las remisiones se capturaron al recibir la ruta
        'Se inserta un Movimiento para cada Punto con sus respectivas Remisiones
        'El punto debe estar en RB porque en fn_RecRutasPropias_Guardar se cambiaron de RU a RB
        'Los que no se cambiaron es porque no se han recibido completos.

        '**Aprovechar esta funcion "fn_RecRutasPropias_GuardarMov" para recalcular los movimientos para que a Facturación le aparezca todo correcto
        '**En caso de que los importes hayan sido corregidos
        Me.Cursor = Cursors.WaitCursor
        If cn_Recepcion.fn_RecRutasPropias_GuardarMov(cmb_Rutas.SelectedValue, dtp_Fecha.Value.Date) Then
        End If

        Me.Cursor = Cursors.Default
        Call LlenarListas()

    End Sub

    Private Sub btn_AgregaComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregaRemision.Click
        SegundosDesconexion = 0
        Dim frm_Nuevo As New frm_Dialogo

        If Lsv_Puntos.SelectedItems(0).SubItems(12).Text = "2" Then
            MsgBox("No se puede agregar remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If Lsv_Puntos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un punto.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else

            frm_Nuevo.Id_Punto = Lsv_Puntos.SelectedItems(0).Tag
            frm_Nuevo.Nuevo = True
            frm_Nuevo.Id_CO = Lsv_Puntos.SelectedItems(0).SubItems(3).Text
            frm_Nuevo.lbl_OrigenNombre.Text = Lsv_Puntos.SelectedItems(0).Text
            If Lsv_Puntos.SelectedItems(0).Text.Trim = "" Then
                frm_Nuevo.lbl_OrigenNombre.Text = Lsv_Puntos.SelectedItems(0).SubItems(1).Text
            End If
            frm_Nuevo.lbl_DestinoNombre.Text = Lsv_Puntos.SelectedItems(0).SubItems(1).Text
            frm_Nuevo.Nuevo = True
            frm_Nuevo.ShowDialog()
            Call LlenaRemisiones() 'Refresca las Remisiones
            Call LlenaPuntosRemisiones() 'pestaña New
            Tab_RemisionesM.Text = "RemisionesM" + " (" + Str(lsv_PuntosyRemisiones.Items.Count).Trim + ")"

        End If
    End Sub

    Private Sub Btn_RBoveda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lsv_Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Materiales.SelectedIndexChanged

        SegundosDesconexion = 0


        indice = 0

        If Lsv_Materiales.SelectedItems.Count > 0 Then
            indice = Lsv_Materiales.SelectedItems(0).Index
            Call LlenaRemisionesMatDetalle()

        Else
            Lsv_MatEnvases.Items.Clear()
            Btn_RegresarAb.Enabled = False
            Btn_ValidarM.Enabled = False

        End If


    End Sub

    Private Sub Lsv_Atms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Atms.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_AtmsD.Items.Clear()
        Btn_RBovedaAtms.Text = "Regresar a Boveda"
        If Lsv_Atms.SelectedItems.Count = 0 Then
            Btn_RBovedaAtms.Enabled = False
            tbx_Remision_Retiro.Text = "0"
            Exit Sub
        End If
        If Lsv_Atms.SelectedItems(0).SubItems(8).Text = "A" Or Lsv_Atms.SelectedItems(0).SubItems(8).Text = "CA" Then
            If Lsv_Atms.SelectedItems(0).SubItems(9).Text <> "RB" Then
                Btn_RBovedaAtms.Enabled = True
            Else
                Btn_RBovedaAtms.Enabled = False
            End If
        ElseIf Lsv_Atms.SelectedItems(0).SubItems(8).Text = "DO" Or Lsv_Atms.SelectedItems(0).SubItems(8).Text = "DC" Or
                Lsv_Atms.SelectedItems(0).SubItems(8).Text = "CO" Or Lsv_Atms.SelectedItems(0).SubItems(8).Text = "NA" Then
            Btn_RBovedaAtms.Text = "Validar"
            Btn_RBovedaAtms.Enabled = Lsv_Atms.SelectedItems(0).SubItems(9).Text <> "RB" Or (Lsv_Atms.SelectedItems(0).SubItems(8).Text = "DC" And Lsv_Atms.SelectedItems(0).SubItems(12).Text > 0)
        End If
        tbx_Remision_Retiro.Text = Lsv_Atms.SelectedItems(0).SubItems(11).Text
        If Not cn_Recepcion.fn_RecRutasPropias_LlenarRemision(lsv_AtmsD, Lsv_Atms.SelectedItems(0).SubItems(12).Text) Then
            MsgBox("Ha ocurrido un error al intentar cargar los datos de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub Validar_B()
        Dim Datos As DataRow
        If Lsv_Atms.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Punto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Btn_RBovedaAtms.Enabled = False
            Exit Sub
        End If
        Dim StatusActual As String = Lsv_Atms.SelectedItems(0).SubItems(8).Text
        Dim StatusB As String = Lsv_Atms.SelectedItems(0).SubItems(9).Text
        If Btn_RBovedaAtms.Text = "Regresar a Boveda" Then
            If cmb_Boveda.SelectedValue = 0 Then
                MsgBox("Seleccione una Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Boveda.Focus()
                Exit Sub
            End If
            If cn_Recepcion.fn_RecRutasPropiasAtmsRegBoveda(Lsv_Atms.SelectedItems(0).Tag, CInt(Lsv_Atms.SelectedItems(0).SubItems(3).Text) + CInt(Lsv_Atms.SelectedItems(0).SubItems(4).Text), Lsv_Atms.SelectedItems(0).SubItems(7).Text, Lsv_Atms.SelectedItems(0).SubItems(10).Text, StatusActual) = True Then
                MsgBox("Registro Guardado.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Else
            Dim frm_Nuevo As New frm_DialogoAtms
            If StatusB = "RB" Then
                'CUANDO EL PUNTO YA FUE RECIBIDO EN BOVEDA SE MUESTRAN LOS DATOS PERO
                'NO SE PUEDE GUARDAR. EL BOTON ESTA DESHABILITADO
                frm_Nuevo.Id_PuntoC = Lsv_Atms.SelectedItems(0).Tag
                frm_Nuevo.tbx_Remision.Text = Lsv_Atms.SelectedItems(0).SubItems(11).Text
                frm_Nuevo.tbx_Remision.Tag = Lsv_Atms.SelectedItems(0).SubItems(11).Text
                frm_Nuevo.RemisionID = Lsv_Atms.SelectedItems(0).SubItems(12).Text
                frm_Nuevo.Nuevo = False
                frm_Nuevo.btn_Guardar.Enabled = False
                frm_Nuevo.Status = "RB"
                frm_Nuevo.ShowDialog()
                Exit Sub ' Provicional Jesus 19/08/2020
            End If
            If cmb_Boveda.SelectedValue = 0 Then
                MsgBox("Seleccione una Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Boveda.Focus()
                Exit Sub
            End If
            If Lsv_Atms.SelectedItems(0).SubItems(12).Text = 0 Then
                'Cuando se capturo desde Cajeros
                Dim Respuesta As MsgBoxResult
                Respuesta = MsgBox("Hubo Retiro(Custodia, Remanente o No Aplicada)?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, frm_MENU.Text)
                Select Case Respuesta
                    Case MsgBoxResult.Yes

                        Datos = cn_Recepcion.fn_RecRutasPropiasAtmsOrigenGet(Lsv_Atms.SelectedItems(0).Tag)
                        Datos = cn_Recepcion.fn_RecRutasPropiasAtmsOrigenGet(Lsv_Atms.SelectedItems(0).Tag)
                        If Datos Is Nothing Then
                            MsgBox("Ocurrió un Error al intentar consultar el Origen y Destino de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        frm_Nuevo.ProgramacionID = cmb_Rutas.SelectedValue
                        frm_Nuevo.Id_PuntoC = Lsv_Atms.SelectedItems(0).Tag
                        frm_Nuevo.RemisionID = Lsv_Atms.SelectedItems(0).SubItems(12).Text
                        frm_Nuevo.COrigen = Datos("Entidad_Origen")
                        frm_Nuevo.CDestino = Datos("Entidad_Destino")
                        frm_Nuevo.DotacionID = Lsv_Atms.SelectedItems(0).SubItems(10).Text
                        frm_Nuevo.IDBoveda = cmb_Boveda.SelectedValue
                        frm_Nuevo.Nuevo = True
                        frm_Nuevo.Utiliza_Rd = Lsv_Atms.SelectedItems(0).SubItems(13).Text
                        frm_Nuevo.Clave_Cliente = Lsv_Atms.SelectedItems(0).SubItems(14).Text
                        If StatusActual = "NA" Then
                            frm_Nuevo.Es_NoAplicada = True
                        End If
                        frm_Nuevo.ShowDialog()
                    Case MsgBoxResult.No
                        If cn_Recepcion.fn_RecRutasPropiasAtmsValidar(Lsv_Atms.SelectedItems(0).Tag) = True Then
                            MsgBox("Registro Validado.", MsgBoxStyle.Information, frm_MENU.Text)
                        End If
                End Select
            Else

                Datos = cn_Recepcion.fn_RecRutasPropiasAtmsOrigenGet(Lsv_Atms.SelectedItems(0).Tag)
                If Datos Is Nothing Then
                    MsgBox("Ocurrió un Error al intentar consultar el Origen y Destino de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                frm_Nuevo.Id_PuntoC = Lsv_Atms.SelectedItems(0).Tag
                frm_Nuevo.tbx_Remision.Text = Lsv_Atms.SelectedItems(0).SubItems(11).Text
                frm_Nuevo.tbx_Remision.Tag = Lsv_Atms.SelectedItems(0).SubItems(11).Text
                frm_Nuevo.RemisionID = Lsv_Atms.SelectedItems(0).SubItems(12).Text
                frm_Nuevo.COrigen = Datos("Entidad_Origen")
                frm_Nuevo.CDestino = Datos("Entidad_Destino")
                frm_Nuevo.Nuevo = False
                frm_Nuevo.Utiliza_Rd = Lsv_Atms.SelectedItems(0).SubItems(13).Text
                frm_Nuevo.Clave_Cliente = Lsv_Atms.SelectedItems(0).SubItems(14).Text
                frm_Nuevo.IDBoveda = cmb_Boveda.SelectedValue
                If StatusActual = "NA" Then
                    frm_Nuevo.Es_NoAplicada = True
                End If
                frm_Nuevo.ShowDialog()
            End If
            frm_Nuevo.Dispose()
        End If
        Call LlenarListas()
    End Sub

    Private Sub Btn_RBovedaAtms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RBovedaAtms.Click
        SegundosDesconexion = 0
        Validar_B()
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_General.SelectedIndexChanged
        btn_AgregaRemision.Enabled = False

        If Tab_General.SelectedTab.Name = "Tab_RemisionesM" Then
            tbx_ValidarRemision.Clear()
            tbx_ValidarRemision.Focus()
        ElseIf Tab_General.SelectedTab.Name = Tab_Atms.Name Then
            tbx_EnvasesAtm.Focus()
        ElseIf Tab_General.SelectedTab.Name = Tab_AtmsFallas.Name Then
            tbx_envasesf.Focus()
        ElseIf Tab_General.SelectedTab.Name = Tab_Materiales.Name Then
            Tbx_EnvaseM.Focus()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub lsv_Remisiones_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Remisiones.MouseClick
        If lsv_Remisiones.SelectedItems(0).SubItems(1).Text.Trim = "" Then
            Exit Sub
        Else
            tbx_Remision.Text = lsv_Remisiones.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub Lsv_Atms_AlActualizar() Handles Lsv_Atms.AlActualizar
        If Not cn_Recepcion.fn_RecRutasPropias_LlenarRemision(lsv_AtmsD, 0) Then
            MsgBox("Ha ocurrido un error al intentar cargar los datos de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Btn_RBovedaAtms.Enabled = False
    End Sub

    Private Sub Lsv_Todos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Todos.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_TodosD.Items.Clear()
        If Lsv_Todos.SelectedItems.Count > 0 Then
            cn_Recepcion.fn_ReRutasPropiasLlenaListaRemisiones(lsv_TodosD, Lsv_Todos.SelectedItems(0).Tag)
            lsv_TodosD.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv_TodosD.Columns(4).TextAlign = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub Lsv_Puntos_AlActualizar() Handles Lsv_Puntos.AlActualizar, lsv_PuntosyRemisiones.AlActualizar
        btn_GrabarServicio.Enabled = Lsv_Puntos.Items.Count > 0 And cmb_Boveda.SelectedValue <> 0
        btn_GrabarServicios.Enabled = lsv_PuntosyRemisiones.Items.Count > 0 And cmb_Boveda.SelectedValue <> 0
    End Sub

    Private Sub cmb_Boveda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Boveda.SelectedValueChanged
        SegundosDesconexion = 0
        btn_GrabarServicio.Enabled = Lsv_Puntos.Items.Count > 0 And cmb_Boveda.SelectedValue <> 0
        btn_GrabarServicios.Enabled = lsv_PuntosyRemisiones.Items.Count > 0 And cmb_Boveda.SelectedValue <> 0
    End Sub

    Private Sub tbx_Remision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Remision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Validar()
        End If
    End Sub

    Private Sub btn_cuadreruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cuadreruta.Click
        SegundosDesconexion = 0
        If Not cn_Recepcion.fn_RecRutasCuadre(cmb_Rutas.SelectedValue, dtp_Fecha.Value.Date) Then
            MsgBox("Ocurrió un error al intentar imprimir el Cuadre de Ruta.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_VerCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_VerCV.Click, Lsv_CVisita.DoubleClick
        SegundosDesconexion = 0
        If Lsv_CVisita.SelectedItems.Count = 0 Then Exit Sub
        Dim frm As New frm_ComprobanteVmodal
        frm.Id_Punto = Lsv_CVisita.SelectedItems(0).Tag
        frm.Horario = Lsv_CVisita.SelectedItems(0).SubItems(5).Text
        frm.ShowDialog()
        cn_Recepcion.fn_RecRutasPropiasLlenalistaCompVisitas(Lsv_CVisita, cmb_Rutas.SelectedValue)
        btn_VerCV.Enabled = False
    End Sub

    Private Sub Lsv_CVisita_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lsv_CVisita.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_VerCV.Enabled = Lsv_CVisita.SelectedItems.Count > 0
    End Sub

    Private Sub Tab_Remisiones_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Remisiones.MouseHover, Tab_Atms.MouseHover, Tab_CVisita.MouseHover, Tab_Materiales.MouseHover, Tab_Pendientes.MouseHover, Tab_Resumen.MouseHover, Tab_Todos.MouseHover
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_AtmsFallas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_AtmsFallas.SelectedIndexChanged
        SegundosDesconexion = 0
        lsv_AtmsFallasD.Items.Clear()
        Btn_RBovedaAtmsF.Enabled = False
        tbx_Remision_RetiroF.Text = ""
        If lsv_AtmsFallas.SelectedItems.Count > 0 Then
            If lsv_AtmsFallas.SelectedItems(0).SubItems(3).Text = "ATENDIDA" Then
                Btn_RBovedaAtmsF.Enabled = True
                tbx_Remision_RetiroF.Text = lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text
                If CDbl(lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text) > 0 Then
                    If Not cn_Recepcion.fn_RecRutasPropias_LlenarRemision(lsv_AtmsFallasD, lsv_AtmsFallas.SelectedItems(0).SubItems(5).Text) Then
                        Btn_RBovedaAtmsF.Enabled = True
                        MsgBox("Ha ocurrido un error al intentar cargar los datos de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Else
                        lsv_AtmsFallasD.Columns(1).TextAlign = HorizontalAlignment.Right
                        lsv_AtmsFallasD.Columns(2).TextAlign = HorizontalAlignment.Right
                        lsv_AtmsFallasD.Columns(3).TextAlign = HorizontalAlignment.Right
                    End If
                End If
            Else
                Btn_RBovedaAtmsF.Enabled = False
            End If
        End If
    End Sub

    Private Sub Btn_RBovedaAtmsF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RBovedaAtmsF.Click
        SegundosDesconexion = 0
        If lsv_AtmsFallas.SelectedItems.Count > 0 Then
            If lsv_AtmsFallas.SelectedItems(0).SubItems(4).Text = "A" Then
                If cmb_Boveda.SelectedValue = 0 Then
                    MsgBox("Seleccione una Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Boveda.Focus()
                    Exit Sub
                End If

                Dim frm_Nuevo As New frm_DialogoAtms
                Dim Datos As DataRow
                If CInt(lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text) = 0 Then
                    'Cuando se capturo desde Cajeros
                    Select Case MsgBox("Hubo Retiro?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, frm_MENU.Text)
                        Case MsgBoxResult.Yes
                            Datos = cn_Recepcion.fn_RecRutasPropiasAtmsFallasOrigenGet(lsv_AtmsFallas.SelectedItems(0).Tag)
                            If Datos Is Nothing Then
                                MsgBox("Ocurrió un Error al intentar consultar el Origen y Destino de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            frm_Nuevo.Es_Falla = True
                            frm_Nuevo.ProgramacionID = cmb_Rutas.SelectedValue
                            frm_Nuevo.Id_PuntoC = 0
                            frm_Nuevo.Id_Falla = lsv_AtmsFallas.SelectedItems(0).Tag
                            frm_Nuevo.RemisionID = 0
                            frm_Nuevo.COrigen = Datos("Entidad_Origen")
                            frm_Nuevo.CDestino = Datos("Entidad_Destino")
                            frm_Nuevo.DotacionID = 0
                            frm_Nuevo.IDBoveda = cmb_Boveda.SelectedValue
                            frm_Nuevo.Nuevo = True
                            frm_Nuevo.Utiliza_Rd = lsv_AtmsFallas.SelectedItems(0).SubItems(6).Text
                            frm_Nuevo.Clave_Cliente = lsv_AtmsFallas.SelectedItems(0).SubItems(7).Text
                            frm_Nuevo.ShowDialog()
                            If Not frm_Nuevo.Cancelado Then Call LlenarListas()
                        Case MsgBoxResult.No
                            If cn_Recepcion.fn_RecRutasPropiasAtmsFallasValidar(lsv_AtmsFallas.SelectedItems(0).Tag) = True Then
                                MsgBox("Registro Validado.", MsgBoxStyle.Information, frm_MENU.Text)
                                Call LlenarListas()
                            End If
                    End Select
                Else
                    Datos = cn_Recepcion.fn_RecRutasPropiasAtmsFallasOrigenGet(lsv_AtmsFallas.SelectedItems(0).Tag)
                    If Datos Is Nothing Then
                        MsgBox("Ocurrió un Error al intentar consultar el Origen y Destino de la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    frm_Nuevo.Id_PuntoC = 0
                    frm_Nuevo.Id_Falla = lsv_AtmsFallas.SelectedItems(0).Tag
                    frm_Nuevo.tbx_Remision.Text = lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text
                    frm_Nuevo.tbx_Remision.Tag = lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text
                    frm_Nuevo.RemisionID = lsv_AtmsFallas.SelectedItems(0).SubItems(5).Text
                    frm_Nuevo.COrigen = Datos("Entidad_Origen") '(Caja Bancaria)
                    frm_Nuevo.CDestino = Datos("Entidad_Destino") '(Cajero)
                    frm_Nuevo.Nuevo = False
                    frm_Nuevo.Es_Falla = True
                    frm_Nuevo.IDBoveda = cmb_Boveda.SelectedValue
                    frm_Nuevo.Utiliza_Rd = lsv_AtmsFallas.SelectedItems(0).SubItems(6).Text
                    frm_Nuevo.Clave_Cliente = lsv_AtmsFallas.SelectedItems(0).SubItems(7).Text
                    frm_Nuevo.ShowDialog()
                End If
            Else 'Cuando el punto ya fue recibido en bóveda
                Dim frm_Nuevo As New frm_DialogoAtms
                frm_Nuevo.Id_PuntoC = 0
                frm_Nuevo.Id_Falla = lsv_AtmsFallas.SelectedItems(0).Tag
                frm_Nuevo.tbx_Remision.Text = lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text
                frm_Nuevo.tbx_Remision.Tag = lsv_AtmsFallas.SelectedItems(0).SubItems(2).Text
                frm_Nuevo.RemisionID = lsv_AtmsFallas.SelectedItems(0).SubItems(5).Text
                frm_Nuevo.Nuevo = False
                frm_Nuevo.btn_Guardar.Enabled = False
                frm_Nuevo.Status = "RB"
                frm_Nuevo.Es_Falla = True
                frm_Nuevo.ShowDialog()
            End If
        Else 'Cuando no se ha seleccionado ningun registro
            MsgBox("Debe seleccionar una Falla.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Sub LlenaPuntosRemisiones()
        tbx_ValidarRemision.Clear()
        lsv_PuntosyRemisiones.Items.Clear()
        lbl_PuntosyRemisiones.Text = "Registros: 0"
        If cmb_Rutas.SelectedValue > 0 Then
            cn_Recepcion.fn_RecRutasPropias_LlenarListaPuntosyRemisiones(lsv_PuntosyRemisiones, cmb_Rutas.SelectedValue)
        End If
        lbl_PuntosyRemisiones.Text = "Registros: " & lsv_PuntosyRemisiones.Items.Count

        Dim Contador As Integer = 0
        'Revisar que existan remisiones Validadas y puntos RU
        For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If Elemento.SubItems(5).Text.Trim = "VALIDADO" And Microsoft.VisualBasic.Left(Elemento.SubItems(8).Text.Trim.ToUpper, 1) = "B" Then
                Contador += 1
            End If
        Next
        Tab_RemisionesM.Text = "RemisionesM" + " (" + Str(lsv_PuntosyRemisiones.Items.Count).Trim + ")"
        lbl_PuntosyRemisionesV.Text = "Validados: " & Contador.ToString
        tbx_ValidarRemision.Focus()
    End Sub

    Function ValidarNumeroRemision() As Boolean
        SegundosDesconexion = 0
        DesativarCOntrolesPuntosRemisiones(True)
        If tbx_ValidarRemision.Text.Trim = "" Then
            'MsgBox("Capture un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If Elemento.Text = tbx_ValidarRemision.Text.Trim Then
                Elemento.Selected = True
                Elemento.EnsureVisible()
            End If
        Next

        If lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
            lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Tag = 0

            If Not PuntoTieneCaset(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(26).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(29).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(28).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(30).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(27).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(14).Text, lsv_PuntosyRemisiones) Then
                DesativarCOntrolesPuntosRemisiones(False)
                Exit Function
            End If
        End If

        'Buscar el Numero de Remision en la Lista
        For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If Elemento.Text = tbx_ValidarRemision.Text.Trim Then
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Call MostrarDialogo2()
                Call LlenaPuntosRemisiones()
                'tbx_ValidarRemision.Clear()
                'tbx_ValidarRemision.Focus()
                Return True
                Exit Function
            End If
        Next
        Return False
        'MsgBox("No se encontró la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Function

    Private Sub MostrarDialogo2()
        frm_Dialog.Refresh()
        'frm_Dialog.btn_Guardar.Enabled = True
        frm_Dialog.Validar = True

        If lsv_PuntosyRemisiones.SelectedItems(0).SubItems(16).Text = "EN" Then
            frm_Dialog.RR = True
        Else
            frm_Dialog.RR = False
        End If

        Select Case lsv_PuntosyRemisiones.SelectedItems(0).SubItems(5).Text
            Case "MARCADO PARA REGRESAR", "RECIBIDO EN BOVEDA", "REGRESADO"
                frm_Dialog.Bloqueado = True
            Case Else
                frm_Dialog.Bloqueado = False
        End Select

        frm_Dialog.tbx_EnvasesSN.Text = CInt(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(7).Text)
        frm_Dialog.Id_Remision = lsv_PuntosyRemisiones.SelectedItems(0).Tag 'ID_Rem
        frm_Dialog.tbx_Remision.Tag = lsv_PuntosyRemisiones.SelectedItems(0).Tag 'ID_Rem
        frm_Dialog.tbx_Remision.Text = lsv_PuntosyRemisiones.SelectedItems(0).Text
        frm_Dialog.tbx_RemisionOriginal.Tag = lsv_PuntosyRemisiones.SelectedItems(0).Tag 'ID_Rem
        frm_Dialog.tbx_RemisionOriginal.Text = lsv_PuntosyRemisiones.SelectedItems(0).Text
        frm_Dialog.Id_Punto = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(13).Text
        frm_Dialog.Id_CO = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(14).Text
        frm_Dialog.lbl_OrigenNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Text
        If lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Text.Trim = "" Then
            frm_Dialog.lbl_OrigenNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(2).Text
        End If
        frm_Dialog.lbl_DestinoNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(3).Text
        frm_Dialog.Id_CiaProp = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(23).Text
        frm_Dialog.Hora_Remision = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(24).Text
        frm_Dialog.Nuevo = False
        'Remision digital ... Se guarda el tipo de remision y la cantidad de envases que  dice contener
        frm_Dialog.Cant_env = CInt(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(6).Text)
        frm_Dialog.tipoRemision = CInt(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(25).Text)
        frm_Dialog.ShowDialog()

    End Sub

    Private Sub btn_ValidarRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarRemision.Click
        SegundosDesconexion = 0
        If Not ValidarNumeroRemision() Then
            Buscar_Envase(lsv_tv, tbx_ValidarRemision)
        End If
    End Sub

    Private Sub tbx_ValidarRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_ValidarRemision.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not ValidarNumeroRemision() Then
                Buscar_Envase(lsv_tv, tbx_ValidarRemision)
            End If
        End If
    End Sub

    Private Sub btn_GrabarServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabarServicios.Click
        SegundosDesconexion = 0
        If lsv_PuntosyRemisiones.Items.Count = 0 Then
            MsgBox("No existen Remisiones para guardar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If cmb_Boveda.SelectedValue = 0 Then
            MsgBox("Seleccione la Bóveda donde se guardarán las Remisiones que está recibiendo.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Boveda.Focus()
            Exit Sub
        End If
        Dim Contador As Integer = 0
        'Revisar que existan remisiones Validadas y puntos RU
        For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If Elemento.SubItems(4).Text.Trim.ToUpper = "EN RUTA" And Elemento.SubItems(5).Text.Trim = "VALIDADO" _
                And Microsoft.VisualBasic.Left(Elemento.SubItems(8).Text.Trim.ToUpper, 1) = "B" Then
                Contador += 1
            End If
        Next
        If Contador = 0 Then
            MsgBox("No se encontraron remisiones Validadas para Recibir.", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim ct As Integer = cn_Recepcion.fn_RecRutasPropias_GuardarXRemision(cmb_Boveda.SelectedValue, cmb_Rutas.SelectedValue, lsv_PuntosyRemisiones, dtp_Fecha.Value.Date, lsv_PuntosyRemisiones.Items(0).SubItems(12).Text)

        If ct = -1 Then
            MsgBox("Ocurrió un error al grabar los servicios.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Me.Cursor = Cursors.Default

        If ct = -2 Then
            MsgBox("Se grabaron los servicios correctamente. Los registros para Facturación no se pudieron Generar.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        ElseIf ct > 0 Then
            MsgBox(ct & " Servicio(s) grabado(s) correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        ElseIf ct = 0 Then
            MsgBox("No se afectó ningun servicio, Verifique estatus de la remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If
        Call LlenarListas()
    End Sub

    Private Sub lsv_PuntosyRemisiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_PuntosyRemisiones.SelectedIndexChanged
        SegundosDesconexion = 0
        DesativarCOntrolesPuntosRemisiones(True)
        'tbx_ValidarRemision.Clear()

        If lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then

            lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Tag = 0

            If Not PuntoTieneCaset(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(26).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(29).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(28).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(30).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(27).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(14).Text, lsv_PuntosyRemisiones) Then
                DesativarCOntrolesPuntosRemisiones(False)
                Exit Sub
            End If

            'tbx_ValidarRemision.Text = lsv_PuntosyRemisiones.SelectedItems(0).Text
            tbx_ValidarRemision.Focus()
        End If
    End Sub

    Private Sub lsv_PuntosyRemisiones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_PuntosyRemisiones.DoubleClick
        Doble_click()
    End Sub

    Sub Doble_click()
        DesativarCOntrolesPuntosRemisiones(True)

        'Se desactivo esta parte.
        'Variables.Id_RemisionFacturacion = lsv_PuntosyRemisiones.Items(lsv_PuntosyRemisiones.SelectedIndices(0)).Tag
        'Dim dr_movimiento As DataRow = fn_IniciarServicios_ObtenerMovimiento(Id_RemisionFacturacion)
        'Id_Movimiento = dr_movimiento("Id_Movimiento")

        If lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
            lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Tag = 0

            If Not PuntoTieneCaset(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(26).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(29).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(28).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(30).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(27).Text, lsv_PuntosyRemisiones.SelectedItems(0).SubItems(14).Text, lsv_PuntosyRemisiones) Then
                DesativarCOntrolesPuntosRemisiones(False)
                Exit Sub
            End If
        End If

        Call MostrarDialogo2()
        Call LlenaPuntosRemisiones()
        ''Actualizar envases al serar el fomulario 
        ''Lista de envases 19/08/20
        fn_RecRutasPropiastvEnvases(lsv_tv, cmb_Rutas.SelectedValue)
        Lbl_envases.Text = "Registros: " & lsv_tv.Items.Count
        Color_Item(lsv_tv)
        'ColorDot() ''Pintar Dotaciones
        ''
        'Call LlenaPuntosRemisiones()
        'tbx_ValidarRemision.Clear()
        'tbx_ValidarRemision.Focus()
    End Sub

    Private Sub btn_AgregarNuevaRemisionN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarNuevaRemision.Click
        SegundosDesconexion = 0
        If lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
            If lsv_PuntosyRemisiones.SelectedItems(0).SubItems(25).Text = "2" Then
                MsgBox("No se puede agregar remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Dim frm_Nuevo As New frm_Dialogo
            frm_Nuevo.Id_Punto = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(13).Text
            frm_Nuevo.Nuevo = True

            frm_Nuevo.lbl_OrigenNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Text
            If lsv_PuntosyRemisiones.SelectedItems(0).SubItems(1).Text.Trim = "" Then
                frm_Nuevo.lbl_OrigenNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(2).Text
            End If
            frm_Nuevo.lbl_DestinoNombre.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(3).Text
            frm_Nuevo.Nuevo = True
            frm_Nuevo.Id_CO = CInt(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(14).Text)
            frm_Nuevo.ShowDialog()
            Call LlenaPuntosRemisiones() 'Refresca las Remisiones
            Call LlenaRemisiones() ' pestaña antes
        Else
            Exit Sub
            'Dim frm As New frm_PuntosAgregarRemision
            'frm.Id_Programacion = cmb_Rutas.SelectedValue
            'frm.ShowDialog()
            'Call LlenaPuntosRemisiones() 'Refresca las Remisiones
            'Call LlenaRemisiones() ' pestaña antes
        End If
    End Sub

    Private Sub btn_StatusRutas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_StatusRutas.Click
        Dim frm As New frm_StatusRutas
        frm.dtp_Fecha.Value = dtp_Fecha.Value
        frm.ShowDialog()
    End Sub

    Private Function PuntoUtilizaCaset(ByVal UtilizaCaset As String) As Boolean
        Return (UtilizaCaset = "S")
    End Function

    Private Function EsPuntoEspecial(ByVal PuntoEspecial As String) As Boolean
        Return (PuntoEspecial = "S")
    End Function

    Private Function RetiroCaseT(ByVal RetiroCas As String) As Boolean
        Return (RetiroCas = "S")
    End Function

    Private Function EntregoCaset(ByVal EntregoCas As String) As Boolean
        Return (EntregoCas = "S")
    End Function

    Private Function CasetPropio(ByVal EsPropio As String) As Boolean
        Return (EsPropio = "S")
    End Function

    Public Function RecibioCaset(ByVal EsPropio As String, ByVal Especial As String, ByVal Id_Cliente As Integer, ByVal lsv As cp_Listview) As Boolean


        Dim Dt_CasetSalidaEntradasRec As DataTable = fn_KardexCaset_ESRecepcion(cmb_Rutas.SelectedValue, Id_Cliente, "S")


        If Dt_CasetSalidaEntradasRec Is Nothing Then
            MsgBox("OCurrió un error al intentar consultar Salidas y Entradas de Caset.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If


        If Dt_CasetSalidaEntradasRec.Rows.Count > 0 Then

            For Each dr As DataRow In Dt_CasetSalidaEntradasRec.Rows
                If dr("Status") = "ER" And dr("Tipo") = 2 Then

                    MsgBox("Imposible validar el punto, ya que no se ha recibido caset", MsgBoxStyle.Information, frm_MENU.Text)
                    Return False

                ElseIf dr("Status").ToString() = "EN" And dr("Tipo").ToString() = 1 Then

                    If dr("Ruta_Inicio").ToString() = "S" Then
                        If lsv.SelectedItems.Count > 0 Then lsv.SelectedItems(0).SubItems(1).Tag = 1 '1 significa que es ruta de inicio
                        Return True
                    ElseIf dr("Ruta_Inicio").ToString() = "N" And dr("Tipo").ToString() = 2 Then
                        If Not CasetPropio(EsPropio) And Not EsPuntoEspecial(Especial) Then
                            MsgBox("Imposible continuar, ya que no se ha recibido caset.", MsgBoxStyle.Information, frm_MENU.Text)
                            Return False
                        End If
                    End If
                End If
            Next
        End If
        Return True
    End Function

    Public Function RutaInicio(ByVal Dt_CasetSalidaRec As DataTable, ByVal Dt_CasetEntradaRec As DataTable) As Boolean
        If Dt_CasetSalidaRec.Rows.Count > 0 And Dt_CasetEntradaRec.Rows.Count = 0 Then
            For Each dr As DataRow In Dt_CasetSalidaRec.Rows
                If Not dr("Ruta_Inicio").ToString() = "S" Then
                    Return False
                End If
            Next
        ElseIf Dt_CasetEntradaRec.Rows.Count = 0 And Dt_CasetSalidaRec.Rows.Count = 0 Then
            MsgBox("Imposible continuar, ya que no se escaneo caset de salida ni entrada.", MsgBoxStyle.Information, frm_MENU.Text)
            Return False
        End If
        Lsv_Puntos.SelectedItems(0).SubItems(1).Tag = 1 ' si llegó hasta aquí significa que es ruta de inicio
        Return True ' si llego hasta aqui quiere decir que todos los caset son de ruta de inicio
    End Function

    Public Sub DesactivarControles()
        Btn_Validar.Enabled = False
        btn_GrabarServicio.Enabled = False
        btn_AgregaRemision.Enabled = False
        btn_cuadreruta.Enabled = False
    End Sub

    Public Sub DesativarCOntrolesPuntosRemisiones(ByVal Valor As Boolean)
        btn_AgregarNuevaRemision.Enabled = Valor
        btn_GrabarServicios.Enabled = Valor
        btn_cuadreruta.Enabled = Valor
    End Sub

    Public Function ExisteCasetEnRuta() As Boolean
        Return (fn_Kardex_CasetAsinadoRuta_GetRecepcion(cmb_Rutas.SelectedValue, 0, 2).Rows.Count > 0)
    End Function

    Public Sub PuntoCasetRecibidoValidar() ' le asigna un valor a quellos servicios de ruta inicio. puede pasar que depues de validar un servicio el usuario cierre la ventana y se pierda el valor de ruta inicio asignado a cada servicio.
        ' razon por la cual se realiza esta validacion.


        For Each elemento As ListViewItem In lsv_PuntosyRemisiones.Items
            If elemento.SubItems(5).Text = "VALIDADO" Then
                elemento.Selected = True
                elemento.SubItems(1).Tag = 0 'significa que no es ruta de inicio, si lo es mas adelante se asigna un 1
                'se puede dar el caso en una programación haya un solo punto que utiliza caset y ese sea cancelado, obligar al usuario que lo reciba en recepcion
                PuntoTieneCaset(elemento.SubItems(26).Text, elemento.SubItems(29).Text, elemento.SubItems(28).Text, elemento.SubItems(30).Text, elemento.SubItems(27).Text, elemento.SubItems(14).Text, lsv_PuntosyRemisiones)
            End If
            elemento.Selected = True
        Next

        For Each item As ListViewItem In Lsv_Puntos.Items
            Dim dt_Remisiones As DataTable = cn_Recepcion.fn_ReRutasPropiasLlenaListaRemisionesDataT(item.Tag)
            For Each remision As DataRow In dt_Remisiones.Rows
                If remision("Status").ToString() = "VALIDADO" Then
                    item.Selected = True
                    item.SubItems(1).Tag = 0 'significa que no es ruta de inicio, si lo es mas adelante se asigna un 1
                    'se puede dar el caso en una programación haya un solo punto que utiliza caset y ese sea cancelado, obligar al usuario que lo reciba en recepcion
                    PuntoTieneCaset(item.SubItems(7).Text, item.SubItems(10).Text, item.SubItems(9).Text, item.SubItems(11).Text, item.SubItems(8).Text, item.SubItems(3).Text, Lsv_Puntos)
                End If
            Next
        Next

    End Sub

    Dim RemisionB As String
    ''>>REMISIONES DIGITALES 
    Function Buscar_Envase(ByVal lsv As ListView, ByVal tbx As TextBox) As Boolean
        If tbx.Text.Trim = Nothing Or tbx.Text = "Sin envase" Then Exit Function
        For Each elemento As ListViewItem In lsv.Items
            If (tbx.Text.Trim = elemento.SubItems(1).Text AndAlso Buscar_Numero(tbx.Text) = False) Then
                RemisionB = elemento.SubItems(0).Text
                List_Envases.Add(tbx.Text.Trim)
                elemento.BackColor = Color.LightGreen
                Contar_Remisiones_Scaner_X_envase() 'Abre la ventana de validar cuando se scanean el total de envases de una remision.
                Return True
            End If
        Next
        Return False
    End Function

    Function Contar_Remisiones_Scaner_X_envase()
        Dim Cont As Integer
        For Each Remision As ListViewItem In lsv_tv.Items
            If Remision.SubItems(0).Text = RemisionB AndAlso Remision.BackColor = Color.LightGreen Then
                Cont += 1
            End If
        Next
        For Each Remision As ListViewItem In lsv_PuntosyRemisiones.Items
            '            MessageBox.Show(Remision.SubItems(0).Text + " " + Remision.SubItems(6).Text)
            If Remision.SubItems(0).Text = RemisionB AndAlso Cont = Remision.SubItems(6).Text Then
                Remision.Selected = True
                Doble_click()
                Exit For
            End If
        Next
    End Function

    Function Buscar_Numero(ByVal Numero As String) As Boolean
        For Each NumeroE As String In List_Envases
            If NumeroE = Numero Then Return True
        Next
        Return False
    End Function

    Sub Color_Item(ByVal lsv As ListView)
        For Each elemento As ListViewItem In lsv.Items
            If Buscar_Numero(elemento.SubItems(1).Text) Then
                elemento.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    'Sub ColorDot()
    '    For Each Elemento As ListViewItem In lsv_PuntosyRemisiones.Items
    '        If Elemento.SubItems(25).Text = "2" Then
    '            Elemento.BackColor = Color.LightSkyBlue
    '        End If
    '    Next
    'End Sub

    Private Sub tbx_EnvasesAtm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_EnvasesAtm.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Buscar_Envase(lsv_envases, tbx_EnvasesAtm)
        End If
    End Sub

    Private Sub tbx_envasesf_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_envasesf.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Buscar_Envase(lsv_fallas, tbx_envasesf)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        'If lsv_TodosD.SelectedItems.Count > 0 Or lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
        '    ContextMenuStrip1.Enabled = True
        'Else
        '    ContextMenuStrip1.Enabled = False
        'End If
    End Sub

    Private Sub CopiarRemisionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarRemisionToolStripMenuItem.Click
        Select Case Tab_General.SelectedTab.Name.ToUpper
            Case Tab_RemisionesM.Name.ToString.ToUpper
                If lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
                    tbx_copy.Text = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text
                    Copy_remision = lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text
                    tbx_copy.SelectAll()
                    tbx_copy.Copy()
                Else
                    MsgBox("Seleccione una remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                End If
            Case Tab_Todos.Name.ToString.ToUpper
                If lsv_TodosD.SelectedItems.Count > 0 Then
                    tbx_copy.Text = lsv_TodosD.SelectedItems(0).SubItems(1).Text
                    Copy_remision = lsv_TodosD.SelectedItems(0).SubItems(1).Text
                    tbx_copy.SelectAll()
                    tbx_copy.Copy()
                Else
                    MsgBox("Seleccione una remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                End If
            Case Tab_Atms.Name.ToString.ToUpper
                If Lsv_Atms.SelectedItems.Count > 0 Then
                    tbx_copy.Text = Lsv_Atms.SelectedItems(0).SubItems(0).Text
                    Copy_remision = Lsv_Atms.SelectedItems(0).SubItems(0).Text
                    tbx_copy.SelectAll()
                    tbx_copy.Copy()
                Else
                    MsgBox("Seleccione una remisión.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                End If
        End Select


    End Sub

    Private Sub VerComentariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerComentariosToolStripMenuItem.Click
        If Tab_General.SelectedTab.Name = "Tab_RemisionesM" AndAlso lsv_PuntosyRemisiones.SelectedItems.Count > 0 Then
            If lsv_PuntosyRemisiones.SelectedItems(0).SubItems(31).Text.Trim() <> "" Then
                MessageBox.Show(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(31).Text)
            End If
        End If
    End Sub

    Private Sub VerRemisionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerRemisionToolStripMenuItem.Click
        If lsv_PuntosyRemisiones.SelectedItems.Count <= 0 Then Exit Sub
        Try
            Dim Remisiones As DataTable = cn_Recepcion.obtenerNotificacion(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text)
            For Each noti In Remisiones.Rows
                Dim dtRemisionImporte As DataTable = cn_Recepcion.obtenerRemisionWebImporte(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text)
                Dim dtEnvases As DataTable = cn_Recepcion.obtenerEnvases(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text)
                Dim dtMonedas As DataTable = cn_Recepcion.obtenerImporteMoneda(lsv_PuntosyRemisiones.SelectedItems(0).SubItems(0).Text)

                Dim envases As String = cn_Recepcion.obtenerEnvases(dtEnvases)
                Dim cantEnvaseBillete As String = cn_Recepcion.obtenerEnvaseMoneda(dtEnvases)
                Dim cantEnvaseMixto As String = cn_Recepcion.obtenerEnvaseMixto(dtEnvases)
                Dim cantEnvaseMorr As String = cn_Recepcion.obtenerEnvaseMorralla(dtEnvases)

                Dim impPesos As Decimal = cn_Recepcion.obtenerMonenadaNacional(dtMonedas)
                Dim impExtranjero As Decimal = cn_Recepcion.obtenerMonedaExtranjera(dtMonedas)
                Dim impDoctos As Decimal = cn_Recepcion.obtenerDocumentos(dtMonedas)


                If dtRemisionImporte.Rows.Count = 0 Then
                    Dim dr As DataRow = dtRemisionImporte.NewRow()
                    dr("Mil") = 0
                    dr("Cien") = 0
                    dr("MVeinte") = 0
                    dr("MDos") = 0
                    dr("MPVeinte") = 0
                    dr("Quinientos") = 0
                    dr("Cincuenta") = 0
                    dr("MDiez") = 0
                    dr("MUno") = 0
                    dr("MPDiez") = 0
                    dr("Docientos") = 0
                    dr("Veinte") = 0
                    dr("MCinco") = 0
                    dr("MPCincuenta") = 0
                    dr("MPCinco") = 0
                    dr("Id_RemisionesWebImportes") = 0
                    dr("Id_Remision") = 0
                    dr("Id_RemisionReal") = 0
                    dtRemisionImporte.Rows.Add(dr)
                End If
                Dim stream As MemoryStream = RemisionDigital.Class1.crearPDF(noti("Numero_Remision").ToString(), noti("Fecha").ToString(), noti("Hora").ToString(), noti("Envases").ToString() & "+ " + noti("EnvasesSN").ToString() & " S/N", envases, CStr(impDoctos + impExtranjero + impPesos), FuncionesGlobales.fn_EnLetras((impDoctos + impExtranjero + impPesos).ToString()), noti("NombreClienteOrigen").ToString(), noti("ClaveClienteOrigen").ToString(), noti("DireccionOrigen").ToString(), noti("NombreClienteDestino").ToString(), noti("DireccionDestino").ToString(), noti("Clave_Ruta").ToString(), noti("CiaTraslada").ToString(), noti("Unidad").ToString(), noti("Cajero").ToString(), noti("UsuarioClienteFirma").ToString(), Convert.ToString(impPesos), Convert.ToString(impExtranjero), Convert.ToString(impDoctos), cantEnvaseBillete.ToString(), cantEnvaseMorr.ToString(), cantEnvaseMixto.ToString(), dtRemisionImporte.Rows(0)("Mil").ToString(), dtRemisionImporte.Rows(0)("Quinientos").ToString(), dtRemisionImporte.Rows(0)("Docientos").ToString(), dtRemisionImporte.Rows(0)("Cien").ToString(), dtRemisionImporte.Rows(0)("Cincuenta").ToString(), dtRemisionImporte.Rows(0)("Veinte").ToString(), dtRemisionImporte.Rows(0)("MVeinte").ToString(), dtRemisionImporte.Rows(0)("MDiez").ToString(), dtRemisionImporte.Rows(0)("MCinco").ToString(), dtRemisionImporte.Rows(0)("MDos").ToString(), dtRemisionImporte.Rows(0)("MUno").ToString(), dtRemisionImporte.Rows(0)("MPCincuenta").ToString(), dtRemisionImporte.Rows(0)("MPVeinte").ToString(), dtRemisionImporte.Rows(0)("MPDiez").ToString(), dtRemisionImporte.Rows(0)("MPCinco").ToString(), noti("Comentarios").ToString())

                Dim frm As New frm_ConsultaRemision
                frm.ms = stream
                frm.ShowDialog()
            Next

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al buscar la remision." + ex.Message)
        End Try
    End Sub

    Private Sub Btn_RegresarAb_Click(sender As Object, e As EventArgs) Handles Btn_RegresarAb.Click
        SegundosDesconexion = 0
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Las remisiones del punto se regresaran a la boveda de materiales, ¿ Desea continuar ?", "SIAC", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            If Lsv_Materiales.SelectedItems.Count = 0 Then
                MsgBox("Seleccione una Remisión de Material para Regresar a Bóveda.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            cn_Recepcion.fn_RecRutasPropiasMateriales(cmb_Rutas.SelectedValue, Lsv_Materiales.SelectedItems(0).Tag)
            cmb_Rutas_SelectedIndexChanged(cmb_Rutas, e)
            Btn_RegresarAb.Enabled = False
            Lsv_MatEnvases.Items.Clear()
        End If

    End Sub

    Private Sub Btn_MatBuscar_Click(sender As Object, e As EventArgs) Handles Btn_MatBuscar.Click
        SegundosDesconexion = 0
        If Not Mat_ValidarNumeroRemision() Then
            MatBuscar_Envase()
        End If
    End Sub
    Function Mat_ValidarNumeroRemision() As Boolean
        SegundosDesconexion = 0
        If Tbx_EnvaseM.Text.Trim = "" Then
            'MsgBox("Capture un Número de Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        For Each Elemento As ListViewItem In Lsv_Materiales.Items
            If Elemento.Text = Tbx_EnvaseM.Text.Trim Then
                Elemento.Selected = True
                Elemento.EnsureVisible()
                Return True
            End If
        Next


        Return False
        'MsgBox("No se encontró la Remisión.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Function

    Function MatBuscar_Envase() As Boolean
        If Tbx_EnvaseM.Text.Trim = Nothing Or Tbx_EnvaseM.Text = "Sin envase" Then Exit Function
        For Each Elemento As ListViewItem In Lsv_MatEnvases.Items
            If (Tbx_EnvaseM.Text.Trim = Elemento.SubItems(1).Text) Then
                Elemento.Selected = True
                Elemento.EnsureVisible()


                For Each Elemento2 As ListViewItem In Lsv_Materiales.Items
                    If (Elemento2.Text = Elemento.SubItems(0).Text) Then
                        Elemento2.Selected = True
                        Elemento2.EnsureVisible()
                        Return True
                    End If
                Next
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Tbx_EnvaseM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbx_EnvaseM.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not Mat_ValidarNumeroRemision() Then
                MatBuscar_Envase()
            End If
        End If
    End Sub

    Private Sub Btn_ValidarM_Click(sender As Object, e As EventArgs) Handles Btn_ValidarM.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Se validara la entrega de material con numero de remision: " + Lsv_MatEnvases.SelectedItems(0).SubItems(1).Text + " ¿ Desea continuar ?", "SIAC", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Mat_PuntosValidar(cmb_Rutas.SelectedValue, Lsv_MatEnvases.SelectedItems(0).Tag, Lsv_MatEnvases.SelectedItems(0).SubItems(8).Text)
            LlenaRemisionesMatDetalle()
            Btn_ValidarM.Enabled = False
            If cmb_Rutas.SelectedValue = 0 Then Exit Sub
            cn_Recepcion.fn_RecRutasPropiasLlenalistaMateriales(Lsv_Materiales, cmb_Rutas.SelectedValue)

            Lsv_Materiales.Items(indice).Selected = True


        End If
    End Sub

    Private Sub Lsv_MatEnvases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lsv_MatEnvases.SelectedIndexChanged
        Btn_ValidarM.Enabled = False

        'Try


        If Lsv_MatEnvases.SelectedItems.Count > 0 Then
            If Lsv_MatEnvases.SelectedItems(0).SubItems(2).Text = "REGISTRADO" And Lsv_Materiales.SelectedItems(0).SubItems(2).Text.ToUpper() = "ENTREGADO POR RUTA" Then
                Btn_ValidarM.Enabled = True
                'ElseIf Lsv_MatEnvases.SelectedItems(0).SubItems(2).Text = "ENTREGADO" Then
                '    Btn_ValidarM.Enabled = True
            End If
        End If

        'Catch ex As Exception

        'End Try


    End Sub


End Class