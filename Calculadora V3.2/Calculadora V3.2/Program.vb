Module Program
    Sub Main()
        Dim opcion As String
        Dim n1 As Double
        Dim n2 As Double

        Do
            MostrarMenu()
            opcion = Console.ReadLine()

            ' Sistema anti-idiotas
            Dim opcionNum As Integer
            If Not Integer.TryParse(opcion, opcionNum) Then
                Console.WriteLine()
                Console.WriteLine("[Error] Entrada no valida. Por favor, digite un numero entero del 1 al 10.")
                Pausar()
                Continue Do
            End If

            If opcionNum = 10 Then
                Exit Do
            End If

            If opcionNum < 1 OrElse opcionNum > 9 Then
                Console.WriteLine()
                Console.WriteLine("[Error] Opcion fuera de rango. Digite un numero entre 1 y 10.")
                Pausar()
                Continue Do
            End If

            ' Opciones que piden DOS números
            If opcionNum >= 1 AndAlso opcionNum <= 5 Then
                n1 = LeerNumero("Digite el primer numero: ")
                n2 = LeerNumero("Digite el segundo numero: ")

                Select Case opcionNum
                    Case 1
                        Console.WriteLine("Resultado: " & Sumar(n1, n2))
                    Case 2
                        Console.WriteLine("Resultado: " & Restar(n1, n2))
                    Case 3
                        If n2 = 0 Then
                            Console.WriteLine("[Error] No se puede dividir entre cero.")
                        Else
                            Console.WriteLine("Resultado: " & Dividir(n1, n2))
                        End If
                    Case 4
                        Console.WriteLine("Resultado: " & Multiplicar(n1, n2))
                    Case 5
                        Console.WriteLine("Resultado: " & CalcularPotencia(n1, n2))
                End Select

                ' Opciones que piden UN número
            ElseIf opcionNum >= 6 AndAlso opcionNum <= 9 Then
                n1 = LeerNumero("Digite el numero: ")

                Select Case opcionNum
                    Case 6
                        If n1 < 0 Then
                            Console.WriteLine("[Error] No se puede calcular la raiz cuadrada de un numero negativo.")
                        Else
                            Console.WriteLine("Resultado: " & CalcularRaizCuadrada(n1))
                        End If
                    Case 7
                        Console.WriteLine("Resultado en Binario: " & ConvertirBinario(n1))
                    Case 8
                        Console.WriteLine("Resultado en Hexadecimal: " & ConvertirHexadecimal(n1))
                    Case 9
                        Console.WriteLine("Resultado en Octal: " & ConvertirOctal(n1))
                End Select
            End If

            Pausar()
        Loop

        Console.Clear()
        Console.WriteLine("¡Hasta luego!")
        Console.ReadKey()
    End Sub

    ' PROCEDIMIENTOS

    Sub MostrarMenu()
        Console.Clear()
        Console.WriteLine("========================================")
        Console.WriteLine("       CALCULADORA BASICA Y AVANZADA    ")
        Console.WriteLine("========================================")
        Console.WriteLine(" 1.- Sumar")
        Console.WriteLine(" 2.- Restar")
        Console.WriteLine(" 3.- Dividir")
        Console.WriteLine(" 4.- Multiplicar")
        Console.WriteLine(" 5.- Potencia")
        Console.WriteLine(" 6.- Raiz Cuadrada")
        Console.WriteLine(" 7.- Convertir a Binario")
        Console.WriteLine(" 8.- Convertir a Hexadecimal")
        Console.WriteLine(" 9.- Convertir a Octal")
        Console.WriteLine(" 10.- Salir")
        Console.WriteLine("========================================")
        Console.Write("Digite una opcion: ")
    End Sub

    Sub Pausar()
        Console.WriteLine()
        Console.WriteLine("Presione cualquier tecla para continuar...")
        Console.ReadKey()
    End Sub

    ' Función auxiliar anti-idiotas
    Function LeerNumero(mensaje As String) As Double
        Dim numero As Double
        Dim entrada As String

        Do
            Console.Write(mensaje)
            entrada = Console.ReadLine()
            If Double.TryParse(entrada, numero) Then
                Return numero
            End If
            Console.WriteLine("[Error] Valor no valido. Ingrese un numero correcto.")
        Loop
    End Function

    ' FUNCIONES

    Function Sumar(a As Double, b As Double) As Double
        Return a + b
    End Function

    Function Restar(a As Double, b As Double) As Double
        Return a - b
    End Function

    Function Dividir(a As Double, b As Double) As Double
        Return a / b
    End Function

    Function Multiplicar(a As Double, b As Double) As Double
        Return a * b
    End Function

    Function CalcularPotencia(base As Double, exponente As Double) As Double
        Dim potencia As Double = 1
        For i As Integer = 1 To CInt(Math.Abs(exponente))
            potencia = potencia * base
        Next
        If exponente < 0 Then Return 1 / potencia
        Return potencia
    End Function

    Function CalcularRaizCuadrada(n As Double) As Double
        Dim raiz As Double = n / 2
        If n = 0 Then
            Return 0
        Else
            For i As Integer = 1 To 20
                raiz = (raiz + (n / raiz)) / 2
            Next
            Return raiz
        End If
    End Function

    Function ConvertirBinario(n As Double) As String
        Return Convert.ToString(CInt(n), 2)
    End Function

    Function ConvertirHexadecimal(n As Double) As String
        Return Convert.ToString(CInt(n), 16).ToUpper()
    End Function

    Function ConvertirOctal(n As Double) As String
        Return Convert.ToString(CInt(n), 8)
    End Function

End Module