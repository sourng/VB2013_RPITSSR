Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Me.txtResult.Text = Val(txtValue1.Text) + Val(txtValue2.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtValue1.Text = 50
        Me.txtValue2.Text = 40

    End Sub
End Class
