<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CosultaRemisionRechazada
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
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Btn_Consulta = New System.Windows.Forms.Button
        Me.Ckb_Cia = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.gbx_RemisionesRechazadas = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_RemisionesRechazadas = New Modulo_Recepcion.cp_Listview
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_RemisionesRechazadas.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Compañia)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.Btn_Consulta)
        Me.Gbx_Filtro.Controls.Add(Me.Ckb_Cia)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_hasta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Desde)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 12)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(770, 95)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Compañia.TabIndex = 0
        Me.lbl_Compañia.Text = "Compañía"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Clave = "Clave"
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Filtro = Nothing
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(68, 13)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = False
        Me.cmb_Cia.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_GetNoPropia"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 1
        Me.cmb_Cia.Tipo = 0
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(68, 49)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 4
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.Btn_Consulta.Location = New System.Drawing.Point(390, 46)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Consulta.TabIndex = 7
        Me.Btn_Consulta.Text = "C&onsultar"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'Ckb_Cia
        '
        Me.Ckb_Cia.AutoSize = True
        Me.Ckb_Cia.Location = New System.Drawing.Point(474, 19)
        Me.Ckb_Cia.Name = "Ckb_Cia"
        Me.Ckb_Cia.Size = New System.Drawing.Size(56, 17)
        Me.Ckb_Cia.TabIndex = 2
        Me.Ckb_Cia.Text = "Todos"
        Me.Ckb_Cia.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(211, 49)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 6
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(170, 53)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 5
        Me.lbl_hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(24, 53)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 3
        Me.lbl_Desde.Text = "Desde"
        '
        'gbx_RemisionesRechazadas
        '
        Me.gbx_RemisionesRechazadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RemisionesRechazadas.Controls.Add(Me.Lbl_Registros)
        Me.gbx_RemisionesRechazadas.Controls.Add(Me.lsv_RemisionesRechazadas)
        Me.gbx_RemisionesRechazadas.Location = New System.Drawing.Point(7, 113)
        Me.gbx_RemisionesRechazadas.Name = "gbx_RemisionesRechazadas"
        Me.gbx_RemisionesRechazadas.Size = New System.Drawing.Size(770, 380)
        Me.gbx_RemisionesRechazadas.TabIndex = 1
        Me.gbx_RemisionesRechazadas.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(624, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 6
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_RemisionesRechazadas
        '
        Me.lsv_RemisionesRechazadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_RemisionesRechazadas.FullRowSelect = True
        Me.lsv_RemisionesRechazadas.HideSelection = False
        Me.lsv_RemisionesRechazadas.Location = New System.Drawing.Point(9, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_RemisionesRechazadas.Lvs = ListViewColumnSorter1
        Me.lsv_RemisionesRechazadas.MultiSelect = False
        Me.lsv_RemisionesRechazadas.Name = "lsv_RemisionesRechazadas"
        Me.lsv_RemisionesRechazadas.Row1 = 10
        Me.lsv_RemisionesRechazadas.Row10 = 10
        Me.lsv_RemisionesRechazadas.Row2 = 10
        Me.lsv_RemisionesRechazadas.Row3 = 10
        Me.lsv_RemisionesRechazadas.Row4 = 10
        Me.lsv_RemisionesRechazadas.Row5 = 10
        Me.lsv_RemisionesRechazadas.Row6 = 10
        Me.lsv_RemisionesRechazadas.Row7 = 10
        Me.lsv_RemisionesRechazadas.Row8 = 10
        Me.lsv_RemisionesRechazadas.Row9 = 10
        Me.lsv_RemisionesRechazadas.Size = New System.Drawing.Size(752, 340)
        Me.lsv_RemisionesRechazadas.TabIndex = 0
        Me.lsv_RemisionesRechazadas.UseCompatibleStateImageBehavior = False
        Me.lsv_RemisionesRechazadas.View = System.Windows.Forms.View.Details
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Location = New System.Drawing.Point(7, 499)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(770, 50)
        Me.gbx_botones.TabIndex = 2
        Me.gbx_botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(9, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 1
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_CosultaRemisionRechazada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_RemisionesRechazadas)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CosultaRemisionRechazada"
        Me.Text = "Consulta de Remisiones Rechazadas"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_RemisionesRechazadas.ResumeLayout(False)
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents Ckb_Cia As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_RemisionesRechazadas As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_RemisionesRechazadas As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
