<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_titulosIntroduccion = New System.Windows.Forms.Label()
        Me.lbl_valor2 = New System.Windows.Forms.Label()
        Me.lbl_valor1 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_visualizar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_terminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulosIntroduccion
        '
        Me.lbl_titulosIntroduccion.AutoSize = True
        Me.lbl_titulosIntroduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulosIntroduccion.Location = New System.Drawing.Point(166, 79)
        Me.lbl_titulosIntroduccion.Name = "lbl_titulosIntroduccion"
        Me.lbl_titulosIntroduccion.Size = New System.Drawing.Size(287, 36)
        Me.lbl_titulosIntroduccion.TabIndex = 10
        Me.lbl_titulosIntroduccion.Text = "Titulo de esta tarea"
        '
        'lbl_valor2
        '
        Me.lbl_valor2.AutoSize = True
        Me.lbl_valor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor2.Location = New System.Drawing.Point(169, 195)
        Me.lbl_valor2.Name = "lbl_valor2"
        Me.lbl_valor2.Size = New System.Drawing.Size(81, 17)
        Me.lbl_valor2.TabIndex = 14
        Me.lbl_valor2.Text = "Contraseña"
        '
        'lbl_valor1
        '
        Me.lbl_valor1.AutoSize = True
        Me.lbl_valor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor1.Location = New System.Drawing.Point(169, 154)
        Me.lbl_valor1.Name = "lbl_valor1"
        Me.lbl_valor1.Size = New System.Drawing.Size(57, 17)
        Me.lbl_valor1.TabIndex = 13
        Me.lbl_valor1.Text = "Usuario"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(294, 192)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(120, 20)
        Me.txt_contraseña.TabIndex = 12
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(294, 151)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(120, 20)
        Me.txt_usuario.TabIndex = 11
        '
        'btn_visualizar
        '
        Me.btn_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_visualizar.Location = New System.Drawing.Point(267, 278)
        Me.btn_visualizar.Name = "btn_visualizar"
        Me.btn_visualizar.Size = New System.Drawing.Size(147, 33)
        Me.btn_visualizar.TabIndex = 16
        Me.btn_visualizar.Text = "Visualizar"
        Me.btn_visualizar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(114, 278)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(147, 33)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_terminar
        '
        Me.btn_terminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terminar.Location = New System.Drawing.Point(420, 278)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(147, 33)
        Me.btn_terminar.TabIndex = 17
        Me.btn_terminar.Text = "Terminar"
        Me.btn_terminar.UseVisualStyleBackColor = True
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 426)
        Me.Controls.Add(Me.btn_terminar)
        Me.Controls.Add(Me.btn_visualizar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.lbl_valor2)
        Me.Controls.Add(Me.lbl_valor1)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_titulosIntroduccion)
        Me.Name = "frmEntrada"
        Me.Text = "frmEntrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulosIntroduccion As Label
    Friend WithEvents lbl_valor2 As Label
    Friend WithEvents lbl_valor1 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_visualizar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_terminar As Button
End Class
