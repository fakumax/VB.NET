Imports System
'1.2. Crear un proyecto llamado “CotizaciónTerreno” qué calcule e imprima el costo un terreno
'cuadrado o rectangular, teniendo como datos el ancho y la longitud en metros y el costo del
'metro cuadrado.
Module CotizacionTerreno
    Sub Main(args As String())
        Console.WriteLine("Cotización de terreno")
        Console.WriteLine(calculaprecio(tipoterreno()))

    End Sub
    Function tipoterreno() As UShort
        Dim opcion As Short
        Do
            Console.WriteLine("Ingrese el tipo de terreno : " & vbCrLf &
                         "1 - Cuadrado" & vbCrLf &
                         "2 - Rectangular" & vbCrLf)
            opcion = Console.ReadLine
        Loop While opcion < 1 Or opcion > 2
        Return opcion
    End Function

    Function calculaprecio(tipoterreno As UShort) As String
        Console.Clear()
        Dim ancho, longitud, costocuadrado As Single
        Console.Write("Ingrese el ancho del terreno en metros : ")
        ancho = Console.ReadLine
        Console.Write("Ingrese la longitud del terreno en metros : ")
        longitud = Console.ReadLine
        Console.Write("Ingrese el costo de metro cuadrado : ")
        costocuadrado = Console.ReadLine
        Select Case tipoterreno
            Case 1
                Return "El costo del terreno es : $" & ancho * 4 * costocuadrado
            Case 2
                Return "El costo del terreno es : $" & ancho * longitud * costocuadrado
            Case Else
                Return "Tipo de terreno erroneo"
        End Select
    End Function
End Module
