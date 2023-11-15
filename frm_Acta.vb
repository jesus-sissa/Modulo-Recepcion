Imports CrystalDecisions

Public Class frm_Acta

    Private Sub crv_Acta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crv_Acta.Load
        Me.btn_Imprimir = CType(crv_Acta.Controls(4), ToolStrip).Items(0)
    End Sub

    Private Sub frm_Acta_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult = System.Windows.Forms.DialogResult.Cancel And TypeOf (crv_Acta.ReportSource) Is rpt_ReporteCierre Then
            If MsgBox("ATENCIÓN: Es necesario imprimir el Reporte de Cierre para verificar el contenido de la Bóveda. Si no se imprime no se podrá realizar el Cierre." & Chr(13) & Chr(13) & " Desea cancelar la impresión del Reporte?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, frm_MENU.Text) = MsgBoxResult.Yes Then
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
End Class