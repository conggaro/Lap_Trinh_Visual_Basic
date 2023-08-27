Imports System

Module Program
    ' tạo hàm kiểu sub
    ' có tác dụng in chữ ra màn hình thôi
    Sub Show_Welcome()
        Console.WriteLine($"Welcome to Visual Basic!")
    End Sub



    ' tạo hàm tính tổng
    ' nó sẽ trả về tổng của 2 số
    ' bạn sẽ phải tạo 1 biến
    ' để hứng dữ liệu trả về của hàm tính tổng
    Public Function TinhTong(ByVal bien1 As Double, ByVal bien2 As Double)
        Dim tong As Double = bien1 + bien2

        Return tong
    End Function



    ' hàm trả về kiểu dữ liệu string
    Public Function XyLy_ThongBao(ByVal str As String)
        Dim thong_bao As String = $"Thong bao: {str}"

        Return thong_bao
    End Function



    Sub Main(args As String())
        ' gọi hàm Show_Welcome
        Show_Welcome()

        ' gọi hàm tính tổng
        Dim tong As Double = TinhTong(10.5, 9)
        Console.WriteLine(tong)

        ' gọi hàm xử lý thông báo
        Dim bien_ThongBao As String = XyLy_ThongBao("Huynh Bao Ngoc")
        Console.WriteLine(bien_ThongBao)
    End Sub
End Module
