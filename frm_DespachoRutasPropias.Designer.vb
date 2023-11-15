<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DespachoRutasPropias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DespachoRutasPropias))
        Dim ListViewColumnSorter12 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter13 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter14 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter9 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter11 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter15 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter16 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter17 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter10 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Ruta = New System.Windows.Forms.Label()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Despachar = New System.Windows.Forms.Button()
        Me.Tab_Atms = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_RegistrosATMs = New System.Windows.Forms.Label()
        Me.Tab_Materiales = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_RegistrosM = New System.Windows.Forms.Label()
        Me.Tab_Clientes = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_RegistrosC = New System.Windows.Forms.Label()
        Me.TC_Servicios = New System.Windows.Forms.TabControl()
        Me.tbx_Envase = New Modulo_Recepcion.cp_Textbox()
        Me.lsv_envases = New Modulo_Recepcion.cp_Listview()
        Me.Lsv_BovedaT = New Modulo_Recepcion.cp_Listview()
        Me.Lsv_Boveda = New Modulo_Recepcion.cp_Listview()
        Me.Lsv_EnvasesMat = New Modulo_Recepcion.cp_Listview()
        Me.txt_envasemat = New Modulo_Recepcion.cp_Textbox()
        Me.Lsv_Materiales = New Modulo_Recepcion.cp_Listview()
        Me.tbx_Envase1 = New Modulo_Recepcion.cp_Textbox()
        Me.lsv_envasesatm = New Modulo_Recepcion.cp_Listview()
        Me.Lsv_AtmsT = New Modulo_Recepcion.cp_Listview()
        Me.Lsv_Atms = New Modulo_Recepcion.cp_Listview()
        Me.cmb_Ruta = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam()
        Me.Lsv_MaterialesT = New Modulo_Recepcion.cp_Listview()
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Tab_Atms.SuspendLayout()
        Me.Tab_Materiales.SuspendLayout()
        Me.Tab_Clientes.SuspendLayout()
        Me.TC_Servicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Fecha)
        Me.Gbx_Filtro.Controls.Add(Me.DTP_Fecha)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Ruta)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Ruta)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(900, 45)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(437, 18)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 3
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fecha.Location = New System.Drawing.Point(480, 15)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.DTP_Fecha.TabIndex = 4
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Location = New System.Drawing.Point(6, 19)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Ruta.TabIndex = 0
        Me.Lbl_Ruta.Text = "Ruta"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Despachar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 626)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(900, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(754, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Despachar
        '
        Me.Btn_Despachar.Enabled = False
        Me.Btn_Despachar.Image = CType(resources.GetObject("Btn_Despachar.Image"), System.Drawing.Image)
        Me.Btn_Despachar.Location = New System.Drawing.Point(6, 13)
        Me.Btn_Despachar.Name = "Btn_Despachar"
        Me.Btn_Despachar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Despachar.TabIndex = 0
        Me.Btn_Despachar.Text = "&Despachar"
        Me.Btn_Despachar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Despachar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Despachar.UseVisualStyleBackColor = True
        '
        'Tab_Atms
        '
        Me.Tab_Atms.Controls.Add(Me.Label2)
        Me.Tab_Atms.Controls.Add(Me.tbx_Envase1)
        Me.Tab_Atms.Controls.Add(Me.lsv_envasesatm)
        Me.Tab_Atms.Controls.Add(Me.Lbl_RegistrosATMs)
        Me.Tab_Atms.Controls.Add(Me.Lsv_AtmsT)
        Me.Tab_Atms.Controls.Add(Me.Lsv_Atms)
        Me.Tab_Atms.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Atms.Name = "Tab_Atms"
        Me.Tab_Atms.Size = New System.Drawing.Size(892, 541)
        Me.Tab_Atms.TabIndex = 4
        Me.Tab_Atms.Text = "ATM's"
        Me.Tab_Atms.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Envase:"
        '
        'Lbl_RegistrosATMs
        '
        Me.Lbl_RegistrosATMs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosATMs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosATMs.Location = New System.Drawing.Point(746, 3)
        Me.Lbl_RegistrosATMs.Name = "Lbl_RegistrosATMs"
        Me.Lbl_RegistrosATMs.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosATMs.TabIndex = 7
        Me.Lbl_RegistrosATMs.Text = "Registros: 0"
        Me.Lbl_RegistrosATMs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Materiales
        '
        Me.Tab_Materiales.Controls.Add(Me.Lsv_EnvasesMat)
        Me.Tab_Materiales.Controls.Add(Me.Label3)
        Me.Tab_Materiales.Controls.Add(Me.Lbl_RegistrosM)
        Me.Tab_Materiales.Controls.Add(Me.txt_envasemat)
        Me.Tab_Materiales.Controls.Add(Me.Lsv_MaterialesT)
        Me.Tab_Materiales.Controls.Add(Me.Lsv_Materiales)
        Me.Tab_Materiales.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Materiales.Name = "Tab_Materiales"
        Me.Tab_Materiales.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Materiales.Size = New System.Drawing.Size(892, 541)
        Me.Tab_Materiales.TabIndex = 1
        Me.Tab_Materiales.Text = "Materiales"
        Me.Tab_Materiales.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Envase:"
        '
        'Lbl_RegistrosM
        '
        Me.Lbl_RegistrosM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosM.Location = New System.Drawing.Point(746, 3)
        Me.Lbl_RegistrosM.Name = "Lbl_RegistrosM"
        Me.Lbl_RegistrosM.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosM.TabIndex = 7
        Me.Lbl_RegistrosM.Text = "Registros: 0"
        Me.Lbl_RegistrosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Clientes
        '
        Me.Tab_Clientes.Controls.Add(Me.tbx_Envase)
        Me.Tab_Clientes.Controls.Add(Me.Label1)
        Me.Tab_Clientes.Controls.Add(Me.lsv_envases)
        Me.Tab_Clientes.Controls.Add(Me.Lbl_RegistrosC)
        Me.Tab_Clientes.Controls.Add(Me.Lsv_BovedaT)
        Me.Tab_Clientes.Controls.Add(Me.Lsv_Boveda)
        Me.Tab_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Clientes.Name = "Tab_Clientes"
        Me.Tab_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Clientes.Size = New System.Drawing.Size(892, 541)
        Me.Tab_Clientes.TabIndex = 0
        Me.Tab_Clientes.Text = "Clientes"
        Me.Tab_Clientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Envase:"
        '
        'Lbl_RegistrosC
        '
        Me.Lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosC.Location = New System.Drawing.Point(746, 3)
        Me.Lbl_RegistrosC.Name = "Lbl_RegistrosC"
        Me.Lbl_RegistrosC.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosC.TabIndex = 7
        Me.Lbl_RegistrosC.Text = "Registros: 0"
        Me.Lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TC_Servicios
        '
        Me.TC_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC_Servicios.Controls.Add(Me.Tab_Clientes)
        Me.TC_Servicios.Controls.Add(Me.Tab_Materiales)
        Me.TC_Servicios.Controls.Add(Me.Tab_Atms)
        Me.TC_Servicios.Location = New System.Drawing.Point(9, 53)
        Me.TC_Servicios.Name = "TC_Servicios"
        Me.TC_Servicios.SelectedIndex = 0
        Me.TC_Servicios.Size = New System.Drawing.Size(900, 567)
        Me.TC_Servicios.TabIndex = 1
        '
        'tbx_Envase
        '
        Me.tbx_Envase.Control_Siguiente = Nothing
        Me.tbx_Envase.Filtrado = True
        Me.tbx_Envase.Location = New System.Drawing.Point(58, 18)
        Me.tbx_Envase.MaxLength = 15
        Me.tbx_Envase.Name = "tbx_Envase"
        Me.tbx_Envase.Size = New System.Drawing.Size(150, 20)
        Me.tbx_Envase.TabIndex = 18
        Me.tbx_Envase.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_envases
        '
        Me.lsv_envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_envases.FullRowSelect = True
        Me.lsv_envases.HideSelection = False
        Me.lsv_envases.Location = New System.Drawing.Point(534, 351)
        ListViewColumnSorter12.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter12.SortColumn = 0
        Me.lsv_envases.Lvs = ListViewColumnSorter12
        Me.lsv_envases.MultiSelect = False
        Me.lsv_envases.Name = "lsv_envases"
        Me.lsv_envases.Row1 = 35
        Me.lsv_envases.Row10 = 10
        Me.lsv_envases.Row2 = 35
        Me.lsv_envases.Row3 = 35
        Me.lsv_envases.Row4 = 10
        Me.lsv_envases.Row5 = 10
        Me.lsv_envases.Row6 = 10
        Me.lsv_envases.Row7 = 10
        Me.lsv_envases.Row8 = 10
        Me.lsv_envases.Row9 = 10
        Me.lsv_envases.Size = New System.Drawing.Size(355, 187)
        Me.lsv_envases.TabIndex = 12
        Me.lsv_envases.UseCompatibleStateImageBehavior = False
        Me.lsv_envases.View = System.Windows.Forms.View.Details
        '
        'Lsv_BovedaT
        '
        Me.Lsv_BovedaT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_BovedaT.FullRowSelect = True
        Me.Lsv_BovedaT.HideSelection = False
        Me.Lsv_BovedaT.Location = New System.Drawing.Point(3, 351)
        ListViewColumnSorter13.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter13.SortColumn = 0
        Me.Lsv_BovedaT.Lvs = ListViewColumnSorter13
        Me.Lsv_BovedaT.MultiSelect = False
        Me.Lsv_BovedaT.Name = "Lsv_BovedaT"
        Me.Lsv_BovedaT.Row1 = 10
        Me.Lsv_BovedaT.Row10 = 10
        Me.Lsv_BovedaT.Row2 = 10
        Me.Lsv_BovedaT.Row3 = 10
        Me.Lsv_BovedaT.Row4 = 10
        Me.Lsv_BovedaT.Row5 = 10
        Me.Lsv_BovedaT.Row6 = 10
        Me.Lsv_BovedaT.Row7 = 10
        Me.Lsv_BovedaT.Row8 = 10
        Me.Lsv_BovedaT.Row9 = 10
        Me.Lsv_BovedaT.Size = New System.Drawing.Size(525, 187)
        Me.Lsv_BovedaT.TabIndex = 1
        Me.Lsv_BovedaT.UseCompatibleStateImageBehavior = False
        Me.Lsv_BovedaT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Boveda
        '
        Me.Lsv_Boveda.AllowColumnReorder = True
        Me.Lsv_Boveda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Boveda.FullRowSelect = True
        Me.Lsv_Boveda.HideSelection = False
        Me.Lsv_Boveda.Location = New System.Drawing.Point(3, 51)
        ListViewColumnSorter14.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter14.SortColumn = 0
        Me.Lsv_Boveda.Lvs = ListViewColumnSorter14
        Me.Lsv_Boveda.MultiSelect = False
        Me.Lsv_Boveda.Name = "Lsv_Boveda"
        Me.Lsv_Boveda.Row1 = 10
        Me.Lsv_Boveda.Row10 = 0
        Me.Lsv_Boveda.Row2 = 25
        Me.Lsv_Boveda.Row3 = 25
        Me.Lsv_Boveda.Row4 = 15
        Me.Lsv_Boveda.Row5 = 10
        Me.Lsv_Boveda.Row6 = 10
        Me.Lsv_Boveda.Row7 = 0
        Me.Lsv_Boveda.Row8 = 0
        Me.Lsv_Boveda.Row9 = 0
        Me.Lsv_Boveda.Size = New System.Drawing.Size(886, 294)
        Me.Lsv_Boveda.TabIndex = 0
        Me.Lsv_Boveda.UseCompatibleStateImageBehavior = False
        Me.Lsv_Boveda.View = System.Windows.Forms.View.Details
        '
        'Lsv_EnvasesMat
        '
        Me.Lsv_EnvasesMat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_EnvasesMat.FullRowSelect = True
        Me.Lsv_EnvasesMat.HideSelection = False
        Me.Lsv_EnvasesMat.Location = New System.Drawing.Point(534, 351)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.Lsv_EnvasesMat.Lvs = ListViewColumnSorter9
        Me.Lsv_EnvasesMat.MultiSelect = False
        Me.Lsv_EnvasesMat.Name = "Lsv_EnvasesMat"
        Me.Lsv_EnvasesMat.Row1 = 35
        Me.Lsv_EnvasesMat.Row10 = 10
        Me.Lsv_EnvasesMat.Row2 = 35
        Me.Lsv_EnvasesMat.Row3 = 35
        Me.Lsv_EnvasesMat.Row4 = 10
        Me.Lsv_EnvasesMat.Row5 = 10
        Me.Lsv_EnvasesMat.Row6 = 10
        Me.Lsv_EnvasesMat.Row7 = 10
        Me.Lsv_EnvasesMat.Row8 = 10
        Me.Lsv_EnvasesMat.Row9 = 10
        Me.Lsv_EnvasesMat.Size = New System.Drawing.Size(355, 187)
        Me.Lsv_EnvasesMat.TabIndex = 18
        Me.Lsv_EnvasesMat.UseCompatibleStateImageBehavior = False
        Me.Lsv_EnvasesMat.View = System.Windows.Forms.View.Details
        '
        'txt_envasemat
        '
        Me.txt_envasemat.Control_Siguiente = Nothing
        Me.txt_envasemat.Filtrado = True
        Me.txt_envasemat.Location = New System.Drawing.Point(58, 18)
        Me.txt_envasemat.MaxLength = 15
        Me.txt_envasemat.Name = "txt_envasemat"
        Me.txt_envasemat.Size = New System.Drawing.Size(150, 20)
        Me.txt_envasemat.TabIndex = 17
        Me.txt_envasemat.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Lsv_Materiales
        '
        Me.Lsv_Materiales.AllowColumnReorder = True
        Me.Lsv_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Materiales.FullRowSelect = True
        Me.Lsv_Materiales.HideSelection = False
        Me.Lsv_Materiales.Location = New System.Drawing.Point(3, 51)
        ListViewColumnSorter11.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter11.SortColumn = 0
        Me.Lsv_Materiales.Lvs = ListViewColumnSorter11
        Me.Lsv_Materiales.MultiSelect = False
        Me.Lsv_Materiales.Name = "Lsv_Materiales"
        Me.Lsv_Materiales.Row1 = 10
        Me.Lsv_Materiales.Row10 = 0
        Me.Lsv_Materiales.Row2 = 25
        Me.Lsv_Materiales.Row3 = 25
        Me.Lsv_Materiales.Row4 = 15
        Me.Lsv_Materiales.Row5 = 11
        Me.Lsv_Materiales.Row6 = 10
        Me.Lsv_Materiales.Row7 = 0
        Me.Lsv_Materiales.Row8 = 0
        Me.Lsv_Materiales.Row9 = 0
        Me.Lsv_Materiales.Size = New System.Drawing.Size(886, 294)
        Me.Lsv_Materiales.TabIndex = 0
        Me.Lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.Lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'tbx_Envase1
        '
        Me.tbx_Envase1.Control_Siguiente = Nothing
        Me.tbx_Envase1.Filtrado = True
        Me.tbx_Envase1.Location = New System.Drawing.Point(58, 18)
        Me.tbx_Envase1.MaxLength = 15
        Me.tbx_Envase1.Name = "tbx_Envase1"
        Me.tbx_Envase1.Size = New System.Drawing.Size(150, 20)
        Me.tbx_Envase1.TabIndex = 16
        Me.tbx_Envase1.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_envasesatm
        '
        Me.lsv_envasesatm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_envasesatm.FullRowSelect = True
        Me.lsv_envasesatm.HideSelection = False
        Me.lsv_envasesatm.Location = New System.Drawing.Point(534, 351)
        ListViewColumnSorter15.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter15.SortColumn = 0
        Me.lsv_envasesatm.Lvs = ListViewColumnSorter15
        Me.lsv_envasesatm.MultiSelect = False
        Me.lsv_envasesatm.Name = "lsv_envasesatm"
        Me.lsv_envasesatm.Row1 = 35
        Me.lsv_envasesatm.Row10 = 10
        Me.lsv_envasesatm.Row2 = 35
        Me.lsv_envasesatm.Row3 = 35
        Me.lsv_envasesatm.Row4 = 10
        Me.lsv_envasesatm.Row5 = 10
        Me.lsv_envasesatm.Row6 = 10
        Me.lsv_envasesatm.Row7 = 10
        Me.lsv_envasesatm.Row8 = 10
        Me.lsv_envasesatm.Row9 = 10
        Me.lsv_envasesatm.Size = New System.Drawing.Size(355, 187)
        Me.lsv_envasesatm.TabIndex = 14
        Me.lsv_envasesatm.UseCompatibleStateImageBehavior = False
        Me.lsv_envasesatm.View = System.Windows.Forms.View.Details
        '
        'Lsv_AtmsT
        '
        Me.Lsv_AtmsT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_AtmsT.FullRowSelect = True
        Me.Lsv_AtmsT.HideSelection = False
        Me.Lsv_AtmsT.Location = New System.Drawing.Point(3, 351)
        ListViewColumnSorter16.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter16.SortColumn = 0
        Me.Lsv_AtmsT.Lvs = ListViewColumnSorter16
        Me.Lsv_AtmsT.MultiSelect = False
        Me.Lsv_AtmsT.Name = "Lsv_AtmsT"
        Me.Lsv_AtmsT.Row1 = 10
        Me.Lsv_AtmsT.Row10 = 10
        Me.Lsv_AtmsT.Row2 = 10
        Me.Lsv_AtmsT.Row3 = 10
        Me.Lsv_AtmsT.Row4 = 10
        Me.Lsv_AtmsT.Row5 = 10
        Me.Lsv_AtmsT.Row6 = 10
        Me.Lsv_AtmsT.Row7 = 10
        Me.Lsv_AtmsT.Row8 = 10
        Me.Lsv_AtmsT.Row9 = 10
        Me.Lsv_AtmsT.Size = New System.Drawing.Size(525, 187)
        Me.Lsv_AtmsT.TabIndex = 1
        Me.Lsv_AtmsT.UseCompatibleStateImageBehavior = False
        Me.Lsv_AtmsT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Atms
        '
        Me.Lsv_Atms.AllowColumnReorder = True
        Me.Lsv_Atms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Atms.FullRowSelect = True
        Me.Lsv_Atms.HideSelection = False
        Me.Lsv_Atms.Location = New System.Drawing.Point(3, 51)
        ListViewColumnSorter17.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter17.SortColumn = 0
        Me.Lsv_Atms.Lvs = ListViewColumnSorter17
        Me.Lsv_Atms.MultiSelect = False
        Me.Lsv_Atms.Name = "Lsv_Atms"
        Me.Lsv_Atms.Row1 = 10
        Me.Lsv_Atms.Row10 = 0
        Me.Lsv_Atms.Row2 = 15
        Me.Lsv_Atms.Row3 = 20
        Me.Lsv_Atms.Row4 = 5
        Me.Lsv_Atms.Row5 = 10
        Me.Lsv_Atms.Row6 = 10
        Me.Lsv_Atms.Row7 = 10
        Me.Lsv_Atms.Row8 = 0
        Me.Lsv_Atms.Row9 = 0
        Me.Lsv_Atms.Size = New System.Drawing.Size(886, 294)
        Me.Lsv_Atms.TabIndex = 0
        Me.Lsv_Atms.UseCompatibleStateImageBehavior = False
        Me.Lsv_Atms.View = System.Windows.Forms.View.Details
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Clave = "Clave"
        Me.cmb_Ruta.Control_Siguiente = Me.DTP_Fecha
        Me.cmb_Ruta.DisplayMember = "Descripcion"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.Empresa = False
        Me.cmb_Ruta.Filtro = Nothing
        Me.cmb_Ruta.Location = New System.Drawing.Point(42, 16)
        Me.cmb_Ruta.MaxDropDownItems = 20
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Pista = False
        Me.cmb_Ruta.Size = New System.Drawing.Size(377, 21)
        Me.cmb_Ruta.StoredProcedure = "CAT_Rutas_Programadas"
        Me.cmb_Ruta.Sucursal = False
        Me.cmb_Ruta.TabIndex = 1
        Me.cmb_Ruta.Tipo = 0
        Me.cmb_Ruta.ValueMember = "Id_Ruta"
        '
        'Lsv_MaterialesT
        '
        Me.Lsv_MaterialesT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_MaterialesT.FullRowSelect = True
        Me.Lsv_MaterialesT.HideSelection = False
        Me.Lsv_MaterialesT.Location = New System.Drawing.Point(3, 351)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.Lsv_MaterialesT.Lvs = ListViewColumnSorter10
        Me.Lsv_MaterialesT.MultiSelect = False
        Me.Lsv_MaterialesT.Name = "Lsv_MaterialesT"
        Me.Lsv_MaterialesT.Row1 = 10
        Me.Lsv_MaterialesT.Row10 = 10
        Me.Lsv_MaterialesT.Row2 = 10
        Me.Lsv_MaterialesT.Row3 = 10
        Me.Lsv_MaterialesT.Row4 = 10
        Me.Lsv_MaterialesT.Row5 = 10
        Me.Lsv_MaterialesT.Row6 = 10
        Me.Lsv_MaterialesT.Row7 = 10
        Me.Lsv_MaterialesT.Row8 = 10
        Me.Lsv_MaterialesT.Row9 = 10
        Me.Lsv_MaterialesT.Size = New System.Drawing.Size(525, 187)
        Me.Lsv_MaterialesT.TabIndex = 1
        Me.Lsv_MaterialesT.UseCompatibleStateImageBehavior = False
        Me.Lsv_MaterialesT.View = System.Windows.Forms.View.Details
        '
        'frm_DespachoRutasPropias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 688)
        Me.Controls.Add(Me.TC_Servicios)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DespachoRutasPropias"
        Me.Text = "Despacho Rutas Propias"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Tab_Atms.ResumeLayout(False)
        Me.Tab_Atms.PerformLayout()
        Me.Tab_Materiales.ResumeLayout(False)
        Me.Tab_Materiales.PerformLayout()
        Me.Tab_Clientes.ResumeLayout(False)
        Me.Tab_Clientes.PerformLayout()
        Me.TC_Servicios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents Btn_Despachar As System.Windows.Forms.Button
    Friend WithEvents cmb_Ruta As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents DTP_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Tab_Atms As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_RegistrosATMs As System.Windows.Forms.Label
    Friend WithEvents Lsv_AtmsT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Atms As Modulo_Recepcion.cp_Listview
    Friend WithEvents Tab_Materiales As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_RegistrosM As System.Windows.Forms.Label
    Friend WithEvents Lsv_Materiales As Modulo_Recepcion.cp_Listview
    Friend WithEvents Tab_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_RegistrosC As System.Windows.Forms.Label
    Friend WithEvents Lsv_BovedaT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Boveda As Modulo_Recepcion.cp_Listview
    Friend WithEvents TC_Servicios As System.Windows.Forms.TabControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsv_envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Envase1 As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lsv_envasesatm As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lsv_EnvasesMat As Modulo_Recepcion.cp_Listview
    Friend WithEvents txt_envasemat As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Envase As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lsv_MaterialesT As cp_Listview
End Class
