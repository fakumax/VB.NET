Imports System
'1.7. Crear un proyecto llamado “EquivalenciasPies”. Se debe ingresar una distancia medidas en
'pies y calcular su equivalente en pulgadas, yarda, cms y metros. Utilizar únicamente las
'equivalencias conocidas :  1 pie = 12 pulgadas, 1 yarda = 3 pies, 1 pulgada = 2.54 cm, 1 metro
'= 100 cm.
Module EquivalenciasPies
    Sub Main(args As String())
        Dim datos As Integer = ingresoDatos()
        Console.WriteLine(equivalencias(datos))
    End Sub

    Function ingresoDatos() As UInt32
        Console.Write("Ingrese un valor en pies : ")
        Return Console.ReadLine()
    End Function

    Function equivalencias(datos As Integer) As String
        Dim opcion As Byte
        Console.WriteLine("Ingrese el valor a convertir")
        Console.WriteLine("1 - Pulgada")
        Console.WriteLine("2 - Yarda")
        Console.WriteLine("3 - Centimetros ")
        Console.WriteLine("4 - Metro ")
        Console.Write("Seleccione una opción : ")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                Return "Pulgadas : " & datos * 12
            Case 2
                Return "Yarda : " & datos / 3
            Case 3
                Return "Centimetros : " & datos * 12 * 2.54
            Case 4
                Return "Metro : " & (datos * 12 * 2.54) / 100
            Case Else
                Return "Error en la elección"
        End Select
    End Function
End Module
