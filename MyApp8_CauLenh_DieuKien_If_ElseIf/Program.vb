Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Nhap n: ")

        ' tạo biến n
        Dim n As Integer

        n = Console.ReadLine()

        ' sử dụng câu lệnh điều kiện If... ElseIf
        If n > 0 Then
            Console.WriteLine("n lon hon 0")

        ElseIf n < 0 Then
            Console.WriteLine("n nho hon 0")

        ElseIf n = 0 Then
            Console.WriteLine("n bang 0")

        End If
    End Sub
End Module
