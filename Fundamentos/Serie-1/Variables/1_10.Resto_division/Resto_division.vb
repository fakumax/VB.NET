Imports System
'1.10. Crear un proyecto y un módulo llamado “Resto_division” para mostrar el resto de un
'valor entero ingresados por teclado divido por 2.
Module Resto_division
    Sub Main(args As String())
        Dim valorEntero As UInteger
        Console.Write("Ingrese un valor entero : ")
        valorEntero = Console.ReadLine
        Console.WriteLine("El resto divido por 2 es : " & valorEntero Mod 2)
    End Sub
End Module
