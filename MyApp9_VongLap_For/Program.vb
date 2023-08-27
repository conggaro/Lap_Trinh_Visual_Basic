Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Su dung vong lap For:")

        ' sử dụng vòng lặp For
        ' để in ra các số từ 1 đến 10

        ' cú pháp để kết thúc vòng lặp For
        ' là sử dụng từ khóa Next
        For i As Integer = 1 To 10
            Console.WriteLine(i)
        Next

        ' nếu bạn muốn thoát vòng lặp For một cách đột ngột
        ' bạn có thể sử dụng lệnh Exit For
        ' nó giống từ khóa break trong lập trình C#
        Console.WriteLine($"{vbCrLf}Thoat khoi vong lap For mot cach dot ngot:")

        For i As Integer = 1 To 10
            Console.WriteLine(i)

            If i >= 5 Then
                Exit For
            End If
        Next
    End Sub
End Module