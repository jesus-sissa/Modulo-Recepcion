<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarFechaYruta
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
        Dim ListViewColumnSorter5 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter7 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter8 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.tab_General = New System.Windows.Forms.TabControl
        Me.tab_Boveda = New System.Windows.Forms.TabPage
        Me.lbl_RemisionBoveda = New System.Windows.Forms.Label
        Me.lbl_RegistrosTV = New System.Windows.Forms.Label
        Me.btn_BuscarBoveda = New System.Windows.Forms.Button
        Me.gbx_Boveda = New System.Windows.Forms.GroupBox
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.cbx_Todas = New System.Windows.Forms.CheckBox
        Me.Tab_Atms = New System.Windows.Forms.TabPage
        Me.lbl_RemisionCajeros = New System.Windows.Forms.Label
        Me.Lbl_RegistrosAtm = New System.Windows.Forms.Label
        Me.btn_BuscarCajeros = New System.Windows.Forms.Button
        Me.gbx_Atms = New System.Windows.Forms.GroupBox
        Me.lbl_BovedaProceso = New System.Windows.Forms.Label
        Me.cbx_TodasCajeros = New System.Windows.Forms.CheckBox
        Me.btn_GuardarFecha = New System.Windows.Forms.Button
        Me.btn_GuardarRuta = New System.Windows.Forms.Button
        Me.btn_GuardarTodo = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Ruta = New System.Windows.Forms.Label
        Me.Gbx_FechayRuta = New System.Windows.Forms.GroupBox
        Me.Lbl_NuevoO = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_NuevoO = New System.Windows.Forms.Button
        Me.btn_Remanente = New System.Windows.Forms.Button
        Me.cmb_NuevoOrigen = New Modulo_Recepcion.cp_cmb_SimpleFiltrado
        Me.cmb_Ruta = New Modulo_Recepcion.cp_cmb_Simple
        Me.cmb_Ruta2 = New Modulo_Recepcion.cp_cmb_Simple
        Me.lsv_EnvaseTv = New Modulo_Recepcion.cp_Listview
        Me.tbx_BuscarBoveda = New Modulo_Recepcion.cp_Textbox
        Me.lsv_Boveda = New Modulo_Recepcion.cp_Listview
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.lsv_EnvaseCaj = New Modulo_Recepcion.cp_Listview
        Me.tbx_BuscarCajeros = New Modulo_Recepcion.cp_Textbox
        Me.lsv_Atms = New Modulo_Recepcion.cp_Listview
        Me.cmb_BovedaCajeros = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.chk_Ctodos = New System.Windows.Forms.CheckBox
        Me.tab_General.SuspendLayout()
        Me.tab_Boveda.SuspendLayout()
        Me.gbx_Boveda.SuspendLayout()
        Me.Tab_Atms.SuspendLayout()
        Me.gbx_Atms.SuspendLayout()
        Me.Gbx_FechayRuta.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_General
        '
        Me.tab_General.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_General.Controls.Add(Me.tab_Boveda)
        Me.tab_General.Controls.Add(Me.Tab_Atms)
        Me.tab_General.Location = New System.Drawing.Point(1, 0)
        Me.tab_General.Name = "tab_General"
        Me.tab_General.SelectedIndex = 0
        Me.tab_General.Size = New System.Drawing.Size(1124, 454)
        Me.tab_General.TabIndex = 0
        '
        'tab_Boveda
        '
        Me.tab_Boveda.Controls.Add(Me.lsv_EnvaseTv)
        Me.tab_Boveda.Controls.Add(Me.lbl_RemisionBoveda)
        Me.tab_Boveda.Controls.Add(Me.lbl_RegistrosTV)
        Me.tab_Boveda.Controls.Add(Me.tbx_BuscarBoveda)
        Me.tab_Boveda.Controls.Add(Me.lsv_Boveda)
        Me.tab_Boveda.Controls.Add(Me.btn_BuscarBoveda)
        Me.tab_Boveda.Controls.Add(Me.gbx_Boveda)
        Me.tab_Boveda.Location = New System.Drawing.Point(4, 22)
        Me.tab_Boveda.Name = "tab_Boveda"
        Me.tab_Boveda.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Boveda.Size = New System.Drawing.Size(1116, 428)
        Me.tab_Boveda.TabIndex = 0
        Me.tab_Boveda.Text = "TV"
        Me.tab_Boveda.UseVisualStyleBackColor = True
        '
        'lbl_RemisionBoveda
        '
        Me.lbl_RemisionBoveda.AutoSize = True
        Me.lbl_RemisionBoveda.Location = New System.Drawing.Point(7, 61)
        Me.lbl_RemisionBoveda.Name = "lbl_RemisionBoveda"
        Me.lbl_RemisionBoveda.Size = New System.Drawing.Size(43, 13)
        Me.lbl_RemisionBoveda.TabIndex = 6
        Me.lbl_RemisionBoveda.Text = "Envase"
        '
        'lbl_RegistrosTV
        '
        Me.lbl_RegistrosTV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosTV.Location = New System.Drawing.Point(978, 64)
        Me.lbl_RegistrosTV.Name = "lbl_RegistrosTV"
        Me.lbl_RegistrosTV.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosTV.TabIndex = 3
        Me.lbl_RegistrosTV.Text = "Registros: 0"
        Me.lbl_RegistrosTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_BuscarBoveda
        '
        Me.btn_BuscarBoveda.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.btn_BuscarBoveda.Location = New System.Drawing.Point(297, 56)
        Me.btn_BuscarBoveda.Name = "btn_BuscarBoveda"
        Me.btn_BuscarBoveda.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarBoveda.TabIndex = 4
        Me.btn_BuscarBoveda.Text = "&Buscar"
        Me.btn_BuscarBoveda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarBoveda.UseVisualStyleBackColor = True
        '
        'gbx_Boveda
        '
        Me.gbx_Boveda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Boveda.Controls.Add(Me.lbl_Boveda)
        Me.gbx_Boveda.Controls.Add(Me.cmb_Boveda)
        Me.gbx_Boveda.Controls.Add(Me.cbx_Todas)
        Me.gbx_Boveda.Location = New System.Drawing.Point(3, 6)
        Me.gbx_Boveda.Name = "gbx_Boveda"
        Me.gbx_Boveda.Size = New System.Drawing.Size(1110, 46)
        Me.gbx_Boveda.TabIndex = 0
        Me.gbx_Boveda.TabStop = False
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(10, 17)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'cbx_Todas
        '
        Me.cbx_Todas.AutoSize = True
        Me.cbx_Todas.Location = New System.Drawing.Point(294, 16)
        Me.cbx_Todas.Name = "cbx_Todas"
        Me.cbx_Todas.Size = New System.Drawing.Size(56, 17)
        Me.cbx_Todas.TabIndex = 2
        Me.cbx_Todas.Text = "Todas"
        Me.cbx_Todas.UseVisualStyleBackColor = True
        '
        'Tab_Atms
        '
        Me.Tab_Atms.Controls.Add(Me.lsv_EnvaseCaj)
        Me.Tab_Atms.Controls.Add(Me.lbl_RemisionCajeros)
        Me.Tab_Atms.Controls.Add(Me.Lbl_RegistrosAtm)
        Me.Tab_Atms.Controls.Add(Me.tbx_BuscarCajeros)
        Me.Tab_Atms.Controls.Add(Me.lsv_Atms)
        Me.Tab_Atms.Controls.Add(Me.btn_BuscarCajeros)
        Me.Tab_Atms.Controls.Add(Me.gbx_Atms)
        Me.Tab_Atms.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Atms.Name = "Tab_Atms"
        Me.Tab_Atms.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Atms.Size = New System.Drawing.Size(1116, 428)
        Me.Tab_Atms.TabIndex = 1
        Me.Tab_Atms.Text = "ATM's"
        Me.Tab_Atms.UseVisualStyleBackColor = True
        '
        'lbl_RemisionCajeros
        '
        Me.lbl_RemisionCajeros.AutoSize = True
        Me.lbl_RemisionCajeros.Location = New System.Drawing.Point(8, 61)
        Me.lbl_RemisionCajeros.Name = "lbl_RemisionCajeros"
        Me.lbl_RemisionCajeros.Size = New System.Drawing.Size(43, 13)
        Me.lbl_RemisionCajeros.TabIndex = 5
        Me.lbl_RemisionCajeros.Text = "Envase"
        '
        'Lbl_RegistrosAtm
        '
        Me.Lbl_RegistrosAtm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosAtm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosAtm.Location = New System.Drawing.Point(978, 63)
        Me.Lbl_RegistrosAtm.Name = "Lbl_RegistrosAtm"
        Me.Lbl_RegistrosAtm.Size = New System.Drawing.Size(135, 15)
        Me.Lbl_RegistrosAtm.TabIndex = 3
        Me.Lbl_RegistrosAtm.Text = "Registros: 0"
        Me.Lbl_RegistrosAtm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_BuscarCajeros
        '
        Me.btn_BuscarCajeros.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.btn_BuscarCajeros.Location = New System.Drawing.Point(298, 56)
        Me.btn_BuscarCajeros.Name = "btn_BuscarCajeros"
        Me.btn_BuscarCajeros.Size = New System.Drawing.Size(75, 23)
        Me.btn_BuscarCajeros.TabIndex = 4
        Me.btn_BuscarCajeros.Text = "&Buscar"
        Me.btn_BuscarCajeros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCajeros.UseVisualStyleBackColor = True
        '
        'gbx_Atms
        '
        Me.gbx_Atms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Atms.Controls.Add(Me.lbl_BovedaProceso)
        Me.gbx_Atms.Controls.Add(Me.cmb_BovedaCajeros)
        Me.gbx_Atms.Controls.Add(Me.cbx_TodasCajeros)
        Me.gbx_Atms.Location = New System.Drawing.Point(3, 6)
        Me.gbx_Atms.Name = "gbx_Atms"
        Me.gbx_Atms.Size = New System.Drawing.Size(1110, 46)
        Me.gbx_Atms.TabIndex = 0
        Me.gbx_Atms.TabStop = False
        '
        'lbl_BovedaProceso
        '
        Me.lbl_BovedaProceso.AutoSize = True
        Me.lbl_BovedaProceso.Location = New System.Drawing.Point(11, 16)
        Me.lbl_BovedaProceso.Name = "lbl_BovedaProceso"
        Me.lbl_BovedaProceso.Size = New System.Drawing.Size(44, 13)
        Me.lbl_BovedaProceso.TabIndex = 0
        Me.lbl_BovedaProceso.Text = "Bóveda"
        '
        'cbx_TodasCajeros
        '
        Me.cbx_TodasCajeros.AutoSize = True
        Me.cbx_TodasCajeros.Location = New System.Drawing.Point(295, 15)
        Me.cbx_TodasCajeros.Name = "cbx_TodasCajeros"
        Me.cbx_TodasCajeros.Size = New System.Drawing.Size(56, 17)
        Me.cbx_TodasCajeros.TabIndex = 2
        Me.cbx_TodasCajeros.Text = "Todas"
        Me.cbx_TodasCajeros.UseVisualStyleBackColor = True
        '
        'btn_GuardarFecha
        '
        Me.btn_GuardarFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarFecha.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_GuardarFecha.Location = New System.Drawing.Point(6, 13)
        Me.btn_GuardarFecha.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_GuardarFecha.Name = "btn_GuardarFecha"
        Me.btn_GuardarFecha.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarFecha.TabIndex = 0
        Me.btn_GuardarFecha.Text = "Guardar &Fecha"
        Me.btn_GuardarFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarFecha.UseVisualStyleBackColor = True
        '
        'btn_GuardarRuta
        '
        Me.btn_GuardarRuta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarRuta.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_GuardarRuta.Location = New System.Drawing.Point(155, 13)
        Me.btn_GuardarRuta.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_GuardarRuta.Name = "btn_GuardarRuta"
        Me.btn_GuardarRuta.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarRuta.TabIndex = 1
        Me.btn_GuardarRuta.Text = "&Guaradar Ruta"
        Me.btn_GuardarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarRuta.UseVisualStyleBackColor = True
        '
        'btn_GuardarTodo
        '
        Me.btn_GuardarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarTodo.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_GuardarTodo.Location = New System.Drawing.Point(304, 13)
        Me.btn_GuardarTodo.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_GuardarTodo.Name = "btn_GuardarTodo"
        Me.btn_GuardarTodo.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarTodo.TabIndex = 2
        Me.btn_GuardarTodo.Text = "Guardar &Todo"
        Me.btn_GuardarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarTodo.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(970, 13)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(13, 17)
        Me.lbl_Fecha.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(56, 13)
        Me.dtp_Fecha.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'lbl_Ruta
        '
        Me.lbl_Ruta.AutoSize = True
        Me.lbl_Ruta.Location = New System.Drawing.Point(166, 17)
        Me.lbl_Ruta.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.lbl_Ruta.Name = "lbl_Ruta"
        Me.lbl_Ruta.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Ruta.TabIndex = 2
        Me.lbl_Ruta.Text = "Ruta"
        '
        'Gbx_FechayRuta
        '
        Me.Gbx_FechayRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_FechayRuta.Controls.Add(Me.chk_Ctodos)
        Me.Gbx_FechayRuta.Controls.Add(Me.cmb_NuevoOrigen)
        Me.Gbx_FechayRuta.Controls.Add(Me.Lbl_NuevoO)
        Me.Gbx_FechayRuta.Controls.Add(Me.cmb_Ruta)
        Me.Gbx_FechayRuta.Controls.Add(Me.cmb_Ruta2)
        Me.Gbx_FechayRuta.Controls.Add(Me.lbl_Fecha)
        Me.Gbx_FechayRuta.Controls.Add(Me.lbl_Ruta)
        Me.Gbx_FechayRuta.Controls.Add(Me.dtp_Fecha)
        Me.Gbx_FechayRuta.Location = New System.Drawing.Point(4, 458)
        Me.Gbx_FechayRuta.Name = "Gbx_FechayRuta"
        Me.Gbx_FechayRuta.Size = New System.Drawing.Size(1117, 41)
        Me.Gbx_FechayRuta.TabIndex = 1
        Me.Gbx_FechayRuta.TabStop = False
        '
        'Lbl_NuevoO
        '
        Me.Lbl_NuevoO.AutoSize = True
        Me.Lbl_NuevoO.Location = New System.Drawing.Point(443, 17)
        Me.Lbl_NuevoO.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Lbl_NuevoO.Name = "Lbl_NuevoO"
        Me.Lbl_NuevoO.Size = New System.Drawing.Size(73, 13)
        Me.Lbl_NuevoO.TabIndex = 6
        Me.Lbl_NuevoO.Text = "Nuevo Origen"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_NuevoO)
        Me.Gbx_Botones.Controls.Add(Me.btn_Remanente)
        Me.Gbx_Botones.Controls.Add(Me.btn_GuardarTodo)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_GuardarFecha)
        Me.Gbx_Botones.Controls.Add(Me.btn_GuardarRuta)
        Me.Gbx_Botones.Location = New System.Drawing.Point(4, 503)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(1117, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_NuevoO
        '
        Me.Btn_NuevoO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_NuevoO.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.Btn_NuevoO.Location = New System.Drawing.Point(610, 13)
        Me.Btn_NuevoO.Name = "Btn_NuevoO"
        Me.Btn_NuevoO.Size = New System.Drawing.Size(160, 30)
        Me.Btn_NuevoO.TabIndex = 6
        Me.Btn_NuevoO.Text = "Nuevo Origen"
        Me.Btn_NuevoO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_NuevoO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_NuevoO.UseVisualStyleBackColor = True
        '
        'btn_Remanente
        '
        Me.btn_Remanente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Remanente.Enabled = False
        Me.btn_Remanente.Image = Global.Modulo_Recepcion.My.Resources.Resources.refresh
        Me.btn_Remanente.Location = New System.Drawing.Point(452, 13)
        Me.btn_Remanente.Margin = New System.Windows.Forms.Padding(15, 3, 15, 3)
        Me.btn_Remanente.Name = "btn_Remanente"
        Me.btn_Remanente.Size = New System.Drawing.Size(140, 30)
        Me.btn_Remanente.TabIndex = 3
        Me.btn_Remanente.Text = "&Remanente"
        Me.btn_Remanente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Remanente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Remanente.UseVisualStyleBackColor = True
        Me.btn_Remanente.Visible = False
        '
        'cmb_NuevoOrigen
        '
        Me.cmb_NuevoOrigen.Clave = Nothing
        Me.cmb_NuevoOrigen.Control_Siguiente = Nothing
        Me.cmb_NuevoOrigen.DisplayMember = "NombreComercial"
        Me.cmb_NuevoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NuevoOrigen.Empresa = False
        Me.cmb_NuevoOrigen.Filtro = Nothing
        Me.cmb_NuevoOrigen.FormattingEnabled = True
        Me.cmb_NuevoOrigen.Location = New System.Drawing.Point(522, 13)
        Me.cmb_NuevoOrigen.MaxDropDownItems = 20
        Me.cmb_NuevoOrigen.Name = "cmb_NuevoOrigen"
        Me.cmb_NuevoOrigen.Pista = True
        Me.cmb_NuevoOrigen.Size = New System.Drawing.Size(416, 21)
        Me.cmb_NuevoOrigen.StoredProcedure = Nothing
        Me.cmb_NuevoOrigen.Sucursal = False
        Me.cmb_NuevoOrigen.TabIndex = 7
        Me.cmb_NuevoOrigen.Tipo = 0
        Me.cmb_NuevoOrigen.ValueMember = "Id_Cliente"
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Control_Siguiente = Me.btn_Cerrar
        Me.cmb_Ruta.DisplayMember = "Descripcion"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.Empresa = False
        Me.cmb_Ruta.FormattingEnabled = True
        Me.cmb_Ruta.Location = New System.Drawing.Point(202, 12)
        Me.cmb_Ruta.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cmb_Ruta.MaxDropDownItems = 20
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Pista = False
        Me.cmb_Ruta.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ruta.StoredProcedure = "Cat_RutasTipos_Get"
        Me.cmb_Ruta.Sucursal = True
        Me.cmb_Ruta.TabIndex = 3
        Me.cmb_Ruta.ValueMember = "Id_Ruta"
        '
        'cmb_Ruta2
        '
        Me.cmb_Ruta2.Control_Siguiente = Me.btn_Cerrar
        Me.cmb_Ruta2.DisplayMember = "Descripcion"
        Me.cmb_Ruta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta2.Empresa = False
        Me.cmb_Ruta2.FormattingEnabled = True
        Me.cmb_Ruta2.Location = New System.Drawing.Point(202, 12)
        Me.cmb_Ruta2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cmb_Ruta2.MaxDropDownItems = 20
        Me.cmb_Ruta2.Name = "cmb_Ruta2"
        Me.cmb_Ruta2.Pista = False
        Me.cmb_Ruta2.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Ruta2.StoredProcedure = "Cat_RutasTipos_Get"
        Me.cmb_Ruta2.Sucursal = True
        Me.cmb_Ruta2.TabIndex = 4
        Me.cmb_Ruta2.ValueMember = "Id_Ruta"
        Me.cmb_Ruta2.Visible = False
        '
        'lsv_EnvaseTv
        '
        Me.lsv_EnvaseTv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvaseTv.FullRowSelect = True
        Me.lsv_EnvaseTv.HideSelection = False
        Me.lsv_EnvaseTv.Location = New System.Drawing.Point(3, 284)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_EnvaseTv.Lvs = ListViewColumnSorter5
        Me.lsv_EnvaseTv.MultiSelect = False
        Me.lsv_EnvaseTv.Name = "lsv_EnvaseTv"
        Me.lsv_EnvaseTv.Row1 = 10
        Me.lsv_EnvaseTv.Row10 = 0
        Me.lsv_EnvaseTv.Row2 = 10
        Me.lsv_EnvaseTv.Row3 = 10
        Me.lsv_EnvaseTv.Row4 = 15
        Me.lsv_EnvaseTv.Row5 = 15
        Me.lsv_EnvaseTv.Row6 = 10
        Me.lsv_EnvaseTv.Row7 = 10
        Me.lsv_EnvaseTv.Row8 = 10
        Me.lsv_EnvaseTv.Row9 = 0
        Me.lsv_EnvaseTv.Size = New System.Drawing.Size(1110, 138)
        Me.lsv_EnvaseTv.TabIndex = 8
        Me.lsv_EnvaseTv.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvaseTv.View = System.Windows.Forms.View.Details
        '
        'tbx_BuscarBoveda
        '
        Me.tbx_BuscarBoveda.Control_Siguiente = Nothing
        Me.tbx_BuscarBoveda.Filtrado = False
        Me.tbx_BuscarBoveda.Location = New System.Drawing.Point(63, 58)
        Me.tbx_BuscarBoveda.MaxLength = 200
        Me.tbx_BuscarBoveda.Name = "tbx_BuscarBoveda"
        Me.tbx_BuscarBoveda.Size = New System.Drawing.Size(228, 20)
        Me.tbx_BuscarBoveda.TabIndex = 3
        Me.tbx_BuscarBoveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Boveda
        '
        Me.lsv_Boveda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Boveda.CheckBoxes = True
        Me.lsv_Boveda.FullRowSelect = True
        Me.lsv_Boveda.HideSelection = False
        Me.lsv_Boveda.Location = New System.Drawing.Point(3, 82)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_Boveda.Lvs = ListViewColumnSorter6
        Me.lsv_Boveda.MultiSelect = False
        Me.lsv_Boveda.Name = "lsv_Boveda"
        Me.lsv_Boveda.Row1 = 10
        Me.lsv_Boveda.Row10 = 0
        Me.lsv_Boveda.Row2 = 10
        Me.lsv_Boveda.Row3 = 10
        Me.lsv_Boveda.Row4 = 15
        Me.lsv_Boveda.Row5 = 15
        Me.lsv_Boveda.Row6 = 10
        Me.lsv_Boveda.Row7 = 10
        Me.lsv_Boveda.Row8 = 10
        Me.lsv_Boveda.Row9 = 0
        Me.lsv_Boveda.Size = New System.Drawing.Size(1110, 197)
        Me.lsv_Boveda.TabIndex = 1
        Me.lsv_Boveda.UseCompatibleStateImageBehavior = False
        Me.lsv_Boveda.View = System.Windows.Forms.View.Details
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = Nothing
        Me.cmb_Boveda.Control_Siguiente = Me.tbx_BuscarBoveda
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Nothing
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(60, 14)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 1
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'lsv_EnvaseCaj
        '
        Me.lsv_EnvaseCaj.AllowColumnReorder = True
        Me.lsv_EnvaseCaj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvaseCaj.FullRowSelect = True
        Me.lsv_EnvaseCaj.HideSelection = False
        Me.lsv_EnvaseCaj.Location = New System.Drawing.Point(3, 290)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_EnvaseCaj.Lvs = ListViewColumnSorter7
        Me.lsv_EnvaseCaj.MultiSelect = False
        Me.lsv_EnvaseCaj.Name = "lsv_EnvaseCaj"
        Me.lsv_EnvaseCaj.Row1 = 10
        Me.lsv_EnvaseCaj.Row10 = 0
        Me.lsv_EnvaseCaj.Row2 = 10
        Me.lsv_EnvaseCaj.Row3 = 10
        Me.lsv_EnvaseCaj.Row4 = 20
        Me.lsv_EnvaseCaj.Row5 = 20
        Me.lsv_EnvaseCaj.Row6 = 10
        Me.lsv_EnvaseCaj.Row7 = 10
        Me.lsv_EnvaseCaj.Row8 = 10
        Me.lsv_EnvaseCaj.Row9 = 0
        Me.lsv_EnvaseCaj.Size = New System.Drawing.Size(1110, 131)
        Me.lsv_EnvaseCaj.TabIndex = 7
        Me.lsv_EnvaseCaj.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvaseCaj.View = System.Windows.Forms.View.Details
        '
        'tbx_BuscarCajeros
        '
        Me.tbx_BuscarCajeros.Control_Siguiente = Nothing
        Me.tbx_BuscarCajeros.Filtrado = False
        Me.tbx_BuscarCajeros.Location = New System.Drawing.Point(64, 58)
        Me.tbx_BuscarCajeros.MaxLength = 200
        Me.tbx_BuscarCajeros.Name = "tbx_BuscarCajeros"
        Me.tbx_BuscarCajeros.Size = New System.Drawing.Size(228, 20)
        Me.tbx_BuscarCajeros.TabIndex = 3
        Me.tbx_BuscarCajeros.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Atms
        '
        Me.lsv_Atms.AllowColumnReorder = True
        Me.lsv_Atms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Atms.CheckBoxes = True
        Me.lsv_Atms.FullRowSelect = True
        Me.lsv_Atms.HideSelection = False
        Me.lsv_Atms.Location = New System.Drawing.Point(3, 82)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.lsv_Atms.Lvs = ListViewColumnSorter8
        Me.lsv_Atms.MultiSelect = False
        Me.lsv_Atms.Name = "lsv_Atms"
        Me.lsv_Atms.Row1 = 10
        Me.lsv_Atms.Row10 = 0
        Me.lsv_Atms.Row2 = 10
        Me.lsv_Atms.Row3 = 10
        Me.lsv_Atms.Row4 = 20
        Me.lsv_Atms.Row5 = 20
        Me.lsv_Atms.Row6 = 10
        Me.lsv_Atms.Row7 = 10
        Me.lsv_Atms.Row8 = 10
        Me.lsv_Atms.Row9 = 0
        Me.lsv_Atms.Size = New System.Drawing.Size(1110, 204)
        Me.lsv_Atms.TabIndex = 1
        Me.lsv_Atms.UseCompatibleStateImageBehavior = False
        Me.lsv_Atms.View = System.Windows.Forms.View.Details
        '
        'cmb_BovedaCajeros
        '
        Me.cmb_BovedaCajeros.Clave = Nothing
        Me.cmb_BovedaCajeros.Control_Siguiente = Me.btn_BuscarCajeros
        Me.cmb_BovedaCajeros.DisplayMember = "Descripcion"
        Me.cmb_BovedaCajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BovedaCajeros.Empresa = False
        Me.cmb_BovedaCajeros.Filtro = Nothing
        Me.cmb_BovedaCajeros.FormattingEnabled = True
        Me.cmb_BovedaCajeros.Location = New System.Drawing.Point(61, 13)
        Me.cmb_BovedaCajeros.MaxDropDownItems = 20
        Me.cmb_BovedaCajeros.Name = "cmb_BovedaCajeros"
        Me.cmb_BovedaCajeros.Pista = False
        Me.cmb_BovedaCajeros.Size = New System.Drawing.Size(228, 21)
        Me.cmb_BovedaCajeros.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_BovedaCajeros.Sucursal = True
        Me.cmb_BovedaCajeros.TabIndex = 1
        Me.cmb_BovedaCajeros.Tipo = 0
        Me.cmb_BovedaCajeros.ValueMember = "Id_Boveda"
        '
        'chk_Ctodos
        '
        Me.chk_Ctodos.AutoSize = True
        Me.chk_Ctodos.Location = New System.Drawing.Point(944, 16)
        Me.chk_Ctodos.Name = "chk_Ctodos"
        Me.chk_Ctodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Ctodos.TabIndex = 8
        Me.chk_Ctodos.Text = "Todas"
        Me.chk_Ctodos.UseVisualStyleBackColor = True
        '
        'frm_AsignarFechaYruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 562)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_FechayRuta)
        Me.Controls.Add(Me.tab_General)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AsignarFechaYruta"
        Me.Text = "Asignar Fecha y Ruta a Servicios"
        Me.tab_General.ResumeLayout(False)
        Me.tab_Boveda.ResumeLayout(False)
        Me.tab_Boveda.PerformLayout()
        Me.gbx_Boveda.ResumeLayout(False)
        Me.gbx_Boveda.PerformLayout()
        Me.Tab_Atms.ResumeLayout(False)
        Me.Tab_Atms.PerformLayout()
        Me.gbx_Atms.ResumeLayout(False)
        Me.gbx_Atms.PerformLayout()
        Me.Gbx_FechayRuta.ResumeLayout(False)
        Me.Gbx_FechayRuta.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_General As System.Windows.Forms.TabControl
    Friend WithEvents tab_Boveda As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Atms As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents cbx_Todas As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_BuscarBoveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarBoveda As System.Windows.Forms.Button
    Friend WithEvents lsv_Boveda As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Atms As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_GuardarFecha As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarRuta As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarTodo As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Ruta As System.Windows.Forms.Label
    Friend WithEvents cmb_Ruta As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents tbx_BuscarCajeros As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarCajeros As System.Windows.Forms.Button
    Friend WithEvents cbx_TodasCajeros As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_BovedaCajeros As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_BovedaProceso As System.Windows.Forms.Label
    Friend WithEvents cmb_Ruta2 As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents gbx_Boveda As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Atms As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_FechayRuta As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Remanente As System.Windows.Forms.Button
    Friend WithEvents lbl_RegistrosTV As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosAtm As System.Windows.Forms.Label
    Friend WithEvents lbl_RemisionCajeros As System.Windows.Forms.Label
    Friend WithEvents lbl_RemisionBoveda As System.Windows.Forms.Label
    Friend WithEvents lsv_EnvaseTv As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_EnvaseCaj As Modulo_Recepcion.cp_Listview
    Friend WithEvents cmb_NuevoOrigen As Modulo_Recepcion.cp_cmb_SimpleFiltrado
    Friend WithEvents Lbl_NuevoO As System.Windows.Forms.Label
    Friend WithEvents Btn_NuevoO As System.Windows.Forms.Button
    Friend WithEvents chk_Ctodos As System.Windows.Forms.CheckBox
End Class
