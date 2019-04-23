Imports System
'1.7. Crear un proyecto y un módulo llamado semanas y en el declarar las siguientes constantes: días
'del año, días laborables y días de la semana. Informar cuantas semanas tiene el año y cuantas
'semanas son laborables.
Module semanas
    Sub Main(args As String())

        Const dAnio As UShort = 365
        Const dLaborales As Byte = 5
        Const dSemana As Byte = 7
        Dim semanasAnio As UShort = dAnio \ dSemana
        Console.WriteLine("El Año tiene {0} semanas", semanasAnio)
        Console.WriteLine("El Año tiene {0} semanas laborables", (semanasAnio * dLaborales) \ dSemana)
    End Sub
End Module
