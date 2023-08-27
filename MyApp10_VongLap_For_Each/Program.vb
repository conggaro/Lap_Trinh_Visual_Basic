Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Su dung vong lap For Each:")

        ' vòng lặp For Each
        ' thường được sử dụng
        ' để in ra các phần tử trong danh sách

        ' ví dụ:
        ' tạo đối tượng có kiểu danh sách
        Dim danhSach As New List(Of String)

        ' thêm phần tử vào danh sách
        danhSach.Add("Rolls Royce")
        danhSach.Add("Bugatti")
        danhSach.Add("Lamborghini")
        danhSach.Add("BMW")
        danhSach.Add("Audi")
        danhSach.Add("Toyota")

        Dim i As Integer = 0

        ' bây giờ
        ' tôi sẽ sử dụng vòng lặp For Each
        For Each item As String In danhSach
            i = i + 1

            Console.WriteLine($"{i}. {item}")
        Next
    End Sub
End Module
