Imports System

'một chương trình VB.NET đơn giản nhất
'là một chương trình chỉ có 1 mô-đun

Module Program
    'khai báo biến toàn cục
    Dim ho_ten As String
    Dim tuoi As Integer
    Dim diem_toan As Double
    Dim diem_van As Double
    Dim diem_TB As Double

    'khai báo hàm nhập dữ liệu
    Sub NhapDuLieu()
        Console.WriteLine("---------- NHAP DU LIEU ----------")
        Console.Write("Nhap ho ten: ")
        ho_ten = Console.ReadLine()

        Console.Write("Nhap tuoi: ")
        tuoi = Console.ReadLine()

        Console.Write("Nhap diem toan: ")
        diem_toan = Console.ReadLine()

        Console.Write("Nhap diem van: ")
        diem_van = Console.ReadLine()
    End Sub

    'khai báo hàm hiển thị
    Sub HienThi()
        Console.WriteLine("------------ HIEN THI ------------")
        Console.WriteLine(ho_ten)
        Console.WriteLine(tuoi)
        Console.WriteLine(diem_toan)
        Console.WriteLine(diem_van)
        Console.WriteLine(diem_TB)
    End Sub

    'khai báo hàm tính trung bình cộng của 2 số
    Sub Tinh_TrungBinhCong(
        ByVal a As Double,
        ByVal b As Double,
        ByRef TBC As Double
    )
        TBC = (a + b) / 2
    End Sub

    Sub Main(args As String())
        'gọi hàm nhập dữ liệu
        NhapDuLieu()

        'gọi hàm tính điểm trung bình
        Tinh_TrungBinhCong(diem_toan, diem_van, diem_TB)

        Console.WriteLine()

        'gọi hàm hiển thị
        HienThi()
    End Sub
End Module
