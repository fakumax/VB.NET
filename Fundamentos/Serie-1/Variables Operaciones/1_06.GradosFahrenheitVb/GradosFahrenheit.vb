Imports System
'1.6. Crea un proyecto llamado “GradosFahrenheit” donde se ingresa la temperatura en Celsius y
'se muestra su equivalente en fahrenheit. Investigar la fórmula necesaria para realizar el
'cálculo.
Module GradosFahrenheit
    Sub Main(args As String())
        Dim celsius As UInt32 = celsiusAdd()
        Console.WriteLine("El resultado de {0}° Celsius a Fahrenheit es : {1}", celsius, celsiusConvertidor(celsius))
    End Sub

    Function celsiusAdd() As UInt32
        Console.Write("Ingrese un valor en celsius : ")
        Return Console.ReadLine()
    End Function

    Function celsiusConvertidor(celsius As UInt32) As Single
        Return (celsius * 1.8) + 32
    End Function

End Module
