Imports System
'3.4. Crear un proyecto y un módulo “Venta” para resolver con IF: ingresar dos valores
'relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'es 251 o más el descuento es del 20%. Informar subtotal (cantidad por precio unitario),
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto
'descontado).
Module Venta
    Sub Main(args As String())
        Dim cantidad As UShort
        Dim precio As Single
        Console.Write("Ingrese la cantidad : ")
        cantidad = Console.ReadLine
        Console.Write("Ingrese el precio : ")
        precio = Console.ReadLine
        impresion(cantidad, precio)
    End Sub
    Sub impresion(cantidad As UShort, precio As Single)
        Dim total As Decimal = cantidad * precio
        Dim porciento As Single = porcentaje(cantidad)
        Console.WriteLine(vbTab & "VENTA")
        Console.WriteLine("Subtotal :  $" & total)
        Console.WriteLine("Descuento : '{0}'%", porciento)
        Console.WriteLine("A descontar : ${0} ", total * (porciento / 100))
        Console.WriteLine("TOTAL : ${0}", total - (total * (porciento / 100)))

    End Sub
    Function porcentaje(cantidad As UShort) As UShort
        If cantidad < 10 Then
            Return 0
        ElseIf cantidad <= 50 Then
            Return 5
        ElseIf cantidad <= 250 Then
            Return 10
        Else
            Return 20
        End If
    End Function
End Module
