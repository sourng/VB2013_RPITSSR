Public Class InputLanguages
    Public Sub EnglishKeyboard()
        For Each Language As InputLanguage In InputLanguage.InstalledInputLanguages
            If Language.Culture.TwoLetterISOLanguageName.Contains("en") = True Then
                InputLanguage.CurrentInputLanguage = Language
            End If
        Next
    End Sub
    Public Sub KhmerKeyboard()
        For Each Language As InputLanguage In InputLanguage.InstalledInputLanguages
            If Language.Culture.TwoLetterISOLanguageName.Contains("km") = True Then
                InputLanguage.CurrentInputLanguage = Language
            End If
        Next
    End Sub
End Class
