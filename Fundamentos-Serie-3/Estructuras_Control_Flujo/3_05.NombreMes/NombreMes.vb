Imports System
'3.5. Crear un proyecto y un módulo “NombreMes” para resolver con CASE. Crear una
'enumeración para los meses del año. Ingresar un valor numérico y mostrar a que mes
'corresponde.Si el valor es inválido mostrar el mensaje correspondiente.
Module NombreMes
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
        Console.WriteLine("El mes es : " & mostrarMeses(mes))
    End Sub
    Function mostrarMeses(mes As meses) As String
        Select Case mes
            Case meses.Enero
                Return meses.Enero.ToString
            Case meses.Febrero
                Return meses.Febrero.ToString
            Case meses.Marzo
                Return meses.Marzo.ToString
            Case meses.Abril
                Return meses.Abril.ToString
            Case meses.Mayo
                Return meses.Mayo.ToString
            Case meses.Junio
                Return meses.Junio.ToString
            Case meses.Julio
                Return meses.Julio.ToString
            Case meses.Agosto
                Return meses.Agosto.ToString
            Case meses.Septiembre
                Return meses.Septiembre.ToString
            Case meses.Octubre
                Return meses.Octubre.ToString
            Case meses.Noviembre
                Return meses.Noviembre.ToString
            Case meses.Diciembre
                Return meses.Diciembre.ToString
            Case Else
                Return "Error de mes ingresado"
        End Select
    End Function
End Module
