<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Pernoctas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Pernoctas))
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.tab_Pernoctas = New System.Windows.Forms.TabControl
        Me.tab_Custodia = New System.Windows.Forms.TabPage
        Me.lsv_Custodia = New Modulo_Recepcion.cp_Listview
        Me.tab_Proceso = New System.Windows.Forms.TabPage
        Me.lsv_Proceso = New Modulo_Recepcion.cp_Listview
        Me.gbx_Filtros = New System.Windows.Forms.GroupBox
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.tbx_Cliente = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Cliente = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Recepcion.cp_cmb_Manual
        Me.lbl_Hasta = New System.Windows.Forms.Label
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Percnotas = New System.Windows.Forms.GroupBox
        Me.pct_ConPernocta = New System.Windows.Forms.PictureBox
        Me.lbl_ConPernocta = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.lbl_Dias = New System.Windows.Forms.Label
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.btn_Editar = New System.Windows.Forms.Button
        Me.lsv_Pernoctas = New Modulo_Recepcion.cp_Listview
        Me.gbx_Valores = New System.Windows.Forms.GroupBox
        Me.lbl_FinPernocta = New System.Windows.Forms.Label
        Me.dtp_FinPernocta = New System.Windows.Forms.DateTimePicker
        Me.lbl_InicioPernocta = New System.Windows.Forms.Label
        Me.dtp_InicioPernocta = New System.Windows.Forms.DateTimePicker
        Me.lbl_CS = New System.Windows.Forms.Label
        Me.cmb_CS = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Dias = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Observaciones = New Modulo_Recepcion.cp_Textbox
        Me.tab_Pernoctas.SuspendLayout()
        Me.tab_Custodia.SuspendLayout()
        Me.tab_Proceso.SuspendLayout()
        Me.gbx_Filtros.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Percnotas.SuspendLayout()
        CType(Me.pct_ConPernocta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Valores.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_Pernoctas
        '
        Me.tab_Pernoctas.Controls.Add(Me.tab_Custodia)
        Me.tab_Pernoctas.Controls.Add(Me.tab_Proceso)
        Me.tab_Pernoctas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_Pernoctas.Location = New System.Drawing.Point(3, 16)
        Me.tab_Pernoctas.Name = "tab_Pernoctas"
        Me.tab_Pernoctas.SelectedIndex = 0
        Me.tab_Pernoctas.Size = New System.Drawing.Size(760, 134)
        Me.tab_Pernoctas.TabIndex = 0
        '
        'tab_Custodia
        '
        Me.tab_Custodia.Controls.Add(Me.lsv_Custodia)
        Me.tab_Custodia.Location = New System.Drawing.Point(4, 22)
        Me.tab_Custodia.Name = "tab_Custodia"
        Me.tab_Custodia.Size = New System.Drawing.Size(752, 108)
        Me.tab_Custodia.TabIndex = 0
        Me.tab_Custodia.Text = "Custodia"
        Me.tab_Custodia.UseVisualStyleBackColor = True
        '
        'lsv_Custodia
        '
        Me.lsv_Custodia.AllowColumnReorder = True
        Me.lsv_Custodia.CheckBoxes = True
        Me.lsv_Custodia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Custodia.FullRowSelect = True
        Me.lsv_Custodia.HideSelection = False
        Me.lsv_Custodia.Location = New System.Drawing.Point(0, 0)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Custodia.Lvs = ListViewColumnSorter1
        Me.lsv_Custodia.MultiSelect = False
        Me.lsv_Custodia.Name = "lsv_Custodia"
        Me.lsv_Custodia.Row1 = 10
        Me.lsv_Custodia.Row10 = 0
        Me.lsv_Custodia.Row2 = 12
        Me.lsv_Custodia.Row3 = 12
        Me.lsv_Custodia.Row4 = 10
        Me.lsv_Custodia.Row5 = 10
        Me.lsv_Custodia.Row6 = 10
        Me.lsv_Custodia.Row7 = 10
        Me.lsv_Custodia.Row8 = 10
        Me.lsv_Custodia.Row9 = 10
        Me.lsv_Custodia.Size = New System.Drawing.Size(752, 108)
        Me.lsv_Custodia.TabIndex = 0
        Me.lsv_Custodia.UseCompatibleStateImageBehavior = False
        Me.lsv_Custodia.View = System.Windows.Forms.View.Details
        '
        'tab_Proceso
        '
        Me.tab_Proceso.Controls.Add(Me.lsv_Proceso)
        Me.tab_Proceso.Location = New System.Drawing.Point(4, 22)
        Me.tab_Proceso.Name = "tab_Proceso"
        Me.tab_Proceso.Size = New System.Drawing.Size(752, 108)
        Me.tab_Proceso.TabIndex = 1
        Me.tab_Proceso.Text = "Proceso"
        Me.tab_Proceso.UseVisualStyleBackColor = True
        '
        'lsv_Proceso
        '
        Me.lsv_Proceso.AllowColumnReorder = True
        Me.lsv_Proceso.CheckBoxes = True
        Me.lsv_Proceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Proceso.FullRowSelect = True
        Me.lsv_Proceso.HideSelection = False
        Me.lsv_Proceso.Location = New System.Drawing.Point(0, 0)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Proceso.Lvs = ListViewColumnSorter2
        Me.lsv_Proceso.MultiSelect = False
        Me.lsv_Proceso.Name = "lsv_Proceso"
        Me.lsv_Proceso.Row1 = 10
        Me.lsv_Proceso.Row10 = 0
        Me.lsv_Proceso.Row2 = 12
        Me.lsv_Proceso.Row3 = 12
        Me.lsv_Proceso.Row4 = 10
        Me.lsv_Proceso.Row5 = 10
        Me.lsv_Proceso.Row6 = 10
        Me.lsv_Proceso.Row7 = 10
        Me.lsv_Proceso.Row8 = 10
        Me.lsv_Proceso.Row9 = 10
        Me.lsv_Proceso.Size = New System.Drawing.Size(752, 108)
        Me.lsv_Proceso.TabIndex = 0
        Me.lsv_Proceso.UseCompatibleStateImageBehavior = False
        Me.lsv_Proceso.View = System.Windows.Forms.View.Details
        '
        'gbx_Filtros
        '
        Me.gbx_Filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Filtros.Controls.Add(Me.tbx_Cliente)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Filtros.Controls.Add(Me.chk_Status)
        Me.gbx_Filtros.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtros.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Filtros.Controls.Add(Me.lbl_Desde)
        Me.gbx_Filtros.Controls.Add(Me.dtp_Desde)
        Me.gbx_Filtros.ForeColor = System.Drawing.Color.Black
        Me.gbx_Filtros.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Filtros.Name = "gbx_Filtros"
        Me.gbx_Filtros.Size = New System.Drawing.Size(766, 96)
        Me.gbx_Filtros.TabIndex = 0
        Me.gbx_Filtros.TabStop = False
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(7, 44)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Cliente.TabIndex = 4
        Me.lbl_Cliente.Text = "Cliente"
        '
        'tbx_Cliente
        '
        Me.tbx_Cliente.Control_Siguiente = Me.cmb_Cliente
        Me.tbx_Cliente.Filtrado = True
        Me.tbx_Cliente.Location = New System.Drawing.Point(51, 42)
        Me.tbx_Cliente.MaxLength = 10
        Me.tbx_Cliente.Name = "tbx_Cliente"
        Me.tbx_Cliente.Size = New System.Drawing.Size(58, 20)
        Me.tbx_Cliente.TabIndex = 5
        Me.tbx_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Cliente.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = "Clave_Cliente"
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Me.tbx_Cliente
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(115, 41)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(368, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 6
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(222, 70)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 9
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(541, 59)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(8, 71)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 7
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(51, 68)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(165, 21)
        Me.cmb_Status.TabIndex = 8
        Me.cmb_Status.ValueMember = "value"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(152, 18)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(193, 15)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(7, 18)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(51, 15)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Guardar)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(9, 499)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Controles.TabIndex = 4
        Me.gbx_Controles.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 12)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Percnotas
        '
        Me.gbx_Percnotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Percnotas.Controls.Add(Me.pct_ConPernocta)
        Me.gbx_Percnotas.Controls.Add(Me.lbl_ConPernocta)
        Me.gbx_Percnotas.Controls.Add(Me.tab_Pernoctas)
        Me.gbx_Percnotas.ForeColor = System.Drawing.Color.Black
        Me.gbx_Percnotas.Location = New System.Drawing.Point(9, 104)
        Me.gbx_Percnotas.Name = "gbx_Percnotas"
        Me.gbx_Percnotas.Size = New System.Drawing.Size(766, 153)
        Me.gbx_Percnotas.TabIndex = 1
        Me.gbx_Percnotas.TabStop = False
        Me.gbx_Percnotas.Text = "Remisiones"
        '
        'pct_ConPernocta
        '
        Me.pct_ConPernocta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_ConPernocta.BackColor = System.Drawing.Color.Blue
        Me.pct_ConPernocta.Location = New System.Drawing.Point(673, 15)
        Me.pct_ConPernocta.Name = "pct_ConPernocta"
        Me.pct_ConPernocta.Size = New System.Drawing.Size(16, 15)
        Me.pct_ConPernocta.TabIndex = 1
        Me.pct_ConPernocta.TabStop = False
        '
        'lbl_ConPernocta
        '
        Me.lbl_ConPernocta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ConPernocta.AutoSize = True
        Me.lbl_ConPernocta.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ConPernocta.Location = New System.Drawing.Point(689, 16)
        Me.lbl_ConPernocta.Name = "lbl_ConPernocta"
        Me.lbl_ConPernocta.Size = New System.Drawing.Size(72, 13)
        Me.lbl_ConPernocta.TabIndex = 1
        Me.lbl_ConPernocta.Text = "Con Pernocta"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(379, 16)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 10
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'lbl_Dias
        '
        Me.lbl_Dias.AutoSize = True
        Me.lbl_Dias.Location = New System.Drawing.Point(305, 16)
        Me.lbl_Dias.Name = "lbl_Dias"
        Me.lbl_Dias.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Dias.TabIndex = 4
        Me.lbl_Dias.Text = "Total"
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Detalle.Controls.Add(Me.btn_Baja)
        Me.gbx_Detalle.Controls.Add(Me.btn_Editar)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Pernoctas)
        Me.gbx_Detalle.Location = New System.Drawing.Point(9, 328)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(766, 167)
        Me.gbx_Detalle.TabIndex = 3
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Pernoctas"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(670, 91)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(90, 30)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "C&ancelar"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_Baja.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Baja.Location = New System.Drawing.Point(670, 54)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(90, 30)
        Me.btn_Baja.TabIndex = 3
        Me.btn_Baja.Text = "&Baja"
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Editar.Enabled = False
        Me.btn_Editar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn_Editar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Editar
        Me.btn_Editar.Location = New System.Drawing.Point(670, 17)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(90, 30)
        Me.btn_Editar.TabIndex = 2
        Me.btn_Editar.Text = "&Editar"
        Me.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'lsv_Pernoctas
        '
        Me.lsv_Pernoctas.AllowColumnReorder = True
        Me.lsv_Pernoctas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Pernoctas.FullRowSelect = True
        Me.lsv_Pernoctas.HideSelection = False
        Me.lsv_Pernoctas.Location = New System.Drawing.Point(7, 17)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Pernoctas.Lvs = ListViewColumnSorter3
        Me.lsv_Pernoctas.MultiSelect = False
        Me.lsv_Pernoctas.Name = "lsv_Pernoctas"
        Me.lsv_Pernoctas.Row1 = 15
        Me.lsv_Pernoctas.Row10 = 0
        Me.lsv_Pernoctas.Row2 = 10
        Me.lsv_Pernoctas.Row3 = 20
        Me.lsv_Pernoctas.Row4 = 10
        Me.lsv_Pernoctas.Row5 = 0
        Me.lsv_Pernoctas.Row6 = 0
        Me.lsv_Pernoctas.Row7 = 0
        Me.lsv_Pernoctas.Row8 = 0
        Me.lsv_Pernoctas.Row9 = 0
        Me.lsv_Pernoctas.Size = New System.Drawing.Size(657, 144)
        Me.lsv_Pernoctas.TabIndex = 1
        Me.lsv_Pernoctas.UseCompatibleStateImageBehavior = False
        Me.lsv_Pernoctas.View = System.Windows.Forms.View.Details
        '
        'gbx_Valores
        '
        Me.gbx_Valores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Valores.Controls.Add(Me.lbl_FinPernocta)
        Me.gbx_Valores.Controls.Add(Me.dtp_FinPernocta)
        Me.gbx_Valores.Controls.Add(Me.lbl_InicioPernocta)
        Me.gbx_Valores.Controls.Add(Me.dtp_InicioPernocta)
        Me.gbx_Valores.Controls.Add(Me.lbl_CS)
        Me.gbx_Valores.Controls.Add(Me.cmb_CS)
        Me.gbx_Valores.Controls.Add(Me.lbl_Dias)
        Me.gbx_Valores.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Valores.Controls.Add(Me.tbx_Dias)
        Me.gbx_Valores.Controls.Add(Me.tbx_Observaciones)
        Me.gbx_Valores.Location = New System.Drawing.Point(9, 258)
        Me.gbx_Valores.Name = "gbx_Valores"
        Me.gbx_Valores.Size = New System.Drawing.Size(766, 66)
        Me.gbx_Valores.TabIndex = 2
        Me.gbx_Valores.TabStop = False
        '
        'lbl_FinPernocta
        '
        Me.lbl_FinPernocta.AutoSize = True
        Me.lbl_FinPernocta.Location = New System.Drawing.Point(162, 16)
        Me.lbl_FinPernocta.Name = "lbl_FinPernocta"
        Me.lbl_FinPernocta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_FinPernocta.TabIndex = 2
        Me.lbl_FinPernocta.Text = "Hasta"
        '
        'dtp_FinPernocta
        '
        Me.dtp_FinPernocta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FinPernocta.Location = New System.Drawing.Point(203, 13)
        Me.dtp_FinPernocta.Name = "dtp_FinPernocta"
        Me.dtp_FinPernocta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FinPernocta.TabIndex = 3
        '
        'lbl_InicioPernocta
        '
        Me.lbl_InicioPernocta.AutoSize = True
        Me.lbl_InicioPernocta.Location = New System.Drawing.Point(17, 16)
        Me.lbl_InicioPernocta.Name = "lbl_InicioPernocta"
        Me.lbl_InicioPernocta.Size = New System.Drawing.Size(38, 13)
        Me.lbl_InicioPernocta.TabIndex = 0
        Me.lbl_InicioPernocta.Text = "Desde"
        '
        'dtp_InicioPernocta
        '
        Me.dtp_InicioPernocta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_InicioPernocta.Location = New System.Drawing.Point(61, 13)
        Me.dtp_InicioPernocta.Name = "dtp_InicioPernocta"
        Me.dtp_InicioPernocta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_InicioPernocta.TabIndex = 1
        '
        'lbl_CS
        '
        Me.lbl_CS.AutoSize = True
        Me.lbl_CS.Location = New System.Drawing.Point(10, 43)
        Me.lbl_CS.Name = "lbl_CS"
        Me.lbl_CS.Size = New System.Drawing.Size(45, 13)
        Me.lbl_CS.TabIndex = 6
        Me.lbl_CS.Text = "Servicio"
        '
        'cmb_CS
        '
        Me.cmb_CS.Clave = Nothing
        Me.cmb_CS.Control_Siguiente = Nothing
        Me.cmb_CS.DisplayMember = "Descripcion"
        Me.cmb_CS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CS.Empresa = False
        Me.cmb_CS.Filtro = Nothing
        Me.cmb_CS.FormattingEnabled = True
        Me.cmb_CS.Location = New System.Drawing.Point(61, 39)
        Me.cmb_CS.MaxDropDownItems = 20
        Me.cmb_CS.Name = "cmb_CS"
        Me.cmb_CS.Pista = False
        Me.cmb_CS.Size = New System.Drawing.Size(312, 21)
        Me.cmb_CS.StoredProcedure = "Cat_ClientesServicios_GetCombo"
        Me.cmb_CS.Sucursal = False
        Me.cmb_CS.TabIndex = 7
        Me.cmb_CS.Tipo = 0
        Me.cmb_CS.ValueMember = "Id_CS"
        '
        'tbx_Dias
        '
        Me.tbx_Dias.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Dias.Control_Siguiente = Me.tbx_Observaciones
        Me.tbx_Dias.Filtrado = False
        Me.tbx_Dias.Location = New System.Drawing.Point(342, 13)
        Me.tbx_Dias.MaxLength = 2
        Me.tbx_Dias.Name = "tbx_Dias"
        Me.tbx_Dias.ReadOnly = True
        Me.tbx_Dias.Size = New System.Drawing.Size(31, 20)
        Me.tbx_Dias.TabIndex = 5
        Me.tbx_Dias.TabStop = False
        Me.tbx_Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Dias.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(463, 13)
        Me.tbx_Observaciones.MaxLength = 200
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(289, 47)
        Me.tbx_Observaciones.TabIndex = 11
        Me.tbx_Observaciones.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_Pernoctas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Valores)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Percnotas)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Filtros)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Pernoctas"
        Me.Text = "Pernoctas"
        Me.tab_Pernoctas.ResumeLayout(False)
        Me.tab_Custodia.ResumeLayout(False)
        Me.tab_Proceso.ResumeLayout(False)
        Me.gbx_Filtros.ResumeLayout(False)
        Me.gbx_Filtros.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Percnotas.ResumeLayout(False)
        Me.gbx_Percnotas.PerformLayout()
        CType(Me.pct_ConPernocta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Valores.ResumeLayout(False)
        Me.gbx_Valores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_Pernoctas As System.Windows.Forms.TabControl
    Friend WithEvents lsv_Proceso As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents tab_Proceso As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Custodia As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Recepcion.cp_cmb_Manual
    Friend WithEvents gbx_Percnotas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Dias As System.Windows.Forms.Label
    Friend WithEvents tbx_Dias As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Observaciones As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lsv_Pernoctas As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents gbx_Valores As System.Windows.Forms.GroupBox
    Friend WithEvents tab_Custodia As System.Windows.Forms.TabPage
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents pct_ConPernocta As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_ConPernocta As System.Windows.Forms.Label
    Friend WithEvents tbx_Cliente As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Cliente As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_CS As System.Windows.Forms.Label
    Friend WithEvents cmb_CS As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_FinPernocta As System.Windows.Forms.Label
    Friend WithEvents dtp_FinPernocta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_InicioPernocta As System.Windows.Forms.Label
    Friend WithEvents dtp_InicioPernocta As System.Windows.Forms.DateTimePicker
End Class
