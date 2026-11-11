Imports System

Module Program
    Sub Main(args As String())
        Dim Voltajes(4) As Integer
        Voltajes(0) = 0
        Voltajes(1) = 1
        Voltajes(2) = 2
        Voltajes(3) = 3
        Voltajes(4) = 4
        Console.WriteLine("El primer voltaje es " & Voltajes(0))
        Console.WriteLine("El último voltaje es " & Voltajes(4))
    End Sub
End Module