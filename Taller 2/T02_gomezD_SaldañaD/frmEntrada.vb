Public Class frmEntrada
    Private Sub lbl_tituloCalculos_Click(sender As Object, e As EventArgs) Handles lbl_titulosIntroduccion.Click

    End Sub

    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_valor1_Click(sender As Object, e As EventArgs) Handles lbl_valor1.Click

    End Sub

    Private Sub lbl_valor2_Click(sender As Object, e As EventArgs) Handles lbl_valor2.Click

    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged

    End Sub

    Private Sub btn_terminar_Click(sender As Object, e As EventArgs) Handles btn_terminar.Click
        Close()

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        frmInfo.txt_info.Text = frmInfo.txt_info.Text & txt_usuario.Text
        frmInfo.txt_info.Text = frmInfo.txt_info.Text & "  " & txt_contraseña.Text & vbNewLine
        frmInfo.txt_ultimaCaptura.Text = txt_usuario.Text + "    " & txt_contraseña.Text
        txt_usuario.Text = ''''
        txt_contraseña.Text = ''''
        txt_usuario.Focus()
        txt_usuario.Text = String.Empty
        txt_contraseña.Text = String.Empty
        MsgBox("Tu mensaje se ha guardado con exito")
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs) Handles btn_visualizar.Click
        Me.Hide()
        frmInfo.Show()
    End Sub
End Class