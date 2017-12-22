
Imports MySql.Data.MySqlClient
Public Class frmLogin

    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim passChar As Boolean = False
    Dim User As String = "Admin"
    Dim pass As String = "123"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passChar = True Then
            txtPassword.PasswordChar = ""
            passChar = False
        Else
            txtPassword.PasswordChar = "*"
            passChar = True
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sql As String
        Dim publictable As New DataTable
        ConnectDB()  'Call Function Connection

        Try
            If txtUserName.Text = "" And txtPassword.Text = "" Then
                MsgBox("Password or Username Incorrect!")

            Else
                sql = "select * from tbl_users where Email ='" & txtUserName.Text & "' and Pass = '" & txtPassword.Text & "'"
                'bind the connection and query
                With cmd
                    .Connection = MysqlConn
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(publictable)

                If publictable.Rows.Count > 0 Then

                    user_email = publictable.Rows(0).Item(4)  'ទាញយក​ Email
                    UserName = publictable.Rows(0).Item(1) & " " & publictable.Rows(0).Item(2) '​ទាញយក​ឈ្មោះ​

                    frmMDIForm.Show()
                    Me.Hide()

                Else
                    MsgBox("Contact administrator to registered!")

                End If

                da.Dispose()
            End If
        Catch ex As Exception

        End Try

    End Sub
 
End Class
