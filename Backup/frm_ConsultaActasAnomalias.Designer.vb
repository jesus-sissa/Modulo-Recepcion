<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaActasAnomalias
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
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.rdb_PorRemision = New System.Windows.Forms.RadioButton
        Me.rdb_PorFecha = New System.Windows.Forms.RadioButton
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_NRemision = New System.Windows.Forms.Label
        Me.dtp_FechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Lbl_FechaIni = New System.Windows.Forms.Label
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lsv_Listado = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Reimprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.rdb_PorRemision)
        Me.Gbx_Filtro.Controls.Add(Me.rdb_PorFecha)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_NRemision)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_FechaFin)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_FechaInicio)
        Me.Gbx_Filtro.Controls.Add(Me.Label3)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_FechaIni)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 12)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(766, 113)
        Me.Gbx_Filtro.TabIndex = 2
        Me.Gbx_Filtro.TabStop = False
        '
        'rdb_PorRemision
        '
        Me.rdb_PorRemision.AutoSize = True
        Me.rdb_PorRemision.Location = New System.Drawing.Point(187, 19)
        Me.rdb_PorRemision.Name = "rdb_PorRemision"
        Me.rdb_PorRemision.Size = New System.Drawing.Size(87, 17)
        Me.rdb_PorRemision.TabIndex = 11
        Me.rdb_PorRemision.TabStop = True
        Me.rdb_PorRemision.Text = "Por Remisión"
        Me.rdb_PorRemision.UseVisualStyleBackColor = True
        '
        'rdb_PorFecha
        '
        Me.rdb_PorFecha.AutoSize = True
        Me.rdb_PorFecha.Checked = True
        Me.rdb_PorFecha.Location = New System.Drawing.Point(91, 19)
        Me.rdb_PorFecha.Name = "rdb_PorFecha"
        Me.rdb_PorFecha.Size = New System.Drawing.Size(74, 17)
        Me.rdb_PorFecha.TabIndex = 11
        Me.rdb_PorFecha.TabStop = True
        Me.rdb_PorFecha.Text = "Por Fecha"
        Me.rdb_PorFecha.UseVisualStyleBackColor = True
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.btn_Mostrar
        Me.tbx_Remision.Enabled = False
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Remision.Location = New System.Drawing.Point(91, 68)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(246, 29)
        Me.tbx_Remision.TabIndex = 10
        Me.tbx_Remision.Text = "0"
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(343, 67)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 8
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Lbl_NRemision
        '
        Me.Lbl_NRemision.AutoSize = True
        Me.Lbl_NRemision.Location = New System.Drawing.Point(7, 79)
        Me.Lbl_NRemision.Name = "Lbl_NRemision"
        Me.Lbl_NRemision.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NRemision.TabIndex = 9
        Me.Lbl_NRemision.Text = "Num. Remisión"
        '
        'dtp_FechaFin
        '
        Me.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFin.Location = New System.Drawing.Point(252, 40)
        Me.dtp_FechaFin.Name = "dtp_FechaFin"
        Me.dtp_FechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaFin.TabIndex = 7
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(91, 42)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaInicio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha Fin"
        '
        'Lbl_FechaIni
        '
        Me.Lbl_FechaIni.AutoSize = True
        Me.Lbl_FechaIni.Location = New System.Drawing.Point(20, 46)
        Me.Lbl_FechaIni.Name = "Lbl_FechaIni"
        Me.Lbl_FechaIni.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_FechaIni.TabIndex = 3
        Me.Lbl_FechaIni.Text = "Fecha Inicio"
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Listado)
        Me.Gbx_Listado.Location = New System.Drawing.Point(9, 131)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(766, 362)
        Me.Gbx_Listado.TabIndex = 3
        Me.Gbx_Listado.TabStop = False
        Me.Gbx_Listado.Text = "Listado de Actas"
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter1
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 10
        Me.lsv_Listado.Row10 = 0
        Me.lsv_Listado.Row2 = 10
        Me.lsv_Listado.Row3 = 10
        Me.lsv_Listado.Row4 = 10
        Me.lsv_Listado.Row5 = 30
        Me.lsv_Listado.Row6 = 25
        Me.lsv_Listado.Row7 = 0
        Me.lsv_Listado.Row8 = 0
        Me.lsv_Listado.Row9 = 0
        Me.lsv_Listado.Size = New System.Drawing.Size(756, 319)
        Me.lsv_Listado.TabIndex = 0
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Reimprimir)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Reimprimir
        '
        Me.btn_Reimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Reimprimir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Imprimir
        Me.btn_Reimprimir.Location = New System.Drawing.Point(6, 14)
        Me.btn_Reimprimir.Name = "btn_Reimprimir"
        Me.btn_Reimprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Reimprimir.TabIndex = 9
        Me.btn_Reimprimir.Text = "&Reimprimir"
        Me.btn_Reimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Reimprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(625, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.lbl_Registros.TabIndex = 4
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_ConsultaActasAnomalias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaActasAnomalias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Actas de Recepción de Remisiones"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaIni As System.Windows.Forms.Label
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Listado As Modulo_Recepcion.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Reimprimir As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_NRemision As System.Windows.Forms.Label
    Friend WithEvents rdb_PorRemision As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PorFecha As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
