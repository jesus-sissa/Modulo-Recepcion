<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprobanteVmodal
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
        Me.Gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.tbx_Hora = New System.Windows.Forms.TextBox
        Me.tbx_Folio = New System.Windows.Forms.TextBox
        Me.Lbl_HoraProg = New System.Windows.Forms.Label
        Me.Lbl_ClienteT = New System.Windows.Forms.Label
        Me.Lbl_HoraT = New System.Windows.Forms.Label
        Me.Lbl_FechaT = New System.Windows.Forms.Label
        Me.lbl_Horario = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_Hora = New System.Windows.Forms.Label
        Me.lbl_Fecha = New System.Windows.Forms.Label
        Me.lbl_Folio = New System.Windows.Forms.Label
        Me.Lbl_FoliosCV = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Validar = New System.Windows.Forms.Button
        Me.Gbx_Detalle.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Detalle
        '
        Me.Gbx_Detalle.Controls.Add(Me.tbx_Hora)
        Me.Gbx_Detalle.Controls.Add(Me.tbx_Folio)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_HoraProg)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_ClienteT)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_HoraT)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_FechaT)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Horario)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Cliente)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Hora)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Fecha)
        Me.Gbx_Detalle.Controls.Add(Me.lbl_Folio)
        Me.Gbx_Detalle.Controls.Add(Me.Lbl_FoliosCV)
        Me.Gbx_Detalle.Location = New System.Drawing.Point(5, 3)
        Me.Gbx_Detalle.Name = "Gbx_Detalle"
        Me.Gbx_Detalle.Size = New System.Drawing.Size(433, 182)
        Me.Gbx_Detalle.TabIndex = 0
        Me.Gbx_Detalle.TabStop = False
        Me.Gbx_Detalle.Text = "Detalle"
        '
        'tbx_Hora
        '
        Me.tbx_Hora.Location = New System.Drawing.Point(107, 69)
        Me.tbx_Hora.MaxLength = 5
        Me.tbx_Hora.Name = "tbx_Hora"
        Me.tbx_Hora.Size = New System.Drawing.Size(62, 20)
        Me.tbx_Hora.TabIndex = 6
        '
        'tbx_Folio
        '
        Me.tbx_Folio.Location = New System.Drawing.Point(107, 19)
        Me.tbx_Folio.MaxLength = 6
        Me.tbx_Folio.Name = "tbx_Folio"
        Me.tbx_Folio.Size = New System.Drawing.Size(62, 20)
        Me.tbx_Folio.TabIndex = 1
        '
        'Lbl_HoraProg
        '
        Me.Lbl_HoraProg.AutoSize = True
        Me.Lbl_HoraProg.Location = New System.Drawing.Point(11, 154)
        Me.Lbl_HoraProg.Name = "Lbl_HoraProg"
        Me.Lbl_HoraProg.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_HoraProg.TabIndex = 10
        Me.Lbl_HoraProg.Text = "Hora Programada"
        '
        'Lbl_ClienteT
        '
        Me.Lbl_ClienteT.AutoSize = True
        Me.Lbl_ClienteT.Location = New System.Drawing.Point(62, 96)
        Me.Lbl_ClienteT.Name = "Lbl_ClienteT"
        Me.Lbl_ClienteT.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ClienteT.TabIndex = 8
        Me.Lbl_ClienteT.Text = "Cliente"
        '
        'Lbl_HoraT
        '
        Me.Lbl_HoraT.AutoSize = True
        Me.Lbl_HoraT.Location = New System.Drawing.Point(71, 70)
        Me.Lbl_HoraT.Name = "Lbl_HoraT"
        Me.Lbl_HoraT.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_HoraT.TabIndex = 5
        Me.Lbl_HoraT.Text = "Hora"
        '
        'Lbl_FechaT
        '
        Me.Lbl_FechaT.AutoSize = True
        Me.Lbl_FechaT.Location = New System.Drawing.Point(64, 45)
        Me.Lbl_FechaT.Name = "Lbl_FechaT"
        Me.Lbl_FechaT.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_FechaT.TabIndex = 3
        Me.Lbl_FechaT.Text = "Fecha"
        '
        'lbl_Horario
        '
        Me.lbl_Horario.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Horario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Horario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Horario.Location = New System.Drawing.Point(107, 153)
        Me.lbl_Horario.Name = "lbl_Horario"
        Me.lbl_Horario.Size = New System.Drawing.Size(118, 19)
        Me.lbl_Horario.TabIndex = 11
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(107, 95)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(320, 53)
        Me.lbl_Cliente.TabIndex = 9
        '
        'lbl_Hora
        '
        Me.lbl_Hora.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(175, 69)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(62, 19)
        Me.lbl_Hora.TabIndex = 7
        Me.lbl_Hora.Visible = False
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(107, 44)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(62, 19)
        Me.lbl_Fecha.TabIndex = 4
        '
        'lbl_Folio
        '
        Me.lbl_Folio.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Folio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Folio.Location = New System.Drawing.Point(175, 19)
        Me.lbl_Folio.Name = "lbl_Folio"
        Me.lbl_Folio.Size = New System.Drawing.Size(62, 19)
        Me.lbl_Folio.TabIndex = 2
        Me.lbl_Folio.Visible = False
        '
        'Lbl_FoliosCV
        '
        Me.Lbl_FoliosCV.AutoSize = True
        Me.Lbl_FoliosCV.Location = New System.Drawing.Point(55, 22)
        Me.Lbl_FoliosCV.Name = "Lbl_FoliosCV"
        Me.Lbl_FoliosCV.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_FoliosCV.TabIndex = 0
        Me.Lbl_FoliosCV.Text = "Folio CV"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Validar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 191)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(433, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(287, 13)
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
        Me.btn_Validar.Location = New System.Drawing.Point(7, 13)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 0
        Me.btn_Validar.Text = "&Validar CV"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'frm_ComprobanteVmodal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 247)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Detalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ComprobanteVmodal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de Visita"
        Me.Gbx_Detalle.ResumeLayout(False)
        Me.Gbx_Detalle.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_HoraProg As System.Windows.Forms.Label
    Friend WithEvents Lbl_ClienteT As System.Windows.Forms.Label
    Friend WithEvents Lbl_HoraT As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaT As System.Windows.Forms.Label
    Friend WithEvents Lbl_FoliosCV As System.Windows.Forms.Label
    Friend WithEvents lbl_Horario As System.Windows.Forms.Label
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Folio As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_Hora As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Folio As System.Windows.Forms.TextBox
End Class
