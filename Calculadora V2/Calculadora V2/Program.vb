Module Program
    Sub Main()
        Dim opcion As String
        Dim n1 As Double
        Dim n2 As Double
        'este es el menu de la calculadora
        Do
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
            opcion = Console.ReadLine()

            'este es el codigo que termina el programa si el usuario digita la opcion 10
            If opcion = "10" Then
                Exit Do
            End If

            'Opciones que piden DOS numeros (Sumar, Restar, Dividir, Multiplicar, Potencia)
            If opcion = "1" Or opcion = "2" Or opcion = "3" Or opcion = "4" Or opcion = "5" Then
                Console.Write("Digite el primer numero: ")
                n1 = CDbl(Console.ReadLine())
                Console.Write("Digite el segundo numero: ")
                n2 = CDbl(Console.ReadLine())

                If opcion = "1" Then
                    Console.WriteLine("Resultado: " & (n1 + n2))
                ElseIf opcion = "2" Then
                    Console.WriteLine("Resultado: " & (n1 - n2))
                ElseIf opcion = "3" Then
                    If n2 = 0 Then
                        Console.WriteLine("No se puede dividir entre cero")
                    Else
                        Console.WriteLine("Resultado: " & (n1 / n2))
                    End If
                ElseIf opcion = "4" Then
                    Console.WriteLine("Resultado: " & (n1 * n2))
                ElseIf opcion = "5" Then

                    Dim potencia As Double = 1
                    Dim i As Integer
                    For i = 1 To CInt(n2)
                        potencia = potencia * n1
                    Next
                    Console.WriteLine("Resultado: " & potencia)
                End If

                'Opciones que piden un numero (Raiz, Binario, Hexadecimal, Octal)
            ElseIf opcion = "6" Or opcion = "7" Or opcion = "8" Or opcion = "9" Then
                Console.Write("Digite el numero: ")
                n1 = CDbl(Console.ReadLine())

                If opcion = "6" Then
                    If n1 < 0 Then
                        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo")
                    Else

                        Dim raiz As Double = n1 / 2
                        If n1 = 0 Then
                            raiz = 0
                        Else
                            For i As Integer = 1 To 20
                                raiz = (raiz + (n1 / raiz)) / 2
                            Next
                        End If
                        Console.WriteLine("Resultado: " & raiz)
                    End If
                ElseIf opcion = "7" Then
                    Console.WriteLine("Resultado en Binario: " & Convert.ToString(CInt(n1), 2))
                ElseIf opcion = "8" Then
                    Console.WriteLine("Resultado en Hexadecimal: " & Convert.ToString(CInt(n1), 16).ToUpper())
                ElseIf opcion = "9" Then
                    Console.WriteLine("Resultado en Octal: " & Convert.ToString(CInt(n1), 8))
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
End Module