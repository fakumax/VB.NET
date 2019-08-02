Imports System
Imports System.Math
'3.18. Utilizar una función para validar los valores ingresados en el punto 2.3 sean enteros
'positivos, si no cumple esta condición pedir el reingreso del dato.
Module HipotenusaV2
    Sub Main(args As String())
        Console.WriteLine("El resultado 'C' es : " & hipotenusa())
    End Sub
    Function hipotenusa() As Double
        Dim a, b As Double
        Do
            If a < 0 Or b < 0 Then
                Console.WriteLine("Reingrese el número, debe ser positivo.")
            End If
            Console.Write("Ingrese lado 'A' : ")
            a = Console.ReadLine
            Console.Write("Ingrese lado 'B' : ")
            b = Console.ReadLine
        Loop Until a > 0 And b > 0
        Return Sqrt((a ^ 2) + (b ^ 2))
    End Function
End Module
