Imports System
'1.7. Crear un proyecto y un módulo llamado “equivalencia_dias” y en el declarar las siguientes
'constantes: días por semana, horas por día y minutos por hora. Ingresar un numero cualquiera de
'días e informar que corresponde a número de semanas, número de horas y número de minutos.
Module equivalencia_dias
    Sub Main(args As String())
        Const diaSemana As Byte = 7
        Const horaDia As Byte = 24
        Const minutoHora As Byte = 60
        Dim dias As Integer
        Console.WriteLine("Ingrese un número de días")
        dias = Console.ReadLine
        Console.WriteLine("El número de 'Semanas' es : " & dias \ diaSemana)
        Console.WriteLine("El número de 'Horas' es : " & dias * horaDia)
        Console.WriteLine("El número de 'Minutos' es : " & dias * horaDia * minutoHora)
    End Sub
End Module
