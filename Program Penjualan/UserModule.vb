Module Login
    Public Function doLogin(ByVal username As String, ByVal password As String) As Boolean
        If (username.Equals("admin") And password.Equals("admin")) Then
            Return True
        ElseIf (Not (username.Equals("admin"))) Then
            MessageBox.Show("Username Is Not Valid")
            Return False
        ElseIf (Not (password.Equals("admin"))) Then
            MessageBox.Show("Password Invalid")
            Return False
        End If
        Return False
    End Function

End Module
