<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelarEnvioMorralla
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
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_lista = New System.Windows.Forms.GroupBox
        Me.Lbl_RegistrosDA = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Recepcion.cp_Textbox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Remisiones = New Modulo_Recepcion.cp_Listview
        Me.gbx_botones.SuspendLayout()
        Me.gbx_lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_botones
        '
        Me.gbx_botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_botones.Location = New System.Drawing.Point(8, 499)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(767, 50)
        Me.gbx_botones.TabIndex = 1
        Me.gbx_botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(621, 13)
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
        'gbx_lista
        '
        Me.gbx_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_lista.Controls.Add(Me.Lbl_RegistrosDA)
        Me.gbx_lista.Controls.Add(Me.tbx_Buscar)
        Me.gbx_lista.Controls.Add(Me.btn_Buscar)
        Me.gbx_lista.Controls.Add(Me.lsv_Envases)
        Me.gbx_lista.Controls.Add(Me.lbl_Buscar)
        Me.gbx_lista.Controls.Add(Me.lsv_Remisiones)
        Me.gbx_lista.Location = New System.Drawing.Point(8, 12)
        Me.gbx_lista.Name = "gbx_lista"
        Me.gbx_lista.Size = New System.Drawing.Size(767, 481)
        Me.gbx_lista.TabIndex = 0
        Me.gbx_lista.TabStop = False
        '
        'Lbl_RegistrosDA
        '
        Me.Lbl_RegistrosDA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosDA.Location = New System.Drawing.Point(621, 30)
        Me.Lbl_RegistrosDA.Name = "Lbl_RegistrosDA"
        Me.Lbl_RegistrosDA.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosDA.TabIndex = 12
        Me.Lbl_RegistrosDA.Text = "Registros: 0"
        Me.Lbl_RegistrosDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(52, 21)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(263, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(321, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "&Buscar"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 345)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 15
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 15
        Me.lsv_Envases.Row3 = 0
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(755, 130)
        Me.lsv_Envases.TabIndex = 5
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(6, 24)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar"
        '
        'lsv_Remisiones
        '
        Me.lsv_Remisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remisiones.CheckBoxes = True
        Me.lsv_Remisiones.FullRowSelect = True
        Me.lsv_Remisiones.HideSelection = False
        Me.lsv_Remisiones.Location = New System.Drawing.Point(6, 48)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Remisiones.Lvs = ListViewColumnSorter2
        Me.lsv_Remisiones.MultiSelect = False
        Me.lsv_Remisiones.Name = "lsv_Remisiones"
        Me.lsv_Remisiones.Row1 = 8
        Me.lsv_Remisiones.Row10 = 0
        Me.lsv_Remisiones.Row2 = 7
        Me.lsv_Remisiones.Row3 = 7
        Me.lsv_Remisiones.Row4 = 7
        Me.lsv_Remisiones.Row5 = 20
        Me.lsv_Remisiones.Row6 = 22
        Me.lsv_Remisiones.Row7 = 22
        Me.lsv_Remisiones.Row8 = 0
        Me.lsv_Remisiones.Row9 = 0
        Me.lsv_Remisiones.Size = New System.Drawing.Size(755, 291)
        Me.lsv_Remisiones.TabIndex = 4
        Me.lsv_Remisiones.UseCompatibleStateImageBehavior = False
        Me.lsv_Remisiones.View = System.Windows.Forms.View.Details
        '
        'frm_CancelarEnvioMorralla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_lista)
        Me.Controls.Add(Me.gbx_botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CancelarEnvioMorralla"
        Me.Text = "Cancelar Envio a Morralla"
        Me.gbx_botones.ResumeLayout(False)
        Me.gbx_lista.ResumeLayout(False)
        Me.gbx_lista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_lista As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Remisiones As Modulo_Recepcion.cp_Listview
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosDA As System.Windows.Forms.Label
End Class
