Public Class fmr_inicio

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_TituloInicio.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_calculosMatematicos_Click(sender As Object, e As EventArgs) Handles btn_Calculos.Click
        frm_calculo.Show()
    End Sub

    Private Sub btn_manejoTextos_Click(sender As Object, e As EventArgs) Handles btn_manejoTextos.Click
        frmEntrada.Show()

    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Close()
    End Sub
End Class
