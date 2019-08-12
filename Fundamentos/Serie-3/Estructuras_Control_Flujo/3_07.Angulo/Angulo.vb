Imports System
'3.7. Crear un proyecto y un módulo “Angulo” para resolver con CASE: ingresar el tamaño de un
'ángulo en grados e imprimir el mensaje correspondiente según la siguiente tabla:
'Agudo si es menor a 90°
'Recto si es igual a 90°
'Obtuso si es mayor que 90° pero menor que 180°
'Llano si es igual a 180°
'Cóncavo si es mayor que 180° pero menor que 360°
'Error Si el valor es menor a 0º o mayor de 360º
Module Angulo
    Sub Main(args As String())
        Dim valor As UShort
        Console.WriteLine("Ingrese el Angulo : ")
        valor = Console.ReadLine
        Console.WriteLine(tamanioAngulo(valor))
    End Sub
    Function tamanioAngulo(valor As UShort) As String
        Select Case valor
            Case 1 To 89
                Return "Ángulo Agudo"
            Case 90
                Return "Ángulo Recto"
            Case <= 179
                Return "Ángulo Obtuso"
            Case 180
                Return "Ángulo Llano"
            Case <= 359
                Return "Ángulo Cóncavo"
            Case 360
                Return "Ángulo Completo"
            Case Else
                Return "Error"
        End Select
    End Function
End Module
