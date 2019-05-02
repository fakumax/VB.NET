Module Cadenas1
    '1.14. Crear un proyecto y un módulo llamado “Cadenas1” que ingrese una palabra por teclado
    'e informar : 
    '* En que posición aparece la primer “a”.
    '* En que posición aparece la primer “o”.
    '* La palabra invertida.
    Sub Main()
        Dim cadenaIngresada As String
        Console.Write("Ingrese una cadena : ")
        cadenaIngresada = Console.ReadLine
        Console.WriteLine("La primer 'a' está en la posición : " & InStr(cadenaIngresada, "a"))
        Console.WriteLine("La primer 'o' está en la posición : " & InStr(cadenaIngresada, "o"))
        Console.WriteLine("La palabra inversa es : " & StrReverse(cadenaIngresada))
        Console.ReadKey()
    End Sub

End Module
