Imports System

Module Program
    Public ho_ten As String
    Public diem_toan As Double
    Public diem_van As Double
    Public diem_TB As Double

    Sub Main(args As String())
        'nhập họ tên
        Console.Write("Nhap ho ten: ")
        ho_ten = Console.ReadLine()

        'nhập điểm toán
        Console.Write("Nhap diem toan: ")
        diem_toan = Console.ReadLine()

        'nhập điểm văn
        Console.Write("Nhap diem van: ")
        diem_van = Console.ReadLine()

        'in ra thông báo
        Console.WriteLine()
        Console.WriteLine($"---------- THONG BAO ----------")
        Console.WriteLine($"Ho ten: {ho_ten}")
        Console.WriteLine($"Diem toan: {diem_toan}")
        Console.WriteLine($"Diem van: {diem_van}")

        diem_TB = (diem_toan + diem_van) / 2

        Console.WriteLine($"Diem trung binh: {diem_TB}")
    End Sub
End Module
