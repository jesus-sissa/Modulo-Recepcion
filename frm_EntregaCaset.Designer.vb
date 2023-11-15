<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EntregaCaset
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
        Me.rdb_EntregaCartucho = New System.Windows.Forms.RadioButton
        Me.rdb_RecibeCartucho = New System.Windows.Forms.RadioButton
        Me.lbl_Caset = New System.Windows.Forms.Label
        Me.lbl_EmpleadoEntrega = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.gbx_Parametros = New System.Windows.Forms.GroupBox
        Me.gbx_Casets = New System.Windows.Forms.GroupBox
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lsv_Casets = New Modulo_Recepcion.cp_Listview
        Me.cmb_Cliente = New Modulo_Recepcion.cp_cmb_SimpleFiltrado
        Me.tbx_CodigoBarra = New Modulo_Recepcion.cp_Textbox
        Me.cmb_EmpleadoEntrega = New Modulo_Recepcion.cp_cmb_SimpleFiltrado
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.gbx_Parametros.SuspendLayout()
        Me.gbx_Casets.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdb_EntregaCartucho
        '
        Me.rdb_EntregaCartucho.AutoSize = True
        Me.rdb_EntregaCartucho.Location = New System.Drawing.Point(133, 19)
        Me.rdb_EntregaCartucho.Name = "rdb_EntregaCartucho"
        Me.rdb_EntregaCartucho.Size = New System.Drawing.Size(108, 17)
        Me.rdb_EntregaCartucho.TabIndex = 0
        Me.rdb_EntregaCartucho.TabStop = True
        Me.rdb_EntregaCartucho.Text = "Entrega Cartucho"
        Me.rdb_EntregaCartucho.UseVisualStyleBackColor = True
        '
        'rdb_RecibeCartucho
        '
        Me.rdb_RecibeCartucho.AutoSize = True
        Me.rdb_RecibeCartucho.Location = New System.Drawing.Point(256, 19)
        Me.rdb_RecibeCartucho.Name = "rdb_RecibeCartucho"
        Me.rdb_RecibeCartucho.Size = New System.Drawing.Size(105, 17)
        Me.rdb_RecibeCartucho.TabIndex = 1
        Me.rdb_RecibeCartucho.TabStop = True
        Me.rdb_RecibeCartucho.Text = "Recibe Cartucho"
        Me.rdb_RecibeCartucho.UseVisualStyleBackColor = True
        '
        'lbl_Caset
        '
        Me.lbl_Caset.AutoSize = True
        Me.lbl_Caset.Location = New System.Drawing.Point(94, 99)
        Me.lbl_Caset.Name = "lbl_Caset"
        Me.lbl_Caset.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Caset.TabIndex = 4
        Me.lbl_Caset.Text = "Caset"
        '
        'lbl_EmpleadoEntrega
        '
        Me.lbl_EmpleadoEntrega.AutoSize = True
        Me.lbl_EmpleadoEntrega.Location = New System.Drawing.Point(33, 45)
        Me.lbl_EmpleadoEntrega.Name = "lbl_EmpleadoEntrega"
        Me.lbl_EmpleadoEntrega.Size = New System.Drawing.Size(94, 13)
        Me.lbl_EmpleadoEntrega.TabIndex = 8
        Me.lbl_EmpleadoEntrega.Text = "Empleado Entrega"
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(54, 72)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Cliente.TabIndex = 9
        Me.lbl_Cliente.Text = "Cliente Origen"
        '
        'gbx_Parametros
        '
        Me.gbx_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Parametros.Controls.Add(Me.rdb_EntregaCartucho)
        Me.gbx_Parametros.Controls.Add(Me.cmb_Cliente)
        Me.gbx_Parametros.Controls.Add(Me.rdb_RecibeCartucho)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Cliente)
        Me.gbx_Parametros.Controls.Add(Me.lbl_Caset)
        Me.gbx_Parametros.Controls.Add(Me.lbl_EmpleadoEntrega)
        Me.gbx_Parametros.Controls.Add(Me.tbx_CodigoBarra)
        Me.gbx_Parametros.Controls.Add(Me.cmb_EmpleadoEntrega)
        Me.gbx_Parametros.Location = New System.Drawing.Point(12, 12)
        Me.gbx_Parametros.Name = "gbx_Parametros"
        Me.gbx_Parametros.Size = New System.Drawing.Size(554, 127)
        Me.gbx_Parametros.TabIndex = 3
        Me.gbx_Parametros.TabStop = False
        '
        'gbx_Casets
        '
        Me.gbx_Casets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Casets.Controls.Add(Me.lsv_Casets)
        Me.gbx_Casets.Location = New System.Drawing.Point(12, 146)
        Me.gbx_Casets.Name = "gbx_Casets"
        Me.gbx_Casets.Size = New System.Drawing.Size(554, 273)
        Me.gbx_Casets.TabIndex = 4
        Me.gbx_Casets.TabStop = False
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Eliminar)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_botones.Location = New System.Drawing.Point(12, 425)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(554, 51)
        Me.gbx_botones.TabIndex = 5
        Me.gbx_botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(463, 11)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(85, 32)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 10)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(121, 34)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lsv_Casets
        '
        Me.lsv_Casets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Casets.FullRowSelect = True
        Me.lsv_Casets.HideSelection = False
        Me.lsv_Casets.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Casets.Lvs = ListViewColumnSorter1
        Me.lsv_Casets.MultiSelect = False
        Me.lsv_Casets.Name = "lsv_Casets"
        Me.lsv_Casets.Row1 = 15
        Me.lsv_Casets.Row10 = 10
        Me.lsv_Casets.Row2 = 15
        Me.lsv_Casets.Row3 = 10
        Me.lsv_Casets.Row4 = 10
        Me.lsv_Casets.Row5 = 10
        Me.lsv_Casets.Row6 = 10
        Me.lsv_Casets.Row7 = 10
        Me.lsv_Casets.Row8 = 10
        Me.lsv_Casets.Row9 = 10
        Me.lsv_Casets.Size = New System.Drawing.Size(542, 248)
        Me.lsv_Casets.TabIndex = 3
        Me.lsv_Casets.UseCompatibleStateImageBehavior = False
        Me.lsv_Casets.View = System.Windows.Forms.View.Details
        '
        'cmb_Cliente
        '
        Me.cmb_Cliente.Clave = Nothing
        Me.cmb_Cliente.Control_Siguiente = Nothing
        Me.cmb_Cliente.DisplayMember = "Nombre_Comercial"
        Me.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cliente.Empresa = False
        Me.cmb_Cliente.Filtro = Nothing
        Me.cmb_Cliente.FormattingEnabled = True
        Me.cmb_Cliente.Location = New System.Drawing.Point(133, 69)
        Me.cmb_Cliente.MaxDropDownItems = 20
        Me.cmb_Cliente.Name = "cmb_Cliente"
        Me.cmb_Cliente.Pista = False
        Me.cmb_Cliente.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Cliente.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_Cliente.Sucursal = False
        Me.cmb_Cliente.TabIndex = 7
        Me.cmb_Cliente.Tipo = 0
        Me.cmb_Cliente.ValueMember = "Id_Cliente"
        '
        'tbx_CodigoBarra
        '
        Me.tbx_CodigoBarra.Control_Siguiente = Nothing
        Me.tbx_CodigoBarra.Filtrado = True
        Me.tbx_CodigoBarra.Location = New System.Drawing.Point(133, 96)
        Me.tbx_CodigoBarra.Name = "tbx_CodigoBarra"
        Me.tbx_CodigoBarra.Size = New System.Drawing.Size(132, 20)
        Me.tbx_CodigoBarra.TabIndex = 5
        Me.tbx_CodigoBarra.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'cmb_EmpleadoEntrega
        '
        Me.cmb_EmpleadoEntrega.Clave = Nothing
        Me.cmb_EmpleadoEntrega.Control_Siguiente = Nothing
        Me.cmb_EmpleadoEntrega.DisplayMember = "Nombre"
        Me.cmb_EmpleadoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmpleadoEntrega.Empresa = False
        Me.cmb_EmpleadoEntrega.Filtro = Nothing
        Me.cmb_EmpleadoEntrega.FormattingEnabled = True
        Me.cmb_EmpleadoEntrega.Location = New System.Drawing.Point(133, 42)
        Me.cmb_EmpleadoEntrega.MaxDropDownItems = 20
        Me.cmb_EmpleadoEntrega.Name = "cmb_EmpleadoEntrega"
        Me.cmb_EmpleadoEntrega.Pista = False
        Me.cmb_EmpleadoEntrega.Size = New System.Drawing.Size(350, 21)
        Me.cmb_EmpleadoEntrega.StoredProcedure = "Tv_Tripulacion_GetSaleRuta"
        Me.cmb_EmpleadoEntrega.Sucursal = True
        Me.cmb_EmpleadoEntrega.TabIndex = 6
        Me.cmb_EmpleadoEntrega.Tipo = 0
        Me.cmb_EmpleadoEntrega.ValueMember = "Id_Empleado"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(211, 11)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(121, 34)
        Me.btn_Eliminar.TabIndex = 2
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'frm_EntregaCaset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 481)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_Casets)
        Me.Controls.Add(Me.gbx_Parametros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(589, 520)
        Me.Name = "frm_EntregaCaset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salidas y Entradas de  CASSET"
        Me.gbx_Parametros.ResumeLayout(False)
        Me.gbx_Parametros.PerformLayout()
        Me.gbx_Casets.ResumeLayout(False)
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdb_EntregaCartucho As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_RecibeCartucho As System.Windows.Forms.RadioButton
    Friend WithEvents lsv_Casets As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Caset As System.Windows.Forms.Label
    Friend WithEvents tbx_CodigoBarra As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_EmpleadoEntrega As Modulo_Recepcion.cp_cmb_SimpleFiltrado
    Friend WithEvents cmb_Cliente As Modulo_Recepcion.cp_cmb_SimpleFiltrado
    Friend WithEvents lbl_EmpleadoEntrega As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents gbx_Parametros As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Casets As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
End Class
