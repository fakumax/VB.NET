Module Refrase
    '    1.15. Crear un proyecto y un módulo llamado “Refrase” que ingrese por teclado dos palabras,
    'la primera palabra será reemplazada por la segunda dentro de la frase: “Aunque la cadena sea
    'de oro, sirve para lo mismo.”. La palabra que es reemplazada es reconocida dentro de la frase
    'porque esta precedida de un espacio y seguida de un espacio, de una coma o de un punto.
    'Mostrar el resultado.
    Sub Main()
        Dim primerPalabra As String
        Dim segundaPalabra As String
        Dim cadena As String
        Console.Write("Ingrese una palabra : ")
        primerPalabra = Console.ReadLine
        Console.Write("Ingrese otra palabra : ")
        segundaPalabra = Console.ReadLine
        cadena = "Aunque la cadena sea de oro, sirve para lo mismo."
        Console.WriteLine(cadena)
        cadena = Replace(cadena, primerPalabra, segundaPalabra)
        Console.WriteLine(cadena)
        Console.ReadKey()
    End Sub

End Module
