<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reporte
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
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.EnableToolTips = False
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.ShowCloseButton = False
        Me.crv.ShowExportButton = False
        Me.crv.ShowGotoPageButton = False
        Me.crv.ShowGroupTreeButton = False
        Me.crv.ShowRefreshButton = False
        Me.crv.ShowTextSearchButton = False
        Me.crv.Size = New System.Drawing.Size(784, 562)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'frm_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.crv)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Reporte"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Imprimir As ToolStripButton
End Class
