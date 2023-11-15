Imports System.Windows.Forms
Imports System.Threading
Imports System.Globalization
Imports System.Deployment.Application

Public Class frm_MENU

    Private Segundos As Integer = 0
    Dim PrimeraCarga As Boolean = True
    Dim DespachoBandera As Boolean = False

    Private Sub frm_MENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If LoginId > 0 Then
            Cn_Login.Login_CerrarSesion()
            'Insertar en Usr_Log
            If TipoBloqueo <> 0 Then
                Cn_Login.fn_Log_Create("CIERRE DE SESION(DESPUES DE BLOQUEO)")
            Else
                Cn_Login.fn_Log_Create("CIERRE DE SESION")
            End If
        End If
    End Sub

    Private Sub frm_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Call Deshabilitar_Todo()

        'Cambiar la configuración regional
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES", False)

        ' Obtengo la informacion de formato numerico
        Dim nfi As Globalization.NumberFormatInfo = Thread.CurrentThread.CurrentCulture.NumberFormat
        ' Obtengo la informacion de formato fecha
        Dim Dfi As Globalization.DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        If nfi.NumberDecimalSeparator <> "." Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.NumberGroupSeparator <> "," Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.CurrencySymbol <> "$" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortDatePattern <> "dd/MM/yyyy" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortTimePattern <> "HH:mm:ss" And Dfi.ShortTimePattern <> "hh:mm tt" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        tmr_Inicio.Enabled = True
    End Sub

    Private Sub tmr_Inicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Inicio.Tick
        TipoBloqueo = 0
        SegundosDesconexion = 0
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Dim frmSet As New frm_Settings
        'verificar Si hay tipoesquema y DAtos de conexion
        If My.Settings.TipoEsquema = "0" Then
            frmSet.ShowDialog()
            If My.Settings.TipoEsquema = "0" Then
                MsgBox("No se ha especificado el tipo de esquema a utiliar.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If

        If cn_Recepcion.fn_CuentaSettings() = 10 Then
            frmSet.ShowDialog()
            If cn_Recepcion.fn_CuentaSettings() = 10 Then
                MsgBox("No se ha capturado el nombre del Servidor y la Base de Datos.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If
        '---------------
        frm_Login.ShowDialog()
        If SucursalId = 0 Then
            Me.Close()
            Exit Sub
        End If
        Me.Text = "SIAC. Módulo Recepción v" & ModuloVersion & "  ** Conectado A: " & SucursalDatos

        '----Ocultar Menus
        'Cuando Morralla Recibe Rutas los menus no deben estar disponibles
        EnviarServiciosAMorrallaToolStripMenuItem.Visible = Not MorrallaRecibeRuta
        CancelarEnvíoAMorrallaToolStripMenuItem.Visible = Not MorrallaRecibeRuta


        Me.Cursor = Cursors.WaitCursor
        cn_Mensajes.ActualizarMensajes()
        Me.Cursor = Cursors.Default
        tmr_Hora.Enabled = True

    End Sub

    Private Sub tmr_Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Hora.Tick
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString

        Segundos += 1
        SegundosDesconexion += 1
        If SegundosDesconexion >= (MinutosDesconexion * 60) Then
            SegundosDesconexion = 0
            tmr_Hora.Enabled = False

            If VerificaDespachosPendientes() Then
                tmr_Hora.Enabled = True
                Exit Sub
            End If
            Call CerrarModales()

            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("BLOQUEO POR INACTIVIDAD")
            TipoBloqueo = 2

            Me.Hide()
            frm_Login.ShowDialog()
            tmr_Hora.Enabled = True
        End If
        If Segundos >= 300 Then
            cn_Mensajes.ActualizarMensajes()
            Segundos = 0
        End If

    End Sub

    Function VerificaDespachosPendientes() As Boolean
        VerificaDespachosPendientes = False
        'For I As Integer = 0 To Application.OpenForms.Count - 1
        '    If Application.OpenForms(I).Name = "frm_DespachoRutasPropias" Then
        '        DespachoBandera = True
        '        Exit For
        '    End If
        'Next
        'If Application.OpenForms("frm_DespachoRutasPropias") IsNot Nothing Then
        '    'Si está abierto el formulario frm_DespachoRutasPropias
        '    For I As Integer = 0 To Application.OpenForms.Count - 1
        '        If Application.OpenForms(I).Name = "frm_Reporte" Then
        '            Application.OpenForms(I).Close()
        '            Return True
        '            Exit Function
        '        End If
        '    Next
        'End If

        If Application.OpenForms("frm_DespachoRutasPropias") IsNot Nothing And Application.OpenForms("frm_Reporte") IsNot Nothing Then
            Application.OpenForms("frm_Reporte").Close()
            Return True
            Exit Function
        End If
    End Function

    Sub CerrarModales()
        Dim Contador As Integer = Application.OpenForms.Count
        Dim formulario() As String = Nothing
        Dim a As Integer = 0

        'Se llena el arreglo con los nombres de los formularios abiertos
        'que sean modales
        For n As Integer = 0 To Contador - 1
            If Application.OpenForms(n).Modal Then
                ReDim Preserve formulario(a)
                formulario(a) = Application.OpenForms(n).Name
                a += 1
                'ElseIf Application.OpenForms(n).Name = "frm_DespachoRutasPropias" Then
                '    ReDim Preserve formulario(a)
                '    formulario(a) = Application.OpenForms(n).Name
                '    a += 1
            End If
        Next

        Try
            'Se cierran todos los formularios cuyos nombres se guardaron en el arreglo formulario
            If formulario IsNot Nothing AndAlso formulario.Length > 0 Then
                For ILocal As Integer = 0 To formulario.Length - 1
                    Application.OpenForms(formulario(ILocal)).Dispose()
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub tsb_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Bloquear.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BLOQUEAR SISTEMA")
        TipoBloqueo = 1

        tmr_Hora.Enabled = False
        Me.Hide()
        frm_Login.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0
        For Each element As ToolStripItem In MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If
                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If
                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub frm_MENU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Control + Keys.F10 + Keys.Shift + Keys.Alt Then
            MsgBox(Cnx_Datos, MsgBoxStyle.Information, Text)
        End If
    End Sub

    Private Sub RecepcionDeRutasExternasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionDeRutasExternasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE RUTAS EXTERNAS")

        Dim frm As New frm_RecepcionRutasExternas
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub RecepcionDeRutasPropiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionDeRutasPropiasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE RUTAS PROPIAS")

        Dim frm As New frm_RecepcionRutasInternas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeSaldoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALDO")

        Dim frm As New frm_ConsultaSaldo
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DespachoDeRutasExternasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespachoDeRutasExternasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESPACHO DE RUTAS EXTERNAS")

        Dim frm As New frm_DespachoRutasExternas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DespachoDeRutasPropiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespachoDeRutasPropiasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESPACHO DE RUTAS PROPIAS")

        Dim frm As New frm_DespachoRutasPropias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AsignarAProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarAProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR SERVICIOS A PROCESO")

        Dim frm As New frm_AsignarProceso
        frm.Destino = "P"
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DevolucionDeResguardosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionDeResguardosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE RESGUARDO")

        Dim frm As New frm_DevoluciondeResguardo
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AperturaYCierreDeBovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaYCierreDeBovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE BOVEDAS")

        Dim frm As New frm_BovedasApertura
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaEntradasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ENTRADAS")

        Dim frm As New frm_ConsultaEntradas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaSalidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaSalidasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALIDAS")

        Dim frm As New frm_ConsultaSalidas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub CambioDeTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeTurnoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIO DE TURNO")

        Dim frm As New frm_CambioTurno
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub EntradaDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeMaterialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENTRADA DE MATERIALES")

        Dim frm As New frm_EntradaMateriales
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DevolucionDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionDeMaterialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE MATERIALES")

        Dim frm As New frm_DevolucionMateriales
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ReciboResguardoABovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboResguardoABovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENTRADA DE RESGUARDO")

        Dim frm As New frm_EntradaResguardos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE RESGUARDO")

        Dim frm As New frm_DevolucionReciboResgLotesBoveda
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AsignarFechaORutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarFechaORutaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR FECHA Y RUTA A SERVICIOS")

        Dim frm As New frm_AsignarFechaYruta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub EntradaDotacionesCajerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDotacionesCajerosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ERCIBIR DOTACIONES DE CAJEROS")

        Dim frm As New frm_EntradaDotaciones
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DevolucionDotacionesACajerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionDotacionesACajerosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE DOTACIONES")

        Dim frm As New frm_DevolucionDotacion
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DevolucionDeConcentracionesACajerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionDeConcentracionesACajerosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR SERVICIOS A CAJEROS")

        Dim frm As New frm_AsignarATM
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR SERVICIOS REGRESADOS DE PROCESO")

        Dim frm As New frm_EntradaServiciosReg
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub RastreoDeRemisionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RastreoDeRemisionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RASTREO DE REMISIONES")

        Dim frm As New frm_Rastreo
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tbs_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs_Salir.Click
        Me.Close()
    End Sub

    Private Sub tsb_CambioTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_CambioTurno.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIO DE TURNO")

        Dim frm As New frm_CambioTurno
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tbs_DespachoPropias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs_DespachoPropias.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESPACHO DE RUTAS PROPIAS")

        Dim frm As New frm_DespachoRutasPropias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tbs_DespachoExternas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs_DespachoExternas.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESPACHO DE RUTAS EXTERNAS")

        Dim frm As New frm_DespachoRutasExternas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tbs_RecepcionPropias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs_RecepcionPropias.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE RUTAS PROPIAS")

        Dim frm As New frm_RecepcionRutasInternas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tbs_RecepcionExternas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbs_RecepcionExternas.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE RUTAS EXTERNAS")

        Dim frm As New frm_RecepcionRutasExternas
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub tsb_LeerMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_LeerMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub tsb_NuevoMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_NuevoMensaje.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub tsb_AsignarFechaHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_AsignarFechaHora.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR FECHA Y RUTA A SERVICIOS")

        Dim frm As New frm_AsignarFechaYruta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_AsignarProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_AsignarProceso.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR SERVICIOS A PROCESO")

        Dim frm As New frm_AsignarProceso
        frm.Destino = "P"
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_ResguardoRecibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ResguardoRecibir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR RESGUARDO")

        Dim frm As New frm_EntradaResguardos
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_RecibirRegresadosProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_RecibirRegresadosProceso.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR SERVICIOS REGRESADOS DE PROCESO")

        Dim frm As New frm_EntradaServiciosReg
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_DotacionesRecibir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesRecibir.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECIBIR DOTACIONES DE CAJEROS")

        Dim frm As New frm_EntradaDotaciones
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_ResguardosEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_ResguardosEnviar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE RESGUARDO")

        Dim frm As New frm_DevoluciondeResguardo
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_DotacionesEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_DotacionesEnviar.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCION DE DOTACIONES")

        Dim frm As New frm_DevolucionDotacion
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub tsb_Saldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Saldo.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SALDO")

        Dim frm As New frm_ConsultaSaldo
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub VerMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub EnviarMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub RecepciónDeCustodiasDeATMsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeCustodiasDeATMsToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE CUSTODIAS ATMS")

        Dim frm As New frm_RecepcionCustodiasATMs
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub MovimientosInternosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosInternosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: MOVIMIENTOS INTERNOS (CUSTODIAS)")

        Dim frm As New frm_MovInt_Custodias
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub CambiarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarClienteToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR CLIENTE A SERVICIO")

        Dim frm As New frm_CambiarCliente
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub CancelarEnvioAProcesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioAProcesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO A PROCESO")

        Dim frm As New frm_CancelarEnvioProceso2 '6/julio/2012
        frm.Depto = "P"
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CancelarEnvioACajerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioACajerosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO A CAJEROS")

        Dim frm As New frm_CancelarEnvioCajeros
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CancelarEnvioAAuditoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvioAAuditoriaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO A AUDITORIA")

        Dim frm As New frm_CancelarEnvioAuditoria
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ReportarFallaEnEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnEquipoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN EQUIPO")

        Dim frm As New frm_ReporteFallas
        frm.ShowDialog()
    End Sub

    Private Sub ReportarFallaEnSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnSistemaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLAS EN SISTEMA")

        Dim frm As New frm_ReporteFallasS
        frm.ShowDialog()
    End Sub

    Private Sub ActualizacionesInstaladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionesInstaladasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSLTA DE ACTUALIZACIONES INSTALADAS")

        FuncionesGlobales.MostrarVentana(frm_ActualizacionesConsultar)
    End Sub

    Private Sub CancelarDespachoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarDespachoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR DESPACHO")

        Dim frm As New frm_CancelarDespacho
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AcercaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACERCA DE")

        Dim frm As New frm_About
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub SeguimientoAFallasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAFallasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SEGUIMIENTO A FALLAS")

        Dim frm As New frm_ReporteFallasConsultar
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ComprobarRemisiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprobarRemisiónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: COMPROBAR REMISION")

        Dim frm As New frm_ComprobarRemisiones
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub AnomalíasEnEnvasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomalíasEnEnvasesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ANOMALIAS EN ENVASES")

        Dim frm As New frm_ActaRemision
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeAperturasYCierresDeBóvedasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAperturasYCierresDeBóvedasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE APERTURAS Y CIERRES DE BOVEDAS")

        Dim frm As New frm_ConsultaAperturasCierres
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeActasDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeActasDeToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ACTAS DE ANOMALIAS EN REMISIONES")

        Dim frm As New frm_ConsultaActasAnomalias
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub PernoctasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PernoctasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PERNOCTAS")

        Dim frm As New frm_Pernoctas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ConsultaDeAlertasGeneradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlertasGeneradasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ALERTAS GENERADAS")

        Dim frm As New frm_AlertasConsultas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub SolicitudDeEquipoServicioYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeEquipoServicioYOtrosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SOLICITUD DE EQUIPO, SERVICIO Y OTROS")

        Dim frm As New frm_ReporteFallasI
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        Call InstallUpdateSyncWithInfo()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        SegundosDesconexion = 0
        Dim info As UpdateCheckInfo = Nothing
        Me.Cursor = Cursors.WaitCursor
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                Me.Cursor = Cursors.Default
                MsgBox("La actualización no se puede descargar en este momento. " + Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            Catch ioe As InvalidOperationException
                Me.Cursor = Cursors.Default
                MsgBox("Esta no es una Aplicacion ClickOnce. No se puede actualizar. Error: " & ioe.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Me.Cursor = Cursors.Default
                    Dim dr As DialogResult = MsgBox("Está disponible la nueva versión " & info.AvailableVersion.ToString & ". Desea Instalarla Ahora?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MsgBox("El Sistema ha detectado una actualización marcada como obligatoria. La versión mínima requerida es " & _
                        info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la Actualización y se reiniciará el Sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
                End If
                Me.Cursor = Cursors.WaitCursor
                If (doUpdate) Then
                    Try
                        AD.Update()
                        Me.Cursor = Cursors.Default
                        MsgBox("La Actualización se instaló correctamente, El Sistema se reiniciará.", MsgBoxStyle.Exclamation, Me.Text)
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo instalar la Actualziación. " & Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.Text)
                        Return
                    End Try
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se encontraron Actualizaciones Disponibles.", MsgBoxStyle.Information, Me.Text)
            End If
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Esta no es una aplicación ClickOnce Válida.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

    Private Sub ConsultaDeDespachosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeDespachosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE DESPACHOS")

        Dim frm As New frm_DespachosConsulta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub DescargarManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarManualDeUsuarioToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_DescargarArchivo
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaRemisionesRechazadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaRemisionesRechazadasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE REMISIONES RECHAZADAS")

        Dim frm As New frm_CosultaRemisionRechazada
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CatálogoDeBóvedasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeBóvedasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE BOVEDAS")
        Dim frm As New frm_Bovedas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub VitacoraCambiosDeRutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VitacoraCambiosDeRutaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BITACORA DE CAMBIOS DE RUTA")
        Dim frm As New Frm_BitacoraCambiosRuta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CambiarServiciosDeBovedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarServiciosDeBovedaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR SERVICIOS DE BOVEDA")
        Dim frm As New frm_CambioServiciosBoveda
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub EnviarServiciosAMorrallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarServiciosAMorrallaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR SERVICIOS A MORRALLA")

        Dim frm As New frm_AsignarProceso
        frm.Destino = "M"
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub CancelarEnvíoAMorrallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarEnvíoAMorrallaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CANCELAR ENVIO A MORRALLA")

        Dim frm As New frm_CancelarEnvioProceso2
        frm.Depto = "M"
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub AdmistracionDeCartuchosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmistracionDeCartuchosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ADMINISTRACION CARTUCHOS")

        Dim frm As New frm_Kardex
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

  

    Private Sub AsignarCasetARutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarCasetARutaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR CASET A RUTA")
        Dim frm As New frm_AsignarCasetRuta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub RecepcionDeCasetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionDeCasetToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECEPCION DE CASET")
        Dim frm As New frm_RecepcionCasetRuta
        FuncionesGlobales.MostrarVentana(frm)
    End Sub


    Private Sub ReasignacionDeCassettesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReasignacionDeCassettesToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR CASET A CLIENTE")
        Dim frm As New frm_CasetAsignaCliente
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultarRemisionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarRemisionToolStripMenuItem.Click
        Dim frm As New frm_ConsultaRemision
        frm.Show()
    End Sub

    Private Sub ConsultaDeDespachosCanceladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeDespachosCanceladosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BITACORA DE CAMBIOS DE RUTA")
        Dim frm As New frm_DespachosCancelados
        FuncionesGlobales.MostrarVentana(frm)
    End Sub
End Class
