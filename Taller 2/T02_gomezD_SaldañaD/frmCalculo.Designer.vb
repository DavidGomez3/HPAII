<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calculo
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
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_valor1 = New System.Windows.Forms.TextBox()
        Me.txt_valor2 = New System.Windows.Forms.TextBox()
        Me.lbl_valor1 = New System.Windows.Forms.Label()
        Me.lbl_tituloCalculos = New System.Windows.Forms.Label()
        Me.lbl_valor2 = New System.Windows.Forms.Label()
        Me.text_resultatado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(192, 288)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(227, 42)
        Me.btn_calcular.TabIndex = 2
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(192, 336)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(227, 42)
        Me.btn_limpiar.TabIndex = 3
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'txt_valor1
        '
        Me.txt_valor1.Location = New System.Drawing.Point(343, 132)
        Me.txt_valor1.Name = "txt_valor1"
        Me.txt_valor1.Size = New System.Drawing.Size(120, 20)
        Me.txt_valor1.TabIndex = 4
        '
        'txt_valor2
        '
        Me.txt_valor2.Location = New System.Drawing.Point(343, 173)
        Me.txt_valor2.Name = "txt_valor2"
        Me.txt_valor2.Size = New System.Drawing.Size(120, 20)
        Me.txt_valor2.TabIndex = 5
        '
        'lbl_valor1
        '
        Me.lbl_valor1.AutoSize = True
        Me.lbl_valor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor1.Location = New System.Drawing.Point(168, 132)
        Me.lbl_valor1.Name = "lbl_valor1"
        Me.lbl_valor1.Size = New System.Drawing.Size(145, 17)
        Me.lbl_valor1.TabIndex = 7
        Me.lbl_valor1.Text = "Inserte el primer valor"
        '
        'lbl_tituloCalculos
        '
        Me.lbl_tituloCalculos.AutoSize = True
        Me.lbl_tituloCalculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloCalculos.Location = New System.Drawing.Point(167, 61)
        Me.lbl_tituloCalculos.Name = "lbl_tituloCalculos"
        Me.lbl_tituloCalculos.Size = New System.Drawing.Size(287, 36)
        Me.lbl_tituloCalculos.TabIndex = 9
        Me.lbl_tituloCalculos.Text = "Titulo de esta tarea"
        '
        'lbl_valor2
        '
        Me.lbl_valor2.AutoSize = True
        Me.lbl_valor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor2.Location = New System.Drawing.Point(168, 173)
        Me.lbl_valor2.Name = "lbl_valor2"
        Me.lbl_valor2.Size = New System.Drawing.Size(160, 17)
        Me.lbl_valor2.TabIndex = 10
        Me.lbl_valor2.Text = "Inserte el segundo valor"
        '
        'text_resultatado
        '
        Me.text_resultatado.Location = New System.Drawing.Point(249, 235)
        Me.text_resultatado.Name = "text_resultatado"
        Me.text_resultatado.Size = New System.Drawing.Size(120, 20)
        Me.text_resultatado.TabIndex = 11
        '
        'frm_calculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 426)
        Me.Controls.Add(Me.text_resultatado)
        Me.Controls.Add(Me.lbl_valor2)
        Me.Controls.Add(Me.lbl_tituloCalculos)
        Me.Controls.Add(Me.lbl_valor1)
        Me.Controls.Add(Me.txt_valor2)
        Me.Controls.Add(Me.txt_valor1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Name = "frm_calculo"
        Me.Text = "Taller #2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents txt_valor1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_valor2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_valor1 As System.Windows.Forms.Label
    Friend WithEvents lbl_tituloCalculos As System.Windows.Forms.Label
    Friend WithEvents lbl_valor2 As System.Windows.Forms.Label
    Friend WithEvents text_resultatado As TextBox
End Class
