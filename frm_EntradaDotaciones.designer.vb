<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EntradaDotaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EntradaDotaciones))
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Recibir = New System.Windows.Forms.Button()
        Me.gbx_Dotacion = New System.Windows.Forms.GroupBox()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.tbx_BovedaClve = New Modulo_Recepcion.cp_Textbox()
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Boveda = New System.Windows.Forms.Label()
        Me.lsv_Dotacion = New Modulo_Recepcion.cp_Listview()
        Me.gbx_DotacionD = New System.Windows.Forms.GroupBox()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.gbx_DotacionB = New System.Windows.Forms.GroupBox()
        Me.lsv_Envase = New Modulo_Recepcion.cp_Listview()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsv_DotacionD = New System.Windows.Forms.ListView()
        Me.gbx_Dotacion.SuspendLayout()
        Me.gbx_DotacionD.SuspendLayout()
        Me.gbx_DotacionB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'btn_Recibir
        '
        Me.btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Recibir.Enabled = False
        Me.btn_Recibir.Image = CType(resources.GetObject("btn_Recibir.Image"), System.Drawing.Image)
        Me.btn_Recibir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 0
        Me.btn_Recibir.Text = "&Recibir"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'gbx_Dotacion
        '
        Me.gbx_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Dotacion.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Dotacion.Controls.Add(Me.tbx_BovedaClve)
        Me.gbx_Dotacion.Controls.Add(Me.cmb_Boveda)
        Me.gbx_Dotacion.Controls.Add(Me.lbl_Boveda)
        Me.gbx_Dotacion.Controls.Add(Me.lsv_Dotacion)
        Me.gbx_Dotacion.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Dotacion.Name = "gbx_Dotacion"
        Me.gbx_Dotacion.Size = New System.Drawing.Size(769, 196)
        Me.gbx_Dotacion.TabIndex = 0
        Me.gbx_Dotacion.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(623, 21)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 11
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_BovedaClve
        '
        Me.tbx_BovedaClve.Control_Siguiente = Nothing
        Me.tbx_BovedaClve.Filtrado = True
        Me.tbx_BovedaClve.Location = New System.Drawing.Point(59, 15)
        Me.tbx_BovedaClve.MaxLength = 20
        Me.tbx_BovedaClve.Name = "tbx_BovedaClve"
        Me.tbx_BovedaClve.Size = New System.Drawing.Size(73, 20)
        Me.tbx_BovedaClve.TabIndex = 1
        Me.tbx_BovedaClve.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Nothing
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_BovedaClve
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(138, 15)
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
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(9, 18)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'lsv_Dotacion
        '
        Me.lsv_Dotacion.AllowColumnReorder = True
        Me.lsv_Dotacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotacion.FullRowSelect = True
        Me.lsv_Dotacion.HideSelection = False
        Me.lsv_Dotacion.Location = New System.Drawing.Point(6, 43)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Dotacion.Lvs = ListViewColumnSorter1
        Me.lsv_Dotacion.MultiSelect = False
        Me.lsv_Dotacion.Name = "lsv_Dotacion"
        Me.lsv_Dotacion.Row1 = 10
        Me.lsv_Dotacion.Row10 = 0
        Me.lsv_Dotacion.Row2 = 10
        Me.lsv_Dotacion.Row3 = 10
        Me.lsv_Dotacion.Row4 = 10
        Me.lsv_Dotacion.Row5 = 20
        Me.lsv_Dotacion.Row6 = 10
        Me.lsv_Dotacion.Row7 = 10
        Me.lsv_Dotacion.Row8 = 0
        Me.lsv_Dotacion.Row9 = 0
        Me.lsv_Dotacion.Size = New System.Drawing.Size(757, 142)
        Me.lsv_Dotacion.TabIndex = 3
        Me.lsv_Dotacion.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotacion.View = System.Windows.Forms.View.Details
        '
        'gbx_DotacionD
        '
        Me.gbx_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DotacionD.BackColor = System.Drawing.Color.Transparent
        Me.gbx_DotacionD.Controls.Add(Me.lbl_Buscar)
        Me.gbx_DotacionD.Controls.Add(Me.tbx_Buscar)
        Me.gbx_DotacionD.Controls.Add(Me.lsv_DotacionD)
        Me.gbx_DotacionD.Controls.Add(Me.btn_Buscar)
        Me.gbx_DotacionD.Location = New System.Drawing.Point(8, 203)
        Me.gbx_DotacionD.Name = "gbx_DotacionD"
        Me.gbx_DotacionD.Size = New System.Drawing.Size(769, 162)
        Me.gbx_DotacionD.TabIndex = 1
        Me.gbx_DotacionD.TabStop = False
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(10, 16)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(56, 13)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(394, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Enabled = False
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(456, 10)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(82, 25)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'gbx_DotacionB
        '
        Me.gbx_DotacionB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DotacionB.Controls.Add(Me.btn_Recibir)
        Me.gbx_DotacionB.Controls.Add(Me.btn_Cerrar)
        Me.gbx_DotacionB.Location = New System.Drawing.Point(8, 499)
        Me.gbx_DotacionB.Name = "gbx_DotacionB"
        Me.gbx_DotacionB.Size = New System.Drawing.Size(769, 50)
        Me.gbx_DotacionB.TabIndex = 2
        Me.gbx_DotacionB.TabStop = False
        '
        'lsv_Envase
        '
        Me.lsv_Envase.AllowColumnReorder = True
        Me.lsv_Envase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envase.FullRowSelect = True
        Me.lsv_Envase.HideSelection = False
        Me.lsv_Envase.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Envase.Lvs = ListViewColumnSorter2
        Me.lsv_Envase.MultiSelect = False
        Me.lsv_Envase.Name = "lsv_Envase"
        Me.lsv_Envase.Row1 = 10
        Me.lsv_Envase.Row10 = 0
        Me.lsv_Envase.Row2 = 10
        Me.lsv_Envase.Row3 = 10
        Me.lsv_Envase.Row4 = 10
        Me.lsv_Envase.Row5 = 20
        Me.lsv_Envase.Row6 = 10
        Me.lsv_Envase.Row7 = 10
        Me.lsv_Envase.Row8 = 0
        Me.lsv_Envase.Row9 = 0
        Me.lsv_Envase.Size = New System.Drawing.Size(757, 105)
        Me.lsv_Envase.TabIndex = 3
        Me.lsv_Envase.UseCompatibleStateImageBehavior = False
        Me.lsv_Envase.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lsv_Envase)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 130)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'lsv_DotacionD
        '
        Me.lsv_DotacionD.AllowColumnReorder = True
        Me.lsv_DotacionD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionD.FullRowSelect = True
        Me.lsv_DotacionD.HideSelection = False
        Me.lsv_DotacionD.Location = New System.Drawing.Point(6, 41)
        Me.lsv_DotacionD.MultiSelect = False
        Me.lsv_DotacionD.Name = "lsv_DotacionD"
        Me.lsv_DotacionD.Size = New System.Drawing.Size(757, 115)
        Me.lsv_DotacionD.TabIndex = 3
        Me.lsv_DotacionD.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionD.View = System.Windows.Forms.View.Details
        '
        'frm_EntradaDotaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbx_DotacionB)
        Me.Controls.Add(Me.gbx_Dotacion)
        Me.Controls.Add(Me.gbx_DotacionD)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EntradaDotaciones"
        Me.Text = "Entrada Dotaciones"
        Me.gbx_Dotacion.ResumeLayout(False)
        Me.gbx_Dotacion.PerformLayout()
        Me.gbx_DotacionD.ResumeLayout(False)
        Me.gbx_DotacionD.PerformLayout()
        Me.gbx_DotacionB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents gbx_Dotacion As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_BovedaClve As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents gbx_DotacionD As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Buscar As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents gbx_DotacionB As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Dotacion As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Envase As Modulo_Recepcion.cp_Listview
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_DotacionD As ListView
End Class
