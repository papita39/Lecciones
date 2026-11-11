Imports System
Imports System.ComponentModel

Module LaboratorioApp
    Sub Main(args As String())
        Dim ComponentesLab As New List(Of String)()
        ComponentesLab.Add("Microscopio")
        ComponentesLab.Add("Centrifuga")
        ComponentesLab.Add("Espectrofotometro")
        'Se quita un componente de la lista
        ComponentesLab.Remove("Centrifuga")
        'Se muestra en la pantalla la cantidad de componentes en la lista
        Console.WriteLine("Cantidad de componentes en el laboratorio: " & ComponentesLab.Count)
        Console.WriteLine("Componentes del laboratorio:")
        For Each componente As String In ComponentesLab
            Console.WriteLine("- " & componente)
        Next

        Console.WriteLine(Environment.NewLine & "Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module