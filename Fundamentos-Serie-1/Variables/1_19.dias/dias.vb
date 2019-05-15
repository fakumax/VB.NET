Imports System
'1.19. Crear un proyecto y un módulo llamado “días” utilizando una enumeración para los días
'de la semana en español, mostrar que día que corresponde al resultado.}

Module dias
    Enum semanaDias
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
        Domingo
    End Enum
    Sub Main(args As String())
        Console.WriteLine("{0} - valor: {1}", semanaDias.Lunes.ToString, semanaDias.Lunes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Martes.ToString, semanaDias.Martes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Miercoles.ToString, semanaDias.Miercoles.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Jueves.ToString, semanaDias.Jueves.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Viernes.ToString, semanaDias.Viernes.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Sabado.ToString, semanaDias.Sabado.GetHashCode)
        Console.WriteLine("{0} - valor: {1}", semanaDias.Domingo.ToString, semanaDias.Domingo.GetHashCode)

    End Sub
End Module
