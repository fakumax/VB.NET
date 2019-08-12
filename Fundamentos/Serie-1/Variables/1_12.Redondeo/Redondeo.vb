Imports System
Imports System.Math
'1.12. Crear un proyecto y un módulo llamado “Redondeo” que ingresar un número real por
'teclado y mostrar su valor aproximado por exceso, su valor aproximado por defecto y su valor
'redondeado.
Module Redondeo
    Sub Main(args As String())
        Dim valor As Decimal
        Console.Write("Ingrese un valor : ")
        valor = Console.ReadLine
        Console.WriteLine("Valor Aproximado por exceso : " & Ceiling(valor))
        Console.WriteLine("Valor Aproximado por defecto : " & Floor(valor))
        Console.WriteLine("Valor Aproximado Redondeado : " & Round(valor))
    End Sub
End Module
