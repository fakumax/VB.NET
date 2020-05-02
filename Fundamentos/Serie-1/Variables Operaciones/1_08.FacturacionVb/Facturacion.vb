Imports System
'1.8. Crea un proyecto llamado “Facturación” en el cual se ingresa el nombre de un artículo y su
'costo.La utilidad es del 150 por ciento y el impuesto es el 21 por ciento. Calcular e imprimir
'artículo, utilidad, impuesto y precio de venta.
Module Facturacion
    Sub Main(args As String())
        Dim articulo As String = nombreArticulo()
        Dim precio As Single = costoArticulo()
        Dim precioUtilidad As Single = precio * 150 / 100
        Dim iva As Single = (precio + precioUtilidad) * 0.21
        Console.WriteLine("Artículo : {0}" & vbCrLf &
                          "Precio: {1}" & vbCrLf &
                          "Utilidad: {2}" & vbCrLf &
                          "Impuesto : {3}" & vbCrLf &
                          "PRECIO VENTA: {4}", articulo, precio, precioUtilidad, iva, precio + precioUtilidad + iva)
    End Sub

    Function nombreArticulo() As String
        Console.Write("Ingrese nombre de un producto : ")
        Return Console.ReadLine
    End Function

    Function costoArticulo() As Single
        Console.Write("Ingrese costo del articulo : ")
        Return Console.ReadLine
    End Function
End Module
