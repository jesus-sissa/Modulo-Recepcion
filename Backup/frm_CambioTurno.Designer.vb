<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CambioTurno
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
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.tbx_Responsable = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Hora = New Modulo_Recepcion.cp_Textbox
        Me.tbx_FechaInicio = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Turno = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_Responsable = New System.Windows.Forms.Label
        Me.Lbl_FechaIni = New System.Windows.Forms.Label
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.Lbl_Turno = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cambio = New System.Windows.Forms.Button
        Me.gbx_Totales = New System.Windows.Forms.GroupBox
        Me.tbx_EnvasesS = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_EnvasesSal = New System.Windows.Forms.Label
        Me.tbx_RemisionesS = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_RemisionesSal = New System.Windows.Forms.Label
        Me.tbx_EnvasesE = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_EnvasesEnt = New System.Windows.Forms.Label
        Me.tbx_RemisionesE = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_RemisionesEnt = New System.Windows.Forms.Label
        Me.Lsv_Turno = New Modulo_Recepcion.cp_Listview
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Totales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Responsable)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Hora)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_FechaInicio)
        Me.Gbx_Filtro.Controls.Add(Me.tbx_Turno)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Responsable)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_FechaIni)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Hora)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Turno)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 2)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(770, 79)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'tbx_Responsable
        '
        Me.tbx_Responsable.BackColor = System.Drawing.Color.White
        Me.tbx_Responsable.Control_Siguiente = Nothing
        Me.tbx_Responsable.Enabled = False
        Me.tbx_Responsable.Filtrado = True
        Me.tbx_Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Responsable.ForeColor = System.Drawing.Color.Black
        Me.tbx_Responsable.Location = New System.Drawing.Point(83, 46)
        Me.tbx_Responsable.MaxLength = 10
        Me.tbx_Responsable.Name = "tbx_Responsable"
        Me.tbx_Responsable.Size = New System.Drawing.Size(276, 20)
        Me.tbx_Responsable.TabIndex = 7
        Me.tbx_Responsable.TabStop = False
        Me.tbx_Responsable.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Hora
        '
        Me.tbx_Hora.BackColor = System.Drawing.Color.White
        Me.tbx_Hora.Control_Siguiente = Me.tbx_Responsable
        Me.tbx_Hora.Enabled = False
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Hora.ForeColor = System.Drawing.Color.Black
        Me.tbx_Hora.Location = New System.Drawing.Point(401, 19)
        Me.tbx_Hora.MaxLength = 10
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(65, 20)
        Me.tbx_Hora.TabIndex = 5
        Me.tbx_Hora.TabStop = False
        Me.tbx_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Hora.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_FechaInicio
        '
        Me.tbx_FechaInicio.BackColor = System.Drawing.Color.White
        Me.tbx_FechaInicio.Control_Siguiente = Me.tbx_Hora
        Me.tbx_FechaInicio.Enabled = False
        Me.tbx_FechaInicio.Filtrado = True
        Me.tbx_FechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_FechaInicio.ForeColor = System.Drawing.Color.Black
        Me.tbx_FechaInicio.Location = New System.Drawing.Point(262, 19)
        Me.tbx_FechaInicio.MaxLength = 10
        Me.tbx_FechaInicio.Name = "tbx_FechaInicio"
        Me.tbx_FechaInicio.Size = New System.Drawing.Size(97, 20)
        Me.tbx_FechaInicio.TabIndex = 3
        Me.tbx_FechaInicio.TabStop = False
        Me.tbx_FechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_FechaInicio.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Turno
        '
        Me.tbx_Turno.BackColor = System.Drawing.Color.White
        Me.tbx_Turno.Control_Siguiente = Me.tbx_FechaInicio
        Me.tbx_Turno.Enabled = False
        Me.tbx_Turno.Filtrado = True
        Me.tbx_Turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Turno.ForeColor = System.Drawing.Color.Black
        Me.tbx_Turno.Location = New System.Drawing.Point(83, 19)
        Me.tbx_Turno.MaxLength = 10
        Me.tbx_Turno.Name = "tbx_Turno"
        Me.tbx_Turno.Size = New System.Drawing.Size(52, 20)
        Me.tbx_Turno.TabIndex = 1
        Me.tbx_Turno.TabStop = False
        Me.tbx_Turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Turno.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_Responsable
        '
        Me.Lbl_Responsable.AutoSize = True
        Me.Lbl_Responsable.Location = New System.Drawing.Point(7, 49)
        Me.Lbl_Responsable.Name = "Lbl_Responsable"
        Me.Lbl_Responsable.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_Responsable.TabIndex = 6
        Me.Lbl_Responsable.Text = "Responsable"
        '
        'Lbl_FechaIni
        '
        Me.Lbl_FechaIni.AutoSize = True
        Me.Lbl_FechaIni.Location = New System.Drawing.Point(191, 22)
        Me.Lbl_FechaIni.Name = "Lbl_FechaIni"
        Me.Lbl_FechaIni.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_FechaIni.TabIndex = 2
        Me.Lbl_FechaIni.Text = "Fecha Inicio"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(365, 22)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 4
        Me.Lbl_Hora.Text = "Hora"
        '
        'Lbl_Turno
        '
        Me.Lbl_Turno.AutoSize = True
        Me.Lbl_Turno.Location = New System.Drawing.Point(9, 22)
        Me.Lbl_Turno.Name = "Lbl_Turno"
        Me.Lbl_Turno.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_Turno.TabIndex = 0
        Me.Lbl_Turno.Text = "Turno Actual"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cambio)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cambio
        '
        Me.btn_Cambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cambio.Enabled = False
        Me.btn_Cambio.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow
        Me.btn_Cambio.Location = New System.Drawing.Point(6, 12)
        Me.btn_Cambio.Name = "btn_Cambio"
        Me.btn_Cambio.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cambio.TabIndex = 0
        Me.btn_Cambio.Text = "C&ambio"
        Me.btn_Cambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cambio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cambio.UseVisualStyleBackColor = True
        '
        'gbx_Totales
        '
        Me.gbx_Totales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Totales.Controls.Add(Me.tbx_EnvasesS)
        Me.gbx_Totales.Controls.Add(Me.Lbl_EnvasesSal)
        Me.gbx_Totales.Controls.Add(Me.tbx_RemisionesS)
        Me.gbx_Totales.Controls.Add(Me.Lbl_RemisionesSal)
        Me.gbx_Totales.Controls.Add(Me.tbx_EnvasesE)
        Me.gbx_Totales.Controls.Add(Me.Lbl_EnvasesEnt)
        Me.gbx_Totales.Controls.Add(Me.tbx_RemisionesE)
        Me.gbx_Totales.Controls.Add(Me.Lbl_RemisionesEnt)
        Me.gbx_Totales.Location = New System.Drawing.Point(7, 421)
        Me.gbx_Totales.Name = "gbx_Totales"
        Me.gbx_Totales.Size = New System.Drawing.Size(770, 72)
        Me.gbx_Totales.TabIndex = 2
        Me.gbx_Totales.TabStop = False
        Me.gbx_Totales.Text = "Totales"
        '
        'tbx_EnvasesS
        '
        Me.tbx_EnvasesS.BackColor = System.Drawing.Color.White
        Me.tbx_EnvasesS.Control_Siguiente = Me.btn_Cambio
        Me.tbx_EnvasesS.Enabled = False
        Me.tbx_EnvasesS.Filtrado = True
        Me.tbx_EnvasesS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_EnvasesS.ForeColor = System.Drawing.Color.Black
        Me.tbx_EnvasesS.Location = New System.Drawing.Point(376, 45)
        Me.tbx_EnvasesS.MaxLength = 10
        Me.tbx_EnvasesS.Name = "tbx_EnvasesS"
        Me.tbx_EnvasesS.ReadOnly = True
        Me.tbx_EnvasesS.Size = New System.Drawing.Size(65, 21)
        Me.tbx_EnvasesS.TabIndex = 7
        Me.tbx_EnvasesS.TabStop = False
        Me.tbx_EnvasesS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_EnvasesS.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_EnvasesSal
        '
        Me.Lbl_EnvasesSal.AutoSize = True
        Me.Lbl_EnvasesSal.Location = New System.Drawing.Point(290, 48)
        Me.Lbl_EnvasesSal.Name = "Lbl_EnvasesSal"
        Me.Lbl_EnvasesSal.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_EnvasesSal.TabIndex = 6
        Me.Lbl_EnvasesSal.Text = "Envases Salida"
        '
        'tbx_RemisionesS
        '
        Me.tbx_RemisionesS.BackColor = System.Drawing.Color.White
        Me.tbx_RemisionesS.Control_Siguiente = Me.tbx_EnvasesS
        Me.tbx_RemisionesS.Enabled = False
        Me.tbx_RemisionesS.Filtrado = True
        Me.tbx_RemisionesS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_RemisionesS.ForeColor = System.Drawing.Color.Black
        Me.tbx_RemisionesS.Location = New System.Drawing.Point(376, 19)
        Me.tbx_RemisionesS.MaxLength = 10
        Me.tbx_RemisionesS.Name = "tbx_RemisionesS"
        Me.tbx_RemisionesS.ReadOnly = True
        Me.tbx_RemisionesS.Size = New System.Drawing.Size(65, 21)
        Me.tbx_RemisionesS.TabIndex = 5
        Me.tbx_RemisionesS.TabStop = False
        Me.tbx_RemisionesS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_RemisionesS.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_RemisionesSal
        '
        Me.Lbl_RemisionesSal.AutoSize = True
        Me.Lbl_RemisionesSal.Location = New System.Drawing.Point(277, 22)
        Me.Lbl_RemisionesSal.Name = "Lbl_RemisionesSal"
        Me.Lbl_RemisionesSal.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_RemisionesSal.TabIndex = 4
        Me.Lbl_RemisionesSal.Text = "Remisiones Salida"
        '
        'tbx_EnvasesE
        '
        Me.tbx_EnvasesE.BackColor = System.Drawing.Color.White
        Me.tbx_EnvasesE.Control_Siguiente = Me.tbx_RemisionesS
        Me.tbx_EnvasesE.Enabled = False
        Me.tbx_EnvasesE.Filtrado = True
        Me.tbx_EnvasesE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_EnvasesE.ForeColor = System.Drawing.Color.Black
        Me.tbx_EnvasesE.Location = New System.Drawing.Point(156, 45)
        Me.tbx_EnvasesE.MaxLength = 10
        Me.tbx_EnvasesE.Name = "tbx_EnvasesE"
        Me.tbx_EnvasesE.ReadOnly = True
        Me.tbx_EnvasesE.Size = New System.Drawing.Size(65, 21)
        Me.tbx_EnvasesE.TabIndex = 3
        Me.tbx_EnvasesE.TabStop = False
        Me.tbx_EnvasesE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_EnvasesE.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_EnvasesEnt
        '
        Me.Lbl_EnvasesEnt.AutoSize = True
        Me.Lbl_EnvasesEnt.Location = New System.Drawing.Point(62, 48)
        Me.Lbl_EnvasesEnt.Name = "Lbl_EnvasesEnt"
        Me.Lbl_EnvasesEnt.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_EnvasesEnt.TabIndex = 2
        Me.Lbl_EnvasesEnt.Text = "Envases Entrada"
        '
        'tbx_RemisionesE
        '
        Me.tbx_RemisionesE.BackColor = System.Drawing.Color.White
        Me.tbx_RemisionesE.Control_Siguiente = Me.tbx_EnvasesE
        Me.tbx_RemisionesE.Enabled = False
        Me.tbx_RemisionesE.Filtrado = True
        Me.tbx_RemisionesE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_RemisionesE.ForeColor = System.Drawing.Color.Black
        Me.tbx_RemisionesE.Location = New System.Drawing.Point(156, 19)
        Me.tbx_RemisionesE.MaxLength = 10
        Me.tbx_RemisionesE.Name = "tbx_RemisionesE"
        Me.tbx_RemisionesE.ReadOnly = True
        Me.tbx_RemisionesE.Size = New System.Drawing.Size(65, 21)
        Me.tbx_RemisionesE.TabIndex = 1
        Me.tbx_RemisionesE.TabStop = False
        Me.tbx_RemisionesE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_RemisionesE.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_RemisionesEnt
        '
        Me.Lbl_RemisionesEnt.AutoSize = True
        Me.Lbl_RemisionesEnt.Location = New System.Drawing.Point(49, 22)
        Me.Lbl_RemisionesEnt.Name = "Lbl_RemisionesEnt"
        Me.Lbl_RemisionesEnt.Size = New System.Drawing.Size(101, 13)
        Me.Lbl_RemisionesEnt.TabIndex = 0
        Me.Lbl_RemisionesEnt.Text = "Remisiones Entrada"
        '
        'Lsv_Turno
        '
        Me.Lsv_Turno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Turno.FullRowSelect = True
        Me.Lsv_Turno.HideSelection = False
        Me.Lsv_Turno.Location = New System.Drawing.Point(7, 102)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Turno.Lvs = ListViewColumnSorter1
        Me.Lsv_Turno.MultiSelect = False
        Me.Lsv_Turno.Name = "Lsv_Turno"
        Me.Lsv_Turno.Row1 = 10
        Me.Lsv_Turno.Row10 = 0
        Me.Lsv_Turno.Row2 = 10
        Me.Lsv_Turno.Row3 = 10
        Me.Lsv_Turno.Row4 = 10
        Me.Lsv_Turno.Row5 = 10
        Me.Lsv_Turno.Row6 = 10
        Me.Lsv_Turno.Row7 = 0
        Me.Lsv_Turno.Row8 = 0
        Me.Lsv_Turno.Row9 = 0
        Me.Lsv_Turno.Size = New System.Drawing.Size(770, 313)
        Me.Lsv_Turno.TabIndex = 1
        Me.Lsv_Turno.UseCompatibleStateImageBehavior = False
        Me.Lsv_Turno.View = System.Windows.Forms.View.Details
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(627, 84)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(150, 15)
        Me.lbl_Registros.TabIndex = 10
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_CambioTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbl_Registros)
        Me.Controls.Add(Me.gbx_Totales)
        Me.Controls.Add(Me.Lsv_Turno)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CambioTurno"
        Me.Text = "Cambio de Turno"
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Totales.ResumeLayout(False)
        Me.gbx_Totales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Turno As System.Windows.Forms.Label
    Friend WithEvents btn_Cambio As System.Windows.Forms.Button
    Friend WithEvents tbx_Turno As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Responsable As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaIni As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Lsv_Turno As Modulo_Recepcion.cp_Listview
    Friend WithEvents tbx_FechaInicio As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Responsable As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Hora As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Totales As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_EnvasesE As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_EnvasesEnt As System.Windows.Forms.Label
    Friend WithEvents tbx_RemisionesE As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_RemisionesEnt As System.Windows.Forms.Label
    Friend WithEvents tbx_EnvasesS As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_EnvasesSal As System.Windows.Forms.Label
    Friend WithEvents tbx_RemisionesS As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_RemisionesSal As System.Windows.Forms.Label
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
