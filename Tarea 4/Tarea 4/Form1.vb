Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num, i, factorial As Integer
        num = CInt(txtNumero.Text)
        factorial = 1
        For i = 1 To num
            factorial = factorial * i
        Next
        txtFactorial.Text = factorial

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero.Text = ""
        txtFactorial.Text = ""
    End Sub
End Class
