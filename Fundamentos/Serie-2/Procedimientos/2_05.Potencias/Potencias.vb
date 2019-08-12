Imports System
'2.5. Crear un proyecto y un módulo llamado “Potencias” que implemente una función que
'retornará la primera vez que es invocada el valor al cuadrado, la siguiente vez el valor al
'cubo y así sucesivamente. Ingresar por teclado un valor numérico y mostrar ese valor
'elevado a la 2°, 3° y 5° potencias. Por ejemplo, ingresando 3 mostrar: 9, 27 y 243.
Module Potencias
    Sub Main(args As String())
        Dim valoringresado As Integer
        Console.WriteLine("Ingrese un valor")
        valoringresado = Console.ReadLine
        Console.WriteLine("El resultado es : " & retornaPotencia(valoringresado, 1))
        Console.WriteLine("El resultado es : " & retornaPotencia(valoringresado, 2))
        Console.WriteLine("El resultado es : " & retornaPotencia(valoringresado, 3))
        Console.WriteLine("El resultado es : " & retornaPotencia(valoringresado, 5))
    End Sub
    Function retornaPotencia(valoringresado As Integer, potencia As Integer) As Integer
        Return valoringresado ^ potencia
    End Function
End Module
