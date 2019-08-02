Imports System
'3.2. Crear un proyecto y un módulo “Menor” para resolver con IF: ingresar tres valores y mostrar
'el menor.
Module Menor
    Sub Main(args As String())
        Dim valor1 As UShort = datoIngresado()
        Dim valor2 As UShort = datoIngresado()
        Dim valor3 As UShort = datoIngresado()
        Console.WriteLine(menor(valor1, valor2, valor3))
    End Sub
    Function menor(ByRef a As Integer , ByRef b As Integer, ByRef c As Integer) As String
        If (a < b) And (a < c) Then
            Return "El menor valor es " & a
        ElseIf (b < a) And (b < c) Then
            Return "El menor valor es " & b
        ElseIf a = b And b = c Then
            Return "Los valores son iguales " & a
        Else
            Return "El menor valor es el " & c
        End If
    End Function
    Function datoIngresado() As Integer
        Console.WriteLine("Ingrese un valor :")
        Return Console.ReadLine
    End Function
End Module
