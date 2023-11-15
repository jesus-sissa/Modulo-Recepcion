Imports CrystalDecisions

Public Class frm_Reporte
    Public Tipo As String = ""

    Private Sub frm_Reporte_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DialogResult = System.Windows.Forms.DialogResult.Cancel And TypeOf (crv.ReportSource) Is rpt_DespachoNuevo Then
            If MsgBox("ATENCIÓN: Si cierra la pantalla las Remisiones se quedarán en Bóveda y no le aparecerán a la Ruta." & Chr(13) & Chr(13) & " Desea cancelar el Despacho?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                DialogResult = System.Windows.Forms.DialogResult.No
                Me.Close()
                Cn_Login.fn_Log_Create("El Usuario decide cancelar el Despacho. Las Remisiones no aparecerán en la Ruta.")
            Else
                e.Cancel = True
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.Cancel And TypeOf (crv.ReportSource) Is rpt_ReporteCierre Then
            DialogResult = System.Windows.Forms.DialogResult.Yes
            If MsgBox("ATENCIÓN: El Reporte de Saldo de Bóveda es útil para verificar el contenido de la Bóveda al momento de la Apertura o Cierre. Si no se imprime no tendrá una referencia para cuadrar cundo se haga el próximo movimiento." & Chr(13) & Chr(13) & " Desea cancelar la impresión del Reporte?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                DialogResult = System.Windows.Forms.DialogResult.No
                Me.Close()
            Else
                e.Cancel = True
            End If
        ElseIf DialogResult = System.Windows.Forms.DialogResult.Cancel And TypeOf (crv.ReportSource) Is ListaDespacho Then
            If MsgBox("ATENCIÓN: El Reporte de lista de Remisiones y envases es util en caso que el movil falle. Si no se imprime no tendrá una referencia para relizar las entregas." & Chr(13) & Chr(13) & " Desea cancelar la impresión del Reporte?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
                DialogResult = System.Windows.Forms.DialogResult.No
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click

        If MsgBox("Se imprimió correctamente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
            DialogResult = System.Windows.Forms.DialogResult.Yes
            Me.Close()
        End If

    End Sub

    Private Sub crv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles crv.Load
        'Se crea un objeto en tiempo de ejecusión para detectar cuando se 
        'hace click sobre "Imprimir"
        Me.btn_Imprimir = CType(crv.Controls(4), ToolStrip).Items(0)
    End Sub

End Class