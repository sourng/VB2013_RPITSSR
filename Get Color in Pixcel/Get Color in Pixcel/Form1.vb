Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)
        b.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), New Drawing.Point(0, 0), a.Size)
        Dim c As Drawing.Color = a.GetPixel(0, 0)
        PictureBox1.BackColor = c
        TextBox1.Text = PictureBox1.BackColor.Name

        TextBox1.BackColor = c

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        TextBox2.Text = TextBox1.Text

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPixel_Example(e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Text = TextBox1.Text
    End Sub


    Private Sub SetPixel_Example(ByVal e As PaintEventArgs)

        ' Create a Bitmap object from a file.
        Dim myBitmap As New Bitmap("Grapes.png")

        ' Draw myBitmap to the screen.
        e.Graphics.DrawImage(myBitmap, 0, 0, myBitmap.Width, _
        myBitmap.Height)

        ' Set each pixel in myBitmap to black.
        Dim Xcount As Integer
        For Xcount = 0 To myBitmap.Width - 1
            Dim Ycount As Integer
            For Ycount = 0 To myBitmap.Height - 1
                myBitmap.SetPixel(Xcount, Ycount, Color.Black)
            Next Ycount
        Next Xcount

        ' Draw myBitmap to the screen again.
        e.Graphics.DrawImage(myBitmap, myBitmap.Width, 0, myBitmap.Width, _
            myBitmap.Height)
    End Sub

End Class
