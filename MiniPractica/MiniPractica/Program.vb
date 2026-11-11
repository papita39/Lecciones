Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Digitar nota")
        Dim nota As Integer = Integer.Parse(Console.ReadLine)
        If nota >= 70 Then
            Console.WriteLine("No ta quemao")
        Else
            Console.WriteLine("Ta Quemao")
        End If
        Console.ReadKey()
    End Sub
End Module