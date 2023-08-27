Imports System

' tạo lớp ConNguoi
Public Class ConNguoi
    ' đây là thuộc tính của họ tên
    Private ho_ten As String

    ' đây là thuộc tính của tuổi
    Private tuoi As Integer

    ' đây là thuộc tính của giới tính
    Private gioi_tinh As Boolean

    ' đây là thuộc tính của điểm toán
    Private diem_toan As Double

    ' đây là thuộc tính của điểm văn
    Private diem_van As Double

    ' đây là thuộc tính của điểm trung bình
    Private diem_TB As Double



    ' đây là hàm khởi tạo không tham số
    Public Sub New()
        ho_ten = String.Empty
        tuoi = 0
        gioi_tinh = False
        diem_toan = 0
        diem_van = 0
        diem_TB = 0
        Return
    End Sub



    ' đây là hàm khởi tạo có tham số
    Public Sub New(ByVal data1 As String,
                   ByVal data2 As Integer,
                   ByVal data3 As Boolean,
                   ByVal data4 As Double,
                   ByVal data5 As Double)

        ho_ten = data1
        tuoi = data2
        gioi_tinh = data3
        diem_toan = data4
        diem_van = data5

        ' gán luôn giá trị 0
        ' cho thuộc tính điểm trung bình
        diem_TB = 0
    End Sub



    ' đây là hàm khởi tạo sao chép
    Public Sub New(ByRef dt As ConNguoi)
        ho_ten = dt.ho_ten
        tuoi = dt.tuoi
        gioi_tinh = dt.gioi_tinh
        diem_toan = dt.diem_toan
        diem_van = dt.diem_van
        diem_TB = dt.diem_TB
    End Sub



    ' đây là phương thức nhập dữ liệu
    Public Sub NhapDuLieu()
        Console.Write("Nhap ho ten: ")
        ho_ten = Console.ReadLine()

        Console.Write("Nhap tuoi: ")
        tuoi = Console.ReadLine()

        Console.Write("Nhap gioi tinh: ")
        gioi_tinh = Console.ReadLine()

        Console.Write("Nhap diem toan: ")
        diem_toan = Console.ReadLine()

        Console.Write("Nhap diem van: ")
        diem_van = Console.ReadLine()
    End Sub



    ' đây là phương thức hiển thị dữ liệu
    Public Sub HienThi()
        Console.WriteLine($"Ho ten: {ho_ten}")
        Console.WriteLine($"Tuoi: {tuoi}")
        Console.WriteLine($"Gioi tinh: {gioi_tinh}")
        Console.WriteLine($"Diem toan: {diem_toan}")
        Console.WriteLine($"Diem van: {diem_van}")

        ' tính điểm trung bình
        diem_TB = (diem_toan + diem_van) / 2

        Console.WriteLine($"Diem trung binh: {diem_TB}")
    End Sub



    ' trong code Visual Basic
    ' thì nó dùng từ khóa Property
    ' để tạo ra phương thức set, phương thức get

    Property _HoTen() As String
        Get
            Return ho_ten
        End Get

        Set(ByVal thamSo As String)
            ho_ten = thamSo
        End Set
    End Property

    Property _Tuoi() As Integer
        Get
            Return tuoi
        End Get

        Set(ByVal thamSo As Integer)
            tuoi = thamSo
        End Set
    End Property

    Property _GioiTinh() As Boolean
        Get
            Return gioi_tinh
        End Get

        Set(ByVal thamSo As Boolean)
            gioi_tinh = thamSo
        End Set
    End Property

    Property _DiemToan() As Double
        Get
            Return diem_toan
        End Get

        Set(ByVal thamSo As Double)
            diem_toan = thamSo
        End Set
    End Property

    Property _DiemVan() As Double
        Get
            Return diem_van
        End Get

        Set(ByVal thamSo As Double)
            diem_van = thamSo
        End Set
    End Property
End Class



Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim dt As New ConNguoi()

        Dim dt2 As New ConNguoi("Nguyen Van Binh",
                                30,
                                True,
                                9.5,
                                8.8)

        Console.WriteLine("---------- NHAP DU LIEU ----------")

        ' gọi phương thức nhập dữ liệu
        dt.NhapDuLieu()

        Console.WriteLine($"{vbCrLf}{vbCrLf}------------ HIEN THI ------------")

        ' gọi phương thức hiển thị dữ liệu
        dt.HienThi()

        ' câu lệnh xuống dòng
        Console.WriteLine()

        dt2.HienThi()

        ' câu lệnh xuống dòng
        Console.WriteLine()

        Dim dt3 As New ConNguoi(dt)
        dt3.HienThi()



        ' ví dụ:
        ' cách sử dụng phương thức set, get
        Dim dt4 As New ConNguoi()
        dt4._HoTen = "Huynh Bao Ngoc"
        dt4._Tuoi = 20
        dt4._GioiTinh = False
        dt4._DiemToan = 9.5
        dt4._DiemVan = 9.8

        dt4.HienThi()
    End Sub
End Module