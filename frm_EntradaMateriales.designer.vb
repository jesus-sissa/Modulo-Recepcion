<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EntradaMateriales
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
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EntradaMateriales))
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Recibir = New System.Windows.Forms.Button()
        Me.Gbx_Listas = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview()
        Me.gbx_DotacionD = New System.Windows.Forms.GroupBox()
        Me.lsv_VentasD = New Modulo_Recepcion.cp_Listview()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Lbl_Registros = New System.Windows.Forms.Label()
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam()
        Me.tbx_CveBoveda = New Modulo_Recepcion.cp_Textbox()
        Me.lbl_Boveda = New System.Windows.Forms.Label()
        Me.lsv_Ventas = New Modulo_Recepcion.cp_Listview()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Gbx_Listas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DotacionD.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
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
        Me.btn_Recibir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Recibir.Location = New System.Drawing.Point(6, 13)
        Me.btn_Recibir.Name = "btn_Recibir"
        Me.btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Recibir.TabIndex = 0
        Me.btn_Recibir.Text = "&Recibir"
        Me.btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Recibir.UseVisualStyleBackColor = True
        '
        'Gbx_Listas
        '
        Me.Gbx_Listas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listas.Controls.Add(Me.GroupBox1)
        Me.Gbx_Listas.Controls.Add(Me.gbx_DotacionD)
        Me.Gbx_Listas.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listas.Controls.Add(Me.cmb_Boveda)
        Me.Gbx_Listas.Controls.Add(Me.tbx_CveBoveda)
        Me.Gbx_Listas.Controls.Add(Me.lbl_Boveda)
        Me.Gbx_Listas.Controls.Add(Me.lsv_Ventas)
        Me.Gbx_Listas.Location = New System.Drawing.Point(9, 2)
        Me.Gbx_Listas.Name = "Gbx_Listas"
        Me.Gbx_Listas.Size = New System.Drawing.Size(767, 563)
        Me.Gbx_Listas.TabIndex = 0
        Me.Gbx_Listas.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lsv_Envases)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 130)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 10
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 10
        Me.lsv_Envases.Row5 = 20
        Me.lsv_Envases.Row6 = 10
        Me.lsv_Envases.Row7 = 10
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(738, 105)
        Me.lsv_Envases.TabIndex = 3
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'gbx_DotacionD
        '
        Me.gbx_DotacionD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_DotacionD.BackColor = System.Drawing.Color.Transparent
        Me.gbx_DotacionD.Controls.Add(Me.lsv_VentasD)
        Me.gbx_DotacionD.Controls.Add(Me.lbl_Buscar)
        Me.gbx_DotacionD.Controls.Add(Me.tbx_Buscar)
        Me.gbx_DotacionD.Controls.Add(Me.btn_Buscar)
        Me.gbx_DotacionD.Location = New System.Drawing.Point(6, 256)
        Me.gbx_DotacionD.Name = "gbx_DotacionD"
        Me.gbx_DotacionD.Size = New System.Drawing.Size(755, 162)
        Me.gbx_DotacionD.TabIndex = 20
        Me.gbx_DotacionD.TabStop = False
        '
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(6, 41)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter2
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Row1 = 15
        Me.lsv_VentasD.Row10 = 0
        Me.lsv_VentasD.Row2 = 30
        Me.lsv_VentasD.Row3 = 30
        Me.lsv_VentasD.Row4 = 0
        Me.lsv_VentasD.Row5 = 0
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(738, 115)
        Me.lsv_VentasD.TabIndex = 20
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
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
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(621, 17)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 11
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Nothing
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_CveBoveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(115, 15)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_BovedaMat_Get"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 2
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'tbx_CveBoveda
        '
        Me.tbx_CveBoveda.Control_Siguiente = Nothing
        Me.tbx_CveBoveda.Filtrado = True
        Me.tbx_CveBoveda.Location = New System.Drawing.Point(59, 15)
        Me.tbx_CveBoveda.MaxLength = 20
        Me.tbx_CveBoveda.Name = "tbx_CveBoveda"
        Me.tbx_CveBoveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveBoveda.TabIndex = 1
        Me.tbx_CveBoveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
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
        'lsv_Ventas
        '
        Me.lsv_Ventas.AllowColumnReorder = True
        Me.lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Ventas.FullRowSelect = True
        Me.lsv_Ventas.HideSelection = False
        Me.lsv_Ventas.Location = New System.Drawing.Point(12, 60)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Ventas.Lvs = ListViewColumnSorter3
        Me.lsv_Ventas.MultiSelect = False
        Me.lsv_Ventas.Name = "lsv_Ventas"
        Me.lsv_Ventas.Row1 = 20
        Me.lsv_Ventas.Row10 = 0
        Me.lsv_Ventas.Row2 = 10
        Me.lsv_Ventas.Row3 = 10
        Me.lsv_Ventas.Row4 = 10
        Me.lsv_Ventas.Row5 = 10
        Me.lsv_Ventas.Row6 = 0
        Me.lsv_Ventas.Row7 = 0
        Me.lsv_Ventas.Row8 = 0
        Me.lsv_Ventas.Row9 = 0
        Me.lsv_Ventas.Size = New System.Drawing.Size(738, 187)
        Me.lsv_Ventas.TabIndex = 3
        Me.lsv_Ventas.UseCompatibleStateImageBehavior = False
        Me.lsv_Ventas.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Recibir)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 571)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'frm_EntradaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 633)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EntradaMateriales"
        Me.Text = "Entrada Materiales a Bóveda"
        Me.Gbx_Listas.ResumeLayout(False)
        Me.Gbx_Listas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DotacionD.ResumeLayout(False)
        Me.gbx_DotacionD.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Ventas As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listas As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveBoveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_DotacionD As GroupBox
    Friend WithEvents lbl_Buscar As Label
    Friend WithEvents tbx_Buscar As cp_Textbox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents lsv_VentasD As cp_Listview
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lsv_Envases As cp_Listview
End Class
