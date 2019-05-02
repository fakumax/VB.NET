Imports System
'1.18. Crear un proyecto y un módulo llamado “Nueva_fecha” que se ingrese una fecha y un
'número dados de días, Mostrar como resultado la fecha obtenida de sumar la cantidad de días a
'la fecha dada.
Module Nueva_fecha
    Sub Main(args As String())
        Dim fechaInicial As Date
        Dim diasAgregados As UShort
        Console.Write("Ingrese una fecha (AAAA-MM-DD) : ")
        fechaInicial = Console.ReadLine
        Console.Write("Ingrese cantidad dias a sumar : ")
        diasAgregados = Console.ReadLine
        Console.WriteLine("La fecha Inicial es : " & fechaInicial)
        Console.WriteLine("La fecha Final es : " & fechaInicial.AddDays(diasAgregados))
    End Sub
End Module
