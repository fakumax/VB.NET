Imports System
'3.14. Crear un proyecto y un módulo “Descuento” para ingresar repetitivamente dos
'valores relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es
'entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es
'del 10% y si es 251 o más el descuento es del 20%. Informar por cada producto subtotal
'(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y el total
'(subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a cero, informar el
'total de pesos descontados y el total a cobrar.
Module Descuento
    Sub Main(args As String())
        Dim totalGral As Single
        Dim descuento As Single
        productos(totalGral, descuento)
        Console.WriteLine(vbNewLine & "Suma TOTAL productos : " & totalGral)
        Console.WriteLine("Descuento Final: " & vbTab & descuento)
        Console.WriteLine("A PAGAR : " & vbTab & vbTab & totalGral - descuento)
    End Sub
    Sub productos(ByRef totalGral As Single, ByRef descuento As Single)
        Dim cantidad As UShort
        Dim precio As Single
        Do While True
            Console.Write("Ingrese la cantidad : ")
            cantidad = Console.ReadLine
            If cantidad = 0 Then
                Exit Do
            Else
                Console.Write("Ingrese el precio : ")
                precio = Console.ReadLine
                descuento += impresion(cantidad, precio, totalGral)
            End If
        Loop
    End Sub
    Function impresion(cantidad As UShort, precio As Single, ByRef totalGral As Single) As Single
        Dim total As Decimal = cantidad * precio
        totalGral += total
        Dim porciento As Single = porcentaje(cantidad)
        Console.WriteLine(vbTab & "VENTA")
        Console.WriteLine("Subtotal :  $" & total)
        Console.WriteLine("Descuento : '{0}'%", porciento)
        Console.WriteLine("A descontar : ${0} ", total * porciento / 100)
        Console.WriteLine("TOTAL : ${0}", total - (total * (porciento / 100)))
        Return total * porciento / 100
    End Function
    Function porcentaje(cantidad As UShort) As UShort
        Select Case cantidad
            Case <10
                Return 0
            Case <= 50
                Return 5
            Case <= 250
                Return 10
            Case Else
                Return 20
        End Select
    End Function
End Module




