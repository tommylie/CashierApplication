Module PasswordUtility
    Public Function encrypt(ByVal password As String) As String
        Dim result As String = ""
        Dim charOfPasswd() As Char
        charOfPasswd = password.ToCharArray
        For i = 0 To password.Length - 1
            result &= (Asc(charOfPasswd(i)) + 0).ToString
        Next i
        Return result
    End Function

    Public Function decrypt(ByVal password As String) As String
        Dim result As String = ""
        Dim charOfPasswd() As Char
        charOfPasswd = password.ToCharArray
        For i = 0 To password.Length - 1
            result &= (Chr(Asc(charOfPasswd(i)) - 0)).ToString
        Next i
        Return result
    End Function
End Module
