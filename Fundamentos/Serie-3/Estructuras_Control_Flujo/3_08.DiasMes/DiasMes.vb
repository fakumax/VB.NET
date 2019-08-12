Imports System
'3.8. Crear un proyecto y un módulo “DiasMes” para resolver con CASE: Elabore un programa
'que indique cuantos días tiene un mes respetando los siguientes requerimientos:
'• En el flujo normal se ingresa el número de mes a evaluar y mediante una enumeración
'se informa la cantidad de días que tiene el mes.
'• En el caso de ser febrero, además ingresar el año y tener en cuenta que tiene 28 días y si
'es un año bisiesto tiene 29 días. Un año bisiesto es aquél que es múltiplo de 4 y no de 100
'o cuando es múltiplo de 400. Por ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
Module DiasMes
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub Main(args As String())
        Dim mes As meses
        Console.Write("Ingrese un valor para mostrar el mes : ")
        mes = Console.ReadLine
        Console.WriteLine(mostrarMeses(mes))
    End Sub
    Function mostrarMeses(mes As meses) As String
        Select Case mes
            Case meses.Enero, meses.Marzo, meses.Mayo, meses.Julio, meses.Agosto, meses.Octubre, meses.Diciembre
                Return "El mes tiene 31 días"
            Case meses.Febrero
                Return febrero()
            Case meses.Abril, meses.Junio, meses.Septiembre, meses.Noviembre
                Return "El mes tiene 30 días"
            Case Else
                Return "Error de mes ingresado"
        End Select
    End Function
    Function febrero() As String
        Dim valor As UShort
        Console.Write("Ingrese el año 'AAAA' : ")
        valor = Console.ReadLine
        If valor Mod 4 = 0 And valor Mod 100 <> 0 Or valor Mod 400 = 0 Then
            Return "El mes tiene 29 días, es bisiesto"
        Else
            Return "El mes tiene 28 días"
        End If
    End Function
End Module
