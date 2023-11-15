<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Kardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Kardex))
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Tab_Cartuchos = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.lbl_ClaveEmpleado = New System.Windows.Forms.Label
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Movimiento = New System.Windows.Forms.Label
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Rutas = New System.Windows.Forms.Label
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_ClaveEmpleado = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Empleado = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.cmb_Movimiento = New Modulo_Recepcion.cp_cmb_Manual
        Me.tbx_CodigoBarra = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Rutas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_CveRuta = New Modulo_Recepcion.cp_Textbox
        Me.lsv_Cartuchos = New Modulo_Recepcion.cp_Listview
        Me.Tab_Cartuchos.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Cartuchos
        '
        Me.Tab_Cartuchos.Controls.Add(Me.tab_Listado)
        Me.Tab_Cartuchos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Cartuchos.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Cartuchos.Name = "Tab_Cartuchos"
        Me.Tab_Cartuchos.SelectedIndex = 0
        Me.Tab_Cartuchos.Size = New System.Drawing.Size(804, 600)
        Me.Tab_Cartuchos.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.lbl_ClaveEmpleado)
        Me.tab_Listado.Controls.Add(Me.tbx_ClaveEmpleado)
        Me.tab_Listado.Controls.Add(Me.cmb_Empleado)
        Me.tab_Listado.Controls.Add(Me.btn_Mostrar)
        Me.tab_Listado.Controls.Add(Me.cmb_Movimiento)
        Me.tab_Listado.Controls.Add(Me.lbl_Movimiento)
        Me.tab_Listado.Controls.Add(Me.tbx_CodigoBarra)
        Me.tab_Listado.Controls.Add(Me.lbl_CodigoBarra)
        Me.tab_Listado.Controls.Add(Me.lbl_fecha)
        Me.tab_Listado.Controls.Add(Me.dtp_Fecha)
        Me.tab_Listado.Controls.Add(Me.lbl_Rutas)
        Me.tab_Listado.Controls.Add(Me.tbx_CveRuta)
        Me.tab_Listado.Controls.Add(Me.cmb_Rutas)
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.Btn_Guardar)
        Me.tab_Listado.Controls.Add(Me.lsv_Cartuchos)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(796, 574)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'lbl_ClaveEmpleado
        '
        Me.lbl_ClaveEmpleado.AutoSize = True
        Me.lbl_ClaveEmpleado.Location = New System.Drawing.Point(20, 82)
        Me.lbl_ClaveEmpleado.Name = "lbl_ClaveEmpleado"
        Me.lbl_ClaveEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_ClaveEmpleado.TabIndex = 58
        Me.lbl_ClaveEmpleado.Text = "Empleado"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow2
        Me.btn_Mostrar.Location = New System.Drawing.Point(255, 106)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(141, 30)
        Me.btn_Mostrar.TabIndex = 53
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Movimiento
        '
        Me.lbl_Movimiento.AutoSize = True
        Me.lbl_Movimiento.Location = New System.Drawing.Point(11, 54)
        Me.lbl_Movimiento.Name = "lbl_Movimiento"
        Me.lbl_Movimiento.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Movimiento.TabIndex = 27
        Me.lbl_Movimiento.Text = "Movimiento"
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(4, 112)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(73, 13)
        Me.lbl_CodigoBarra.TabIndex = 24
        Me.lbl_CodigoBarra.Text = "Código Barras"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(35, 8)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 19
        Me.lbl_fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(78, 2)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 20
        '
        'lbl_Rutas
        '
        Me.lbl_Rutas.AutoSize = True
        Me.lbl_Rutas.Location = New System.Drawing.Point(42, 29)
        Me.lbl_Rutas.Name = "lbl_Rutas"
        Me.lbl_Rutas.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Rutas.TabIndex = 21
        Me.lbl_Rutas.Text = "Ruta"
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(646, 133)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.lbl_Registros.TabIndex = 15
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(649, 537)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 13
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Enabled = False
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(7, 537)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 11
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_ClaveEmpleado
        '
        Me.tbx_ClaveEmpleado.Control_Siguiente = Me.cmb_Empleado
        Me.tbx_ClaveEmpleado.Filtrado = True
        Me.tbx_ClaveEmpleado.Location = New System.Drawing.Point(77, 79)
        Me.tbx_ClaveEmpleado.MaxLength = 4
        Me.tbx_ClaveEmpleado.Name = "tbx_ClaveEmpleado"
        Me.tbx_ClaveEmpleado.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveEmpleado.TabIndex = 59
        Me.tbx_ClaveEmpleado.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave"
        Me.cmb_Empleado.Control_Siguiente = Nothing
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_ClaveEmpleado
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(133, 78)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = False
        Me.cmb_Empleado.Size = New System.Drawing.Size(263, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_Empleados_Get "
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 60
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'cmb_Movimiento
        '
        Me.cmb_Movimiento.Control_Siguiente = Nothing
        Me.cmb_Movimiento.DisplayMember = "display"
        Me.cmb_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Movimiento.FormattingEnabled = True
        Me.cmb_Movimiento.Location = New System.Drawing.Point(78, 51)
        Me.cmb_Movimiento.MaxDropDownItems = 20
        Me.cmb_Movimiento.Name = "cmb_Movimiento"
        Me.cmb_Movimiento.Size = New System.Drawing.Size(319, 21)
        Me.cmb_Movimiento.TabIndex = 28
        Me.cmb_Movimiento.ValueMember = "value"
        '
        'tbx_CodigoBarra
        '
        Me.tbx_CodigoBarra.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_CodigoBarra.Enabled = False
        Me.tbx_CodigoBarra.Filtrado = True
        Me.tbx_CodigoBarra.Location = New System.Drawing.Point(77, 105)
        Me.tbx_CodigoBarra.MaxLength = 15
        Me.tbx_CodigoBarra.Name = "tbx_CodigoBarra"
        Me.tbx_CodigoBarra.Size = New System.Drawing.Size(113, 20)
        Me.tbx_CodigoBarra.TabIndex = 25
        Me.tbx_CodigoBarra.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Rutas
        '
        Me.cmb_Rutas.Clave = "Clave"
        Me.cmb_Rutas.Control_Siguiente = Nothing
        Me.cmb_Rutas.DisplayMember = "Descripcion"
        Me.cmb_Rutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rutas.Empresa = False
        Me.cmb_Rutas.Filtro = Me.tbx_CveRuta
        Me.cmb_Rutas.FormattingEnabled = True
        Me.cmb_Rutas.Location = New System.Drawing.Point(134, 25)
        Me.cmb_Rutas.MaxDropDownItems = 20
        Me.cmb_Rutas.Name = "cmb_Rutas"
        Me.cmb_Rutas.Pista = False
        Me.cmb_Rutas.Size = New System.Drawing.Size(263, 21)
        Me.cmb_Rutas.StoredProcedure = "CAT_Rutas_Programadas"
        Me.cmb_Rutas.Sucursal = True
        Me.cmb_Rutas.TabIndex = 23
        Me.cmb_Rutas.Tipo = 0
        Me.cmb_Rutas.ValueMember = "Id_Programacion"
        '
        'tbx_CveRuta
        '
        Me.tbx_CveRuta.Control_Siguiente = Me.cmb_Rutas
        Me.tbx_CveRuta.Filtrado = True
        Me.tbx_CveRuta.Location = New System.Drawing.Point(78, 26)
        Me.tbx_CveRuta.MaxLength = 4
        Me.tbx_CveRuta.Name = "tbx_CveRuta"
        Me.tbx_CveRuta.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CveRuta.TabIndex = 22
        Me.tbx_CveRuta.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lsv_Cartuchos
        '
        Me.lsv_Cartuchos.AllowColumnReorder = True
        Me.lsv_Cartuchos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cartuchos.CheckBoxes = True
        Me.lsv_Cartuchos.FullRowSelect = True
        Me.lsv_Cartuchos.HideSelection = False
        Me.lsv_Cartuchos.Location = New System.Drawing.Point(3, 154)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Cartuchos.Lvs = ListViewColumnSorter1
        Me.lsv_Cartuchos.MultiSelect = False
        Me.lsv_Cartuchos.Name = "lsv_Cartuchos"
        Me.lsv_Cartuchos.Row1 = 10
        Me.lsv_Cartuchos.Row10 = 0
        Me.lsv_Cartuchos.Row2 = 30
        Me.lsv_Cartuchos.Row3 = 5
        Me.lsv_Cartuchos.Row4 = 5
        Me.lsv_Cartuchos.Row5 = 10
        Me.lsv_Cartuchos.Row6 = 10
        Me.lsv_Cartuchos.Row7 = 10
        Me.lsv_Cartuchos.Row8 = 8
        Me.lsv_Cartuchos.Row9 = 0
        Me.lsv_Cartuchos.Size = New System.Drawing.Size(790, 374)
        Me.lsv_Cartuchos.TabIndex = 1
        Me.lsv_Cartuchos.UseCompatibleStateImageBehavior = False
        Me.lsv_Cartuchos.View = System.Windows.Forms.View.Details
        '
        'frm_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 600)
        Me.Controls.Add(Me.Tab_Cartuchos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Kardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo  Cartuchos"
        Me.Tab_Cartuchos.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Cartuchos As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Cartuchos As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Rutas As System.Windows.Forms.Label
    Friend WithEvents tbx_CveRuta As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Rutas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_CodigoBarra As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents lbl_Movimiento As System.Windows.Forms.Label
    Friend WithEvents cmb_Movimiento As Modulo_Recepcion.cp_cmb_Manual
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_ClaveEmpleado As System.Windows.Forms.Label
    Friend WithEvents tbx_ClaveEmpleado As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Empleado As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
End Class
