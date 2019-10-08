Module ReverseString

    Sub Main()
        Dim x As Integer
        Dim Inputstring As String
        Dim NextChar As String
        Dim Outstring As String

        Inputstring = ""
        Outstring = ""
        NextChar = ""
        x = 0

        Console.Write("Plz enter the string you want to reverse: ")
        Inputstring = Console.ReadLine

        For x = Len(Inputstring) To 1 Step -1
            NextChar = Mid(Inputstring, x, 1)
            Outstring = Outstring & NextChar
        Next
        Console.WriteLine(Outstring)
        Console.ReadKey()


    End Sub

End Module
