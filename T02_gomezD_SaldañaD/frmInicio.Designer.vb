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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmr_inicio))
        Me.lbl_TituloInicio = New System.Windows.Forms.Label()
        Me.btn_Calculos = New System.Windows.Forms.Button()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_manejoTextos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TituloInicio
        '
        Me.lbl_TituloInicio.AutoSize = True
        Me.lbl_TituloInicio.Font = New System.Drawing.Font("Microsoft YaHei", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_TituloInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lbl_TituloInicio.Location = New System.Drawing.Point(143, 27)
        Me.lbl_TituloInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_TituloInicio.Name = "lbl_TituloInicio"
        Me.lbl_TituloInicio.Size = New System.Drawing.Size(538, 112)
        Me.lbl_TituloInicio.TabIndex = 0
        Me.lbl_TituloInicio.Text = "Herramientas de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programación Aplicadas"
        Me.lbl_TituloInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Calculos
        '
        Me.btn_Calculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Calculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Calculos.FlatAppearance.BorderSize = 0
        Me.btn_Calculos.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Calculos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Calculos.Location = New System.Drawing.Point(251, 258)
        Me.btn_Calculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Calculos.Name = "btn_Calculos"
        Me.btn_Calculos.Size = New System.Drawing.Size(303, 60)
        Me.btn_Calculos.TabIndex = 1
        Me.btn_Calculos.Text = "Calculos matemáticos"
        Me.btn_Calculos.UseVisualStyleBackColor = False
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.White
        Me.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btn_finalizar.FlatAppearance.BorderSize = 3
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_finalizar.ForeColor = System.Drawing.Color.Crimson
        Me.btn_finalizar.Location = New System.Drawing.Point(251, 407)
        Me.btn_finalizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(303, 52)
        Me.btn_finalizar.TabIndex = 3
        Me.btn_finalizar.Text = "Finalizar"
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(339, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Taller 8"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(153, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(511, 10)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_manejoTextos
        '
        Me.btn_manejoTextos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_manejoTextos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manejoTextos.FlatAppearance.BorderSize = 0
        Me.btn_manejoTextos.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manejoTextos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_manejoTextos.Location = New System.Drawing.Point(251, 326)
        Me.btn_manejoTextos.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_manejoTextos.Name = "btn_manejoTextos"
        Me.btn_manejoTextos.Size = New System.Drawing.Size(303, 60)
        Me.btn_manejoTextos.TabIndex = 6
        Me.btn_manejoTextos.Text = "Manejo de textos"
        Me.btn_manejoTextos.UseVisualStyleBackColor = False
        '
        'fmr_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(841, 524)
        Me.Controls.Add(Me.btn_manejoTextos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.btn_Calculos)
        Me.Controls.Add(Me.lbl_TituloInicio)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmr_inicio"
        Me.Text = "Taller #2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_TituloInicio As System.Windows.Forms.Label
    Friend WithEvents btn_Calculos As System.Windows.Forms.Button
    Friend WithEvents btn_finalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_manejoTextos As Button
End Class
