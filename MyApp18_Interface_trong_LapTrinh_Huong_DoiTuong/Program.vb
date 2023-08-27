Imports System

' tạo interface
Public Interface IMyInterface1
    Sub ThongBao()
End Interface



Public Interface IMyInterface2
    ' tạo phương thức tính BMI
    Function Tinh_BMI(ByVal chieu_cao As Double,
                      ByVal can_nang As Double)
End Interface



' tạo lớp ConNguoi
Public Class ConNguoi
    ' triển khai interface
    Implements IMyInterface1
    Implements IMyInterface2



    ' triển khai phương thức thông báo
    Public Sub ThongBao() Implements IMyInterface1.ThongBao
        Console.WriteLine("Day la con nguoi")
    End Sub



    ' triển khai phương thức tính BMI
    Public Function Tinh_BMI(chieu_cao As Double,
                             can_nang As Double) Implements IMyInterface2.Tinh_BMI

        Return can_nang / (chieu_cao ^ 2)
    End Function
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim dt As New ConNguoi

        ' gọi phương thức thông báo
        dt.ThongBao()

        ' tạo biến để lưu giá trị BMI
        Dim bien_BMI As Double

        ' gọi phương thức tính BMI
        bien_BMI = dt.Tinh_BMI(1.8, 60)

        ' in ra màn hình BMI
        ' sử dụng hàm Round() để làm tròn số
        ' lấy 3 chữ số đằng sau dấu phẩy
        Console.WriteLine($"BMI = {Math.Round(bien_BMI, 3)}")
    End Sub
End Module