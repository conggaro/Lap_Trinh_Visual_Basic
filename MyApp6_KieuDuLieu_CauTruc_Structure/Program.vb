Imports System

Module Program
    ' sử dụng kiểu dữ liệu Structure
    Structure ConNguoi
        Dim ho_ten As String
        Dim tuoi As Integer
        Dim gioi_tinh As Boolean
    End Structure



    ' tạo hàm nhập dữ liệu
    ' tham số truyền vào sẽ như một đối tượng luôn
    Sub NhapDuLieu(ByRef thamSo As ConNguoi)
        Console.Write("Nhap ten: ")
        thamSo.ho_ten = Console.ReadLine()

        Console.Write("Nhap tuoi: ")
        thamSo.tuoi = Console.ReadLine()

        Console.Write("Nhap gioi tinh (nhap 1 hoac 0): ")
        thamSo.gioi_tinh = Console.ReadLine()
    End Sub



    ' tạo hàm hiển thị dữ liệu
    Sub HienThi(ByVal thamSo As ConNguoi)
        Console.WriteLine($"Ho ten: {thamSo.ho_ten}")
        Console.WriteLine($"Tuoi: {thamSo.tuoi}")
        Console.WriteLine($"Gioi tinh: {thamSo.gioi_tinh}")
    End Sub



    Sub Main(args As String())
        ' tạo biến có kiểu ConNguoi
        ' nó giống tạo đối tượng trong lập trình hướng đối tượng
        Dim dt As ConNguoi

        Console.WriteLine("------------ NHAP DU LIEU ------------")

        ' gọi hàm nhập dữ liệu
        NhapDuLieu(dt)

        Console.WriteLine($"{vbCrLf}---------- HIEN THI DU LIEU ----------")

        ' gọi hàm hiển thị dữ liệu
        HienThi(dt)
    End Sub
End Module