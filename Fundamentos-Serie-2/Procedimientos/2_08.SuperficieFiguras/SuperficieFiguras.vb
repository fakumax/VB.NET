Imports System
'2.8. Crear un proyecto y un módulo llamado “SuperficieFiguras” para calcular la superficie de
'una figura. Los valores se ingresan por consola Usar una función sobrecargada para resolver
'el área y según el número de parámetros será
Module SuperficieFiguras
    Sub Main(args As String())
        Dim lado, baseMayor, baseMenor As Integer
        Console.WriteLine("Ingrese el lado : ")
        lado = Console.ReadLine
        Console.WriteLine("Ingrese la Base Mayor: ")
        baseMayor = Console.ReadLine
        Console.WriteLine("Ingrese base menor: ")
        baseMenor = Console.ReadLine
        Console.WriteLine("La superficie del cuadrado es : " & superficie(lado))
        Console.WriteLine("La superficie del rectangulo es : " & superficie(lado, baseMayor))
        Console.WriteLine("La superficie del trapecio es : " & superficie(lado, baseMayor, baseMenor))
    End Sub
    Function superficie(lado As Integer) As Single
        Return lado * lado
    End Function
    Function superficie(altura As Integer, base As Integer) As Single
        Return base * altura
    End Function
    Function superficie(altura As Integer, baseMayor As Integer, baseMenor As Integer) As Single
        Return ((baseMayor + baseMenor) / 2) * altura
    End Function
End Module
