<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CambiarCliente
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Editar = New System.Windows.Forms.GroupBox
        Me.lbl_ClienteDestino = New System.Windows.Forms.Label
        Me.lbl_ClienteO = New System.Windows.Forms.Label
        Me.rb_Deposito = New System.Windows.Forms.RadioButton
        Me.rb_Custodia = New System.Windows.Forms.RadioButton
        Me.gbx_Buscar = New System.Windows.Forms.GroupBox
        Me.lbl_CiaTraslado = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_Remision = New System.Windows.Forms.Label
        Me.cmb_ClienteD = New Modulo_Recepcion.cp_cmb_Simple
        Me.cmb_ClienteO = New Modulo_Recepcion.cp_cmb_Simple
        Me.tbx_Remision = New Modulo_Recepcion.cp_Textbox
        Me.cmb_Cia = New Modulo_Recepcion.cp_cmb_Parametro
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Editar.SuspendLayout()
        Me.gbx_Buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 156)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(665, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(516, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Editar
        '
        Me.gbx_Editar.Controls.Add(Me.lbl_ClienteDestino)
        Me.gbx_Editar.Controls.Add(Me.lbl_ClienteO)
        Me.gbx_Editar.Controls.Add(Me.cmb_ClienteD)
        Me.gbx_Editar.Controls.Add(Me.cmb_ClienteO)
        Me.gbx_Editar.Controls.Add(Me.rb_Deposito)
        Me.gbx_Editar.Controls.Add(Me.rb_Custodia)
        Me.gbx_Editar.Location = New System.Drawing.Point(5, 60)
        Me.gbx_Editar.Name = "gbx_Editar"
        Me.gbx_Editar.Size = New System.Drawing.Size(665, 90)
        Me.gbx_Editar.TabIndex = 1
        Me.gbx_Editar.TabStop = False
        '
        'lbl_ClienteDestino
        '
        Me.lbl_ClienteDestino.AutoSize = True
        Me.lbl_ClienteDestino.Location = New System.Drawing.Point(85, 56)
        Me.lbl_ClienteDestino.Name = "lbl_ClienteDestino"
        Me.lbl_ClienteDestino.Size = New System.Drawing.Size(78, 13)
        Me.lbl_ClienteDestino.TabIndex = 4
        Me.lbl_ClienteDestino.Text = "Cliente Destino"
        '
        'lbl_ClienteO
        '
        Me.lbl_ClienteO.AutoSize = True
        Me.lbl_ClienteO.Location = New System.Drawing.Point(85, 21)
        Me.lbl_ClienteO.Name = "lbl_ClienteO"
        Me.lbl_ClienteO.Size = New System.Drawing.Size(73, 13)
        Me.lbl_ClienteO.TabIndex = 1
        Me.lbl_ClienteO.Text = "Cliente Origen"
        '
        'rb_Deposito
        '
        Me.rb_Deposito.AutoSize = True
        Me.rb_Deposito.Location = New System.Drawing.Point(12, 54)
        Me.rb_Deposito.Name = "rb_Deposito"
        Me.rb_Deposito.Size = New System.Drawing.Size(67, 17)
        Me.rb_Deposito.TabIndex = 3
        Me.rb_Deposito.TabStop = True
        Me.rb_Deposito.Text = "Depósito"
        Me.rb_Deposito.UseVisualStyleBackColor = True
        '
        'rb_Custodia
        '
        Me.rb_Custodia.AutoSize = True
        Me.rb_Custodia.Location = New System.Drawing.Point(12, 19)
        Me.rb_Custodia.Name = "rb_Custodia"
        Me.rb_Custodia.Size = New System.Drawing.Size(66, 17)
        Me.rb_Custodia.TabIndex = 0
        Me.rb_Custodia.TabStop = True
        Me.rb_Custodia.Text = "Custodia"
        Me.rb_Custodia.UseVisualStyleBackColor = True
        '
        'gbx_Buscar
        '
        Me.gbx_Buscar.Controls.Add(Me.tbx_Remision)
        Me.gbx_Buscar.Controls.Add(Me.cmb_Cia)
        Me.gbx_Buscar.Controls.Add(Me.lbl_CiaTraslado)
        Me.gbx_Buscar.Controls.Add(Me.btn_Buscar)
        Me.gbx_Buscar.Controls.Add(Me.lbl_Remision)
        Me.gbx_Buscar.Location = New System.Drawing.Point(5, 2)
        Me.gbx_Buscar.Name = "gbx_Buscar"
        Me.gbx_Buscar.Size = New System.Drawing.Size(665, 52)
        Me.gbx_Buscar.TabIndex = 0
        Me.gbx_Buscar.TabStop = False
        Me.gbx_Buscar.Text = "Buscar"
        '
        'lbl_CiaTraslado
        '
        Me.lbl_CiaTraslado.AutoSize = True
        Me.lbl_CiaTraslado.Location = New System.Drawing.Point(245, 22)
        Me.lbl_CiaTraslado.Name = "lbl_CiaTraslado"
        Me.lbl_CiaTraslado.Size = New System.Drawing.Size(81, 13)
        Me.lbl_CiaTraslado.TabIndex = 3
        Me.lbl_CiaTraslado.Text = "Cia de Traslado"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(212, 17)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(27, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Remision
        '
        Me.lbl_Remision.AutoSize = True
        Me.lbl_Remision.Location = New System.Drawing.Point(9, 22)
        Me.lbl_Remision.Name = "lbl_Remision"
        Me.lbl_Remision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Remision.TabIndex = 0
        Me.lbl_Remision.Text = "Remisión"
        '
        'cmb_ClienteD
        '
        Me.cmb_ClienteD.Control_Siguiente = Nothing
        Me.cmb_ClienteD.DisplayMember = "Nombre_Comercial"
        Me.cmb_ClienteD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteD.Empresa = False
        Me.cmb_ClienteD.FormattingEnabled = True
        Me.cmb_ClienteD.Location = New System.Drawing.Point(169, 53)
        Me.cmb_ClienteD.MaxDropDownItems = 20
        Me.cmb_ClienteD.Name = "cmb_ClienteD"
        Me.cmb_ClienteD.Pista = False
        Me.cmb_ClienteD.Size = New System.Drawing.Size(479, 21)
        Me.cmb_ClienteD.StoredProcedure = "Cat_Clientes_ComboGet"
        Me.cmb_ClienteD.Sucursal = False
        Me.cmb_ClienteD.TabIndex = 5
        Me.cmb_ClienteD.ValueMember = "Id_Cliente"
        '
        'cmb_ClienteO
        '
        Me.cmb_ClienteO.Control_Siguiente = Nothing
        Me.cmb_ClienteO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ClienteO.Empresa = False
        Me.cmb_ClienteO.FormattingEnabled = True
        Me.cmb_ClienteO.Location = New System.Drawing.Point(169, 19)
        Me.cmb_ClienteO.MaxDropDownItems = 20
        Me.cmb_ClienteO.Name = "cmb_ClienteO"
        Me.cmb_ClienteO.Pista = True
        Me.cmb_ClienteO.Size = New System.Drawing.Size(479, 21)
        Me.cmb_ClienteO.StoredProcedure = Nothing
        Me.cmb_ClienteO.Sucursal = False
        Me.cmb_ClienteO.TabIndex = 2
        '
        'tbx_Remision
        '
        Me.tbx_Remision.Control_Siguiente = Nothing
        Me.tbx_Remision.Filtrado = False
        Me.tbx_Remision.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Remision.Location = New System.Drawing.Point(65, 19)
        Me.tbx_Remision.MaxLength = 15
        Me.tbx_Remision.Name = "tbx_Remision"
        Me.tbx_Remision.Size = New System.Drawing.Size(141, 23)
        Me.tbx_Remision.TabIndex = 1
        Me.tbx_Remision.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Cia
        '
        Me.cmb_Cia.Control_Siguiente = Nothing
        Me.cmb_Cia.DisplayMember = "Alias"
        Me.cmb_Cia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cia.Empresa = False
        Me.cmb_Cia.Location = New System.Drawing.Point(332, 18)
        Me.cmb_Cia.MaxDropDownItems = 20
        Me.cmb_Cia.Name = "cmb_Cia"
        Me.cmb_Cia.NombreParametro = "@Numero_Remision"
        Me.cmb_Cia.Pista = False
        Me.cmb_Cia.Size = New System.Drawing.Size(316, 21)
        Me.cmb_Cia.StoredProcedure = "Cat_Remisiones_ExisteByNumero"
        Me.cmb_Cia.Sucursal = True
        Me.cmb_Cia.TabIndex = 4
        Me.cmb_Cia.Tipodedatos = System.Data.SqlDbType.BigInt
        Me.cmb_Cia.ValorParametro = Nothing
        Me.cmb_Cia.ValueMember = "Id_Remision"
        '
        'frm_CambiarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 211)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Editar)
        Me.Controls.Add(Me.gbx_Buscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CambiarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Cliente"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Editar.ResumeLayout(False)
        Me.gbx_Editar.PerformLayout()
        Me.gbx_Buscar.ResumeLayout(False)
        Me.gbx_Buscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Editar As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Remision As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_Cia As Modulo_Recepcion.cp_cmb_Parametro
    Friend WithEvents lbl_CiaTraslado As System.Windows.Forms.Label
    Friend WithEvents tbx_Remision As Modulo_Recepcion.cp_Textbox
    Friend WithEvents rb_Deposito As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Custodia As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_ClienteDestino As System.Windows.Forms.Label
    Friend WithEvents lbl_ClienteO As System.Windows.Forms.Label
    Friend WithEvents cmb_ClienteD As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents cmb_ClienteO As Modulo_Recepcion.cp_cmb_Simple
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
