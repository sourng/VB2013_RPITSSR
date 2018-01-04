Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://ftp.sourngonline.com/myupload/file.txt"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential("sourngonline", "sng9999@")
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile
        Dim file() As Byte = System.IO.File.ReadAllBytes("c:\file.txt")
        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()
    End Sub
End Class
