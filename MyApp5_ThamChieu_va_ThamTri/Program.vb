Imports System

Module Program
    ' hàm sử dụng tham chiếu
    Public Sub ThamChieu_TangLen_1(ByRef thamChieu As Integer)
        thamChieu = thamChieu + 1
    End Sub



    ' hàm sử dụng tham trị
    Public Sub ThamTri_TangLen_1(ByVal thamTri As Integer)
        thamTri = thamTri + 1
    End Sub



    Sub Main(args As String())
        ' tạo biến a
        Dim a As Integer = 0

        ' tạo biến b
        Dim b As Integer = 0

        ' in ra a và b lúc ban đầu
        Console.WriteLine("Ban dau:")
        Console.WriteLine($"a = {a}")

        ' cái vbCrLf dùng để xuống dòng
        ' trong ngôn ngữ Visual Basic
        ' ngôn ngữ khác thì nó dùng ký tự '\n'
        Console.WriteLine($"b = {b}{vbCrLf}")

        ' gọi hàm sử dụng tham chiếu
        ThamChieu_TangLen_1(a)

        ' gọi hàm sử dụng tham trị
        ThamTri_TangLen_1(b)

        Console.WriteLine("Luc sau:")
        Console.WriteLine($"a = {a}")
        Console.WriteLine($"b = {b}")
    End Sub
End Module
