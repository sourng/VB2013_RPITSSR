Public Class EncryptDecrypt
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TestEncoding()

    End Sub

    Sub TestEncoding()
        Dim plainText As String = TxtEncrypt.Text
        Dim password As String = InputBox("Protect with password: ")

        Dim wrapper As New EncryptDecryptVB(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)

        TxtEncryptResult.Text = cipherText
        My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
    End Sub

    Sub TestDecoding()
        Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")
        Dim password As String = InputBox("Enter password for decrypt: ")
        Dim wrapper As New EncryptDecryptVB(password)

        ' DecryptData throws if the wrong password is used.
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            ' MsgBox("The plain text is: " & plainText)
            TxtDecryptResult.Text = plainText
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TestDecoding()
    End Sub
End Class