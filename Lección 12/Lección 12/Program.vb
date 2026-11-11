Imports System

Module Module1
    Sub Main()
        Dim tabla As Integer = 7

        For i As Integer = 1 To 10
            Console.WriteLine(tabla & " x " & i & " = " & (tabla * i))
        Next

        Console.WriteLine("Fin de la tabla")

        Console.ReadLine()
    End Sub
End Module