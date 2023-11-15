<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PuntosAgregarRemision
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
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.gbx_Puntos = New System.Windows.Forms.GroupBox
        Me.lbl_SeleccionarRuta = New System.Windows.Forms.Label
        Me.Lbl_RegistrosPuntos = New System.Windows.Forms.Label
        Me.lsv_Puntos = New Modulo_Recepcion.cp_Listview
        Me.grp_Controles = New System.Windows.Forms.GroupBox
        Me.btn_CapturaRemision = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Puntos.SuspendLayout()
        Me.grp_Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Puntos
        '
        Me.gbx_Puntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Puntos.Controls.Add(Me.lbl_SeleccionarRuta)
        Me.gbx_Puntos.Controls.Add(Me.Lbl_RegistrosPuntos)
        Me.gbx_Puntos.Controls.Add(Me.lsv_Puntos)
        Me.gbx_Puntos.Location = New System.Drawing.Point(6, 5)
        Me.gbx_Puntos.Name = "gbx_Puntos"
        Me.gbx_Puntos.Size = New System.Drawing.Size(765, 372)
        Me.gbx_Puntos.TabIndex = 0
        Me.gbx_Puntos.TabStop = False
        '
        'lbl_SeleccionarRuta
        '
        Me.lbl_SeleccionarRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SeleccionarRuta.Location = New System.Drawing.Point(6, 14)
        Me.lbl_SeleccionarRuta.Name = "lbl_SeleccionarRuta"
        Me.lbl_SeleccionarRuta.Size = New System.Drawing.Size(476, 17)
        Me.lbl_SeleccionarRuta.TabIndex = 9
        Me.lbl_SeleccionarRuta.Text = "Seleccione el Punto al cual desea agregar una Remisión."
        '
        'Lbl_RegistrosPuntos
        '
        Me.Lbl_RegistrosPuntos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosPuntos.Location = New System.Drawing.Point(581, 12)
        Me.Lbl_RegistrosPuntos.Name = "Lbl_RegistrosPuntos"
        Me.Lbl_RegistrosPuntos.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosPuntos.TabIndex = 8
        Me.Lbl_RegistrosPuntos.Text = "Registros: 0"
        Me.Lbl_RegistrosPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Puntos
        '
        Me.lsv_Puntos.AllowColumnReorder = True
        Me.lsv_Puntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Puntos.FullRowSelect = True
        Me.lsv_Puntos.HideSelection = False
        Me.lsv_Puntos.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Puntos.Lvs = ListViewColumnSorter1
        Me.lsv_Puntos.MultiSelect = False
        Me.lsv_Puntos.Name = "lsv_Puntos"
        Me.lsv_Puntos.Row1 = 43
        Me.lsv_Puntos.Row10 = 0
        Me.lsv_Puntos.Row2 = 43
        Me.lsv_Puntos.Row3 = 12
        Me.lsv_Puntos.Row4 = 0
        Me.lsv_Puntos.Row5 = 0
        Me.lsv_Puntos.Row6 = 0
        Me.lsv_Puntos.Row7 = 0
        Me.lsv_Puntos.Row8 = 0
        Me.lsv_Puntos.Row9 = 0
        Me.lsv_Puntos.Size = New System.Drawing.Size(749, 326)
        Me.lsv_Puntos.TabIndex = 1
        Me.lsv_Puntos.UseCompatibleStateImageBehavior = False
        Me.lsv_Puntos.View = System.Windows.Forms.View.Details
        '
        'grp_Controles
        '
        Me.grp_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Controles.Controls.Add(Me.btn_CapturaRemision)
        Me.grp_Controles.Controls.Add(Me.btn_Cerrar)
        Me.grp_Controles.Location = New System.Drawing.Point(6, 379)
        Me.grp_Controles.Name = "grp_Controles"
        Me.grp_Controles.Size = New System.Drawing.Size(765, 51)
        Me.grp_Controles.TabIndex = 3
        Me.grp_Controles.TabStop = False
        '
        'btn_CapturaRemision
        '
        Me.btn_CapturaRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CapturaRemision.Enabled = False
        Me.btn_CapturaRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.Remision
        Me.btn_CapturaRemision.Location = New System.Drawing.Point(6, 15)
        Me.btn_CapturaRemision.Name = "btn_CapturaRemision"
        Me.btn_CapturaRemision.Size = New System.Drawing.Size(142, 30)
        Me.btn_CapturaRemision.TabIndex = 6
        Me.btn_CapturaRemision.Text = "&Agregar Remisión (F3)"
        Me.btn_CapturaRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CapturaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CapturaRemision.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(619, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar (Esc)"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_PuntosAgregarRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 436)
        Me.Controls.Add(Me.grp_Controles)
        Me.Controls.Add(Me.gbx_Puntos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PuntosAgregarRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Remisiones a los Puntos"
        Me.gbx_Puntos.ResumeLayout(False)
        Me.grp_Controles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Puntos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Puntos As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_RegistrosPuntos As System.Windows.Forms.Label
    Friend WithEvents grp_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_CapturaRemision As System.Windows.Forms.Button
    Friend WithEvents lbl_SeleccionarRuta As System.Windows.Forms.Label
End Class
