<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RechazarRemision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RechazarRemision))
        Me.gbx_DatosRemision = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Compañia = New System.Windows.Forms.Label
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
        Me.tbx_NoRemision = New Modulo_Recepcion.cp_Textbox
        Me.tbx_totalEnvases = New Modulo_Recepcion.cp_Textbox
        Me.tbx_totalImporte = New Modulo_Recepcion.cp_Textbox
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.Lbl_Observaciones = New System.Windows.Forms.Label
        Me.Lbl_ImporteTotal = New System.Windows.Forms.Label
        Me.Lbl_EnvasesTotal = New System.Windows.Forms.Label
        Me.Lbl_NRemision = New System.Windows.Forms.Label
        Me.gbx_botones = New System.Windows.Forms.GroupBox
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.Btn_Cancelar = New System.Windows.Forms.Button
        Me.gbx_DatosRemision.SuspendLayout()
        Me.gbx_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_DatosRemision
        '
        Me.gbx_DatosRemision.Controls.Add(Me.Label9)
        Me.gbx_DatosRemision.Controls.Add(Me.Label8)
        Me.gbx_DatosRemision.Controls.Add(Me.Label7)
        Me.gbx_DatosRemision.Controls.Add(Me.Label6)
        Me.gbx_DatosRemision.Controls.Add(Me.Label4)
        Me.gbx_DatosRemision.Controls.Add(Me.lbl_Compañia)
        Me.gbx_DatosRemision.Controls.Add(Me.cmb_Cia)
        Me.gbx_DatosRemision.Controls.Add(Me.Lbl_Observaciones)
        Me.gbx_DatosRemision.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_DatosRemision.Controls.Add(Me.tbx_totalImporte)
        Me.gbx_DatosRemision.Controls.Add(Me.tbx_totalEnvases)
        Me.gbx_DatosRemision.Controls.Add(Me.Lbl_ImporteTotal)
        Me.gbx_DatosRemision.Controls.Add(Me.Lbl_EnvasesTotal)
        Me.gbx_DatosRemision.Controls.Add(Me.Lbl_NRemision)
        Me.gbx_DatosRemision.Controls.Add(Me.tbx_NoRemision)
        Me.gbx_DatosRemision.Location = New System.Drawing.Point(6, 12)
        Me.gbx_DatosRemision.Name = "gbx_DatosRemision"
        Me.gbx_DatosRemision.Size = New System.Drawing.Size(582, 301)
        Me.gbx_DatosRemision.TabIndex = 0
        Me.gbx_DatosRemision.TabStop = False
        Me.gbx_DatosRemision.Text = "Datos Remisión"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(538, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Tag = ""
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(318, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Tag = ""
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(173, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Tag = ""
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(318, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Tag = ""
        Me.Label6.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(538, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Tag = ""
        Me.Label4.Text = "*"
        '
        'lbl_Compañia
        '
        Me.lbl_Compañia.AutoSize = True
        Me.lbl_Compañia.Location = New System.Drawing.Point(54, 22)
        Me.lbl_Compañia.Name = "lbl_Compañia"
        Me.lbl_Compañia.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Compañia.TabIndex = 0
        Me.lbl_Compañia.Text = "Compañía"
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Clave = "Clave"
        Me.cmb_Cia.Control_Siguiente = Me.tbx_NoRemision
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Filtro = Nothing
        Me.cmb_Cia.FormattingEnabled = True
        Me.cmb_Cia.Location = New System.Drawing.Point(116, 19)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.Pista = False
        Me.cmb_Cia.Size = New System.Drawing.Size(419, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Cias_GetNoPropia"
        Me.cmb_Cia.Sucursal = False
        Me.cmb_Cia.TabIndex = 1
        Me.cmb_Cia.Tipo = 0
        Me.cmb_Cia.ValueMember = "Id_Cia"
        '
        'tbx_NoRemision
        '
        Me.tbx_NoRemision.Control_Siguiente = Me.tbx_totalEnvases
        Me.tbx_NoRemision.Filtrado = True
        Me.tbx_NoRemision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NoRemision.Location = New System.Drawing.Point(116, 45)
        Me.tbx_NoRemision.MaxLength = 10
        Me.tbx_NoRemision.Name = "tbx_NoRemision"
        Me.tbx_NoRemision.Size = New System.Drawing.Size(198, 26)
        Me.tbx_NoRemision.TabIndex = 3
        Me.tbx_NoRemision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_totalEnvases
        '
        Me.tbx_totalEnvases.Control_Siguiente = Me.tbx_totalImporte
        Me.tbx_totalEnvases.Filtrado = True
        Me.tbx_totalEnvases.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_totalEnvases.Location = New System.Drawing.Point(116, 77)
        Me.tbx_totalEnvases.MaxLength = 2
        Me.tbx_totalEnvases.Name = "tbx_totalEnvases"
        Me.tbx_totalEnvases.Size = New System.Drawing.Size(53, 26)
        Me.tbx_totalEnvases.TabIndex = 5
        Me.tbx_totalEnvases.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_totalImporte
        '
        Me.tbx_totalImporte.Control_Siguiente = Me.rtb_Observaciones
        Me.tbx_totalImporte.Filtrado = True
        Me.tbx_totalImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_totalImporte.Location = New System.Drawing.Point(116, 109)
        Me.tbx_totalImporte.MaxLength = 10
        Me.tbx_totalImporte.Name = "tbx_totalImporte"
        Me.tbx_totalImporte.Size = New System.Drawing.Size(198, 26)
        Me.tbx_totalImporte.TabIndex = 7
        Me.tbx_totalImporte.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(116, 141)
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(419, 154)
        Me.rtb_Observaciones.TabIndex = 9
        Me.rtb_Observaciones.Text = ""
        '
        'Lbl_Observaciones
        '
        Me.Lbl_Observaciones.AutoSize = True
        Me.Lbl_Observaciones.Location = New System.Drawing.Point(32, 144)
        Me.Lbl_Observaciones.Name = "Lbl_Observaciones"
        Me.Lbl_Observaciones.Size = New System.Drawing.Size(81, 13)
        Me.Lbl_Observaciones.TabIndex = 8
        Me.Lbl_Observaciones.Text = "Observaciones:"
        '
        'Lbl_ImporteTotal
        '
        Me.Lbl_ImporteTotal.AutoSize = True
        Me.Lbl_ImporteTotal.Location = New System.Drawing.Point(38, 117)
        Me.Lbl_ImporteTotal.Name = "Lbl_ImporteTotal"
        Me.Lbl_ImporteTotal.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_ImporteTotal.TabIndex = 6
        Me.Lbl_ImporteTotal.Text = "Importe Total:"
        '
        'Lbl_EnvasesTotal
        '
        Me.Lbl_EnvasesTotal.AutoSize = True
        Me.Lbl_EnvasesTotal.Location = New System.Drawing.Point(32, 85)
        Me.Lbl_EnvasesTotal.Name = "Lbl_EnvasesTotal"
        Me.Lbl_EnvasesTotal.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_EnvasesTotal.TabIndex = 4
        Me.Lbl_EnvasesTotal.Text = "Envases Total:"
        '
        'Lbl_NRemision
        '
        Me.Lbl_NRemision.AutoSize = True
        Me.Lbl_NRemision.Location = New System.Drawing.Point(5, 53)
        Me.Lbl_NRemision.Name = "Lbl_NRemision"
        Me.Lbl_NRemision.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_NRemision.TabIndex = 2
        Me.Lbl_NRemision.Text = "Numero de Remisión:"
        '
        'gbx_botones
        '
        Me.gbx_botones.Controls.Add(Me.Btn_Guardar)
        Me.gbx_botones.Controls.Add(Me.Btn_Cancelar)
        Me.gbx_botones.Location = New System.Drawing.Point(6, 319)
        Me.gbx_botones.Name = "gbx_botones"
        Me.gbx_botones.Size = New System.Drawing.Size(582, 50)
        Me.gbx_botones.TabIndex = 1
        Me.gbx_botones.TabStop = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Image = CType(resources.GetObject("Btn_Guardar.Image"), System.Drawing.Image)
        Me.Btn_Guardar.Location = New System.Drawing.Point(8, 14)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.Text = "&Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.Btn_Cancelar.Location = New System.Drawing.Point(436, 14)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cancelar.TabIndex = 1
        Me.Btn_Cancelar.Text = "&Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frm_RechazarRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 371)
        Me.Controls.Add(Me.gbx_botones)
        Me.Controls.Add(Me.gbx_DatosRemision)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_RechazarRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rechazar Remisión"
        Me.gbx_DatosRemision.ResumeLayout(False)
        Me.gbx_DatosRemision.PerformLayout()
        Me.gbx_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_DatosRemision As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_NoRemision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents gbx_botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_NRemision As System.Windows.Forms.Label
    Friend WithEvents Lbl_ImporteTotal As System.Windows.Forms.Label
    Friend WithEvents Lbl_EnvasesTotal As System.Windows.Forms.Label
    Friend WithEvents tbx_totalImporte As Modulo_Recepcion.cp_Textbox
    Friend WithEvents tbx_totalEnvases As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_Compañia As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_SimpleFiltradoParam
End Class
