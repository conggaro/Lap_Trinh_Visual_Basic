Imports System

' tạo lớp động vật
Public Class DongVat
    ' tạo phương thức thông báo
    Public Overridable Sub ThongBao()
        Console.WriteLine("Day la thong bao DongVat")
    End Sub
End Class



' tạo lớp con chó
Public Class ConCho
    ' dùng từ khoa Inherits để kế thừa
    Inherits DongVat



    ' tạo phương thức thông báo
    ' nhưng ghi đè phương thức thông báo của lớp cha
    Public Overrides Sub ThongBao()
        Console.WriteLine("Day la thong bao ConCho")
    End Sub
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim dt As New ConCho

        ' gọi phương thức thông báo
        dt.ThongBao()
    End Sub
End Module