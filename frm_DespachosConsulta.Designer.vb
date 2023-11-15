<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DespachosConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DespachosConsulta))
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.Btn_Consulta = New System.Windows.Forms.Button
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.chk_Cia = New System.Windows.Forms.CheckBox
        Me.cmb_Cias = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Status = New Modulo_Recepcion.cp_cmb_Manual
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.chk_Usuario = New System.Windows.Forms.CheckBox
        Me.chk_Ruta = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.cmb_Usuario = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Usuario = New System.Windows.Forms.Label
        Me.cmb_Ruta = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Ruta = New System.Windows.Forms.Label
        Me.Gbx_Despacho = New System.Windows.Forms.GroupBox
        Me.lsv_Despachos = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.lsv_Detalle = New Modulo_Recepcion.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Despacho.SuspendLayout()
        Me.Gbx_Detalle.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.Btn_Consulta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Compañia)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Cia)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Cias)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Status)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Status)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Usuario)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Ruta)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_FechaHasta)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_FechaDesde)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Usuario)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Usuario)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Ruta)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Ruta)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 4)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(770, 156)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.Btn_Consulta.Location = New System.Drawing.Point(476, 117)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Consulta.TabIndex = 16
        Me.Btn_Consulta.Text = "C&onsultar"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(6, 48)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Compañia.TabIndex = 4
        Me.lbl_Compañia.Text = "Compañía TV"
        '
        'chk_Cia
        '
        Me.chk_Cia.AutoSize = True
        Me.chk_Cia.Location = New System.Drawing.Point(412, 44)
        Me.chk_Cia.Name = "chk_Cia"
        Me.chk_Cia.Size = New System.Drawing.Size(56, 17)
        Me.chk_Cia.TabIndex = 6
        Me.chk_Cia.Text = "Todas"
        Me.chk_Cia.UseVisualStyleBackColor = True
        '
        'cmb_Cias
        '
        Me.cmb_Cias.Clave = "Clave"
        Me.cmb_Cias.Control_Siguiente = Nothing
        Me.cmb_Cias.DisplayMember = "Nombre"
        Me.cmb_Cias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cias.Empresa = False
        Me.cmb_Cias.Filtro = Nothing
        Me.cmb_Cias.FormattingEnabled = True
        Me.cmb_Cias.Location = New System.Drawing.Point(85, 42)
        Me.cmb_Cias.MaxDropDownItems = 20
        Me.cmb_Cias.Name = "cmb_Cias"
        Me.cmb_Cias.Pista = True
        Me.cmb_Cias.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Cias.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cias.Sucursal = False
        Me.cmb_Cias.TabIndex = 5
        Me.cmb_Cias.Tipo = 0
        Me.cmb_Cias.ValueMember = "Id_Cia"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(85, 123)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Status.TabIndex = 14
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(42, 125)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 13
        Me.lbl_Status.Text = "Status"
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(260, 125)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 15
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'chk_Usuario
        '
        Me.chk_Usuario.AutoSize = True
        Me.chk_Usuario.Location = New System.Drawing.Point(412, 98)
        Me.chk_Usuario.Name = "chk_Usuario"
        Me.chk_Usuario.Size = New System.Drawing.Size(56, 17)
        Me.chk_Usuario.TabIndex = 12
        Me.chk_Usuario.Text = "Todos"
        Me.chk_Usuario.UseVisualStyleBackColor = True
        '
        'chk_Ruta
        '
        Me.chk_Ruta.AutoSize = True
        Me.chk_Ruta.Location = New System.Drawing.Point(260, 71)
        Me.chk_Ruta.Name = "chk_Ruta"
        Me.chk_Ruta.Size = New System.Drawing.Size(56, 17)
        Me.chk_Ruta.TabIndex = 9
        Me.chk_Ruta.Text = "Todas"
        Me.chk_Ruta.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(227, 16)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(85, 16)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(186, 20)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_FechaHasta.TabIndex = 2
        Me.lbl_FechaHasta.Text = "Hasta"
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(41, 20)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_FechaDesde.TabIndex = 0
        Me.lbl_FechaDesde.Text = "Desde"
        '
        'cmb_Usuario
        '
        Me.cmb_Usuario.Clave = "Clave"
        Me.cmb_Usuario.Control_Siguiente = Nothing
        Me.cmb_Usuario.DisplayMember = "Nombre"
        Me.cmb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Usuario.Empresa = False
        Me.cmb_Usuario.Filtro = Nothing
        Me.cmb_Usuario.Location = New System.Drawing.Point(85, 96)
        Me.cmb_Usuario.MaxDropDownItems = 20
        Me.cmb_Usuario.Name = "cmb_Usuario"
        Me.cmb_Usuario.Pista = False
        Me.cmb_Usuario.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Usuario.StoredProcedure = "Bo_Despacho_GetUsuarios"
        Me.cmb_Usuario.Sucursal = True
        Me.cmb_Usuario.TabIndex = 11
        Me.cmb_Usuario.Tipo = 0
        Me.cmb_Usuario.ValueMember = "Usuario_Despacho"
        '
        'Lbl_Usuario
        '
        Me.Lbl_Usuario.AutoSize = True
        Me.Lbl_Usuario.Location = New System.Drawing.Point(36, 99)
        Me.Lbl_Usuario.Name = "Lbl_Usuario"
        Me.Lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Usuario.TabIndex = 10
        Me.Lbl_Usuario.Text = "Usuario"
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Clave = "Clave"
        Me.cmb_Ruta.Control_Siguiente = Nothing
        Me.cmb_Ruta.DisplayMember = "Descripcion"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.Empresa = False
        Me.cmb_Ruta.Filtro = Nothing
        Me.cmb_Ruta.Location = New System.Drawing.Point(85, 69)
        Me.cmb_Ruta.MaxDropDownItems = 20
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Pista = False
        Me.cmb_Ruta.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Ruta.StoredProcedure = "Cat_RutasCombo_Get1y2"
        Me.cmb_Ruta.Sucursal = True
        Me.cmb_Ruta.TabIndex = 8
        Me.cmb_Ruta.Tipo = 0
        Me.cmb_Ruta.ValueMember = "Id_Ruta"
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Location = New System.Drawing.Point(49, 72)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Ruta.TabIndex = 7
        Me.Lbl_Ruta.Text = "Ruta"
        '
        'Gbx_Despacho
        '
        Me.Gbx_Despacho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Despacho.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Despacho.Controls.Add(Me.lsv_Despachos)
        Me.Gbx_Despacho.Location = New System.Drawing.Point(7, 166)
        Me.Gbx_Despacho.Name = "Gbx_Despacho"
        Me.Gbx_Despacho.Size = New System.Drawing.Size(770, 169)
        Me.Gbx_Despacho.TabIndex = 1
        Me.Gbx_Despacho.TabStop = False
        '
        'lsv_Despachos
        '
        Me.lsv_Despachos.AllowColumnReorder = True
        Me.lsv_Despachos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Despachos.FullRowSelect = True
        Me.lsv_Despachos.HideSelection = False
        Me.lsv_Despachos.Location = New System.Drawing.Point(3, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Despachos.Lvs = ListViewColumnSorter1
        Me.lsv_Despachos.MultiSelect = False
        Me.lsv_Despachos.Name = "lsv_Despachos"
        Me.lsv_Despachos.Row1 = 8
        Me.lsv_Despachos.Row10 = 0
        Me.lsv_Despachos.Row2 = 6
        Me.lsv_Despachos.Row3 = 20
        Me.lsv_Despachos.Row4 = 10
        Me.lsv_Despachos.Row5 = 25
        Me.lsv_Despachos.Row6 = 10
        Me.lsv_Despachos.Row7 = 10
        Me.lsv_Despachos.Row8 = 10
        Me.lsv_Despachos.Row9 = 0
        Me.lsv_Despachos.Size = New System.Drawing.Size(762, 129)
        Me.lsv_Despachos.TabIndex = 0
        Me.lsv_Despachos.UseCompatibleStateImageBehavior = False
        Me.lsv_Despachos.View = System.Windows.Forms.View.Details
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(7, 338)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(770, 160)
        Me.Gbx_Detalle.TabIndex = 2
        Me.Gbx_Detalle.TabStop = False
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter2
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 10
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 30
        Me.lsv_Detalle.Row3 = 10
        Me.lsv_Detalle.Row4 = 10
        Me.lsv_Detalle.Row5 = 0
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(764, 141)
        Me.lsv_Detalle.TabIndex = 0
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 504)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(5, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(627, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 7
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_DespachosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Detalle)
        Me.Controls.Add(Me.Gbx_Despacho)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DespachosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Despachos"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Despacho.ResumeLayout(False)
        Me.Gbx_Detalle.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Ruta As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaHasta As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaDesde As System.Windows.Forms.Label
    Friend WithEvents cmb_Usuario As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents Gbx_Despacho As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Despachos As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Detalle As Modulo_Recepcion.cp_Listview
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents chk_Usuario As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Ruta As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Recepcion.cp_cmb_Manual
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents chk_Cia As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Cias As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
