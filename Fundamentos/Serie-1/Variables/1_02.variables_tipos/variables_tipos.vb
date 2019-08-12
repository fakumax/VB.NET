Imports System

'   1.2. Crear un proyecto y un módulo llamado “variables_tipos”. Declarar variables de la lista adjunta
'como locales(DIM) utilizando tipos de datos adecuados para cada información y usando
'nombres que respeten las reglas de sintaxis. Asignarles valores programáticamente y luego
'mostrar por consola la leyenda que representa el dato seguido del valor del dato.
'* Nombre de una persona
'* Número de documento
'* Lugar de nacimiento
'* Fecha de nacimiento
'* Altura corporal (cms)
'* Si es argentino
'* Temperatura ambiente
'* Nombre calle
'* Altura de calle
'* Distancia en kms entre dos ciudades cualquiera
'* Profundidad del mar en metros
'* Cantidad de habitantes del territorio nacional.
'* Peso de un producto de un supermercado en kilogramos
'* Monto de un artículo de un supermercado.
Module variables_tipos

    Sub Main(args As String())

        Dim nombre As String = "carlos"
        Dim dni As UInteger = 40142132
        Dim lugarNacimiento As String = "Bariloche"
        Dim fechaNacimiento As Date = "21/01/2019"
        Dim altura As Byte = 193
        Dim esArgentino As Boolean = "True"
        Dim temperatura As SByte = 32
        Dim calle As String = "Tripoli"
        Dim altura_calle As UInteger = 3141
        Dim distanciaKms As UInteger = 123
        Dim profundidadMar As UShort = 3214
        Dim pesoKg As UShort = 123
        Dim montoArticulo As Decimal = 23.3

        Console.WriteLine("El nombre en STRING es :" & nombre)
        Console.WriteLine("El DNI en UInteger es :" & dni)
        Console.WriteLine("El Lugar de Nacimiento en STRING es :" & lugarNacimiento)
        Console.WriteLine("La Fecha de Nacimiento en DATE es :" & fechaNacimiento)
        Console.WriteLine("La altura en Byte es :" & altura)
        Console.WriteLine("La Nacionalidad es BOOLEAN es :" & esArgentino)
        Console.WriteLine("La temperatura en SByte es :" & temperatura)
        Console.WriteLine("La calle en STRING es :" & calle)
        Console.WriteLine("La Altura de la calle en UINTEGER es :" & altura_calle)
        Console.WriteLine("La Distancia en UINTEGER es :" & distanciaKms)
        Console.WriteLine("La Profundidad es USHORT es :" & profundidadMar)
        Console.WriteLine("El Peso en USHORT es :" & pesoKg)
        Console.WriteLine("El Monto en DECIMAL es :" & montoArticulo)


    End Sub
End Module