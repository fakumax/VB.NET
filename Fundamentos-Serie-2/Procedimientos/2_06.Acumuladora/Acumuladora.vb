Imports System
'2.6. Crear un proyecto y un módulo llamado “Acumuladora” que implemente una subrutina que
'recibe un valor Decimal y lo va acumulando. Invocar por lo menos tres veces la subrutina
'desde el main y mostrar luego de cada llamada mostrar el valor acumulado.
Module Acumuladora
    Sub Main(args As String())
        Dim valor As Integer = 8
        acumula(valor)
        Console.WriteLine("El valor es : " & valor)
        acumula(valor)
        Console.WriteLine("El valor es : " & valor)
        acumula(valor)
        Console.WriteLine("El valor es : " & valor)
    End Sub
    Sub acumula(ByRef valor As Integer)
        valor += valor
    End Sub
End Module
