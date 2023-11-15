<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BitacoraCambiosRuta
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
        Me.Rdb_Remision = New System.Windows.Forms.RadioButton
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Rdb_Fecha = New System.Windows.Forms.RadioButton
        Me.Gbx_Remision = New System.Windows.Forms.GroupBox
        Me.Tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lsv_Listado = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Exportar = New System.Windows.Forms.Button
        Me.Gbx_Fecha = New System.Windows.Forms.GroupBox
        Me.Lbl_Hasta = New System.Windows.Forms.Label
        Me.Lbl_Desde = New System.Windows.Forms.Label
        Me.Dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.Dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Btn_Mostrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Remision.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Fecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rdb_Remision
        '
        Me.Rdb_Remision.AutoSize = True
        Me.Rdb_Remision.Location = New System.Drawing.Point(14, 51)
        Me.Rdb_Remision.Name = "Rdb_Remision"
        Me.Rdb_Remision.Size = New System.Drawing.Size(87, 17)
        Me.Rdb_Remision.TabIndex = 1
        Me.Rdb_Remision.TabStop = True
        Me.Rdb_Remision.Text = "Por Remision"
        Me.Rdb_Remision.UseVisualStyleBackColor = True
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Controls.Add(Me.Rdb_Fecha)
        Me.Gbx_Filtro.Controls.Add(Me.Rdb_Remision)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(6, 4)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(107, 82)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        Me.Gbx_Filtro.Text = "Filtro"
        '
        'Rdb_Fecha
        '
        Me.Rdb_Fecha.AutoSize = True
        Me.Rdb_Fecha.Location = New System.Drawing.Point(14, 23)
        Me.Rdb_Fecha.Name = "Rdb_Fecha"
        Me.Rdb_Fecha.Size = New System.Drawing.Size(74, 17)
        Me.Rdb_Fecha.TabIndex = 0
        Me.Rdb_Fecha.TabStop = True
        Me.Rdb_Fecha.Text = "Por Fecha"
        Me.Rdb_Fecha.UseVisualStyleBackColor = True
        '
        'Gbx_Remision
        '
        Me.Gbx_Remision.Controls.Add(Me.Tbx_Remision)
        Me.Gbx_Remision.Location = New System.Drawing.Point(128, 46)
        Me.Gbx_Remision.Name = "Gbx_Remision"
        Me.Gbx_Remision.Size = New System.Drawing.Size(160, 40)
        Me.Gbx_Remision.TabIndex = 2
        Me.Gbx_Remision.TabStop = False
        '
        'Tbx_Remision
        '
        Me.Tbx_Remision.Control_Siguiente = Nothing
        Me.Tbx_Remision.Filtrado = True
        Me.Tbx_Remision.Location = New System.Drawing.Point(6, 15)
        Me.Tbx_Remision.Name = "Tbx_Remision"
        Me.Tbx_Remision.Size = New System.Drawing.Size(136, 20)
        Me.Tbx_Remision.TabIndex = 0
        Me.Tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_Listado)
        Me.Gbx_Listado.Location = New System.Drawing.Point(6, 87)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(771, 412)
        Me.Gbx_Listado.TabIndex = 4
        Me.Gbx_Listado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(591, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_Registros.TabIndex = 0
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Listado
        '
        Me.Lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Listado.FullRowSelect = True
        Me.Lsv_Listado.HideSelection = False
        Me.Lsv_Listado.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Listado.Lvs = ListViewColumnSorter1
        Me.Lsv_Listado.MultiSelect = False
        Me.Lsv_Listado.Name = "Lsv_Listado"
        Me.Lsv_Listado.Row1 = 10
        Me.Lsv_Listado.Row10 = 0
        Me.Lsv_Listado.Row2 = 30
        Me.Lsv_Listado.Row3 = 15
        Me.Lsv_Listado.Row4 = 12
        Me.Lsv_Listado.Row5 = 12
        Me.Lsv_Listado.Row6 = 20
        Me.Lsv_Listado.Row7 = 12
        Me.Lsv_Listado.Row8 = 10
        Me.Lsv_Listado.Row9 = 10
        Me.Lsv_Listado.Size = New System.Drawing.Size(759, 372)
        Me.Lsv_Listado.TabIndex = 1
        Me.Lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.Lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Exportar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 505)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(771, 50)
        Me.Gbx_Botones.TabIndex = 5
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(625, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Exportar.Enabled = False
        Me.Btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.Btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Exportar.TabIndex = 0
        Me.Btn_Exportar.Text = "Exportar"
        Me.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'Gbx_Fecha
        '
        Me.Gbx_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Fecha.Controls.Add(Me.Lbl_Hasta)
        Me.Gbx_Fecha.Controls.Add(Me.Lbl_Desde)
        Me.Gbx_Fecha.Controls.Add(Me.Dtp_Hasta)
        Me.Gbx_Fecha.Controls.Add(Me.Dtp_Desde)
        Me.Gbx_Fecha.Enabled = False
        Me.Gbx_Fecha.Location = New System.Drawing.Point(125, 4)
        Me.Gbx_Fecha.Name = "Gbx_Fecha"
        Me.Gbx_Fecha.Size = New System.Drawing.Size(652, 41)
        Me.Gbx_Fecha.TabIndex = 1
        Me.Gbx_Fecha.TabStop = False
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(156, 16)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Hasta.TabIndex = 2
        Me.Lbl_Hasta.Text = "Hasta:"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(8, 17)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Desde.TabIndex = 0
        Me.Lbl_Desde.Text = "Desde:"
        '
        'Dtp_Hasta
        '
        Me.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Hasta.Location = New System.Drawing.Point(200, 14)
        Me.Dtp_Hasta.Name = "Dtp_Hasta"
        Me.Dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.Dtp_Hasta.TabIndex = 3
        '
        'Dtp_Desde
        '
        Me.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Desde.Location = New System.Drawing.Point(55, 14)
        Me.Dtp_Desde.Name = "Dtp_Desde"
        Me.Dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.Dtp_Desde.TabIndex = 1
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.Btn_Mostrar.Location = New System.Drawing.Point(294, 55)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Mostrar.TabIndex = 3
        Me.Btn_Mostrar.Text = "Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Frm_BitacoraCambiosRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Btn_Mostrar)
        Me.Controls.Add(Me.Gbx_Fecha)
        Me.Controls.Add(Me.Gbx_Remision)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Frm_BitacoraCambiosRuta"
        Me.Text = "Bitacora de Cambios de Ruta"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Remision.ResumeLayout(False)
        Me.Gbx_Remision.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Fecha.ResumeLayout(False)
        Me.Gbx_Fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rdb_Remision As System.Windows.Forms.RadioButton
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Remision As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_Fecha As System.Windows.Forms.RadioButton
    Friend WithEvents Gbx_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents Dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents Lsv_Listado As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Mostrar As System.Windows.Forms.Button
End Class
