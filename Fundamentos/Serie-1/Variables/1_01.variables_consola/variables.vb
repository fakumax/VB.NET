Imports System

'1.1. Crear un módulo llamado “variables”
'* Declarar las variables necesarias e ingresar por teclado los siguientes datos nombre,
'apellido, fecha de nacimiento.
'* Luego mostrar por consola una cadena concatenada de la siguiente forma: “<apellido>,
'<nombre> nació el <fecha de nacimiento>”
Module variables
    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Dim fechaNacimiento As Date
        Console.Write("Ingrese un nombre : ")
        nombre = Console.ReadLine()
        Console.Write("Ingrese un apellido : ")
        apellido = Console.ReadLine()
        Console.Write("Ingrese una fecha de nacimiento : ")
        fechaNacimiento = Console.ReadLine()
        Console.WriteLine("{0},{1} nació el {2} ", apellido, nombre, fechaNacimiento)
    End Sub
End Module
