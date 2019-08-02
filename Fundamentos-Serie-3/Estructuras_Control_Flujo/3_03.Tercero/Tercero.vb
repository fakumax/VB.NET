Imports System
'3.3. Crear un proyecto y un módulo “Tercero” para resolver con IF ingresar 5 valores enteros e
'informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.
Module Tercero
    Sub Main(args As String())
        Dim posicion As Integer = 1
        Dim valorMayor As Integer
        Dim valor1 As Integer = datoIngresado()
        Dim valor2 As Integer = datoIngresado()
        valorMayor = mayor(valor1, valor2, posicion)
        Dim valor3 As Integer = datoIngresado()
        valorMayor = mayor(valorMayor, valor3, posicion)
        Dim valor4 As Integer = datoIngresado()
        valorMayor = mayor(valorMayor, valor4, posicion)
        Dim valor5 As Integer = datoIngresado()
        valorMayor = mayor(valorMayor, valor5, posicion)
        Console.WriteLine("El número mas grande es '{0}' en la posición '{1}'", valorMayor, posicion)
    End Sub
    Function datoIngresado() As Integer
        Console.WriteLine("Ingrese un valor :")
        Return Console.ReadLine
    End Function
    Function mayor(valor1 As Integer, valor2 As Integer, ByRef posicion As Integer) As Integer
        If valor1 > valor2 Then
            Return valor1
        Else
            posicion += 1
            Return valor2
        End If
    End Function
End Module
