<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Observaciones
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
        Me.Gbx_Observacion = New System.Windows.Forms.GroupBox
        Me.tbx_Observaciones = New Modulo_Recepcion.cp_Textbox
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Observacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Observacion
        '
        Me.Gbx_Observacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Observacion.Controls.Add(Me.tbx_Observaciones)
        Me.Gbx_Observacion.Location = New System.Drawing.Point(7, 37)
        Me.Gbx_Observacion.Name = "Gbx_Observacion"
        Me.Gbx_Observacion.Size = New System.Drawing.Size(449, 99)
        Me.Gbx_Observacion.TabIndex = 1
        Me.Gbx_Observacion.TabStop = False
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Observaciones.Control_Siguiente = Nothing
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(6, 13)
        Me.tbx_Observaciones.MaxLength = 150
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(437, 76)
        Me.tbx_Observaciones.TabIndex = 0
        Me.tbx_Observaciones.TipoDatos = Modulo_Recepcion.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nota.Location = New System.Drawing.Point(15, 9)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(395, 29)
        Me.Lbl_Nota.TabIndex = 0
        Me.Lbl_Nota.Text = "Indique la razón por la que se modifica el Número de Remisión. (Máximo 150 caract" & _
            "eres)"
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Guardar
        Me.btn_Aceptar.Location = New System.Drawing.Point(7, 142)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.Text = "&Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Recepcion.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(316, 142)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_Observaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 181)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.Lbl_Nota)
        Me.Controls.Add(Me.Gbx_Observacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(470, 210)
        Me.Name = "frm_Observaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observaciones"
        Me.TopMost = True
        Me.Gbx_Observacion.ResumeLayout(False)
        Me.Gbx_Observacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Observacion As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Observaciones As Modulo_Recepcion.cp_Textbox
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
End Class
