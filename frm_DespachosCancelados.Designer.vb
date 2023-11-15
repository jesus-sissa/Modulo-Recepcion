<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DespachosCancelados
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
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.gbx_Totales = New System.Windows.Forms.GroupBox()
        Me.Lbl_RegistrosR = New System.Windows.Forms.Label()
        Me.lsv_Detalle = New Modulo_Recepcion.cp_Listview()
        Me.gbx_Lista = New System.Windows.Forms.GroupBox()
        Me.lbl_RegistrosD = New System.Windows.Forms.Label()
        Me.lsv_Despachos = New Modulo_Recepcion.cp_Listview()
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.Cmb_Depto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Totales.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.gbx_Parametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 603)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(912, 50)
        Me.gbx_Botones.TabIndex = 8
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 2
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'gbx_Totales
        '
        Me.gbx_Totales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Totales.Controls.Add(Me.Lbl_RegistrosR)
        Me.gbx_Totales.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Totales.Location = New System.Drawing.Point(12, 397)
        Me.gbx_Totales.Name = "gbx_Totales"
        Me.gbx_Totales.Size = New System.Drawing.Size(912, 200)
        Me.gbx_Totales.TabIndex = 7
        Me.gbx_Totales.TabStop = False
        Me.gbx_Totales.Text = "Remisiones"
        '
        'Lbl_RegistrosR
        '
        Me.Lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosR.Location = New System.Drawing.Point(771, 16)
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
        Me.lsv_Detalle.Row1 = 15
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 35
        Me.lsv_Detalle.Row3 = 15
        Me.lsv_Detalle.Row4 = 15
        Me.lsv_Detalle.Row5 = 0
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(895, 160)
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
        Me.gbx_Lista.Controls.Add(Me.lsv_Despachos)
        Me.gbx_Lista.Location = New System.Drawing.Point(12, 94)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(912, 297)
        Me.gbx_Lista.TabIndex = 6
        Me.gbx_Lista.TabStop = False
        Me.gbx_Lista.Text = "Despachos"
        '
        'lbl_RegistrosD
        '
        Me.lbl_RegistrosD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosD.Location = New System.Drawing.Point(771, 16)
        Me.lbl_RegistrosD.Name = "lbl_RegistrosD"
        Me.lbl_RegistrosD.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosD.TabIndex = 10
        Me.lbl_RegistrosD.Text = "Registros: 0"
        Me.lbl_RegistrosD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Despachos
        '
        Me.lsv_Despachos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Despachos.FullRowSelect = True
        Me.lsv_Despachos.HideSelection = False
        Me.lsv_Despachos.Location = New System.Drawing.Point(3, 34)
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
        Me.lsv_Despachos.Size = New System.Drawing.Size(906, 257)
        Me.lsv_Despachos.TabIndex = 4
        Me.lsv_Despachos.UseCompatibleStateImageBehavior = False
        Me.lsv_Despachos.View = System.Windows.Forms.View.Details
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.Label1)
        Me.gbx_Parametros.Controls.Add(Me.Cmb_Depto)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Parametros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Parametros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Parametros.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(912, 76)
        Me.gbx_Parametros.TabIndex = 9
        Me.gbx_Parametros.TabStop = False
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(205, 19)
        Me.dtp_Hasta.MinDate = New Date(2009, 8, 13, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(50, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow2
        Me.btn_Mostrar.Location = New System.Drawing.Point(318, 14)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(136, 30)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(6, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(164, 23)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'Cmb_Depto
        '
        Me.Cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Depto.FormattingEnabled = True
        Me.Cmb_Depto.Items.AddRange(New Object() {"PROCESO ", "MORRALLA", "TODOS"})
        Me.Cmb_Depto.Location = New System.Drawing.Point(51, 49)
        Me.Cmb_Depto.Name = "Cmb_Depto"
        Me.Cmb_Depto.Size = New System.Drawing.Size(94, 21)
        Me.Cmb_Depto.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Depto."
        '
        'frm_DespachosCancelados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 673)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Totales)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Name = "frm_DespachosCancelados"
        Me.Text = "frm_DespachosCancelados"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Totales.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbx_Botones As GroupBox
    Friend WithEvents gbx_Totales As GroupBox
    Friend WithEvents Lbl_RegistrosR As Label
    Friend WithEvents lsv_Detalle As cp_Listview
    Friend WithEvents gbx_Lista As GroupBox
    Friend WithEvents lbl_RegistrosD As Label
    Friend WithEvents lsv_Despachos As cp_Listview
    Friend WithEvents gbx_Parametros As GroupBox
    Friend WithEvents dtp_Hasta As DateTimePicker
    Friend WithEvents dtp_Desde As DateTimePicker
    Friend WithEvents btn_Mostrar As Button
    Friend WithEvents lbl_Desde As Label
    Friend WithEvents lbl_Hasta As Label
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Depto As ComboBox
End Class
