<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecepcionCasetRuta
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
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Rutas = New System.Windows.Forms.Label
        Me.tbx_CveRuta = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgv_Casets = New System.Windows.Forms.DataGridView
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Datos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Casets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Datos.Controls.Add(Me.lbl_fecha)
        Me.gbx_Datos.Controls.Add(Me.dtp_Fecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_Rutas)
        Me.gbx_Datos.Controls.Add(Me.tbx_CveRuta)
        Me.gbx_Datos.Controls.Add(Me.cmb_Rutas)
        Me.gbx_Datos.Location = New System.Drawing.Point(2, 5)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(779, 83)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(511, 28)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(103, 30)
        Me.btn_Mostrar.TabIndex = 16
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        Me.btn_Mostrar.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(6, 18)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 5
        Me.lbl_fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(49, 14)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 6
        '
        'lbl_Rutas
        '
        Me.lbl_Rutas.AutoSize = True
        Me.lbl_Rutas.Location = New System.Drawing.Point(13, 41)
        Me.lbl_Rutas.Name = "lbl_Rutas"
        Me.lbl_Rutas.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Rutas.TabIndex = 7
        Me.lbl_Rutas.Text = "Ruta"
        '
        'tbx_CveRuta
        '
        Me.tbx_CveRuta.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_CveRuta.Filtrado = True
        Me.tbx_CveRuta.Location = New System.Drawing.Point(49, 38)
        Me.tbx_CveRuta.MaxLength = 4
        Me.tbx_CveRuta.Name = "tbx_CveRuta"
        Me.tbx_CveRuta.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveRuta.TabIndex = 8
        Me.tbx_CveRuta.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
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
        Me.cmb_Rutas.Location = New System.Drawing.Point(105, 37)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgv_Casets)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_Registros)
        Me.GroupBox1.Controls.Add(Me.tbx_Remision)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 546)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.dgv_Casets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Casets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.dgv_Casets.Location = New System.Drawing.Point(6, 52)
        Me.dgv_Casets.Name = "dgv_Casets"
        Me.dgv_Casets.RowHeadersVisible = False
        Me.dgv_Casets.Size = New System.Drawing.Size(764, 488)
        Me.dgv_Casets.TabIndex = 19
        '
        'chk
        '
        Me.chk.HeaderText = ""
        Me.chk.Name = "chk"
        Me.chk.Width = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Scanear Codigo"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.AutoSize = True
        Me.lbl_Registros.Location = New System.Drawing.Point(657, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registro: 0"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Location = New System.Drawing.Point(128, 15)
        Me.tbx_Remision.MaxLength = 20
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(136, 20)
        Me.tbx_Remision.TabIndex = 18
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(2, 646)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(779, 54)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 11)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(122, 37)
        Me.btn_Guardar.TabIndex = 1
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(648, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(122, 37)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_RecepcionCasetRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 712)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbx_Datos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_RecepcionCasetRuta"
        Me.Text = "Recepcion de Caset"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Casets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Rutas As System.Windows.Forms.Label
    Friend WithEvents tbx_CveRuta As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents dgv_Casets As System.Windows.Forms.DataGridView
    Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
