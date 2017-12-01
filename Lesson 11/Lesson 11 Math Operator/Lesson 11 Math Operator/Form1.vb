Public Class Form1

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim num1, num2, difference, product, quotient, sum As Single
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 + num2
        difference = num1 - num2
        product = num1 * num2
        quotient = num1 / num2
        lblSum.Text = sum
        lblDiff.Text = difference
        lblPro.Text = product
        lblQuot.Text = quotient
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Single
        a = TextBox1.Text
        b = TextBox2.Text
        c = (a ^ 2 + b ^ 2) ^ (1 / 2)
        Label3.Text = c
    End Sub
End Class
