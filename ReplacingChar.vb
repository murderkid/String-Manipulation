Module ReplacingChar

    Sub Main()
        Dim String1, NewString As String
        Dim Char1, Char2, Char3 As String

        String1 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        NewString = ""

        Console.Write("Please enter the String you want to edit: ")
        String1 = Console.ReadLine
        Console.Write("Please enter the charecter you want to replace: ")
        Char1 = Console.ReadLine
        Console.Write("Please enter the charecter you want to replace With: ")
        Char2 = Console.ReadLine

        For Count = 1 To Len(String1)
            Char3 = Mid(String1, Count, 1)
            If Asc(Char3) = Asc(Char1) Then
                NewString = NewString & Char2
            Else
                NewString = NewString & Char3

            End If
        Next
        Console.Write(NewString)
        Console.ReadKey()



    End Sub

End Module
