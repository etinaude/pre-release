Module task1
    Private computers(50, 50) As String
    Function findarray(y)
        Dim found As Integer
        For x = 0 To 50
            If y = computers(x, 0) Then
                found = x
                Exit For
            Else
                found = -1
            End If
        Next
        Return found
    End Function
    Class Computer
        Private Code As String
        Private Width As Decimal
        Private Height As Decimal
        Private Weight As Decimal
        Private Make As String
        Private Processor As String
        Private RAM_Size As String
        Private Storage_Size As String
        Public Sub getcomputer()
            Get_code()
            Get_Width()
            Get_Height()
            Get_Weight()
            Get_make()
            Get_Processor()
            Get_RAM_Size()
            Get_Storage_Size()
        End Sub
        Public Sub testcomputer()
            Code = phoneinfo(0)
            Width = phoneinfo(1)
            Height = phoneinfo(2)
            Weight = phoneinfo(3)
            Make = phoneinfo(4)
            Processor = phoneinfo(5)
            RAM_Size = phoneinfo(6)
            Storage_Size = phoneinfo(7)
        End Sub
        Public Sub NewComputer()
            Set_code()
            Set_Width()
            Set_Height()
            Set_Weight()
            Set_make()
            Set_Processor()
            Set_RAM_Size()
            Set_Storage_Size()
        End Sub
        Public Sub Set_code()
            Code = Console.ReadLine
        End Sub
        Public Sub Get_code()
            Console.WriteLine(Code)
        End Sub
        Public Sub Set_Width()
            Width = Console.ReadLine
        End Sub
        Public Sub Get_Width()
            Console.WriteLine(Width)
        End Sub
        Public Sub Set_Height()
            Height = Console.ReadLine
        End Sub
        Public Sub Get_Height()
            Console.WriteLine(Height)
        End Sub
        Public Sub Set_Weight()
            Weight = Console.ReadLine
        End Sub
        Public Sub Get_Weight()
            Console.WriteLine(Weight)
        End Sub
        Public Sub Set_make()
            Make = Console.ReadLine
        End Sub
        Public Sub Get_make()
            Console.WriteLine(Make)
        End Sub
        Public Sub Set_Processor()
            Processor = Console.ReadLine
        End Sub
        Public Sub Get_Processor()
            Console.WriteLine(Processor)
        End Sub
        Public Sub Set_RAM_Size()
            RAM_Size = Console.ReadLine
        End Sub
        Public Sub Get_RAM_Size()
            Console.WriteLine(RAM_Size)
        End Sub
        Public Sub Set_Storage_Size()
            Storage_Size = Console.ReadLine
        End Sub
        Public Sub Get_Storage_Size()
            Console.WriteLine(Storage_Size)
        End Sub
    End Class
    Class Mobile_Phone
        Inherits Computer
        Private Camera As Boolean
        Private G3 As Boolean
        Private G4 As Boolean
        Private Network As String
        Public Sub Testphone()
            testcomputer()
            Camera = phoneinfo(8)
            G3 = phoneinfo(9)
            G4 = phoneinfo(10)
            Network = phoneinfo(11)
        End Sub
        Public Sub NewPhone()
            NewComputer()
            Set_Camera()
            Set_G3()
            Set_G4()
            Set_Network()
        End Sub
        Public Sub Set_Camera()
            Camera = Console.ReadLine()
        End Sub
        Public Sub Get_Camera()
            Console.WriteLine(Camera)
        End Sub
        Public Sub Set_G3()
            G3 = Console.ReadLine()
        End Sub
        Public Sub Get_G3()
            Console.WriteLine(G3)
        End Sub
        Public Sub Set_G4()
            G4 = Console.ReadLine()
        End Sub
        Public Sub Get_G4()
            Console.WriteLine(G4)
        End Sub
        Public Sub Set_Network()
            Network = Console.ReadLine()
        End Sub
        Public Sub Get_Network()
            Console.WriteLine(Network)
        End Sub
    End Class
    Class Laptop
        Inherits Computer
        Private Touch_Screen As Boolean
        Private Removable_Screen As Boolean
        Private Tablet_Mode As Boolean
        Private USB_Ports As Integer
        Public Sub Newlaptop()
            NewComputer()
            Set_Touch_Screen()
            Set_Removable_Screen()
            Set_Tablet_Mode()
            Set_USB_Ports()
        End Sub
        Public Sub Set_Touch_Screen()
            Touch_Screen = Console.ReadLine
        End Sub
        Public Sub Get_Touch_Screen()
            Console.WriteLine(Touch_Screen)
        End Sub
        Public Sub Set_Removable_Screen()
            Removable_Screen = Console.ReadLine
        End Sub
        Public Sub Get_Removable_Screen()
            Console.WriteLine(Removable_Screen)
        End Sub
        Public Sub Set_Tablet_Mode()
            Tablet_Mode = Console.ReadLine
        End Sub
        Public Sub Get_Tablet_Mode()
            Console.WriteLine(Tablet_Mode)
        End Sub
        Public Sub Set_USB_Ports()
            Do
                USB_Ports = Console.ReadLine
                If USB_Ports < 0 Or USB_Ports > 6 Then
                    Console.WriteLine("sorry thats an invaild input")
                End If
            Loop Until USB_Ports > -1 And USB_Ports < 7
        End Sub
        Public Sub Get_USB_Ports()
            Console.WriteLine(USB_Ports)
        End Sub
    End Class
    Dim phoneinfo() As String = {"mb1", 6.2, 10.8, 0.3, "camphones", "CIE234", "2GB", "64GB", True, True, True, "Camnetwork"}
    Sub Main()
        Dim x As Integer
        Dim ans As Integer
        For x = 0 To 11
            computers(0, x) = phoneinfo(x)
        Next
        Dim phone As New Mobile_Phone
        Dim input
        phone.Testphone()
        Console.WriteLine("what are you looking for?")
        input = Console.ReadLine()
        ans = findarray(input)
        If ans = -1 Then
            Console.WriteLine("not found")
        Else
            For x = 0 To 11
                Console.WriteLine(computers(ans, x))
            Next
        End If
        Console.ReadLine()
    End Sub
End Module
