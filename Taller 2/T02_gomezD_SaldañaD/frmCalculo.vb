Public Class frm_calculo

    Private Sub lb_titulo_Click(sender As Object, e As EventArgs) Handles lbl_tituloCalculos.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_valor1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_valor2.TextChanged

    End Sub

    Private Sub frm_calculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_valor1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles text_resultatado.TextChanged

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim valor1, valor2, resultado As Double

        Try
            valor1 = CDbl(txt_valor1.Text)
            valor2 = CDbl(txt_valor2.Text)

            resultado = valor1 + valor2

            text_resultatado.Text = resultado.ToString
        Catch ex As Exception
            MsgBox("Solo se pueden ingresar numeros" & ex.Message)
            txt_valor1.Text = String.Empty
            txt_valor2.Text = String.Empty
        End Try

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_valor1.Text = String.Empty
        txt_valor2.Text = String.Empty
        text_resultatado.Text = String.Empty
    End Sub
End Class