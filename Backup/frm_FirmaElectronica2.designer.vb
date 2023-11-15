<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FirmaElectronica2
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
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lbl_Contraseña = New System.Windows.Forms.Label
        Me.tbx_Contraseña = New System.Windows.Forms.TextBox
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tbx_ContraseñaSeg = New System.Windows.Forms.TextBox
        Me.Contraseña = New System.Windows.Forms.Label
        Me.Lbl_UsuarioSeg = New System.Windows.Forms.Label
        Me.lbl_ley = New System.Windows.Forms.Label
        Me.tbx_UsuarioSeg = New Modulo_Recepcion.cp_Textbox
        Me.tbx_Empleado = New Modulo_Recepcion.cp_Textbox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.Location = New System.Drawing.Point(19, 9)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Empleado.TabIndex = 0
        Me.lbl_Empleado.Text = "Usuario de Bóveda"
        Me.lbl_Empleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Location = New System.Drawing.Point(56, 35)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Contraseña.TabIndex = 2
        Me.lbl_Contraseña.Text = "Contraseña"
        Me.lbl_Contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Contraseña
        '
        Me.tbx_Contraseña.Location = New System.Drawing.Point(123, 32)
        Me.tbx_Contraseña.MaxLength = 50
        Me.tbx_Contraseña.Name = "tbx_Contraseña"
        Me.tbx_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Contraseña.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Contraseña.TabIndex = 3
        Me.tbx_Contraseña.UseSystemPasswordChar = True
        '
        'btn_Validar
        '
        Me.btn_Validar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Validar.Image = Global.Modulo_Recepcion.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(5, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 10
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(159, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 11
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'tbx_ContraseñaSeg
        '
        Me.tbx_ContraseñaSeg.Location = New System.Drawing.Point(123, 86)
        Me.tbx_ContraseñaSeg.MaxLength = 50
        Me.tbx_ContraseñaSeg.Name = "tbx_ContraseñaSeg"
        Me.tbx_ContraseñaSeg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_ContraseñaSeg.Size = New System.Drawing.Size(170, 20)
        Me.tbx_ContraseñaSeg.TabIndex = 7
        Me.tbx_ContraseñaSeg.UseSystemPasswordChar = True
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Location = New System.Drawing.Point(56, 89)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.Contraseña.TabIndex = 6
        Me.Contraseña.Text = "Contraseña"
        Me.Contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_UsuarioSeg
        '
        Me.Lbl_UsuarioSeg.Location = New System.Drawing.Point(8, 63)
        Me.Lbl_UsuarioSeg.Name = "Lbl_UsuarioSeg"
        Me.Lbl_UsuarioSeg.Size = New System.Drawing.Size(109, 13)
        Me.Lbl_UsuarioSeg.TabIndex = 4
        Me.Lbl_UsuarioSeg.Text = "Usuario de Seguridad"
        Me.Lbl_UsuarioSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ley
        '
        Me.lbl_ley.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ley.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ley.Location = New System.Drawing.Point(12, 121)
        Me.lbl_ley.Name = "lbl_ley"
        Me.lbl_ley.Size = New System.Drawing.Size(303, 96)
        Me.lbl_ley.TabIndex = 8
        Me.lbl_ley.Text = "Con base en el Contrato celebrado entre usted y la Empresa, al realizar este tran" & _
            "sacción Usted está ACEPTANDO las Responsabilidades que resulten de esta acción."
        Me.lbl_ley.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbx_UsuarioSeg
        '
        Me.tbx_UsuarioSeg.Control_Siguiente = Me.tbx_ContraseñaSeg
        Me.tbx_UsuarioSeg.Filtrado = False
        Me.tbx_UsuarioSeg.Location = New System.Drawing.Point(123, 60)
        Me.tbx_UsuarioSeg.MaxLength = 10
        Me.tbx_UsuarioSeg.Name = "tbx_UsuarioSeg"
        Me.tbx_UsuarioSeg.Size = New System.Drawing.Size(170, 20)
        Me.tbx_UsuarioSeg.TabIndex = 5
        Me.tbx_UsuarioSeg.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.Control_Siguiente = Me.tbx_Contraseña
        Me.tbx_Empleado.Filtrado = False
        Me.tbx_Empleado.Location = New System.Drawing.Point(123, 6)
        Me.tbx_Empleado.MaxLength = 10
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.Size = New System.Drawing.Size(170, 20)
        Me.tbx_Empleado.TabIndex = 1
        Me.tbx_Empleado.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(11, 220)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(304, 48)
        Me.gbx_Botones.TabIndex = 12
        Me.gbx_Botones.TabStop = False
        '
        'frm_FirmaElectronica2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.lbl_ley)
        Me.Controls.Add(Me.tbx_ContraseñaSeg)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Lbl_UsuarioSeg)
        Me.Controls.Add(Me.tbx_UsuarioSeg)
        Me.Controls.Add(Me.tbx_Contraseña)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.lbl_Empleado)
        Me.Controls.Add(Me.tbx_Empleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(330, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(330, 300)
        Me.Name = "frm_FirmaElectronica2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones de Validación"
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_Empleado As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Contraseña As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents tbx_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ContraseñaSeg As System.Windows.Forms.TextBox
    Friend WithEvents Contraseña As System.Windows.Forms.Label
    Friend WithEvents Lbl_UsuarioSeg As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioSeg As Modulo_Recepcion.cp_Textbox
    Friend WithEvents lbl_ley As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
End Class
