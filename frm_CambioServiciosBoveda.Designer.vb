<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CambioServiciosBoveda
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
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.cmb_BovedaOrigen = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.chk_Todos = New System.Windows.Forms.CheckBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.lsv_Servicios = New Modulo_Recepcion.cp_Listview
        Me.gbx_Guardar = New System.Windows.Forms.GroupBox
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.cmb_BovedaDestino = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_BovedaB = New System.Windows.Forms.Label
        Me.gbx_Datos.SuspendLayout()
        Me.Gbx_Listado.SuspendLayout()
        Me.gbx_Guardar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(9, 22)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda Origen"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.cmb_BovedaOrigen)
        Me.gbx_Datos.Controls.Add(Me.lbl_Boveda)
        Me.gbx_Datos.Location = New System.Drawing.Point(4, 7)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(776, 50)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        '
        'cmb_BovedaOrigen
        '
        Me.cmb_BovedaOrigen.Clave = "Clave"
        Me.cmb_BovedaOrigen.Control_Siguiente = Nothing
        Me.cmb_BovedaOrigen.DisplayMember = "Descripcion"
        Me.cmb_BovedaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BovedaOrigen.Empresa = False
        Me.cmb_BovedaOrigen.Filtro = Nothing
        Me.cmb_BovedaOrigen.FormattingEnabled = True
        Me.cmb_BovedaOrigen.Location = New System.Drawing.Point(93, 19)
        Me.cmb_BovedaOrigen.MaxDropDownItems = 20
        Me.cmb_BovedaOrigen.Name = "cmb_BovedaOrigen"
        Me.cmb_BovedaOrigen.Pista = False
        Me.cmb_BovedaOrigen.Size = New System.Drawing.Size(230, 21)
        Me.cmb_BovedaOrigen.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_BovedaOrigen.Sucursal = True
        Me.cmb_BovedaOrigen.TabIndex = 2
        Me.cmb_BovedaOrigen.Tipo = 0
        Me.cmb_BovedaOrigen.ValueMember = "Id_Boveda"
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.chk_Todos)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Registros)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Servicios)
        Me.Gbx_Listado.Location = New System.Drawing.Point(4, 64)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(775, 442)
        Me.Gbx_Listado.TabIndex = 1
        Me.Gbx_Listado.TabStop = False
        Me.Gbx_Listado.Text = "Servicios"
        '
        'chk_Todos
        '
        Me.chk_Todos.AutoSize = True
        Me.chk_Todos.Location = New System.Drawing.Point(7, 20)
        Me.chk_Todos.Name = "chk_Todos"
        Me.chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Todos.TabIndex = 0
        Me.chk_Todos.Text = "Todos"
        Me.chk_Todos.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(497, 16)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(272, 16)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Servicios
        '
        Me.lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Servicios.CheckBoxes = True
        Me.lsv_Servicios.FullRowSelect = True
        Me.lsv_Servicios.HideSelection = False
        Me.lsv_Servicios.Location = New System.Drawing.Point(6, 37)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Servicios.Lvs = ListViewColumnSorter1
        Me.lsv_Servicios.MultiSelect = False
        Me.lsv_Servicios.Name = "lsv_Servicios"
        Me.lsv_Servicios.Row1 = 7
        Me.lsv_Servicios.Row10 = 0
        Me.lsv_Servicios.Row2 = 7
        Me.lsv_Servicios.Row3 = 15
        Me.lsv_Servicios.Row4 = 15
        Me.lsv_Servicios.Row5 = 20
        Me.lsv_Servicios.Row6 = 15
        Me.lsv_Servicios.Row7 = 15
        Me.lsv_Servicios.Row8 = 0
        Me.lsv_Servicios.Row9 = 0
        Me.lsv_Servicios.Size = New System.Drawing.Size(763, 399)
        Me.lsv_Servicios.TabIndex = 2
        Me.lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'gbx_Guardar
        '
        Me.gbx_Guardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Guardar.Controls.Add(Me.Btn_Cancelar)
        Me.gbx_Guardar.Controls.Add(Me.btn_Guardar)
        Me.gbx_Guardar.Controls.Add(Me.cmb_BovedaDestino)
        Me.gbx_Guardar.Controls.Add(Me.Lbl_BovedaB)
        Me.gbx_Guardar.Location = New System.Drawing.Point(4, 507)
        Me.gbx_Guardar.Name = "gbx_Guardar"
        Me.gbx_Guardar.Size = New System.Drawing.Size(775, 50)
        Me.gbx_Guardar.TabIndex = 2
        Me.gbx_Guardar.TabStop = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(629, 14)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 3
        Me.Btn_Cancelar.Text = "&Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(329, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'cmb_BovedaDestino
        '
        Me.cmb_BovedaDestino.Clave = "Clave"
        Me.cmb_BovedaDestino.Control_Siguiente = Nothing
        Me.cmb_BovedaDestino.DisplayMember = "Descripcion"
        Me.cmb_BovedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BovedaDestino.Empresa = False
        Me.cmb_BovedaDestino.Filtro = Nothing
        Me.cmb_BovedaDestino.FormattingEnabled = True
        Me.cmb_BovedaDestino.Location = New System.Drawing.Point(93, 19)
        Me.cmb_BovedaDestino.MaxDropDownItems = 20
        Me.cmb_BovedaDestino.Name = "cmb_BovedaDestino"
        Me.cmb_BovedaDestino.Pista = False
        Me.cmb_BovedaDestino.Size = New System.Drawing.Size(230, 21)
        Me.cmb_BovedaDestino.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_BovedaDestino.Sucursal = True
        Me.cmb_BovedaDestino.TabIndex = 1
        Me.cmb_BovedaDestino.Tipo = 0
        Me.cmb_BovedaDestino.ValueMember = "Id_Boveda"
        '
        'Lbl_BovedaB
        '
        Me.Lbl_BovedaB.AutoSize = True
        Me.Lbl_BovedaB.Location = New System.Drawing.Point(9, 22)
        Me.Lbl_BovedaB.Name = "Lbl_BovedaB"
        Me.Lbl_BovedaB.Size = New System.Drawing.Size(83, 13)
        Me.Lbl_BovedaB.TabIndex = 0
        Me.Lbl_BovedaB.Text = "Bóveda Destino"
        '
        'frm_CambioServiciosBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gbx_Guardar)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.Controls.Add(Me.gbx_Datos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CambioServiciosBoveda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Servicios de Boveda"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Listado.PerformLayout()
        Me.gbx_Guardar.ResumeLayout(False)
        Me.gbx_Guardar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents cmb_BovedaOrigen As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Servicios As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents gbx_Guardar As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_BovedaDestino As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_BovedaB As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
End Class
