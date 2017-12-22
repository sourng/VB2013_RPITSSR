Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1, text2, text3, text4 As String
        text1 = "Visual"
        text2 = "Basic"
        text3 = "2013″"
        text4 = text1 + text2 + text3
        MsgBox(text4)
    End Sub
End Class
