<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecepcionCustodiasATMs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RecepcionCustodiasATMs))
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.lbl_Cajero = New System.Windows.Forms.Label
        Me.Lbl_NRemision = New System.Windows.Forms.Label
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.dgDinero = New System.Windows.Forms.DataGridView
        Me.Lbl_CajaBancaria = New System.Windows.Forms.Label
        Me.grbEnvases = New System.Windows.Forms.GroupBox
        Me.lbl_TotalEnvases = New System.Windows.Forms.Label
        Me.lbl_Tcapturado = New System.Windows.Forms.Label
        Me.Lbl_EnvasesSN = New System.Windows.Forms.Label
        Me.tbx_EnvasesSn = New Modulo_Recepcion.cp_Textbox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_Numero = New Modulo_Recepcion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Recepcion.cp_cmb_Simple
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_Banco = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Cajeros = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.tbx_CveCliente = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Banco = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEnvases.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(36, 15)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'lbl_Cajero
        '
        Me.lbl_Cajero.AutoSize = True
        Me.lbl_Cajero.Location = New System.Drawing.Point(43, 69)
        Me.lbl_Cajero.Name = "lbl_Cajero"
        Me.lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Cajero.TabIndex = 6
        Me.lbl_Cajero.Text = "Cajero"
        '
        'Lbl_NRemision
        '
        Me.Lbl_NRemision.AutoSize = True
        Me.Lbl_NRemision.Location = New System.Drawing.Point(2, 104)
        Me.Lbl_NRemision.Name = "Lbl_NRemision"
        Me.Lbl_NRemision.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NRemision.TabIndex = 9
        Me.Lbl_NRemision.Text = "Num. Remisión"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(381, 12)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'dgDinero
        '
        Me.dgDinero.AllowUserToAddRows = False
        Me.dgDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDinero.Location = New System.Drawing.Point(7, 128)
        Me.dgDinero.Name = "dgDinero"
        Me.dgDinero.Size = New System.Drawing.Size(526, 156)
        Me.dgDinero.TabIndex = 11
        '
        'Lbl_CajaBancaria
        '
        Me.Lbl_CajaBancaria.AutoSize = True
        Me.Lbl_CajaBancaria.Location = New System.Drawing.Point(7, 42)
        Me.Lbl_CajaBancaria.Name = "Lbl_CajaBancaria"
        Me.Lbl_CajaBancaria.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_CajaBancaria.TabIndex = 3
        Me.Lbl_CajaBancaria.Text = "Caja Bancaria"
        '
        'grbEnvases
        '
        Me.grbEnvases.Controls.Add(Me.lbl_TotalEnvases)
        Me.grbEnvases.Controls.Add(Me.lbl_Tcapturado)
        Me.grbEnvases.Controls.Add(Me.Lbl_EnvasesSN)
        Me.grbEnvases.Controls.Add(Me.tbx_EnvasesSn)
        Me.grbEnvases.Controls.Add(Me.btn_Eliminar)
        Me.grbEnvases.Controls.Add(Me.lsv_Envases)
        Me.grbEnvases.Controls.Add(Me.Btn_Agregar)
        Me.grbEnvases.Controls.Add(Me.tbx_Numero)
        Me.grbEnvases.Controls.Add(Me.cmb_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_numero)
        Me.grbEnvases.Location = New System.Drawing.Point(7, 290)
        Me.grbEnvases.Name = "grbEnvases"
        Me.grbEnvases.Size = New System.Drawing.Size(526, 245)
        Me.grbEnvases.TabIndex = 12
        Me.grbEnvases.TabStop = False
        Me.grbEnvases.Text = "Envases"
        '
        'lbl_TotalEnvases
        '
        Me.lbl_TotalEnvases.AutoSize = True
        Me.lbl_TotalEnvases.Location = New System.Drawing.Point(111, 218)
        Me.lbl_TotalEnvases.Name = "lbl_TotalEnvases"
        Me.lbl_TotalEnvases.Size = New System.Drawing.Size(13, 13)
        Me.lbl_TotalEnvases.TabIndex = 10
        Me.lbl_TotalEnvases.Text = "0"
        '
        'lbl_Tcapturado
        '
        Me.lbl_Tcapturado.AutoSize = True
        Me.lbl_Tcapturado.Location = New System.Drawing.Point(90, 199)
        Me.lbl_Tcapturado.Name = "lbl_Tcapturado"
        Me.lbl_Tcapturado.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Tcapturado.TabIndex = 9
        Me.lbl_Tcapturado.Text = "Total Envases"
        '
        'Lbl_EnvasesSN
        '
        Me.Lbl_EnvasesSN.AutoSize = True
        Me.Lbl_EnvasesSN.Location = New System.Drawing.Point(13, 199)
        Me.Lbl_EnvasesSN.Name = "Lbl_EnvasesSN"
        Me.Lbl_EnvasesSN.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_EnvasesSN.TabIndex = 7
        Me.Lbl_EnvasesSN.Text = "Envases S/N"
        '
        'tbx_EnvasesSn
        '
        Me.tbx_EnvasesSn.Control_Siguiente = Nothing
        Me.tbx_EnvasesSn.Filtrado = True
        Me.tbx_EnvasesSn.Location = New System.Drawing.Point(16, 215)
        Me.tbx_EnvasesSn.MaxLength = 4
        Me.tbx_EnvasesSn.Name = "tbx_EnvasesSn"
        Me.tbx_EnvasesSn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_EnvasesSn.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EnvasesSn.TabIndex = 8
        Me.tbx_EnvasesSn.Text = "0"
        Me.tbx_EnvasesSn.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 154)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(153, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 50
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(367, 165)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 118)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_Numero.Filtrado = False
        Me.tbx_Numero.Location = New System.Drawing.Point(6, 35)
        Me.tbx_Numero.MaxLength = 15
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(141, 20)
        Me.tbx_Numero.TabIndex = 1
        Me.tbx_Numero.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_TipoEnvase
        '
        Me.cmb_TipoEnvase.Control_Siguiente = Me.Btn_Agregar
        Me.cmb_TipoEnvase.DisplayMember = "Descripcion"
        Me.cmb_TipoEnvase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoEnvase.Empresa = False
        Me.cmb_TipoEnvase.FormattingEnabled = True
        Me.cmb_TipoEnvase.Location = New System.Drawing.Point(6, 74)
        Me.cmb_TipoEnvase.MaxDropDownItems = 20
        Me.cmb_TipoEnvase.Name = "cmb_TipoEnvase"
        Me.cmb_TipoEnvase.Pista = True
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(141, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
        '
        'lbl_TipoEnvase
        '
        Me.lbl_TipoEnvase.AutoSize = True
        Me.lbl_TipoEnvase.Location = New System.Drawing.Point(6, 58)
        Me.lbl_TipoEnvase.Name = "lbl_TipoEnvase"
        Me.lbl_TipoEnvase.Size = New System.Drawing.Size(82, 13)
        Me.lbl_TipoEnvase.TabIndex = 2
        Me.lbl_TipoEnvase.Text = "Tipo de Envase"
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(6, 19)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(44, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Número"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.Btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cancelar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 541)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(526, 50)
        Me.Gbx_Botones.TabIndex = 13
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(4, 12)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_Banco
        '
        Me.tbx_Banco.Control_Siguiente = Me.cmb_Cajeros
        Me.tbx_Banco.Filtrado = True
        Me.tbx_Banco.Location = New System.Drawing.Point(86, 39)
        Me.tbx_Banco.MaxLength = 4
        Me.tbx_Banco.Name = "tbx_Banco"
        Me.tbx_Banco.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Banco.TabIndex = 4
        Me.tbx_Banco.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_Banco.Visible = False
        '
        'cmb_Cajeros
        '
        Me.cmb_Cajeros.Clave = "No. Cajero"
        Me.cmb_Cajeros.Control_Siguiente = Me.tbx_Remision
        Me.cmb_Cajeros.DisplayMember = "Descripcion"
        Me.cmb_Cajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cajeros.Empresa = False
        Me.cmb_Cajeros.Filtro = Me.tbx_CveCliente
        Me.cmb_Cajeros.FormattingEnabled = True
        Me.cmb_Cajeros.Location = New System.Drawing.Point(142, 66)
        Me.cmb_Cajeros.MaxDropDownItems = 20
        Me.cmb_Cajeros.Name = "cmb_Cajeros"
        Me.cmb_Cajeros.Pista = False
        Me.cmb_Cajeros.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Cajeros.StoredProcedure = "Caj_Cajeros_GET"
        Me.cmb_Cajeros.Sucursal = True
        Me.cmb_Cajeros.TabIndex = 8
        Me.cmb_Cajeros.Tipo = 0
        Me.cmb_Cajeros.ValueMember = "Id_Cajero"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.dgDinero
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Remision.Location = New System.Drawing.Point(86, 93)
        Me.tbx_Remision.MaxLength = 10
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(183, 29)
        Me.tbx_Remision.TabIndex = 10
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_CveCliente
        '
        Me.tbx_CveCliente.Control_Siguiente = Me.cmb_Cajeros
        Me.tbx_CveCliente.Filtrado = True
        Me.tbx_CveCliente.Location = New System.Drawing.Point(86, 66)
        Me.tbx_CveCliente.MaxLength = 4
        Me.tbx_CveCliente.Name = "tbx_CveCliente"
        Me.tbx_CveCliente.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveCliente.TabIndex = 7
        Me.tbx_CveCliente.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Banco
        '
        Me.cmb_Banco.Clave = "ID_ClienteP"
        Me.cmb_Banco.Control_Siguiente = Me.tbx_Remision
        Me.cmb_Banco.DisplayMember = "Nombre_Comercial"
        Me.cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Banco.Empresa = False
        Me.cmb_Banco.Filtro = Me.tbx_Banco
        Me.cmb_Banco.FormattingEnabled = True
        Me.cmb_Banco.Location = New System.Drawing.Point(142, 39)
        Me.cmb_Banco.MaxDropDownItems = 20
        Me.cmb_Banco.Name = "cmb_Banco"
        Me.cmb_Banco.Pista = False
        Me.cmb_Banco.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Banco.StoredProcedure = "Cat_ClientesBancos_Read"
        Me.cmb_Banco.Sucursal = False
        Me.cmb_Banco.TabIndex = 5
        Me.cmb_Banco.Tipo = 0
        Me.cmb_Banco.ValueMember = "Id_CajaBancaria"
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(86, 12)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 1
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Me.tbx_CveCliente
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_Cve_Boveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(142, 12)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(321, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 2
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'frm_RecepcionCustodiasATMs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 601)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grbEnvases)
        Me.Controls.Add(Me.tbx_Banco)
        Me.Controls.Add(Me.cmb_Banco)
        Me.Controls.Add(Me.Lbl_CajaBancaria)
        Me.Controls.Add(Me.dgDinero)
        Me.Controls.Add(Me.Lbl_NRemision)
        Me.Controls.Add(Me.tbx_Remision)
        Me.Controls.Add(Me.cmb_Cajeros)
        Me.Controls.Add(Me.tbx_CveCliente)
        Me.Controls.Add(Me.lbl_Cajero)
        Me.Controls.Add(Me.tbx_Cve_Boveda)
        Me.Controls.Add(Me.cmb_Boveda)
        Me.Controls.Add(Me.lbl_Boveda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 630)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 630)
        Me.Name = "frm_RecepcionCustodiasATMs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepción de Custodias de ATM's"
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEnvases.ResumeLayout(False)
        Me.grbEnvases.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveCliente As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents cmb_Cajeros As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_NRemision As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dgDinero As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_CajaBancaria As System.Windows.Forms.Label
    Friend WithEvents cmb_Banco As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Banco As Modulo_Recepcion.cp_Textbox
    Friend WithEvents grbEnvases As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbx_Numero As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_TipoEnvase As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents lbl_TipoEnvase As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalEnvases As System.Windows.Forms.Label
    Friend WithEvents lbl_Tcapturado As System.Windows.Forms.Label
    Friend WithEvents Lbl_EnvasesSN As System.Windows.Forms.Label
    Friend WithEvents tbx_EnvasesSn As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
End Class
