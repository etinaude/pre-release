Module task3
    Structure boat
        Dim boat_name As String
        Dim Manufacturer As String
        Dim boat_type As String
    End Structure
    Sub Main()
        Dim floaty(6) As boat
        floaty(0).boat_name = "boaty_mc_boatface"
        floaty(1).boat_name = "carnival_spirit"
        floaty(2).boat_name = "titanic"
        floaty(3).boat_name = "tarere"
        Console.WriteLine("new boat?")
        floaty(4).boat_name = Console.ReadLine()
        Console.WriteLine("manufacturer?")
        floaty(4).Manufacturer = Console.ReadLine()
        Console.WriteLine("type?")
        floaty(4).boat_type = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("what boat you lookin' for?")
        Dim input As String = Console.ReadLine()
        Dim found As Boolean
        Console.Clear()
        For x = 0 To floaty.Length() - 1
            If input = floaty(x).boat_name Then
                found = True
                Console.WriteLine(floaty(x).boat_name)
                Console.WriteLine(floaty(x).Manufacturer)
                Console.WriteLine(floaty(x).boat_type)
                Exit For
            End If
        Next
        If found = False Then
            Console.WriteLine("not found")
        End If
        Console.ReadLine()
    End Sub
End Module
