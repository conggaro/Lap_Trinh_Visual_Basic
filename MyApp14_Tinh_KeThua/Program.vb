Imports System

' tạo lớp động vật
Public Class DongVat
    ' tạo phương thức Hello_DongVat
    Public Sub Hello_DongVat()
        Console.WriteLine("Xin chao DongVat.")
    End Sub
End Class



' tạo lớp con chó
Public Class ConCho
    ' lớp con chó được kế thừa lớp động vật
    ' bằng cách sử dụng từ khóa Inherits
    Inherits DongVat



    ' tạo phương thức Hello_ConCho
    Public Sub Hello_ConCho()
        Console.WriteLine("Xin chao ConCho.")
    End Sub
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim dt As New ConCho

        ' gọi phương thức Hello_DongVat
        ' vì kế thừa nên gọi được phương thức của lớp cha
        dt.Hello_DongVat()

        ' gọi phương thức Hello_ConCho
        dt.Hello_ConCho()
    End Sub
End Module