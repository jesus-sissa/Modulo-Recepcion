<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BovedasApertura
    Inherits Form
    'Inherits Modulo_Recepcion.frm_Base

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BovedasApertura))
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.BTN_Exportar = New System.Windows.Forms.Button
        Me.Gbx_Observaciones = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.tbx_HoraAp = New Modulo_Recepcion.cp_Textbox
        Me.tbx_MinAp = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Hora = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Min = New Modulo_Recepcion.cp_Textbox
        Me.dtp_FechaApertura = New System.Windows.Forms.DateTimePicker
        Me.lbl_HoraPA = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.lbl_FechaPA = New System.Windows.Forms.Label
        Me.tbx_Observaciones = New System.Windows.Forms.TextBox
        Me.Lbl_Observaciones = New System.Windows.Forms.Label
        Me.Lbl_Fecha = New System.Windows.Forms.Label
        Me.BTN_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Recepcion.cp_Listview
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Observaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.lbl_Registros)
        Me.tab_Listado.Controls.Add(Me.Gbx_Botones)
        Me.tab_Listado.Controls.Add(Me.Gbx_Observaciones)
        Me.tab_Listado.Controls.Add(Me.BTN_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.BTN_Exportar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 477)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 8
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(627, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 5
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'BTN_Exportar
        '
        Me.BTN_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_Exportar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Exportar
        Me.BTN_Exportar.Location = New System.Drawing.Point(152, 14)
        Me.BTN_Exportar.Name = "BTN_Exportar"
        Me.BTN_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.BTN_Exportar.TabIndex = 6
        Me.BTN_Exportar.Text = "&Exportar"
        Me.BTN_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Exportar.UseVisualStyleBackColor = True
        '
        'Gbx_Observaciones
        '
        Me.Gbx_Observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Observaciones.Controls.Add(Me.Label6)
        Me.Gbx_Observaciones.Controls.Add(Me.Label3)
        Me.Gbx_Observaciones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Observaciones.Controls.Add(Me.tbx_HoraAp)
        Me.Gbx_Observaciones.Controls.Add(Me.tbx_Hora)
        Me.Gbx_Observaciones.Controls.Add(Me.tbx_MinAp)
        Me.Gbx_Observaciones.Controls.Add(Me.tbx_Min)
        Me.Gbx_Observaciones.Controls.Add(Me.dtp_FechaApertura)
        Me.Gbx_Observaciones.Controls.Add(Me.lbl_HoraPA)
        Me.Gbx_Observaciones.Controls.Add(Me.dtp_Fecha)
        Me.Gbx_Observaciones.Controls.Add(Me.Lbl_Hora)
        Me.Gbx_Observaciones.Controls.Add(Me.lbl_FechaPA)
        Me.Gbx_Observaciones.Controls.Add(Me.tbx_Observaciones)
        Me.Gbx_Observaciones.Controls.Add(Me.Lbl_Observaciones)
        Me.Gbx_Observaciones.Controls.Add(Me.Lbl_Fecha)
        Me.Gbx_Observaciones.Location = New System.Drawing.Point(3, 255)
        Me.Gbx_Observaciones.Name = "Gbx_Observaciones"
        Me.Gbx_Observaciones.Size = New System.Drawing.Size(770, 216)
        Me.Gbx_Observaciones.TabIndex = 4
        Me.Gbx_Observaciones.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ":"
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(627, 180)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 6
        Me.btn_Imprimir.Text = "&Reporte de Saldo"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'tbx_HoraAp
        '
        Me.tbx_HoraAp.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_HoraAp.Control_Siguiente = Me.tbx_MinAp
        Me.tbx_HoraAp.Filtrado = True
        Me.tbx_HoraAp.Location = New System.Drawing.Point(305, 42)
        Me.tbx_HoraAp.MaxLength = 4
        Me.tbx_HoraAp.Name = "tbx_HoraAp"
        Me.tbx_HoraAp.Size = New System.Drawing.Size(23, 20)
        Me.tbx_HoraAp.TabIndex = 5
        Me.tbx_HoraAp.Text = "00"
        Me.tbx_HoraAp.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_MinAp
        '
        Me.tbx_MinAp.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_MinAp.Control_Siguiente = Nothing
        Me.tbx_MinAp.Filtrado = True
        Me.tbx_MinAp.Location = New System.Drawing.Point(338, 42)
        Me.tbx_MinAp.MaxLength = 4
        Me.tbx_MinAp.Name = "tbx_MinAp"
        Me.tbx_MinAp.Size = New System.Drawing.Size(23, 20)
        Me.tbx_MinAp.TabIndex = 7
        Me.tbx_MinAp.Text = "00"
        Me.tbx_MinAp.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Hora
        '
        Me.tbx_Hora.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Hora.Control_Siguiente = Me.tbx_Min
        Me.tbx_Hora.Filtrado = True
        Me.tbx_Hora.Location = New System.Drawing.Point(56, 45)
        Me.tbx_Hora.MaxLength = 4
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(23, 20)
        Me.tbx_Hora.TabIndex = 5
        Me.tbx_Hora.Text = "00"
        Me.tbx_Hora.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Min
        '
        Me.tbx_Min.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Min.Control_Siguiente = Nothing
        Me.tbx_Min.Filtrado = True
        Me.tbx_Min.Location = New System.Drawing.Point(89, 45)
        Me.tbx_Min.MaxLength = 4
        Me.tbx_Min.Name = "tbx_Min"
        Me.tbx_Min.Size = New System.Drawing.Size(23, 20)
        Me.tbx_Min.TabIndex = 7
        Me.tbx_Min.Text = "00"
        Me.tbx_Min.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_FechaApertura
        '
        Me.dtp_FechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaApertura.Location = New System.Drawing.Point(305, 16)
        Me.dtp_FechaApertura.Name = "dtp_FechaApertura"
        Me.dtp_FechaApertura.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaApertura.TabIndex = 1
        '
        'lbl_HoraPA
        '
        Me.lbl_HoraPA.AutoSize = True
        Me.lbl_HoraPA.Location = New System.Drawing.Point(187, 46)
        Me.lbl_HoraPA.Name = "lbl_HoraPA"
        Me.lbl_HoraPA.Size = New System.Drawing.Size(112, 13)
        Me.lbl_HoraPA.TabIndex = 0
        Me.lbl_HoraPA.Text = "Hora próxima Apertura"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(56, 19)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(20, 48)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 0
        Me.Lbl_Hora.Text = "Hora"
        '
        'lbl_FechaPA
        '
        Me.lbl_FechaPA.AutoSize = True
        Me.lbl_FechaPA.Location = New System.Drawing.Point(180, 20)
        Me.lbl_FechaPA.Name = "lbl_FechaPA"
        Me.lbl_FechaPA.Size = New System.Drawing.Size(119, 13)
        Me.lbl_FechaPA.TabIndex = 0
        Me.lbl_FechaPA.Text = "Fecha próxima Apertura"
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Observaciones.Location = New System.Drawing.Point(3, 85)
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(764, 89)
        Me.tbx_Observaciones.TabIndex = 0
        '
        'Lbl_Observaciones
        '
        Me.Lbl_Observaciones.AutoSize = True
        Me.Lbl_Observaciones.Location = New System.Drawing.Point(6, 68)
        Me.Lbl_Observaciones.Name = "Lbl_Observaciones"
        Me.Lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_Observaciones.TabIndex = 0
        Me.Lbl_Observaciones.Text = "Observaciones"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(13, 23)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Fecha.TabIndex = 0
        Me.Lbl_Fecha.Text = "Fecha"
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.BTN_Buscar.Location = New System.Drawing.Point(626, 4)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 2
        Me.BTN_Buscar.Text = "B&uscar"
        Me.BTN_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.BTN_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(6, 9)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.AllowColumnReorder = True
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 48)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 30
        Me.lsv_Catalogo.Row3 = 5
        Me.lsv_Catalogo.Row4 = 5
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 10
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(770, 201)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(633, 30)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(135, 15)
        Me.lbl_Registros.TabIndex = 10
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_BovedasApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_BovedasApertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Bóvedas"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Observaciones.ResumeLayout(False)
        Me.Gbx_Observaciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents BTN_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents BTN_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Recepcion.cp_Listview
    Friend WithEvents Gbx_Observaciones As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_HoraAp As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_MinAp As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Hora As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_Min As Modulo_Recepcion.cp_Textbox
    Friend WithEvents dtp_FechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraPA As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaPA As System.Windows.Forms.Label
    Friend WithEvents Lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
End Class
