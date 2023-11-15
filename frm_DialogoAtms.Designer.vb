<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DialogoAtms
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
        Me.GpoDatos = New System.Windows.Forms.GroupBox
        Me.Btn_Agregar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.grbEnvases = New System.Windows.Forms.GroupBox
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_TipoEnvase = New System.Windows.Forms.Label
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.dgDinero = New System.Windows.Forms.DataGridView
        Me.Gbx_NRemision = New System.Windows.Forms.GroupBox
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Remision = New System.Windows.Forms.GroupBox
        Me.lbl_TRemision = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.tbx_TotalRemision = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Envases = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Numero = New Modulo_Recepcion.cp_Textbox
        Me.cmb_TipoEnvase = New Modulo_Recepcion.cp_cmb_Simple
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.GpoDatos.SuspendLayout()
        Me.grbEnvases.SuspendLayout()
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_NRemision.SuspendLayout()
        Me.Gbx_Remision.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpoDatos
        '
        Me.GpoDatos.Controls.Add(Me.tbx_Envases)
        Me.GpoDatos.Controls.Add(Me.Label2)
        Me.GpoDatos.Controls.Add(Me.grbEnvases)
        Me.GpoDatos.Location = New System.Drawing.Point(9, 259)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(497, 243)
        Me.GpoDatos.TabIndex = 3
        Me.GpoDatos.TabStop = False
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Agregar
        Me.Btn_Agregar.Location = New System.Drawing.Point(6, 118)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "&Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Envases sin Número:"
        '
        'grbEnvases
        '
        Me.grbEnvases.Controls.Add(Me.btn_Eliminar)
        Me.grbEnvases.Controls.Add(Me.lsv_Envases)
        Me.grbEnvases.Controls.Add(Me.Btn_Agregar)
        Me.grbEnvases.Controls.Add(Me.tbx_Numero)
        Me.grbEnvases.Controls.Add(Me.cmb_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_TipoEnvase)
        Me.grbEnvases.Controls.Add(Me.lbl_numero)
        Me.grbEnvases.Location = New System.Drawing.Point(6, 19)
        Me.grbEnvases.Name = "grbEnvases"
        Me.grbEnvases.Size = New System.Drawing.Size(485, 195)
        Me.grbEnvases.TabIndex = 0
        Me.grbEnvases.TabStop = False
        Me.grbEnvases.Text = "Envases"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(6, 154)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 5
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
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
        'dgDinero
        '
        Me.dgDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDinero.Location = New System.Drawing.Point(9, 48)
        Me.dgDinero.Name = "dgDinero"
        Me.dgDinero.Size = New System.Drawing.Size(497, 156)
        Me.dgDinero.TabIndex = 1
        '
        'Gbx_NRemision
        '
        Me.Gbx_NRemision.Controls.Add(Me.tbx_Remision)
        Me.Gbx_NRemision.Controls.Add(Me.lbl_Remision)
        Me.Gbx_NRemision.Location = New System.Drawing.Point(10, 3)
        Me.Gbx_NRemision.Name = "Gbx_NRemision"
        Me.Gbx_NRemision.Size = New System.Drawing.Size(496, 39)
        Me.Gbx_NRemision.TabIndex = 0
        Me.Gbx_NRemision.TabStop = False
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(105, 13)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Número de Remisión"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(353, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_Remision
        '
        Me.Gbx_Remision.Controls.Add(Me.lbl_TRemision)
        Me.Gbx_Remision.Controls.Add(Me.tbx_TotalRemision)
        Me.Gbx_Remision.Location = New System.Drawing.Point(9, 210)
        Me.Gbx_Remision.Name = "Gbx_Remision"
        Me.Gbx_Remision.Size = New System.Drawing.Size(497, 44)
        Me.Gbx_Remision.TabIndex = 2
        Me.Gbx_Remision.TabStop = False
        '
        'lbl_TRemision
        '
        Me.lbl_TRemision.AutoSize = True
        Me.lbl_TRemision.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TRemision.Location = New System.Drawing.Point(187, 18)
        Me.lbl_TRemision.Name = "lbl_TRemision"
        Me.lbl_TRemision.Size = New System.Drawing.Size(101, 13)
        Me.lbl_TRemision.TabIndex = 0
        Me.lbl_TRemision.Text = "Tota de la Remisión"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 509)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(496, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'tbx_TotalRemision
        '
        Me.tbx_TotalRemision.Control_Siguiente = Nothing
        Me.tbx_TotalRemision.Enabled = False
        Me.tbx_TotalRemision.Filtrado = True
        Me.tbx_TotalRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TotalRemision.Location = New System.Drawing.Point(294, 15)
        Me.tbx_TotalRemision.MaxLength = 10
        Me.tbx_TotalRemision.Name = "tbx_TotalRemision"
        Me.tbx_TotalRemision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_TotalRemision.Size = New System.Drawing.Size(187, 20)
        Me.tbx_TotalRemision.TabIndex = 1
        Me.tbx_TotalRemision.TabStop = False
        Me.tbx_TotalRemision.Text = "0"
        Me.tbx_TotalRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = False
        Me.tbx_Remision.Location = New System.Drawing.Point(117, 13)
        Me.tbx_Remision.MaxLength = 10
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Remision.TabIndex = 1
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Envases
        '
        Me.tbx_Envases.Control_Siguiente = Me.tbx_Numero
        Me.tbx_Envases.Filtrado = True
        Me.tbx_Envases.Location = New System.Drawing.Point(439, 219)
        Me.tbx_Envases.MaxLength = 4
        Me.tbx_Envases.Name = "tbx_Envases"
        Me.tbx_Envases.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbx_Envases.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Envases.TabIndex = 2
        Me.tbx_Envases.Text = "0"
        Me.tbx_Envases.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Me.cmb_TipoEnvase
        Me.tbx_Numero.Filtrado = False
        Me.tbx_Numero.Location = New System.Drawing.Point(6, 35)
        Me.tbx_Numero.MaxLength = 15
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(140, 20)
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
        Me.cmb_TipoEnvase.Size = New System.Drawing.Size(140, 21)
        Me.cmb_TipoEnvase.StoredProcedure = "CAT_TipoEnvase_GET"
        Me.cmb_TipoEnvase.Sucursal = False
        Me.cmb_TipoEnvase.TabIndex = 3
        Me.cmb_TipoEnvase.ValueMember = "Id_TipoE"
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
        Me.lsv_Envases.Row10 = 10
        Me.lsv_Envases.Row2 = 50
        Me.lsv_Envases.Row3 = 10
        Me.lsv_Envases.Row4 = 10
        Me.lsv_Envases.Row5 = 10
        Me.lsv_Envases.Row6 = 10
        Me.lsv_Envases.Row7 = 10
        Me.lsv_Envases.Row8 = 10
        Me.lsv_Envases.Row9 = 10
        Me.lsv_Envases.Size = New System.Drawing.Size(326, 165)
        Me.lsv_Envases.TabIndex = 6
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_DialogoAtms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 571)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Remision)
        Me.Controls.Add(Me.Gbx_NRemision)
        Me.Controls.Add(Me.dgDinero)
        Me.Controls.Add(Me.GpoDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 600)
        Me.Name = "frm_DialogoAtms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura Número de Remisión y Envases"
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.grbEnvases.ResumeLayout(False)
        Me.grbEnvases.PerformLayout()
        CType(Me.dgDinero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_NRemision.ResumeLayout(False)
        Me.Gbx_NRemision.PerformLayout()
        Me.Gbx_Remision.ResumeLayout(False)
        Me.Gbx_Remision.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grbEnvases As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoEnvase As System.Windows.Forms.Label
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoEnvase As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents tbx_Numero As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents dgDinero As System.Windows.Forms.DataGridView
    Friend WithEvents Gbx_NRemision As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Envases As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents Gbx_Remision As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TRemision As System.Windows.Forms.Label
    Friend WithEvents tbx_TotalRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
End Class
