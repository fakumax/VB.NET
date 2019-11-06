Imports System
'4.2. Crear un proyecto llamado �Ventas� y un m�dulo que cuenta con tres vectores cargados
'program�ticamente referente a productos: el primero tiene el c�digo, el segundo el nombre y
'el tercero el precio unitario.
'* Repetitivamente se ingresa un c�digo de producto y el programa muestra su descripci�n
'y precio, si el c�digo no existe mostrar un mensaje de Error.
'* luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
'de venta por ese producto y el total general (acumulado los productos anteriores).
'* Se repite el proceso hasta que el c�digo sea cero.
Module Ventas
    Sub Main(args As String())
        Dim codigo = New UShort() {1, 2, 3}
        Dim nombre = New String() {"papa", "manzana", "uva"}
        Dim precio = New Single() {2.6, 1.2, 4.5}
        Dim total, subtotal As Decimal
        Dim buscar As UShort = ingresoValor()
        Dim cantidad, indice As UShort
        Do Until buscar = 0

            If existe(buscar, codigo, indice) Then
                'Console.WriteLine(indice)
                Console.WriteLine("PRODUCTO : " & nombre(indice))
                Console.WriteLine("PRECIO : " & precio(indice))
                Console.Write(vbNewLine & "Cantidad del producto : ")
                cantidad = Console.ReadLine
                subtotal = precio(indice) * cantidad
                Console.WriteLine("-- SUBTOTAL -- : " & subtotal)
                total += subtotal
            Else
                Console.WriteLine("Reingrese valor... ")
            End If
            buscar = ingresoValor()
        Loop
        Console.WriteLine(vbNewLine & "El TOTAL es : " & total)

    End Sub

    Function existe(buscar As UShort, codigo() As UShort, ByRef indice As UShort) As Boolean

        For x = 0 To codigo.Length - 1
            If codigo(x) = buscar Then
                ' reduzco el indice en -1 para que no explote
                indice = buscar - 1
                Return True
            End If
        Next
        Return False

    End Function

    Function ingresoValor() As UShort
        Console.Write("Ingrese c�digo del producto: ")
        Return Console.ReadLine
    End Function
End Module
