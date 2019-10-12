Module Module1

    Sub Main()
        Dim Str1, Vowels As String
        Dim VowelCount, count As Integer
        Dim NextVowel As String
        Dim NextChar As String



        Vowels = "AEIOU"

        Console.Write("Please enter the string: ")
        Str1 = Console.ReadLine

        For count = 1 To 5
            NextVowel = Mid(Vowels, count, 1)
            For count2 = 1 To Len(Str1)
                NextChar = Mid(Str1, count2, 1)
                If UCase(NextChar) = NextVowel Then
                    VowelCount = VowelCount + 1
                End If
            Next
        Next
        Console.WriteLine(VowelCount)
        Console.ReadKey()
    End Sub

End Module
