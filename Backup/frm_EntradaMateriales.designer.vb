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
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Recibir = New System.Windows.Forms.Button
        Me.Gbx_Listas = New System.Windows.Forms.GroupBox
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveBoveda = New Modulo_Recepcion.cp_Textbox
        Me.lsv_VentasD = New Modulo_Recepcion.cp_Listview
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.lsv_VentasT = New Modulo_Recepcion.cp_Listview
        Me.lsv_Ventas = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Gbx_Listas.SuspendLayout()
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
        Me.Gbx_Listas.Controls.Add(Me.lsv_Envases)
        Me.Gbx_Listas.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listas.Controls.Add(Me.cmb_Boveda)
        Me.Gbx_Listas.Controls.Add(Me.tbx_CveBoveda)
        Me.Gbx_Listas.Controls.Add(Me.lsv_VentasD)
        Me.Gbx_Listas.Controls.Add(Me.lbl_Boveda)
        Me.Gbx_Listas.Controls.Add(Me.lsv_VentasT)
        Me.Gbx_Listas.Controls.Add(Me.lsv_Ventas)
        Me.Gbx_Listas.Location = New System.Drawing.Point(9, 2)
        Me.Gbx_Listas.Name = "Gbx_Listas"
        Me.Gbx_Listas.Size = New System.Drawing.Size(767, 491)
        Me.Gbx_Listas.TabIndex = 0
        Me.Gbx_Listas.TabStop = False
        '
        'lsv_Envases
        '
        Me.lsv_Envases.AllowColumnReorder = True
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 387)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 10
        Me.lsv_Envases.Row10 = 10
        Me.lsv_Envases.Row2 = 10
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 30
        Me.lsv_Envases.Row5 = 10
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(755, 98)
        Me.lsv_Envases.TabIndex = 19
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
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
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
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
        'lsv_VentasD
        '
        Me.lsv_VentasD.AllowColumnReorder = True
        Me.lsv_VentasD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasD.FullRowSelect = True
        Me.lsv_VentasD.HideSelection = False
        Me.lsv_VentasD.Location = New System.Drawing.Point(6, 284)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_VentasD.Lvs = ListViewColumnSorter2
        Me.lsv_VentasD.MultiSelect = False
        Me.lsv_VentasD.Name = "lsv_VentasD"
        Me.lsv_VentasD.Row1 = 10
        Me.lsv_VentasD.Row10 = 10
        Me.lsv_VentasD.Row2 = 10
        Me.lsv_VentasD.Row3 = 10
        Me.lsv_VentasD.Row4 = 30
        Me.lsv_VentasD.Row5 = 10
        Me.lsv_VentasD.Row6 = 0
        Me.lsv_VentasD.Row7 = 0
        Me.lsv_VentasD.Row8 = 0
        Me.lsv_VentasD.Row9 = 0
        Me.lsv_VentasD.Size = New System.Drawing.Size(755, 98)
        Me.lsv_VentasD.TabIndex = 5
        Me.lsv_VentasD.TabStop = False
        Me.lsv_VentasD.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasD.View = System.Windows.Forms.View.Details
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
        'lsv_VentasT
        '
        Me.lsv_VentasT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VentasT.FullRowSelect = True
        Me.lsv_VentasT.HideSelection = False
        Me.lsv_VentasT.Location = New System.Drawing.Point(6, 196)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_VentasT.Lvs = ListViewColumnSorter3
        Me.lsv_VentasT.MultiSelect = False
        Me.lsv_VentasT.Name = "lsv_VentasT"
        Me.lsv_VentasT.Row1 = 10
        Me.lsv_VentasT.Row10 = 10
        Me.lsv_VentasT.Row2 = 10
        Me.lsv_VentasT.Row3 = 10
        Me.lsv_VentasT.Row4 = 10
        Me.lsv_VentasT.Row5 = 10
        Me.lsv_VentasT.Row6 = 10
        Me.lsv_VentasT.Row7 = 10
        Me.lsv_VentasT.Row8 = 10
        Me.lsv_VentasT.Row9 = 10
        Me.lsv_VentasT.Size = New System.Drawing.Size(755, 84)
        Me.lsv_VentasT.TabIndex = 4
        Me.lsv_VentasT.UseCompatibleStateImageBehavior = False
        Me.lsv_VentasT.View = System.Windows.Forms.View.Details
        '
        'lsv_Ventas
        '
        Me.lsv_Ventas.AllowColumnReorder = True
        Me.lsv_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Ventas.FullRowSelect = True
        Me.lsv_Ventas.HideSelection = False
        Me.lsv_Ventas.Location = New System.Drawing.Point(6, 60)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Ventas.Lvs = ListViewColumnSorter4
        Me.lsv_Ventas.MultiSelect = False
        Me.lsv_Ventas.Name = "lsv_Ventas"
        Me.lsv_Ventas.Row1 = 20
        Me.lsv_Ventas.Row10 = 0
        Me.lsv_Ventas.Row2 = 10
        Me.lsv_Ventas.Row3 = 10
        Me.lsv_Ventas.Row4 = 10
        Me.lsv_Ventas.Row5 = 10
        Me.lsv_Ventas.Row6 = 10
        Me.lsv_Ventas.Row7 = 0
        Me.lsv_Ventas.Row8 = 0
        Me.lsv_Ventas.Row9 = 0
        Me.lsv_Ventas.Size = New System.Drawing.Size(755, 132)
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
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(767, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'frm_EntradaMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listas)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EntradaMateriales"
        Me.Text = "Entrada Materiales a Bóveda"
        Me.Gbx_Listas.ResumeLayout(False)
        Me.Gbx_Listas.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Ventas As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents lsv_VentasD As Modulo_Recepcion.cp_Listview
    Friend WithEvents Gbx_Listas As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CveBoveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_VentasT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
End Class
