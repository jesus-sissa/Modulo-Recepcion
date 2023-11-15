<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaSalidas
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
        Dim ListViewColumnSorter43 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter44 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter41 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter42 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter45 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter46 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter47 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter48 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter49 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter50 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Lbl_Filtro = New System.Windows.Forms.GroupBox
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker
        Me.Btn_Consulta = New System.Windows.Forms.Button
        Me.Ckb_Bovedas = New System.Windows.Forms.CheckBox
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker
        Me.lbl_hasta = New System.Windows.Forms.Label
        Me.lbl_Desde = New System.Windows.Forms.Label
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Exportar = New System.Windows.Forms.Button
        Me.TabPage = New System.Windows.Forms.TabControl
        Me.Rutas = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosR = New System.Windows.Forms.Label
        Me.Lsv_RutasT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Rutas = New Modulo_Recepcion.cp_Listview
        Me.gbx_Rutas = New System.Windows.Forms.GroupBox
        Me.lbl_Rutas = New System.Windows.Forms.Label
        Me.Ckb_Rutas = New System.Windows.Forms.CheckBox
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveRuta = New Modulo_Recepcion.cp_Textbox
        Me.RutasExternas = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosRE = New System.Windows.Forms.Label
        Me.Lsv_RutasExternasT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_RutasExternas = New Modulo_Recepcion.cp_Listview
        Me.gbx_RutasExternas = New System.Windows.Forms.GroupBox
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.ckb_CiaRE = New System.Windows.Forms.CheckBox
        Me.cmb_CiaRE = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Procesos = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosP = New System.Windows.Forms.Label
        Me.Lsv_ProcesosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Proceso = New Modulo_Recepcion.cp_Listview
        Me.gbx_Procesos = New System.Windows.Forms.GroupBox
        Me.Lbl_Cia = New System.Windows.Forms.Label
        Me.Ckb_TodosProc = New System.Windows.Forms.CheckBox
        Me.cmb_CiaProc = New Modulo_Recepcion.cp_cmb_SimpleFiltrado
        Me.Cajas = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosC = New System.Windows.Forms.Label
        Me.Lsv_CajerosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Cajeros = New Modulo_Recepcion.cp_Listview
        Me.TabResguardo = New System.Windows.Forms.TabPage
        Me.lbl_RegistrosRes = New System.Windows.Forms.Label
        Me.lsv_ResguardosT = New Modulo_Recepcion.cp_Listview
        Me.lsv_Resguardos = New Modulo_Recepcion.cp_Listview
        Me.Lbl_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.Rutas.SuspendLayout()
        Me.gbx_Rutas.SuspendLayout()
        Me.RutasExternas.SuspendLayout()
        Me.gbx_RutasExternas.SuspendLayout()
        Me.Procesos.SuspendLayout()
        Me.gbx_Procesos.SuspendLayout()
        Me.Cajas.SuspendLayout()
        Me.TabResguardo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Filtro
        '
        Me.Lbl_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Filtro.Controls.Add(Me.dtp_Desde)
        Me.Lbl_Filtro.Controls.Add(Me.Btn_Consulta)
        Me.Lbl_Filtro.Controls.Add(Me.Ckb_Bovedas)
        Me.Lbl_Filtro.Controls.Add(Me.dtp_Hasta)
        Me.Lbl_Filtro.Controls.Add(Me.lbl_hasta)
        Me.Lbl_Filtro.Controls.Add(Me.lbl_Desde)
        Me.Lbl_Filtro.Controls.Add(Me.tbx_Cve_Boveda)
        Me.Lbl_Filtro.Controls.Add(Me.cmb_Boveda)
        Me.Lbl_Filtro.Controls.Add(Me.lbl_Boveda)
        Me.Lbl_Filtro.Location = New System.Drawing.Point(8, 2)
        Me.Lbl_Filtro.Name = "Lbl_Filtro"
        Me.Lbl_Filtro.Size = New System.Drawing.Size(768, 79)
        Me.Lbl_Filtro.TabIndex = 0
        Me.Lbl_Filtro.TabStop = False
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(66, 19)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Desde.TabIndex = 1
        '
        'Btn_Consulta
        '
        Me.Btn_Consulta.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.Btn_Consulta.Location = New System.Drawing.Point(511, 39)
        Me.Btn_Consulta.Name = "Btn_Consulta"
        Me.Btn_Consulta.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Consulta.TabIndex = 8
        Me.Btn_Consulta.Text = "C&onsultar"
        Me.Btn_Consulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Consulta.UseVisualStyleBackColor = True
        '
        'Ckb_Bovedas
        '
        Me.Ckb_Bovedas.AutoSize = True
        Me.Ckb_Bovedas.Location = New System.Drawing.Point(449, 47)
        Me.Ckb_Bovedas.Name = "Ckb_Bovedas"
        Me.Ckb_Bovedas.Size = New System.Drawing.Size(56, 17)
        Me.Ckb_Bovedas.TabIndex = 7
        Me.Ckb_Bovedas.Text = "Todos"
        Me.Ckb_Bovedas.UseVisualStyleBackColor = True
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(209, 19)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Hasta.TabIndex = 3
        '
        'lbl_hasta
        '
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(168, 23)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_hasta.TabIndex = 2
        Me.lbl_hasta.Text = "Hasta"
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(22, 23)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(66, 45)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 5
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Nothing
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_Cve_Boveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(122, 45)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 6
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(16, 48)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 4
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.Btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(768, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Exportar
        '
        Me.Btn_Exportar.Enabled = False
        Me.Btn_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.Btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.Btn_Exportar.Name = "Btn_Exportar"
        Me.Btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Exportar.TabIndex = 0
        Me.Btn_Exportar.Text = "&Exportar"
        Me.Btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Exportar.UseVisualStyleBackColor = True
        '
        'TabPage
        '
        Me.TabPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPage.Controls.Add(Me.Rutas)
        Me.TabPage.Controls.Add(Me.RutasExternas)
        Me.TabPage.Controls.Add(Me.Procesos)
        Me.TabPage.Controls.Add(Me.Cajas)
        Me.TabPage.Controls.Add(Me.TabResguardo)
        Me.TabPage.Location = New System.Drawing.Point(8, 87)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(768, 406)
        Me.TabPage.TabIndex = 1
        '
        'Rutas
        '
        Me.Rutas.Controls.Add(Me.lbl_RegistrosR)
        Me.Rutas.Controls.Add(Me.Lsv_RutasT)
        Me.Rutas.Controls.Add(Me.Lsv_Rutas)
        Me.Rutas.Controls.Add(Me.gbx_Rutas)
        Me.Rutas.Location = New System.Drawing.Point(4, 22)
        Me.Rutas.Name = "Rutas"
        Me.Rutas.Size = New System.Drawing.Size(760, 380)
        Me.Rutas.TabIndex = 4
        Me.Rutas.Text = "Rutas"
        Me.Rutas.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosR
        '
        Me.lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosR.Location = New System.Drawing.Point(617, 52)
        Me.lbl_RegistrosR.Name = "lbl_RegistrosR"
        Me.lbl_RegistrosR.Size = New System.Drawing.Size(140, 15)
        Me.lbl_RegistrosR.TabIndex = 4
        Me.lbl_RegistrosR.Text = "Registros: 0"
        Me.lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_RutasT
        '
        Me.Lsv_RutasT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_RutasT.FullRowSelect = True
        Me.Lsv_RutasT.HideSelection = False
        Me.Lsv_RutasT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter43.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter43.SortColumn = 0
        Me.Lsv_RutasT.Lvs = ListViewColumnSorter43
        Me.Lsv_RutasT.MultiSelect = False
        Me.Lsv_RutasT.Name = "Lsv_RutasT"
        Me.Lsv_RutasT.Row1 = 10
        Me.Lsv_RutasT.Row10 = 10
        Me.Lsv_RutasT.Row2 = 10
        Me.Lsv_RutasT.Row3 = 10
        Me.Lsv_RutasT.Row4 = 10
        Me.Lsv_RutasT.Row5 = 10
        Me.Lsv_RutasT.Row6 = 10
        Me.Lsv_RutasT.Row7 = 10
        Me.Lsv_RutasT.Row8 = 10
        Me.Lsv_RutasT.Row9 = 10
        Me.Lsv_RutasT.Size = New System.Drawing.Size(754, 87)
        Me.Lsv_RutasT.TabIndex = 2
        Me.Lsv_RutasT.UseCompatibleStateImageBehavior = False
        Me.Lsv_RutasT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Rutas
        '
        Me.Lsv_Rutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Rutas.FullRowSelect = True
        Me.Lsv_Rutas.HideSelection = False
        Me.Lsv_Rutas.Location = New System.Drawing.Point(3, 70)
        ListViewColumnSorter44.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter44.SortColumn = 0
        Me.Lsv_Rutas.Lvs = ListViewColumnSorter44
        Me.Lsv_Rutas.MultiSelect = False
        Me.Lsv_Rutas.Name = "Lsv_Rutas"
        Me.Lsv_Rutas.Row1 = 10
        Me.Lsv_Rutas.Row10 = 0
        Me.Lsv_Rutas.Row2 = 8
        Me.Lsv_Rutas.Row3 = 8
        Me.Lsv_Rutas.Row4 = 20
        Me.Lsv_Rutas.Row5 = 10
        Me.Lsv_Rutas.Row6 = 10
        Me.Lsv_Rutas.Row7 = 10
        Me.Lsv_Rutas.Row8 = 10
        Me.Lsv_Rutas.Row9 = 10
        Me.Lsv_Rutas.Size = New System.Drawing.Size(754, 214)
        Me.Lsv_Rutas.TabIndex = 1
        Me.Lsv_Rutas.TabStop = False
        Me.Lsv_Rutas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Rutas.View = System.Windows.Forms.View.Details
        '
        'gbx_Rutas
        '
        Me.gbx_Rutas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Rutas.Controls.Add(Me.lbl_Rutas)
        Me.gbx_Rutas.Controls.Add(Me.Ckb_Rutas)
        Me.gbx_Rutas.Controls.Add(Me.cmb_Rutas)
        Me.gbx_Rutas.Controls.Add(Me.tbx_CveRuta)
        Me.gbx_Rutas.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Rutas.Name = "gbx_Rutas"
        Me.gbx_Rutas.Size = New System.Drawing.Size(754, 46)
        Me.gbx_Rutas.TabIndex = 0
        Me.gbx_Rutas.TabStop = False
        '
        'lbl_Rutas
        '
        Me.lbl_Rutas.AutoSize = True
        Me.lbl_Rutas.Location = New System.Drawing.Point(18, 19)
        Me.lbl_Rutas.Name = "lbl_Rutas"
        Me.lbl_Rutas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Rutas.TabIndex = 0
        Me.lbl_Rutas.Text = "Rutas"
        '
        'Ckb_Rutas
        '
        Me.Ckb_Rutas.AutoSize = True
        Me.Ckb_Rutas.Checked = True
        Me.Ckb_Rutas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ckb_Rutas.Location = New System.Drawing.Point(442, 18)
        Me.Ckb_Rutas.Name = "Ckb_Rutas"
        Me.Ckb_Rutas.Size = New System.Drawing.Size(56, 17)
        Me.Ckb_Rutas.TabIndex = 3
        Me.Ckb_Rutas.Text = "Todos"
        Me.Ckb_Rutas.UseVisualStyleBackColor = True
        '
        'cmb_Rutas
        '
        Me.cmb_Rutas.Clave = "Clave"
        Me.cmb_Rutas.Control_Siguiente = Nothing
        Me.cmb_Rutas.DisplayMember = "Descripcion"
        Me.cmb_Rutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rutas.Empresa = False
        Me.cmb_Rutas.Enabled = False
        Me.cmb_Rutas.Filtro = Me.tbx_CveRuta
        Me.cmb_Rutas.FormattingEnabled = True
        Me.cmb_Rutas.Location = New System.Drawing.Point(115, 15)
        Me.cmb_Rutas.MaxDropDownItems = 20
        Me.cmb_Rutas.Name = "cmb_Rutas"
        Me.cmb_Rutas.Pista = True
        Me.cmb_Rutas.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Rutas.StoredProcedure = "Cat_RutasTipo_Get"
        Me.cmb_Rutas.Sucursal = True
        Me.cmb_Rutas.TabIndex = 2
        Me.cmb_Rutas.Tipo = 0
        Me.cmb_Rutas.ValueMember = "Id_Ruta"
        '
        'tbx_CveRuta
        '
        Me.tbx_CveRuta.Control_Siguiente = Nothing
        Me.tbx_CveRuta.Enabled = False
        Me.tbx_CveRuta.Filtrado = True
        Me.tbx_CveRuta.Location = New System.Drawing.Point(59, 16)
        Me.tbx_CveRuta.MaxLength = 4
        Me.tbx_CveRuta.Name = "tbx_CveRuta"
        Me.tbx_CveRuta.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveRuta.TabIndex = 1
        Me.tbx_CveRuta.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'RutasExternas
        '
        Me.RutasExternas.Controls.Add(Me.Lbl_RegistrosRE)
        Me.RutasExternas.Controls.Add(Me.Lsv_RutasExternasT)
        Me.RutasExternas.Controls.Add(Me.Lsv_RutasExternas)
        Me.RutasExternas.Controls.Add(Me.gbx_RutasExternas)
        Me.RutasExternas.Location = New System.Drawing.Point(4, 22)
        Me.RutasExternas.Name = "RutasExternas"
        Me.RutasExternas.Size = New System.Drawing.Size(760, 380)
        Me.RutasExternas.TabIndex = 5
        Me.RutasExternas.Text = "Rutas Externas"
        Me.RutasExternas.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosRE
        '
        Me.Lbl_RegistrosRE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosRE.Location = New System.Drawing.Point(617, 52)
        Me.Lbl_RegistrosRE.Name = "Lbl_RegistrosRE"
        Me.Lbl_RegistrosRE.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosRE.TabIndex = 4
        Me.Lbl_RegistrosRE.Text = "Registros: 0"
        Me.Lbl_RegistrosRE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_RutasExternasT
        '
        Me.Lsv_RutasExternasT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_RutasExternasT.FullRowSelect = True
        Me.Lsv_RutasExternasT.HideSelection = False
        Me.Lsv_RutasExternasT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter41.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter41.SortColumn = 0
        Me.Lsv_RutasExternasT.Lvs = ListViewColumnSorter41
        Me.Lsv_RutasExternasT.MultiSelect = False
        Me.Lsv_RutasExternasT.Name = "Lsv_RutasExternasT"
        Me.Lsv_RutasExternasT.Row1 = 10
        Me.Lsv_RutasExternasT.Row10 = 10
        Me.Lsv_RutasExternasT.Row2 = 10
        Me.Lsv_RutasExternasT.Row3 = 10
        Me.Lsv_RutasExternasT.Row4 = 10
        Me.Lsv_RutasExternasT.Row5 = 10
        Me.Lsv_RutasExternasT.Row6 = 10
        Me.Lsv_RutasExternasT.Row7 = 10
        Me.Lsv_RutasExternasT.Row8 = 10
        Me.Lsv_RutasExternasT.Row9 = 10
        Me.Lsv_RutasExternasT.Size = New System.Drawing.Size(754, 87)
        Me.Lsv_RutasExternasT.TabIndex = 2
        Me.Lsv_RutasExternasT.UseCompatibleStateImageBehavior = False
        Me.Lsv_RutasExternasT.View = System.Windows.Forms.View.Details
        '
        'Lsv_RutasExternas
        '
        Me.Lsv_RutasExternas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_RutasExternas.FullRowSelect = True
        Me.Lsv_RutasExternas.HideSelection = False
        Me.Lsv_RutasExternas.Location = New System.Drawing.Point(3, 70)
        ListViewColumnSorter42.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter42.SortColumn = 0
        Me.Lsv_RutasExternas.Lvs = ListViewColumnSorter42
        Me.Lsv_RutasExternas.MultiSelect = False
        Me.Lsv_RutasExternas.Name = "Lsv_RutasExternas"
        Me.Lsv_RutasExternas.Row1 = 10
        Me.Lsv_RutasExternas.Row10 = 0
        Me.Lsv_RutasExternas.Row2 = 8
        Me.Lsv_RutasExternas.Row3 = 8
        Me.Lsv_RutasExternas.Row4 = 20
        Me.Lsv_RutasExternas.Row5 = 10
        Me.Lsv_RutasExternas.Row6 = 10
        Me.Lsv_RutasExternas.Row7 = 10
        Me.Lsv_RutasExternas.Row8 = 10
        Me.Lsv_RutasExternas.Row9 = 0
        Me.Lsv_RutasExternas.Size = New System.Drawing.Size(754, 214)
        Me.Lsv_RutasExternas.TabIndex = 1
        Me.Lsv_RutasExternas.TabStop = False
        Me.Lsv_RutasExternas.UseCompatibleStateImageBehavior = False
        Me.Lsv_RutasExternas.View = System.Windows.Forms.View.Details
        '
        'gbx_RutasExternas
        '
        Me.gbx_RutasExternas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_RutasExternas.Controls.Add(Me.lbl_Compañia)
        Me.gbx_RutasExternas.Controls.Add(Me.ckb_CiaRE)
        Me.gbx_RutasExternas.Controls.Add(Me.cmb_CiaRE)
        Me.gbx_RutasExternas.Location = New System.Drawing.Point(3, 3)
        Me.gbx_RutasExternas.Name = "gbx_RutasExternas"
        Me.gbx_RutasExternas.Size = New System.Drawing.Size(754, 46)
        Me.gbx_RutasExternas.TabIndex = 0
        Me.gbx_RutasExternas.TabStop = False
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(21, 19)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Compañia.TabIndex = 0
        Me.lbl_Compañia.Text = "Compañía de TV"
        '
        'ckb_CiaRE
        '
        Me.ckb_CiaRE.AutoSize = True
        Me.ckb_CiaRE.Checked = True
        Me.ckb_CiaRE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_CiaRE.Location = New System.Drawing.Point(442, 19)
        Me.ckb_CiaRE.Name = "ckb_CiaRE"
        Me.ckb_CiaRE.Size = New System.Drawing.Size(56, 17)
        Me.ckb_CiaRE.TabIndex = 3
        Me.ckb_CiaRE.Text = "Todas"
        Me.ckb_CiaRE.UseVisualStyleBackColor = True
        '
        'cmb_CiaRE
        '
        Me.cmb_CiaRE.Clave = ""
        Me.cmb_CiaRE.Control_Siguiente = Nothing
        Me.cmb_CiaRE.DisplayMember = "Nombre"
        Me.cmb_CiaRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiaRE.Empresa = False
        Me.cmb_CiaRE.Enabled = False
        Me.cmb_CiaRE.Filtro = Nothing
        Me.cmb_CiaRE.FormattingEnabled = True
        Me.cmb_CiaRE.Location = New System.Drawing.Point(115, 16)
        Me.cmb_CiaRE.MaxDropDownItems = 20
        Me.cmb_CiaRE.Name = "cmb_CiaRE"
        Me.cmb_CiaRE.Pista = False
        Me.cmb_CiaRE.Size = New System.Drawing.Size(321, 21)
        Me.cmb_CiaRE.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_CiaRE.Sucursal = False
        Me.cmb_CiaRE.TabIndex = 2
        Me.cmb_CiaRE.Tipo = 0
        Me.cmb_CiaRE.ValueMember = "Id_Cia"
        '
        'Procesos
        '
        Me.Procesos.Controls.Add(Me.lbl_RegistrosP)
        Me.Procesos.Controls.Add(Me.Lsv_ProcesosT)
        Me.Procesos.Controls.Add(Me.Lsv_Proceso)
        Me.Procesos.Controls.Add(Me.gbx_Procesos)
        Me.Procesos.Location = New System.Drawing.Point(4, 22)
        Me.Procesos.Name = "Procesos"
        Me.Procesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Procesos.Size = New System.Drawing.Size(760, 380)
        Me.Procesos.TabIndex = 0
        Me.Procesos.Text = "Proceso"
        Me.Procesos.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosP
        '
        Me.lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosP.Location = New System.Drawing.Point(618, 52)
        Me.lbl_RegistrosP.Name = "lbl_RegistrosP"
        Me.lbl_RegistrosP.Size = New System.Drawing.Size(140, 15)
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
        Me.Lsv_ProcesosT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter45.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter45.SortColumn = 0
        Me.Lsv_ProcesosT.Lvs = ListViewColumnSorter45
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
        Me.Lsv_ProcesosT.Size = New System.Drawing.Size(754, 87)
        Me.Lsv_ProcesosT.TabIndex = 2
        Me.Lsv_ProcesosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ProcesosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Proceso
        '
        Me.Lsv_Proceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Proceso.FullRowSelect = True
        Me.Lsv_Proceso.HideSelection = False
        Me.Lsv_Proceso.Location = New System.Drawing.Point(3, 70)
        ListViewColumnSorter46.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter46.SortColumn = 0
        Me.Lsv_Proceso.Lvs = ListViewColumnSorter46
        Me.Lsv_Proceso.MultiSelect = False
        Me.Lsv_Proceso.Name = "Lsv_Proceso"
        Me.Lsv_Proceso.Row1 = 10
        Me.Lsv_Proceso.Row10 = 0
        Me.Lsv_Proceso.Row2 = 8
        Me.Lsv_Proceso.Row3 = 8
        Me.Lsv_Proceso.Row4 = 20
        Me.Lsv_Proceso.Row5 = 10
        Me.Lsv_Proceso.Row6 = 10
        Me.Lsv_Proceso.Row7 = 10
        Me.Lsv_Proceso.Row8 = 10
        Me.Lsv_Proceso.Row9 = 0
        Me.Lsv_Proceso.Size = New System.Drawing.Size(754, 214)
        Me.Lsv_Proceso.TabIndex = 1
        Me.Lsv_Proceso.TabStop = False
        Me.Lsv_Proceso.UseCompatibleStateImageBehavior = False
        Me.Lsv_Proceso.View = System.Windows.Forms.View.Details
        '
        'gbx_Procesos
        '
        Me.gbx_Procesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Procesos.Controls.Add(Me.Lbl_Cia)
        Me.gbx_Procesos.Controls.Add(Me.Ckb_TodosProc)
        Me.gbx_Procesos.Controls.Add(Me.cmb_CiaProc)
        Me.gbx_Procesos.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Procesos.Name = "gbx_Procesos"
        Me.gbx_Procesos.Size = New System.Drawing.Size(754, 46)
        Me.gbx_Procesos.TabIndex = 0
        Me.gbx_Procesos.TabStop = False
        '
        'Lbl_Cia
        '
        Me.Lbl_Cia.AutoSize = True
        Me.Lbl_Cia.Location = New System.Drawing.Point(21, 19)
        Me.Lbl_Cia.Name = "Lbl_Cia"
        Me.Lbl_Cia.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_Cia.TabIndex = 0
        Me.Lbl_Cia.Text = "Compañía de TV"
        '
        'Ckb_TodosProc
        '
        Me.Ckb_TodosProc.AutoSize = True
        Me.Ckb_TodosProc.Checked = True
        Me.Ckb_TodosProc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Ckb_TodosProc.Location = New System.Drawing.Point(442, 19)
        Me.Ckb_TodosProc.Name = "Ckb_TodosProc"
        Me.Ckb_TodosProc.Size = New System.Drawing.Size(56, 17)
        Me.Ckb_TodosProc.TabIndex = 3
        Me.Ckb_TodosProc.Text = "Todas"
        Me.Ckb_TodosProc.UseVisualStyleBackColor = True
        '
        'cmb_CiaProc
        '
        Me.cmb_CiaProc.Clave = ""
        Me.cmb_CiaProc.Control_Siguiente = Nothing
        Me.cmb_CiaProc.DisplayMember = "Nombre"
        Me.cmb_CiaProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiaProc.Empresa = False
        Me.cmb_CiaProc.Enabled = False
        Me.cmb_CiaProc.Filtro = Nothing
        Me.cmb_CiaProc.FormattingEnabled = True
        Me.cmb_CiaProc.Location = New System.Drawing.Point(115, 16)
        Me.cmb_CiaProc.MaxDropDownItems = 20
        Me.cmb_CiaProc.Name = "cmb_CiaProc"
        Me.cmb_CiaProc.Pista = False
        Me.cmb_CiaProc.Size = New System.Drawing.Size(321, 21)
        Me.cmb_CiaProc.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_CiaProc.Sucursal = False
        Me.cmb_CiaProc.TabIndex = 2
        Me.cmb_CiaProc.Tipo = 0
        Me.cmb_CiaProc.ValueMember = "Id_Cia"
        '
        'Cajas
        '
        Me.Cajas.Controls.Add(Me.lbl_RegistrosC)
        Me.Cajas.Controls.Add(Me.Lsv_CajerosT)
        Me.Cajas.Controls.Add(Me.Lsv_Cajeros)
        Me.Cajas.Location = New System.Drawing.Point(4, 22)
        Me.Cajas.Name = "Cajas"
        Me.Cajas.Padding = New System.Windows.Forms.Padding(3)
        Me.Cajas.Size = New System.Drawing.Size(760, 380)
        Me.Cajas.TabIndex = 1
        Me.Cajas.Text = "Cajeros"
        Me.Cajas.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosC
        '
        Me.lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosC.Location = New System.Drawing.Point(622, 3)
        Me.lbl_RegistrosC.Name = "lbl_RegistrosC"
        Me.lbl_RegistrosC.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosC.TabIndex = 4
        Me.lbl_RegistrosC.Text = "Registros: 0"
        Me.lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_CajerosT
        '
        Me.Lsv_CajerosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_CajerosT.FullRowSelect = True
        Me.Lsv_CajerosT.HideSelection = False
        Me.Lsv_CajerosT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter47.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter47.SortColumn = 0
        Me.Lsv_CajerosT.Lvs = ListViewColumnSorter47
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
        Me.Lsv_CajerosT.Size = New System.Drawing.Size(754, 87)
        Me.Lsv_CajerosT.TabIndex = 1
        Me.Lsv_CajerosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_CajerosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Cajeros
        '
        Me.Lsv_Cajeros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Cajeros.FullRowSelect = True
        Me.Lsv_Cajeros.HideSelection = False
        Me.Lsv_Cajeros.Location = New System.Drawing.Point(3, 21)
        ListViewColumnSorter48.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter48.SortColumn = 0
        Me.Lsv_Cajeros.Lvs = ListViewColumnSorter48
        Me.Lsv_Cajeros.MultiSelect = False
        Me.Lsv_Cajeros.Name = "Lsv_Cajeros"
        Me.Lsv_Cajeros.Row1 = 10
        Me.Lsv_Cajeros.Row10 = 10
        Me.Lsv_Cajeros.Row2 = 8
        Me.Lsv_Cajeros.Row3 = 8
        Me.Lsv_Cajeros.Row4 = 15
        Me.Lsv_Cajeros.Row5 = 10
        Me.Lsv_Cajeros.Row6 = 15
        Me.Lsv_Cajeros.Row7 = 10
        Me.Lsv_Cajeros.Row8 = 8
        Me.Lsv_Cajeros.Row9 = 8
        Me.Lsv_Cajeros.Size = New System.Drawing.Size(754, 263)
        Me.Lsv_Cajeros.TabIndex = 0
        Me.Lsv_Cajeros.TabStop = False
        Me.Lsv_Cajeros.UseCompatibleStateImageBehavior = False
        Me.Lsv_Cajeros.View = System.Windows.Forms.View.Details
        '
        'TabResguardo
        '
        Me.TabResguardo.Controls.Add(Me.lbl_RegistrosRes)
        Me.TabResguardo.Controls.Add(Me.lsv_ResguardosT)
        Me.TabResguardo.Controls.Add(Me.lsv_Resguardos)
        Me.TabResguardo.Location = New System.Drawing.Point(4, 22)
        Me.TabResguardo.Name = "TabResguardo"
        Me.TabResguardo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResguardo.Size = New System.Drawing.Size(760, 380)
        Me.TabResguardo.TabIndex = 8
        Me.TabResguardo.Text = "Resguardos"
        Me.TabResguardo.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosRes
        '
        Me.lbl_RegistrosRes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosRes.Location = New System.Drawing.Point(622, 3)
        Me.lbl_RegistrosRes.Name = "lbl_RegistrosRes"
        Me.lbl_RegistrosRes.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosRes.TabIndex = 4
        Me.lbl_RegistrosRes.Text = "Registros: 0"
        Me.lbl_RegistrosRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ResguardosT
        '
        Me.lsv_ResguardosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ResguardosT.FullRowSelect = True
        Me.lsv_ResguardosT.HideSelection = False
        Me.lsv_ResguardosT.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter49.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter49.SortColumn = 0
        Me.lsv_ResguardosT.Lvs = ListViewColumnSorter49
        Me.lsv_ResguardosT.MultiSelect = False
        Me.lsv_ResguardosT.Name = "lsv_ResguardosT"
        Me.lsv_ResguardosT.Row1 = 10
        Me.lsv_ResguardosT.Row10 = 10
        Me.lsv_ResguardosT.Row2 = 10
        Me.lsv_ResguardosT.Row3 = 10
        Me.lsv_ResguardosT.Row4 = 10
        Me.lsv_ResguardosT.Row5 = 10
        Me.lsv_ResguardosT.Row6 = 10
        Me.lsv_ResguardosT.Row7 = 10
        Me.lsv_ResguardosT.Row8 = 10
        Me.lsv_ResguardosT.Row9 = 10
        Me.lsv_ResguardosT.Size = New System.Drawing.Size(754, 87)
        Me.lsv_ResguardosT.TabIndex = 1
        Me.lsv_ResguardosT.UseCompatibleStateImageBehavior = False
        Me.lsv_ResguardosT.View = System.Windows.Forms.View.Details
        '
        'lsv_Resguardos
        '
        Me.lsv_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Resguardos.FullRowSelect = True
        Me.lsv_Resguardos.HideSelection = False
        Me.lsv_Resguardos.Location = New System.Drawing.Point(3, 21)
        ListViewColumnSorter50.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter50.SortColumn = 0
        Me.lsv_Resguardos.Lvs = ListViewColumnSorter50
        Me.lsv_Resguardos.MultiSelect = False
        Me.lsv_Resguardos.Name = "lsv_Resguardos"
        Me.lsv_Resguardos.Row1 = 10
        Me.lsv_Resguardos.Row10 = 0
        Me.lsv_Resguardos.Row2 = 10
        Me.lsv_Resguardos.Row3 = 10
        Me.lsv_Resguardos.Row4 = 10
        Me.lsv_Resguardos.Row5 = 10
        Me.lsv_Resguardos.Row6 = 10
        Me.lsv_Resguardos.Row7 = 10
        Me.lsv_Resguardos.Row8 = 10
        Me.lsv_Resguardos.Row9 = 0
        Me.lsv_Resguardos.Size = New System.Drawing.Size(754, 263)
        Me.lsv_Resguardos.TabIndex = 0
        Me.lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'frm_ConsultaSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TabPage)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Lbl_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaSalidas"
        Me.Text = "Consulta Salidas"
        Me.Lbl_Filtro.ResumeLayout(False)
        Me.Lbl_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.Rutas.ResumeLayout(False)
        Me.gbx_Rutas.ResumeLayout(False)
        Me.gbx_Rutas.PerformLayout()
        Me.RutasExternas.ResumeLayout(False)
        Me.gbx_RutasExternas.ResumeLayout(False)
        Me.gbx_RutasExternas.PerformLayout()
        Me.Procesos.ResumeLayout(False)
        Me.gbx_Procesos.ResumeLayout(False)
        Me.gbx_Procesos.PerformLayout()
        Me.Cajas.ResumeLayout(False)
        Me.TabResguardo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents Procesos As System.Windows.Forms.TabPage
    Friend WithEvents Cajas As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Proceso As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Cajeros As Modulo_Recepcion.cp_Listview
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents Rutas As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Rutas As Modulo_Recepcion.cp_Listview
    Friend WithEvents RutasExternas As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_RutasExternas As Modulo_Recepcion.cp_Listview
    Friend WithEvents Ckb_Rutas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Rutas As System.Windows.Forms.Label
    Friend WithEvents tbx_CveRuta As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents ckb_CiaRE As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents cmb_CiaRE As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Ckb_TodosProc As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents cmb_CiaProc As Modulo_Recepcion.cp_cmb_SimpleFiltrado
    Friend WithEvents Ckb_Bovedas As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Consulta As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents TabResguardo As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Resguardos As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_ResguardosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_CajerosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Procesos As System.Windows.Forms.GroupBox
    Friend WithEvents Lsv_ProcesosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_RutasExternas As System.Windows.Forms.GroupBox
    Friend WithEvents Lsv_RutasExternasT As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Rutas As System.Windows.Forms.GroupBox
    Friend WithEvents Lsv_RutasT As Modulo_Recepcion.cp_Listview
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosRE As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosP As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosC As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosRes As System.Windows.Forms.Label
End Class
