Imports System
'1.1. Crear un proyecto llamado “Costos” qué calcula imprima el costo de producción de un
'artículo, teniendo como datos la descripción y el número de unidades producidas. El costo se
'calcula multiplicando el número de unidades producidas por un factor de costo de materiales
'de 3. 5 y sumándole el producto un costo fijo de 10.700. Informar todos los datos ingresados
'junto a los resultados calculados.
Module Costos
    Sub Main(args As String())
        Dim articulo As String
        Dim unidades As UInt32
        Console.Write("Ingrese descripción del artículo : ")
        articulo = Console.ReadLine
        Console.Write("Ingrese el número de unidades producidas : ")
        unidades = Console.ReadLine
        Console.WriteLine("El artículo es : {0} " & vbCrLf &
                          "Las unidades producidas son : {1} " & vbCrLf &
                          "Costo Fijo : 10.700" & vbCrLf &
                          "El resultado de costos es : {2} ", articulo, unidades, costo(unidades))
    End Sub
    Function costo(unidades) As Single
        Return unidades * 3.5 + 10700
    End Function

End Module
