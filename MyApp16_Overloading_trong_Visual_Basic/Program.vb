Imports System

' tạo lớp tính toán
Public Class TinhToan
    ' tạo phương thức tính tổng
    ' với tham số kiểu Integer
    Public Overloads Function TinhTong(ByVal thamSo1 As Integer,
                                       ByVal thamSo2 As Integer)

        Return thamSo1 + thamSo2
    End Function



    ' tạo phương thức tính tổng
    ' với tham số kiểu Double
    Public Overloads Function TinhTong(ByVal thamSo1 As Double,
                                       ByVal thamSo2 As Double)
        Return thamSo1 + thamSo2
    End Function
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim dt As New TinhToan

        ' tạo biến tổng 1
        Dim tong1 As Integer = dt.TinhTong(5, 10)

        ' in ra biến tổng 1
        Console.WriteLine($"tong1 = {tong1}")

        ' tạo biến tổng 2
        Dim tong2 As Double = dt.TinhTong(9.9, 20)

        ' in ra biến tổng 2
        Console.WriteLine($"tong2 = {tong2}")
    End Sub
End Module