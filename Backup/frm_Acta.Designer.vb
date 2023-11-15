<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Acta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crv_Acta = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv_Acta
        '
        Me.crv_Acta.ActiveViewIndex = -1
        Me.crv_Acta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Acta.DisplayGroupTree = False
        Me.crv_Acta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv_Acta.Location = New System.Drawing.Point(0, 0)
        Me.crv_Acta.Name = "crv_Acta"
        Me.crv_Acta.SelectionFormula = ""
        Me.crv_Acta.ShowExportButton = False
        Me.crv_Acta.ShowGroupTreeButton = False
        Me.crv_Acta.Size = New System.Drawing.Size(784, 561)
        Me.crv_Acta.TabIndex = 0
        Me.crv_Acta.ViewTimeSelectionFormula = ""
        '
        'frm_Acta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.crv_Acta)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Acta"
        Me.Text = "Acta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv_Acta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Imprimir As ToolStripButton
End Class
