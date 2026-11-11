Module Program
    Sub Main()
        Dim i As Integer
        Dim opcion As Integer
        Dim n1 As Double
        Dim n2 As Double

        For i = 1 To 1000
            Console.Clear()
            Console.WriteLine("CALCULADORA BASICA")
            Console.WriteLine("1.- Sumar")
            Console.WriteLine("2.- Restar")
            Console.WriteLine("3.- Dividir")
            Console.WriteLine("4.- Multiplicar")
            Console.WriteLine("5.- Salir")
            Console.Write("Digite una opcion: ")
            opcion = Console.ReadLine()

            If opcion = 5 Then
                Exit For
            End If

            If opcion >= 1 And opcion <= 4 Then
                Console.Write("Digite el primer numero: ")
                n1 = Console.ReadLine()
                Console.Write("Digite el segundo numero: ")
                n2 = Console.ReadLine()

                If opcion = 1 Then
                    Console.WriteLine("Resultado: " & (n1 + n2))
                ElseIf opcion = 2 Then
                    Console.WriteLine("Resultado: " & (n1 - n2))
                ElseIf opcion = 3 Then
                    If n2 = 0 Then
                        Console.WriteLine("No se puede dividir entre cero")
                    Else
                        Console.WriteLine("Resultado: " & (n1 / n2))
                    End If
                Else
                    Console.WriteLine("Resultado: " & (n1 * n2))
                End If
            Else
                Console.WriteLine("Opcion no valida")
            End If

            Console.WriteLine("Presione una tecla para continuar...")
            Console.ReadKey()
        Next

        Console.WriteLine("Hasta luego")
        Console.ReadKey()
    End Sub
End Module