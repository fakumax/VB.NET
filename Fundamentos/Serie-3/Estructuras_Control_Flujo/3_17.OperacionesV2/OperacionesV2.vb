Imports System
'3.17. En base al ejercicio anterior: agregar una subrutina sobrecargada para mostrar por
'consola las operaciones realizadas. Esta subrutina se invoca desde el método main y ella
'invoca las funciones de cálculo. Ej.: resultado(operaciones.suma, 5, 8)
'imprimiría en consola 5 + 8 = 13.
Module OperacionesV2
    Enum operadores
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum
    Sub Main(args As String())
        Console.Write("Sumar con 2 parametros : ")
        resultado(operadores.suma, 5, 6)
        Console.Write("Sumar con 3 parametros : ")
        resultado(operadores.suma, 5, 6, 6)
        Console.Write("Sumar con 4 parametros : ")
        resultado(operadores.suma, 5, 6, 6, 6)
        Console.Write("Multiplicar con 2 parametros : ")
        resultado(operadores.multiplicacion, 5, 6)
        Console.Write("Multiplicar con 3 parametros : ")
        resultado(operadores.multiplicacion, 5, 6, 6)
        Console.Write("Multiplicar con 4 parametros : ")
        resultado(operadores.multiplicacion, 5, 6, 6, 6)
        Console.Write("Resta con 2 parametros : ")
        resultado(operadores.resta, 5, 6)
        Console.Write("Resta con 3 parametros : ")
        resultado(operadores.resta, 5, 6, 6)
        Console.Write("Resta con 4 parametros : ")
        resultado(operadores.resta, 5, 6, 6, 6)
        Console.Write("Dividir con 2 parametros : ")
        resultado(operadores.division, 5, 6)
        Console.Write("Dividir con 3 parametros : ")
        resultado(operadores.division, 5, 6, 6)
        Console.Write("Dividir con 4 parametros : ")
        resultado(operadores.division, 5, 6, 6, 6)
        Console.WriteLine("Predeterminada : " & calcula(5, 6))
    End Sub
    Sub resultado(operador As operadores, valor1 As Single, valor2 As Single)
        Console.WriteLine("{0}{1}{2} = {3}", valor1, operadorSigno(operador), valor2, calcula(operador, valor1, valor2))
    End Sub
    Sub resultado(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single)
        Console.WriteLine("{0}{1}{2}{3}{4} = {5}", valor1, operadorSigno(operador), valor2, operadorSigno(operador), valor3, calcula(operador, valor1, valor2, valor3))
    End Sub
    Sub resultado(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single)
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6} = {7}", valor1, operadorSigno(operador), valor2, operadorSigno(operador), valor3, operadorSigno(operador), valor4, calcula(operador, valor1, valor2, valor3, valor4))
    End Sub
    Function operadorSigno(operador As operadores) As String
        Select Case operador
            Case operadores.suma
                Return "+"
            Case operadores.resta
                Return "-"
            Case operadores.multiplicacion
                Return "*"
            Case operadores.division
                Return "/"
            Case Else
                Return "Error"
        End Select
    End Function
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single) As Single
        Select Case operador
            Case operadores.suma
                Return valor1 + valor2
            Case operadores.resta
                Return valor1 - valor2
            Case operadores.multiplicacion
                Return valor1 * valor2
            Case operadores.division
                Return valor1 / valor2
            Case Else
                Return "Un error ha ocurrido."
        End Select
    End Function
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return calcula(operador, calcula(operador, valor1, valor2), valor3)
    End Function
    Function calcula(operador As operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return calcula(operador, calcula(operador, valor1, valor2, valor3), valor4)
    End Function
    Function calcula(valor1 As Single, valor2 As Single) As Single
        Return valor1 + valor2
    End Function
End Module
