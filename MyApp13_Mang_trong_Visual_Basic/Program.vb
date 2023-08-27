Imports System

Module Program
    Sub Main(args As String())
        ' tạo mảng trong Visual Basic
        ' mảng chính là Array
        Dim mang_arr(5) As Integer

        ' ghi dữ liệu vào mảng
        mang_arr(0) = 10
        mang_arr(1) = 20
        mang_arr(2) = 30
        mang_arr(3) = 40
        mang_arr(4) = 50

        ' in mảng ra màn hình
        For i As Integer = 0 To 4
            Console.WriteLine(mang_arr(i))
        Next
    End Sub
End Module
