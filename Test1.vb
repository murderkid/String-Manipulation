Module Module1

    Sub Main()

        Dim BinStr, temp, Bit As String
        Dim dec As Integer
        Dim Length As Integer
        Dim IsValid As Boolean = True

        Console.WriteLine("Enter the Binary Number")
        BinStr = Console.ReadLine

        Length = Len(BinStr)

        If Length > 8 Or Length < 1 Then

            Console.WriteLine("Not Valid Binary Number")
            IsValid = False
        Else
            For x = 1 To Length
                Bit = Mid(BinStr, x, 1)
                If Bit <> "0" And Bit <> "1" Then
                    IsValid = False
                    Console.WriteLine("Not Valid Binary Number")
                End If

                temp = Val(Mid(BinStr, Length, 1))
                Length = Length - 1
                If temp <> "0" Then
                    dec += (2 ^ (x - 1))
                End If
            Next
            If IsValid = True Then
                Console.WriteLine("The Denary number of " & BinStr & " is : " & dec)
            End If

            Console.ReadKey()
        End If
        Console.ReadKey()
    End Sub

End Module
