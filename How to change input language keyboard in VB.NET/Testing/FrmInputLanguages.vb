Public Class FrmInputLanguages


    Private InputLang As New InputLanguages
    Private Sub TxtKhmerKeyboard_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtKhmerKeyboard.GotFocus
        InputLang.KhmerKeyboard()
    End Sub

    Private Sub TxtEnglishKeyboard_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEnglishKeyboard.GotFocus
        InputLang.EnglishKeyboard()
    End Sub


    Private Sub TxtKhmerKeyboard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKhmerKeyboard.KeyPress
        'If Not Char.IsLetter(e.KeyChar) Then e.Handled = True  'letters only

        If Char.IsNumber(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Or e.KeyChar = Chr(13) Then e.Handled = False 'Backspace or Enter
    End Sub
End Class