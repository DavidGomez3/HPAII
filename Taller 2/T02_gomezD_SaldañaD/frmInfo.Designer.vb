<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Me.lbl_ultimaCaptura = New System.Windows.Forms.Label()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.txt_ultimaCaptura = New System.Windows.Forms.TextBox()
        Me.txt_info = New System.Windows.Forms.TextBox()
        Me.btn_terminar = New System.Windows.Forms.Button()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulosIntroduccion
        '
        Me.lbl_titulosIntroduccion.AutoSize = True
        Me.lbl_titulosIntroduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulosIntroduccion.Location = New System.Drawing.Point(165, 68)
        Me.lbl_titulosIntroduccion.Name = "lbl_titulosIntroduccion"
        Me.lbl_titulosIntroduccion.Size = New System.Drawing.Size(287, 36)
        Me.lbl_titulosIntroduccion.TabIndex = 11
        Me.lbl_titulosIntroduccion.Text = "Titulo de esta tarea"
        '
        'lbl_ultimaCaptura
        '
        Me.lbl_ultimaCaptura.AutoSize = True
        Me.lbl_ultimaCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ultimaCaptura.Location = New System.Drawing.Point(125, 221)
        Me.lbl_ultimaCaptura.Name = "lbl_ultimaCaptura"
        Me.lbl_ultimaCaptura.Size = New System.Drawing.Size(99, 17)
        Me.lbl_ultimaCaptura.TabIndex = 18
        Me.lbl_ultimaCaptura.Text = "Ultima captura"
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_informacion.Location = New System.Drawing.Point(125, 142)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(149, 17)
        Me.lbl_informacion.TabIndex = 17
        Me.lbl_informacion.Text = "Información registrada"
        '
        'txt_ultimaCaptura
        '
        Me.txt_ultimaCaptura.Location = New System.Drawing.Point(289, 218)
        Me.txt_ultimaCaptura.Name = "txt_ultimaCaptura"
        Me.txt_ultimaCaptura.Size = New System.Drawing.Size(219, 20)
        Me.txt_ultimaCaptura.TabIndex = 16
        '
        'txt_info
        '
        Me.txt_info.Location = New System.Drawing.Point(289, 141)
        Me.txt_info.Multiline = True
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(219, 55)
        Me.txt_info.TabIndex = 15
        '
        'btn_terminar
        '
        Me.btn_terminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terminar.Location = New System.Drawing.Point(198, 322)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(227, 42)
        Me.btn_terminar.TabIndex = 20
        Me.btn_terminar.Text = "Terminar"
        Me.btn_terminar.UseCompatibleTextRendering = True
        Me.btn_terminar.UseVisualStyleBackColor = True
        '
        'btn_regresar
        '
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(198, 274)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(227, 42)
        Me.btn_regresar.TabIndex = 19
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 426)
        Me.Controls.Add(Me.btn_terminar)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.lbl_ultimaCaptura)
        Me.Controls.Add(Me.lbl_informacion)
        Me.Controls.Add(Me.txt_ultimaCaptura)
        Me.Controls.Add(Me.txt_info)
        Me.Controls.Add(Me.lbl_titulosIntroduccion)
        Me.Name = "frmInfo"
        Me.Text = "frmInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulosIntroduccion As Label
    Friend WithEvents lbl_ultimaCaptura As Label
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents txt_ultimaCaptura As TextBox
    Friend WithEvents txt_info As TextBox
    Friend WithEvents btn_terminar As Button
    Friend WithEvents btn_regresar As Button
End Class
