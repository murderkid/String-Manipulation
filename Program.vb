Imports System

Module Program

	Sub Main()
		Dim i As Integer
		Dim Student(10) As String
		Dim Name, Search As String
		Dim IsFound As Boolean

		IsFound = False

		i = 0

		For i = 1 To 10
			Console.WriteLine("Enter no " & i & " Student")
			Name = Console.ReadLine()
			Student(i) = Name
		Next

	Console.WriteLine("Please enter the student Name you want to search for")
		Search = Console.ReadLine()

		For i = 1 To 10
			If Student(i) = Search Then
				IsFound = True
				Exit For
			End If
		Next

		If IsFound = True Then
			Console.WriteLine("Found")
		End If
		Console.ReadKey()

	End Sub
End Module
