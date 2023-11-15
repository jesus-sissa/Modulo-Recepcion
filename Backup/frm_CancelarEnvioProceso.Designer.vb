<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelarEnvioProceso
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_Lista = New System.Windows.Forms.GroupBox
        Me.lsv_Detalles = New Modulo_Recepcion.cp_Listview
        Me.lsv_Envios = New Modulo_Recepcion.cp_Listview
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 507)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(620, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 0
        Me.btn_Cancelar.Text = "C&ancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Lista.Controls.Add(Me.lsv_Detalles)
        Me.gbx_Lista.Controls.Add(Me.lsv_Envios)
        Me.gbx_Lista.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(766, 499)
        Me.gbx_Lista.TabIndex = 0
        Me.gbx_Lista.TabStop = False
        '
        'lsv_Detalles
        '
        Me.lsv_Detalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalles.FullRowSelect = True
        Me.lsv_Detalles.HideSelection = False
        Me.lsv_Detalles.Location = New System.Drawing.Point(6, 246)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Detalles.Lvs = ListViewColumnSorter1
        Me.lsv_Detalles.MultiSelect = False
        Me.lsv_Detalles.Name = "lsv_Detalles"
        Me.lsv_Detalles.Row1 = 10
        Me.lsv_Detalles.Row10 = 10
        Me.lsv_Detalles.Row2 = 20
        Me.lsv_Detalles.Row3 = 20
        Me.lsv_Detalles.Row4 = 10
        Me.lsv_Detalles.Row5 = 10
        Me.lsv_Detalles.Row6 = 10
        Me.lsv_Detalles.Row7 = 10
        Me.lsv_Detalles.Row8 = 10
        Me.lsv_Detalles.Row9 = 10
        Me.lsv_Detalles.Size = New System.Drawing.Size(754, 247)
        Me.lsv_Detalles.TabIndex = 1
        Me.lsv_Detalles.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalles.View = System.Windows.Forms.View.Details
        '
        'lsv_Envios
        '
        Me.lsv_Envios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envios.CheckBoxes = True
        Me.lsv_Envios.FullRowSelect = True
        Me.lsv_Envios.HideSelection = False
        Me.lsv_Envios.Location = New System.Drawing.Point(6, 34)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Envios.Lvs = ListViewColumnSorter2
        Me.lsv_Envios.MultiSelect = False
        Me.lsv_Envios.Name = "lsv_Envios"
        Me.lsv_Envios.Row1 = 7
        Me.lsv_Envios.Row10 = 0
        Me.lsv_Envios.Row2 = 20
        Me.lsv_Envios.Row3 = 7
        Me.lsv_Envios.Row4 = 7
        Me.lsv_Envios.Row5 = 7
        Me.lsv_Envios.Row6 = 7
        Me.lsv_Envios.Row7 = 0
        Me.lsv_Envios.Row8 = 0
        Me.lsv_Envios.Row9 = 0
        Me.lsv_Envios.Size = New System.Drawing.Size(754, 206)
        Me.lsv_Envios.TabIndex = 0
        Me.lsv_Envios.UseCompatibleStateImageBehavior = False
        Me.lsv_Envios.View = System.Windows.Forms.View.Details
        '
        'Lbl_Registros
        '
        Me.Lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Registros.Location = New System.Drawing.Point(620, 16)
        Me.Lbl_Registros.Name = "Lbl_Registros"
        Me.Lbl_Registros.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_Registros.TabIndex = 12
        Me.Lbl_Registros.Text = "Registros: 0"
        Me.Lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_CancelarEnvioProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 569)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Lista)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CancelarEnvioProceso"
        Me.Text = "Cancelar Envio a Proceso"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Lista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envios As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Detalles As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
End Class
