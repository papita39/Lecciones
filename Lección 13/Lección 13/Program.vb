Module Program
    Sub Main()
        Dim opcion As Integer
        Dim n1 As Double
        Dim n2 As Double

        Do
            Console.WriteLine("MENU")
            Console.WriteLine("1.- Sumar")
            Console.WriteLine("2.- Restar")
            Console.WriteLine("3.- Salir")
            Console.Write("Digite una opcion: ")
            opcion = Console.ReadLine()

            If opcion = 1 Or opcion = 2 Then
                Console.Write("Digite el primer numero: ")
                n1 = Console.ReadLine()
                Console.Write("Digite el segundo numero: ")
                n2 = Console.ReadLine()

                If opcion = 1 Then
                    Console.WriteLine("Resultado: " & (n1 + n2))
                Else
                    Console.WriteLine("Resultado: " & (n1 - n2))
                End If
            ElseIf opcion <> 3 Then
                Console.WriteLine("Opcion no valida")
            End If

            Console.WriteLine()
        Loop Until opcion = 3

        Console.WriteLine("Hasta luego")
        Console.ReadKey()
    End Sub
End Module
