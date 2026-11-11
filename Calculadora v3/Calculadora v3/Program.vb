Module Program
    Sub Main()
        Dim opcion As String
        Dim n1 As Double
        Dim n2 As Double

        Do
            MostrarMenu()
            opcion = Console.ReadLine()

            ' Código que termina el programa si el usuario digita la opción 10
            If opcion = "10" Then
                Exit Do
            End If

            ' Opciones que piden DOS números (Sumar, Restar, Dividir, Multiplicar, Potencia)
            If opcion = "1" Or opcion = "2" Or opcion = "3" Or opcion = "4" Or opcion = "5" Then
                Console.Write("Digite el primer numero: ")
                n1 = CDbl(Console.ReadLine())
                Console.Write("Digite el segundo numero: ")
                n2 = CDbl(Console.ReadLine())

                If opcion = "1" Then
                    Console.WriteLine("Resultado: " & Sumar(n1, n2))
                ElseIf opcion = "2" Then
                    Console.WriteLine("Resultado: " & Restar(n1, n2))
                ElseIf opcion = "3" Then
                    If n2 = 0 Then
                        Console.WriteLine("No se puede dividir entre cero")
                    Else
                        Console.WriteLine("Resultado: " & Dividir(n1, n2))
                    End If
                ElseIf opcion = "4" Then
                    Console.WriteLine("Resultado: " & Multiplicar(n1, n2))
                ElseIf opcion = "5" Then
                    Console.WriteLine("Resultado: " & CalcularPotencia(n1, n2))
                End If

                ' Opciones que piden UN número (Raíz, Binario, Hexadecimal, Octal)
            ElseIf opcion = "6" Or opcion = "7" Or opcion = "8" Or opcion = "9" Then
                Console.Write("Digite el numero: ")
                n1 = CDbl(Console.ReadLine())

                If opcion = "6" Then
                    If n1 < 0 Then
                        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo")
                    Else
                        Console.WriteLine("Resultado: " & CalcularRaizCuadrada(n1))
                    End If
                ElseIf opcion = "7" Then
                    Console.WriteLine("Resultado en Binario: " & ConvertirBinario(n1))
                ElseIf opcion = "8" Then
                    Console.WriteLine("Resultado en Hexadecimal: " & ConvertirHexadecimal(n1))
                ElseIf opcion = "9" Then
                    Console.WriteLine("Resultado en Octal: " & ConvertirOctal(n1))
                End If
            Else
                Console.WriteLine("Opcion no valida")
            End If

            Console.WriteLine("Presione una tecla para continuar...")
            Console.ReadKey()
        Loop

        Console.WriteLine("Hasta luego")
        Console.ReadKey()
    End Sub

    ' ==========================================
    ' PROCEDIMIENTOS (Sub)
    ' ==========================================

    Sub MostrarMenu()
        Console.Clear()
        Console.WriteLine("CALCULADORA BASICA Y AVANZADA")
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
        Console.Write("Digite una opcion: ")
    End Sub

    ' ==========================================
    ' FUNCIONES (Function)
    ' ==========================================

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
        For i As Integer = 1 To CInt(exponente)
            potencia = potencia * base
        Next
        Return potencia
    End Function

    Function CalcularRaizCuadrada(n As Double) As Double
        Dim raiz As Double = n / 2
        If n = 0 Then
            raiz = 0
        Else
            For i As Integer = 1 To 20
                raiz = (raiz + (n / raiz)) / 2
            Next
        End If
        Return raiz
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