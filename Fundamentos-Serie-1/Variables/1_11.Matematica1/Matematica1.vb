Imports System
Imports System.Math
'1.11. Crear un proyecto y un módulo llamado “Matematica1” para ingresar un número por
'teclado y mostrar:
'* su valor absoluto,
'* el resultado de elevarlo a la décima potencia
'* raíz cuadrada.
Module Matematica1
    Sub Main(args As String())
        Dim valor As Decimal
        Console.Write("Ingrese un número por teclado : ")
        valor = Console.ReadLine
        Console.WriteLine("El valor absoluto es de : " & Abs(valor))
        Console.WriteLine("valor ^ 10 : " & Pow(valor, 10))
        Console.WriteLine("La Raíz cuadrada es : " & Sqrt(valor))
    End Sub
End Module
