<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CasetAsignaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CasetAsignaCliente))
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Container = New System.Windows.Forms.SplitContainer
        Me.gbx_CasetDisponibles = New System.Windows.Forms.GroupBox
        Me.btn_Asignar = New System.Windows.Forms.Button
        Me.lbl_ClienteAsignar = New System.Windows.Forms.Label
        Me.dtp_Fecha_Asignacion = New System.Windows.Forms.DateTimePicker
        Me.lbl_Fecha_Asignacion = New System.Windows.Forms.Label
        Me.Tab_CasetDisponibles = New System.Windows.Forms.TabControl
        Me.tbp_CasetNorma = New System.Windows.Forms.TabPage
        Me.tbp_SeguridadInterna = New System.Windows.Forms.TabPage
        Me.lbl_ScanearCasset = New System.Windows.Forms.Label
        Me.lbl_CasetsDisponibles = New System.Windows.Forms.Label
        Me.gbx_CasetAsignados = New System.Windows.Forms.GroupBox
        Me.btn_Retirar = New System.Windows.Forms.Button
        Me.tbx_Observaciones = New System.Windows.Forms.RichTextBox
        Me.lbl_ObrsevacionCancela = New System.Windows.Forms.Label
        Me.dtp_Fecha_Cancela = New System.Windows.Forms.DateTimePicker
        Me.lbl_Fecha_Cancela = New System.Windows.Forms.Label
        Me.lbl_CasetsAsignados = New System.Windows.Forms.Label
        Me.cmb_Cliente = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.lsv_CasetDisponibles = New Modulo_Recepcion.cp_Listview
        Me.lsv_Seguridad = New Modulo_Recepcion.cp_Listview
        Me.tbx_CodigoBarra = New Modulo_Recepcion.cp_Textbox
        Me.lsv_CasetAsignados = New Modulo_Recepcion.cp_Listview
        Me.gbx_Botones.SuspendLayout()
        Me.Container.Panel1.SuspendLayout()
        Me.Container.Panel2.SuspendLayout()
        Me.Container.SuspendLayout()
        Me.gbx_CasetDisponibles.SuspendLayout()
        Me.Tab_CasetDisponibles.SuspendLayout()
        Me.tbp_CasetNorma.SuspendLayout()
        Me.tbp_SeguridadInterna.SuspendLayout()
        Me.gbx_CasetAsignados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(3, 528)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(979, 59)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(843, 19)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 33)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Container
        '
        Me.Container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Container.Location = New System.Drawing.Point(3, 3)
        Me.Container.Name = "Container"
        '
        'Container.Panel1
        '
        Me.Container.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Container.Panel1.Controls.Add(Me.gbx_CasetDisponibles)
        '
        'Container.Panel2
        '
        Me.Container.Panel2.Controls.Add(Me.gbx_CasetAsignados)
        Me.Container.Size = New System.Drawing.Size(979, 519)
        Me.Container.SplitterDistance = 483
        Me.Container.TabIndex = 0
        '
        'gbx_CasetDisponibles
        '
        Me.gbx_CasetDisponibles.Controls.Add(Me.btn_Asignar)
        Me.gbx_CasetDisponibles.Controls.Add(Me.cmb_Cliente)
        Me.gbx_CasetDisponibles.Controls.Add(Me.lbl_ClienteAsignar)
        Me.gbx_CasetDisponibles.Controls.Add(Me.dtp_Fecha_Asignacion)
        Me.gbx_CasetDisponibles.Controls.Add(Me.lbl_Fecha_Asignacion)
        Me.gbx_CasetDisponibles.Controls.Add(Me.Tab_CasetDisponibles)
        Me.gbx_CasetDisponibles.Controls.Add(Me.tbx_CodigoBarra)
        Me.gbx_CasetDisponibles.Controls.Add(Me.lbl_ScanearCasset)
        Me.gbx_CasetDisponibles.Controls.Add(Me.lbl_CasetsDisponibles)
        Me.gbx_CasetDisponibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_CasetDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_CasetDisponibles.Location = New System.Drawing.Point(0, 0)
        Me.gbx_CasetDisponibles.Name = "gbx_CasetDisponibles"
        Me.gbx_CasetDisponibles.Size = New System.Drawing.Size(483, 519)
        Me.gbx_CasetDisponibles.TabIndex = 0
        Me.gbx_CasetDisponibles.TabStop = False
        Me.gbx_CasetDisponibles.Text = "Casets Disponibles"
        '
        'btn_Asignar
        '
        Me.btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar.Location = New System.Drawing.Point(398, 490)
        Me.btn_Asignar.Name = "btn_Asignar"
        Me.btn_Asignar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Asignar.TabIndex = 17
        Me.btn_Asignar.Text = "Asignar"
        Me.btn_Asignar.UseVisualStyleBackColor = True
        '
        'lbl_ClienteAsignar
        '
        Me.lbl_ClienteAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ClienteAsignar.AutoSize = True
        Me.lbl_ClienteAsignar.Location = New System.Drawing.Point(13, 466)
        Me.lbl_ClienteAsignar.Name = "lbl_ClienteAsignar"
        Me.lbl_ClienteAsignar.Size = New System.Drawing.Size(104, 13)
        Me.lbl_ClienteAsignar.TabIndex = 15
        Me.lbl_ClienteAsignar.Text = "Cliente A Asignar"
        '
        'dtp_Fecha_Asignacion
        '
        Me.dtp_Fecha_Asignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_Fecha_Asignacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Asignacion.Location = New System.Drawing.Point(127, 435)
        Me.dtp_Fecha_Asignacion.Name = "dtp_Fecha_Asignacion"
        Me.dtp_Fecha_Asignacion.Size = New System.Drawing.Size(106, 20)
        Me.dtp_Fecha_Asignacion.TabIndex = 14
        '
        'lbl_Fecha_Asignacion
        '
        Me.lbl_Fecha_Asignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha_Asignacion.AutoSize = True
        Me.lbl_Fecha_Asignacion.Location = New System.Drawing.Point(13, 441)
        Me.lbl_Fecha_Asignacion.Name = "lbl_Fecha_Asignacion"
        Me.lbl_Fecha_Asignacion.Size = New System.Drawing.Size(108, 13)
        Me.lbl_Fecha_Asignacion.TabIndex = 13
        Me.lbl_Fecha_Asignacion.Text = "Fecha Asignación"
        '
        'Tab_CasetDisponibles
        '
        Me.Tab_CasetDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_CasetDisponibles.Controls.Add(Me.tbp_CasetNorma)
        Me.Tab_CasetDisponibles.Controls.Add(Me.tbp_SeguridadInterna)
        Me.Tab_CasetDisponibles.Location = New System.Drawing.Point(10, 43)
        Me.Tab_CasetDisponibles.Name = "Tab_CasetDisponibles"
        Me.Tab_CasetDisponibles.SelectedIndex = 0
        Me.Tab_CasetDisponibles.Size = New System.Drawing.Size(467, 386)
        Me.Tab_CasetDisponibles.TabIndex = 12
        '
        'tbp_CasetNorma
        '
        Me.tbp_CasetNorma.Controls.Add(Me.lsv_CasetDisponibles)
        Me.tbp_CasetNorma.Location = New System.Drawing.Point(4, 22)
        Me.tbp_CasetNorma.Name = "tbp_CasetNorma"
        Me.tbp_CasetNorma.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_CasetNorma.Size = New System.Drawing.Size(459, 360)
        Me.tbp_CasetNorma.TabIndex = 0
        Me.tbp_CasetNorma.Text = "Caset Normal"
        Me.tbp_CasetNorma.UseVisualStyleBackColor = True
        '
        'tbp_SeguridadInterna
        '
        Me.tbp_SeguridadInterna.Controls.Add(Me.lsv_Seguridad)
        Me.tbp_SeguridadInterna.Location = New System.Drawing.Point(4, 22)
        Me.tbp_SeguridadInterna.Name = "tbp_SeguridadInterna"
        Me.tbp_SeguridadInterna.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_SeguridadInterna.Size = New System.Drawing.Size(459, 360)
        Me.tbp_SeguridadInterna.TabIndex = 1
        Me.tbp_SeguridadInterna.Text = "Caset Seguridad"
        Me.tbp_SeguridadInterna.UseVisualStyleBackColor = True
        '
        'lbl_ScanearCasset
        '
        Me.lbl_ScanearCasset.AutoSize = True
        Me.lbl_ScanearCasset.Location = New System.Drawing.Point(3, 26)
        Me.lbl_ScanearCasset.Name = "lbl_ScanearCasset"
        Me.lbl_ScanearCasset.Size = New System.Drawing.Size(90, 13)
        Me.lbl_ScanearCasset.TabIndex = 10
        Me.lbl_ScanearCasset.Text = "Scanear Caset"
        '
        'lbl_CasetsDisponibles
        '
        Me.lbl_CasetsDisponibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CasetsDisponibles.AutoSize = True
        Me.lbl_CasetsDisponibles.Location = New System.Drawing.Point(352, 26)
        Me.lbl_CasetsDisponibles.Name = "lbl_CasetsDisponibles"
        Me.lbl_CasetsDisponibles.Size = New System.Drawing.Size(125, 13)
        Me.lbl_CasetsDisponibles.TabIndex = 9
        Me.lbl_CasetsDisponibles.Text = "0 Casets Disponibles"
        '
        'gbx_CasetAsignados
        '
        Me.gbx_CasetAsignados.Controls.Add(Me.btn_Retirar)
        Me.gbx_CasetAsignados.Controls.Add(Me.tbx_Observaciones)
        Me.gbx_CasetAsignados.Controls.Add(Me.lbl_ObrsevacionCancela)
        Me.gbx_CasetAsignados.Controls.Add(Me.dtp_Fecha_Cancela)
        Me.gbx_CasetAsignados.Controls.Add(Me.lbl_Fecha_Cancela)
        Me.gbx_CasetAsignados.Controls.Add(Me.lsv_CasetAsignados)
        Me.gbx_CasetAsignados.Controls.Add(Me.lbl_CasetsAsignados)
        Me.gbx_CasetAsignados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_CasetAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_CasetAsignados.Location = New System.Drawing.Point(0, 0)
        Me.gbx_CasetAsignados.Name = "gbx_CasetAsignados"
        Me.gbx_CasetAsignados.Size = New System.Drawing.Size(492, 519)
        Me.gbx_CasetAsignados.TabIndex = 0
        Me.gbx_CasetAsignados.TabStop = False
        Me.gbx_CasetAsignados.Text = "Casets Asignados"
        '
        'btn_Retirar
        '
        Me.btn_Retirar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Retirar.Location = New System.Drawing.Point(411, 490)
        Me.btn_Retirar.Name = "btn_Retirar"
        Me.btn_Retirar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Retirar.TabIndex = 15
        Me.btn_Retirar.Text = "Retirar"
        Me.btn_Retirar.UseVisualStyleBackColor = True
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Observaciones.Location = New System.Drawing.Point(137, 419)
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(352, 65)
        Me.tbx_Observaciones.TabIndex = 14
        Me.tbx_Observaciones.Text = ""
        '
        'lbl_ObrsevacionCancela
        '
        Me.lbl_ObrsevacionCancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ObrsevacionCancela.AutoSize = True
        Me.lbl_ObrsevacionCancela.Location = New System.Drawing.Point(3, 435)
        Me.lbl_ObrsevacionCancela.Name = "lbl_ObrsevacionCancela"
        Me.lbl_ObrsevacionCancela.Size = New System.Drawing.Size(128, 13)
        Me.lbl_ObrsevacionCancela.TabIndex = 13
        Me.lbl_ObrsevacionCancela.Text = "Observación Cancela"
        Me.lbl_ObrsevacionCancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_Fecha_Cancela
        '
        Me.dtp_Fecha_Cancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_Fecha_Cancela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha_Cancela.Location = New System.Drawing.Point(106, 393)
        Me.dtp_Fecha_Cancela.Name = "dtp_Fecha_Cancela"
        Me.dtp_Fecha_Cancela.Size = New System.Drawing.Size(98, 20)
        Me.dtp_Fecha_Cancela.TabIndex = 12
        '
        'lbl_Fecha_Cancela
        '
        Me.lbl_Fecha_Cancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha_Cancela.AutoSize = True
        Me.lbl_Fecha_Cancela.Location = New System.Drawing.Point(5, 399)
        Me.lbl_Fecha_Cancela.Name = "lbl_Fecha_Cancela"
        Me.lbl_Fecha_Cancela.Size = New System.Drawing.Size(95, 13)
        Me.lbl_Fecha_Cancela.TabIndex = 11
        Me.lbl_Fecha_Cancela.Text = "Fecha_Cancela"
        '
        'lbl_CasetsAsignados
        '
        Me.lbl_CasetsAsignados.AutoSize = True
        Me.lbl_CasetsAsignados.Location = New System.Drawing.Point(6, 26)
        Me.lbl_CasetsAsignados.Name = "lbl_CasetsAsignados"
        Me.lbl_CasetsAsignados.Size = New System.Drawing.Size(118, 13)
        Me.lbl_CasetsAsignados.TabIndex = 9
        Me.lbl_CasetsAsignados.Text = "0 Casets Asignados"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_Cliente.Clave = Nothing
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(127, 463)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(346, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 16
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'lsv_CasetDisponibles
        '
        Me.lsv_CasetDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CasetDisponibles.CheckBoxes = True
        Me.lsv_CasetDisponibles.FullRowSelect = True
        Me.lsv_CasetDisponibles.HideSelection = False
        Me.lsv_CasetDisponibles.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_CasetDisponibles.Lvs = ListViewColumnSorter1
        Me.lsv_CasetDisponibles.MultiSelect = False
        Me.lsv_CasetDisponibles.Name = "lsv_CasetDisponibles"
        Me.lsv_CasetDisponibles.Row1 = 20
        Me.lsv_CasetDisponibles.Row10 = 0
        Me.lsv_CasetDisponibles.Row2 = 20
        Me.lsv_CasetDisponibles.Row3 = 40
        Me.lsv_CasetDisponibles.Row4 = 20
        Me.lsv_CasetDisponibles.Row5 = 20
        Me.lsv_CasetDisponibles.Row6 = 20
        Me.lsv_CasetDisponibles.Row7 = 20
        Me.lsv_CasetDisponibles.Row8 = 0
        Me.lsv_CasetDisponibles.Row9 = 0
        Me.lsv_CasetDisponibles.Size = New System.Drawing.Size(453, 354)
        Me.lsv_CasetDisponibles.TabIndex = 0
        Me.lsv_CasetDisponibles.UseCompatibleStateImageBehavior = False
        Me.lsv_CasetDisponibles.View = System.Windows.Forms.View.Details
        '
        'lsv_Seguridad
        '
        Me.lsv_Seguridad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Seguridad.FullRowSelect = True
        Me.lsv_Seguridad.HideSelection = False
        Me.lsv_Seguridad.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Seguridad.Lvs = ListViewColumnSorter2
        Me.lsv_Seguridad.MultiSelect = False
        Me.lsv_Seguridad.Name = "lsv_Seguridad"
        Me.lsv_Seguridad.Row1 = 20
        Me.lsv_Seguridad.Row10 = 20
        Me.lsv_Seguridad.Row2 = 20
        Me.lsv_Seguridad.Row3 = 40
        Me.lsv_Seguridad.Row4 = 20
        Me.lsv_Seguridad.Row5 = 20
        Me.lsv_Seguridad.Row6 = 20
        Me.lsv_Seguridad.Row7 = 0
        Me.lsv_Seguridad.Row8 = 0
        Me.lsv_Seguridad.Row9 = 0
        Me.lsv_Seguridad.Size = New System.Drawing.Size(453, 354)
        Me.lsv_Seguridad.TabIndex = 1
        Me.lsv_Seguridad.UseCompatibleStateImageBehavior = False
        Me.lsv_Seguridad.View = System.Windows.Forms.View.Details
        '
        'tbx_CodigoBarra
        '
        Me.tbx_CodigoBarra.Control_Siguiente = Nothing
        Me.tbx_CodigoBarra.Filtrado = True
        Me.tbx_CodigoBarra.Location = New System.Drawing.Point(99, 23)
        Me.tbx_CodigoBarra.Name = "tbx_CodigoBarra"
        Me.tbx_CodigoBarra.Size = New System.Drawing.Size(188, 20)
        Me.tbx_CodigoBarra.TabIndex = 11
        Me.tbx_CodigoBarra.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'lsv_CasetAsignados
        '
        Me.lsv_CasetAsignados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CasetAsignados.CheckBoxes = True
        Me.lsv_CasetAsignados.FullRowSelect = True
        Me.lsv_CasetAsignados.HideSelection = False
        Me.lsv_CasetAsignados.Location = New System.Drawing.Point(3, 43)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_CasetAsignados.Lvs = ListViewColumnSorter3
        Me.lsv_CasetAsignados.MultiSelect = False
        Me.lsv_CasetAsignados.Name = "lsv_CasetAsignados"
        Me.lsv_CasetAsignados.Row1 = 20
        Me.lsv_CasetAsignados.Row10 = 20
        Me.lsv_CasetAsignados.Row2 = 40
        Me.lsv_CasetAsignados.Row3 = 20
        Me.lsv_CasetAsignados.Row4 = 20
        Me.lsv_CasetAsignados.Row5 = 20
        Me.lsv_CasetAsignados.Row6 = 20
        Me.lsv_CasetAsignados.Row7 = 0
        Me.lsv_CasetAsignados.Row8 = 0
        Me.lsv_CasetAsignados.Row9 = 0
        Me.lsv_CasetAsignados.Size = New System.Drawing.Size(486, 344)
        Me.lsv_CasetAsignados.TabIndex = 10
        Me.lsv_CasetAsignados.UseCompatibleStateImageBehavior = False
        Me.lsv_CasetAsignados.View = System.Windows.Forms.View.Details
        '
        'frm_CasetAsignaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 592)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Container)
        Me.MinimizeBox = False
        Me.Name = "frm_CasetAsignaCliente"
        Me.Text = "Asignacion de Caset a Clientes"
        Me.gbx_Botones.ResumeLayout(False)
        Me.Container.Panel1.ResumeLayout(False)
        Me.Container.Panel2.ResumeLayout(False)
        Me.Container.ResumeLayout(False)
        Me.gbx_CasetDisponibles.ResumeLayout(False)
        Me.gbx_CasetDisponibles.PerformLayout()
        Me.Tab_CasetDisponibles.ResumeLayout(False)
        Me.tbp_CasetNorma.ResumeLayout(False)
        Me.tbp_SeguridadInterna.ResumeLayout(False)
        Me.gbx_CasetAsignados.ResumeLayout(False)
        Me.gbx_CasetAsignados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Container As System.Windows.Forms.SplitContainer
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_CasetDisponibles As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_CasetAsignados As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ScanearCasset As System.Windows.Forms.Label
    Friend WithEvents lbl_CasetsDisponibles As System.Windows.Forms.Label
    Friend WithEvents btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents cmb_Cliente As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_ClienteAsignar As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha_Asignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha_Asignacion As System.Windows.Forms.Label
    Friend WithEvents Tab_CasetDisponibles As System.Windows.Forms.TabControl
    Friend WithEvents tbp_CasetNorma As System.Windows.Forms.TabPage
    Friend WithEvents tbp_SeguridadInterna As System.Windows.Forms.TabPage
    Friend WithEvents tbx_CodigoBarra As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_CasetsAsignados As System.Windows.Forms.Label
    Friend WithEvents lsv_CasetDisponibles As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Seguridad As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_ObrsevacionCancela As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha_Cancela As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha_Cancela As System.Windows.Forms.Label
    Friend WithEvents lsv_CasetAsignados As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Retirar As System.Windows.Forms.Button
    Friend WithEvents tbx_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
