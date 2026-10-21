Module Program
    Sub Main(args As String())
        Console.WriteLine("--- Calculadora de Promedio de Notas ---")

        Console.Write("Ingresa la primera nota: ")
        Dim nota1 As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingresa la segunda nota: ")
        Dim nota2 As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingresa la tercera nota: ")
        Dim nota3 As Double = Double.Parse(Console.ReadLine())

        Dim promedio As Double = (nota1 + nota2 + nota3) / 3

        Console.WriteLine("El promedio es: " & promedio.ToString("F2"))
    End Sub
End Module
