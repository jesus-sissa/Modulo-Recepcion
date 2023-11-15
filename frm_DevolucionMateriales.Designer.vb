<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DevolucionMateriales
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
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DevolucionMateriales))
        Me.gbx_Materiales = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.Lsv_Materiales = New Modulo_Recepcion.cp_Listview
        Me.Lsv_MaterialesT = New Modulo_Recepcion.cp_Listview
        Me.grp_Materiales = New System.Windows.Forms.GroupBox
        Me.lsv_Envase = New Modulo_Recepcion.cp_Listview
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.gbx_Materiales.SuspendLayout()
        Me.grp_Materiales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Materiales
        '
        Me.gbx_Materiales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Materiales.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Materiales.Controls.Add(Me.btn_Validar)
        Me.gbx_Materiales.Location = New System.Drawing.Point(7, 499)
        Me.gbx_Materiales.Name = "gbx_Materiales"
        Me.gbx_Materiales.Size = New System.Drawing.Size(770, 50)
        Me.gbx_Materiales.TabIndex = 1
        Me.gbx_Materiales.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'Lsv_Materiales
        '
        Me.Lsv_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Materiales.CheckBoxes = True
        Me.Lsv_Materiales.FullRowSelect = True
        Me.Lsv_Materiales.HideSelection = False
        Me.Lsv_Materiales.Location = New System.Drawing.Point(7, 35)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Lsv_Materiales.Lvs = ListViewColumnSorter1
        Me.Lsv_Materiales.MultiSelect = False
        Me.Lsv_Materiales.Name = "Lsv_Materiales"
        Me.Lsv_Materiales.Row1 = 10
        Me.Lsv_Materiales.Row10 = 0
        Me.Lsv_Materiales.Row2 = 10
        Me.Lsv_Materiales.Row3 = 10
        Me.Lsv_Materiales.Row4 = 10
        Me.Lsv_Materiales.Row5 = 10
        Me.Lsv_Materiales.Row6 = 10
        Me.Lsv_Materiales.Row7 = 0
        Me.Lsv_Materiales.Row8 = 0
        Me.Lsv_Materiales.Row9 = 0
        Me.Lsv_Materiales.Size = New System.Drawing.Size(758, 134)
        Me.Lsv_Materiales.TabIndex = 0
        Me.Lsv_Materiales.UseCompatibleStateImageBehavior = False
        Me.Lsv_Materiales.View = System.Windows.Forms.View.Details
        '
        'Lsv_MaterialesT
        '
        Me.Lsv_MaterialesT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_MaterialesT.FullRowSelect = True
        Me.Lsv_MaterialesT.HideSelection = False
        Me.Lsv_MaterialesT.Location = New System.Drawing.Point(5, 174)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_MaterialesT.Lvs = ListViewColumnSorter2
        Me.Lsv_MaterialesT.MultiSelect = False
        Me.Lsv_MaterialesT.Name = "Lsv_MaterialesT"
        Me.Lsv_MaterialesT.Row1 = 10
        Me.Lsv_MaterialesT.Row10 = 10
        Me.Lsv_MaterialesT.Row2 = 10
        Me.Lsv_MaterialesT.Row3 = 10
        Me.Lsv_MaterialesT.Row4 = 10
        Me.Lsv_MaterialesT.Row5 = 10
        Me.Lsv_MaterialesT.Row6 = 10
        Me.Lsv_MaterialesT.Row7 = 10
        Me.Lsv_MaterialesT.Row8 = 10
        Me.Lsv_MaterialesT.Row9 = 10
        Me.Lsv_MaterialesT.Size = New System.Drawing.Size(758, 128)
        Me.Lsv_MaterialesT.TabIndex = 1
        Me.Lsv_MaterialesT.UseCompatibleStateImageBehavior = False
        Me.Lsv_MaterialesT.View = System.Windows.Forms.View.Details
        '
        'grp_Materiales
        '
        Me.grp_Materiales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Materiales.Controls.Add(Me.lsv_Envase)
        Me.grp_Materiales.Controls.Add(Me.Lbl_Registros)
        Me.grp_Materiales.Controls.Add(Me.Lsv_MaterialesT)
        Me.grp_Materiales.Controls.Add(Me.Lsv_Materiales)
        Me.grp_Materiales.Location = New System.Drawing.Point(7, 52)
        Me.grp_Materiales.Name = "grp_Materiales"
        Me.grp_Materiales.Size = New System.Drawing.Size(770, 447)
        Me.grp_Materiales.TabIndex = 0
        Me.grp_Materiales.TabStop = False
        '
        'lsv_Envase
        '
        Me.lsv_Envase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envase.FullRowSelect = True
        Me.lsv_Envase.HideSelection = False
        Me.lsv_Envase.Location = New System.Drawing.Point(6, 307)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Envase.Lvs = ListViewColumnSorter3
        Me.lsv_Envase.MultiSelect = False
        Me.lsv_Envase.Name = "lsv_Envase"
        Me.lsv_Envase.Row1 = 10
        Me.lsv_Envase.Row10 = 10
        Me.lsv_Envase.Row2 = 10
        Me.lsv_Envase.Row3 = 10
        Me.lsv_Envase.Row4 = 10
        Me.lsv_Envase.Row5 = 10
        Me.lsv_Envase.Row6 = 10
        Me.lsv_Envase.Row7 = 10
        Me.lsv_Envase.Row8 = 10
        Me.lsv_Envase.Row9 = 10
        Me.lsv_Envase.Size = New System.Drawing.Size(758, 133)
        Me.lsv_Envase.TabIndex = 12
        Me.lsv_Envase.UseCompatibleStateImageBehavior = False
        Me.lsv_Envase.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(624, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 10
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(10, 23)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 6
        Me.lbl_Buscar.Text = "Buscar"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(56, 20)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(394, 20)
        Me.tbx_Buscar.TabIndex = 7
        Me.tbx_Buscar.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = CType(resources.GetObject("btn_Buscar.Image"), System.Drawing.Image)
        Me.btn_Buscar.Location = New System.Drawing.Point(456, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(82, 25)
        Me.btn_Buscar.TabIndex = 8
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'frm_DevolucionMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.gbx_Materiales)
        Me.Controls.Add(Me.grp_Materiales)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_DevolucionMateriales"
        Me.Text = "Devolución de Materiales"
        Me.gbx_Materiales.ResumeLayout(False)
        Me.grp_Materiales.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbx_Materiales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents Lsv_Materiales As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_MaterialesT As Modulo_Recepcion.cp_Listview
    Friend WithEvents grp_Materiales As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_Buscar As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envase As Modulo_Recepcion.cp_Listview
End Class
