Imports System
Imports System.DateTime
'2.1. Crear un proyecto y un módulo llamado “AhoraEs” que imprima la fecha y hora actual con
'sus respectivas leyendas según los siguientes requerimientos:
'• Utilizar una sub para imprimir la fecha actual.
'• Utilizar una function para obtener la hora actual.
'• Llamar a los procedimientos desde el Main.
Module AhoraEs
    Sub Main(args As String())
        fechaActual()
        Console.WriteLine("La hora es " & horaActual())
    End Sub
    Sub fechaActual()
        Console.WriteLine("La fecha es : " & Now.Date)
    End Sub

    Function horaActual() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
