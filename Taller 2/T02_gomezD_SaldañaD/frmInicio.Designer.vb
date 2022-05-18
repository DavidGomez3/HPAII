<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmr_inicio
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
        Me.lbl_TituloInicio = New System.Windows.Forms.Label()
        Me.btn_Calculos = New System.Windows.Forms.Button()
        Me.btn_manejoTextos = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_TituloInicio
        '
        Me.lbl_TituloInicio.AutoSize = True
        Me.lbl_TituloInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloInicio.Location = New System.Drawing.Point(177, 113)
        Me.lbl_TituloInicio.Name = "lbl_TituloInicio"
        Me.lbl_TituloInicio.Size = New System.Drawing.Size(287, 36)
        Me.lbl_TituloInicio.TabIndex = 0
        Me.lbl_TituloInicio.Text = "Titulo de esta tarea"
        '
        'btn_Calculos
        '
        Me.btn_Calculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calculos.Location = New System.Drawing.Point(93, 185)
        Me.btn_Calculos.Name = "btn_Calculos"
        Me.btn_Calculos.Size = New System.Drawing.Size(227, 42)
        Me.btn_Calculos.TabIndex = 1
        Me.btn_Calculos.Text = "Calculos matemáticos"
        Me.btn_Calculos.UseVisualStyleBackColor = True
        '
        'btn_manejoTextos
        '
        Me.btn_manejoTextos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manejoTextos.Location = New System.Drawing.Point(326, 185)
        Me.btn_manejoTextos.Name = "btn_manejoTextos"
        Me.btn_manejoTextos.Size = New System.Drawing.Size(227, 42)
        Me.btn_manejoTextos.TabIndex = 2
        Me.btn_manejoTextos.Text = "Manejo de textos"
        Me.btn_manejoTextos.UseVisualStyleBackColor = True
        '
        'btn_finalizar
        '
        Me.btn_finalizar.Location = New System.Drawing.Point(262, 260)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(119, 42)
        Me.btn_finalizar.TabIndex = 3
        Me.btn_finalizar.Text = "Finalizar"
        Me.btn_finalizar.UseVisualStyleBackColor = True
        '
        'fmr_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 426)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.btn_manejoTextos)
        Me.Controls.Add(Me.btn_Calculos)
        Me.Controls.Add(Me.lbl_TituloInicio)
        Me.Name = "fmr_inicio"
        Me.Text = "Taller #2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_TituloInicio As System.Windows.Forms.Label
    Friend WithEvents btn_Calculos As System.Windows.Forms.Button
    Friend WithEvents btn_manejoTextos As System.Windows.Forms.Button
    Friend WithEvents btn_finalizar As System.Windows.Forms.Button

End Class
