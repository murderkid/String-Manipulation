Module mostrepeatedcharcounter

    Sub Main()
        Dim Inputstr As String
        Dim Alpha1, Alpha2, MostRepeatedAlpha, Answer As String
        Dim HighestCount, Count, countAlpha As Integer

        Answer = ""
        HighestCount = 0
        countAlpha = 0
        Inputstr = ""
        MostRepeatedAlpha = ""



        Console.Write("Please enter a string : ")
        Inputstr = Console.ReadLine

        For Count = 1 To Len(Inputstr)
            countAlpha = 0
            Alpha1 = Mid(Inputstr, Count, 1)
            For count2 As Integer = 1 To Len(Inputstr)
                Alpha2 = Mid(Inputstr, count2, 1)
                If Alpha1 = Alpha2 Then
                    countAlpha = countAlpha + 1
                End If
            Next
            If HighestCount < countAlpha Then
                HighestCount = countAlpha
                MostRepeatedAlpha = Alpha1
            End If

        Next


        Console.WriteLine("Most repeated character is " & MostRepeatedAlpha & ", and it is repeated " & HighestCount & " times.")


        Console.ReadKey()
        End

End Module
