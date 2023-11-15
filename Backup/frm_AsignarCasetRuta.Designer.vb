<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarCasetRuta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Casets = New System.Windows.Forms.GroupBox
        Me.dgv_Casets = New System.Windows.Forms.DataGridView
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.lbl_RegistroCaset = New System.Windows.Forms.Label
        Me.btn_Asignar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lbl_Scanear = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Rutas = New System.Windows.Forms.Label
        Me.gbx_CasetRuta = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Regsitros1 = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.tbx_Codigo = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveRuta = New Modulo_Recepcion.cp_Textbox
        Me.lsv_CasetAsignadoRuta = New Modulo_Recepcion.cp_Listview
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbx_Casets.SuspendLayout()
        CType(Me.dgv_Casets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_CasetRuta.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Casets)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Datos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_CasetRuta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_Registros)
        Me.SplitContainer1.Size = New System.Drawing.Size(1018, 729)
        Me.SplitContainer1.SplitterDistance = 516
        Me.SplitContainer1.TabIndex = 0
        '
        'gbx_Casets
        '
        Me.gbx_Casets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Casets.Controls.Add(Me.dgv_Casets)
        Me.gbx_Casets.Controls.Add(Me.lbl_RegistroCaset)
        Me.gbx_Casets.Controls.Add(Me.btn_Asignar)
        Me.gbx_Casets.Location = New System.Drawing.Point(3, 157)
        Me.gbx_Casets.Name = "gbx_Casets"
        Me.gbx_Casets.Size = New System.Drawing.Size(510, 569)
        Me.gbx_Casets.TabIndex = 12
        Me.gbx_Casets.TabStop = False
        '
        'dgv_Casets
        '
        Me.dgv_Casets.AllowUserToAddRows = False
        Me.dgv_Casets.AllowUserToDeleteRows = False
        Me.dgv_Casets.AllowUserToResizeColumns = False
        Me.dgv_Casets.AllowUserToResizeRows = False
        Me.dgv_Casets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Casets.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_Casets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Casets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Casets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Casets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Casets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Casets.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Casets.Location = New System.Drawing.Point(6, 48)
        Me.dgv_Casets.Name = "dgv_Casets"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Casets.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Casets.RowHeadersVisible = False
        Me.dgv_Casets.Size = New System.Drawing.Size(498, 466)
        Me.dgv_Casets.TabIndex = 8
        '
        'chk
        '
        Me.chk.HeaderText = ""
        Me.chk.Name = "chk"
        Me.chk.Width = 20
        '
        'lbl_RegistroCaset
        '
        Me.lbl_RegistroCaset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistroCaset.AutoSize = True
        Me.lbl_RegistroCaset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistroCaset.Location = New System.Drawing.Point(385, 24)
        Me.lbl_RegistroCaset.Name = "lbl_RegistroCaset"
        Me.lbl_RegistroCaset.Size = New System.Drawing.Size(75, 13)
        Me.lbl_RegistroCaset.TabIndex = 7
        Me.lbl_RegistroCaset.Text = "Registros: 0"
        '
        'btn_Asignar
        '
        Me.btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar.Location = New System.Drawing.Point(428, 537)
        Me.btn_Asignar.Name = "btn_Asignar"
        Me.btn_Asignar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Asignar.TabIndex = 6
        Me.btn_Asignar.Text = "Asignar"
        Me.btn_Asignar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.tbx_Codigo)
        Me.gbx_Datos.Controls.Add(Me.lbl_Scanear)
        Me.gbx_Datos.Controls.Add(Me.cmb_Rutas)
        Me.gbx_Datos.Controls.Add(Me.lbl_fecha)
        Me.gbx_Datos.Controls.Add(Me.tbx_CveRuta)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_Rutas)
        Me.gbx_Datos.Location = New System.Drawing.Point(3, 4)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(510, 147)
        Me.gbx_Datos.TabIndex = 10
        Me.gbx_Datos.TabStop = False
        '
        'lbl_Scanear
        '
        Me.lbl_Scanear.AutoSize = True
        Me.lbl_Scanear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Scanear.Location = New System.Drawing.Point(4, 90)
        Me.lbl_Scanear.Name = "lbl_Scanear"
        Me.lbl_Scanear.Size = New System.Drawing.Size(97, 13)
        Me.lbl_Scanear.TabIndex = 8
        Me.lbl_Scanear.Text = "Scanear Codigo"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(5, 15)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 5
        Me.lbl_fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(48, 11)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 6
        '
        'lbl_Rutas
        '
        Me.lbl_Rutas.AutoSize = True
        Me.lbl_Rutas.Location = New System.Drawing.Point(12, 38)
        Me.lbl_Rutas.Name = "lbl_Rutas"
        Me.lbl_Rutas.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Rutas.TabIndex = 7
        Me.lbl_Rutas.Text = "Ruta"
        '
        'gbx_CasetRuta
        '
        Me.gbx_CasetRuta.Controls.Add(Me.btn_Cerrar)
        Me.gbx_CasetRuta.Controls.Add(Me.lbl_Regsitros1)
        Me.gbx_CasetRuta.Controls.Add(Me.lsv_CasetAsignadoRuta)
        Me.gbx_CasetRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_CasetRuta.Location = New System.Drawing.Point(0, 0)
        Me.gbx_CasetRuta.Name = "gbx_CasetRuta"
        Me.gbx_CasetRuta.Size = New System.Drawing.Size(498, 729)
        Me.gbx_CasetRuta.TabIndex = 9
        Me.gbx_CasetRuta.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(377, 677)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(115, 40)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Regsitros1
        '
        Me.lbl_Regsitros1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Regsitros1.AutoSize = True
        Me.lbl_Regsitros1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Regsitros1.Location = New System.Drawing.Point(402, 19)
        Me.lbl_Regsitros1.Name = "lbl_Regsitros1"
        Me.lbl_Regsitros1.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Regsitros1.TabIndex = 8
        Me.lbl_Regsitros1.Text = "Registros"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.AutoSize = True
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(426, 19)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Registros.TabIndex = 8
        Me.lbl_Registros.Text = "Registros"
        '
        'tbx_Codigo
        '
        Me.tbx_Codigo.Control_Siguiente = Nothing
        Me.tbx_Codigo.Filtrado = True
        Me.tbx_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Codigo.Location = New System.Drawing.Point(107, 85)
        Me.tbx_Codigo.Name = "tbx_Codigo"
        Me.tbx_Codigo.Size = New System.Drawing.Size(158, 22)
        Me.tbx_Codigo.TabIndex = 9
        Me.tbx_Codigo.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Rutas
        '
        Me.cmb_Rutas.Clave = "Clave"
        Me.cmb_Rutas.Control_Siguiente = Nothing
        Me.cmb_Rutas.DisplayMember = "Descripcion"
        Me.cmb_Rutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rutas.Empresa = False
        Me.cmb_Rutas.Filtro = Me.tbx_CveRuta
        Me.cmb_Rutas.FormattingEnabled = True
        Me.cmb_Rutas.Location = New System.Drawing.Point(104, 34)
        Me.cmb_Rutas.MaxDropDownItems = 20
        Me.cmb_Rutas.Name = "cmb_Rutas"
        Me.cmb_Rutas.Pista = False
        Me.cmb_Rutas.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Rutas.StoredProcedure = "CAT_Rutas_Programadas"
        Me.cmb_Rutas.Sucursal = True
        Me.cmb_Rutas.TabIndex = 9
        Me.cmb_Rutas.Tipo = 0
        Me.cmb_Rutas.ValueMember = "Id_Programacion"
        '
        'tbx_CveRuta
        '
        Me.tbx_CveRuta.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_CveRuta.Filtrado = True
        Me.tbx_CveRuta.Location = New System.Drawing.Point(48, 35)
        Me.tbx_CveRuta.MaxLength = 4
        Me.tbx_CveRuta.Name = "tbx_CveRuta"
        Me.tbx_CveRuta.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveRuta.TabIndex = 8
        Me.tbx_CveRuta.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_CasetAsignadoRuta
        '
        Me.lsv_CasetAsignadoRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CasetAsignadoRuta.FullRowSelect = True
        Me.lsv_CasetAsignadoRuta.HideSelection = False
        Me.lsv_CasetAsignadoRuta.Location = New System.Drawing.Point(6, 38)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_CasetAsignadoRuta.Lvs = ListViewColumnSorter1
        Me.lsv_CasetAsignadoRuta.MultiSelect = False
        Me.lsv_CasetAsignadoRuta.Name = "lsv_CasetAsignadoRuta"
        Me.lsv_CasetAsignadoRuta.Row1 = 15
        Me.lsv_CasetAsignadoRuta.Row10 = 10
        Me.lsv_CasetAsignadoRuta.Row2 = 40
        Me.lsv_CasetAsignadoRuta.Row3 = 15
        Me.lsv_CasetAsignadoRuta.Row4 = 35
        Me.lsv_CasetAsignadoRuta.Row5 = 35
        Me.lsv_CasetAsignadoRuta.Row6 = 0
        Me.lsv_CasetAsignadoRuta.Row7 = 0
        Me.lsv_CasetAsignadoRuta.Row8 = 0
        Me.lsv_CasetAsignadoRuta.Row9 = 10
        Me.lsv_CasetAsignadoRuta.Size = New System.Drawing.Size(486, 633)
        Me.lsv_CasetAsignadoRuta.TabIndex = 0
        Me.lsv_CasetAsignadoRuta.UseCompatibleStateImageBehavior = False
        Me.lsv_CasetAsignadoRuta.View = System.Windows.Forms.View.Details
        '
        'frm_AsignarCasetRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 729)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_AsignarCasetRuta"
        Me.Text = "frm_AsignarCasetRuta"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbx_Casets.ResumeLayout(False)
        Me.gbx_Casets.PerformLayout()
        CType(Me.dgv_Casets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_CasetRuta.ResumeLayout(False)
        Me.gbx_CasetRuta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Rutas As System.Windows.Forms.Label
    Friend WithEvents tbx_CveRuta As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Casets As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistroCaset As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_CasetRuta As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Regsitros1 As System.Windows.Forms.Label
    Friend WithEvents lsv_CasetAsignadoRuta As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Codigo As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Scanear As System.Windows.Forms.Label
    Friend WithEvents dgv_Casets As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
