Imports System

Module Program
    Sub Main(args As String())

        Console.Write("¿Cómo te llamas?: ")
        Dim nombre As String = Console.ReadLine()

        Console.Write("¿Cuál es tu apellido?: ")
        Dim apellido As String = Console.ReadLine()

        Console.Write("¿Cuántos años tienes?: ")
        Dim edad As String = Console.ReadLine()

        Console.Write("¿Cuál es tu fecha de nacimiento?: ")
        Dim fechaNacimiento As String = Console.ReadLine()

        Console.Write("¿En qué taller estás?: ")
        Dim taller As String = Console.ReadLine()

        Console.Write("¿Cuál es la asignatura?: ")
        Dim asignatura As String = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine($"Un placer, {nombre} {apellido}.")
        Console.WriteLine($"Tienes {edad} años y naciste el {fechaNacimiento}.")
        Console.WriteLine($"Perteneces al taller de {taller} y estás en la asignatura de {asignatura}.")

        Console.ReadKey()
    End Sub
End Module