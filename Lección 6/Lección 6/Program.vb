Imports System

Module Program
    Sub Main()
        Dim estadoLED As String = "Apagado"
        Console.WriteLine($"Antes del cambio: El LED está {estadoLED}")
        estadoLED = "Encendido"
        Console.WriteLine($"Después del cambio: El LED está {estadoLED}")
        Console.ReadKey()
    End Sub
End Module