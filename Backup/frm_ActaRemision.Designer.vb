<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ActaRemision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ActaRemision))
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgDinero = New System.Windows.Forms.DataGridView
        Me.gbx_Envases = New System.Windows.Forms.GroupBox
        Me.lbl_TotalEnvases = New System.Windows.Forms.Label
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.tbx_EnvasesSn = New Modulo_Recepcion.cp_Textbox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Tcapturado = New System.Windows.Forms.Label
        Me.Lbl_Envases = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_Total = New System.Windows.Forms.GroupBox
        Me.lbl_TRemision = New System.Windows.Forms.Label
        Me.tbx_TotalRemision = New Modulo_Recepcion.cp_Textbox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_HoraRem = New System.Windows.Forms.Label
        Me.tbx_Hora = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Min = New Modulo_Recepcion.cp_Textbox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Lbl_Operador = New System.Windows.Forms.Label
        Me.Lbl_Cajero = New System.Windows.Forms.Label
        Me.gbx_Acta = New System.Windows.Forms.GroupBox
        Me.Lbl_Ejemplo = New System.Windows.Forms.Label
        Me.Lbl_Cliente = New System.Windows.Forms.Label
        Me.cmb_Cliente = New Modulo_Recepcion.cp_cmb_Simple
        Me.tbx_Esclusa = New Modulo_Recepcion.cp_Textbox
        Me.dtp_FechaActa = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Observaciones = New System.Windows.Forms.Label
        Me.Lbl_TipoAnomalia = New System.Windows.Forms.Label
        Me.Lbl_NEsclusa = New System.Windows.Forms.Label
        Me.rtb_Motivo = New System.Windows.Forms.RichTextBox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbx_HoraActa = New Modulo_Recepcion.cp_Textbox
        Me.tbx_MinActa = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.gbx_Ruta = New System.Windows.Forms.GroupBox
        Me.cmb_Custodio = New Modulo_Recepcion.cp_cmb_Simple
        Me.cmb_Operador = New Modulo_Recepcion.cp_cmb_Simple
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_Parametro
        Me.Lbl_Ruta = New System.Windows.Forms.Label
        Me.lsv_Custodios = New Modulo_Recepcion.cp_Listview
        Me.Lbl_Custodios = New System.Windows.Forms.Label
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveCia = New Modulo_Recepcion.cp_Textbox
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Envases.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Total.SuspendLayout()
        Me.gbx_Acta.SuspendLayout()
        Me.gbx_Ruta.SuspendLayout()
        Me.gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(33, 18)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Compañia.TabIndex = 0
        Me.lbl_Compañia.Text = "Compañía"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Num. Remisión"
        '
        'dgDinero
        '
        Me.dgDinero.AllowUserToAddRows = False
        Me.dgDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDinero.Enabled = False
        Me.dgDinero.Location = New System.Drawing.Point(6, 13)
        Me.dgDinero.Name = "dgDinero"
        Me.dgDinero.Size = New System.Drawing.Size(400, 156)
        Me.dgDinero.TabIndex = 0
        '
        'gbx_Envases
        '
        Me.gbx_Envases.Controls.Add(Me.lbl_TotalEnvases)
        Me.gbx_Envases.Controls.Add(Me.lsv_Envases)
        Me.gbx_Envases.Controls.Add(Me.tbx_EnvasesSn)
        Me.gbx_Envases.Controls.Add(Me.lbl_Tcapturado)
        Me.gbx_Envases.Controls.Add(Me.Lbl_Envases)
        Me.gbx_Envases.Location = New System.Drawing.Point(425, 88)
        Me.gbx_Envases.Name = "gbx_Envases"
        Me.gbx_Envases.Size = New System.Drawing.Size(364, 206)
        Me.gbx_Envases.TabIndex = 2
        Me.gbx_Envases.TabStop = False
        Me.gbx_Envases.Text = "Envases"
        '
        'lbl_TotalEnvases
        '
        Me.lbl_TotalEnvases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalEnvases.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalEnvases.Location = New System.Drawing.Point(311, 175)
        Me.lbl_TotalEnvases.Name = "lbl_TotalEnvases"
        Me.lbl_TotalEnvases.Size = New System.Drawing.Size(44, 18)
        Me.lbl_TotalEnvases.TabIndex = 4
        Me.lbl_TotalEnvases.Text = "0"
        Me.lbl_TotalEnvases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.Enabled = False
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(8, 14)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
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
        Me.lsv_Envases.Size = New System.Drawing.Size(350, 155)
        Me.lsv_Envases.TabIndex = 0
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'tbx_EnvasesSn
        '
        Me.tbx_EnvasesSn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_EnvasesSn.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_EnvasesSn.Control_Siguiente = Me.Btn_Guardar
        Me.tbx_EnvasesSn.Filtrado = True
        Me.tbx_EnvasesSn.Location = New System.Drawing.Point(89, 175)
        Me.tbx_EnvasesSn.MaxLength = 4
        Me.tbx_EnvasesSn.Name = "tbx_EnvasesSn"
        Me.tbx_EnvasesSn.ReadOnly = True
        Me.tbx_EnvasesSn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_EnvasesSn.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EnvasesSn.TabIndex = 2
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
        'lbl_Tcapturado
        '
        Me.lbl_Tcapturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Tcapturado.AutoSize = True
        Me.lbl_Tcapturado.Location = New System.Drawing.Point(234, 178)
        Me.lbl_Tcapturado.Name = "lbl_Tcapturado"
        Me.lbl_Tcapturado.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Tcapturado.TabIndex = 3
        Me.lbl_Tcapturado.Text = "Total Envases"
        '
        'Lbl_Envases
        '
        Me.Lbl_Envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Envases.AutoSize = True
        Me.Lbl_Envases.Location = New System.Drawing.Point(12, 178)
        Me.Lbl_Envases.Name = "Lbl_Envases"
        Me.Lbl_Envases.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_Envases.TabIndex = 1
        Me.Lbl_Envases.Text = "Envases S/N"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.Btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.Btn_Cancelar)
        Me.gbx_Botones.Location = New System.Drawing.Point(7, 632)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(782, 50)
        Me.gbx_Botones.TabIndex = 5
        Me.gbx_Botones.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(637, 13)
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
        Me.gbx_Total.Controls.Add(Me.dgDinero)
        Me.gbx_Total.Controls.Add(Me.lbl_HoraRem)
        Me.gbx_Total.Controls.Add(Me.tbx_Hora)
        Me.gbx_Total.Controls.Add(Me.tbx_Min)
        Me.gbx_Total.Location = New System.Drawing.Point(7, 88)
        Me.gbx_Total.Name = "gbx_Total"
        Me.gbx_Total.Size = New System.Drawing.Size(412, 206)
        Me.gbx_Total.TabIndex = 1
        Me.gbx_Total.TabStop = False
        '
        'lbl_TRemision
        '
        Me.lbl_TRemision.AutoSize = True
        Me.lbl_TRemision.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TRemision.Location = New System.Drawing.Point(221, 178)
        Me.lbl_TRemision.Name = "lbl_TRemision"
        Me.lbl_TRemision.Size = New System.Drawing.Size(69, 13)
        Me.lbl_TRemision.TabIndex = 5
        Me.lbl_TRemision.Text = "Importe Total"
        '
        'tbx_TotalRemision
        '
        Me.tbx_TotalRemision.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_TotalRemision.Control_Siguiente = Nothing
        Me.tbx_TotalRemision.Filtrado = True
        Me.tbx_TotalRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemision.Location = New System.Drawing.Point(296, 175)
        Me.tbx_TotalRemision.MaxLength = 10
        Me.tbx_TotalRemision.Name = "tbx_TotalRemision"
        Me.tbx_TotalRemision.ReadOnly = True
        Me.tbx_TotalRemision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_TotalRemision.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TotalRemision.TabIndex = 6
        Me.tbx_TotalRemision.TabStop = False
        Me.tbx_TotalRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":"
        '
        'lbl_HoraRem
        '
        Me.lbl_HoraRem.AutoSize = True
        Me.lbl_HoraRem.Location = New System.Drawing.Point(7, 182)
        Me.lbl_HoraRem.Name = "lbl_HoraRem"
        Me.lbl_HoraRem.Size = New System.Drawing.Size(76, 13)
        Me.lbl_HoraRem.TabIndex = 1
        Me.lbl_HoraRem.Text = "Hora Remisión"
        '
        'tbx_Hora
        '
        Me.tbx_Hora.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Hora.Control_Siguiente = Me.tbx_Min
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(86, 178)
        Me.tbx_Hora.MaxLength = 4
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.ReadOnly = True
        Me.tbx_Hora.Size = New System.Drawing.Size(23, 20)
        Me.tbx_Hora.TabIndex = 2
        Me.tbx_Hora.Text = "00"
        Me.tbx_Hora.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Min
        '
        Me.tbx_Min.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Min.Control_Siguiente = Nothing
        Me.tbx_Min.Filtrado = True
        Me.tbx_Min.Location = New System.Drawing.Point(119, 178)
        Me.tbx_Min.MaxLength = 4
        Me.tbx_Min.Name = "tbx_Min"
        Me.tbx_Min.ReadOnly = True
        Me.tbx_Min.Size = New System.Drawing.Size(23, 20)
        Me.tbx_Min.TabIndex = 4
        Me.tbx_Min.Text = "00"
        Me.tbx_Min.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(284, 40)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 5
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Lbl_Operador
        '
        Me.Lbl_Operador.AutoSize = True
        Me.Lbl_Operador.Location = New System.Drawing.Point(32, 61)
        Me.Lbl_Operador.Name = "Lbl_Operador"
        Me.Lbl_Operador.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_Operador.TabIndex = 2
        Me.Lbl_Operador.Text = "Operador"
        '
        'Lbl_Cajero
        '
        Me.Lbl_Cajero.AutoSize = True
        Me.Lbl_Cajero.Location = New System.Drawing.Point(46, 88)
        Me.Lbl_Cajero.Name = "Lbl_Cajero"
        Me.Lbl_Cajero.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Cajero.TabIndex = 4
        Me.Lbl_Cajero.Text = "Cajero"
        '
        'gbx_Acta
        '
        Me.gbx_Acta.Controls.Add(Me.Lbl_Ejemplo)
        Me.gbx_Acta.Controls.Add(Me.Lbl_Cliente)
        Me.gbx_Acta.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Acta.Controls.Add(Me.tbx_Esclusa)
        Me.gbx_Acta.Controls.Add(Me.Lbl_Observaciones)
        Me.gbx_Acta.Controls.Add(Me.Lbl_TipoAnomalia)
        Me.gbx_Acta.Controls.Add(Me.Lbl_NEsclusa)
        Me.gbx_Acta.Controls.Add(Me.dtp_FechaActa)
        Me.gbx_Acta.Controls.Add(Me.rtb_Motivo)
        Me.gbx_Acta.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Acta.Controls.Add(Me.Label9)
        Me.gbx_Acta.Controls.Add(Me.tbx_HoraActa)
        Me.gbx_Acta.Controls.Add(Me.tbx_MinActa)
        Me.gbx_Acta.Controls.Add(Me.Lbl_Fecha)
        Me.gbx_Acta.Controls.Add(Me.Lbl_Hora)
        Me.gbx_Acta.Location = New System.Drawing.Point(7, 430)
        Me.gbx_Acta.Name = "gbx_Acta"
        Me.gbx_Acta.Size = New System.Drawing.Size(782, 201)
        Me.gbx_Acta.TabIndex = 4
        Me.gbx_Acta.TabStop = False
        Me.gbx_Acta.Text = "Datos del Acta"
        '
        'Lbl_Ejemplo
        '
        Me.Lbl_Ejemplo.AutoSize = True
        Me.Lbl_Ejemplo.Location = New System.Drawing.Point(408, 52)
        Me.Lbl_Ejemplo.Name = "Lbl_Ejemplo"
        Me.Lbl_Ejemplo.Size = New System.Drawing.Size(96, 13)
        Me.Lbl_Ejemplo.TabIndex = 14
        Me.Lbl_Ejemplo.Text = "(De 00:00 a 23:29)"
        '
        'Lbl_Cliente
        '
        Me.Lbl_Cliente.AutoSize = True
        Me.Lbl_Cliente.Location = New System.Drawing.Point(44, 26)
        Me.Lbl_Cliente.Name = "Lbl_Cliente"
        Me.Lbl_Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Cliente.TabIndex = 0
        Me.Lbl_Cliente.Text = "Cliente"
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Control_Siguiente = Me.tbx_Esclusa
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Enabled = False
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(89, 22)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = True
        Me.cmb_Cliente.Size = New System.Drawing.Size(437, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_ClientesCombo_Get"
        Me.cmb_Cliente.Sucursal = True
        Me.cmb_Cliente.TabIndex = 1
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_Esclusa
        '
        Me.tbx_Esclusa.Control_Siguiente = Me.dtp_FechaActa
        Me.tbx_Esclusa.Filtrado = True
        Me.tbx_Esclusa.Location = New System.Drawing.Point(89, 49)
        Me.tbx_Esclusa.MaxLength = 4
        Me.tbx_Esclusa.Name = "tbx_Esclusa"
        Me.tbx_Esclusa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_Esclusa.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Esclusa.TabIndex = 3
        Me.tbx_Esclusa.Text = "0"
        Me.tbx_Esclusa.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_FechaActa
        '
        Me.dtp_FechaActa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaActa.Location = New System.Drawing.Point(197, 48)
        Me.dtp_FechaActa.Name = "dtp_FechaActa"
        Me.dtp_FechaActa.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaActa.TabIndex = 5
        '
        'Lbl_Observaciones
        '
        Me.Lbl_Observaciones.AutoSize = True
        Me.Lbl_Observaciones.Location = New System.Drawing.Point(2, 125)
        Me.Lbl_Observaciones.Name = "Lbl_Observaciones"
        Me.Lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_Observaciones.TabIndex = 12
        Me.Lbl_Observaciones.Text = "Observaciones"
        '
        'Lbl_TipoAnomalia
        '
        Me.Lbl_TipoAnomalia.Location = New System.Drawing.Point(8, 74)
        Me.Lbl_TipoAnomalia.Name = "Lbl_TipoAnomalia"
        Me.Lbl_TipoAnomalia.Size = New System.Drawing.Size(72, 37)
        Me.Lbl_TipoAnomalia.TabIndex = 10
        Me.Lbl_TipoAnomalia.Text = "Motivo o Tipo de Anomalía"
        Me.Lbl_TipoAnomalia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_NEsclusa
        '
        Me.Lbl_NEsclusa.AutoSize = True
        Me.Lbl_NEsclusa.Location = New System.Drawing.Point(11, 52)
        Me.Lbl_NEsclusa.Name = "Lbl_NEsclusa"
        Me.Lbl_NEsclusa.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_NEsclusa.TabIndex = 2
        Me.Lbl_NEsclusa.Text = "Num. Esclusa"
        '
        'rtb_Motivo
        '
        Me.rtb_Motivo.Location = New System.Drawing.Point(86, 76)
        Me.rtb_Motivo.MaxLength = 200
        Me.rtb_Motivo.Name = "rtb_Motivo"
        Me.rtb_Motivo.Size = New System.Drawing.Size(440, 40)
        Me.rtb_Motivo.TabIndex = 11
        Me.rtb_Motivo.Text = ""
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(86, 122)
        Me.rtb_Observaciones.MaxLength = 5000
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(440, 69)
        Me.rtb_Observaciones.TabIndex = 13
        Me.rtb_Observaciones.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = ":"
        '
        'tbx_HoraActa
        '
        Me.tbx_HoraActa.Control_Siguiente = Me.tbx_MinActa
        Me.tbx_HoraActa.Filtrado = True
        Me.tbx_HoraActa.Location = New System.Drawing.Point(346, 49)
        Me.tbx_HoraActa.MaxLength = 4
        Me.tbx_HoraActa.Name = "tbx_HoraActa"
        Me.tbx_HoraActa.Size = New System.Drawing.Size(23, 20)
        Me.tbx_HoraActa.TabIndex = 7
        Me.tbx_HoraActa.Text = "00"
        Me.tbx_HoraActa.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_MinActa
        '
        Me.tbx_MinActa.Control_Siguiente = Me.rtb_Motivo
        Me.tbx_MinActa.Filtrado = True
        Me.tbx_MinActa.Location = New System.Drawing.Point(379, 49)
        Me.tbx_MinActa.MaxLength = 4
        Me.tbx_MinActa.Name = "tbx_MinActa"
        Me.tbx_MinActa.Size = New System.Drawing.Size(23, 20)
        Me.tbx_MinActa.TabIndex = 9
        Me.tbx_MinActa.Text = "00"
        Me.tbx_MinActa.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(154, 52)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 4
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(310, 52)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 6
        Me.Lbl_Hora.Text = "Hora"
        '
        'gbx_Ruta
        '
        Me.gbx_Ruta.Controls.Add(Me.cmb_Custodio)
        Me.gbx_Ruta.Controls.Add(Me.cmb_Operador)
        Me.gbx_Ruta.Controls.Add(Me.cmb_Rutas)
        Me.gbx_Ruta.Controls.Add(Me.Lbl_Ruta)
        Me.gbx_Ruta.Controls.Add(Me.lsv_Custodios)
        Me.gbx_Ruta.Controls.Add(Me.Lbl_Operador)
        Me.gbx_Ruta.Controls.Add(Me.Lbl_Cajero)
        Me.gbx_Ruta.Controls.Add(Me.Lbl_Custodios)
        Me.gbx_Ruta.Location = New System.Drawing.Point(7, 300)
        Me.gbx_Ruta.Name = "gbx_Ruta"
        Me.gbx_Ruta.Size = New System.Drawing.Size(782, 124)
        Me.gbx_Ruta.TabIndex = 3
        Me.gbx_Ruta.TabStop = False
        Me.gbx_Ruta.Text = "Tripulación"
        '
        'cmb_Custodio
        '
        Me.cmb_Custodio.Control_Siguiente = Nothing
        Me.cmb_Custodio.DisplayMember = "Nombre"
        Me.cmb_Custodio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Custodio.Empresa = False
        Me.cmb_Custodio.Enabled = False
        Me.cmb_Custodio.FormattingEnabled = True
        Me.cmb_Custodio.Location = New System.Drawing.Point(89, 85)
        Me.cmb_Custodio.MaxDropDownItems = 20
        Me.cmb_Custodio.Name = "cmb_Custodio"
        Me.cmb_Custodio.Pista = False
        Me.cmb_Custodio.Size = New System.Drawing.Size(313, 21)
        Me.cmb_Custodio.StoredProcedure = "Tv_Tripulacion_Get"
        Me.cmb_Custodio.Sucursal = True
        Me.cmb_Custodio.TabIndex = 5
        Me.cmb_Custodio.ValueMember = "Id_Empleado"
        '
        'cmb_Operador
        '
        Me.cmb_Operador.Control_Siguiente = Nothing
        Me.cmb_Operador.DisplayMember = "Nombre"
        Me.cmb_Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Operador.Empresa = False
        Me.cmb_Operador.Enabled = False
        Me.cmb_Operador.FormattingEnabled = True
        Me.cmb_Operador.Location = New System.Drawing.Point(89, 58)
        Me.cmb_Operador.MaxDropDownItems = 20
        Me.cmb_Operador.Name = "cmb_Operador"
        Me.cmb_Operador.Pista = False
        Me.cmb_Operador.Size = New System.Drawing.Size(313, 21)
        Me.cmb_Operador.StoredProcedure = "Tv_Tripulacion_Get"
        Me.cmb_Operador.Sucursal = True
        Me.cmb_Operador.TabIndex = 3
        Me.cmb_Operador.ValueMember = "Id_Empleado"
        '
        'cmb_Rutas
        '
        Me.cmb_Rutas.Control_Siguiente = Nothing
        Me.cmb_Rutas.DisplayMember = "Descripcion"
        Me.cmb_Rutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rutas.Empresa = False
        Me.cmb_Rutas.Enabled = False
        Me.cmb_Rutas.FormattingEnabled = True
        Me.cmb_Rutas.Location = New System.Drawing.Point(89, 31)
        Me.cmb_Rutas.MaxDropDownItems = 20
        Me.cmb_Rutas.Name = "cmb_Rutas"
        Me.cmb_Rutas.NombreParametro = "@Tipo"
        Me.cmb_Rutas.Pista = True
        Me.cmb_Rutas.Size = New System.Drawing.Size(313, 21)
        Me.cmb_Rutas.StoredProcedure = "Cat_Rutas_Get"
        Me.cmb_Rutas.Sucursal = True
        Me.cmb_Rutas.TabIndex = 1
        Me.cmb_Rutas.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Rutas.ValorParametro = Nothing
        Me.cmb_Rutas.ValueMember = "Id_Ruta"
        '
        'Lbl_Ruta
        '
        Me.Lbl_Ruta.AutoSize = True
        Me.Lbl_Ruta.Location = New System.Drawing.Point(53, 34)
        Me.Lbl_Ruta.Name = "Lbl_Ruta"
        Me.Lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Ruta.TabIndex = 0
        Me.Lbl_Ruta.Text = "Ruta"
        '
        'lsv_Custodios
        '
        Me.lsv_Custodios.AllowColumnReorder = True
        Me.lsv_Custodios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Custodios.Enabled = False
        Me.lsv_Custodios.FullRowSelect = True
        Me.lsv_Custodios.HideSelection = False
        Me.lsv_Custodios.Location = New System.Drawing.Point(426, 31)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Custodios.Lvs = ListViewColumnSorter2
        Me.lsv_Custodios.MultiSelect = False
        Me.lsv_Custodios.Name = "lsv_Custodios"
        Me.lsv_Custodios.Row1 = 20
        Me.lsv_Custodios.Row10 = 0
        Me.lsv_Custodios.Row2 = 75
        Me.lsv_Custodios.Row3 = 0
        Me.lsv_Custodios.Row4 = 0
        Me.lsv_Custodios.Row5 = 0
        Me.lsv_Custodios.Row6 = 0
        Me.lsv_Custodios.Row7 = 0
        Me.lsv_Custodios.Row8 = 0
        Me.lsv_Custodios.Row9 = 0
        Me.lsv_Custodios.Size = New System.Drawing.Size(345, 84)
        Me.lsv_Custodios.TabIndex = 7
        Me.lsv_Custodios.TabStop = False
        Me.lsv_Custodios.UseCompatibleStateImageBehavior = False
        Me.lsv_Custodios.View = System.Windows.Forms.View.Details
        '
        'Lbl_Custodios
        '
        Me.Lbl_Custodios.AutoSize = True
        Me.Lbl_Custodios.Location = New System.Drawing.Point(430, 11)
        Me.Lbl_Custodios.Name = "Lbl_Custodios"
        Me.Lbl_Custodios.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Custodios.TabIndex = 6
        Me.Lbl_Custodios.Text = "Custodios"
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Controls.Add(Me.tbx_Remision)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Cia)
        Me.gbx_Filtro.Controls.Add(Me.tbx_CveCia)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Compañia)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Location = New System.Drawing.Point(7, 3)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(782, 79)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Me.btn_Mostrar
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbx_Remision.Location = New System.Drawing.Point(95, 41)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(183, 29)
        Me.tbx_Remision.TabIndex = 4
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Clave = "Clave"
        Me.cmb_Cia.Control_Siguiente = Me.tbx_Remision
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Enabled = False
        Me.cmb_Cia.Filtro = Me.tbx_CveCia
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(151, 15)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = True
        Me.cmb_Cia.Size = New System.Drawing.Size(381, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_Get"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 2
        Me.cmb_Cia.TabStop = False
        Me.cmb_Cia.Tipo = 0
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'tbx_CveCia
        '
        Me.tbx_CveCia.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_CveCia.Control_Siguiente = Me.cmb_Cia
        Me.tbx_CveCia.Enabled = False
        Me.tbx_CveCia.Filtrado = True
        Me.tbx_CveCia.Location = New System.Drawing.Point(95, 15)
        Me.tbx_CveCia.MaxLength = 4
        Me.tbx_CveCia.Name = "tbx_CveCia"
        Me.tbx_CveCia.ReadOnly = True
        Me.tbx_CveCia.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveCia.TabIndex = 1
        Me.tbx_CveCia.TabStop = False
        Me.tbx_CveCia.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_ActaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 691)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Controls.Add(Me.gbx_Ruta)
        Me.Controls.Add(Me.gbx_Acta)
        Me.Controls.Add(Me.gbx_Total)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Envases)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 720)
        Me.Name = "frm_ActaRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acta por Anomalía en Remisión"
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Envases.ResumeLayout(False)
        Me.gbx_Envases.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Total.ResumeLayout(False)
        Me.gbx_Total.PerformLayout()
        Me.gbx_Acta.ResumeLayout(False)
        Me.gbx_Acta.PerformLayout()
        Me.gbx_Ruta.ResumeLayout(False)
        Me.gbx_Ruta.PerformLayout()
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveCia As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dgDinero As System.Windows.Forms.DataGridView
    Friend WithEvents gbx_Envases As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_TotalEnvases As System.Windows.Forms.Label
    Friend WithEvents lbl_Tcapturado As System.Windows.Forms.Label
    Friend WithEvents Lbl_Envases As System.Windows.Forms.Label
    Friend WithEvents tbx_EnvasesSn As Modulo_Recepcion.cp_Textbox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Total As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_TotalRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_HoraRem As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Min As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Hora As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Operador As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cajero As System.Windows.Forms.Label
    Friend WithEvents gbx_Acta As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Ruta As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaActa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbx_HoraActa As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_MinActa As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents tbx_Esclusa As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_NEsclusa As System.Windows.Forms.Label
    Friend WithEvents Lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoAnomalia As System.Windows.Forms.Label
    Friend WithEvents rtb_Motivo As System.Windows.Forms.RichTextBox
    Friend WithEvents Lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents lsv_Custodios As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Custodios As System.Windows.Forms.Label
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_Parametro
    Friend WithEvents cmb_Operador As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents cmb_Custodio As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents cmb_Cliente As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Ejemplo As System.Windows.Forms.Label
End Class
