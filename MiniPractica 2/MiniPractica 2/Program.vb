Imports System

Module Program
    Sub Main(args As String())
        Dim Nota(4) As Integer
        Nota(0) = 60
        Nota(1) = 60
        Nota(2) = 60
        Nota(3) = 60
        Nota(4) = 70

        Dim nombres(4) As String
        nombres(0) = "Angelo"
        nombres(1) = "Dearwin"
        nombres(2) = "Yagency"
        nombres(3) = "Brailin"
        nombres(4) = "Derek"

        For i As Integer = 0 To 4
            Console.WriteLine(nombres(i) & " tiene una nota de: " & Nota(i))
        Next
    End Sub
End Module
