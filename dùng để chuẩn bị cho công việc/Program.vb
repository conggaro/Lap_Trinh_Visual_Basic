Imports System

Module Program
    Sub Main(args As String())
        ' tạo đối tượng
        Dim person1 As New PersonEntity()
        person1.ID = 1
        person1.NAME = "John"

        ' Gọi phương thức ShowInfo để hiển thị thông tin của đối tượng
        person1.ShowInfo()



        ' khai báo biến
        ' có kiểu dữ liệu danh sách
        Dim personList As New List(Of PersonEntity)()
        personList.Add(person1)
        personList.Add(person1)
        personList.Add(person1)


        Dim personList2 As New List(Of PersonEntity) From
        {
            New PersonEntity() With {.ID = 1, .NAME = "Nguyen Van A"},
            New PersonEntity() With {.ID = 2, .NAME = "Nguyen Van B"},
            New PersonEntity() With {.ID = 3, .NAME = "Nguyen Van C"}
        }


        ' học cách sử dụng linq
        ' trong code Visual Basic
        Dim query = From item In personList2
                    Where item.ID >= 2
                    Order By item.ID Descending
                    Select item


        ' linq nhưng ánh xạ các phần tử sang
        ' kiểu dữ liệu PersonDTO
        Dim query2 = From item In personList2
                     Where item.ID >= 2
                     Order By item.ID Descending
                     Select New PersonDTO With
                     {
                         .Id = item.ID,
                         .Name = item.NAME
                     }


        ' lấy bản ghi đầu tiên
        ' theo điều kiện
        Dim get1 = personList2.FirstOrDefault(Function(x) x.ID = 3)


        ' nếu không tìm thấy bản ghi nào
        ' thì nó sẽ trả về "Nothing"
        Dim get2 = personList2.FirstOrDefault(Function(x) x.ID = 10)


        ' sử dụng phương thức Where()
        Dim useWhere = personList2.Where(Function(x) x.NAME = "Nguyen Van B")


        ' sử dụng phương thức Any()
        Dim useAny1 = personList2.Any(Function(x) x.ID = 3)
        Dim useAny2 = personList2.Any(Function(x) x.ID = 100)


        ' sử dụng phương thức All()
        ' kiểm tra xem tất cả bản ghi có ID = 2 không
        ' nếu đúng thì True
        ' nếu sai thì False
        Dim useAll1 = personList2.All(Function(x) x.ID = 2)


        ' kiểm tra xem tất cả bản ghi có ID >= 0 không
        ' nếu đúng thì True
        ' nếu sai thì False
        Dim useAll2 = personList2.All(Function(x) x.ID >= 0)



        ' tạo danh sách có
        ' các phần tử là kiểu dữ liệu "Product"
        Dim listProduct = CreateListProduct()


        ' tạo danh sách có
        ' các phần tử là kiểu dữ liệu "Brand"
        Dim listBrand = CreateListBrand()


        ' kết hợp dữ liệu
        ' từ 2 danh sách "listProduct" và "listBrand"
        ' để cung cấp nhiều thông tin cho "người dùng"
        Dim dataSource = From item1 In listProduct
                         From item2 In listBrand.Where(Function(x) x.ID = item1.BRAND_ID).DefaultIfEmpty()
                         Select New With
                         {
                            .Id = item1.ID,
                            .NameProduct = item1.NAME,
                            .NameBrand = item2.NAME
                         }


        ' kết hợp dữ liệu
        ' cách 2
        Dim dataSource2 = From item1 In listProduct
                          Join item2 In listBrand On item2.ID Equals item1.BRAND_ID
                          Where item1.ID >= 5
                          Order By item1.ID Descending
                          Select New With
                          {
                              .Id = item1.ID,
                              .NameProduct = item1.NAME,
                              .NameBrand = item2.NAME
                          }


        ' kết hợp dữ liệu
        ' cách 3
        Dim dataSource3 = From item1 In listProduct
                          Group Join item2 In listBrand On item2.ID Equals item1.BRAND_ID Into BrandGroup = Group
                          From item2 In BrandGroup.DefaultIfEmpty()
                          Where item1.ID >= 5
                          Order By item1.ID Descending
                          Select New With
                          {
                              .Id = item1.ID,
                              .NameProduct = item1.NAME,
                              .NameBrand = If(item2 IsNot Nothing, item2.NAME, String.Empty)
                          }


        ' sử dụng phương thức DistinctBy()
        Dim useDistinctBy = listProduct.DistinctBy(Function(x) x.BRAND_ID)
    End Sub



    ' hàm tạo danh sách bản ghi
    ' các phần tử có kiểu dữ liệu "Product"
    Function CreateListProduct() As List(Of Product)
        Dim list = New List(Of Product) From
        {
            New Product With {.ID = 1, .NAME = "P_01", .BRAND_ID = 1},
            New Product With {.ID = 2, .NAME = "P_02", .BRAND_ID = 1},
            New Product With {.ID = 3, .NAME = "P_03", .BRAND_ID = 2},
            New Product With {.ID = 4, .NAME = "P_04", .BRAND_ID = 2},
            New Product With {.ID = 5, .NAME = "P_05", .BRAND_ID = 3},
            New Product With {.ID = 6, .NAME = "P_06", .BRAND_ID = 3},
            New Product With {.ID = 7, .NAME = "P_07", .BRAND_ID = 4},
            New Product With {.ID = 8, .NAME = "P_08", .BRAND_ID = 4},
            New Product With {.ID = 9, .NAME = "P_09", .BRAND_ID = 5},
            New Product With {.ID = 10, .NAME = "P_10", .BRAND_ID = 5}
        }

        Return list
    End Function



    ' hàm tạo danh sách bản ghi
    ' các phần tử có kiểu dữ liệu "Brand"
    Function CreateListBrand() As List(Of Brand)
        Dim list = New List(Of Brand) From
        {
            New Brand With {.ID = 1, .NAME = "Rolls-Royce"},
            New Brand With {.ID = 2, .NAME = "Toyota"},
            New Brand With {.ID = 3, .NAME = "Mazda"},
            New Brand With {.ID = 4, .NAME = "Ford"},
            New Brand With {.ID = 5, .NAME = "Cadillac"}
        }

        Return list
    End Function
End Module



Public Class PersonEntity
    Public Property ID As Integer
    Public Property NAME As String

    Public Sub ShowInfo()
        Console.WriteLine("ID: " & ID)
        Console.WriteLine("Name: " & NAME)
    End Sub
End Class



Public Class PersonDTO
    Public Property Id As Nullable(Of Integer)
    Public Property Name As String
End Class



Public Class Product
    Public Property ID As Integer
    Public Property NAME As String
    Public Property BRAND_ID As String
End Class



Public Class Brand
    Public Property ID As Integer
    Public Property NAME As String
End Class