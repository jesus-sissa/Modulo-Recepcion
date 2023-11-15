<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecepcionRutasInternas
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
        Me.components = New System.ComponentModel.Container
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
        Dim ListViewColumnSorter11 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter12 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter13 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter14 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter15 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter16 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Tab_General = New System.Windows.Forms.TabControl
        Me.Tab_Remisiones = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosR = New System.Windows.Forms.Label
        Me.Btn_Validar = New System.Windows.Forms.Button
        Me.btn_GrabarServicio = New System.Windows.Forms.Button
        Me.btn_AgregaRemision = New System.Windows.Forms.Button
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.Tab_RemisionesM = New System.Windows.Forms.TabPage
        Me.Lbl_envases = New System.Windows.Forms.Label
        Me.btn_AgregarNuevaRemision = New System.Windows.Forms.Button
        Me.lbl_PuntosyRemisionesV = New System.Windows.Forms.Label
        Me.lbl_PuntosyRemisiones = New System.Windows.Forms.Label
        Me.btn_ValidarRemision = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarRemisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerComentariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lbl_RemisionValida = New System.Windows.Forms.Label
        Me.btn_GrabarServicios = New System.Windows.Forms.Button
        Me.Tab_CVisita = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosCV = New System.Windows.Forms.Label
        Me.btn_VerCV = New System.Windows.Forms.Button
        Me.Tab_Pendientes = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosP = New System.Windows.Forms.Label
        Me.Tab_Todos = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosT = New System.Windows.Forms.Label
        Me.Lbl_Remisiones = New System.Windows.Forms.Label
        Me.Tab_Resumen = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosRes = New System.Windows.Forms.Label
        Me.Tab_Materiales = New System.Windows.Forms.TabPage
        Me.Lbl_RegistrosM = New System.Windows.Forms.Label
        Me.Btn_RBoveda = New System.Windows.Forms.Button
        Me.Tab_Atms = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbl_RegistrosAtms = New System.Windows.Forms.Label
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.lbl_RemisionRetiro = New System.Windows.Forms.Label
        Me.Btn_RBovedaAtms = New System.Windows.Forms.Button
        Me.Tab_AtmsFallas = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Lbl_RegistrosAtmsF = New System.Windows.Forms.Label
        Me.Lbl_RemisionesRet = New System.Windows.Forms.Label
        Me.Btn_RBovedaAtmsF = New System.Windows.Forms.Button
        Me.grp_Remisiones = New System.Windows.Forms.GroupBox
        Me.tbx_copy = New System.Windows.Forms.TextBox
        Me.btn_Actualizar = New System.Windows.Forms.Button
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Rutas = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_StatusRutas = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_cuadreruta = New System.Windows.Forms.Button
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveRuta = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.lsv_Remisiones = New Modulo_Recepcion.cp_Listview
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.Lsv_Puntos = New Modulo_Recepcion.cp_Listview
        Me.lsv_tv = New Modulo_Recepcion.cp_Listview
        Me.lsv_PuntosyRemisiones = New Modulo_Recepcion.cp_Listview
        Me.tbx_ValidarRemision = New Modulo_Recepcion.cp_Textbox
        Me.Lsv_CVisita = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Pendientes = New Modulo_Recepcion.cp_Listview
        Me.lsv_TodosD = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Todos = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Resumen = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Materiales = New Modulo_Recepcion.cp_Listview
        Me.tbx_EnvasesAtm = New Modulo_Recepcion.cp_Textbox
        Me.lsv_envases = New Modulo_Recepcion.cp_Listview
        Me.tbx_Remision_Retiro = New Modulo_Recepcion.cp_Textbox
        Me.lsv_AtmsD = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Atms = New Modulo_Recepcion.cp_Listview
        Me.tbx_envasesf = New Modulo_Recepcion.cp_Textbox
        Me.lsv_fallas = New Modulo_Recepcion.cp_Listview
        Me.tbx_Remision_RetiroF = New Modulo_Recepcion.cp_Textbox
        Me.lsv_AtmsFallasD = New Modulo_Recepcion.cp_Listview
        Me.lsv_AtmsFallas = New Modulo_Recepcion.cp_Listview
        Me.VerRemisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Tab_General.SuspendLayout()
        Me.Tab_Remisiones.SuspendLayout()
        Me.Tab_RemisionesM.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Tab_CVisita.SuspendLayout()
        Me.Tab_Pendientes.SuspendLayout()
        Me.Tab_Todos.SuspendLayout()
        Me.Tab_Resumen.SuspendLayout()
        Me.Tab_Materiales.SuspendLayout()
        Me.Tab_Atms.SuspendLayout()
        Me.Tab_AtmsFallas.SuspendLayout()
        Me.grp_Remisiones.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_General
        '
        Me.Tab_General.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_General.Controls.Add(Me.Tab_Remisiones)
        Me.Tab_General.Controls.Add(Me.Tab_RemisionesM)
        Me.Tab_General.Controls.Add(Me.Tab_CVisita)
        Me.Tab_General.Controls.Add(Me.Tab_Pendientes)
        Me.Tab_General.Controls.Add(Me.Tab_Todos)
        Me.Tab_General.Controls.Add(Me.Tab_Resumen)
        Me.Tab_General.Controls.Add(Me.Tab_Materiales)
        Me.Tab_General.Controls.Add(Me.Tab_Atms)
        Me.Tab_General.Controls.Add(Me.Tab_AtmsFallas)
        Me.Tab_General.Location = New System.Drawing.Point(4, 95)
        Me.Tab_General.Name = "Tab_General"
        Me.Tab_General.SelectedIndex = 0
        Me.Tab_General.Size = New System.Drawing.Size(860, 490)
        Me.Tab_General.TabIndex = 1
        '
        'Tab_Remisiones
        '
        Me.Tab_Remisiones.Controls.Add(Me.Lbl_RegistrosR)
        Me.Tab_Remisiones.Controls.Add(Me.Btn_Validar)
        Me.Tab_Remisiones.Controls.Add(Me.lsv_Remisiones)
        Me.Tab_Remisiones.Controls.Add(Me.btn_GrabarServicio)
        Me.Tab_Remisiones.Controls.Add(Me.btn_AgregaRemision)
        Me.Tab_Remisiones.Controls.Add(Me.tbx_Remision)
        Me.Tab_Remisiones.Controls.Add(Me.Lsv_Puntos)
        Me.Tab_Remisiones.Controls.Add(Me.lbl_Remision)
        Me.Tab_Remisiones.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Remisiones.Name = "Tab_Remisiones"
        Me.Tab_Remisiones.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Remisiones.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Remisiones.TabIndex = 0
        Me.Tab_Remisiones.Text = "Remisiones"
        Me.Tab_Remisiones.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosR
        '
        Me.Lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosR.Location = New System.Drawing.Point(672, 3)
        Me.Lbl_RegistrosR.Name = "Lbl_RegistrosR"
        Me.Lbl_RegistrosR.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosR.TabIndex = 7
        Me.Lbl_RegistrosR.Text = "Registros: 0"
        Me.Lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_Validar
        '
        Me.Btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Validar.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.Btn_Validar.Location = New System.Drawing.Point(708, 295)
        Me.Btn_Validar.Name = "Btn_Validar"
        Me.Btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Validar.TabIndex = 3
        Me.Btn_Validar.Text = "&Validar"
        Me.Btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_GrabarServicio
        '
        Me.btn_GrabarServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GrabarServicio.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_GrabarServicio.Location = New System.Drawing.Point(148, 430)
        Me.btn_GrabarServicio.Name = "btn_GrabarServicio"
        Me.btn_GrabarServicio.Size = New System.Drawing.Size(140, 30)
        Me.btn_GrabarServicio.TabIndex = 6
        Me.btn_GrabarServicio.Text = "Grabar &Servicio"
        Me.btn_GrabarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GrabarServicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GrabarServicio.UseVisualStyleBackColor = True
        '
        'btn_AgregaRemision
        '
        Me.btn_AgregaRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_AgregaRemision.Enabled = False
        Me.btn_AgregaRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.btn_AgregaRemision.Location = New System.Drawing.Point(2, 430)
        Me.btn_AgregaRemision.Name = "btn_AgregaRemision"
        Me.btn_AgregaRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_AgregaRemision.TabIndex = 5
        Me.btn_AgregaRemision.Text = "&Agregar Remisión"
        Me.btn_AgregaRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregaRemision.UseVisualStyleBackColor = True
        '
        'lbl_Remision
        '
        Me.lbl_Remision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(3, 307)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 1
        Me.lbl_Remision.Text = "Remisión"
        '
        'Tab_RemisionesM
        '
        Me.Tab_RemisionesM.Controls.Add(Me.Lbl_envases)
        Me.Tab_RemisionesM.Controls.Add(Me.lsv_tv)
        Me.Tab_RemisionesM.Controls.Add(Me.btn_AgregarNuevaRemision)
        Me.Tab_RemisionesM.Controls.Add(Me.lbl_PuntosyRemisionesV)
        Me.Tab_RemisionesM.Controls.Add(Me.lbl_PuntosyRemisiones)
        Me.Tab_RemisionesM.Controls.Add(Me.btn_ValidarRemision)
        Me.Tab_RemisionesM.Controls.Add(Me.lsv_PuntosyRemisiones)
        Me.Tab_RemisionesM.Controls.Add(Me.lbl_RemisionValida)
        Me.Tab_RemisionesM.Controls.Add(Me.btn_GrabarServicios)
        Me.Tab_RemisionesM.Controls.Add(Me.tbx_ValidarRemision)
        Me.Tab_RemisionesM.Location = New System.Drawing.Point(4, 22)
        Me.Tab_RemisionesM.Name = "Tab_RemisionesM"
        Me.Tab_RemisionesM.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_RemisionesM.Size = New System.Drawing.Size(852, 464)
        Me.Tab_RemisionesM.TabIndex = 8
        Me.Tab_RemisionesM.Text = "RemisionesM"
        Me.Tab_RemisionesM.UseVisualStyleBackColor = True
        '
        'Lbl_envases
        '
        Me.Lbl_envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_envases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_envases.Location = New System.Drawing.Point(711, 284)
        Me.Lbl_envases.Name = "Lbl_envases"
        Me.Lbl_envases.Size = New System.Drawing.Size(124, 15)
        Me.Lbl_envases.TabIndex = 20
        Me.Lbl_envases.Text = "Registros: 0"
        Me.Lbl_envases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_AgregarNuevaRemision
        '
        Me.btn_AgregarNuevaRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_AgregarNuevaRemision.Enabled = False
        Me.btn_AgregarNuevaRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.btn_AgregarNuevaRemision.Location = New System.Drawing.Point(6, 269)
        Me.btn_AgregarNuevaRemision.Name = "btn_AgregarNuevaRemision"
        Me.btn_AgregarNuevaRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_AgregarNuevaRemision.TabIndex = 8
        Me.btn_AgregarNuevaRemision.Text = "&Agregar RemisiónN"
        Me.btn_AgregarNuevaRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarNuevaRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarNuevaRemision.UseVisualStyleBackColor = True
        '
        'lbl_PuntosyRemisionesV
        '
        Me.lbl_PuntosyRemisionesV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_PuntosyRemisionesV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PuntosyRemisionesV.Location = New System.Drawing.Point(583, 21)
        Me.lbl_PuntosyRemisionesV.Name = "lbl_PuntosyRemisionesV"
        Me.lbl_PuntosyRemisionesV.Size = New System.Drawing.Size(127, 15)
        Me.lbl_PuntosyRemisionesV.TabIndex = 15
        Me.lbl_PuntosyRemisionesV.Text = "Validados: 0"
        Me.lbl_PuntosyRemisionesV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_PuntosyRemisiones
        '
        Me.lbl_PuntosyRemisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_PuntosyRemisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PuntosyRemisiones.Location = New System.Drawing.Point(711, 21)
        Me.lbl_PuntosyRemisiones.Name = "lbl_PuntosyRemisiones"
        Me.lbl_PuntosyRemisiones.Size = New System.Drawing.Size(124, 15)
        Me.lbl_PuntosyRemisiones.TabIndex = 14
        Me.lbl_PuntosyRemisiones.Text = "Registros: 0"
        Me.lbl_PuntosyRemisiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ValidarRemision
        '
        Me.btn_ValidarRemision.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.btn_ValidarRemision.Location = New System.Drawing.Point(231, 6)
        Me.btn_ValidarRemision.Name = "btn_ValidarRemision"
        Me.btn_ValidarRemision.Size = New System.Drawing.Size(140, 30)
        Me.btn_ValidarRemision.TabIndex = 10
        Me.btn_ValidarRemision.Text = "&Validar"
        Me.btn_ValidarRemision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ValidarRemision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ValidarRemision.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarRemisionToolStripMenuItem, Me.VerComentariosToolStripMenuItem, Me.VerRemisionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 92)
        '
        'CopiarRemisionToolStripMenuItem
        '
        Me.CopiarRemisionToolStripMenuItem.Name = "CopiarRemisionToolStripMenuItem"
        Me.CopiarRemisionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CopiarRemisionToolStripMenuItem.Text = "Copiar remision"
        '
        'VerComentariosToolStripMenuItem
        '
        Me.VerComentariosToolStripMenuItem.Name = "VerComentariosToolStripMenuItem"
        Me.VerComentariosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VerComentariosToolStripMenuItem.Text = "Ver comentarios"
        '
        'lbl_RemisionValida
        '
        Me.lbl_RemisionValida.AutoSize = True
        Me.lbl_RemisionValida.Location = New System.Drawing.Point(7, 13)
        Me.lbl_RemisionValida.Name = "lbl_RemisionValida"
        Me.lbl_RemisionValida.Size = New System.Drawing.Size(43, 13)
        Me.lbl_RemisionValida.TabIndex = 8
        Me.lbl_RemisionValida.Text = "Envase"
        '
        'btn_GrabarServicios
        '
        Me.btn_GrabarServicios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GrabarServicios.Enabled = False
        Me.btn_GrabarServicios.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_GrabarServicios.Location = New System.Drawing.Point(152, 269)
        Me.btn_GrabarServicios.Name = "btn_GrabarServicios"
        Me.btn_GrabarServicios.Size = New System.Drawing.Size(140, 30)
        Me.btn_GrabarServicios.TabIndex = 13
        Me.btn_GrabarServicios.Text = "Grabar &Servicios"
        Me.btn_GrabarServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GrabarServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GrabarServicios.UseVisualStyleBackColor = True
        '
        'Tab_CVisita
        '
        Me.Tab_CVisita.Controls.Add(Me.Lbl_RegistrosCV)
        Me.Tab_CVisita.Controls.Add(Me.Lsv_CVisita)
        Me.Tab_CVisita.Controls.Add(Me.btn_VerCV)
        Me.Tab_CVisita.Location = New System.Drawing.Point(4, 22)
        Me.Tab_CVisita.Name = "Tab_CVisita"
        Me.Tab_CVisita.Size = New System.Drawing.Size(852, 464)
        Me.Tab_CVisita.TabIndex = 5
        Me.Tab_CVisita.Text = "Comprobante Visita"
        Me.Tab_CVisita.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosCV
        '
        Me.Lbl_RegistrosCV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosCV.Location = New System.Drawing.Point(674, 3)
        Me.Lbl_RegistrosCV.Name = "Lbl_RegistrosCV"
        Me.Lbl_RegistrosCV.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosCV.TabIndex = 2
        Me.Lbl_RegistrosCV.Text = "Registros: 0"
        Me.Lbl_RegistrosCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_VerCV
        '
        Me.btn_VerCV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_VerCV.Enabled = False
        Me.btn_VerCV.Image = Global.Modulo_Recepcion.My.Resources.Resources.AsignarCantFichas
        Me.btn_VerCV.Location = New System.Drawing.Point(4, 435)
        Me.btn_VerCV.Name = "btn_VerCV"
        Me.btn_VerCV.Size = New System.Drawing.Size(140, 30)
        Me.btn_VerCV.TabIndex = 1
        Me.btn_VerCV.Text = "&Validar CV"
        Me.btn_VerCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VerCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_VerCV.UseVisualStyleBackColor = True
        '
        'Tab_Pendientes
        '
        Me.Tab_Pendientes.Controls.Add(Me.Lbl_RegistrosP)
        Me.Tab_Pendientes.Controls.Add(Me.Lsv_Pendientes)
        Me.Tab_Pendientes.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Pendientes.Name = "Tab_Pendientes"
        Me.Tab_Pendientes.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Pendientes.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Pendientes.TabIndex = 1
        Me.Tab_Pendientes.Text = "Pendientes"
        Me.Tab_Pendientes.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosP
        '
        Me.Lbl_RegistrosP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosP.Location = New System.Drawing.Point(671, 3)
        Me.Lbl_RegistrosP.Name = "Lbl_RegistrosP"
        Me.Lbl_RegistrosP.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosP.TabIndex = 2
        Me.Lbl_RegistrosP.Text = "Registros: 0"
        Me.Lbl_RegistrosP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Todos
        '
        Me.Tab_Todos.Controls.Add(Me.Lbl_RegistrosT)
        Me.Tab_Todos.Controls.Add(Me.Lbl_Remisiones)
        Me.Tab_Todos.Controls.Add(Me.lsv_TodosD)
        Me.Tab_Todos.Controls.Add(Me.Lsv_Todos)
        Me.Tab_Todos.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Todos.Name = "Tab_Todos"
        Me.Tab_Todos.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Todos.TabIndex = 4
        Me.Tab_Todos.Text = "Todos"
        Me.Tab_Todos.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosT
        '
        Me.Lbl_RegistrosT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosT.Location = New System.Drawing.Point(674, 4)
        Me.Lbl_RegistrosT.Name = "Lbl_RegistrosT"
        Me.Lbl_RegistrosT.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosT.TabIndex = 7
        Me.Lbl_RegistrosT.Text = "Registros: 0"
        Me.Lbl_RegistrosT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Remisiones
        '
        Me.Lbl_Remisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Remisiones.AutoSize = True
        Me.Lbl_Remisiones.Location = New System.Drawing.Point(4, 347)
        Me.Lbl_Remisiones.Name = "Lbl_Remisiones"
        Me.Lbl_Remisiones.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_Remisiones.TabIndex = 6
        Me.Lbl_Remisiones.Text = "Remisiones"
        '
        'Tab_Resumen
        '
        Me.Tab_Resumen.Controls.Add(Me.Lbl_RegistrosRes)
        Me.Tab_Resumen.Controls.Add(Me.Lsv_Resumen)
        Me.Tab_Resumen.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Resumen.Name = "Tab_Resumen"
        Me.Tab_Resumen.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Resumen.TabIndex = 2
        Me.Tab_Resumen.Text = "Resumen"
        Me.Tab_Resumen.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosRes
        '
        Me.Lbl_RegistrosRes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosRes.Location = New System.Drawing.Point(674, 4)
        Me.Lbl_RegistrosRes.Name = "Lbl_RegistrosRes"
        Me.Lbl_RegistrosRes.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosRes.TabIndex = 2
        Me.Lbl_RegistrosRes.Text = "Registros: 0"
        Me.Lbl_RegistrosRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Materiales
        '
        Me.Tab_Materiales.Controls.Add(Me.Lbl_RegistrosM)
        Me.Tab_Materiales.Controls.Add(Me.Btn_RBoveda)
        Me.Tab_Materiales.Controls.Add(Me.Lsv_Materiales)
        Me.Tab_Materiales.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Materiales.Name = "Tab_Materiales"
        Me.Tab_Materiales.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Materiales.TabIndex = 3
        Me.Tab_Materiales.Text = "Materiales"
        Me.Tab_Materiales.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosM
        '
        Me.Lbl_RegistrosM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosM.Location = New System.Drawing.Point(674, 4)
        Me.Lbl_RegistrosM.Name = "Lbl_RegistrosM"
        Me.Lbl_RegistrosM.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosM.TabIndex = 2
        Me.Lbl_RegistrosM.Text = "Registros: 0"
        Me.Lbl_RegistrosM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_RBoveda
        '
        Me.Btn_RBoveda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_RBoveda.Location = New System.Drawing.Point(708, 433)
        Me.Btn_RBoveda.Name = "Btn_RBoveda"
        Me.Btn_RBoveda.Size = New System.Drawing.Size(140, 30)
        Me.Btn_RBoveda.TabIndex = 1
        Me.Btn_RBoveda.Text = "Regresar a &Bóveda"
        Me.Btn_RBoveda.UseVisualStyleBackColor = True
        '
        'Tab_Atms
        '
        Me.Tab_Atms.Controls.Add(Me.Label1)
        Me.Tab_Atms.Controls.Add(Me.tbx_EnvasesAtm)
        Me.Tab_Atms.Controls.Add(Me.lsv_envases)
        Me.Tab_Atms.Controls.Add(Me.Lbl_RegistrosAtms)
        Me.Tab_Atms.Controls.Add(Me.Lbl_Nota)
        Me.Tab_Atms.Controls.Add(Me.lbl_RemisionRetiro)
        Me.Tab_Atms.Controls.Add(Me.tbx_Remision_Retiro)
        Me.Tab_Atms.Controls.Add(Me.lsv_AtmsD)
        Me.Tab_Atms.Controls.Add(Me.Btn_RBovedaAtms)
        Me.Tab_Atms.Controls.Add(Me.Lsv_Atms)
        Me.Tab_Atms.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Atms.Name = "Tab_Atms"
        Me.Tab_Atms.Size = New System.Drawing.Size(852, 464)
        Me.Tab_Atms.TabIndex = 6
        Me.Tab_Atms.Text = "ATM's"
        Me.Tab_Atms.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Envase"
        '
        'Lbl_RegistrosAtms
        '
        Me.Lbl_RegistrosAtms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosAtms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosAtms.Location = New System.Drawing.Point(672, 4)
        Me.Lbl_RegistrosAtms.Name = "Lbl_RegistrosAtms"
        Me.Lbl_RegistrosAtms.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosAtms.TabIndex = 6
        Me.Lbl_RegistrosAtms.Text = "Registros: 0"
        Me.Lbl_RegistrosAtms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(226, 307)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(271, 13)
        Me.Lbl_Nota.TabIndex = 5
        Me.Lbl_Nota.Text = "(Puede ser un Remanente o una Dotación No Aplicada)"
        '
        'lbl_RemisionRetiro
        '
        Me.lbl_RemisionRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_RemisionRetiro.AutoSize = True
        Me.lbl_RemisionRetiro.Location = New System.Drawing.Point(3, 307)
        Me.lbl_RemisionRetiro.Name = "lbl_RemisionRetiro"
        Me.lbl_RemisionRetiro.Size = New System.Drawing.Size(81, 13)
        Me.lbl_RemisionRetiro.TabIndex = 1
        Me.lbl_RemisionRetiro.Text = "Remisión Retiro"
        '
        'Btn_RBovedaAtms
        '
        Me.Btn_RBovedaAtms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_RBovedaAtms.Location = New System.Drawing.Point(707, 298)
        Me.Btn_RBovedaAtms.Name = "Btn_RBovedaAtms"
        Me.Btn_RBovedaAtms.Size = New System.Drawing.Size(140, 30)
        Me.Btn_RBovedaAtms.TabIndex = 3
        Me.Btn_RBovedaAtms.Text = "Regresar a &Bóveda"
        Me.Btn_RBovedaAtms.UseVisualStyleBackColor = True
        '
        'Tab_AtmsFallas
        '
        Me.Tab_AtmsFallas.Controls.Add(Me.Label2)
        Me.Tab_AtmsFallas.Controls.Add(Me.tbx_envasesf)
        Me.Tab_AtmsFallas.Controls.Add(Me.lsv_fallas)
        Me.Tab_AtmsFallas.Controls.Add(Me.Lbl_RegistrosAtmsF)
        Me.Tab_AtmsFallas.Controls.Add(Me.Lbl_RemisionesRet)
        Me.Tab_AtmsFallas.Controls.Add(Me.tbx_Remision_RetiroF)
        Me.Tab_AtmsFallas.Controls.Add(Me.lsv_AtmsFallasD)
        Me.Tab_AtmsFallas.Controls.Add(Me.Btn_RBovedaAtmsF)
        Me.Tab_AtmsFallas.Controls.Add(Me.lsv_AtmsFallas)
        Me.Tab_AtmsFallas.Location = New System.Drawing.Point(4, 22)
        Me.Tab_AtmsFallas.Name = "Tab_AtmsFallas"
        Me.Tab_AtmsFallas.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_AtmsFallas.Size = New System.Drawing.Size(852, 464)
        Me.Tab_AtmsFallas.TabIndex = 7
        Me.Tab_AtmsFallas.Text = "ATM's Fallas"
        Me.Tab_AtmsFallas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Envase"
        '
        'Lbl_RegistrosAtmsF
        '
        Me.Lbl_RegistrosAtmsF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosAtmsF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosAtmsF.Location = New System.Drawing.Point(672, 4)
        Me.Lbl_RegistrosAtmsF.Name = "Lbl_RegistrosAtmsF"
        Me.Lbl_RegistrosAtmsF.Size = New System.Drawing.Size(174, 15)
        Me.Lbl_RegistrosAtmsF.TabIndex = 5
        Me.Lbl_RegistrosAtmsF.Text = "Registros: 0"
        Me.Lbl_RegistrosAtmsF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_RemisionesRet
        '
        Me.Lbl_RemisionesRet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RemisionesRet.AutoSize = True
        Me.Lbl_RemisionesRet.Location = New System.Drawing.Point(3, 307)
        Me.Lbl_RemisionesRet.Name = "Lbl_RemisionesRet"
        Me.Lbl_RemisionesRet.Size = New System.Drawing.Size(81, 13)
        Me.Lbl_RemisionesRet.TabIndex = 1
        Me.Lbl_RemisionesRet.Text = "Remisión Retiro"
        '
        'Btn_RBovedaAtmsF
        '
        Me.Btn_RBovedaAtmsF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_RBovedaAtmsF.Enabled = False
        Me.Btn_RBovedaAtmsF.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.Btn_RBovedaAtmsF.Location = New System.Drawing.Point(707, 298)
        Me.Btn_RBovedaAtmsF.Name = "Btn_RBovedaAtmsF"
        Me.Btn_RBovedaAtmsF.Size = New System.Drawing.Size(140, 30)
        Me.Btn_RBovedaAtmsF.TabIndex = 3
        Me.Btn_RBovedaAtmsF.Text = "&Validar"
        Me.Btn_RBovedaAtmsF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_RBovedaAtmsF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_RBovedaAtmsF.UseVisualStyleBackColor = True
        '
        'grp_Remisiones
        '
        Me.grp_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Remisiones.Controls.Add(Me.tbx_copy)
        Me.grp_Remisiones.Controls.Add(Me.btn_Actualizar)
        Me.grp_Remisiones.Controls.Add(Me.lbl_Boveda)
        Me.grp_Remisiones.Controls.Add(Me.tbx_Cve_Boveda)
        Me.grp_Remisiones.Controls.Add(Me.cmb_Boveda)
        Me.grp_Remisiones.Controls.Add(Me.lbl_fecha)
        Me.grp_Remisiones.Controls.Add(Me.dtp_Fecha)
        Me.grp_Remisiones.Controls.Add(Me.lbl_Rutas)
        Me.grp_Remisiones.Controls.Add(Me.tbx_CveRuta)
        Me.grp_Remisiones.Controls.Add(Me.cmb_Rutas)
        Me.grp_Remisiones.ForeColor = System.Drawing.Color.Black
        Me.grp_Remisiones.Location = New System.Drawing.Point(6, 2)
        Me.grp_Remisiones.Name = "grp_Remisiones"
        Me.grp_Remisiones.Size = New System.Drawing.Size(857, 85)
        Me.grp_Remisiones.TabIndex = 0
        Me.grp_Remisiones.TabStop = False
        '
        'tbx_copy
        '
        Me.tbx_copy.Location = New System.Drawing.Point(721, 56)
        Me.tbx_copy.Name = "tbx_copy"
        Me.tbx_copy.Size = New System.Drawing.Size(100, 20)
        Me.tbx_copy.TabIndex = 10
        Me.tbx_copy.Visible = False
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Actualizar.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.btn_Actualizar.Location = New System.Drawing.Point(540, 51)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Actualizar.TabIndex = 8
        Me.btn_Actualizar.Text = "&Actualizar"
        Me.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(18, 62)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 5
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(25, 15)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 0
        Me.lbl_fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(68, 11)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'lbl_Rutas
        '
        Me.lbl_Rutas.AutoSize = True
        Me.lbl_Rutas.Location = New System.Drawing.Point(32, 38)
        Me.lbl_Rutas.Name = "lbl_Rutas"
        Me.lbl_Rutas.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Rutas.TabIndex = 2
        Me.lbl_Rutas.Text = "Ruta"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_StatusRutas)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_cuadreruta)
        Me.gbx_Botones.Location = New System.Drawing.Point(4, 584)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(860, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_StatusRutas
        '
        Me.btn_StatusRutas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_StatusRutas.Image = Global.Modulo_Recepcion.My.Resources.Resources.StatusRutas
        Me.btn_StatusRutas.Location = New System.Drawing.Point(156, 12)
        Me.btn_StatusRutas.Name = "btn_StatusRutas"
        Me.btn_StatusRutas.Size = New System.Drawing.Size(140, 30)
        Me.btn_StatusRutas.TabIndex = 9
        Me.btn_StatusRutas.Text = "&Status Rutas"
        Me.btn_StatusRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_StatusRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_StatusRutas.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(714, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_cuadreruta
        '
        Me.btn_cuadreruta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cuadreruta.Enabled = False
        Me.btn_cuadreruta.Image = Global.Modulo_Recepcion.My.Resources.Resources.Modify
        Me.btn_cuadreruta.Location = New System.Drawing.Point(10, 12)
        Me.btn_cuadreruta.Name = "btn_cuadreruta"
        Me.btn_cuadreruta.Size = New System.Drawing.Size(140, 30)
        Me.btn_cuadreruta.TabIndex = 0
        Me.btn_cuadreruta.Text = "Cuadre de &Ruta"
        Me.btn_cuadreruta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cuadreruta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cuadreruta.UseVisualStyleBackColor = True
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(68, 59)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 6
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Me.Tab_General
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_Cve_Boveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(124, 59)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 7
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'tbx_CveRuta
        '
        Me.tbx_CveRuta.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_CveRuta.Filtrado = True
        Me.tbx_CveRuta.Location = New System.Drawing.Point(68, 35)
        Me.tbx_CveRuta.MaxLength = 4
        Me.tbx_CveRuta.Name = "tbx_CveRuta"
        Me.tbx_CveRuta.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveRuta.TabIndex = 3
        Me.tbx_CveRuta.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Rutas
        '
        Me.cmb_Rutas.Clave = "Clave"
        Me.cmb_Rutas.Control_Siguiente = Me.tbx_Cve_Boveda
        Me.cmb_Rutas.DisplayMember = "Descripcion"
        Me.cmb_Rutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rutas.Empresa = False
        Me.cmb_Rutas.Filtro = Me.tbx_CveRuta
        Me.cmb_Rutas.FormattingEnabled = True
        Me.cmb_Rutas.Location = New System.Drawing.Point(124, 34)
        Me.cmb_Rutas.MaxDropDownItems = 20
        Me.cmb_Rutas.Name = "cmb_Rutas"
        Me.cmb_Rutas.Pista = False
        Me.cmb_Rutas.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Rutas.StoredProcedure = "CAT_Rutas_Programadas"
        Me.cmb_Rutas.Sucursal = True
        Me.cmb_Rutas.TabIndex = 4
        Me.cmb_Rutas.Tipo = 0
        Me.cmb_Rutas.ValueMember = "Id_Programacion"
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.AllowColumnReorder = True
        Me.lsv_Remisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(3, 328)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter1
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 10
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 10
        Me.lsv_Remisiones.Row3 = 10
        Me.lsv_Remisiones.Row4 = 5
        Me.lsv_Remisiones.Row5 = 5
        Me.lsv_Remisiones.Row6 = 10
        Me.lsv_Remisiones.Row7 = 20
        Me.lsv_Remisiones.Row8 = 10
        Me.lsv_Remisiones.Row9 = 10
        Me.lsv_Remisiones.Size = New System.Drawing.Size(845, 100)
        Me.lsv_Remisiones.TabIndex = 4
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = True
        Me.tbx_Remision.Location = New System.Drawing.Point(59, 304)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(150, 20)
        Me.tbx_Remision.TabIndex = 2
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lsv_Puntos
        '
        Me.Lsv_Puntos.AllowColumnReorder = True
        Me.Lsv_Puntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Puntos.FullRowSelect = True
        Me.Lsv_Puntos.HideSelection = False
        Me.Lsv_Puntos.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Puntos.Lvs = ListViewColumnSorter2
        Me.Lsv_Puntos.MultiSelect = False
        Me.Lsv_Puntos.Name = "Lsv_Puntos"
        Me.Lsv_Puntos.Row1 = 39
        Me.Lsv_Puntos.Row10 = 0
        Me.Lsv_Puntos.Row2 = 29
        Me.Lsv_Puntos.Row3 = 29
        Me.Lsv_Puntos.Row4 = 0
        Me.Lsv_Puntos.Row5 = 0
        Me.Lsv_Puntos.Row6 = 0
        Me.Lsv_Puntos.Row7 = 0
        Me.Lsv_Puntos.Row8 = 0
        Me.Lsv_Puntos.Row9 = 0
        Me.Lsv_Puntos.Size = New System.Drawing.Size(842, 270)
        Me.Lsv_Puntos.TabIndex = 0
        Me.Lsv_Puntos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Puntos.View = System.Windows.Forms.View.Details
        '
        'lsv_tv
        '
        Me.lsv_tv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_tv.FullRowSelect = True
        Me.lsv_tv.HideSelection = False
        Me.lsv_tv.Location = New System.Drawing.Point(4, 306)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_tv.Lvs = ListViewColumnSorter3
        Me.lsv_tv.MultiSelect = False
        Me.lsv_tv.Name = "lsv_tv"
        Me.lsv_tv.Row1 = 30
        Me.lsv_tv.Row10 = 10
        Me.lsv_tv.Row2 = 40
        Me.lsv_tv.Row3 = 10
        Me.lsv_tv.Row4 = 10
        Me.lsv_tv.Row5 = 10
        Me.lsv_tv.Row6 = 10
        Me.lsv_tv.Row7 = 10
        Me.lsv_tv.Row8 = 10
        Me.lsv_tv.Row9 = 10
        Me.lsv_tv.Size = New System.Drawing.Size(845, 153)
        Me.lsv_tv.TabIndex = 19
        Me.lsv_tv.UseCompatibleStateImageBehavior = False
        Me.lsv_tv.View = System.Windows.Forms.View.Details
        '
        'lsv_PuntosyRemisiones
        '
        Me.lsv_PuntosyRemisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_PuntosyRemisiones.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lsv_PuntosyRemisiones.FullRowSelect = True
        Me.lsv_PuntosyRemisiones.HideSelection = False
        Me.lsv_PuntosyRemisiones.Location = New System.Drawing.Point(3, 42)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_PuntosyRemisiones.Lvs = ListViewColumnSorter4
        Me.lsv_PuntosyRemisiones.MultiSelect = False
        Me.lsv_PuntosyRemisiones.Name = "lsv_PuntosyRemisiones"
        Me.lsv_PuntosyRemisiones.Row1 = 10
        Me.lsv_PuntosyRemisiones.Row10 = 15
        Me.lsv_PuntosyRemisiones.Row2 = 21
        Me.lsv_PuntosyRemisiones.Row3 = 21
        Me.lsv_PuntosyRemisiones.Row4 = 21
        Me.lsv_PuntosyRemisiones.Row5 = 10
        Me.lsv_PuntosyRemisiones.Row6 = 10
        Me.lsv_PuntosyRemisiones.Row7 = 8
        Me.lsv_PuntosyRemisiones.Row8 = 8
        Me.lsv_PuntosyRemisiones.Row9 = 8
        Me.lsv_PuntosyRemisiones.Size = New System.Drawing.Size(846, 220)
        Me.lsv_PuntosyRemisiones.TabIndex = 11
        Me.lsv_PuntosyRemisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_PuntosyRemisiones.View = System.Windows.Forms.View.Details
        '
        'tbx_ValidarRemision
        '
        Me.tbx_ValidarRemision.Control_Siguiente = Nothing
        Me.tbx_ValidarRemision.Filtrado = True
        Me.tbx_ValidarRemision.Location = New System.Drawing.Point(58, 10)
        Me.tbx_ValidarRemision.MaxLength = 15
        Me.tbx_ValidarRemision.Name = "tbx_ValidarRemision"
        Me.tbx_ValidarRemision.Size = New System.Drawing.Size(150, 20)
        Me.tbx_ValidarRemision.TabIndex = 9
        Me.tbx_ValidarRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Lsv_CVisita
        '
        Me.Lsv_CVisita.AllowColumnReorder = True
        Me.Lsv_CVisita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_CVisita.FullRowSelect = True
        Me.Lsv_CVisita.HideSelection = False
        Me.Lsv_CVisita.Location = New System.Drawing.Point(3, 21)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.Lsv_CVisita.Lvs = ListViewColumnSorter5
        Me.Lsv_CVisita.MultiSelect = False
        Me.Lsv_CVisita.Name = "Lsv_CVisita"
        Me.Lsv_CVisita.Row1 = 8
        Me.Lsv_CVisita.Row10 = 0
        Me.Lsv_CVisita.Row2 = 8
        Me.Lsv_CVisita.Row3 = 30
        Me.Lsv_CVisita.Row4 = 30
        Me.Lsv_CVisita.Row5 = 12
        Me.Lsv_CVisita.Row6 = 8
        Me.Lsv_CVisita.Row7 = 0
        Me.Lsv_CVisita.Row8 = 0
        Me.Lsv_CVisita.Row9 = 0
        Me.Lsv_CVisita.Size = New System.Drawing.Size(845, 408)
        Me.Lsv_CVisita.TabIndex = 0
        Me.Lsv_CVisita.UseCompatibleStateImageBehavior = False
        Me.Lsv_CVisita.View = System.Windows.Forms.View.Details
        '
        'Lsv_Pendientes
        '
        Me.Lsv_Pendientes.AllowColumnReorder = True
        Me.Lsv_Pendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Pendientes.FullRowSelect = True
        Me.Lsv_Pendientes.HideSelection = False
        Me.Lsv_Pendientes.Location = New System.Drawing.Point(3, 21)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.Lsv_Pendientes.Lvs = ListViewColumnSorter6
        Me.Lsv_Pendientes.MultiSelect = False
        Me.Lsv_Pendientes.Name = "Lsv_Pendientes"
        Me.Lsv_Pendientes.Row1 = 39
        Me.Lsv_Pendientes.Row10 = 0
        Me.Lsv_Pendientes.Row2 = 29
        Me.Lsv_Pendientes.Row3 = 29
        Me.Lsv_Pendientes.Row4 = 0
        Me.Lsv_Pendientes.Row5 = 0
        Me.Lsv_Pendientes.Row6 = 0
        Me.Lsv_Pendientes.Row7 = 0
        Me.Lsv_Pendientes.Row8 = 0
        Me.Lsv_Pendientes.Row9 = 0
        Me.Lsv_Pendientes.Size = New System.Drawing.Size(842, 441)
        Me.Lsv_Pendientes.TabIndex = 0
        Me.Lsv_Pendientes.UseCompatibleStateImageBehavior = False
        Me.Lsv_Pendientes.View = System.Windows.Forms.View.Details
        '
        'lsv_TodosD
        '
        Me.lsv_TodosD.AllowColumnReorder = True
        Me.lsv_TodosD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TodosD.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lsv_TodosD.FullRowSelect = True
        Me.lsv_TodosD.HideSelection = False
        Me.lsv_TodosD.Location = New System.Drawing.Point(3, 363)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_TodosD.Lvs = ListViewColumnSorter7
        Me.lsv_TodosD.MultiSelect = False
        Me.lsv_TodosD.Name = "lsv_TodosD"
        Me.lsv_TodosD.Row1 = 15
        Me.lsv_TodosD.Row10 = 0
        Me.lsv_TodosD.Row2 = 10
        Me.lsv_TodosD.Row3 = 10
        Me.lsv_TodosD.Row4 = 5
        Me.lsv_TodosD.Row5 = 5
        Me.lsv_TodosD.Row6 = 10
        Me.lsv_TodosD.Row7 = 20
        Me.lsv_TodosD.Row8 = 10
        Me.lsv_TodosD.Row9 = 10
        Me.lsv_TodosD.Size = New System.Drawing.Size(842, 99)
        Me.lsv_TodosD.TabIndex = 1
        Me.lsv_TodosD.UseCompatibleStateImageBehavior = False
        Me.lsv_TodosD.View = System.Windows.Forms.View.Details
        '
        'Lsv_Todos
        '
        Me.Lsv_Todos.AllowColumnReorder = True
        Me.Lsv_Todos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Todos.FullRowSelect = True
        Me.Lsv_Todos.HideSelection = False
        Me.Lsv_Todos.Location = New System.Drawing.Point(3, 22)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.Lsv_Todos.Lvs = ListViewColumnSorter8
        Me.Lsv_Todos.MultiSelect = False
        Me.Lsv_Todos.Name = "Lsv_Todos"
        Me.Lsv_Todos.Row1 = 39
        Me.Lsv_Todos.Row10 = 0
        Me.Lsv_Todos.Row2 = 29
        Me.Lsv_Todos.Row3 = 29
        Me.Lsv_Todos.Row4 = 0
        Me.Lsv_Todos.Row5 = 0
        Me.Lsv_Todos.Row6 = 0
        Me.Lsv_Todos.Row7 = 0
        Me.Lsv_Todos.Row8 = 0
        Me.Lsv_Todos.Row9 = 0
        Me.Lsv_Todos.Size = New System.Drawing.Size(842, 323)
        Me.Lsv_Todos.TabIndex = 0
        Me.Lsv_Todos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Todos.View = System.Windows.Forms.View.Details
        '
        'Lsv_Resumen
        '
        Me.Lsv_Resumen.AllowColumnReorder = True
        Me.Lsv_Resumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Resumen.FullRowSelect = True
        Me.Lsv_Resumen.HideSelection = False
        Me.Lsv_Resumen.Location = New System.Drawing.Point(3, 22)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.Lsv_Resumen.Lvs = ListViewColumnSorter9
        Me.Lsv_Resumen.MultiSelect = False
        Me.Lsv_Resumen.Name = "Lsv_Resumen"
        Me.Lsv_Resumen.Row1 = 20
        Me.Lsv_Resumen.Row10 = 0
        Me.Lsv_Resumen.Row2 = 10
        Me.Lsv_Resumen.Row3 = 10
        Me.Lsv_Resumen.Row4 = 10
        Me.Lsv_Resumen.Row5 = 0
        Me.Lsv_Resumen.Row6 = 0
        Me.Lsv_Resumen.Row7 = 0
        Me.Lsv_Resumen.Row8 = 0
        Me.Lsv_Resumen.Row9 = 0
        Me.Lsv_Resumen.Size = New System.Drawing.Size(846, 441)
        Me.Lsv_Resumen.TabIndex = 0
        Me.Lsv_Resumen.UseCompatibleStateImageBehavior = False
        Me.Lsv_Resumen.View = System.Windows.Forms.View.Details
        '
        'Lsv_Materiales
        '
        Me.Lsv_Materiales.AllowColumnReorder = True
        Me.Lsv_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Materiales.FullRowSelect = True
        Me.Lsv_Materiales.HideSelection = False
        Me.Lsv_Materiales.Location = New System.Drawing.Point(3, 22)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.Lsv_Materiales.Lvs = ListViewColumnSorter10
        Me.Lsv_Materiales.MultiSelect = False
        Me.Lsv_Materiales.Name = "Lsv_Materiales"
        Me.Lsv_Materiales.Row1 = 20
        Me.Lsv_Materiales.Row10 = 0
        Me.Lsv_Materiales.Row2 = 15
        Me.Lsv_Materiales.Row3 = 15
        Me.Lsv_Materiales.Row4 = 0
        Me.Lsv_Materiales.Row5 = 0
        Me.Lsv_Materiales.Row6 = 0
        Me.Lsv_Materiales.Row7 = 0
        Me.Lsv_Materiales.Row8 = 0
        Me.Lsv_Materiales.Row9 = 0
        Me.Lsv_Materiales.Size = New System.Drawing.Size(845, 408)
        Me.Lsv_Materiales.TabIndex = 0
        Me.Lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.Lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'tbx_EnvasesAtm
        '
        Me.tbx_EnvasesAtm.Control_Siguiente = Nothing
        Me.tbx_EnvasesAtm.Filtrado = True
        Me.tbx_EnvasesAtm.Location = New System.Drawing.Point(58, 10)
        Me.tbx_EnvasesAtm.MaxLength = 15
        Me.tbx_EnvasesAtm.Name = "tbx_EnvasesAtm"
        Me.tbx_EnvasesAtm.Size = New System.Drawing.Size(150, 20)
        Me.tbx_EnvasesAtm.TabIndex = 16
        Me.tbx_EnvasesAtm.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_envases
        '
        Me.lsv_envases.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_envases.FullRowSelect = True
        Me.lsv_envases.HideSelection = False
        Me.lsv_envases.Location = New System.Drawing.Point(523, 332)
        ListViewColumnSorter11.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter11.SortColumn = 0
        Me.lsv_envases.Lvs = ListViewColumnSorter11
        Me.lsv_envases.MultiSelect = False
        Me.lsv_envases.Name = "lsv_envases"
        Me.lsv_envases.Row1 = 30
        Me.lsv_envases.Row10 = 10
        Me.lsv_envases.Row2 = 40
        Me.lsv_envases.Row3 = 10
        Me.lsv_envases.Row4 = 10
        Me.lsv_envases.Row5 = 10
        Me.lsv_envases.Row6 = 10
        Me.lsv_envases.Row7 = 10
        Me.lsv_envases.Row8 = 10
        Me.lsv_envases.Row9 = 10
        Me.lsv_envases.Size = New System.Drawing.Size(325, 129)
        Me.lsv_envases.TabIndex = 14
        Me.lsv_envases.UseCompatibleStateImageBehavior = False
        Me.lsv_envases.View = System.Windows.Forms.View.Details
        '
        'tbx_Remision_Retiro
        '
        Me.tbx_Remision_Retiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Remision_Retiro.Control_Siguiente = Nothing
        Me.tbx_Remision_Retiro.Filtrado = True
        Me.tbx_Remision_Retiro.Location = New System.Drawing.Point(90, 304)
        Me.tbx_Remision_Retiro.MaxLength = 15
        Me.tbx_Remision_Retiro.Name = "tbx_Remision_Retiro"
        Me.tbx_Remision_Retiro.Size = New System.Drawing.Size(130, 20)
        Me.tbx_Remision_Retiro.TabIndex = 2
        Me.tbx_Remision_Retiro.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lsv_AtmsD
        '
        Me.lsv_AtmsD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_AtmsD.FullRowSelect = True
        Me.lsv_AtmsD.HideSelection = False
        Me.lsv_AtmsD.Location = New System.Drawing.Point(3, 332)
        ListViewColumnSorter12.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter12.SortColumn = 0
        Me.lsv_AtmsD.Lvs = ListViewColumnSorter12
        Me.lsv_AtmsD.MultiSelect = False
        Me.lsv_AtmsD.Name = "lsv_AtmsD"
        Me.lsv_AtmsD.Row1 = 10
        Me.lsv_AtmsD.Row10 = 0
        Me.lsv_AtmsD.Row2 = 10
        Me.lsv_AtmsD.Row3 = 10
        Me.lsv_AtmsD.Row4 = 10
        Me.lsv_AtmsD.Row5 = 0
        Me.lsv_AtmsD.Row6 = 0
        Me.lsv_AtmsD.Row7 = 0
        Me.lsv_AtmsD.Row8 = 0
        Me.lsv_AtmsD.Row9 = 0
        Me.lsv_AtmsD.Size = New System.Drawing.Size(514, 129)
        Me.lsv_AtmsD.TabIndex = 4
        Me.lsv_AtmsD.UseCompatibleStateImageBehavior = False
        Me.lsv_AtmsD.View = System.Windows.Forms.View.Details
        '
        'Lsv_Atms
        '
        Me.Lsv_Atms.AllowColumnReorder = True
        Me.Lsv_Atms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Atms.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Lsv_Atms.FullRowSelect = True
        Me.Lsv_Atms.HideSelection = False
        Me.Lsv_Atms.Location = New System.Drawing.Point(3, 36)
        ListViewColumnSorter13.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter13.SortColumn = 0
        Me.Lsv_Atms.Lvs = ListViewColumnSorter13
        Me.Lsv_Atms.MultiSelect = False
        Me.Lsv_Atms.Name = "Lsv_Atms"
        Me.Lsv_Atms.Row1 = 10
        Me.Lsv_Atms.Row10 = 0
        Me.Lsv_Atms.Row2 = 15
        Me.Lsv_Atms.Row3 = 20
        Me.Lsv_Atms.Row4 = 5
        Me.Lsv_Atms.Row5 = 5
        Me.Lsv_Atms.Row6 = 10
        Me.Lsv_Atms.Row7 = 10
        Me.Lsv_Atms.Row8 = 0
        Me.Lsv_Atms.Row9 = 0
        Me.Lsv_Atms.Size = New System.Drawing.Size(843, 260)
        Me.Lsv_Atms.TabIndex = 0
        Me.Lsv_Atms.UseCompatibleStateImageBehavior = False
        Me.Lsv_Atms.View = System.Windows.Forms.View.Details
        '
        'tbx_envasesf
        '
        Me.tbx_envasesf.Control_Siguiente = Nothing
        Me.tbx_envasesf.Filtrado = True
        Me.tbx_envasesf.Location = New System.Drawing.Point(58, 10)
        Me.tbx_envasesf.MaxLength = 15
        Me.tbx_envasesf.Name = "tbx_envasesf"
        Me.tbx_envasesf.Size = New System.Drawing.Size(150, 20)
        Me.tbx_envasesf.TabIndex = 18
        Me.tbx_envasesf.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_fallas
        '
        Me.lsv_fallas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_fallas.FullRowSelect = True
        Me.lsv_fallas.HideSelection = False
        Me.lsv_fallas.Location = New System.Drawing.Point(523, 332)
        ListViewColumnSorter14.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter14.SortColumn = 0
        Me.lsv_fallas.Lvs = ListViewColumnSorter14
        Me.lsv_fallas.MultiSelect = False
        Me.lsv_fallas.Name = "lsv_fallas"
        Me.lsv_fallas.Row1 = 30
        Me.lsv_fallas.Row10 = 10
        Me.lsv_fallas.Row2 = 40
        Me.lsv_fallas.Row3 = 10
        Me.lsv_fallas.Row4 = 10
        Me.lsv_fallas.Row5 = 10
        Me.lsv_fallas.Row6 = 10
        Me.lsv_fallas.Row7 = 10
        Me.lsv_fallas.Row8 = 10
        Me.lsv_fallas.Row9 = 10
        Me.lsv_fallas.Size = New System.Drawing.Size(325, 129)
        Me.lsv_fallas.TabIndex = 15
        Me.lsv_fallas.UseCompatibleStateImageBehavior = False
        Me.lsv_fallas.View = System.Windows.Forms.View.Details
        '
        'tbx_Remision_RetiroF
        '
        Me.tbx_Remision_RetiroF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Remision_RetiroF.Control_Siguiente = Nothing
        Me.tbx_Remision_RetiroF.Filtrado = True
        Me.tbx_Remision_RetiroF.Location = New System.Drawing.Point(90, 304)
        Me.tbx_Remision_RetiroF.MaxLength = 15
        Me.tbx_Remision_RetiroF.Name = "tbx_Remision_RetiroF"
        Me.tbx_Remision_RetiroF.Size = New System.Drawing.Size(129, 20)
        Me.tbx_Remision_RetiroF.TabIndex = 2
        Me.tbx_Remision_RetiroF.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lsv_AtmsFallasD
        '
        Me.lsv_AtmsFallasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_AtmsFallasD.FullRowSelect = True
        Me.lsv_AtmsFallasD.HideSelection = False
        Me.lsv_AtmsFallasD.Location = New System.Drawing.Point(3, 332)
        ListViewColumnSorter15.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter15.SortColumn = 0
        Me.lsv_AtmsFallasD.Lvs = ListViewColumnSorter15
        Me.lsv_AtmsFallasD.MultiSelect = False
        Me.lsv_AtmsFallasD.Name = "lsv_AtmsFallasD"
        Me.lsv_AtmsFallasD.Row1 = 10
        Me.lsv_AtmsFallasD.Row10 = 0
        Me.lsv_AtmsFallasD.Row2 = 10
        Me.lsv_AtmsFallasD.Row3 = 10
        Me.lsv_AtmsFallasD.Row4 = 10
        Me.lsv_AtmsFallasD.Row5 = 0
        Me.lsv_AtmsFallasD.Row6 = 0
        Me.lsv_AtmsFallasD.Row7 = 0
        Me.lsv_AtmsFallasD.Row8 = 0
        Me.lsv_AtmsFallasD.Row9 = 0
        Me.lsv_AtmsFallasD.Size = New System.Drawing.Size(514, 129)
        Me.lsv_AtmsFallasD.TabIndex = 4
        Me.lsv_AtmsFallasD.UseCompatibleStateImageBehavior = False
        Me.lsv_AtmsFallasD.View = System.Windows.Forms.View.Details
        '
        'lsv_AtmsFallas
        '
        Me.lsv_AtmsFallas.AllowColumnReorder = True
        Me.lsv_AtmsFallas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_AtmsFallas.FullRowSelect = True
        Me.lsv_AtmsFallas.HideSelection = False
        Me.lsv_AtmsFallas.Location = New System.Drawing.Point(3, 36)
        ListViewColumnSorter16.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter16.SortColumn = 0
        Me.lsv_AtmsFallas.Lvs = ListViewColumnSorter16
        Me.lsv_AtmsFallas.MultiSelect = False
        Me.lsv_AtmsFallas.Name = "lsv_AtmsFallas"
        Me.lsv_AtmsFallas.Row1 = 25
        Me.lsv_AtmsFallas.Row10 = 0
        Me.lsv_AtmsFallas.Row2 = 25
        Me.lsv_AtmsFallas.Row3 = 20
        Me.lsv_AtmsFallas.Row4 = 15
        Me.lsv_AtmsFallas.Row5 = 0
        Me.lsv_AtmsFallas.Row6 = 0
        Me.lsv_AtmsFallas.Row7 = 0
        Me.lsv_AtmsFallas.Row8 = 0
        Me.lsv_AtmsFallas.Row9 = 0
        Me.lsv_AtmsFallas.Size = New System.Drawing.Size(843, 260)
        Me.lsv_AtmsFallas.TabIndex = 0
        Me.lsv_AtmsFallas.UseCompatibleStateImageBehavior = False
        Me.lsv_AtmsFallas.View = System.Windows.Forms.View.Details
        '
        'VerRemisionToolStripMenuItem
        '
        Me.VerRemisionToolStripMenuItem.Name = "VerRemisionToolStripMenuItem"
        Me.VerRemisionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VerRemisionToolStripMenuItem.Text = "Ver Remision"
        '
        'frm_RecepcionRutasInternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 640)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.grp_Remisiones)
        Me.Controls.Add(Me.Tab_General)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_RecepcionRutasInternas"
        Me.Text = "Recepción Rutas Propias"
        Me.Tab_General.ResumeLayout(False)
        Me.Tab_Remisiones.ResumeLayout(False)
        Me.Tab_Remisiones.PerformLayout()
        Me.Tab_RemisionesM.ResumeLayout(False)
        Me.Tab_RemisionesM.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Tab_CVisita.ResumeLayout(False)
        Me.Tab_Pendientes.ResumeLayout(False)
        Me.Tab_Todos.ResumeLayout(False)
        Me.Tab_Todos.PerformLayout()
        Me.Tab_Resumen.ResumeLayout(False)
        Me.Tab_Materiales.ResumeLayout(False)
        Me.Tab_Atms.ResumeLayout(False)
        Me.Tab_Atms.PerformLayout()
        Me.Tab_AtmsFallas.ResumeLayout(False)
        Me.Tab_AtmsFallas.PerformLayout()
        Me.grp_Remisiones.ResumeLayout(False)
        Me.grp_Remisiones.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_General As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Remisiones As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Pendientes As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Resumen As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Materiales As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Todos As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Puntos As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_cuadreruta As System.Windows.Forms.Button
    Friend WithEvents btn_AgregaRemision As System.Windows.Forms.Button
    Friend WithEvents btn_GrabarServicio As System.Windows.Forms.Button
    Friend WithEvents grp_Remisiones As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveRuta As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Rutas As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents Btn_Validar As System.Windows.Forms.Button
    Friend WithEvents lsv_Remisiones As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Pendientes As Modulo_Recepcion.cp_Listview
    Friend WithEvents Tab_CVisita As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_CVisita As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Todos As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Resumen As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_Materiales As Modulo_Recepcion.cp_Listview
    Friend WithEvents Tab_Atms As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Atms As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_RBoveda As System.Windows.Forms.Button
    Friend WithEvents Btn_RBovedaAtms As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_RemisionRetiro As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision_Retiro As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lsv_AtmsD As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_TodosD As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_VerCV As System.Windows.Forms.Button
    Friend WithEvents Tab_AtmsFallas As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_RemisionesRet As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision_RetiroF As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lsv_AtmsFallasD As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_RBovedaAtmsF As System.Windows.Forms.Button
    Friend WithEvents lsv_AtmsFallas As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents Lbl_Remisiones As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosCV As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosP As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosT As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosRes As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosM As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosAtms As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosAtmsF As System.Windows.Forms.Label
    Friend WithEvents Tab_RemisionesM As System.Windows.Forms.TabPage
    Friend WithEvents lbl_PuntosyRemisiones As System.Windows.Forms.Label
    Friend WithEvents btn_ValidarRemision As System.Windows.Forms.Button
    Friend WithEvents btn_GrabarServicios As System.Windows.Forms.Button
    Friend WithEvents tbx_ValidarRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_RemisionValida As System.Windows.Forms.Label
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents lbl_PuntosyRemisionesV As System.Windows.Forms.Label
    Friend WithEvents btn_AgregarNuevaRemision As System.Windows.Forms.Button
    Friend WithEvents btn_StatusRutas As System.Windows.Forms.Button
    Friend WithEvents tbx_copy As System.Windows.Forms.TextBox
    Friend WithEvents lsv_tv As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_fallas As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_EnvasesAtm As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_envasesf As Modulo_Recepcion.cp_Textbox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarRemisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_envases As System.Windows.Forms.Label
    Friend WithEvents lsv_PuntosyRemisiones As Modulo_Recepcion.cp_Listview
    Friend WithEvents VerComentariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerRemisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
