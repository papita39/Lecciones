Imports System

Module Program
    Sub Main(args As String())
        Dim nota As Integer
        Console.Write("Nota (0 a 100): ")
        nota = Integer.Parse(Console.ReadLine())

        If nota >= 90 Then
            Console.WriteLine("Letra A")
        ElseIf nota >= 80 Then
            Console.WriteLine("Letra B")
        ElseIf nota >= 70 Then
            Console.WriteLine("Letra C")
        ElseIf nota >= 60 Then
            Console.WriteLine("Letra D")
        Else
            Console.WriteLine("Letra F")
        End If
    End Sub
End Module
