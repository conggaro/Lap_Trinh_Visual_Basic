Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Nhap so n: ")

        ' tạo biến n
        Dim n As Integer

        n = Console.ReadLine()

        ' sử dụng câu lệnh điều kiện If
        If n > 0 Then
            Console.WriteLine("n > 0")
        End If

        If n < 0 Then
            Console.WriteLine("n < 0")
        End If

        If n = 0 Then
            Console.WriteLine("n == 0")
        End If
    End Sub
End Module
