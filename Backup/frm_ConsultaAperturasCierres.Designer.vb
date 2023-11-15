<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConsultaAperturasCierres
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Reimprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.dtp_FechaFin = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.cmb_Bovedas = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lbl_FechaFin = New System.Windows.Forms.Label
        Me.Lbl_Ini = New System.Windows.Forms.Label
        Me.Lbl_Boveda = New System.Windows.Forms.Label
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lsv_Listado = New Modulo_Recepcion.cp_Listview
        Me.lbl_RegistrosTV = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Reimprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 502)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Reimprimir
        '
        Me.btn_Reimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Reimprimir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Imprimir
        Me.btn_Reimprimir.Location = New System.Drawing.Point(6, 14)
        Me.btn_Reimprimir.Name = "btn_Reimprimir"
        Me.btn_Reimprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Reimprimir.TabIndex = 9
        Me.btn_Reimprimir.Text = "&Reimprimir"
        Me.btn_Reimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Reimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Reimprimir.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_FechaFin)
        Me.Gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.dtp_FechaInicio)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Bovedas)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_FechaFin)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Ini)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Boveda)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(9, 3)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(766, 68)
        Me.Gbx_Filtro.TabIndex = 1
        Me.Gbx_Filtro.TabStop = False
        '
        'dtp_FechaFin
        '
        Me.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFin.Location = New System.Drawing.Point(237, 13)
        Me.dtp_FechaFin.Name = "dtp_FechaFin"
        Me.dtp_FechaFin.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaFin.TabIndex = 7
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mostrar.Image = Global.Modulo_Recepcion.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(329, 33)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 8
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(77, 13)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaInicio.TabIndex = 7
        '
        'cmb_Bovedas
        '
        Me.cmb_Bovedas.Clave = Nothing
        Me.cmb_Bovedas.Control_Siguiente = Nothing
        Me.cmb_Bovedas.DisplayMember = "Descripcion"
        Me.cmb_Bovedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Bovedas.Empresa = False
        Me.cmb_Bovedas.Filtro = Nothing
        Me.cmb_Bovedas.FormattingEnabled = True
        Me.cmb_Bovedas.Location = New System.Drawing.Point(77, 39)
        Me.cmb_Bovedas.MaxDropDownItems = 20
        Me.cmb_Bovedas.Name = "cmb_Bovedas"
        Me.cmb_Bovedas.Pista = False
        Me.cmb_Bovedas.Size = New System.Drawing.Size(246, 21)
        Me.cmb_Bovedas.StoredProcedure = "Cat_Bovedas_GetCombo2"
        Me.cmb_Bovedas.Sucursal = True
        Me.cmb_Bovedas.TabIndex = 6
        Me.cmb_Bovedas.Tipo = 0
        Me.cmb_Bovedas.ValueMember = "Id_Boveda"
        '
        'Lbl_FechaFin
        '
        Me.Lbl_FechaFin.AutoSize = True
        Me.Lbl_FechaFin.Location = New System.Drawing.Point(178, 17)
        Me.Lbl_FechaFin.Name = "Lbl_FechaFin"
        Me.Lbl_FechaFin.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_FechaFin.TabIndex = 3
        Me.Lbl_FechaFin.Text = "Fecha Fin"
        '
        'Lbl_Ini
        '
        Me.Lbl_Ini.AutoSize = True
        Me.Lbl_Ini.Location = New System.Drawing.Point(6, 17)
        Me.Lbl_Ini.Name = "Lbl_Ini"
        Me.Lbl_Ini.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_Ini.TabIndex = 3
        Me.Lbl_Ini.Text = "Fecha Inicio"
        '
        'Lbl_Boveda
        '
        Me.Lbl_Boveda.AutoSize = True
        Me.Lbl_Boveda.Location = New System.Drawing.Point(27, 42)
        Me.Lbl_Boveda.Name = "Lbl_Boveda"
        Me.Lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Boveda.TabIndex = 3
        Me.Lbl_Boveda.Text = "Bóveda"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lbl_RegistrosTV)
        Me.gbx_Datos.Controls.Add(Me.lsv_Listado)
        Me.gbx_Datos.Location = New System.Drawing.Point(9, 77)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(766, 424)
        Me.gbx_Datos.TabIndex = 2
        Me.gbx_Datos.TabStop = False
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter1
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 10
        Me.lsv_Listado.Row10 = 0
        Me.lsv_Listado.Row2 = 10
        Me.lsv_Listado.Row3 = 30
        Me.lsv_Listado.Row4 = 10
        Me.lsv_Listado.Row5 = 15
        Me.lsv_Listado.Row6 = 15
        Me.lsv_Listado.Row7 = 0
        Me.lsv_Listado.Row8 = 0
        Me.lsv_Listado.Row9 = 0
        Me.lsv_Listado.Size = New System.Drawing.Size(754, 384)
        Me.lsv_Listado.TabIndex = 0
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'lbl_RegistrosTV
        '
        Me.lbl_RegistrosTV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosTV.Location = New System.Drawing.Point(625, 16)
        Me.lbl_RegistrosTV.Name = "lbl_RegistrosTV"
        Me.lbl_RegistrosTV.Size = New System.Drawing.Size(135, 15)
        Me.lbl_RegistrosTV.TabIndex = 4
        Me.lbl_RegistrosTV.Text = "Registros: 0"
        Me.lbl_RegistrosTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_ConsultaAperturasCierres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ConsultaAperturasCierres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Aperturas/Cierres de Bóvedas"
        Me.gbx_Botones.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.gbx_Datos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Listado As Modulo_Recepcion.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Reimprimir As System.Windows.Forms.Button
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Bovedas As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_FechaFin As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ini As System.Windows.Forms.Label
    Friend WithEvents Lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_RegistrosTV As System.Windows.Forms.Label
End Class
