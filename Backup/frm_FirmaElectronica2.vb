Imports System.Web.Security

Public Class frm_FirmaElectronica2
    Public Empleado As Integer = 0
    Public Bloquear As Boolean = False
    Public Firma As Boolean = False
    Private Veces As Integer = 0

    Private Sub frm_FirmaElectronica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bloquear = True Then
            tbx_Empleado.Text = Empleado
            tbx_Empleado.Enabled = False
            tbx_Contraseña.Focus()
        Else
            tbx_Empleado.Text = ""
            tbx_Empleado.Enabled = True
            tbx_Empleado.Focus()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Firma = False
        Me.Close()
    End Sub

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        If tbx_Empleado.Text.Trim = tbx_UsuarioSeg.Text.Trim Then
            MsgBox("El Usuario de Bóveda y el Usuario de Seguridad deben ser diferentes.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Empleado.SelectAll()
            tbx_Empleado.Focus()
            Exit Sub
        End If

        If Validar(tbx_Empleado.Text.Trim, tbx_Contraseña.Text.Trim) = True Then
            If Validar(tbx_UsuarioSeg.Text.Trim, tbx_ContraseñaSeg.Text.Trim) = True Then
                Firma = True
                Me.Close()
            Else
                Firma = False
                tbx_ContraseñaSeg.Focus()
            End If
        Else
            tbx_Contraseña.Focus()
            Firma = False
        End If

    End Sub

    Private Function Validar(ByVal Usuario As String, ByVal Pass As String) As Boolean

        Dim Contra As String = Pass
        tbx_Contraseña.Text = ""
        If Trim(usuario) = "" Then
            MsgBox("Indique el ID de Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(usuario, FuncionesGlobales.Validar_Cadena.Numeros_Enteros) Then
            MsgBox("'" & Usuario & "', No es un ID de Empelado válido.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Contra = "" Then
            MsgBox("Indique la Contraseña.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        If Not FuncionesGlobales.fn_Valida_Cadena(Contra, FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar) Then
            MsgBox("Indique una Contraseña válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End If
        Veces = Veces + 1
        If Veces > Intentos_Login Then
            ResP = Cn_Login.Usuarios_Bloquear(Integer.Parse(Usuario.Trim))
            If ResP > 0 Then
                MsgBox("Usted ha sido Bloqueado por exceder los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Veces = 0
                Return False
            Else
                MsgBox("Usted ha excedido los Intentos de Entrada.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
        End If
        Dim DT As DataTable = Cn_Login.Usuarios_Read(Integer.Parse(usuario.Trim))
        If DT.Rows.Count = 0 Then
            MsgBox("Usuario no encontrado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        Else
            ContraHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Contra, "SHA1")
            If DT.Rows(0)("Password") <> ContraHash Then
                MsgBox("Usuario o Contraseña Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Return False
            ElseIf DT.Rows(0)("Status") <> "A" Then
                MsgBox("Usuario Bloqueado. Imposible Entrar al Sistema. Consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Contraseña.Focus()
                Return False
            ElseIf DT.Rows(0)("Dias_Expira") < 1 Then
                MsgBox("La Contraseña está expirada. Pro favor capture una nueva.", MsgBoxStyle.Critical, frm_MENU.Text)
                DT.Dispose()
                tbx_Contraseña.Focus()
                Return False
            Else
                If UsuarioTipo = 1 Then
                    Return True
                Else
                    Return True
                End If
                Veces = 0
            End If
        End If
    End Function

    Private Sub tbx_Contraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Contraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_UsuarioSeg.Focus()
        End If
    End Sub

    Private Sub tbx_ContraseñaSeg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_ContraseñaSeg.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_Validar.Focus()
        End If
    End Sub

End Class