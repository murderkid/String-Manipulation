﻿Module Module1

    Sub Main()
        Dim Alpha, InputStr, Symbols, CapsAlpha, SmallAlpha, Numbers As String
        Dim count As Integer
        Dim Answer, Ans As String

        Alpha = ""
        CapsAlpha = ""
        SmallAlpha = ""
        Symbols = ""
        Numbers = ""
        Answer = "Y"

        While Answer = "Y"
            Console.Write("PLease enter the String: ")
            InputStr = Console.ReadLine

            For count = 1 To Len(InputStr)
                Alpha = Mid(InputStr, count, 1)
                If Asc(Alpha) >= Asc("a") And Asc(Alpha) <= Asc("z") Then
                    SmallAlpha = SmallAlpha & Alpha
                ElseIf Asc(Alpha) >= Asc("A") And Asc(Alpha) <= Asc("Z") Then
                    CapsAlpha = CapsAlpha & Alpha
                ElseIf Asc(Alpha) >= Asc("0") And Asc(Alpha) <= Asc("9") Then
                    Numbers = Numbers & Alpha
                Else
                    Symbols = Symbols & Alpha
                End If
            Next
            If CapsAlpha <> "" Then
                Console.WriteLine("Capital Alphabets: " & CapsAlpha)
            End If
            If SmallAlpha <> "" Then
                Console.WriteLine("Small Alphabets: " & SmallAlpha)
            End If
            If Symbols <> "" Then
                Console.WriteLine("Symbols present are: " & Symbols)
            End If
            If Numbers <> "" Then
                Console.WriteLine("Numbers are: " & Numbers)
            End If
            Console.Write("Do you wanna repeat this, please answer in N or Y : ")
            Ans = Console.ReadLine
            Answer = UCase(Ans)
        End While

        If Answer = "N" Then
            Console.WriteLine("*******GOOD BYE*******")
        End If


        Console.ReadKey()

    End Sub

End Module
