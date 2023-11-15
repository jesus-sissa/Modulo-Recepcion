<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Bovedas
    '  Inherits Modulo_Recepcion.frm_Base
    Inherits Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Bovedas))
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.BTN_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Btn_Baja = New System.Windows.Forms.Button
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbl_TipoBov = New System.Windows.Forms.Label
        Me.lbl_Importe = New System.Windows.Forms.Label
        Me.lbl_Moneda = New System.Windows.Forms.Label
        Me.lbl_Cierre = New System.Windows.Forms.Label
        Me.dtp_cierre = New System.Windows.Forms.DateTimePicker
        Me.lbl_Apertura = New System.Windows.Forms.Label
        Me.dtp_Apertura = New System.Windows.Forms.DateTimePicker
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.lbl_Descripcion = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox
        Me.lsv_Catalogo = New Modulo_Recepcion.cp_Listview
        Me.cmb_Tipo = New Modulo_Recepcion.cp_cmb_Manual
        Me.tbx_Importe = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Moneda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Descripcion = New Modulo_Recepcion.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.BTN_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.BTN_Exportar)
        Me.tab_Listado.Controls.Add(Me.Btn_Baja)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(633, 30)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.lbl_Registros.TabIndex = 9
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Modificar.Enabled = False
        Me.BTN_Modificar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Editar
        Me.BTN_Modificar.Location = New System.Drawing.Point(151, 497)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Modificar.TabIndex = 8
        Me.BTN_Modificar.Text = "&Modificar"
        Me.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 497)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(297, 497)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 5
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Btn_Baja
        '
        Me.Btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Baja.Enabled = False
        Me.Btn_Baja.Image = Global.Modulo_Recepcion.My.Resources.Resources.BajaReing
        Me.Btn_Baja.Location = New System.Drawing.Point(5, 497)
        Me.Btn_Baja.Name = "Btn_Baja"
        Me.Btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Baja.TabIndex = 4
        Me.Btn_Baja.Text = "&Baja / Reing."
        Me.Btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Baja.UseVisualStyleBackColor = True
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 3
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 1
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.cmb_Tipo)
        Me.Tab_Nuevo.Controls.Add(Me.Label8)
        Me.Tab_Nuevo.Controls.Add(Me.Label6)
        Me.Tab_Nuevo.Controls.Add(Me.Label5)
        Me.Tab_Nuevo.Controls.Add(Me.Label4)
        Me.Tab_Nuevo.Controls.Add(Me.Label3)
        Me.Tab_Nuevo.Controls.Add(Me.Label2)
        Me.Tab_Nuevo.Controls.Add(Me.Label1)
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_TipoBov)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Importe)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Moneda)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Cierre)
        Me.Tab_Nuevo.Controls.Add(Me.dtp_cierre)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Apertura)
        Me.Tab_Nuevo.Controls.Add(Me.dtp_Apertura)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Clave)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Descripcion)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Importe)
        Me.Tab_Nuevo.Controls.Add(Me.cmb_Moneda)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Clave)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Descripcion)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(776, 368)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(361, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(244, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(362, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(222, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(222, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(484, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(184, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'Lbl_TipoBov
        '
        Me.Lbl_TipoBov.AutoSize = True
        Me.Lbl_TipoBov.Location = New System.Drawing.Point(39, 199)
        Me.Lbl_TipoBov.Name = "Lbl_TipoBov"
        Me.Lbl_TipoBov.Size = New System.Drawing.Size(83, 13)
        Me.Lbl_TipoBov.TabIndex = 18
        Me.Lbl_TipoBov.Text = "Tipo de Bóveda"
        '
        'lbl_Importe
        '
        Me.lbl_Importe.AutoSize = True
        Me.lbl_Importe.Location = New System.Drawing.Point(24, 174)
        Me.lbl_Importe.Name = "lbl_Importe"
        Me.lbl_Importe.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Importe.TabIndex = 15
        Me.lbl_Importe.Text = "Importe Línea Roja"
        '
        'lbl_Moneda
        '
        Me.lbl_Moneda.AutoSize = True
        Me.lbl_Moneda.Location = New System.Drawing.Point(20, 147)
        Me.lbl_Moneda.Name = "lbl_Moneda"
        Me.lbl_Moneda.Size = New System.Drawing.Size(102, 13)
        Me.lbl_Moneda.TabIndex = 12
        Me.lbl_Moneda.Text = "Moneda Línea Roja"
        '
        'lbl_Cierre
        '
        Me.lbl_Cierre.AutoSize = True
        Me.lbl_Cierre.Location = New System.Drawing.Point(47, 122)
        Me.lbl_Cierre.Name = "lbl_Cierre"
        Me.lbl_Cierre.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Cierre.TabIndex = 9
        Me.lbl_Cierre.Text = "Hora de Cierre"
        '
        'dtp_cierre
        '
        Me.dtp_cierre.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_cierre.Location = New System.Drawing.Point(128, 118)
        Me.dtp_cierre.Name = "dtp_cierre"
        Me.dtp_cierre.ShowUpDown = True
        Me.dtp_cierre.Size = New System.Drawing.Size(88, 20)
        Me.dtp_cierre.TabIndex = 10
        Me.dtp_cierre.Value = New Date(2009, 5, 15, 0, 0, 0, 0)
        '
        'lbl_Apertura
        '
        Me.lbl_Apertura.AutoSize = True
        Me.lbl_Apertura.Location = New System.Drawing.Point(34, 96)
        Me.lbl_Apertura.Name = "lbl_Apertura"
        Me.lbl_Apertura.Size = New System.Drawing.Size(88, 13)
        Me.lbl_Apertura.TabIndex = 6
        Me.lbl_Apertura.Text = "Hora de Apertura"
        '
        'dtp_Apertura
        '
        Me.dtp_Apertura.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dtp_Apertura.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_Apertura.Location = New System.Drawing.Point(128, 92)
        Me.dtp_Apertura.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtp_Apertura.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtp_Apertura.Name = "dtp_Apertura"
        Me.dtp_Apertura.ShowUpDown = True
        Me.dtp_Apertura.Size = New System.Drawing.Size(88, 20)
        Me.dtp_Apertura.TabIndex = 7
        Me.dtp_Apertura.Value = New Date(2009, 5, 15, 0, 0, 0, 0)
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(88, 43)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(59, 69)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 3
        Me.lbl_Descripcion.Text = "Descripcion"
        Me.lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(128, 227)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(141, 30)
        Me.btn_Guardar.TabIndex = 20
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(274, 227)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 21
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 2
        Me.tbx_Buscar.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 48)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 30
        Me.lsv_Catalogo.Row3 = 5
        Me.lsv_Catalogo.Row4 = 5
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 8
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(770, 444)
        Me.lsv_Catalogo.TabIndex = 0
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(129, 196)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(226, 21)
        Me.cmb_Tipo.TabIndex = 19
        Me.cmb_Tipo.ValueMember = "value"
        '
        'tbx_Importe
        '
        Me.tbx_Importe.BackColor = System.Drawing.Color.White
        Me.tbx_Importe.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Importe.Filtrado = True
        Me.tbx_Importe.Location = New System.Drawing.Point(128, 171)
        Me.tbx_Importe.MaxLength = 10
        Me.tbx_Importe.Name = "tbx_Importe"
        Me.tbx_Importe.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Importe.TabIndex = 16
        Me.tbx_Importe.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.BackColor = System.Drawing.Color.White
        Me.cmb_Moneda.Clave = Nothing
        Me.cmb_Moneda.Control_Siguiente = Me.tbx_Importe
        Me.cmb_Moneda.DisplayMember = "Nombre"
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.Empresa = False
        Me.cmb_Moneda.Filtro = Nothing
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(128, 144)
        Me.cmb_Moneda.MaxDropDownItems = 20
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Pista = False
        Me.cmb_Moneda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Moneda.StoredProcedure = "Cat_MonedasCombo_Get"
        Me.cmb_Moneda.Sucursal = False
        Me.cmb_Moneda.TabIndex = 13
        Me.cmb_Moneda.Tipo = 0
        Me.cmb_Moneda.ValueMember = "Id_Moneda"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.BackColor = System.Drawing.Color.White
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Descripcion
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(128, 40)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.BackColor = System.Drawing.Color.White
        Me.tbx_Descripcion.Control_Siguiente = Me.dtp_Apertura
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(128, 66)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Descripcion.TabIndex = 4
        Me.tbx_Descripcion.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'frm_Bovedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Bovedas"
        Me.Text = "Catalogo de Bovedas"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents Btn_Baja As System.Windows.Forms.Button
    Friend WithEvents BTN_Modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Descripcion As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Buscar As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_Recepcion.cp_Textbox
    Friend WithEvents dtp_Apertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Cierre As System.Windows.Forms.Label
    Friend WithEvents dtp_cierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Apertura As System.Windows.Forms.Label
    Friend WithEvents cmb_Moneda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Moneda As System.Windows.Forms.Label
    Friend WithEvents tbx_Importe As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Importe As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Tipo As Modulo_Recepcion.cp_cmb_Manual
    Friend WithEvents Lbl_TipoBov As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
