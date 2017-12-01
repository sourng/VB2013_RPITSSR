Public Class Form1
    

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        'Using Wrong Variable 
        Dim YourMessage As Integer
        YourMessage = "Happy Birthday!" 'មិនអាច​ទទួល​តម្លៃ​បាន​
        MsgBox(YourMessage)

        '----------------------------------------------------------
        


    End Sub

    Private Sub btnFindRoot_Click(sender As Object, e As EventArgs) Handles btnFindRoot.Click
        Dim a As Double = Val(txtA.Text)
        Dim b As Double = Val(txtB.Text)
        Dim c As Double = Val(txtC.Text)

        Dim delta As Double
        Dim x1 As Double
        Dim x2 As Double

        'delta = b * b - 4 * a * c
        delta = b ^ 2 - 4 * a * c

        If (delta > 0) Then
            x1 = (-b - Math.Sqrt(delta)) / (2 * a)
            x2 = (-b + Math.Sqrt(delta)) / (2 * a)
            'MsgBox("Result X1=" & x1 & " and X2=" & x2)
            lblRoot.Text = ("Result X1=" & x1 & " and X2=" & x2)
        ElseIf delta = 0 Then
            x1 = (-b / (2 * a))
            'MsgBox("Result of X1=X2=" & x1)
            lblRoot.Text = ("Result of X1=X2=" & x1)

        Else
            'MsgBox("No Root")
            lblRoot.Text = "No Root"
        End If


    End Sub

    Private Sub btnConst_Click(sender As Object, e As EventArgs) Handles btnConst.Click
        Const Pi As Single = 3.14
        Dim Cirlce As Single
        Dim R As Single = InputBox("Please Enter R:")

        Cirlce = Pi * R ^ 2

        lblRoot.Text = Cirlce



    End Sub
End Class
