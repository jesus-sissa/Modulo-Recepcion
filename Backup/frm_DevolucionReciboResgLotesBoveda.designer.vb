<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DevolucionReciboResgLotesBoveda
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
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Devolucion = New System.Windows.Forms.Button
        Me.gbx_Resguardos = New System.Windows.Forms.GroupBox
        Me.lsv_Resguardos = New Modulo_Recepcion.cp_Listview
        Me.lsv_ResguardosT = New Modulo_Recepcion.cp_Listview
        Me.grp_Devolucion = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Resguardos.SuspendLayout()
        Me.grp_Devolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(552, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Devolucion
        '
        Me.btn_Devolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Devolucion.Enabled = False
        Me.btn_Devolucion.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Devolucion.Location = New System.Drawing.Point(6, 13)
        Me.btn_Devolucion.Name = "btn_Devolucion"
        Me.btn_Devolucion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Devolucion.TabIndex = 0
        Me.btn_Devolucion.Text = "&Devolución"
        Me.btn_Devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Devolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Devolucion.UseVisualStyleBackColor = True
        '
        'gbx_Resguardos
        '
        Me.gbx_Resguardos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Resguardos.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Resguardos.Controls.Add(Me.btn_Devolucion)
        Me.gbx_Resguardos.Location = New System.Drawing.Point(8, 476)
        Me.gbx_Resguardos.Name = "gbx_Resguardos"
        Me.gbx_Resguardos.Size = New System.Drawing.Size(698, 50)
        Me.gbx_Resguardos.TabIndex = 1
        Me.gbx_Resguardos.TabStop = False
        '
        'lsv_Resguardos
        '
        Me.lsv_Resguardos.AllowColumnReorder = True
        Me.lsv_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Resguardos.FullRowSelect = True
        Me.lsv_Resguardos.HideSelection = False
        Me.lsv_Resguardos.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Resguardos.Lvs = ListViewColumnSorter1
        Me.lsv_Resguardos.MultiSelect = False
        Me.lsv_Resguardos.Name = "lsv_Resguardos"
        Me.lsv_Resguardos.Row1 = 10
        Me.lsv_Resguardos.Row10 = 0
        Me.lsv_Resguardos.Row2 = 10
        Me.lsv_Resguardos.Row3 = 10
        Me.lsv_Resguardos.Row4 = 10
        Me.lsv_Resguardos.Row5 = 10
        Me.lsv_Resguardos.Row6 = 0
        Me.lsv_Resguardos.Row7 = 0
        Me.lsv_Resguardos.Row8 = 0
        Me.lsv_Resguardos.Row9 = 0
        Me.lsv_Resguardos.Size = New System.Drawing.Size(686, 323)
        Me.lsv_Resguardos.TabIndex = 0
        Me.lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'lsv_ResguardosT
        '
        Me.lsv_ResguardosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ResguardosT.FullRowSelect = True
        Me.lsv_ResguardosT.HideSelection = False
        Me.lsv_ResguardosT.Location = New System.Drawing.Point(6, 363)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ResguardosT.Lvs = ListViewColumnSorter2
        Me.lsv_ResguardosT.MultiSelect = False
        Me.lsv_ResguardosT.Name = "lsv_ResguardosT"
        Me.lsv_ResguardosT.Row1 = 10
        Me.lsv_ResguardosT.Row10 = 10
        Me.lsv_ResguardosT.Row2 = 10
        Me.lsv_ResguardosT.Row3 = 10
        Me.lsv_ResguardosT.Row4 = 10
        Me.lsv_ResguardosT.Row5 = 10
        Me.lsv_ResguardosT.Row6 = 10
        Me.lsv_ResguardosT.Row7 = 10
        Me.lsv_ResguardosT.Row8 = 10
        Me.lsv_ResguardosT.Row9 = 10
        Me.lsv_ResguardosT.Size = New System.Drawing.Size(686, 99)
        Me.lsv_ResguardosT.TabIndex = 1
        Me.lsv_ResguardosT.UseCompatibleStateImageBehavior = False
        Me.lsv_ResguardosT.View = System.Windows.Forms.View.Details
        '
        'grp_Devolucion
        '
        Me.grp_Devolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Devolucion.Controls.Add(Me.Lbl_Registros)
        Me.grp_Devolucion.Controls.Add(Me.lsv_Resguardos)
        Me.grp_Devolucion.Controls.Add(Me.lsv_ResguardosT)
        Me.grp_Devolucion.Location = New System.Drawing.Point(8, 2)
        Me.grp_Devolucion.Name = "grp_Devolucion"
        Me.grp_Devolucion.Size = New System.Drawing.Size(698, 468)
        Me.grp_Devolucion.TabIndex = 0
        Me.grp_Devolucion.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(552, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 10
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_DevolucionReciboResgLotesBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 538)
        Me.Controls.Add(Me.gbx_Resguardos)
        Me.Controls.Add(Me.grp_Devolucion)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(730, 577)
        Me.Name = "frm_DevolucionReciboResgLotesBoveda"
        Me.Text = "Devolución Resguardos"
        Me.gbx_Resguardos.ResumeLayout(False)
        Me.grp_Devolucion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Resguardos As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Devolucion As System.Windows.Forms.Button
    Friend WithEvents gbx_Resguardos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_ResguardosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents grp_Devolucion As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
