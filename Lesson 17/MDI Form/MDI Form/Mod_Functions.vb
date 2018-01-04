Imports MySql.Data.MySqlClient

Module Mod_Functions
    Public MysqlConn As New MySqlConnection
	
    Public user_type, UserName, user_email As String
    Public Sub ConnectDB()

        MysqlConn.ConnectionString = ("server=localhost;user id=root;password=;database=vb_training")
        Try
            MysqlConn.Open()
            ' MessageBox.Show("Connection to Database has been opened.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Module
