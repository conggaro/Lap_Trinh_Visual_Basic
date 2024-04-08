Imports System

Module Program
    Sub Main(args As String())
        ' Trong Visual Basic (VB),
        ' từ khóa "Dim" là viết tắt của "Dimension",
        ' đây là từ được sử dụng để khai báo biến.
        ' Từ khóa "Dim" được sử dụng
        ' để khai báo biến cục bộ (local variables)
        ' hoặc để khai báo các mảng.


        ' khai báo biến String
        Dim name As String = "Visual Basic"


        ' khai báo biến có kiểu Integer
        Dim number1 As Integer = 1


        ' khai báo biến có kiểu Double
        Dim number2 As Double = 2.5


        ' khai báo biến có kiểu Single
        ' vì trong Visual Basic (VB),
        ' không có kiểu dữ liệu "float"
        Dim number3 As Single = 9.9


        ' khai báo biến có kiểu Decimal
        Dim number4 As Decimal = 10.5


        ' khai báo biến có kiểu Long
        Dim number5 As Long = 123456789


        ' khai báo biến có kiểu Boolean
        Dim condition As Boolean = True


        Console.WriteLine(name)
        Console.WriteLine(number1)
        Console.WriteLine(number2)
        Console.WriteLine(number3)
        Console.WriteLine(number4)
        Console.WriteLine(number5)
        Console.WriteLine(condition)


        ' khai báo đối tượng
        Dim person As New Person()

        person.Id = 1
        person.Name = "Nguyen Van A"

        person.ShowInfo()
        Console.WriteLine(person.Total(1, 2))


        ' ngày hiện tại
        Dim currentDate As DateTime = DateTime.Now

        ' ngày cụ thể
        Dim specificDate As DateTime = New DateTime(2023, 12, 31)


        ' sử dụng hàm tĩnh
        Console.WriteLine(MathUtils.Add(5, 3))
        Console.WriteLine(MathUtils.Subtract(5, 3))
        Console.WriteLine(MathUtils.Recursive(3))
    End Sub
End Module



Public Class Person
#Region "khai báo thuộc tính Id"
    Private _id As Integer?

    ' thuộc tính Id có thể lưu giá trị null
    ' vì có dấu hỏi chấm
    Public Property Id As Integer?
        Get
            Return _id
        End Get
        Set(ByVal value As Integer?)
            _id = value
        End Set
    End Property
#End Region


#Region "khai báo thuộc tính Name"
    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
#End Region


#Region "phương thức không có kiểu trả về"
    ' Trong Visual Basic (VB),
    ' không có kiểu trả về "void"
    ' như trong một số ngôn ngữ lập trình khác
    ' như C# hoặc Java.
    ' Thay vào đó, trong VB,
    ' bạn sử dụng từ khóa "Sub" để khai báo
    ' phương thức không trả về giá trị.
    Public Sub ShowInfo()
        Console.WriteLine($"[{Id}, {Name}]")
    End Sub
#End Region


#Region "phương thức có kiểu trả về"
    ' khai báo phương thức có kiểu trả về
    Public Function Total(x1 As Integer, x2 As Integer) As Integer
        Return x1 + x2
    End Function
#End Region
End Class



Module MathUtils
    ' Trong Visual Basic (VB),
    ' không có khái niệm "hàm static"
    ' như trong một số ngôn ngữ lập trình khác
    ' như C# hoặc Java.
    ' Tuy nhiên, bạn có thể tạo
    ' các phương thức tĩnh (static methods)
    ' bằng cách định nghĩa chúng trong một module.

    ' Module trong VB được sử dụng
    ' để chứa mã trong một phạm vi toàn cục
    ' và các thành viên của Module
    ' có thể truy cập trực tiếp
    ' mà không cần tạo một thể hiện của Module.
    ' Do đó, khi bạn định nghĩa một phương thức
    ' trong một Module,
    ' nó hoạt động như một phương thức tĩnh (Static method)
    ' vì bạn không cần tạo một thể hiện của Module để gọi nó.
    Public Function Add(x As Integer, y As Integer) As Integer
            Return x + y
        End Function


    Public Function Subtract(x As Integer, y As Integer) As Integer
        Return x - y
    End Function


    ' tạo hàm đệ quy
    Public Function Recursive(parameter As Integer) As Integer
        If parameter <= 1 Then
            Return 1
        Else
            Return parameter * Recursive(parameter - 1)
        End If
    End Function
End Module
