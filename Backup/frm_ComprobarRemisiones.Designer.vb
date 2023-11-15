<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprobarRemisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ComprobarRemisiones))
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.Lbl_NumRemision = New System.Windows.Forms.Label
        Me.dgDinero = New System.Windows.Forms.DataGridView
        Me.grbEnvases = New System.Windows.Forms.GroupBox
        Me.lbl_TotalEnvases = New System.Windows.Forms.Label
        Me.lbl_Tcapturado = New System.Windows.Forms.Label
        Me.Lbl_EnvasesSN = New System.Windows.Forms.Label
        Me.tbx_EnvasesSn = New Modulo_Recepcion.cp_Textbox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_Numero = New Modulo_Recepcion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Recepcion.cp_cmb_Simple
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_Total = New System.Windows.Forms.GroupBox
        Me.lbl_TRemision = New System.Windows.Forms.Label
        Me.tbx_TotalRemision = New Modulo_Recepcion.cp_Textbox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Hora = New System.Windows.Forms.Label
        Me.tbx_Min = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Hora = New Modulo_Recepcion.cp_Textbox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_CiaProp = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.tbx_CveCia = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbEnvases.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Total.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(8, 14)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Compañia.TabIndex = 0
        Me.lbl_Compañia.Text = "Cia. Traslada"
        '
        'Lbl_NumRemision
        '
        Me.Lbl_NumRemision.AutoSize = True
        Me.Lbl_NumRemision.Location = New System.Drawing.Point(1, 48)
        Me.Lbl_NumRemision.Name = "Lbl_NumRemision"
        Me.Lbl_NumRemision.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NumRemision.TabIndex = 3
        Me.Lbl_NumRemision.Text = "Num. Remisión"
        '
        'dgDinero
        '
        Me.dgDinero.AllowUserToAddRows = False
        Me.dgDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDinero.Enabled = False
        Me.dgDinero.Location = New System.Drawing.Point(7, 72)
        Me.dgDinero.Name = "dgDinero"
        Me.dgDinero.Size = New System.Drawing.Size(526, 161)
        Me.dgDinero.TabIndex = 6
        '
        'grbEnvases
        '
        Me.grbEnvases.Controls.Add(Me.lbl_TotalEnvases)
        Me.grbEnvases.Controls.Add(Me.lbl_Tcapturado)
        Me.grbEnvases.Controls.Add(Me.Lbl_EnvasesSN)
        Me.grbEnvases.Controls.Add(Me.tbx_EnvasesSn)
        Me.grbEnvases.Controls.Add(Me.btn_Eliminar)
        Me.grbEnvases.Controls.Add(Me.lsv_Envases)
        Me.grbEnvases.Controls.Add(Me.btn_Modificar)
        Me.grbEnvases.Controls.Add(Me.Btn_Agregar)
        Me.grbEnvases.Controls.Add(Me.tbx_Numero)
        Me.grbEnvases.Controls.Add(Me.cmb_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_numero)
        Me.grbEnvases.Enabled = False
        Me.grbEnvases.Location = New System.Drawing.Point(7, 308)
        Me.grbEnvases.Name = "grbEnvases"
        Me.grbEnvases.Size = New System.Drawing.Size(531, 252)
        Me.grbEnvases.TabIndex = 10
        Me.grbEnvases.TabStop = False
        Me.grbEnvases.Text = "Envases"
        '
        'lbl_TotalEnvases
        '
        Me.lbl_TotalEnvases.AutoSize = True
        Me.lbl_TotalEnvases.Location = New System.Drawing.Point(394, 225)
        Me.lbl_TotalEnvases.Name = "lbl_TotalEnvases"
        Me.lbl_TotalEnvases.Size = New System.Drawing.Size(13, 13)
        Me.lbl_TotalEnvases.TabIndex = 11
        Me.lbl_TotalEnvases.Text = "0"
        '
        'lbl_Tcapturado
        '
        Me.lbl_Tcapturado.AutoSize = True
        Me.lbl_Tcapturado.Location = New System.Drawing.Point(303, 225)
        Me.lbl_Tcapturado.Name = "lbl_Tcapturado"
        Me.lbl_Tcapturado.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Tcapturado.TabIndex = 10
        Me.lbl_Tcapturado.Text = "Total Envases"
        '
        'Lbl_EnvasesSN
        '
        Me.Lbl_EnvasesSN.AutoSize = True
        Me.Lbl_EnvasesSN.Location = New System.Drawing.Point(160, 225)
        Me.Lbl_EnvasesSN.Name = "Lbl_EnvasesSN"
        Me.Lbl_EnvasesSN.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_EnvasesSN.TabIndex = 8
        Me.Lbl_EnvasesSN.Text = "Envases S/N"
        '
        'tbx_EnvasesSn
        '
        Me.tbx_EnvasesSn.Control_Siguiente = Me.Btn_Guardar
        Me.tbx_EnvasesSn.Filtrado = True
        Me.tbx_EnvasesSn.Location = New System.Drawing.Point(237, 222)
        Me.tbx_EnvasesSn.MaxLength = 4
        Me.tbx_EnvasesSn.Name = "tbx_EnvasesSn"
        Me.tbx_EnvasesSn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_EnvasesSn.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EnvasesSn.TabIndex = 9
        Me.tbx_EnvasesSn.Text = "0"
        Me.tbx_EnvasesSn.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(4, 13)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 196)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 7
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
        Me.lsv_Envases.Size = New System.Drawing.Size(372, 197)
        Me.lsv_Envases.TabIndex = 4
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(7, 124)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "M&odificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 160)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Agregar.TabIndex = 6
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
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 567)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(531, 50)
        Me.Gbx_Botones.TabIndex = 11
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(386, 13)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_Total
        '
        Me.gbx_Total.Controls.Add(Me.lbl_TRemision)
        Me.gbx_Total.Controls.Add(Me.tbx_TotalRemision)
        Me.gbx_Total.Controls.Add(Me.Label2)
        Me.gbx_Total.Controls.Add(Me.lbl_Hora)
        Me.gbx_Total.Controls.Add(Me.tbx_Min)
        Me.gbx_Total.Controls.Add(Me.tbx_Hora)
        Me.gbx_Total.Enabled = False
        Me.gbx_Total.Location = New System.Drawing.Point(7, 262)
        Me.gbx_Total.Name = "gbx_Total"
        Me.gbx_Total.Size = New System.Drawing.Size(531, 44)
        Me.gbx_Total.TabIndex = 9
        Me.gbx_Total.TabStop = False
        '
        'lbl_TRemision
        '
        Me.lbl_TRemision.AutoSize = True
        Me.lbl_TRemision.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TRemision.Location = New System.Drawing.Point(223, 15)
        Me.lbl_TRemision.Name = "lbl_TRemision"
        Me.lbl_TRemision.Size = New System.Drawing.Size(104, 17)
        Me.lbl_TRemision.TabIndex = 4
        Me.lbl_TRemision.Text = "Importe Total"
        '
        'tbx_TotalRemision
        '
        Me.tbx_TotalRemision.Control_Siguiente = Nothing
        Me.tbx_TotalRemision.Enabled = False
        Me.tbx_TotalRemision.Filtrado = True
        Me.tbx_TotalRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemision.Location = New System.Drawing.Point(333, 13)
        Me.tbx_TotalRemision.MaxLength = 10
        Me.tbx_TotalRemision.Name = "tbx_TotalRemision"
        Me.tbx_TotalRemision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_TotalRemision.Size = New System.Drawing.Size(187, 23)
        Me.tbx_TotalRemision.TabIndex = 5
        Me.tbx_TotalRemision.TabStop = False
        Me.tbx_TotalRemision.Text = "0"
        Me.tbx_TotalRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Location = New System.Drawing.Point(7, 16)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(91, 13)
        Me.lbl_Hora.TabIndex = 0
        Me.lbl_Hora.Text = "Hora en Remisión"
        '
        'tbx_Min
        '
        Me.tbx_Min.Control_Siguiente = Me.tbx_Numero
        Me.tbx_Min.Filtrado = True
        Me.tbx_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Min.Location = New System.Drawing.Point(143, 12)
        Me.tbx_Min.MaxLength = 4
        Me.tbx_Min.Name = "tbx_Min"
        Me.tbx_Min.Size = New System.Drawing.Size(27, 23)
        Me.tbx_Min.TabIndex = 3
        Me.tbx_Min.Text = "00"
        Me.tbx_Min.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Hora
        '
        Me.tbx_Hora.Control_Siguiente = Me.tbx_Min
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Hora.Location = New System.Drawing.Point(103, 12)
        Me.tbx_Hora.MaxLength = 4
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(27, 23)
        Me.tbx_Hora.TabIndex = 1
        Me.tbx_Hora.Text = "00"
        Me.tbx_Hora.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(274, 36)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 5
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cia. Propietaria"
        '
        'cmb_CiaProp
        '
        Me.cmb_CiaProp.Clave = "Clave"
        Me.cmb_CiaProp.Control_Siguiente = Me.tbx_Remision
        Me.cmb_CiaProp.DisplayMember = "Alias"
        Me.cmb_CiaProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiaProp.Empresa = False
        Me.cmb_CiaProp.Filtro = Nothing
        Me.cmb_CiaProp.FormattingEnabled = True
        Me.cmb_CiaProp.Location = New System.Drawing.Point(141, 239)
        Me.cmb_CiaProp.MaxDropDownItems = 20
        Me.cmb_CiaProp.Name = "cmb_CiaProp"
        Me.cmb_CiaProp.Pista = True
        Me.cmb_CiaProp.Size = New System.Drawing.Size(392, 21)
        Me.cmb_CiaProp.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_CiaProp.Sucursal = False
        Me.cmb_CiaProp.TabIndex = 8
        Me.cmb_CiaProp.Tipo = 0
        Me.cmb_CiaProp.ValueMember = "Id_Cia"
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Remision.Location = New System.Drawing.Point(85, 37)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(183, 29)
        Me.tbx_Remision.TabIndex = 4
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_CveCia
        '
        Me.tbx_CveCia.Control_Siguiente = Me.cmb_Cia
        Me.tbx_CveCia.Filtrado = True
        Me.tbx_CveCia.Location = New System.Drawing.Point(85, 11)
        Me.tbx_CveCia.MaxLength = 4
        Me.tbx_CveCia.Name = "tbx_CveCia"
        Me.tbx_CveCia.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveCia.TabIndex = 1
        Me.tbx_CveCia.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Clave = "Clave"
        Me.cmb_Cia.Control_Siguiente = Me.tbx_Remision
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Filtro = Me.tbx_CveCia
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(141, 11)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(392, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 2
        Me.cmb_Cia.Tipo = 0
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'frm_ComprobarRemisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_CiaProp)
        Me.Controls.Add(Me.gbx_Total)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.grbEnvases)
        Me.Controls.Add(Me.dgDinero)
        Me.Controls.Add(Me.Lbl_NumRemision)
        Me.Controls.Add(Me.tbx_Remision)
        Me.Controls.Add(Me.lbl_Compañia)
        Me.Controls.Add(Me.tbx_CveCia)
        Me.Controls.Add(Me.cmb_Cia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 750)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 650)
        Me.Name = "frm_ComprobarRemisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobar Remisiones"
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbEnvases.ResumeLayout(False)
        Me.grbEnvases.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Total.ResumeLayout(False)
        Me.gbx_Total.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveCia As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_NumRemision As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dgDinero As System.Windows.Forms.DataGridView
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
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Total As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_TotalRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Min As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Hora As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_CiaProp As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
End Class
