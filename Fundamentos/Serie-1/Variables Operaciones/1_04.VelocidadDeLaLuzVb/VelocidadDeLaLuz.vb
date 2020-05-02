Imports System
'1.4. Crear un proyecto llamado “VelocidadDeLaLuz”. Teniendo en cuenta que la velocidad de la
'luz 300.0 kilómetros por segundo, elaborar un algoritmo que lea un tiempo en segundos
'imprima la distancia que recorre la luz en dicho tiempo.
Module VelocidadDeLaLuz
    Sub Main(args As String())
        Dim segundos As UInt32 = ingresoSegundos()
        Console.WriteLine("La distancia recorrida en {0} segundos " &
                          "de la luz es : {1} km/s", segundos, calculoVelocidadLuz(segundos))

    End Sub

    Function ingresoSegundos() As UInt32
        Console.Write("Ingrese una cantidad de segundos : ")
        Return Console.ReadLine()
    End Function

    Function calculoVelocidadLuz(segundos As UInt32)
        Return segundos * 300
    End Function
End Module
