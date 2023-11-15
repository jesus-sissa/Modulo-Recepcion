<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EntradaServiciosReg
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
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.lbl_registrosPro = New System.Windows.Forms.Label
        Me.lsv_serviciosProD = New Modulo_Recepcion.cp_Listview
        Me.lsv_ServiciosPro = New Modulo_Recepcion.cp_Listview
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Actualizar = New System.Windows.Forms.Button
        Me.btn_Recibir = New System.Windows.Forms.Button
        Me.tab_ServiciosRegresados = New System.Windows.Forms.TabControl
        Me.tab_Proceso = New System.Windows.Forms.TabPage
        Me.tab_Morralla = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_registrosMor = New System.Windows.Forms.Label
        Me.lsv_serviciosMorD = New Modulo_Recepcion.cp_Listview
        Me.lsv_serviciosMor = New Modulo_Recepcion.cp_Listview
        Me.gbx_serviciosRegresados = New System.Windows.Forms.GroupBox
        Me.gbx_boveda = New System.Windows.Forms.GroupBox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.Gbx_Listado.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.tab_ServiciosRegresados.SuspendLayout()
        Me.tab_Proceso.SuspendLayout()
        Me.tab_Morralla.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_serviciosRegresados.SuspendLayout()
        Me.gbx_boveda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.lbl_registrosPro)
        Me.Gbx_Listado.Controls.Add(Me.lsv_serviciosProD)
        Me.Gbx_Listado.Controls.Add(Me.lsv_ServiciosPro)
        Me.Gbx_Listado.Location = New System.Drawing.Point(2, 6)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(744, 389)
        Me.Gbx_Listado.TabIndex = 0
        Me.Gbx_Listado.TabStop = False
        '
        'lbl_registrosPro
        '
        Me.lbl_registrosPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_registrosPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registrosPro.Location = New System.Drawing.Point(602, 11)
        Me.lbl_registrosPro.Name = "lbl_registrosPro"
        Me.lbl_registrosPro.Size = New System.Drawing.Size(140, 15)
        Me.lbl_registrosPro.TabIndex = 1
        Me.lbl_registrosPro.Text = "Registros: 0"
        Me.lbl_registrosPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_serviciosProD
        '
        Me.lsv_serviciosProD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_serviciosProD.FullRowSelect = True
        Me.lsv_serviciosProD.HideSelection = False
        Me.lsv_serviciosProD.Location = New System.Drawing.Point(6, 285)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_serviciosProD.Lvs = ListViewColumnSorter1
        Me.lsv_serviciosProD.MultiSelect = False
        Me.lsv_serviciosProD.Name = "lsv_serviciosProD"
        Me.lsv_serviciosProD.Row1 = 10
        Me.lsv_serviciosProD.Row10 = 0
        Me.lsv_serviciosProD.Row2 = 20
        Me.lsv_serviciosProD.Row3 = 10
        Me.lsv_serviciosProD.Row4 = 10
        Me.lsv_serviciosProD.Row5 = 10
        Me.lsv_serviciosProD.Row6 = 0
        Me.lsv_serviciosProD.Row7 = 0
        Me.lsv_serviciosProD.Row8 = 0
        Me.lsv_serviciosProD.Row9 = 0
        Me.lsv_serviciosProD.Size = New System.Drawing.Size(732, 98)
        Me.lsv_serviciosProD.TabIndex = 2
        Me.lsv_serviciosProD.TabStop = False
        Me.lsv_serviciosProD.UseCompatibleStateImageBehavior = False
        Me.lsv_serviciosProD.View = System.Windows.Forms.View.Details
        '
        'lsv_ServiciosPro
        '
        Me.lsv_ServiciosPro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ServiciosPro.CheckBoxes = True
        Me.lsv_ServiciosPro.FullRowSelect = True
        Me.lsv_ServiciosPro.HideSelection = False
        Me.lsv_ServiciosPro.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_ServiciosPro.Lvs = ListViewColumnSorter2
        Me.lsv_ServiciosPro.MultiSelect = False
        Me.lsv_ServiciosPro.Name = "lsv_ServiciosPro"
        Me.lsv_ServiciosPro.Row1 = 8
        Me.lsv_ServiciosPro.Row10 = 0
        Me.lsv_ServiciosPro.Row2 = 15
        Me.lsv_ServiciosPro.Row3 = 10
        Me.lsv_ServiciosPro.Row4 = 10
        Me.lsv_ServiciosPro.Row5 = 10
        Me.lsv_ServiciosPro.Row6 = 40
        Me.lsv_ServiciosPro.Row7 = 0
        Me.lsv_ServiciosPro.Row8 = 0
        Me.lsv_ServiciosPro.Row9 = 0
        Me.lsv_ServiciosPro.Size = New System.Drawing.Size(732, 250)
        Me.lsv_ServiciosPro.TabIndex = 0
        Me.lsv_ServiciosPro.UseCompatibleStateImageBehavior = False
        Me.lsv_ServiciosPro.View = System.Windows.Forms.View.Details
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(8, 18)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Actualizar)
        Me.gbx_Botones.Controls.Add(Me.btn_Recibir)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(775, 51)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(629, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Actualizar.Image = Global.Modulo_Recepcion.My.Resources.Resources.agt_reload
        Me.btn_Actualizar.Location = New System.Drawing.Point(152, 13)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Actualizar.TabIndex = 1
        Me.btn_Actualizar.Text = "&Actualizar"
        Me.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'btn_Recibir
        '
        Me.btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibir.Enabled = False
        Me.btn_Recibir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Money_Vault_32
        Me.btn_Recibir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 0
        Me.btn_Recibir.Text = "&Recibir"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'tab_ServiciosRegresados
        '
        Me.tab_ServiciosRegresados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_ServiciosRegresados.Controls.Add(Me.tab_Proceso)
        Me.tab_ServiciosRegresados.Controls.Add(Me.tab_Morralla)
        Me.tab_ServiciosRegresados.Location = New System.Drawing.Point(6, 19)
        Me.tab_ServiciosRegresados.Name = "tab_ServiciosRegresados"
        Me.tab_ServiciosRegresados.SelectedIndex = 0
        Me.tab_ServiciosRegresados.Size = New System.Drawing.Size(760, 427)
        Me.tab_ServiciosRegresados.TabIndex = 0
        '
        'tab_Proceso
        '
        Me.tab_Proceso.Controls.Add(Me.Gbx_Listado)
        Me.tab_Proceso.Location = New System.Drawing.Point(4, 22)
        Me.tab_Proceso.Name = "tab_Proceso"
        Me.tab_Proceso.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Proceso.Size = New System.Drawing.Size(752, 401)
        Me.tab_Proceso.TabIndex = 0
        Me.tab_Proceso.Text = "Proceso"
        Me.tab_Proceso.UseVisualStyleBackColor = True
        '
        'tab_Morralla
        '
        Me.tab_Morralla.Controls.Add(Me.GroupBox1)
        Me.tab_Morralla.Location = New System.Drawing.Point(4, 22)
        Me.tab_Morralla.Name = "tab_Morralla"
        Me.tab_Morralla.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Morralla.Size = New System.Drawing.Size(752, 401)
        Me.tab_Morralla.TabIndex = 1
        Me.tab_Morralla.Text = "Morralla"
        Me.tab_Morralla.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_registrosMor)
        Me.GroupBox1.Controls.Add(Me.lsv_serviciosMorD)
        Me.GroupBox1.Controls.Add(Me.lsv_serviciosMor)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 389)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbl_registrosMor
        '
        Me.lbl_registrosMor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_registrosMor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registrosMor.Location = New System.Drawing.Point(599, 11)
        Me.lbl_registrosMor.Name = "lbl_registrosMor"
        Me.lbl_registrosMor.Size = New System.Drawing.Size(140, 15)
        Me.lbl_registrosMor.TabIndex = 12
        Me.lbl_registrosMor.Text = "Registros: 0"
        Me.lbl_registrosMor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_serviciosMorD
        '
        Me.lsv_serviciosMorD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_serviciosMorD.FullRowSelect = True
        Me.lsv_serviciosMorD.HideSelection = False
        Me.lsv_serviciosMorD.Location = New System.Drawing.Point(6, 285)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_serviciosMorD.Lvs = ListViewColumnSorter3
        Me.lsv_serviciosMorD.MultiSelect = False
        Me.lsv_serviciosMorD.Name = "lsv_serviciosMorD"
        Me.lsv_serviciosMorD.Row1 = 10
        Me.lsv_serviciosMorD.Row10 = 0
        Me.lsv_serviciosMorD.Row2 = 20
        Me.lsv_serviciosMorD.Row3 = 10
        Me.lsv_serviciosMorD.Row4 = 10
        Me.lsv_serviciosMorD.Row5 = 10
        Me.lsv_serviciosMorD.Row6 = 0
        Me.lsv_serviciosMorD.Row7 = 0
        Me.lsv_serviciosMorD.Row8 = 0
        Me.lsv_serviciosMorD.Row9 = 0
        Me.lsv_serviciosMorD.Size = New System.Drawing.Size(731, 98)
        Me.lsv_serviciosMorD.TabIndex = 5
        Me.lsv_serviciosMorD.TabStop = False
        Me.lsv_serviciosMorD.UseCompatibleStateImageBehavior = False
        Me.lsv_serviciosMorD.View = System.Windows.Forms.View.Details
        '
        'lsv_serviciosMor
        '
        Me.lsv_serviciosMor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_serviciosMor.CheckBoxes = True
        Me.lsv_serviciosMor.FullRowSelect = True
        Me.lsv_serviciosMor.HideSelection = False
        Me.lsv_serviciosMor.Location = New System.Drawing.Point(6, 29)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_serviciosMor.Lvs = ListViewColumnSorter4
        Me.lsv_serviciosMor.MultiSelect = False
        Me.lsv_serviciosMor.Name = "lsv_serviciosMor"
        Me.lsv_serviciosMor.Row1 = 8
        Me.lsv_serviciosMor.Row10 = 0
        Me.lsv_serviciosMor.Row2 = 15
        Me.lsv_serviciosMor.Row3 = 10
        Me.lsv_serviciosMor.Row4 = 10
        Me.lsv_serviciosMor.Row5 = 10
        Me.lsv_serviciosMor.Row6 = 40
        Me.lsv_serviciosMor.Row7 = 0
        Me.lsv_serviciosMor.Row8 = 0
        Me.lsv_serviciosMor.Row9 = 0
        Me.lsv_serviciosMor.Size = New System.Drawing.Size(731, 250)
        Me.lsv_serviciosMor.TabIndex = 3
        Me.lsv_serviciosMor.UseCompatibleStateImageBehavior = False
        Me.lsv_serviciosMor.View = System.Windows.Forms.View.Details
        '
        'gbx_serviciosRegresados
        '
        Me.gbx_serviciosRegresados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_serviciosRegresados.Controls.Add(Me.tab_ServiciosRegresados)
        Me.gbx_serviciosRegresados.Location = New System.Drawing.Point(5, 53)
        Me.gbx_serviciosRegresados.Name = "gbx_serviciosRegresados"
        Me.gbx_serviciosRegresados.Size = New System.Drawing.Size(775, 452)
        Me.gbx_serviciosRegresados.TabIndex = 1
        Me.gbx_serviciosRegresados.TabStop = False
        '
        'gbx_boveda
        '
        Me.gbx_boveda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_boveda.Controls.Add(Me.cmb_Boveda)
        Me.gbx_boveda.Controls.Add(Me.lbl_Boveda)
        Me.gbx_boveda.Controls.Add(Me.tbx_Cve_Boveda)
        Me.gbx_boveda.Location = New System.Drawing.Point(5, 3)
        Me.gbx_boveda.Name = "gbx_boveda"
        Me.gbx_boveda.Size = New System.Drawing.Size(775, 47)
        Me.gbx_boveda.TabIndex = 0
        Me.gbx_boveda.TabStop = False
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
        Me.cmb_Boveda.Location = New System.Drawing.Point(114, 15)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 2
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(58, 15)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 1
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_EntradaServiciosReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_boveda)
        Me.Controls.Add(Me.gbx_serviciosRegresados)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EntradaServiciosReg"
        Me.Text = "Servicios Regresados"
        Me.Gbx_Listado.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.tab_ServiciosRegresados.ResumeLayout(False)
        Me.tab_Proceso.ResumeLayout(False)
        Me.tab_Morralla.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_serviciosRegresados.ResumeLayout(False)
        Me.gbx_boveda.ResumeLayout(False)
        Me.gbx_boveda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lsv_serviciosProD As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_ServiciosPro As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents lbl_registrosPro As System.Windows.Forms.Label
    Friend WithEvents tab_ServiciosRegresados As System.Windows.Forms.TabControl
    Friend WithEvents tab_Proceso As System.Windows.Forms.TabPage
    Friend WithEvents tab_Morralla As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_registrosMor As System.Windows.Forms.Label
    Friend WithEvents lsv_serviciosMorD As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_serviciosMor As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_serviciosRegresados As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_boveda As System.Windows.Forms.GroupBox
End Class
