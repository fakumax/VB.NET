Imports System
'3.13. Crear un proyecto y un módulo “Primos” para obtener los números primos menores a
'mil.En matemáticas, un número primo es un número natural mayor que 1 que tiene
'únicamente dos divisores distintos: él mismo y el 1.
Module Primos
    Sub Main(args As String())
        Console.WriteLine("Los Numeroros Primos son : " & vbNewLine)
        numerosPrimos(1000)
    End Sub
    Sub numerosPrimos(maxNumero As UInt32)
        Dim primos As Integer
        For x As Integer = 2 To maxNumero
            For n = 1 To x
                If x Mod n = 0 Then
                    primos += 1
                End If
            Next
            If primos = 2 Then
                Console.Write(x & ",")
            End If
            primos = 0
        Next
    End Sub

End Module
