Imports System
Imports System.Math
'3.19. Utilizar un procedimiento para validar los valores ingresados en el punto 2.4 sean
'positivos, si no cumple esta condición pedir el reingreso del dato.
Module VolumenCilindroV2
    Sub Main(args As String())
        Console.WriteLine("El resultado es  : " & devuelveVolumen())
    End Sub
    Function devuelveVolumen() As Decimal
        Dim radio, altura As Integer
        Do
            If radio < 0 Or altura < 0 Then
                Console.WriteLine("Reingrese el número, debe ser positivo.")
            End If
            Console.Write("Ingrese el radio : ")
            radio = Console.ReadLine
            Console.Write("Ingrese la altura : ")
            altura = Console.ReadLine
        Loop Until radio > 0 And altura > 0
        Return PI * radio ^ 2 * altura
    End Function
End Module
