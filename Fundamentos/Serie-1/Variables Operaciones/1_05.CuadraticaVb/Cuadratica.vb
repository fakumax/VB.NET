Imports System
'1.5. Crear un proyecto y un módulo llamado “Cuadratica” que resuelva la siguiente ecuación 
'x = ((b^2)-(4*a*c))/(2*a)
'donde a = 1, b = 5 y c=2. Mostrar el resultado obtenido.
Module Cuadratica
    Sub Main(args As String())
        Console.WriteLine("El resultado es : " & resuelveCuadratica(1, 5, 2))
    End Sub

    Function resuelveCuadratica(a As UInt32, b As UInt32, c As UInt32) As Single
        Return (b ^ 2 - 4 * a * c) / (2 * a)
    End Function
End Module
