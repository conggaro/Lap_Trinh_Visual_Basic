Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Su dung vong lap While:")

        Dim i As Integer = 1

        ' sử dụng vòng lặp while
        ' để in ra các số nhỏ hơn hoặc bằng 10
        While i <= 10
            Console.WriteLine(i)

            i = i + 1
        End While
    End Sub
End Module
