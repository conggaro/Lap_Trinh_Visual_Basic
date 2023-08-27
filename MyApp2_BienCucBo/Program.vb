Imports System

Module Program
    Sub Main(args As String())
        'để sử dụng biến cục bộ trong VB.NET
        'thì chúng ta sử dụng từ khóa Dim
        'để khai báo biến

        Dim ho_ten As String

        Console.Write("Nhap ho ten: ")
        ho_ten = Console.ReadLine()

        Console.WriteLine($"Xin chao, {ho_ten}")
    End Sub
End Module
