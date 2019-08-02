Imports System
'3.10. Crear un proyecto y un módulo “MultiplosCinco” para resolver con For y Do Loop:
'con ingresar dos valores numéricos enteros cualquiera, el primero menor al segundo,
'calcular cuántos números múltiplos de cinco hay entre ellos e informar. Repetir esta solución
'en el mismo módulo con las diferentes alternativas las estructuras de repetición “do while …
'loop”, “do until … loop”, “do … loop while”, “do … loop until y “for”
Module MultiplosCinco
    Sub Main(args As String())
        Dim valor, valor2 As Integer
        Console.Write("Ingrese un número : ")
        valor = Console.ReadLine
        Console.Write("Ingrese un número mayor al primero : ")
        valor2 = Console.ReadLine
        Console.WriteLine("Resultado hecho en FOR :" & multiploFor(valor, valor2))
        Console.WriteLine("Resultado hecho en DO WHILE :" & multiploDoWhile(valor, valor2))
        Console.WriteLine("Resultado hecho en DO UNTIL :" & multiploDoUntil(valor, valor2))
        Console.WriteLine("Resultado hecho en DO LOOP WHILE :" & multiploDoLoopWhile(valor, valor2))
        Console.WriteLine("Resultado hecho en DO LOOP UNTIL :" & multiploDoLoopUntil(valor, valor2))
    End Sub
    Function multiploFor(valor As Integer, valor2 As Integer) As Integer
        Dim cantidadMultiplos As Integer
        For x = valor To valor2
            If x Mod 5 = 0 Then
                cantidadMultiplos += 1
            End If
        Next
        Return cantidadMultiplos
    End Function
    Function multiploDoWhile(valor As Integer, valor2 As Integer) As Integer
        Dim cantidadMultiplos As Integer
        Do While valor <= valor2
            If valor Mod 5 = 0 Then
                cantidadMultiplos += 1
                valor += 1
            Else
                valor += 1
            End If
        Loop
        Return cantidadMultiplos
    End Function
    Function multiploDoUntil(valor As Integer, valor2 As Integer) As Integer
        Dim cantidadMultiplos As Integer
        Do Until valor > valor2
            If valor Mod 5 = 0 Then
                cantidadMultiplos += 1
                valor += 1
            Else
                valor += 1
            End If
        Loop
        Return cantidadMultiplos
    End Function
    Function multiploDoLoopWhile(valor As Integer, valor2 As Integer) As Integer
        Dim cantidadMultiplos As Integer
        Do
            If valor Mod 5 = 0 Then
                cantidadMultiplos += 1
                valor += 1
            Else
                valor += 1
            End If
        Loop While valor <= valor2
        Return cantidadMultiplos
    End Function
    Function multiploDoLoopUntil(valor As Integer, valor2 As Integer) As Integer
        Dim cantidadMultiplos As Integer
        Do
            If valor Mod 5 = 0 Then
                cantidadMultiplos += 1
                valor += 1
            Else
                valor += 1
            End If
        Loop Until valor > valor2
        Return cantidadMultiplos
    End Function


End Module