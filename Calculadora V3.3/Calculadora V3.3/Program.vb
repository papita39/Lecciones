Module Program

    Sub Main()
        Dim opcion As String

        Do
            Console.Clear()
            MostrarMenu()
            Console.Write("Digite una opcion: ")
            opcion = Console.ReadLine()

            If opcion = "10" Then
                Exit Do
            End If

            ProcesarOpcion(opcion)

            Console.WriteLine()
            Console.WriteLine("Presione una tecla para continuar...")
            Console.ReadKey()
        Loop

        Console.Clear()
        Console.WriteLine("Hasta luego")
        Console.ReadKey()
    End Sub

    Sub MostrarMenu()
        Console.WriteLine("================================")
        Console.WriteLine("        CALCULADORA V3.3        ")
        Console.WriteLine("================================")
        Console.WriteLine("1.- Sumar")
        Console.WriteLine("2.- Restar")
        Console.WriteLine("3.- Dividir")
        Console.WriteLine("4.- Multiplicar")
        Console.WriteLine("5.- Potencia")
        Console.WriteLine("6.- Raiz Cuadrada")
        Console.WriteLine("7.- Convertir a Binario")
        Console.WriteLine("8.- Convertir a Hexadecimal")
        Console.WriteLine("9.- Convertir a Octal")
        Console.WriteLine("10.- Salir")
        Console.WriteLine("================================")
    End Sub

    Sub ProcesarOpcion(opc As String)
        Console.WriteLine()

        If opc >= "1" AndAlso opc <= "5" Then
            Dim n1 As Double = PedirNumero("Digite el primer numero: ")
            Dim n2 As Double = PedirNumero("Digite el segundo numero: ")

            If opc = "1" Then
                Console.WriteLine("Resultado: " & (n1 + n2))
            ElseIf opc = "2" Then
                Console.WriteLine("Resultado: " & (n1 - n2))
            ElseIf opc = "3" Then
                If n2 = 0 Then
                    Console.WriteLine("No se puede dividir entre cero")
                Else
                    Console.WriteLine("Resultado: " & (n1 / n2))
                End If
            ElseIf opc = "4" Then
                Console.WriteLine("Resultado: " & (n1 * n2))
            ElseIf opc = "5" Then
                Console.WriteLine("Resultado: " & Math.Pow(n1, n2))
            End If

        ElseIf opc >= "6" AndAlso opc <= "9" Then
            Dim n As Integer = CInt(PedirNumero("Digite el numero: "))

            If opc = "6" Then
                If n < 0 Then
                    Console.WriteLine("No se puede calcular la raiz de un numero negativo")
                Else
                    Console.WriteLine("Resultado: " & Math.Sqrt(n))
                End If
            ElseIf opc = "7" Then
                Console.WriteLine("Resultado en Binario: " & Convert.ToString(n, 2))
            ElseIf opc = "8" Then
                Console.WriteLine("Resultado en Hexadecimal: " & Convert.ToString(n, 16).ToUpper())
            ElseIf opc = "9" Then
                Console.WriteLine("Resultado en Octal: " & Convert.ToString(n, 8))
            End If

        Else
            Console.WriteLine("Opcion no valida")
        End If
    End Sub

    Function PedirNumero(mensaje As String) As Double
        Console.Write(mensaje)
        Return CDbl(Console.ReadLine())
    End Function

End Module