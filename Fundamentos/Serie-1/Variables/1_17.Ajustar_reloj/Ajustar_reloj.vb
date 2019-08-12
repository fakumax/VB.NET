Imports System
'1.17. Crear un proyecto y un módulo llamado “Ajustar_reloj” que lea separadamente un
'número de día (1 a 31) y una hora (0 a 24). Con esos valores crea una variable de tipo Date
'usando el mes y año actual y mostrarla.
Module Ajustar_reloj
    Sub Main(args As String())
        Dim numeroDia As Byte
        Dim hora As Byte
        Dim fechaCreada As Date
        Console.WriteLine("Ingrese un número de días (1-31) : ")
        numeroDia = Console.ReadLine
        Console.WriteLine("Ingrese una hora (0-24) : ")
        hora = Console.ReadLine
        fechaCreada = New DateTime(DateTime.Now.Year, DateTime.Now.Month, numeroDia, hora, DateTime.Now.Minute, DateTime.Now.Second)
        Console.WriteLine(fechaCreada)
    End Sub
End Module
