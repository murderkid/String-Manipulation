Module MidWord

    Sub Main()

        Dim STR1 As String
        Dim MidWord As String
        Dim Space1 As Integer
        Dim Space2 As Integer
        Dim Wordpos As Integer

        MidWord = ""


        Console.Write("PLease enter Name composed of three words only: ")
        STR1 = Console.ReadLine()

        Space1 = InStr(STR1, " ")
        Space2 = InStr(Space1 + 1, STR1, " ")
        Wordpos = Space2 - Space1 - 1
        MidWord = Mid(STR1, Space1 + 1, Wordpos)

        Console.WriteLine(MidWord)
        Console.ReadKey()
    End Sub

End Module
