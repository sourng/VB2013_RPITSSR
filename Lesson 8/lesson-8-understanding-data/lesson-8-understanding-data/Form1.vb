Public Class Form1

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim DOB As Date
        DOB = "12-Mar-2018"

        Dim x As Double
        x = Math.Sqrt(16)
        MsgBox(DOB & " Sqrt :" & x)
    End Sub
End Class
