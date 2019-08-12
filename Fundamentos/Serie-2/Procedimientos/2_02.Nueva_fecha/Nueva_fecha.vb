Imports System
Imports System.DateTime
'2.2. Crear un proyecto y un módulo llamado “Nueva_fecha” con una función que reciba un valor
'fecha y un valor entero que representa una cantidad de días y retorne a la fecha sumada la
'cantidad de días. En el módulo principal ingresar una fecha y la cantidad de días, invocar a la
'función creada y mostrar el valor obtenido.
Module Nueva_fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim cantidadDias As UShort
        Console.WriteLine("Ingrese una fecha :")
        fecha = Console.ReadLine
        Console.WriteLine("Ingrese una cantidad de dias :")
        cantidadDias = Console.ReadLine
        Console.WriteLine(recibeFecha(fecha, cantidadDias))
    End Sub

    Function recibeFecha(fecha As Date, cantidadDias As UShort) As String
        Return fecha.AddDays(cantidadDias)
    End Function
End Module
