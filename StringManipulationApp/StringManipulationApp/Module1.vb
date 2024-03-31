Imports StringLibrary

Module Module1

    Sub Main()
        Dim originalString As String = "Hello, World!"
        Dim reversedString As String = StringManipulations.ReverseString(originalString)
        Dim concatenatedString As String = StringManipulations.ConcatenateStrings("Hello", ", ", "World", "!")

        Console.WriteLine($"Original: {originalString}")
        Console.WriteLine($"Reversed: {reversedString}")
        Console.WriteLine($"Concatenated: {concatenatedString}")

        Console.ReadKey()
    End Sub


End Module
