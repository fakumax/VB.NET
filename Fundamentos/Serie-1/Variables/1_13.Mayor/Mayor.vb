Imports System
Imports System.Math
'1.13. Crear un proyecto y un módulo llamado “Mayor” que lea tres números y muestre el
'mayor.
Module Mayor
    Sub Main(args As String())
        Dim valorA As Integer
        Dim valorB As Integer
        Dim valorC As Integer
        Dim maximo As Integer
        Console.WriteLine("Ingrese un número : ")
        valorA = Console.ReadLine
        Console.WriteLine("Ingrese un número : ")
        valorB = Console.ReadLine
        Console.WriteLine("Ingrese un número : ")
        valorC = Console.ReadLine
        maximo = Max(valorA, valorB)
        maximo = Max(maximo, valorC)
        Console.WriteLine("El mayor es : " & maximo)
    End Sub
End Module
