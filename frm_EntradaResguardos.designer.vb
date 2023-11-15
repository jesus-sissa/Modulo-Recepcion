<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EntradaResguardos
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
        Dim ListViewColumnSorter2 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_Recibir = New System.Windows.Forms.Button
        Me.gbx_Resguardos = New System.Windows.Forms.GroupBox
        Me.Lbl_Registros = New System.Windows.Forms.Label
        Me.lbl_Boveda = New System.Windows.Forms.Label
        Me.tbx_Cve_Boveda = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Boveda = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.Lsv_ResguardosD = New Modulo_Recepcion.cp_Listview
        Me.Lsv_ResguardosT = New Modulo_Recepcion.cp_Listview
        Me.Lsv_Resguardos = New Modulo_Recepcion.cp_Listview
        Me.lsv_Envases = New Modulo_Recepcion.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Resguardos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Recibir)
        Me.Gbx_Botones.Location = New System.Drawing.Point(9, 499)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(766, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(620, 13)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Recibir
        '
        Me.Btn_Recibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Recibir.Enabled = False
        Me.Btn_Recibir.Image = Global.Modulo_Recepcion.My.Resources.Resources.Money_Vault_32
        Me.Btn_Recibir.Location = New System.Drawing.Point(6, 13)
        Me.Btn_Recibir.Name = "Btn_Recibir"
        Me.Btn_Recibir.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Recibir.TabIndex = 0
        Me.Btn_Recibir.Text = "&Recibir"
        Me.Btn_Recibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Recibir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Recibir.UseVisualStyleBackColor = True
        '
        'gbx_Resguardos
        '
        Me.gbx_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Resguardos.Controls.Add(Me.lsv_Envases)
        Me.gbx_Resguardos.Controls.Add(Me.Lbl_Registros)
        Me.gbx_Resguardos.Controls.Add(Me.lbl_Boveda)
        Me.gbx_Resguardos.Controls.Add(Me.tbx_Cve_Boveda)
        Me.gbx_Resguardos.Controls.Add(Me.Lsv_ResguardosD)
        Me.gbx_Resguardos.Controls.Add(Me.cmb_Boveda)
        Me.gbx_Resguardos.Controls.Add(Me.Lsv_ResguardosT)
        Me.gbx_Resguardos.Controls.Add(Me.Lsv_Resguardos)
        Me.gbx_Resguardos.Location = New System.Drawing.Point(9, 2)
        Me.gbx_Resguardos.Name = "gbx_Resguardos"
        Me.gbx_Resguardos.Size = New System.Drawing.Size(766, 491)
        Me.gbx_Resguardos.TabIndex = 0
        Me.gbx_Resguardos.TabStop = False
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
        'lbl_Boveda
        '
        Me.lbl_Boveda.AutoSize = True
        Me.lbl_Boveda.Location = New System.Drawing.Point(9, 18)
        Me.lbl_Boveda.Name = "lbl_Boveda"
        Me.lbl_Boveda.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Boveda.TabIndex = 0
        Me.lbl_Boveda.Text = "Bóveda"
        '
        'tbx_Cve_Boveda
        '
        Me.tbx_Cve_Boveda.Control_Siguiente = Me.cmb_Boveda
        Me.tbx_Cve_Boveda.Filtrado = True
        Me.tbx_Cve_Boveda.Location = New System.Drawing.Point(59, 15)
        Me.tbx_Cve_Boveda.MaxLength = 4
        Me.tbx_Cve_Boveda.Name = "tbx_Cve_Boveda"
        Me.tbx_Cve_Boveda.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cve_Boveda.TabIndex = 1
        Me.tbx_Cve_Boveda.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Boveda
        '
        Me.cmb_Boveda.Clave = "Clave"
        Me.cmb_Boveda.Control_Siguiente = Nothing
        Me.cmb_Boveda.DisplayMember = "Descripcion"
        Me.cmb_Boveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Boveda.Empresa = False
        Me.cmb_Boveda.Filtro = Me.tbx_Cve_Boveda
        Me.cmb_Boveda.FormattingEnabled = True
        Me.cmb_Boveda.Location = New System.Drawing.Point(115, 15)
        Me.cmb_Boveda.MaxDropDownItems = 20
        Me.cmb_Boveda.Name = "cmb_Boveda"
        Me.cmb_Boveda.Pista = False
        Me.cmb_Boveda.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Boveda.StoredProcedure = "Cat_Bovedas_ComboGet"
        Me.cmb_Boveda.Sucursal = True
        Me.cmb_Boveda.TabIndex = 2
        Me.cmb_Boveda.Tipo = 0
        Me.cmb_Boveda.ValueMember = "Id_Boveda"
        '
        'Lsv_ResguardosD
        '
        Me.Lsv_ResguardosD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ResguardosD.FullRowSelect = True
        Me.Lsv_ResguardosD.HideSelection = False
        Me.Lsv_ResguardosD.Location = New System.Drawing.Point(7, 268)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.Lsv_ResguardosD.Lvs = ListViewColumnSorter2
        Me.Lsv_ResguardosD.MultiSelect = False
        Me.Lsv_ResguardosD.Name = "Lsv_ResguardosD"
        Me.Lsv_ResguardosD.Row1 = 12
        Me.Lsv_ResguardosD.Row10 = 0
        Me.Lsv_ResguardosD.Row2 = 15
        Me.Lsv_ResguardosD.Row3 = 15
        Me.Lsv_ResguardosD.Row4 = 0
        Me.Lsv_ResguardosD.Row5 = 0
        Me.Lsv_ResguardosD.Row6 = 0
        Me.Lsv_ResguardosD.Row7 = 0
        Me.Lsv_ResguardosD.Row8 = 0
        Me.Lsv_ResguardosD.Row9 = 0
        Me.Lsv_ResguardosD.Size = New System.Drawing.Size(753, 110)
        Me.Lsv_ResguardosD.TabIndex = 5
        Me.Lsv_ResguardosD.TabStop = False
        Me.Lsv_ResguardosD.UseCompatibleStateImageBehavior = False
        Me.Lsv_ResguardosD.View = System.Windows.Forms.View.Details
        '
        'Lsv_ResguardosT
        '
        Me.Lsv_ResguardosT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_ResguardosT.FullRowSelect = True
        Me.Lsv_ResguardosT.HideSelection = False
        Me.Lsv_ResguardosT.Location = New System.Drawing.Point(6, 161)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_ResguardosT.Lvs = ListViewColumnSorter3
        Me.Lsv_ResguardosT.MultiSelect = False
        Me.Lsv_ResguardosT.Name = "Lsv_ResguardosT"
        Me.Lsv_ResguardosT.Row1 = 10
        Me.Lsv_ResguardosT.Row10 = 10
        Me.Lsv_ResguardosT.Row2 = 10
        Me.Lsv_ResguardosT.Row3 = 10
        Me.Lsv_ResguardosT.Row4 = 10
        Me.Lsv_ResguardosT.Row5 = 10
        Me.Lsv_ResguardosT.Row6 = 10
        Me.Lsv_ResguardosT.Row7 = 10
        Me.Lsv_ResguardosT.Row8 = 10
        Me.Lsv_ResguardosT.Row9 = 10
        Me.Lsv_ResguardosT.Size = New System.Drawing.Size(754, 103)
        Me.Lsv_ResguardosT.TabIndex = 4
        Me.Lsv_ResguardosT.UseCompatibleStateImageBehavior = False
        Me.Lsv_ResguardosT.View = System.Windows.Forms.View.Details
        '
        'Lsv_Resguardos
        '
        Me.Lsv_Resguardos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Resguardos.FullRowSelect = True
        Me.Lsv_Resguardos.HideSelection = False
        Me.Lsv_Resguardos.Location = New System.Drawing.Point(6, 42)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.Lsv_Resguardos.Lvs = ListViewColumnSorter4
        Me.Lsv_Resguardos.MultiSelect = False
        Me.Lsv_Resguardos.Name = "Lsv_Resguardos"
        Me.Lsv_Resguardos.Row1 = 8
        Me.Lsv_Resguardos.Row10 = 0
        Me.Lsv_Resguardos.Row2 = 8
        Me.Lsv_Resguardos.Row3 = 40
        Me.Lsv_Resguardos.Row4 = 10
        Me.Lsv_Resguardos.Row5 = 10
        Me.Lsv_Resguardos.Row6 = 10
        Me.Lsv_Resguardos.Row7 = 0
        Me.Lsv_Resguardos.Row8 = 0
        Me.Lsv_Resguardos.Row9 = 0
        Me.Lsv_Resguardos.Size = New System.Drawing.Size(754, 115)
        Me.Lsv_Resguardos.TabIndex = 3
        Me.Lsv_Resguardos.UseCompatibleStateImageBehavior = False
        Me.Lsv_Resguardos.View = System.Windows.Forms.View.Details
        '
        'lsv_Envases
        '
        Me.lsv_Envases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Envases.FullRowSelect = True
        Me.lsv_Envases.HideSelection = False
        Me.lsv_Envases.Location = New System.Drawing.Point(6, 384)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Envases.Lvs = ListViewColumnSorter1
        Me.lsv_Envases.MultiSelect = False
        Me.lsv_Envases.Name = "lsv_Envases"
        Me.lsv_Envases.Row1 = 12
        Me.lsv_Envases.Row10 = 0
        Me.lsv_Envases.Row2 = 15
        Me.lsv_Envases.Row3 = 15
        Me.lsv_Envases.Row4 = 0
        Me.lsv_Envases.Row5 = 0
        Me.lsv_Envases.Row6 = 0
        Me.lsv_Envases.Row7 = 0
        Me.lsv_Envases.Row8 = 0
        Me.lsv_Envases.Row9 = 0
        Me.lsv_Envases.Size = New System.Drawing.Size(754, 98)
        Me.lsv_Envases.TabIndex = 14
        Me.lsv_Envases.TabStop = False
        Me.lsv_Envases.UseCompatibleStateImageBehavior = False
        Me.lsv_Envases.View = System.Windows.Forms.View.Details
        '
        'frm_EntradaResguardos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Resguardos)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EntradaResguardos"
        Me.Text = "Recepción de Resguardos"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Resguardos.ResumeLayout(False)
        Me.gbx_Resguardos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lsv_Resguardos As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lsv_ResguardosD As Modulo_Recepcion.cp_Listview
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Recibir As System.Windows.Forms.Button
    Friend WithEvents gbx_Resguardos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Boveda As System.Windows.Forms.Label
    Friend WithEvents tbx_Cve_Boveda As Modulo_Recepcion.cp_Textbox
    Friend WithEvents cmb_Boveda As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lsv_ResguardosT As Modulo_Recepcion.cp_Listview
    Friend WithEvents Lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents lsv_Envases As Modulo_Recepcion.cp_Listview
End Class
