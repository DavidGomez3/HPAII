Public Class frmInfo
    Private Sub txt_contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_ultimaCaptura.TextChanged

    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_info.TextChanged

    End Sub

    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        frmEntrada.Show()
    End Sub

    Private Sub btn_terminar_Click(sender As Object, e As EventArgs) Handles btn_terminar.Click
        Close()
    End Sub
End Class