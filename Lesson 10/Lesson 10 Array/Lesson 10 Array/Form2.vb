Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click

    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.Leave, Button18.Leave, Button17.Leave, Button16.Leave, Button15.Leave, Button14.Leave, Button13.Leave, Button12.Leave

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button18.MouseHover, Button17.MouseHover, Button16.MouseHover, Button15.MouseHover, Button14.MouseHover, Button13.MouseHover, Button12.MouseHover
        Button1.BackColor = Color.Purple

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button18.MouseLeave, Button17.MouseLeave, Button16.MouseLeave, Button15.MouseLeave, Button14.MouseLeave, Button13.MouseLeave, Button12.MouseLeave
        Button1.BackColor = Color.DarkOliveGreen
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove, Button18.MouseMove, Button17.MouseMove, Button16.MouseMove, Button15.MouseMove, Button14.MouseMove, Button13.MouseMove, Button12.MouseMove

    End Sub
End Class