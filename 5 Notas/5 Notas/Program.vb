Imports System

Module Program
    Sub Main(args As String())
        'Bucle para ingresar 5 notas y calcular el promedio
        Dim Notas(5) As Double
        Dim Suma As Double = 0
        Dim Promedio As Double
        'Codigo base
        For i As Integer = 0 To 4
            Console.WriteLine("Ingrese la nota " & (i + 1) & ":")
            Notas(i) = Convert.ToDouble(Console.ReadLine())
            Suma += Notas(i)
        Next
        Promedio = Suma / 5
        Console.WriteLine("El promedio es: " & Promedio)
    End Sub
End Module