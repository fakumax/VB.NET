Imports System
'4.3. Crear un proyecto llamado “Notas” y un módulo que utilice arrays para almacenar las notas (entre 0 y 10)
'de una serie de alumnos.
'- Primero paso es ingresar la cantidad de alumnos y la cantidad de notas que tiene
'cada uno teniendo en cuenta un máximo aceptado de 40 alumnos y 4 notas por alumno. 
'- Iterativamente ingresar el nombre de un alumno y sus notas. Validar que tenga un nombre de al menos 3 caracteres,
'que no sea repetido y el rango de la nota correcto. 
'- Al completar la iteración informar por cada alumno el nombre,
'el promedio, si aprobó o desaprobó teniendo en cuenta que aprueba con 6 o más. 
'- También informar quien es el mejor alumno (puede haber más de uno). "
'- Implementar procedimientos para resolver las siguientes tareas : 
'* Para validar el nombre 
'* Para validar la inexistencia de un nombre igual 
'* Para validar el rango de la nota 
'* Para determinar el promedio 
'* Para imprimir si el alumno aprobó o no 
'* Para determinar la lista de mejores alumnos
Module Notas
    Sub Main(args As String())
        Dim cantAlumnos As UShort = validaAlumnos()
        Dim cantNotas As UShort = validaNotas()
        Dim alumnos(cantAlumnos, cantNotas) As Integer
        Console.WriteLine("El sistema va a tener : " & vbCrLf &
                          "ALUMNOS: {0}" & vbCrLf &
                          "NOTAS: {1}" & vbCrLf, cantAlumnos, cantNotas)
        testing(cantAlumnos, cantNotas)

    End Sub

    Function validaAlumnos() As UShort
        Dim cantAlumnos As UShort
        Do
            Console.Write("Ingrese la cantidad de alumnos(max 40) : ")
            cantAlumnos = Console.ReadLine
        Loop Until cantAlumnos <= 40
        Return cantAlumnos
    End Function
    Function validaNotas() As UShort
        Dim cantNotas As UShort
        Do
            Console.Write("Ingrese la cantidad de notas(max 4) : ")
            cantNotas = Console.ReadLine
        Loop Until cantNotas <= 4
        Return cantNotas
    End Function
    Sub validaNotas(ByRef notas As UShort)
        Do
            Console.Write("Ingrese la notas(0-10) : ")
            notas = Console.ReadLine
        Loop Until notas <= 10
    End Sub
    Sub validaNombre(ByRef nombre As String)
        Do
            Console.WriteLine("Ingrese el NOMBRE del alumno(min 3 letras) : ")
            nombre = Console.ReadLine
        Loop Until nombre.Length >= 3

    End Sub
    Sub testing(calumnos As UShort, cnotas As UShort)

        Dim nombre As String = ""
        Dim notas As UShort = 0
        Dim alumnos(calumnos, cnotas) As String
        For a = 0 To calumnos - 1
            validaNombre(nombre)
            alumnos(a, 0) = nombre
            For n = 0 To cnotas - 1
                validaNotas(notas)
                alumnos(a, n) = notas
            Next
        Next

        For Each alumno In alumnos
            Console.WriteLine(alumno)
        Next

    End Sub
End Module
