<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AsignarATM
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
        Dim ListViewColumnSorter7 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter8 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AsignarATM))
        Dim ListViewColumnSorter5 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter6 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Enviar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Custodia = New System.Windows.Forms.Button
        Me.Tab_Control = New System.Windows.Forms.TabControl
        Me.Tab_Concentracion = New System.Windows.Forms.TabPage
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_BuscarRem = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarRem = New System.Windows.Forms.Button
        Me.lsv_EnvasesRem = New Modulo_Recepcion.cp_Listview
        Me.lbl_RegistrosR = New System.Windows.Forms.Label
        Me.lsv_Remanentes = New Modulo_Recepcion.cp_Listview
        Me.Tab_Servicios = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_BuscarSer = New Modulo_Recepcion.cp_Textbox
        Me.btn_BuscarSer = New System.Windows.Forms.Button
        Me.lsv_EnvaseSer = New Modulo_Recepcion.cp_Listview
        Me.Lbl_RegistrosS = New System.Windows.Forms.Label
        Me.Lsv_Servicios = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.Tab_Control.SuspendLayout()
        Me.Tab_Concentracion.SuspendLayout()
        Me.Tab_Servicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(631, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Enviar
        '
        Me.btn_Enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Enviar.Enabled = False
        Me.btn_Enviar.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.btn_Enviar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Enviar.Name = "btn_Enviar"
        Me.btn_Enviar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Enviar.TabIndex = 0
        Me.btn_Enviar.Text = "&Enviar"
        Me.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Enviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Enviar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Custodia)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Enviar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 507)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(777, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Custodia
        '
        Me.Btn_Custodia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Custodia.Enabled = False
        Me.Btn_Custodia.Image = Global.Modulo_Recepcion.My.Resources.Resources.refresh
        Me.Btn_Custodia.Location = New System.Drawing.Point(152, 13)
        Me.Btn_Custodia.Name = "Btn_Custodia"
        Me.Btn_Custodia.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Custodia.TabIndex = 2
        Me.Btn_Custodia.Text = "&Custodia"
        Me.Btn_Custodia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Custodia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Custodia.UseVisualStyleBackColor = True
        '
        'Tab_Control
        '
        Me.Tab_Control.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Control.Controls.Add(Me.Tab_Concentracion)
        Me.Tab_Control.Controls.Add(Me.Tab_Servicios)
        Me.Tab_Control.Location = New System.Drawing.Point(2, 0)
        Me.Tab_Control.Name = "Tab_Control"
        Me.Tab_Control.SelectedIndex = 0
        Me.Tab_Control.Size = New System.Drawing.Size(782, 507)
        Me.Tab_Control.TabIndex = 0
        '
        'Tab_Concentracion
        '
        Me.Tab_Concentracion.Controls.Add(Me.lbl_Buscar)
        Me.Tab_Concentracion.Controls.Add(Me.tbx_BuscarRem)
        Me.Tab_Concentracion.Controls.Add(Me.btn_BuscarRem)
        Me.Tab_Concentracion.Controls.Add(Me.lsv_EnvasesRem)
        Me.Tab_Concentracion.Controls.Add(Me.lbl_RegistrosR)
        Me.Tab_Concentracion.Controls.Add(Me.lsv_Remanentes)
        Me.Tab_Concentracion.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Concentracion.Name = "Tab_Concentracion"
        Me.Tab_Concentracion.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Concentracion.Size = New System.Drawing.Size(774, 481)
        Me.Tab_Concentracion.TabIndex = 0
        Me.Tab_Concentracion.Text = "Remanentes"
        Me.Tab_Concentracion.UseVisualStyleBackColor = True
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(6, 34)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 15
        Me.lbl_Buscar.Text = "Buscar"
        '
        'tbx_BuscarRem
        '
        Me.tbx_BuscarRem.Control_Siguiente = Nothing
        Me.tbx_BuscarRem.Filtrado = False
        Me.tbx_BuscarRem.Location = New System.Drawing.Point(52, 31)
        Me.tbx_BuscarRem.Name = "tbx_BuscarRem"
        Me.tbx_BuscarRem.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarRem.TabIndex = 16
        Me.tbx_BuscarRem.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarRem
        '
        Me.btn_BuscarRem.Image = CType(resources.GetObject("btn_BuscarRem.Image"), System.Drawing.Image)
        Me.btn_BuscarRem.Location = New System.Drawing.Point(452, 28)
        Me.btn_BuscarRem.Name = "btn_BuscarRem"
        Me.btn_BuscarRem.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarRem.TabIndex = 17
        Me.btn_BuscarRem.Text = "&Buscar"
        Me.btn_BuscarRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarRem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarRem.UseVisualStyleBackColor = True
        '
        'lsv_EnvasesRem
        '
        Me.lsv_EnvasesRem.AllowColumnReorder = True
        Me.lsv_EnvasesRem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesRem.FullRowSelect = True
        Me.lsv_EnvasesRem.HideSelection = False
        Me.lsv_EnvasesRem.Location = New System.Drawing.Point(4, 380)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_EnvasesRem.Lvs = ListViewColumnSorter7
        Me.lsv_EnvasesRem.MultiSelect = False
        Me.lsv_EnvasesRem.Name = "lsv_EnvasesRem"
        Me.lsv_EnvasesRem.Row1 = 10
        Me.lsv_EnvasesRem.Row10 = 0
        Me.lsv_EnvasesRem.Row2 = 10
        Me.lsv_EnvasesRem.Row3 = 10
        Me.lsv_EnvasesRem.Row4 = 15
        Me.lsv_EnvasesRem.Row5 = 10
        Me.lsv_EnvasesRem.Row6 = 10
        Me.lsv_EnvasesRem.Row7 = 10
        Me.lsv_EnvasesRem.Row8 = 0
        Me.lsv_EnvasesRem.Row9 = 0
        Me.lsv_EnvasesRem.Size = New System.Drawing.Size(767, 97)
        Me.lsv_EnvasesRem.TabIndex = 4
        Me.lsv_EnvasesRem.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesRem.View = System.Windows.Forms.View.Details
        '
        'lbl_RegistrosR
        '
        Me.lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosR.Location = New System.Drawing.Point(636, 3)
        Me.lbl_RegistrosR.Name = "lbl_RegistrosR"
        Me.lbl_RegistrosR.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosR.TabIndex = 2
        Me.lbl_RegistrosR.Text = "Registros: 0"
        Me.lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Remanentes
        '
        Me.lsv_Remanentes.AllowColumnReorder = True
        Me.lsv_Remanentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remanentes.CheckBoxes = True
        Me.lsv_Remanentes.FullRowSelect = True
        Me.lsv_Remanentes.HideSelection = False
        Me.lsv_Remanentes.Location = New System.Drawing.Point(6, 62)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.lsv_Remanentes.Lvs = ListViewColumnSorter8
        Me.lsv_Remanentes.MultiSelect = False
        Me.lsv_Remanentes.Name = "lsv_Remanentes"
        Me.lsv_Remanentes.Row1 = 10
        Me.lsv_Remanentes.Row10 = 0
        Me.lsv_Remanentes.Row2 = 10
        Me.lsv_Remanentes.Row3 = 10
        Me.lsv_Remanentes.Row4 = 15
        Me.lsv_Remanentes.Row5 = 10
        Me.lsv_Remanentes.Row6 = 10
        Me.lsv_Remanentes.Row7 = 10
        Me.lsv_Remanentes.Row8 = 0
        Me.lsv_Remanentes.Row9 = 0
        Me.lsv_Remanentes.Size = New System.Drawing.Size(767, 316)
        Me.lsv_Remanentes.TabIndex = 0
        Me.lsv_Remanentes.UseCompatibleStateImageBehavior = False
        Me.lsv_Remanentes.View = System.Windows.Forms.View.Details
        '
        'Tab_Servicios
        '
        Me.Tab_Servicios.Controls.Add(Me.Label1)
        Me.Tab_Servicios.Controls.Add(Me.tbx_BuscarSer)
        Me.Tab_Servicios.Controls.Add(Me.btn_BuscarSer)
        Me.Tab_Servicios.Controls.Add(Me.lsv_EnvaseSer)
        Me.Tab_Servicios.Controls.Add(Me.Lbl_RegistrosS)
        Me.Tab_Servicios.Controls.Add(Me.Lsv_Servicios)
        Me.Tab_Servicios.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Servicios.Name = "Tab_Servicios"
        Me.Tab_Servicios.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Servicios.Size = New System.Drawing.Size(774, 481)
        Me.Tab_Servicios.TabIndex = 1
        Me.Tab_Servicios.Text = "Servicios"
        Me.Tab_Servicios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar"
        '
        'tbx_BuscarSer
        '
        Me.tbx_BuscarSer.Control_Siguiente = Nothing
        Me.tbx_BuscarSer.Filtrado = False
        Me.tbx_BuscarSer.Location = New System.Drawing.Point(58, 26)
        Me.tbx_BuscarSer.Name = "tbx_BuscarSer"
        Me.tbx_BuscarSer.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarSer.TabIndex = 19
        Me.tbx_BuscarSer.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_BuscarSer
        '
        Me.btn_BuscarSer.Image = CType(resources.GetObject("btn_BuscarSer.Image"), System.Drawing.Image)
        Me.btn_BuscarSer.Location = New System.Drawing.Point(456, 23)
        Me.btn_BuscarSer.Name = "btn_BuscarSer"
        Me.btn_BuscarSer.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarSer.TabIndex = 20
        Me.btn_BuscarSer.Text = "&Buscar"
        Me.btn_BuscarSer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarSer.UseVisualStyleBackColor = True
        '
        'lsv_EnvaseSer
        '
        Me.lsv_EnvaseSer.AllowColumnReorder = True
        Me.lsv_EnvaseSer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvaseSer.FullRowSelect = True
        Me.lsv_EnvaseSer.HideSelection = False
        Me.lsv_EnvaseSer.Location = New System.Drawing.Point(4, 380)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_EnvaseSer.Lvs = ListViewColumnSorter5
        Me.lsv_EnvaseSer.MultiSelect = False
        Me.lsv_EnvaseSer.Name = "lsv_EnvaseSer"
        Me.lsv_EnvaseSer.Row1 = 10
        Me.lsv_EnvaseSer.Row10 = 0
        Me.lsv_EnvaseSer.Row2 = 10
        Me.lsv_EnvaseSer.Row3 = 10
        Me.lsv_EnvaseSer.Row4 = 15
        Me.lsv_EnvaseSer.Row5 = 10
        Me.lsv_EnvaseSer.Row6 = 10
        Me.lsv_EnvaseSer.Row7 = 10
        Me.lsv_EnvaseSer.Row8 = 0
        Me.lsv_EnvaseSer.Row9 = 0
        Me.lsv_EnvaseSer.Size = New System.Drawing.Size(767, 97)
        Me.lsv_EnvaseSer.TabIndex = 5
        Me.lsv_EnvaseSer.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvaseSer.View = System.Windows.Forms.View.Details
        '
        'Lbl_RegistrosS
        '
        Me.Lbl_RegistrosS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosS.Location = New System.Drawing.Point(631, 3)
        Me.Lbl_RegistrosS.Name = "Lbl_RegistrosS"
        Me.Lbl_RegistrosS.Size = New System.Drawing.Size(135, 15)
        Me.Lbl_RegistrosS.TabIndex = 2
        Me.Lbl_RegistrosS.Text = "Registros: 0"
        Me.Lbl_RegistrosS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Servicios
        '
        Me.Lsv_Servicios.AllowColumnReorder = True
        Me.Lsv_Servicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Servicios.CheckBoxes = True
        Me.Lsv_Servicios.FullRowSelect = True
        Me.Lsv_Servicios.HideSelection = False
        Me.Lsv_Servicios.Location = New System.Drawing.Point(3, 60)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.Lsv_Servicios.Lvs = ListViewColumnSorter6
        Me.Lsv_Servicios.MultiSelect = False
        Me.Lsv_Servicios.Name = "Lsv_Servicios"
        Me.Lsv_Servicios.Row1 = 10
        Me.Lsv_Servicios.Row10 = 0
        Me.Lsv_Servicios.Row2 = 10
        Me.Lsv_Servicios.Row3 = 10
        Me.Lsv_Servicios.Row4 = 15
        Me.Lsv_Servicios.Row5 = 10
        Me.Lsv_Servicios.Row6 = 10
        Me.Lsv_Servicios.Row7 = 10
        Me.Lsv_Servicios.Row8 = 0
        Me.Lsv_Servicios.Row9 = 0
        Me.Lsv_Servicios.Size = New System.Drawing.Size(767, 318)
        Me.Lsv_Servicios.TabIndex = 0
        Me.Lsv_Servicios.UseCompatibleStateImageBehavior = False
        Me.Lsv_Servicios.View = System.Windows.Forms.View.Details
        '
        'frm_AsignarATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Tab_Control)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_AsignarATM"
        Me.Text = "Enviar Servicios a Cajeros"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Tab_Control.ResumeLayout(False)
        Me.Tab_Concentracion.ResumeLayout(False)
        Me.Tab_Concentracion.PerformLayout()
        Me.Tab_Servicios.ResumeLayout(False)
        Me.Tab_Servicios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Remanentes As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Tab_Control As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Concentracion As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Servicios As System.Windows.Forms.TabPage
    Friend WithEvents Lsv_Servicios As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosS As System.Windows.Forms.Label
    Friend WithEvents Btn_Custodia As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarRem As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarRem As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesRem As Modulo_Recepcion.cp_Listview
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarSer As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarSer As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvaseSer As Modulo_Recepcion.cp_Listview
End Class
