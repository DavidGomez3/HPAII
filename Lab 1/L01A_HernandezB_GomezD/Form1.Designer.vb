<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CambioDeTexto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lb_TituloTexto = New System.Windows.Forms.Label()
        Me.Lb_IntroducirTexto = New System.Windows.Forms.Label()
        Me.Txt_TextoIngresado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lb_TituloTexto
        '
        Me.Lb_TituloTexto.AutoSize = True
        Me.Lb_TituloTexto.Font = New System.Drawing.Font("Gill Sans MT", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lb_TituloTexto.Location = New System.Drawing.Point(56, 60)
        Me.Lb_TituloTexto.Name = "Lb_TituloTexto"
        Me.Lb_TituloTexto.Size = New System.Drawing.Size(838, 69)
        Me.Lb_TituloTexto.TabIndex = 0
        Me.Lb_TituloTexto.Text = "Ejemplo Radio buttom y checkbox"
        '
        'Lb_IntroducirTexto
        '
        Me.Lb_IntroducirTexto.AutoSize = True
        Me.Lb_IntroducirTexto.Font = New System.Drawing.Font("Gill Sans MT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lb_IntroducirTexto.Location = New System.Drawing.Point(68, 158)
        Me.Lb_IntroducirTexto.Name = "Lb_IntroducirTexto"
        Me.Lb_IntroducirTexto.Size = New System.Drawing.Size(332, 47)
        Me.Lb_IntroducirTexto.TabIndex = 1
        Me.Lb_IntroducirTexto.Text = "Introduzca su texto"
        '
        'Txt_TextoIngresado
        '
        Me.Txt_TextoIngresado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_TextoIngresado.Location = New System.Drawing.Point(78, 219)
        Me.Txt_TextoIngresado.Multiline = True
        Me.Txt_TextoIngresado.Name = "Txt_TextoIngresado"
        Me.Txt_TextoIngresado.Size = New System.Drawing.Size(769, 108)
        Me.Txt_TextoIngresado.TabIndex = 2
        '
        'Frm_CambioDeTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(948, 642)
        Me.Controls.Add(Me.Txt_TextoIngresado)
        Me.Controls.Add(Me.Lb_IntroducirTexto)
        Me.Controls.Add(Me.Lb_TituloTexto)
        Me.Name = "Frm_CambioDeTexto"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_TituloTexto As Label
    Friend WithEvents Lb_IntroducirTexto As Label
    Friend WithEvents Txt_TextoIngresado As TextBox
End Class
