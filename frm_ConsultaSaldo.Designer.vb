<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaSaldo
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
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter5 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter7 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter8 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter9 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter10 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.Btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.Tab_Custodias = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosC = New System.Windows.Forms.Label
        Me.Lsv_CustodiasT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Custodias = New Modulo_Recepcion.cp_Listview
        Me.gbx_CambioRemision = New System.Windows.Forms.GroupBox
        Me.btn_CambiarRemision = New System.Windows.Forms.Button
        Me.Lbl_CambiarNumRemC = New System.Windows.Forms.Label
        Me.tbx_NuevaRemision = New Modulo_Recepcion.cp_Textbox
        Me.Tab_Procesos = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosP = New System.Windows.Forms.Label
        Me.Lsv_ProcesosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Procesos = New Modulo_Recepcion.cp_Listview
        Me.Tab_Cajeros = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosAtm = New System.Windows.Forms.Label
        Me.Lsv_CajerosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Cajeros = New Modulo_Recepcion.cp_Listview
        Me.gbx_CambioRemisionCaj = New System.Windows.Forms.GroupBox
        Me.btn_CambiarRemisionCaj = New System.Windows.Forms.Button
        Me.Lbl_CambiarNumRemAtms = New System.Windows.Forms.Label
        Me.tbx_NuevaRemisionCaj = New Modulo_Recepcion.cp_Textbox
        Me.Tab_Resguardos = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosRS = New System.Windows.Forms.Label
        Me.Lsv_ResguardosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Resguardos = New Modulo_Recepcion.cp_Listview
        Me.Tab_Materiales = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosM = New System.Windows.Forms.Label
        Me.Lsv_MaterialesT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Materiales = New Modulo_Recepcion.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ReemplazarRemision = New System.Windows.Forms.Button
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Tab_Custodias.SuspendLayout()
        Me.gbx_CambioRemision.SuspendLayout()
        Me.Tab_Procesos.SuspendLayout()
        Me.Tab_Cajeros.SuspendLayout()
        Me.gbx_CambioRemisionCaj.SuspendLayout()
        Me.Tab_Resguardos.SuspendLayout()
        Me.Tab_Materiales.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.chk_Todos)
        Me.gbx_Filtro.Controls.Add(Me.Btn_Buscar)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Remision)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Boveda)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Cve_Boveda)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Boveda)
        Me.gbx_Filtro.Location = New System.Drawing.Point(5, 2)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbx_Filtro.Size = New System.Drawing.Size(776, 67)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(445, 18)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 3
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.Btn_Buscar.Location = New System.Drawing.Point(255, 38)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buscar.TabIndex = 6
        Me.Btn_Buscar.Text = "&Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Location = New System.Drawing.Point(62, 40)
        Me.tbx_Remision.MaxLength = 20
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(187, 20)
        Me.tbx_Remision.TabIndex = 5
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(6, 44)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 4
        Me.lbl_Remision.Text = "Remisión"
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(12, 19)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(62, 14)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 1
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Me.tbx_Remision
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_Cve_Boveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(118, 14)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_Boveda.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 2
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.Tab_Custodias)
        Me.TabControl.Controls.Add(Me.Tab_Procesos)
        Me.TabControl.Controls.Add(Me.Tab_Cajeros)
        Me.TabControl.Controls.Add(Me.Tab_Resguardos)
        Me.TabControl.Controls.Add(Me.Tab_Materiales)
        Me.TabControl.Location = New System.Drawing.Point(5, 76)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(776, 432)
        Me.TabControl.TabIndex = 1
        '
        'Tab_Custodias
        '
        Me.Tab_Custodias.Controls.Add(Me.lbl_RegistrosC)
        Me.Tab_Custodias.Controls.Add(Me.Lsv_CustodiasT)
        Me.Tab_Custodias.Controls.Add(Me.Lsv_Custodias)
        Me.Tab_Custodias.Controls.Add(Me.gbx_CambioRemision)
        Me.Tab_Custodias.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Custodias.Name = "Tab_Custodias"
        Me.Tab_Custodias.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Custodias.Size = New System.Drawing.Size(768, 406)
        Me.Tab_Custodias.TabIndex = 0
        Me.Tab_Custodias.Text = "Custodias"
        Me.Tab_Custodias.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosC
        '
        Me.lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosC.Location = New System.Drawing.Point(630, 52)
        Me.lbl_RegistrosC.Name = "lbl_RegistrosC"
        Me.lbl_RegistrosC.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosC.TabIndex = 4
        Me.lbl_RegistrosC.Text = "Registros: 0"
        Me.lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_CustodiasT
        '
        Me.Lsv_CustodiasT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_CustodiasT.FullRowSelect = True
        Me.Lsv_CustodiasT.HideSelection = False
        Me.Lsv_CustodiasT.Location = New System.Drawing.Point(3, 316)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_CustodiasT.Lvs = ListViewColumnSorter1
        Me.Lsv_CustodiasT.MultiSelect = False
        Me.Lsv_CustodiasT.Name = "Lsv_CustodiasT"
        Me.Lsv_CustodiasT.Row1 = 10
        Me.Lsv_CustodiasT.Row10 = 10
        Me.Lsv_CustodiasT.Row2 = 10
        Me.Lsv_CustodiasT.Row3 = 10
        Me.Lsv_CustodiasT.Row4 = 10
        Me.Lsv_CustodiasT.Row5 = 10
        Me.Lsv_CustodiasT.Row6 = 10
        Me.Lsv_CustodiasT.Row7 = 10
        Me.Lsv_CustodiasT.Row8 = 10
        Me.Lsv_CustodiasT.Row9 = 10
        Me.Lsv_CustodiasT.Size = New System.Drawing.Size(762, 84)
        Me.Lsv_CustodiasT.TabIndex = 2
        Me.Lsv_CustodiasT.UseCompatibleStateImageBehavior = False
        Me.Lsv_CustodiasT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Custodias
        '
        Me.Lsv_Custodias.AllowColumnReorder = True
        Me.Lsv_Custodias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Custodias.CheckBoxes = True
        Me.Lsv_Custodias.FullRowSelect = True
        Me.Lsv_Custodias.HideSelection = False
        Me.Lsv_Custodias.Location = New System.Drawing.Point(3, 70)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Custodias.Lvs = ListViewColumnSorter2
        Me.Lsv_Custodias.MultiSelect = False
        Me.Lsv_Custodias.Name = "Lsv_Custodias"
        Me.Lsv_Custodias.Row1 = 8
        Me.Lsv_Custodias.Row10 = 0
        Me.Lsv_Custodias.Row2 = 8
        Me.Lsv_Custodias.Row3 = 9
        Me.Lsv_Custodias.Row4 = 25
        Me.Lsv_Custodias.Row5 = 25
        Me.Lsv_Custodias.Row6 = 10
        Me.Lsv_Custodias.Row7 = 10
        Me.Lsv_Custodias.Row8 = 0
        Me.Lsv_Custodias.Row9 = 0
        Me.Lsv_Custodias.Size = New System.Drawing.Size(762, 240)
        Me.Lsv_Custodias.TabIndex = 1
        Me.Lsv_Custodias.TabStop = False
        Me.Lsv_Custodias.UseCompatibleStateImageBehavior = False
        Me.Lsv_Custodias.View = System.Windows.Forms.View.Details
        '
        'gbx_CambioRemision
        '
        Me.gbx_CambioRemision.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CambioRemision.Controls.Add(Me.btn_CambiarRemision)
        Me.gbx_CambioRemision.Controls.Add(Me.Lbl_CambiarNumRemC)
        Me.gbx_CambioRemision.Controls.Add(Me.tbx_NuevaRemision)
        Me.gbx_CambioRemision.Location = New System.Drawing.Point(3, 3)
        Me.gbx_CambioRemision.Name = "gbx_CambioRemision"
        Me.gbx_CambioRemision.Size = New System.Drawing.Size(762, 46)
        Me.gbx_CambioRemision.TabIndex = 0
        Me.gbx_CambioRemision.TabStop = False
        '
        'btn_CambiarRemision
        '
        Me.btn_CambiarRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CambiarRemision.Enabled = False
        Me.btn_CambiarRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.btn_CambiarRemision.Location = New System.Drawing.Point(616, 10)
        Me.btn_CambiarRemision.Name = "btn_CambiarRemision"
        Me.btn_CambiarRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_CambiarRemision.TabIndex = 2
        Me.btn_CambiarRemision.Text = "Ca&mbiar"
        Me.btn_CambiarRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CambiarRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CambiarRemision.UseVisualStyleBackColor = True
        '
        'Lbl_CambiarNumRemC
        '
        Me.Lbl_CambiarNumRemC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CambiarNumRemC.AutoSize = True
        Me.Lbl_CambiarNumRemC.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CambiarNumRemC.Location = New System.Drawing.Point(333, 19)
        Me.Lbl_CambiarNumRemC.Name = "Lbl_CambiarNumRemC"
        Me.Lbl_CambiarNumRemC.Size = New System.Drawing.Size(146, 13)
        Me.Lbl_CambiarNumRemC.TabIndex = 0
        Me.Lbl_CambiarNumRemC.Text = "Cambiar Número de Remisión"
        '
        'tbx_NuevaRemision
        '
        Me.tbx_NuevaRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_NuevaRemision.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_NuevaRemision.Control_Siguiente = Me.btn_CambiarRemision
        Me.tbx_NuevaRemision.Enabled = False
        Me.tbx_NuevaRemision.Filtrado = True
        Me.tbx_NuevaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NuevaRemision.Location = New System.Drawing.Point(485, 14)
        Me.tbx_NuevaRemision.MaxLength = 15
        Me.tbx_NuevaRemision.Name = "tbx_NuevaRemision"
        Me.tbx_NuevaRemision.Size = New System.Drawing.Size(125, 23)
        Me.tbx_NuevaRemision.TabIndex = 1
        Me.tbx_NuevaRemision.TabStop = False
        Me.tbx_NuevaRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NuevaRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tab_Procesos
        '
        Me.Tab_Procesos.Controls.Add(Me.lbl_RegistrosP)
        Me.Tab_Procesos.Controls.Add(Me.Lsv_ProcesosT)
        Me.Tab_Procesos.Controls.Add(Me.Lsv_Procesos)
        Me.Tab_Procesos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Procesos.Name = "Tab_Procesos"
        Me.Tab_Procesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Procesos.Size = New System.Drawing.Size(768, 406)
        Me.Tab_Procesos.TabIndex = 1
        Me.Tab_Procesos.Text = "Proceso"
        Me.Tab_Procesos.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosP
        '
        Me.lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosP.Location = New System.Drawing.Point(627, 3)
        Me.lbl_RegistrosP.Name = "lbl_RegistrosP"
        Me.lbl_RegistrosP.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosP.TabIndex = 4
        Me.lbl_RegistrosP.Text = "Registros: 0"
        Me.lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_ProcesosT
        '
        Me.Lsv_ProcesosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ProcesosT.FullRowSelect = True
        Me.Lsv_ProcesosT.HideSelection = False
        Me.Lsv_ProcesosT.Location = New System.Drawing.Point(6, 290)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_ProcesosT.Lvs = ListViewColumnSorter3
        Me.Lsv_ProcesosT.MultiSelect = False
        Me.Lsv_ProcesosT.Name = "Lsv_ProcesosT"
        Me.Lsv_ProcesosT.Row1 = 10
        Me.Lsv_ProcesosT.Row10 = 10
        Me.Lsv_ProcesosT.Row2 = 10
        Me.Lsv_ProcesosT.Row3 = 10
        Me.Lsv_ProcesosT.Row4 = 10
        Me.Lsv_ProcesosT.Row5 = 10
        Me.Lsv_ProcesosT.Row6 = 10
        Me.Lsv_ProcesosT.Row7 = 10
        Me.Lsv_ProcesosT.Row8 = 10
        Me.Lsv_ProcesosT.Row9 = 10
        Me.Lsv_ProcesosT.Size = New System.Drawing.Size(756, 100)
        Me.Lsv_ProcesosT.TabIndex = 1
        Me.Lsv_ProcesosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ProcesosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Procesos
        '
        Me.Lsv_Procesos.AllowColumnReorder = True
        Me.Lsv_Procesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Procesos.CheckBoxes = True
        Me.Lsv_Procesos.FullRowSelect = True
        Me.Lsv_Procesos.HideSelection = False
        Me.Lsv_Procesos.Location = New System.Drawing.Point(6, 21)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.Lsv_Procesos.Lvs = ListViewColumnSorter4
        Me.Lsv_Procesos.MultiSelect = False
        Me.Lsv_Procesos.Name = "Lsv_Procesos"
        Me.Lsv_Procesos.Row1 = 9
        Me.Lsv_Procesos.Row10 = 0
        Me.Lsv_Procesos.Row2 = 9
        Me.Lsv_Procesos.Row3 = 9
        Me.Lsv_Procesos.Row4 = 29
        Me.Lsv_Procesos.Row5 = 29
        Me.Lsv_Procesos.Row6 = 10
        Me.Lsv_Procesos.Row7 = 0
        Me.Lsv_Procesos.Row8 = 0
        Me.Lsv_Procesos.Row9 = 0
        Me.Lsv_Procesos.Size = New System.Drawing.Size(756, 263)
        Me.Lsv_Procesos.TabIndex = 0
        Me.Lsv_Procesos.TabStop = False
        Me.Lsv_Procesos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Procesos.View = System.Windows.Forms.View.Details
        '
        'Tab_Cajeros
        '
        Me.Tab_Cajeros.Controls.Add(Me.lbl_RegistrosAtm)
        Me.Tab_Cajeros.Controls.Add(Me.Lsv_CajerosT)
        Me.Tab_Cajeros.Controls.Add(Me.Lsv_Cajeros)
        Me.Tab_Cajeros.Controls.Add(Me.gbx_CambioRemisionCaj)
        Me.Tab_Cajeros.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Cajeros.Name = "Tab_Cajeros"
        Me.Tab_Cajeros.Size = New System.Drawing.Size(768, 406)
        Me.Tab_Cajeros.TabIndex = 2
        Me.Tab_Cajeros.Text = "Cajeros ATM's"
        Me.Tab_Cajeros.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosAtm
        '
        Me.lbl_RegistrosAtm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosAtm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosAtm.Location = New System.Drawing.Point(628, 52)
        Me.lbl_RegistrosAtm.Name = "lbl_RegistrosAtm"
        Me.lbl_RegistrosAtm.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosAtm.TabIndex = 4
        Me.lbl_RegistrosAtm.Text = "Registros: 0"
        Me.lbl_RegistrosAtm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_CajerosT
        '
        Me.Lsv_CajerosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_CajerosT.FullRowSelect = True
        Me.Lsv_CajerosT.HideSelection = False
        Me.Lsv_CajerosT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.Lsv_CajerosT.Lvs = ListViewColumnSorter5
        Me.Lsv_CajerosT.MultiSelect = False
        Me.Lsv_CajerosT.Name = "Lsv_CajerosT"
        Me.Lsv_CajerosT.Row1 = 10
        Me.Lsv_CajerosT.Row10 = 10
        Me.Lsv_CajerosT.Row2 = 10
        Me.Lsv_CajerosT.Row3 = 10
        Me.Lsv_CajerosT.Row4 = 10
        Me.Lsv_CajerosT.Row5 = 10
        Me.Lsv_CajerosT.Row6 = 10
        Me.Lsv_CajerosT.Row7 = 10
        Me.Lsv_CajerosT.Row8 = 10
        Me.Lsv_CajerosT.Row9 = 10
        Me.Lsv_CajerosT.Size = New System.Drawing.Size(760, 103)
        Me.Lsv_CajerosT.TabIndex = 2
        Me.Lsv_CajerosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_CajerosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Cajeros
        '
        Me.Lsv_Cajeros.AllowColumnReorder = True
        Me.Lsv_Cajeros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Cajeros.FullRowSelect = True
        Me.Lsv_Cajeros.HideSelection = False
        Me.Lsv_Cajeros.Location = New System.Drawing.Point(3, 70)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.Lsv_Cajeros.Lvs = ListViewColumnSorter6
        Me.Lsv_Cajeros.MultiSelect = False
        Me.Lsv_Cajeros.Name = "Lsv_Cajeros"
        Me.Lsv_Cajeros.Row1 = 9
        Me.Lsv_Cajeros.Row10 = 0
        Me.Lsv_Cajeros.Row2 = 9
        Me.Lsv_Cajeros.Row3 = 9
        Me.Lsv_Cajeros.Row4 = 29
        Me.Lsv_Cajeros.Row5 = 29
        Me.Lsv_Cajeros.Row6 = 10
        Me.Lsv_Cajeros.Row7 = 0
        Me.Lsv_Cajeros.Row8 = 0
        Me.Lsv_Cajeros.Row9 = 0
        Me.Lsv_Cajeros.Size = New System.Drawing.Size(760, 214)
        Me.Lsv_Cajeros.TabIndex = 1
        Me.Lsv_Cajeros.TabStop = False
        Me.Lsv_Cajeros.UseCompatibleStateImageBehavior = False
        Me.Lsv_Cajeros.View = System.Windows.Forms.View.Details
        '
        'gbx_CambioRemisionCaj
        '
        Me.gbx_CambioRemisionCaj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CambioRemisionCaj.Controls.Add(Me.btn_CambiarRemisionCaj)
        Me.gbx_CambioRemisionCaj.Controls.Add(Me.Lbl_CambiarNumRemAtms)
        Me.gbx_CambioRemisionCaj.Controls.Add(Me.tbx_NuevaRemisionCaj)
        Me.gbx_CambioRemisionCaj.Location = New System.Drawing.Point(3, 3)
        Me.gbx_CambioRemisionCaj.Name = "gbx_CambioRemisionCaj"
        Me.gbx_CambioRemisionCaj.Size = New System.Drawing.Size(760, 46)
        Me.gbx_CambioRemisionCaj.TabIndex = 0
        Me.gbx_CambioRemisionCaj.TabStop = False
        '
        'btn_CambiarRemisionCaj
        '
        Me.btn_CambiarRemisionCaj.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CambiarRemisionCaj.Enabled = False
        Me.btn_CambiarRemisionCaj.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.btn_CambiarRemisionCaj.Location = New System.Drawing.Point(614, 10)
        Me.btn_CambiarRemisionCaj.Name = "btn_CambiarRemisionCaj"
        Me.btn_CambiarRemisionCaj.Size = New System.Drawing.Size(140, 30)
        Me.btn_CambiarRemisionCaj.TabIndex = 2
        Me.btn_CambiarRemisionCaj.Text = "Ca&mbiar"
        Me.btn_CambiarRemisionCaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CambiarRemisionCaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CambiarRemisionCaj.UseVisualStyleBackColor = True
        '
        'Lbl_CambiarNumRemAtms
        '
        Me.Lbl_CambiarNumRemAtms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CambiarNumRemAtms.AutoSize = True
        Me.Lbl_CambiarNumRemAtms.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CambiarNumRemAtms.Location = New System.Drawing.Point(331, 19)
        Me.Lbl_CambiarNumRemAtms.Name = "Lbl_CambiarNumRemAtms"
        Me.Lbl_CambiarNumRemAtms.Size = New System.Drawing.Size(146, 13)
        Me.Lbl_CambiarNumRemAtms.TabIndex = 0
        Me.Lbl_CambiarNumRemAtms.Text = "Cambiar Número de Remisión"
        '
        'tbx_NuevaRemisionCaj
        '
        Me.tbx_NuevaRemisionCaj.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_NuevaRemisionCaj.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_NuevaRemisionCaj.Control_Siguiente = Me.btn_CambiarRemisionCaj
        Me.tbx_NuevaRemisionCaj.Enabled = False
        Me.tbx_NuevaRemisionCaj.Filtrado = True
        Me.tbx_NuevaRemisionCaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NuevaRemisionCaj.Location = New System.Drawing.Point(483, 14)
        Me.tbx_NuevaRemisionCaj.MaxLength = 15
        Me.tbx_NuevaRemisionCaj.Name = "tbx_NuevaRemisionCaj"
        Me.tbx_NuevaRemisionCaj.Size = New System.Drawing.Size(125, 23)
        Me.tbx_NuevaRemisionCaj.TabIndex = 1
        Me.tbx_NuevaRemisionCaj.TabStop = False
        Me.tbx_NuevaRemisionCaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NuevaRemisionCaj.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tab_Resguardos
        '
        Me.Tab_Resguardos.Controls.Add(Me.lbl_RegistrosRS)
        Me.Tab_Resguardos.Controls.Add(Me.Lsv_ResguardosT)
        Me.Tab_Resguardos.Controls.Add(Me.Lsv_Resguardos)
        Me.Tab_Resguardos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Resguardos.Name = "Tab_Resguardos"
        Me.Tab_Resguardos.Size = New System.Drawing.Size(768, 406)
        Me.Tab_Resguardos.TabIndex = 3
        Me.Tab_Resguardos.Text = "Resguardos de Saldo"
        Me.Tab_Resguardos.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosRS
        '
        Me.lbl_RegistrosRS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosRS.Location = New System.Drawing.Point(628, 4)
        Me.lbl_RegistrosRS.Name = "lbl_RegistrosRS"
        Me.lbl_RegistrosRS.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosRS.TabIndex = 4
        Me.lbl_RegistrosRS.Text = "Registros: 0"
        Me.lbl_RegistrosRS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_ResguardosT
        '
        Me.Lsv_ResguardosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ResguardosT.FullRowSelect = True
        Me.Lsv_ResguardosT.HideSelection = False
        Me.Lsv_ResguardosT.Location = New System.Drawing.Point(4, 290)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.Lsv_ResguardosT.Lvs = ListViewColumnSorter7
        Me.Lsv_ResguardosT.MultiSelect = False
        Me.Lsv_ResguardosT.Name = "Lsv_ResguardosT"
        Me.Lsv_ResguardosT.Row1 = 10
        Me.Lsv_ResguardosT.Row10 = 10
        Me.Lsv_ResguardosT.Row2 = 10
        Me.Lsv_ResguardosT.Row3 = 10
        Me.Lsv_ResguardosT.Row4 = 10
        Me.Lsv_ResguardosT.Row5 = 10
        Me.Lsv_ResguardosT.Row6 = 10
        Me.Lsv_ResguardosT.Row7 = 10
        Me.Lsv_ResguardosT.Row8 = 10
        Me.Lsv_ResguardosT.Row9 = 10
        Me.Lsv_ResguardosT.Size = New System.Drawing.Size(760, 103)
        Me.Lsv_ResguardosT.TabIndex = 1
        Me.Lsv_ResguardosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ResguardosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Resguardos
        '
        Me.Lsv_Resguardos.AllowColumnReorder = True
        Me.Lsv_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Resguardos.FullRowSelect = True
        Me.Lsv_Resguardos.HideSelection = False
        Me.Lsv_Resguardos.Location = New System.Drawing.Point(4, 22)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.Lsv_Resguardos.Lvs = ListViewColumnSorter8
        Me.Lsv_Resguardos.MultiSelect = False
        Me.Lsv_Resguardos.Name = "Lsv_Resguardos"
        Me.Lsv_Resguardos.Row1 = 9
        Me.Lsv_Resguardos.Row10 = 0
        Me.Lsv_Resguardos.Row2 = 9
        Me.Lsv_Resguardos.Row3 = 9
        Me.Lsv_Resguardos.Row4 = 29
        Me.Lsv_Resguardos.Row5 = 29
        Me.Lsv_Resguardos.Row6 = 10
        Me.Lsv_Resguardos.Row7 = 0
        Me.Lsv_Resguardos.Row8 = 0
        Me.Lsv_Resguardos.Row9 = 0
        Me.Lsv_Resguardos.Size = New System.Drawing.Size(760, 262)
        Me.Lsv_Resguardos.TabIndex = 0
        Me.Lsv_Resguardos.TabStop = False
        Me.Lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'Tab_Materiales
        '
        Me.Tab_Materiales.Controls.Add(Me.lbl_RegistrosM)
        Me.Tab_Materiales.Controls.Add(Me.Lsv_MaterialesT)
        Me.Tab_Materiales.Controls.Add(Me.Lsv_Materiales)
        Me.Tab_Materiales.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Materiales.Name = "Tab_Materiales"
        Me.Tab_Materiales.Size = New System.Drawing.Size(768, 406)
        Me.Tab_Materiales.TabIndex = 4
        Me.Tab_Materiales.Text = "Materiales"
        Me.Tab_Materiales.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosM
        '
        Me.lbl_RegistrosM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosM.Location = New System.Drawing.Point(628, 5)
        Me.lbl_RegistrosM.Name = "lbl_RegistrosM"
        Me.lbl_RegistrosM.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosM.TabIndex = 4
        Me.lbl_RegistrosM.Text = "Registros: 0"
        Me.lbl_RegistrosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_MaterialesT
        '
        Me.Lsv_MaterialesT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_MaterialesT.FullRowSelect = True
        Me.Lsv_MaterialesT.HideSelection = False
        Me.Lsv_MaterialesT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.Lsv_MaterialesT.Lvs = ListViewColumnSorter9
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
        Me.Lsv_MaterialesT.Size = New System.Drawing.Size(760, 103)
        Me.Lsv_MaterialesT.TabIndex = 1
        Me.Lsv_MaterialesT.UseCompatibleStateImageBehavior = False
        Me.Lsv_MaterialesT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Materiales
        '
        Me.Lsv_Materiales.AllowColumnReorder = True
        Me.Lsv_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Materiales.FullRowSelect = True
        Me.Lsv_Materiales.HideSelection = False
        Me.Lsv_Materiales.Location = New System.Drawing.Point(3, 23)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.Lsv_Materiales.Lvs = ListViewColumnSorter10
        Me.Lsv_Materiales.MultiSelect = False
        Me.Lsv_Materiales.Name = "Lsv_Materiales"
        Me.Lsv_Materiales.Row1 = 9
        Me.Lsv_Materiales.Row10 = 0
        Me.Lsv_Materiales.Row2 = 9
        Me.Lsv_Materiales.Row3 = 9
        Me.Lsv_Materiales.Row4 = 29
        Me.Lsv_Materiales.Row5 = 29
        Me.Lsv_Materiales.Row6 = 10
        Me.Lsv_Materiales.Row7 = 0
        Me.Lsv_Materiales.Row8 = 0
        Me.Lsv_Materiales.Row9 = 0
        Me.Lsv_Materiales.Size = New System.Drawing.Size(760, 261)
        Me.Lsv_Materiales.TabIndex = 0
        Me.Lsv_Materiales.TabStop = False
        Me.Lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.Lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ReemplazarRemision)
        Me.gbx_Botones.Controls.Add(Me.btn_Baja)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 508)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(776, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_ReemplazarRemision
        '
        Me.btn_ReemplazarRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ReemplazarRemision.Enabled = False
        Me.btn_ReemplazarRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.ReemplazarRemision
        Me.btn_ReemplazarRemision.Location = New System.Drawing.Point(298, 13)
        Me.btn_ReemplazarRemision.Name = "btn_ReemplazarRemision"
        Me.btn_ReemplazarRemision.Size = New System.Drawing.Size(147, 30)
        Me.btn_ReemplazarRemision.TabIndex = 1
        Me.btn_ReemplazarRemision.Text = "&Reemplazar Remisión"
        Me.btn_ReemplazarRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ReemplazarRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ReemplazarRemision.UseVisualStyleBackColor = True
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Baja.Location = New System.Drawing.Point(152, 13)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 1
        Me.btn_Baja.Text = "&Baja (Depurar)"
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_ConsultaSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaSaldo"
        Me.Text = "Consulta de Saldo"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.Tab_Custodias.ResumeLayout(False)
        Me.gbx_CambioRemision.ResumeLayout(False)
        Me.gbx_CambioRemision.PerformLayout()
        Me.Tab_Procesos.ResumeLayout(False)
        Me.Tab_Cajeros.ResumeLayout(False)
        Me.gbx_CambioRemisionCaj.ResumeLayout(False)
        Me.gbx_CambioRemisionCaj.PerformLayout()
        Me.Tab_Resguardos.ResumeLayout(False)
        Me.Tab_Materiales.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Custodias As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Procesos As System.Windows.Forms.TabPage
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Tab_Cajeros As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Custodias As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Procesos As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Cajeros As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Tab_Resguardos As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Resguardos As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Tab_Materiales As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Materiales As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_CustodiasT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_ProcesosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_CajerosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_ResguardosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_MaterialesT As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_CambioRemision As System.Windows.Forms.GroupBox
    Friend WithEvents btn_CambiarRemision As System.Windows.Forms.Button
    Friend WithEvents Lbl_CambiarNumRemC As System.Windows.Forms.Label
    Friend WithEvents tbx_NuevaRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents gbx_CambioRemisionCaj As System.Windows.Forms.GroupBox
    Friend WithEvents btn_CambiarRemisionCaj As System.Windows.Forms.Button
    Friend WithEvents Lbl_CambiarNumRemAtms As System.Windows.Forms.Label
    Friend WithEvents tbx_NuevaRemisionCaj As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_ReemplazarRemision As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistrosC As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosP As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosAtm As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosRS As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosM As System.Windows.Forms.Label
End Class
