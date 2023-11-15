<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StatusRutas
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
        Me.gbx_StatusRutas = New System.Windows.Forms.GroupBox
        Me.lbl_TotalRutas = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_Dentro = New System.Windows.Forms.Label
        Me.lbl_Fuera = New System.Windows.Forms.Label
        Me.lbl_ColorDentro = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lsv_Rutas = New Modulo_Recepcion.cp_Listview
        Me.gbx_StatusRutas.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_StatusRutas
        '
        Me.gbx_StatusRutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_StatusRutas.Controls.Add(Me.lbl_TotalRutas)
        Me.gbx_StatusRutas.Controls.Add(Me.lbl_Fecha)
        Me.gbx_StatusRutas.Controls.Add(Me.dtp_Fecha)
        Me.gbx_StatusRutas.Controls.Add(Me.lbl_Dentro)
        Me.gbx_StatusRutas.Controls.Add(Me.lbl_Fuera)
        Me.gbx_StatusRutas.Controls.Add(Me.lsv_Rutas)
        Me.gbx_StatusRutas.Controls.Add(Me.lbl_ColorDentro)
        Me.gbx_StatusRutas.Location = New System.Drawing.Point(5, 5)
        Me.gbx_StatusRutas.Name = "gbx_StatusRutas"
        Me.gbx_StatusRutas.Size = New System.Drawing.Size(620, 526)
        Me.gbx_StatusRutas.TabIndex = 0
        Me.gbx_StatusRutas.TabStop = False
        '
        'lbl_TotalRutas
        '
        Me.lbl_TotalRutas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalRutas.Location = New System.Drawing.Point(153, 13)
        Me.lbl_TotalRutas.Name = "lbl_TotalRutas"
        Me.lbl_TotalRutas.Size = New System.Drawing.Size(128, 23)
        Me.lbl_TotalRutas.TabIndex = 2
        Me.lbl_TotalRutas.Text = "Total Rutas: 0"
        Me.lbl_TotalRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(9, 15)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha"
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(52, 13)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(95, 20)
        Me.dtp_Fecha.TabIndex = 1
        '
        'lbl_Dentro
        '
        Me.lbl_Dentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Dentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Dentro.Location = New System.Drawing.Point(496, 17)
        Me.lbl_Dentro.Name = "lbl_Dentro"
        Me.lbl_Dentro.Size = New System.Drawing.Size(116, 20)
        Me.lbl_Dentro.TabIndex = 5
        Me.lbl_Dentro.Text = "Recibidos: 0"
        '
        'lbl_Fuera
        '
        Me.lbl_Fuera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fuera.Location = New System.Drawing.Point(299, 13)
        Me.lbl_Fuera.Name = "lbl_Fuera"
        Me.lbl_Fuera.Size = New System.Drawing.Size(127, 23)
        Me.lbl_Fuera.TabIndex = 3
        Me.lbl_Fuera.Text = "Pendientes: 0"
        Me.lbl_Fuera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_ColorDentro
        '
        Me.lbl_ColorDentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ColorDentro.BackColor = System.Drawing.Color.LightGreen
        Me.lbl_ColorDentro.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_ColorDentro.Location = New System.Drawing.Point(462, 15)
        Me.lbl_ColorDentro.Name = "lbl_ColorDentro"
        Me.lbl_ColorDentro.Size = New System.Drawing.Size(33, 20)
        Me.lbl_ColorDentro.TabIndex = 4
        Me.lbl_ColorDentro.Text = "     "
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 530)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(620, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(474, 12)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar (Esc)"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lsv_Rutas
        '
        Me.lsv_Rutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Rutas.FullRowSelect = True
        Me.lsv_Rutas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_Rutas.HideSelection = False
        Me.lsv_Rutas.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Rutas.Lvs = ListViewColumnSorter1
        Me.lsv_Rutas.MultiSelect = False
        Me.lsv_Rutas.Name = "lsv_Rutas"
        Me.lsv_Rutas.Row1 = 10
        Me.lsv_Rutas.Row10 = 0
        Me.lsv_Rutas.Row2 = 35
        Me.lsv_Rutas.Row3 = 25
        Me.lsv_Rutas.Row4 = 25
        Me.lsv_Rutas.Row5 = 0
        Me.lsv_Rutas.Row6 = 0
        Me.lsv_Rutas.Row7 = 0
        Me.lsv_Rutas.Row8 = 0
        Me.lsv_Rutas.Row9 = 0
        Me.lsv_Rutas.Size = New System.Drawing.Size(608, 480)
        Me.lsv_Rutas.TabIndex = 6
        Me.lsv_Rutas.UseCompatibleStateImageBehavior = False
        Me.lsv_Rutas.View = System.Windows.Forms.View.Details
        '
        'frm_StatusRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 586)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_StatusRutas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_StatusRutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estatus de las Rutas"
        Me.gbx_StatusRutas.ResumeLayout(False)
        Me.gbx_StatusRutas.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_StatusRutas As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Rutas As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Dentro As System.Windows.Forms.Label
    Friend WithEvents lbl_Fuera As System.Windows.Forms.Label
    Friend WithEvents lbl_ColorDentro As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_TotalRutas As System.Windows.Forms.Label
End Class
