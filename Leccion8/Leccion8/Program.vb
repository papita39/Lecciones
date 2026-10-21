Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Ingresa el voltaje: ")
        Dim voltaje As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("El voltaje ingresado es: " & voltaje & " V")
    End Sub
End Module
