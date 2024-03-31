Public Class StringManipulations
    Public Shared Function ReverseString(input As String) As String
        Dim charArray As Char() = input.ToCharArray()
        Array.Reverse(charArray)
        Return New String(charArray)
    End Function

    Public Shared Function ConcatenateStrings(ByVal ParamArray strings() As String) As String
        Return String.Join("", strings)
    End Function
End Class

