Imports System
'3.1. Crear un proyecto y un módulo “Comparar” para resolver con IF: se ingresan dos valores
'numéricos e informar por pantalla cuál es la relación entre ambos: mayor, menor o igual.

Module Comparar
    Sub Main(args As String())
        Dim valor1, valor2 As Integer
        Console.Write("Ingrese un valor : ")
        valor1 = Console.ReadLine
        Console.Write("Ingrese otro valor : ")
        valor2 = Console.ReadLine
        Console.WriteLine(comparaRelacion(valor1, valor2))
    End Sub
    Function comparaRelacion(valor1 As Integer, valor2 As Integer) As String
        If valor1 > valor2 Then
            Return "El primer valor ingresado es más grande"
        ElseIf valor1 < valor2 Then
            Return "El segundo valor ingresado es más grande"
        Else
            Return "Los valores son iguales"
        End If
    End Function
End Module
