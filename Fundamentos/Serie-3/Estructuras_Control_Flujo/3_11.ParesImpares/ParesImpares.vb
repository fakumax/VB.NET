Imports System
'3.11. Crear un proyecto y un módulo “ParesImpares” Utilizando la estructura de repetición
'más adecuada elaborar un programa que se ingresen valores enteros hasta que se ingrese
'cero(descartar negativos).Luego informar cuantos son pares y cuantos impares. Si todos son
'pares o todos son impares informar esta situación particular en lugar de la consigna anterior.
Module ParesImpares
    Sub Main(args As String())
        Dim valor, par, impar As UInteger
        Do
            Console.Write("Ingrese un número : ")
            valor = Console.ReadLine
            If valor = 0 Then
                Exit Do
            ElseIf valor > 0 Then
                parImpar(valor, par, impar)
            Else
                Console.WriteLine("Ingrese un valor positivo.")
            End If
        Loop While True
        If impar = 0 Then
            Console.WriteLine("Todos los numeros son pares.")
        ElseIf par = 0 Then
            Console.WriteLine("Todos los números son impares.")
        Else
            Console.WriteLine("Los pares son : " & par)
            Console.WriteLine("Los impares son : " & impar)
        End If
    End Sub
    Sub parImpar(valor As Integer, ByRef par As Integer, ByRef impar As Integer)
        If valor Mod 2 = 0 Then
            par += 1
        Else
            impar += 1
        End If
    End Sub
End Module
