Imports System
'1.6. Crear un proyecto y un módulo llamado “suma_promedio” que calcule la sumatoria y la media
'de cuatro números enteros ingresados por teclado.
Module suma_promedio
    Sub Main(args As String())
        Dim valorA As Integer
        Dim valorB As Integer
        Dim valorC As Integer
        Dim valorD As Integer
        Dim sumatoria As Integer
        Dim media As Single
        Console.WriteLine("Ingrese un valor entero para A :")
        valorA = Console.ReadLine
        Console.WriteLine("Ingrese un valor entero para B :")
        valorB = Console.ReadLine
        Console.WriteLine("Ingrese un valor entero para C :")
        valorC = Console.ReadLine
        Console.WriteLine("Ingrese un valor entero para D :")
        valorD = Console.ReadLine
        sumatoria = valorA + valorB + valorC + valorD
        media = sumatoria / 4
        Console.WriteLine("La Sumatoria de los valores es de : {0}" & vbLf & "La media es de : {1}", sumatoria, media)
    End Sub
End Module
