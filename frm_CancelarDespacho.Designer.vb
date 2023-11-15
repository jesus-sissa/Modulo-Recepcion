<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelarDespacho
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
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Me.gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.gbx_Totales = New System.Windows.Forms.GroupBox()
        Me.Lbl_RegistrosR = New System.Windows.Forms.Label()
        Me.lsv_Detalle = New Modulo_Recepcion.cp_Listview()
        Me.gbx_Lista = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosD = New System.Windows.Forms.Label()
        Me.Lbl_DespachosFin = New System.Windows.Forms.Label()
        Me.Tbx_Azul = New System.Windows.Forms.TextBox()
        Me.rdb_Todos = New System.Windows.Forms.RadioButton()
        Me.rdb_Externos = New System.Windows.Forms.RadioButton()
        Me.rdb_Internos = New System.Windows.Forms.RadioButton()
        Me.Lbl_Nota = New System.Windows.Forms.Label()
        Me.lsv_Despachos = New Modulo_Recepcion.cp_Listview()
        Me.Btn_Individual = New System.Windows.Forms.Button()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Totales.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_Individual)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "C&ancelar lote"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_Totales
        '
        Me.gbx_Totales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Totales.Controls.Add(Me.Lbl_RegistrosR)
        Me.gbx_Totales.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Totales.Location = New System.Drawing.Point(9, 293)
        Me.gbx_Totales.Name = "gbx_Totales"
        Me.gbx_Totales.Size = New System.Drawing.Size(767, 200)
        Me.gbx_Totales.TabIndex = 1
        Me.gbx_Totales.TabStop = False
        Me.gbx_Totales.Text = "Remisiones"
        '
        'Lbl_RegistrosR
        '
        Me.Lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosR.Location = New System.Drawing.Point(626, 16)
        Me.Lbl_RegistrosR.Name = "Lbl_RegistrosR"
        Me.Lbl_RegistrosR.Size = New System.Drawing.Size(135, 15)
        Me.Lbl_RegistrosR.TabIndex = 10
        Me.Lbl_RegistrosR.Text = "Registros: 0"
        Me.Lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(9, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter1
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 10
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 20
        Me.lsv_Detalle.Row3 = 20
        Me.lsv_Detalle.Row4 = 10
        Me.lsv_Detalle.Row5 = 10
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(750, 160)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.lbl_RegistrosD)
        Me.gbx_Lista.Controls.Add(Me.Lbl_DespachosFin)
        Me.gbx_Lista.Controls.Add(Me.Tbx_Azul)
        Me.gbx_Lista.Controls.Add(Me.rdb_Todos)
        Me.gbx_Lista.Controls.Add(Me.rdb_Externos)
        Me.gbx_Lista.Controls.Add(Me.rdb_Internos)
        Me.gbx_Lista.Controls.Add(Me.Lbl_Nota)
        Me.gbx_Lista.Controls.Add(Me.lsv_Despachos)
        Me.gbx_Lista.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(767, 285)
        Me.gbx_Lista.TabIndex = 0
        Me.gbx_Lista.TabStop = False
        Me.gbx_Lista.Text = "Despachos"
        '
        'lbl_RegistrosD
        '
        Me.lbl_RegistrosD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosD.Location = New System.Drawing.Point(626, 63)
        Me.lbl_RegistrosD.Name = "lbl_RegistrosD"
        Me.lbl_RegistrosD.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosD.TabIndex = 10
        Me.lbl_RegistrosD.Text = "Registros: 0"
        Me.lbl_RegistrosD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_DespachosFin
        '
        Me.Lbl_DespachosFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DespachosFin.AutoSize = True
        Me.Lbl_DespachosFin.Location = New System.Drawing.Point(642, 45)
        Me.Lbl_DespachosFin.Name = "Lbl_DespachosFin"
        Me.Lbl_DespachosFin.Size = New System.Drawing.Size(117, 13)
        Me.Lbl_DespachosFin.TabIndex = 6
        Me.Lbl_DespachosFin.Text = "Despachos por finalizar"
        '
        'Tbx_Azul
        '
        Me.Tbx_Azul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbx_Azul.BackColor = System.Drawing.Color.Blue
        Me.Tbx_Azul.Location = New System.Drawing.Point(621, 45)
        Me.Tbx_Azul.Multiline = True
        Me.Tbx_Azul.Name = "Tbx_Azul"
        Me.Tbx_Azul.Size = New System.Drawing.Size(15, 15)
        Me.Tbx_Azul.TabIndex = 5
        Me.Tbx_Azul.TabStop = False
        '
        'rdb_Todos
        '
        Me.rdb_Todos.AutoSize = True
        Me.rdb_Todos.Location = New System.Drawing.Point(415, 19)
        Me.rdb_Todos.Name = "rdb_Todos"
        Me.rdb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rdb_Todos.TabIndex = 2
        Me.rdb_Todos.TabStop = True
        Me.rdb_Todos.Text = "Todos"
        Me.rdb_Todos.UseVisualStyleBackColor = True
        '
        'rdb_Externos
        '
        Me.rdb_Externos.AutoSize = True
        Me.rdb_Externos.Location = New System.Drawing.Point(267, 19)
        Me.rdb_Externos.Name = "rdb_Externos"
        Me.rdb_Externos.Size = New System.Drawing.Size(123, 17)
        Me.rdb_Externos.TabIndex = 1
        Me.rdb_Externos.TabStop = True
        Me.rdb_Externos.Text = "Despachos Externos"
        Me.rdb_Externos.UseVisualStyleBackColor = True
        '
        'rdb_Internos
        '
        Me.rdb_Internos.AutoSize = True
        Me.rdb_Internos.Location = New System.Drawing.Point(119, 19)
        Me.rdb_Internos.Name = "rdb_Internos"
        Me.rdb_Internos.Size = New System.Drawing.Size(120, 17)
        Me.rdb_Internos.TabIndex = 0
        Me.rdb_Internos.TabStop = True
        Me.rdb_Internos.Text = "Despachos Internos"
        Me.rdb_Internos.UseVisualStyleBackColor = True
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(6, 48)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(273, 13)
        Me.Lbl_Nota.TabIndex = 3
        Me.Lbl_Nota.Text = "NOTA: Solo se muestran Despachos de la Fecha Actual"
        '
        'lsv_Despachos
        '
        Me.lsv_Despachos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Despachos.FullRowSelect = True
        Me.lsv_Despachos.HideSelection = False
        Me.lsv_Despachos.Location = New System.Drawing.Point(3, 81)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Despachos.Lvs = ListViewColumnSorter2
        Me.lsv_Despachos.MultiSelect = False
        Me.lsv_Despachos.Name = "lsv_Despachos"
        Me.lsv_Despachos.Row1 = 6
        Me.lsv_Despachos.Row10 = 0
        Me.lsv_Despachos.Row2 = 6
        Me.lsv_Despachos.Row3 = 10
        Me.lsv_Despachos.Row4 = 20
        Me.lsv_Despachos.Row5 = 20
        Me.lsv_Despachos.Row6 = 7
        Me.lsv_Despachos.Row7 = 7
        Me.lsv_Despachos.Row8 = 8
        Me.lsv_Despachos.Row9 = 8
        Me.lsv_Despachos.Size = New System.Drawing.Size(761, 198)
        Me.lsv_Despachos.TabIndex = 4
        Me.lsv_Despachos.UseCompatibleStateImageBehavior = False
        Me.lsv_Despachos.View = System.Windows.Forms.View.Details
        '
        'Btn_Individual
        '
        Me.Btn_Individual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Individual.Enabled = False
        Me.Btn_Individual.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cancelar
        Me.Btn_Individual.Location = New System.Drawing.Point(161, 13)
        Me.Btn_Individual.Name = "Btn_Individual"
        Me.Btn_Individual.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Individual.TabIndex = 2
        Me.Btn_Individual.Text = "Cancelar individual"
        Me.Btn_Individual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Individual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Individual.UseVisualStyleBackColor = True
        '
        'frm_CancelarDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Totales)
        Me.Controls.Add(Me.gbx_Lista)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CancelarDespacho"
        Me.Text = "Cancelar Despacho"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Totales.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Lista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents gbx_Totales As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Despachos As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents rdb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Externos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Internos As System.Windows.Forms.RadioButton
    Friend WithEvents Tbx_Azul As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_DespachosFin As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosD As System.Windows.Forms.Label
    Friend WithEvents Btn_Individual As Button
End Class
