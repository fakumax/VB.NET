Imports System
'1.16. Crear un proyecto y un módulo llamado “Reloj” que muestre en líneas diferentes con sus
'correspondientes títulos los siguientes valores en el momento de la ejecución: día del año, mes,
'hora y minuto
Module Reloj
    Sub Main(args As String())
        Console.WriteLine("Día del año : " & DateTime.Now.Day())
        Console.WriteLine("Mes del año : " & DateTime.Now.Month())
        Console.WriteLine("Hora y minutos : " & DateTime.Now.ToShortTimeString)
    End Sub
End Module
