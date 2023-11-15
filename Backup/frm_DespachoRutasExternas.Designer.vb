<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DespachoRutasExternas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DespachoRutasExternas))
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.cmb_Cias = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_Cias = New System.Windows.Forms.Label
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.Lsv_BovedaT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Boveda = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Despachar = New System.Windows.Forms.Button
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Cias)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Cias)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(765, 45)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'cmb_Cias
        '
        Me.cmb_Cias.Clave = Nothing
        Me.cmb_Cias.Control_Siguiente = Nothing
        Me.cmb_Cias.DisplayMember = "Alias"
        Me.cmb_Cias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cias.Empresa = False
        Me.cmb_Cias.Filtro = Nothing
        Me.cmb_Cias.FormattingEnabled = True
        Me.cmb_Cias.Location = New System.Drawing.Point(96, 15)
        Me.cmb_Cias.MaxDropDownItems = 20
        Me.cmb_Cias.Name = "cmb_Cias"
        Me.cmb_Cias.Pista = False
        Me.cmb_Cias.Size = New System.Drawing.Size(236, 21)
        Me.cmb_Cias.StoredProcedure = "Cat_Cias_GetNoPropia"
        Me.cmb_Cias.Sucursal = False
        Me.cmb_Cias.TabIndex = 1
        Me.cmb_Cias.Tipo = 0
        Me.cmb_Cias.ValueMember = "Id_Cia"
        '
        'Lbl_Cias
        '
        Me.Lbl_Cias.AutoSize = True
        Me.Lbl_Cias.Location = New System.Drawing.Point(6, 18)
        Me.Lbl_Cias.Name = "Lbl_Cias"
        Me.Lbl_Cias.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_Cias.TabIndex = 0
        Me.Lbl_Cias.Text = "Cia. de Traslado"
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_BovedaT)
        Me.Gbx_Listado.Controls.Add(Me.Lsv_Boveda)
        Me.Gbx_Listado.Location = New System.Drawing.Point(9, 53)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(765, 440)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(619, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 7
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_BovedaT
        '
        Me.Lsv_BovedaT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_BovedaT.FullRowSelect = True
        Me.Lsv_BovedaT.HideSelection = False
        Me.Lsv_BovedaT.Location = New System.Drawing.Point(6, 347)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_BovedaT.Lvs = ListViewColumnSorter1
        Me.Lsv_BovedaT.MultiSelect = False
        Me.Lsv_BovedaT.Name = "Lsv_BovedaT"
        Me.Lsv_BovedaT.Row1 = 10
        Me.Lsv_BovedaT.Row10 = 10
        Me.Lsv_BovedaT.Row2 = 10
        Me.Lsv_BovedaT.Row3 = 10
        Me.Lsv_BovedaT.Row4 = 10
        Me.Lsv_BovedaT.Row5 = 10
        Me.Lsv_BovedaT.Row6 = 10
        Me.Lsv_BovedaT.Row7 = 10
        Me.Lsv_BovedaT.Row8 = 10
        Me.Lsv_BovedaT.Row9 = 10
        Me.Lsv_BovedaT.Size = New System.Drawing.Size(753, 87)
        Me.Lsv_BovedaT.TabIndex = 1
        Me.Lsv_BovedaT.UseCompatibleStateImageBehavior = False
        Me.Lsv_BovedaT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Boveda
        '
        Me.Lsv_Boveda.AllowColumnReorder = True
        Me.Lsv_Boveda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Boveda.FullRowSelect = True
        Me.Lsv_Boveda.HideSelection = False
        Me.Lsv_Boveda.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_Boveda.Lvs = ListViewColumnSorter2
        Me.Lsv_Boveda.MultiSelect = False
        Me.Lsv_Boveda.Name = "Lsv_Boveda"
        Me.Lsv_Boveda.Row1 = 10
        Me.Lsv_Boveda.Row10 = 0
        Me.Lsv_Boveda.Row2 = 20
        Me.Lsv_Boveda.Row3 = 20
        Me.Lsv_Boveda.Row4 = 20
        Me.Lsv_Boveda.Row5 = 15
        Me.Lsv_Boveda.Row6 = 0
        Me.Lsv_Boveda.Row7 = 0
        Me.Lsv_Boveda.Row8 = 0
        Me.Lsv_Boveda.Row9 = 0
        Me.Lsv_Boveda.Size = New System.Drawing.Size(753, 307)
        Me.Lsv_Boveda.TabIndex = 0
        Me.Lsv_Boveda.UseCompatibleStateImageBehavior = False
        Me.Lsv_Boveda.View = System.Windows.Forms.View.Details
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Despachar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(765, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(619, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Despachar
        '
        Me.Btn_Despachar.Enabled = False
        Me.Btn_Despachar.Image = CType(resources.GetObject("Btn_Despachar.Image"), System.Drawing.Image)
        Me.Btn_Despachar.Location = New System.Drawing.Point(6, 13)
        Me.Btn_Despachar.Name = "Btn_Despachar"
        Me.Btn_Despachar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Despachar.TabIndex = 0
        Me.Btn_Despachar.Text = "&Despachar"
        Me.Btn_Despachar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Despachar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Despachar.UseVisualStyleBackColor = True
        '
        'frm_DespachoRutasExternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DespachoRutasExternas"
        Me.Text = "Despacho Proveedores"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Cias As System.Windows.Forms.Label
    Friend WithEvents Lsv_Boveda As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_Despachar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Lsv_BovedaT As Modulo_Recepcion.cp_Listview
    Friend WithEvents cmb_Cias As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
