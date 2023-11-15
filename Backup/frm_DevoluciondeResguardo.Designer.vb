<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DevoluciondeResguardo
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
        Dim ListViewColumnSorter64 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter65 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter66 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter67 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter68 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter69 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter70 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter71 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter72 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter73 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter74 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter75 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DevoluciondeResguardo))
        Dim ListViewColumnSorter61 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter62 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter63 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_Caja = New Modulo_Recepcion.cp_cmb_Simple
        Me.Lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Devolucion = New System.Windows.Forms.Button
        Me.TabPage = New System.Windows.Forms.TabControl
        Me.Procesos = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbx_BuscarP = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarP = New System.Windows.Forms.Button
        Me.lsv_EnvasesP = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosP = New System.Windows.Forms.Label
        Me.Lsv_Procesos = New Modulo_Recepcion.cp_Listview
        Me.Lsv_ProcesosT = New Modulo_Recepcion.cp_Listview
        Me.Cajas = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbx_BuscarCaj = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarCaj = New System.Windows.Forms.Button
        Me.lsv_EnvasesC = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosC = New System.Windows.Forms.Label
        Me.Lsv_CajerosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Cajeros = New Modulo_Recepcion.cp_Listview
        Me.Morralla = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbx_BuscarMor = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarMor = New System.Windows.Forms.Button
        Me.lsv_EnvasesM = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosM = New System.Windows.Forms.Label
        Me.Lsv_MorrallaT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Morralla = New Modulo_Recepcion.cp_Listview
        Me.Clasificados = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbx_BuscarCla = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarCla = New System.Windows.Forms.Button
        Me.lsv_EnvasesCl = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosCl = New System.Windows.Forms.Label
        Me.Lsv_ClasificadosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Clasificados = New Modulo_Recepcion.cp_Listview
        Me.Tab_Nominas = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbx_BuscarNom = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarNom = New System.Windows.Forms.Button
        Me.lsv_EnvasesNom = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosN = New System.Windows.Forms.Label
        Me.Lsv_NominasT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Nominas = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.TabPage.SuspendLayout()
        Me.Procesos.SuspendLayout()
        Me.Cajas.SuspendLayout()
        Me.Morralla.SuspendLayout()
        Me.Clasificados.SuspendLayout()
        Me.Tab_Nominas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(769, 47)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'cmb_Caja
        '
        Me.cmb_Caja.Control_Siguiente = Nothing
        Me.cmb_Caja.DisplayMember = "Nombre Comercial"
        Me.cmb_Caja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Caja.Empresa = False
        Me.cmb_Caja.FormattingEnabled = True
        Me.cmb_Caja.Location = New System.Drawing.Point(85, 15)
        Me.cmb_Caja.MaxDropDownItems = 20
        Me.cmb_Caja.Name = "cmb_Caja"
        Me.cmb_Caja.Pista = False
        Me.cmb_Caja.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Caja.StoredProcedure = "Pro_CajasBancarias_Get"
        Me.cmb_Caja.Sucursal = True
        Me.cmb_Caja.TabIndex = 1
        Me.cmb_Caja.ValueMember = "Id_cajaBancaria"
        '
        'Lbl_CajaBancaria
        '
        Me.Lbl_CajaBancaria.AutoSize = True
        Me.Lbl_CajaBancaria.Location = New System.Drawing.Point(6, 18)
        Me.Lbl_CajaBancaria.Name = "Lbl_CajaBancaria"
        Me.Lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_CajaBancaria.TabIndex = 0
        Me.Lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Devolucion)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 499)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(769, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(623, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Devolucion
        '
        Me.btn_Devolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Devolucion.Enabled = False
        Me.btn_Devolucion.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Devolucion.Location = New System.Drawing.Point(6, 13)
        Me.btn_Devolucion.Name = "btn_Devolucion"
        Me.btn_Devolucion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Devolucion.TabIndex = 0
        Me.btn_Devolucion.Text = "&Devolución"
        Me.btn_Devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Devolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Devolucion.UseVisualStyleBackColor = True
        '
        'TabPage
        '
        Me.TabPage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPage.Controls.Add(Me.Procesos)
        Me.TabPage.Controls.Add(Me.Cajas)
        Me.TabPage.Controls.Add(Me.Morralla)
        Me.TabPage.Controls.Add(Me.Clasificados)
        Me.TabPage.Controls.Add(Me.Tab_Nominas)
        Me.TabPage.Location = New System.Drawing.Point(7, 55)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(769, 438)
        Me.TabPage.TabIndex = 1
        '
        'Procesos
        '
        Me.Procesos.Controls.Add(Me.Label2)
        Me.Procesos.Controls.Add(Me.tbx_BuscarP)
        Me.Procesos.Controls.Add(Me.btn_BuscarP)
        Me.Procesos.Controls.Add(Me.lsv_EnvasesP)
        Me.Procesos.Controls.Add(Me.Lbl_RegistrosP)
        Me.Procesos.Controls.Add(Me.Lsv_Procesos)
        Me.Procesos.Controls.Add(Me.Lsv_ProcesosT)
        Me.Procesos.Location = New System.Drawing.Point(4, 22)
        Me.Procesos.Name = "Procesos"
        Me.Procesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Procesos.Size = New System.Drawing.Size(761, 412)
        Me.Procesos.TabIndex = 0
        Me.Procesos.Text = "Proceso"
        Me.Procesos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Buscar"
        '
        'tbx_BuscarP
        '
        Me.tbx_BuscarP.Control_Siguiente = Nothing
        Me.tbx_BuscarP.Filtrado = False
        Me.tbx_BuscarP.Location = New System.Drawing.Point(51, 24)
        Me.tbx_BuscarP.Name = "tbx_BuscarP"
        Me.tbx_BuscarP.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarP.TabIndex = 16
        Me.tbx_BuscarP.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarP
        '
        Me.btn_BuscarP.Image = CType(resources.GetObject("btn_BuscarP.Image"), System.Drawing.Image)
        Me.btn_BuscarP.Location = New System.Drawing.Point(451, 21)
        Me.btn_BuscarP.Name = "btn_BuscarP"
        Me.btn_BuscarP.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarP.TabIndex = 17
        Me.btn_BuscarP.Text = "&Buscar"
        Me.btn_BuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarP.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesP
        '
        Me.lsv_EnvasesP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesP.FullRowSelect = True
        Me.lsv_EnvasesP.HideSelection = False
        Me.lsv_EnvasesP.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter64.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter64.SortColumn = 0
        Me.lsv_EnvasesP.Lvs = ListViewColumnSorter64
        Me.lsv_EnvasesP.MultiSelect = False
        Me.lsv_EnvasesP.Name = "lsv_EnvasesP"
        Me.lsv_EnvasesP.Row1 = 10
        Me.lsv_EnvasesP.Row10 = 10
        Me.lsv_EnvasesP.Row2 = 10
        Me.lsv_EnvasesP.Row3 = 10
        Me.lsv_EnvasesP.Row4 = 10
        Me.lsv_EnvasesP.Row5 = 10
        Me.lsv_EnvasesP.Row6 = 10
        Me.lsv_EnvasesP.Row7 = 10
        Me.lsv_EnvasesP.Row8 = 10
        Me.lsv_EnvasesP.Row9 = 10
        Me.lsv_EnvasesP.Size = New System.Drawing.Size(755, 87)
        Me.lsv_EnvasesP.TabIndex = 10
        Me.lsv_EnvasesP.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesP.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosP
        '
        Me.Lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosP.Location = New System.Drawing.Point(615, 3)
        Me.Lbl_RegistrosP.Name = "Lbl_RegistrosP"
        Me.Lbl_RegistrosP.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosP.TabIndex = 8
        Me.Lbl_RegistrosP.Text = "Registros: 0"
        Me.Lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Procesos
        '
        Me.Lsv_Procesos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Procesos.FullRowSelect = True
        Me.Lsv_Procesos.HideSelection = False
        Me.Lsv_Procesos.Location = New System.Drawing.Point(3, 56)
        ListViewColumnSorter65.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter65.SortColumn = 0
        Me.Lsv_Procesos.Lvs = ListViewColumnSorter65
        Me.Lsv_Procesos.MultiSelect = False
        Me.Lsv_Procesos.Name = "Lsv_Procesos"
        Me.Lsv_Procesos.Row1 = 10
        Me.Lsv_Procesos.Row10 = 0
        Me.Lsv_Procesos.Row2 = 10
        Me.Lsv_Procesos.Row3 = 10
        Me.Lsv_Procesos.Row4 = 15
        Me.Lsv_Procesos.Row5 = 11
        Me.Lsv_Procesos.Row6 = 0
        Me.Lsv_Procesos.Row7 = 0
        Me.Lsv_Procesos.Row8 = 0
        Me.Lsv_Procesos.Row9 = 0
        Me.Lsv_Procesos.Size = New System.Drawing.Size(755, 174)
        Me.Lsv_Procesos.TabIndex = 0
        Me.Lsv_Procesos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Procesos.View = System.Windows.Forms.View.Details
        '
        'Lsv_ProcesosT
        '
        Me.Lsv_ProcesosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ProcesosT.FullRowSelect = True
        Me.Lsv_ProcesosT.HideSelection = False
        Me.Lsv_ProcesosT.Location = New System.Drawing.Point(3, 233)
        ListViewColumnSorter66.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter66.SortColumn = 0
        Me.Lsv_ProcesosT.Lvs = ListViewColumnSorter66
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
        Me.Lsv_ProcesosT.Size = New System.Drawing.Size(755, 87)
        Me.Lsv_ProcesosT.TabIndex = 1
        Me.Lsv_ProcesosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ProcesosT.View = System.Windows.Forms.View.Details
        '
        'Cajas
        '
        Me.Cajas.Controls.Add(Me.Label3)
        Me.Cajas.Controls.Add(Me.tbx_BuscarCaj)
        Me.Cajas.Controls.Add(Me.btn_BuscarCaj)
        Me.Cajas.Controls.Add(Me.lsv_EnvasesC)
        Me.Cajas.Controls.Add(Me.Lbl_RegistrosC)
        Me.Cajas.Controls.Add(Me.Lsv_CajerosT)
        Me.Cajas.Controls.Add(Me.Lsv_Cajeros)
        Me.Cajas.Location = New System.Drawing.Point(4, 22)
        Me.Cajas.Name = "Cajas"
        Me.Cajas.Padding = New System.Windows.Forms.Padding(3)
        Me.Cajas.Size = New System.Drawing.Size(761, 412)
        Me.Cajas.TabIndex = 1
        Me.Cajas.Text = "Cajeros"
        Me.Cajas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Buscar"
        '
        'tbx_BuscarCaj
        '
        Me.tbx_BuscarCaj.Control_Siguiente = Nothing
        Me.tbx_BuscarCaj.Filtrado = False
        Me.tbx_BuscarCaj.Location = New System.Drawing.Point(49, 23)
        Me.tbx_BuscarCaj.Name = "tbx_BuscarCaj"
        Me.tbx_BuscarCaj.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarCaj.TabIndex = 19
        Me.tbx_BuscarCaj.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarCaj
        '
        Me.btn_BuscarCaj.Image = CType(resources.GetObject("btn_BuscarCaj.Image"), System.Drawing.Image)
        Me.btn_BuscarCaj.Location = New System.Drawing.Point(449, 20)
        Me.btn_BuscarCaj.Name = "btn_BuscarCaj"
        Me.btn_BuscarCaj.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarCaj.TabIndex = 20
        Me.btn_BuscarCaj.Text = "&Buscar"
        Me.btn_BuscarCaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarCaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCaj.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesC
        '
        Me.lsv_EnvasesC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesC.FullRowSelect = True
        Me.lsv_EnvasesC.HideSelection = False
        Me.lsv_EnvasesC.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter67.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter67.SortColumn = 0
        Me.lsv_EnvasesC.Lvs = ListViewColumnSorter67
        Me.lsv_EnvasesC.MultiSelect = False
        Me.lsv_EnvasesC.Name = "lsv_EnvasesC"
        Me.lsv_EnvasesC.Row1 = 10
        Me.lsv_EnvasesC.Row10 = 10
        Me.lsv_EnvasesC.Row2 = 10
        Me.lsv_EnvasesC.Row3 = 10
        Me.lsv_EnvasesC.Row4 = 10
        Me.lsv_EnvasesC.Row5 = 10
        Me.lsv_EnvasesC.Row6 = 10
        Me.lsv_EnvasesC.Row7 = 10
        Me.lsv_EnvasesC.Row8 = 10
        Me.lsv_EnvasesC.Row9 = 10
        Me.lsv_EnvasesC.Size = New System.Drawing.Size(755, 87)
        Me.lsv_EnvasesC.TabIndex = 10
        Me.lsv_EnvasesC.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesC.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosC
        '
        Me.Lbl_RegistrosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosC.Location = New System.Drawing.Point(615, 3)
        Me.Lbl_RegistrosC.Name = "Lbl_RegistrosC"
        Me.Lbl_RegistrosC.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosC.TabIndex = 8
        Me.Lbl_RegistrosC.Text = "Registros: 0"
        Me.Lbl_RegistrosC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_CajerosT
        '
        Me.Lsv_CajerosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_CajerosT.FullRowSelect = True
        Me.Lsv_CajerosT.HideSelection = False
        Me.Lsv_CajerosT.Location = New System.Drawing.Point(3, 233)
        ListViewColumnSorter68.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter68.SortColumn = 0
        Me.Lsv_CajerosT.Lvs = ListViewColumnSorter68
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
        Me.Lsv_CajerosT.Size = New System.Drawing.Size(755, 87)
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
        Me.Lsv_Cajeros.Location = New System.Drawing.Point(3, 57)
        ListViewColumnSorter69.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter69.SortColumn = 0
        Me.Lsv_Cajeros.Lvs = ListViewColumnSorter69
        Me.Lsv_Cajeros.MultiSelect = False
        Me.Lsv_Cajeros.Name = "Lsv_Cajeros"
        Me.Lsv_Cajeros.Row1 = 10
        Me.Lsv_Cajeros.Row10 = 0
        Me.Lsv_Cajeros.Row2 = 10
        Me.Lsv_Cajeros.Row3 = 10
        Me.Lsv_Cajeros.Row4 = 15
        Me.Lsv_Cajeros.Row5 = 11
        Me.Lsv_Cajeros.Row6 = 0
        Me.Lsv_Cajeros.Row7 = 0
        Me.Lsv_Cajeros.Row8 = 0
        Me.Lsv_Cajeros.Row9 = 0
        Me.Lsv_Cajeros.Size = New System.Drawing.Size(755, 174)
        Me.Lsv_Cajeros.TabIndex = 0
        Me.Lsv_Cajeros.UseCompatibleStateImageBehavior = False
        Me.Lsv_Cajeros.View = System.Windows.Forms.View.Details
        '
        'Morralla
        '
        Me.Morralla.Controls.Add(Me.Label4)
        Me.Morralla.Controls.Add(Me.tbx_BuscarMor)
        Me.Morralla.Controls.Add(Me.btn_BuscarMor)
        Me.Morralla.Controls.Add(Me.lsv_EnvasesM)
        Me.Morralla.Controls.Add(Me.Lbl_RegistrosM)
        Me.Morralla.Controls.Add(Me.Lsv_MorrallaT)
        Me.Morralla.Controls.Add(Me.Lsv_Morralla)
        Me.Morralla.Location = New System.Drawing.Point(4, 22)
        Me.Morralla.Name = "Morralla"
        Me.Morralla.Size = New System.Drawing.Size(761, 412)
        Me.Morralla.TabIndex = 2
        Me.Morralla.Text = "Morralla"
        Me.Morralla.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Buscar"
        '
        'tbx_BuscarMor
        '
        Me.tbx_BuscarMor.Control_Siguiente = Nothing
        Me.tbx_BuscarMor.Filtrado = False
        Me.tbx_BuscarMor.Location = New System.Drawing.Point(49, 22)
        Me.tbx_BuscarMor.Name = "tbx_BuscarMor"
        Me.tbx_BuscarMor.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarMor.TabIndex = 22
        Me.tbx_BuscarMor.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarMor
        '
        Me.btn_BuscarMor.Image = CType(resources.GetObject("btn_BuscarMor.Image"), System.Drawing.Image)
        Me.btn_BuscarMor.Location = New System.Drawing.Point(449, 19)
        Me.btn_BuscarMor.Name = "btn_BuscarMor"
        Me.btn_BuscarMor.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarMor.TabIndex = 23
        Me.btn_BuscarMor.Text = "&Buscar"
        Me.btn_BuscarMor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarMor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarMor.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesM
        '
        Me.lsv_EnvasesM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesM.FullRowSelect = True
        Me.lsv_EnvasesM.HideSelection = False
        Me.lsv_EnvasesM.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter70.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter70.SortColumn = 0
        Me.lsv_EnvasesM.Lvs = ListViewColumnSorter70
        Me.lsv_EnvasesM.MultiSelect = False
        Me.lsv_EnvasesM.Name = "lsv_EnvasesM"
        Me.lsv_EnvasesM.Row1 = 10
        Me.lsv_EnvasesM.Row10 = 10
        Me.lsv_EnvasesM.Row2 = 10
        Me.lsv_EnvasesM.Row3 = 10
        Me.lsv_EnvasesM.Row4 = 10
        Me.lsv_EnvasesM.Row5 = 10
        Me.lsv_EnvasesM.Row6 = 10
        Me.lsv_EnvasesM.Row7 = 10
        Me.lsv_EnvasesM.Row8 = 10
        Me.lsv_EnvasesM.Row9 = 10
        Me.lsv_EnvasesM.Size = New System.Drawing.Size(755, 87)
        Me.lsv_EnvasesM.TabIndex = 10
        Me.lsv_EnvasesM.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesM.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosM
        '
        Me.Lbl_RegistrosM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosM.Location = New System.Drawing.Point(618, 4)
        Me.Lbl_RegistrosM.Name = "Lbl_RegistrosM"
        Me.Lbl_RegistrosM.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosM.TabIndex = 8
        Me.Lbl_RegistrosM.Text = "Registros: 0"
        Me.Lbl_RegistrosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_MorrallaT
        '
        Me.Lsv_MorrallaT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_MorrallaT.FullRowSelect = True
        Me.Lsv_MorrallaT.HideSelection = False
        Me.Lsv_MorrallaT.Location = New System.Drawing.Point(3, 233)
        ListViewColumnSorter71.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter71.SortColumn = 0
        Me.Lsv_MorrallaT.Lvs = ListViewColumnSorter71
        Me.Lsv_MorrallaT.MultiSelect = False
        Me.Lsv_MorrallaT.Name = "Lsv_MorrallaT"
        Me.Lsv_MorrallaT.Row1 = 10
        Me.Lsv_MorrallaT.Row10 = 10
        Me.Lsv_MorrallaT.Row2 = 10
        Me.Lsv_MorrallaT.Row3 = 10
        Me.Lsv_MorrallaT.Row4 = 10
        Me.Lsv_MorrallaT.Row5 = 10
        Me.Lsv_MorrallaT.Row6 = 10
        Me.Lsv_MorrallaT.Row7 = 10
        Me.Lsv_MorrallaT.Row8 = 10
        Me.Lsv_MorrallaT.Row9 = 10
        Me.Lsv_MorrallaT.Size = New System.Drawing.Size(755, 87)
        Me.Lsv_MorrallaT.TabIndex = 1
        Me.Lsv_MorrallaT.UseCompatibleStateImageBehavior = False
        Me.Lsv_MorrallaT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Morralla
        '
        Me.Lsv_Morralla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Morralla.FullRowSelect = True
        Me.Lsv_Morralla.HideSelection = False
        Me.Lsv_Morralla.Location = New System.Drawing.Point(3, 57)
        ListViewColumnSorter72.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter72.SortColumn = 0
        Me.Lsv_Morralla.Lvs = ListViewColumnSorter72
        Me.Lsv_Morralla.MultiSelect = False
        Me.Lsv_Morralla.Name = "Lsv_Morralla"
        Me.Lsv_Morralla.Row1 = 10
        Me.Lsv_Morralla.Row10 = 0
        Me.Lsv_Morralla.Row2 = 10
        Me.Lsv_Morralla.Row3 = 10
        Me.Lsv_Morralla.Row4 = 15
        Me.Lsv_Morralla.Row5 = 11
        Me.Lsv_Morralla.Row6 = 0
        Me.Lsv_Morralla.Row7 = 0
        Me.Lsv_Morralla.Row8 = 0
        Me.Lsv_Morralla.Row9 = 0
        Me.Lsv_Morralla.Size = New System.Drawing.Size(755, 174)
        Me.Lsv_Morralla.TabIndex = 0
        Me.Lsv_Morralla.UseCompatibleStateImageBehavior = False
        Me.Lsv_Morralla.View = System.Windows.Forms.View.Details
        '
        'Clasificados
        '
        Me.Clasificados.Controls.Add(Me.Label5)
        Me.Clasificados.Controls.Add(Me.tbx_BuscarCla)
        Me.Clasificados.Controls.Add(Me.btn_BuscarCla)
        Me.Clasificados.Controls.Add(Me.lsv_EnvasesCl)
        Me.Clasificados.Controls.Add(Me.Lbl_RegistrosCl)
        Me.Clasificados.Controls.Add(Me.Lsv_ClasificadosT)
        Me.Clasificados.Controls.Add(Me.Lsv_Clasificados)
        Me.Clasificados.Location = New System.Drawing.Point(4, 22)
        Me.Clasificados.Name = "Clasificados"
        Me.Clasificados.Size = New System.Drawing.Size(761, 412)
        Me.Clasificados.TabIndex = 3
        Me.Clasificados.Text = "Clasificados"
        Me.Clasificados.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Buscar"
        '
        'tbx_BuscarCla
        '
        Me.tbx_BuscarCla.Control_Siguiente = Nothing
        Me.tbx_BuscarCla.Filtrado = False
        Me.tbx_BuscarCla.Location = New System.Drawing.Point(49, 22)
        Me.tbx_BuscarCla.Name = "tbx_BuscarCla"
        Me.tbx_BuscarCla.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarCla.TabIndex = 25
        Me.tbx_BuscarCla.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarCla
        '
        Me.btn_BuscarCla.Image = CType(resources.GetObject("btn_BuscarCla.Image"), System.Drawing.Image)
        Me.btn_BuscarCla.Location = New System.Drawing.Point(449, 19)
        Me.btn_BuscarCla.Name = "btn_BuscarCla"
        Me.btn_BuscarCla.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarCla.TabIndex = 26
        Me.btn_BuscarCla.Text = "&Buscar"
        Me.btn_BuscarCla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarCla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCla.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesCl
        '
        Me.lsv_EnvasesCl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesCl.FullRowSelect = True
        Me.lsv_EnvasesCl.HideSelection = False
        Me.lsv_EnvasesCl.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter73.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter73.SortColumn = 0
        Me.lsv_EnvasesCl.Lvs = ListViewColumnSorter73
        Me.lsv_EnvasesCl.MultiSelect = False
        Me.lsv_EnvasesCl.Name = "lsv_EnvasesCl"
        Me.lsv_EnvasesCl.Row1 = 10
        Me.lsv_EnvasesCl.Row10 = 10
        Me.lsv_EnvasesCl.Row2 = 10
        Me.lsv_EnvasesCl.Row3 = 10
        Me.lsv_EnvasesCl.Row4 = 10
        Me.lsv_EnvasesCl.Row5 = 10
        Me.lsv_EnvasesCl.Row6 = 10
        Me.lsv_EnvasesCl.Row7 = 10
        Me.lsv_EnvasesCl.Row8 = 10
        Me.lsv_EnvasesCl.Row9 = 10
        Me.lsv_EnvasesCl.Size = New System.Drawing.Size(755, 87)
        Me.lsv_EnvasesCl.TabIndex = 10
        Me.lsv_EnvasesCl.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesCl.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosCl
        '
        Me.Lbl_RegistrosCl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosCl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosCl.Location = New System.Drawing.Point(618, 3)
        Me.Lbl_RegistrosCl.Name = "Lbl_RegistrosCl"
        Me.Lbl_RegistrosCl.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosCl.TabIndex = 8
        Me.Lbl_RegistrosCl.Text = "Registros: 0"
        Me.Lbl_RegistrosCl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_ClasificadosT
        '
        Me.Lsv_ClasificadosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ClasificadosT.FullRowSelect = True
        Me.Lsv_ClasificadosT.HideSelection = False
        Me.Lsv_ClasificadosT.Location = New System.Drawing.Point(3, 233)
        ListViewColumnSorter74.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter74.SortColumn = 0
        Me.Lsv_ClasificadosT.Lvs = ListViewColumnSorter74
        Me.Lsv_ClasificadosT.MultiSelect = False
        Me.Lsv_ClasificadosT.Name = "Lsv_ClasificadosT"
        Me.Lsv_ClasificadosT.Row1 = 10
        Me.Lsv_ClasificadosT.Row10 = 10
        Me.Lsv_ClasificadosT.Row2 = 10
        Me.Lsv_ClasificadosT.Row3 = 10
        Me.Lsv_ClasificadosT.Row4 = 10
        Me.Lsv_ClasificadosT.Row5 = 10
        Me.Lsv_ClasificadosT.Row6 = 10
        Me.Lsv_ClasificadosT.Row7 = 10
        Me.Lsv_ClasificadosT.Row8 = 10
        Me.Lsv_ClasificadosT.Row9 = 10
        Me.Lsv_ClasificadosT.Size = New System.Drawing.Size(755, 87)
        Me.Lsv_ClasificadosT.TabIndex = 1
        Me.Lsv_ClasificadosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ClasificadosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Clasificados
        '
        Me.Lsv_Clasificados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Clasificados.FullRowSelect = True
        Me.Lsv_Clasificados.HideSelection = False
        Me.Lsv_Clasificados.Location = New System.Drawing.Point(3, 57)
        ListViewColumnSorter75.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter75.SortColumn = 0
        Me.Lsv_Clasificados.Lvs = ListViewColumnSorter75
        Me.Lsv_Clasificados.MultiSelect = False
        Me.Lsv_Clasificados.Name = "Lsv_Clasificados"
        Me.Lsv_Clasificados.Row1 = 10
        Me.Lsv_Clasificados.Row10 = 0
        Me.Lsv_Clasificados.Row2 = 10
        Me.Lsv_Clasificados.Row3 = 10
        Me.Lsv_Clasificados.Row4 = 15
        Me.Lsv_Clasificados.Row5 = 11
        Me.Lsv_Clasificados.Row6 = 0
        Me.Lsv_Clasificados.Row7 = 0
        Me.Lsv_Clasificados.Row8 = 0
        Me.Lsv_Clasificados.Row9 = 0
        Me.Lsv_Clasificados.Size = New System.Drawing.Size(755, 174)
        Me.Lsv_Clasificados.TabIndex = 0
        Me.Lsv_Clasificados.UseCompatibleStateImageBehavior = False
        Me.Lsv_Clasificados.View = System.Windows.Forms.View.Details
        '
        'Tab_Nominas
        '
        Me.Tab_Nominas.Controls.Add(Me.Label6)
        Me.Tab_Nominas.Controls.Add(Me.tbx_BuscarNom)
        Me.Tab_Nominas.Controls.Add(Me.btn_BuscarNom)
        Me.Tab_Nominas.Controls.Add(Me.lsv_EnvasesNom)
        Me.Tab_Nominas.Controls.Add(Me.Lbl_RegistrosN)
        Me.Tab_Nominas.Controls.Add(Me.Lsv_NominasT)
        Me.Tab_Nominas.Controls.Add(Me.Lsv_Nominas)
        Me.Tab_Nominas.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nominas.Name = "Tab_Nominas"
        Me.Tab_Nominas.Size = New System.Drawing.Size(761, 412)
        Me.Tab_Nominas.TabIndex = 4
        Me.Tab_Nominas.Text = "Nóminas"
        Me.Tab_Nominas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Buscar"
        '
        'tbx_BuscarNom
        '
        Me.tbx_BuscarNom.Control_Siguiente = Nothing
        Me.tbx_BuscarNom.Filtrado = False
        Me.tbx_BuscarNom.Location = New System.Drawing.Point(53, 28)
        Me.tbx_BuscarNom.Name = "tbx_BuscarNom"
        Me.tbx_BuscarNom.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarNom.TabIndex = 28
        Me.tbx_BuscarNom.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarNom
        '
        Me.btn_BuscarNom.Image = CType(resources.GetObject("btn_BuscarNom.Image"), System.Drawing.Image)
        Me.btn_BuscarNom.Location = New System.Drawing.Point(453, 25)
        Me.btn_BuscarNom.Name = "btn_BuscarNom"
        Me.btn_BuscarNom.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarNom.TabIndex = 29
        Me.btn_BuscarNom.Text = "&Buscar"
        Me.btn_BuscarNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarNom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarNom.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesNom
        '
        Me.lsv_EnvasesNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesNom.FullRowSelect = True
        Me.lsv_EnvasesNom.HideSelection = False
        Me.lsv_EnvasesNom.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter61.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter61.SortColumn = 0
        Me.lsv_EnvasesNom.Lvs = ListViewColumnSorter61
        Me.lsv_EnvasesNom.MultiSelect = False
        Me.lsv_EnvasesNom.Name = "lsv_EnvasesNom"
        Me.lsv_EnvasesNom.Row1 = 10
        Me.lsv_EnvasesNom.Row10 = 10
        Me.lsv_EnvasesNom.Row2 = 10
        Me.lsv_EnvasesNom.Row3 = 10
        Me.lsv_EnvasesNom.Row4 = 10
        Me.lsv_EnvasesNom.Row5 = 10
        Me.lsv_EnvasesNom.Row6 = 10
        Me.lsv_EnvasesNom.Row7 = 10
        Me.lsv_EnvasesNom.Row8 = 10
        Me.lsv_EnvasesNom.Row9 = 10
        Me.lsv_EnvasesNom.Size = New System.Drawing.Size(755, 87)
        Me.lsv_EnvasesNom.TabIndex = 10
        Me.lsv_EnvasesNom.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesNom.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosN
        '
        Me.Lbl_RegistrosN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosN.Location = New System.Drawing.Point(618, 3)
        Me.Lbl_RegistrosN.Name = "Lbl_RegistrosN"
        Me.Lbl_RegistrosN.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosN.TabIndex = 8
        Me.Lbl_RegistrosN.Text = "Registros: 0"
        Me.Lbl_RegistrosN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_NominasT
        '
        Me.Lsv_NominasT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_NominasT.FullRowSelect = True
        Me.Lsv_NominasT.HideSelection = False
        Me.Lsv_NominasT.Location = New System.Drawing.Point(3, 234)
        ListViewColumnSorter62.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter62.SortColumn = 0
        Me.Lsv_NominasT.Lvs = ListViewColumnSorter62
        Me.Lsv_NominasT.MultiSelect = False
        Me.Lsv_NominasT.Name = "Lsv_NominasT"
        Me.Lsv_NominasT.Row1 = 10
        Me.Lsv_NominasT.Row10 = 10
        Me.Lsv_NominasT.Row2 = 10
        Me.Lsv_NominasT.Row3 = 10
        Me.Lsv_NominasT.Row4 = 10
        Me.Lsv_NominasT.Row5 = 10
        Me.Lsv_NominasT.Row6 = 10
        Me.Lsv_NominasT.Row7 = 10
        Me.Lsv_NominasT.Row8 = 10
        Me.Lsv_NominasT.Row9 = 10
        Me.Lsv_NominasT.Size = New System.Drawing.Size(755, 87)
        Me.Lsv_NominasT.TabIndex = 1
        Me.Lsv_NominasT.UseCompatibleStateImageBehavior = False
        Me.Lsv_NominasT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Nominas
        '
        Me.Lsv_Nominas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Nominas.FullRowSelect = True
        Me.Lsv_Nominas.HideSelection = False
        Me.Lsv_Nominas.Location = New System.Drawing.Point(3, 57)
        ListViewColumnSorter63.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter63.SortColumn = 0
        Me.Lsv_Nominas.Lvs = ListViewColumnSorter63
        Me.Lsv_Nominas.MultiSelect = False
        Me.Lsv_Nominas.Name = "Lsv_Nominas"
        Me.Lsv_Nominas.Row1 = 10
        Me.Lsv_Nominas.Row10 = 0
        Me.Lsv_Nominas.Row2 = 10
        Me.Lsv_Nominas.Row3 = 10
        Me.Lsv_Nominas.Row4 = 15
        Me.Lsv_Nominas.Row5 = 11
        Me.Lsv_Nominas.Row6 = 0
        Me.Lsv_Nominas.Row7 = 0
        Me.Lsv_Nominas.Row8 = 0
        Me.Lsv_Nominas.Row9 = 0
        Me.Lsv_Nominas.Size = New System.Drawing.Size(755, 174)
        Me.Lsv_Nominas.TabIndex = 0
        Me.Lsv_Nominas.UseCompatibleStateImageBehavior = False
        Me.Lsv_Nominas.View = System.Windows.Forms.View.Details
        '
        'frm_DevoluciondeResguardo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabPage)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DevoluciondeResguardo"
        Me.Text = "Devolución de Resguardo"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.TabPage.ResumeLayout(False)
        Me.Procesos.ResumeLayout(False)
        Me.Procesos.PerformLayout()
        Me.Cajas.ResumeLayout(False)
        Me.Cajas.PerformLayout()
        Me.Morralla.ResumeLayout(False)
        Me.Morralla.PerformLayout()
        Me.Clasificados.ResumeLayout(False)
        Me.Clasificados.PerformLayout()
        Me.Tab_Nominas.ResumeLayout(False)
        Me.Tab_Nominas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents Procesos As System.Windows.Forms.TabPage
    Friend WithEvents Cajas As System.Windows.Forms.TabPage
    Friend WithEvents Morralla As System.Windows.Forms.TabPage
    Friend WithEvents Clasificados As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Procesos As Modulo_Recepcion.cp_Listview
    Friend WithEvents cmb_Caja As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents Lsv_Cajeros As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Devolucion As System.Windows.Forms.Button
    Friend WithEvents Lsv_Morralla As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Clasificados As Modulo_Recepcion.cp_Listview
    Friend WithEvents Tab_Nominas As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Nominas As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lsv_ProcesosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_CajerosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_MorrallaT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_ClasificadosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_NominasT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_RegistrosP As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosC As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosM As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosCl As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosN As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarP As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarP As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesP As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarCaj As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarCaj As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesC As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarMor As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarMor As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesM As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_EnvasesCl As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarCla As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarCla As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarNom As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarNom As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesNom As Modulo_Recepcion.cp_Listview
End Class
