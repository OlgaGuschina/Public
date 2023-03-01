Imports System

Module Cows
    Sub Main(args As String())
        Dim number, ver As String
        'TODO: генерируем число
        number = "1234"

        Console.WriteLine("Угадай число")

        Do
            ver = Console.ReadLine()
            For i = 0 To 3
                If (number.Chars(0) = ver.Chars(0)) Then
                    Console.WriteLine("Угадал")
                Else
                    Console.WriteLine("Не верно")
                End If
            Next
        Loop Until number = ver
    End Sub
End Module
