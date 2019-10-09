Module Module1

    Sub Main()
        Dim InputString, MyStr, NewStr, Firstword As String
        Dim X As Integer
        Dim Spacepos1 As Boolean = False
        Dim Str2, Alpha, LastWord, Word, Alpha2 As String
        Dim Count As Integer
        Dim SpaceCount As Integer
        Dim Space As Boolean = False

        NewStr = ""
        Word = ""
        LastWord = ""
        Firstword = ""
        Str2 = ""
        Alpha = ""
        Alpha2 = ""
        SpaceCount = 0

        Console.Write("Please enter a string For the First word: ")
        InputString = Console.ReadLine
        Console.Write("Please enter the string for the Last Word: ")
        Str2 = Console.ReadLine




        For X = 1 To Len(InputString)

            MyStr = Mid(InputString, X, 1)
            If MyStr = " " Then
                Spacepos1 = True
                Exit For
            Else

                Firstword = Firstword & MyStr
            End If
        Next



        For Count = Len(Str2) To 1 Step -1
            Alpha = Mid(Str2, Count, 1)
            If Alpha = " " Then
                Space = True
                Exit For
            Else
                Word = Word & Alpha
            End If
        Next
        For Count2 = Len(Word) To 1 Step -1
            Alpha2 = Mid(Word, Count2, 1)
            LastWord = LastWord & Alpha2
        Next
        NewStr = Firstword & " " & LastWord

        Console.Write(NewStr)
        Console.ReadKey()

    End Sub

End Module
