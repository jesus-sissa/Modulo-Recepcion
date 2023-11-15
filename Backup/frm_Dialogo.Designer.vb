<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Dialogo
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
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.GpoDatos = New System.Windows.Forms.GroupBox
        Me.tbx_EnvasesSN = New Modulo_Recepcion.cp_Textbox
        Me.tbx_NumeroEnvase = New Modulo_Recepcion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Recepcion.cp_cmb_Simple
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.grbEnvases = New System.Windows.Forms.GroupBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.dgDinero = New System.Windows.Forms.DataGridView
        Me.Gbx_NRemision = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_Minutos = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Horas = New Modulo_Recepcion.cp_Textbox
        Me.lbl_HoraRemision = New System.Windows.Forms.Label
        Me.cmb_CiasProp = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_Cias = New System.Windows.Forms.Label
        Me.tbx_RemisionReemplazo = New Modulo_Recepcion.cp_Textbox
        Me.tbx_RemisionOriginal = New Modulo_Recepcion.cp_Textbox
        Me.lbl_RemisionReemplazo = New System.Windows.Forms.Label
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Regresa = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_TotalRem = New System.Windows.Forms.GroupBox
        Me.lbl_DestinoNombre = New System.Windows.Forms.Label
        Me.lbl_OrigenNombre = New System.Windows.Forms.Label
        Me.lbl_Destino = New System.Windows.Forms.Label
        Me.lbl_Origen = New System.Windows.Forms.Label
        Me.lbl_TRemision = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbx_TotalRemision = New Modulo_Recepcion.cp_Textbox
        Me.GpoDatos.SuspendLayout()
        Me.grbEnvases.SuspendLayout()
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_NRemision.SuspendLayout()
        Me.Gbx_TotalRem.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpoDatos
        '
        Me.GpoDatos.Controls.Add(Me.tbx_EnvasesSN)
        Me.GpoDatos.Controls.Add(Me.Lbl_Total)
        Me.GpoDatos.Controls.Add(Me.grbEnvases)
        Me.GpoDatos.Location = New System.Drawing.Point(11, 342)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(503, 208)
        Me.GpoDatos.TabIndex = 5
        Me.GpoDatos.TabStop = False
        '
        'tbx_EnvasesSN
        '
        Me.tbx_EnvasesSN.Control_Siguiente = Me.tbx_NumeroEnvase
        Me.tbx_EnvasesSN.Filtrado = True
        Me.tbx_EnvasesSN.Location = New System.Drawing.Point(430, 183)
        Me.tbx_EnvasesSN.MaxLength = 4
        Me.tbx_EnvasesSN.Name = "tbx_EnvasesSN"
        Me.tbx_EnvasesSN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_EnvasesSN.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EnvasesSN.TabIndex = 2
        Me.tbx_EnvasesSN.Text = "0"
        Me.tbx_EnvasesSN.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NumeroEnvase
        '
        Me.tbx_NumeroEnvase.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_NumeroEnvase.Filtrado = True
        Me.tbx_NumeroEnvase.Location = New System.Drawing.Point(6, 35)
        Me.tbx_NumeroEnvase.MaxLength = 15
        Me.tbx_NumeroEnvase.Name = "tbx_NumeroEnvase"
        Me.tbx_NumeroEnvase.Size = New System.Drawing.Size(140, 20)
        Me.tbx_NumeroEnvase.TabIndex = 1
        Me.tbx_NumeroEnvase.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
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
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(140, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 98)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Location = New System.Drawing.Point(319, 186)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_Total.TabIndex = 1
        Me.Lbl_Total.Text = "Envases sin Número:"
        '
        'grbEnvases
        '
        Me.grbEnvases.Controls.Add(Me.btn_Eliminar)
        Me.grbEnvases.Controls.Add(Me.lsv_Envases)
        Me.grbEnvases.Controls.Add(Me.Btn_Agregar)
        Me.grbEnvases.Controls.Add(Me.tbx_NumeroEnvase)
        Me.grbEnvases.Controls.Add(Me.cmb_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_numero)
        Me.grbEnvases.Location = New System.Drawing.Point(6, 10)
        Me.grbEnvases.Name = "grbEnvases"
        Me.grbEnvases.Size = New System.Drawing.Size(490, 169)
        Me.grbEnvases.TabIndex = 0
        Me.grbEnvases.TabStop = False
        Me.grbEnvases.Text = "Envases"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 134)
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
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter2
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 45
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 45
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(331, 145)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
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
        'dgDinero
        '
        Me.dgDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDinero.Location = New System.Drawing.Point(11, 108)
        Me.dgDinero.Name = "dgDinero"
        Me.dgDinero.Size = New System.Drawing.Size(503, 148)
        Me.dgDinero.TabIndex = 1
        '
        'Gbx_NRemision
        '
        Me.Gbx_NRemision.Controls.Add(Me.Label1)
        Me.Gbx_NRemision.Controls.Add(Me.tbx_Minutos)
        Me.Gbx_NRemision.Controls.Add(Me.tbx_Horas)
        Me.Gbx_NRemision.Controls.Add(Me.lbl_HoraRemision)
        Me.Gbx_NRemision.Controls.Add(Me.cmb_CiasProp)
        Me.Gbx_NRemision.Controls.Add(Me.Lbl_Cias)
        Me.Gbx_NRemision.Controls.Add(Me.tbx_RemisionReemplazo)
        Me.Gbx_NRemision.Controls.Add(Me.tbx_RemisionOriginal)
        Me.Gbx_NRemision.Controls.Add(Me.tbx_Remision)
        Me.Gbx_NRemision.Controls.Add(Me.lbl_RemisionReemplazo)
        Me.Gbx_NRemision.Controls.Add(Me.lbl_Remision)
        Me.Gbx_NRemision.Location = New System.Drawing.Point(12, 3)
        Me.Gbx_NRemision.Name = "Gbx_NRemision"
        Me.Gbx_NRemision.Size = New System.Drawing.Size(502, 95)
        Me.Gbx_NRemision.TabIndex = 0
        Me.Gbx_NRemision.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = ":"
        '
        'tbx_Minutos
        '
        Me.tbx_Minutos.Control_Siguiente = Nothing
        Me.tbx_Minutos.Filtrado = True
        Me.tbx_Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Minutos.Location = New System.Drawing.Point(161, 68)
        Me.tbx_Minutos.MaxLength = 2
        Me.tbx_Minutos.Name = "tbx_Minutos"
        Me.tbx_Minutos.Size = New System.Drawing.Size(30, 23)
        Me.tbx_Minutos.TabIndex = 9
        Me.tbx_Minutos.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Horas
        '
        Me.tbx_Horas.Control_Siguiente = Me.tbx_Minutos
        Me.tbx_Horas.Filtrado = True
        Me.tbx_Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Horas.Location = New System.Drawing.Point(117, 68)
        Me.tbx_Horas.MaxLength = 2
        Me.tbx_Horas.Name = "tbx_Horas"
        Me.tbx_Horas.Size = New System.Drawing.Size(30, 23)
        Me.tbx_Horas.TabIndex = 8
        Me.tbx_Horas.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_HoraRemision
        '
        Me.lbl_HoraRemision.AutoSize = True
        Me.lbl_HoraRemision.Location = New System.Drawing.Point(20, 73)
        Me.lbl_HoraRemision.Name = "lbl_HoraRemision"
        Me.lbl_HoraRemision.Size = New System.Drawing.Size(91, 13)
        Me.lbl_HoraRemision.TabIndex = 7
        Me.lbl_HoraRemision.Text = "Hora en Remisión"
        '
        'cmb_CiasProp
        '
        Me.cmb_CiasProp.Clave = Nothing
        Me.cmb_CiasProp.Control_Siguiente = Me.tbx_Remision
        Me.cmb_CiasProp.DisplayMember = "Alias"
        Me.cmb_CiasProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiasProp.Empresa = False
        Me.cmb_CiasProp.Filtro = Nothing
        Me.cmb_CiasProp.FormattingEnabled = True
        Me.cmb_CiasProp.Location = New System.Drawing.Point(117, 12)
        Me.cmb_CiasProp.MaxDropDownItems = 20
        Me.cmb_CiasProp.Name = "cmb_CiasProp"
        Me.cmb_CiasProp.Pista = False
        Me.cmb_CiasProp.Size = New System.Drawing.Size(236, 21)
        Me.cmb_CiasProp.StoredProcedure = "Cat_CiasCombo_Get"
        Me.cmb_CiasProp.Sucursal = False
        Me.cmb_CiasProp.TabIndex = 1
        Me.cmb_CiasProp.Tipo = 0
        Me.cmb_CiasProp.ValueMember = "Id_Cia"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.tbx_Horas
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.Location = New System.Drawing.Point(117, 39)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(122, 23)
        Me.tbx_Remision.TabIndex = 3
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_Cias
        '
        Me.Lbl_Cias.AutoSize = True
        Me.Lbl_Cias.Location = New System.Drawing.Point(33, 15)
        Me.Lbl_Cias.Name = "Lbl_Cias"
        Me.Lbl_Cias.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_Cias.TabIndex = 0
        Me.Lbl_Cias.Text = "Cia. Propietaria"
        '
        'tbx_RemisionReemplazo
        '
        Me.tbx_RemisionReemplazo.Control_Siguiente = Nothing
        Me.tbx_RemisionReemplazo.Enabled = False
        Me.tbx_RemisionReemplazo.Filtrado = False
        Me.tbx_RemisionReemplazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_RemisionReemplazo.Location = New System.Drawing.Point(373, 39)
        Me.tbx_RemisionReemplazo.MaxLength = 15
        Me.tbx_RemisionReemplazo.Name = "tbx_RemisionReemplazo"
        Me.tbx_RemisionReemplazo.Size = New System.Drawing.Size(122, 23)
        Me.tbx_RemisionReemplazo.TabIndex = 6
        Me.tbx_RemisionReemplazo.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_RemisionReemplazo.Visible = False
        '
        'tbx_RemisionOriginal
        '
        Me.tbx_RemisionOriginal.Control_Siguiente = Nothing
        Me.tbx_RemisionOriginal.Enabled = False
        Me.tbx_RemisionOriginal.Filtrado = False
        Me.tbx_RemisionOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_RemisionOriginal.Location = New System.Drawing.Point(249, 39)
        Me.tbx_RemisionOriginal.MaxLength = 15
        Me.tbx_RemisionOriginal.Name = "tbx_RemisionOriginal"
        Me.tbx_RemisionOriginal.Size = New System.Drawing.Size(122, 23)
        Me.tbx_RemisionOriginal.TabIndex = 4
        Me.tbx_RemisionOriginal.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_RemisionOriginal.Visible = False
        '
        'lbl_RemisionReemplazo
        '
        Me.lbl_RemisionReemplazo.AutoSize = True
        Me.lbl_RemisionReemplazo.Location = New System.Drawing.Point(263, 44)
        Me.lbl_RemisionReemplazo.Name = "lbl_RemisionReemplazo"
        Me.lbl_RemisionReemplazo.Size = New System.Drawing.Size(85, 13)
        Me.lbl_RemisionReemplazo.TabIndex = 5
        Me.lbl_RemisionReemplazo.Text = "Nueva Remisión"
        Me.lbl_RemisionReemplazo.Visible = False
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(6, 44)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(105, 13)
        Me.lbl_Remision.TabIndex = 2
        Me.lbl_Remision.Text = "Número de Remisión"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(351, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar (Esc)"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Regresa
        '
        Me.btn_Regresa.Image = Global.Modulo_Recepcion.My.Resources.Resources.undo
        Me.btn_Regresa.Location = New System.Drawing.Point(181, 13)
        Me.btn_Regresa.Name = "btn_Regresa"
        Me.btn_Regresa.Size = New System.Drawing.Size(140, 30)
        Me.btn_Regresa.TabIndex = 1
        Me.btn_Regresa.Text = "&Marcar para Regresar"
        Me.btn_Regresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Regresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Regresa.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar (F2)"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_TotalRem
        '
        Me.Gbx_TotalRem.Controls.Add(Me.lbl_DestinoNombre)
        Me.Gbx_TotalRem.Controls.Add(Me.lbl_OrigenNombre)
        Me.Gbx_TotalRem.Controls.Add(Me.lbl_Destino)
        Me.Gbx_TotalRem.Controls.Add(Me.lbl_Origen)
        Me.Gbx_TotalRem.Location = New System.Drawing.Point(11, 285)
        Me.Gbx_TotalRem.Name = "Gbx_TotalRem"
        Me.Gbx_TotalRem.Size = New System.Drawing.Size(503, 55)
        Me.Gbx_TotalRem.TabIndex = 4
        Me.Gbx_TotalRem.TabStop = False
        '
        'lbl_DestinoNombre
        '
        Me.lbl_DestinoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DestinoNombre.Location = New System.Drawing.Point(55, 36)
        Me.lbl_DestinoNombre.Name = "lbl_DestinoNombre"
        Me.lbl_DestinoNombre.Size = New System.Drawing.Size(441, 13)
        Me.lbl_DestinoNombre.TabIndex = 5
        Me.lbl_DestinoNombre.Text = "Destino"
        '
        'lbl_OrigenNombre
        '
        Me.lbl_OrigenNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OrigenNombre.Location = New System.Drawing.Point(55, 13)
        Me.lbl_OrigenNombre.Name = "lbl_OrigenNombre"
        Me.lbl_OrigenNombre.Size = New System.Drawing.Size(441, 13)
        Me.lbl_OrigenNombre.TabIndex = 4
        Me.lbl_OrigenNombre.Text = "Origen"
        '
        'lbl_Destino
        '
        Me.lbl_Destino.AutoSize = True
        Me.lbl_Destino.Location = New System.Drawing.Point(6, 36)
        Me.lbl_Destino.Name = "lbl_Destino"
        Me.lbl_Destino.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Destino.TabIndex = 3
        Me.lbl_Destino.Text = "Destino"
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(11, 13)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Origen.TabIndex = 2
        Me.lbl_Origen.Text = "Origen"
        '
        'lbl_TRemision
        '
        Me.lbl_TRemision.AutoSize = True
        Me.lbl_TRemision.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TRemision.Location = New System.Drawing.Point(217, 265)
        Me.lbl_TRemision.Name = "lbl_TRemision"
        Me.lbl_TRemision.Size = New System.Drawing.Size(104, 17)
        Me.lbl_TRemision.TabIndex = 2
        Me.lbl_TRemision.Text = "Importe Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_Guardar)
        Me.GroupBox3.Controls.Add(Me.btn_Regresa)
        Me.GroupBox3.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 552)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 50)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'tbx_TotalRemision
        '
        Me.tbx_TotalRemision.Control_Siguiente = Nothing
        Me.tbx_TotalRemision.Enabled = False
        Me.tbx_TotalRemision.Filtrado = True
        Me.tbx_TotalRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemision.Location = New System.Drawing.Point(327, 262)
        Me.tbx_TotalRemision.MaxLength = 10
        Me.tbx_TotalRemision.Name = "tbx_TotalRemision"
        Me.tbx_TotalRemision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_TotalRemision.Size = New System.Drawing.Size(187, 23)
        Me.tbx_TotalRemision.TabIndex = 3
        Me.tbx_TotalRemision.TabStop = False
        Me.tbx_TotalRemision.Text = "0"
        Me.tbx_TotalRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'frm_Dialogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Gbx_TotalRem)
        Me.Controls.Add(Me.Gbx_NRemision)
        Me.Controls.Add(Me.dgDinero)
        Me.Controls.Add(Me.lbl_TRemision)
        Me.Controls.Add(Me.GpoDatos)
        Me.Controls.Add(Me.tbx_TotalRemision)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Dialogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura Número de Remisión y Envases"
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.grbEnvases.ResumeLayout(False)
        Me.grbEnvases.PerformLayout()
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_NRemision.ResumeLayout(False)
        Me.Gbx_NRemision.PerformLayout()
        Me.Gbx_TotalRem.ResumeLayout(False)
        Me.Gbx_TotalRem.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grbEnvases As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoEnvase As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoEnvase As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents tbx_NumeroEnvase As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Regresa As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents dgDinero As System.Windows.Forms.DataGridView
    Friend WithEvents Gbx_NRemision As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_EnvasesSN As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents Gbx_TotalRem As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_TotalRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_RemisionOriginal As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_RemisionReemplazo As System.Windows.Forms.Label
    Friend WithEvents tbx_RemisionReemplazo As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_DestinoNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_OrigenNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Destino As System.Windows.Forms.Label
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents cmb_CiasProp As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Cias As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraRemision As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Minutos As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Horas As Modulo_Recepcion.cp_Textbox
End Class
