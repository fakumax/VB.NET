Imports System
'1.7. Crear un proyecto y un m�dulo llamado semanas y en el declarar las siguientes constantes: d�as
'del a�o, d�as laborables y d�as de la semana. Informar cuantas semanas tiene el a�o y cuantas
'semanas son laborables.
Module semanas
    Sub Main(args As String())

        Const dAnio As UShort = 365
        Const dLaborales As Byte = 5
        Const dSemana As Byte = 7
        Dim semanasAnio As UShort = dAnio \ dSemana
        Console.WriteLine("El A�o tiene {0} semanas", semanasAnio)
        Console.WriteLine("El A�o tiene {0} semanas laborables", (semanasAnio * dLaborales) \ dSemana)
    End Sub
End Module
