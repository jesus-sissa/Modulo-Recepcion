﻿Imports System.Web.Security
Imports Modulo_Recepcion.cn_Recepcion

Public Class frm_FirmaElectronica
    Public Bloquear As Boolean = False
    Public Firma As Boolean = False
    Public PedirObservaciones As Boolean = False
    Public Observaciones As String = ""
    Public Max_Caracteres_Obs As Integer = 150
    Public Min_Caracteres_Obs As Integer = 10
    Private Veces As Integer = 0
    Public Empleado As Integer = 0
    Public CasetAutorizaValidar As Boolean = False
    Public CancelarDespachoValidar As Boolean = False
    Dim dt_EmpleadoAutoriza As DataTable
    Dim dt_EmpleadosCancelaDespacho As DataTable

    Private Sub frm_FirmaElectronica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Se comento por que ya no se utiliza

        'If CasetAutorizaValidar Then
        '    dt_EmpleadoAutoriza = fn_Kardex_CasetAutoriza_get()

        '    If dt_EmpleadoAutoriza Is Nothing Then
        '        MsgBox("Ocurrió un error al intentar consultar Empleado Autoriza", MsgBoxStyle.Critical, frm_MENU.Text)
        '        Exit Sub
        '    End If
        'End If

        If CancelarDespachoValidar Then
            dt_EmpleadosCancelaDespacho = fn_Lista_DespachosCancela_get()

            If dt_EmpleadosCancelaDespacho Is Nothing Then
                MsgBox("Ocurrió un error al intentar consultar Empleado Autoriza", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If



        If Bloquear Then
            tbx_Empleado.Text = UsuarioId
            tbx_Empleado.Enabled = False
            tbx_Contraseña.Focus()
        Else
            tbx_Empleado.Text = ""
            tbx_Empleado.Enabled = True
            tbx_Empleado.Focus()
        End If
        If PedirObservaciones Then rtb_Observaciones.Enabled = True
        rtb_Observaciones.Clear()
        gbx_Observaciones.Enabled = PedirObservaciones
        rtb_Observaciones.MaxLength = Max_Caracteres_Obs
        lbl_Maximo.Text = "Máximo " & Max_Caracteres_Obs & " caracteres."
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Firma = False
        Me.Close()
    End Sub

    Private Sub tbx_Contraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Contraseña.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = Keys.Enter Then
            If PedirObservaciones Then
                rtb_Observaciones.Focus()
            Else
                Call Validar()
            End If
        End If
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0
        Call Validar()
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        SegundosDesconexion = 0
        e.KeyChar = UCase(e.KeyChar)

        If Asc(e.KeyChar) = Keys.Enter Then
            Call Validar()
        End If
    End Sub

    Sub Validar()
        SegundosDesconexion = 0

        Dim Contra As String = tbx_Contraseña.Text.Trim
        'tbx_Contraseña.Text = ""
        If tbx_Empleado.Text.Trim = "" Then
            MsgBox("Indique el ID de Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Empleado.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(tbx_Empleado.Text.Trim, FuncionesGlobales.Validar_Cadena.Numeros_Enteros) Then
            MsgBox("'" & tbx_Empleado.Text.Trim & "', No es un ID de Usuario válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Empleado.Focus()
            Exit Sub
        End If
        If Contra = "" Then
            MsgBox("Indique la Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contraseña.Focus()
            Exit Sub
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(Contra, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            MsgBox("Indique una Contraseña válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Contraseña.Focus()
            Exit Sub
        End If
        If PedirObservaciones And rtb_Observaciones.Text.Length < Min_Caracteres_Obs Then
            MsgBox("Debe indicar Observaciones mas descriptivas.", MsgBoxStyle.Critical, frm_MENU.Text)
            rtb_Observaciones.Focus()
            Exit Sub
        End If

        'Se comento por que ya no se usa JROO

        'If CasetAutorizaValidar Then
        '    For Each row As DataRow In dt_EmpleadoAutoriza.Rows
        '        If Not CInt(row("Id_Empleado")) = CInt(tbx_Empleado.Text) Then
        '            MsgBox("Empleado no Autorizado para realizar recepción de CASSET.", MsgBoxStyle.Critical, frm_MENU.Text)
        '            Exit Sub
        '        End If
        '    Next
        'End If

        'Valida que el empleado que se firma este autorizado para cancelar despachos. JROO
        If CancelarDespachoValidar Then
            Dim Continuar As Boolean = False
            For Each row As DataRow In dt_EmpleadosCancelaDespacho.Rows
                If CInt(row("Id_Empleado")) = CInt(tbx_Empleado.Text) AndAlso row("Status") = "ACTIVO" Then
                    Continuar = True
                    Exit For
                End If
            Next
            If Not Continuar Then
                MsgBox("Empleado no autorizado para cancelar despacho.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        Veces = Veces + 1
        If Veces > Intentos_Login Then
            ResP = Cn_Login.Usuarios_Bloquear(Integer.Parse(tbx_Empleado.Text.Trim))
            If ResP > 0 Then
                MsgBox("Usted ha sido Bloqueado por exceder los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Veces = 0
                Exit Sub
            Else
                MsgBox("Usted ha excedido los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        Dim DT As DataTable = Cn_Login.Usuarios_Read(Integer.Parse(tbx_Empleado.Text.Trim))
        If DT.Rows.Count = 0 Then
            MsgBox("Usuario no encontrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            ContraHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Contra, "SHA1")
            If DT.Rows(0)("Password") <> ContraHash Then
                DT.Dispose()
                MsgBox("Usuario o Contraseña Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Exit Sub
            ElseIf DT.Rows(0)("Dias_Expira") < 1 Then
                DT.Dispose()
                MsgBox("La Contraseña está expirada.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Exit Sub
            ElseIf DT.Rows(0)("Status") <> "A" Then
                DT.Dispose()
                MsgBox("Usuario Bloqueado. Imposible Entrar al Sistema. Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Exit Sub
            Else
                Firma = True
                Veces = 0
                Empleado = tbx_Empleado.Text.Trim
            End If
        End If
        Observaciones = rtb_Observaciones.Text.Trim
        SegundosDesconexion = 0
        Me.Close()
    End Sub

End Class