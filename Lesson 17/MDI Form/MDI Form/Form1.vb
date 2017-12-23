Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Private Sub btnShow_Click(sender As Object, e As EventArgs)
        ConnectDB()  'Call Function Connection
        GetDataToListView()
    End Sub

    Private Sub GetDataToListView()
        lvUsers.Items.Clear()
        Try
            'conn = New MySqlConnection
            'conn.ConnectionString = My.Settings.Conn
            MysqlConn.Open()
            Dim sql As String
            sql = "SELECT user_id,FName,LName,Gender,BOD,Email,Province,Phone,Salary FROM tbl_users"
            cmd = New MySqlCommand(sql, MysqlConn)
            dr = cmd.ExecuteReader
            Dim list As ListViewItem
            Do While dr.Read = True
                list = New ListViewItem(dr(0).ToString)
                list.SubItems.Add(dr(1))
                list.SubItems.Add(dr(2))
                list.SubItems.Add(dr(3))
                list.SubItems.Add(dr(4))
                list.SubItems.Add(dr(5))
                list.SubItems.Add(dr(6))
                list.SubItems.Add(dr(7))
                list.SubItems.Add(dr(8))

                lvUsers.Items.Add(list)
            Loop
        Catch ex As MySqlException
            MysqlConn.Close()
            MsgBox(ex.Message)
            Exit Try

        Finally
            MysqlConn.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()  'Call Function Connection
        GetDataToListView()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim j As Integer = lvUsers.Items.Count
        If Me.txtFName.Text = "" Then
            MsgBox("Please Fill in First Name")
            lbl_FName.ForeColor = Color.Red

            Me.txtFName.Focus()
        ElseIf Me.txtLName.Text = "" Then
            MsgBox("Please fill in Last Name")
            lbl_LName.ForeColor = Color.Red
            Me.txtLName.Focus()
        Else

            lvUsers.Items.Add(Me.txtID.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtFName.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtLName.Text)
            lvUsers.Items(j).SubItems.Add(Me.cboGender.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtBOD.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtEmail.Text)
            'frmUserList.lv_Users.Items(j).SubItems.Add(Me.txtPassword.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtCommune.Text & "," & txtDistrict.Text & "," & txtProvince.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtPhone.Text)
            lvUsers.Items(j).SubItems.Add(Me.txtSalary.Text)

            'Save Data From form to Database table name tbl_users

            Dim READER As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim Query As String

                Query = "INSERT INTO tbl_users (FName, LName, Gender, Email, Pass,BOD, Commune, District, Province,Phone, Salary, Image) values ('" _
                   & txtFName.Text & "','" & txtLName.Text & "','" & cboGender.Text & "','" & txtEmail.Text & "','" & txtPassword.Text & "','" & txtBOD.Text & "','" _
                   & txtCommune.Text & "','" & txtDistrict.Text & "','" & txtProvince.Text & "','" & txtPhone.Text & "','" & txtSalary.Text & "','" & lblImageFile.Text & "')"

                'Query = "INSERT INTO table_Name (F1,F2,F3,F4,...,Fn) Value(" & txtFName.Text & ",'" & txtFName.Text & "','" & txtFName.Text & "')"


                Dim Command = New MySqlCommand(Query, MysqlConn)
                READER = Command.ExecuteReader
                MessageBox.Show("Data Saved")
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try


            Call Clear()

        End If
    End Sub

    Private Sub Clear()
        Me.txtID.Text = ""
        Me.txtFName.Text = ""
        Me.cboGender.Text = ""
        Me.txtPassword.Text = ""
        Me.txtEmail.Text = ""
        Me.txtLName.Text = ""
        Me.txtBOD.Text = ""
        Me.txtCommune.Text = ""
        Me.txtDistrict.Text = ""
        Me.txtProvince.Text = ""
        Me.txtPhone.Text = ""
        Me.txtSalary.Text = ""
        'Me.UserImage.Image = Nothing
        'Me.lblImageFile.Text = "No Image"
        Me.txtID.Text = lvUsers.Items.Count + 1
        Me.txtFName.Focus()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call Clear()
    End Sub
End Class
