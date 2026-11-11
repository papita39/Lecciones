Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("========================================")
        Console.WriteLine("          SELECCIONE UN MODO            ")
        Console.WriteLine("========================================")
        Console.WriteLine("  [1] Medir Voltaje")
        Console.WriteLine("  [2] Medir Corriente CD")
        Console.WriteLine("  [3] Medir Corriente CA")
        Console.WriteLine("  [4] Medir Resistencia")
        Console.WriteLine("  [5] Probar continuidad")
        Console.WriteLine("  [6] Probar diodos")
        Console.WriteLine("  [7] Probar capacitores")
        Console.WriteLine("  [8] Medir frecuencia")
        Console.WriteLine("  [9] Salir")
        Console.WriteLine("----------------------------------------")
        Console.Write("Ingrese una opción (1-9): ")
        Console.Write("Opción (1 a 9): ")

        Dim op As Integer = Integer.Parse(Console.ReadLine())
        Select Case op
            Case 1
                Console.WriteLine("Medir voltaje")
            Case 2
                Console.WriteLine("Medir corriente CD")
            Case 3
                Console.WriteLine("Medir corriente CA")
            Case 4
                Console.WriteLine("Medir Resistencias")
            Case 5
                Console.WriteLine("Probar Continuidad")
            Case 6
                Console.WriteLine("Probar diodo")
            Case 7
                Console.WriteLine("Probar capacitores")
            Case 8
                Console.WriteLine("Medir frecuencia")
            Case 9
                Console.WriteLine("Salir")
            Case Else
                Console.WriteLine(" ._. Opción no válida. Por favor, elija un número del 1 al 9.")

        End Select


    End Sub
End Module