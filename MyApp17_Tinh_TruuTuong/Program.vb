Imports System

' ngôn ngữ lập trình Visual Basic không hỗ trợ đa kế thừa



' tạo lớp trừu tượng động vật
Public MustInherit Class DongVat
    ' tạo phương thức trừu tượng
    Public MustOverride Sub ThongBao()
End Class



' tạo lớp con chó
' kế thừa lớp động vật
Public Class ConCho
    Inherits DongVat


    ' ghi đè phương thức thông báo
    ' được kế thừa từ lớp DongVat
    Public Overrides Sub ThongBao()
        Console.WriteLine("Day la ConCho")
    End Sub
End Class



' tạo lớp con mèo
' kế thừa lớp động vật
Public Class ConMeo
    Inherits DongVat



    Public Overrides Sub ThongBao()
        Console.WriteLine("Day la ConMeo")
    End Sub
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng có kiểu con chó
        Dim dt_ConCho As New ConCho

        ' gọi phương thức thông báo
        dt_ConCho.ThongBao()

        ' dòng code này để xuống dòng
        Console.WriteLine()

        ' tạo đối tượng có kiểu con mèo
        Dim dt_ConMeo As New ConMeo

        ' gọi phương thức thông báo
        dt_ConMeo.ThongBao()
    End Sub
End Module