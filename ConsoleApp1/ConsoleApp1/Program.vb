Module Program
    Sub Main()
        Dim voltaje1 As Double = Ohm(2.0, 10.0)
        Dim voltaje2 As Double = Ohm(1.5, 100.0)
        Dim voltaje3 As Double = Ohm(0.5, 470.0)

        Console.WriteLine("Resultado 1: " & voltaje1 & " V")
        Console.WriteLine("Resultado 2: " & voltaje2 & " V")
        Console.WriteLine("Resultado 3: " & voltaje3 & " V")

        Console.ReadKey()
    End Sub

    Function Ohm(i As Double, r As Double) As Double
        Return i * r
    End Function
End Module