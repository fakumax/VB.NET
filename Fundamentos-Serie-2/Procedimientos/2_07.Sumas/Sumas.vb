Imports System
'2.7. Crear un proyecto y un módulo llamado “Sumas” que implementa una función sobrecargada
'capaz de sumar dos, tres y cuatro valores de acuerdo al número de argumentos que recibe.
'Invocarla desde el módulo main probando las diferentes alternativas y mostrando los
'resultados por consola. Ej.: sumar(5, 8).Minimizar la repetición de código.
Module Sumas
    Sub Main(args As String())
        Console.WriteLine("El resultado es : " & sumas(3, 4))
        Console.WriteLine("El resultado es : " & sumas(3, 4, 5))
        Console.WriteLine("El resultado es : " & sumas(3, 4, 9, 8))
    End Sub

    Function sumas(num1 As Integer, num2 As Integer) As Integer
        Return num1 + num2
    End Function
    Function sumas(num1 As Integer, num2 As Integer, num3 As Integer) As Integer
        Return num1 + num2 + num3
    End Function

    Function sumas(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer)
        Return num1 + num2 + num3 + num4
    End Function

End Module
