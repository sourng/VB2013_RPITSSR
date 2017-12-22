Public Class Form1 'ឈ្មោះ​របស់​ form
    Dim password As Integer
    Dim crackpass As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = 123

        sum(5, 6)   'ហៅ​ Sub procedure ឈ្មោះ​ថា​ sum
    End Sub
    Sub sum(a As Single, b As Single)
        MsgBox("sum=" & a + b)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Timer1.Enabled = True
    End Sub
   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        generate()
        If crackpass = password Then
            Timer1.Enabled = False
            Label1.Text = crackpass
            MsgBox("Password Cracked!Login Successful!")
        Else : Label1.Text = crackpass
            Label2.Text = "Please wait..."
        End If

    End Sub

    Sub generate()
        crackpass = Int(Rnd() * 100) + 100
    End Sub


End Class









