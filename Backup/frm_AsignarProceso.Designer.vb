<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarProceso
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
        Dim ListViewColumnSorter10 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter11 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter12 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter7 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarProceso))
        Dim ListViewColumnSorter8 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter9 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_Simple
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.Lbl_Cia = New System.Windows.Forms.Label
        Me.cmb_Caja = New Modulo_Recepcion.cp_cmb_Simple
        Me.Lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Facturacion = New System.Windows.Forms.Button
        Me.btn_Devolucion = New System.Windows.Forms.Button
        Me.btn_Morralla = New System.Windows.Forms.Button
        Me.btn_Asignar = New System.Windows.Forms.Button
        Me.lbl_Envases = New System.Windows.Forms.Label
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.lbl_Remisiones = New System.Windows.Forms.Label
        Me.Tab_Servicios = New System.Windows.Forms.TabControl
        Me.Servicios = New System.Windows.Forms.TabPage
        Me.lsv_EnvasesSer = New Modulo_Recepcion.cp_Listview
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_BuscarSer = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarSer = New System.Windows.Forms.Button
        Me.lbl_RegistrosS = New System.Windows.Forms.Label
        Me.lsv_ServiciosD = New Modulo_Recepcion.cp_Listview
        Me.gbx_Servicios = New System.Windows.Forms.GroupBox
        Me.btn_CambiarRemision = New System.Windows.Forms.Button
        Me.Lbl_CambiarNum = New System.Windows.Forms.Label
        Me.tbx_NuevaRemision = New Modulo_Recepcion.cp_Textbox
        Me.cbx_Todos = New System.Windows.Forms.CheckBox
        Me.lsv_Servicios = New Modulo_Recepcion.cp_Listview
        Me.Retenidos = New System.Windows.Forms.TabPage
        Me.lsv_EnvasesRet = New Modulo_Recepcion.cp_Listview
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_BuscarRet = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarRet = New System.Windows.Forms.Button
        Me.lbl_RegistrosR = New System.Windows.Forms.Label
        Me.Lsv_Retenidos = New Modulo_Recepcion.cp_Listview
        Me.Lsv_RetenidosT = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Totales = New System.Windows.Forms.GroupBox
        Me.tbx_TotalImporte = New Modulo_Recepcion.cp_Textbox
        Me.tbx_TotalRemisiones = New Modulo_Recepcion.cp_Textbox
        Me.tbx_TotalEnvases = New Modulo_Recepcion.cp_Textbox
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Tab_Servicios.SuspendLayout()
        Me.Servicios.SuspendLayout()
        Me.gbx_Servicios.SuspendLayout()
        Me.Retenidos.SuspendLayout()
        Me.Gbx_Totales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Todos)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Cia)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Caja)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_CajaBancaria)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(5, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(775, 79)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(429, 47)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 4
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Me.Btn_Cerrar
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(85, 45)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(338, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 3
        Me.cmb_Cia.ValueMember = "ID_Cia"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(629, 13)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Lbl_Cia
        '
        Me.Lbl_Cia.AutoSize = True
        Me.Lbl_Cia.Location = New System.Drawing.Point(13, 48)
        Me.Lbl_Cia.Name = "Lbl_Cia"
        Me.Lbl_Cia.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Cia.TabIndex = 2
        Me.Lbl_Cia.Text = "Cia Traslado"
        '
        'cmb_Caja
        '
        Me.cmb_Caja.Control_Siguiente = Me.cmb_Cia
        Me.cmb_Caja.DisplayMember = "Nombre Comercial"
        Me.cmb_Caja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Caja.Empresa = False
        Me.cmb_Caja.FormattingEnabled = True
        Me.cmb_Caja.Location = New System.Drawing.Point(85, 18)
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
        Me.Lbl_CajaBancaria.Location = New System.Drawing.Point(6, 21)
        Me.Lbl_CajaBancaria.Name = "Lbl_CajaBancaria"
        Me.Lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_CajaBancaria.TabIndex = 0
        Me.Lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Facturacion)
        Me.Gbx_Botones.Controls.Add(Me.btn_Devolucion)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Morralla)
        Me.Gbx_Botones.Controls.Add(Me.btn_Asignar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(775, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Facturacion
        '
        Me.btn_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Facturacion.Enabled = False
        Me.btn_Facturacion.Image = Global.Modulo_Recepcion.My.Resources.Resources.Money_Vault_32
        Me.btn_Facturacion.Location = New System.Drawing.Point(444, 12)
        Me.btn_Facturacion.Name = "btn_Facturacion"
        Me.btn_Facturacion.Size = New System.Drawing.Size(164, 30)
        Me.btn_Facturacion.TabIndex = 4
        Me.btn_Facturacion.Text = "Asignar a &Facturacion"
        Me.btn_Facturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Facturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Facturacion.UseVisualStyleBackColor = True
        '
        'btn_Devolucion
        '
        Me.btn_Devolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Devolucion.Enabled = False
        Me.btn_Devolucion.Image = Global.Modulo_Recepcion.My.Resources.Resources.Banco
        Me.btn_Devolucion.Location = New System.Drawing.Point(298, 13)
        Me.btn_Devolucion.Name = "btn_Devolucion"
        Me.btn_Devolucion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Devolucion.TabIndex = 2
        Me.btn_Devolucion.Text = "&Devol. al Cliente"
        Me.btn_Devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Devolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Devolucion.UseVisualStyleBackColor = True
        '
        'btn_Morralla
        '
        Me.btn_Morralla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Morralla.Enabled = False
        Me.btn_Morralla.Image = Global.Modulo_Recepcion.My.Resources.Resources.coins
        Me.btn_Morralla.Location = New System.Drawing.Point(152, 13)
        Me.btn_Morralla.Name = "btn_Morralla"
        Me.btn_Morralla.Size = New System.Drawing.Size(140, 30)
        Me.btn_Morralla.TabIndex = 1
        Me.btn_Morralla.Text = "Asignar a &Morralla"
        Me.btn_Morralla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Morralla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Morralla.UseVisualStyleBackColor = True
        '
        'btn_Asignar
        '
        Me.btn_Asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Asignar.Enabled = False
        Me.btn_Asignar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Clasificado
        Me.btn_Asignar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Asignar.Name = "btn_Asignar"
        Me.btn_Asignar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Asignar.TabIndex = 0
        Me.btn_Asignar.Text = "&Asignar a Proceso"
        Me.btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Asignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Asignar.UseVisualStyleBackColor = True
        '
        'lbl_Envases
        '
        Me.lbl_Envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Envases.AutoSize = True
        Me.lbl_Envases.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Envases.Location = New System.Drawing.Point(145, 20)
        Me.lbl_Envases.Name = "lbl_Envases"
        Me.lbl_Envases.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Envases.TabIndex = 2
        Me.lbl_Envases.Text = "Envases"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Importe.Location = New System.Drawing.Point(240, 20)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Importe.TabIndex = 4
        Me.lbl_Importe.Text = "Importe"
        '
        'lbl_Remisiones
        '
        Me.lbl_Remisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Remisiones.AutoSize = True
        Me.lbl_Remisiones.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remisiones.Location = New System.Drawing.Point(31, 20)
        Me.lbl_Remisiones.Name = "lbl_Remisiones"
        Me.lbl_Remisiones.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Remisiones.TabIndex = 0
        Me.lbl_Remisiones.Text = "Remisiones"
        '
        'Tab_Servicios
        '
        Me.Tab_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Servicios.Controls.Add(Me.Servicios)
        Me.Tab_Servicios.Controls.Add(Me.Retenidos)
        Me.Tab_Servicios.Location = New System.Drawing.Point(5, 85)
        Me.Tab_Servicios.Name = "Tab_Servicios"
        Me.Tab_Servicios.SelectedIndex = 0
        Me.Tab_Servicios.Size = New System.Drawing.Size(775, 370)
        Me.Tab_Servicios.TabIndex = 1
        '
        'Servicios
        '
        Me.Servicios.Controls.Add(Me.lsv_EnvasesSer)
        Me.Servicios.Controls.Add(Me.lbl_Buscar)
        Me.Servicios.Controls.Add(Me.tbx_BuscarSer)
        Me.Servicios.Controls.Add(Me.btn_BuscarSer)
        Me.Servicios.Controls.Add(Me.lbl_RegistrosS)
        Me.Servicios.Controls.Add(Me.lsv_ServiciosD)
        Me.Servicios.Controls.Add(Me.gbx_Servicios)
        Me.Servicios.Controls.Add(Me.lsv_Servicios)
        Me.Servicios.Location = New System.Drawing.Point(4, 22)
        Me.Servicios.Name = "Servicios"
        Me.Servicios.Padding = New System.Windows.Forms.Padding(3)
        Me.Servicios.Size = New System.Drawing.Size(767, 344)
        Me.Servicios.TabIndex = 0
        Me.Servicios.Text = "Servicios"
        Me.Servicios.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesSer
        '
        Me.lsv_EnvasesSer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesSer.FullRowSelect = True
        Me.lsv_EnvasesSer.HideSelection = False
        Me.lsv_EnvasesSer.Location = New System.Drawing.Point(3, 279)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.lsv_EnvasesSer.Lvs = ListViewColumnSorter10
        Me.lsv_EnvasesSer.MultiSelect = False
        Me.lsv_EnvasesSer.Name = "lsv_EnvasesSer"
        Me.lsv_EnvasesSer.Row1 = 10
        Me.lsv_EnvasesSer.Row10 = 10
        Me.lsv_EnvasesSer.Row2 = 10
        Me.lsv_EnvasesSer.Row3 = 10
        Me.lsv_EnvasesSer.Row4 = 10
        Me.lsv_EnvasesSer.Row5 = 10
        Me.lsv_EnvasesSer.Row6 = 10
        Me.lsv_EnvasesSer.Row7 = 10
        Me.lsv_EnvasesSer.Row8 = 10
        Me.lsv_EnvasesSer.Row9 = 10
        Me.lsv_EnvasesSer.Size = New System.Drawing.Size(761, 62)
        Me.lsv_EnvasesSer.TabIndex = 18
        Me.lsv_EnvasesSer.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesSer.View = System.Windows.Forms.View.Details
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(6, 68)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 15
        Me.lbl_Buscar.Text = "Buscar"
        '
        'tbx_BuscarSer
        '
        Me.tbx_BuscarSer.Control_Siguiente = Nothing
        Me.tbx_BuscarSer.Filtrado = False
        Me.tbx_BuscarSer.Location = New System.Drawing.Point(52, 65)
        Me.tbx_BuscarSer.Name = "tbx_BuscarSer"
        Me.tbx_BuscarSer.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarSer.TabIndex = 16
        Me.tbx_BuscarSer.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarSer
        '
        Me.btn_BuscarSer.Image = CType(resources.GetObject("btn_BuscarSer.Image"), System.Drawing.Image)
        Me.btn_BuscarSer.Location = New System.Drawing.Point(452, 62)
        Me.btn_BuscarSer.Name = "btn_BuscarSer"
        Me.btn_BuscarSer.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarSer.TabIndex = 17
        Me.btn_BuscarSer.Text = "&Buscar"
        Me.btn_BuscarSer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarSer.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosS
        '
        Me.lbl_RegistrosS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosS.Location = New System.Drawing.Point(629, 56)
        Me.lbl_RegistrosS.Name = "lbl_RegistrosS"
        Me.lbl_RegistrosS.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosS.TabIndex = 5
        Me.lbl_RegistrosS.Text = "Registros: 0"
        Me.lbl_RegistrosS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_ServiciosD
        '
        Me.lsv_ServiciosD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosD.FullRowSelect = True
        Me.lsv_ServiciosD.HideSelection = False
        Me.lsv_ServiciosD.Location = New System.Drawing.Point(3, 203)
        ListViewColumnSorter11.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter11.SortColumn = 0
        Me.lsv_ServiciosD.Lvs = ListViewColumnSorter11
        Me.lsv_ServiciosD.MultiSelect = False
        Me.lsv_ServiciosD.Name = "lsv_ServiciosD"
        Me.lsv_ServiciosD.Row1 = 10
        Me.lsv_ServiciosD.Row10 = 10
        Me.lsv_ServiciosD.Row2 = 10
        Me.lsv_ServiciosD.Row3 = 10
        Me.lsv_ServiciosD.Row4 = 10
        Me.lsv_ServiciosD.Row5 = 10
        Me.lsv_ServiciosD.Row6 = 10
        Me.lsv_ServiciosD.Row7 = 10
        Me.lsv_ServiciosD.Row8 = 10
        Me.lsv_ServiciosD.Row9 = 10
        Me.lsv_ServiciosD.Size = New System.Drawing.Size(761, 73)
        Me.lsv_ServiciosD.TabIndex = 1
        Me.lsv_ServiciosD.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosD.View = System.Windows.Forms.View.Details
        '
        'gbx_Servicios
        '
        Me.gbx_Servicios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Servicios.Controls.Add(Me.btn_CambiarRemision)
        Me.gbx_Servicios.Controls.Add(Me.Lbl_CambiarNum)
        Me.gbx_Servicios.Controls.Add(Me.tbx_NuevaRemision)
        Me.gbx_Servicios.Controls.Add(Me.cbx_Todos)
        Me.gbx_Servicios.Location = New System.Drawing.Point(3, 6)
        Me.gbx_Servicios.Name = "gbx_Servicios"
        Me.gbx_Servicios.Size = New System.Drawing.Size(761, 47)
        Me.gbx_Servicios.TabIndex = 0
        Me.gbx_Servicios.TabStop = False
        '
        'btn_CambiarRemision
        '
        Me.btn_CambiarRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CambiarRemision.Enabled = False
        Me.btn_CambiarRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.btn_CambiarRemision.Location = New System.Drawing.Point(615, 11)
        Me.btn_CambiarRemision.Name = "btn_CambiarRemision"
        Me.btn_CambiarRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_CambiarRemision.TabIndex = 3
        Me.btn_CambiarRemision.Text = "Cam&biar"
        Me.btn_CambiarRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CambiarRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CambiarRemision.UseVisualStyleBackColor = True
        '
        'Lbl_CambiarNum
        '
        Me.Lbl_CambiarNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CambiarNum.AutoSize = True
        Me.Lbl_CambiarNum.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CambiarNum.Location = New System.Drawing.Point(332, 20)
        Me.Lbl_CambiarNum.Name = "Lbl_CambiarNum"
        Me.Lbl_CambiarNum.Size = New System.Drawing.Size(146, 13)
        Me.Lbl_CambiarNum.TabIndex = 1
        Me.Lbl_CambiarNum.Text = "Cambiar Número de Remisión"
        '
        'tbx_NuevaRemision
        '
        Me.tbx_NuevaRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_NuevaRemision.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_NuevaRemision.Control_Siguiente = Me.btn_CambiarRemision
        Me.tbx_NuevaRemision.Filtrado = True
        Me.tbx_NuevaRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NuevaRemision.Location = New System.Drawing.Point(484, 15)
        Me.tbx_NuevaRemision.MaxLength = 15
        Me.tbx_NuevaRemision.Name = "tbx_NuevaRemision"
        Me.tbx_NuevaRemision.Size = New System.Drawing.Size(125, 23)
        Me.tbx_NuevaRemision.TabIndex = 2
        Me.tbx_NuevaRemision.TabStop = False
        Me.tbx_NuevaRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NuevaRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cbx_Todos
        '
        Me.cbx_Todos.AutoSize = True
        Me.cbx_Todos.Location = New System.Drawing.Point(6, 19)
        Me.cbx_Todos.Name = "cbx_Todos"
        Me.cbx_Todos.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todos.TabIndex = 0
        Me.cbx_Todos.Text = "Todos"
        Me.cbx_Todos.UseVisualStyleBackColor = True
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.AllowColumnReorder = True
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(3, 93)
        ListViewColumnSorter12.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter12.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter12
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 10
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 30
        Me.lsv_Servicios.Row3 = 30
        Me.lsv_Servicios.Row4 = 15
        Me.lsv_Servicios.Row5 = 10
        Me.lsv_Servicios.Row6 = 0
        Me.lsv_Servicios.Row7 = 0
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(761, 105)
        Me.lsv_Servicios.TabIndex = 4
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'Retenidos
        '
        Me.Retenidos.Controls.Add(Me.lsv_EnvasesRet)
        Me.Retenidos.Controls.Add(Me.Label1)
        Me.Retenidos.Controls.Add(Me.tbx_BuscarRet)
        Me.Retenidos.Controls.Add(Me.btn_BuscarRet)
        Me.Retenidos.Controls.Add(Me.lbl_RegistrosR)
        Me.Retenidos.Controls.Add(Me.Lsv_Retenidos)
        Me.Retenidos.Controls.Add(Me.Lsv_RetenidosT)
        Me.Retenidos.Location = New System.Drawing.Point(4, 22)
        Me.Retenidos.Name = "Retenidos"
        Me.Retenidos.Padding = New System.Windows.Forms.Padding(3)
        Me.Retenidos.Size = New System.Drawing.Size(767, 344)
        Me.Retenidos.TabIndex = 1
        Me.Retenidos.Text = "Retenidos"
        Me.Retenidos.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesRet
        '
        Me.lsv_EnvasesRet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesRet.FullRowSelect = True
        Me.lsv_EnvasesRet.HideSelection = False
        Me.lsv_EnvasesRet.Location = New System.Drawing.Point(4, 271)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_EnvasesRet.Lvs = ListViewColumnSorter7
        Me.lsv_EnvasesRet.MultiSelect = False
        Me.lsv_EnvasesRet.Name = "lsv_EnvasesRet"
        Me.lsv_EnvasesRet.Row1 = 10
        Me.lsv_EnvasesRet.Row10 = 10
        Me.lsv_EnvasesRet.Row2 = 10
        Me.lsv_EnvasesRet.Row3 = 10
        Me.lsv_EnvasesRet.Row4 = 10
        Me.lsv_EnvasesRet.Row5 = 10
        Me.lsv_EnvasesRet.Row6 = 10
        Me.lsv_EnvasesRet.Row7 = 10
        Me.lsv_EnvasesRet.Row8 = 10
        Me.lsv_EnvasesRet.Row9 = 10
        Me.lsv_EnvasesRet.Size = New System.Drawing.Size(758, 67)
        Me.lsv_EnvasesRet.TabIndex = 21
        Me.lsv_EnvasesRet.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesRet.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar"
        '
        'tbx_BuscarRet
        '
        Me.tbx_BuscarRet.Control_Siguiente = Nothing
        Me.tbx_BuscarRet.Filtrado = False
        Me.tbx_BuscarRet.Location = New System.Drawing.Point(55, 20)
        Me.tbx_BuscarRet.Name = "tbx_BuscarRet"
        Me.tbx_BuscarRet.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarRet.TabIndex = 19
        Me.tbx_BuscarRet.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarRet
        '
        Me.btn_BuscarRet.Image = CType(resources.GetObject("btn_BuscarRet.Image"), System.Drawing.Image)
        Me.btn_BuscarRet.Location = New System.Drawing.Point(455, 17)
        Me.btn_BuscarRet.Name = "btn_BuscarRet"
        Me.btn_BuscarRet.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarRet.TabIndex = 20
        Me.btn_BuscarRet.Text = "&Buscar"
        Me.btn_BuscarRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarRet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarRet.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosR
        '
        Me.lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosR.Location = New System.Drawing.Point(618, 3)
        Me.lbl_RegistrosR.Name = "lbl_RegistrosR"
        Me.lbl_RegistrosR.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosR.TabIndex = 4
        Me.lbl_RegistrosR.Text = "Registros: 0"
        Me.lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Retenidos
        '
        Me.Lsv_Retenidos.AllowColumnReorder = True
        Me.Lsv_Retenidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Retenidos.FullRowSelect = True
        Me.Lsv_Retenidos.HideSelection = False
        Me.Lsv_Retenidos.Location = New System.Drawing.Point(3, 51)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.Lsv_Retenidos.Lvs = ListViewColumnSorter8
        Me.Lsv_Retenidos.MultiSelect = False
        Me.Lsv_Retenidos.Name = "Lsv_Retenidos"
        Me.Lsv_Retenidos.Row1 = 10
        Me.Lsv_Retenidos.Row10 = 0
        Me.Lsv_Retenidos.Row2 = 30
        Me.Lsv_Retenidos.Row3 = 30
        Me.Lsv_Retenidos.Row4 = 15
        Me.Lsv_Retenidos.Row5 = 10
        Me.Lsv_Retenidos.Row6 = 0
        Me.Lsv_Retenidos.Row7 = 0
        Me.Lsv_Retenidos.Row8 = 0
        Me.Lsv_Retenidos.Row9 = 0
        Me.Lsv_Retenidos.Size = New System.Drawing.Size(758, 125)
        Me.Lsv_Retenidos.TabIndex = 0
        Me.Lsv_Retenidos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Retenidos.View = System.Windows.Forms.View.Details
        '
        'Lsv_RetenidosT
        '
        Me.Lsv_RetenidosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_RetenidosT.FullRowSelect = True
        Me.Lsv_RetenidosT.HideSelection = False
        Me.Lsv_RetenidosT.Location = New System.Drawing.Point(3, 180)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.Lsv_RetenidosT.Lvs = ListViewColumnSorter9
        Me.Lsv_RetenidosT.MultiSelect = False
        Me.Lsv_RetenidosT.Name = "Lsv_RetenidosT"
        Me.Lsv_RetenidosT.Row1 = 10
        Me.Lsv_RetenidosT.Row10 = 10
        Me.Lsv_RetenidosT.Row2 = 10
        Me.Lsv_RetenidosT.Row3 = 10
        Me.Lsv_RetenidosT.Row4 = 10
        Me.Lsv_RetenidosT.Row5 = 10
        Me.Lsv_RetenidosT.Row6 = 10
        Me.Lsv_RetenidosT.Row7 = 10
        Me.Lsv_RetenidosT.Row8 = 10
        Me.Lsv_RetenidosT.Row9 = 10
        Me.Lsv_RetenidosT.Size = New System.Drawing.Size(758, 87)
        Me.Lsv_RetenidosT.TabIndex = 1
        Me.Lsv_RetenidosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_RetenidosT.View = System.Windows.Forms.View.Details
        '
        'Gbx_Totales
        '
        Me.Gbx_Totales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Totales.Controls.Add(Me.tbx_TotalImporte)
        Me.Gbx_Totales.Controls.Add(Me.tbx_TotalRemisiones)
        Me.Gbx_Totales.Controls.Add(Me.tbx_TotalEnvases)
        Me.Gbx_Totales.Controls.Add(Me.lbl_Envases)
        Me.Gbx_Totales.Controls.Add(Me.lbl_Remisiones)
        Me.Gbx_Totales.Controls.Add(Me.lbl_Importe)
        Me.Gbx_Totales.Location = New System.Drawing.Point(5, 460)
        Me.Gbx_Totales.Name = "Gbx_Totales"
        Me.Gbx_Totales.Size = New System.Drawing.Size(775, 47)
        Me.Gbx_Totales.TabIndex = 2
        Me.Gbx_Totales.TabStop = False
        Me.Gbx_Totales.Text = "Totales"
        '
        'tbx_TotalImporte
        '
        Me.tbx_TotalImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotalImporte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_TotalImporte.Control_Siguiente = Me.Btn_Cerrar
        Me.tbx_TotalImporte.Filtrado = True
        Me.tbx_TotalImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalImporte.Location = New System.Drawing.Point(288, 17)
        Me.tbx_TotalImporte.MaxLength = 10
        Me.tbx_TotalImporte.Name = "tbx_TotalImporte"
        Me.tbx_TotalImporte.ReadOnly = True
        Me.tbx_TotalImporte.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TotalImporte.TabIndex = 5
        Me.tbx_TotalImporte.TabStop = False
        Me.tbx_TotalImporte.Text = "0"
        Me.tbx_TotalImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_TotalImporte.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_TotalRemisiones
        '
        Me.tbx_TotalRemisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotalRemisiones.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_TotalRemisiones.Control_Siguiente = Me.tbx_TotalEnvases
        Me.tbx_TotalRemisiones.Filtrado = True
        Me.tbx_TotalRemisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemisiones.Location = New System.Drawing.Point(97, 17)
        Me.tbx_TotalRemisiones.MaxLength = 10
        Me.tbx_TotalRemisiones.Name = "tbx_TotalRemisiones"
        Me.tbx_TotalRemisiones.ReadOnly = True
        Me.tbx_TotalRemisiones.Size = New System.Drawing.Size(40, 20)
        Me.tbx_TotalRemisiones.TabIndex = 1
        Me.tbx_TotalRemisiones.TabStop = False
        Me.tbx_TotalRemisiones.Text = "0"
        Me.tbx_TotalRemisiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_TotalRemisiones.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_TotalEnvases
        '
        Me.tbx_TotalEnvases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_TotalEnvases.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbx_TotalEnvases.Control_Siguiente = Me.tbx_TotalImporte
        Me.tbx_TotalEnvases.Filtrado = True
        Me.tbx_TotalEnvases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalEnvases.Location = New System.Drawing.Point(194, 17)
        Me.tbx_TotalEnvases.MaxLength = 10
        Me.tbx_TotalEnvases.Name = "tbx_TotalEnvases"
        Me.tbx_TotalEnvases.ReadOnly = True
        Me.tbx_TotalEnvases.Size = New System.Drawing.Size(40, 20)
        Me.tbx_TotalEnvases.TabIndex = 3
        Me.tbx_TotalEnvases.TabStop = False
        Me.tbx_TotalEnvases.Text = "0"
        Me.tbx_TotalEnvases.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_TotalEnvases.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'frm_AsignarProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Totales)
        Me.Controls.Add(Me.Tab_Servicios)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AsignarProceso"
        Me.Text = "Asignar a Proceso"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Tab_Servicios.ResumeLayout(False)
        Me.Servicios.ResumeLayout(False)
        Me.Servicios.PerformLayout()
        Me.gbx_Servicios.ResumeLayout(False)
        Me.gbx_Servicios.PerformLayout()
        Me.Retenidos.ResumeLayout(False)
        Me.Retenidos.PerformLayout()
        Me.Gbx_Totales.ResumeLayout(False)
        Me.Gbx_Totales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents lbl_Envases As System.Windows.Forms.Label
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents lbl_Remisiones As System.Windows.Forms.Label
    Friend WithEvents tbx_TotalEnvases As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_TotalImporte As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_TotalRemisiones As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Tab_Servicios As System.Windows.Forms.TabControl
    Friend WithEvents Servicios As System.Windows.Forms.TabPage
    Friend WithEvents Retenidos As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Servicios As Modulo_Recepcion.cp_Listview
    Friend WithEvents cmb_Caja As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents Lbl_Cia As System.Windows.Forms.Label
    Friend WithEvents Lsv_Retenidos As Modulo_Recepcion.cp_Listview
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Asignar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_ServiciosD As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_RetenidosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Servicios As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_CambiarRemision As System.Windows.Forms.Button
    Friend WithEvents Lbl_CambiarNum As System.Windows.Forms.Label
    Friend WithEvents tbx_NuevaRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Morralla As System.Windows.Forms.Button
    Friend WithEvents Gbx_Totales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Devolucion As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistrosS As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents btn_Facturacion As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesSer As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarSer As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarSer As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesRet As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarRet As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarRet As System.Windows.Forms.Button
End Class
