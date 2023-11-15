<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CancelarEnvioCajeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CancelarEnvioCajeros))
        Dim ListViewColumnSorter22 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter23 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter24 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter25 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter26 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter27 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter19 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter20 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Dim ListViewColumnSorter21 As Modulo_Recepcion.ListViewColumnSorter = New Modulo_Recepcion.ListViewColumnSorter
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_Remanentes = New System.Windows.Forms.GroupBox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.btn_BuscarR = New System.Windows.Forms.Button
        Me.lbl_RegistrosR = New System.Windows.Forms.Label
        Me.tab_Principal = New System.Windows.Forms.TabControl
        Me.Tab_Remanentes = New System.Windows.Forms.TabPage
        Me.tab_Dotaciones = New System.Windows.Forms.TabPage
        Me.gbx_Dotaciones = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_BuscarDP = New System.Windows.Forms.Button
        Me.Lbl_RegistrosDP = New System.Windows.Forms.Label
        Me.tab_DotacionesA = New System.Windows.Forms.TabPage
        Me.gbx_DotacionesA = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_BuscarAd = New System.Windows.Forms.Button
        Me.Lbl_RegistrosDA = New System.Windows.Forms.Label
        Me.tbx_BuscarR = New Modulo_Recepcion.cp_Textbox
        Me.lsv_EnvasesR = New Modulo_Recepcion.cp_Listview
        Me.lsv_RemanentesD = New Modulo_Recepcion.cp_Listview
        Me.lsv_Remanentes = New Modulo_Recepcion.cp_Listview
        Me.tbx_BuscarDP = New Modulo_Recepcion.cp_Textbox
        Me.lsv_EnvasesDP = New Modulo_Recepcion.cp_Listview
        Me.lsv_DotacionesD = New Modulo_Recepcion.cp_Listview
        Me.lsv_Dotaciones = New Modulo_Recepcion.cp_Listview
        Me.tbx_BuscarAD = New Modulo_Recepcion.cp_Textbox
        Me.lsv_EnvasesDA = New Modulo_Recepcion.cp_Listview
        Me.lsv_DotacionesAD = New Modulo_Recepcion.cp_Listview
        Me.lsv_DotacionesA = New Modulo_Recepcion.cp_Listview
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Remanentes.SuspendLayout()
        Me.tab_Principal.SuspendLayout()
        Me.Tab_Remanentes.SuspendLayout()
        Me.tab_Dotaciones.SuspendLayout()
        Me.gbx_Dotaciones.SuspendLayout()
        Me.tab_DotacionesA.SuspendLayout()
        Me.gbx_DotacionesA.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 525)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(688, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(542, 13)
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
        'gbx_Remanentes
        '
        Me.gbx_Remanentes.Controls.Add(Me.lbl_Buscar)
        Me.gbx_Remanentes.Controls.Add(Me.tbx_BuscarR)
        Me.gbx_Remanentes.Controls.Add(Me.btn_BuscarR)
        Me.gbx_Remanentes.Controls.Add(Me.lsv_EnvasesR)
        Me.gbx_Remanentes.Controls.Add(Me.lbl_RegistrosR)
        Me.gbx_Remanentes.Controls.Add(Me.lsv_RemanentesD)
        Me.gbx_Remanentes.Controls.Add(Me.lsv_Remanentes)
        Me.gbx_Remanentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Remanentes.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Remanentes.Name = "gbx_Remanentes"
        Me.gbx_Remanentes.Size = New System.Drawing.Size(680, 480)
        Me.gbx_Remanentes.TabIndex = 0
        Me.gbx_Remanentes.TabStop = False
        Me.gbx_Remanentes.Text = "Remanentes"
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(6, 42)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 16
        Me.lbl_Buscar.Text = "Buscar"
        '
        'btn_BuscarR
        '
        Me.btn_BuscarR.Image = CType(resources.GetObject("btn_BuscarR.Image"), System.Drawing.Image)
        Me.btn_BuscarR.Location = New System.Drawing.Point(452, 36)
        Me.btn_BuscarR.Name = "btn_BuscarR"
        Me.btn_BuscarR.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarR.TabIndex = 18
        Me.btn_BuscarR.Text = "&Buscar"
        Me.btn_BuscarR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarR.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosR
        '
        Me.lbl_RegistrosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosR.Location = New System.Drawing.Point(534, 16)
        Me.lbl_RegistrosR.Name = "lbl_RegistrosR"
        Me.lbl_RegistrosR.Size = New System.Drawing.Size(140, 15)
        Me.lbl_RegistrosR.TabIndex = 11
        Me.lbl_RegistrosR.Text = "Registros: 0"
        Me.lbl_RegistrosR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tab_Principal
        '
        Me.tab_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_Principal.Controls.Add(Me.Tab_Remanentes)
        Me.tab_Principal.Controls.Add(Me.tab_Dotaciones)
        Me.tab_Principal.Controls.Add(Me.tab_DotacionesA)
        Me.tab_Principal.Location = New System.Drawing.Point(6, 7)
        Me.tab_Principal.Name = "tab_Principal"
        Me.tab_Principal.SelectedIndex = 0
        Me.tab_Principal.Size = New System.Drawing.Size(694, 512)
        Me.tab_Principal.TabIndex = 2
        '
        'Tab_Remanentes
        '
        Me.Tab_Remanentes.Controls.Add(Me.gbx_Remanentes)
        Me.Tab_Remanentes.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Remanentes.Name = "Tab_Remanentes"
        Me.Tab_Remanentes.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Remanentes.Size = New System.Drawing.Size(686, 486)
        Me.Tab_Remanentes.TabIndex = 0
        Me.Tab_Remanentes.Text = "Remanentes"
        Me.Tab_Remanentes.UseVisualStyleBackColor = True
        '
        'tab_Dotaciones
        '
        Me.tab_Dotaciones.Controls.Add(Me.gbx_Dotaciones)
        Me.tab_Dotaciones.Location = New System.Drawing.Point(4, 22)
        Me.tab_Dotaciones.Name = "tab_Dotaciones"
        Me.tab_Dotaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Dotaciones.Size = New System.Drawing.Size(686, 486)
        Me.tab_Dotaciones.TabIndex = 1
        Me.tab_Dotaciones.Text = "Dotaciones Proceso"
        Me.tab_Dotaciones.UseVisualStyleBackColor = True
        '
        'gbx_Dotaciones
        '
        Me.gbx_Dotaciones.Controls.Add(Me.Label1)
        Me.gbx_Dotaciones.Controls.Add(Me.tbx_BuscarDP)
        Me.gbx_Dotaciones.Controls.Add(Me.btn_BuscarDP)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_EnvasesDP)
        Me.gbx_Dotaciones.Controls.Add(Me.Lbl_RegistrosDP)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_DotacionesD)
        Me.gbx_Dotaciones.Controls.Add(Me.lsv_Dotaciones)
        Me.gbx_Dotaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Dotaciones.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Dotaciones.Name = "gbx_Dotaciones"
        Me.gbx_Dotaciones.Size = New System.Drawing.Size(680, 480)
        Me.gbx_Dotaciones.TabIndex = 1
        Me.gbx_Dotaciones.TabStop = False
        Me.gbx_Dotaciones.Text = "Dotaciones Proceso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar"
        '
        'btn_BuscarDP
        '
        Me.btn_BuscarDP.Image = CType(resources.GetObject("btn_BuscarDP.Image"), System.Drawing.Image)
        Me.btn_BuscarDP.Location = New System.Drawing.Point(452, 40)
        Me.btn_BuscarDP.Name = "btn_BuscarDP"
        Me.btn_BuscarDP.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarDP.TabIndex = 21
        Me.btn_BuscarDP.Text = "&Buscar"
        Me.btn_BuscarDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarDP.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosDP
        '
        Me.Lbl_RegistrosDP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosDP.Location = New System.Drawing.Point(534, 16)
        Me.Lbl_RegistrosDP.Name = "Lbl_RegistrosDP"
        Me.Lbl_RegistrosDP.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosDP.TabIndex = 11
        Me.Lbl_RegistrosDP.Text = "Registros: 0"
        Me.Lbl_RegistrosDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tab_DotacionesA
        '
        Me.tab_DotacionesA.Controls.Add(Me.gbx_DotacionesA)
        Me.tab_DotacionesA.Location = New System.Drawing.Point(4, 22)
        Me.tab_DotacionesA.Name = "tab_DotacionesA"
        Me.tab_DotacionesA.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DotacionesA.Size = New System.Drawing.Size(686, 486)
        Me.tab_DotacionesA.TabIndex = 2
        Me.tab_DotacionesA.Text = "Dotaciones Auditoría"
        Me.tab_DotacionesA.UseVisualStyleBackColor = True
        '
        'gbx_DotacionesA
        '
        Me.gbx_DotacionesA.Controls.Add(Me.Label2)
        Me.gbx_DotacionesA.Controls.Add(Me.tbx_BuscarAD)
        Me.gbx_DotacionesA.Controls.Add(Me.btn_BuscarAd)
        Me.gbx_DotacionesA.Controls.Add(Me.lsv_EnvasesDA)
        Me.gbx_DotacionesA.Controls.Add(Me.Lbl_RegistrosDA)
        Me.gbx_DotacionesA.Controls.Add(Me.lsv_DotacionesAD)
        Me.gbx_DotacionesA.Controls.Add(Me.lsv_DotacionesA)
        Me.gbx_DotacionesA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_DotacionesA.Location = New System.Drawing.Point(3, 3)
        Me.gbx_DotacionesA.Name = "gbx_DotacionesA"
        Me.gbx_DotacionesA.Size = New System.Drawing.Size(680, 480)
        Me.gbx_DotacionesA.TabIndex = 2
        Me.gbx_DotacionesA.TabStop = False
        Me.gbx_DotacionesA.Text = "Dotaciones Auditoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Buscar"
        '
        'btn_BuscarAd
        '
        Me.btn_BuscarAd.Image = CType(resources.GetObject("btn_BuscarAd.Image"), System.Drawing.Image)
        Me.btn_BuscarAd.Location = New System.Drawing.Point(452, 31)
        Me.btn_BuscarAd.Name = "btn_BuscarAd"
        Me.btn_BuscarAd.Size = New System.Drawing.Size(82, 25)
        Me.btn_BuscarAd.TabIndex = 24
        Me.btn_BuscarAd.Text = "&Buscar"
        Me.btn_BuscarAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarAd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarAd.UseVisualStyleBackColor = True
        '
        'Lbl_RegistrosDA
        '
        Me.Lbl_RegistrosDA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_RegistrosDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RegistrosDA.Location = New System.Drawing.Point(534, 47)
        Me.Lbl_RegistrosDA.Name = "Lbl_RegistrosDA"
        Me.Lbl_RegistrosDA.Size = New System.Drawing.Size(140, 15)
        Me.Lbl_RegistrosDA.TabIndex = 11
        Me.Lbl_RegistrosDA.Text = "Registros: 0"
        Me.Lbl_RegistrosDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_BuscarR
        '
        Me.tbx_BuscarR.Control_Siguiente = Nothing
        Me.tbx_BuscarR.Filtrado = False
        Me.tbx_BuscarR.Location = New System.Drawing.Point(52, 39)
        Me.tbx_BuscarR.Name = "tbx_BuscarR"
        Me.tbx_BuscarR.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarR.TabIndex = 17
        Me.tbx_BuscarR.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_EnvasesR
        '
        Me.lsv_EnvasesR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesR.FullRowSelect = True
        Me.lsv_EnvasesR.HideSelection = False
        Me.lsv_EnvasesR.Location = New System.Drawing.Point(6, 357)
        ListViewColumnSorter22.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter22.SortColumn = 0
        Me.lsv_EnvasesR.Lvs = ListViewColumnSorter22
        Me.lsv_EnvasesR.MultiSelect = False
        Me.lsv_EnvasesR.Name = "lsv_EnvasesR"
        Me.lsv_EnvasesR.Row1 = 10
        Me.lsv_EnvasesR.Row10 = 10
        Me.lsv_EnvasesR.Row2 = 20
        Me.lsv_EnvasesR.Row3 = 20
        Me.lsv_EnvasesR.Row4 = 10
        Me.lsv_EnvasesR.Row5 = 10
        Me.lsv_EnvasesR.Row6 = 10
        Me.lsv_EnvasesR.Row7 = 10
        Me.lsv_EnvasesR.Row8 = 10
        Me.lsv_EnvasesR.Row9 = 10
        Me.lsv_EnvasesR.Size = New System.Drawing.Size(668, 117)
        Me.lsv_EnvasesR.TabIndex = 13
        Me.lsv_EnvasesR.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesR.View = System.Windows.Forms.View.Details
        '
        'lsv_RemanentesD
        '
        Me.lsv_RemanentesD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_RemanentesD.FullRowSelect = True
        Me.lsv_RemanentesD.HideSelection = False
        Me.lsv_RemanentesD.Location = New System.Drawing.Point(6, 243)
        ListViewColumnSorter23.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter23.SortColumn = 0
        Me.lsv_RemanentesD.Lvs = ListViewColumnSorter23
        Me.lsv_RemanentesD.MultiSelect = False
        Me.lsv_RemanentesD.Name = "lsv_RemanentesD"
        Me.lsv_RemanentesD.Row1 = 10
        Me.lsv_RemanentesD.Row10 = 10
        Me.lsv_RemanentesD.Row2 = 20
        Me.lsv_RemanentesD.Row3 = 20
        Me.lsv_RemanentesD.Row4 = 10
        Me.lsv_RemanentesD.Row5 = 10
        Me.lsv_RemanentesD.Row6 = 10
        Me.lsv_RemanentesD.Row7 = 10
        Me.lsv_RemanentesD.Row8 = 10
        Me.lsv_RemanentesD.Row9 = 10
        Me.lsv_RemanentesD.Size = New System.Drawing.Size(668, 111)
        Me.lsv_RemanentesD.TabIndex = 1
        Me.lsv_RemanentesD.UseCompatibleStateImageBehavior = False
        Me.lsv_RemanentesD.View = System.Windows.Forms.View.Details
        '
        'lsv_Remanentes
        '
        Me.lsv_Remanentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Remanentes.CheckBoxes = True
        Me.lsv_Remanentes.FullRowSelect = True
        Me.lsv_Remanentes.HideSelection = False
        Me.lsv_Remanentes.Location = New System.Drawing.Point(6, 78)
        ListViewColumnSorter24.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter24.SortColumn = 0
        Me.lsv_Remanentes.Lvs = ListViewColumnSorter24
        Me.lsv_Remanentes.MultiSelect = False
        Me.lsv_Remanentes.Name = "lsv_Remanentes"
        Me.lsv_Remanentes.Row1 = 12
        Me.lsv_Remanentes.Row10 = 0
        Me.lsv_Remanentes.Row2 = 30
        Me.lsv_Remanentes.Row3 = 12
        Me.lsv_Remanentes.Row4 = 12
        Me.lsv_Remanentes.Row5 = 12
        Me.lsv_Remanentes.Row6 = 12
        Me.lsv_Remanentes.Row7 = 0
        Me.lsv_Remanentes.Row8 = 0
        Me.lsv_Remanentes.Row9 = 0
        Me.lsv_Remanentes.Size = New System.Drawing.Size(668, 159)
        Me.lsv_Remanentes.TabIndex = 0
        Me.lsv_Remanentes.UseCompatibleStateImageBehavior = False
        Me.lsv_Remanentes.View = System.Windows.Forms.View.Details
        '
        'tbx_BuscarDP
        '
        Me.tbx_BuscarDP.Control_Siguiente = Nothing
        Me.tbx_BuscarDP.Filtrado = False
        Me.tbx_BuscarDP.Location = New System.Drawing.Point(52, 43)
        Me.tbx_BuscarDP.Name = "tbx_BuscarDP"
        Me.tbx_BuscarDP.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarDP.TabIndex = 20
        Me.tbx_BuscarDP.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_EnvasesDP
        '
        Me.lsv_EnvasesDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesDP.FullRowSelect = True
        Me.lsv_EnvasesDP.HideSelection = False
        Me.lsv_EnvasesDP.Location = New System.Drawing.Point(6, 359)
        ListViewColumnSorter25.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter25.SortColumn = 0
        Me.lsv_EnvasesDP.Lvs = ListViewColumnSorter25
        Me.lsv_EnvasesDP.MultiSelect = False
        Me.lsv_EnvasesDP.Name = "lsv_EnvasesDP"
        Me.lsv_EnvasesDP.Row1 = 10
        Me.lsv_EnvasesDP.Row10 = 10
        Me.lsv_EnvasesDP.Row2 = 20
        Me.lsv_EnvasesDP.Row3 = 20
        Me.lsv_EnvasesDP.Row4 = 10
        Me.lsv_EnvasesDP.Row5 = 10
        Me.lsv_EnvasesDP.Row6 = 10
        Me.lsv_EnvasesDP.Row7 = 10
        Me.lsv_EnvasesDP.Row8 = 10
        Me.lsv_EnvasesDP.Row9 = 10
        Me.lsv_EnvasesDP.Size = New System.Drawing.Size(668, 116)
        Me.lsv_EnvasesDP.TabIndex = 13
        Me.lsv_EnvasesDP.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesDP.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionesD
        '
        Me.lsv_DotacionesD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionesD.FullRowSelect = True
        Me.lsv_DotacionesD.HideSelection = False
        Me.lsv_DotacionesD.Location = New System.Drawing.Point(6, 241)
        ListViewColumnSorter26.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter26.SortColumn = 0
        Me.lsv_DotacionesD.Lvs = ListViewColumnSorter26
        Me.lsv_DotacionesD.MultiSelect = False
        Me.lsv_DotacionesD.Name = "lsv_DotacionesD"
        Me.lsv_DotacionesD.Row1 = 10
        Me.lsv_DotacionesD.Row10 = 10
        Me.lsv_DotacionesD.Row2 = 20
        Me.lsv_DotacionesD.Row3 = 20
        Me.lsv_DotacionesD.Row4 = 10
        Me.lsv_DotacionesD.Row5 = 10
        Me.lsv_DotacionesD.Row6 = 10
        Me.lsv_DotacionesD.Row7 = 10
        Me.lsv_DotacionesD.Row8 = 10
        Me.lsv_DotacionesD.Row9 = 10
        Me.lsv_DotacionesD.Size = New System.Drawing.Size(668, 116)
        Me.lsv_DotacionesD.TabIndex = 1
        Me.lsv_DotacionesD.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionesD.View = System.Windows.Forms.View.Details
        '
        'lsv_Dotaciones
        '
        Me.lsv_Dotaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Dotaciones.CheckBoxes = True
        Me.lsv_Dotaciones.FullRowSelect = True
        Me.lsv_Dotaciones.HideSelection = False
        Me.lsv_Dotaciones.Location = New System.Drawing.Point(6, 78)
        ListViewColumnSorter27.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter27.SortColumn = 0
        Me.lsv_Dotaciones.Lvs = ListViewColumnSorter27
        Me.lsv_Dotaciones.MultiSelect = False
        Me.lsv_Dotaciones.Name = "lsv_Dotaciones"
        Me.lsv_Dotaciones.Row1 = 12
        Me.lsv_Dotaciones.Row10 = 0
        Me.lsv_Dotaciones.Row2 = 30
        Me.lsv_Dotaciones.Row3 = 12
        Me.lsv_Dotaciones.Row4 = 12
        Me.lsv_Dotaciones.Row5 = 12
        Me.lsv_Dotaciones.Row6 = 12
        Me.lsv_Dotaciones.Row7 = 0
        Me.lsv_Dotaciones.Row8 = 0
        Me.lsv_Dotaciones.Row9 = 0
        Me.lsv_Dotaciones.Size = New System.Drawing.Size(668, 159)
        Me.lsv_Dotaciones.TabIndex = 0
        Me.lsv_Dotaciones.UseCompatibleStateImageBehavior = False
        Me.lsv_Dotaciones.View = System.Windows.Forms.View.Details
        '
        'tbx_BuscarAD
        '
        Me.tbx_BuscarAD.Control_Siguiente = Nothing
        Me.tbx_BuscarAD.Filtrado = False
        Me.tbx_BuscarAD.Location = New System.Drawing.Point(52, 34)
        Me.tbx_BuscarAD.Name = "tbx_BuscarAD"
        Me.tbx_BuscarAD.Size = New System.Drawing.Size(394, 20)
        Me.tbx_BuscarAD.TabIndex = 23
        Me.tbx_BuscarAD.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_EnvasesDA
        '
        Me.lsv_EnvasesDA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EnvasesDA.FullRowSelect = True
        Me.lsv_EnvasesDA.HideSelection = False
        Me.lsv_EnvasesDA.Location = New System.Drawing.Point(6, 368)
        ListViewColumnSorter19.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter19.SortColumn = 0
        Me.lsv_EnvasesDA.Lvs = ListViewColumnSorter19
        Me.lsv_EnvasesDA.MultiSelect = False
        Me.lsv_EnvasesDA.Name = "lsv_EnvasesDA"
        Me.lsv_EnvasesDA.Row1 = 10
        Me.lsv_EnvasesDA.Row10 = 10
        Me.lsv_EnvasesDA.Row2 = 20
        Me.lsv_EnvasesDA.Row3 = 20
        Me.lsv_EnvasesDA.Row4 = 10
        Me.lsv_EnvasesDA.Row5 = 10
        Me.lsv_EnvasesDA.Row6 = 10
        Me.lsv_EnvasesDA.Row7 = 10
        Me.lsv_EnvasesDA.Row8 = 10
        Me.lsv_EnvasesDA.Row9 = 10
        Me.lsv_EnvasesDA.Size = New System.Drawing.Size(668, 106)
        Me.lsv_EnvasesDA.TabIndex = 13
        Me.lsv_EnvasesDA.UseCompatibleStateImageBehavior = False
        Me.lsv_EnvasesDA.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionesAD
        '
        Me.lsv_DotacionesAD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionesAD.FullRowSelect = True
        Me.lsv_DotacionesAD.HideSelection = False
        Me.lsv_DotacionesAD.Location = New System.Drawing.Point(6, 242)
        ListViewColumnSorter20.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter20.SortColumn = 0
        Me.lsv_DotacionesAD.Lvs = ListViewColumnSorter20
        Me.lsv_DotacionesAD.MultiSelect = False
        Me.lsv_DotacionesAD.Name = "lsv_DotacionesAD"
        Me.lsv_DotacionesAD.Row1 = 10
        Me.lsv_DotacionesAD.Row10 = 10
        Me.lsv_DotacionesAD.Row2 = 20
        Me.lsv_DotacionesAD.Row3 = 20
        Me.lsv_DotacionesAD.Row4 = 10
        Me.lsv_DotacionesAD.Row5 = 10
        Me.lsv_DotacionesAD.Row6 = 10
        Me.lsv_DotacionesAD.Row7 = 10
        Me.lsv_DotacionesAD.Row8 = 10
        Me.lsv_DotacionesAD.Row9 = 10
        Me.lsv_DotacionesAD.Size = New System.Drawing.Size(668, 122)
        Me.lsv_DotacionesAD.TabIndex = 1
        Me.lsv_DotacionesAD.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionesAD.View = System.Windows.Forms.View.Details
        '
        'lsv_DotacionesA
        '
        Me.lsv_DotacionesA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_DotacionesA.CheckBoxes = True
        Me.lsv_DotacionesA.FullRowSelect = True
        Me.lsv_DotacionesA.HideSelection = False
        Me.lsv_DotacionesA.Location = New System.Drawing.Point(6, 69)
        ListViewColumnSorter21.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter21.SortColumn = 0
        Me.lsv_DotacionesA.Lvs = ListViewColumnSorter21
        Me.lsv_DotacionesA.MultiSelect = False
        Me.lsv_DotacionesA.Name = "lsv_DotacionesA"
        Me.lsv_DotacionesA.Row1 = 12
        Me.lsv_DotacionesA.Row10 = 0
        Me.lsv_DotacionesA.Row2 = 30
        Me.lsv_DotacionesA.Row3 = 12
        Me.lsv_DotacionesA.Row4 = 12
        Me.lsv_DotacionesA.Row5 = 12
        Me.lsv_DotacionesA.Row6 = 12
        Me.lsv_DotacionesA.Row7 = 0
        Me.lsv_DotacionesA.Row8 = 0
        Me.lsv_DotacionesA.Row9 = 0
        Me.lsv_DotacionesA.Size = New System.Drawing.Size(668, 168)
        Me.lsv_DotacionesA.TabIndex = 0
        Me.lsv_DotacionesA.UseCompatibleStateImageBehavior = False
        Me.lsv_DotacionesA.View = System.Windows.Forms.View.Details
        '
        'frm_CancelarEnvioCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 587)
        Me.Controls.Add(Me.tab_Principal)
        Me.Controls.Add(Me.gbx_Botones)
        Me.MinimizeBox = False
        Me.Name = "frm_CancelarEnvioCajeros"
        Me.Text = "Cancelar Envio a Cajeros"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Remanentes.ResumeLayout(False)
        Me.gbx_Remanentes.PerformLayout()
        Me.tab_Principal.ResumeLayout(False)
        Me.Tab_Remanentes.ResumeLayout(False)
        Me.tab_Dotaciones.ResumeLayout(False)
        Me.gbx_Dotaciones.ResumeLayout(False)
        Me.gbx_Dotaciones.PerformLayout()
        Me.tab_DotacionesA.ResumeLayout(False)
        Me.gbx_DotacionesA.ResumeLayout(False)
        Me.gbx_DotacionesA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Remanentes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lsv_Remanentes As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_RemanentesD As Modulo_Recepcion.cp_Listview
    Friend WithEvents tab_Principal As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Remanentes As System.Windows.Forms.TabPage
    Friend WithEvents tab_Dotaciones As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Dotaciones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_DotacionesD As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_Dotaciones As Modulo_Recepcion.cp_Listview
    Friend WithEvents tab_DotacionesA As System.Windows.Forms.TabPage
    Friend WithEvents gbx_DotacionesA As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_DotacionesAD As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_DotacionesA As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_RegistrosR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosDP As System.Windows.Forms.Label
    Friend WithEvents Lbl_RegistrosDA As System.Windows.Forms.Label
    Friend WithEvents lsv_EnvasesR As Modulo_Recepcion.cp_Listview
    Friend WithEvents lsv_EnvasesDP As Modulo_Recepcion.cp_Listview
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarR As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarDP As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarDP As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_BuscarAD As Modulo_Recepcion.cp_Textbox
    Friend WithEvents btn_BuscarAd As System.Windows.Forms.Button
    Friend WithEvents lsv_EnvasesDA As Modulo_Recepcion.cp_Listview
End Class
